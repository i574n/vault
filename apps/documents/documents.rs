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
        use fable_library_rust::NativeArray_::count;
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
        use fable_library_rust::Range_::rangeNumeric;
        use fable_library_rust::Seq_::delay;
        use fable_library_rust::Seq_::map as map_1;
        use fable_library_rust::Seq_::ofList;
        use fable_library_rust::Seq_::toArray as toArray_1;
        use fable_library_rust::String_::contains;
        use fable_library_rust::String_::endsWith;
        use fable_library_rust::String_::getCharAt;
        use fable_library_rust::String_::getSlice;
        use fable_library_rust::String_::join;
        use fable_library_rust::String_::length;
        use fable_library_rust::String_::ofChar;
        use fable_library_rust::String_::padRight;
        use fable_library_rust::String_::replace;
        use fable_library_rust::String_::split;
        use fable_library_rust::String_::sprintf;
        use fable_library_rust::String_::string;
        use fable_library_rust::String_::toLower;
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
        #[derive(Clone, Debug, Default, PartialEq, PartialOrd, Hash, Eq)]
        pub struct Mut4 {
            pub l0: MutCell<i32>,
            pub l1: MutCell<i32>,
            pub l2: MutCell<Array<string>>,
        }
        impl core::fmt::Display for Documents::Mut4 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug, Default, PartialEq, PartialOrd, Hash, Eq)]
        pub struct Mut5 {
            pub l0: MutCell<i32>,
        }
        impl core::fmt::Display for Documents::Mut5 {
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
        pub enum US9 {
            US9_0,
            US9_1,
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
        #[derive(Clone, Copy, Debug, PartialEq, PartialOrd, Hash, Eq)]
        pub enum US8 {
            US8_0,
            US8_1(Documents::US9),
            US8_2,
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
            pub fn get_IsUS8_2(this_: &MutCell<Documents::US8>, unitArg: ()) -> bool {
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
        pub enum US10 {
            US10_0,
            US10_1(char),
            US10_2(u8),
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
        #[derive(Clone, Debug)]
        pub enum US11 {
            US11_0(std::sync::Arc<std::sync::Mutex<Option<std::process::Child>>>),
            US11_1(std::string::String),
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
        #[derive(Clone, Debug)]
        pub enum US12 {
            US12_0(
                std::sync::Arc<
                    std::sync::Mutex<
                        std::sync::Arc<std::sync::mpsc::Receiver<std::string::String>>,
                    >,
                >,
            ),
            US12_1,
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
        }
        impl core::fmt::Display for Documents::US12 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum US13 {
            US13_0(std::string::String),
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
            US14_0(std::process::Output),
            US14_1(std::string::String),
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
            US15_0(Func1<(bool, string, i32), Arc<Async<()>>>),
            US15_1,
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
        #[derive(Clone, Copy, Debug, PartialEq, PartialOrd, Hash, Eq)]
        pub enum US16 {
            US16_0(CancellationToken),
            US16_1,
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
        #[derive(Clone, Debug, PartialEq, PartialOrd, Hash, Eq)]
        pub enum US17 {
            US17_0(Result<string, LrcPtr<(string, string)>>),
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
            fn v2() -> (
                LrcPtr<Documents::Mut0>,
                LrcPtr<Documents::Mut1>,
                LrcPtr<Documents::Mut2>,
                Option<i64>,
                LrcPtr<Documents::Mut3>,
            ) {
                Documents::closure2((), ())
            }
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
        pub fn method16() -> string {
            string("^\\\\\\\\\\?\\\\")
        }
        pub fn method17(v0_1: string) -> string {
            v0_1
        }
        pub fn method18() -> string {
            string("")
        }
        pub fn method19(v0_1: i32, v1_1: LrcPtr<Documents::Mut4>) -> bool {
            v1_1.l0.get().clone() < v0_1
        }
        pub fn method20(v0_1: i32, v1_1: LrcPtr<Documents::Mut5>) -> bool {
            v1_1.l0.get().clone() < v0_1
        }
        pub fn method21(v0_1: string) -> string {
            v0_1
        }
        pub fn method22(v0_1: string) -> string {
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
        pub fn method26(v0_1: async_walkdir::DirEntry) -> async_walkdir::DirEntry {
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
        pub fn method27() -> Func1<std::io::Error, std::string::String> {
            Func1::new(move |v: std::io::Error| Documents::closure13((), v))
        }
        pub fn closure14(unitVar: (), v0_1: std::fs::FileType) -> Documents::US5 {
            Documents::US5::US5_0(v0_1)
        }
        pub fn closure15(unitVar: (), v0_1: std::string::String) -> Documents::US5 {
            Documents::US5::US5_1(v0_1)
        }
        pub fn method28(v0_1: std::fs::FileType) -> std::fs::FileType {
            v0_1
        }
        pub fn method29(v0_1: Documents::US4) -> Documents::US4 {
            v0_1
        }
        pub fn method25(
            v0_1: async_walkdir::DirEntry,
        ) -> std::pin::Pin<Box<dyn std::future::Future<Output = Documents::US4> + Send>> {
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
                    let v12: Documents::US5 = match &v9 {
                        Err(v9_1_0) => Documents::closure15((), v9_1_0.clone()),
                        Ok(v9_0_0) => Documents::closure14((), v9_0_0.clone()),
                    };
                    let v74: Documents::US4 =
                        Documents::method29(if let Documents::US5::US5_0(v12_0_0) = &v12 {
                            let v14: std::fs::FileType = Documents::method28(match &v12 {
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
                        Box<dyn std::future::Future<Output = Documents::US4> + Send>,
                    > = Documents::method25(v0_1);
                    let v4: Documents::US4 = v2.await;
                    let v14: async_walkdir::Filtering = Documents::method30(match &v4 {
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
            Documents::method24(v0_1)
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
            let v1_1 = Documents::method27();
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
        pub fn method31() -> Func1<Result<async_walkdir::DirEntry, std::io::Error>, Option<string>>
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
        pub fn method32() -> (string, string) {
            (string(""), string(""))
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
        pub fn method33() -> Func1<char, Func1<LrcPtr<Documents::UH0>, LrcPtr<Documents::UH0>>> {
            Func1::new(move |v: char| Documents::closure24((), v))
        }
        pub fn method34(
            v0_1: string,
            v1_1: string,
            v2: LrcPtr<Documents::UH0>,
            v3: Documents::US8,
        ) -> (string, string) {
            let v0_1: MutCell<string> = MutCell::new(v0_1.clone());
            let v1_1: MutCell<string> = MutCell::new(v1_1.clone());
            let v2: MutCell<LrcPtr<Documents::UH0>> = MutCell::new(v2.clone());
            let v3: MutCell<Documents::US8> = MutCell::new(v3.clone());
            '_method34: loop {
                break '_method34 (if let Documents::UH0::UH0_1(v2_1_0, v2_1_1) =
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
                            let v3_temp: Documents::US8 =
                                Documents::US8::US8_1(Documents::US9::US9_0);
                            v0_1.set(v0_1_temp);
                            v1_1.set(v1_1_temp);
                            v2.set(v2_temp);
                            v3.set(v3_temp);
                            continue '_method34;
                        } else {
                            match &v3.get().clone() {
                                Documents::US8::US8_1(v3_1_0) => {
                                    if let Documents::US9::US9_0 = v3_1_0 {
                                        let v0_1_temp: string = v0_1.get().clone();
                                        let v1_1_temp: string = v1_1.get().clone();
                                        let v2_temp: LrcPtr<Documents::UH0> = v5.clone();
                                        let v3_temp: Documents::US8 =
                                            Documents::US8::US8_1(Documents::US9::US9_1);
                                        v0_1.set(v0_1_temp);
                                        v1_1.set(v1_1_temp);
                                        v2.set(v2_temp);
                                        v3.set(v3_temp);
                                        continue '_method34;
                                    } else {
                                        if ' ' == v4 {
                                            let v0_1_temp: string = v0_1.get().clone();
                                            let v1_1_temp: string = v1_1.get().clone();
                                            let v2_temp: LrcPtr<Documents::UH0> = v5.clone();
                                            let v3_temp: Documents::US8 = Documents::US8::US8_2;
                                            v0_1.set(v0_1_temp);
                                            v1_1.set(v1_1_temp);
                                            v2.set(v2_temp);
                                            v3.set(v3_temp);
                                            continue '_method34;
                                        } else {
                                            let v0_1_temp: string = v0_1.get().clone();
                                            let v1_1_temp: string =
                                                sprintf!("{}{}", v1_1.get().clone(), v4);
                                            let v2_temp: LrcPtr<Documents::UH0> = v5.clone();
                                            let v3_temp: Documents::US8 = v3.get().clone();
                                            v0_1.set(v0_1_temp);
                                            v1_1.set(v1_1_temp);
                                            v2.set(v2_temp);
                                            v3.set(v3_temp);
                                            continue '_method34;
                                        }
                                    }
                                }
                                Documents::US8::US8_0 => {
                                    if ' ' == v4 {
                                        let v0_1_temp: string = v0_1.get().clone();
                                        let v1_1_temp: string = v1_1.get().clone();
                                        let v2_temp: LrcPtr<Documents::UH0> = v5.clone();
                                        let v3_temp: Documents::US8 = Documents::US8::US8_2;
                                        v0_1.set(v0_1_temp);
                                        v1_1.set(v1_1_temp);
                                        v2.set(v2_temp);
                                        v3.set(v3_temp);
                                        continue '_method34;
                                    } else {
                                        let v0_1_temp: string = v0_1.get().clone();
                                        let v1_1_temp: string =
                                            sprintf!("{}{}", v1_1.get().clone(), v4);
                                        let v2_temp: LrcPtr<Documents::UH0> = v5.clone();
                                        let v3_temp: Documents::US8 = v3.get().clone();
                                        v0_1.set(v0_1_temp);
                                        v1_1.set(v1_1_temp);
                                        v2.set(v2_temp);
                                        v3.set(v3_temp);
                                        continue '_method34;
                                    }
                                }
                                _ => {
                                    let v0_1_temp: string =
                                        sprintf!("{}{}", v0_1.get().clone(), v4);
                                    let v1_1_temp: string = v1_1.get().clone();
                                    let v2_temp: LrcPtr<Documents::UH0> = v5.clone();
                                    let v3_temp: Documents::US8 = Documents::US8::US8_2;
                                    v0_1.set(v0_1_temp);
                                    v1_1.set(v1_1_temp);
                                    v2.set(v2_temp);
                                    v3.set(v3_temp);
                                    continue '_method34;
                                }
                            }
                        }
                    } else {
                        if '\'' == v4 {
                            if v1_1.get().clone() == string("") {
                                let v0_1_temp: string = v0_1.get().clone();
                                let v1_1_temp: string = v1_1.get().clone();
                                let v2_temp: LrcPtr<Documents::UH0> = v5.clone();
                                let v3_temp: Documents::US8 =
                                    Documents::US8::US8_1(Documents::US9::US9_0);
                                v0_1.set(v0_1_temp);
                                v1_1.set(v1_1_temp);
                                v2.set(v2_temp);
                                v3.set(v3_temp);
                                continue '_method34;
                            } else {
                                match &v3.get().clone() {
                                    Documents::US8::US8_1(v3_1_0) => {
                                        if let Documents::US9::US9_0 = v3_1_0 {
                                            let v0_1_temp: string = v0_1.get().clone();
                                            let v1_1_temp: string = v1_1.get().clone();
                                            let v2_temp: LrcPtr<Documents::UH0> = v5.clone();
                                            let v3_temp: Documents::US8 =
                                                Documents::US8::US8_1(Documents::US9::US9_1);
                                            v0_1.set(v0_1_temp);
                                            v1_1.set(v1_1_temp);
                                            v2.set(v2_temp);
                                            v3.set(v3_temp);
                                            continue '_method34;
                                        } else {
                                            if ' ' == v4 {
                                                let v0_1_temp: string = v0_1.get().clone();
                                                let v1_1_temp: string = v1_1.get().clone();
                                                let v2_temp: LrcPtr<Documents::UH0> = v5.clone();
                                                let v3_temp: Documents::US8 = Documents::US8::US8_2;
                                                v0_1.set(v0_1_temp);
                                                v1_1.set(v1_1_temp);
                                                v2.set(v2_temp);
                                                v3.set(v3_temp);
                                                continue '_method34;
                                            } else {
                                                let v0_1_temp: string = v0_1.get().clone();
                                                let v1_1_temp: string =
                                                    sprintf!("{}{}", v1_1.get().clone(), v4);
                                                let v2_temp: LrcPtr<Documents::UH0> = v5.clone();
                                                let v3_temp: Documents::US8 = v3.get().clone();
                                                v0_1.set(v0_1_temp);
                                                v1_1.set(v1_1_temp);
                                                v2.set(v2_temp);
                                                v3.set(v3_temp);
                                                continue '_method34;
                                            }
                                        }
                                    }
                                    Documents::US8::US8_0 => {
                                        if ' ' == v4 {
                                            let v0_1_temp: string = v0_1.get().clone();
                                            let v1_1_temp: string = v1_1.get().clone();
                                            let v2_temp: LrcPtr<Documents::UH0> = v5.clone();
                                            let v3_temp: Documents::US8 = Documents::US8::US8_2;
                                            v0_1.set(v0_1_temp);
                                            v1_1.set(v1_1_temp);
                                            v2.set(v2_temp);
                                            v3.set(v3_temp);
                                            continue '_method34;
                                        } else {
                                            let v0_1_temp: string = v0_1.get().clone();
                                            let v1_1_temp: string =
                                                sprintf!("{}{}", v1_1.get().clone(), v4);
                                            let v2_temp: LrcPtr<Documents::UH0> = v5.clone();
                                            let v3_temp: Documents::US8 = v3.get().clone();
                                            v0_1.set(v0_1_temp);
                                            v1_1.set(v1_1_temp);
                                            v2.set(v2_temp);
                                            v3.set(v3_temp);
                                            continue '_method34;
                                        }
                                    }
                                    _ => {
                                        let v0_1_temp: string =
                                            sprintf!("{}{}", v0_1.get().clone(), v4);
                                        let v1_1_temp: string = v1_1.get().clone();
                                        let v2_temp: LrcPtr<Documents::UH0> = v5.clone();
                                        let v3_temp: Documents::US8 = Documents::US8::US8_2;
                                        v0_1.set(v0_1_temp);
                                        v1_1.set(v1_1_temp);
                                        v2.set(v2_temp);
                                        v3.set(v3_temp);
                                        continue '_method34;
                                    }
                                }
                            }
                        } else {
                            match &v3.get().clone() {
                                Documents::US8::US8_1(v3_1_0) => {
                                    if let Documents::US9::US9_0 = v3_1_0 {
                                        if ' ' == v4 {
                                            let v0_1_temp: string = v0_1.get().clone();
                                            let v1_1_temp: string =
                                                sprintf!("{} ", v1_1.get().clone());
                                            let v2_temp: LrcPtr<Documents::UH0> = v5.clone();
                                            let v3_temp: Documents::US8 =
                                                Documents::US8::US8_1(Documents::US9::US9_0);
                                            v0_1.set(v0_1_temp);
                                            v1_1.set(v1_1_temp);
                                            v2.set(v2_temp);
                                            v3.set(v3_temp);
                                            continue '_method34;
                                        } else {
                                            let v0_1_temp: string = v0_1.get().clone();
                                            let v1_1_temp: string =
                                                sprintf!("{}{}", v1_1.get().clone(), v4);
                                            let v2_temp: LrcPtr<Documents::UH0> = v5.clone();
                                            let v3_temp: Documents::US8 = v3.get().clone();
                                            v0_1.set(v0_1_temp);
                                            v1_1.set(v1_1_temp);
                                            v2.set(v2_temp);
                                            v3.set(v3_temp);
                                            continue '_method34;
                                        }
                                    } else {
                                        if ' ' == v4 {
                                            let v0_1_temp: string = v0_1.get().clone();
                                            let v1_1_temp: string = v1_1.get().clone();
                                            let v2_temp: LrcPtr<Documents::UH0> = v5.clone();
                                            let v3_temp: Documents::US8 = Documents::US8::US8_2;
                                            v0_1.set(v0_1_temp);
                                            v1_1.set(v1_1_temp);
                                            v2.set(v2_temp);
                                            v3.set(v3_temp);
                                            continue '_method34;
                                        } else {
                                            let v0_1_temp: string = v0_1.get().clone();
                                            let v1_1_temp: string =
                                                sprintf!("{}{}", v1_1.get().clone(), v4);
                                            let v2_temp: LrcPtr<Documents::UH0> = v5.clone();
                                            let v3_temp: Documents::US8 = v3.get().clone();
                                            v0_1.set(v0_1_temp);
                                            v1_1.set(v1_1_temp);
                                            v2.set(v2_temp);
                                            v3.set(v3_temp);
                                            continue '_method34;
                                        }
                                    }
                                }
                                Documents::US8::US8_0 => {
                                    if ' ' == v4 {
                                        let v0_1_temp: string = v0_1.get().clone();
                                        let v1_1_temp: string = v1_1.get().clone();
                                        let v2_temp: LrcPtr<Documents::UH0> = v5.clone();
                                        let v3_temp: Documents::US8 = Documents::US8::US8_2;
                                        v0_1.set(v0_1_temp);
                                        v1_1.set(v1_1_temp);
                                        v2.set(v2_temp);
                                        v3.set(v3_temp);
                                        continue '_method34;
                                    } else {
                                        let v0_1_temp: string = v0_1.get().clone();
                                        let v1_1_temp: string =
                                            sprintf!("{}{}", v1_1.get().clone(), v4);
                                        let v2_temp: LrcPtr<Documents::UH0> = v5;
                                        let v3_temp: Documents::US8 = v3.get().clone();
                                        v0_1.set(v0_1_temp);
                                        v1_1.set(v1_1_temp);
                                        v2.set(v2_temp);
                                        v3.set(v3_temp);
                                        continue '_method34;
                                    }
                                }
                                _ => {
                                    let v0_1_temp: string =
                                        sprintf!("{}{}", v0_1.get().clone(), v4);
                                    let v1_1_temp: string = v1_1.get().clone();
                                    let v2_temp: LrcPtr<Documents::UH0> = v5.clone();
                                    let v3_temp: Documents::US8 = Documents::US8::US8_2;
                                    v0_1.set(v0_1_temp);
                                    v1_1.set(v1_1_temp);
                                    v2.set(v2_temp);
                                    v3.set(v3_temp);
                                    continue '_method34;
                                }
                            }
                        }
                    }
                } else {
                    match &v3.get().clone() {
                        Documents::US8::US8_1(v3_1_0) => {
                            if let Documents::US9::US9_0 = v3_1_0 {
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
                        Documents::US8::US8_0 => (
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
        pub fn closure26(unitVar: (), v0_1: string) -> Documents::US7 {
            Documents::US7::US7_0(v0_1)
        }
        pub fn method36() -> Func1<string, Documents::US7> {
            Func1::new(move |v: string| Documents::closure26((), v))
        }
        pub fn method39(
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
                    Documents::method39(
                        match v0_1.as_ref() {
                            Documents::UH1::UH1_1(_, x) => x.clone(),
                            _ => unreachable!(),
                        },
                        v1_1.clone(),
                    ),
                )),
            }
        }
        pub fn method38(
            v0_1: string,
            v1_1: LrcPtr<Documents::UH1>,
            v2: LrcPtr<Documents::UH0>,
            v3: Documents::US10,
        ) -> (LrcPtr<Documents::UH1>, string) {
            let v0_1: MutCell<string> = MutCell::new(v0_1.clone());
            let v1_1: MutCell<LrcPtr<Documents::UH1>> = MutCell::new(v1_1.clone());
            let v2: MutCell<LrcPtr<Documents::UH0>> = MutCell::new(v2.clone());
            let v3: MutCell<Documents::US10> = MutCell::new(v3.clone());
            '_method38: loop {
                break '_method38 (match &v3.get().clone() {
                    Documents::US10::US10_1(v3_1_0) => {
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
                                    if v3.get().clone() == Documents::US10::US10_1('\\') {
                                        Documents::method37(
                                            v0_1.get().clone(),
                                            v1_1.get().clone(),
                                            v108.clone(),
                                            v3.get().clone(),
                                            Documents::US10::US10_0,
                                        )
                                    } else {
                                        if '\\' == v105 {
                                            if !(v3.get().clone() == Documents::US10::US10_2(0_u8))
                                            {
                                                Documents::method37(
                                                    sprintf!("{}\"", v0_1.get().clone()),
                                                    v1_1.get().clone(),
                                                    v108.clone(),
                                                    v3.get().clone(),
                                                    Documents::US10::US10_1('\"'),
                                                )
                                            } else {
                                                if v3.get().clone() == Documents::US10::US10_1('\\')
                                                {
                                                    Documents::method37(
                                                        sprintf!("{}\"", v0_1.get().clone()),
                                                        v1_1.get().clone(),
                                                        v108.clone(),
                                                        v3.get().clone(),
                                                        Documents::US10::US10_1('\"'),
                                                    )
                                                } else {
                                                    Documents::method37(
                                                        v0_1.get().clone(),
                                                        v1_1.get().clone(),
                                                        v108.clone(),
                                                        v3.get().clone(),
                                                        Documents::US10::US10_0,
                                                    )
                                                }
                                            }
                                        } else {
                                            if '\\' == v107 {
                                                Documents::method37(
                                                    v0_1.get().clone(),
                                                    v1_1.get().clone(),
                                                    v108.clone(),
                                                    v3.get().clone(),
                                                    Documents::US10::US10_2(1_u8),
                                                )
                                            } else {
                                                if v3.get().clone() == Documents::US10::US10_2(0_u8)
                                                {
                                                    Documents::method37(
                                                        sprintf!("{}\"", v0_1.get().clone()),
                                                        v1_1.get().clone(),
                                                        v108.clone(),
                                                        v3.get().clone(),
                                                        Documents::US10::US10_1('\"'),
                                                    )
                                                } else {
                                                    Documents::method37(
                                                        string(""),
                                                        Documents::method39(
                                                            v1_1.get().clone(),
                                                            LrcPtr::new(Documents::UH1::UH1_1(
                                                                v0_1.get().clone(),
                                                                LrcPtr::new(Documents::UH1::UH1_0),
                                                            )),
                                                        ),
                                                        v108.clone(),
                                                        v3.get().clone(),
                                                        Documents::US10::US10_0,
                                                    )
                                                }
                                            }
                                        }
                                    }
                                } else {
                                    if '\\' == v105 {
                                        if '\\' == v107 {
                                            Documents::method37(
                                                v0_1.get().clone(),
                                                v1_1.get().clone(),
                                                v108.clone(),
                                                v3.get().clone(),
                                                Documents::US10::US10_2(1_u8),
                                            )
                                        } else {
                                            if ' ' == v107 {
                                                let v0_1_temp: string =
                                                    sprintf!("{} ", v0_1.get().clone());
                                                let v1_1_temp: LrcPtr<Documents::UH1> =
                                                    v1_1.get().clone();
                                                let v2_temp: LrcPtr<Documents::UH0> = v108.clone();
                                                let v3_temp: Documents::US10 = v3.get().clone();
                                                v0_1.set(v0_1_temp);
                                                v1_1.set(v1_1_temp);
                                                v2.set(v2_temp);
                                                v3.set(v3_temp);
                                                continue '_method38;
                                            } else {
                                                let v0_1_temp: string =
                                                    sprintf!("{}{}", v0_1.get().clone(), v107);
                                                let v1_1_temp: LrcPtr<Documents::UH1> =
                                                    v1_1.get().clone();
                                                let v2_temp: LrcPtr<Documents::UH0> = v108.clone();
                                                let v3_temp: Documents::US10 = v3.get().clone();
                                                v0_1.set(v0_1_temp);
                                                v1_1.set(v1_1_temp);
                                                v2.set(v2_temp);
                                                v3.set(v3_temp);
                                                continue '_method38;
                                            }
                                        }
                                    } else {
                                        if '\\' == v107 {
                                            Documents::method37(
                                                v0_1.get().clone(),
                                                v1_1.get().clone(),
                                                v108,
                                                v3.get().clone(),
                                                Documents::US10::US10_2(1_u8),
                                            )
                                        } else {
                                            if ' ' == v107 {
                                                let v0_1_temp: string =
                                                    sprintf!("{} ", v0_1.get().clone());
                                                let v1_1_temp: LrcPtr<Documents::UH1> =
                                                    v1_1.get().clone();
                                                let v2_temp: LrcPtr<Documents::UH0> = v108.clone();
                                                let v3_temp: Documents::US10 = v3.get().clone();
                                                v0_1.set(v0_1_temp);
                                                v1_1.set(v1_1_temp);
                                                v2.set(v2_temp);
                                                v3.set(v3_temp);
                                                continue '_method38;
                                            } else {
                                                let v0_1_temp: string =
                                                    sprintf!("{}{}", v0_1.get().clone(), v107);
                                                let v1_1_temp: LrcPtr<Documents::UH1> =
                                                    v1_1.get().clone();
                                                let v2_temp: LrcPtr<Documents::UH0> = v108.clone();
                                                let v3_temp: Documents::US10 = v3.get().clone();
                                                v0_1.set(v0_1_temp);
                                                v1_1.set(v1_1_temp);
                                                v2.set(v2_temp);
                                                v3.set(v3_temp);
                                                continue '_method38;
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
                                            Documents::method39(
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
                                            Documents::method39(
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
                                        if !(v3.get().clone() == Documents::US10::US10_2(0_u8)) {
                                            Documents::method37(
                                                sprintf!("{}\"", v0_1.get().clone()),
                                                v1_1.get().clone(),
                                                v220.clone(),
                                                v3.get().clone(),
                                                Documents::US10::US10_1('\"'),
                                            )
                                        } else {
                                            if v3.get().clone() == Documents::US10::US10_1('\\') {
                                                Documents::method37(
                                                    sprintf!("{}\"", v0_1.get().clone()),
                                                    v1_1.get().clone(),
                                                    v220.clone(),
                                                    v3.get().clone(),
                                                    Documents::US10::US10_1('\"'),
                                                )
                                            } else {
                                                Documents::method37(
                                                    v0_1.get().clone(),
                                                    v1_1.get().clone(),
                                                    v220.clone(),
                                                    v3.get().clone(),
                                                    Documents::US10::US10_0,
                                                )
                                            }
                                        }
                                    } else {
                                        if '\\' == v219 {
                                            Documents::method37(
                                                v0_1.get().clone(),
                                                v1_1.get().clone(),
                                                v220.clone(),
                                                v3.get().clone(),
                                                Documents::US10::US10_2(1_u8),
                                            )
                                        } else {
                                            if ' ' == v219 {
                                                let v0_1_temp: string =
                                                    sprintf!("{} ", v0_1.get().clone());
                                                let v1_1_temp: LrcPtr<Documents::UH1> =
                                                    v1_1.get().clone();
                                                let v2_temp: LrcPtr<Documents::UH0> = v220;
                                                let v3_temp: Documents::US10 = v3.get().clone();
                                                v0_1.set(v0_1_temp);
                                                v1_1.set(v1_1_temp);
                                                v2.set(v2_temp);
                                                v3.set(v3_temp);
                                                continue '_method38;
                                            } else {
                                                let v0_1_temp: string =
                                                    sprintf!("{}{}", v0_1.get().clone(), v219);
                                                let v1_1_temp: LrcPtr<Documents::UH1> =
                                                    v1_1.get().clone();
                                                let v2_temp: LrcPtr<Documents::UH0> = v220.clone();
                                                let v3_temp: Documents::US10 = v3.get().clone();
                                                v0_1.set(v0_1_temp);
                                                v1_1.set(v1_1_temp);
                                                v2.set(v2_temp);
                                                v3.set(v3_temp);
                                                continue '_method38;
                                            }
                                        }
                                    }
                                } else {
                                    (
                                        if v0_1.get().clone() == string("") {
                                            v1_1.get().clone()
                                        } else {
                                            Documents::method39(
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
                                        Documents::method37(
                                            v0_1.get().clone(),
                                            v1_1.get().clone(),
                                            v270.clone(),
                                            v3.get().clone(),
                                            Documents::US10::US10_2(1_u8),
                                        )
                                    } else {
                                        if '\"' == v269 {
                                            if v3.get().clone() == Documents::US10::US10_2(0_u8) {
                                                Documents::method37(
                                                    sprintf!("{}\"", v0_1.get().clone()),
                                                    v1_1.get().clone(),
                                                    v270.clone(),
                                                    v3.get().clone(),
                                                    Documents::US10::US10_1('\"'),
                                                )
                                            } else {
                                                Documents::method37(
                                                    string(""),
                                                    Documents::method39(
                                                        v1_1.get().clone(),
                                                        LrcPtr::new(Documents::UH1::UH1_1(
                                                            v0_1.get().clone(),
                                                            LrcPtr::new(Documents::UH1::UH1_0),
                                                        )),
                                                    ),
                                                    v270.clone(),
                                                    v3.get().clone(),
                                                    Documents::US10::US10_0,
                                                )
                                            }
                                        } else {
                                            if ' ' == v269 {
                                                let v0_1_temp: string =
                                                    sprintf!("{} ", v0_1.get().clone());
                                                let v1_1_temp: LrcPtr<Documents::UH1> =
                                                    v1_1.get().clone();
                                                let v2_temp: LrcPtr<Documents::UH0> = v270;
                                                let v3_temp: Documents::US10 = v3.get().clone();
                                                v0_1.set(v0_1_temp);
                                                v1_1.set(v1_1_temp);
                                                v2.set(v2_temp);
                                                v3.set(v3_temp);
                                                continue '_method38;
                                            } else {
                                                let v0_1_temp: string =
                                                    sprintf!("{}{}", v0_1.get().clone(), v269);
                                                let v1_1_temp: LrcPtr<Documents::UH1> =
                                                    v1_1.get().clone();
                                                let v2_temp: LrcPtr<Documents::UH0> = v270.clone();
                                                let v3_temp: Documents::US10 = v3.get().clone();
                                                v0_1.set(v0_1_temp);
                                                v1_1.set(v1_1_temp);
                                                v2.set(v2_temp);
                                                v3.set(v3_temp);
                                                continue '_method38;
                                            }
                                        }
                                    }
                                } else {
                                    (
                                        if v0_1.get().clone() == string("") {
                                            v1_1.get().clone()
                                        } else {
                                            Documents::method39(
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
                    Documents::US10::US10_0 => {
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
                                Documents::method37(
                                    string(""),
                                    v1_1.get().clone(),
                                    v5.clone(),
                                    v3.get().clone(),
                                    Documents::US10::US10_1('\"'),
                                )
                            } else {
                                if '\\' == v4 {
                                    Documents::method37(
                                        v0_1.get().clone(),
                                        v1_1.get().clone(),
                                        v5.clone(),
                                        v3.get().clone(),
                                        Documents::US10::US10_2(0_u8),
                                    )
                                } else {
                                    if ' ' == v4 {
                                        let v0_1_temp: string = string("");
                                        let v1_1_temp: LrcPtr<Documents::UH1> =
                                            if v0_1.get().clone() == string("") {
                                                v1_1.get().clone()
                                            } else {
                                                Documents::method39(
                                                    v1_1.get().clone(),
                                                    LrcPtr::new(Documents::UH1::UH1_1(
                                                        v0_1.get().clone(),
                                                        LrcPtr::new(Documents::UH1::UH1_0),
                                                    )),
                                                )
                                            };
                                        let v2_temp: LrcPtr<Documents::UH0> = v5;
                                        let v3_temp: Documents::US10 = v3.get().clone();
                                        v0_1.set(v0_1_temp);
                                        v1_1.set(v1_1_temp);
                                        v2.set(v2_temp);
                                        v3.set(v3_temp);
                                        continue '_method38;
                                    } else {
                                        let v0_1_temp: string =
                                            sprintf!("{}{}", v0_1.get().clone(), v4);
                                        let v1_1_temp: LrcPtr<Documents::UH1> = v1_1.get().clone();
                                        let v2_temp: LrcPtr<Documents::UH0> = v5.clone();
                                        let v3_temp: Documents::US10 = v3.get().clone();
                                        v0_1.set(v0_1_temp);
                                        v1_1.set(v1_1_temp);
                                        v2.set(v2_temp);
                                        v3.set(v3_temp);
                                        continue '_method38;
                                    }
                                }
                            }
                        } else {
                            (
                                if v0_1.get().clone() == string("") {
                                    v1_1.get().clone()
                                } else {
                                    Documents::method39(
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
                    Documents::US10::US10_2(v3_2_0) => {
                        let v44: u8 = match &v3.get().clone() {
                            Documents::US10::US10_2(x) => x.clone(),
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
                                Documents::method37(
                                    v0_1.get().clone(),
                                    v1_1.get().clone(),
                                    v46.clone(),
                                    v3.get().clone(),
                                    Documents::US10::US10_1('\\'),
                                )
                            } else {
                                if '\"' == v45 {
                                    if if let Documents::US10::US10_0 = &v3.get().clone() {
                                        true
                                    } else {
                                        false
                                    } {
                                        let v0_1_temp: string = v0_1.get().clone();
                                        let v1_1_temp: LrcPtr<Documents::UH1> = v1_1.get().clone();
                                        let v2_temp: LrcPtr<Documents::UH0> = v46.clone();
                                        let v3_temp: Documents::US10 = v3.get().clone();
                                        v0_1.set(v0_1_temp);
                                        v1_1.set(v1_1_temp);
                                        v2.set(v2_temp);
                                        v3.set(v3_temp);
                                        continue '_method38;
                                    } else {
                                        Documents::method37(
                                            sprintf!("{}\"", v0_1.get().clone()),
                                            v1_1.get().clone(),
                                            v46.clone(),
                                            v3.get().clone(),
                                            Documents::US10::US10_2(v44),
                                        )
                                    }
                                } else {
                                    if ' ' == v45 {
                                        let v0_1_temp: string = sprintf!("{} ", v0_1.get().clone());
                                        let v1_1_temp: LrcPtr<Documents::UH1> = v1_1.get().clone();
                                        let v2_temp: LrcPtr<Documents::UH0> = v46.clone();
                                        let v3_temp: Documents::US10 = v3.get().clone();
                                        v0_1.set(v0_1_temp);
                                        v1_1.set(v1_1_temp);
                                        v2.set(v2_temp);
                                        v3.set(v3_temp);
                                        continue '_method38;
                                    } else {
                                        if 1_u8 == v44 {
                                            if !(v3.get().clone() == v3.get().clone()) {
                                                let v0_1_temp: string =
                                                    sprintf!("{}\\{}", v0_1.get().clone(), v45);
                                                let v1_1_temp: LrcPtr<Documents::UH1> =
                                                    v1_1.get().clone();
                                                let v2_temp: LrcPtr<Documents::UH0> = v46.clone();
                                                let v3_temp: Documents::US10 = v3.get().clone();
                                                v0_1.set(v0_1_temp);
                                                v1_1.set(v1_1_temp);
                                                v2.set(v2_temp);
                                                v3.set(v3_temp);
                                                continue '_method38;
                                            } else {
                                                let v0_1_temp: string =
                                                    sprintf!("{}{}", v0_1.get().clone(), v45);
                                                let v1_1_temp: LrcPtr<Documents::UH1> =
                                                    v1_1.get().clone();
                                                let v2_temp: LrcPtr<Documents::UH0> = v46.clone();
                                                let v3_temp: Documents::US10 = v3.get().clone();
                                                v0_1.set(v0_1_temp);
                                                v1_1.set(v1_1_temp);
                                                v2.set(v2_temp);
                                                v3.set(v3_temp);
                                                continue '_method38;
                                            }
                                        } else {
                                            let v0_1_temp: string =
                                                sprintf!("{}{}", v0_1.get().clone(), v45);
                                            let v1_1_temp: LrcPtr<Documents::UH1> =
                                                v1_1.get().clone();
                                            let v2_temp: LrcPtr<Documents::UH0> = v46.clone();
                                            let v3_temp: Documents::US10 = v3.get().clone();
                                            v0_1.set(v0_1_temp);
                                            v1_1.set(v1_1_temp);
                                            v2.set(v2_temp);
                                            v3.set(v3_temp);
                                            continue '_method38;
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
                                        Documents::method39(
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
                                        Documents::method39(
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
        pub fn method37(
            v0_1: string,
            v1_1: LrcPtr<Documents::UH1>,
            v2: LrcPtr<Documents::UH0>,
            v3: Documents::US10,
            v4: Documents::US10,
        ) -> (LrcPtr<Documents::UH1>, string) {
            let v0_1: MutCell<string> = MutCell::new(v0_1.clone());
            let v1_1: MutCell<LrcPtr<Documents::UH1>> = MutCell::new(v1_1.clone());
            let v2: MutCell<LrcPtr<Documents::UH0>> = MutCell::new(v2.clone());
            let v3: MutCell<Documents::US10> = MutCell::new(v3.clone());
            let v4: MutCell<Documents::US10> = MutCell::new(v4.clone());
            '_method37: loop {
                break '_method37 (match &v4.get().clone() {
                    Documents::US10::US10_1(v4_1_0) => {
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
                                    if v3.get().clone() == Documents::US10::US10_1('\\') {
                                        let v0_1_temp: string = v0_1.get().clone();
                                        let v1_1_temp: LrcPtr<Documents::UH1> = v1_1.get().clone();
                                        let v2_temp: LrcPtr<Documents::UH0> = v109.clone();
                                        let v3_temp: Documents::US10 = v4.get().clone();
                                        let v4_temp: Documents::US10 = Documents::US10::US10_0;
                                        v0_1.set(v0_1_temp);
                                        v1_1.set(v1_1_temp);
                                        v2.set(v2_temp);
                                        v3.set(v3_temp);
                                        v4.set(v4_temp);
                                        continue '_method37;
                                    } else {
                                        if '\\' == v106 {
                                            if !(v3.get().clone() == Documents::US10::US10_2(0_u8))
                                            {
                                                let v0_1_temp: string =
                                                    sprintf!("{}\"", v0_1.get().clone());
                                                let v1_1_temp: LrcPtr<Documents::UH1> =
                                                    v1_1.get().clone();
                                                let v2_temp: LrcPtr<Documents::UH0> = v109.clone();
                                                let v3_temp: Documents::US10 = v4.get().clone();
                                                let v4_temp: Documents::US10 =
                                                    Documents::US10::US10_1('\"');
                                                v0_1.set(v0_1_temp);
                                                v1_1.set(v1_1_temp);
                                                v2.set(v2_temp);
                                                v3.set(v3_temp);
                                                v4.set(v4_temp);
                                                continue '_method37;
                                            } else {
                                                if v3.get().clone() == Documents::US10::US10_1('\\')
                                                {
                                                    let v0_1_temp: string =
                                                        sprintf!("{}\"", v0_1.get().clone());
                                                    let v1_1_temp: LrcPtr<Documents::UH1> =
                                                        v1_1.get().clone();
                                                    let v2_temp: LrcPtr<Documents::UH0> =
                                                        v109.clone();
                                                    let v3_temp: Documents::US10 = v4.get().clone();
                                                    let v4_temp: Documents::US10 =
                                                        Documents::US10::US10_1('\"');
                                                    v0_1.set(v0_1_temp);
                                                    v1_1.set(v1_1_temp);
                                                    v2.set(v2_temp);
                                                    v3.set(v3_temp);
                                                    v4.set(v4_temp);
                                                    continue '_method37;
                                                } else {
                                                    let v0_1_temp: string = v0_1.get().clone();
                                                    let v1_1_temp: LrcPtr<Documents::UH1> =
                                                        v1_1.get().clone();
                                                    let v2_temp: LrcPtr<Documents::UH0> =
                                                        v109.clone();
                                                    let v3_temp: Documents::US10 = v4.get().clone();
                                                    let v4_temp: Documents::US10 =
                                                        Documents::US10::US10_0;
                                                    v0_1.set(v0_1_temp);
                                                    v1_1.set(v1_1_temp);
                                                    v2.set(v2_temp);
                                                    v3.set(v3_temp);
                                                    v4.set(v4_temp);
                                                    continue '_method37;
                                                }
                                            }
                                        } else {
                                            if '\\' == v108 {
                                                let v0_1_temp: string = v0_1.get().clone();
                                                let v1_1_temp: LrcPtr<Documents::UH1> =
                                                    v1_1.get().clone();
                                                let v2_temp: LrcPtr<Documents::UH0> = v109.clone();
                                                let v3_temp: Documents::US10 = v4.get().clone();
                                                let v4_temp: Documents::US10 =
                                                    Documents::US10::US10_2(1_u8);
                                                v0_1.set(v0_1_temp);
                                                v1_1.set(v1_1_temp);
                                                v2.set(v2_temp);
                                                v3.set(v3_temp);
                                                v4.set(v4_temp);
                                                continue '_method37;
                                            } else {
                                                if v3.get().clone() == Documents::US10::US10_2(0_u8)
                                                {
                                                    let v0_1_temp: string =
                                                        sprintf!("{}\"", v0_1.get().clone());
                                                    let v1_1_temp: LrcPtr<Documents::UH1> =
                                                        v1_1.get().clone();
                                                    let v2_temp: LrcPtr<Documents::UH0> =
                                                        v109.clone();
                                                    let v3_temp: Documents::US10 = v4.get().clone();
                                                    let v4_temp: Documents::US10 =
                                                        Documents::US10::US10_1('\"');
                                                    v0_1.set(v0_1_temp);
                                                    v1_1.set(v1_1_temp);
                                                    v2.set(v2_temp);
                                                    v3.set(v3_temp);
                                                    v4.set(v4_temp);
                                                    continue '_method37;
                                                } else {
                                                    let v0_1_temp: string = string("");
                                                    let v1_1_temp: LrcPtr<Documents::UH1> =
                                                        Documents::method39(
                                                            v1_1.get().clone(),
                                                            LrcPtr::new(Documents::UH1::UH1_1(
                                                                v0_1.get().clone(),
                                                                LrcPtr::new(Documents::UH1::UH1_0),
                                                            )),
                                                        );
                                                    let v2_temp: LrcPtr<Documents::UH0> =
                                                        v109.clone();
                                                    let v3_temp: Documents::US10 = v4.get().clone();
                                                    let v4_temp: Documents::US10 =
                                                        Documents::US10::US10_0;
                                                    v0_1.set(v0_1_temp);
                                                    v1_1.set(v1_1_temp);
                                                    v2.set(v2_temp);
                                                    v3.set(v3_temp);
                                                    v4.set(v4_temp);
                                                    continue '_method37;
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
                                            let v3_temp: Documents::US10 = v4.get().clone();
                                            let v4_temp: Documents::US10 =
                                                Documents::US10::US10_2(1_u8);
                                            v0_1.set(v0_1_temp);
                                            v1_1.set(v1_1_temp);
                                            v2.set(v2_temp);
                                            v3.set(v3_temp);
                                            v4.set(v4_temp);
                                            continue '_method37;
                                        } else {
                                            if ' ' == v108 {
                                                Documents::method38(
                                                    sprintf!("{} ", v0_1.get().clone()),
                                                    v1_1.get().clone(),
                                                    v109.clone(),
                                                    v4.get().clone(),
                                                )
                                            } else {
                                                Documents::method38(
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
                                            let v3_temp: Documents::US10 = v4.get().clone();
                                            let v4_temp: Documents::US10 =
                                                Documents::US10::US10_2(1_u8);
                                            v0_1.set(v0_1_temp);
                                            v1_1.set(v1_1_temp);
                                            v2.set(v2_temp);
                                            v3.set(v3_temp);
                                            v4.set(v4_temp);
                                            continue '_method37;
                                        } else {
                                            if ' ' == v108 {
                                                Documents::method38(
                                                    sprintf!("{} ", v0_1.get().clone()),
                                                    v1_1.get().clone(),
                                                    v109.clone(),
                                                    v4.get().clone(),
                                                )
                                            } else {
                                                Documents::method38(
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
                                            Documents::method39(
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
                                            Documents::method39(
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
                                        if !(v3.get().clone() == Documents::US10::US10_2(0_u8)) {
                                            let v0_1_temp: string =
                                                sprintf!("{}\"", v0_1.get().clone());
                                            let v1_1_temp: LrcPtr<Documents::UH1> =
                                                v1_1.get().clone();
                                            let v2_temp: LrcPtr<Documents::UH0> = v221.clone();
                                            let v3_temp: Documents::US10 = v4.get().clone();
                                            let v4_temp: Documents::US10 =
                                                Documents::US10::US10_1('\"');
                                            v0_1.set(v0_1_temp);
                                            v1_1.set(v1_1_temp);
                                            v2.set(v2_temp);
                                            v3.set(v3_temp);
                                            v4.set(v4_temp);
                                            continue '_method37;
                                        } else {
                                            if v3.get().clone() == Documents::US10::US10_1('\\') {
                                                let v0_1_temp: string =
                                                    sprintf!("{}\"", v0_1.get().clone());
                                                let v1_1_temp: LrcPtr<Documents::UH1> =
                                                    v1_1.get().clone();
                                                let v2_temp: LrcPtr<Documents::UH0> = v221.clone();
                                                let v3_temp: Documents::US10 = v4.get().clone();
                                                let v4_temp: Documents::US10 =
                                                    Documents::US10::US10_1('\"');
                                                v0_1.set(v0_1_temp);
                                                v1_1.set(v1_1_temp);
                                                v2.set(v2_temp);
                                                v3.set(v3_temp);
                                                v4.set(v4_temp);
                                                continue '_method37;
                                            } else {
                                                let v0_1_temp: string = v0_1.get().clone();
                                                let v1_1_temp: LrcPtr<Documents::UH1> =
                                                    v1_1.get().clone();
                                                let v2_temp: LrcPtr<Documents::UH0> = v221;
                                                let v3_temp: Documents::US10 = v4.get().clone();
                                                let v4_temp: Documents::US10 =
                                                    Documents::US10::US10_0;
                                                v0_1.set(v0_1_temp);
                                                v1_1.set(v1_1_temp);
                                                v2.set(v2_temp);
                                                v3.set(v3_temp);
                                                v4.set(v4_temp);
                                                continue '_method37;
                                            }
                                        }
                                    } else {
                                        if '\\' == v220 {
                                            let v0_1_temp: string = v0_1.get().clone();
                                            let v1_1_temp: LrcPtr<Documents::UH1> =
                                                v1_1.get().clone();
                                            let v2_temp: LrcPtr<Documents::UH0> = v221.clone();
                                            let v3_temp: Documents::US10 = v4.get().clone();
                                            let v4_temp: Documents::US10 =
                                                Documents::US10::US10_2(1_u8);
                                            v0_1.set(v0_1_temp);
                                            v1_1.set(v1_1_temp);
                                            v2.set(v2_temp);
                                            v3.set(v3_temp);
                                            v4.set(v4_temp);
                                            continue '_method37;
                                        } else {
                                            if ' ' == v220 {
                                                Documents::method38(
                                                    sprintf!("{} ", v0_1.get().clone()),
                                                    v1_1.get().clone(),
                                                    v221.clone(),
                                                    v4.get().clone(),
                                                )
                                            } else {
                                                Documents::method38(
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
                                            Documents::method39(
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
                                        let v3_temp: Documents::US10 = v4.get().clone();
                                        let v4_temp: Documents::US10 =
                                            Documents::US10::US10_2(1_u8);
                                        v0_1.set(v0_1_temp);
                                        v1_1.set(v1_1_temp);
                                        v2.set(v2_temp);
                                        v3.set(v3_temp);
                                        v4.set(v4_temp);
                                        continue '_method37;
                                    } else {
                                        if '\"' == v270 {
                                            if v3.get().clone() == Documents::US10::US10_2(0_u8) {
                                                let v0_1_temp: string =
                                                    sprintf!("{}\"", v0_1.get().clone());
                                                let v1_1_temp: LrcPtr<Documents::UH1> =
                                                    v1_1.get().clone();
                                                let v2_temp: LrcPtr<Documents::UH0> = v271.clone();
                                                let v3_temp: Documents::US10 = v4.get().clone();
                                                let v4_temp: Documents::US10 =
                                                    Documents::US10::US10_1('\"');
                                                v0_1.set(v0_1_temp);
                                                v1_1.set(v1_1_temp);
                                                v2.set(v2_temp);
                                                v3.set(v3_temp);
                                                v4.set(v4_temp);
                                                continue '_method37;
                                            } else {
                                                let v0_1_temp: string = string("");
                                                let v1_1_temp: LrcPtr<Documents::UH1> =
                                                    Documents::method39(
                                                        v1_1.get().clone(),
                                                        LrcPtr::new(Documents::UH1::UH1_1(
                                                            v0_1.get().clone(),
                                                            LrcPtr::new(Documents::UH1::UH1_0),
                                                        )),
                                                    );
                                                let v2_temp: LrcPtr<Documents::UH0> = v271.clone();
                                                let v3_temp: Documents::US10 = v4.get().clone();
                                                let v4_temp: Documents::US10 =
                                                    Documents::US10::US10_0;
                                                v0_1.set(v0_1_temp);
                                                v1_1.set(v1_1_temp);
                                                v2.set(v2_temp);
                                                v3.set(v3_temp);
                                                v4.set(v4_temp);
                                                continue '_method37;
                                            }
                                        } else {
                                            if ' ' == v270 {
                                                Documents::method38(
                                                    sprintf!("{} ", v0_1.get().clone()),
                                                    v1_1.get().clone(),
                                                    v271.clone(),
                                                    v4.get().clone(),
                                                )
                                            } else {
                                                Documents::method38(
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
                                            Documents::method39(
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
                    Documents::US10::US10_0 => {
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
                                let v3_temp: Documents::US10 = v4.get().clone();
                                let v4_temp: Documents::US10 = Documents::US10::US10_1('\"');
                                v0_1.set(v0_1_temp);
                                v1_1.set(v1_1_temp);
                                v2.set(v2_temp);
                                v3.set(v3_temp);
                                v4.set(v4_temp);
                                continue '_method37;
                            } else {
                                if '\\' == v5 {
                                    let v0_1_temp: string = v0_1.get().clone();
                                    let v1_1_temp: LrcPtr<Documents::UH1> = v1_1.get().clone();
                                    let v2_temp: LrcPtr<Documents::UH0> = v6;
                                    let v3_temp: Documents::US10 = v4.get().clone();
                                    let v4_temp: Documents::US10 = Documents::US10::US10_2(0_u8);
                                    v0_1.set(v0_1_temp);
                                    v1_1.set(v1_1_temp);
                                    v2.set(v2_temp);
                                    v3.set(v3_temp);
                                    v4.set(v4_temp);
                                    continue '_method37;
                                } else {
                                    if ' ' == v5 {
                                        Documents::method38(
                                            string(""),
                                            if v0_1.get().clone() == string("") {
                                                v1_1.get().clone()
                                            } else {
                                                Documents::method39(
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
                                        Documents::method38(
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
                                    Documents::method39(
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
                    Documents::US10::US10_2(v4_2_0) => {
                        let v45: u8 = match &v4.get().clone() {
                            Documents::US10::US10_2(x) => x.clone(),
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
                                let v3_temp: Documents::US10 = v4.get().clone();
                                let v4_temp: Documents::US10 = Documents::US10::US10_1('\\');
                                v0_1.set(v0_1_temp);
                                v1_1.set(v1_1_temp);
                                v2.set(v2_temp);
                                v3.set(v3_temp);
                                v4.set(v4_temp);
                                continue '_method37;
                            } else {
                                if '\"' == v46 {
                                    if if let Documents::US10::US10_0 = &v3.get().clone() {
                                        true
                                    } else {
                                        false
                                    } {
                                        Documents::method38(
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
                                        let v3_temp: Documents::US10 = v4.get().clone();
                                        let v4_temp: Documents::US10 = Documents::US10::US10_2(v45);
                                        v0_1.set(v0_1_temp);
                                        v1_1.set(v1_1_temp);
                                        v2.set(v2_temp);
                                        v3.set(v3_temp);
                                        v4.set(v4_temp);
                                        continue '_method37;
                                    }
                                } else {
                                    if ' ' == v46 {
                                        Documents::method38(
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
                                                let v3_temp: Documents::US10 = v4.get().clone();
                                                let v4_temp: Documents::US10 = v3.get().clone();
                                                v0_1.set(v0_1_temp);
                                                v1_1.set(v1_1_temp);
                                                v2.set(v2_temp);
                                                v3.set(v3_temp);
                                                v4.set(v4_temp);
                                                continue '_method37;
                                            } else {
                                                Documents::method38(
                                                    sprintf!("{}{}", v0_1.get().clone(), v46),
                                                    v1_1.get().clone(),
                                                    v47.clone(),
                                                    v4.get().clone(),
                                                )
                                            }
                                        } else {
                                            Documents::method38(
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
                                        Documents::method39(
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
                                        Documents::method39(
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
        pub fn method40(v0_1: LrcPtr<Documents::UH1>, v1_1: List<string>) -> List<string> {
            match v0_1.as_ref() {
                Documents::UH1::UH1_0 => v1_1.clone(),
                Documents::UH1::UH1_1(v0_1_1_0, v0_1_1_1) => cons(
                    match v0_1.as_ref() {
                        Documents::UH1::UH1_1(x, _) => x.clone(),
                        _ => unreachable!(),
                    },
                    Documents::method40(
                        match v0_1.as_ref() {
                            Documents::UH1::UH1_1(_, x) => x.clone(),
                            _ => unreachable!(),
                        },
                        v1_1.clone(),
                    ),
                ),
            }
        }
        pub fn method35(v0_1: string) -> Array<string> {
            let _v0: MutCell<Option<Option<string>>> = MutCell::new(None::<Option<string>>);
            _v0.set(Some(Some(v0_1)));
            {
                let v6: Option<string> = getValue(_v0.get().clone());
                let v9: Documents::US7 =
                    defaultValue(Documents::US7::US7_1, map(Documents::method36(), v6));
                let v12: string = match &v9 {
                    Documents::US7::US7_0(v9_0_0) => match &v9 {
                        Documents::US7::US7_0(x) => x.clone(),
                        _ => unreachable!(),
                    },
                    _ => string(""),
                };
                let v13: i32 = length(v12.clone());
                let v14: Array<char> = new_init(&'\u{0000}', v13);
                let v15: LrcPtr<Documents::Mut5> = LrcPtr::new(Documents::Mut5 {
                    l0: MutCell::new(0_i32),
                });
                while Documents::method20(v13, v15.clone()) {
                    let v17: i32 = v15.l0.get().clone();
                    let v18: char = getCharAt(v12.clone(), v17);
                    v14.get_mut()[v17 as usize] = v18;
                    {
                        let v19: i32 = v17 + 1_i32;
                        v15.l0.set(v19);
                        ()
                    }
                }
                {
                    let v21: List<char> = ofArray(v14.clone());
                    toArray(Documents::method40(
                        (Documents::method37(
                            string(""),
                            LrcPtr::new(Documents::UH1::UH1_0),
                            foldBack(
                                Func2::new(move |b0: char, b1: LrcPtr<Documents::UH0>| {
                                    (Documents::method33())(b0)(b1)
                                }),
                                v21,
                                LrcPtr::new(Documents::UH0::UH0_0),
                            ),
                            Documents::US10::US10_0,
                            Documents::US10::US10_0,
                        ))
                        .0
                        .clone(),
                        empty::<string>(),
                    ))
                }
            }
        }
        pub fn closure27(unitVar: (), v0_1: string) -> std::string::String {
            let v1_1: string = Documents::method13(v0_1);
            let v3: &str = fable_library_rust::String_::LrcStr::as_str(&v1_1);
            String::from(v3)
        }
        pub fn closure28(
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
        pub fn method41() -> Func0<string> {
            Func0::new(move || Documents::closure6((), ()))
        }
        pub fn method43(v0_1: string) -> string {
            v0_1
        }
        pub fn method45(
            v0_1: std::sync::Mutex<Option<std::process::Child>>,
        ) -> std::sync::Mutex<Option<std::process::Child>> {
            v0_1
        }
        pub fn closure29(
            unitVar: (),
            v0_1: std::process::Child,
        ) -> std::sync::Arc<std::sync::Mutex<Option<std::process::Child>>> {
            let v4: std::sync::Mutex<Option<std::process::Child>> =
                Documents::method45(std::sync::Mutex::new(Some(v0_1)));
            std::sync::Arc::new(v4)
        }
        pub fn method44(
        ) -> Func1<std::process::Child, std::sync::Arc<std::sync::Mutex<Option<std::process::Child>>>>
        {
            Func1::new(move |v: std::process::Child| Documents::closure29((), v))
        }
        pub fn method46(
            v0_1: Result<std::process::Child, std::io::Error>,
        ) -> Result<std::process::Child, std::io::Error> {
            v0_1
        }
        pub fn closure30(
            unitVar: (),
            v0_1: std::sync::Arc<std::sync::Mutex<Option<std::process::Child>>>,
        ) -> Documents::US11 {
            Documents::US11::US11_0(v0_1)
        }
        pub fn closure31(unitVar: (), v0_1: std::string::String) -> Documents::US11 {
            Documents::US11::US11_1(v0_1)
        }
        pub fn closure32(v0_1: std::string::String, unitVar: ()) -> string {
            sprintf!("execute_with_options -1 / error: {}", v0_1)
        }
        pub fn method47(
            v0_1: std::sync::Arc<std::sync::Mutex<Option<std::process::Child>>>,
        ) -> std::sync::Arc<std::sync::Mutex<Option<std::process::Child>>> {
            v0_1
        }
        pub fn method48(
            v0_1: std::sync::Mutex<Option<std::process::ChildStdout>>,
        ) -> std::sync::Mutex<Option<std::process::ChildStdout>> {
            v0_1
        }
        pub fn method49(
            v0_1: std::sync::Mutex<Option<std::process::ChildStderr>>,
        ) -> std::sync::Mutex<Option<std::process::ChildStderr>> {
            v0_1
        }
        pub fn method50(
            v0_1: std::sync::Arc<std::sync::mpsc::Receiver<std::string::String>>,
        ) -> std::sync::Arc<std::sync::mpsc::Receiver<std::string::String>> {
            v0_1
        }
        pub fn method51(
            v0_1: std::sync::Mutex<std::sync::mpsc::Sender<std::string::String>>,
        ) -> std::sync::Mutex<std::sync::mpsc::Sender<std::string::String>> {
            v0_1
        }
        pub fn method52(
            v0_1: std::sync::Mutex<std::sync::Arc<std::sync::mpsc::Receiver<std::string::String>>>,
        ) -> std::sync::Mutex<std::sync::Arc<std::sync::mpsc::Receiver<std::string::String>>>
        {
            v0_1
        }
        pub fn method53(
            v0_1: std::sync::Mutex<std::io::Lines<std::io::BufReader<std::process::ChildStdout>>>,
        ) -> std::sync::Mutex<std::io::Lines<std::io::BufReader<std::process::ChildStdout>>>
        {
            v0_1
        }
        pub fn closure34(unitVar: (), v0_1: std::string::String) -> Documents::US13 {
            Documents::US13::US13_0(v0_1)
        }
        pub fn closure35(unitVar: (), v0_1: std::string::String) -> Documents::US13 {
            Documents::US13::US13_1(v0_1)
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
            let v2 = Documents::method27();
            let v4: Result<std::string::String, std::string::String> = v1_1.map_err(|x| v2(x));
            let v7: Documents::US13 = match &v4 {
                Err(v4_1_0) => Documents::closure35((), v4_1_0.clone()),
                Ok(v4_0_0) => Documents::closure34((), v4_0_0.clone()),
            };
            let v23: std::string::String = match &v7 {
                Documents::US13::US13_0(v7_0_0) => {
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
                Documents::US13::US13_1(v7_1_0) => {
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
        pub fn method54(
            v0_1: std::sync::Arc<std::sync::Mutex<std::sync::mpsc::Sender<std::string::String>>>,
        ) -> Func1<Result<std::string::String, std::io::Error>, ()> {
            Func1::new({
                let v0_1 = v0_1.clone();
                move |v: Result<std::string::String, std::io::Error>| {
                    Documents::closure33(v0_1.clone(), v)
                }
            })
        }
        pub fn method55(
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
            let v2 = Documents::method27();
            let v4: Result<std::string::String, std::string::String> = v1_1.map_err(|x| v2(x));
            let v7: Documents::US13 = match &v4 {
                Err(v4_1_0) => Documents::closure35((), v4_1_0.clone()),
                Ok(v4_0_0) => Documents::closure34((), v4_0_0.clone()),
            };
            let v23: std::string::String = match &v7 {
                Documents::US13::US13_0(v7_0_0) => {
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
                Documents::US13::US13_1(v7_1_0) => {
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
        pub fn method56(
            v0_1: std::sync::Arc<std::sync::Mutex<std::sync::mpsc::Sender<std::string::String>>>,
        ) -> Func1<Result<std::string::String, std::io::Error>, ()> {
            Func1::new({
                let v0_1 = v0_1.clone();
                move |v: Result<std::string::String, std::io::Error>| {
                    Documents::closure38(v0_1.clone(), v)
                }
            })
        }
        pub fn closure40(unitVar: (), v0_1: std::process::Output) -> Documents::US14 {
            Documents::US14::US14_0(v0_1)
        }
        pub fn closure41(unitVar: (), v0_1: std::string::String) -> Documents::US14 {
            Documents::US14::US14_1(v0_1)
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
        pub fn method57(v0_: i32, v0__1: string) -> LrcPtr<(i32, string)> {
            LrcPtr::new((v0_, v0__1))
        }
        pub fn method42(
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
                        defaultValue(Documents::US7::US7_1, map(Documents::method36(), v3));
                    let v29: &mut std::process::Command = match &v23 {
                        Documents::US7::US7_0(v23_0_0) => {
                            let v25: string = Documents::method43(match &v23 {
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
                    let v34 = Documents::method44();
                    let v35: Result<std::process::Child, std::io::Error> = Documents::method46(v33);
                    let v37: Result<
                        std::sync::Arc<std::sync::Mutex<Option<std::process::Child>>>,
                        std::io::Error,
                    > = v35.map(|x| v34(x));
                    let v38 = Documents::method27();
                    let v40: Result<
                        std::sync::Arc<std::sync::Mutex<Option<std::process::Child>>>,
                        std::string::String,
                    > = v37.map_err(|x| v38(x));
                    let v43: Documents::US11 = match &v40 {
                        Err(v40_1_0) => Documents::closure31((), v40_1_0.clone()),
                        Ok(v40_0_0) => Documents::closure30((), v40_0_0.clone()),
                    };
                    let patternInput_1: (i32, Documents::US3, Documents::US12) = match &v43 {
                        Documents::US11::US11_0(v43_0_0) => {
                            let v45: std::sync::Arc<std::sync::Mutex<Option<std::process::Child>>> =
                                Documents::method47(v43_0_0.clone());
                            let v47: std::process::ChildStdout =
                                v45.lock().unwrap().as_mut().unwrap().stdout.take().unwrap();
                            let v49: std::process::ChildStderr =
                                v45.lock().unwrap().as_mut().unwrap().stderr.take().unwrap();
                            let v53: std::sync::Mutex<Option<std::process::ChildStdout>> =
                                Documents::method48(std::sync::Mutex::new(Some(v47)));
                            let v55: std::sync::Arc<
                                std::sync::Mutex<Option<std::process::ChildStdout>>,
                            > = std::sync::Arc::new(v53);
                            let v59: std::sync::Mutex<Option<std::process::ChildStderr>> =
                                Documents::method49(std::sync::Mutex::new(Some(v49)));
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
                            > = Documents::method50(patternInput.1.clone());
                            let v67: bool = true;
                            let v65 = v65;
                            let v70: std::sync::Mutex<
                                std::sync::mpsc::Sender<std::string::String>,
                            > = Documents::method51(std::sync::Mutex::new(patternInput.0.clone()));
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
                            > = Documents::method52(std::sync::Mutex::new(v65));
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
                                > = Documents::method53(std::sync::Mutex::new(v85));
                                let v90: std::sync::Arc<
                                    std::sync::Mutex<
                                        std::io::Lines<
                                            std::io::BufReader<std::process::ChildStdout>,
                                        >,
                                    >,
                                > = std::sync::Arc::new(v88);
                                let v91 = Documents::method54(v74);
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
                                > = Documents::method55(std::sync::Mutex::new(v99));
                                let v104: std::sync::Arc<
                                    std::sync::Mutex<
                                        std::io::Lines<
                                            std::io::BufReader<std::process::ChildStderr>,
                                        >,
                                    >,
                                > = std::sync::Arc::new(v102);
                                let v105 = Documents::method56(v72);
                                let v107: bool = true;
                                for line in v104.lock().unwrap().by_ref() {
                                    v105(line)
                                }
                                let v109: bool = true;
                            });
                            let v111: Result<std::process::Output, std::io::Error> =
                                v45.lock().unwrap().take().unwrap().wait_with_output();
                            let v112 = Documents::method27();
                            let v114: Result<std::process::Output, std::string::String> =
                                v111.map_err(|x| v112(x));
                            let v116: bool = true;
                            v83.join().unwrap();
                            let v118: bool = true;
                            v97.join().unwrap();
                            let v121: Documents::US14 = match &v114 {
                                Err(v114_1_0) => Documents::closure41((), v114_1_0.clone()),
                                Ok(v114_0_0) => Documents::closure40((), v114_0_0.clone()),
                            };
                            match &v121 {
                                Documents::US14::US14_0(v121_0_0) => (
                                    v121_0_0.clone().status.code().unwrap(),
                                    Documents::US3::US3_1,
                                    Documents::US12::US12_0(v81),
                                ),
                                Documents::US14::US14_1(v121_1_0) => {
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
                                        Documents::US12::US12_1,
                                    )
                                }
                            }
                        }
                        Documents::US11::US11_1(v43_1_0) => {
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
                                Documents::US12::US12_1,
                            )
                        }
                    };
                    let v150: Documents::US12 = patternInput_1.2.clone();
                    let v149: Documents::US3 = patternInput_1.1.clone();
                    let v148: i32 = patternInput_1.0.clone();
                    let v157: Documents::US3 = match &v150 {
                        Documents::US12::US12_0(v150_0_0) => Documents::US3::US3_0(
                            match &v150 {
                                Documents::US12::US12_0(x) => x.clone(),
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
                            Documents::method57(v182.0.clone(), v182.1.clone());
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
        ) -> Documents::US15 {
            Documents::US15::US15_0(v0_1)
        }
        pub fn method58() -> Func1<Func1<(bool, string, i32), Arc<Async<()>>>, Documents::US15> {
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
        pub fn closure49(unitVar: (), v0_1: CancellationToken) -> Documents::US16 {
            Documents::US16::US16_0(v0_1)
        }
        pub fn method59() -> Func1<CancellationToken, Documents::US16> {
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
        pub fn method60() -> string {
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
            string("documents.run / par_map / crowbook")
        }
        pub fn closure54(v0_1: string, v1_1: i32, unitVar: ()) -> string {
            sprintf!(
                "exit_code: {:?} / result: {} / {}",
                v1_1,
                v0_1,
                Documents::closure6((), ())
            )
        }
        pub fn method61(v0_1: string) -> string {
            v0_1
        }
        pub fn closure55(unitVar: (), unitVar_1: ()) -> string {
            string("documents.run / par_map")
        }
        pub fn closure56(
            v0_1: string,
            v1_1: string,
            v2: string,
            v3: string,
            v4: i32,
            v5: string,
            v6: i32,
            v7: string,
            v8: string,
            v9: Array<Option<Result<string, LrcPtr<(string, string)>>>>,
            unitVar: (),
        ) -> string {
            sprintf!("file: {} / real_path: {} / relative_path: {} / origin_hash_exit_code: {} / origin_hash: {} / local_git_hash_exit_code: {} / local_git_hash: {} / hash1: {} / hash2: {:?} / files: {:?} / {}",
                     v1_1, v2, v0_1, v4, v3, v6, v5, v7, v8, v9,
                     Documents::closure6((), ()))
        }
        pub fn closure23(
            v0_1: string,
            v1_1: string,
            v2: string,
            v3: string,
        ) -> Result<
            LrcPtr<(
                string,
                Vec<Option<Result<string, LrcPtr<(string, string)>>>>,
            )>,
            std::string::String,
        > {
            let _v4: MutCell<Option<string>> = MutCell::new(None::<string>);
            let v6: string = Documents::method12(v3);
            let v7: string = Documents::method13(v6.clone());
            let v9: &str = fable_library_rust::String_::LrcStr::as_str(&v7);
            let v11: std::string::String = String::from(v9);
            let v13: std::path::PathBuf = std::path::PathBuf::from(v11);
            {
                let x_8: string = if v13.exists() == false {
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
                                {
                                    let v88: string = getValue(_v46.get().clone());
                                    let _v89: MutCell<Option<bool>> = MutCell::new(None::<bool>);
                                    {
                                        let x_4: bool = cfg!(windows);
                                        _v89.set(Some(x_4))
                                    }
                                    {
                                        let v127: Array<string> = split(
                                            if getValue(_v89.get().clone()) == false {
                                                v88.clone()
                                            } else {
                                                let _v102: MutCell<Option<string>> =
                                                    MutCell::new(None::<string>);
                                                let v104: string = Documents::method16();
                                                let v105: string = Documents::method17(v88);
                                                let v106: string = Documents::method18();
                                                let v108: &str = &regex::Regex::new(&v104)
                                                    .unwrap()
                                                    .replace_all(&v105, &*v106);
                                                let v110: std::string::String = String::from(v108);
                                                {
                                                    let x_5: string =
                                                        fable_library_rust::String_::fromString(
                                                            v110,
                                                        );
                                                    _v102.set(Some(x_5))
                                                }
                                                {
                                                    let v120: string =
                                                        getValue(_v102.get().clone());
                                                    replace(
                                                        sprintf!(
                                                            "{}{}",
                                                            toLower(ofChar(getCharAt(
                                                                v120.clone(),
                                                                0_i32
                                                            ))),
                                                            getSlice(
                                                                v120,
                                                                Some(1_i32),
                                                                None::<i32>
                                                            )
                                                        ),
                                                        string("\\"),
                                                        string("/"),
                                                    )
                                                }
                                            },
                                            string("/"),
                                            -1_i32,
                                            0_i32,
                                        );
                                        let v129: i32 = count(v127.clone());
                                        let v130: LrcPtr<Documents::Mut4> =
                                            LrcPtr::new(Documents::Mut4 {
                                                l0: MutCell::new(0_i32),
                                                l1: MutCell::new(0_i32),
                                                l2: MutCell::new(new_empty::<string>()),
                                            });
                                        while Documents::method19(v129, v130.clone()) {
                                            let v132: i32 = v130.l0.get().clone();
                                            let v135: i32 = v132.wrapping_neg() + v129 - 1_i32;
                                            let matchValue: i32 = v130.l1.get().clone();
                                            let v137: Array<string> = v130.l2.get().clone();
                                            let v136: i32 = matchValue;
                                            let v138: string = v127[v135].clone();
                                            let patternInput_1: (i32, Array<string>) =
                                                if string("..") == v138.clone() {
                                                    (v136 + 1_i32, v137.clone())
                                                } else {
                                                    if 0_i32 == v136 {
                                                        let v142: Array<string> =
                                                            new_array(&[v138]);
                                                        let v143: i32 = count(v142.clone());
                                                        let v145: i32 = v143 + count(v137.clone());
                                                        let v146: Array<string> =
                                                            new_init(&string(""), v145);
                                                        let v147: LrcPtr<Documents::Mut5> =
                                                            LrcPtr::new(Documents::Mut5 {
                                                                l0: MutCell::new(0_i32),
                                                            });
                                                        while Documents::method20(
                                                            v145,
                                                            v147.clone(),
                                                        ) {
                                                            let v149: i32 = v147.l0.get().clone();
                                                            let v154: string = if v149 < v143 {
                                                                v142[v149].clone()
                                                            } else {
                                                                let v152: i32 = v149 - v143;
                                                                v137[v152].clone()
                                                            };
                                                            v146.get_mut()[v149 as usize] = v154;
                                                            {
                                                                let v155: i32 = v149 + 1_i32;
                                                                v147.l0.set(v155);
                                                                ()
                                                            }
                                                        }
                                                        (v136, v146.clone())
                                                    } else {
                                                        (v136 - 1_i32, v137.clone())
                                                    }
                                                };
                                            let v161: i32 = v132 + 1_i32;
                                            v130.l0.set(v161);
                                            v130.l1.set(patternInput_1.0.clone());
                                            v130.l2.set(patternInput_1.1.clone());
                                            ()
                                        }
                                        {
                                            let matchValue_2: i32 = v130.l1.get().clone();
                                            let v163: Array<string> = v130.l2.get().clone();
                                            let v164: LrcPtr<dyn IEnumerable_1<string>> =
                                                delay(Func0::new({
                                                    let v163 = v163.clone();
                                                    move || {
                                                        map_1(
                                                            Func1::new({
                                                                let v163 = v163.clone();
                                                                move |i: i32| v163[i].clone()
                                                            }),
                                                            rangeNumeric(
                                                                0_i32,
                                                                1_i32,
                                                                count(v163.clone()) - 1_i32,
                                                            ),
                                                        )
                                                    }
                                                }));
                                            let _v165: MutCell<Option<char>> =
                                                MutCell::new(None::<char>);
                                            {
                                                let x_6: char = std::path::MAIN_SEPARATOR;
                                                _v165.set(Some(x_6))
                                            }
                                            join(
                                                Documents::method21(ofChar(getValue(
                                                    _v165.get().clone(),
                                                ))),
                                                toArray_1(v164),
                                            )
                                        }
                                    }
                                }
                            }
                        }
                    }
                } else {
                    let v182: Result<std::path::PathBuf, std::io::Error> =
                        std::fs::canonicalize(&*v6);
                    let v184: std::path::PathBuf = v182.unwrap();
                    let v186: std::path::Display = v184.display();
                    let _v187: MutCell<Option<std::string::String>> =
                        MutCell::new(None::<std::string::String>);
                    {
                        let x_7: std::string::String = format!("{}", v186);
                        _v187.set(Some(x_7))
                    }
                    {
                        let v198: std::string::String = getValue(_v187.get().clone());
                        fable_library_rust::String_::fromString(v198)
                    }
                };
                _v4.set(Some(x_8))
            }
            {
                let v209: string = getValue(_v4.get().clone());
                let v210: string = Documents::method13(v209.clone());
                let v212: &str = fable_library_rust::String_::LrcStr::as_str(&v210);
                let v214: std::string::String = String::from(v212);
                let v216: std::path::PathBuf = std::path::PathBuf::from(v214);
                let v218: std::path::Display = v216.display();
                let _v219: MutCell<Option<std::string::String>> =
                    MutCell::new(None::<std::string::String>);
                {
                    let x_9: std::string::String = format!("{}", v218);
                    _v219.set(Some(x_9))
                }
                {
                    let v230: std::string::String = getValue(_v219.get().clone());
                    let v238: string = sprintf!(
                        ".{}",
                        replace(
                            replace(
                                fable_library_rust::String_::fromString(v230),
                                v1_1.clone(),
                                string("")
                            ),
                            string("\\"),
                            string("/")
                        )
                    );
                    let _v239: MutCell<Option<bool>> = MutCell::new(None::<bool>);
                    {
                        let x_10: bool = cfg!(windows);
                        _v239.set(Some(x_10))
                    }
                    {
                        let v272: string = if getValue(_v239.get().clone()) == false {
                            v209.clone()
                        } else {
                            let _v252: MutCell<Option<string>> = MutCell::new(None::<string>);
                            let v254: string = Documents::method16();
                            let v255: string = Documents::method17(v209);
                            let v256: string = Documents::method18();
                            let v258: &str =
                                &regex::Regex::new(&v254).unwrap().replace_all(&v255, &*v256);
                            let v260: std::string::String = String::from(v258);
                            {
                                let x_11: string = fable_library_rust::String_::fromString(v260);
                                _v252.set(Some(x_11))
                            }
                            {
                                let v269: string = getValue(_v252.get().clone());
                                replace(
                                    sprintf!(
                                        "{}{}",
                                        toLower(ofChar(getCharAt(v269.clone(), 0_i32))),
                                        getSlice(v269, Some(1_i32), None::<i32>)
                                    ),
                                    string("\\"),
                                    string("/"),
                                )
                            }
                        };
                        let _v273: MutCell<Option<string>> = MutCell::new(None::<string>);
                        let v275: string = Documents::method13(v0_1.clone());
                        let v277: &str = fable_library_rust::String_::LrcStr::as_str(&v275);
                        let v279: std::string::String = String::from(v277);
                        let v281: std::path::PathBuf = std::path::PathBuf::from(v279);
                        let v282: string = Documents::method13(v238.clone());
                        let v284: &str = fable_library_rust::String_::LrcStr::as_str(&v282);
                        let v286: std::string::String = String::from(v284);
                        let v288: std::path::PathBuf = v281.join(v286);
                        let v290: std::path::Display = v288.display();
                        let _v291: MutCell<Option<std::string::String>> =
                            MutCell::new(None::<std::string::String>);
                        {
                            let x_12: std::string::String = format!("{}", v290);
                            _v291.set(Some(x_12))
                        }
                        {
                            let v302: std::string::String = getValue(_v291.get().clone());
                            {
                                let x_13: string = fable_library_rust::String_::fromString(v302);
                                _v273.set(Some(x_13))
                            }
                            {
                                let v315: string = getValue(_v273.get().clone());
                                let _v316: MutCell<Option<bool>> = MutCell::new(None::<bool>);
                                {
                                    let x_14: bool = cfg!(windows);
                                    _v316.set(Some(x_14))
                                }
                                {
                                    let v349: string = if getValue(_v316.get().clone()) == false {
                                        v315.clone()
                                    } else {
                                        let _v329: MutCell<Option<string>> =
                                            MutCell::new(None::<string>);
                                        let v331: string = Documents::method16();
                                        let v332: string = Documents::method17(v315);
                                        let v333: string = Documents::method18();
                                        let v335: &str = &regex::Regex::new(&v331)
                                            .unwrap()
                                            .replace_all(&v332, &*v333);
                                        let v337: std::string::String = String::from(v335);
                                        {
                                            let x_15: string =
                                                fable_library_rust::String_::fromString(v337);
                                            _v329.set(Some(x_15))
                                        }
                                        {
                                            let v346: string = getValue(_v329.get().clone());
                                            replace(
                                                sprintf!(
                                                    "{}{}",
                                                    toLower(ofChar(getCharAt(v346.clone(), 0_i32))),
                                                    getSlice(v346, Some(1_i32), None::<i32>)
                                                ),
                                                string("\\"),
                                                string("/"),
                                            )
                                        }
                                    };
                                    let v350: Option<CancellationToken> = None::<CancellationToken>;
                                    let v351 = None::<Func1<(bool, string, i32), Arc<Async<()>>>>;
                                    let v353: string =
                                        sprintf!("git ls-tree --format=\'%(objectname)\' origin/gh-pages \"{}\"",
                                                 v349.clone());
                                    let v354: Option<string> = Some(v0_1);
                                    let _v355: MutCell<Option<(i32, string)>> =
                                        MutCell::new(None::<(i32, string)>);
                                    let patternInput_3: (string, string) = Documents::method32();
                                    let v359: i32 = length(v353.clone());
                                    let v360: Array<char> = new_init(&'\u{0000}', v359);
                                    let v361: LrcPtr<Documents::Mut5> =
                                        LrcPtr::new(Documents::Mut5 {
                                            l0: MutCell::new(0_i32),
                                        });
                                    while Documents::method20(v359, v361.clone()) {
                                        let v363: i32 = v361.l0.get().clone();
                                        let v364: char = getCharAt(v353.clone(), v363);
                                        v360.get_mut()[v363 as usize] = v364;
                                        {
                                            let v365: i32 = v363 + 1_i32;
                                            v361.l0.set(v365);
                                            ()
                                        }
                                    }
                                    {
                                        let v367: List<char> = ofArray(v360.clone());
                                        let patternInput_4: (string, string) = Documents::method34(
                                            patternInput_3.1.clone(),
                                            patternInput_3.0.clone(),
                                            foldBack(
                                                Func2::new(
                                                    move |b0: char, b1: LrcPtr<Documents::UH0>| {
                                                        (Documents::method33())(b0)(b1)
                                                    },
                                                ),
                                                v367,
                                                LrcPtr::new(Documents::UH0::UH0_0),
                                            ),
                                            Documents::US8::US8_0,
                                        );
                                        let v375: string = patternInput_4.0.clone();
                                        let v377: Array<string> =
                                            Documents::method35(patternInput_4.1.clone());
                                        let v379: Vec<string> = v377.to_vec();
                                        fn v381(v: string) -> std::string::String {
                                            Documents::closure27((), v)
                                        }
                                        let v382: Vec<std::string::String> = v379
                                            .iter()
                                            .map(|x| Func1::from(v381)(x.clone()))
                                            .collect();
                                        Documents::method3(
                                            Documents::US0::US0_1,
                                            Func0::new({
                                                let v350 = v350.clone();
                                                let v351 = v351.clone();
                                                let v353 = v353.clone();
                                                let v354 = v354.clone();
                                                let v375 = v375.clone();
                                                let v382 = v382.clone();
                                                move || {
                                                    Documents::closure28(
                                                        v350.clone(),
                                                        v353.clone(),
                                                        v351.clone(),
                                                        v354.clone(),
                                                        v375.clone(),
                                                        v382.clone(),
                                                        (),
                                                    )
                                                }
                                            }),
                                            Documents::method41(),
                                        );
                                        {
                                            let v386: std::pin::Pin<
                                                Box<
                                                    dyn std::future::Future<
                                                        Output = LrcPtr<(i32, string)>,
                                                    >,
                                                >,
                                            > = Documents::method42(
                                                v350.clone(),
                                                v353.clone(),
                                                v351.clone(),
                                                v354.clone(),
                                                v375.clone(),
                                                v382.clone(),
                                            );
                                            let v388: LrcPtr<(i32, string)> =
                                                futures_lite::future::block_on(v386);
                                            _v355.set(Some((v388.0.clone(), v388.1.clone())));
                                            {
                                                let patternInput_5: (i32, string) =
                                                    getValue(_v355.get().clone());
                                                let v561: string = patternInput_5.1.clone();
                                                let _v562: MutCell<Option<string>> =
                                                    MutCell::new(None::<string>);
                                                let v564: string =
                                                    Documents::method13(v1_1.clone());
                                                let v566: &str =
                                                    fable_library_rust::String_::LrcStr::as_str(
                                                        &v564,
                                                    );
                                                let v568: std::string::String = String::from(v566);
                                                let v570: std::path::PathBuf =
                                                    std::path::PathBuf::from(v568);
                                                let v571: string =
                                                    Documents::method13(v238.clone());
                                                let v573: &str =
                                                    fable_library_rust::String_::LrcStr::as_str(
                                                        &v571,
                                                    );
                                                let v575: std::string::String = String::from(v573);
                                                let v577: std::path::PathBuf = v570.join(v575);
                                                let v579: std::path::Display = v577.display();
                                                let _v580: MutCell<Option<std::string::String>> =
                                                    MutCell::new(None::<std::string::String>);
                                                {
                                                    let x_17: std::string::String =
                                                        format!("{}", v579);
                                                    _v580.set(Some(x_17))
                                                }
                                                {
                                                    let v591: std::string::String =
                                                        getValue(_v580.get().clone());
                                                    {
                                                        let x_18: string =
                                                            fable_library_rust::String_::fromString(
                                                                v591,
                                                            );
                                                        _v562.set(Some(x_18))
                                                    }
                                                    {
                                                        let v603: string =
                                                            getValue(_v562.get().clone());
                                                        let _v604: MutCell<Option<bool>> =
                                                            MutCell::new(None::<bool>);
                                                        {
                                                            let x_19: bool = cfg!(windows);
                                                            _v604.set(Some(x_19))
                                                        }
                                                        {
                                                            let v637: string = if getValue(
                                                                _v604.get().clone(),
                                                            ) == false
                                                            {
                                                                v603.clone()
                                                            } else {
                                                                let _v617: MutCell<Option<string>> =
                                                                    MutCell::new(None::<string>);
                                                                let v619: string =
                                                                    Documents::method16();
                                                                let v620: string =
                                                                    Documents::method17(v603);
                                                                let v621: string =
                                                                    Documents::method18();
                                                                let v623: &str =
                                                                    &regex::Regex::new(&v619)
                                                                        .unwrap()
                                                                        .replace_all(&v620, &*v621);
                                                                let v625: std::string::String =
                                                                    String::from(v623);
                                                                {
                                                                    let x_20:
                                                                                string =
                                                                            fable_library_rust::String_::fromString(v625);
                                                                    _v617.set(Some(x_20))
                                                                }
                                                                {
                                                                    let v634: string = getValue(
                                                                        _v617.get().clone(),
                                                                    );
                                                                    replace(
                                                                        sprintf!(
                                                                            "{}{}",
                                                                            toLower(ofChar(
                                                                                getCharAt(
                                                                                    v634.clone(),
                                                                                    0_i32
                                                                                )
                                                                            )),
                                                                            getSlice(
                                                                                v634,
                                                                                Some(1_i32),
                                                                                None::<i32>
                                                                            )
                                                                        ),
                                                                        string("\\"),
                                                                        string("/"),
                                                                    )
                                                                }
                                                            };
                                                            let v638: Option<CancellationToken> =
                                                                None::<CancellationToken>;
                                                            let v639 = None::<
                                                                Func1<
                                                                    (bool, string, i32),
                                                                    Arc<Async<()>>,
                                                                >,
                                                            >;
                                                            let v641: string = sprintf!(
                                                                "git hash-object \"{}\"",
                                                                v637.clone()
                                                            );
                                                            let v642: Option<string> =
                                                                Some(v1_1.clone());
                                                            let _v643: MutCell<
                                                                Option<(i32, string)>,
                                                            > = MutCell::new(None::<(i32, string)>);
                                                            let patternInput_6: (string, string) =
                                                                Documents::method32();
                                                            let v647: i32 = length(v641.clone());
                                                            let v648: Array<char> =
                                                                new_init(&'\u{0000}', v647);
                                                            let v649: LrcPtr<Documents::Mut5> =
                                                                LrcPtr::new(Documents::Mut5 {
                                                                    l0: MutCell::new(0_i32),
                                                                });
                                                            while Documents::method20(
                                                                v647,
                                                                v649.clone(),
                                                            ) {
                                                                let v651: i32 =
                                                                    v649.l0.get().clone();
                                                                let v652: char =
                                                                    getCharAt(v641.clone(), v651);
                                                                v648.get_mut()[v651 as usize] =
                                                                    v652;
                                                                {
                                                                    let v653: i32 = v651 + 1_i32;
                                                                    v649.l0.set(v653);
                                                                    ()
                                                                }
                                                            }
                                                            {
                                                                let v655: List<char> =
                                                                    ofArray(v648.clone());
                                                                let patternInput_7:
                                                                        (string,
                                                                         string) =
                                                                    Documents::method34(patternInput_6.1.clone(),
                                                                                        patternInput_6.0.clone(),
                                                                                        foldBack(Func2::new(move
                                                                                                                |b0:
                                                                                                                     char,
                                                                                                                 b1:
                                                                                                                     LrcPtr<Documents::UH0>|
                                                                                                                (Documents::method33())(b0)(b1)),
                                                                                                 v655,
                                                                                                 LrcPtr::new(Documents::UH0::UH0_0)),
                                                                                        Documents::US8::US8_0);
                                                                let v663: string =
                                                                    patternInput_7.0.clone();
                                                                let v665: Array<string> =
                                                                    Documents::method35(
                                                                        patternInput_7.1.clone(),
                                                                    );
                                                                let v667: Vec<string> =
                                                                    v665.to_vec();
                                                                let v669: Vec<std::string::String> =
                                                                    v667.iter()
                                                                        .map(|x| {
                                                                            Func1::from(v381)(
                                                                                x.clone(),
                                                                            )
                                                                        })
                                                                        .collect();
                                                                Documents::method3(
                                                                    Documents::US0::US0_1,
                                                                    Func0::new({
                                                                        let v638 = v638.clone();
                                                                        let v639 = v639.clone();
                                                                        let v641 = v641.clone();
                                                                        let v642 = v642.clone();
                                                                        let v663 = v663.clone();
                                                                        let v669 = v669.clone();
                                                                        move || {
                                                                            Documents::closure28(
                                                                                v638.clone(),
                                                                                v641.clone(),
                                                                                v639.clone(),
                                                                                v642.clone(),
                                                                                v663.clone(),
                                                                                v669.clone(),
                                                                                (),
                                                                            )
                                                                        }
                                                                    }),
                                                                    Documents::method41(),
                                                                );
                                                                {
                                                                    let v673: std::pin::Pin<
                                                                        Box<
                                                                            dyn std::future::Future<
                                                                                Output = LrcPtr<(
                                                                                    i32,
                                                                                    string,
                                                                                )>,
                                                                            >,
                                                                        >,
                                                                    > = Documents::method42(
                                                                        v638.clone(),
                                                                        v641.clone(),
                                                                        v639.clone(),
                                                                        v642.clone(),
                                                                        v663.clone(),
                                                                        v669.clone(),
                                                                    );
                                                                    let v675:
                                                                            LrcPtr<(i32,
                                                                                    string)> =
                                                                        futures_lite::future::block_on(v673);
                                                                    _v643.set(Some((
                                                                        v675.0.clone(),
                                                                        v675.1.clone(),
                                                                    )));
                                                                    {
                                                                        let patternInput_8: (
                                                                            i32,
                                                                            string,
                                                                        ) = getValue(
                                                                            _v643.get().clone(),
                                                                        );
                                                                        let v848: string =
                                                                            patternInput_8
                                                                                .1
                                                                                .clone();
                                                                        let v3799: Array<
                                                                            Option<
                                                                                Result<
                                                                                    string,
                                                                                    LrcPtr<(
                                                                                        string,
                                                                                        string,
                                                                                    )>,
                                                                                >,
                                                                            >,
                                                                        > = if contains(
                                                                            v561.clone(),
                                                                            v848.clone(),
                                                                        ) == false
                                                                        {
                                                                            let _v851: MutCell<
                                                                                Option<bool>,
                                                                            > = MutCell::new(
                                                                                None::<bool>,
                                                                            );
                                                                            {
                                                                                let x_22: bool =
                                                                                    cfg!(windows);
                                                                                _v851
                                                                                    .set(Some(x_22))
                                                                            }
                                                                            {
                                                                                let v885:
                                                                                            Option<CancellationToken> =
                                                                                        None::<CancellationToken>;
                                                                                let v886 = None::<
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
                                                                                let v887: Option<
                                                                                    string,
                                                                                > = None::<string>;
                                                                                let v888:
                                                                                            string =
                                                                                        sprintf!("pwsh -c \"(Get-FileHash \\\"{}\\\" -Algorithm SHA256).Hash\"",
                                                                                                 if getValue(_v851.get().clone())
                                                                                                        ==
                                                                                                        false
                                                                                                    {
                                                                                                     v637.clone()
                                                                                                 } else {
                                                                                                     let _v864:
                                                                                                             MutCell<Option<string>> =
                                                                                                         MutCell::new(None::<string>);
                                                                                                     let v866:
                                                                                                             string =
                                                                                                         Documents::method16();
                                                                                                     let v867:
                                                                                                             string =
                                                                                                         Documents::method17(v637.clone());
                                                                                                     let v868:
                                                                                                             string =
                                                                                                         Documents::method18();
                                                                                                     let v870:
                                                                                                             &str =
                                                                                                         &regex::Regex::new(&v866).unwrap().replace_all(&v867, &*v868);
                                                                                                     let v872:
                                                                                                             std::string::String =
                                                                                                         String::from(v870);
                                                                                                     {
                                                                                                         let x_23:
                                                                                                                 string =
                                                                                                             fable_library_rust::String_::fromString(v872);
                                                                                                         _v864.set(Some(x_23))
                                                                                                     }
                                                                                                     {
                                                                                                         let v881:
                                                                                                                 string =
                                                                                                             getValue(_v864.get().clone());
                                                                                                         replace(sprintf!("{}{}",
                                                                                                                          toLower(ofChar(getCharAt(v881.clone(),
                                                                                                                                                   0_i32))),
                                                                                                                          getSlice(v881,
                                                                                                                                   Some(1_i32),
                                                                                                                                   None::<i32>)),
                                                                                                                 string("\\"),
                                                                                                                 string("/"))
                                                                                                     }
                                                                                                 });
                                                                                let _v889: MutCell<
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
                                                                                let patternInput_9:
                                                                                            (string,
                                                                                             string) =
                                                                                        Documents::method32();
                                                                                let v893: i32 =
                                                                                    length(
                                                                                        v888.clone(
                                                                                        ),
                                                                                    );
                                                                                let v894: Array<
                                                                                    char,
                                                                                > = new_init(
                                                                                    &'\u{0000}',
                                                                                    v893,
                                                                                );
                                                                                let v895:
                                                                                            LrcPtr<Documents::Mut5> =
                                                                                        LrcPtr::new(Documents::Mut5{l0:
                                                                                                                        MutCell::new(0_i32),});
                                                                                while Documents::method20(v893,
                                                                                                              v895.clone())
                                                                                          {
                                                                                        let v897:
                                                                                                i32 =
                                                                                            v895.l0.get().clone();
                                                                                        let v898:
                                                                                                char =
                                                                                            getCharAt(v888.clone(),
                                                                                                      v897);
                                                                                        v894.get_mut()[v897
                                                                                                           as
                                                                                                           usize]
                                                                                            =
                                                                                            v898;
                                                                                        {
                                                                                            let v899:
                                                                                                    i32 =
                                                                                                v897
                                                                                                    +
                                                                                                    1_i32;
                                                                                            v895.l0.set(v899);
                                                                                            ()
                                                                                        }
                                                                                    }
                                                                                {
                                                                                    let v901: List<
                                                                                        char,
                                                                                    > = ofArray(
                                                                                        v894.clone(
                                                                                        ),
                                                                                    );
                                                                                    let patternInput_10:
                                                                                                (string,
                                                                                                 string) =
                                                                                            Documents::method34(patternInput_9.1.clone(),
                                                                                                                patternInput_9.0.clone(),
                                                                                                                foldBack(Func2::new(move
                                                                                                                                        |b0:
                                                                                                                                             char,
                                                                                                                                         b1:
                                                                                                                                             LrcPtr<Documents::UH0>|
                                                                                                                                        (Documents::method33())(b0)(b1)),
                                                                                                                         v901,
                                                                                                                         LrcPtr::new(Documents::UH0::UH0_0)),
                                                                                                                Documents::US8::US8_0);
                                                                                    let v909:
                                                                                                string =
                                                                                            patternInput_10.0.clone();
                                                                                    let v911:
                                                                                                Array<string> =
                                                                                            Documents::method35(patternInput_10.1.clone());
                                                                                    let v913: Vec<
                                                                                        string,
                                                                                    > = v911
                                                                                        .to_vec();
                                                                                    let v915:
                                                                                                Vec<std::string::String> =
                                                                                            v913.iter().map(|x| Func1::from(v381)(x.clone())).collect();
                                                                                    Documents::method3(Documents::US0::US0_1,
                                                                                                           Func0::new({
                                                                                                                          let v885
                                                                                                                              =
                                                                                                                              v885.clone();
                                                                                                                          let v886
                                                                                                                              =
                                                                                                                              v886.clone();
                                                                                                                          let v887
                                                                                                                              =
                                                                                                                              v887.clone();
                                                                                                                          let v888
                                                                                                                              =
                                                                                                                              v888.clone();
                                                                                                                          let v909
                                                                                                                              =
                                                                                                                              v909.clone();
                                                                                                                          let v915
                                                                                                                              =
                                                                                                                              v915.clone();
                                                                                                                          move
                                                                                                                              ||
                                                                                                                              Documents::closure28(v885.clone(),
                                                                                                                                                   v888.clone(),
                                                                                                                                                   v886.clone(),
                                                                                                                                                   v887.clone(),
                                                                                                                                                   v909.clone(),
                                                                                                                                                   v915.clone(),
                                                                                                                                                   ())
                                                                                                                      }),
                                                                                                           Documents::method41());
                                                                                    {
                                                                                        let v919:
                                                                                                    std::pin::Pin<Box<dyn std::future::Future<Output = LrcPtr<(i32,
                                                                                                                                                               string)>>>> =
                                                                                                Documents::method42(v885.clone(),
                                                                                                                    v888.clone(),
                                                                                                                    v886.clone(),
                                                                                                                    v887.clone(),
                                                                                                                    v909.clone(),
                                                                                                                    v915.clone());
                                                                                        let v921:
                                                                                                    LrcPtr<(i32,
                                                                                                            string)> =
                                                                                                futures_lite::future::block_on(v919);
                                                                                        _v889.set(Some((v921.0.clone(),
                                                                                                            v921.1.clone())));
                                                                                        {
                                                                                            let v1094:
                                                                                                        string =
                                                                                                    (getValue(_v889.get().clone())).1.clone();
                                                                                            let _v1095:
                                                                                                        MutCell<Option<string>> =
                                                                                                    MutCell::new(None::<string>);
                                                                                            let v1097:
                                                                                                        string =
                                                                                                    Documents::method13(v2);
                                                                                            let v1099:
                                                                                                        &str =
                                                                                                    fable_library_rust::String_::LrcStr::as_str(&v1097);
                                                                                            let v1101:
                                                                                                        std::string::String =
                                                                                                    String::from(v1099);
                                                                                            let v1103:
                                                                                                        std::path::PathBuf =
                                                                                                    std::path::PathBuf::from(v1101);
                                                                                            let v1104:
                                                                                                        string =
                                                                                                    Documents::method13(v238.clone());
                                                                                            let v1106:
                                                                                                        &str =
                                                                                                    fable_library_rust::String_::LrcStr::as_str(&v1104);
                                                                                            let v1108:
                                                                                                        std::string::String =
                                                                                                    String::from(v1106);
                                                                                            let v1110:
                                                                                                        std::path::PathBuf =
                                                                                                    v1103.join(v1108);
                                                                                            let v1112:
                                                                                                        std::path::Display =
                                                                                                    v1110.display();
                                                                                            let _v1113:
                                                                                                        MutCell<Option<std::string::String>> =
                                                                                                    MutCell::new(None::<std::string::String>);
                                                                                            {
                                                                                                let x_25:
                                                                                                            std::string::String =
                                                                                                        format!("{}", v1112);
                                                                                                _v1113.set(Some(x_25))
                                                                                            }
                                                                                            {
                                                                                                let v1124:
                                                                                                            std::string::String =
                                                                                                        getValue(_v1113.get().clone());
                                                                                                {
                                                                                                    let x_26:
                                                                                                                string =
                                                                                                            fable_library_rust::String_::fromString(v1124);
                                                                                                    _v1095.set(Some(x_26))
                                                                                                }
                                                                                                {
                                                                                                    let v1136:
                                                                                                                string =
                                                                                                            getValue(_v1095.get().clone());
                                                                                                    let _v1137:
                                                                                                                MutCell<Option<bool>> =
                                                                                                            MutCell::new(None::<bool>);
                                                                                                    {
                                                                                                        let x_27:
                                                                                                                    bool =
                                                                                                                cfg!(windows);
                                                                                                        _v1137.set(Some(x_27))
                                                                                                    }
                                                                                                    {
                                                                                                        let v1170:
                                                                                                                    string =
                                                                                                                if getValue(_v1137.get().clone())
                                                                                                                       ==
                                                                                                                       false
                                                                                                                   {
                                                                                                                    v1136.clone()
                                                                                                                } else {
                                                                                                                    let _v1150:
                                                                                                                            MutCell<Option<string>> =
                                                                                                                        MutCell::new(None::<string>);
                                                                                                                    let v1152:
                                                                                                                            string =
                                                                                                                        Documents::method16();
                                                                                                                    let v1153:
                                                                                                                            string =
                                                                                                                        Documents::method17(v1136);
                                                                                                                    let v1154:
                                                                                                                            string =
                                                                                                                        Documents::method18();
                                                                                                                    let v1156:
                                                                                                                            &str =
                                                                                                                        &regex::Regex::new(&v1152).unwrap().replace_all(&v1153, &*v1154);
                                                                                                                    let v1158:
                                                                                                                            std::string::String =
                                                                                                                        String::from(v1156);
                                                                                                                    {
                                                                                                                        let x_28:
                                                                                                                                string =
                                                                                                                            fable_library_rust::String_::fromString(v1158);
                                                                                                                        _v1150.set(Some(x_28))
                                                                                                                    }
                                                                                                                    {
                                                                                                                        let v1167:
                                                                                                                                string =
                                                                                                                            getValue(_v1150.get().clone());
                                                                                                                        replace(sprintf!("{}{}",
                                                                                                                                         toLower(ofChar(getCharAt(v1167.clone(),
                                                                                                                                                                  0_i32))),
                                                                                                                                         getSlice(v1167,
                                                                                                                                                  Some(1_i32),
                                                                                                                                                  None::<i32>)),
                                                                                                                                string("\\"),
                                                                                                                                string("/"))
                                                                                                                    }
                                                                                                                };
                                                                                                        let _v1171:
                                                                                                                    MutCell<Option<bool>> =
                                                                                                                MutCell::new(None::<bool>);
                                                                                                        let v1173:
                                                                                                                    string =
                                                                                                                Documents::method13(v1170.clone());
                                                                                                        let v1175:
                                                                                                                    &str =
                                                                                                                fable_library_rust::String_::LrcStr::as_str(&v1173);
                                                                                                        let v1177:
                                                                                                                    std::string::String =
                                                                                                                String::from(v1175);
                                                                                                        let v1179:
                                                                                                                    std::path::PathBuf =
                                                                                                                std::path::PathBuf::from(v1177);
                                                                                                        {
                                                                                                            let x_29:
                                                                                                                        bool =
                                                                                                                    if v1179.clone().exists()
                                                                                                                       {
                                                                                                                        v1179.is_file()
                                                                                                                    } else {
                                                                                                                        false
                                                                                                                    };
                                                                                                            _v1171.set(Some(x_29))
                                                                                                        }
                                                                                                        {
                                                                                                            let v1439:
                                                                                                                        string =
                                                                                                                    if getValue(_v1171.get().clone())
                                                                                                                       {
                                                                                                                        let _v1195:
                                                                                                                                MutCell<Option<bool>> =
                                                                                                                            MutCell::new(None::<bool>);
                                                                                                                        {
                                                                                                                            let x_30:
                                                                                                                                    bool =
                                                                                                                                cfg!(windows);
                                                                                                                            _v1195.set(Some(x_30))
                                                                                                                        }
                                                                                                                        {
                                                                                                                            let v1229:
                                                                                                                                    Option<CancellationToken> =
                                                                                                                                None::<CancellationToken>;
                                                                                                                            let v1230 =
                                                                                                                                None::<Func1<(bool,
                                                                                                                                              string,
                                                                                                                                              i32),
                                                                                                                                             Arc<Async<()>>>>;
                                                                                                                            let v1231:
                                                                                                                                    Option<string> =
                                                                                                                                None::<string>;
                                                                                                                            let v1232:
                                                                                                                                    string =
                                                                                                                                sprintf!("pwsh -c \"(Get-FileHash \\\"{}\\\" -Algorithm SHA256).Hash\"",
                                                                                                                                         if getValue(_v1195.get().clone())
                                                                                                                                                ==
                                                                                                                                                false
                                                                                                                                            {
                                                                                                                                             v1170.clone()
                                                                                                                                         } else {
                                                                                                                                             let _v1208:
                                                                                                                                                     MutCell<Option<string>> =
                                                                                                                                                 MutCell::new(None::<string>);
                                                                                                                                             let v1210:
                                                                                                                                                     string =
                                                                                                                                                 Documents::method16();
                                                                                                                                             let v1211:
                                                                                                                                                     string =
                                                                                                                                                 Documents::method17(v1170.clone());
                                                                                                                                             let v1212:
                                                                                                                                                     string =
                                                                                                                                                 Documents::method18();
                                                                                                                                             let v1214:
                                                                                                                                                     &str =
                                                                                                                                                 &regex::Regex::new(&v1210).unwrap().replace_all(&v1211, &*v1212);
                                                                                                                                             let v1216:
                                                                                                                                                     std::string::String =
                                                                                                                                                 String::from(v1214);
                                                                                                                                             {
                                                                                                                                                 let x_31:
                                                                                                                                                         string =
                                                                                                                                                     fable_library_rust::String_::fromString(v1216);
                                                                                                                                                 _v1208.set(Some(x_31))
                                                                                                                                             }
                                                                                                                                             {
                                                                                                                                                 let v1225:
                                                                                                                                                         string =
                                                                                                                                                     getValue(_v1208.get().clone());
                                                                                                                                                 replace(sprintf!("{}{}",
                                                                                                                                                                  toLower(ofChar(getCharAt(v1225.clone(),
                                                                                                                                                                                           0_i32))),
                                                                                                                                                                  getSlice(v1225,
                                                                                                                                                                           Some(1_i32),
                                                                                                                                                                           None::<i32>)),
                                                                                                                                                         string("\\"),
                                                                                                                                                         string("/"))
                                                                                                                                             }
                                                                                                                                         });
                                                                                                                            let _v1233:
                                                                                                                                    MutCell<Option<(i32,
                                                                                                                                                    string)>> =
                                                                                                                                MutCell::new(None::<(i32,
                                                                                                                                                     string)>);
                                                                                                                            let patternInput_12:
                                                                                                                                    (string,
                                                                                                                                     string) =
                                                                                                                                Documents::method32();
                                                                                                                            let v1237:
                                                                                                                                    i32 =
                                                                                                                                length(v1232.clone());
                                                                                                                            let v1238:
                                                                                                                                    Array<char> =
                                                                                                                                new_init(&'\u{0000}',
                                                                                                                                         v1237);
                                                                                                                            let v1239:
                                                                                                                                    LrcPtr<Documents::Mut5> =
                                                                                                                                LrcPtr::new(Documents::Mut5{l0:
                                                                                                                                                                MutCell::new(0_i32),});
                                                                                                                            while Documents::method20(v1237,
                                                                                                                                                      v1239.clone())
                                                                                                                                  {
                                                                                                                                let v1241:
                                                                                                                                        i32 =
                                                                                                                                    v1239.l0.get().clone();
                                                                                                                                let v1242:
                                                                                                                                        char =
                                                                                                                                    getCharAt(v1232.clone(),
                                                                                                                                              v1241);
                                                                                                                                v1238.get_mut()[v1241
                                                                                                                                                    as
                                                                                                                                                    usize]
                                                                                                                                    =
                                                                                                                                    v1242;
                                                                                                                                {
                                                                                                                                    let v1243:
                                                                                                                                            i32 =
                                                                                                                                        v1241
                                                                                                                                            +
                                                                                                                                            1_i32;
                                                                                                                                    v1239.l0.set(v1243);
                                                                                                                                    ()
                                                                                                                                }
                                                                                                                            }
                                                                                                                            {
                                                                                                                                let v1245:
                                                                                                                                        List<char> =
                                                                                                                                    ofArray(v1238.clone());
                                                                                                                                let patternInput_13:
                                                                                                                                        (string,
                                                                                                                                         string) =
                                                                                                                                    Documents::method34(patternInput_12.1.clone(),
                                                                                                                                                        patternInput_12.0.clone(),
                                                                                                                                                        foldBack(Func2::new(move
                                                                                                                                                                                |b0:
                                                                                                                                                                                     char,
                                                                                                                                                                                 b1:
                                                                                                                                                                                     LrcPtr<Documents::UH0>|
                                                                                                                                                                                (Documents::method33())(b0)(b1)),
                                                                                                                                                                 v1245,
                                                                                                                                                                 LrcPtr::new(Documents::UH0::UH0_0)),
                                                                                                                                                        Documents::US8::US8_0);
                                                                                                                                let v1253:
                                                                                                                                        string =
                                                                                                                                    patternInput_13.0.clone();
                                                                                                                                let v1255:
                                                                                                                                        Array<string> =
                                                                                                                                    Documents::method35(patternInput_13.1.clone());
                                                                                                                                let v1257:
                                                                                                                                        Vec<string> =
                                                                                                                                    v1255.to_vec();
                                                                                                                                let v1259:
                                                                                                                                        Vec<std::string::String> =
                                                                                                                                    v1257.iter().map(|x| Func1::from(v381)(x.clone())).collect();
                                                                                                                                Documents::method3(Documents::US0::US0_1,
                                                                                                                                                   Func0::new({
                                                                                                                                                                  let v1229
                                                                                                                                                                      =
                                                                                                                                                                      v1229.clone();
                                                                                                                                                                  let v1230
                                                                                                                                                                      =
                                                                                                                                                                      v1230.clone();
                                                                                                                                                                  let v1231
                                                                                                                                                                      =
                                                                                                                                                                      v1231.clone();
                                                                                                                                                                  let v1232
                                                                                                                                                                      =
                                                                                                                                                                      v1232.clone();
                                                                                                                                                                  let v1253
                                                                                                                                                                      =
                                                                                                                                                                      v1253.clone();
                                                                                                                                                                  let v1259
                                                                                                                                                                      =
                                                                                                                                                                      v1259.clone();
                                                                                                                                                                  move
                                                                                                                                                                      ||
                                                                                                                                                                      Documents::closure28(v1229.clone(),
                                                                                                                                                                                           v1232.clone(),
                                                                                                                                                                                           v1230.clone(),
                                                                                                                                                                                           v1231.clone(),
                                                                                                                                                                                           v1253.clone(),
                                                                                                                                                                                           v1259.clone(),
                                                                                                                                                                                           ())
                                                                                                                                                              }),
                                                                                                                                                   Documents::method41());
                                                                                                                                {
                                                                                                                                    let v1263:
                                                                                                                                            std::pin::Pin<Box<dyn std::future::Future<Output = LrcPtr<(i32,
                                                                                                                                                                                                       string)>>>> =
                                                                                                                                        Documents::method42(v1229.clone(),
                                                                                                                                                            v1232.clone(),
                                                                                                                                                            v1230.clone(),
                                                                                                                                                            v1231.clone(),
                                                                                                                                                            v1253.clone(),
                                                                                                                                                            v1259.clone());
                                                                                                                                    let v1265:
                                                                                                                                            LrcPtr<(i32,
                                                                                                                                                    string)> =
                                                                                                                                        futures_lite::future::block_on(v1263);
                                                                                                                                    _v1233.set(Some((v1265.0.clone(),
                                                                                                                                                     v1265.1.clone())));
                                                                                                                                    (getValue(_v1233.get().clone())).1.clone()
                                                                                                                                }
                                                                                                                            }
                                                                                                                        }
                                                                                                                    } else {
                                                                                                                        string("")
                                                                                                                    };
                                                                                                            if v1094.clone()
                                                                                                                       !=
                                                                                                                       v1439.clone()
                                                                                                                   {
                                                                                                                    let v1443:
                                                                                                                            string =
                                                                                                                        sprintf!("{}.{}",
                                                                                                                                 v637.clone(),
                                                                                                                                 string("epub"));
                                                                                                                    let v1444:
                                                                                                                            string =
                                                                                                                        sprintf!("{}.{}",
                                                                                                                                 v1170.clone(),
                                                                                                                                 string("epub"));
                                                                                                                    let _v1445:
                                                                                                                            MutCell<Option<bool>> =
                                                                                                                        MutCell::new(None::<bool>);
                                                                                                                    let v1447:
                                                                                                                            string =
                                                                                                                        Documents::method13(v1443.clone());
                                                                                                                    let v1449:
                                                                                                                            &str =
                                                                                                                        fable_library_rust::String_::LrcStr::as_str(&v1447);
                                                                                                                    let v1451:
                                                                                                                            std::string::String =
                                                                                                                        String::from(v1449);
                                                                                                                    let v1453:
                                                                                                                            std::path::PathBuf =
                                                                                                                        std::path::PathBuf::from(v1451);
                                                                                                                    {
                                                                                                                        let x_33:
                                                                                                                                bool =
                                                                                                                            if v1453.clone().exists()
                                                                                                                               {
                                                                                                                                v1453.is_file()
                                                                                                                            } else {
                                                                                                                                false
                                                                                                                            };
                                                                                                                        _v1445.set(Some(x_33))
                                                                                                                    }
                                                                                                                    {
                                                                                                                        let v2215:
                                                                                                                                Documents::US17 =
                                                                                                                            if (if if getValue(_v1445.get().clone())
                                                                                                                                      {
                                                                                                                                       let _v1468:
                                                                                                                                               MutCell<Option<bool>> =
                                                                                                                                           MutCell::new(None::<bool>);
                                                                                                                                       let v1470:
                                                                                                                                               string =
                                                                                                                                           Documents::method13(v1444.clone());
                                                                                                                                       let v1472:
                                                                                                                                               &str =
                                                                                                                                           fable_library_rust::String_::LrcStr::as_str(&v1470);
                                                                                                                                       let v1474:
                                                                                                                                               std::string::String =
                                                                                                                                           String::from(v1472);
                                                                                                                                       let v1476:
                                                                                                                                               std::path::PathBuf =
                                                                                                                                           std::path::PathBuf::from(v1474);
                                                                                                                                       {
                                                                                                                                           let x_34:
                                                                                                                                                   bool =
                                                                                                                                               if v1476.clone().exists()
                                                                                                                                                  {
                                                                                                                                                   v1476.is_file()
                                                                                                                                               } else {
                                                                                                                                                   false
                                                                                                                                               };
                                                                                                                                           _v1468.set(Some(x_34))
                                                                                                                                       }
                                                                                                                                       getValue(_v1468.get().clone())
                                                                                                                                   } else {
                                                                                                                                       false
                                                                                                                                   }
                                                                                                                                   {
                                                                                                                                    let _v1492:
                                                                                                                                            MutCell<Option<bool>> =
                                                                                                                                        MutCell::new(None::<bool>);
                                                                                                                                    {
                                                                                                                                        let x_35:
                                                                                                                                                bool =
                                                                                                                                            cfg!(windows);
                                                                                                                                        _v1492.set(Some(x_35))
                                                                                                                                    }
                                                                                                                                    {
                                                                                                                                        let v1526:
                                                                                                                                                Option<CancellationToken> =
                                                                                                                                            None::<CancellationToken>;
                                                                                                                                        let v1527 =
                                                                                                                                            None::<Func1<(bool,
                                                                                                                                                          string,
                                                                                                                                                          i32),
                                                                                                                                                         Arc<Async<()>>>>;
                                                                                                                                        let v1528:
                                                                                                                                                Option<string> =
                                                                                                                                            None::<string>;
                                                                                                                                        let v1529:
                                                                                                                                                string =
                                                                                                                                            sprintf!("pwsh -c \"(Get-FileHash \\\"{}\\\" -Algorithm SHA256).Hash\"",
                                                                                                                                                     if getValue(_v1492.get().clone())
                                                                                                                                                            ==
                                                                                                                                                            false
                                                                                                                                                        {
                                                                                                                                                         v1443.clone()
                                                                                                                                                     } else {
                                                                                                                                                         let _v1505:
                                                                                                                                                                 MutCell<Option<string>> =
                                                                                                                                                             MutCell::new(None::<string>);
                                                                                                                                                         let v1507:
                                                                                                                                                                 string =
                                                                                                                                                             Documents::method16();
                                                                                                                                                         let v1508:
                                                                                                                                                                 string =
                                                                                                                                                             Documents::method17(v1443.clone());
                                                                                                                                                         let v1509:
                                                                                                                                                                 string =
                                                                                                                                                             Documents::method18();
                                                                                                                                                         let v1511:
                                                                                                                                                                 &str =
                                                                                                                                                             &regex::Regex::new(&v1507).unwrap().replace_all(&v1508, &*v1509);
                                                                                                                                                         let v1513:
                                                                                                                                                                 std::string::String =
                                                                                                                                                             String::from(v1511);
                                                                                                                                                         {
                                                                                                                                                             let x_36:
                                                                                                                                                                     string =
                                                                                                                                                                 fable_library_rust::String_::fromString(v1513);
                                                                                                                                                             _v1505.set(Some(x_36))
                                                                                                                                                         }
                                                                                                                                                         {
                                                                                                                                                             let v1522:
                                                                                                                                                                     string =
                                                                                                                                                                 getValue(_v1505.get().clone());
                                                                                                                                                             replace(sprintf!("{}{}",
                                                                                                                                                                              toLower(ofChar(getCharAt(v1522.clone(),
                                                                                                                                                                                                       0_i32))),
                                                                                                                                                                              getSlice(v1522,
                                                                                                                                                                                       Some(1_i32),
                                                                                                                                                                                       None::<i32>)),
                                                                                                                                                                     string("\\"),
                                                                                                                                                                     string("/"))
                                                                                                                                                         }
                                                                                                                                                     });
                                                                                                                                        let _v1530:
                                                                                                                                                MutCell<Option<(i32,
                                                                                                                                                                string)>> =
                                                                                                                                            MutCell::new(None::<(i32,
                                                                                                                                                                 string)>);
                                                                                                                                        let patternInput_15:
                                                                                                                                                (string,
                                                                                                                                                 string) =
                                                                                                                                            Documents::method32();
                                                                                                                                        let v1534:
                                                                                                                                                i32 =
                                                                                                                                            length(v1529.clone());
                                                                                                                                        let v1535:
                                                                                                                                                Array<char> =
                                                                                                                                            new_init(&'\u{0000}',
                                                                                                                                                     v1534);
                                                                                                                                        let v1536:
                                                                                                                                                LrcPtr<Documents::Mut5> =
                                                                                                                                            LrcPtr::new(Documents::Mut5{l0:
                                                                                                                                                                            MutCell::new(0_i32),});
                                                                                                                                        while Documents::method20(v1534,
                                                                                                                                                                  v1536.clone())
                                                                                                                                              {
                                                                                                                                            let v1538:
                                                                                                                                                    i32 =
                                                                                                                                                v1536.l0.get().clone();
                                                                                                                                            let v1539:
                                                                                                                                                    char =
                                                                                                                                                getCharAt(v1529.clone(),
                                                                                                                                                          v1538);
                                                                                                                                            v1535.get_mut()[v1538
                                                                                                                                                                as
                                                                                                                                                                usize]
                                                                                                                                                =
                                                                                                                                                v1539;
                                                                                                                                            {
                                                                                                                                                let v1540:
                                                                                                                                                        i32 =
                                                                                                                                                    v1538
                                                                                                                                                        +
                                                                                                                                                        1_i32;
                                                                                                                                                v1536.l0.set(v1540);
                                                                                                                                                ()
                                                                                                                                            }
                                                                                                                                        }
                                                                                                                                        {
                                                                                                                                            let v1542:
                                                                                                                                                    List<char> =
                                                                                                                                                ofArray(v1535.clone());
                                                                                                                                            let patternInput_16:
                                                                                                                                                    (string,
                                                                                                                                                     string) =
                                                                                                                                                Documents::method34(patternInput_15.1.clone(),
                                                                                                                                                                    patternInput_15.0.clone(),
                                                                                                                                                                    foldBack(Func2::new(move
                                                                                                                                                                                            |b0:
                                                                                                                                                                                                 char,
                                                                                                                                                                                             b1:
                                                                                                                                                                                                 LrcPtr<Documents::UH0>|
                                                                                                                                                                                            (Documents::method33())(b0)(b1)),
                                                                                                                                                                             v1542,
                                                                                                                                                                             LrcPtr::new(Documents::UH0::UH0_0)),
                                                                                                                                                                    Documents::US8::US8_0);
                                                                                                                                            let v1550:
                                                                                                                                                    string =
                                                                                                                                                patternInput_16.0.clone();
                                                                                                                                            let v1552:
                                                                                                                                                    Array<string> =
                                                                                                                                                Documents::method35(patternInput_16.1.clone());
                                                                                                                                            let v1554:
                                                                                                                                                    Vec<string> =
                                                                                                                                                v1552.to_vec();
                                                                                                                                            let v1556:
                                                                                                                                                    Vec<std::string::String> =
                                                                                                                                                v1554.iter().map(|x| Func1::from(v381)(x.clone())).collect();
                                                                                                                                            Documents::method3(Documents::US0::US0_1,
                                                                                                                                                               Func0::new({
                                                                                                                                                                              let v1526
                                                                                                                                                                                  =
                                                                                                                                                                                  v1526.clone();
                                                                                                                                                                              let v1527
                                                                                                                                                                                  =
                                                                                                                                                                                  v1527.clone();
                                                                                                                                                                              let v1528
                                                                                                                                                                                  =
                                                                                                                                                                                  v1528.clone();
                                                                                                                                                                              let v1529
                                                                                                                                                                                  =
                                                                                                                                                                                  v1529.clone();
                                                                                                                                                                              let v1550
                                                                                                                                                                                  =
                                                                                                                                                                                  v1550.clone();
                                                                                                                                                                              let v1556
                                                                                                                                                                                  =
                                                                                                                                                                                  v1556.clone();
                                                                                                                                                                              move
                                                                                                                                                                                  ||
                                                                                                                                                                                  Documents::closure28(v1526.clone(),
                                                                                                                                                                                                       v1529.clone(),
                                                                                                                                                                                                       v1527.clone(),
                                                                                                                                                                                                       v1528.clone(),
                                                                                                                                                                                                       v1550.clone(),
                                                                                                                                                                                                       v1556.clone(),
                                                                                                                                                                                                       ())
                                                                                                                                                                          }),
                                                                                                                                                               Documents::method41());
                                                                                                                                            {
                                                                                                                                                let v1560:
                                                                                                                                                        std::pin::Pin<Box<dyn std::future::Future<Output = LrcPtr<(i32,
                                                                                                                                                                                                                   string)>>>> =
                                                                                                                                                    Documents::method42(v1526.clone(),
                                                                                                                                                                        v1529.clone(),
                                                                                                                                                                        v1527.clone(),
                                                                                                                                                                        v1528.clone(),
                                                                                                                                                                        v1550.clone(),
                                                                                                                                                                        v1556.clone());
                                                                                                                                                let v1562:
                                                                                                                                                        LrcPtr<(i32,
                                                                                                                                                                string)> =
                                                                                                                                                    futures_lite::future::block_on(v1560);
                                                                                                                                                _v1530.set(Some((v1562.0.clone(),
                                                                                                                                                                 v1562.1.clone())));
                                                                                                                                                {
                                                                                                                                                    let patternInput_17:
                                                                                                                                                            (i32,
                                                                                                                                                             string) =
                                                                                                                                                        getValue(_v1530.get().clone());
                                                                                                                                                    let _v1736:
                                                                                                                                                            MutCell<Option<bool>> =
                                                                                                                                                        MutCell::new(None::<bool>);
                                                                                                                                                    {
                                                                                                                                                        let x_38:
                                                                                                                                                                bool =
                                                                                                                                                            cfg!(windows);
                                                                                                                                                        _v1736.set(Some(x_38))
                                                                                                                                                    }
                                                                                                                                                    {
                                                                                                                                                        let v1770:
                                                                                                                                                                Option<CancellationToken> =
                                                                                                                                                            None::<CancellationToken>;
                                                                                                                                                        let v1771 =
                                                                                                                                                            None::<Func1<(bool,
                                                                                                                                                                          string,
                                                                                                                                                                          i32),
                                                                                                                                                                         Arc<Async<()>>>>;
                                                                                                                                                        let v1772:
                                                                                                                                                                Option<string> =
                                                                                                                                                            None::<string>;
                                                                                                                                                        let v1773:
                                                                                                                                                                string =
                                                                                                                                                            sprintf!("pwsh -c \"(Get-FileHash \\\"{}\\\" -Algorithm SHA256).Hash\"",
                                                                                                                                                                     if getValue(_v1736.get().clone())
                                                                                                                                                                            ==
                                                                                                                                                                            false
                                                                                                                                                                        {
                                                                                                                                                                         v1444.clone()
                                                                                                                                                                     } else {
                                                                                                                                                                         let _v1749:
                                                                                                                                                                                 MutCell<Option<string>> =
                                                                                                                                                                             MutCell::new(None::<string>);
                                                                                                                                                                         let v1751:
                                                                                                                                                                                 string =
                                                                                                                                                                             Documents::method16();
                                                                                                                                                                         let v1752:
                                                                                                                                                                                 string =
                                                                                                                                                                             Documents::method17(v1444.clone());
                                                                                                                                                                         let v1753:
                                                                                                                                                                                 string =
                                                                                                                                                                             Documents::method18();
                                                                                                                                                                         let v1755:
                                                                                                                                                                                 &str =
                                                                                                                                                                             &regex::Regex::new(&v1751).unwrap().replace_all(&v1752, &*v1753);
                                                                                                                                                                         let v1757:
                                                                                                                                                                                 std::string::String =
                                                                                                                                                                             String::from(v1755);
                                                                                                                                                                         {
                                                                                                                                                                             let x_39:
                                                                                                                                                                                     string =
                                                                                                                                                                                 fable_library_rust::String_::fromString(v1757);
                                                                                                                                                                             _v1749.set(Some(x_39))
                                                                                                                                                                         }
                                                                                                                                                                         {
                                                                                                                                                                             let v1766:
                                                                                                                                                                                     string =
                                                                                                                                                                                 getValue(_v1749.get().clone());
                                                                                                                                                                             replace(sprintf!("{}{}",
                                                                                                                                                                                              toLower(ofChar(getCharAt(v1766.clone(),
                                                                                                                                                                                                                       0_i32))),
                                                                                                                                                                                              getSlice(v1766,
                                                                                                                                                                                                       Some(1_i32),
                                                                                                                                                                                                       None::<i32>)),
                                                                                                                                                                                     string("\\"),
                                                                                                                                                                                     string("/"))
                                                                                                                                                                         }
                                                                                                                                                                     });
                                                                                                                                                        let _v1774:
                                                                                                                                                                MutCell<Option<(i32,
                                                                                                                                                                                string)>> =
                                                                                                                                                            MutCell::new(None::<(i32,
                                                                                                                                                                                 string)>);
                                                                                                                                                        let patternInput_18:
                                                                                                                                                                (string,
                                                                                                                                                                 string) =
                                                                                                                                                            Documents::method32();
                                                                                                                                                        let v1778:
                                                                                                                                                                i32 =
                                                                                                                                                            length(v1773.clone());
                                                                                                                                                        let v1779:
                                                                                                                                                                Array<char> =
                                                                                                                                                            new_init(&'\u{0000}',
                                                                                                                                                                     v1778);
                                                                                                                                                        let v1780:
                                                                                                                                                                LrcPtr<Documents::Mut5> =
                                                                                                                                                            LrcPtr::new(Documents::Mut5{l0:
                                                                                                                                                                                            MutCell::new(0_i32),});
                                                                                                                                                        while Documents::method20(v1778,
                                                                                                                                                                                  v1780.clone())
                                                                                                                                                              {
                                                                                                                                                            let v1782:
                                                                                                                                                                    i32 =
                                                                                                                                                                v1780.l0.get().clone();
                                                                                                                                                            let v1783:
                                                                                                                                                                    char =
                                                                                                                                                                getCharAt(v1773.clone(),
                                                                                                                                                                          v1782);
                                                                                                                                                            v1779.get_mut()[v1782
                                                                                                                                                                                as
                                                                                                                                                                                usize]
                                                                                                                                                                =
                                                                                                                                                                v1783;
                                                                                                                                                            {
                                                                                                                                                                let v1784:
                                                                                                                                                                        i32 =
                                                                                                                                                                    v1782
                                                                                                                                                                        +
                                                                                                                                                                        1_i32;
                                                                                                                                                                v1780.l0.set(v1784);
                                                                                                                                                                ()
                                                                                                                                                            }
                                                                                                                                                        }
                                                                                                                                                        {
                                                                                                                                                            let v1786:
                                                                                                                                                                    List<char> =
                                                                                                                                                                ofArray(v1779.clone());
                                                                                                                                                            let patternInput_19:
                                                                                                                                                                    (string,
                                                                                                                                                                     string) =
                                                                                                                                                                Documents::method34(patternInput_18.1.clone(),
                                                                                                                                                                                    patternInput_18.0.clone(),
                                                                                                                                                                                    foldBack(Func2::new(move
                                                                                                                                                                                                            |b0:
                                                                                                                                                                                                                 char,
                                                                                                                                                                                                             b1:
                                                                                                                                                                                                                 LrcPtr<Documents::UH0>|
                                                                                                                                                                                                            (Documents::method33())(b0)(b1)),
                                                                                                                                                                                             v1786,
                                                                                                                                                                                             LrcPtr::new(Documents::UH0::UH0_0)),
                                                                                                                                                                                    Documents::US8::US8_0);
                                                                                                                                                            let v1794:
                                                                                                                                                                    string =
                                                                                                                                                                patternInput_19.0.clone();
                                                                                                                                                            let v1796:
                                                                                                                                                                    Array<string> =
                                                                                                                                                                Documents::method35(patternInput_19.1.clone());
                                                                                                                                                            let v1798:
                                                                                                                                                                    Vec<string> =
                                                                                                                                                                v1796.to_vec();
                                                                                                                                                            let v1800:
                                                                                                                                                                    Vec<std::string::String> =
                                                                                                                                                                v1798.iter().map(|x| Func1::from(v381)(x.clone())).collect();
                                                                                                                                                            Documents::method3(Documents::US0::US0_1,
                                                                                                                                                                               Func0::new({
                                                                                                                                                                                              let v1770
                                                                                                                                                                                                  =
                                                                                                                                                                                                  v1770.clone();
                                                                                                                                                                                              let v1771
                                                                                                                                                                                                  =
                                                                                                                                                                                                  v1771.clone();
                                                                                                                                                                                              let v1772
                                                                                                                                                                                                  =
                                                                                                                                                                                                  v1772.clone();
                                                                                                                                                                                              let v1773
                                                                                                                                                                                                  =
                                                                                                                                                                                                  v1773.clone();
                                                                                                                                                                                              let v1794
                                                                                                                                                                                                  =
                                                                                                                                                                                                  v1794.clone();
                                                                                                                                                                                              let v1800
                                                                                                                                                                                                  =
                                                                                                                                                                                                  v1800.clone();
                                                                                                                                                                                              move
                                                                                                                                                                                                  ||
                                                                                                                                                                                                  Documents::closure28(v1770.clone(),
                                                                                                                                                                                                                       v1773.clone(),
                                                                                                                                                                                                                       v1771.clone(),
                                                                                                                                                                                                                       v1772.clone(),
                                                                                                                                                                                                                       v1794.clone(),
                                                                                                                                                                                                                       v1800.clone(),
                                                                                                                                                                                                                       ())
                                                                                                                                                                                          }),
                                                                                                                                                                               Documents::method41());
                                                                                                                                                            {
                                                                                                                                                                let v1804:
                                                                                                                                                                        std::pin::Pin<Box<dyn std::future::Future<Output = LrcPtr<(i32,
                                                                                                                                                                                                                                   string)>>>> =
                                                                                                                                                                    Documents::method42(v1770.clone(),
                                                                                                                                                                                        v1773.clone(),
                                                                                                                                                                                        v1771.clone(),
                                                                                                                                                                                        v1772.clone(),
                                                                                                                                                                                        v1794.clone(),
                                                                                                                                                                                        v1800.clone());
                                                                                                                                                                let v1806:
                                                                                                                                                                        LrcPtr<(i32,
                                                                                                                                                                                string)> =
                                                                                                                                                                    futures_lite::future::block_on(v1804);
                                                                                                                                                                _v1774.set(Some((v1806.0.clone(),
                                                                                                                                                                                 v1806.1.clone())));
                                                                                                                                                                patternInput_17.1.clone()
                                                                                                                                                                    ==
                                                                                                                                                                    (getValue(_v1774.get().clone())).1.clone()
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
                                                                                                                                let v1983:
                                                                                                                                        string =
                                                                                                                                    sprintf!("crowbook --single \"{}\" --output \"{}\" --to {} --set rendering.num_depth 6 html.css.add \\\"\'\'\' body {{ color: #e8e6e3; background-color: #202324; }} a {{ color: #989693; }} \'\'\'\\\"",
                                                                                                                                             v637.clone(),
                                                                                                                                             v1443.clone(),
                                                                                                                                             string("epub"));
                                                                                                                                let v1984:
                                                                                                                                        Option<CancellationToken> =
                                                                                                                                    None::<CancellationToken>;
                                                                                                                                let v1985 =
                                                                                                                                    None::<Func1<(bool,
                                                                                                                                                  string,
                                                                                                                                                  i32),
                                                                                                                                                 Arc<Async<()>>>>;
                                                                                                                                let v1987:
                                                                                                                                        Option<string> =
                                                                                                                                    Some(v1_1.clone());
                                                                                                                                let _v1988:
                                                                                                                                        MutCell<Option<(i32,
                                                                                                                                                        string)>> =
                                                                                                                                    MutCell::new(None::<(i32,
                                                                                                                                                         string)>);
                                                                                                                                let patternInput_21:
                                                                                                                                        (string,
                                                                                                                                         string) =
                                                                                                                                    Documents::method32();
                                                                                                                                let v1992:
                                                                                                                                        i32 =
                                                                                                                                    length(v1983.clone());
                                                                                                                                let v1993:
                                                                                                                                        Array<char> =
                                                                                                                                    new_init(&'\u{0000}',
                                                                                                                                             v1992);
                                                                                                                                let v1994:
                                                                                                                                        LrcPtr<Documents::Mut5> =
                                                                                                                                    LrcPtr::new(Documents::Mut5{l0:
                                                                                                                                                                    MutCell::new(0_i32),});
                                                                                                                                while Documents::method20(v1992,
                                                                                                                                                          v1994.clone())
                                                                                                                                      {
                                                                                                                                    let v1996:
                                                                                                                                            i32 =
                                                                                                                                        v1994.l0.get().clone();
                                                                                                                                    let v1997:
                                                                                                                                            char =
                                                                                                                                        getCharAt(v1983.clone(),
                                                                                                                                                  v1996);
                                                                                                                                    v1993.get_mut()[v1996
                                                                                                                                                        as
                                                                                                                                                        usize]
                                                                                                                                        =
                                                                                                                                        v1997;
                                                                                                                                    {
                                                                                                                                        let v1998:
                                                                                                                                                i32 =
                                                                                                                                            v1996
                                                                                                                                                +
                                                                                                                                                1_i32;
                                                                                                                                        v1994.l0.set(v1998);
                                                                                                                                        ()
                                                                                                                                    }
                                                                                                                                }
                                                                                                                                {
                                                                                                                                    let v2000:
                                                                                                                                            List<char> =
                                                                                                                                        ofArray(v1993.clone());
                                                                                                                                    let patternInput_22:
                                                                                                                                            (string,
                                                                                                                                             string) =
                                                                                                                                        Documents::method34(patternInput_21.1.clone(),
                                                                                                                                                            patternInput_21.0.clone(),
                                                                                                                                                            foldBack(Func2::new(move
                                                                                                                                                                                    |b0:
                                                                                                                                                                                         char,
                                                                                                                                                                                     b1:
                                                                                                                                                                                         LrcPtr<Documents::UH0>|
                                                                                                                                                                                    (Documents::method33())(b0)(b1)),
                                                                                                                                                                     v2000,
                                                                                                                                                                     LrcPtr::new(Documents::UH0::UH0_0)),
                                                                                                                                                            Documents::US8::US8_0);
                                                                                                                                    let v2008:
                                                                                                                                            string =
                                                                                                                                        patternInput_22.0.clone();
                                                                                                                                    let v2010:
                                                                                                                                            Array<string> =
                                                                                                                                        Documents::method35(patternInput_22.1.clone());
                                                                                                                                    let v2012:
                                                                                                                                            Vec<string> =
                                                                                                                                        v2010.to_vec();
                                                                                                                                    let v2014:
                                                                                                                                            Vec<std::string::String> =
                                                                                                                                        v2012.iter().map(|x| Func1::from(v381)(x.clone())).collect();
                                                                                                                                    Documents::method3(Documents::US0::US0_1,
                                                                                                                                                       Func0::new({
                                                                                                                                                                      let v1983
                                                                                                                                                                          =
                                                                                                                                                                          v1983.clone();
                                                                                                                                                                      let v1984
                                                                                                                                                                          =
                                                                                                                                                                          v1984.clone();
                                                                                                                                                                      let v1985
                                                                                                                                                                          =
                                                                                                                                                                          v1985.clone();
                                                                                                                                                                      let v1987
                                                                                                                                                                          =
                                                                                                                                                                          v1987.clone();
                                                                                                                                                                      let v2008
                                                                                                                                                                          =
                                                                                                                                                                          v2008.clone();
                                                                                                                                                                      let v2014
                                                                                                                                                                          =
                                                                                                                                                                          v2014.clone();
                                                                                                                                                                      move
                                                                                                                                                                          ||
                                                                                                                                                                          Documents::closure28(v1984.clone(),
                                                                                                                                                                                               v1983.clone(),
                                                                                                                                                                                               v1985.clone(),
                                                                                                                                                                                               v1987.clone(),
                                                                                                                                                                                               v2008.clone(),
                                                                                                                                                                                               v2014.clone(),
                                                                                                                                                                                               ())
                                                                                                                                                                  }),
                                                                                                                                                       Documents::method41());
                                                                                                                                    {
                                                                                                                                        let v2018:
                                                                                                                                                std::pin::Pin<Box<dyn std::future::Future<Output = LrcPtr<(i32,
                                                                                                                                                                                                           string)>>>> =
                                                                                                                                            Documents::method42(v1984.clone(),
                                                                                                                                                                v1983.clone(),
                                                                                                                                                                v1985.clone(),
                                                                                                                                                                v1987.clone(),
                                                                                                                                                                v2008.clone(),
                                                                                                                                                                v2014.clone());
                                                                                                                                        let v2020:
                                                                                                                                                LrcPtr<(i32,
                                                                                                                                                        string)> =
                                                                                                                                            futures_lite::future::block_on(v2018);
                                                                                                                                        _v1988.set(Some((v2020.0.clone(),
                                                                                                                                                         v2020.1.clone())));
                                                                                                                                        {
                                                                                                                                            let patternInput_23:
                                                                                                                                                    (i32,
                                                                                                                                                     string) =
                                                                                                                                                getValue(_v1988.get().clone());
                                                                                                                                            let v2193:
                                                                                                                                                    string =
                                                                                                                                                patternInput_23.1.clone();
                                                                                                                                            let v2192:
                                                                                                                                                    i32 =
                                                                                                                                                patternInput_23.0.clone();
                                                                                                                                            if if v2192
                                                                                                                                                      !=
                                                                                                                                                      0_i32
                                                                                                                                                  {
                                                                                                                                                   true
                                                                                                                                               } else {
                                                                                                                                                   contains(v2193.clone(),
                                                                                                                                                            string("ERROR"))
                                                                                                                                               }
                                                                                                                                               {
                                                                                                                                                Documents::method3(Documents::US0::US0_2,
                                                                                                                                                                   Func0::new(move
                                                                                                                                                                                  ||
                                                                                                                                                                                  Documents::closure53((),
                                                                                                                                                                                                       ())),
                                                                                                                                                                   Func0::new({
                                                                                                                                                                                  let v2192
                                                                                                                                                                                      =
                                                                                                                                                                                      v2192.clone();
                                                                                                                                                                                  let v2193
                                                                                                                                                                                      =
                                                                                                                                                                                      v2193.clone();
                                                                                                                                                                                  move
                                                                                                                                                                                      ||
                                                                                                                                                                                      Documents::closure54(v2193.clone(),
                                                                                                                                                                                                           v2192,
                                                                                                                                                                                                           ())
                                                                                                                                                                              }));
                                                                                                                                                Documents::US17::US17_0(Err::<string,
                                                                                                                                                                              LrcPtr<(string,
                                                                                                                                                                                      string)>>(LrcPtr::new((v1443.clone(),
                                                                                                                                                                                                             v2193.clone()))))
                                                                                                                                            } else {
                                                                                                                                                let _v2204:
                                                                                                                                                        MutCell<Option<()>> =
                                                                                                                                                    MutCell::new(None::<()>);
                                                                                                                                                let v2206:
                                                                                                                                                        string =
                                                                                                                                                    Documents::method61(v1444);
                                                                                                                                                let v2208:
                                                                                                                                                        Result<u64,
                                                                                                                                                               std::io::Error> =
                                                                                                                                                    std::fs::copy(&*v1443, &*v2206);
                                                                                                                                                let v2210:
                                                                                                                                                        u64 =
                                                                                                                                                    v2208.unwrap();
                                                                                                                                                _v2204.set(Some(()));
                                                                                                                                                getValue(_v2204.get().clone());
                                                                                                                                                Documents::US17::US17_0(Ok::<string,
                                                                                                                                                                             LrcPtr<(string,
                                                                                                                                                                                     string)>>(v1443))
                                                                                                                                            }
                                                                                                                                        }
                                                                                                                                    }
                                                                                                                                }
                                                                                                                            } else {
                                                                                                                                Documents::US17::US17_1
                                                                                                                            };
                                                                                                                        let v2220:
                                                                                                                                Option<Result<string,
                                                                                                                                              LrcPtr<(string,
                                                                                                                                                      string)>>> =
                                                                                                                            match &v2215
                                                                                                                                {
                                                                                                                                Documents::US17::US17_0(v2215_0_0)
                                                                                                                                =>
                                                                                                                                Some(match &v2215
                                                                                                                                         {
                                                                                                                                         Documents::US17::US17_0(x)
                                                                                                                                         =>
                                                                                                                                         x.clone(),
                                                                                                                                         _
                                                                                                                                         =>
                                                                                                                                         unreachable!(),
                                                                                                                                     }),
                                                                                                                                _
                                                                                                                                =>
                                                                                                                                None::<Result<string,
                                                                                                                                              LrcPtr<(string,
                                                                                                                                                      string)>>>,
                                                                                                                            };
                                                                                                                        let v2222:
                                                                                                                                string =
                                                                                                                            sprintf!("{}.{}",
                                                                                                                                     v637.clone(),
                                                                                                                                     string("pdf"));
                                                                                                                        let v2223:
                                                                                                                                string =
                                                                                                                            sprintf!("{}.{}",
                                                                                                                                     v1170.clone(),
                                                                                                                                     string("pdf"));
                                                                                                                        let _v2224:
                                                                                                                                MutCell<Option<bool>> =
                                                                                                                            MutCell::new(None::<bool>);
                                                                                                                        let v2226:
                                                                                                                                string =
                                                                                                                            Documents::method13(v2222.clone());
                                                                                                                        let v2228:
                                                                                                                                &str =
                                                                                                                            fable_library_rust::String_::LrcStr::as_str(&v2226);
                                                                                                                        let v2230:
                                                                                                                                std::string::String =
                                                                                                                            String::from(v2228);
                                                                                                                        let v2232:
                                                                                                                                std::path::PathBuf =
                                                                                                                            std::path::PathBuf::from(v2230);
                                                                                                                        {
                                                                                                                            let x_43:
                                                                                                                                    bool =
                                                                                                                                if v2232.clone().exists()
                                                                                                                                   {
                                                                                                                                    v2232.is_file()
                                                                                                                                } else {
                                                                                                                                    false
                                                                                                                                };
                                                                                                                            _v2224.set(Some(x_43))
                                                                                                                        }
                                                                                                                        {
                                                                                                                            let v2994:
                                                                                                                                    Documents::US17 =
                                                                                                                                if (if if getValue(_v2224.get().clone())
                                                                                                                                          {
                                                                                                                                           let _v2247:
                                                                                                                                                   MutCell<Option<bool>> =
                                                                                                                                               MutCell::new(None::<bool>);
                                                                                                                                           let v2249:
                                                                                                                                                   string =
                                                                                                                                               Documents::method13(v2223.clone());
                                                                                                                                           let v2251:
                                                                                                                                                   &str =
                                                                                                                                               fable_library_rust::String_::LrcStr::as_str(&v2249);
                                                                                                                                           let v2253:
                                                                                                                                                   std::string::String =
                                                                                                                                               String::from(v2251);
                                                                                                                                           let v2255:
                                                                                                                                                   std::path::PathBuf =
                                                                                                                                               std::path::PathBuf::from(v2253);
                                                                                                                                           {
                                                                                                                                               let x_44:
                                                                                                                                                       bool =
                                                                                                                                                   if v2255.clone().exists()
                                                                                                                                                      {
                                                                                                                                                       v2255.is_file()
                                                                                                                                                   } else {
                                                                                                                                                       false
                                                                                                                                                   };
                                                                                                                                               _v2247.set(Some(x_44))
                                                                                                                                           }
                                                                                                                                           getValue(_v2247.get().clone())
                                                                                                                                       } else {
                                                                                                                                           false
                                                                                                                                       }
                                                                                                                                       {
                                                                                                                                        let _v2271:
                                                                                                                                                MutCell<Option<bool>> =
                                                                                                                                            MutCell::new(None::<bool>);
                                                                                                                                        {
                                                                                                                                            let x_45:
                                                                                                                                                    bool =
                                                                                                                                                cfg!(windows);
                                                                                                                                            _v2271.set(Some(x_45))
                                                                                                                                        }
                                                                                                                                        {
                                                                                                                                            let v2305:
                                                                                                                                                    Option<CancellationToken> =
                                                                                                                                                None::<CancellationToken>;
                                                                                                                                            let v2306 =
                                                                                                                                                None::<Func1<(bool,
                                                                                                                                                              string,
                                                                                                                                                              i32),
                                                                                                                                                             Arc<Async<()>>>>;
                                                                                                                                            let v2307:
                                                                                                                                                    Option<string> =
                                                                                                                                                None::<string>;
                                                                                                                                            let v2308:
                                                                                                                                                    string =
                                                                                                                                                sprintf!("pwsh -c \"(Get-FileHash \\\"{}\\\" -Algorithm SHA256).Hash\"",
                                                                                                                                                         if getValue(_v2271.get().clone())
                                                                                                                                                                ==
                                                                                                                                                                false
                                                                                                                                                            {
                                                                                                                                                             v2222.clone()
                                                                                                                                                         } else {
                                                                                                                                                             let _v2284:
                                                                                                                                                                     MutCell<Option<string>> =
                                                                                                                                                                 MutCell::new(None::<string>);
                                                                                                                                                             let v2286:
                                                                                                                                                                     string =
                                                                                                                                                                 Documents::method16();
                                                                                                                                                             let v2287:
                                                                                                                                                                     string =
                                                                                                                                                                 Documents::method17(v2222.clone());
                                                                                                                                                             let v2288:
                                                                                                                                                                     string =
                                                                                                                                                                 Documents::method18();
                                                                                                                                                             let v2290:
                                                                                                                                                                     &str =
                                                                                                                                                                 &regex::Regex::new(&v2286).unwrap().replace_all(&v2287, &*v2288);
                                                                                                                                                             let v2292:
                                                                                                                                                                     std::string::String =
                                                                                                                                                                 String::from(v2290);
                                                                                                                                                             {
                                                                                                                                                                 let x_46:
                                                                                                                                                                         string =
                                                                                                                                                                     fable_library_rust::String_::fromString(v2292);
                                                                                                                                                                 _v2284.set(Some(x_46))
                                                                                                                                                             }
                                                                                                                                                             {
                                                                                                                                                                 let v2301:
                                                                                                                                                                         string =
                                                                                                                                                                     getValue(_v2284.get().clone());
                                                                                                                                                                 replace(sprintf!("{}{}",
                                                                                                                                                                                  toLower(ofChar(getCharAt(v2301.clone(),
                                                                                                                                                                                                           0_i32))),
                                                                                                                                                                                  getSlice(v2301,
                                                                                                                                                                                           Some(1_i32),
                                                                                                                                                                                           None::<i32>)),
                                                                                                                                                                         string("\\"),
                                                                                                                                                                         string("/"))
                                                                                                                                                             }
                                                                                                                                                         });
                                                                                                                                            let _v2309:
                                                                                                                                                    MutCell<Option<(i32,
                                                                                                                                                                    string)>> =
                                                                                                                                                MutCell::new(None::<(i32,
                                                                                                                                                                     string)>);
                                                                                                                                            let patternInput_24:
                                                                                                                                                    (string,
                                                                                                                                                     string) =
                                                                                                                                                Documents::method32();
                                                                                                                                            let v2313:
                                                                                                                                                    i32 =
                                                                                                                                                length(v2308.clone());
                                                                                                                                            let v2314:
                                                                                                                                                    Array<char> =
                                                                                                                                                new_init(&'\u{0000}',
                                                                                                                                                         v2313);
                                                                                                                                            let v2315:
                                                                                                                                                    LrcPtr<Documents::Mut5> =
                                                                                                                                                LrcPtr::new(Documents::Mut5{l0:
                                                                                                                                                                                MutCell::new(0_i32),});
                                                                                                                                            while Documents::method20(v2313,
                                                                                                                                                                      v2315.clone())
                                                                                                                                                  {
                                                                                                                                                let v2317:
                                                                                                                                                        i32 =
                                                                                                                                                    v2315.l0.get().clone();
                                                                                                                                                let v2318:
                                                                                                                                                        char =
                                                                                                                                                    getCharAt(v2308.clone(),
                                                                                                                                                              v2317);
                                                                                                                                                v2314.get_mut()[v2317
                                                                                                                                                                    as
                                                                                                                                                                    usize]
                                                                                                                                                    =
                                                                                                                                                    v2318;
                                                                                                                                                {
                                                                                                                                                    let v2319:
                                                                                                                                                            i32 =
                                                                                                                                                        v2317
                                                                                                                                                            +
                                                                                                                                                            1_i32;
                                                                                                                                                    v2315.l0.set(v2319);
                                                                                                                                                    ()
                                                                                                                                                }
                                                                                                                                            }
                                                                                                                                            {
                                                                                                                                                let v2321:
                                                                                                                                                        List<char> =
                                                                                                                                                    ofArray(v2314.clone());
                                                                                                                                                let patternInput_25:
                                                                                                                                                        (string,
                                                                                                                                                         string) =
                                                                                                                                                    Documents::method34(patternInput_24.1.clone(),
                                                                                                                                                                        patternInput_24.0.clone(),
                                                                                                                                                                        foldBack(Func2::new(move
                                                                                                                                                                                                |b0:
                                                                                                                                                                                                     char,
                                                                                                                                                                                                 b1:
                                                                                                                                                                                                     LrcPtr<Documents::UH0>|
                                                                                                                                                                                                (Documents::method33())(b0)(b1)),
                                                                                                                                                                                 v2321,
                                                                                                                                                                                 LrcPtr::new(Documents::UH0::UH0_0)),
                                                                                                                                                                        Documents::US8::US8_0);
                                                                                                                                                let v2329:
                                                                                                                                                        string =
                                                                                                                                                    patternInput_25.0.clone();
                                                                                                                                                let v2331:
                                                                                                                                                        Array<string> =
                                                                                                                                                    Documents::method35(patternInput_25.1.clone());
                                                                                                                                                let v2333:
                                                                                                                                                        Vec<string> =
                                                                                                                                                    v2331.to_vec();
                                                                                                                                                let v2335:
                                                                                                                                                        Vec<std::string::String> =
                                                                                                                                                    v2333.iter().map(|x| Func1::from(v381)(x.clone())).collect();
                                                                                                                                                Documents::method3(Documents::US0::US0_1,
                                                                                                                                                                   Func0::new({
                                                                                                                                                                                  let v2305
                                                                                                                                                                                      =
                                                                                                                                                                                      v2305.clone();
                                                                                                                                                                                  let v2306
                                                                                                                                                                                      =
                                                                                                                                                                                      v2306.clone();
                                                                                                                                                                                  let v2307
                                                                                                                                                                                      =
                                                                                                                                                                                      v2307.clone();
                                                                                                                                                                                  let v2308
                                                                                                                                                                                      =
                                                                                                                                                                                      v2308.clone();
                                                                                                                                                                                  let v2329
                                                                                                                                                                                      =
                                                                                                                                                                                      v2329.clone();
                                                                                                                                                                                  let v2335
                                                                                                                                                                                      =
                                                                                                                                                                                      v2335.clone();
                                                                                                                                                                                  move
                                                                                                                                                                                      ||
                                                                                                                                                                                      Documents::closure28(v2305.clone(),
                                                                                                                                                                                                           v2308.clone(),
                                                                                                                                                                                                           v2306.clone(),
                                                                                                                                                                                                           v2307.clone(),
                                                                                                                                                                                                           v2329.clone(),
                                                                                                                                                                                                           v2335.clone(),
                                                                                                                                                                                                           ())
                                                                                                                                                                              }),
                                                                                                                                                                   Documents::method41());
                                                                                                                                                {
                                                                                                                                                    let v2339:
                                                                                                                                                            std::pin::Pin<Box<dyn std::future::Future<Output = LrcPtr<(i32,
                                                                                                                                                                                                                       string)>>>> =
                                                                                                                                                        Documents::method42(v2305.clone(),
                                                                                                                                                                            v2308.clone(),
                                                                                                                                                                            v2306.clone(),
                                                                                                                                                                            v2307.clone(),
                                                                                                                                                                            v2329.clone(),
                                                                                                                                                                            v2335.clone());
                                                                                                                                                    let v2341:
                                                                                                                                                            LrcPtr<(i32,
                                                                                                                                                                    string)> =
                                                                                                                                                        futures_lite::future::block_on(v2339);
                                                                                                                                                    _v2309.set(Some((v2341.0.clone(),
                                                                                                                                                                     v2341.1.clone())));
                                                                                                                                                    {
                                                                                                                                                        let patternInput_26:
                                                                                                                                                                (i32,
                                                                                                                                                                 string) =
                                                                                                                                                            getValue(_v2309.get().clone());
                                                                                                                                                        let _v2515:
                                                                                                                                                                MutCell<Option<bool>> =
                                                                                                                                                            MutCell::new(None::<bool>);
                                                                                                                                                        {
                                                                                                                                                            let x_48:
                                                                                                                                                                    bool =
                                                                                                                                                                cfg!(windows);
                                                                                                                                                            _v2515.set(Some(x_48))
                                                                                                                                                        }
                                                                                                                                                        {
                                                                                                                                                            let v2549:
                                                                                                                                                                    Option<CancellationToken> =
                                                                                                                                                                None::<CancellationToken>;
                                                                                                                                                            let v2550 =
                                                                                                                                                                None::<Func1<(bool,
                                                                                                                                                                              string,
                                                                                                                                                                              i32),
                                                                                                                                                                             Arc<Async<()>>>>;
                                                                                                                                                            let v2551:
                                                                                                                                                                    Option<string> =
                                                                                                                                                                None::<string>;
                                                                                                                                                            let v2552:
                                                                                                                                                                    string =
                                                                                                                                                                sprintf!("pwsh -c \"(Get-FileHash \\\"{}\\\" -Algorithm SHA256).Hash\"",
                                                                                                                                                                         if getValue(_v2515.get().clone())
                                                                                                                                                                                ==
                                                                                                                                                                                false
                                                                                                                                                                            {
                                                                                                                                                                             v2223.clone()
                                                                                                                                                                         } else {
                                                                                                                                                                             let _v2528:
                                                                                                                                                                                     MutCell<Option<string>> =
                                                                                                                                                                                 MutCell::new(None::<string>);
                                                                                                                                                                             let v2530:
                                                                                                                                                                                     string =
                                                                                                                                                                                 Documents::method16();
                                                                                                                                                                             let v2531:
                                                                                                                                                                                     string =
                                                                                                                                                                                 Documents::method17(v2223.clone());
                                                                                                                                                                             let v2532:
                                                                                                                                                                                     string =
                                                                                                                                                                                 Documents::method18();
                                                                                                                                                                             let v2534:
                                                                                                                                                                                     &str =
                                                                                                                                                                                 &regex::Regex::new(&v2530).unwrap().replace_all(&v2531, &*v2532);
                                                                                                                                                                             let v2536:
                                                                                                                                                                                     std::string::String =
                                                                                                                                                                                 String::from(v2534);
                                                                                                                                                                             {
                                                                                                                                                                                 let x_49:
                                                                                                                                                                                         string =
                                                                                                                                                                                     fable_library_rust::String_::fromString(v2536);
                                                                                                                                                                                 _v2528.set(Some(x_49))
                                                                                                                                                                             }
                                                                                                                                                                             {
                                                                                                                                                                                 let v2545:
                                                                                                                                                                                         string =
                                                                                                                                                                                     getValue(_v2528.get().clone());
                                                                                                                                                                                 replace(sprintf!("{}{}",
                                                                                                                                                                                                  toLower(ofChar(getCharAt(v2545.clone(),
                                                                                                                                                                                                                           0_i32))),
                                                                                                                                                                                                  getSlice(v2545,
                                                                                                                                                                                                           Some(1_i32),
                                                                                                                                                                                                           None::<i32>)),
                                                                                                                                                                                         string("\\"),
                                                                                                                                                                                         string("/"))
                                                                                                                                                                             }
                                                                                                                                                                         });
                                                                                                                                                            let _v2553:
                                                                                                                                                                    MutCell<Option<(i32,
                                                                                                                                                                                    string)>> =
                                                                                                                                                                MutCell::new(None::<(i32,
                                                                                                                                                                                     string)>);
                                                                                                                                                            let patternInput_27:
                                                                                                                                                                    (string,
                                                                                                                                                                     string) =
                                                                                                                                                                Documents::method32();
                                                                                                                                                            let v2557:
                                                                                                                                                                    i32 =
                                                                                                                                                                length(v2552.clone());
                                                                                                                                                            let v2558:
                                                                                                                                                                    Array<char> =
                                                                                                                                                                new_init(&'\u{0000}',
                                                                                                                                                                         v2557);
                                                                                                                                                            let v2559:
                                                                                                                                                                    LrcPtr<Documents::Mut5> =
                                                                                                                                                                LrcPtr::new(Documents::Mut5{l0:
                                                                                                                                                                                                MutCell::new(0_i32),});
                                                                                                                                                            while Documents::method20(v2557,
                                                                                                                                                                                      v2559.clone())
                                                                                                                                                                  {
                                                                                                                                                                let v2561:
                                                                                                                                                                        i32 =
                                                                                                                                                                    v2559.l0.get().clone();
                                                                                                                                                                let v2562:
                                                                                                                                                                        char =
                                                                                                                                                                    getCharAt(v2552.clone(),
                                                                                                                                                                              v2561);
                                                                                                                                                                v2558.get_mut()[v2561
                                                                                                                                                                                    as
                                                                                                                                                                                    usize]
                                                                                                                                                                    =
                                                                                                                                                                    v2562;
                                                                                                                                                                {
                                                                                                                                                                    let v2563:
                                                                                                                                                                            i32 =
                                                                                                                                                                        v2561
                                                                                                                                                                            +
                                                                                                                                                                            1_i32;
                                                                                                                                                                    v2559.l0.set(v2563);
                                                                                                                                                                    ()
                                                                                                                                                                }
                                                                                                                                                            }
                                                                                                                                                            {
                                                                                                                                                                let v2565:
                                                                                                                                                                        List<char> =
                                                                                                                                                                    ofArray(v2558.clone());
                                                                                                                                                                let patternInput_28:
                                                                                                                                                                        (string,
                                                                                                                                                                         string) =
                                                                                                                                                                    Documents::method34(patternInput_27.1.clone(),
                                                                                                                                                                                        patternInput_27.0.clone(),
                                                                                                                                                                                        foldBack(Func2::new(move
                                                                                                                                                                                                                |b0:
                                                                                                                                                                                                                     char,
                                                                                                                                                                                                                 b1:
                                                                                                                                                                                                                     LrcPtr<Documents::UH0>|
                                                                                                                                                                                                                (Documents::method33())(b0)(b1)),
                                                                                                                                                                                                 v2565,
                                                                                                                                                                                                 LrcPtr::new(Documents::UH0::UH0_0)),
                                                                                                                                                                                        Documents::US8::US8_0);
                                                                                                                                                                let v2573:
                                                                                                                                                                        string =
                                                                                                                                                                    patternInput_28.0.clone();
                                                                                                                                                                let v2575:
                                                                                                                                                                        Array<string> =
                                                                                                                                                                    Documents::method35(patternInput_28.1.clone());
                                                                                                                                                                let v2577:
                                                                                                                                                                        Vec<string> =
                                                                                                                                                                    v2575.to_vec();
                                                                                                                                                                let v2579:
                                                                                                                                                                        Vec<std::string::String> =
                                                                                                                                                                    v2577.iter().map(|x| Func1::from(v381)(x.clone())).collect();
                                                                                                                                                                Documents::method3(Documents::US0::US0_1,
                                                                                                                                                                                   Func0::new({
                                                                                                                                                                                                  let v2549
                                                                                                                                                                                                      =
                                                                                                                                                                                                      v2549.clone();
                                                                                                                                                                                                  let v2550
                                                                                                                                                                                                      =
                                                                                                                                                                                                      v2550.clone();
                                                                                                                                                                                                  let v2551
                                                                                                                                                                                                      =
                                                                                                                                                                                                      v2551.clone();
                                                                                                                                                                                                  let v2552
                                                                                                                                                                                                      =
                                                                                                                                                                                                      v2552.clone();
                                                                                                                                                                                                  let v2573
                                                                                                                                                                                                      =
                                                                                                                                                                                                      v2573.clone();
                                                                                                                                                                                                  let v2579
                                                                                                                                                                                                      =
                                                                                                                                                                                                      v2579.clone();
                                                                                                                                                                                                  move
                                                                                                                                                                                                      ||
                                                                                                                                                                                                      Documents::closure28(v2549.clone(),
                                                                                                                                                                                                                           v2552.clone(),
                                                                                                                                                                                                                           v2550.clone(),
                                                                                                                                                                                                                           v2551.clone(),
                                                                                                                                                                                                                           v2573.clone(),
                                                                                                                                                                                                                           v2579.clone(),
                                                                                                                                                                                                                           ())
                                                                                                                                                                                              }),
                                                                                                                                                                                   Documents::method41());
                                                                                                                                                                {
                                                                                                                                                                    let v2583:
                                                                                                                                                                            std::pin::Pin<Box<dyn std::future::Future<Output = LrcPtr<(i32,
                                                                                                                                                                                                                                       string)>>>> =
                                                                                                                                                                        Documents::method42(v2549.clone(),
                                                                                                                                                                                            v2552.clone(),
                                                                                                                                                                                            v2550.clone(),
                                                                                                                                                                                            v2551.clone(),
                                                                                                                                                                                            v2573.clone(),
                                                                                                                                                                                            v2579.clone());
                                                                                                                                                                    let v2585:
                                                                                                                                                                            LrcPtr<(i32,
                                                                                                                                                                                    string)> =
                                                                                                                                                                        futures_lite::future::block_on(v2583);
                                                                                                                                                                    _v2553.set(Some((v2585.0.clone(),
                                                                                                                                                                                     v2585.1.clone())));
                                                                                                                                                                    patternInput_26.1.clone()
                                                                                                                                                                        ==
                                                                                                                                                                        (getValue(_v2553.get().clone())).1.clone()
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
                                                                                                                                    let v2762:
                                                                                                                                            string =
                                                                                                                                        sprintf!("crowbook --single \"{}\" --output \"{}\" --to {} --set rendering.num_depth 6 html.css.add \\\"\'\'\' body {{ color: #e8e6e3; background-color: #202324; }} a {{ color: #989693; }} \'\'\'\\\"",
                                                                                                                                                 v637.clone(),
                                                                                                                                                 v2222.clone(),
                                                                                                                                                 string("pdf"));
                                                                                                                                    let v2763:
                                                                                                                                            Option<CancellationToken> =
                                                                                                                                        None::<CancellationToken>;
                                                                                                                                    let v2764 =
                                                                                                                                        None::<Func1<(bool,
                                                                                                                                                      string,
                                                                                                                                                      i32),
                                                                                                                                                     Arc<Async<()>>>>;
                                                                                                                                    let v2766:
                                                                                                                                            Option<string> =
                                                                                                                                        Some(v1_1.clone());
                                                                                                                                    let _v2767:
                                                                                                                                            MutCell<Option<(i32,
                                                                                                                                                            string)>> =
                                                                                                                                        MutCell::new(None::<(i32,
                                                                                                                                                             string)>);
                                                                                                                                    let patternInput_30:
                                                                                                                                            (string,
                                                                                                                                             string) =
                                                                                                                                        Documents::method32();
                                                                                                                                    let v2771:
                                                                                                                                            i32 =
                                                                                                                                        length(v2762.clone());
                                                                                                                                    let v2772:
                                                                                                                                            Array<char> =
                                                                                                                                        new_init(&'\u{0000}',
                                                                                                                                                 v2771);
                                                                                                                                    let v2773:
                                                                                                                                            LrcPtr<Documents::Mut5> =
                                                                                                                                        LrcPtr::new(Documents::Mut5{l0:
                                                                                                                                                                        MutCell::new(0_i32),});
                                                                                                                                    while Documents::method20(v2771,
                                                                                                                                                              v2773.clone())
                                                                                                                                          {
                                                                                                                                        let v2775:
                                                                                                                                                i32 =
                                                                                                                                            v2773.l0.get().clone();
                                                                                                                                        let v2776:
                                                                                                                                                char =
                                                                                                                                            getCharAt(v2762.clone(),
                                                                                                                                                      v2775);
                                                                                                                                        v2772.get_mut()[v2775
                                                                                                                                                            as
                                                                                                                                                            usize]
                                                                                                                                            =
                                                                                                                                            v2776;
                                                                                                                                        {
                                                                                                                                            let v2777:
                                                                                                                                                    i32 =
                                                                                                                                                v2775
                                                                                                                                                    +
                                                                                                                                                    1_i32;
                                                                                                                                            v2773.l0.set(v2777);
                                                                                                                                            ()
                                                                                                                                        }
                                                                                                                                    }
                                                                                                                                    {
                                                                                                                                        let v2779:
                                                                                                                                                List<char> =
                                                                                                                                            ofArray(v2772.clone());
                                                                                                                                        let patternInput_31:
                                                                                                                                                (string,
                                                                                                                                                 string) =
                                                                                                                                            Documents::method34(patternInput_30.1.clone(),
                                                                                                                                                                patternInput_30.0.clone(),
                                                                                                                                                                foldBack(Func2::new(move
                                                                                                                                                                                        |b0:
                                                                                                                                                                                             char,
                                                                                                                                                                                         b1:
                                                                                                                                                                                             LrcPtr<Documents::UH0>|
                                                                                                                                                                                        (Documents::method33())(b0)(b1)),
                                                                                                                                                                         v2779,
                                                                                                                                                                         LrcPtr::new(Documents::UH0::UH0_0)),
                                                                                                                                                                Documents::US8::US8_0);
                                                                                                                                        let v2787:
                                                                                                                                                string =
                                                                                                                                            patternInput_31.0.clone();
                                                                                                                                        let v2789:
                                                                                                                                                Array<string> =
                                                                                                                                            Documents::method35(patternInput_31.1.clone());
                                                                                                                                        let v2791:
                                                                                                                                                Vec<string> =
                                                                                                                                            v2789.to_vec();
                                                                                                                                        let v2793:
                                                                                                                                                Vec<std::string::String> =
                                                                                                                                            v2791.iter().map(|x| Func1::from(v381)(x.clone())).collect();
                                                                                                                                        Documents::method3(Documents::US0::US0_1,
                                                                                                                                                           Func0::new({
                                                                                                                                                                          let v2762
                                                                                                                                                                              =
                                                                                                                                                                              v2762.clone();
                                                                                                                                                                          let v2763
                                                                                                                                                                              =
                                                                                                                                                                              v2763.clone();
                                                                                                                                                                          let v2764
                                                                                                                                                                              =
                                                                                                                                                                              v2764.clone();
                                                                                                                                                                          let v2766
                                                                                                                                                                              =
                                                                                                                                                                              v2766.clone();
                                                                                                                                                                          let v2787
                                                                                                                                                                              =
                                                                                                                                                                              v2787.clone();
                                                                                                                                                                          let v2793
                                                                                                                                                                              =
                                                                                                                                                                              v2793.clone();
                                                                                                                                                                          move
                                                                                                                                                                              ||
                                                                                                                                                                              Documents::closure28(v2763.clone(),
                                                                                                                                                                                                   v2762.clone(),
                                                                                                                                                                                                   v2764.clone(),
                                                                                                                                                                                                   v2766.clone(),
                                                                                                                                                                                                   v2787.clone(),
                                                                                                                                                                                                   v2793.clone(),
                                                                                                                                                                                                   ())
                                                                                                                                                                      }),
                                                                                                                                                           Documents::method41());
                                                                                                                                        {
                                                                                                                                            let v2797:
                                                                                                                                                    std::pin::Pin<Box<dyn std::future::Future<Output = LrcPtr<(i32,
                                                                                                                                                                                                               string)>>>> =
                                                                                                                                                Documents::method42(v2763.clone(),
                                                                                                                                                                    v2762.clone(),
                                                                                                                                                                    v2764.clone(),
                                                                                                                                                                    v2766.clone(),
                                                                                                                                                                    v2787.clone(),
                                                                                                                                                                    v2793.clone());
                                                                                                                                            let v2799:
                                                                                                                                                    LrcPtr<(i32,
                                                                                                                                                            string)> =
                                                                                                                                                futures_lite::future::block_on(v2797);
                                                                                                                                            _v2767.set(Some((v2799.0.clone(),
                                                                                                                                                             v2799.1.clone())));
                                                                                                                                            {
                                                                                                                                                let patternInput_32:
                                                                                                                                                        (i32,
                                                                                                                                                         string) =
                                                                                                                                                    getValue(_v2767.get().clone());
                                                                                                                                                let v2972:
                                                                                                                                                        string =
                                                                                                                                                    patternInput_32.1.clone();
                                                                                                                                                let v2971:
                                                                                                                                                        i32 =
                                                                                                                                                    patternInput_32.0.clone();
                                                                                                                                                if if v2971
                                                                                                                                                          !=
                                                                                                                                                          0_i32
                                                                                                                                                      {
                                                                                                                                                       true
                                                                                                                                                   } else {
                                                                                                                                                       contains(v2972.clone(),
                                                                                                                                                                string("ERROR"))
                                                                                                                                                   }
                                                                                                                                                   {
                                                                                                                                                    Documents::method3(Documents::US0::US0_2,
                                                                                                                                                                       Func0::new(move
                                                                                                                                                                                      ||
                                                                                                                                                                                      Documents::closure53((),
                                                                                                                                                                                                           ())),
                                                                                                                                                                       Func0::new({
                                                                                                                                                                                      let v2971
                                                                                                                                                                                          =
                                                                                                                                                                                          v2971.clone();
                                                                                                                                                                                      let v2972
                                                                                                                                                                                          =
                                                                                                                                                                                          v2972.clone();
                                                                                                                                                                                      move
                                                                                                                                                                                          ||
                                                                                                                                                                                          Documents::closure54(v2972.clone(),
                                                                                                                                                                                                               v2971,
                                                                                                                                                                                                               ())
                                                                                                                                                                                  }));
                                                                                                                                                    Documents::US17::US17_0(Err::<string,
                                                                                                                                                                                  LrcPtr<(string,
                                                                                                                                                                                          string)>>(LrcPtr::new((v2222.clone(),
                                                                                                                                                                                                                 v2972.clone()))))
                                                                                                                                                } else {
                                                                                                                                                    let _v2983:
                                                                                                                                                            MutCell<Option<()>> =
                                                                                                                                                        MutCell::new(None::<()>);
                                                                                                                                                    let v2985:
                                                                                                                                                            string =
                                                                                                                                                        Documents::method61(v2223);
                                                                                                                                                    let v2987:
                                                                                                                                                            Result<u64,
                                                                                                                                                                   std::io::Error> =
                                                                                                                                                        std::fs::copy(&*v2222, &*v2985);
                                                                                                                                                    let v2989:
                                                                                                                                                            u64 =
                                                                                                                                                        v2987.unwrap();
                                                                                                                                                    _v2983.set(Some(()));
                                                                                                                                                    getValue(_v2983.get().clone());
                                                                                                                                                    Documents::US17::US17_0(Ok::<string,
                                                                                                                                                                                 LrcPtr<(string,
                                                                                                                                                                                         string)>>(v2222))
                                                                                                                                                }
                                                                                                                                            }
                                                                                                                                        }
                                                                                                                                    }
                                                                                                                                } else {
                                                                                                                                    Documents::US17::US17_1
                                                                                                                                };
                                                                                                                            let v2999:
                                                                                                                                    Option<Result<string,
                                                                                                                                                  LrcPtr<(string,
                                                                                                                                                          string)>>> =
                                                                                                                                match &v2994
                                                                                                                                    {
                                                                                                                                    Documents::US17::US17_0(v2994_0_0)
                                                                                                                                    =>
                                                                                                                                    Some(match &v2994
                                                                                                                                             {
                                                                                                                                             Documents::US17::US17_0(x)
                                                                                                                                             =>
                                                                                                                                             x.clone(),
                                                                                                                                             _
                                                                                                                                             =>
                                                                                                                                             unreachable!(),
                                                                                                                                         }),
                                                                                                                                    _
                                                                                                                                    =>
                                                                                                                                    None::<Result<string,
                                                                                                                                                  LrcPtr<(string,
                                                                                                                                                          string)>>>,
                                                                                                                                };
                                                                                                                            let v3001:
                                                                                                                                    string =
                                                                                                                                sprintf!("{}.{}",
                                                                                                                                         v637.clone(),
                                                                                                                                         string("html"));
                                                                                                                            let v3002:
                                                                                                                                    string =
                                                                                                                                sprintf!("{}.{}",
                                                                                                                                         v1170.clone(),
                                                                                                                                         string("html"));
                                                                                                                            let _v3003:
                                                                                                                                    MutCell<Option<bool>> =
                                                                                                                                MutCell::new(None::<bool>);
                                                                                                                            let v3005:
                                                                                                                                    string =
                                                                                                                                Documents::method13(v3001.clone());
                                                                                                                            let v3007:
                                                                                                                                    &str =
                                                                                                                                fable_library_rust::String_::LrcStr::as_str(&v3005);
                                                                                                                            let v3009:
                                                                                                                                    std::string::String =
                                                                                                                                String::from(v3007);
                                                                                                                            let v3011:
                                                                                                                                    std::path::PathBuf =
                                                                                                                                std::path::PathBuf::from(v3009);
                                                                                                                            {
                                                                                                                                let x_53:
                                                                                                                                        bool =
                                                                                                                                    if v3011.clone().exists()
                                                                                                                                       {
                                                                                                                                        v3011.is_file()
                                                                                                                                    } else {
                                                                                                                                        false
                                                                                                                                    };
                                                                                                                                _v3003.set(Some(x_53))
                                                                                                                            }
                                                                                                                            {
                                                                                                                                let v3773:
                                                                                                                                        Documents::US17 =
                                                                                                                                    if (if if getValue(_v3003.get().clone())
                                                                                                                                              {
                                                                                                                                               let _v3026:
                                                                                                                                                       MutCell<Option<bool>> =
                                                                                                                                                   MutCell::new(None::<bool>);
                                                                                                                                               let v3028:
                                                                                                                                                       string =
                                                                                                                                                   Documents::method13(v3002.clone());
                                                                                                                                               let v3030:
                                                                                                                                                       &str =
                                                                                                                                                   fable_library_rust::String_::LrcStr::as_str(&v3028);
                                                                                                                                               let v3032:
                                                                                                                                                       std::string::String =
                                                                                                                                                   String::from(v3030);
                                                                                                                                               let v3034:
                                                                                                                                                       std::path::PathBuf =
                                                                                                                                                   std::path::PathBuf::from(v3032);
                                                                                                                                               {
                                                                                                                                                   let x_54:
                                                                                                                                                           bool =
                                                                                                                                                       if v3034.clone().exists()
                                                                                                                                                          {
                                                                                                                                                           v3034.is_file()
                                                                                                                                                       } else {
                                                                                                                                                           false
                                                                                                                                                       };
                                                                                                                                                   _v3026.set(Some(x_54))
                                                                                                                                               }
                                                                                                                                               getValue(_v3026.get().clone())
                                                                                                                                           } else {
                                                                                                                                               false
                                                                                                                                           }
                                                                                                                                           {
                                                                                                                                            let _v3050:
                                                                                                                                                    MutCell<Option<bool>> =
                                                                                                                                                MutCell::new(None::<bool>);
                                                                                                                                            {
                                                                                                                                                let x_55:
                                                                                                                                                        bool =
                                                                                                                                                    cfg!(windows);
                                                                                                                                                _v3050.set(Some(x_55))
                                                                                                                                            }
                                                                                                                                            {
                                                                                                                                                let v3084:
                                                                                                                                                        Option<CancellationToken> =
                                                                                                                                                    None::<CancellationToken>;
                                                                                                                                                let v3085 =
                                                                                                                                                    None::<Func1<(bool,
                                                                                                                                                                  string,
                                                                                                                                                                  i32),
                                                                                                                                                                 Arc<Async<()>>>>;
                                                                                                                                                let v3086:
                                                                                                                                                        Option<string> =
                                                                                                                                                    None::<string>;
                                                                                                                                                let v3087:
                                                                                                                                                        string =
                                                                                                                                                    sprintf!("pwsh -c \"(Get-FileHash \\\"{}\\\" -Algorithm SHA256).Hash\"",
                                                                                                                                                             if getValue(_v3050.get().clone())
                                                                                                                                                                    ==
                                                                                                                                                                    false
                                                                                                                                                                {
                                                                                                                                                                 v3001.clone()
                                                                                                                                                             } else {
                                                                                                                                                                 let _v3063:
                                                                                                                                                                         MutCell<Option<string>> =
                                                                                                                                                                     MutCell::new(None::<string>);
                                                                                                                                                                 let v3065:
                                                                                                                                                                         string =
                                                                                                                                                                     Documents::method16();
                                                                                                                                                                 let v3066:
                                                                                                                                                                         string =
                                                                                                                                                                     Documents::method17(v3001.clone());
                                                                                                                                                                 let v3067:
                                                                                                                                                                         string =
                                                                                                                                                                     Documents::method18();
                                                                                                                                                                 let v3069:
                                                                                                                                                                         &str =
                                                                                                                                                                     &regex::Regex::new(&v3065).unwrap().replace_all(&v3066, &*v3067);
                                                                                                                                                                 let v3071:
                                                                                                                                                                         std::string::String =
                                                                                                                                                                     String::from(v3069);
                                                                                                                                                                 {
                                                                                                                                                                     let x_56:
                                                                                                                                                                             string =
                                                                                                                                                                         fable_library_rust::String_::fromString(v3071);
                                                                                                                                                                     _v3063.set(Some(x_56))
                                                                                                                                                                 }
                                                                                                                                                                 {
                                                                                                                                                                     let v3080:
                                                                                                                                                                             string =
                                                                                                                                                                         getValue(_v3063.get().clone());
                                                                                                                                                                     replace(sprintf!("{}{}",
                                                                                                                                                                                      toLower(ofChar(getCharAt(v3080.clone(),
                                                                                                                                                                                                               0_i32))),
                                                                                                                                                                                      getSlice(v3080,
                                                                                                                                                                                               Some(1_i32),
                                                                                                                                                                                               None::<i32>)),
                                                                                                                                                                             string("\\"),
                                                                                                                                                                             string("/"))
                                                                                                                                                                 }
                                                                                                                                                             });
                                                                                                                                                let _v3088:
                                                                                                                                                        MutCell<Option<(i32,
                                                                                                                                                                        string)>> =
                                                                                                                                                    MutCell::new(None::<(i32,
                                                                                                                                                                         string)>);
                                                                                                                                                let patternInput_33:
                                                                                                                                                        (string,
                                                                                                                                                         string) =
                                                                                                                                                    Documents::method32();
                                                                                                                                                let v3092:
                                                                                                                                                        i32 =
                                                                                                                                                    length(v3087.clone());
                                                                                                                                                let v3093:
                                                                                                                                                        Array<char> =
                                                                                                                                                    new_init(&'\u{0000}',
                                                                                                                                                             v3092);
                                                                                                                                                let v3094:
                                                                                                                                                        LrcPtr<Documents::Mut5> =
                                                                                                                                                    LrcPtr::new(Documents::Mut5{l0:
                                                                                                                                                                                    MutCell::new(0_i32),});
                                                                                                                                                while Documents::method20(v3092,
                                                                                                                                                                          v3094.clone())
                                                                                                                                                      {
                                                                                                                                                    let v3096:
                                                                                                                                                            i32 =
                                                                                                                                                        v3094.l0.get().clone();
                                                                                                                                                    let v3097:
                                                                                                                                                            char =
                                                                                                                                                        getCharAt(v3087.clone(),
                                                                                                                                                                  v3096);
                                                                                                                                                    v3093.get_mut()[v3096
                                                                                                                                                                        as
                                                                                                                                                                        usize]
                                                                                                                                                        =
                                                                                                                                                        v3097;
                                                                                                                                                    {
                                                                                                                                                        let v3098:
                                                                                                                                                                i32 =
                                                                                                                                                            v3096
                                                                                                                                                                +
                                                                                                                                                                1_i32;
                                                                                                                                                        v3094.l0.set(v3098);
                                                                                                                                                        ()
                                                                                                                                                    }
                                                                                                                                                }
                                                                                                                                                {
                                                                                                                                                    let v3100:
                                                                                                                                                            List<char> =
                                                                                                                                                        ofArray(v3093.clone());
                                                                                                                                                    let patternInput_34:
                                                                                                                                                            (string,
                                                                                                                                                             string) =
                                                                                                                                                        Documents::method34(patternInput_33.1.clone(),
                                                                                                                                                                            patternInput_33.0.clone(),
                                                                                                                                                                            foldBack(Func2::new(move
                                                                                                                                                                                                    |b0:
                                                                                                                                                                                                         char,
                                                                                                                                                                                                     b1:
                                                                                                                                                                                                         LrcPtr<Documents::UH0>|
                                                                                                                                                                                                    (Documents::method33())(b0)(b1)),
                                                                                                                                                                                     v3100,
                                                                                                                                                                                     LrcPtr::new(Documents::UH0::UH0_0)),
                                                                                                                                                                            Documents::US8::US8_0);
                                                                                                                                                    let v3108:
                                                                                                                                                            string =
                                                                                                                                                        patternInput_34.0.clone();
                                                                                                                                                    let v3110:
                                                                                                                                                            Array<string> =
                                                                                                                                                        Documents::method35(patternInput_34.1.clone());
                                                                                                                                                    let v3112:
                                                                                                                                                            Vec<string> =
                                                                                                                                                        v3110.to_vec();
                                                                                                                                                    let v3114:
                                                                                                                                                            Vec<std::string::String> =
                                                                                                                                                        v3112.iter().map(|x| Func1::from(v381)(x.clone())).collect();
                                                                                                                                                    Documents::method3(Documents::US0::US0_1,
                                                                                                                                                                       Func0::new({
                                                                                                                                                                                      let v3084
                                                                                                                                                                                          =
                                                                                                                                                                                          v3084.clone();
                                                                                                                                                                                      let v3085
                                                                                                                                                                                          =
                                                                                                                                                                                          v3085.clone();
                                                                                                                                                                                      let v3086
                                                                                                                                                                                          =
                                                                                                                                                                                          v3086.clone();
                                                                                                                                                                                      let v3087
                                                                                                                                                                                          =
                                                                                                                                                                                          v3087.clone();
                                                                                                                                                                                      let v3108
                                                                                                                                                                                          =
                                                                                                                                                                                          v3108.clone();
                                                                                                                                                                                      let v3114
                                                                                                                                                                                          =
                                                                                                                                                                                          v3114.clone();
                                                                                                                                                                                      move
                                                                                                                                                                                          ||
                                                                                                                                                                                          Documents::closure28(v3084.clone(),
                                                                                                                                                                                                               v3087.clone(),
                                                                                                                                                                                                               v3085.clone(),
                                                                                                                                                                                                               v3086.clone(),
                                                                                                                                                                                                               v3108.clone(),
                                                                                                                                                                                                               v3114.clone(),
                                                                                                                                                                                                               ())
                                                                                                                                                                                  }),
                                                                                                                                                                       Documents::method41());
                                                                                                                                                    {
                                                                                                                                                        let v3118:
                                                                                                                                                                std::pin::Pin<Box<dyn std::future::Future<Output = LrcPtr<(i32,
                                                                                                                                                                                                                           string)>>>> =
                                                                                                                                                            Documents::method42(v3084.clone(),
                                                                                                                                                                                v3087.clone(),
                                                                                                                                                                                v3085.clone(),
                                                                                                                                                                                v3086.clone(),
                                                                                                                                                                                v3108.clone(),
                                                                                                                                                                                v3114.clone());
                                                                                                                                                        let v3120:
                                                                                                                                                                LrcPtr<(i32,
                                                                                                                                                                        string)> =
                                                                                                                                                            futures_lite::future::block_on(v3118);
                                                                                                                                                        _v3088.set(Some((v3120.0.clone(),
                                                                                                                                                                         v3120.1.clone())));
                                                                                                                                                        {
                                                                                                                                                            let patternInput_35:
                                                                                                                                                                    (i32,
                                                                                                                                                                     string) =
                                                                                                                                                                getValue(_v3088.get().clone());
                                                                                                                                                            let _v3294:
                                                                                                                                                                    MutCell<Option<bool>> =
                                                                                                                                                                MutCell::new(None::<bool>);
                                                                                                                                                            {
                                                                                                                                                                let x_58:
                                                                                                                                                                        bool =
                                                                                                                                                                    cfg!(windows);
                                                                                                                                                                _v3294.set(Some(x_58))
                                                                                                                                                            }
                                                                                                                                                            {
                                                                                                                                                                let v3328:
                                                                                                                                                                        Option<CancellationToken> =
                                                                                                                                                                    None::<CancellationToken>;
                                                                                                                                                                let v3329 =
                                                                                                                                                                    None::<Func1<(bool,
                                                                                                                                                                                  string,
                                                                                                                                                                                  i32),
                                                                                                                                                                                 Arc<Async<()>>>>;
                                                                                                                                                                let v3330:
                                                                                                                                                                        Option<string> =
                                                                                                                                                                    None::<string>;
                                                                                                                                                                let v3331:
                                                                                                                                                                        string =
                                                                                                                                                                    sprintf!("pwsh -c \"(Get-FileHash \\\"{}\\\" -Algorithm SHA256).Hash\"",
                                                                                                                                                                             if getValue(_v3294.get().clone())
                                                                                                                                                                                    ==
                                                                                                                                                                                    false
                                                                                                                                                                                {
                                                                                                                                                                                 v3002.clone()
                                                                                                                                                                             } else {
                                                                                                                                                                                 let _v3307:
                                                                                                                                                                                         MutCell<Option<string>> =
                                                                                                                                                                                     MutCell::new(None::<string>);
                                                                                                                                                                                 let v3309:
                                                                                                                                                                                         string =
                                                                                                                                                                                     Documents::method16();
                                                                                                                                                                                 let v3310:
                                                                                                                                                                                         string =
                                                                                                                                                                                     Documents::method17(v3002.clone());
                                                                                                                                                                                 let v3311:
                                                                                                                                                                                         string =
                                                                                                                                                                                     Documents::method18();
                                                                                                                                                                                 let v3313:
                                                                                                                                                                                         &str =
                                                                                                                                                                                     &regex::Regex::new(&v3309).unwrap().replace_all(&v3310, &*v3311);
                                                                                                                                                                                 let v3315:
                                                                                                                                                                                         std::string::String =
                                                                                                                                                                                     String::from(v3313);
                                                                                                                                                                                 {
                                                                                                                                                                                     let x_59:
                                                                                                                                                                                             string =
                                                                                                                                                                                         fable_library_rust::String_::fromString(v3315);
                                                                                                                                                                                     _v3307.set(Some(x_59))
                                                                                                                                                                                 }
                                                                                                                                                                                 {
                                                                                                                                                                                     let v3324:
                                                                                                                                                                                             string =
                                                                                                                                                                                         getValue(_v3307.get().clone());
                                                                                                                                                                                     replace(sprintf!("{}{}",
                                                                                                                                                                                                      toLower(ofChar(getCharAt(v3324.clone(),
                                                                                                                                                                                                                               0_i32))),
                                                                                                                                                                                                      getSlice(v3324,
                                                                                                                                                                                                               Some(1_i32),
                                                                                                                                                                                                               None::<i32>)),
                                                                                                                                                                                             string("\\"),
                                                                                                                                                                                             string("/"))
                                                                                                                                                                                 }
                                                                                                                                                                             });
                                                                                                                                                                let _v3332:
                                                                                                                                                                        MutCell<Option<(i32,
                                                                                                                                                                                        string)>> =
                                                                                                                                                                    MutCell::new(None::<(i32,
                                                                                                                                                                                         string)>);
                                                                                                                                                                let patternInput_36:
                                                                                                                                                                        (string,
                                                                                                                                                                         string) =
                                                                                                                                                                    Documents::method32();
                                                                                                                                                                let v3336:
                                                                                                                                                                        i32 =
                                                                                                                                                                    length(v3331.clone());
                                                                                                                                                                let v3337:
                                                                                                                                                                        Array<char> =
                                                                                                                                                                    new_init(&'\u{0000}',
                                                                                                                                                                             v3336);
                                                                                                                                                                let v3338:
                                                                                                                                                                        LrcPtr<Documents::Mut5> =
                                                                                                                                                                    LrcPtr::new(Documents::Mut5{l0:
                                                                                                                                                                                                    MutCell::new(0_i32),});
                                                                                                                                                                while Documents::method20(v3336,
                                                                                                                                                                                          v3338.clone())
                                                                                                                                                                      {
                                                                                                                                                                    let v3340:
                                                                                                                                                                            i32 =
                                                                                                                                                                        v3338.l0.get().clone();
                                                                                                                                                                    let v3341:
                                                                                                                                                                            char =
                                                                                                                                                                        getCharAt(v3331.clone(),
                                                                                                                                                                                  v3340);
                                                                                                                                                                    v3337.get_mut()[v3340
                                                                                                                                                                                        as
                                                                                                                                                                                        usize]
                                                                                                                                                                        =
                                                                                                                                                                        v3341;
                                                                                                                                                                    {
                                                                                                                                                                        let v3342:
                                                                                                                                                                                i32 =
                                                                                                                                                                            v3340
                                                                                                                                                                                +
                                                                                                                                                                                1_i32;
                                                                                                                                                                        v3338.l0.set(v3342);
                                                                                                                                                                        ()
                                                                                                                                                                    }
                                                                                                                                                                }
                                                                                                                                                                {
                                                                                                                                                                    let v3344:
                                                                                                                                                                            List<char> =
                                                                                                                                                                        ofArray(v3337.clone());
                                                                                                                                                                    let patternInput_37:
                                                                                                                                                                            (string,
                                                                                                                                                                             string) =
                                                                                                                                                                        Documents::method34(patternInput_36.1.clone(),
                                                                                                                                                                                            patternInput_36.0.clone(),
                                                                                                                                                                                            foldBack(Func2::new(move
                                                                                                                                                                                                                    |b0:
                                                                                                                                                                                                                         char,
                                                                                                                                                                                                                     b1:
                                                                                                                                                                                                                         LrcPtr<Documents::UH0>|
                                                                                                                                                                                                                    (Documents::method33())(b0)(b1)),
                                                                                                                                                                                                     v3344,
                                                                                                                                                                                                     LrcPtr::new(Documents::UH0::UH0_0)),
                                                                                                                                                                                            Documents::US8::US8_0);
                                                                                                                                                                    let v3352:
                                                                                                                                                                            string =
                                                                                                                                                                        patternInput_37.0.clone();
                                                                                                                                                                    let v3354:
                                                                                                                                                                            Array<string> =
                                                                                                                                                                        Documents::method35(patternInput_37.1.clone());
                                                                                                                                                                    let v3356:
                                                                                                                                                                            Vec<string> =
                                                                                                                                                                        v3354.to_vec();
                                                                                                                                                                    let v3358:
                                                                                                                                                                            Vec<std::string::String> =
                                                                                                                                                                        v3356.iter().map(|x| Func1::from(v381)(x.clone())).collect();
                                                                                                                                                                    Documents::method3(Documents::US0::US0_1,
                                                                                                                                                                                       Func0::new({
                                                                                                                                                                                                      let v3328
                                                                                                                                                                                                          =
                                                                                                                                                                                                          v3328.clone();
                                                                                                                                                                                                      let v3329
                                                                                                                                                                                                          =
                                                                                                                                                                                                          v3329.clone();
                                                                                                                                                                                                      let v3330
                                                                                                                                                                                                          =
                                                                                                                                                                                                          v3330.clone();
                                                                                                                                                                                                      let v3331
                                                                                                                                                                                                          =
                                                                                                                                                                                                          v3331.clone();
                                                                                                                                                                                                      let v3352
                                                                                                                                                                                                          =
                                                                                                                                                                                                          v3352.clone();
                                                                                                                                                                                                      let v3358
                                                                                                                                                                                                          =
                                                                                                                                                                                                          v3358.clone();
                                                                                                                                                                                                      move
                                                                                                                                                                                                          ||
                                                                                                                                                                                                          Documents::closure28(v3328.clone(),
                                                                                                                                                                                                                               v3331.clone(),
                                                                                                                                                                                                                               v3329.clone(),
                                                                                                                                                                                                                               v3330.clone(),
                                                                                                                                                                                                                               v3352.clone(),
                                                                                                                                                                                                                               v3358.clone(),
                                                                                                                                                                                                                               ())
                                                                                                                                                                                                  }),
                                                                                                                                                                                       Documents::method41());
                                                                                                                                                                    {
                                                                                                                                                                        let v3362:
                                                                                                                                                                                std::pin::Pin<Box<dyn std::future::Future<Output = LrcPtr<(i32,
                                                                                                                                                                                                                                           string)>>>> =
                                                                                                                                                                            Documents::method42(v3328.clone(),
                                                                                                                                                                                                v3331.clone(),
                                                                                                                                                                                                v3329.clone(),
                                                                                                                                                                                                v3330.clone(),
                                                                                                                                                                                                v3352.clone(),
                                                                                                                                                                                                v3358.clone());
                                                                                                                                                                        let v3364:
                                                                                                                                                                                LrcPtr<(i32,
                                                                                                                                                                                        string)> =
                                                                                                                                                                            futures_lite::future::block_on(v3362);
                                                                                                                                                                        _v3332.set(Some((v3364.0.clone(),
                                                                                                                                                                                         v3364.1.clone())));
                                                                                                                                                                        patternInput_35.1.clone()
                                                                                                                                                                            ==
                                                                                                                                                                            (getValue(_v3332.get().clone())).1.clone()
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
                                                                                                                                        let v3541:
                                                                                                                                                string =
                                                                                                                                            sprintf!("crowbook --single \"{}\" --output \"{}\" --to {} --set rendering.num_depth 6 html.css.add \\\"\'\'\' body {{ color: #e8e6e3; background-color: #202324; }} a {{ color: #989693; }} \'\'\'\\\"",
                                                                                                                                                     v637,
                                                                                                                                                     v3001.clone(),
                                                                                                                                                     string("html"));
                                                                                                                                        let v3542:
                                                                                                                                                Option<CancellationToken> =
                                                                                                                                            None::<CancellationToken>;
                                                                                                                                        let v3543 =
                                                                                                                                            None::<Func1<(bool,
                                                                                                                                                          string,
                                                                                                                                                          i32),
                                                                                                                                                         Arc<Async<()>>>>;
                                                                                                                                        let v3545:
                                                                                                                                                Option<string> =
                                                                                                                                            Some(v1_1);
                                                                                                                                        let _v3546:
                                                                                                                                                MutCell<Option<(i32,
                                                                                                                                                                string)>> =
                                                                                                                                            MutCell::new(None::<(i32,
                                                                                                                                                                 string)>);
                                                                                                                                        let patternInput_39:
                                                                                                                                                (string,
                                                                                                                                                 string) =
                                                                                                                                            Documents::method32();
                                                                                                                                        let v3550:
                                                                                                                                                i32 =
                                                                                                                                            length(v3541.clone());
                                                                                                                                        let v3551:
                                                                                                                                                Array<char> =
                                                                                                                                            new_init(&'\u{0000}',
                                                                                                                                                     v3550);
                                                                                                                                        let v3552:
                                                                                                                                                LrcPtr<Documents::Mut5> =
                                                                                                                                            LrcPtr::new(Documents::Mut5{l0:
                                                                                                                                                                            MutCell::new(0_i32),});
                                                                                                                                        while Documents::method20(v3550,
                                                                                                                                                                  v3552.clone())
                                                                                                                                              {
                                                                                                                                            let v3554:
                                                                                                                                                    i32 =
                                                                                                                                                v3552.l0.get().clone();
                                                                                                                                            let v3555:
                                                                                                                                                    char =
                                                                                                                                                getCharAt(v3541.clone(),
                                                                                                                                                          v3554);
                                                                                                                                            v3551.get_mut()[v3554
                                                                                                                                                                as
                                                                                                                                                                usize]
                                                                                                                                                =
                                                                                                                                                v3555;
                                                                                                                                            {
                                                                                                                                                let v3556:
                                                                                                                                                        i32 =
                                                                                                                                                    v3554
                                                                                                                                                        +
                                                                                                                                                        1_i32;
                                                                                                                                                v3552.l0.set(v3556);
                                                                                                                                                ()
                                                                                                                                            }
                                                                                                                                        }
                                                                                                                                        {
                                                                                                                                            let v3558:
                                                                                                                                                    List<char> =
                                                                                                                                                ofArray(v3551.clone());
                                                                                                                                            let patternInput_40:
                                                                                                                                                    (string,
                                                                                                                                                     string) =
                                                                                                                                                Documents::method34(patternInput_39.1.clone(),
                                                                                                                                                                    patternInput_39.0.clone(),
                                                                                                                                                                    foldBack(Func2::new(move
                                                                                                                                                                                            |b0:
                                                                                                                                                                                                 char,
                                                                                                                                                                                             b1:
                                                                                                                                                                                                 LrcPtr<Documents::UH0>|
                                                                                                                                                                                            (Documents::method33())(b0)(b1)),
                                                                                                                                                                             v3558,
                                                                                                                                                                             LrcPtr::new(Documents::UH0::UH0_0)),
                                                                                                                                                                    Documents::US8::US8_0);
                                                                                                                                            let v3566:
                                                                                                                                                    string =
                                                                                                                                                patternInput_40.0.clone();
                                                                                                                                            let v3568:
                                                                                                                                                    Array<string> =
                                                                                                                                                Documents::method35(patternInput_40.1.clone());
                                                                                                                                            let v3570:
                                                                                                                                                    Vec<string> =
                                                                                                                                                v3568.to_vec();
                                                                                                                                            let v3572:
                                                                                                                                                    Vec<std::string::String> =
                                                                                                                                                v3570.iter().map(|x| Func1::from(v381)(x.clone())).collect();
                                                                                                                                            Documents::method3(Documents::US0::US0_1,
                                                                                                                                                               Func0::new({
                                                                                                                                                                              let v3541
                                                                                                                                                                                  =
                                                                                                                                                                                  v3541.clone();
                                                                                                                                                                              let v3542
                                                                                                                                                                                  =
                                                                                                                                                                                  v3542.clone();
                                                                                                                                                                              let v3543
                                                                                                                                                                                  =
                                                                                                                                                                                  v3543.clone();
                                                                                                                                                                              let v3545
                                                                                                                                                                                  =
                                                                                                                                                                                  v3545.clone();
                                                                                                                                                                              let v3566
                                                                                                                                                                                  =
                                                                                                                                                                                  v3566.clone();
                                                                                                                                                                              let v3572
                                                                                                                                                                                  =
                                                                                                                                                                                  v3572.clone();
                                                                                                                                                                              move
                                                                                                                                                                                  ||
                                                                                                                                                                                  Documents::closure28(v3542.clone(),
                                                                                                                                                                                                       v3541.clone(),
                                                                                                                                                                                                       v3543.clone(),
                                                                                                                                                                                                       v3545.clone(),
                                                                                                                                                                                                       v3566.clone(),
                                                                                                                                                                                                       v3572.clone(),
                                                                                                                                                                                                       ())
                                                                                                                                                                          }),
                                                                                                                                                               Documents::method41());
                                                                                                                                            {
                                                                                                                                                let v3576:
                                                                                                                                                        std::pin::Pin<Box<dyn std::future::Future<Output = LrcPtr<(i32,
                                                                                                                                                                                                                   string)>>>> =
                                                                                                                                                    Documents::method42(v3542.clone(),
                                                                                                                                                                        v3541.clone(),
                                                                                                                                                                        v3543.clone(),
                                                                                                                                                                        v3545.clone(),
                                                                                                                                                                        v3566.clone(),
                                                                                                                                                                        v3572.clone());
                                                                                                                                                let v3578:
                                                                                                                                                        LrcPtr<(i32,
                                                                                                                                                                string)> =
                                                                                                                                                    futures_lite::future::block_on(v3576);
                                                                                                                                                _v3546.set(Some((v3578.0.clone(),
                                                                                                                                                                 v3578.1.clone())));
                                                                                                                                                {
                                                                                                                                                    let patternInput_41:
                                                                                                                                                            (i32,
                                                                                                                                                             string) =
                                                                                                                                                        getValue(_v3546.get().clone());
                                                                                                                                                    let v3751:
                                                                                                                                                            string =
                                                                                                                                                        patternInput_41.1.clone();
                                                                                                                                                    let v3750:
                                                                                                                                                            i32 =
                                                                                                                                                        patternInput_41.0.clone();
                                                                                                                                                    if if v3750
                                                                                                                                                              !=
                                                                                                                                                              0_i32
                                                                                                                                                          {
                                                                                                                                                           true
                                                                                                                                                       } else {
                                                                                                                                                           contains(v3751.clone(),
                                                                                                                                                                    string("ERROR"))
                                                                                                                                                       }
                                                                                                                                                       {
                                                                                                                                                        Documents::method3(Documents::US0::US0_2,
                                                                                                                                                                           Func0::new(move
                                                                                                                                                                                          ||
                                                                                                                                                                                          Documents::closure53((),
                                                                                                                                                                                                               ())),
                                                                                                                                                                           Func0::new({
                                                                                                                                                                                          let v3750
                                                                                                                                                                                              =
                                                                                                                                                                                              v3750.clone();
                                                                                                                                                                                          let v3751
                                                                                                                                                                                              =
                                                                                                                                                                                              v3751.clone();
                                                                                                                                                                                          move
                                                                                                                                                                                              ||
                                                                                                                                                                                              Documents::closure54(v3751.clone(),
                                                                                                                                                                                                                   v3750,
                                                                                                                                                                                                                   ())
                                                                                                                                                                                      }));
                                                                                                                                                        Documents::US17::US17_0(Err::<string,
                                                                                                                                                                                      LrcPtr<(string,
                                                                                                                                                                                              string)>>(LrcPtr::new((v3001.clone(),
                                                                                                                                                                                                                     v3751.clone()))))
                                                                                                                                                    } else {
                                                                                                                                                        let _v3762:
                                                                                                                                                                MutCell<Option<()>> =
                                                                                                                                                            MutCell::new(None::<()>);
                                                                                                                                                        let v3764:
                                                                                                                                                                string =
                                                                                                                                                            Documents::method61(v3002);
                                                                                                                                                        let v3766:
                                                                                                                                                                Result<u64,
                                                                                                                                                                       std::io::Error> =
                                                                                                                                                            std::fs::copy(&*v3001, &*v3764);
                                                                                                                                                        let v3768:
                                                                                                                                                                u64 =
                                                                                                                                                            v3766.unwrap();
                                                                                                                                                        _v3762.set(Some(()));
                                                                                                                                                        getValue(_v3762.get().clone());
                                                                                                                                                        Documents::US17::US17_0(Ok::<string,
                                                                                                                                                                                     LrcPtr<(string,
                                                                                                                                                                                             string)>>(v3001))
                                                                                                                                                    }
                                                                                                                                                }
                                                                                                                                            }
                                                                                                                                        }
                                                                                                                                    } else {
                                                                                                                                        Documents::US17::US17_1
                                                                                                                                    };
                                                                                                                                let v3785:
                                                                                                                                        Array<Option<Result<string,
                                                                                                                                                            LrcPtr<(string,
                                                                                                                                                                    string)>>>> =
                                                                                                                                    toArray(ofArray(new_array(&[match &v3773
                                                                                                                                                                    {
                                                                                                                                                                    Documents::US17::US17_0(v3773_0_0)
                                                                                                                                                                    =>
                                                                                                                                                                    Some(match &v3773
                                                                                                                                                                             {
                                                                                                                                                                             Documents::US17::US17_0(x)
                                                                                                                                                                             =>
                                                                                                                                                                             x.clone(),
                                                                                                                                                                             _
                                                                                                                                                                             =>
                                                                                                                                                                             unreachable!(),
                                                                                                                                                                         }),
                                                                                                                                                                    _
                                                                                                                                                                    =>
                                                                                                                                                                    None::<Result<string,
                                                                                                                                                                                  LrcPtr<(string,
                                                                                                                                                                                          string)>>>,
                                                                                                                                                                },
                                                                                                                                                                v2999,
                                                                                                                                                                v2220,
                                                                                                                                                                None::<Result<string,
                                                                                                                                                                              LrcPtr<(string,
                                                                                                                                                                                      string)>>>])));
                                                                                                                                Documents::method3(Documents::US0::US0_2,
                                                                                                                                                   Func0::new(move
                                                                                                                                                                  ||
                                                                                                                                                                  Documents::closure55((),
                                                                                                                                                                                       ())),
                                                                                                                                                   Func0::new({
                                                                                                                                                                  let patternInput_5
                                                                                                                                                                      =
                                                                                                                                                                      patternInput_5.clone();
                                                                                                                                                                  let patternInput_8
                                                                                                                                                                      =
                                                                                                                                                                      patternInput_8.clone();
                                                                                                                                                                  let v1094
                                                                                                                                                                      =
                                                                                                                                                                      v1094.clone();
                                                                                                                                                                  let v1439
                                                                                                                                                                      =
                                                                                                                                                                      v1439.clone();
                                                                                                                                                                  let v238
                                                                                                                                                                      =
                                                                                                                                                                      v238.clone();
                                                                                                                                                                  let v272
                                                                                                                                                                      =
                                                                                                                                                                      v272.clone();
                                                                                                                                                                  let v349
                                                                                                                                                                      =
                                                                                                                                                                      v349.clone();
                                                                                                                                                                  let v3785
                                                                                                                                                                      =
                                                                                                                                                                      v3785.clone();
                                                                                                                                                                  let v561
                                                                                                                                                                      =
                                                                                                                                                                      v561.clone();
                                                                                                                                                                  let v848
                                                                                                                                                                      =
                                                                                                                                                                      v848.clone();
                                                                                                                                                                  move
                                                                                                                                                                      ||
                                                                                                                                                                      Documents::closure56(v238.clone(),
                                                                                                                                                                                           v272.clone(),
                                                                                                                                                                                           v349.clone(),
                                                                                                                                                                                           v561.clone(),
                                                                                                                                                                                           patternInput_5.0.clone(),
                                                                                                                                                                                           v848.clone(),
                                                                                                                                                                                           patternInput_8.0.clone(),
                                                                                                                                                                                           v1094.clone(),
                                                                                                                                                                                           v1439.clone(),
                                                                                                                                                                                           v3785.clone(),
                                                                                                                                                                                           ())
                                                                                                                                                              }));
                                                                                                                                {
                                                                                                                                    let _v3789:
                                                                                                                                            MutCell<Option<()>> =
                                                                                                                                        MutCell::new(None::<()>);
                                                                                                                                    let v3791:
                                                                                                                                            string =
                                                                                                                                        Documents::method61(v1170);
                                                                                                                                    let v3793:
                                                                                                                                            Result<u64,
                                                                                                                                                   std::io::Error> =
                                                                                                                                        std::fs::copy(&*v637, &*v3791);
                                                                                                                                    let v3795:
                                                                                                                                            u64 =
                                                                                                                                        v3793.unwrap();
                                                                                                                                    _v3789.set(Some(()));
                                                                                                                                    getValue(_v3789.get().clone());
                                                                                                                                    v3785.clone()
                                                                                                                                }
                                                                                                                            }
                                                                                                                        }
                                                                                                                    }
                                                                                                                } else {
                                                                                                                    new_empty::<Option<Result<string,
                                                                                                                                              LrcPtr<(string,
                                                                                                                                                      string)>>>>()
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
                                                                                Option<
                                                                                    Result<
                                                                                        string,
                                                                                        LrcPtr<(
                                                                                            string,
                                                                                            string,
                                                                                        )>,
                                                                                    >,
                                                                                >,
                                                                            >(
                                                                            )
                                                                        };
                                                                        Ok::<LrcPtr<(string,
                                                                                     Vec<Option<Result<string,
                                                                                                       LrcPtr<(string,
                                                                                                               string)>>>>)>,
                                                                             std::string::String>(LrcPtr::new((v272.clone(),
                                                                                                               v3799.to_vec())))
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
        }
        pub fn closure57(unitVar: (), unitVar_1: ()) -> string {
            string("documents.run")
        }
        pub fn closure58(
            v0_1: Vec<
                Result<
                    LrcPtr<(
                        string,
                        Vec<Option<Result<string, LrcPtr<(string, string)>>>>,
                    )>,
                    std::string::String,
                >,
            >,
            unitVar: (),
        ) -> string {
            sprintf!(
                "result_len: {} / {}",
                v0_1.len(),
                Documents::closure6((), ())
            )
        }
        pub fn method62(
            v0_1: Result<
                Vec<
                    Result<
                        LrcPtr<(
                            string,
                            Vec<Option<Result<string, LrcPtr<(string, string)>>>>,
                        )>,
                        std::string::String,
                    >,
                >,
                std::string::String,
            >,
        ) -> Result<
            Vec<
                Result<
                    LrcPtr<(
                        string,
                        Vec<Option<Result<string, LrcPtr<(string, string)>>>>,
                    )>,
                    std::string::String,
                >,
            >,
            std::string::String,
        > {
            v0_1
        }
        pub fn method23(
            v0_1: string,
            v1_1: string,
            v2: string,
        ) -> std::pin::Pin<
            Box<
                dyn std::future::Future<
                    Output = Result<
                        Vec<
                            Result<
                                LrcPtr<(
                                    string,
                                    Vec<Option<Result<string, LrcPtr<(string, string)>>>>,
                                )>,
                                std::string::String,
                            >,
                        >,
                        std::string::String,
                    >,
                >,
            >,
        > {
            let __result = Box::pin(async move {
                //;
                {
                    let v5: async_walkdir::WalkDir = async_walkdir::WalkDir::new(&*v1_1.clone());
                    let v8: async_walkdir::WalkDir = async_walkdir::WalkDir::filter(v5, |x| {
                        Func1::new(move |v: async_walkdir::DirEntry| Documents::closure12((), v))(x)
                    });
                    let v9 = Documents::method31();
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
                        let v21: Vec<
                            Result<
                                LrcPtr<(
                                    string,
                                    Vec<Option<Result<string, LrcPtr<(string, string)>>>>,
                                )>,
                                std::string::String,
                            >,
                        > = rayon::iter::ParallelIterator::collect(v19);
                        Documents::method3(
                            Documents::US0::US0_1,
                            Func0::new(move || Documents::closure57((), ())),
                            Func0::new({
                                let v21 = v21.clone();
                                move || Documents::closure58(v21.clone(), ())
                            }),
                        );
                        {
                            let v26: Result<
                                Vec<
                                    Result<
                                        LrcPtr<(
                                            string,
                                            Vec<Option<Result<string, LrcPtr<(string, string)>>>>,
                                        )>,
                                        std::string::String,
                                    >,
                                >,
                                std::string::String,
                            > = Documents::method62(Ok::<
                                Vec<
                                    Result<
                                        LrcPtr<(
                                            string,
                                            Vec<Option<Result<string, LrcPtr<(string, string)>>>>,
                                        )>,
                                        std::string::String,
                                    >,
                                >,
                                std::string::String,
                            >(v21.clone()));
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
                                    let x_10: string = if v108.exists() == false {
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
                                                    {
                                                        let v183: string =
                                                            getValue(_v141.get().clone());
                                                        let _v184: MutCell<Option<bool>> =
                                                            MutCell::new(None::<bool>);
                                                        {
                                                            let x_6: bool = cfg!(windows);
                                                            _v184.set(Some(x_6))
                                                        }
                                                        {
                                                            let v222: Array<string> = split(
                                                                if getValue(_v184.get().clone())
                                                                    == false
                                                                {
                                                                    v183.clone()
                                                                } else {
                                                                    let _v197: MutCell<
                                                                        Option<string>,
                                                                    > = MutCell::new(
                                                                        None::<string>,
                                                                    );
                                                                    let v199: string =
                                                                        Documents::method16();
                                                                    let v200: string =
                                                                        Documents::method17(v183);
                                                                    let v201: string =
                                                                        Documents::method18();
                                                                    let v203: &str =
                                                                        &regex::Regex::new(&v199)
                                                                            .unwrap()
                                                                            .replace_all(
                                                                                &v200, &*v201,
                                                                            );
                                                                    let v205: std::string::String =
                                                                        String::from(v203);
                                                                    {
                                                                        let x_7:
                                                                                          string =
                                                                                      fable_library_rust::String_::fromString(v205);
                                                                        _v197.set(Some(x_7))
                                                                    }
                                                                    {
                                                                        let v215: string = getValue(
                                                                            _v197.get().clone(),
                                                                        );
                                                                        replace(
                                                                            sprintf!(
                                                                                "{}{}",
                                                                                toLower(ofChar(
                                                                                    getCharAt(
                                                                                        v215.clone(
                                                                                        ),
                                                                                        0_i32
                                                                                    )
                                                                                )),
                                                                                getSlice(
                                                                                    v215,
                                                                                    Some(1_i32),
                                                                                    None::<i32>
                                                                                )
                                                                            ),
                                                                            string("\\"),
                                                                            string("/"),
                                                                        )
                                                                    }
                                                                },
                                                                string("/"),
                                                                -1_i32,
                                                                0_i32,
                                                            );
                                                            let v224: i32 = count(v222.clone());
                                                            let v225: LrcPtr<Documents::Mut4> =
                                                                LrcPtr::new(Documents::Mut4 {
                                                                    l0: MutCell::new(0_i32),
                                                                    l1: MutCell::new(0_i32),
                                                                    l2: MutCell::new(new_empty::<
                                                                        string,
                                                                    >(
                                                                    )),
                                                                });
                                                            while Documents::method19(
                                                                v224,
                                                                v225.clone(),
                                                            ) {
                                                                let v227: i32 =
                                                                    v225.l0.get().clone();
                                                                let v230: i32 = v227.wrapping_neg()
                                                                    + v224
                                                                    - 1_i32;
                                                                let matchValue: i32 =
                                                                    v225.l1.get().clone();
                                                                let v232: Array<string> =
                                                                    v225.l2.get().clone();
                                                                let v231: i32 = matchValue;
                                                                let v233: string =
                                                                    v222[v230].clone();
                                                                let patternInput_2: (
                                                                    i32,
                                                                    Array<string>,
                                                                ) = if string("..") == v233.clone()
                                                                {
                                                                    (v231 + 1_i32, v232.clone())
                                                                } else {
                                                                    if 0_i32 == v231 {
                                                                        let v237: Array<string> =
                                                                            new_array(&[v233]);
                                                                        let v238: i32 =
                                                                            count(v237.clone());
                                                                        let v240: i32 = v238
                                                                            + count(v232.clone());
                                                                        let v241: Array<string> =
                                                                            new_init(
                                                                                &string(""),
                                                                                v240,
                                                                            );
                                                                        let v242: LrcPtr<
                                                                            Documents::Mut5,
                                                                        > = LrcPtr::new(
                                                                            Documents::Mut5 {
                                                                                l0: MutCell::new(
                                                                                    0_i32,
                                                                                ),
                                                                            },
                                                                        );
                                                                        while Documents::method20(
                                                                            v240,
                                                                            v242.clone(),
                                                                        ) {
                                                                            let v244: i32 = v242
                                                                                .l0
                                                                                .get()
                                                                                .clone();
                                                                            let v249: string =
                                                                                if v244 < v238 {
                                                                                    v237[v244]
                                                                                        .clone()
                                                                                } else {
                                                                                    let v247: i32 =
                                                                                        v244 - v238;
                                                                                    v232[v247]
                                                                                        .clone()
                                                                                };
                                                                            v241.get_mut()
                                                                                [v244 as usize] =
                                                                                v249;
                                                                            {
                                                                                let v250: i32 =
                                                                                    v244 + 1_i32;
                                                                                v242.l0.set(v250);
                                                                                ()
                                                                            }
                                                                        }
                                                                        (v231, v241.clone())
                                                                    } else {
                                                                        (v231 - 1_i32, v232.clone())
                                                                    }
                                                                };
                                                                let v256: i32 = v227 + 1_i32;
                                                                v225.l0.set(v256);
                                                                v225.l1
                                                                    .set(patternInput_2.0.clone());
                                                                v225.l2
                                                                    .set(patternInput_2.1.clone());
                                                                ()
                                                            }
                                                            {
                                                                let matchValue_2: i32 =
                                                                    v225.l1.get().clone();
                                                                let v258: Array<string> =
                                                                    v225.l2.get().clone();
                                                                let v259: LrcPtr<
                                                                    dyn IEnumerable_1<string>,
                                                                > = delay(Func0::new({
                                                                    let v258 = v258.clone();
                                                                    move || {
                                                                        map_1(
                                                                            Func1::new({
                                                                                let v258 =
                                                                                    v258.clone();
                                                                                move |i: i32| {
                                                                                    v258[i].clone()
                                                                                }
                                                                            }),
                                                                            rangeNumeric(
                                                                                0_i32,
                                                                                1_i32,
                                                                                count(v258.clone())
                                                                                    - 1_i32,
                                                                            ),
                                                                        )
                                                                    }
                                                                }));
                                                                let _v260: MutCell<Option<char>> =
                                                                    MutCell::new(None::<char>);
                                                                {
                                                                    let x_8: char =
                                                                        std::path::MAIN_SEPARATOR;
                                                                    _v260.set(Some(x_8))
                                                                }
                                                                join(
                                                                    Documents::method21(ofChar(
                                                                        getValue(
                                                                            _v260.get().clone(),
                                                                        ),
                                                                    )),
                                                                    toArray_1(v259),
                                                                )
                                                            }
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    } else {
                                        let v277: Result<std::path::PathBuf, std::io::Error> =
                                            std::fs::canonicalize(&*v101);
                                        let v279: std::path::PathBuf = v277.unwrap();
                                        let v281: std::path::Display = v279.display();
                                        let _v282: MutCell<Option<std::string::String>> =
                                            MutCell::new(None::<std::string::String>);
                                        {
                                            let x_9: std::string::String = format!("{}", v281);
                                            _v282.set(Some(x_9))
                                        }
                                        {
                                            let v293: std::string::String =
                                                getValue(_v282.get().clone());
                                            fable_library_rust::String_::fromString(v293)
                                        }
                                    };
                                    _v99.set(Some(x_10))
                                }
                                {
                                    let v304: string = getValue(_v99.get().clone());
                                    let _v305: MutCell<Option<string>> =
                                        MutCell::new(None::<string>);
                                    let v307: string = Documents::method12(v70);
                                    let v308: string = Documents::method13(v307.clone());
                                    let v310: &str =
                                        fable_library_rust::String_::LrcStr::as_str(&v308);
                                    let v312: std::string::String = String::from(v310);
                                    let v314: std::path::PathBuf = std::path::PathBuf::from(v312);
                                    {
                                        let x_19: string = if v314.exists() == false {
                                            let _v318: MutCell<Option<string>> =
                                                MutCell::new(None::<string>);
                                            let v321: Result<std::path::PathBuf, std::io::Error> =
                                                std::env::current_dir();
                                            let v323: std::path::PathBuf = v321.unwrap();
                                            let v325: std::path::Display = v323.display();
                                            let _v326: MutCell<Option<std::string::String>> =
                                                MutCell::new(None::<std::string::String>);
                                            {
                                                let x_11: std::string::String = format!("{}", v325);
                                                _v326.set(Some(x_11))
                                            }
                                            {
                                                let v337: std::string::String =
                                                    getValue(_v326.get().clone());
                                                {
                                                    let x_12: string =
                                                        fable_library_rust::String_::fromString(
                                                            v337,
                                                        );
                                                    _v318.set(Some(x_12))
                                                }
                                                {
                                                    let _v347: MutCell<Option<string>> =
                                                        MutCell::new(None::<string>);
                                                    let v349: string = Documents::method13(
                                                        getValue(_v318.get().clone()),
                                                    );
                                                    let v351: &str =
                                                        fable_library_rust::String_::LrcStr::as_str(
                                                            &v349,
                                                        );
                                                    let v353: std::string::String =
                                                        String::from(v351);
                                                    let v355: std::path::PathBuf =
                                                        std::path::PathBuf::from(v353);
                                                    let v356: string =
                                                        Documents::method13(v307.clone());
                                                    let v358: &str =
                                                        fable_library_rust::String_::LrcStr::as_str(
                                                            &v356,
                                                        );
                                                    let v360: std::string::String =
                                                        String::from(v358);
                                                    let v362: std::path::PathBuf = v355.join(v360);
                                                    let v364: std::path::Display = v362.display();
                                                    let _v365: MutCell<
                                                        Option<std::string::String>,
                                                    > = MutCell::new(None::<std::string::String>);
                                                    {
                                                        let x_13: std::string::String =
                                                            format!("{}", v364);
                                                        _v365.set(Some(x_13))
                                                    }
                                                    {
                                                        let v376: std::string::String =
                                                            getValue(_v365.get().clone());
                                                        {
                                                            let x_14:
                                                                        string =
                                                                    fable_library_rust::String_::fromString(v376);
                                                            _v347.set(Some(x_14))
                                                        }
                                                        {
                                                            let v389: string =
                                                                getValue(_v347.get().clone());
                                                            let _v390: MutCell<Option<bool>> =
                                                                MutCell::new(None::<bool>);
                                                            {
                                                                let x_15: bool = cfg!(windows);
                                                                _v390.set(Some(x_15))
                                                            }
                                                            {
                                                                let v428: Array<string> = split(
                                                                    if getValue(_v390.get().clone())
                                                                        == false
                                                                    {
                                                                        v389.clone()
                                                                    } else {
                                                                        let _v403: MutCell<
                                                                            Option<string>,
                                                                        > = MutCell::new(
                                                                            None::<string>,
                                                                        );
                                                                        let v405: string =
                                                                            Documents::method16();
                                                                        let v406: string =
                                                                            Documents::method17(
                                                                                v389,
                                                                            );
                                                                        let v407: string =
                                                                            Documents::method18();
                                                                        let v409: &str =
                                                                            &regex::Regex::new(
                                                                                &v405,
                                                                            )
                                                                            .unwrap()
                                                                            .replace_all(
                                                                                &v406, &*v407,
                                                                            );
                                                                        let v411:
                                                                                          std::string::String =
                                                                                      String::from(v409);
                                                                        {
                                                                            let x_16:
                                                                                              string =
                                                                                          fable_library_rust::String_::fromString(v411);
                                                                            _v403.set(Some(x_16))
                                                                        }
                                                                        {
                                                                            let v421: string =
                                                                                getValue(
                                                                                    _v403
                                                                                        .get()
                                                                                        .clone(),
                                                                                );
                                                                            replace(sprintf!("{}{}",
                                                                                                       toLower(ofChar(getCharAt(v421.clone(),
                                                                                                                                0_i32))),
                                                                                                       getSlice(v421,
                                                                                                                Some(1_i32),
                                                                                                                None::<i32>)),
                                                                                              string("\\"),
                                                                                              string("/"))
                                                                        }
                                                                    },
                                                                    string("/"),
                                                                    -1_i32,
                                                                    0_i32,
                                                                );
                                                                let v430: i32 = count(v428.clone());
                                                                let v431: LrcPtr<Documents::Mut4> =
                                                                    LrcPtr::new(Documents::Mut4 {
                                                                        l0: MutCell::new(0_i32),
                                                                        l1: MutCell::new(0_i32),
                                                                        l2: MutCell::new(
                                                                            new_empty::<string>(),
                                                                        ),
                                                                    });
                                                                while Documents::method19(
                                                                    v430,
                                                                    v431.clone(),
                                                                ) {
                                                                    let v433: i32 =
                                                                        v431.l0.get().clone();
                                                                    let v436: i32 =
                                                                        v433.wrapping_neg() + v430
                                                                            - 1_i32;
                                                                    let matchValue_4: i32 =
                                                                        v431.l1.get().clone();
                                                                    let v438: Array<string> =
                                                                        v431.l2.get().clone();
                                                                    let v437: i32 = matchValue_4;
                                                                    let v439: string =
                                                                        v428[v436].clone();
                                                                    let patternInput_5: (
                                                                        i32,
                                                                        Array<string>,
                                                                    ) = if string("..")
                                                                        == v439.clone()
                                                                    {
                                                                        (v437 + 1_i32, v438.clone())
                                                                    } else {
                                                                        if 0_i32 == v437 {
                                                                            let v443: Array<
                                                                                string,
                                                                            > = new_array(&[v439]);
                                                                            let v444: i32 =
                                                                                count(v443.clone());
                                                                            let v446: i32 = v444
                                                                                + count(
                                                                                    v438.clone(),
                                                                                );
                                                                            let v447: Array<
                                                                                string,
                                                                            > = new_init(
                                                                                &string(""),
                                                                                v446,
                                                                            );
                                                                            let v448: LrcPtr<
                                                                                Documents::Mut5,
                                                                            > = LrcPtr::new(
                                                                                Documents::Mut5 {
                                                                                    l0:
                                                                                        MutCell::new(
                                                                                            0_i32,
                                                                                        ),
                                                                                },
                                                                            );
                                                                            while
                                                                                Documents::method20(
                                                                                    v446,
                                                                                    v448.clone(),
                                                                                )
                                                                            {
                                                                                let v450: i32 =
                                                                                    v448.l0
                                                                                        .get()
                                                                                        .clone();
                                                                                let v455: string =
                                                                                    if v450 < v444 {
                                                                                        v443[v450]
                                                                                            .clone()
                                                                                    } else {
                                                                                        let v453:
                                                                                                        i32 =
                                                                                                    v450
                                                                                                        -
                                                                                                        v444;
                                                                                        v438[v453]
                                                                                            .clone()
                                                                                    };
                                                                                v447.get_mut()[v450
                                                                                    as usize] =
                                                                                    v455;
                                                                                {
                                                                                    let v456: i32 =
                                                                                        v450 + 1_i32;
                                                                                    v448.l0
                                                                                        .set(v456);
                                                                                    ()
                                                                                }
                                                                            }
                                                                            (v437, v447.clone())
                                                                        } else {
                                                                            (
                                                                                v437 - 1_i32,
                                                                                v438.clone(),
                                                                            )
                                                                        }
                                                                    };
                                                                    let v462: i32 = v433 + 1_i32;
                                                                    v431.l0.set(v462);
                                                                    v431.l1.set(
                                                                        patternInput_5.0.clone(),
                                                                    );
                                                                    v431.l2.set(
                                                                        patternInput_5.1.clone(),
                                                                    );
                                                                    ()
                                                                }
                                                                {
                                                                    let matchValue_6: i32 =
                                                                        v431.l1.get().clone();
                                                                    let v464: Array<string> =
                                                                        v431.l2.get().clone();
                                                                    let v465: LrcPtr<
                                                                        dyn IEnumerable_1<string>,
                                                                    > = delay(Func0::new({
                                                                        let v464 = v464.clone();
                                                                        move || {
                                                                            map_1(
                                                                                Func1::new({
                                                                                    let v464 = v464
                                                                                        .clone();
                                                                                    move
                                                                                                                              |i_1:
                                                                                                                                   i32|
                                                                                                                              v464[i_1].clone()
                                                                                }),
                                                                                rangeNumeric(
                                                                                    0_i32,
                                                                                    1_i32,
                                                                                    count(
                                                                                        v464.clone(
                                                                                        ),
                                                                                    ) - 1_i32,
                                                                                ),
                                                                            )
                                                                        }
                                                                    }));
                                                                    let _v466: MutCell<
                                                                        Option<char>,
                                                                    > = MutCell::new(None::<char>);
                                                                    {
                                                                        let x_17:
                                                                                    char =
                                                                                std::path::MAIN_SEPARATOR;
                                                                        _v466.set(Some(x_17))
                                                                    }
                                                                    join(
                                                                        Documents::method21(
                                                                            ofChar(getValue(
                                                                                _v466.get().clone(),
                                                                            )),
                                                                        ),
                                                                        toArray_1(v465),
                                                                    )
                                                                }
                                                            }
                                                        }
                                                    }
                                                }
                                            }
                                        } else {
                                            let v483: Result<std::path::PathBuf, std::io::Error> =
                                                std::fs::canonicalize(&*v307);
                                            let v485: std::path::PathBuf = v483.unwrap();
                                            let v487: std::path::Display = v485.display();
                                            let _v488: MutCell<Option<std::string::String>> =
                                                MutCell::new(None::<std::string::String>);
                                            {
                                                let x_18: std::string::String = format!("{}", v487);
                                                _v488.set(Some(x_18))
                                            }
                                            {
                                                let v499: std::string::String =
                                                    getValue(_v488.get().clone());
                                                fable_library_rust::String_::fromString(v499)
                                            }
                                        };
                                        _v305.set(Some(x_19))
                                    }
                                    {
                                        let v510: string = getValue(_v305.get().clone());
                                        let _v511: MutCell<Option<string>> =
                                            MutCell::new(None::<string>);
                                        let v513: string = Documents::method12(v84);
                                        let v514: string = Documents::method13(v513.clone());
                                        let v516: &str =
                                            fable_library_rust::String_::LrcStr::as_str(&v514);
                                        let v518: std::string::String = String::from(v516);
                                        let v520: std::path::PathBuf =
                                            std::path::PathBuf::from(v518);
                                        {
                                            let x_28: string = if v520.exists() == false {
                                                let _v524: MutCell<Option<string>> =
                                                    MutCell::new(None::<string>);
                                                let v527: Result<
                                                    std::path::PathBuf,
                                                    std::io::Error,
                                                > = std::env::current_dir();
                                                let v529: std::path::PathBuf = v527.unwrap();
                                                let v531: std::path::Display = v529.display();
                                                let _v532: MutCell<Option<std::string::String>> =
                                                    MutCell::new(None::<std::string::String>);
                                                {
                                                    let x_20: std::string::String =
                                                        format!("{}", v531);
                                                    _v532.set(Some(x_20))
                                                }
                                                {
                                                    let v543: std::string::String =
                                                        getValue(_v532.get().clone());
                                                    {
                                                        let x_21: string =
                                                            fable_library_rust::String_::fromString(
                                                                v543,
                                                            );
                                                        _v524.set(Some(x_21))
                                                    }
                                                    {
                                                        let _v553: MutCell<Option<string>> =
                                                            MutCell::new(None::<string>);
                                                        let v555: string = Documents::method13(
                                                            getValue(_v524.get().clone()),
                                                        );
                                                        let v557: &str =
                                                                fable_library_rust::String_::LrcStr::as_str(&v555);
                                                        let v559: std::string::String =
                                                            String::from(v557);
                                                        let v561: std::path::PathBuf =
                                                            std::path::PathBuf::from(v559);
                                                        let v562: string =
                                                            Documents::method13(v513.clone());
                                                        let v564: &str =
                                                                fable_library_rust::String_::LrcStr::as_str(&v562);
                                                        let v566: std::string::String =
                                                            String::from(v564);
                                                        let v568: std::path::PathBuf =
                                                            v561.join(v566);
                                                        let v570: std::path::Display =
                                                            v568.display();
                                                        let _v571: MutCell<
                                                            Option<std::string::String>,
                                                        > = MutCell::new(
                                                            None::<std::string::String>,
                                                        );
                                                        {
                                                            let x_22: std::string::String =
                                                                format!("{}", v570);
                                                            _v571.set(Some(x_22))
                                                        }
                                                        {
                                                            let v582: std::string::String =
                                                                getValue(_v571.get().clone());
                                                            {
                                                                let x_23:
                                                                            string =
                                                                        fable_library_rust::String_::fromString(v582);
                                                                _v553.set(Some(x_23))
                                                            }
                                                            {
                                                                let v595: string =
                                                                    getValue(_v553.get().clone());
                                                                let _v596: MutCell<Option<bool>> =
                                                                    MutCell::new(None::<bool>);
                                                                {
                                                                    let x_24: bool = cfg!(windows);
                                                                    _v596.set(Some(x_24))
                                                                }
                                                                {
                                                                    let v634: Array<string> = split(
                                                                        if getValue(
                                                                            _v596.get().clone(),
                                                                        ) == false
                                                                        {
                                                                            v595.clone()
                                                                        } else {
                                                                            let _v609: MutCell<
                                                                                Option<string>,
                                                                            > = MutCell::new(
                                                                                None::<string>,
                                                                            );
                                                                            let v611: string =
                                                                                Documents::method16(
                                                                                );
                                                                            let v612: string =
                                                                                Documents::method17(
                                                                                    v595,
                                                                                );
                                                                            let v613: string =
                                                                                Documents::method18(
                                                                                );
                                                                            let v615: &str =
                                                                                &regex::Regex::new(
                                                                                    &v611,
                                                                                )
                                                                                .unwrap()
                                                                                .replace_all(
                                                                                    &v612, &*v613,
                                                                                );
                                                                            let v617:
                                                                                              std::string::String =
                                                                                          String::from(v615);
                                                                            {
                                                                                let x_25:
                                                                                                  string =
                                                                                              fable_library_rust::String_::fromString(v617);
                                                                                _v609
                                                                                    .set(Some(x_25))
                                                                            }
                                                                            {
                                                                                let v627: string =
                                                                                    getValue(
                                                                                        _v609
                                                                                            .get()
                                                                                            .clone(
                                                                                            ),
                                                                                    );
                                                                                replace(sprintf!("{}{}",
                                                                                                           toLower(ofChar(getCharAt(v627.clone(),
                                                                                                                                    0_i32))),
                                                                                                           getSlice(v627,
                                                                                                                    Some(1_i32),
                                                                                                                    None::<i32>)),
                                                                                                  string("\\"),
                                                                                                  string("/"))
                                                                            }
                                                                        },
                                                                        string("/"),
                                                                        -1_i32,
                                                                        0_i32,
                                                                    );
                                                                    let v636: i32 =
                                                                        count(v634.clone());
                                                                    let v637: LrcPtr<
                                                                        Documents::Mut4,
                                                                    > = LrcPtr::new(
                                                                        Documents::Mut4 {
                                                                            l0: MutCell::new(0_i32),
                                                                            l1: MutCell::new(0_i32),
                                                                            l2: MutCell::new(
                                                                                new_empty::<string>(
                                                                                ),
                                                                            ),
                                                                        },
                                                                    );
                                                                    while Documents::method19(
                                                                        v636,
                                                                        v637.clone(),
                                                                    ) {
                                                                        let v639: i32 =
                                                                            v637.l0.get().clone();
                                                                        let v642: i32 = v639
                                                                            .wrapping_neg()
                                                                            + v636
                                                                            - 1_i32;
                                                                        let matchValue_8: i32 =
                                                                            v637.l1.get().clone();
                                                                        let v644: Array<string> =
                                                                            v637.l2.get().clone();
                                                                        let v643: i32 =
                                                                            matchValue_8;
                                                                        let v645: string =
                                                                            v634[v642].clone();
                                                                        let patternInput_8: (
                                                                            i32,
                                                                            Array<string>,
                                                                        ) = if string("..")
                                                                            == v645.clone()
                                                                        {
                                                                            (
                                                                                v643 + 1_i32,
                                                                                v644.clone(),
                                                                            )
                                                                        } else {
                                                                            if 0_i32 == v643 {
                                                                                let v649: Array<
                                                                                    string,
                                                                                > = new_array(&[
                                                                                    v645,
                                                                                ]);
                                                                                let v650: i32 =
                                                                                    count(
                                                                                        v649.clone(
                                                                                        ),
                                                                                    );
                                                                                let v652: i32 = v650
                                                                                    + count(
                                                                                        v644.clone(
                                                                                        ),
                                                                                    );
                                                                                let v653: Array<
                                                                                    string,
                                                                                > = new_init(
                                                                                    &string(""),
                                                                                    v652,
                                                                                );
                                                                                let v654:
                                                                                                LrcPtr<Documents::Mut5> =
                                                                                            LrcPtr::new(Documents::Mut5{l0:
                                                                                                                            MutCell::new(0_i32),});
                                                                                while Documents::method20(v652,
                                                                                                                  v654.clone())
                                                                                              {
                                                                                            let v656:
                                                                                                    i32 =
                                                                                                v654.l0.get().clone();
                                                                                            let v661:
                                                                                                    string =
                                                                                                if v656
                                                                                                       <
                                                                                                       v650
                                                                                                   {
                                                                                                    v649[v656].clone()
                                                                                                } else {
                                                                                                    let v659:
                                                                                                            i32 =
                                                                                                        v656
                                                                                                            -
                                                                                                            v650;
                                                                                                    v644[v659].clone()
                                                                                                };
                                                                                            v653.get_mut()[v656
                                                                                                               as
                                                                                                               usize]
                                                                                                =
                                                                                                v661;
                                                                                            {
                                                                                                let v662:
                                                                                                        i32 =
                                                                                                    v656
                                                                                                        +
                                                                                                        1_i32;
                                                                                                v654.l0.set(v662);
                                                                                                ()
                                                                                            }
                                                                                        }
                                                                                (v643, v653.clone())
                                                                            } else {
                                                                                (
                                                                                    v643 - 1_i32,
                                                                                    v644.clone(),
                                                                                )
                                                                            }
                                                                        };
                                                                        let v668: i32 =
                                                                            v639 + 1_i32;
                                                                        v637.l0.set(v668);
                                                                        v637.l1.set(
                                                                            patternInput_8
                                                                                .0
                                                                                .clone(),
                                                                        );
                                                                        v637.l2.set(
                                                                            patternInput_8
                                                                                .1
                                                                                .clone(),
                                                                        );
                                                                        ()
                                                                    }
                                                                    {
                                                                        let matchValue_10: i32 =
                                                                            v637.l1.get().clone();
                                                                        let v670: Array<string> =
                                                                            v637.l2.get().clone();
                                                                        let v671: LrcPtr<
                                                                            dyn IEnumerable_1<
                                                                                string,
                                                                            >,
                                                                        > = delay(Func0::new({
                                                                            let v670 = v670.clone();
                                                                            move || {
                                                                                map_1(Func1::new({
                                                                                                                              let v670
                                                                                                                                  =
                                                                                                                                  v670.clone();
                                                                                                                              move
                                                                                                                                  |i_2:
                                                                                                                                       i32|
                                                                                                                                  v670[i_2].clone()
                                                                                                                          }),
                                                                                                               rangeNumeric(0_i32,
                                                                                                                            1_i32,
                                                                                                                            count(v670.clone())
                                                                                                                                -
                                                                                                                                1_i32))
                                                                            }
                                                                        }));
                                                                        let _v672: MutCell<
                                                                            Option<char>,
                                                                        > = MutCell::new(
                                                                            None::<char>,
                                                                        );
                                                                        {
                                                                            let x_26:
                                                                                        char =
                                                                                    std::path::MAIN_SEPARATOR;
                                                                            _v672.set(Some(x_26))
                                                                        }
                                                                        join(
                                                                            Documents::method21(
                                                                                ofChar(getValue(
                                                                                    _v672
                                                                                        .get()
                                                                                        .clone(),
                                                                                )),
                                                                            ),
                                                                            toArray_1(v671),
                                                                        )
                                                                    }
                                                                }
                                                            }
                                                        }
                                                    }
                                                }
                                            } else {
                                                let v689: Result<
                                                    std::path::PathBuf,
                                                    std::io::Error,
                                                > = std::fs::canonicalize(&*v513);
                                                let v691: std::path::PathBuf = v689.unwrap();
                                                let v693: std::path::Display = v691.display();
                                                let _v694: MutCell<Option<std::string::String>> =
                                                    MutCell::new(None::<std::string::String>);
                                                {
                                                    let x_27: std::string::String =
                                                        format!("{}", v693);
                                                    _v694.set(Some(x_27))
                                                }
                                                {
                                                    let v705: std::string::String =
                                                        getValue(_v694.get().clone());
                                                    fable_library_rust::String_::fromString(v705)
                                                }
                                            };
                                            _v511.set(Some(x_28))
                                        }
                                        {
                                            let v716: string = getValue(_v511.get().clone());
                                            Documents::method3(
                                                Documents::US0::US0_1,
                                                Func0::new(move || Documents::closure10((), ())),
                                                Func0::new({
                                                    let v304 = v304.clone();
                                                    let v510 = v510.clone();
                                                    let v716 = v716.clone();
                                                    let v98 = v98.clone();
                                                    move || {
                                                        Documents::closure11(
                                                            v98.clone(),
                                                            v304.clone(),
                                                            v510.clone(),
                                                            v716.clone(),
                                                            (),
                                                        )
                                                    }
                                                }),
                                            );
                                            {
                                                let v720: std::pin::Pin<
                                                    Box<
                                                        dyn std::future::Future<
                                                            Output = Result<
                                                                Vec<
                                                                    Result<
                                                                        LrcPtr<(
                                                                            string,
                                                                            Vec<
                                                                                Option<
                                                                                    Result<
                                                                                        string,
                                                                                        LrcPtr<(
                                                                                            string,
                                                                                            string,
                                                                                        )>,
                                                                                    >,
                                                                                >,
                                                                            >,
                                                                        )>,
                                                                        std::string::String,
                                                                    >,
                                                                >,
                                                                std::string::String,
                                                            >,
                                                        >,
                                                    >,
                                                > = Documents::method23(
                                                    v304.clone(),
                                                    v510.clone(),
                                                    v716.clone(),
                                                );
                                                let v722: Result<
                                                    Vec<
                                                        Result<
                                                            LrcPtr<(
                                                                string,
                                                                Vec<
                                                                    Option<
                                                                        Result<
                                                                            string,
                                                                            LrcPtr<(
                                                                                string,
                                                                                string,
                                                                            )>,
                                                                        >,
                                                                    >,
                                                                >,
                                                            )>,
                                                            std::string::String,
                                                        >,
                                                    >,
                                                    std::string::String,
                                                > = futures_lite::future::block_on(v720);
                                                let v724: Vec<
                                                    Result<
                                                        LrcPtr<(
                                                            string,
                                                            Vec<
                                                                Option<
                                                                    Result<
                                                                        string,
                                                                        LrcPtr<(string, string)>,
                                                                    >,
                                                                >,
                                                            >,
                                                        )>,
                                                        std::string::String,
                                                    >,
                                                > = v722.unwrap();
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
