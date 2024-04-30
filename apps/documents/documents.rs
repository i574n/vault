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
        pub fn method17() -> string {
            string("^\\\\\\\\\\?\\\\")
        }
        pub fn method18(v0_1: string) -> string {
            v0_1
        }
        pub fn method19() -> string {
            string("")
        }
        pub fn method20(v0_1: i32, v1_1: LrcPtr<Documents::Mut4>) -> bool {
            v1_1.l0.get().clone() < v0_1
        }
        pub fn method21(v0_1: i32, v1_1: LrcPtr<Documents::Mut5>) -> bool {
            v1_1.l0.get().clone() < v0_1
        }
        pub fn method22(v0_1: string) -> string {
            v0_1
        }
        pub fn method23(v0_1: string) -> string {
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
        pub fn method27(v0_1: async_walkdir::DirEntry) -> async_walkdir::DirEntry {
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
        pub fn method28() -> Func1<std::io::Error, std::string::String> {
            Func1::new(move |v: std::io::Error| Documents::closure13((), v))
        }
        pub fn closure14(unitVar: (), v0_1: std::fs::FileType) -> Documents::US5 {
            Documents::US5::US5_0(v0_1)
        }
        pub fn closure15(unitVar: (), v0_1: std::string::String) -> Documents::US5 {
            Documents::US5::US5_1(v0_1)
        }
        pub fn method29(v0_1: std::fs::FileType) -> std::fs::FileType {
            v0_1
        }
        pub fn method30(v0_1: Documents::US4) -> Documents::US4 {
            v0_1
        }
        pub fn method26(
            v0_1: async_walkdir::DirEntry,
        ) -> std::pin::Pin<Box<dyn std::future::Future<Output = Documents::US4> + Send>> {
            let __result = Box::pin(async move {
                //;
                {
                    let v2: async_walkdir::DirEntry = Documents::method27(v0_1.clone());
                    let v4: std::pin::Pin<
                        Box<
                            dyn std::future::Future<
                                    Output = Result<std::fs::FileType, std::io::Error>,
                                > + Send,
                        >,
                    > = Box::pin(async_walkdir::DirEntry::file_type(&v2));
                    let v6: Result<std::fs::FileType, std::io::Error> = v4.await;
                    let v7 = Documents::method28();
                    let v9: Result<std::fs::FileType, std::string::String> = v6.map_err(|x| v7(x));
                    let v12: Documents::US5 = match &v9 {
                        Err(v9_1_0) => Documents::closure15((), v9_1_0.clone()),
                        Ok(v9_0_0) => Documents::closure14((), v9_0_0.clone()),
                    };
                    let v74: Documents::US4 =
                        Documents::method30(if let Documents::US5::US5_0(v12_0_0) = &v12 {
                            let v14: std::fs::FileType = Documents::method29(match &v12 {
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
        pub fn method31(v0_1: async_walkdir::Filtering) -> async_walkdir::Filtering {
            v0_1
        }
        pub fn method25(
            v0_1: async_walkdir::DirEntry,
        ) -> std::pin::Pin<Box<dyn std::future::Future<Output = async_walkdir::Filtering> + Send>>
        {
            let __result = Box::pin(async {
                //;
                {
                    let v2: std::pin::Pin<
                        Box<dyn std::future::Future<Output = Documents::US4> + Send>,
                    > = Documents::method26(v0_1);
                    let v4: Documents::US4 = v2.await;
                    let v14: async_walkdir::Filtering = Documents::method31(match &v4 {
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
            Documents::method25(v0_1)
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
            let v1_1 = Documents::method28();
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
        pub fn method32() -> Func1<Result<async_walkdir::DirEntry, std::io::Error>, Option<string>>
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
        pub fn method33(
            v0_1: Option<CancellationToken>,
            v1_1: string,
            v2: Array<(string, string)>,
            v3: Option<Func1<(bool, string, i32), Arc<Async<()>>>>,
            v4: Option<string>,
        ) -> string {
            v1_1
        }
        pub fn method34() -> (string, string) {
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
        pub fn method35() -> Func1<char, Func1<LrcPtr<Documents::UH0>, LrcPtr<Documents::UH0>>> {
            Func1::new(move |v: char| Documents::closure24((), v))
        }
        pub fn method36(
            v0_1: string,
            v1_1: string,
            v2: LrcPtr<Documents::UH0>,
            v3: Documents::US8,
        ) -> (string, string) {
            let v0_1: MutCell<string> = MutCell::new(v0_1.clone());
            let v1_1: MutCell<string> = MutCell::new(v1_1.clone());
            let v2: MutCell<LrcPtr<Documents::UH0>> = MutCell::new(v2.clone());
            let v3: MutCell<Documents::US8> = MutCell::new(v3.clone());
            '_method36: loop {
                break '_method36 (if let Documents::UH0::UH0_1(v2_1_0, v2_1_1) =
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
                            continue '_method36;
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
                                        continue '_method36;
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
                                            continue '_method36;
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
                                            continue '_method36;
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
                                        continue '_method36;
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
                                        continue '_method36;
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
                                    continue '_method36;
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
                                continue '_method36;
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
                                            continue '_method36;
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
                                                continue '_method36;
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
                                                continue '_method36;
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
                                            continue '_method36;
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
                                            continue '_method36;
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
                                        continue '_method36;
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
                                            continue '_method36;
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
                                            continue '_method36;
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
                                            continue '_method36;
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
                                            continue '_method36;
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
                                        continue '_method36;
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
                                        continue '_method36;
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
                                    continue '_method36;
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
        pub fn method38() -> Func1<string, Documents::US7> {
            Func1::new(move |v: string| Documents::closure26((), v))
        }
        pub fn method41(
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
                    Documents::method41(
                        match v0_1.as_ref() {
                            Documents::UH1::UH1_1(_, x) => x.clone(),
                            _ => unreachable!(),
                        },
                        v1_1.clone(),
                    ),
                )),
            }
        }
        pub fn method40(
            v0_1: string,
            v1_1: LrcPtr<Documents::UH1>,
            v2: LrcPtr<Documents::UH0>,
            v3: Documents::US10,
        ) -> (LrcPtr<Documents::UH1>, string) {
            let v0_1: MutCell<string> = MutCell::new(v0_1.clone());
            let v1_1: MutCell<LrcPtr<Documents::UH1>> = MutCell::new(v1_1.clone());
            let v2: MutCell<LrcPtr<Documents::UH0>> = MutCell::new(v2.clone());
            let v3: MutCell<Documents::US10> = MutCell::new(v3.clone());
            '_method40: loop {
                break '_method40 (match &v3.get().clone() {
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
                                        Documents::method39(
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
                                                Documents::method39(
                                                    sprintf!("{}\"", v0_1.get().clone()),
                                                    v1_1.get().clone(),
                                                    v108.clone(),
                                                    v3.get().clone(),
                                                    Documents::US10::US10_1('\"'),
                                                )
                                            } else {
                                                if v3.get().clone() == Documents::US10::US10_1('\\')
                                                {
                                                    Documents::method39(
                                                        sprintf!("{}\"", v0_1.get().clone()),
                                                        v1_1.get().clone(),
                                                        v108.clone(),
                                                        v3.get().clone(),
                                                        Documents::US10::US10_1('\"'),
                                                    )
                                                } else {
                                                    Documents::method39(
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
                                                Documents::method39(
                                                    v0_1.get().clone(),
                                                    v1_1.get().clone(),
                                                    v108.clone(),
                                                    v3.get().clone(),
                                                    Documents::US10::US10_2(1_u8),
                                                )
                                            } else {
                                                if v3.get().clone() == Documents::US10::US10_2(0_u8)
                                                {
                                                    Documents::method39(
                                                        sprintf!("{}\"", v0_1.get().clone()),
                                                        v1_1.get().clone(),
                                                        v108.clone(),
                                                        v3.get().clone(),
                                                        Documents::US10::US10_1('\"'),
                                                    )
                                                } else {
                                                    Documents::method39(
                                                        string(""),
                                                        Documents::method41(
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
                                            Documents::method39(
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
                                                continue '_method40;
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
                                                continue '_method40;
                                            }
                                        }
                                    } else {
                                        if '\\' == v107 {
                                            Documents::method39(
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
                                                continue '_method40;
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
                                                continue '_method40;
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
                                            Documents::method41(
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
                                            Documents::method41(
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
                                            Documents::method39(
                                                sprintf!("{}\"", v0_1.get().clone()),
                                                v1_1.get().clone(),
                                                v220.clone(),
                                                v3.get().clone(),
                                                Documents::US10::US10_1('\"'),
                                            )
                                        } else {
                                            if v3.get().clone() == Documents::US10::US10_1('\\') {
                                                Documents::method39(
                                                    sprintf!("{}\"", v0_1.get().clone()),
                                                    v1_1.get().clone(),
                                                    v220.clone(),
                                                    v3.get().clone(),
                                                    Documents::US10::US10_1('\"'),
                                                )
                                            } else {
                                                Documents::method39(
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
                                            Documents::method39(
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
                                                continue '_method40;
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
                                                continue '_method40;
                                            }
                                        }
                                    }
                                } else {
                                    (
                                        if v0_1.get().clone() == string("") {
                                            v1_1.get().clone()
                                        } else {
                                            Documents::method41(
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
                                        Documents::method39(
                                            v0_1.get().clone(),
                                            v1_1.get().clone(),
                                            v270.clone(),
                                            v3.get().clone(),
                                            Documents::US10::US10_2(1_u8),
                                        )
                                    } else {
                                        if '\"' == v269 {
                                            if v3.get().clone() == Documents::US10::US10_2(0_u8) {
                                                Documents::method39(
                                                    sprintf!("{}\"", v0_1.get().clone()),
                                                    v1_1.get().clone(),
                                                    v270.clone(),
                                                    v3.get().clone(),
                                                    Documents::US10::US10_1('\"'),
                                                )
                                            } else {
                                                Documents::method39(
                                                    string(""),
                                                    Documents::method41(
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
                                                continue '_method40;
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
                                                continue '_method40;
                                            }
                                        }
                                    }
                                } else {
                                    (
                                        if v0_1.get().clone() == string("") {
                                            v1_1.get().clone()
                                        } else {
                                            Documents::method41(
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
                                Documents::method39(
                                    string(""),
                                    v1_1.get().clone(),
                                    v5.clone(),
                                    v3.get().clone(),
                                    Documents::US10::US10_1('\"'),
                                )
                            } else {
                                if '\\' == v4 {
                                    Documents::method39(
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
                                                Documents::method41(
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
                                        continue '_method40;
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
                                        continue '_method40;
                                    }
                                }
                            }
                        } else {
                            (
                                if v0_1.get().clone() == string("") {
                                    v1_1.get().clone()
                                } else {
                                    Documents::method41(
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
                                Documents::method39(
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
                                        continue '_method40;
                                    } else {
                                        Documents::method39(
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
                                        continue '_method40;
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
                                                continue '_method40;
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
                                                continue '_method40;
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
                                            continue '_method40;
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
                                        Documents::method41(
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
                                        Documents::method41(
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
        pub fn method39(
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
            '_method39: loop {
                break '_method39 (match &v4.get().clone() {
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
                                        continue '_method39;
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
                                                continue '_method39;
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
                                                    continue '_method39;
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
                                                    continue '_method39;
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
                                                continue '_method39;
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
                                                    continue '_method39;
                                                } else {
                                                    let v0_1_temp: string = string("");
                                                    let v1_1_temp: LrcPtr<Documents::UH1> =
                                                        Documents::method41(
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
                                                    continue '_method39;
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
                                            continue '_method39;
                                        } else {
                                            if ' ' == v108 {
                                                Documents::method40(
                                                    sprintf!("{} ", v0_1.get().clone()),
                                                    v1_1.get().clone(),
                                                    v109.clone(),
                                                    v4.get().clone(),
                                                )
                                            } else {
                                                Documents::method40(
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
                                            continue '_method39;
                                        } else {
                                            if ' ' == v108 {
                                                Documents::method40(
                                                    sprintf!("{} ", v0_1.get().clone()),
                                                    v1_1.get().clone(),
                                                    v109.clone(),
                                                    v4.get().clone(),
                                                )
                                            } else {
                                                Documents::method40(
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
                                            Documents::method41(
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
                                            Documents::method41(
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
                                            continue '_method39;
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
                                                continue '_method39;
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
                                                continue '_method39;
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
                                            continue '_method39;
                                        } else {
                                            if ' ' == v220 {
                                                Documents::method40(
                                                    sprintf!("{} ", v0_1.get().clone()),
                                                    v1_1.get().clone(),
                                                    v221.clone(),
                                                    v4.get().clone(),
                                                )
                                            } else {
                                                Documents::method40(
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
                                            Documents::method41(
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
                                        continue '_method39;
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
                                                continue '_method39;
                                            } else {
                                                let v0_1_temp: string = string("");
                                                let v1_1_temp: LrcPtr<Documents::UH1> =
                                                    Documents::method41(
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
                                                continue '_method39;
                                            }
                                        } else {
                                            if ' ' == v270 {
                                                Documents::method40(
                                                    sprintf!("{} ", v0_1.get().clone()),
                                                    v1_1.get().clone(),
                                                    v271.clone(),
                                                    v4.get().clone(),
                                                )
                                            } else {
                                                Documents::method40(
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
                                            Documents::method41(
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
                                continue '_method39;
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
                                    continue '_method39;
                                } else {
                                    if ' ' == v5 {
                                        Documents::method40(
                                            string(""),
                                            if v0_1.get().clone() == string("") {
                                                v1_1.get().clone()
                                            } else {
                                                Documents::method41(
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
                                        Documents::method40(
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
                                    Documents::method41(
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
                                continue '_method39;
                            } else {
                                if '\"' == v46 {
                                    if if let Documents::US10::US10_0 = &v3.get().clone() {
                                        true
                                    } else {
                                        false
                                    } {
                                        Documents::method40(
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
                                        continue '_method39;
                                    }
                                } else {
                                    if ' ' == v46 {
                                        Documents::method40(
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
                                                continue '_method39;
                                            } else {
                                                Documents::method40(
                                                    sprintf!("{}{}", v0_1.get().clone(), v46),
                                                    v1_1.get().clone(),
                                                    v47.clone(),
                                                    v4.get().clone(),
                                                )
                                            }
                                        } else {
                                            Documents::method40(
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
                                        Documents::method41(
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
                                        Documents::method41(
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
        pub fn method42(v0_1: LrcPtr<Documents::UH1>, v1_1: List<string>) -> List<string> {
            match v0_1.as_ref() {
                Documents::UH1::UH1_0 => v1_1.clone(),
                Documents::UH1::UH1_1(v0_1_1_0, v0_1_1_1) => cons(
                    match v0_1.as_ref() {
                        Documents::UH1::UH1_1(x, _) => x.clone(),
                        _ => unreachable!(),
                    },
                    Documents::method42(
                        match v0_1.as_ref() {
                            Documents::UH1::UH1_1(_, x) => x.clone(),
                            _ => unreachable!(),
                        },
                        v1_1.clone(),
                    ),
                ),
            }
        }
        pub fn method37(v0_1: string) -> Array<string> {
            let _v0: MutCell<Option<Option<string>>> = MutCell::new(None::<Option<string>>);
            _v0.set(Some(Some(v0_1)));
            {
                let v6: Option<string> = getValue(_v0.get().clone());
                let v9: Documents::US7 =
                    defaultValue(Documents::US7::US7_1, map(Documents::method38(), v6));
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
                while Documents::method21(v13, v15.clone()) {
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
                    toArray(Documents::method42(
                        (Documents::method39(
                            string(""),
                            LrcPtr::new(Documents::UH1::UH1_0),
                            foldBack(
                                Func2::new(move |b0: char, b1: LrcPtr<Documents::UH0>| {
                                    (Documents::method35())(b0)(b1)
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
            let v1_1: string = Documents::method14(v0_1);
            let v3: &str = fable_library_rust::String_::LrcStr::as_str(&v1_1);
            String::from(v3)
        }
        pub fn closure28(
            v0_1: Option<CancellationToken>,
            v1_1: string,
            v2: Array<(string, string)>,
            v3: Option<Func1<(bool, string, i32), Arc<Async<()>>>>,
            v4: Option<string>,
            v5: string,
            v6: Vec<std::string::String>,
            unitVar: (),
        ) -> string {
            sprintf!(
                "execute_with_options / file_name: {} / arguments: {:?} / options: {:?}",
                v5,
                v6,
                (v0_1, v1_1, v2, v3, v4)
            )
        }
        pub fn method43() -> Func0<string> {
            Func0::new(move || Documents::closure6((), ()))
        }
        pub fn method45(v0_1: string) -> string {
            v0_1
        }
        pub fn method47(
            v0_1: std::sync::Mutex<Option<std::process::Child>>,
        ) -> std::sync::Mutex<Option<std::process::Child>> {
            v0_1
        }
        pub fn closure29(
            unitVar: (),
            v0_1: std::process::Child,
        ) -> std::sync::Arc<std::sync::Mutex<Option<std::process::Child>>> {
            let v4: std::sync::Mutex<Option<std::process::Child>> =
                Documents::method47(std::sync::Mutex::new(Some(v0_1)));
            std::sync::Arc::new(v4)
        }
        pub fn method46(
        ) -> Func1<std::process::Child, std::sync::Arc<std::sync::Mutex<Option<std::process::Child>>>>
        {
            Func1::new(move |v: std::process::Child| Documents::closure29((), v))
        }
        pub fn method48(
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
        pub fn method49(
            v0_1: std::sync::Arc<std::sync::Mutex<Option<std::process::Child>>>,
        ) -> std::sync::Arc<std::sync::Mutex<Option<std::process::Child>>> {
            v0_1
        }
        pub fn method50(
            v0_1: std::sync::Mutex<Option<std::process::ChildStdout>>,
        ) -> std::sync::Mutex<Option<std::process::ChildStdout>> {
            v0_1
        }
        pub fn method51(
            v0_1: std::sync::Mutex<Option<std::process::ChildStderr>>,
        ) -> std::sync::Mutex<Option<std::process::ChildStderr>> {
            v0_1
        }
        pub fn method52(
            v0_1: std::sync::Arc<std::sync::mpsc::Receiver<std::string::String>>,
        ) -> std::sync::Arc<std::sync::mpsc::Receiver<std::string::String>> {
            v0_1
        }
        pub fn method53(
            v0_1: std::sync::Mutex<std::sync::mpsc::Sender<std::string::String>>,
        ) -> std::sync::Mutex<std::sync::mpsc::Sender<std::string::String>> {
            v0_1
        }
        pub fn method54(
            v0_1: std::sync::Mutex<std::sync::Arc<std::sync::mpsc::Receiver<std::string::String>>>,
        ) -> std::sync::Mutex<std::sync::Arc<std::sync::mpsc::Receiver<std::string::String>>>
        {
            v0_1
        }
        pub fn method55(
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
            let v2 = Documents::method28();
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
                        let v17: string = Documents::method14(sprintf!("[{}]", v12.clone()));
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
                    Documents::closure33(v0_1.clone(), v)
                }
            })
        }
        pub fn method57(
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
            let v2 = Documents::method28();
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
                        let v17: string = Documents::method14(sprintf!("[{}]", v12.clone()));
                        let v19: &str = fable_library_rust::String_::LrcStr::as_str(&v17);
                        String::from(v19)
                    }
                }
            };
            let v25: bool = true;
            v0_1.lock().unwrap().send(v23).unwrap();
            ()
        }
        pub fn method58(
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
        pub fn method59(v0_: i32, v0__1: string) -> LrcPtr<(i32, string)> {
            LrcPtr::new((v0_, v0__1))
        }
        pub fn method44(
            v0_1: Option<CancellationToken>,
            v1_1: string,
            v2: Array<(string, string)>,
            v3: Option<Func1<(bool, string, i32), Arc<Async<()>>>>,
            v4: Option<string>,
            v5: string,
            v6: Vec<std::string::String>,
        ) -> std::pin::Pin<Box<dyn std::future::Future<Output = LrcPtr<(i32, string)>>>> {
            let __result = Box::pin(async move {
                //;
                {
                    let v9: std::process::Command = std::process::Command::new(&*v5);
                    let v11: bool = true;
                    let mut v9 = v9;
                    let v13: &mut std::process::Command =
                        std::process::Command::args(&mut v9, &*v6);
                    let v15: bool = true;
                    let mut v13 = v13;
                    let v17: &mut std::process::Command =
                        std::process::Command::stdout(&mut v13, std::process::Stdio::piped());
                    let v19: bool = true;
                    let mut v17 = v17;
                    let v21: &mut std::process::Command =
                        std::process::Command::stderr(&mut v17, std::process::Stdio::piped());
                    let v24: Documents::US7 =
                        defaultValue(Documents::US7::US7_1, map(Documents::method38(), v4));
                    let v30: &mut std::process::Command = match &v24 {
                        Documents::US7::US7_0(v24_0_0) => {
                            let v26: string = Documents::method45(match &v24 {
                                Documents::US7::US7_0(x) => x.clone(),
                                _ => unreachable!(),
                            });
                            std::process::Command::current_dir(v21, &*v26)
                        }
                        _ => v21,
                    };
                    let v32: bool = true;
                    let mut v30 = v30;
                    let v34: Result<std::process::Child, std::io::Error> =
                        std::process::Command::spawn(&mut v30);
                    let v35 = Documents::method46();
                    let v36: Result<std::process::Child, std::io::Error> = Documents::method48(v34);
                    let v38: Result<
                        std::sync::Arc<std::sync::Mutex<Option<std::process::Child>>>,
                        std::io::Error,
                    > = v36.map(|x| v35(x));
                    let v39 = Documents::method28();
                    let v41: Result<
                        std::sync::Arc<std::sync::Mutex<Option<std::process::Child>>>,
                        std::string::String,
                    > = v38.map_err(|x| v39(x));
                    let v44: Documents::US11 = match &v41 {
                        Err(v41_1_0) => Documents::closure31((), v41_1_0.clone()),
                        Ok(v41_0_0) => Documents::closure30((), v41_0_0.clone()),
                    };
                    let patternInput_1: (i32, Documents::US3, Documents::US12) = match &v44 {
                        Documents::US11::US11_0(v44_0_0) => {
                            let v46: std::sync::Arc<std::sync::Mutex<Option<std::process::Child>>> =
                                Documents::method49(v44_0_0.clone());
                            let v48: std::process::ChildStdout =
                                v46.lock().unwrap().as_mut().unwrap().stdout.take().unwrap();
                            let v50: std::process::ChildStderr =
                                v46.lock().unwrap().as_mut().unwrap().stderr.take().unwrap();
                            let v54: std::sync::Mutex<Option<std::process::ChildStdout>> =
                                Documents::method50(std::sync::Mutex::new(Some(v48)));
                            let v56: std::sync::Arc<
                                std::sync::Mutex<Option<std::process::ChildStdout>>,
                            > = std::sync::Arc::new(v54);
                            let v60: std::sync::Mutex<Option<std::process::ChildStderr>> =
                                Documents::method51(std::sync::Mutex::new(Some(v50)));
                            let v62: std::sync::Arc<
                                std::sync::Mutex<Option<std::process::ChildStderr>>,
                            > = std::sync::Arc::new(v60);
                            let patternInput: (
                                std::sync::mpsc::Sender<std::string::String>,
                                std::sync::Arc<std::sync::mpsc::Receiver<std::string::String>>,
                            ) = {
                                let (sender, receiver) = std::sync::mpsc::channel();
                                (sender, std::sync::Arc::new(receiver))
                            };
                            let v66: std::sync::Arc<
                                std::sync::mpsc::Receiver<std::string::String>,
                            > = Documents::method52(patternInput.1.clone());
                            let v68: bool = true;
                            let v66 = v66;
                            let v71: std::sync::Mutex<
                                std::sync::mpsc::Sender<std::string::String>,
                            > = Documents::method53(std::sync::Mutex::new(patternInput.0.clone()));
                            let v73: std::sync::Arc<
                                std::sync::Mutex<std::sync::mpsc::Sender<std::string::String>>,
                            > = std::sync::Arc::new(v71);
                            let v75: std::sync::Arc<
                                std::sync::Mutex<std::sync::mpsc::Sender<std::string::String>>,
                            > = v73.clone();
                            let v77: std::sync::Arc<
                                std::sync::Mutex<std::sync::mpsc::Sender<std::string::String>>,
                            > = v73.clone();
                            let v80: std::sync::Mutex<
                                std::sync::Arc<std::sync::mpsc::Receiver<std::string::String>>,
                            > = Documents::method54(std::sync::Mutex::new(v66));
                            let v82: std::sync::Arc<
                                std::sync::Mutex<
                                    std::sync::Arc<std::sync::mpsc::Receiver<std::string::String>>,
                                >,
                            > = std::sync::Arc::new(v80);
                            let v84: std::thread::JoinHandle<()> = std::thread::spawn(move || {
                                //;
                                let v86: std::io::Lines<
                                    std::io::BufReader<std::process::ChildStdout>,
                                > = std::io::BufRead::lines(std::io::BufReader::new(
                                    v56.lock().unwrap().take().unwrap(),
                                ));
                                let v89: std::sync::Mutex<
                                    std::io::Lines<std::io::BufReader<std::process::ChildStdout>>,
                                > = Documents::method55(std::sync::Mutex::new(v86));
                                let v91: std::sync::Arc<
                                    std::sync::Mutex<
                                        std::io::Lines<
                                            std::io::BufReader<std::process::ChildStdout>,
                                        >,
                                    >,
                                > = std::sync::Arc::new(v89);
                                let v92 = Documents::method56(v75);
                                let v94: bool = true;
                                for line in v91.lock().unwrap().by_ref() {
                                    v92(line)
                                }
                                let v96: bool = true;
                            });
                            let v98: std::thread::JoinHandle<()> = std::thread::spawn(move || {
                                //;
                                let v100: std::io::Lines<
                                    std::io::BufReader<std::process::ChildStderr>,
                                > = std::io::BufRead::lines(std::io::BufReader::new(
                                    v62.lock().unwrap().take().unwrap(),
                                ));
                                let v103: std::sync::Mutex<
                                    std::io::Lines<std::io::BufReader<std::process::ChildStderr>>,
                                > = Documents::method57(std::sync::Mutex::new(v100));
                                let v105: std::sync::Arc<
                                    std::sync::Mutex<
                                        std::io::Lines<
                                            std::io::BufReader<std::process::ChildStderr>,
                                        >,
                                    >,
                                > = std::sync::Arc::new(v103);
                                let v106 = Documents::method58(v73);
                                let v108: bool = true;
                                for line in v105.lock().unwrap().by_ref() {
                                    v106(line)
                                }
                                let v110: bool = true;
                            });
                            let v112: Result<std::process::Output, std::io::Error> =
                                v46.lock().unwrap().take().unwrap().wait_with_output();
                            let v113 = Documents::method28();
                            let v115: Result<std::process::Output, std::string::String> =
                                v112.map_err(|x| v113(x));
                            let v117: bool = true;
                            v84.join().unwrap();
                            let v119: bool = true;
                            v98.join().unwrap();
                            let v122: Documents::US14 = match &v115 {
                                Err(v115_1_0) => Documents::closure41((), v115_1_0.clone()),
                                Ok(v115_0_0) => Documents::closure40((), v115_0_0.clone()),
                            };
                            match &v122 {
                                Documents::US14::US14_0(v122_0_0) => (
                                    v122_0_0.clone().status.code().unwrap(),
                                    Documents::US3::US3_1,
                                    Documents::US12::US12_0(v82),
                                ),
                                Documents::US14::US14_1(v122_1_0) => {
                                    let v128: std::string::String = v122_1_0.clone();
                                    Documents::method3(
                                        Documents::US0::US0_4,
                                        Func0::new({
                                            let v128 = v128.clone();
                                            move || Documents::closure42(v128.clone(), ())
                                        }),
                                        Func0::new(move || Documents::closure6((), ())),
                                    );
                                    (
                                        -2_i32,
                                        Documents::US3::US3_0(v128.clone()),
                                        Documents::US12::US12_1,
                                    )
                                }
                            }
                        }
                        Documents::US11::US11_1(v44_1_0) => {
                            let v140: std::string::String = v44_1_0.clone();
                            Documents::method3(
                                Documents::US0::US0_4,
                                Func0::new({
                                    let v140 = v140.clone();
                                    move || Documents::closure32(v140.clone(), ())
                                }),
                                Func0::new(move || Documents::closure6((), ())),
                            );
                            (
                                -1_i32,
                                Documents::US3::US3_0(v140.clone()),
                                Documents::US12::US12_1,
                            )
                        }
                    };
                    let v151: Documents::US12 = patternInput_1.2.clone();
                    let v150: Documents::US3 = patternInput_1.1.clone();
                    let v149: i32 = patternInput_1.0.clone();
                    let v158: Documents::US3 = match &v151 {
                        Documents::US12::US12_0(v151_0_0) => Documents::US3::US3_0(
                            match &v151 {
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
                    let v165: Documents::US7 = match &v158 {
                        Documents::US3::US3_0(v158_0_0) => Documents::US7::US7_0(
                            fable_library_rust::String_::fromString(match &v158 {
                                Documents::US3::US3_0(x) => x.clone(),
                                _ => unreachable!(),
                            }),
                        ),
                        _ => Documents::US7::US7_1,
                    };
                    let v172: Documents::US7 = match &v150 {
                        Documents::US3::US3_0(v150_0_0) => Documents::US7::US7_0(
                            fable_library_rust::String_::fromString(match &v150 {
                                Documents::US3::US3_0(x) => x.clone(),
                                _ => unreachable!(),
                            }),
                        ),
                        _ => Documents::US7::US7_1,
                    };
                    let v176: string = match &v172 {
                        Documents::US7::US7_0(v172_0_0) => match &v172 {
                            Documents::US7::US7_0(x) => x.clone(),
                            _ => unreachable!(),
                        },
                        _ => string(""),
                    };
                    let v179: string = match &v165 {
                        Documents::US7::US7_0(v165_0_0) => match &v165 {
                            Documents::US7::US7_0(x) => x.clone(),
                            _ => unreachable!(),
                        },
                        _ => v176,
                    };
                    Documents::method3(
                        Documents::US0::US0_0,
                        Func0::new({
                            let v149 = v149.clone();
                            let v179 = v179.clone();
                            move || Documents::closure43(v149, v179.clone(), ())
                        }),
                        Func0::new(move || Documents::closure6((), ())),
                    );
                    {
                        let v183: LrcPtr<(i32, string)> = LrcPtr::new((v149, v179.clone()));
                        let v184: LrcPtr<(i32, string)> =
                            Documents::method59(v183.0.clone(), v183.1.clone());
                        v184
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
            v2: Array<(string, string)>,
            v3: Option<Func1<(bool, string, i32), Arc<Async<()>>>>,
            v4: Option<string>,
            unitVar: (),
        ) -> string {
            sprintf!(
                "execute_with_options_async / options: {:?}",
                (v0_1, v1_1, v2, v3, v4)
            )
        }
        pub fn closure46(
            unitVar: (),
            v0_1: Func1<(bool, string, i32), Arc<Async<()>>>,
        ) -> Documents::US15 {
            Documents::US15::US15_0(v0_1)
        }
        pub fn method60() -> Func1<Func1<(bool, string, i32), Arc<Async<()>>>, Documents::US15> {
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
            v2: Array<(string, string)>,
            v3: Option<Func1<(bool, string, i32), Arc<Async<()>>>>,
            v4: Option<string>,
            v5: (),
            v6: LrcPtr<ConcurrentStack_1<string>>,
            v7: (),
        ) {
            let _v8: MutCell<Option<Arc<Async<()>>>> = MutCell::new(None::<Arc<Async<()>>>);
            {
                let x: Arc<Async<()>> = defaultOf();
                _v8.set(Some(x))
            }
            {
                let v33: Arc<Async<()>> = getValue(_v8.get().clone());
                let _v34: MutCell<Option<()>> = MutCell::new(None::<()>);
                defaultOf::<()>();
                _v34.set(Some(()));
                getValue(_v34.get().clone());
                ()
            }
        }
        pub fn closure48(
            v0_1: Option<CancellationToken>,
            v1_1: string,
            v2: Array<(string, string)>,
            v3: Option<Func1<(bool, string, i32), Arc<Async<()>>>>,
            v4: Option<string>,
            v5: (),
            v6: LrcPtr<ConcurrentStack_1<string>>,
            v7: (),
        ) {
            let _v8: MutCell<Option<Arc<Async<()>>>> = MutCell::new(None::<Arc<Async<()>>>);
            {
                let x: Arc<Async<()>> = defaultOf();
                _v8.set(Some(x))
            }
            {
                let v34: Arc<Async<()>> = getValue(_v8.get().clone());
                let _v35: MutCell<Option<()>> = MutCell::new(None::<()>);
                defaultOf::<()>();
                _v35.set(Some(()));
                getValue(_v35.get().clone());
                ()
            }
        }
        pub fn closure49(unitVar: (), v0_1: CancellationToken) -> Documents::US16 {
            Documents::US16::US16_0(v0_1)
        }
        pub fn method61() -> Func1<CancellationToken, Documents::US16> {
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
        pub fn method62() -> string {
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
        pub fn method63(v0_1: string) -> string {
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
            let v6: string = Documents::method13(v3);
            let v7: string = Documents::method14(v6.clone());
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
                            let v48: string = Documents::method14(getValue(_v17.get().clone()));
                            let v50: &str = fable_library_rust::String_::LrcStr::as_str(&v48);
                            let v52: std::string::String = String::from(v50);
                            let v54: std::path::PathBuf = std::path::PathBuf::from(v52);
                            let v55: string = Documents::method14(v6.clone());
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
                                                let v104: string = Documents::method17();
                                                let v105: string = Documents::method18(v88);
                                                let v106: string = Documents::method19();
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
                                        while Documents::method20(v129, v130.clone()) {
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
                                                        while Documents::method21(
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
                                                        (0_i32, v146.clone())
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
                                                Documents::method22(ofChar(getValue(
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
                let v210: string = Documents::method14(v209.clone());
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
                            let v254: string = Documents::method17();
                            let v255: string = Documents::method18(v209);
                            let v256: string = Documents::method19();
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
                        let v275: string = Documents::method14(v0_1.clone());
                        let v277: &str = fable_library_rust::String_::LrcStr::as_str(&v275);
                        let v279: std::string::String = String::from(v277);
                        let v281: std::path::PathBuf = std::path::PathBuf::from(v279);
                        let v282: string = Documents::method14(v238.clone());
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
                                        let v331: string = Documents::method17();
                                        let v332: string = Documents::method18(v315);
                                        let v333: string = Documents::method19();
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
                                    let v351: Option<CancellationToken> = None::<CancellationToken>;
                                    let v352: Array<(string, string)> =
                                        new_empty::<(string, string)>();
                                    let v353 = None::<Func1<(bool, string, i32), Arc<Async<()>>>>;
                                    let v354: string =
                                        sprintf!("git ls-tree --format=\'%(objectname)\' origin/gh-pages \"{}\"",
                                                 v349.clone());
                                    let v355: Option<string> = Some(v0_1);
                                    let _v356: MutCell<Option<(i32, string)>> =
                                        MutCell::new(None::<(i32, string)>);
                                    let v358: string = Documents::method33(
                                        v351.clone(),
                                        v354.clone(),
                                        v352.clone(),
                                        v353.clone(),
                                        v355.clone(),
                                    );
                                    let patternInput_3: (string, string) = Documents::method34();
                                    let v361: i32 = length(v358.clone());
                                    let v362: Array<char> = new_init(&'\u{0000}', v361);
                                    let v363: LrcPtr<Documents::Mut5> =
                                        LrcPtr::new(Documents::Mut5 {
                                            l0: MutCell::new(0_i32),
                                        });
                                    while Documents::method21(v361, v363.clone()) {
                                        let v365: i32 = v363.l0.get().clone();
                                        let v366: char = getCharAt(v358.clone(), v365);
                                        v362.get_mut()[v365 as usize] = v366;
                                        {
                                            let v367: i32 = v365 + 1_i32;
                                            v363.l0.set(v367);
                                            ()
                                        }
                                    }
                                    {
                                        let v369: List<char> = ofArray(v362.clone());
                                        let patternInput_4: (string, string) = Documents::method36(
                                            patternInput_3.1.clone(),
                                            patternInput_3.0.clone(),
                                            foldBack(
                                                Func2::new(
                                                    move |b0: char, b1: LrcPtr<Documents::UH0>| {
                                                        (Documents::method35())(b0)(b1)
                                                    },
                                                ),
                                                v369,
                                                LrcPtr::new(Documents::UH0::UH0_0),
                                            ),
                                            Documents::US8::US8_0,
                                        );
                                        let v377: string = patternInput_4.0.clone();
                                        let v379: Array<string> =
                                            Documents::method37(patternInput_4.1.clone());
                                        let v381: Vec<string> = v379.to_vec();
                                        fn v383(v: string) -> std::string::String {
                                            Documents::closure27((), v)
                                        }
                                        let v384: Vec<std::string::String> = v381
                                            .iter()
                                            .map(|x| Func1::from(v383)(x.clone()))
                                            .collect();
                                        Documents::method3(
                                            Documents::US0::US0_1,
                                            Func0::new({
                                                let v351 = v351.clone();
                                                let v352 = v352.clone();
                                                let v353 = v353.clone();
                                                let v354 = v354.clone();
                                                let v355 = v355.clone();
                                                let v377 = v377.clone();
                                                let v384 = v384.clone();
                                                move || {
                                                    Documents::closure28(
                                                        v351.clone(),
                                                        v354.clone(),
                                                        v352.clone(),
                                                        v353.clone(),
                                                        v355.clone(),
                                                        v377.clone(),
                                                        v384.clone(),
                                                        (),
                                                    )
                                                }
                                            }),
                                            Documents::method43(),
                                        );
                                        {
                                            let v388: std::pin::Pin<
                                                Box<
                                                    dyn std::future::Future<
                                                        Output = LrcPtr<(i32, string)>,
                                                    >,
                                                >,
                                            > = Documents::method44(
                                                v351.clone(),
                                                v354.clone(),
                                                v352.clone(),
                                                v353.clone(),
                                                v355.clone(),
                                                v377.clone(),
                                                v384.clone(),
                                            );
                                            let v390: LrcPtr<(i32, string)> =
                                                futures_lite::future::block_on(v388);
                                            _v356.set(Some((v390.0.clone(), v390.1.clone())));
                                            {
                                                let patternInput_5: (i32, string) =
                                                    getValue(_v356.get().clone());
                                                let v571: string = patternInput_5.1.clone();
                                                let _v572: MutCell<Option<string>> =
                                                    MutCell::new(None::<string>);
                                                let v574: string =
                                                    Documents::method14(v1_1.clone());
                                                let v576: &str =
                                                    fable_library_rust::String_::LrcStr::as_str(
                                                        &v574,
                                                    );
                                                let v578: std::string::String = String::from(v576);
                                                let v580: std::path::PathBuf =
                                                    std::path::PathBuf::from(v578);
                                                let v581: string =
                                                    Documents::method14(v238.clone());
                                                let v583: &str =
                                                    fable_library_rust::String_::LrcStr::as_str(
                                                        &v581,
                                                    );
                                                let v585: std::string::String = String::from(v583);
                                                let v587: std::path::PathBuf = v580.join(v585);
                                                let v589: std::path::Display = v587.display();
                                                let _v590: MutCell<Option<std::string::String>> =
                                                    MutCell::new(None::<std::string::String>);
                                                {
                                                    let x_17: std::string::String =
                                                        format!("{}", v589);
                                                    _v590.set(Some(x_17))
                                                }
                                                {
                                                    let v601: std::string::String =
                                                        getValue(_v590.get().clone());
                                                    {
                                                        let x_18: string =
                                                            fable_library_rust::String_::fromString(
                                                                v601,
                                                            );
                                                        _v572.set(Some(x_18))
                                                    }
                                                    {
                                                        let v613: string =
                                                            getValue(_v572.get().clone());
                                                        let _v614: MutCell<Option<bool>> =
                                                            MutCell::new(None::<bool>);
                                                        {
                                                            let x_19: bool = cfg!(windows);
                                                            _v614.set(Some(x_19))
                                                        }
                                                        {
                                                            let v647: string = if getValue(
                                                                _v614.get().clone(),
                                                            ) == false
                                                            {
                                                                v613.clone()
                                                            } else {
                                                                let _v627: MutCell<Option<string>> =
                                                                    MutCell::new(None::<string>);
                                                                let v629: string =
                                                                    Documents::method17();
                                                                let v630: string =
                                                                    Documents::method18(v613);
                                                                let v631: string =
                                                                    Documents::method19();
                                                                let v633: &str =
                                                                    &regex::Regex::new(&v629)
                                                                        .unwrap()
                                                                        .replace_all(&v630, &*v631);
                                                                let v635: std::string::String =
                                                                    String::from(v633);
                                                                {
                                                                    let x_20:
                                                                                string =
                                                                            fable_library_rust::String_::fromString(v635);
                                                                    _v627.set(Some(x_20))
                                                                }
                                                                {
                                                                    let v644: string = getValue(
                                                                        _v627.get().clone(),
                                                                    );
                                                                    replace(
                                                                        sprintf!(
                                                                            "{}{}",
                                                                            toLower(ofChar(
                                                                                getCharAt(
                                                                                    v644.clone(),
                                                                                    0_i32
                                                                                )
                                                                            )),
                                                                            getSlice(
                                                                                v644,
                                                                                Some(1_i32),
                                                                                None::<i32>
                                                                            )
                                                                        ),
                                                                        string("\\"),
                                                                        string("/"),
                                                                    )
                                                                }
                                                            };
                                                            let v649: Option<CancellationToken> =
                                                                None::<CancellationToken>;
                                                            let v650: Array<(string, string)> =
                                                                new_empty::<(string, string)>();
                                                            let v651 = None::<
                                                                Func1<
                                                                    (bool, string, i32),
                                                                    Arc<Async<()>>,
                                                                >,
                                                            >;
                                                            let v652: string = sprintf!(
                                                                "git hash-object \"{}\"",
                                                                v647.clone()
                                                            );
                                                            let v653: Option<string> =
                                                                Some(v1_1.clone());
                                                            let _v654: MutCell<
                                                                Option<(i32, string)>,
                                                            > = MutCell::new(None::<(i32, string)>);
                                                            let v656: string = Documents::method33(
                                                                v649.clone(),
                                                                v652.clone(),
                                                                v650.clone(),
                                                                v651.clone(),
                                                                v653.clone(),
                                                            );
                                                            let patternInput_6: (string, string) =
                                                                Documents::method34();
                                                            let v659: i32 = length(v656.clone());
                                                            let v660: Array<char> =
                                                                new_init(&'\u{0000}', v659);
                                                            let v661: LrcPtr<Documents::Mut5> =
                                                                LrcPtr::new(Documents::Mut5 {
                                                                    l0: MutCell::new(0_i32),
                                                                });
                                                            while Documents::method21(
                                                                v659,
                                                                v661.clone(),
                                                            ) {
                                                                let v663: i32 =
                                                                    v661.l0.get().clone();
                                                                let v664: char =
                                                                    getCharAt(v656.clone(), v663);
                                                                v660.get_mut()[v663 as usize] =
                                                                    v664;
                                                                {
                                                                    let v665: i32 = v663 + 1_i32;
                                                                    v661.l0.set(v665);
                                                                    ()
                                                                }
                                                            }
                                                            {
                                                                let v667: List<char> =
                                                                    ofArray(v660.clone());
                                                                let patternInput_7:
                                                                        (string,
                                                                         string) =
                                                                    Documents::method36(patternInput_6.1.clone(),
                                                                                        patternInput_6.0.clone(),
                                                                                        foldBack(Func2::new(move
                                                                                                                |b0:
                                                                                                                     char,
                                                                                                                 b1:
                                                                                                                     LrcPtr<Documents::UH0>|
                                                                                                                (Documents::method35())(b0)(b1)),
                                                                                                 v667,
                                                                                                 LrcPtr::new(Documents::UH0::UH0_0)),
                                                                                        Documents::US8::US8_0);
                                                                let v675: string =
                                                                    patternInput_7.0.clone();
                                                                let v677: Array<string> =
                                                                    Documents::method37(
                                                                        patternInput_7.1.clone(),
                                                                    );
                                                                let v679: Vec<string> =
                                                                    v677.to_vec();
                                                                let v681: Vec<std::string::String> =
                                                                    v679.iter()
                                                                        .map(|x| {
                                                                            Func1::from(v383)(
                                                                                x.clone(),
                                                                            )
                                                                        })
                                                                        .collect();
                                                                Documents::method3(
                                                                    Documents::US0::US0_1,
                                                                    Func0::new({
                                                                        let v649 = v649.clone();
                                                                        let v650 = v650.clone();
                                                                        let v651 = v651.clone();
                                                                        let v652 = v652.clone();
                                                                        let v653 = v653.clone();
                                                                        let v675 = v675.clone();
                                                                        let v681 = v681.clone();
                                                                        move || {
                                                                            Documents::closure28(
                                                                                v649.clone(),
                                                                                v652.clone(),
                                                                                v650.clone(),
                                                                                v651.clone(),
                                                                                v653.clone(),
                                                                                v675.clone(),
                                                                                v681.clone(),
                                                                                (),
                                                                            )
                                                                        }
                                                                    }),
                                                                    Documents::method43(),
                                                                );
                                                                {
                                                                    let v685: std::pin::Pin<
                                                                        Box<
                                                                            dyn std::future::Future<
                                                                                Output = LrcPtr<(
                                                                                    i32,
                                                                                    string,
                                                                                )>,
                                                                            >,
                                                                        >,
                                                                    > = Documents::method44(
                                                                        v649.clone(),
                                                                        v652.clone(),
                                                                        v650.clone(),
                                                                        v651.clone(),
                                                                        v653.clone(),
                                                                        v675.clone(),
                                                                        v681.clone(),
                                                                    );
                                                                    let v687:
                                                                            LrcPtr<(i32,
                                                                                    string)> =
                                                                        futures_lite::future::block_on(v685);
                                                                    _v654.set(Some((
                                                                        v687.0.clone(),
                                                                        v687.1.clone(),
                                                                    )));
                                                                    {
                                                                        let patternInput_8: (
                                                                            i32,
                                                                            string,
                                                                        ) = getValue(
                                                                            _v654.get().clone(),
                                                                        );
                                                                        let v868: string =
                                                                            patternInput_8
                                                                                .1
                                                                                .clone();
                                                                        let v3929: Array<
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
                                                                            v571.clone(),
                                                                            v868.clone(),
                                                                        ) == false
                                                                        {
                                                                            let _v871: MutCell<
                                                                                Option<bool>,
                                                                            > = MutCell::new(
                                                                                None::<bool>,
                                                                            );
                                                                            {
                                                                                let x_22: bool =
                                                                                    cfg!(windows);
                                                                                _v871
                                                                                    .set(Some(x_22))
                                                                            }
                                                                            {
                                                                                let v905: Option<
                                                                                    string,
                                                                                > = None::<string>;
                                                                                let v906:
                                                                                            Option<CancellationToken> =
                                                                                        None::<CancellationToken>;
                                                                                let v907: Array<(
                                                                                    string,
                                                                                    string,
                                                                                )> = new_empty::<(
                                                                                    string,
                                                                                    string,
                                                                                )>(
                                                                                );
                                                                                let v908 = None::<
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
                                                                                let v909:
                                                                                            string =
                                                                                        sprintf!("pwsh -c \"(Get-FileHash \\\"{}\\\" -Algorithm SHA256).Hash\"",
                                                                                                 if getValue(_v871.get().clone())
                                                                                                        ==
                                                                                                        false
                                                                                                    {
                                                                                                     v647.clone()
                                                                                                 } else {
                                                                                                     let _v884:
                                                                                                             MutCell<Option<string>> =
                                                                                                         MutCell::new(None::<string>);
                                                                                                     let v886:
                                                                                                             string =
                                                                                                         Documents::method17();
                                                                                                     let v887:
                                                                                                             string =
                                                                                                         Documents::method18(v647.clone());
                                                                                                     let v888:
                                                                                                             string =
                                                                                                         Documents::method19();
                                                                                                     let v890:
                                                                                                             &str =
                                                                                                         &regex::Regex::new(&v886).unwrap().replace_all(&v887, &*v888);
                                                                                                     let v892:
                                                                                                             std::string::String =
                                                                                                         String::from(v890);
                                                                                                     {
                                                                                                         let x_23:
                                                                                                                 string =
                                                                                                             fable_library_rust::String_::fromString(v892);
                                                                                                         _v884.set(Some(x_23))
                                                                                                     }
                                                                                                     {
                                                                                                         let v901:
                                                                                                                 string =
                                                                                                             getValue(_v884.get().clone());
                                                                                                         replace(sprintf!("{}{}",
                                                                                                                          toLower(ofChar(getCharAt(v901.clone(),
                                                                                                                                                   0_i32))),
                                                                                                                          getSlice(v901,
                                                                                                                                   Some(1_i32),
                                                                                                                                   None::<i32>)),
                                                                                                                 string("\\"),
                                                                                                                 string("/"))
                                                                                                     }
                                                                                                 });
                                                                                let _v910: MutCell<
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
                                                                                let v912:
                                                                                            string =
                                                                                        Documents::method33(v906.clone(),
                                                                                                            v909.clone(),
                                                                                                            v907.clone(),
                                                                                                            v908.clone(),
                                                                                                            v905.clone());
                                                                                let patternInput_9:
                                                                                            (string,
                                                                                             string) =
                                                                                        Documents::method34();
                                                                                let v915: i32 =
                                                                                    length(
                                                                                        v912.clone(
                                                                                        ),
                                                                                    );
                                                                                let v916: Array<
                                                                                    char,
                                                                                > = new_init(
                                                                                    &'\u{0000}',
                                                                                    v915,
                                                                                );
                                                                                let v917:
                                                                                            LrcPtr<Documents::Mut5> =
                                                                                        LrcPtr::new(Documents::Mut5{l0:
                                                                                                                        MutCell::new(0_i32),});
                                                                                while Documents::method21(v915,
                                                                                                              v917.clone())
                                                                                          {
                                                                                        let v919:
                                                                                                i32 =
                                                                                            v917.l0.get().clone();
                                                                                        let v920:
                                                                                                char =
                                                                                            getCharAt(v912.clone(),
                                                                                                      v919);
                                                                                        v916.get_mut()[v919
                                                                                                           as
                                                                                                           usize]
                                                                                            =
                                                                                            v920;
                                                                                        {
                                                                                            let v921:
                                                                                                    i32 =
                                                                                                v919
                                                                                                    +
                                                                                                    1_i32;
                                                                                            v917.l0.set(v921);
                                                                                            ()
                                                                                        }
                                                                                    }
                                                                                {
                                                                                    let v923: List<
                                                                                        char,
                                                                                    > = ofArray(
                                                                                        v916.clone(
                                                                                        ),
                                                                                    );
                                                                                    let patternInput_10:
                                                                                                (string,
                                                                                                 string) =
                                                                                            Documents::method36(patternInput_9.1.clone(),
                                                                                                                patternInput_9.0.clone(),
                                                                                                                foldBack(Func2::new(move
                                                                                                                                        |b0:
                                                                                                                                             char,
                                                                                                                                         b1:
                                                                                                                                             LrcPtr<Documents::UH0>|
                                                                                                                                        (Documents::method35())(b0)(b1)),
                                                                                                                         v923,
                                                                                                                         LrcPtr::new(Documents::UH0::UH0_0)),
                                                                                                                Documents::US8::US8_0);
                                                                                    let v931:
                                                                                                string =
                                                                                            patternInput_10.0.clone();
                                                                                    let v933:
                                                                                                Array<string> =
                                                                                            Documents::method37(patternInput_10.1.clone());
                                                                                    let v935: Vec<
                                                                                        string,
                                                                                    > = v933
                                                                                        .to_vec();
                                                                                    let v937:
                                                                                                Vec<std::string::String> =
                                                                                            v935.iter().map(|x| Func1::from(v383)(x.clone())).collect();
                                                                                    Documents::method3(Documents::US0::US0_1,
                                                                                                           Func0::new({
                                                                                                                          let v905
                                                                                                                              =
                                                                                                                              v905.clone();
                                                                                                                          let v906
                                                                                                                              =
                                                                                                                              v906.clone();
                                                                                                                          let v907
                                                                                                                              =
                                                                                                                              v907.clone();
                                                                                                                          let v908
                                                                                                                              =
                                                                                                                              v908.clone();
                                                                                                                          let v909
                                                                                                                              =
                                                                                                                              v909.clone();
                                                                                                                          let v931
                                                                                                                              =
                                                                                                                              v931.clone();
                                                                                                                          let v937
                                                                                                                              =
                                                                                                                              v937.clone();
                                                                                                                          move
                                                                                                                              ||
                                                                                                                              Documents::closure28(v906.clone(),
                                                                                                                                                   v909.clone(),
                                                                                                                                                   v907.clone(),
                                                                                                                                                   v908.clone(),
                                                                                                                                                   v905.clone(),
                                                                                                                                                   v931.clone(),
                                                                                                                                                   v937.clone(),
                                                                                                                                                   ())
                                                                                                                      }),
                                                                                                           Documents::method43());
                                                                                    {
                                                                                        let v941:
                                                                                                    std::pin::Pin<Box<dyn std::future::Future<Output = LrcPtr<(i32,
                                                                                                                                                               string)>>>> =
                                                                                                Documents::method44(v906.clone(),
                                                                                                                    v909.clone(),
                                                                                                                    v907.clone(),
                                                                                                                    v908.clone(),
                                                                                                                    v905.clone(),
                                                                                                                    v931.clone(),
                                                                                                                    v937.clone());
                                                                                        let v943:
                                                                                                    LrcPtr<(i32,
                                                                                                            string)> =
                                                                                                futures_lite::future::block_on(v941);
                                                                                        _v910.set(Some((v943.0.clone(),
                                                                                                            v943.1.clone())));
                                                                                        {
                                                                                            let v1124:
                                                                                                        string =
                                                                                                    (getValue(_v910.get().clone())).1.clone();
                                                                                            let _v1125:
                                                                                                        MutCell<Option<string>> =
                                                                                                    MutCell::new(None::<string>);
                                                                                            let v1127:
                                                                                                        string =
                                                                                                    Documents::method14(v2);
                                                                                            let v1129:
                                                                                                        &str =
                                                                                                    fable_library_rust::String_::LrcStr::as_str(&v1127);
                                                                                            let v1131:
                                                                                                        std::string::String =
                                                                                                    String::from(v1129);
                                                                                            let v1133:
                                                                                                        std::path::PathBuf =
                                                                                                    std::path::PathBuf::from(v1131);
                                                                                            let v1134:
                                                                                                        string =
                                                                                                    Documents::method14(v238.clone());
                                                                                            let v1136:
                                                                                                        &str =
                                                                                                    fable_library_rust::String_::LrcStr::as_str(&v1134);
                                                                                            let v1138:
                                                                                                        std::string::String =
                                                                                                    String::from(v1136);
                                                                                            let v1140:
                                                                                                        std::path::PathBuf =
                                                                                                    v1133.join(v1138);
                                                                                            let v1142:
                                                                                                        std::path::Display =
                                                                                                    v1140.display();
                                                                                            let _v1143:
                                                                                                        MutCell<Option<std::string::String>> =
                                                                                                    MutCell::new(None::<std::string::String>);
                                                                                            {
                                                                                                let x_25:
                                                                                                            std::string::String =
                                                                                                        format!("{}", v1142);
                                                                                                _v1143.set(Some(x_25))
                                                                                            }
                                                                                            {
                                                                                                let v1154:
                                                                                                            std::string::String =
                                                                                                        getValue(_v1143.get().clone());
                                                                                                {
                                                                                                    let x_26:
                                                                                                                string =
                                                                                                            fable_library_rust::String_::fromString(v1154);
                                                                                                    _v1125.set(Some(x_26))
                                                                                                }
                                                                                                {
                                                                                                    let v1166:
                                                                                                                string =
                                                                                                            getValue(_v1125.get().clone());
                                                                                                    let _v1167:
                                                                                                                MutCell<Option<bool>> =
                                                                                                            MutCell::new(None::<bool>);
                                                                                                    {
                                                                                                        let x_27:
                                                                                                                    bool =
                                                                                                                cfg!(windows);
                                                                                                        _v1167.set(Some(x_27))
                                                                                                    }
                                                                                                    {
                                                                                                        let v1200:
                                                                                                                    string =
                                                                                                                if getValue(_v1167.get().clone())
                                                                                                                       ==
                                                                                                                       false
                                                                                                                   {
                                                                                                                    v1166.clone()
                                                                                                                } else {
                                                                                                                    let _v1180:
                                                                                                                            MutCell<Option<string>> =
                                                                                                                        MutCell::new(None::<string>);
                                                                                                                    let v1182:
                                                                                                                            string =
                                                                                                                        Documents::method17();
                                                                                                                    let v1183:
                                                                                                                            string =
                                                                                                                        Documents::method18(v1166);
                                                                                                                    let v1184:
                                                                                                                            string =
                                                                                                                        Documents::method19();
                                                                                                                    let v1186:
                                                                                                                            &str =
                                                                                                                        &regex::Regex::new(&v1182).unwrap().replace_all(&v1183, &*v1184);
                                                                                                                    let v1188:
                                                                                                                            std::string::String =
                                                                                                                        String::from(v1186);
                                                                                                                    {
                                                                                                                        let x_28:
                                                                                                                                string =
                                                                                                                            fable_library_rust::String_::fromString(v1188);
                                                                                                                        _v1180.set(Some(x_28))
                                                                                                                    }
                                                                                                                    {
                                                                                                                        let v1197:
                                                                                                                                string =
                                                                                                                            getValue(_v1180.get().clone());
                                                                                                                        replace(sprintf!("{}{}",
                                                                                                                                         toLower(ofChar(getCharAt(v1197.clone(),
                                                                                                                                                                  0_i32))),
                                                                                                                                         getSlice(v1197,
                                                                                                                                                  Some(1_i32),
                                                                                                                                                  None::<i32>)),
                                                                                                                                string("\\"),
                                                                                                                                string("/"))
                                                                                                                    }
                                                                                                                };
                                                                                                        let _v1201:
                                                                                                                    MutCell<Option<bool>> =
                                                                                                                MutCell::new(None::<bool>);
                                                                                                        let v1203:
                                                                                                                    string =
                                                                                                                Documents::method14(v1200.clone());
                                                                                                        let v1205:
                                                                                                                    &str =
                                                                                                                fable_library_rust::String_::LrcStr::as_str(&v1203);
                                                                                                        let v1207:
                                                                                                                    std::string::String =
                                                                                                                String::from(v1205);
                                                                                                        let v1209:
                                                                                                                    std::path::PathBuf =
                                                                                                                std::path::PathBuf::from(v1207);
                                                                                                        {
                                                                                                            let x_29:
                                                                                                                        bool =
                                                                                                                    if v1209.clone().exists()
                                                                                                                       {
                                                                                                                        v1209.is_file()
                                                                                                                    } else {
                                                                                                                        false
                                                                                                                    };
                                                                                                            _v1201.set(Some(x_29))
                                                                                                        }
                                                                                                        {
                                                                                                            let v1479:
                                                                                                                        string =
                                                                                                                    if getValue(_v1201.get().clone())
                                                                                                                       {
                                                                                                                        let _v1225:
                                                                                                                                MutCell<Option<bool>> =
                                                                                                                            MutCell::new(None::<bool>);
                                                                                                                        {
                                                                                                                            let x_30:
                                                                                                                                    bool =
                                                                                                                                cfg!(windows);
                                                                                                                            _v1225.set(Some(x_30))
                                                                                                                        }
                                                                                                                        {
                                                                                                                            let v1259:
                                                                                                                                    Option<string> =
                                                                                                                                None::<string>;
                                                                                                                            let v1260:
                                                                                                                                    Option<CancellationToken> =
                                                                                                                                None::<CancellationToken>;
                                                                                                                            let v1261:
                                                                                                                                    Array<(string,
                                                                                                                                           string)> =
                                                                                                                                new_empty::<(string,
                                                                                                                                             string)>();
                                                                                                                            let v1262 =
                                                                                                                                None::<Func1<(bool,
                                                                                                                                              string,
                                                                                                                                              i32),
                                                                                                                                             Arc<Async<()>>>>;
                                                                                                                            let v1263:
                                                                                                                                    string =
                                                                                                                                sprintf!("pwsh -c \"(Get-FileHash \\\"{}\\\" -Algorithm SHA256).Hash\"",
                                                                                                                                         if getValue(_v1225.get().clone())
                                                                                                                                                ==
                                                                                                                                                false
                                                                                                                                            {
                                                                                                                                             v1200.clone()
                                                                                                                                         } else {
                                                                                                                                             let _v1238:
                                                                                                                                                     MutCell<Option<string>> =
                                                                                                                                                 MutCell::new(None::<string>);
                                                                                                                                             let v1240:
                                                                                                                                                     string =
                                                                                                                                                 Documents::method17();
                                                                                                                                             let v1241:
                                                                                                                                                     string =
                                                                                                                                                 Documents::method18(v1200.clone());
                                                                                                                                             let v1242:
                                                                                                                                                     string =
                                                                                                                                                 Documents::method19();
                                                                                                                                             let v1244:
                                                                                                                                                     &str =
                                                                                                                                                 &regex::Regex::new(&v1240).unwrap().replace_all(&v1241, &*v1242);
                                                                                                                                             let v1246:
                                                                                                                                                     std::string::String =
                                                                                                                                                 String::from(v1244);
                                                                                                                                             {
                                                                                                                                                 let x_31:
                                                                                                                                                         string =
                                                                                                                                                     fable_library_rust::String_::fromString(v1246);
                                                                                                                                                 _v1238.set(Some(x_31))
                                                                                                                                             }
                                                                                                                                             {
                                                                                                                                                 let v1255:
                                                                                                                                                         string =
                                                                                                                                                     getValue(_v1238.get().clone());
                                                                                                                                                 replace(sprintf!("{}{}",
                                                                                                                                                                  toLower(ofChar(getCharAt(v1255.clone(),
                                                                                                                                                                                           0_i32))),
                                                                                                                                                                  getSlice(v1255,
                                                                                                                                                                           Some(1_i32),
                                                                                                                                                                           None::<i32>)),
                                                                                                                                                         string("\\"),
                                                                                                                                                         string("/"))
                                                                                                                                             }
                                                                                                                                         });
                                                                                                                            let _v1264:
                                                                                                                                    MutCell<Option<(i32,
                                                                                                                                                    string)>> =
                                                                                                                                MutCell::new(None::<(i32,
                                                                                                                                                     string)>);
                                                                                                                            let v1266:
                                                                                                                                    string =
                                                                                                                                Documents::method33(v1260.clone(),
                                                                                                                                                    v1263.clone(),
                                                                                                                                                    v1261.clone(),
                                                                                                                                                    v1262.clone(),
                                                                                                                                                    v1259.clone());
                                                                                                                            let patternInput_12:
                                                                                                                                    (string,
                                                                                                                                     string) =
                                                                                                                                Documents::method34();
                                                                                                                            let v1269:
                                                                                                                                    i32 =
                                                                                                                                length(v1266.clone());
                                                                                                                            let v1270:
                                                                                                                                    Array<char> =
                                                                                                                                new_init(&'\u{0000}',
                                                                                                                                         v1269);
                                                                                                                            let v1271:
                                                                                                                                    LrcPtr<Documents::Mut5> =
                                                                                                                                LrcPtr::new(Documents::Mut5{l0:
                                                                                                                                                                MutCell::new(0_i32),});
                                                                                                                            while Documents::method21(v1269,
                                                                                                                                                      v1271.clone())
                                                                                                                                  {
                                                                                                                                let v1273:
                                                                                                                                        i32 =
                                                                                                                                    v1271.l0.get().clone();
                                                                                                                                let v1274:
                                                                                                                                        char =
                                                                                                                                    getCharAt(v1266.clone(),
                                                                                                                                              v1273);
                                                                                                                                v1270.get_mut()[v1273
                                                                                                                                                    as
                                                                                                                                                    usize]
                                                                                                                                    =
                                                                                                                                    v1274;
                                                                                                                                {
                                                                                                                                    let v1275:
                                                                                                                                            i32 =
                                                                                                                                        v1273
                                                                                                                                            +
                                                                                                                                            1_i32;
                                                                                                                                    v1271.l0.set(v1275);
                                                                                                                                    ()
                                                                                                                                }
                                                                                                                            }
                                                                                                                            {
                                                                                                                                let v1277:
                                                                                                                                        List<char> =
                                                                                                                                    ofArray(v1270.clone());
                                                                                                                                let patternInput_13:
                                                                                                                                        (string,
                                                                                                                                         string) =
                                                                                                                                    Documents::method36(patternInput_12.1.clone(),
                                                                                                                                                        patternInput_12.0.clone(),
                                                                                                                                                        foldBack(Func2::new(move
                                                                                                                                                                                |b0:
                                                                                                                                                                                     char,
                                                                                                                                                                                 b1:
                                                                                                                                                                                     LrcPtr<Documents::UH0>|
                                                                                                                                                                                (Documents::method35())(b0)(b1)),
                                                                                                                                                                 v1277,
                                                                                                                                                                 LrcPtr::new(Documents::UH0::UH0_0)),
                                                                                                                                                        Documents::US8::US8_0);
                                                                                                                                let v1285:
                                                                                                                                        string =
                                                                                                                                    patternInput_13.0.clone();
                                                                                                                                let v1287:
                                                                                                                                        Array<string> =
                                                                                                                                    Documents::method37(patternInput_13.1.clone());
                                                                                                                                let v1289:
                                                                                                                                        Vec<string> =
                                                                                                                                    v1287.to_vec();
                                                                                                                                let v1291:
                                                                                                                                        Vec<std::string::String> =
                                                                                                                                    v1289.iter().map(|x| Func1::from(v383)(x.clone())).collect();
                                                                                                                                Documents::method3(Documents::US0::US0_1,
                                                                                                                                                   Func0::new({
                                                                                                                                                                  let v1259
                                                                                                                                                                      =
                                                                                                                                                                      v1259.clone();
                                                                                                                                                                  let v1260
                                                                                                                                                                      =
                                                                                                                                                                      v1260.clone();
                                                                                                                                                                  let v1261
                                                                                                                                                                      =
                                                                                                                                                                      v1261.clone();
                                                                                                                                                                  let v1262
                                                                                                                                                                      =
                                                                                                                                                                      v1262.clone();
                                                                                                                                                                  let v1263
                                                                                                                                                                      =
                                                                                                                                                                      v1263.clone();
                                                                                                                                                                  let v1285
                                                                                                                                                                      =
                                                                                                                                                                      v1285.clone();
                                                                                                                                                                  let v1291
                                                                                                                                                                      =
                                                                                                                                                                      v1291.clone();
                                                                                                                                                                  move
                                                                                                                                                                      ||
                                                                                                                                                                      Documents::closure28(v1260.clone(),
                                                                                                                                                                                           v1263.clone(),
                                                                                                                                                                                           v1261.clone(),
                                                                                                                                                                                           v1262.clone(),
                                                                                                                                                                                           v1259.clone(),
                                                                                                                                                                                           v1285.clone(),
                                                                                                                                                                                           v1291.clone(),
                                                                                                                                                                                           ())
                                                                                                                                                              }),
                                                                                                                                                   Documents::method43());
                                                                                                                                {
                                                                                                                                    let v1295:
                                                                                                                                            std::pin::Pin<Box<dyn std::future::Future<Output = LrcPtr<(i32,
                                                                                                                                                                                                       string)>>>> =
                                                                                                                                        Documents::method44(v1260.clone(),
                                                                                                                                                            v1263.clone(),
                                                                                                                                                            v1261.clone(),
                                                                                                                                                            v1262.clone(),
                                                                                                                                                            v1259.clone(),
                                                                                                                                                            v1285.clone(),
                                                                                                                                                            v1291.clone());
                                                                                                                                    let v1297:
                                                                                                                                            LrcPtr<(i32,
                                                                                                                                                    string)> =
                                                                                                                                        futures_lite::future::block_on(v1295);
                                                                                                                                    _v1264.set(Some((v1297.0.clone(),
                                                                                                                                                     v1297.1.clone())));
                                                                                                                                    (getValue(_v1264.get().clone())).1.clone()
                                                                                                                                }
                                                                                                                            }
                                                                                                                        }
                                                                                                                    } else {
                                                                                                                        string("")
                                                                                                                    };
                                                                                                            if v1124.clone()
                                                                                                                       !=
                                                                                                                       v1479.clone()
                                                                                                                   {
                                                                                                                    let v1483:
                                                                                                                            string =
                                                                                                                        sprintf!("{}.{}",
                                                                                                                                 v647.clone(),
                                                                                                                                 string("epub"));
                                                                                                                    let v1484:
                                                                                                                            string =
                                                                                                                        sprintf!("{}.{}",
                                                                                                                                 v1200.clone(),
                                                                                                                                 string("epub"));
                                                                                                                    let _v1485:
                                                                                                                            MutCell<Option<bool>> =
                                                                                                                        MutCell::new(None::<bool>);
                                                                                                                    let v1487:
                                                                                                                            string =
                                                                                                                        Documents::method14(v1483.clone());
                                                                                                                    let v1489:
                                                                                                                            &str =
                                                                                                                        fable_library_rust::String_::LrcStr::as_str(&v1487);
                                                                                                                    let v1491:
                                                                                                                            std::string::String =
                                                                                                                        String::from(v1489);
                                                                                                                    let v1493:
                                                                                                                            std::path::PathBuf =
                                                                                                                        std::path::PathBuf::from(v1491);
                                                                                                                    {
                                                                                                                        let x_33:
                                                                                                                                bool =
                                                                                                                            if v1493.clone().exists()
                                                                                                                               {
                                                                                                                                v1493.is_file()
                                                                                                                            } else {
                                                                                                                                false
                                                                                                                            };
                                                                                                                        _v1485.set(Some(x_33))
                                                                                                                    }
                                                                                                                    {
                                                                                                                        let v2285:
                                                                                                                                Documents::US17 =
                                                                                                                            if (if if getValue(_v1485.get().clone())
                                                                                                                                      {
                                                                                                                                       let _v1508:
                                                                                                                                               MutCell<Option<bool>> =
                                                                                                                                           MutCell::new(None::<bool>);
                                                                                                                                       let v1510:
                                                                                                                                               string =
                                                                                                                                           Documents::method14(v1484.clone());
                                                                                                                                       let v1512:
                                                                                                                                               &str =
                                                                                                                                           fable_library_rust::String_::LrcStr::as_str(&v1510);
                                                                                                                                       let v1514:
                                                                                                                                               std::string::String =
                                                                                                                                           String::from(v1512);
                                                                                                                                       let v1516:
                                                                                                                                               std::path::PathBuf =
                                                                                                                                           std::path::PathBuf::from(v1514);
                                                                                                                                       {
                                                                                                                                           let x_34:
                                                                                                                                                   bool =
                                                                                                                                               if v1516.clone().exists()
                                                                                                                                                  {
                                                                                                                                                   v1516.is_file()
                                                                                                                                               } else {
                                                                                                                                                   false
                                                                                                                                               };
                                                                                                                                           _v1508.set(Some(x_34))
                                                                                                                                       }
                                                                                                                                       getValue(_v1508.get().clone())
                                                                                                                                   } else {
                                                                                                                                       false
                                                                                                                                   }
                                                                                                                                   {
                                                                                                                                    let _v1532:
                                                                                                                                            MutCell<Option<bool>> =
                                                                                                                                        MutCell::new(None::<bool>);
                                                                                                                                    {
                                                                                                                                        let x_35:
                                                                                                                                                bool =
                                                                                                                                            cfg!(windows);
                                                                                                                                        _v1532.set(Some(x_35))
                                                                                                                                    }
                                                                                                                                    {
                                                                                                                                        let v1566:
                                                                                                                                                Option<string> =
                                                                                                                                            None::<string>;
                                                                                                                                        let v1567:
                                                                                                                                                Option<CancellationToken> =
                                                                                                                                            None::<CancellationToken>;
                                                                                                                                        let v1568:
                                                                                                                                                Array<(string,
                                                                                                                                                       string)> =
                                                                                                                                            new_empty::<(string,
                                                                                                                                                         string)>();
                                                                                                                                        let v1569 =
                                                                                                                                            None::<Func1<(bool,
                                                                                                                                                          string,
                                                                                                                                                          i32),
                                                                                                                                                         Arc<Async<()>>>>;
                                                                                                                                        let v1570:
                                                                                                                                                string =
                                                                                                                                            sprintf!("pwsh -c \"(Get-FileHash \\\"{}\\\" -Algorithm SHA256).Hash\"",
                                                                                                                                                     if getValue(_v1532.get().clone())
                                                                                                                                                            ==
                                                                                                                                                            false
                                                                                                                                                        {
                                                                                                                                                         v1483.clone()
                                                                                                                                                     } else {
                                                                                                                                                         let _v1545:
                                                                                                                                                                 MutCell<Option<string>> =
                                                                                                                                                             MutCell::new(None::<string>);
                                                                                                                                                         let v1547:
                                                                                                                                                                 string =
                                                                                                                                                             Documents::method17();
                                                                                                                                                         let v1548:
                                                                                                                                                                 string =
                                                                                                                                                             Documents::method18(v1483.clone());
                                                                                                                                                         let v1549:
                                                                                                                                                                 string =
                                                                                                                                                             Documents::method19();
                                                                                                                                                         let v1551:
                                                                                                                                                                 &str =
                                                                                                                                                             &regex::Regex::new(&v1547).unwrap().replace_all(&v1548, &*v1549);
                                                                                                                                                         let v1553:
                                                                                                                                                                 std::string::String =
                                                                                                                                                             String::from(v1551);
                                                                                                                                                         {
                                                                                                                                                             let x_36:
                                                                                                                                                                     string =
                                                                                                                                                                 fable_library_rust::String_::fromString(v1553);
                                                                                                                                                             _v1545.set(Some(x_36))
                                                                                                                                                         }
                                                                                                                                                         {
                                                                                                                                                             let v1562:
                                                                                                                                                                     string =
                                                                                                                                                                 getValue(_v1545.get().clone());
                                                                                                                                                             replace(sprintf!("{}{}",
                                                                                                                                                                              toLower(ofChar(getCharAt(v1562.clone(),
                                                                                                                                                                                                       0_i32))),
                                                                                                                                                                              getSlice(v1562,
                                                                                                                                                                                       Some(1_i32),
                                                                                                                                                                                       None::<i32>)),
                                                                                                                                                                     string("\\"),
                                                                                                                                                                     string("/"))
                                                                                                                                                         }
                                                                                                                                                     });
                                                                                                                                        let _v1571:
                                                                                                                                                MutCell<Option<(i32,
                                                                                                                                                                string)>> =
                                                                                                                                            MutCell::new(None::<(i32,
                                                                                                                                                                 string)>);
                                                                                                                                        let v1573:
                                                                                                                                                string =
                                                                                                                                            Documents::method33(v1567.clone(),
                                                                                                                                                                v1570.clone(),
                                                                                                                                                                v1568.clone(),
                                                                                                                                                                v1569.clone(),
                                                                                                                                                                v1566.clone());
                                                                                                                                        let patternInput_15:
                                                                                                                                                (string,
                                                                                                                                                 string) =
                                                                                                                                            Documents::method34();
                                                                                                                                        let v1576:
                                                                                                                                                i32 =
                                                                                                                                            length(v1573.clone());
                                                                                                                                        let v1577:
                                                                                                                                                Array<char> =
                                                                                                                                            new_init(&'\u{0000}',
                                                                                                                                                     v1576);
                                                                                                                                        let v1578:
                                                                                                                                                LrcPtr<Documents::Mut5> =
                                                                                                                                            LrcPtr::new(Documents::Mut5{l0:
                                                                                                                                                                            MutCell::new(0_i32),});
                                                                                                                                        while Documents::method21(v1576,
                                                                                                                                                                  v1578.clone())
                                                                                                                                              {
                                                                                                                                            let v1580:
                                                                                                                                                    i32 =
                                                                                                                                                v1578.l0.get().clone();
                                                                                                                                            let v1581:
                                                                                                                                                    char =
                                                                                                                                                getCharAt(v1573.clone(),
                                                                                                                                                          v1580);
                                                                                                                                            v1577.get_mut()[v1580
                                                                                                                                                                as
                                                                                                                                                                usize]
                                                                                                                                                =
                                                                                                                                                v1581;
                                                                                                                                            {
                                                                                                                                                let v1582:
                                                                                                                                                        i32 =
                                                                                                                                                    v1580
                                                                                                                                                        +
                                                                                                                                                        1_i32;
                                                                                                                                                v1578.l0.set(v1582);
                                                                                                                                                ()
                                                                                                                                            }
                                                                                                                                        }
                                                                                                                                        {
                                                                                                                                            let v1584:
                                                                                                                                                    List<char> =
                                                                                                                                                ofArray(v1577.clone());
                                                                                                                                            let patternInput_16:
                                                                                                                                                    (string,
                                                                                                                                                     string) =
                                                                                                                                                Documents::method36(patternInput_15.1.clone(),
                                                                                                                                                                    patternInput_15.0.clone(),
                                                                                                                                                                    foldBack(Func2::new(move
                                                                                                                                                                                            |b0:
                                                                                                                                                                                                 char,
                                                                                                                                                                                             b1:
                                                                                                                                                                                                 LrcPtr<Documents::UH0>|
                                                                                                                                                                                            (Documents::method35())(b0)(b1)),
                                                                                                                                                                             v1584,
                                                                                                                                                                             LrcPtr::new(Documents::UH0::UH0_0)),
                                                                                                                                                                    Documents::US8::US8_0);
                                                                                                                                            let v1592:
                                                                                                                                                    string =
                                                                                                                                                patternInput_16.0.clone();
                                                                                                                                            let v1594:
                                                                                                                                                    Array<string> =
                                                                                                                                                Documents::method37(patternInput_16.1.clone());
                                                                                                                                            let v1596:
                                                                                                                                                    Vec<string> =
                                                                                                                                                v1594.to_vec();
                                                                                                                                            let v1598:
                                                                                                                                                    Vec<std::string::String> =
                                                                                                                                                v1596.iter().map(|x| Func1::from(v383)(x.clone())).collect();
                                                                                                                                            Documents::method3(Documents::US0::US0_1,
                                                                                                                                                               Func0::new({
                                                                                                                                                                              let v1566
                                                                                                                                                                                  =
                                                                                                                                                                                  v1566.clone();
                                                                                                                                                                              let v1567
                                                                                                                                                                                  =
                                                                                                                                                                                  v1567.clone();
                                                                                                                                                                              let v1568
                                                                                                                                                                                  =
                                                                                                                                                                                  v1568.clone();
                                                                                                                                                                              let v1569
                                                                                                                                                                                  =
                                                                                                                                                                                  v1569.clone();
                                                                                                                                                                              let v1570
                                                                                                                                                                                  =
                                                                                                                                                                                  v1570.clone();
                                                                                                                                                                              let v1592
                                                                                                                                                                                  =
                                                                                                                                                                                  v1592.clone();
                                                                                                                                                                              let v1598
                                                                                                                                                                                  =
                                                                                                                                                                                  v1598.clone();
                                                                                                                                                                              move
                                                                                                                                                                                  ||
                                                                                                                                                                                  Documents::closure28(v1567.clone(),
                                                                                                                                                                                                       v1570.clone(),
                                                                                                                                                                                                       v1568.clone(),
                                                                                                                                                                                                       v1569.clone(),
                                                                                                                                                                                                       v1566.clone(),
                                                                                                                                                                                                       v1592.clone(),
                                                                                                                                                                                                       v1598.clone(),
                                                                                                                                                                                                       ())
                                                                                                                                                                          }),
                                                                                                                                                               Documents::method43());
                                                                                                                                            {
                                                                                                                                                let v1602:
                                                                                                                                                        std::pin::Pin<Box<dyn std::future::Future<Output = LrcPtr<(i32,
                                                                                                                                                                                                                   string)>>>> =
                                                                                                                                                    Documents::method44(v1567.clone(),
                                                                                                                                                                        v1570.clone(),
                                                                                                                                                                        v1568.clone(),
                                                                                                                                                                        v1569.clone(),
                                                                                                                                                                        v1566.clone(),
                                                                                                                                                                        v1592.clone(),
                                                                                                                                                                        v1598.clone());
                                                                                                                                                let v1604:
                                                                                                                                                        LrcPtr<(i32,
                                                                                                                                                                string)> =
                                                                                                                                                    futures_lite::future::block_on(v1602);
                                                                                                                                                _v1571.set(Some((v1604.0.clone(),
                                                                                                                                                                 v1604.1.clone())));
                                                                                                                                                {
                                                                                                                                                    let patternInput_17:
                                                                                                                                                            (i32,
                                                                                                                                                             string) =
                                                                                                                                                        getValue(_v1571.get().clone());
                                                                                                                                                    let _v1786:
                                                                                                                                                            MutCell<Option<bool>> =
                                                                                                                                                        MutCell::new(None::<bool>);
                                                                                                                                                    {
                                                                                                                                                        let x_38:
                                                                                                                                                                bool =
                                                                                                                                                            cfg!(windows);
                                                                                                                                                        _v1786.set(Some(x_38))
                                                                                                                                                    }
                                                                                                                                                    {
                                                                                                                                                        let v1820:
                                                                                                                                                                Option<string> =
                                                                                                                                                            None::<string>;
                                                                                                                                                        let v1821:
                                                                                                                                                                Option<CancellationToken> =
                                                                                                                                                            None::<CancellationToken>;
                                                                                                                                                        let v1822:
                                                                                                                                                                Array<(string,
                                                                                                                                                                       string)> =
                                                                                                                                                            new_empty::<(string,
                                                                                                                                                                         string)>();
                                                                                                                                                        let v1823 =
                                                                                                                                                            None::<Func1<(bool,
                                                                                                                                                                          string,
                                                                                                                                                                          i32),
                                                                                                                                                                         Arc<Async<()>>>>;
                                                                                                                                                        let v1824:
                                                                                                                                                                string =
                                                                                                                                                            sprintf!("pwsh -c \"(Get-FileHash \\\"{}\\\" -Algorithm SHA256).Hash\"",
                                                                                                                                                                     if getValue(_v1786.get().clone())
                                                                                                                                                                            ==
                                                                                                                                                                            false
                                                                                                                                                                        {
                                                                                                                                                                         v1484.clone()
                                                                                                                                                                     } else {
                                                                                                                                                                         let _v1799:
                                                                                                                                                                                 MutCell<Option<string>> =
                                                                                                                                                                             MutCell::new(None::<string>);
                                                                                                                                                                         let v1801:
                                                                                                                                                                                 string =
                                                                                                                                                                             Documents::method17();
                                                                                                                                                                         let v1802:
                                                                                                                                                                                 string =
                                                                                                                                                                             Documents::method18(v1484.clone());
                                                                                                                                                                         let v1803:
                                                                                                                                                                                 string =
                                                                                                                                                                             Documents::method19();
                                                                                                                                                                         let v1805:
                                                                                                                                                                                 &str =
                                                                                                                                                                             &regex::Regex::new(&v1801).unwrap().replace_all(&v1802, &*v1803);
                                                                                                                                                                         let v1807:
                                                                                                                                                                                 std::string::String =
                                                                                                                                                                             String::from(v1805);
                                                                                                                                                                         {
                                                                                                                                                                             let x_39:
                                                                                                                                                                                     string =
                                                                                                                                                                                 fable_library_rust::String_::fromString(v1807);
                                                                                                                                                                             _v1799.set(Some(x_39))
                                                                                                                                                                         }
                                                                                                                                                                         {
                                                                                                                                                                             let v1816:
                                                                                                                                                                                     string =
                                                                                                                                                                                 getValue(_v1799.get().clone());
                                                                                                                                                                             replace(sprintf!("{}{}",
                                                                                                                                                                                              toLower(ofChar(getCharAt(v1816.clone(),
                                                                                                                                                                                                                       0_i32))),
                                                                                                                                                                                              getSlice(v1816,
                                                                                                                                                                                                       Some(1_i32),
                                                                                                                                                                                                       None::<i32>)),
                                                                                                                                                                                     string("\\"),
                                                                                                                                                                                     string("/"))
                                                                                                                                                                         }
                                                                                                                                                                     });
                                                                                                                                                        let _v1825:
                                                                                                                                                                MutCell<Option<(i32,
                                                                                                                                                                                string)>> =
                                                                                                                                                            MutCell::new(None::<(i32,
                                                                                                                                                                                 string)>);
                                                                                                                                                        let v1827:
                                                                                                                                                                string =
                                                                                                                                                            Documents::method33(v1821.clone(),
                                                                                                                                                                                v1824.clone(),
                                                                                                                                                                                v1822.clone(),
                                                                                                                                                                                v1823.clone(),
                                                                                                                                                                                v1820.clone());
                                                                                                                                                        let patternInput_18:
                                                                                                                                                                (string,
                                                                                                                                                                 string) =
                                                                                                                                                            Documents::method34();
                                                                                                                                                        let v1830:
                                                                                                                                                                i32 =
                                                                                                                                                            length(v1827.clone());
                                                                                                                                                        let v1831:
                                                                                                                                                                Array<char> =
                                                                                                                                                            new_init(&'\u{0000}',
                                                                                                                                                                     v1830);
                                                                                                                                                        let v1832:
                                                                                                                                                                LrcPtr<Documents::Mut5> =
                                                                                                                                                            LrcPtr::new(Documents::Mut5{l0:
                                                                                                                                                                                            MutCell::new(0_i32),});
                                                                                                                                                        while Documents::method21(v1830,
                                                                                                                                                                                  v1832.clone())
                                                                                                                                                              {
                                                                                                                                                            let v1834:
                                                                                                                                                                    i32 =
                                                                                                                                                                v1832.l0.get().clone();
                                                                                                                                                            let v1835:
                                                                                                                                                                    char =
                                                                                                                                                                getCharAt(v1827.clone(),
                                                                                                                                                                          v1834);
                                                                                                                                                            v1831.get_mut()[v1834
                                                                                                                                                                                as
                                                                                                                                                                                usize]
                                                                                                                                                                =
                                                                                                                                                                v1835;
                                                                                                                                                            {
                                                                                                                                                                let v1836:
                                                                                                                                                                        i32 =
                                                                                                                                                                    v1834
                                                                                                                                                                        +
                                                                                                                                                                        1_i32;
                                                                                                                                                                v1832.l0.set(v1836);
                                                                                                                                                                ()
                                                                                                                                                            }
                                                                                                                                                        }
                                                                                                                                                        {
                                                                                                                                                            let v1838:
                                                                                                                                                                    List<char> =
                                                                                                                                                                ofArray(v1831.clone());
                                                                                                                                                            let patternInput_19:
                                                                                                                                                                    (string,
                                                                                                                                                                     string) =
                                                                                                                                                                Documents::method36(patternInput_18.1.clone(),
                                                                                                                                                                                    patternInput_18.0.clone(),
                                                                                                                                                                                    foldBack(Func2::new(move
                                                                                                                                                                                                            |b0:
                                                                                                                                                                                                                 char,
                                                                                                                                                                                                             b1:
                                                                                                                                                                                                                 LrcPtr<Documents::UH0>|
                                                                                                                                                                                                            (Documents::method35())(b0)(b1)),
                                                                                                                                                                                             v1838,
                                                                                                                                                                                             LrcPtr::new(Documents::UH0::UH0_0)),
                                                                                                                                                                                    Documents::US8::US8_0);
                                                                                                                                                            let v1846:
                                                                                                                                                                    string =
                                                                                                                                                                patternInput_19.0.clone();
                                                                                                                                                            let v1848:
                                                                                                                                                                    Array<string> =
                                                                                                                                                                Documents::method37(patternInput_19.1.clone());
                                                                                                                                                            let v1850:
                                                                                                                                                                    Vec<string> =
                                                                                                                                                                v1848.to_vec();
                                                                                                                                                            let v1852:
                                                                                                                                                                    Vec<std::string::String> =
                                                                                                                                                                v1850.iter().map(|x| Func1::from(v383)(x.clone())).collect();
                                                                                                                                                            Documents::method3(Documents::US0::US0_1,
                                                                                                                                                                               Func0::new({
                                                                                                                                                                                              let v1820
                                                                                                                                                                                                  =
                                                                                                                                                                                                  v1820.clone();
                                                                                                                                                                                              let v1821
                                                                                                                                                                                                  =
                                                                                                                                                                                                  v1821.clone();
                                                                                                                                                                                              let v1822
                                                                                                                                                                                                  =
                                                                                                                                                                                                  v1822.clone();
                                                                                                                                                                                              let v1823
                                                                                                                                                                                                  =
                                                                                                                                                                                                  v1823.clone();
                                                                                                                                                                                              let v1824
                                                                                                                                                                                                  =
                                                                                                                                                                                                  v1824.clone();
                                                                                                                                                                                              let v1846
                                                                                                                                                                                                  =
                                                                                                                                                                                                  v1846.clone();
                                                                                                                                                                                              let v1852
                                                                                                                                                                                                  =
                                                                                                                                                                                                  v1852.clone();
                                                                                                                                                                                              move
                                                                                                                                                                                                  ||
                                                                                                                                                                                                  Documents::closure28(v1821.clone(),
                                                                                                                                                                                                                       v1824.clone(),
                                                                                                                                                                                                                       v1822.clone(),
                                                                                                                                                                                                                       v1823.clone(),
                                                                                                                                                                                                                       v1820.clone(),
                                                                                                                                                                                                                       v1846.clone(),
                                                                                                                                                                                                                       v1852.clone(),
                                                                                                                                                                                                                       ())
                                                                                                                                                                                          }),
                                                                                                                                                                               Documents::method43());
                                                                                                                                                            {
                                                                                                                                                                let v1856:
                                                                                                                                                                        std::pin::Pin<Box<dyn std::future::Future<Output = LrcPtr<(i32,
                                                                                                                                                                                                                                   string)>>>> =
                                                                                                                                                                    Documents::method44(v1821.clone(),
                                                                                                                                                                                        v1824.clone(),
                                                                                                                                                                                        v1822.clone(),
                                                                                                                                                                                        v1823.clone(),
                                                                                                                                                                                        v1820.clone(),
                                                                                                                                                                                        v1846.clone(),
                                                                                                                                                                                        v1852.clone());
                                                                                                                                                                let v1858:
                                                                                                                                                                        LrcPtr<(i32,
                                                                                                                                                                                string)> =
                                                                                                                                                                    futures_lite::future::block_on(v1856);
                                                                                                                                                                _v1825.set(Some((v1858.0.clone(),
                                                                                                                                                                                 v1858.1.clone())));
                                                                                                                                                                patternInput_17.1.clone()
                                                                                                                                                                    ==
                                                                                                                                                                    (getValue(_v1825.get().clone())).1.clone()
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
                                                                                                                                let v2043:
                                                                                                                                        string =
                                                                                                                                    sprintf!("crowbook --single \"{}\" --output \"{}\" --to {} --set rendering.num_depth 6 html.css.add \\\"\'\'\' body {{ color: #e8e6e3; background-color: #202324; }} a {{ color: #989693; }} \'\'\'\\\"",
                                                                                                                                             v647.clone(),
                                                                                                                                             v1483.clone(),
                                                                                                                                             string("epub"));
                                                                                                                                let v2045:
                                                                                                                                        Option<CancellationToken> =
                                                                                                                                    None::<CancellationToken>;
                                                                                                                                let v2046:
                                                                                                                                        Array<(string,
                                                                                                                                               string)> =
                                                                                                                                    new_empty::<(string,
                                                                                                                                                 string)>();
                                                                                                                                let v2047 =
                                                                                                                                    None::<Func1<(bool,
                                                                                                                                                  string,
                                                                                                                                                  i32),
                                                                                                                                                 Arc<Async<()>>>>;
                                                                                                                                let v2048:
                                                                                                                                        Option<string> =
                                                                                                                                    Some(v1_1.clone());
                                                                                                                                let _v2049:
                                                                                                                                        MutCell<Option<(i32,
                                                                                                                                                        string)>> =
                                                                                                                                    MutCell::new(None::<(i32,
                                                                                                                                                         string)>);
                                                                                                                                let v2051:
                                                                                                                                        string =
                                                                                                                                    Documents::method33(v2045.clone(),
                                                                                                                                                        v2043.clone(),
                                                                                                                                                        v2046.clone(),
                                                                                                                                                        v2047.clone(),
                                                                                                                                                        v2048.clone());
                                                                                                                                let patternInput_21:
                                                                                                                                        (string,
                                                                                                                                         string) =
                                                                                                                                    Documents::method34();
                                                                                                                                let v2054:
                                                                                                                                        i32 =
                                                                                                                                    length(v2051.clone());
                                                                                                                                let v2055:
                                                                                                                                        Array<char> =
                                                                                                                                    new_init(&'\u{0000}',
                                                                                                                                             v2054);
                                                                                                                                let v2056:
                                                                                                                                        LrcPtr<Documents::Mut5> =
                                                                                                                                    LrcPtr::new(Documents::Mut5{l0:
                                                                                                                                                                    MutCell::new(0_i32),});
                                                                                                                                while Documents::method21(v2054,
                                                                                                                                                          v2056.clone())
                                                                                                                                      {
                                                                                                                                    let v2058:
                                                                                                                                            i32 =
                                                                                                                                        v2056.l0.get().clone();
                                                                                                                                    let v2059:
                                                                                                                                            char =
                                                                                                                                        getCharAt(v2051.clone(),
                                                                                                                                                  v2058);
                                                                                                                                    v2055.get_mut()[v2058
                                                                                                                                                        as
                                                                                                                                                        usize]
                                                                                                                                        =
                                                                                                                                        v2059;
                                                                                                                                    {
                                                                                                                                        let v2060:
                                                                                                                                                i32 =
                                                                                                                                            v2058
                                                                                                                                                +
                                                                                                                                                1_i32;
                                                                                                                                        v2056.l0.set(v2060);
                                                                                                                                        ()
                                                                                                                                    }
                                                                                                                                }
                                                                                                                                {
                                                                                                                                    let v2062:
                                                                                                                                            List<char> =
                                                                                                                                        ofArray(v2055.clone());
                                                                                                                                    let patternInput_22:
                                                                                                                                            (string,
                                                                                                                                             string) =
                                                                                                                                        Documents::method36(patternInput_21.1.clone(),
                                                                                                                                                            patternInput_21.0.clone(),
                                                                                                                                                            foldBack(Func2::new(move
                                                                                                                                                                                    |b0:
                                                                                                                                                                                         char,
                                                                                                                                                                                     b1:
                                                                                                                                                                                         LrcPtr<Documents::UH0>|
                                                                                                                                                                                    (Documents::method35())(b0)(b1)),
                                                                                                                                                                     v2062,
                                                                                                                                                                     LrcPtr::new(Documents::UH0::UH0_0)),
                                                                                                                                                            Documents::US8::US8_0);
                                                                                                                                    let v2070:
                                                                                                                                            string =
                                                                                                                                        patternInput_22.0.clone();
                                                                                                                                    let v2072:
                                                                                                                                            Array<string> =
                                                                                                                                        Documents::method37(patternInput_22.1.clone());
                                                                                                                                    let v2074:
                                                                                                                                            Vec<string> =
                                                                                                                                        v2072.to_vec();
                                                                                                                                    let v2076:
                                                                                                                                            Vec<std::string::String> =
                                                                                                                                        v2074.iter().map(|x| Func1::from(v383)(x.clone())).collect();
                                                                                                                                    Documents::method3(Documents::US0::US0_1,
                                                                                                                                                       Func0::new({
                                                                                                                                                                      let v2043
                                                                                                                                                                          =
                                                                                                                                                                          v2043.clone();
                                                                                                                                                                      let v2045
                                                                                                                                                                          =
                                                                                                                                                                          v2045.clone();
                                                                                                                                                                      let v2046
                                                                                                                                                                          =
                                                                                                                                                                          v2046.clone();
                                                                                                                                                                      let v2047
                                                                                                                                                                          =
                                                                                                                                                                          v2047.clone();
                                                                                                                                                                      let v2048
                                                                                                                                                                          =
                                                                                                                                                                          v2048.clone();
                                                                                                                                                                      let v2070
                                                                                                                                                                          =
                                                                                                                                                                          v2070.clone();
                                                                                                                                                                      let v2076
                                                                                                                                                                          =
                                                                                                                                                                          v2076.clone();
                                                                                                                                                                      move
                                                                                                                                                                          ||
                                                                                                                                                                          Documents::closure28(v2045.clone(),
                                                                                                                                                                                               v2043.clone(),
                                                                                                                                                                                               v2046.clone(),
                                                                                                                                                                                               v2047.clone(),
                                                                                                                                                                                               v2048.clone(),
                                                                                                                                                                                               v2070.clone(),
                                                                                                                                                                                               v2076.clone(),
                                                                                                                                                                                               ())
                                                                                                                                                                  }),
                                                                                                                                                       Documents::method43());
                                                                                                                                    {
                                                                                                                                        let v2080:
                                                                                                                                                std::pin::Pin<Box<dyn std::future::Future<Output = LrcPtr<(i32,
                                                                                                                                                                                                           string)>>>> =
                                                                                                                                            Documents::method44(v2045.clone(),
                                                                                                                                                                v2043.clone(),
                                                                                                                                                                v2046.clone(),
                                                                                                                                                                v2047.clone(),
                                                                                                                                                                v2048.clone(),
                                                                                                                                                                v2070.clone(),
                                                                                                                                                                v2076.clone());
                                                                                                                                        let v2082:
                                                                                                                                                LrcPtr<(i32,
                                                                                                                                                        string)> =
                                                                                                                                            futures_lite::future::block_on(v2080);
                                                                                                                                        _v2049.set(Some((v2082.0.clone(),
                                                                                                                                                         v2082.1.clone())));
                                                                                                                                        {
                                                                                                                                            let patternInput_23:
                                                                                                                                                    (i32,
                                                                                                                                                     string) =
                                                                                                                                                getValue(_v2049.get().clone());
                                                                                                                                            let v2263:
                                                                                                                                                    string =
                                                                                                                                                patternInput_23.1.clone();
                                                                                                                                            let v2262:
                                                                                                                                                    i32 =
                                                                                                                                                patternInput_23.0.clone();
                                                                                                                                            if if v2262
                                                                                                                                                      !=
                                                                                                                                                      0_i32
                                                                                                                                                  {
                                                                                                                                                   true
                                                                                                                                               } else {
                                                                                                                                                   contains(v2263.clone(),
                                                                                                                                                            string("ERROR"))
                                                                                                                                               }
                                                                                                                                               {
                                                                                                                                                Documents::method3(Documents::US0::US0_2,
                                                                                                                                                                   Func0::new(move
                                                                                                                                                                                  ||
                                                                                                                                                                                  Documents::closure53((),
                                                                                                                                                                                                       ())),
                                                                                                                                                                   Func0::new({
                                                                                                                                                                                  let v2262
                                                                                                                                                                                      =
                                                                                                                                                                                      v2262.clone();
                                                                                                                                                                                  let v2263
                                                                                                                                                                                      =
                                                                                                                                                                                      v2263.clone();
                                                                                                                                                                                  move
                                                                                                                                                                                      ||
                                                                                                                                                                                      Documents::closure54(v2263.clone(),
                                                                                                                                                                                                           v2262,
                                                                                                                                                                                                           ())
                                                                                                                                                                              }));
                                                                                                                                                Documents::US17::US17_0(Err::<string,
                                                                                                                                                                              LrcPtr<(string,
                                                                                                                                                                                      string)>>(LrcPtr::new((v1483.clone(),
                                                                                                                                                                                                             v2263.clone()))))
                                                                                                                                            } else {
                                                                                                                                                let _v2274:
                                                                                                                                                        MutCell<Option<()>> =
                                                                                                                                                    MutCell::new(None::<()>);
                                                                                                                                                let v2276:
                                                                                                                                                        string =
                                                                                                                                                    Documents::method63(v1484);
                                                                                                                                                let v2278:
                                                                                                                                                        Result<u64,
                                                                                                                                                               std::io::Error> =
                                                                                                                                                    std::fs::copy(&*v1483, &*v2276);
                                                                                                                                                let v2280:
                                                                                                                                                        u64 =
                                                                                                                                                    v2278.unwrap();
                                                                                                                                                _v2274.set(Some(()));
                                                                                                                                                getValue(_v2274.get().clone());
                                                                                                                                                Documents::US17::US17_0(Ok::<string,
                                                                                                                                                                             LrcPtr<(string,
                                                                                                                                                                                     string)>>(v1483))
                                                                                                                                            }
                                                                                                                                        }
                                                                                                                                    }
                                                                                                                                }
                                                                                                                            } else {
                                                                                                                                Documents::US17::US17_1
                                                                                                                            };
                                                                                                                        let v2290:
                                                                                                                                Option<Result<string,
                                                                                                                                              LrcPtr<(string,
                                                                                                                                                      string)>>> =
                                                                                                                            match &v2285
                                                                                                                                {
                                                                                                                                Documents::US17::US17_0(v2285_0_0)
                                                                                                                                =>
                                                                                                                                Some(match &v2285
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
                                                                                                                        let v2292:
                                                                                                                                string =
                                                                                                                            sprintf!("{}.{}",
                                                                                                                                     v647.clone(),
                                                                                                                                     string("pdf"));
                                                                                                                        let v2293:
                                                                                                                                string =
                                                                                                                            sprintf!("{}.{}",
                                                                                                                                     v1200.clone(),
                                                                                                                                     string("pdf"));
                                                                                                                        let _v2294:
                                                                                                                                MutCell<Option<bool>> =
                                                                                                                            MutCell::new(None::<bool>);
                                                                                                                        let v2296:
                                                                                                                                string =
                                                                                                                            Documents::method14(v2292.clone());
                                                                                                                        let v2298:
                                                                                                                                &str =
                                                                                                                            fable_library_rust::String_::LrcStr::as_str(&v2296);
                                                                                                                        let v2300:
                                                                                                                                std::string::String =
                                                                                                                            String::from(v2298);
                                                                                                                        let v2302:
                                                                                                                                std::path::PathBuf =
                                                                                                                            std::path::PathBuf::from(v2300);
                                                                                                                        {
                                                                                                                            let x_43:
                                                                                                                                    bool =
                                                                                                                                if v2302.clone().exists()
                                                                                                                                   {
                                                                                                                                    v2302.is_file()
                                                                                                                                } else {
                                                                                                                                    false
                                                                                                                                };
                                                                                                                            _v2294.set(Some(x_43))
                                                                                                                        }
                                                                                                                        {
                                                                                                                            let v3094:
                                                                                                                                    Documents::US17 =
                                                                                                                                if (if if getValue(_v2294.get().clone())
                                                                                                                                          {
                                                                                                                                           let _v2317:
                                                                                                                                                   MutCell<Option<bool>> =
                                                                                                                                               MutCell::new(None::<bool>);
                                                                                                                                           let v2319:
                                                                                                                                                   string =
                                                                                                                                               Documents::method14(v2293.clone());
                                                                                                                                           let v2321:
                                                                                                                                                   &str =
                                                                                                                                               fable_library_rust::String_::LrcStr::as_str(&v2319);
                                                                                                                                           let v2323:
                                                                                                                                                   std::string::String =
                                                                                                                                               String::from(v2321);
                                                                                                                                           let v2325:
                                                                                                                                                   std::path::PathBuf =
                                                                                                                                               std::path::PathBuf::from(v2323);
                                                                                                                                           {
                                                                                                                                               let x_44:
                                                                                                                                                       bool =
                                                                                                                                                   if v2325.clone().exists()
                                                                                                                                                      {
                                                                                                                                                       v2325.is_file()
                                                                                                                                                   } else {
                                                                                                                                                       false
                                                                                                                                                   };
                                                                                                                                               _v2317.set(Some(x_44))
                                                                                                                                           }
                                                                                                                                           getValue(_v2317.get().clone())
                                                                                                                                       } else {
                                                                                                                                           false
                                                                                                                                       }
                                                                                                                                       {
                                                                                                                                        let _v2341:
                                                                                                                                                MutCell<Option<bool>> =
                                                                                                                                            MutCell::new(None::<bool>);
                                                                                                                                        {
                                                                                                                                            let x_45:
                                                                                                                                                    bool =
                                                                                                                                                cfg!(windows);
                                                                                                                                            _v2341.set(Some(x_45))
                                                                                                                                        }
                                                                                                                                        {
                                                                                                                                            let v2375:
                                                                                                                                                    Option<string> =
                                                                                                                                                None::<string>;
                                                                                                                                            let v2376:
                                                                                                                                                    Option<CancellationToken> =
                                                                                                                                                None::<CancellationToken>;
                                                                                                                                            let v2377:
                                                                                                                                                    Array<(string,
                                                                                                                                                           string)> =
                                                                                                                                                new_empty::<(string,
                                                                                                                                                             string)>();
                                                                                                                                            let v2378 =
                                                                                                                                                None::<Func1<(bool,
                                                                                                                                                              string,
                                                                                                                                                              i32),
                                                                                                                                                             Arc<Async<()>>>>;
                                                                                                                                            let v2379:
                                                                                                                                                    string =
                                                                                                                                                sprintf!("pwsh -c \"(Get-FileHash \\\"{}\\\" -Algorithm SHA256).Hash\"",
                                                                                                                                                         if getValue(_v2341.get().clone())
                                                                                                                                                                ==
                                                                                                                                                                false
                                                                                                                                                            {
                                                                                                                                                             v2292.clone()
                                                                                                                                                         } else {
                                                                                                                                                             let _v2354:
                                                                                                                                                                     MutCell<Option<string>> =
                                                                                                                                                                 MutCell::new(None::<string>);
                                                                                                                                                             let v2356:
                                                                                                                                                                     string =
                                                                                                                                                                 Documents::method17();
                                                                                                                                                             let v2357:
                                                                                                                                                                     string =
                                                                                                                                                                 Documents::method18(v2292.clone());
                                                                                                                                                             let v2358:
                                                                                                                                                                     string =
                                                                                                                                                                 Documents::method19();
                                                                                                                                                             let v2360:
                                                                                                                                                                     &str =
                                                                                                                                                                 &regex::Regex::new(&v2356).unwrap().replace_all(&v2357, &*v2358);
                                                                                                                                                             let v2362:
                                                                                                                                                                     std::string::String =
                                                                                                                                                                 String::from(v2360);
                                                                                                                                                             {
                                                                                                                                                                 let x_46:
                                                                                                                                                                         string =
                                                                                                                                                                     fable_library_rust::String_::fromString(v2362);
                                                                                                                                                                 _v2354.set(Some(x_46))
                                                                                                                                                             }
                                                                                                                                                             {
                                                                                                                                                                 let v2371:
                                                                                                                                                                         string =
                                                                                                                                                                     getValue(_v2354.get().clone());
                                                                                                                                                                 replace(sprintf!("{}{}",
                                                                                                                                                                                  toLower(ofChar(getCharAt(v2371.clone(),
                                                                                                                                                                                                           0_i32))),
                                                                                                                                                                                  getSlice(v2371,
                                                                                                                                                                                           Some(1_i32),
                                                                                                                                                                                           None::<i32>)),
                                                                                                                                                                         string("\\"),
                                                                                                                                                                         string("/"))
                                                                                                                                                             }
                                                                                                                                                         });
                                                                                                                                            let _v2380:
                                                                                                                                                    MutCell<Option<(i32,
                                                                                                                                                                    string)>> =
                                                                                                                                                MutCell::new(None::<(i32,
                                                                                                                                                                     string)>);
                                                                                                                                            let v2382:
                                                                                                                                                    string =
                                                                                                                                                Documents::method33(v2376.clone(),
                                                                                                                                                                    v2379.clone(),
                                                                                                                                                                    v2377.clone(),
                                                                                                                                                                    v2378.clone(),
                                                                                                                                                                    v2375.clone());
                                                                                                                                            let patternInput_24:
                                                                                                                                                    (string,
                                                                                                                                                     string) =
                                                                                                                                                Documents::method34();
                                                                                                                                            let v2385:
                                                                                                                                                    i32 =
                                                                                                                                                length(v2382.clone());
                                                                                                                                            let v2386:
                                                                                                                                                    Array<char> =
                                                                                                                                                new_init(&'\u{0000}',
                                                                                                                                                         v2385);
                                                                                                                                            let v2387:
                                                                                                                                                    LrcPtr<Documents::Mut5> =
                                                                                                                                                LrcPtr::new(Documents::Mut5{l0:
                                                                                                                                                                                MutCell::new(0_i32),});
                                                                                                                                            while Documents::method21(v2385,
                                                                                                                                                                      v2387.clone())
                                                                                                                                                  {
                                                                                                                                                let v2389:
                                                                                                                                                        i32 =
                                                                                                                                                    v2387.l0.get().clone();
                                                                                                                                                let v2390:
                                                                                                                                                        char =
                                                                                                                                                    getCharAt(v2382.clone(),
                                                                                                                                                              v2389);
                                                                                                                                                v2386.get_mut()[v2389
                                                                                                                                                                    as
                                                                                                                                                                    usize]
                                                                                                                                                    =
                                                                                                                                                    v2390;
                                                                                                                                                {
                                                                                                                                                    let v2391:
                                                                                                                                                            i32 =
                                                                                                                                                        v2389
                                                                                                                                                            +
                                                                                                                                                            1_i32;
                                                                                                                                                    v2387.l0.set(v2391);
                                                                                                                                                    ()
                                                                                                                                                }
                                                                                                                                            }
                                                                                                                                            {
                                                                                                                                                let v2393:
                                                                                                                                                        List<char> =
                                                                                                                                                    ofArray(v2386.clone());
                                                                                                                                                let patternInput_25:
                                                                                                                                                        (string,
                                                                                                                                                         string) =
                                                                                                                                                    Documents::method36(patternInput_24.1.clone(),
                                                                                                                                                                        patternInput_24.0.clone(),
                                                                                                                                                                        foldBack(Func2::new(move
                                                                                                                                                                                                |b0:
                                                                                                                                                                                                     char,
                                                                                                                                                                                                 b1:
                                                                                                                                                                                                     LrcPtr<Documents::UH0>|
                                                                                                                                                                                                (Documents::method35())(b0)(b1)),
                                                                                                                                                                                 v2393,
                                                                                                                                                                                 LrcPtr::new(Documents::UH0::UH0_0)),
                                                                                                                                                                        Documents::US8::US8_0);
                                                                                                                                                let v2401:
                                                                                                                                                        string =
                                                                                                                                                    patternInput_25.0.clone();
                                                                                                                                                let v2403:
                                                                                                                                                        Array<string> =
                                                                                                                                                    Documents::method37(patternInput_25.1.clone());
                                                                                                                                                let v2405:
                                                                                                                                                        Vec<string> =
                                                                                                                                                    v2403.to_vec();
                                                                                                                                                let v2407:
                                                                                                                                                        Vec<std::string::String> =
                                                                                                                                                    v2405.iter().map(|x| Func1::from(v383)(x.clone())).collect();
                                                                                                                                                Documents::method3(Documents::US0::US0_1,
                                                                                                                                                                   Func0::new({
                                                                                                                                                                                  let v2375
                                                                                                                                                                                      =
                                                                                                                                                                                      v2375.clone();
                                                                                                                                                                                  let v2376
                                                                                                                                                                                      =
                                                                                                                                                                                      v2376.clone();
                                                                                                                                                                                  let v2377
                                                                                                                                                                                      =
                                                                                                                                                                                      v2377.clone();
                                                                                                                                                                                  let v2378
                                                                                                                                                                                      =
                                                                                                                                                                                      v2378.clone();
                                                                                                                                                                                  let v2379
                                                                                                                                                                                      =
                                                                                                                                                                                      v2379.clone();
                                                                                                                                                                                  let v2401
                                                                                                                                                                                      =
                                                                                                                                                                                      v2401.clone();
                                                                                                                                                                                  let v2407
                                                                                                                                                                                      =
                                                                                                                                                                                      v2407.clone();
                                                                                                                                                                                  move
                                                                                                                                                                                      ||
                                                                                                                                                                                      Documents::closure28(v2376.clone(),
                                                                                                                                                                                                           v2379.clone(),
                                                                                                                                                                                                           v2377.clone(),
                                                                                                                                                                                                           v2378.clone(),
                                                                                                                                                                                                           v2375.clone(),
                                                                                                                                                                                                           v2401.clone(),
                                                                                                                                                                                                           v2407.clone(),
                                                                                                                                                                                                           ())
                                                                                                                                                                              }),
                                                                                                                                                                   Documents::method43());
                                                                                                                                                {
                                                                                                                                                    let v2411:
                                                                                                                                                            std::pin::Pin<Box<dyn std::future::Future<Output = LrcPtr<(i32,
                                                                                                                                                                                                                       string)>>>> =
                                                                                                                                                        Documents::method44(v2376.clone(),
                                                                                                                                                                            v2379.clone(),
                                                                                                                                                                            v2377.clone(),
                                                                                                                                                                            v2378.clone(),
                                                                                                                                                                            v2375.clone(),
                                                                                                                                                                            v2401.clone(),
                                                                                                                                                                            v2407.clone());
                                                                                                                                                    let v2413:
                                                                                                                                                            LrcPtr<(i32,
                                                                                                                                                                    string)> =
                                                                                                                                                        futures_lite::future::block_on(v2411);
                                                                                                                                                    _v2380.set(Some((v2413.0.clone(),
                                                                                                                                                                     v2413.1.clone())));
                                                                                                                                                    {
                                                                                                                                                        let patternInput_26:
                                                                                                                                                                (i32,
                                                                                                                                                                 string) =
                                                                                                                                                            getValue(_v2380.get().clone());
                                                                                                                                                        let _v2595:
                                                                                                                                                                MutCell<Option<bool>> =
                                                                                                                                                            MutCell::new(None::<bool>);
                                                                                                                                                        {
                                                                                                                                                            let x_48:
                                                                                                                                                                    bool =
                                                                                                                                                                cfg!(windows);
                                                                                                                                                            _v2595.set(Some(x_48))
                                                                                                                                                        }
                                                                                                                                                        {
                                                                                                                                                            let v2629:
                                                                                                                                                                    Option<string> =
                                                                                                                                                                None::<string>;
                                                                                                                                                            let v2630:
                                                                                                                                                                    Option<CancellationToken> =
                                                                                                                                                                None::<CancellationToken>;
                                                                                                                                                            let v2631:
                                                                                                                                                                    Array<(string,
                                                                                                                                                                           string)> =
                                                                                                                                                                new_empty::<(string,
                                                                                                                                                                             string)>();
                                                                                                                                                            let v2632 =
                                                                                                                                                                None::<Func1<(bool,
                                                                                                                                                                              string,
                                                                                                                                                                              i32),
                                                                                                                                                                             Arc<Async<()>>>>;
                                                                                                                                                            let v2633:
                                                                                                                                                                    string =
                                                                                                                                                                sprintf!("pwsh -c \"(Get-FileHash \\\"{}\\\" -Algorithm SHA256).Hash\"",
                                                                                                                                                                         if getValue(_v2595.get().clone())
                                                                                                                                                                                ==
                                                                                                                                                                                false
                                                                                                                                                                            {
                                                                                                                                                                             v2293.clone()
                                                                                                                                                                         } else {
                                                                                                                                                                             let _v2608:
                                                                                                                                                                                     MutCell<Option<string>> =
                                                                                                                                                                                 MutCell::new(None::<string>);
                                                                                                                                                                             let v2610:
                                                                                                                                                                                     string =
                                                                                                                                                                                 Documents::method17();
                                                                                                                                                                             let v2611:
                                                                                                                                                                                     string =
                                                                                                                                                                                 Documents::method18(v2293.clone());
                                                                                                                                                                             let v2612:
                                                                                                                                                                                     string =
                                                                                                                                                                                 Documents::method19();
                                                                                                                                                                             let v2614:
                                                                                                                                                                                     &str =
                                                                                                                                                                                 &regex::Regex::new(&v2610).unwrap().replace_all(&v2611, &*v2612);
                                                                                                                                                                             let v2616:
                                                                                                                                                                                     std::string::String =
                                                                                                                                                                                 String::from(v2614);
                                                                                                                                                                             {
                                                                                                                                                                                 let x_49:
                                                                                                                                                                                         string =
                                                                                                                                                                                     fable_library_rust::String_::fromString(v2616);
                                                                                                                                                                                 _v2608.set(Some(x_49))
                                                                                                                                                                             }
                                                                                                                                                                             {
                                                                                                                                                                                 let v2625:
                                                                                                                                                                                         string =
                                                                                                                                                                                     getValue(_v2608.get().clone());
                                                                                                                                                                                 replace(sprintf!("{}{}",
                                                                                                                                                                                                  toLower(ofChar(getCharAt(v2625.clone(),
                                                                                                                                                                                                                           0_i32))),
                                                                                                                                                                                                  getSlice(v2625,
                                                                                                                                                                                                           Some(1_i32),
                                                                                                                                                                                                           None::<i32>)),
                                                                                                                                                                                         string("\\"),
                                                                                                                                                                                         string("/"))
                                                                                                                                                                             }
                                                                                                                                                                         });
                                                                                                                                                            let _v2634:
                                                                                                                                                                    MutCell<Option<(i32,
                                                                                                                                                                                    string)>> =
                                                                                                                                                                MutCell::new(None::<(i32,
                                                                                                                                                                                     string)>);
                                                                                                                                                            let v2636:
                                                                                                                                                                    string =
                                                                                                                                                                Documents::method33(v2630.clone(),
                                                                                                                                                                                    v2633.clone(),
                                                                                                                                                                                    v2631.clone(),
                                                                                                                                                                                    v2632.clone(),
                                                                                                                                                                                    v2629.clone());
                                                                                                                                                            let patternInput_27:
                                                                                                                                                                    (string,
                                                                                                                                                                     string) =
                                                                                                                                                                Documents::method34();
                                                                                                                                                            let v2639:
                                                                                                                                                                    i32 =
                                                                                                                                                                length(v2636.clone());
                                                                                                                                                            let v2640:
                                                                                                                                                                    Array<char> =
                                                                                                                                                                new_init(&'\u{0000}',
                                                                                                                                                                         v2639);
                                                                                                                                                            let v2641:
                                                                                                                                                                    LrcPtr<Documents::Mut5> =
                                                                                                                                                                LrcPtr::new(Documents::Mut5{l0:
                                                                                                                                                                                                MutCell::new(0_i32),});
                                                                                                                                                            while Documents::method21(v2639,
                                                                                                                                                                                      v2641.clone())
                                                                                                                                                                  {
                                                                                                                                                                let v2643:
                                                                                                                                                                        i32 =
                                                                                                                                                                    v2641.l0.get().clone();
                                                                                                                                                                let v2644:
                                                                                                                                                                        char =
                                                                                                                                                                    getCharAt(v2636.clone(),
                                                                                                                                                                              v2643);
                                                                                                                                                                v2640.get_mut()[v2643
                                                                                                                                                                                    as
                                                                                                                                                                                    usize]
                                                                                                                                                                    =
                                                                                                                                                                    v2644;
                                                                                                                                                                {
                                                                                                                                                                    let v2645:
                                                                                                                                                                            i32 =
                                                                                                                                                                        v2643
                                                                                                                                                                            +
                                                                                                                                                                            1_i32;
                                                                                                                                                                    v2641.l0.set(v2645);
                                                                                                                                                                    ()
                                                                                                                                                                }
                                                                                                                                                            }
                                                                                                                                                            {
                                                                                                                                                                let v2647:
                                                                                                                                                                        List<char> =
                                                                                                                                                                    ofArray(v2640.clone());
                                                                                                                                                                let patternInput_28:
                                                                                                                                                                        (string,
                                                                                                                                                                         string) =
                                                                                                                                                                    Documents::method36(patternInput_27.1.clone(),
                                                                                                                                                                                        patternInput_27.0.clone(),
                                                                                                                                                                                        foldBack(Func2::new(move
                                                                                                                                                                                                                |b0:
                                                                                                                                                                                                                     char,
                                                                                                                                                                                                                 b1:
                                                                                                                                                                                                                     LrcPtr<Documents::UH0>|
                                                                                                                                                                                                                (Documents::method35())(b0)(b1)),
                                                                                                                                                                                                 v2647,
                                                                                                                                                                                                 LrcPtr::new(Documents::UH0::UH0_0)),
                                                                                                                                                                                        Documents::US8::US8_0);
                                                                                                                                                                let v2655:
                                                                                                                                                                        string =
                                                                                                                                                                    patternInput_28.0.clone();
                                                                                                                                                                let v2657:
                                                                                                                                                                        Array<string> =
                                                                                                                                                                    Documents::method37(patternInput_28.1.clone());
                                                                                                                                                                let v2659:
                                                                                                                                                                        Vec<string> =
                                                                                                                                                                    v2657.to_vec();
                                                                                                                                                                let v2661:
                                                                                                                                                                        Vec<std::string::String> =
                                                                                                                                                                    v2659.iter().map(|x| Func1::from(v383)(x.clone())).collect();
                                                                                                                                                                Documents::method3(Documents::US0::US0_1,
                                                                                                                                                                                   Func0::new({
                                                                                                                                                                                                  let v2629
                                                                                                                                                                                                      =
                                                                                                                                                                                                      v2629.clone();
                                                                                                                                                                                                  let v2630
                                                                                                                                                                                                      =
                                                                                                                                                                                                      v2630.clone();
                                                                                                                                                                                                  let v2631
                                                                                                                                                                                                      =
                                                                                                                                                                                                      v2631.clone();
                                                                                                                                                                                                  let v2632
                                                                                                                                                                                                      =
                                                                                                                                                                                                      v2632.clone();
                                                                                                                                                                                                  let v2633
                                                                                                                                                                                                      =
                                                                                                                                                                                                      v2633.clone();
                                                                                                                                                                                                  let v2655
                                                                                                                                                                                                      =
                                                                                                                                                                                                      v2655.clone();
                                                                                                                                                                                                  let v2661
                                                                                                                                                                                                      =
                                                                                                                                                                                                      v2661.clone();
                                                                                                                                                                                                  move
                                                                                                                                                                                                      ||
                                                                                                                                                                                                      Documents::closure28(v2630.clone(),
                                                                                                                                                                                                                           v2633.clone(),
                                                                                                                                                                                                                           v2631.clone(),
                                                                                                                                                                                                                           v2632.clone(),
                                                                                                                                                                                                                           v2629.clone(),
                                                                                                                                                                                                                           v2655.clone(),
                                                                                                                                                                                                                           v2661.clone(),
                                                                                                                                                                                                                           ())
                                                                                                                                                                                              }),
                                                                                                                                                                                   Documents::method43());
                                                                                                                                                                {
                                                                                                                                                                    let v2665:
                                                                                                                                                                            std::pin::Pin<Box<dyn std::future::Future<Output = LrcPtr<(i32,
                                                                                                                                                                                                                                       string)>>>> =
                                                                                                                                                                        Documents::method44(v2630.clone(),
                                                                                                                                                                                            v2633.clone(),
                                                                                                                                                                                            v2631.clone(),
                                                                                                                                                                                            v2632.clone(),
                                                                                                                                                                                            v2629.clone(),
                                                                                                                                                                                            v2655.clone(),
                                                                                                                                                                                            v2661.clone());
                                                                                                                                                                    let v2667:
                                                                                                                                                                            LrcPtr<(i32,
                                                                                                                                                                                    string)> =
                                                                                                                                                                        futures_lite::future::block_on(v2665);
                                                                                                                                                                    _v2634.set(Some((v2667.0.clone(),
                                                                                                                                                                                     v2667.1.clone())));
                                                                                                                                                                    patternInput_26.1.clone()
                                                                                                                                                                        ==
                                                                                                                                                                        (getValue(_v2634.get().clone())).1.clone()
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
                                                                                                                                    let v2852:
                                                                                                                                            string =
                                                                                                                                        sprintf!("crowbook --single \"{}\" --output \"{}\" --to {} --set rendering.num_depth 6 html.css.add \\\"\'\'\' body {{ color: #e8e6e3; background-color: #202324; }} a {{ color: #989693; }} \'\'\'\\\"",
                                                                                                                                                 v647.clone(),
                                                                                                                                                 v2292.clone(),
                                                                                                                                                 string("pdf"));
                                                                                                                                    let v2854:
                                                                                                                                            Option<CancellationToken> =
                                                                                                                                        None::<CancellationToken>;
                                                                                                                                    let v2855:
                                                                                                                                            Array<(string,
                                                                                                                                                   string)> =
                                                                                                                                        new_empty::<(string,
                                                                                                                                                     string)>();
                                                                                                                                    let v2856 =
                                                                                                                                        None::<Func1<(bool,
                                                                                                                                                      string,
                                                                                                                                                      i32),
                                                                                                                                                     Arc<Async<()>>>>;
                                                                                                                                    let v2857:
                                                                                                                                            Option<string> =
                                                                                                                                        Some(v1_1.clone());
                                                                                                                                    let _v2858:
                                                                                                                                            MutCell<Option<(i32,
                                                                                                                                                            string)>> =
                                                                                                                                        MutCell::new(None::<(i32,
                                                                                                                                                             string)>);
                                                                                                                                    let v2860:
                                                                                                                                            string =
                                                                                                                                        Documents::method33(v2854.clone(),
                                                                                                                                                            v2852.clone(),
                                                                                                                                                            v2855.clone(),
                                                                                                                                                            v2856.clone(),
                                                                                                                                                            v2857.clone());
                                                                                                                                    let patternInput_30:
                                                                                                                                            (string,
                                                                                                                                             string) =
                                                                                                                                        Documents::method34();
                                                                                                                                    let v2863:
                                                                                                                                            i32 =
                                                                                                                                        length(v2860.clone());
                                                                                                                                    let v2864:
                                                                                                                                            Array<char> =
                                                                                                                                        new_init(&'\u{0000}',
                                                                                                                                                 v2863);
                                                                                                                                    let v2865:
                                                                                                                                            LrcPtr<Documents::Mut5> =
                                                                                                                                        LrcPtr::new(Documents::Mut5{l0:
                                                                                                                                                                        MutCell::new(0_i32),});
                                                                                                                                    while Documents::method21(v2863,
                                                                                                                                                              v2865.clone())
                                                                                                                                          {
                                                                                                                                        let v2867:
                                                                                                                                                i32 =
                                                                                                                                            v2865.l0.get().clone();
                                                                                                                                        let v2868:
                                                                                                                                                char =
                                                                                                                                            getCharAt(v2860.clone(),
                                                                                                                                                      v2867);
                                                                                                                                        v2864.get_mut()[v2867
                                                                                                                                                            as
                                                                                                                                                            usize]
                                                                                                                                            =
                                                                                                                                            v2868;
                                                                                                                                        {
                                                                                                                                            let v2869:
                                                                                                                                                    i32 =
                                                                                                                                                v2867
                                                                                                                                                    +
                                                                                                                                                    1_i32;
                                                                                                                                            v2865.l0.set(v2869);
                                                                                                                                            ()
                                                                                                                                        }
                                                                                                                                    }
                                                                                                                                    {
                                                                                                                                        let v2871:
                                                                                                                                                List<char> =
                                                                                                                                            ofArray(v2864.clone());
                                                                                                                                        let patternInput_31:
                                                                                                                                                (string,
                                                                                                                                                 string) =
                                                                                                                                            Documents::method36(patternInput_30.1.clone(),
                                                                                                                                                                patternInput_30.0.clone(),
                                                                                                                                                                foldBack(Func2::new(move
                                                                                                                                                                                        |b0:
                                                                                                                                                                                             char,
                                                                                                                                                                                         b1:
                                                                                                                                                                                             LrcPtr<Documents::UH0>|
                                                                                                                                                                                        (Documents::method35())(b0)(b1)),
                                                                                                                                                                         v2871,
                                                                                                                                                                         LrcPtr::new(Documents::UH0::UH0_0)),
                                                                                                                                                                Documents::US8::US8_0);
                                                                                                                                        let v2879:
                                                                                                                                                string =
                                                                                                                                            patternInput_31.0.clone();
                                                                                                                                        let v2881:
                                                                                                                                                Array<string> =
                                                                                                                                            Documents::method37(patternInput_31.1.clone());
                                                                                                                                        let v2883:
                                                                                                                                                Vec<string> =
                                                                                                                                            v2881.to_vec();
                                                                                                                                        let v2885:
                                                                                                                                                Vec<std::string::String> =
                                                                                                                                            v2883.iter().map(|x| Func1::from(v383)(x.clone())).collect();
                                                                                                                                        Documents::method3(Documents::US0::US0_1,
                                                                                                                                                           Func0::new({
                                                                                                                                                                          let v2852
                                                                                                                                                                              =
                                                                                                                                                                              v2852.clone();
                                                                                                                                                                          let v2854
                                                                                                                                                                              =
                                                                                                                                                                              v2854.clone();
                                                                                                                                                                          let v2855
                                                                                                                                                                              =
                                                                                                                                                                              v2855.clone();
                                                                                                                                                                          let v2856
                                                                                                                                                                              =
                                                                                                                                                                              v2856.clone();
                                                                                                                                                                          let v2857
                                                                                                                                                                              =
                                                                                                                                                                              v2857.clone();
                                                                                                                                                                          let v2879
                                                                                                                                                                              =
                                                                                                                                                                              v2879.clone();
                                                                                                                                                                          let v2885
                                                                                                                                                                              =
                                                                                                                                                                              v2885.clone();
                                                                                                                                                                          move
                                                                                                                                                                              ||
                                                                                                                                                                              Documents::closure28(v2854.clone(),
                                                                                                                                                                                                   v2852.clone(),
                                                                                                                                                                                                   v2855.clone(),
                                                                                                                                                                                                   v2856.clone(),
                                                                                                                                                                                                   v2857.clone(),
                                                                                                                                                                                                   v2879.clone(),
                                                                                                                                                                                                   v2885.clone(),
                                                                                                                                                                                                   ())
                                                                                                                                                                      }),
                                                                                                                                                           Documents::method43());
                                                                                                                                        {
                                                                                                                                            let v2889:
                                                                                                                                                    std::pin::Pin<Box<dyn std::future::Future<Output = LrcPtr<(i32,
                                                                                                                                                                                                               string)>>>> =
                                                                                                                                                Documents::method44(v2854.clone(),
                                                                                                                                                                    v2852.clone(),
                                                                                                                                                                    v2855.clone(),
                                                                                                                                                                    v2856.clone(),
                                                                                                                                                                    v2857.clone(),
                                                                                                                                                                    v2879.clone(),
                                                                                                                                                                    v2885.clone());
                                                                                                                                            let v2891:
                                                                                                                                                    LrcPtr<(i32,
                                                                                                                                                            string)> =
                                                                                                                                                futures_lite::future::block_on(v2889);
                                                                                                                                            _v2858.set(Some((v2891.0.clone(),
                                                                                                                                                             v2891.1.clone())));
                                                                                                                                            {
                                                                                                                                                let patternInput_32:
                                                                                                                                                        (i32,
                                                                                                                                                         string) =
                                                                                                                                                    getValue(_v2858.get().clone());
                                                                                                                                                let v3072:
                                                                                                                                                        string =
                                                                                                                                                    patternInput_32.1.clone();
                                                                                                                                                let v3071:
                                                                                                                                                        i32 =
                                                                                                                                                    patternInput_32.0.clone();
                                                                                                                                                if if v3071
                                                                                                                                                          !=
                                                                                                                                                          0_i32
                                                                                                                                                      {
                                                                                                                                                       true
                                                                                                                                                   } else {
                                                                                                                                                       contains(v3072.clone(),
                                                                                                                                                                string("ERROR"))
                                                                                                                                                   }
                                                                                                                                                   {
                                                                                                                                                    Documents::method3(Documents::US0::US0_2,
                                                                                                                                                                       Func0::new(move
                                                                                                                                                                                      ||
                                                                                                                                                                                      Documents::closure53((),
                                                                                                                                                                                                           ())),
                                                                                                                                                                       Func0::new({
                                                                                                                                                                                      let v3071
                                                                                                                                                                                          =
                                                                                                                                                                                          v3071.clone();
                                                                                                                                                                                      let v3072
                                                                                                                                                                                          =
                                                                                                                                                                                          v3072.clone();
                                                                                                                                                                                      move
                                                                                                                                                                                          ||
                                                                                                                                                                                          Documents::closure54(v3072.clone(),
                                                                                                                                                                                                               v3071,
                                                                                                                                                                                                               ())
                                                                                                                                                                                  }));
                                                                                                                                                    Documents::US17::US17_0(Err::<string,
                                                                                                                                                                                  LrcPtr<(string,
                                                                                                                                                                                          string)>>(LrcPtr::new((v2292.clone(),
                                                                                                                                                                                                                 v3072.clone()))))
                                                                                                                                                } else {
                                                                                                                                                    let _v3083:
                                                                                                                                                            MutCell<Option<()>> =
                                                                                                                                                        MutCell::new(None::<()>);
                                                                                                                                                    let v3085:
                                                                                                                                                            string =
                                                                                                                                                        Documents::method63(v2293);
                                                                                                                                                    let v3087:
                                                                                                                                                            Result<u64,
                                                                                                                                                                   std::io::Error> =
                                                                                                                                                        std::fs::copy(&*v2292, &*v3085);
                                                                                                                                                    let v3089:
                                                                                                                                                            u64 =
                                                                                                                                                        v3087.unwrap();
                                                                                                                                                    _v3083.set(Some(()));
                                                                                                                                                    getValue(_v3083.get().clone());
                                                                                                                                                    Documents::US17::US17_0(Ok::<string,
                                                                                                                                                                                 LrcPtr<(string,
                                                                                                                                                                                         string)>>(v2292))
                                                                                                                                                }
                                                                                                                                            }
                                                                                                                                        }
                                                                                                                                    }
                                                                                                                                } else {
                                                                                                                                    Documents::US17::US17_1
                                                                                                                                };
                                                                                                                            let v3099:
                                                                                                                                    Option<Result<string,
                                                                                                                                                  LrcPtr<(string,
                                                                                                                                                          string)>>> =
                                                                                                                                match &v3094
                                                                                                                                    {
                                                                                                                                    Documents::US17::US17_0(v3094_0_0)
                                                                                                                                    =>
                                                                                                                                    Some(match &v3094
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
                                                                                                                            let v3101:
                                                                                                                                    string =
                                                                                                                                sprintf!("{}.{}",
                                                                                                                                         v647.clone(),
                                                                                                                                         string("html"));
                                                                                                                            let v3102:
                                                                                                                                    string =
                                                                                                                                sprintf!("{}.{}",
                                                                                                                                         v1200.clone(),
                                                                                                                                         string("html"));
                                                                                                                            let _v3103:
                                                                                                                                    MutCell<Option<bool>> =
                                                                                                                                MutCell::new(None::<bool>);
                                                                                                                            let v3105:
                                                                                                                                    string =
                                                                                                                                Documents::method14(v3101.clone());
                                                                                                                            let v3107:
                                                                                                                                    &str =
                                                                                                                                fable_library_rust::String_::LrcStr::as_str(&v3105);
                                                                                                                            let v3109:
                                                                                                                                    std::string::String =
                                                                                                                                String::from(v3107);
                                                                                                                            let v3111:
                                                                                                                                    std::path::PathBuf =
                                                                                                                                std::path::PathBuf::from(v3109);
                                                                                                                            {
                                                                                                                                let x_53:
                                                                                                                                        bool =
                                                                                                                                    if v3111.clone().exists()
                                                                                                                                       {
                                                                                                                                        v3111.is_file()
                                                                                                                                    } else {
                                                                                                                                        false
                                                                                                                                    };
                                                                                                                                _v3103.set(Some(x_53))
                                                                                                                            }
                                                                                                                            {
                                                                                                                                let v3903:
                                                                                                                                        Documents::US17 =
                                                                                                                                    if (if if getValue(_v3103.get().clone())
                                                                                                                                              {
                                                                                                                                               let _v3126:
                                                                                                                                                       MutCell<Option<bool>> =
                                                                                                                                                   MutCell::new(None::<bool>);
                                                                                                                                               let v3128:
                                                                                                                                                       string =
                                                                                                                                                   Documents::method14(v3102.clone());
                                                                                                                                               let v3130:
                                                                                                                                                       &str =
                                                                                                                                                   fable_library_rust::String_::LrcStr::as_str(&v3128);
                                                                                                                                               let v3132:
                                                                                                                                                       std::string::String =
                                                                                                                                                   String::from(v3130);
                                                                                                                                               let v3134:
                                                                                                                                                       std::path::PathBuf =
                                                                                                                                                   std::path::PathBuf::from(v3132);
                                                                                                                                               {
                                                                                                                                                   let x_54:
                                                                                                                                                           bool =
                                                                                                                                                       if v3134.clone().exists()
                                                                                                                                                          {
                                                                                                                                                           v3134.is_file()
                                                                                                                                                       } else {
                                                                                                                                                           false
                                                                                                                                                       };
                                                                                                                                                   _v3126.set(Some(x_54))
                                                                                                                                               }
                                                                                                                                               getValue(_v3126.get().clone())
                                                                                                                                           } else {
                                                                                                                                               false
                                                                                                                                           }
                                                                                                                                           {
                                                                                                                                            let _v3150:
                                                                                                                                                    MutCell<Option<bool>> =
                                                                                                                                                MutCell::new(None::<bool>);
                                                                                                                                            {
                                                                                                                                                let x_55:
                                                                                                                                                        bool =
                                                                                                                                                    cfg!(windows);
                                                                                                                                                _v3150.set(Some(x_55))
                                                                                                                                            }
                                                                                                                                            {
                                                                                                                                                let v3184:
                                                                                                                                                        Option<string> =
                                                                                                                                                    None::<string>;
                                                                                                                                                let v3185:
                                                                                                                                                        Option<CancellationToken> =
                                                                                                                                                    None::<CancellationToken>;
                                                                                                                                                let v3186:
                                                                                                                                                        Array<(string,
                                                                                                                                                               string)> =
                                                                                                                                                    new_empty::<(string,
                                                                                                                                                                 string)>();
                                                                                                                                                let v3187 =
                                                                                                                                                    None::<Func1<(bool,
                                                                                                                                                                  string,
                                                                                                                                                                  i32),
                                                                                                                                                                 Arc<Async<()>>>>;
                                                                                                                                                let v3188:
                                                                                                                                                        string =
                                                                                                                                                    sprintf!("pwsh -c \"(Get-FileHash \\\"{}\\\" -Algorithm SHA256).Hash\"",
                                                                                                                                                             if getValue(_v3150.get().clone())
                                                                                                                                                                    ==
                                                                                                                                                                    false
                                                                                                                                                                {
                                                                                                                                                                 v3101.clone()
                                                                                                                                                             } else {
                                                                                                                                                                 let _v3163:
                                                                                                                                                                         MutCell<Option<string>> =
                                                                                                                                                                     MutCell::new(None::<string>);
                                                                                                                                                                 let v3165:
                                                                                                                                                                         string =
                                                                                                                                                                     Documents::method17();
                                                                                                                                                                 let v3166:
                                                                                                                                                                         string =
                                                                                                                                                                     Documents::method18(v3101.clone());
                                                                                                                                                                 let v3167:
                                                                                                                                                                         string =
                                                                                                                                                                     Documents::method19();
                                                                                                                                                                 let v3169:
                                                                                                                                                                         &str =
                                                                                                                                                                     &regex::Regex::new(&v3165).unwrap().replace_all(&v3166, &*v3167);
                                                                                                                                                                 let v3171:
                                                                                                                                                                         std::string::String =
                                                                                                                                                                     String::from(v3169);
                                                                                                                                                                 {
                                                                                                                                                                     let x_56:
                                                                                                                                                                             string =
                                                                                                                                                                         fable_library_rust::String_::fromString(v3171);
                                                                                                                                                                     _v3163.set(Some(x_56))
                                                                                                                                                                 }
                                                                                                                                                                 {
                                                                                                                                                                     let v3180:
                                                                                                                                                                             string =
                                                                                                                                                                         getValue(_v3163.get().clone());
                                                                                                                                                                     replace(sprintf!("{}{}",
                                                                                                                                                                                      toLower(ofChar(getCharAt(v3180.clone(),
                                                                                                                                                                                                               0_i32))),
                                                                                                                                                                                      getSlice(v3180,
                                                                                                                                                                                               Some(1_i32),
                                                                                                                                                                                               None::<i32>)),
                                                                                                                                                                             string("\\"),
                                                                                                                                                                             string("/"))
                                                                                                                                                                 }
                                                                                                                                                             });
                                                                                                                                                let _v3189:
                                                                                                                                                        MutCell<Option<(i32,
                                                                                                                                                                        string)>> =
                                                                                                                                                    MutCell::new(None::<(i32,
                                                                                                                                                                         string)>);
                                                                                                                                                let v3191:
                                                                                                                                                        string =
                                                                                                                                                    Documents::method33(v3185.clone(),
                                                                                                                                                                        v3188.clone(),
                                                                                                                                                                        v3186.clone(),
                                                                                                                                                                        v3187.clone(),
                                                                                                                                                                        v3184.clone());
                                                                                                                                                let patternInput_33:
                                                                                                                                                        (string,
                                                                                                                                                         string) =
                                                                                                                                                    Documents::method34();
                                                                                                                                                let v3194:
                                                                                                                                                        i32 =
                                                                                                                                                    length(v3191.clone());
                                                                                                                                                let v3195:
                                                                                                                                                        Array<char> =
                                                                                                                                                    new_init(&'\u{0000}',
                                                                                                                                                             v3194);
                                                                                                                                                let v3196:
                                                                                                                                                        LrcPtr<Documents::Mut5> =
                                                                                                                                                    LrcPtr::new(Documents::Mut5{l0:
                                                                                                                                                                                    MutCell::new(0_i32),});
                                                                                                                                                while Documents::method21(v3194,
                                                                                                                                                                          v3196.clone())
                                                                                                                                                      {
                                                                                                                                                    let v3198:
                                                                                                                                                            i32 =
                                                                                                                                                        v3196.l0.get().clone();
                                                                                                                                                    let v3199:
                                                                                                                                                            char =
                                                                                                                                                        getCharAt(v3191.clone(),
                                                                                                                                                                  v3198);
                                                                                                                                                    v3195.get_mut()[v3198
                                                                                                                                                                        as
                                                                                                                                                                        usize]
                                                                                                                                                        =
                                                                                                                                                        v3199;
                                                                                                                                                    {
                                                                                                                                                        let v3200:
                                                                                                                                                                i32 =
                                                                                                                                                            v3198
                                                                                                                                                                +
                                                                                                                                                                1_i32;
                                                                                                                                                        v3196.l0.set(v3200);
                                                                                                                                                        ()
                                                                                                                                                    }
                                                                                                                                                }
                                                                                                                                                {
                                                                                                                                                    let v3202:
                                                                                                                                                            List<char> =
                                                                                                                                                        ofArray(v3195.clone());
                                                                                                                                                    let patternInput_34:
                                                                                                                                                            (string,
                                                                                                                                                             string) =
                                                                                                                                                        Documents::method36(patternInput_33.1.clone(),
                                                                                                                                                                            patternInput_33.0.clone(),
                                                                                                                                                                            foldBack(Func2::new(move
                                                                                                                                                                                                    |b0:
                                                                                                                                                                                                         char,
                                                                                                                                                                                                     b1:
                                                                                                                                                                                                         LrcPtr<Documents::UH0>|
                                                                                                                                                                                                    (Documents::method35())(b0)(b1)),
                                                                                                                                                                                     v3202,
                                                                                                                                                                                     LrcPtr::new(Documents::UH0::UH0_0)),
                                                                                                                                                                            Documents::US8::US8_0);
                                                                                                                                                    let v3210:
                                                                                                                                                            string =
                                                                                                                                                        patternInput_34.0.clone();
                                                                                                                                                    let v3212:
                                                                                                                                                            Array<string> =
                                                                                                                                                        Documents::method37(patternInput_34.1.clone());
                                                                                                                                                    let v3214:
                                                                                                                                                            Vec<string> =
                                                                                                                                                        v3212.to_vec();
                                                                                                                                                    let v3216:
                                                                                                                                                            Vec<std::string::String> =
                                                                                                                                                        v3214.iter().map(|x| Func1::from(v383)(x.clone())).collect();
                                                                                                                                                    Documents::method3(Documents::US0::US0_1,
                                                                                                                                                                       Func0::new({
                                                                                                                                                                                      let v3184
                                                                                                                                                                                          =
                                                                                                                                                                                          v3184.clone();
                                                                                                                                                                                      let v3185
                                                                                                                                                                                          =
                                                                                                                                                                                          v3185.clone();
                                                                                                                                                                                      let v3186
                                                                                                                                                                                          =
                                                                                                                                                                                          v3186.clone();
                                                                                                                                                                                      let v3187
                                                                                                                                                                                          =
                                                                                                                                                                                          v3187.clone();
                                                                                                                                                                                      let v3188
                                                                                                                                                                                          =
                                                                                                                                                                                          v3188.clone();
                                                                                                                                                                                      let v3210
                                                                                                                                                                                          =
                                                                                                                                                                                          v3210.clone();
                                                                                                                                                                                      let v3216
                                                                                                                                                                                          =
                                                                                                                                                                                          v3216.clone();
                                                                                                                                                                                      move
                                                                                                                                                                                          ||
                                                                                                                                                                                          Documents::closure28(v3185.clone(),
                                                                                                                                                                                                               v3188.clone(),
                                                                                                                                                                                                               v3186.clone(),
                                                                                                                                                                                                               v3187.clone(),
                                                                                                                                                                                                               v3184.clone(),
                                                                                                                                                                                                               v3210.clone(),
                                                                                                                                                                                                               v3216.clone(),
                                                                                                                                                                                                               ())
                                                                                                                                                                                  }),
                                                                                                                                                                       Documents::method43());
                                                                                                                                                    {
                                                                                                                                                        let v3220:
                                                                                                                                                                std::pin::Pin<Box<dyn std::future::Future<Output = LrcPtr<(i32,
                                                                                                                                                                                                                           string)>>>> =
                                                                                                                                                            Documents::method44(v3185.clone(),
                                                                                                                                                                                v3188.clone(),
                                                                                                                                                                                v3186.clone(),
                                                                                                                                                                                v3187.clone(),
                                                                                                                                                                                v3184.clone(),
                                                                                                                                                                                v3210.clone(),
                                                                                                                                                                                v3216.clone());
                                                                                                                                                        let v3222:
                                                                                                                                                                LrcPtr<(i32,
                                                                                                                                                                        string)> =
                                                                                                                                                            futures_lite::future::block_on(v3220);
                                                                                                                                                        _v3189.set(Some((v3222.0.clone(),
                                                                                                                                                                         v3222.1.clone())));
                                                                                                                                                        {
                                                                                                                                                            let patternInput_35:
                                                                                                                                                                    (i32,
                                                                                                                                                                     string) =
                                                                                                                                                                getValue(_v3189.get().clone());
                                                                                                                                                            let _v3404:
                                                                                                                                                                    MutCell<Option<bool>> =
                                                                                                                                                                MutCell::new(None::<bool>);
                                                                                                                                                            {
                                                                                                                                                                let x_58:
                                                                                                                                                                        bool =
                                                                                                                                                                    cfg!(windows);
                                                                                                                                                                _v3404.set(Some(x_58))
                                                                                                                                                            }
                                                                                                                                                            {
                                                                                                                                                                let v3438:
                                                                                                                                                                        Option<string> =
                                                                                                                                                                    None::<string>;
                                                                                                                                                                let v3439:
                                                                                                                                                                        Option<CancellationToken> =
                                                                                                                                                                    None::<CancellationToken>;
                                                                                                                                                                let v3440:
                                                                                                                                                                        Array<(string,
                                                                                                                                                                               string)> =
                                                                                                                                                                    new_empty::<(string,
                                                                                                                                                                                 string)>();
                                                                                                                                                                let v3441 =
                                                                                                                                                                    None::<Func1<(bool,
                                                                                                                                                                                  string,
                                                                                                                                                                                  i32),
                                                                                                                                                                                 Arc<Async<()>>>>;
                                                                                                                                                                let v3442:
                                                                                                                                                                        string =
                                                                                                                                                                    sprintf!("pwsh -c \"(Get-FileHash \\\"{}\\\" -Algorithm SHA256).Hash\"",
                                                                                                                                                                             if getValue(_v3404.get().clone())
                                                                                                                                                                                    ==
                                                                                                                                                                                    false
                                                                                                                                                                                {
                                                                                                                                                                                 v3102.clone()
                                                                                                                                                                             } else {
                                                                                                                                                                                 let _v3417:
                                                                                                                                                                                         MutCell<Option<string>> =
                                                                                                                                                                                     MutCell::new(None::<string>);
                                                                                                                                                                                 let v3419:
                                                                                                                                                                                         string =
                                                                                                                                                                                     Documents::method17();
                                                                                                                                                                                 let v3420:
                                                                                                                                                                                         string =
                                                                                                                                                                                     Documents::method18(v3102.clone());
                                                                                                                                                                                 let v3421:
                                                                                                                                                                                         string =
                                                                                                                                                                                     Documents::method19();
                                                                                                                                                                                 let v3423:
                                                                                                                                                                                         &str =
                                                                                                                                                                                     &regex::Regex::new(&v3419).unwrap().replace_all(&v3420, &*v3421);
                                                                                                                                                                                 let v3425:
                                                                                                                                                                                         std::string::String =
                                                                                                                                                                                     String::from(v3423);
                                                                                                                                                                                 {
                                                                                                                                                                                     let x_59:
                                                                                                                                                                                             string =
                                                                                                                                                                                         fable_library_rust::String_::fromString(v3425);
                                                                                                                                                                                     _v3417.set(Some(x_59))
                                                                                                                                                                                 }
                                                                                                                                                                                 {
                                                                                                                                                                                     let v3434:
                                                                                                                                                                                             string =
                                                                                                                                                                                         getValue(_v3417.get().clone());
                                                                                                                                                                                     replace(sprintf!("{}{}",
                                                                                                                                                                                                      toLower(ofChar(getCharAt(v3434.clone(),
                                                                                                                                                                                                                               0_i32))),
                                                                                                                                                                                                      getSlice(v3434,
                                                                                                                                                                                                               Some(1_i32),
                                                                                                                                                                                                               None::<i32>)),
                                                                                                                                                                                             string("\\"),
                                                                                                                                                                                             string("/"))
                                                                                                                                                                                 }
                                                                                                                                                                             });
                                                                                                                                                                let _v3443:
                                                                                                                                                                        MutCell<Option<(i32,
                                                                                                                                                                                        string)>> =
                                                                                                                                                                    MutCell::new(None::<(i32,
                                                                                                                                                                                         string)>);
                                                                                                                                                                let v3445:
                                                                                                                                                                        string =
                                                                                                                                                                    Documents::method33(v3439.clone(),
                                                                                                                                                                                        v3442.clone(),
                                                                                                                                                                                        v3440.clone(),
                                                                                                                                                                                        v3441.clone(),
                                                                                                                                                                                        v3438.clone());
                                                                                                                                                                let patternInput_36:
                                                                                                                                                                        (string,
                                                                                                                                                                         string) =
                                                                                                                                                                    Documents::method34();
                                                                                                                                                                let v3448:
                                                                                                                                                                        i32 =
                                                                                                                                                                    length(v3445.clone());
                                                                                                                                                                let v3449:
                                                                                                                                                                        Array<char> =
                                                                                                                                                                    new_init(&'\u{0000}',
                                                                                                                                                                             v3448);
                                                                                                                                                                let v3450:
                                                                                                                                                                        LrcPtr<Documents::Mut5> =
                                                                                                                                                                    LrcPtr::new(Documents::Mut5{l0:
                                                                                                                                                                                                    MutCell::new(0_i32),});
                                                                                                                                                                while Documents::method21(v3448,
                                                                                                                                                                                          v3450.clone())
                                                                                                                                                                      {
                                                                                                                                                                    let v3452:
                                                                                                                                                                            i32 =
                                                                                                                                                                        v3450.l0.get().clone();
                                                                                                                                                                    let v3453:
                                                                                                                                                                            char =
                                                                                                                                                                        getCharAt(v3445.clone(),
                                                                                                                                                                                  v3452);
                                                                                                                                                                    v3449.get_mut()[v3452
                                                                                                                                                                                        as
                                                                                                                                                                                        usize]
                                                                                                                                                                        =
                                                                                                                                                                        v3453;
                                                                                                                                                                    {
                                                                                                                                                                        let v3454:
                                                                                                                                                                                i32 =
                                                                                                                                                                            v3452
                                                                                                                                                                                +
                                                                                                                                                                                1_i32;
                                                                                                                                                                        v3450.l0.set(v3454);
                                                                                                                                                                        ()
                                                                                                                                                                    }
                                                                                                                                                                }
                                                                                                                                                                {
                                                                                                                                                                    let v3456:
                                                                                                                                                                            List<char> =
                                                                                                                                                                        ofArray(v3449.clone());
                                                                                                                                                                    let patternInput_37:
                                                                                                                                                                            (string,
                                                                                                                                                                             string) =
                                                                                                                                                                        Documents::method36(patternInput_36.1.clone(),
                                                                                                                                                                                            patternInput_36.0.clone(),
                                                                                                                                                                                            foldBack(Func2::new(move
                                                                                                                                                                                                                    |b0:
                                                                                                                                                                                                                         char,
                                                                                                                                                                                                                     b1:
                                                                                                                                                                                                                         LrcPtr<Documents::UH0>|
                                                                                                                                                                                                                    (Documents::method35())(b0)(b1)),
                                                                                                                                                                                                     v3456,
                                                                                                                                                                                                     LrcPtr::new(Documents::UH0::UH0_0)),
                                                                                                                                                                                            Documents::US8::US8_0);
                                                                                                                                                                    let v3464:
                                                                                                                                                                            string =
                                                                                                                                                                        patternInput_37.0.clone();
                                                                                                                                                                    let v3466:
                                                                                                                                                                            Array<string> =
                                                                                                                                                                        Documents::method37(patternInput_37.1.clone());
                                                                                                                                                                    let v3468:
                                                                                                                                                                            Vec<string> =
                                                                                                                                                                        v3466.to_vec();
                                                                                                                                                                    let v3470:
                                                                                                                                                                            Vec<std::string::String> =
                                                                                                                                                                        v3468.iter().map(|x| Func1::from(v383)(x.clone())).collect();
                                                                                                                                                                    Documents::method3(Documents::US0::US0_1,
                                                                                                                                                                                       Func0::new({
                                                                                                                                                                                                      let v3438
                                                                                                                                                                                                          =
                                                                                                                                                                                                          v3438.clone();
                                                                                                                                                                                                      let v3439
                                                                                                                                                                                                          =
                                                                                                                                                                                                          v3439.clone();
                                                                                                                                                                                                      let v3440
                                                                                                                                                                                                          =
                                                                                                                                                                                                          v3440.clone();
                                                                                                                                                                                                      let v3441
                                                                                                                                                                                                          =
                                                                                                                                                                                                          v3441.clone();
                                                                                                                                                                                                      let v3442
                                                                                                                                                                                                          =
                                                                                                                                                                                                          v3442.clone();
                                                                                                                                                                                                      let v3464
                                                                                                                                                                                                          =
                                                                                                                                                                                                          v3464.clone();
                                                                                                                                                                                                      let v3470
                                                                                                                                                                                                          =
                                                                                                                                                                                                          v3470.clone();
                                                                                                                                                                                                      move
                                                                                                                                                                                                          ||
                                                                                                                                                                                                          Documents::closure28(v3439.clone(),
                                                                                                                                                                                                                               v3442.clone(),
                                                                                                                                                                                                                               v3440.clone(),
                                                                                                                                                                                                                               v3441.clone(),
                                                                                                                                                                                                                               v3438.clone(),
                                                                                                                                                                                                                               v3464.clone(),
                                                                                                                                                                                                                               v3470.clone(),
                                                                                                                                                                                                                               ())
                                                                                                                                                                                                  }),
                                                                                                                                                                                       Documents::method43());
                                                                                                                                                                    {
                                                                                                                                                                        let v3474:
                                                                                                                                                                                std::pin::Pin<Box<dyn std::future::Future<Output = LrcPtr<(i32,
                                                                                                                                                                                                                                           string)>>>> =
                                                                                                                                                                            Documents::method44(v3439.clone(),
                                                                                                                                                                                                v3442.clone(),
                                                                                                                                                                                                v3440.clone(),
                                                                                                                                                                                                v3441.clone(),
                                                                                                                                                                                                v3438.clone(),
                                                                                                                                                                                                v3464.clone(),
                                                                                                                                                                                                v3470.clone());
                                                                                                                                                                        let v3476:
                                                                                                                                                                                LrcPtr<(i32,
                                                                                                                                                                                        string)> =
                                                                                                                                                                            futures_lite::future::block_on(v3474);
                                                                                                                                                                        _v3443.set(Some((v3476.0.clone(),
                                                                                                                                                                                         v3476.1.clone())));
                                                                                                                                                                        patternInput_35.1.clone()
                                                                                                                                                                            ==
                                                                                                                                                                            (getValue(_v3443.get().clone())).1.clone()
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
                                                                                                                                        let v3661:
                                                                                                                                                string =
                                                                                                                                            sprintf!("crowbook --single \"{}\" --output \"{}\" --to {} --set rendering.num_depth 6 html.css.add \\\"\'\'\' body {{ color: #e8e6e3; background-color: #202324; }} a {{ color: #989693; }} \'\'\'\\\"",
                                                                                                                                                     v647,
                                                                                                                                                     v3101.clone(),
                                                                                                                                                     string("html"));
                                                                                                                                        let v3663:
                                                                                                                                                Option<CancellationToken> =
                                                                                                                                            None::<CancellationToken>;
                                                                                                                                        let v3664:
                                                                                                                                                Array<(string,
                                                                                                                                                       string)> =
                                                                                                                                            new_empty::<(string,
                                                                                                                                                         string)>();
                                                                                                                                        let v3665 =
                                                                                                                                            None::<Func1<(bool,
                                                                                                                                                          string,
                                                                                                                                                          i32),
                                                                                                                                                         Arc<Async<()>>>>;
                                                                                                                                        let v3666:
                                                                                                                                                Option<string> =
                                                                                                                                            Some(v1_1);
                                                                                                                                        let _v3667:
                                                                                                                                                MutCell<Option<(i32,
                                                                                                                                                                string)>> =
                                                                                                                                            MutCell::new(None::<(i32,
                                                                                                                                                                 string)>);
                                                                                                                                        let v3669:
                                                                                                                                                string =
                                                                                                                                            Documents::method33(v3663.clone(),
                                                                                                                                                                v3661.clone(),
                                                                                                                                                                v3664.clone(),
                                                                                                                                                                v3665.clone(),
                                                                                                                                                                v3666.clone());
                                                                                                                                        let patternInput_39:
                                                                                                                                                (string,
                                                                                                                                                 string) =
                                                                                                                                            Documents::method34();
                                                                                                                                        let v3672:
                                                                                                                                                i32 =
                                                                                                                                            length(v3669.clone());
                                                                                                                                        let v3673:
                                                                                                                                                Array<char> =
                                                                                                                                            new_init(&'\u{0000}',
                                                                                                                                                     v3672);
                                                                                                                                        let v3674:
                                                                                                                                                LrcPtr<Documents::Mut5> =
                                                                                                                                            LrcPtr::new(Documents::Mut5{l0:
                                                                                                                                                                            MutCell::new(0_i32),});
                                                                                                                                        while Documents::method21(v3672,
                                                                                                                                                                  v3674.clone())
                                                                                                                                              {
                                                                                                                                            let v3676:
                                                                                                                                                    i32 =
                                                                                                                                                v3674.l0.get().clone();
                                                                                                                                            let v3677:
                                                                                                                                                    char =
                                                                                                                                                getCharAt(v3669.clone(),
                                                                                                                                                          v3676);
                                                                                                                                            v3673.get_mut()[v3676
                                                                                                                                                                as
                                                                                                                                                                usize]
                                                                                                                                                =
                                                                                                                                                v3677;
                                                                                                                                            {
                                                                                                                                                let v3678:
                                                                                                                                                        i32 =
                                                                                                                                                    v3676
                                                                                                                                                        +
                                                                                                                                                        1_i32;
                                                                                                                                                v3674.l0.set(v3678);
                                                                                                                                                ()
                                                                                                                                            }
                                                                                                                                        }
                                                                                                                                        {
                                                                                                                                            let v3680:
                                                                                                                                                    List<char> =
                                                                                                                                                ofArray(v3673.clone());
                                                                                                                                            let patternInput_40:
                                                                                                                                                    (string,
                                                                                                                                                     string) =
                                                                                                                                                Documents::method36(patternInput_39.1.clone(),
                                                                                                                                                                    patternInput_39.0.clone(),
                                                                                                                                                                    foldBack(Func2::new(move
                                                                                                                                                                                            |b0:
                                                                                                                                                                                                 char,
                                                                                                                                                                                             b1:
                                                                                                                                                                                                 LrcPtr<Documents::UH0>|
                                                                                                                                                                                            (Documents::method35())(b0)(b1)),
                                                                                                                                                                             v3680,
                                                                                                                                                                             LrcPtr::new(Documents::UH0::UH0_0)),
                                                                                                                                                                    Documents::US8::US8_0);
                                                                                                                                            let v3688:
                                                                                                                                                    string =
                                                                                                                                                patternInput_40.0.clone();
                                                                                                                                            let v3690:
                                                                                                                                                    Array<string> =
                                                                                                                                                Documents::method37(patternInput_40.1.clone());
                                                                                                                                            let v3692:
                                                                                                                                                    Vec<string> =
                                                                                                                                                v3690.to_vec();
                                                                                                                                            let v3694:
                                                                                                                                                    Vec<std::string::String> =
                                                                                                                                                v3692.iter().map(|x| Func1::from(v383)(x.clone())).collect();
                                                                                                                                            Documents::method3(Documents::US0::US0_1,
                                                                                                                                                               Func0::new({
                                                                                                                                                                              let v3661
                                                                                                                                                                                  =
                                                                                                                                                                                  v3661.clone();
                                                                                                                                                                              let v3663
                                                                                                                                                                                  =
                                                                                                                                                                                  v3663.clone();
                                                                                                                                                                              let v3664
                                                                                                                                                                                  =
                                                                                                                                                                                  v3664.clone();
                                                                                                                                                                              let v3665
                                                                                                                                                                                  =
                                                                                                                                                                                  v3665.clone();
                                                                                                                                                                              let v3666
                                                                                                                                                                                  =
                                                                                                                                                                                  v3666.clone();
                                                                                                                                                                              let v3688
                                                                                                                                                                                  =
                                                                                                                                                                                  v3688.clone();
                                                                                                                                                                              let v3694
                                                                                                                                                                                  =
                                                                                                                                                                                  v3694.clone();
                                                                                                                                                                              move
                                                                                                                                                                                  ||
                                                                                                                                                                                  Documents::closure28(v3663.clone(),
                                                                                                                                                                                                       v3661.clone(),
                                                                                                                                                                                                       v3664.clone(),
                                                                                                                                                                                                       v3665.clone(),
                                                                                                                                                                                                       v3666.clone(),
                                                                                                                                                                                                       v3688.clone(),
                                                                                                                                                                                                       v3694.clone(),
                                                                                                                                                                                                       ())
                                                                                                                                                                          }),
                                                                                                                                                               Documents::method43());
                                                                                                                                            {
                                                                                                                                                let v3698:
                                                                                                                                                        std::pin::Pin<Box<dyn std::future::Future<Output = LrcPtr<(i32,
                                                                                                                                                                                                                   string)>>>> =
                                                                                                                                                    Documents::method44(v3663.clone(),
                                                                                                                                                                        v3661.clone(),
                                                                                                                                                                        v3664.clone(),
                                                                                                                                                                        v3665.clone(),
                                                                                                                                                                        v3666.clone(),
                                                                                                                                                                        v3688.clone(),
                                                                                                                                                                        v3694.clone());
                                                                                                                                                let v3700:
                                                                                                                                                        LrcPtr<(i32,
                                                                                                                                                                string)> =
                                                                                                                                                    futures_lite::future::block_on(v3698);
                                                                                                                                                _v3667.set(Some((v3700.0.clone(),
                                                                                                                                                                 v3700.1.clone())));
                                                                                                                                                {
                                                                                                                                                    let patternInput_41:
                                                                                                                                                            (i32,
                                                                                                                                                             string) =
                                                                                                                                                        getValue(_v3667.get().clone());
                                                                                                                                                    let v3881:
                                                                                                                                                            string =
                                                                                                                                                        patternInput_41.1.clone();
                                                                                                                                                    let v3880:
                                                                                                                                                            i32 =
                                                                                                                                                        patternInput_41.0.clone();
                                                                                                                                                    if if v3880
                                                                                                                                                              !=
                                                                                                                                                              0_i32
                                                                                                                                                          {
                                                                                                                                                           true
                                                                                                                                                       } else {
                                                                                                                                                           contains(v3881.clone(),
                                                                                                                                                                    string("ERROR"))
                                                                                                                                                       }
                                                                                                                                                       {
                                                                                                                                                        Documents::method3(Documents::US0::US0_2,
                                                                                                                                                                           Func0::new(move
                                                                                                                                                                                          ||
                                                                                                                                                                                          Documents::closure53((),
                                                                                                                                                                                                               ())),
                                                                                                                                                                           Func0::new({
                                                                                                                                                                                          let v3880
                                                                                                                                                                                              =
                                                                                                                                                                                              v3880.clone();
                                                                                                                                                                                          let v3881
                                                                                                                                                                                              =
                                                                                                                                                                                              v3881.clone();
                                                                                                                                                                                          move
                                                                                                                                                                                              ||
                                                                                                                                                                                              Documents::closure54(v3881.clone(),
                                                                                                                                                                                                                   v3880,
                                                                                                                                                                                                                   ())
                                                                                                                                                                                      }));
                                                                                                                                                        Documents::US17::US17_0(Err::<string,
                                                                                                                                                                                      LrcPtr<(string,
                                                                                                                                                                                              string)>>(LrcPtr::new((v3101.clone(),
                                                                                                                                                                                                                     v3881.clone()))))
                                                                                                                                                    } else {
                                                                                                                                                        let _v3892:
                                                                                                                                                                MutCell<Option<()>> =
                                                                                                                                                            MutCell::new(None::<()>);
                                                                                                                                                        let v3894:
                                                                                                                                                                string =
                                                                                                                                                            Documents::method63(v3102);
                                                                                                                                                        let v3896:
                                                                                                                                                                Result<u64,
                                                                                                                                                                       std::io::Error> =
                                                                                                                                                            std::fs::copy(&*v3101, &*v3894);
                                                                                                                                                        let v3898:
                                                                                                                                                                u64 =
                                                                                                                                                            v3896.unwrap();
                                                                                                                                                        _v3892.set(Some(()));
                                                                                                                                                        getValue(_v3892.get().clone());
                                                                                                                                                        Documents::US17::US17_0(Ok::<string,
                                                                                                                                                                                     LrcPtr<(string,
                                                                                                                                                                                             string)>>(v3101))
                                                                                                                                                    }
                                                                                                                                                }
                                                                                                                                            }
                                                                                                                                        }
                                                                                                                                    } else {
                                                                                                                                        Documents::US17::US17_1
                                                                                                                                    };
                                                                                                                                let v3915:
                                                                                                                                        Array<Option<Result<string,
                                                                                                                                                            LrcPtr<(string,
                                                                                                                                                                    string)>>>> =
                                                                                                                                    toArray(ofArray(new_array(&[match &v3903
                                                                                                                                                                    {
                                                                                                                                                                    Documents::US17::US17_0(v3903_0_0)
                                                                                                                                                                    =>
                                                                                                                                                                    Some(match &v3903
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
                                                                                                                                                                v3099,
                                                                                                                                                                v2290,
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
                                                                                                                                                                  let v1124
                                                                                                                                                                      =
                                                                                                                                                                      v1124.clone();
                                                                                                                                                                  let v1479
                                                                                                                                                                      =
                                                                                                                                                                      v1479.clone();
                                                                                                                                                                  let v238
                                                                                                                                                                      =
                                                                                                                                                                      v238.clone();
                                                                                                                                                                  let v272
                                                                                                                                                                      =
                                                                                                                                                                      v272.clone();
                                                                                                                                                                  let v349
                                                                                                                                                                      =
                                                                                                                                                                      v349.clone();
                                                                                                                                                                  let v3915
                                                                                                                                                                      =
                                                                                                                                                                      v3915.clone();
                                                                                                                                                                  let v571
                                                                                                                                                                      =
                                                                                                                                                                      v571.clone();
                                                                                                                                                                  let v868
                                                                                                                                                                      =
                                                                                                                                                                      v868.clone();
                                                                                                                                                                  move
                                                                                                                                                                      ||
                                                                                                                                                                      Documents::closure56(v238.clone(),
                                                                                                                                                                                           v272.clone(),
                                                                                                                                                                                           v349.clone(),
                                                                                                                                                                                           v571.clone(),
                                                                                                                                                                                           patternInput_5.0.clone(),
                                                                                                                                                                                           v868.clone(),
                                                                                                                                                                                           patternInput_8.0.clone(),
                                                                                                                                                                                           v1124.clone(),
                                                                                                                                                                                           v1479.clone(),
                                                                                                                                                                                           v3915.clone(),
                                                                                                                                                                                           ())
                                                                                                                                                              }));
                                                                                                                                {
                                                                                                                                    let _v3919:
                                                                                                                                            MutCell<Option<()>> =
                                                                                                                                        MutCell::new(None::<()>);
                                                                                                                                    let v3921:
                                                                                                                                            string =
                                                                                                                                        Documents::method63(v1200);
                                                                                                                                    let v3923:
                                                                                                                                            Result<u64,
                                                                                                                                                   std::io::Error> =
                                                                                                                                        std::fs::copy(&*v647, &*v3921);
                                                                                                                                    let v3925:
                                                                                                                                            u64 =
                                                                                                                                        v3923.unwrap();
                                                                                                                                    _v3919.set(Some(()));
                                                                                                                                    getValue(_v3919.get().clone());
                                                                                                                                    v3915.clone()
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
                                                                                                               v3929.to_vec())))
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
        pub fn method64(
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
        pub fn method24(
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
                    let v9 = Documents::method32();
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
                            > = Documents::method64(Ok::<
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
        pub fn method12(
            v0_1: string,
            v1_1: string,
            v2: string,
            v3: string,
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
            let _v4: MutCell<Option<string>> = MutCell::new(None::<string>);
            let v6: string = Documents::method13(v3);
            let v7: string = Documents::method14(v6.clone());
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
                            let v48: string = Documents::method14(getValue(_v17.get().clone()));
                            let v50: &str = fable_library_rust::String_::LrcStr::as_str(&v48);
                            let v52: std::string::String = String::from(v50);
                            let v54: std::path::PathBuf = std::path::PathBuf::from(v52);
                            let v55: string = Documents::method14(v6.clone());
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
                                                let v104: string = Documents::method17();
                                                let v105: string = Documents::method18(v88);
                                                let v106: string = Documents::method19();
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
                                        while Documents::method20(v129, v130.clone()) {
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
                                                        while Documents::method21(
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
                                                        (0_i32, v146.clone())
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
                                                Documents::method22(ofChar(getValue(
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
                let _v210: MutCell<Option<string>> = MutCell::new(None::<string>);
                let v212: string = Documents::method13(v2);
                let v213: string = Documents::method14(v212.clone());
                let v215: &str = fable_library_rust::String_::LrcStr::as_str(&v213);
                let v217: std::string::String = String::from(v215);
                let v219: std::path::PathBuf = std::path::PathBuf::from(v217);
                {
                    let x_17: string = if v219.exists() == false {
                        let _v223: MutCell<Option<string>> = MutCell::new(None::<string>);
                        let v226: Result<std::path::PathBuf, std::io::Error> =
                            std::env::current_dir();
                        let v228: std::path::PathBuf = v226.unwrap();
                        let v230: std::path::Display = v228.display();
                        let _v231: MutCell<Option<std::string::String>> =
                            MutCell::new(None::<std::string::String>);
                        {
                            let x_9: std::string::String = format!("{}", v230);
                            _v231.set(Some(x_9))
                        }
                        {
                            let v242: std::string::String = getValue(_v231.get().clone());
                            {
                                let x_10: string = fable_library_rust::String_::fromString(v242);
                                _v223.set(Some(x_10))
                            }
                            {
                                let _v252: MutCell<Option<string>> = MutCell::new(None::<string>);
                                let v254: string =
                                    Documents::method14(getValue(_v223.get().clone()));
                                let v256: &str = fable_library_rust::String_::LrcStr::as_str(&v254);
                                let v258: std::string::String = String::from(v256);
                                let v260: std::path::PathBuf = std::path::PathBuf::from(v258);
                                let v261: string = Documents::method14(v212.clone());
                                let v263: &str = fable_library_rust::String_::LrcStr::as_str(&v261);
                                let v265: std::string::String = String::from(v263);
                                let v267: std::path::PathBuf = v260.join(v265);
                                let v269: std::path::Display = v267.display();
                                let _v270: MutCell<Option<std::string::String>> =
                                    MutCell::new(None::<std::string::String>);
                                {
                                    let x_11: std::string::String = format!("{}", v269);
                                    _v270.set(Some(x_11))
                                }
                                {
                                    let v281: std::string::String = getValue(_v270.get().clone());
                                    {
                                        let x_12: string =
                                            fable_library_rust::String_::fromString(v281);
                                        _v252.set(Some(x_12))
                                    }
                                    {
                                        let v294: string = getValue(_v252.get().clone());
                                        let _v295: MutCell<Option<bool>> =
                                            MutCell::new(None::<bool>);
                                        {
                                            let x_13: bool = cfg!(windows);
                                            _v295.set(Some(x_13))
                                        }
                                        {
                                            let v333: Array<string> = split(
                                                if getValue(_v295.get().clone()) == false {
                                                    v294.clone()
                                                } else {
                                                    let _v308: MutCell<Option<string>> =
                                                        MutCell::new(None::<string>);
                                                    let v310: string = Documents::method17();
                                                    let v311: string = Documents::method18(v294);
                                                    let v312: string = Documents::method19();
                                                    let v314: &str = &regex::Regex::new(&v310)
                                                        .unwrap()
                                                        .replace_all(&v311, &*v312);
                                                    let v316: std::string::String =
                                                        String::from(v314);
                                                    {
                                                        let x_14: string =
                                                            fable_library_rust::String_::fromString(
                                                                v316,
                                                            );
                                                        _v308.set(Some(x_14))
                                                    }
                                                    {
                                                        let v326: string =
                                                            getValue(_v308.get().clone());
                                                        replace(
                                                            sprintf!(
                                                                "{}{}",
                                                                toLower(ofChar(getCharAt(
                                                                    v326.clone(),
                                                                    0_i32
                                                                ))),
                                                                getSlice(
                                                                    v326,
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
                                            let v335: i32 = count(v333.clone());
                                            let v336: LrcPtr<Documents::Mut4> =
                                                LrcPtr::new(Documents::Mut4 {
                                                    l0: MutCell::new(0_i32),
                                                    l1: MutCell::new(0_i32),
                                                    l2: MutCell::new(new_empty::<string>()),
                                                });
                                            while Documents::method20(v335, v336.clone()) {
                                                let v338: i32 = v336.l0.get().clone();
                                                let v341: i32 = v338.wrapping_neg() + v335 - 1_i32;
                                                let matchValue_4: i32 = v336.l1.get().clone();
                                                let v343: Array<string> = v336.l2.get().clone();
                                                let v342: i32 = matchValue_4;
                                                let v344: string = v333[v341].clone();
                                                let patternInput_4: (i32, Array<string>) =
                                                    if string("..") == v344.clone() {
                                                        (v342 + 1_i32, v343.clone())
                                                    } else {
                                                        if 0_i32 == v342 {
                                                            let v348: Array<string> =
                                                                new_array(&[v344]);
                                                            let v349: i32 = count(v348.clone());
                                                            let v351: i32 =
                                                                v349 + count(v343.clone());
                                                            let v352: Array<string> =
                                                                new_init(&string(""), v351);
                                                            let v353: LrcPtr<Documents::Mut5> =
                                                                LrcPtr::new(Documents::Mut5 {
                                                                    l0: MutCell::new(0_i32),
                                                                });
                                                            while Documents::method21(
                                                                v351,
                                                                v353.clone(),
                                                            ) {
                                                                let v355: i32 =
                                                                    v353.l0.get().clone();
                                                                let v360: string = if v355 < v349 {
                                                                    v348[v355].clone()
                                                                } else {
                                                                    let v358: i32 = v355 - v349;
                                                                    v343[v358].clone()
                                                                };
                                                                v352.get_mut()[v355 as usize] =
                                                                    v360;
                                                                {
                                                                    let v361: i32 = v355 + 1_i32;
                                                                    v353.l0.set(v361);
                                                                    ()
                                                                }
                                                            }
                                                            (0_i32, v352.clone())
                                                        } else {
                                                            (v342 - 1_i32, v343.clone())
                                                        }
                                                    };
                                                let v367: i32 = v338 + 1_i32;
                                                v336.l0.set(v367);
                                                v336.l1.set(patternInput_4.0.clone());
                                                v336.l2.set(patternInput_4.1.clone());
                                                ()
                                            }
                                            {
                                                let matchValue_6: i32 = v336.l1.get().clone();
                                                let v369: Array<string> = v336.l2.get().clone();
                                                let v370: LrcPtr<dyn IEnumerable_1<string>> =
                                                    delay(Func0::new({
                                                        let v369 = v369.clone();
                                                        move || {
                                                            map_1(
                                                                Func1::new({
                                                                    let v369 = v369.clone();
                                                                    move |i_1: i32| {
                                                                        v369[i_1].clone()
                                                                    }
                                                                }),
                                                                rangeNumeric(
                                                                    0_i32,
                                                                    1_i32,
                                                                    count(v369.clone()) - 1_i32,
                                                                ),
                                                            )
                                                        }
                                                    }));
                                                let _v371: MutCell<Option<char>> =
                                                    MutCell::new(None::<char>);
                                                {
                                                    let x_15: char = std::path::MAIN_SEPARATOR;
                                                    _v371.set(Some(x_15))
                                                }
                                                join(
                                                    Documents::method22(ofChar(getValue(
                                                        _v371.get().clone(),
                                                    ))),
                                                    toArray_1(v370),
                                                )
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    } else {
                        let v388: Result<std::path::PathBuf, std::io::Error> =
                            std::fs::canonicalize(&*v212);
                        let v390: std::path::PathBuf = v388.unwrap();
                        let v392: std::path::Display = v390.display();
                        let _v393: MutCell<Option<std::string::String>> =
                            MutCell::new(None::<std::string::String>);
                        {
                            let x_16: std::string::String = format!("{}", v392);
                            _v393.set(Some(x_16))
                        }
                        {
                            let v404: std::string::String = getValue(_v393.get().clone());
                            fable_library_rust::String_::fromString(v404)
                        }
                    };
                    _v210.set(Some(x_17))
                }
                {
                    let v415: string = getValue(_v210.get().clone());
                    let _v416: MutCell<Option<string>> = MutCell::new(None::<string>);
                    let v418: string = Documents::method13(v1_1);
                    let v419: string = Documents::method14(v418.clone());
                    let v421: &str = fable_library_rust::String_::LrcStr::as_str(&v419);
                    let v423: std::string::String = String::from(v421);
                    let v425: std::path::PathBuf = std::path::PathBuf::from(v423);
                    {
                        let x_26: string = if v425.exists() == false {
                            let _v429: MutCell<Option<string>> = MutCell::new(None::<string>);
                            let v432: Result<std::path::PathBuf, std::io::Error> =
                                std::env::current_dir();
                            let v434: std::path::PathBuf = v432.unwrap();
                            let v436: std::path::Display = v434.display();
                            let _v437: MutCell<Option<std::string::String>> =
                                MutCell::new(None::<std::string::String>);
                            {
                                let x_18: std::string::String = format!("{}", v436);
                                _v437.set(Some(x_18))
                            }
                            {
                                let v448: std::string::String = getValue(_v437.get().clone());
                                {
                                    let x_19: string =
                                        fable_library_rust::String_::fromString(v448);
                                    _v429.set(Some(x_19))
                                }
                                {
                                    let _v458: MutCell<Option<string>> =
                                        MutCell::new(None::<string>);
                                    let v460: string =
                                        Documents::method14(getValue(_v429.get().clone()));
                                    let v462: &str =
                                        fable_library_rust::String_::LrcStr::as_str(&v460);
                                    let v464: std::string::String = String::from(v462);
                                    let v466: std::path::PathBuf = std::path::PathBuf::from(v464);
                                    let v467: string = Documents::method14(v418.clone());
                                    let v469: &str =
                                        fable_library_rust::String_::LrcStr::as_str(&v467);
                                    let v471: std::string::String = String::from(v469);
                                    let v473: std::path::PathBuf = v466.join(v471);
                                    let v475: std::path::Display = v473.display();
                                    let _v476: MutCell<Option<std::string::String>> =
                                        MutCell::new(None::<std::string::String>);
                                    {
                                        let x_20: std::string::String = format!("{}", v475);
                                        _v476.set(Some(x_20))
                                    }
                                    {
                                        let v487: std::string::String =
                                            getValue(_v476.get().clone());
                                        {
                                            let x_21: string =
                                                fable_library_rust::String_::fromString(v487);
                                            _v458.set(Some(x_21))
                                        }
                                        {
                                            let v500: string = getValue(_v458.get().clone());
                                            let _v501: MutCell<Option<bool>> =
                                                MutCell::new(None::<bool>);
                                            {
                                                let x_22: bool = cfg!(windows);
                                                _v501.set(Some(x_22))
                                            }
                                            {
                                                let v539: Array<string> = split(
                                                    if getValue(_v501.get().clone()) == false {
                                                        v500.clone()
                                                    } else {
                                                        let _v514: MutCell<Option<string>> =
                                                            MutCell::new(None::<string>);
                                                        let v516: string = Documents::method17();
                                                        let v517: string =
                                                            Documents::method18(v500);
                                                        let v518: string = Documents::method19();
                                                        let v520: &str = &regex::Regex::new(&v516)
                                                            .unwrap()
                                                            .replace_all(&v517, &*v518);
                                                        let v522: std::string::String =
                                                            String::from(v520);
                                                        {
                                                            let x_23:
                                                                              string =
                                                                          fable_library_rust::String_::fromString(v522);
                                                            _v514.set(Some(x_23))
                                                        }
                                                        {
                                                            let v532: string =
                                                                getValue(_v514.get().clone());
                                                            replace(
                                                                sprintf!(
                                                                    "{}{}",
                                                                    toLower(ofChar(getCharAt(
                                                                        v532.clone(),
                                                                        0_i32
                                                                    ))),
                                                                    getSlice(
                                                                        v532,
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
                                                let v541: i32 = count(v539.clone());
                                                let v542: LrcPtr<Documents::Mut4> =
                                                    LrcPtr::new(Documents::Mut4 {
                                                        l0: MutCell::new(0_i32),
                                                        l1: MutCell::new(0_i32),
                                                        l2: MutCell::new(new_empty::<string>()),
                                                    });
                                                while Documents::method20(v541, v542.clone()) {
                                                    let v544: i32 = v542.l0.get().clone();
                                                    let v547: i32 =
                                                        v544.wrapping_neg() + v541 - 1_i32;
                                                    let matchValue_8: i32 = v542.l1.get().clone();
                                                    let v549: Array<string> = v542.l2.get().clone();
                                                    let v548: i32 = matchValue_8;
                                                    let v550: string = v539[v547].clone();
                                                    let patternInput_7: (i32, Array<string>) =
                                                        if string("..") == v550.clone() {
                                                            (v548 + 1_i32, v549.clone())
                                                        } else {
                                                            if 0_i32 == v548 {
                                                                let v554: Array<string> =
                                                                    new_array(&[v550]);
                                                                let v555: i32 = count(v554.clone());
                                                                let v557: i32 =
                                                                    v555 + count(v549.clone());
                                                                let v558: Array<string> =
                                                                    new_init(&string(""), v557);
                                                                let v559: LrcPtr<Documents::Mut5> =
                                                                    LrcPtr::new(Documents::Mut5 {
                                                                        l0: MutCell::new(0_i32),
                                                                    });
                                                                while Documents::method21(
                                                                    v557,
                                                                    v559.clone(),
                                                                ) {
                                                                    let v561: i32 =
                                                                        v559.l0.get().clone();
                                                                    let v566: string = if v561
                                                                        < v555
                                                                    {
                                                                        v554[v561].clone()
                                                                    } else {
                                                                        let v564: i32 = v561 - v555;
                                                                        v549[v564].clone()
                                                                    };
                                                                    v558.get_mut()[v561 as usize] =
                                                                        v566;
                                                                    {
                                                                        let v567: i32 =
                                                                            v561 + 1_i32;
                                                                        v559.l0.set(v567);
                                                                        ()
                                                                    }
                                                                }
                                                                (0_i32, v558.clone())
                                                            } else {
                                                                (v548 - 1_i32, v549.clone())
                                                            }
                                                        };
                                                    let v573: i32 = v544 + 1_i32;
                                                    v542.l0.set(v573);
                                                    v542.l1.set(patternInput_7.0.clone());
                                                    v542.l2.set(patternInput_7.1.clone());
                                                    ()
                                                }
                                                {
                                                    let matchValue_10: i32 = v542.l1.get().clone();
                                                    let v575: Array<string> = v542.l2.get().clone();
                                                    let v576: LrcPtr<dyn IEnumerable_1<string>> =
                                                        delay(Func0::new({
                                                            let v575 = v575.clone();
                                                            move || {
                                                                map_1(
                                                                    Func1::new({
                                                                        let v575 = v575.clone();
                                                                        move |i_2: i32| {
                                                                            v575[i_2].clone()
                                                                        }
                                                                    }),
                                                                    rangeNumeric(
                                                                        0_i32,
                                                                        1_i32,
                                                                        count(v575.clone()) - 1_i32,
                                                                    ),
                                                                )
                                                            }
                                                        }));
                                                    let _v577: MutCell<Option<char>> =
                                                        MutCell::new(None::<char>);
                                                    {
                                                        let x_24: char = std::path::MAIN_SEPARATOR;
                                                        _v577.set(Some(x_24))
                                                    }
                                                    join(
                                                        Documents::method22(ofChar(getValue(
                                                            _v577.get().clone(),
                                                        ))),
                                                        toArray_1(v576),
                                                    )
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        } else {
                            let v594: Result<std::path::PathBuf, std::io::Error> =
                                std::fs::canonicalize(&*v418);
                            let v596: std::path::PathBuf = v594.unwrap();
                            let v598: std::path::Display = v596.display();
                            let _v599: MutCell<Option<std::string::String>> =
                                MutCell::new(None::<std::string::String>);
                            {
                                let x_25: std::string::String = format!("{}", v598);
                                _v599.set(Some(x_25))
                            }
                            {
                                let v610: std::string::String = getValue(_v599.get().clone());
                                fable_library_rust::String_::fromString(v610)
                            }
                        };
                        _v416.set(Some(x_26))
                    }
                    {
                        let v621: string = getValue(_v416.get().clone());
                        Documents::method3(
                            Documents::US0::US0_1,
                            Func0::new(move || Documents::closure10((), ())),
                            Func0::new({
                                let v0_1 = v0_1.clone();
                                let v209 = v209.clone();
                                let v415 = v415.clone();
                                let v621 = v621.clone();
                                move || {
                                    Documents::closure11(
                                        v0_1.clone(),
                                        v209.clone(),
                                        v415.clone(),
                                        v621.clone(),
                                        (),
                                    )
                                }
                            }),
                        );
                        Documents::method24(v209.clone(), v415.clone(), v621.clone())
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
                                let v99: std::pin::Pin<
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
                                                                        LrcPtr<(string, string)>,
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
                                > = Documents::method12(
                                    fable_library_rust::String_::fromString(v96),
                                    v84,
                                    v70,
                                    v56,
                                );
                                let v101: Result<
                                    Vec<
                                        Result<
                                            LrcPtr<(
                                                string,
                                                Vec<
                                                    Option<
                                                        Result<string, LrcPtr<(string, string)>>,
                                                    >,
                                                >,
                                            )>,
                                            std::string::String,
                                        >,
                                    >,
                                    std::string::String,
                                > = futures_lite::future::block_on(v99);
                                let v103: Vec<
                                    Result<
                                        LrcPtr<(
                                            string,
                                            Vec<Option<Result<string, LrcPtr<(string, string)>>>>,
                                        )>,
                                        std::string::String,
                                    >,
                                > = v101.unwrap();
                                0_i32
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
