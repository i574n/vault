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
        use fable_library_rust::String_::lastIndexOf;
        use fable_library_rust::String_::length;
        use fable_library_rust::String_::ofChar;
        use fable_library_rust::String_::padLeft;
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
        pub trait IPathDirname {
            fn dirname(&self, path: string) -> string;
        }
        impl<V: IPathDirname + Clone + 'static> IPathDirname for LrcPtr<V> {
            #[inline]
            fn dirname(&self, path: string) -> string {
                (**self).dirname(path)
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
        #[derive(Clone, Debug, PartialEq, PartialOrd, Hash, Eq)]
        pub enum US4 {
            US4_0(string),
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
        #[derive(Clone, Debug, PartialEq, PartialOrd, Hash, Eq)]
        pub enum US18 {
            US18_0(i32, string),
            US18_1(i32, string),
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
                    let v74: string = padLeft(
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
        pub fn method13() -> string {
            string("polyglot")
        }
        pub fn method14() -> string {
            string(".paket")
        }
        pub fn method15() -> string {
            string("polyglot")
        }
        pub fn method16() -> string {
            string(".paket")
        }
        pub fn method18(v0_1: string) -> string {
            v0_1
        }
        pub fn method19(v0_1: string) -> string {
            v0_1
        }
        pub fn method20(v0_1: string) -> string {
            v0_1
        }
        pub fn closure10(unitVar: (), v0_1: string) -> Option<string> {
            let _v1: MutCell<Option<Documents::US4>> = MutCell::new(None::<Documents::US4>);
            let v3: string = Documents::method18(v0_1);
            let v5: &str = fable_library_rust::String_::LrcStr::as_str(&v3);
            let v7: std::string::String = String::from(v5);
            let v9: std::path::PathBuf = std::path::PathBuf::from(v7);
            let v11: Option<std::path::PathBuf> = v9.parent().map(std::path::PathBuf::from);
            let v13: std::path::PathBuf = v11?;
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
                    let x_1: Documents::US4 =
                        Documents::US4::US4_0(fable_library_rust::String_::fromString(v27));
                    _v1.set(Some(x_1))
                }
                {
                    let v55: Documents::US4 = getValue(_v1.get().clone());
                    match &v55 {
                        Documents::US4::US4_0(v55_0_0) => Some(match &v55 {
                            Documents::US4::US4_0(x) => x.clone(),
                            _ => unreachable!(),
                        }),
                        _ => None::<string>,
                    }
                }
            }
        }
        pub fn method21() -> Func1<string, Option<string>> {
            Func1::new(move |v: string| Documents::closure10((), v))
        }
        pub fn closure11(unitVar: (), v0_1: string) -> Documents::US4 {
            Documents::US4::US4_0(v0_1)
        }
        pub fn method22() -> Func1<string, Documents::US4> {
            Func1::new(move |v: string| Documents::closure11((), v))
        }
        pub fn method23(v0_1: string, v1_1: string, v2: string) -> string {
            let v0_1: MutCell<string> = MutCell::new(v0_1.clone());
            let v1_1: MutCell<string> = MutCell::new(v1_1.clone());
            let v2: MutCell<string> = MutCell::new(v2.clone());
            '_method23: loop {
                break '_method23 ({
                    let _v3: MutCell<Option<string>> = MutCell::new(None::<string>);
                    let v5: string = Documents::method18(v2.get().clone());
                    let v7: &str = fable_library_rust::String_::LrcStr::as_str(&v5);
                    let v9: std::string::String = String::from(v7);
                    let v11: std::path::PathBuf = std::path::PathBuf::from(v9);
                    let v12: string = Documents::method18(v0_1.get().clone());
                    let v14: &str = fable_library_rust::String_::LrcStr::as_str(&v12);
                    let v16: std::string::String = String::from(v14);
                    let v18: std::path::PathBuf = v11.join(v16);
                    let v20: std::path::Display = v18.display();
                    let _v21: MutCell<Option<std::string::String>> =
                        MutCell::new(None::<std::string::String>);
                    {
                        let x: std::string::String = format!("{}", v20);
                        _v21.set(Some(x))
                    }
                    {
                        let v32: std::string::String = getValue(_v21.get().clone());
                        {
                            let x_1: string = fable_library_rust::String_::fromString(v32);
                            _v3.set(Some(x_1))
                        }
                        {
                            let _v46: MutCell<Option<bool>> = MutCell::new(None::<bool>);
                            let v48: string = Documents::method18(getValue(_v3.get().clone()));
                            let v50: &str = fable_library_rust::String_::LrcStr::as_str(&v48);
                            let v52: std::string::String = String::from(v50);
                            let v54: std::path::PathBuf = std::path::PathBuf::from(v52);
                            {
                                let x_2: bool = if v54.clone().exists() {
                                    v54.is_dir()
                                } else {
                                    false
                                };
                                _v46.set(Some(x_2))
                            }
                            if getValue(_v46.get().clone()) {
                                v2.get().clone()
                            } else {
                                let v71: Option<string> = (Documents::method21())(v2.get().clone());
                                let v74: Documents::US4 = defaultValue(
                                    Documents::US4::US4_1,
                                    map(Documents::method22(), v71),
                                );
                                match &v74 {
                                    Documents::US4::US4_0(v74_0_0) => {
                                        let v0_1_temp: string = v0_1.get().clone();
                                        let v1_1_temp: string = v1_1.get().clone();
                                        let v2_temp: string = match &v74 {
                                            Documents::US4::US4_0(x) => x.clone(),
                                            _ => unreachable!(),
                                        };
                                        v0_1.set(v0_1_temp);
                                        v1_1.set(v1_1_temp);
                                        v2.set(v2_temp);
                                        continue '_method23;
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
                    }
                });
            }
        }
        pub fn method17(v0_1: string, v1_1: string) -> string {
            let _v2: MutCell<Option<string>> = MutCell::new(None::<string>);
            let v4: string = Documents::method18(v1_1.clone());
            let v6: &str = fable_library_rust::String_::LrcStr::as_str(&v4);
            let v8: std::string::String = String::from(v6);
            let v10: std::path::PathBuf = std::path::PathBuf::from(v8);
            let v11: string = Documents::method18(v0_1.clone());
            let v13: &str = fable_library_rust::String_::LrcStr::as_str(&v11);
            let v15: std::string::String = String::from(v13);
            let v17: std::path::PathBuf = v10.join(v15);
            let v19: std::path::Display = v17.display();
            let _v20: MutCell<Option<std::string::String>> =
                MutCell::new(None::<std::string::String>);
            {
                let x: std::string::String = format!("{}", v19);
                _v20.set(Some(x))
            }
            {
                let v31: std::string::String = getValue(_v20.get().clone());
                {
                    let x_1: string = fable_library_rust::String_::fromString(v31);
                    _v2.set(Some(x_1))
                }
                {
                    let _v45: MutCell<Option<bool>> = MutCell::new(None::<bool>);
                    let v47: string = Documents::method18(getValue(_v2.get().clone()));
                    let v49: &str = fable_library_rust::String_::LrcStr::as_str(&v47);
                    let v51: std::string::String = String::from(v49);
                    let v53: std::path::PathBuf = std::path::PathBuf::from(v51);
                    {
                        let x_2: bool = if v53.clone().exists() {
                            v53.is_dir()
                        } else {
                            false
                        };
                        _v45.set(Some(x_2))
                    }
                    if getValue(_v45.get().clone()) {
                        v1_1.clone()
                    } else {
                        let v70: Option<string> = (Documents::method21())(v1_1.clone());
                        let v73: Documents::US4 =
                            defaultValue(Documents::US4::US4_1, map(Documents::method22(), v70));
                        match &v73 {
                            Documents::US4::US4_0(v73_0_0) => Documents::method23(
                                v0_1.clone(),
                                v1_1.clone(),
                                match &v73 {
                                    Documents::US4::US4_0(x) => x.clone(),
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
        }
        pub fn method24() -> string {
            string("polyglot")
        }
        pub fn method25(v0_1: string) -> string {
            v0_1
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
        pub fn method29(v0_1: i32, v1_1: LrcPtr<Documents::Mut4>) -> bool {
            v1_1.l0.get().clone() < v0_1
        }
        pub fn method30(v0_1: i32, v1_1: LrcPtr<Documents::Mut5>) -> bool {
            v1_1.l0.get().clone() < v0_1
        }
        pub fn method31(v0_1: string) -> string {
            v0_1
        }
        pub fn method32(v0_1: string) -> string {
            v0_1
        }
        pub fn closure12(unitVar: (), unitVar_1: ()) -> string {
            string("documents.run")
        }
        pub fn closure13(
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
        pub fn method36(v0_1: async_walkdir::DirEntry) -> async_walkdir::DirEntry {
            v0_1
        }
        pub fn closure15(unitVar: (), v0_1: std::io::Error) -> std::string::String {
            let _v1: MutCell<Option<std::string::String>> =
                MutCell::new(None::<std::string::String>);
            {
                let x: std::string::String = format!("{}", v0_1);
                _v1.set(Some(x))
            }
            getValue(_v1.get().clone())
        }
        pub fn method37() -> Func1<std::io::Error, std::string::String> {
            Func1::new(move |v: std::io::Error| Documents::closure15((), v))
        }
        pub fn closure16(unitVar: (), v0_1: std::fs::FileType) -> Documents::US6 {
            Documents::US6::US6_0(v0_1)
        }
        pub fn closure17(unitVar: (), v0_1: std::string::String) -> Documents::US6 {
            Documents::US6::US6_1(v0_1)
        }
        pub fn method38(v0_1: std::fs::FileType) -> std::fs::FileType {
            v0_1
        }
        pub fn method39(v0_1: Documents::US5) -> Documents::US5 {
            v0_1
        }
        pub fn method35(
            v0_1: async_walkdir::DirEntry,
        ) -> std::pin::Pin<Box<dyn std::future::Future<Output = Documents::US5> + Send>> {
            let __result = Box::pin(async move {
                //;
                {
                    let v2: async_walkdir::DirEntry = Documents::method36(v0_1.clone());
                    let v4: std::pin::Pin<
                        Box<
                            dyn std::future::Future<
                                    Output = Result<std::fs::FileType, std::io::Error>,
                                > + Send,
                        >,
                    > = Box::pin(async_walkdir::DirEntry::file_type(&v2));
                    let v6: Result<std::fs::FileType, std::io::Error> = v4.await;
                    let v7 = Documents::method37();
                    let v9: Result<std::fs::FileType, std::string::String> = v6.map_err(|x| v7(x));
                    let v12: Documents::US6 = match &v9 {
                        Err(v9_1_0) => Documents::closure17((), v9_1_0.clone()),
                        Ok(v9_0_0) => Documents::closure16((), v9_0_0.clone()),
                    };
                    let v74: Documents::US5 =
                        Documents::method39(if let Documents::US6::US6_0(v12_0_0) = &v12 {
                            let v14: std::fs::FileType = Documents::method38(match &v12 {
                                Documents::US6::US6_0(x) => x.clone(),
                                _ => unreachable!(),
                            });
                            if std::fs::FileType::is_dir(&v14) {
                                Documents::US5::US5_0
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
                                        Documents::US5::US5_0
                                    } else {
                                        Documents::US5::US5_2
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
                                    Documents::US5::US5_0
                                } else {
                                    Documents::US5::US5_2
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
        pub fn method40(v0_1: async_walkdir::Filtering) -> async_walkdir::Filtering {
            v0_1
        }
        pub fn method34(
            v0_1: async_walkdir::DirEntry,
        ) -> std::pin::Pin<Box<dyn std::future::Future<Output = async_walkdir::Filtering> + Send>>
        {
            let __result = Box::pin(async {
                //;
                {
                    let v2: std::pin::Pin<
                        Box<dyn std::future::Future<Output = Documents::US5> + Send>,
                    > = Documents::method35(v0_1);
                    let v4: Documents::US5 = v2.await;
                    let v14: async_walkdir::Filtering = Documents::method40(match &v4 {
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
            Documents::method34(v0_1)
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
        ) -> Option<string> {
            let v1_1 = Documents::method37();
            let v3: Result<async_walkdir::DirEntry, std::string::String> =
                v0_1.map_err(|x| v1_1(x));
            let v6: Documents::US7 = match &v3 {
                Err(v3_1_0) => Documents::closure20((), v3_1_0.clone()),
                Ok(v3_0_0) => Documents::closure19((), v3_0_0.clone()),
            };
            let v33: Documents::US4 = match &v6 {
                Documents::US7::US7_0(v6_0_0) => {
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
                        Documents::US4::US4_0(fable_library_rust::String_::fromString(v23))
                    }
                }
                Documents::US7::US7_1(v6_1_0) => {
                    Documents::method3(
                        Documents::US0::US0_4,
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
            match &v33 {
                Documents::US4::US4_0(v33_0_0) => Some(match &v33 {
                    Documents::US4::US4_0(x) => x.clone(),
                    _ => unreachable!(),
                }),
                _ => None::<string>,
            }
        }
        pub fn method41() -> Func1<Result<async_walkdir::DirEntry, std::io::Error>, Option<string>>
        {
            Func1::new(move |v: Result<async_walkdir::DirEntry, std::io::Error>| {
                Documents::closure18((), v)
            })
        }
        pub fn closure23(unitVar: (), unitVar_1: ()) -> string {
            string("documents.run")
        }
        pub fn closure24(v0_1: Vec<string>, unitVar: ()) -> string {
            sprintf!(
                "files_len: {} / {}",
                v0_1.len(),
                Documents::closure6((), ())
            )
        }
        pub fn method42(
            v0_1: Option<CancellationToken>,
            v1_1: string,
            v2: Array<(string, string)>,
            v3: Option<Func1<(bool, string, i32), Arc<Async<()>>>>,
            v4: Option<string>,
        ) -> string {
            v1_1
        }
        pub fn method43() -> (string, string) {
            (string(""), string(""))
        }
        pub fn closure27(v0_1: char, v1_1: LrcPtr<Documents::UH0>) -> LrcPtr<Documents::UH0> {
            LrcPtr::new(Documents::UH0::UH0_1(v0_1, v1_1))
        }
        pub fn closure26(
            unitVar: (),
            v0_1: char,
        ) -> Func1<LrcPtr<Documents::UH0>, LrcPtr<Documents::UH0>> {
            Func1::new({
                let v0_1 = v0_1.clone();
                move |v: LrcPtr<Documents::UH0>| Documents::closure27(v0_1, v)
            })
        }
        pub fn method44() -> Func1<char, Func1<LrcPtr<Documents::UH0>, LrcPtr<Documents::UH0>>> {
            Func1::new(move |v: char| Documents::closure26((), v))
        }
        pub fn method45(
            v0_1: string,
            v1_1: string,
            v2: LrcPtr<Documents::UH0>,
            v3: Documents::US8,
        ) -> (string, string) {
            let v0_1: MutCell<string> = MutCell::new(v0_1.clone());
            let v1_1: MutCell<string> = MutCell::new(v1_1.clone());
            let v2: MutCell<LrcPtr<Documents::UH0>> = MutCell::new(v2.clone());
            let v3: MutCell<Documents::US8> = MutCell::new(v3.clone());
            '_method45: loop {
                break '_method45 (if let Documents::UH0::UH0_1(v2_1_0, v2_1_1) =
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
                            continue '_method45;
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
                                        continue '_method45;
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
                                            continue '_method45;
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
                                            continue '_method45;
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
                                        continue '_method45;
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
                                        continue '_method45;
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
                                    continue '_method45;
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
                                continue '_method45;
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
                                            continue '_method45;
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
                                                continue '_method45;
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
                                                continue '_method45;
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
                                            continue '_method45;
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
                                            continue '_method45;
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
                                        continue '_method45;
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
                                            continue '_method45;
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
                                            continue '_method45;
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
                                            continue '_method45;
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
                                            continue '_method45;
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
                                        continue '_method45;
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
                                        continue '_method45;
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
                                    continue '_method45;
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
        pub fn method49(
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
                    Documents::method49(
                        match v0_1.as_ref() {
                            Documents::UH1::UH1_1(_, x) => x.clone(),
                            _ => unreachable!(),
                        },
                        v1_1.clone(),
                    ),
                )),
            }
        }
        pub fn method48(
            v0_1: string,
            v1_1: LrcPtr<Documents::UH1>,
            v2: LrcPtr<Documents::UH0>,
            v3: Documents::US10,
        ) -> (LrcPtr<Documents::UH1>, string) {
            let v0_1: MutCell<string> = MutCell::new(v0_1.clone());
            let v1_1: MutCell<LrcPtr<Documents::UH1>> = MutCell::new(v1_1.clone());
            let v2: MutCell<LrcPtr<Documents::UH0>> = MutCell::new(v2.clone());
            let v3: MutCell<Documents::US10> = MutCell::new(v3.clone());
            '_method48: loop {
                break '_method48 (match &v3.get().clone() {
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
                                        Documents::method47(
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
                                                Documents::method47(
                                                    sprintf!("{}\"", v0_1.get().clone()),
                                                    v1_1.get().clone(),
                                                    v108.clone(),
                                                    v3.get().clone(),
                                                    Documents::US10::US10_1('\"'),
                                                )
                                            } else {
                                                if v3.get().clone() == Documents::US10::US10_1('\\')
                                                {
                                                    Documents::method47(
                                                        sprintf!("{}\"", v0_1.get().clone()),
                                                        v1_1.get().clone(),
                                                        v108.clone(),
                                                        v3.get().clone(),
                                                        Documents::US10::US10_1('\"'),
                                                    )
                                                } else {
                                                    Documents::method47(
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
                                                Documents::method47(
                                                    v0_1.get().clone(),
                                                    v1_1.get().clone(),
                                                    v108.clone(),
                                                    v3.get().clone(),
                                                    Documents::US10::US10_2(1_u8),
                                                )
                                            } else {
                                                if v3.get().clone() == Documents::US10::US10_2(0_u8)
                                                {
                                                    Documents::method47(
                                                        sprintf!("{}\"", v0_1.get().clone()),
                                                        v1_1.get().clone(),
                                                        v108.clone(),
                                                        v3.get().clone(),
                                                        Documents::US10::US10_1('\"'),
                                                    )
                                                } else {
                                                    Documents::method47(
                                                        string(""),
                                                        Documents::method49(
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
                                            Documents::method47(
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
                                                continue '_method48;
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
                                                continue '_method48;
                                            }
                                        }
                                    } else {
                                        if '\\' == v107 {
                                            Documents::method47(
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
                                                continue '_method48;
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
                                                continue '_method48;
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
                                            Documents::method49(
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
                                            Documents::method49(
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
                                            Documents::method47(
                                                sprintf!("{}\"", v0_1.get().clone()),
                                                v1_1.get().clone(),
                                                v220.clone(),
                                                v3.get().clone(),
                                                Documents::US10::US10_1('\"'),
                                            )
                                        } else {
                                            if v3.get().clone() == Documents::US10::US10_1('\\') {
                                                Documents::method47(
                                                    sprintf!("{}\"", v0_1.get().clone()),
                                                    v1_1.get().clone(),
                                                    v220.clone(),
                                                    v3.get().clone(),
                                                    Documents::US10::US10_1('\"'),
                                                )
                                            } else {
                                                Documents::method47(
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
                                            Documents::method47(
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
                                                continue '_method48;
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
                                                continue '_method48;
                                            }
                                        }
                                    }
                                } else {
                                    (
                                        if v0_1.get().clone() == string("") {
                                            v1_1.get().clone()
                                        } else {
                                            Documents::method49(
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
                                        Documents::method47(
                                            v0_1.get().clone(),
                                            v1_1.get().clone(),
                                            v270.clone(),
                                            v3.get().clone(),
                                            Documents::US10::US10_2(1_u8),
                                        )
                                    } else {
                                        if '\"' == v269 {
                                            if v3.get().clone() == Documents::US10::US10_2(0_u8) {
                                                Documents::method47(
                                                    sprintf!("{}\"", v0_1.get().clone()),
                                                    v1_1.get().clone(),
                                                    v270.clone(),
                                                    v3.get().clone(),
                                                    Documents::US10::US10_1('\"'),
                                                )
                                            } else {
                                                Documents::method47(
                                                    string(""),
                                                    Documents::method49(
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
                                                continue '_method48;
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
                                                continue '_method48;
                                            }
                                        }
                                    }
                                } else {
                                    (
                                        if v0_1.get().clone() == string("") {
                                            v1_1.get().clone()
                                        } else {
                                            Documents::method49(
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
                                Documents::method47(
                                    string(""),
                                    v1_1.get().clone(),
                                    v5.clone(),
                                    v3.get().clone(),
                                    Documents::US10::US10_1('\"'),
                                )
                            } else {
                                if '\\' == v4 {
                                    Documents::method47(
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
                                                Documents::method49(
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
                                        continue '_method48;
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
                                        continue '_method48;
                                    }
                                }
                            }
                        } else {
                            (
                                if v0_1.get().clone() == string("") {
                                    v1_1.get().clone()
                                } else {
                                    Documents::method49(
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
                                Documents::method47(
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
                                        continue '_method48;
                                    } else {
                                        Documents::method47(
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
                                        continue '_method48;
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
                                                continue '_method48;
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
                                                continue '_method48;
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
                                            continue '_method48;
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
                                        Documents::method49(
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
                                        Documents::method49(
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
        pub fn method47(
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
            '_method47: loop {
                break '_method47 (match &v4.get().clone() {
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
                                        continue '_method47;
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
                                                continue '_method47;
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
                                                    continue '_method47;
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
                                                    continue '_method47;
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
                                                continue '_method47;
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
                                                    continue '_method47;
                                                } else {
                                                    let v0_1_temp: string = string("");
                                                    let v1_1_temp: LrcPtr<Documents::UH1> =
                                                        Documents::method49(
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
                                                    continue '_method47;
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
                                            continue '_method47;
                                        } else {
                                            if ' ' == v108 {
                                                Documents::method48(
                                                    sprintf!("{} ", v0_1.get().clone()),
                                                    v1_1.get().clone(),
                                                    v109.clone(),
                                                    v4.get().clone(),
                                                )
                                            } else {
                                                Documents::method48(
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
                                            continue '_method47;
                                        } else {
                                            if ' ' == v108 {
                                                Documents::method48(
                                                    sprintf!("{} ", v0_1.get().clone()),
                                                    v1_1.get().clone(),
                                                    v109.clone(),
                                                    v4.get().clone(),
                                                )
                                            } else {
                                                Documents::method48(
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
                                            Documents::method49(
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
                                            Documents::method49(
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
                                            continue '_method47;
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
                                                continue '_method47;
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
                                                continue '_method47;
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
                                            continue '_method47;
                                        } else {
                                            if ' ' == v220 {
                                                Documents::method48(
                                                    sprintf!("{} ", v0_1.get().clone()),
                                                    v1_1.get().clone(),
                                                    v221.clone(),
                                                    v4.get().clone(),
                                                )
                                            } else {
                                                Documents::method48(
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
                                            Documents::method49(
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
                                        continue '_method47;
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
                                                continue '_method47;
                                            } else {
                                                let v0_1_temp: string = string("");
                                                let v1_1_temp: LrcPtr<Documents::UH1> =
                                                    Documents::method49(
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
                                                continue '_method47;
                                            }
                                        } else {
                                            if ' ' == v270 {
                                                Documents::method48(
                                                    sprintf!("{} ", v0_1.get().clone()),
                                                    v1_1.get().clone(),
                                                    v271.clone(),
                                                    v4.get().clone(),
                                                )
                                            } else {
                                                Documents::method48(
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
                                            Documents::method49(
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
                                continue '_method47;
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
                                    continue '_method47;
                                } else {
                                    if ' ' == v5 {
                                        Documents::method48(
                                            string(""),
                                            if v0_1.get().clone() == string("") {
                                                v1_1.get().clone()
                                            } else {
                                                Documents::method49(
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
                                        Documents::method48(
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
                                    Documents::method49(
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
                                continue '_method47;
                            } else {
                                if '\"' == v46 {
                                    if if let Documents::US10::US10_0 = &v3.get().clone() {
                                        true
                                    } else {
                                        false
                                    } {
                                        Documents::method48(
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
                                        continue '_method47;
                                    }
                                } else {
                                    if ' ' == v46 {
                                        Documents::method48(
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
                                                continue '_method47;
                                            } else {
                                                Documents::method48(
                                                    sprintf!("{}{}", v0_1.get().clone(), v46),
                                                    v1_1.get().clone(),
                                                    v47.clone(),
                                                    v4.get().clone(),
                                                )
                                            }
                                        } else {
                                            Documents::method48(
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
                                        Documents::method49(
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
                                        Documents::method49(
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
        pub fn method50(v0_1: LrcPtr<Documents::UH1>, v1_1: List<string>) -> List<string> {
            match v0_1.as_ref() {
                Documents::UH1::UH1_0 => v1_1.clone(),
                Documents::UH1::UH1_1(v0_1_1_0, v0_1_1_1) => cons(
                    match v0_1.as_ref() {
                        Documents::UH1::UH1_1(x, _) => x.clone(),
                        _ => unreachable!(),
                    },
                    Documents::method50(
                        match v0_1.as_ref() {
                            Documents::UH1::UH1_1(_, x) => x.clone(),
                            _ => unreachable!(),
                        },
                        v1_1.clone(),
                    ),
                ),
            }
        }
        pub fn method46(v0_1: string) -> Array<string> {
            let _v0: MutCell<Option<Option<string>>> = MutCell::new(None::<Option<string>>);
            _v0.set(Some(Some(v0_1)));
            {
                let v6: Option<string> = getValue(_v0.get().clone());
                let v9: Documents::US4 =
                    defaultValue(Documents::US4::US4_1, map(Documents::method22(), v6));
                let v12: string = match &v9 {
                    Documents::US4::US4_0(v9_0_0) => match &v9 {
                        Documents::US4::US4_0(x) => x.clone(),
                        _ => unreachable!(),
                    },
                    _ => string(""),
                };
                let v13: i32 = length(v12.clone());
                let v14: Array<char> = new_init(&'\u{0000}', v13);
                let v15: LrcPtr<Documents::Mut5> = LrcPtr::new(Documents::Mut5 {
                    l0: MutCell::new(0_i32),
                });
                while Documents::method30(v13, v15.clone()) {
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
                    toArray(Documents::method50(
                        (Documents::method47(
                            string(""),
                            LrcPtr::new(Documents::UH1::UH1_0),
                            foldBack(
                                Func2::new(move |b0: char, b1: LrcPtr<Documents::UH0>| {
                                    (Documents::method44())(b0)(b1)
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
        pub fn closure28(unitVar: (), v0_1: string) -> std::string::String {
            let v1_1: string = Documents::method18(v0_1);
            let v3: &str = fable_library_rust::String_::LrcStr::as_str(&v1_1);
            String::from(v3)
        }
        pub fn closure29(
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
        pub fn method51() -> Func0<string> {
            Func0::new(move || Documents::closure6((), ()))
        }
        pub fn method53(v0_1: string) -> string {
            v0_1
        }
        pub fn method55(
            v0_1: std::sync::Mutex<Option<std::process::Child>>,
        ) -> std::sync::Mutex<Option<std::process::Child>> {
            v0_1
        }
        pub fn closure30(
            unitVar: (),
            v0_1: std::process::Child,
        ) -> std::sync::Arc<std::sync::Mutex<Option<std::process::Child>>> {
            let v4: std::sync::Mutex<Option<std::process::Child>> =
                Documents::method55(std::sync::Mutex::new(Some(v0_1)));
            std::sync::Arc::new(v4)
        }
        pub fn method54(
        ) -> Func1<std::process::Child, std::sync::Arc<std::sync::Mutex<Option<std::process::Child>>>>
        {
            Func1::new(move |v: std::process::Child| Documents::closure30((), v))
        }
        pub fn method56(
            v0_1: Result<std::process::Child, std::io::Error>,
        ) -> Result<std::process::Child, std::io::Error> {
            v0_1
        }
        pub fn closure31(
            unitVar: (),
            v0_1: std::sync::Arc<std::sync::Mutex<Option<std::process::Child>>>,
        ) -> Documents::US11 {
            Documents::US11::US11_0(v0_1)
        }
        pub fn closure32(unitVar: (), v0_1: std::string::String) -> Documents::US11 {
            Documents::US11::US11_1(v0_1)
        }
        pub fn closure33(v0_1: std::string::String, unitVar: ()) -> string {
            sprintf!("execute_with_options -1 / error: {}", v0_1)
        }
        pub fn method57(
            v0_1: std::sync::Arc<std::sync::Mutex<Option<std::process::Child>>>,
        ) -> std::sync::Arc<std::sync::Mutex<Option<std::process::Child>>> {
            v0_1
        }
        pub fn method58(
            v0_1: std::sync::Mutex<Option<std::process::ChildStdout>>,
        ) -> std::sync::Mutex<Option<std::process::ChildStdout>> {
            v0_1
        }
        pub fn method59(
            v0_1: std::sync::Mutex<Option<std::process::ChildStderr>>,
        ) -> std::sync::Mutex<Option<std::process::ChildStderr>> {
            v0_1
        }
        pub fn method60(
            v0_1: std::sync::Mutex<Option<std::process::ChildStdin>>,
        ) -> std::sync::Mutex<Option<std::process::ChildStdin>> {
            v0_1
        }
        pub fn method61(
            v0_1: std::sync::Arc<std::sync::mpsc::Receiver<std::string::String>>,
        ) -> std::sync::Arc<std::sync::mpsc::Receiver<std::string::String>> {
            v0_1
        }
        pub fn method62(
            v0_1: std::sync::Mutex<std::sync::mpsc::Sender<std::string::String>>,
        ) -> std::sync::Mutex<std::sync::mpsc::Sender<std::string::String>> {
            v0_1
        }
        pub fn method63(
            v0_1: std::sync::Mutex<std::sync::Arc<std::sync::mpsc::Receiver<std::string::String>>>,
        ) -> std::sync::Mutex<std::sync::Arc<std::sync::mpsc::Receiver<std::string::String>>>
        {
            v0_1
        }
        pub fn method64(
            v0_1: std::sync::Mutex<std::io::Lines<std::io::BufReader<std::process::ChildStdout>>>,
        ) -> std::sync::Mutex<std::io::Lines<std::io::BufReader<std::process::ChildStdout>>>
        {
            v0_1
        }
        pub fn closure35(unitVar: (), v0_1: std::string::String) -> Documents::US13 {
            Documents::US13::US13_0(v0_1)
        }
        pub fn closure36(unitVar: (), v0_1: std::string::String) -> Documents::US13 {
            Documents::US13::US13_1(v0_1)
        }
        pub fn closure37(v0_1: std::string::String, unitVar: ()) -> string {
            sprintf!(
                "execute_with_options / stdout_line / stdout: {} / e: {}",
                true,
                v0_1
            )
        }
        pub fn closure38(v0_1: std::string::String, unitVar: ()) -> string {
            sprintf!("> {}", v0_1)
        }
        pub fn closure34(
            v0_1: std::sync::Arc<std::sync::Mutex<std::sync::mpsc::Sender<std::string::String>>>,
            v1_1: Result<std::string::String, std::io::Error>,
        ) {
            let v2 = Documents::method37();
            let v4: Result<std::string::String, std::string::String> = v1_1.map_err(|x| v2(x));
            let v7: Documents::US13 = match &v4 {
                Err(v4_1_0) => Documents::closure36((), v4_1_0.clone()),
                Ok(v4_0_0) => Documents::closure35((), v4_0_0.clone()),
            };
            let v23: std::string::String = match &v7 {
                Documents::US13::US13_0(v7_0_0) => {
                    let v8: std::string::String = v7_0_0.clone();
                    Documents::method3(
                        Documents::US0::US0_0,
                        Func0::new({
                            let v8 = v8.clone();
                            move || Documents::closure38(v8.clone(), ())
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
                            move || Documents::closure37(v12.clone(), ())
                        }),
                        Func0::new(move || Documents::closure6((), ())),
                    );
                    {
                        let v17: string = Documents::method18(sprintf!("[{}]", v12.clone()));
                        let v19: &str = fable_library_rust::String_::LrcStr::as_str(&v17);
                        String::from(v19)
                    }
                }
            };
            let v25: bool = true;
            v0_1.lock().unwrap().send(v23).unwrap();
            ()
        }
        pub fn method65(
            v0_1: std::sync::Arc<std::sync::Mutex<std::sync::mpsc::Sender<std::string::String>>>,
        ) -> Func1<Result<std::string::String, std::io::Error>, ()> {
            Func1::new({
                let v0_1 = v0_1.clone();
                move |v: Result<std::string::String, std::io::Error>| {
                    Documents::closure34(v0_1.clone(), v)
                }
            })
        }
        pub fn method66(
            v0_1: std::sync::Mutex<std::io::Lines<std::io::BufReader<std::process::ChildStderr>>>,
        ) -> std::sync::Mutex<std::io::Lines<std::io::BufReader<std::process::ChildStderr>>>
        {
            v0_1
        }
        pub fn closure40(v0_1: std::string::String, unitVar: ()) -> string {
            sprintf!(
                "execute_with_options / stdout_line / stdout: {} / e: {}",
                false,
                v0_1
            )
        }
        pub fn closure39(
            v0_1: std::sync::Arc<std::sync::Mutex<std::sync::mpsc::Sender<std::string::String>>>,
            v1_1: Result<std::string::String, std::io::Error>,
        ) {
            let v2 = Documents::method37();
            let v4: Result<std::string::String, std::string::String> = v1_1.map_err(|x| v2(x));
            let v7: Documents::US13 = match &v4 {
                Err(v4_1_0) => Documents::closure36((), v4_1_0.clone()),
                Ok(v4_0_0) => Documents::closure35((), v4_0_0.clone()),
            };
            let v23: std::string::String = match &v7 {
                Documents::US13::US13_0(v7_0_0) => {
                    let v8: std::string::String = v7_0_0.clone();
                    Documents::method3(
                        Documents::US0::US0_0,
                        Func0::new({
                            let v8 = v8.clone();
                            move || Documents::closure38(v8.clone(), ())
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
                            move || Documents::closure40(v12.clone(), ())
                        }),
                        Func0::new(move || Documents::closure6((), ())),
                    );
                    {
                        let v17: string = Documents::method18(sprintf!("[{}]", v12.clone()));
                        let v19: &str = fable_library_rust::String_::LrcStr::as_str(&v17);
                        String::from(v19)
                    }
                }
            };
            let v25: bool = true;
            v0_1.lock().unwrap().send(v23).unwrap();
            ()
        }
        pub fn method67(
            v0_1: std::sync::Arc<std::sync::Mutex<std::sync::mpsc::Sender<std::string::String>>>,
        ) -> Func1<Result<std::string::String, std::io::Error>, ()> {
            Func1::new({
                let v0_1 = v0_1.clone();
                move |v: Result<std::string::String, std::io::Error>| {
                    Documents::closure39(v0_1.clone(), v)
                }
            })
        }
        pub fn method68() -> string {
            string("test\\n\\n")
        }
        pub fn closure41(unitVar: (), v0_1: std::process::Output) -> Documents::US14 {
            Documents::US14::US14_0(v0_1)
        }
        pub fn closure42(unitVar: (), v0_1: std::string::String) -> Documents::US14 {
            Documents::US14::US14_1(v0_1)
        }
        pub fn closure43(v0_1: std::string::String, unitVar: ()) -> string {
            sprintf!("execute_with_options -2 / error: {}", v0_1)
        }
        pub fn closure44(v0_1: i32, v1_1: string, unitVar: ()) -> string {
            sprintf!(
                "execute_with_options / exit_code: {} / std_trace.Length: {}",
                v0_1,
                length(v1_1)
            )
        }
        pub fn method69(v0_: i32, v0__1: string) -> LrcPtr<(i32, string)> {
            LrcPtr::new((v0_, v0__1))
        }
        pub fn method52(
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
                    let v23: bool = true;
                    let mut v21 = v21;
                    let v25: &mut std::process::Command =
                        std::process::Command::stdin(&mut v21, std::process::Stdio::piped());
                    let v28: Documents::US4 =
                        defaultValue(Documents::US4::US4_1, map(Documents::method22(), v4));
                    let v34: &mut std::process::Command = match &v28 {
                        Documents::US4::US4_0(v28_0_0) => {
                            let v30: string = Documents::method53(match &v28 {
                                Documents::US4::US4_0(x) => x.clone(),
                                _ => unreachable!(),
                            });
                            std::process::Command::current_dir(v25, &*v30)
                        }
                        _ => v25,
                    };
                    let v36: bool = true;
                    let mut v34 = v34;
                    let v38: Result<std::process::Child, std::io::Error> =
                        std::process::Command::spawn(&mut v34);
                    let v39 = Documents::method54();
                    let v40: Result<std::process::Child, std::io::Error> = Documents::method56(v38);
                    let v42: Result<
                        std::sync::Arc<std::sync::Mutex<Option<std::process::Child>>>,
                        std::io::Error,
                    > = v40.map(|x| v39(x));
                    let v43 = Documents::method37();
                    let v45: Result<
                        std::sync::Arc<std::sync::Mutex<Option<std::process::Child>>>,
                        std::string::String,
                    > = v42.map_err(|x| v43(x));
                    let v48: Documents::US11 = match &v45 {
                        Err(v45_1_0) => Documents::closure32((), v45_1_0.clone()),
                        Ok(v45_0_0) => Documents::closure31((), v45_0_0.clone()),
                    };
                    let patternInput_1: (i32, Documents::US3, Documents::US12) = match &v48 {
                        Documents::US11::US11_0(v48_0_0) => {
                            let v50: std::sync::Arc<std::sync::Mutex<Option<std::process::Child>>> =
                                Documents::method57(v48_0_0.clone());
                            let v52: std::process::ChildStdout =
                                v50.lock().unwrap().as_mut().unwrap().stdout.take().unwrap();
                            let v54: std::process::ChildStderr =
                                v50.lock().unwrap().as_mut().unwrap().stderr.take().unwrap();
                            let v56: std::process::ChildStdin =
                                v50.lock().unwrap().as_mut().unwrap().stdin.take().unwrap();
                            let v60: std::sync::Mutex<Option<std::process::ChildStdout>> =
                                Documents::method58(std::sync::Mutex::new(Some(v52)));
                            let v62: std::sync::Arc<
                                std::sync::Mutex<Option<std::process::ChildStdout>>,
                            > = std::sync::Arc::new(v60);
                            let v66: std::sync::Mutex<Option<std::process::ChildStderr>> =
                                Documents::method59(std::sync::Mutex::new(Some(v54)));
                            let v68: std::sync::Arc<
                                std::sync::Mutex<Option<std::process::ChildStderr>>,
                            > = std::sync::Arc::new(v66);
                            let v72: std::sync::Mutex<Option<std::process::ChildStdin>> =
                                Documents::method60(std::sync::Mutex::new(Some(v56)));
                            let v74: std::sync::Arc<
                                std::sync::Mutex<Option<std::process::ChildStdin>>,
                            > = std::sync::Arc::new(v72);
                            let patternInput: (
                                std::sync::mpsc::Sender<std::string::String>,
                                std::sync::Arc<std::sync::mpsc::Receiver<std::string::String>>,
                            ) = {
                                let (sender, receiver) = std::sync::mpsc::channel();
                                (sender, std::sync::Arc::new(receiver))
                            };
                            let v78: std::sync::Arc<
                                std::sync::mpsc::Receiver<std::string::String>,
                            > = Documents::method61(patternInput.1.clone());
                            let v80: bool = true;
                            let v78 = v78;
                            let v83: std::sync::Mutex<
                                std::sync::mpsc::Sender<std::string::String>,
                            > = Documents::method62(std::sync::Mutex::new(patternInput.0.clone()));
                            let v85: std::sync::Arc<
                                std::sync::Mutex<std::sync::mpsc::Sender<std::string::String>>,
                            > = std::sync::Arc::new(v83);
                            let v87: std::sync::Arc<
                                std::sync::Mutex<std::sync::mpsc::Sender<std::string::String>>,
                            > = v85.clone();
                            let v89: std::sync::Arc<
                                std::sync::Mutex<std::sync::mpsc::Sender<std::string::String>>,
                            > = v85.clone();
                            let v92: std::sync::Mutex<
                                std::sync::Arc<std::sync::mpsc::Receiver<std::string::String>>,
                            > = Documents::method63(std::sync::Mutex::new(v78));
                            let v94: std::sync::Arc<
                                std::sync::Mutex<
                                    std::sync::Arc<std::sync::mpsc::Receiver<std::string::String>>,
                                >,
                            > = std::sync::Arc::new(v92);
                            let v96: std::thread::JoinHandle<()> = std::thread::spawn(move || {
                                //;
                                let v98: std::io::Lines<
                                    std::io::BufReader<std::process::ChildStdout>,
                                > = std::io::BufRead::lines(std::io::BufReader::new(
                                    v62.lock().unwrap().take().unwrap(),
                                ));
                                let v101: std::sync::Mutex<
                                    std::io::Lines<std::io::BufReader<std::process::ChildStdout>>,
                                > = Documents::method64(std::sync::Mutex::new(v98));
                                let v103: std::sync::Arc<
                                    std::sync::Mutex<
                                        std::io::Lines<
                                            std::io::BufReader<std::process::ChildStdout>,
                                        >,
                                    >,
                                > = std::sync::Arc::new(v101);
                                let v104 = Documents::method65(v87);
                                let v106: bool = true;
                                for line in v103.lock().unwrap().by_ref() {
                                    v104(line)
                                }
                                let v108: bool = true;
                            });
                            let v110: std::thread::JoinHandle<()> = std::thread::spawn(move || {
                                //;
                                let v112: std::io::Lines<
                                    std::io::BufReader<std::process::ChildStderr>,
                                > = std::io::BufRead::lines(std::io::BufReader::new(
                                    v68.lock().unwrap().take().unwrap(),
                                ));
                                let v115: std::sync::Mutex<
                                    std::io::Lines<std::io::BufReader<std::process::ChildStderr>>,
                                > = Documents::method66(std::sync::Mutex::new(v112));
                                let v117: std::sync::Arc<
                                    std::sync::Mutex<
                                        std::io::Lines<
                                            std::io::BufReader<std::process::ChildStderr>,
                                        >,
                                    >,
                                > = std::sync::Arc::new(v115);
                                let v118 = Documents::method67(v85);
                                let v120: bool = true;
                                for line in v117.lock().unwrap().by_ref() {
                                    v118(line)
                                }
                                let v122: bool = true;
                            });
                            let v123: string = Documents::method68();
                            let v125: &[u8] = v123.as_bytes();
                            let v127: bool = true;
                            std::io::Write::write_all(
                                &mut v74.lock().unwrap().take().unwrap(),
                                v125,
                            )
                            .unwrap();
                            let v129: Result<std::process::Output, std::io::Error> =
                                v50.lock().unwrap().take().unwrap().wait_with_output();
                            let v130 = Documents::method37();
                            let v132: Result<std::process::Output, std::string::String> =
                                v129.map_err(|x| v130(x));
                            let v134: bool = true;
                            v96.join().unwrap();
                            let v136: bool = true;
                            v110.join().unwrap();
                            let v139: Documents::US14 = match &v132 {
                                Err(v132_1_0) => Documents::closure42((), v132_1_0.clone()),
                                Ok(v132_0_0) => Documents::closure41((), v132_0_0.clone()),
                            };
                            match &v139 {
                                Documents::US14::US14_0(v139_0_0) => (
                                    v139_0_0.clone().status.code().unwrap(),
                                    Documents::US3::US3_1,
                                    Documents::US12::US12_0(v94),
                                ),
                                Documents::US14::US14_1(v139_1_0) => {
                                    let v145: std::string::String = v139_1_0.clone();
                                    Documents::method3(
                                        Documents::US0::US0_4,
                                        Func0::new({
                                            let v145 = v145.clone();
                                            move || Documents::closure43(v145.clone(), ())
                                        }),
                                        Func0::new(move || Documents::closure6((), ())),
                                    );
                                    (
                                        -2_i32,
                                        Documents::US3::US3_0(v145.clone()),
                                        Documents::US12::US12_1,
                                    )
                                }
                            }
                        }
                        Documents::US11::US11_1(v48_1_0) => {
                            let v157: std::string::String = v48_1_0.clone();
                            Documents::method3(
                                Documents::US0::US0_4,
                                Func0::new({
                                    let v157 = v157.clone();
                                    move || Documents::closure33(v157.clone(), ())
                                }),
                                Func0::new(move || Documents::closure6((), ())),
                            );
                            (
                                -1_i32,
                                Documents::US3::US3_0(v157.clone()),
                                Documents::US12::US12_1,
                            )
                        }
                    };
                    let v168: Documents::US12 = patternInput_1.2.clone();
                    let v167: Documents::US3 = patternInput_1.1.clone();
                    let v166: i32 = patternInput_1.0.clone();
                    let v175: Documents::US3 = match &v168 {
                        Documents::US12::US12_0(v168_0_0) => Documents::US3::US3_0(
                            match &v168 {
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
                    let v182: Documents::US4 = match &v175 {
                        Documents::US3::US3_0(v175_0_0) => Documents::US4::US4_0(
                            fable_library_rust::String_::fromString(match &v175 {
                                Documents::US3::US3_0(x) => x.clone(),
                                _ => unreachable!(),
                            }),
                        ),
                        _ => Documents::US4::US4_1,
                    };
                    let v189: Documents::US4 = match &v167 {
                        Documents::US3::US3_0(v167_0_0) => Documents::US4::US4_0(
                            fable_library_rust::String_::fromString(match &v167 {
                                Documents::US3::US3_0(x) => x.clone(),
                                _ => unreachable!(),
                            }),
                        ),
                        _ => Documents::US4::US4_1,
                    };
                    let v193: string = match &v189 {
                        Documents::US4::US4_0(v189_0_0) => match &v189 {
                            Documents::US4::US4_0(x) => x.clone(),
                            _ => unreachable!(),
                        },
                        _ => string(""),
                    };
                    let v196: string = match &v182 {
                        Documents::US4::US4_0(v182_0_0) => match &v182 {
                            Documents::US4::US4_0(x) => x.clone(),
                            _ => unreachable!(),
                        },
                        _ => v193,
                    };
                    Documents::method3(
                        Documents::US0::US0_0,
                        Func0::new({
                            let v166 = v166.clone();
                            let v196 = v196.clone();
                            move || Documents::closure44(v166, v196.clone(), ())
                        }),
                        Func0::new(move || Documents::closure6((), ())),
                    );
                    {
                        let v200: LrcPtr<(i32, string)> = LrcPtr::new((v166, v196.clone()));
                        let v201: LrcPtr<(i32, string)> =
                            Documents::method69(v200.0.clone(), v200.1.clone());
                        v201
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
        pub fn closure45(
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
        pub fn closure47(
            unitVar: (),
            v0_1: Func1<(bool, string, i32), Arc<Async<()>>>,
        ) -> Documents::US15 {
            Documents::US15::US15_0(v0_1)
        }
        pub fn method70() -> Func1<Func1<(bool, string, i32), Arc<Async<()>>>, Documents::US15> {
            Func1::new(move |v: Func1<(bool, string, i32), Arc<Async<()>>>| {
                Documents::closure47((), v)
            })
        }
        pub fn closure48(v0_1: string, unitVar: ()) -> string {
            sprintf!("> {}", v0_1)
        }
        pub fn closure46(
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
        pub fn closure49(
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
        pub fn closure50(unitVar: (), v0_1: CancellationToken) -> Documents::US16 {
            Documents::US16::US16_0(v0_1)
        }
        pub fn method71() -> Func1<CancellationToken, Documents::US16> {
            Func1::new(move |v: CancellationToken| Documents::closure50((), v))
        }
        pub fn closure51(v0_1: (), unitVar: ()) {
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
        pub fn closure52(v0_1: LrcPtr<TaskCanceledException>, unitVar: ()) -> string {
            sprintf!(
                "execute_with_options_async / WaitForExitAsync / ex: {:?}",
                v0_1
            )
        }
        pub fn method72() -> string {
            string("\n")
        }
        pub fn closure53(v0_1: i32, v1_1: string, unitVar: ()) -> string {
            sprintf!(
                "execute_with_options_async / exit_code: {} / output.Length: {}",
                v0_1,
                length(v1_1)
            )
        }
        pub fn closure55(unitVar: (), unitVar_1: ()) -> string {
            string("documents.run / par_map / files_fn")
        }
        pub fn closure56(v0_1: string, v1_1: i32, unitVar: ()) -> string {
            sprintf!(
                "exit_code: {:?} / result: {} / {}",
                v1_1,
                v0_1,
                Documents::closure6((), ())
            )
        }
        pub fn method73(v0_1: string) -> string {
            v0_1
        }
        pub fn closure54(
            v0_1: string,
            v1_1: string,
            v2: string,
            v3: string,
            v4: string,
        ) -> Documents::US17 {
            let v14: string = if endsWith(v4.clone(), string(".md"), false) == false {
                sprintf!("{}.{}", v0_1.clone(), v4.clone())
            } else {
                sprintf!(
                    "{}.{}",
                    getSlice(
                        v0_1.clone(),
                        Some(0_i32),
                        Some(lastIndexOf(v0_1, string(".")) - 1_i32)
                    ),
                    v4.clone()
                )
            };
            let v23: string = if endsWith(v4.clone(), string(".md"), false) == false {
                sprintf!("{}.{}", v1_1.clone(), v4.clone())
            } else {
                sprintf!(
                    "{}.{}",
                    getSlice(
                        v1_1.clone(),
                        Some(0_i32),
                        Some(lastIndexOf(v1_1, string(".")) - 1_i32)
                    ),
                    v4
                )
            };
            let _v24: MutCell<Option<bool>> = MutCell::new(None::<bool>);
            let v26: string = Documents::method18(v14.clone());
            let v28: &str = fable_library_rust::String_::LrcStr::as_str(&v26);
            let v30: std::string::String = String::from(v28);
            let v32: std::path::PathBuf = std::path::PathBuf::from(v30);
            {
                let x: bool = if v32.clone().exists() {
                    v32.is_file()
                } else {
                    false
                };
                _v24.set(Some(x))
            }
            if (if if getValue(_v24.get().clone()) {
                let _v48: MutCell<Option<bool>> = MutCell::new(None::<bool>);
                let v50: string = Documents::method18(v23.clone());
                let v52: &str = fable_library_rust::String_::LrcStr::as_str(&v50);
                let v54: std::string::String = String::from(v52);
                let v56: std::path::PathBuf = std::path::PathBuf::from(v54);
                {
                    let x_1: bool = if v56.clone().exists() {
                        v56.is_file()
                    } else {
                        false
                    };
                    _v48.set(Some(x_1))
                }
                getValue(_v48.get().clone())
            } else {
                false
            } {
                let _v72: MutCell<Option<bool>> = MutCell::new(None::<bool>);
                {
                    let x_2: bool = cfg!(windows);
                    _v72.set(Some(x_2))
                }
                {
                    let v109: Option<string> = None::<string>;
                    let v110: Option<CancellationToken> = None::<CancellationToken>;
                    let v111: Array<(string, string)> = new_empty::<(string, string)>();
                    let v112 = None::<Func1<(bool, string, i32), Arc<Async<()>>>>;
                    let v113: string = sprintf!(
                        "pwsh -c \"(Get-FileHash \\\"{}\\\" -Algorithm SHA256).Hash\"",
                        if getValue(_v72.get().clone()) == false {
                            v14.clone()
                        } else {
                            let _v85: MutCell<Option<string>> = MutCell::new(None::<string>);
                            let v87: string = Documents::method26();
                            let v88: string = Documents::method27(v14.clone());
                            let v89: string = Documents::method28();
                            let v91: &str =
                                &regex::Regex::new(&v87).unwrap().replace_all(&v88, &*v89);
                            let v93: std::string::String = String::from(v91);
                            {
                                let x_3: string = fable_library_rust::String_::fromString(v93);
                                _v85.set(Some(x_3))
                            }
                            {
                                let v103: string = getValue(_v85.get().clone());
                                replace(
                                    sprintf!(
                                        "{}{}",
                                        toLower(ofChar(getCharAt(v103.clone(), 0_i32))),
                                        getSlice(v103, Some(1_i32), None::<i32>)
                                    ),
                                    string("\\"),
                                    string("/"),
                                )
                            }
                        }
                    );
                    let _v114: MutCell<Option<(i32, string)>> = MutCell::new(None::<(i32, string)>);
                    let v116: string = Documents::method42(
                        v110.clone(),
                        v113.clone(),
                        v111.clone(),
                        v112.clone(),
                        v109.clone(),
                    );
                    let patternInput: (string, string) = Documents::method43();
                    let v119: i32 = length(v116.clone());
                    let v120: Array<char> = new_init(&'\u{0000}', v119);
                    let v121: LrcPtr<Documents::Mut5> = LrcPtr::new(Documents::Mut5 {
                        l0: MutCell::new(0_i32),
                    });
                    while Documents::method30(v119, v121.clone()) {
                        let v123: i32 = v121.l0.get().clone();
                        let v124: char = getCharAt(v116.clone(), v123);
                        v120.get_mut()[v123 as usize] = v124;
                        {
                            let v125: i32 = v123 + 1_i32;
                            v121.l0.set(v125);
                            ()
                        }
                    }
                    {
                        let v127: List<char> = ofArray(v120.clone());
                        let patternInput_1: (string, string) = Documents::method45(
                            patternInput.1.clone(),
                            patternInput.0.clone(),
                            foldBack(
                                Func2::new(move |b0: char, b1: LrcPtr<Documents::UH0>| {
                                    (Documents::method44())(b0)(b1)
                                }),
                                v127,
                                LrcPtr::new(Documents::UH0::UH0_0),
                            ),
                            Documents::US8::US8_0,
                        );
                        let v135: string = patternInput_1.0.clone();
                        let v137: Array<string> = Documents::method46(patternInput_1.1.clone());
                        let v139: Vec<string> = v137.to_vec();
                        fn v141(v: string) -> std::string::String {
                            Documents::closure28((), v)
                        }
                        let v142: Vec<std::string::String> =
                            v139.iter().map(|x| Func1::from(v141)(x.clone())).collect();
                        Documents::method3(
                            Documents::US0::US0_1,
                            Func0::new({
                                let v109 = v109.clone();
                                let v110 = v110.clone();
                                let v111 = v111.clone();
                                let v112 = v112.clone();
                                let v113 = v113.clone();
                                let v135 = v135.clone();
                                let v142 = v142.clone();
                                move || {
                                    Documents::closure29(
                                        v110.clone(),
                                        v113.clone(),
                                        v111.clone(),
                                        v112.clone(),
                                        v109.clone(),
                                        v135.clone(),
                                        v142.clone(),
                                        (),
                                    )
                                }
                            }),
                            Documents::method51(),
                        );
                        {
                            let v146: std::pin::Pin<
                                Box<dyn std::future::Future<Output = LrcPtr<(i32, string)>>>,
                            > = Documents::method52(
                                v110.clone(),
                                v113.clone(),
                                v111.clone(),
                                v112.clone(),
                                v109.clone(),
                                v135.clone(),
                                v142.clone(),
                            );
                            let v148: LrcPtr<(i32, string)> = futures_lite::future::block_on(v146);
                            _v114.set(Some((v148.0.clone(), v148.1.clone())));
                            {
                                let patternInput_2: (i32, string) = getValue(_v114.get().clone());
                                let _v331: MutCell<Option<bool>> = MutCell::new(None::<bool>);
                                {
                                    let x_5: bool = cfg!(windows);
                                    _v331.set(Some(x_5))
                                }
                                {
                                    let v368: Option<string> = None::<string>;
                                    let v369: Option<CancellationToken> = None::<CancellationToken>;
                                    let v370: Array<(string, string)> =
                                        new_empty::<(string, string)>();
                                    let v371 = None::<Func1<(bool, string, i32), Arc<Async<()>>>>;
                                    let v372: string =
                                            sprintf!("pwsh -c \"(Get-FileHash \\\"{}\\\" -Algorithm SHA256).Hash\"",
                                                     if getValue(_v331.get().clone())
                                                            == false {
                                                         v23.clone()
                                                     } else {
                                                         let _v344:
                                                                 MutCell<Option<string>> =
                                                             MutCell::new(None::<string>);
                                                         let v346: string =
                                                             Documents::method26();
                                                         let v347: string =
                                                             Documents::method27(v23.clone());
                                                         let v348: string =
                                                             Documents::method28();
                                                         let v350: &str =
                                                             &regex::Regex::new(&v346).unwrap().replace_all(&v347, &*v348);
                                                         let v352:
                                                                 std::string::String =
                                                             String::from(v350);
                                                         {
                                                             let x_6: string =
                                                                 fable_library_rust::String_::fromString(v352);
                                                             _v344.set(Some(x_6))
                                                         }
                                                         {
                                                             let v362:
                                                                     string =
                                                                 getValue(_v344.get().clone());
                                                             replace(sprintf!("{}{}",
                                                                              toLower(ofChar(getCharAt(v362.clone(),
                                                                                                       0_i32))),
                                                                              getSlice(v362,
                                                                                       Some(1_i32),
                                                                                       None::<i32>)),
                                                                     string("\\"),
                                                                     string("/"))
                                                         }
                                                     });
                                    let _v373: MutCell<Option<(i32, string)>> =
                                        MutCell::new(None::<(i32, string)>);
                                    let v375: string = Documents::method42(
                                        v369.clone(),
                                        v372.clone(),
                                        v370.clone(),
                                        v371.clone(),
                                        v368.clone(),
                                    );
                                    let patternInput_3: (string, string) = Documents::method43();
                                    let v378: i32 = length(v375.clone());
                                    let v379: Array<char> = new_init(&'\u{0000}', v378);
                                    let v380: LrcPtr<Documents::Mut5> =
                                        LrcPtr::new(Documents::Mut5 {
                                            l0: MutCell::new(0_i32),
                                        });
                                    while Documents::method30(v378, v380.clone()) {
                                        let v382: i32 = v380.l0.get().clone();
                                        let v383: char = getCharAt(v375.clone(), v382);
                                        v379.get_mut()[v382 as usize] = v383;
                                        {
                                            let v384: i32 = v382 + 1_i32;
                                            v380.l0.set(v384);
                                            ()
                                        }
                                    }
                                    {
                                        let v386: List<char> = ofArray(v379.clone());
                                        let patternInput_4: (string, string) = Documents::method45(
                                            patternInput_3.1.clone(),
                                            patternInput_3.0.clone(),
                                            foldBack(
                                                Func2::new(
                                                    move |b0: char, b1: LrcPtr<Documents::UH0>| {
                                                        (Documents::method44())(b0)(b1)
                                                    },
                                                ),
                                                v386,
                                                LrcPtr::new(Documents::UH0::UH0_0),
                                            ),
                                            Documents::US8::US8_0,
                                        );
                                        let v394: string = patternInput_4.0.clone();
                                        let v396: Array<string> =
                                            Documents::method46(patternInput_4.1.clone());
                                        let v398: Vec<string> = v396.to_vec();
                                        let v400: Vec<std::string::String> = v398
                                            .iter()
                                            .map(|x| Func1::from(v141)(x.clone()))
                                            .collect();
                                        Documents::method3(
                                            Documents::US0::US0_1,
                                            Func0::new({
                                                let v368 = v368.clone();
                                                let v369 = v369.clone();
                                                let v370 = v370.clone();
                                                let v371 = v371.clone();
                                                let v372 = v372.clone();
                                                let v394 = v394.clone();
                                                let v400 = v400.clone();
                                                move || {
                                                    Documents::closure29(
                                                        v369.clone(),
                                                        v372.clone(),
                                                        v370.clone(),
                                                        v371.clone(),
                                                        v368.clone(),
                                                        v394.clone(),
                                                        v400.clone(),
                                                        (),
                                                    )
                                                }
                                            }),
                                            Documents::method51(),
                                        );
                                        {
                                            let v404: std::pin::Pin<
                                                Box<
                                                    dyn std::future::Future<
                                                        Output = LrcPtr<(i32, string)>,
                                                    >,
                                                >,
                                            > = Documents::method52(
                                                v369.clone(),
                                                v372.clone(),
                                                v370.clone(),
                                                v371.clone(),
                                                v368.clone(),
                                                v394.clone(),
                                                v400.clone(),
                                            );
                                            let v406: LrcPtr<(i32, string)> =
                                                futures_lite::future::block_on(v404);
                                            _v373.set(Some((v406.0.clone(), v406.1.clone())));
                                            patternInput_2.1.clone()
                                                == (getValue(_v373.get().clone())).1.clone()
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            } else {
                false
            }) == false
            {
                let v592: Option<string> = None::<string>;
                let v593: Option<CancellationToken> = None::<CancellationToken>;
                let v594: Array<(string, string)> = new_empty::<(string, string)>();
                let v595 = None::<Func1<(bool, string, i32), Arc<Async<()>>>>;
                let _v596: MutCell<Option<bool>> = MutCell::new(None::<bool>);
                {
                    let x_8: bool = cfg!(windows);
                    _v596.set(Some(x_8))
                }
                {
                    let v611: string = sprintf!(
                        "../vault/deps/hangulize/cmd/hangulize/hangulize{}",
                        if getValue(_v596.get().clone()) {
                            string(".exe")
                        } else {
                            string("")
                        }
                    );
                    let _v612: MutCell<Option<string>> = MutCell::new(None::<string>);
                    let v614: string = Documents::method18(v3);
                    let v616: &str = fable_library_rust::String_::LrcStr::as_str(&v614);
                    let v618: std::string::String = String::from(v616);
                    let v620: std::path::PathBuf = std::path::PathBuf::from(v618);
                    let v621: string = Documents::method18(v611);
                    let v623: &str = fable_library_rust::String_::LrcStr::as_str(&v621);
                    let v625: std::string::String = String::from(v623);
                    let v627: std::path::PathBuf = v620.join(v625);
                    let v629: std::path::Display = v627.display();
                    let _v630: MutCell<Option<std::string::String>> =
                        MutCell::new(None::<std::string::String>);
                    {
                        let x_9: std::string::String = format!("{}", v629);
                        _v630.set(Some(x_9))
                    }
                    {
                        let v641: std::string::String = getValue(_v630.get().clone());
                        {
                            let x_10: string = fable_library_rust::String_::fromString(v641);
                            _v612.set(Some(x_10))
                        }
                        {
                            let v655: string = sprintf!("{} {}", getValue(_v612.get().clone()), v2);
                            let _v656: MutCell<Option<(i32, string)>> =
                                MutCell::new(None::<(i32, string)>);
                            let v658: string = Documents::method42(
                                v593.clone(),
                                v655.clone(),
                                v594.clone(),
                                v595.clone(),
                                v592.clone(),
                            );
                            let patternInput_6: (string, string) = Documents::method43();
                            let v661: i32 = length(v658.clone());
                            let v662: Array<char> = new_init(&'\u{0000}', v661);
                            let v663: LrcPtr<Documents::Mut5> = LrcPtr::new(Documents::Mut5 {
                                l0: MutCell::new(0_i32),
                            });
                            while Documents::method30(v661, v663.clone()) {
                                let v665: i32 = v663.l0.get().clone();
                                let v666: char = getCharAt(v658.clone(), v665);
                                v662.get_mut()[v665 as usize] = v666;
                                {
                                    let v667: i32 = v665 + 1_i32;
                                    v663.l0.set(v667);
                                    ()
                                }
                            }
                            {
                                let v669: List<char> = ofArray(v662.clone());
                                let patternInput_7: (string, string) = Documents::method45(
                                    patternInput_6.1.clone(),
                                    patternInput_6.0.clone(),
                                    foldBack(
                                        Func2::new(move |b0: char, b1: LrcPtr<Documents::UH0>| {
                                            (Documents::method44())(b0)(b1)
                                        }),
                                        v669,
                                        LrcPtr::new(Documents::UH0::UH0_0),
                                    ),
                                    Documents::US8::US8_0,
                                );
                                let v677: string = patternInput_7.0.clone();
                                let v679: Array<string> =
                                    Documents::method46(patternInput_7.1.clone());
                                let v681: Vec<string> = v679.to_vec();
                                let v684: Vec<std::string::String> =
                                    v681.iter()
                                        .map(|x| {
                                            Func1::new(move |v_1: string| {
                                                Documents::closure28((), v_1)
                                            })(x.clone())
                                        })
                                        .collect();
                                Documents::method3(
                                    Documents::US0::US0_1,
                                    Func0::new({
                                        let v592 = v592.clone();
                                        let v593 = v593.clone();
                                        let v594 = v594.clone();
                                        let v595 = v595.clone();
                                        let v655 = v655.clone();
                                        let v677 = v677.clone();
                                        let v684 = v684.clone();
                                        move || {
                                            Documents::closure29(
                                                v593.clone(),
                                                v655.clone(),
                                                v594.clone(),
                                                v595.clone(),
                                                v592.clone(),
                                                v677.clone(),
                                                v684.clone(),
                                                (),
                                            )
                                        }
                                    }),
                                    Documents::method51(),
                                );
                                {
                                    let v688: std::pin::Pin<
                                        Box<
                                            dyn std::future::Future<Output = LrcPtr<(i32, string)>>,
                                        >,
                                    > = Documents::method52(
                                        v593.clone(),
                                        v655.clone(),
                                        v594.clone(),
                                        v595.clone(),
                                        v592.clone(),
                                        v677.clone(),
                                        v684.clone(),
                                    );
                                    let v690: LrcPtr<(i32, string)> =
                                        futures_lite::future::block_on(v688);
                                    _v656.set(Some((v690.0.clone(), v690.1.clone())));
                                    {
                                        let patternInput_8: (i32, string) =
                                            getValue(_v656.get().clone());
                                        let v872: string = patternInput_8.1.clone();
                                        let v871: i32 = patternInput_8.0.clone();
                                        if v871 != 0_i32 {
                                            Documents::method3(
                                                Documents::US0::US0_2,
                                                Func0::new(move || Documents::closure55((), ())),
                                                Func0::new({
                                                    let v871 = v871.clone();
                                                    let v872 = v872.clone();
                                                    move || {
                                                        Documents::closure56(v872.clone(), v871, ())
                                                    }
                                                }),
                                            );
                                            Documents::US17::US17_0(Err::<
                                                string,
                                                LrcPtr<(string, string)>,
                                            >(
                                                LrcPtr::new((v14.clone(), v872.clone())),
                                            ))
                                        } else {
                                            let _v880: MutCell<Option<bool>> =
                                                MutCell::new(None::<bool>);
                                            let v882: string = Documents::method18(v14.clone());
                                            let v884: &str =
                                                fable_library_rust::String_::LrcStr::as_str(&v882);
                                            let v886: std::string::String = String::from(v884);
                                            let v888: std::path::PathBuf =
                                                std::path::PathBuf::from(v886);
                                            {
                                                let x_12: bool = if v888.clone().exists() {
                                                    v888.is_file()
                                                } else {
                                                    false
                                                };
                                                _v880.set(Some(x_12))
                                            }
                                            if getValue(_v880.get().clone()) {
                                                let _v903: MutCell<Option<()>> =
                                                    MutCell::new(None::<()>);
                                                let v905: string = Documents::method73(v23);
                                                let v907: Result<u64, std::io::Error> =
                                                    std::fs::copy(&*v14, &*v905);
                                                let v909: u64 = v907.unwrap();
                                                _v903.set(Some(()));
                                                getValue(_v903.get().clone());
                                                ()
                                            }
                                            Documents::US17::US17_0(Ok::<
                                                string,
                                                LrcPtr<(string, string)>,
                                            >(
                                                v14
                                            ))
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            } else {
                Documents::US17::US17_1
            }
        }
        pub fn closure58(unitVar: (), unitVar_1: ()) -> string {
            string("documents.run / par_map / crowbook")
        }
        pub fn closure59(v0_1: string, v1_1: i32, unitVar: ()) -> string {
            sprintf!(
                "exit_code: {:?} / result: {} / {}",
                v1_1,
                v0_1,
                Documents::closure6((), ())
            )
        }
        pub fn closure57(v0_1: string, v1_1: string, v2: string, v3: string) -> Documents::US17 {
            let v13: string = if endsWith(v3.clone(), string(".md"), false) == false {
                sprintf!("{}.{}", v0_1.clone(), v3.clone())
            } else {
                sprintf!(
                    "{}.{}",
                    getSlice(
                        v0_1.clone(),
                        Some(0_i32),
                        Some(lastIndexOf(v0_1.clone(), string(".")) - 1_i32)
                    ),
                    v3.clone()
                )
            };
            let v22: string = if endsWith(v3.clone(), string(".md"), false) == false {
                sprintf!("{}.{}", v1_1.clone(), v3.clone())
            } else {
                sprintf!(
                    "{}.{}",
                    getSlice(
                        v1_1.clone(),
                        Some(0_i32),
                        Some(lastIndexOf(v1_1, string(".")) - 1_i32)
                    ),
                    v3.clone()
                )
            };
            let _v23: MutCell<Option<bool>> = MutCell::new(None::<bool>);
            let v25: string = Documents::method18(v13.clone());
            let v27: &str = fable_library_rust::String_::LrcStr::as_str(&v25);
            let v29: std::string::String = String::from(v27);
            let v31: std::path::PathBuf = std::path::PathBuf::from(v29);
            {
                let x: bool = if v31.clone().exists() {
                    v31.is_file()
                } else {
                    false
                };
                _v23.set(Some(x))
            }
            if (if if getValue(_v23.get().clone()) {
                let _v47: MutCell<Option<bool>> = MutCell::new(None::<bool>);
                let v49: string = Documents::method18(v22.clone());
                let v51: &str = fable_library_rust::String_::LrcStr::as_str(&v49);
                let v53: std::string::String = String::from(v51);
                let v55: std::path::PathBuf = std::path::PathBuf::from(v53);
                {
                    let x_1: bool = if v55.clone().exists() {
                        v55.is_file()
                    } else {
                        false
                    };
                    _v47.set(Some(x_1))
                }
                getValue(_v47.get().clone())
            } else {
                false
            } {
                let _v71: MutCell<Option<bool>> = MutCell::new(None::<bool>);
                {
                    let x_2: bool = cfg!(windows);
                    _v71.set(Some(x_2))
                }
                {
                    let v108: Option<string> = None::<string>;
                    let v109: Option<CancellationToken> = None::<CancellationToken>;
                    let v110: Array<(string, string)> = new_empty::<(string, string)>();
                    let v111 = None::<Func1<(bool, string, i32), Arc<Async<()>>>>;
                    let v112: string = sprintf!(
                        "pwsh -c \"(Get-FileHash \\\"{}\\\" -Algorithm SHA256).Hash\"",
                        if getValue(_v71.get().clone()) == false {
                            v13.clone()
                        } else {
                            let _v84: MutCell<Option<string>> = MutCell::new(None::<string>);
                            let v86: string = Documents::method26();
                            let v87: string = Documents::method27(v13.clone());
                            let v88: string = Documents::method28();
                            let v90: &str =
                                &regex::Regex::new(&v86).unwrap().replace_all(&v87, &*v88);
                            let v92: std::string::String = String::from(v90);
                            {
                                let x_3: string = fable_library_rust::String_::fromString(v92);
                                _v84.set(Some(x_3))
                            }
                            {
                                let v102: string = getValue(_v84.get().clone());
                                replace(
                                    sprintf!(
                                        "{}{}",
                                        toLower(ofChar(getCharAt(v102.clone(), 0_i32))),
                                        getSlice(v102, Some(1_i32), None::<i32>)
                                    ),
                                    string("\\"),
                                    string("/"),
                                )
                            }
                        }
                    );
                    let _v113: MutCell<Option<(i32, string)>> = MutCell::new(None::<(i32, string)>);
                    let v115: string = Documents::method42(
                        v109.clone(),
                        v112.clone(),
                        v110.clone(),
                        v111.clone(),
                        v108.clone(),
                    );
                    let patternInput: (string, string) = Documents::method43();
                    let v118: i32 = length(v115.clone());
                    let v119: Array<char> = new_init(&'\u{0000}', v118);
                    let v120: LrcPtr<Documents::Mut5> = LrcPtr::new(Documents::Mut5 {
                        l0: MutCell::new(0_i32),
                    });
                    while Documents::method30(v118, v120.clone()) {
                        let v122: i32 = v120.l0.get().clone();
                        let v123: char = getCharAt(v115.clone(), v122);
                        v119.get_mut()[v122 as usize] = v123;
                        {
                            let v124: i32 = v122 + 1_i32;
                            v120.l0.set(v124);
                            ()
                        }
                    }
                    {
                        let v126: List<char> = ofArray(v119.clone());
                        let patternInput_1: (string, string) = Documents::method45(
                            patternInput.1.clone(),
                            patternInput.0.clone(),
                            foldBack(
                                Func2::new(move |b0: char, b1: LrcPtr<Documents::UH0>| {
                                    (Documents::method44())(b0)(b1)
                                }),
                                v126,
                                LrcPtr::new(Documents::UH0::UH0_0),
                            ),
                            Documents::US8::US8_0,
                        );
                        let v134: string = patternInput_1.0.clone();
                        let v136: Array<string> = Documents::method46(patternInput_1.1.clone());
                        let v138: Vec<string> = v136.to_vec();
                        fn v140(v: string) -> std::string::String {
                            Documents::closure28((), v)
                        }
                        let v141: Vec<std::string::String> =
                            v138.iter().map(|x| Func1::from(v140)(x.clone())).collect();
                        Documents::method3(
                            Documents::US0::US0_1,
                            Func0::new({
                                let v108 = v108.clone();
                                let v109 = v109.clone();
                                let v110 = v110.clone();
                                let v111 = v111.clone();
                                let v112 = v112.clone();
                                let v134 = v134.clone();
                                let v141 = v141.clone();
                                move || {
                                    Documents::closure29(
                                        v109.clone(),
                                        v112.clone(),
                                        v110.clone(),
                                        v111.clone(),
                                        v108.clone(),
                                        v134.clone(),
                                        v141.clone(),
                                        (),
                                    )
                                }
                            }),
                            Documents::method51(),
                        );
                        {
                            let v145: std::pin::Pin<
                                Box<dyn std::future::Future<Output = LrcPtr<(i32, string)>>>,
                            > = Documents::method52(
                                v109.clone(),
                                v112.clone(),
                                v110.clone(),
                                v111.clone(),
                                v108.clone(),
                                v134.clone(),
                                v141.clone(),
                            );
                            let v147: LrcPtr<(i32, string)> = futures_lite::future::block_on(v145);
                            _v113.set(Some((v147.0.clone(), v147.1.clone())));
                            {
                                let patternInput_2: (i32, string) = getValue(_v113.get().clone());
                                let _v330: MutCell<Option<bool>> = MutCell::new(None::<bool>);
                                {
                                    let x_5: bool = cfg!(windows);
                                    _v330.set(Some(x_5))
                                }
                                {
                                    let v367: Option<string> = None::<string>;
                                    let v368: Option<CancellationToken> = None::<CancellationToken>;
                                    let v369: Array<(string, string)> =
                                        new_empty::<(string, string)>();
                                    let v370 = None::<Func1<(bool, string, i32), Arc<Async<()>>>>;
                                    let v371: string =
                                            sprintf!("pwsh -c \"(Get-FileHash \\\"{}\\\" -Algorithm SHA256).Hash\"",
                                                     if getValue(_v330.get().clone())
                                                            == false {
                                                         v22.clone()
                                                     } else {
                                                         let _v343:
                                                                 MutCell<Option<string>> =
                                                             MutCell::new(None::<string>);
                                                         let v345: string =
                                                             Documents::method26();
                                                         let v346: string =
                                                             Documents::method27(v22.clone());
                                                         let v347: string =
                                                             Documents::method28();
                                                         let v349: &str =
                                                             &regex::Regex::new(&v345).unwrap().replace_all(&v346, &*v347);
                                                         let v351:
                                                                 std::string::String =
                                                             String::from(v349);
                                                         {
                                                             let x_6: string =
                                                                 fable_library_rust::String_::fromString(v351);
                                                             _v343.set(Some(x_6))
                                                         }
                                                         {
                                                             let v361:
                                                                     string =
                                                                 getValue(_v343.get().clone());
                                                             replace(sprintf!("{}{}",
                                                                              toLower(ofChar(getCharAt(v361.clone(),
                                                                                                       0_i32))),
                                                                              getSlice(v361,
                                                                                       Some(1_i32),
                                                                                       None::<i32>)),
                                                                     string("\\"),
                                                                     string("/"))
                                                         }
                                                     });
                                    let _v372: MutCell<Option<(i32, string)>> =
                                        MutCell::new(None::<(i32, string)>);
                                    let v374: string = Documents::method42(
                                        v368.clone(),
                                        v371.clone(),
                                        v369.clone(),
                                        v370.clone(),
                                        v367.clone(),
                                    );
                                    let patternInput_3: (string, string) = Documents::method43();
                                    let v377: i32 = length(v374.clone());
                                    let v378: Array<char> = new_init(&'\u{0000}', v377);
                                    let v379: LrcPtr<Documents::Mut5> =
                                        LrcPtr::new(Documents::Mut5 {
                                            l0: MutCell::new(0_i32),
                                        });
                                    while Documents::method30(v377, v379.clone()) {
                                        let v381: i32 = v379.l0.get().clone();
                                        let v382: char = getCharAt(v374.clone(), v381);
                                        v378.get_mut()[v381 as usize] = v382;
                                        {
                                            let v383: i32 = v381 + 1_i32;
                                            v379.l0.set(v383);
                                            ()
                                        }
                                    }
                                    {
                                        let v385: List<char> = ofArray(v378.clone());
                                        let patternInput_4: (string, string) = Documents::method45(
                                            patternInput_3.1.clone(),
                                            patternInput_3.0.clone(),
                                            foldBack(
                                                Func2::new(
                                                    move |b0: char, b1: LrcPtr<Documents::UH0>| {
                                                        (Documents::method44())(b0)(b1)
                                                    },
                                                ),
                                                v385,
                                                LrcPtr::new(Documents::UH0::UH0_0),
                                            ),
                                            Documents::US8::US8_0,
                                        );
                                        let v393: string = patternInput_4.0.clone();
                                        let v395: Array<string> =
                                            Documents::method46(patternInput_4.1.clone());
                                        let v397: Vec<string> = v395.to_vec();
                                        let v399: Vec<std::string::String> = v397
                                            .iter()
                                            .map(|x| Func1::from(v140)(x.clone()))
                                            .collect();
                                        Documents::method3(
                                            Documents::US0::US0_1,
                                            Func0::new({
                                                let v367 = v367.clone();
                                                let v368 = v368.clone();
                                                let v369 = v369.clone();
                                                let v370 = v370.clone();
                                                let v371 = v371.clone();
                                                let v393 = v393.clone();
                                                let v399 = v399.clone();
                                                move || {
                                                    Documents::closure29(
                                                        v368.clone(),
                                                        v371.clone(),
                                                        v369.clone(),
                                                        v370.clone(),
                                                        v367.clone(),
                                                        v393.clone(),
                                                        v399.clone(),
                                                        (),
                                                    )
                                                }
                                            }),
                                            Documents::method51(),
                                        );
                                        {
                                            let v403: std::pin::Pin<
                                                Box<
                                                    dyn std::future::Future<
                                                        Output = LrcPtr<(i32, string)>,
                                                    >,
                                                >,
                                            > = Documents::method52(
                                                v368.clone(),
                                                v371.clone(),
                                                v369.clone(),
                                                v370.clone(),
                                                v367.clone(),
                                                v393.clone(),
                                                v399.clone(),
                                            );
                                            let v405: LrcPtr<(i32, string)> =
                                                futures_lite::future::block_on(v403);
                                            _v372.set(Some((v405.0.clone(), v405.1.clone())));
                                            patternInput_2.1.clone()
                                                == (getValue(_v372.get().clone())).1.clone()
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            } else {
                false
            }) == false
            {
                let v591: string =
                    sprintf!("crowbook --single \"{}\" --output \"{}\" --to {} --set rendering.num_depth 6 html.css.add \\\"\'\'\' body {{ color: #e8e6e3; background-color: #202324; }} a {{ color: #989693; }} \'\'\'\\\"",
                             v0_1, v13.clone(), v3);
                let v593: Option<CancellationToken> = None::<CancellationToken>;
                let v594: Array<(string, string)> = new_empty::<(string, string)>();
                let v595 = None::<Func1<(bool, string, i32), Arc<Async<()>>>>;
                let v596: Option<string> = Some(v2);
                let _v597: MutCell<Option<(i32, string)>> = MutCell::new(None::<(i32, string)>);
                let v599: string = Documents::method42(
                    v593.clone(),
                    v591.clone(),
                    v594.clone(),
                    v595.clone(),
                    v596.clone(),
                );
                let patternInput_6: (string, string) = Documents::method43();
                let v602: i32 = length(v599.clone());
                let v603: Array<char> = new_init(&'\u{0000}', v602);
                let v604: LrcPtr<Documents::Mut5> = LrcPtr::new(Documents::Mut5 {
                    l0: MutCell::new(0_i32),
                });
                while Documents::method30(v602, v604.clone()) {
                    let v606: i32 = v604.l0.get().clone();
                    let v607: char = getCharAt(v599.clone(), v606);
                    v603.get_mut()[v606 as usize] = v607;
                    {
                        let v608: i32 = v606 + 1_i32;
                        v604.l0.set(v608);
                        ()
                    }
                }
                {
                    let v610: List<char> = ofArray(v603.clone());
                    let patternInput_7: (string, string) = Documents::method45(
                        patternInput_6.1.clone(),
                        patternInput_6.0.clone(),
                        foldBack(
                            Func2::new(move |b0: char, b1: LrcPtr<Documents::UH0>| {
                                (Documents::method44())(b0)(b1)
                            }),
                            v610,
                            LrcPtr::new(Documents::UH0::UH0_0),
                        ),
                        Documents::US8::US8_0,
                    );
                    let v618: string = patternInput_7.0.clone();
                    let v620: Array<string> = Documents::method46(patternInput_7.1.clone());
                    let v622: Vec<string> = v620.to_vec();
                    let v625: Vec<std::string::String> = v622
                        .iter()
                        .map(|x| {
                            Func1::new(move |v_1: string| Documents::closure28((), v_1))(x.clone())
                        })
                        .collect();
                    Documents::method3(
                        Documents::US0::US0_1,
                        Func0::new({
                            let v591 = v591.clone();
                            let v593 = v593.clone();
                            let v594 = v594.clone();
                            let v595 = v595.clone();
                            let v596 = v596.clone();
                            let v618 = v618.clone();
                            let v625 = v625.clone();
                            move || {
                                Documents::closure29(
                                    v593.clone(),
                                    v591.clone(),
                                    v594.clone(),
                                    v595.clone(),
                                    v596.clone(),
                                    v618.clone(),
                                    v625.clone(),
                                    (),
                                )
                            }
                        }),
                        Documents::method51(),
                    );
                    {
                        let v629: std::pin::Pin<
                            Box<dyn std::future::Future<Output = LrcPtr<(i32, string)>>>,
                        > = Documents::method52(
                            v593.clone(),
                            v591.clone(),
                            v594.clone(),
                            v595.clone(),
                            v596.clone(),
                            v618.clone(),
                            v625.clone(),
                        );
                        let v631: LrcPtr<(i32, string)> = futures_lite::future::block_on(v629);
                        _v597.set(Some((v631.0.clone(), v631.1.clone())));
                        {
                            let patternInput_8: (i32, string) = getValue(_v597.get().clone());
                            let v813: string = patternInput_8.1.clone();
                            let v812: i32 = patternInput_8.0.clone();
                            let v821: Documents::US18 = if contains(v813.clone(), string("ERROR")) {
                                Documents::method3(
                                    Documents::US0::US0_2,
                                    Func0::new(move || Documents::closure58((), ())),
                                    Func0::new({
                                        let v812 = v812.clone();
                                        let v813 = v813.clone();
                                        move || Documents::closure59(v813.clone(), v812, ())
                                    }),
                                );
                                Documents::US18::US18_1(v812, v813.clone())
                            } else {
                                Documents::US18::US18_0(v812, v813.clone())
                            };
                            if let Documents::US18::US18_0(v821_0_0, v821_0_1) = &v821 {
                                let v823: string = match &v821 {
                                    Documents::US18::US18_0(_, x) => x.clone(),
                                    _ => unreachable!(),
                                };
                                let v822: i32 = match &v821 {
                                    Documents::US18::US18_0(x, _) => x.clone(),
                                    _ => unreachable!(),
                                };
                                if v822 != 0_i32 {
                                    Documents::method3(
                                        Documents::US0::US0_2,
                                        Func0::new(move || Documents::closure55((), ())),
                                        Func0::new({
                                            let v822 = v822.clone();
                                            let v823 = v823.clone();
                                            move || Documents::closure56(v823.clone(), v822, ())
                                        }),
                                    );
                                    Documents::US17::US17_0(
                                        Err::<string, LrcPtr<(string, string)>>(LrcPtr::new((
                                            v13.clone(),
                                            v823.clone(),
                                        ))),
                                    )
                                } else {
                                    let _v831: MutCell<Option<bool>> = MutCell::new(None::<bool>);
                                    let v833: string = Documents::method18(v13.clone());
                                    let v835: &str =
                                        fable_library_rust::String_::LrcStr::as_str(&v833);
                                    let v837: std::string::String = String::from(v835);
                                    let v839: std::path::PathBuf = std::path::PathBuf::from(v837);
                                    {
                                        let x_9: bool = if v839.clone().exists() {
                                            v839.is_file()
                                        } else {
                                            false
                                        };
                                        _v831.set(Some(x_9))
                                    }
                                    if getValue(_v831.get().clone()) {
                                        let _v854: MutCell<Option<()>> = MutCell::new(None::<()>);
                                        let v856: string = Documents::method73(v22.clone());
                                        let v858: Result<u64, std::io::Error> =
                                            std::fs::copy(&*v13, &*v856);
                                        let v860: u64 = v858.unwrap();
                                        _v854.set(Some(()));
                                        getValue(_v854.get().clone());
                                        ()
                                    }
                                    Documents::US17::US17_0(Ok::<string, LrcPtr<(string, string)>>(
                                        v13.clone(),
                                    ))
                                }
                            } else {
                                let _v864: MutCell<Option<bool>> = MutCell::new(None::<bool>);
                                let v866: string = Documents::method18(v13.clone());
                                let v868: &str = fable_library_rust::String_::LrcStr::as_str(&v866);
                                let v870: std::string::String = String::from(v868);
                                let v872: std::path::PathBuf = std::path::PathBuf::from(v870);
                                {
                                    let x_11: bool = if v872.clone().exists() {
                                        v872.is_file()
                                    } else {
                                        false
                                    };
                                    _v864.set(Some(x_11))
                                }
                                if getValue(_v864.get().clone()) {
                                    let _v887: MutCell<Option<()>> = MutCell::new(None::<()>);
                                    let v889: string = Documents::method73(v22);
                                    let v891: Result<u64, std::io::Error> =
                                        std::fs::copy(&*v13, &*v889);
                                    let v893: u64 = v891.unwrap();
                                    _v887.set(Some(()));
                                    getValue(_v887.get().clone());
                                    ()
                                }
                                Documents::US17::US17_0(Ok::<string, LrcPtr<(string, string)>>(v13))
                            }
                        }
                    }
                }
            } else {
                Documents::US17::US17_1
            }
        }
        pub fn closure60(
            unitVar: (),
            _arg: (string, Func1<string, Documents::US17>),
        ) -> Option<Result<string, LrcPtr<(string, string)>>> {
            let v2: Documents::US17 = (_arg.1.clone())(_arg.0.clone());
            match &v2 {
                Documents::US17::US17_0(v2_0_0) => Some(match &v2 {
                    Documents::US17::US17_0(x) => x.clone(),
                    _ => unreachable!(),
                }),
                _ => None::<Result<string, LrcPtr<(string, string)>>>,
            }
        }
        pub fn closure61(unitVar: (), unitVar_1: ()) -> string {
            string("documents.run / par_map")
        }
        pub fn closure62(
            v0_1: string,
            v1_1: string,
            v2: string,
            v3: string,
            v4: i32,
            v5: string,
            v6: i32,
            v7: string,
            v8: string,
            v9: Vec<Option<Result<string, LrcPtr<(string, string)>>>>,
            unitVar: (),
        ) -> string {
            sprintf!("file: {} / real_path: {} / relative_path: {} / origin_hash_exit_code: {} / origin_hash: {} / local_git_hash_exit_code: {} / local_git_hash: {} / hash1: {} / hash2: {:?} / files: {:?} / {}",
                     v1_1, v2, v0_1, v4, v3, v6, v5, v7, v8, v9,
                     Documents::closure6((), ()))
        }
        pub fn closure25(
            v0_1: string,
            v1_1: string,
            v2: string,
            v3: string,
            v4: string,
            v5: string,
        ) -> Result<
            LrcPtr<(
                string,
                Vec<Option<Result<string, LrcPtr<(string, string)>>>>,
            )>,
            std::string::String,
        > {
            let _v6: MutCell<Option<string>> = MutCell::new(None::<string>);
            let v8: string = Documents::method25(v5);
            let v9: string = Documents::method18(v8.clone());
            let v11: &str = fable_library_rust::String_::LrcStr::as_str(&v9);
            let v13: std::string::String = String::from(v11);
            let v15: std::path::PathBuf = std::path::PathBuf::from(v13);
            {
                let x_8: string = if v15.exists() == false {
                    let _v19: MutCell<Option<string>> = MutCell::new(None::<string>);
                    let v22: Result<std::path::PathBuf, std::io::Error> = std::env::current_dir();
                    let v24: std::path::PathBuf = v22.unwrap();
                    let v26: std::path::Display = v24.display();
                    let _v27: MutCell<Option<std::string::String>> =
                        MutCell::new(None::<std::string::String>);
                    {
                        let x: std::string::String = format!("{}", v26);
                        _v27.set(Some(x))
                    }
                    {
                        let v38: std::string::String = getValue(_v27.get().clone());
                        {
                            let x_1: string = fable_library_rust::String_::fromString(v38);
                            _v19.set(Some(x_1))
                        }
                        {
                            let v47: string = getValue(_v19.get().clone());
                            let _v48: MutCell<Option<string>> = MutCell::new(None::<string>);
                            let v50: string = Documents::method18(v47.clone());
                            let v52: &str = fable_library_rust::String_::LrcStr::as_str(&v50);
                            let v54: std::string::String = String::from(v52);
                            let v56: std::path::PathBuf = std::path::PathBuf::from(v54);
                            let v57: string = Documents::method18(v8.clone());
                            let v59: &str = fable_library_rust::String_::LrcStr::as_str(&v57);
                            let v61: std::string::String = String::from(v59);
                            let v63: std::path::PathBuf = v56.join(v61);
                            let v65: std::path::Display = v63.display();
                            let _v66: MutCell<Option<std::string::String>> =
                                MutCell::new(None::<std::string::String>);
                            {
                                let x_2: std::string::String = format!("{}", v65);
                                _v66.set(Some(x_2))
                            }
                            {
                                let v77: std::string::String = getValue(_v66.get().clone());
                                {
                                    let x_3: string = fable_library_rust::String_::fromString(v77);
                                    _v48.set(Some(x_3))
                                }
                                {
                                    let v90: string = getValue(_v48.get().clone());
                                    let _v91: MutCell<Option<bool>> = MutCell::new(None::<bool>);
                                    {
                                        let x_4: bool = cfg!(windows);
                                        _v91.set(Some(x_4))
                                    }
                                    {
                                        let v129: Array<string> = split(
                                            if getValue(_v91.get().clone()) == false {
                                                v90.clone()
                                            } else {
                                                let _v104: MutCell<Option<string>> =
                                                    MutCell::new(None::<string>);
                                                let v106: string = Documents::method26();
                                                let v107: string = Documents::method27(v90);
                                                let v108: string = Documents::method28();
                                                let v110: &str = &regex::Regex::new(&v106)
                                                    .unwrap()
                                                    .replace_all(&v107, &*v108);
                                                let v112: std::string::String = String::from(v110);
                                                {
                                                    let x_5: string =
                                                        fable_library_rust::String_::fromString(
                                                            v112,
                                                        );
                                                    _v104.set(Some(x_5))
                                                }
                                                {
                                                    let v122: string =
                                                        getValue(_v104.get().clone());
                                                    replace(
                                                        sprintf!(
                                                            "{}{}",
                                                            toLower(ofChar(getCharAt(
                                                                v122.clone(),
                                                                0_i32
                                                            ))),
                                                            getSlice(
                                                                v122,
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
                                        let v131: i32 = count(v129.clone());
                                        let v132: LrcPtr<Documents::Mut4> =
                                            LrcPtr::new(Documents::Mut4 {
                                                l0: MutCell::new(0_i32),
                                                l1: MutCell::new(0_i32),
                                                l2: MutCell::new(new_empty::<string>()),
                                            });
                                        while Documents::method29(v131, v132.clone()) {
                                            let v134: i32 = v132.l0.get().clone();
                                            let v137: i32 = v134.wrapping_neg() + v131 - 1_i32;
                                            let matchValue: i32 = v132.l1.get().clone();
                                            let v139: Array<string> = v132.l2.get().clone();
                                            let v138: i32 = matchValue;
                                            let v140: string = v129[v137].clone();
                                            let patternInput_1: (i32, Array<string>) =
                                                if string("..") == v140.clone() {
                                                    (v138 + 1_i32, v139.clone())
                                                } else {
                                                    if 0_i32 == v138 {
                                                        if endsWith(
                                                            v140.clone(),
                                                            string(":"),
                                                            false,
                                                        ) {
                                                            let v147: Array<string> =
                                                                new_array(&[sprintf!(
                                                                    "{}:",
                                                                    getCharAt(v47.clone(), 0_i32)
                                                                )]);
                                                            let v148: i32 = count(v147.clone());
                                                            let v150: i32 =
                                                                v148 + count(v139.clone());
                                                            let v151: Array<string> =
                                                                new_init(&string(""), v150);
                                                            let v152: LrcPtr<Documents::Mut5> =
                                                                LrcPtr::new(Documents::Mut5 {
                                                                    l0: MutCell::new(0_i32),
                                                                });
                                                            while Documents::method30(
                                                                v150,
                                                                v152.clone(),
                                                            ) {
                                                                let v154: i32 =
                                                                    v152.l0.get().clone();
                                                                let v159: string = if v154 < v148 {
                                                                    v147[v154].clone()
                                                                } else {
                                                                    let v157: i32 = v154 - v148;
                                                                    v139[v157].clone()
                                                                };
                                                                v151.get_mut()[v154 as usize] =
                                                                    v159;
                                                                {
                                                                    let v160: i32 = v154 + 1_i32;
                                                                    v152.l0.set(v160);
                                                                    ()
                                                                }
                                                            }
                                                            (0_i32, v151.clone())
                                                        } else {
                                                            let v161: Array<string> =
                                                                new_array(&[v140]);
                                                            let v162: i32 = count(v161.clone());
                                                            let v164: i32 =
                                                                v162 + count(v139.clone());
                                                            let v165: Array<string> =
                                                                new_init(&string(""), v164);
                                                            let v166: LrcPtr<Documents::Mut5> =
                                                                LrcPtr::new(Documents::Mut5 {
                                                                    l0: MutCell::new(0_i32),
                                                                });
                                                            while Documents::method30(
                                                                v164,
                                                                v166.clone(),
                                                            ) {
                                                                let v168: i32 =
                                                                    v166.l0.get().clone();
                                                                let v173: string = if v168 < v162 {
                                                                    v161[v168].clone()
                                                                } else {
                                                                    let v171: i32 = v168 - v162;
                                                                    v139[v171].clone()
                                                                };
                                                                v165.get_mut()[v168 as usize] =
                                                                    v173;
                                                                {
                                                                    let v174: i32 = v168 + 1_i32;
                                                                    v166.l0.set(v174);
                                                                    ()
                                                                }
                                                            }
                                                            (0_i32, v165.clone())
                                                        }
                                                    } else {
                                                        (v138 - 1_i32, v139.clone())
                                                    }
                                                };
                                            let v182: i32 = v134 + 1_i32;
                                            v132.l0.set(v182);
                                            v132.l1.set(patternInput_1.0.clone());
                                            v132.l2.set(patternInput_1.1.clone());
                                            ()
                                        }
                                        {
                                            let matchValue_2: i32 = v132.l1.get().clone();
                                            let v184: Array<string> = v132.l2.get().clone();
                                            let v185: LrcPtr<dyn IEnumerable_1<string>> =
                                                delay(Func0::new({
                                                    let v184 = v184.clone();
                                                    move || {
                                                        map_1(
                                                            Func1::new({
                                                                let v184 = v184.clone();
                                                                move |i: i32| v184[i].clone()
                                                            }),
                                                            rangeNumeric(
                                                                0_i32,
                                                                1_i32,
                                                                count(v184.clone()) - 1_i32,
                                                            ),
                                                        )
                                                    }
                                                }));
                                            let _v186: MutCell<Option<char>> =
                                                MutCell::new(None::<char>);
                                            {
                                                let x_6: char = std::path::MAIN_SEPARATOR;
                                                _v186.set(Some(x_6))
                                            }
                                            join(
                                                Documents::method31(ofChar(getValue(
                                                    _v186.get().clone(),
                                                ))),
                                                toArray_1(v185),
                                            )
                                        }
                                    }
                                }
                            }
                        }
                    }
                } else {
                    let v203: Result<std::path::PathBuf, std::io::Error> =
                        std::fs::canonicalize(&*v8);
                    let v205: std::path::PathBuf = v203.unwrap();
                    let v207: std::path::Display = v205.display();
                    let _v208: MutCell<Option<std::string::String>> =
                        MutCell::new(None::<std::string::String>);
                    {
                        let x_7: std::string::String = format!("{}", v207);
                        _v208.set(Some(x_7))
                    }
                    {
                        let v219: std::string::String = getValue(_v208.get().clone());
                        fable_library_rust::String_::fromString(v219)
                    }
                };
                _v6.set(Some(x_8))
            }
            {
                let v230: string = getValue(_v6.get().clone());
                let v231: string = Documents::method18(v230.clone());
                let v233: &str = fable_library_rust::String_::LrcStr::as_str(&v231);
                let v235: std::string::String = String::from(v233);
                let v237: std::path::PathBuf = std::path::PathBuf::from(v235);
                let v239: std::path::Display = v237.display();
                let _v240: MutCell<Option<std::string::String>> =
                    MutCell::new(None::<std::string::String>);
                {
                    let x_9: std::string::String = format!("{}", v239);
                    _v240.set(Some(x_9))
                }
                {
                    let v251: std::string::String = getValue(_v240.get().clone());
                    let v259: string = sprintf!(
                        ".{}",
                        replace(
                            replace(
                                fable_library_rust::String_::fromString(v251),
                                v3.clone(),
                                string("")
                            ),
                            string("\\"),
                            string("/")
                        )
                    );
                    let _v260: MutCell<Option<bool>> = MutCell::new(None::<bool>);
                    {
                        let x_10: bool = cfg!(windows);
                        _v260.set(Some(x_10))
                    }
                    {
                        let v293: string = if getValue(_v260.get().clone()) == false {
                            v230.clone()
                        } else {
                            let _v273: MutCell<Option<string>> = MutCell::new(None::<string>);
                            let v275: string = Documents::method26();
                            let v276: string = Documents::method27(v230);
                            let v277: string = Documents::method28();
                            let v279: &str =
                                &regex::Regex::new(&v275).unwrap().replace_all(&v276, &*v277);
                            let v281: std::string::String = String::from(v279);
                            {
                                let x_11: string = fable_library_rust::String_::fromString(v281);
                                _v273.set(Some(x_11))
                            }
                            {
                                let v290: string = getValue(_v273.get().clone());
                                replace(
                                    sprintf!(
                                        "{}{}",
                                        toLower(ofChar(getCharAt(v290.clone(), 0_i32))),
                                        getSlice(v290, Some(1_i32), None::<i32>)
                                    ),
                                    string("\\"),
                                    string("/"),
                                )
                            }
                        };
                        let _v294: MutCell<Option<string>> = MutCell::new(None::<string>);
                        let v296: string = Documents::method18(v2.clone());
                        let v298: &str = fable_library_rust::String_::LrcStr::as_str(&v296);
                        let v300: std::string::String = String::from(v298);
                        let v302: std::path::PathBuf = std::path::PathBuf::from(v300);
                        let v303: string = Documents::method18(v259.clone());
                        let v305: &str = fable_library_rust::String_::LrcStr::as_str(&v303);
                        let v307: std::string::String = String::from(v305);
                        let v309: std::path::PathBuf = v302.join(v307);
                        let v311: std::path::Display = v309.display();
                        let _v312: MutCell<Option<std::string::String>> =
                            MutCell::new(None::<std::string::String>);
                        {
                            let x_12: std::string::String = format!("{}", v311);
                            _v312.set(Some(x_12))
                        }
                        {
                            let v323: std::string::String = getValue(_v312.get().clone());
                            {
                                let x_13: string = fable_library_rust::String_::fromString(v323);
                                _v294.set(Some(x_13))
                            }
                            {
                                let v336: string = getValue(_v294.get().clone());
                                let _v337: MutCell<Option<bool>> = MutCell::new(None::<bool>);
                                {
                                    let x_14: bool = cfg!(windows);
                                    _v337.set(Some(x_14))
                                }
                                {
                                    let v370: string = if getValue(_v337.get().clone()) == false {
                                        v336.clone()
                                    } else {
                                        let _v350: MutCell<Option<string>> =
                                            MutCell::new(None::<string>);
                                        let v352: string = Documents::method26();
                                        let v353: string = Documents::method27(v336);
                                        let v354: string = Documents::method28();
                                        let v356: &str = &regex::Regex::new(&v352)
                                            .unwrap()
                                            .replace_all(&v353, &*v354);
                                        let v358: std::string::String = String::from(v356);
                                        {
                                            let x_15: string =
                                                fable_library_rust::String_::fromString(v358);
                                            _v350.set(Some(x_15))
                                        }
                                        {
                                            let v367: string = getValue(_v350.get().clone());
                                            replace(
                                                sprintf!(
                                                    "{}{}",
                                                    toLower(ofChar(getCharAt(v367.clone(), 0_i32))),
                                                    getSlice(v367, Some(1_i32), None::<i32>)
                                                ),
                                                string("\\"),
                                                string("/"),
                                            )
                                        }
                                    };
                                    let v372: Option<CancellationToken> = None::<CancellationToken>;
                                    let v373: Array<(string, string)> =
                                        new_empty::<(string, string)>();
                                    let v374 = None::<Func1<(bool, string, i32), Arc<Async<()>>>>;
                                    let v375: string =
                                        sprintf!("git ls-tree --format=\'%(objectname)\' origin/gh-pages \"{}\"",
                                                 v370.clone());
                                    let v376: Option<string> = Some(v2);
                                    let _v377: MutCell<Option<(i32, string)>> =
                                        MutCell::new(None::<(i32, string)>);
                                    let v379: string = Documents::method42(
                                        v372.clone(),
                                        v375.clone(),
                                        v373.clone(),
                                        v374.clone(),
                                        v376.clone(),
                                    );
                                    let patternInput_3: (string, string) = Documents::method43();
                                    let v382: i32 = length(v379.clone());
                                    let v383: Array<char> = new_init(&'\u{0000}', v382);
                                    let v384: LrcPtr<Documents::Mut5> =
                                        LrcPtr::new(Documents::Mut5 {
                                            l0: MutCell::new(0_i32),
                                        });
                                    while Documents::method30(v382, v384.clone()) {
                                        let v386: i32 = v384.l0.get().clone();
                                        let v387: char = getCharAt(v379.clone(), v386);
                                        v383.get_mut()[v386 as usize] = v387;
                                        {
                                            let v388: i32 = v386 + 1_i32;
                                            v384.l0.set(v388);
                                            ()
                                        }
                                    }
                                    {
                                        let v390: List<char> = ofArray(v383.clone());
                                        let patternInput_4: (string, string) = Documents::method45(
                                            patternInput_3.1.clone(),
                                            patternInput_3.0.clone(),
                                            foldBack(
                                                Func2::new(
                                                    move |b0: char, b1: LrcPtr<Documents::UH0>| {
                                                        (Documents::method44())(b0)(b1)
                                                    },
                                                ),
                                                v390,
                                                LrcPtr::new(Documents::UH0::UH0_0),
                                            ),
                                            Documents::US8::US8_0,
                                        );
                                        let v398: string = patternInput_4.0.clone();
                                        let v400: Array<string> =
                                            Documents::method46(patternInput_4.1.clone());
                                        let v402: Vec<string> = v400.to_vec();
                                        fn v404(v: string) -> std::string::String {
                                            Documents::closure28((), v)
                                        }
                                        let v405: Vec<std::string::String> = v402
                                            .iter()
                                            .map(|x| Func1::from(v404)(x.clone()))
                                            .collect();
                                        Documents::method3(
                                            Documents::US0::US0_1,
                                            Func0::new({
                                                let v372 = v372.clone();
                                                let v373 = v373.clone();
                                                let v374 = v374.clone();
                                                let v375 = v375.clone();
                                                let v376 = v376.clone();
                                                let v398 = v398.clone();
                                                let v405 = v405.clone();
                                                move || {
                                                    Documents::closure29(
                                                        v372.clone(),
                                                        v375.clone(),
                                                        v373.clone(),
                                                        v374.clone(),
                                                        v376.clone(),
                                                        v398.clone(),
                                                        v405.clone(),
                                                        (),
                                                    )
                                                }
                                            }),
                                            Documents::method51(),
                                        );
                                        {
                                            let v409: std::pin::Pin<
                                                Box<
                                                    dyn std::future::Future<
                                                        Output = LrcPtr<(i32, string)>,
                                                    >,
                                                >,
                                            > = Documents::method52(
                                                v372.clone(),
                                                v375.clone(),
                                                v373.clone(),
                                                v374.clone(),
                                                v376.clone(),
                                                v398.clone(),
                                                v405.clone(),
                                            );
                                            let v411: LrcPtr<(i32, string)> =
                                                futures_lite::future::block_on(v409);
                                            _v377.set(Some((v411.0.clone(), v411.1.clone())));
                                            {
                                                let patternInput_5: (i32, string) =
                                                    getValue(_v377.get().clone());
                                                let v592: string = patternInput_5.1.clone();
                                                let _v593: MutCell<Option<string>> =
                                                    MutCell::new(None::<string>);
                                                let v595: string = Documents::method18(v3.clone());
                                                let v597: &str =
                                                    fable_library_rust::String_::LrcStr::as_str(
                                                        &v595,
                                                    );
                                                let v599: std::string::String = String::from(v597);
                                                let v601: std::path::PathBuf =
                                                    std::path::PathBuf::from(v599);
                                                let v602: string =
                                                    Documents::method18(v259.clone());
                                                let v604: &str =
                                                    fable_library_rust::String_::LrcStr::as_str(
                                                        &v602,
                                                    );
                                                let v606: std::string::String = String::from(v604);
                                                let v608: std::path::PathBuf = v601.join(v606);
                                                let v610: std::path::Display = v608.display();
                                                let _v611: MutCell<Option<std::string::String>> =
                                                    MutCell::new(None::<std::string::String>);
                                                {
                                                    let x_17: std::string::String =
                                                        format!("{}", v610);
                                                    _v611.set(Some(x_17))
                                                }
                                                {
                                                    let v622: std::string::String =
                                                        getValue(_v611.get().clone());
                                                    {
                                                        let x_18: string =
                                                            fable_library_rust::String_::fromString(
                                                                v622,
                                                            );
                                                        _v593.set(Some(x_18))
                                                    }
                                                    {
                                                        let v634: string =
                                                            getValue(_v593.get().clone());
                                                        let _v635: MutCell<Option<bool>> =
                                                            MutCell::new(None::<bool>);
                                                        {
                                                            let x_19: bool = cfg!(windows);
                                                            _v635.set(Some(x_19))
                                                        }
                                                        {
                                                            let v668: string = if getValue(
                                                                _v635.get().clone(),
                                                            ) == false
                                                            {
                                                                v634.clone()
                                                            } else {
                                                                let _v648: MutCell<Option<string>> =
                                                                    MutCell::new(None::<string>);
                                                                let v650: string =
                                                                    Documents::method26();
                                                                let v651: string =
                                                                    Documents::method27(v634);
                                                                let v652: string =
                                                                    Documents::method28();
                                                                let v654: &str =
                                                                    &regex::Regex::new(&v650)
                                                                        .unwrap()
                                                                        .replace_all(&v651, &*v652);
                                                                let v656: std::string::String =
                                                                    String::from(v654);
                                                                {
                                                                    let x_20:
                                                                                string =
                                                                            fable_library_rust::String_::fromString(v656);
                                                                    _v648.set(Some(x_20))
                                                                }
                                                                {
                                                                    let v665: string = getValue(
                                                                        _v648.get().clone(),
                                                                    );
                                                                    replace(
                                                                        sprintf!(
                                                                            "{}{}",
                                                                            toLower(ofChar(
                                                                                getCharAt(
                                                                                    v665.clone(),
                                                                                    0_i32
                                                                                )
                                                                            )),
                                                                            getSlice(
                                                                                v665,
                                                                                Some(1_i32),
                                                                                None::<i32>
                                                                            )
                                                                        ),
                                                                        string("\\"),
                                                                        string("/"),
                                                                    )
                                                                }
                                                            };
                                                            let v670: Option<CancellationToken> =
                                                                None::<CancellationToken>;
                                                            let v671: Array<(string, string)> =
                                                                new_empty::<(string, string)>();
                                                            let v672 = None::<
                                                                Func1<
                                                                    (bool, string, i32),
                                                                    Arc<Async<()>>,
                                                                >,
                                                            >;
                                                            let v673: string = sprintf!(
                                                                "git hash-object \"{}\"",
                                                                v668.clone()
                                                            );
                                                            let v674: Option<string> =
                                                                Some(v3.clone());
                                                            let _v675: MutCell<
                                                                Option<(i32, string)>,
                                                            > = MutCell::new(None::<(i32, string)>);
                                                            let v677: string = Documents::method42(
                                                                v670.clone(),
                                                                v673.clone(),
                                                                v671.clone(),
                                                                v672.clone(),
                                                                v674.clone(),
                                                            );
                                                            let patternInput_6: (string, string) =
                                                                Documents::method43();
                                                            let v680: i32 = length(v677.clone());
                                                            let v681: Array<char> =
                                                                new_init(&'\u{0000}', v680);
                                                            let v682: LrcPtr<Documents::Mut5> =
                                                                LrcPtr::new(Documents::Mut5 {
                                                                    l0: MutCell::new(0_i32),
                                                                });
                                                            while Documents::method30(
                                                                v680,
                                                                v682.clone(),
                                                            ) {
                                                                let v684: i32 =
                                                                    v682.l0.get().clone();
                                                                let v685: char =
                                                                    getCharAt(v677.clone(), v684);
                                                                v681.get_mut()[v684 as usize] =
                                                                    v685;
                                                                {
                                                                    let v686: i32 = v684 + 1_i32;
                                                                    v682.l0.set(v686);
                                                                    ()
                                                                }
                                                            }
                                                            {
                                                                let v688: List<char> =
                                                                    ofArray(v681.clone());
                                                                let patternInput_7:
                                                                        (string,
                                                                         string) =
                                                                    Documents::method45(patternInput_6.1.clone(),
                                                                                        patternInput_6.0.clone(),
                                                                                        foldBack(Func2::new(move
                                                                                                                |b0:
                                                                                                                     char,
                                                                                                                 b1:
                                                                                                                     LrcPtr<Documents::UH0>|
                                                                                                                (Documents::method44())(b0)(b1)),
                                                                                                 v688,
                                                                                                 LrcPtr::new(Documents::UH0::UH0_0)),
                                                                                        Documents::US8::US8_0);
                                                                let v696: string =
                                                                    patternInput_7.0.clone();
                                                                let v698: Array<string> =
                                                                    Documents::method46(
                                                                        patternInput_7.1.clone(),
                                                                    );
                                                                let v700: Vec<string> =
                                                                    v698.to_vec();
                                                                let v702: Vec<std::string::String> =
                                                                    v700.iter()
                                                                        .map(|x| {
                                                                            Func1::from(v404)(
                                                                                x.clone(),
                                                                            )
                                                                        })
                                                                        .collect();
                                                                Documents::method3(
                                                                    Documents::US0::US0_1,
                                                                    Func0::new({
                                                                        let v670 = v670.clone();
                                                                        let v671 = v671.clone();
                                                                        let v672 = v672.clone();
                                                                        let v673 = v673.clone();
                                                                        let v674 = v674.clone();
                                                                        let v696 = v696.clone();
                                                                        let v702 = v702.clone();
                                                                        move || {
                                                                            Documents::closure29(
                                                                                v670.clone(),
                                                                                v673.clone(),
                                                                                v671.clone(),
                                                                                v672.clone(),
                                                                                v674.clone(),
                                                                                v696.clone(),
                                                                                v702.clone(),
                                                                                (),
                                                                            )
                                                                        }
                                                                    }),
                                                                    Documents::method51(),
                                                                );
                                                                {
                                                                    let v706: std::pin::Pin<
                                                                        Box<
                                                                            dyn std::future::Future<
                                                                                Output = LrcPtr<(
                                                                                    i32,
                                                                                    string,
                                                                                )>,
                                                                            >,
                                                                        >,
                                                                    > = Documents::method52(
                                                                        v670.clone(),
                                                                        v673.clone(),
                                                                        v671.clone(),
                                                                        v672.clone(),
                                                                        v674.clone(),
                                                                        v696.clone(),
                                                                        v702.clone(),
                                                                    );
                                                                    let v708:
                                                                            LrcPtr<(i32,
                                                                                    string)> =
                                                                        futures_lite::future::block_on(v706);
                                                                    _v675.set(Some((
                                                                        v708.0.clone(),
                                                                        v708.1.clone(),
                                                                    )));
                                                                    {
                                                                        let patternInput_8: (
                                                                            i32,
                                                                            string,
                                                                        ) = getValue(
                                                                            _v675.get().clone(),
                                                                        );
                                                                        let v889: string =
                                                                            patternInput_8
                                                                                .1
                                                                                .clone();
                                                                        Ok::<LrcPtr<(string,
                                                                                     Vec<Option<Result<string,
                                                                                                       LrcPtr<(string,
                                                                                                               string)>>>>)>,
                                                                             std::string::String>(LrcPtr::new((v293.clone(),
                                                                                                               if contains(v592.clone(),
                                                                                                                           v889.clone())
                                                                                                                      ==
                                                                                                                      false
                                                                                                                  {
                                                                                                                   let _v892:
                                                                                                                           MutCell<Option<bool>> =
                                                                                                                       MutCell::new(None::<bool>);
                                                                                                                   {
                                                                                                                       let x_22:
                                                                                                                               bool =
                                                                                                                           cfg!(windows);
                                                                                                                       _v892.set(Some(x_22))
                                                                                                                   }
                                                                                                                   {
                                                                                                                       let v926:
                                                                                                                               Option<string> =
                                                                                                                           None::<string>;
                                                                                                                       let v927:
                                                                                                                               Option<CancellationToken> =
                                                                                                                           None::<CancellationToken>;
                                                                                                                       let v928:
                                                                                                                               Array<(string,
                                                                                                                                      string)> =
                                                                                                                           new_empty::<(string,
                                                                                                                                        string)>();
                                                                                                                       let v929 =
                                                                                                                           None::<Func1<(bool,
                                                                                                                                         string,
                                                                                                                                         i32),
                                                                                                                                        Arc<Async<()>>>>;
                                                                                                                       let v930:
                                                                                                                               string =
                                                                                                                           sprintf!("pwsh -c \"(Get-FileHash \\\"{}\\\" -Algorithm SHA256).Hash\"",
                                                                                                                                    if getValue(_v892.get().clone())
                                                                                                                                           ==
                                                                                                                                           false
                                                                                                                                       {
                                                                                                                                        v668.clone()
                                                                                                                                    } else {
                                                                                                                                        let _v905:
                                                                                                                                                MutCell<Option<string>> =
                                                                                                                                            MutCell::new(None::<string>);
                                                                                                                                        let v907:
                                                                                                                                                string =
                                                                                                                                            Documents::method26();
                                                                                                                                        let v908:
                                                                                                                                                string =
                                                                                                                                            Documents::method27(v668.clone());
                                                                                                                                        let v909:
                                                                                                                                                string =
                                                                                                                                            Documents::method28();
                                                                                                                                        let v911:
                                                                                                                                                &str =
                                                                                                                                            &regex::Regex::new(&v907).unwrap().replace_all(&v908, &*v909);
                                                                                                                                        let v913:
                                                                                                                                                std::string::String =
                                                                                                                                            String::from(v911);
                                                                                                                                        {
                                                                                                                                            let x_23:
                                                                                                                                                    string =
                                                                                                                                                fable_library_rust::String_::fromString(v913);
                                                                                                                                            _v905.set(Some(x_23))
                                                                                                                                        }
                                                                                                                                        {
                                                                                                                                            let v922:
                                                                                                                                                    string =
                                                                                                                                                getValue(_v905.get().clone());
                                                                                                                                            replace(sprintf!("{}{}",
                                                                                                                                                             toLower(ofChar(getCharAt(v922.clone(),
                                                                                                                                                                                      0_i32))),
                                                                                                                                                             getSlice(v922,
                                                                                                                                                                      Some(1_i32),
                                                                                                                                                                      None::<i32>)),
                                                                                                                                                    string("\\"),
                                                                                                                                                    string("/"))
                                                                                                                                        }
                                                                                                                                    });
                                                                                                                       let _v931:
                                                                                                                               MutCell<Option<(i32,
                                                                                                                                               string)>> =
                                                                                                                           MutCell::new(None::<(i32,
                                                                                                                                                string)>);
                                                                                                                       let v933:
                                                                                                                               string =
                                                                                                                           Documents::method42(v927.clone(),
                                                                                                                                               v930.clone(),
                                                                                                                                               v928.clone(),
                                                                                                                                               v929.clone(),
                                                                                                                                               v926.clone());
                                                                                                                       let patternInput_9:
                                                                                                                               (string,
                                                                                                                                string) =
                                                                                                                           Documents::method43();
                                                                                                                       let v936:
                                                                                                                               i32 =
                                                                                                                           length(v933.clone());
                                                                                                                       let v937:
                                                                                                                               Array<char> =
                                                                                                                           new_init(&'\u{0000}',
                                                                                                                                    v936);
                                                                                                                       let v938:
                                                                                                                               LrcPtr<Documents::Mut5> =
                                                                                                                           LrcPtr::new(Documents::Mut5{l0:
                                                                                                                                                           MutCell::new(0_i32),});
                                                                                                                       while Documents::method30(v936,
                                                                                                                                                 v938.clone())
                                                                                                                             {
                                                                                                                           let v940:
                                                                                                                                   i32 =
                                                                                                                               v938.l0.get().clone();
                                                                                                                           let v941:
                                                                                                                                   char =
                                                                                                                               getCharAt(v933.clone(),
                                                                                                                                         v940);
                                                                                                                           v937.get_mut()[v940
                                                                                                                                              as
                                                                                                                                              usize]
                                                                                                                               =
                                                                                                                               v941;
                                                                                                                           {
                                                                                                                               let v942:
                                                                                                                                       i32 =
                                                                                                                                   v940
                                                                                                                                       +
                                                                                                                                       1_i32;
                                                                                                                               v938.l0.set(v942);
                                                                                                                               ()
                                                                                                                           }
                                                                                                                       }
                                                                                                                       {
                                                                                                                           let v944:
                                                                                                                                   List<char> =
                                                                                                                               ofArray(v937.clone());
                                                                                                                           let patternInput_10:
                                                                                                                                   (string,
                                                                                                                                    string) =
                                                                                                                               Documents::method45(patternInput_9.1.clone(),
                                                                                                                                                   patternInput_9.0.clone(),
                                                                                                                                                   foldBack(Func2::new(move
                                                                                                                                                                           |b0:
                                                                                                                                                                                char,
                                                                                                                                                                            b1:
                                                                                                                                                                                LrcPtr<Documents::UH0>|
                                                                                                                                                                           (Documents::method44())(b0)(b1)),
                                                                                                                                                            v944,
                                                                                                                                                            LrcPtr::new(Documents::UH0::UH0_0)),
                                                                                                                                                   Documents::US8::US8_0);
                                                                                                                           let v952:
                                                                                                                                   string =
                                                                                                                               patternInput_10.0.clone();
                                                                                                                           let v954:
                                                                                                                                   Array<string> =
                                                                                                                               Documents::method46(patternInput_10.1.clone());
                                                                                                                           let v956:
                                                                                                                                   Vec<string> =
                                                                                                                               v954.to_vec();
                                                                                                                           let v958:
                                                                                                                                   Vec<std::string::String> =
                                                                                                                               v956.iter().map(|x| Func1::from(v404)(x.clone())).collect();
                                                                                                                           Documents::method3(Documents::US0::US0_1,
                                                                                                                                              Func0::new({
                                                                                                                                                             let v926
                                                                                                                                                                 =
                                                                                                                                                                 v926.clone();
                                                                                                                                                             let v927
                                                                                                                                                                 =
                                                                                                                                                                 v927.clone();
                                                                                                                                                             let v928
                                                                                                                                                                 =
                                                                                                                                                                 v928.clone();
                                                                                                                                                             let v929
                                                                                                                                                                 =
                                                                                                                                                                 v929.clone();
                                                                                                                                                             let v930
                                                                                                                                                                 =
                                                                                                                                                                 v930.clone();
                                                                                                                                                             let v952
                                                                                                                                                                 =
                                                                                                                                                                 v952.clone();
                                                                                                                                                             let v958
                                                                                                                                                                 =
                                                                                                                                                                 v958.clone();
                                                                                                                                                             move
                                                                                                                                                                 ||
                                                                                                                                                                 Documents::closure29(v927.clone(),
                                                                                                                                                                                      v930.clone(),
                                                                                                                                                                                      v928.clone(),
                                                                                                                                                                                      v929.clone(),
                                                                                                                                                                                      v926.clone(),
                                                                                                                                                                                      v952.clone(),
                                                                                                                                                                                      v958.clone(),
                                                                                                                                                                                      ())
                                                                                                                                                         }),
                                                                                                                                              Documents::method51());
                                                                                                                           {
                                                                                                                               let v962:
                                                                                                                                       std::pin::Pin<Box<dyn std::future::Future<Output = LrcPtr<(i32,
                                                                                                                                                                                                  string)>>>> =
                                                                                                                                   Documents::method52(v927.clone(),
                                                                                                                                                       v930.clone(),
                                                                                                                                                       v928.clone(),
                                                                                                                                                       v929.clone(),
                                                                                                                                                       v926.clone(),
                                                                                                                                                       v952.clone(),
                                                                                                                                                       v958.clone());
                                                                                                                               let v964:
                                                                                                                                       LrcPtr<(i32,
                                                                                                                                               string)> =
                                                                                                                                   futures_lite::future::block_on(v962);
                                                                                                                               _v931.set(Some((v964.0.clone(),
                                                                                                                                               v964.1.clone())));
                                                                                                                               {
                                                                                                                                   let v1145:
                                                                                                                                           string =
                                                                                                                                       (getValue(_v931.get().clone())).1.clone();
                                                                                                                                   let _v1146:
                                                                                                                                           MutCell<Option<string>> =
                                                                                                                                       MutCell::new(None::<string>);
                                                                                                                                   let v1148:
                                                                                                                                           string =
                                                                                                                                       Documents::method18(v4);
                                                                                                                                   let v1150:
                                                                                                                                           &str =
                                                                                                                                       fable_library_rust::String_::LrcStr::as_str(&v1148);
                                                                                                                                   let v1152:
                                                                                                                                           std::string::String =
                                                                                                                                       String::from(v1150);
                                                                                                                                   let v1154:
                                                                                                                                           std::path::PathBuf =
                                                                                                                                       std::path::PathBuf::from(v1152);
                                                                                                                                   let v1155:
                                                                                                                                           string =
                                                                                                                                       Documents::method18(v259.clone());
                                                                                                                                   let v1157:
                                                                                                                                           &str =
                                                                                                                                       fable_library_rust::String_::LrcStr::as_str(&v1155);
                                                                                                                                   let v1159:
                                                                                                                                           std::string::String =
                                                                                                                                       String::from(v1157);
                                                                                                                                   let v1161:
                                                                                                                                           std::path::PathBuf =
                                                                                                                                       v1154.join(v1159);
                                                                                                                                   let v1163:
                                                                                                                                           std::path::Display =
                                                                                                                                       v1161.display();
                                                                                                                                   let _v1164:
                                                                                                                                           MutCell<Option<std::string::String>> =
                                                                                                                                       MutCell::new(None::<std::string::String>);
                                                                                                                                   {
                                                                                                                                       let x_25:
                                                                                                                                               std::string::String =
                                                                                                                                           format!("{}", v1163);
                                                                                                                                       _v1164.set(Some(x_25))
                                                                                                                                   }
                                                                                                                                   {
                                                                                                                                       let v1175:
                                                                                                                                               std::string::String =
                                                                                                                                           getValue(_v1164.get().clone());
                                                                                                                                       {
                                                                                                                                           let x_26:
                                                                                                                                                   string =
                                                                                                                                               fable_library_rust::String_::fromString(v1175);
                                                                                                                                           _v1146.set(Some(x_26))
                                                                                                                                       }
                                                                                                                                       {
                                                                                                                                           let v1187:
                                                                                                                                                   string =
                                                                                                                                               getValue(_v1146.get().clone());
                                                                                                                                           let _v1188:
                                                                                                                                                   MutCell<Option<bool>> =
                                                                                                                                               MutCell::new(None::<bool>);
                                                                                                                                           {
                                                                                                                                               let x_27:
                                                                                                                                                       bool =
                                                                                                                                                   cfg!(windows);
                                                                                                                                               _v1188.set(Some(x_27))
                                                                                                                                           }
                                                                                                                                           {
                                                                                                                                               let v1221:
                                                                                                                                                       string =
                                                                                                                                                   if getValue(_v1188.get().clone())
                                                                                                                                                          ==
                                                                                                                                                          false
                                                                                                                                                      {
                                                                                                                                                       v1187.clone()
                                                                                                                                                   } else {
                                                                                                                                                       let _v1201:
                                                                                                                                                               MutCell<Option<string>> =
                                                                                                                                                           MutCell::new(None::<string>);
                                                                                                                                                       let v1203:
                                                                                                                                                               string =
                                                                                                                                                           Documents::method26();
                                                                                                                                                       let v1204:
                                                                                                                                                               string =
                                                                                                                                                           Documents::method27(v1187);
                                                                                                                                                       let v1205:
                                                                                                                                                               string =
                                                                                                                                                           Documents::method28();
                                                                                                                                                       let v1207:
                                                                                                                                                               &str =
                                                                                                                                                           &regex::Regex::new(&v1203).unwrap().replace_all(&v1204, &*v1205);
                                                                                                                                                       let v1209:
                                                                                                                                                               std::string::String =
                                                                                                                                                           String::from(v1207);
                                                                                                                                                       {
                                                                                                                                                           let x_28:
                                                                                                                                                                   string =
                                                                                                                                                               fable_library_rust::String_::fromString(v1209);
                                                                                                                                                           _v1201.set(Some(x_28))
                                                                                                                                                       }
                                                                                                                                                       {
                                                                                                                                                           let v1218:
                                                                                                                                                                   string =
                                                                                                                                                               getValue(_v1201.get().clone());
                                                                                                                                                           replace(sprintf!("{}{}",
                                                                                                                                                                            toLower(ofChar(getCharAt(v1218.clone(),
                                                                                                                                                                                                     0_i32))),
                                                                                                                                                                            getSlice(v1218,
                                                                                                                                                                                     Some(1_i32),
                                                                                                                                                                                     None::<i32>)),
                                                                                                                                                                   string("\\"),
                                                                                                                                                                   string("/"))
                                                                                                                                                       }
                                                                                                                                                   };
                                                                                                                                               let _v1222:
                                                                                                                                                       MutCell<Option<bool>> =
                                                                                                                                                   MutCell::new(None::<bool>);
                                                                                                                                               let v1224:
                                                                                                                                                       string =
                                                                                                                                                   Documents::method18(v1221.clone());
                                                                                                                                               let v1226:
                                                                                                                                                       &str =
                                                                                                                                                   fable_library_rust::String_::LrcStr::as_str(&v1224);
                                                                                                                                               let v1228:
                                                                                                                                                       std::string::String =
                                                                                                                                                   String::from(v1226);
                                                                                                                                               let v1230:
                                                                                                                                                       std::path::PathBuf =
                                                                                                                                                   std::path::PathBuf::from(v1228);
                                                                                                                                               {
                                                                                                                                                   let x_29:
                                                                                                                                                           bool =
                                                                                                                                                       if v1230.clone().exists()
                                                                                                                                                          {
                                                                                                                                                           v1230.is_file()
                                                                                                                                                       } else {
                                                                                                                                                           false
                                                                                                                                                       };
                                                                                                                                                   _v1222.set(Some(x_29))
                                                                                                                                               }
                                                                                                                                               {
                                                                                                                                                   let v1500:
                                                                                                                                                           string =
                                                                                                                                                       if getValue(_v1222.get().clone())
                                                                                                                                                          {
                                                                                                                                                           let _v1246:
                                                                                                                                                                   MutCell<Option<bool>> =
                                                                                                                                                               MutCell::new(None::<bool>);
                                                                                                                                                           {
                                                                                                                                                               let x_30:
                                                                                                                                                                       bool =
                                                                                                                                                                   cfg!(windows);
                                                                                                                                                               _v1246.set(Some(x_30))
                                                                                                                                                           }
                                                                                                                                                           {
                                                                                                                                                               let v1280:
                                                                                                                                                                       Option<string> =
                                                                                                                                                                   None::<string>;
                                                                                                                                                               let v1281:
                                                                                                                                                                       Option<CancellationToken> =
                                                                                                                                                                   None::<CancellationToken>;
                                                                                                                                                               let v1282:
                                                                                                                                                                       Array<(string,
                                                                                                                                                                              string)> =
                                                                                                                                                                   new_empty::<(string,
                                                                                                                                                                                string)>();
                                                                                                                                                               let v1283 =
                                                                                                                                                                   None::<Func1<(bool,
                                                                                                                                                                                 string,
                                                                                                                                                                                 i32),
                                                                                                                                                                                Arc<Async<()>>>>;
                                                                                                                                                               let v1284:
                                                                                                                                                                       string =
                                                                                                                                                                   sprintf!("pwsh -c \"(Get-FileHash \\\"{}\\\" -Algorithm SHA256).Hash\"",
                                                                                                                                                                            if getValue(_v1246.get().clone())
                                                                                                                                                                                   ==
                                                                                                                                                                                   false
                                                                                                                                                                               {
                                                                                                                                                                                v1221.clone()
                                                                                                                                                                            } else {
                                                                                                                                                                                let _v1259:
                                                                                                                                                                                        MutCell<Option<string>> =
                                                                                                                                                                                    MutCell::new(None::<string>);
                                                                                                                                                                                let v1261:
                                                                                                                                                                                        string =
                                                                                                                                                                                    Documents::method26();
                                                                                                                                                                                let v1262:
                                                                                                                                                                                        string =
                                                                                                                                                                                    Documents::method27(v1221.clone());
                                                                                                                                                                                let v1263:
                                                                                                                                                                                        string =
                                                                                                                                                                                    Documents::method28();
                                                                                                                                                                                let v1265:
                                                                                                                                                                                        &str =
                                                                                                                                                                                    &regex::Regex::new(&v1261).unwrap().replace_all(&v1262, &*v1263);
                                                                                                                                                                                let v1267:
                                                                                                                                                                                        std::string::String =
                                                                                                                                                                                    String::from(v1265);
                                                                                                                                                                                {
                                                                                                                                                                                    let x_31:
                                                                                                                                                                                            string =
                                                                                                                                                                                        fable_library_rust::String_::fromString(v1267);
                                                                                                                                                                                    _v1259.set(Some(x_31))
                                                                                                                                                                                }
                                                                                                                                                                                {
                                                                                                                                                                                    let v1276:
                                                                                                                                                                                            string =
                                                                                                                                                                                        getValue(_v1259.get().clone());
                                                                                                                                                                                    replace(sprintf!("{}{}",
                                                                                                                                                                                                     toLower(ofChar(getCharAt(v1276.clone(),
                                                                                                                                                                                                                              0_i32))),
                                                                                                                                                                                                     getSlice(v1276,
                                                                                                                                                                                                              Some(1_i32),
                                                                                                                                                                                                              None::<i32>)),
                                                                                                                                                                                            string("\\"),
                                                                                                                                                                                            string("/"))
                                                                                                                                                                                }
                                                                                                                                                                            });
                                                                                                                                                               let _v1285:
                                                                                                                                                                       MutCell<Option<(i32,
                                                                                                                                                                                       string)>> =
                                                                                                                                                                   MutCell::new(None::<(i32,
                                                                                                                                                                                        string)>);
                                                                                                                                                               let v1287:
                                                                                                                                                                       string =
                                                                                                                                                                   Documents::method42(v1281.clone(),
                                                                                                                                                                                       v1284.clone(),
                                                                                                                                                                                       v1282.clone(),
                                                                                                                                                                                       v1283.clone(),
                                                                                                                                                                                       v1280.clone());
                                                                                                                                                               let patternInput_12:
                                                                                                                                                                       (string,
                                                                                                                                                                        string) =
                                                                                                                                                                   Documents::method43();
                                                                                                                                                               let v1290:
                                                                                                                                                                       i32 =
                                                                                                                                                                   length(v1287.clone());
                                                                                                                                                               let v1291:
                                                                                                                                                                       Array<char> =
                                                                                                                                                                   new_init(&'\u{0000}',
                                                                                                                                                                            v1290);
                                                                                                                                                               let v1292:
                                                                                                                                                                       LrcPtr<Documents::Mut5> =
                                                                                                                                                                   LrcPtr::new(Documents::Mut5{l0:
                                                                                                                                                                                                   MutCell::new(0_i32),});
                                                                                                                                                               while Documents::method30(v1290,
                                                                                                                                                                                         v1292.clone())
                                                                                                                                                                     {
                                                                                                                                                                   let v1294:
                                                                                                                                                                           i32 =
                                                                                                                                                                       v1292.l0.get().clone();
                                                                                                                                                                   let v1295:
                                                                                                                                                                           char =
                                                                                                                                                                       getCharAt(v1287.clone(),
                                                                                                                                                                                 v1294);
                                                                                                                                                                   v1291.get_mut()[v1294
                                                                                                                                                                                       as
                                                                                                                                                                                       usize]
                                                                                                                                                                       =
                                                                                                                                                                       v1295;
                                                                                                                                                                   {
                                                                                                                                                                       let v1296:
                                                                                                                                                                               i32 =
                                                                                                                                                                           v1294
                                                                                                                                                                               +
                                                                                                                                                                               1_i32;
                                                                                                                                                                       v1292.l0.set(v1296);
                                                                                                                                                                       ()
                                                                                                                                                                   }
                                                                                                                                                               }
                                                                                                                                                               {
                                                                                                                                                                   let v1298:
                                                                                                                                                                           List<char> =
                                                                                                                                                                       ofArray(v1291.clone());
                                                                                                                                                                   let patternInput_13:
                                                                                                                                                                           (string,
                                                                                                                                                                            string) =
                                                                                                                                                                       Documents::method45(patternInput_12.1.clone(),
                                                                                                                                                                                           patternInput_12.0.clone(),
                                                                                                                                                                                           foldBack(Func2::new(move
                                                                                                                                                                                                                   |b0:
                                                                                                                                                                                                                        char,
                                                                                                                                                                                                                    b1:
                                                                                                                                                                                                                        LrcPtr<Documents::UH0>|
                                                                                                                                                                                                                   (Documents::method44())(b0)(b1)),
                                                                                                                                                                                                    v1298,
                                                                                                                                                                                                    LrcPtr::new(Documents::UH0::UH0_0)),
                                                                                                                                                                                           Documents::US8::US8_0);
                                                                                                                                                                   let v1306:
                                                                                                                                                                           string =
                                                                                                                                                                       patternInput_13.0.clone();
                                                                                                                                                                   let v1308:
                                                                                                                                                                           Array<string> =
                                                                                                                                                                       Documents::method46(patternInput_13.1.clone());
                                                                                                                                                                   let v1310:
                                                                                                                                                                           Vec<string> =
                                                                                                                                                                       v1308.to_vec();
                                                                                                                                                                   let v1312:
                                                                                                                                                                           Vec<std::string::String> =
                                                                                                                                                                       v1310.iter().map(|x| Func1::from(v404)(x.clone())).collect();
                                                                                                                                                                   Documents::method3(Documents::US0::US0_1,
                                                                                                                                                                                      Func0::new({
                                                                                                                                                                                                     let v1280
                                                                                                                                                                                                         =
                                                                                                                                                                                                         v1280.clone();
                                                                                                                                                                                                     let v1281
                                                                                                                                                                                                         =
                                                                                                                                                                                                         v1281.clone();
                                                                                                                                                                                                     let v1282
                                                                                                                                                                                                         =
                                                                                                                                                                                                         v1282.clone();
                                                                                                                                                                                                     let v1283
                                                                                                                                                                                                         =
                                                                                                                                                                                                         v1283.clone();
                                                                                                                                                                                                     let v1284
                                                                                                                                                                                                         =
                                                                                                                                                                                                         v1284.clone();
                                                                                                                                                                                                     let v1306
                                                                                                                                                                                                         =
                                                                                                                                                                                                         v1306.clone();
                                                                                                                                                                                                     let v1312
                                                                                                                                                                                                         =
                                                                                                                                                                                                         v1312.clone();
                                                                                                                                                                                                     move
                                                                                                                                                                                                         ||
                                                                                                                                                                                                         Documents::closure29(v1281.clone(),
                                                                                                                                                                                                                              v1284.clone(),
                                                                                                                                                                                                                              v1282.clone(),
                                                                                                                                                                                                                              v1283.clone(),
                                                                                                                                                                                                                              v1280.clone(),
                                                                                                                                                                                                                              v1306.clone(),
                                                                                                                                                                                                                              v1312.clone(),
                                                                                                                                                                                                                              ())
                                                                                                                                                                                                 }),
                                                                                                                                                                                      Documents::method51());
                                                                                                                                                                   {
                                                                                                                                                                       let v1316:
                                                                                                                                                                               std::pin::Pin<Box<dyn std::future::Future<Output = LrcPtr<(i32,
                                                                                                                                                                                                                                          string)>>>> =
                                                                                                                                                                           Documents::method52(v1281.clone(),
                                                                                                                                                                                               v1284.clone(),
                                                                                                                                                                                               v1282.clone(),
                                                                                                                                                                                               v1283.clone(),
                                                                                                                                                                                               v1280.clone(),
                                                                                                                                                                                               v1306.clone(),
                                                                                                                                                                                               v1312.clone());
                                                                                                                                                                       let v1318:
                                                                                                                                                                               LrcPtr<(i32,
                                                                                                                                                                                       string)> =
                                                                                                                                                                           futures_lite::future::block_on(v1316);
                                                                                                                                                                       _v1285.set(Some((v1318.0.clone(),
                                                                                                                                                                                        v1318.1.clone())));
                                                                                                                                                                       (getValue(_v1285.get().clone())).1.clone()
                                                                                                                                                                   }
                                                                                                                                                               }
                                                                                                                                                           }
                                                                                                                                                       } else {
                                                                                                                                                           string("")
                                                                                                                                                       };
                                                                                                                                                   if v1145.clone()
                                                                                                                                                          !=
                                                                                                                                                          v1500.clone()
                                                                                                                                                      {
                                                                                                                                                       let v1507 =
                                                                                                                                                           Func1::new({
                                                                                                                                                                          let v1221
                                                                                                                                                                              =
                                                                                                                                                                              v1221.clone();
                                                                                                                                                                          let v3
                                                                                                                                                                              =
                                                                                                                                                                              v3.clone();
                                                                                                                                                                          let v668
                                                                                                                                                                              =
                                                                                                                                                                              v668.clone();
                                                                                                                                                                          move
                                                                                                                                                                              |v_2:
                                                                                                                                                                                   string|
                                                                                                                                                                              Documents::closure57(v668.clone(),
                                                                                                                                                                                                   v1221.clone(),
                                                                                                                                                                                                   v3.clone(),
                                                                                                                                                                                                   v_2)
                                                                                                                                                                      });
                                                                                                                                                       let v1514 =
                                                                                                                                                           toArray(ofArray(new_array(&[(string("html"),
                                                                                                                                                                                        v1507.clone()),
                                                                                                                                                                                       (string("pdf"),
                                                                                                                                                                                        v1507.clone()),
                                                                                                                                                                                       (string("epub"),
                                                                                                                                                                                        v1507),
                                                                                                                                                                                       (string("hangul.md"),
                                                                                                                                                                                        Func1::new({
                                                                                                                                                                                                       let v0_1
                                                                                                                                                                                                           =
                                                                                                                                                                                                           v0_1.clone();
                                                                                                                                                                                                       let v1221
                                                                                                                                                                                                           =
                                                                                                                                                                                                           v1221.clone();
                                                                                                                                                                                                       let v1_1
                                                                                                                                                                                                           =
                                                                                                                                                                                                           v1_1.clone();
                                                                                                                                                                                                       let v668
                                                                                                                                                                                                           =
                                                                                                                                                                                                           v668.clone();
                                                                                                                                                                                                       move
                                                                                                                                                                                                           |v_1:
                                                                                                                                                                                                                string|
                                                                                                                                                                                                           Documents::closure54(v668.clone(),
                                                                                                                                                                                                                                v1221.clone(),
                                                                                                                                                                                                                                v0_1.clone(),
                                                                                                                                                                                                                                v1_1.clone(),
                                                                                                                                                                                                                                v_1)
                                                                                                                                                                                                   }))])));
                                                                                                                                                       let v1516 =
                                                                                                                                                           v1514.to_vec();
                                                                                                                                                       let v1518 =
                                                                                                                                                           rayon::iter::IntoParallelIterator::into_par_iter(v1516);
                                                                                                                                                       let v1521 =
                                                                                                                                                           rayon::iter::ParallelIterator::map(v1518, |x| Func1::new(move
                                                                                                                                                                                                                        |arg10_0040_4:
                                                                                                                                                                                                                             (string,
                                                                                                                                                                                                                              Func1<string,
                                                                                                                                                                                                                                    Documents::US17>)|
                                                                                                                                                                                                                        Documents::closure60((),
                                                                                                                                                                                                                                             arg10_0040_4))(x));
                                                                                                                                                       let v1523:
                                                                                                                                                               Vec<Option<Result<string,
                                                                                                                                                                                 LrcPtr<(string,
                                                                                                                                                                                         string)>>>> =
                                                                                                                                                           rayon::iter::ParallelIterator::collect(v1521);
                                                                                                                                                       Documents::method3(Documents::US0::US0_2,
                                                                                                                                                                          Func0::new(move
                                                                                                                                                                                         ||
                                                                                                                                                                                         Documents::closure61((),
                                                                                                                                                                                                              ())),
                                                                                                                                                                          Func0::new({
                                                                                                                                                                                         let patternInput_5
                                                                                                                                                                                             =
                                                                                                                                                                                             patternInput_5.clone();
                                                                                                                                                                                         let patternInput_8
                                                                                                                                                                                             =
                                                                                                                                                                                             patternInput_8.clone();
                                                                                                                                                                                         let v1145
                                                                                                                                                                                             =
                                                                                                                                                                                             v1145.clone();
                                                                                                                                                                                         let v1500
                                                                                                                                                                                             =
                                                                                                                                                                                             v1500.clone();
                                                                                                                                                                                         let v1523
                                                                                                                                                                                             =
                                                                                                                                                                                             v1523.clone();
                                                                                                                                                                                         let v259
                                                                                                                                                                                             =
                                                                                                                                                                                             v259.clone();
                                                                                                                                                                                         let v293
                                                                                                                                                                                             =
                                                                                                                                                                                             v293.clone();
                                                                                                                                                                                         let v370
                                                                                                                                                                                             =
                                                                                                                                                                                             v370.clone();
                                                                                                                                                                                         let v592
                                                                                                                                                                                             =
                                                                                                                                                                                             v592.clone();
                                                                                                                                                                                         let v889
                                                                                                                                                                                             =
                                                                                                                                                                                             v889.clone();
                                                                                                                                                                                         move
                                                                                                                                                                                             ||
                                                                                                                                                                                             Documents::closure62(v259.clone(),
                                                                                                                                                                                                                  v293.clone(),
                                                                                                                                                                                                                  v370.clone(),
                                                                                                                                                                                                                  v592.clone(),
                                                                                                                                                                                                                  patternInput_5.0.clone(),
                                                                                                                                                                                                                  v889.clone(),
                                                                                                                                                                                                                  patternInput_8.0.clone(),
                                                                                                                                                                                                                  v1145.clone(),
                                                                                                                                                                                                                  v1500.clone(),
                                                                                                                                                                                                                  v1523.clone(),
                                                                                                                                                                                                                  ())
                                                                                                                                                                                     }));
                                                                                                                                                       {
                                                                                                                                                           let _v1527:
                                                                                                                                                                   MutCell<Option<()>> =
                                                                                                                                                               MutCell::new(None::<()>);
                                                                                                                                                           let v1529:
                                                                                                                                                                   string =
                                                                                                                                                               Documents::method73(v1221.clone());
                                                                                                                                                           let v1531:
                                                                                                                                                                   Result<u64,
                                                                                                                                                                          std::io::Error> =
                                                                                                                                                               std::fs::copy(&*v668, &*v1529);
                                                                                                                                                           let v1533:
                                                                                                                                                                   u64 =
                                                                                                                                                               v1531.unwrap();
                                                                                                                                                           _v1527.set(Some(()));
                                                                                                                                                           getValue(_v1527.get().clone());
                                                                                                                                                           v1523.clone()
                                                                                                                                                       }
                                                                                                                                                   } else {
                                                                                                                                                       new_empty::<Option<Result<string,
                                                                                                                                                                                 LrcPtr<(string,
                                                                                                                                                                                         string)>>>>().to_vec()
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
                                                                                                                   new_empty::<Option<Result<string,
                                                                                                                                             LrcPtr<(string,
                                                                                                                                                     string)>>>>().to_vec()
                                                                                                               })))
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
        pub fn closure63(unitVar: (), unitVar_1: ()) -> string {
            string("documents.run")
        }
        pub fn closure64(
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
        pub fn method74(
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
        pub fn method33(
            v0_1: string,
            v1_1: string,
            v2: string,
            v3: string,
            v4: string,
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
                    let v7: async_walkdir::WalkDir = async_walkdir::WalkDir::new(&*v3.clone());
                    let v10: async_walkdir::WalkDir = async_walkdir::WalkDir::filter(v7, |x| {
                        Func1::new(move |v: async_walkdir::DirEntry| Documents::closure14((), v))(x)
                    });
                    let v11 = Documents::method41();
                    let v12: string =
                    string("futures_lite::stream::StreamExt::collect(futures_lite::stream::StreamExt::filter_map(v10, |x| v11(x))).await");
                    let v13: Vec<string> = futures_lite::stream::StreamExt::collect(
                        futures_lite::stream::StreamExt::filter_map(v10, |x| v11(x)),
                    )
                    .await;
                    Documents::method3(
                        Documents::US0::US0_1,
                        Func0::new(move || Documents::closure23((), ())),
                        Func0::new({
                            let v13 = v13.clone();
                            move || Documents::closure24(v13.clone(), ())
                        }),
                    );
                    {
                        let v18: rayon::vec::IntoIter<string> =
                            rayon::iter::IntoParallelIterator::into_par_iter(v13);
                        let v21: rayon::iter::Map<rayon::vec::IntoIter<string>, _> =
                            rayon::iter::ParallelIterator::map(v18, |x| {
                                Func1::new({
                                    let v0_1 = v0_1.clone();
                                    let v1_1 = v1_1.clone();
                                    let v2 = v2.clone();
                                    let v3 = v3.clone();
                                    let v4 = v4.clone();
                                    move |v_1: string| {
                                        Documents::closure25(
                                            v0_1.clone(),
                                            v1_1.clone(),
                                            v2.clone(),
                                            v3.clone(),
                                            v4.clone(),
                                            v_1,
                                        )
                                    }
                                })(x)
                            });
                        let v23: Vec<
                            Result<
                                LrcPtr<(
                                    string,
                                    Vec<Option<Result<string, LrcPtr<(string, string)>>>>,
                                )>,
                                std::string::String,
                            >,
                        > = rayon::iter::ParallelIterator::collect(v21);
                        Documents::method3(
                            Documents::US0::US0_1,
                            Func0::new(move || Documents::closure63((), ())),
                            Func0::new({
                                let v23 = v23.clone();
                                move || Documents::closure64(v23.clone(), ())
                            }),
                        );
                        {
                            let v28: Result<
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
                            > = Documents::method74(Ok::<
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
                            >(v23.clone()));
                            v28
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
            let _v5: MutCell<Option<string>> = MutCell::new(None::<string>);
            let v7: string = Documents::method13();
            let v9: &str = fable_library_rust::String_::LrcStr::as_str(&v7);
            let v11: std::string::String = String::from(v9);
            let v13: std::path::PathBuf = std::path::PathBuf::from(v11);
            let v14: string = Documents::method14();
            let v16: &str = fable_library_rust::String_::LrcStr::as_str(&v14);
            let v18: std::string::String = String::from(v16);
            let v20: std::path::PathBuf = v13.join(v18);
            let v22: std::path::Display = v20.display();
            let _v23: MutCell<Option<std::string::String>> =
                MutCell::new(None::<std::string::String>);
            {
                let x: std::string::String = format!("{}", v22);
                _v23.set(Some(x))
            }
            {
                let v34: std::string::String = getValue(_v23.get().clone());
                {
                    let x_1: string = fable_library_rust::String_::fromString(v34);
                    _v5.set(Some(x_1))
                }
                {
                    let _v51: MutCell<Option<string>> = MutCell::new(None::<string>);
                    let v53: string = Documents::method18(Documents::method17(
                        getValue(_v5.get().clone()),
                        string("C:\\home\\git\\polyglot\\target\\polyglot\\builder\\documents"),
                    ));
                    let v55: &str = fable_library_rust::String_::LrcStr::as_str(&v53);
                    let v57: std::string::String = String::from(v55);
                    let v59: std::path::PathBuf = std::path::PathBuf::from(v57);
                    let v60: string = Documents::method13();
                    let v62: &str = fable_library_rust::String_::LrcStr::as_str(&v60);
                    let v64: std::string::String = String::from(v62);
                    let v66: std::path::PathBuf = v59.join(v64);
                    let v68: std::path::Display = v66.display();
                    let _v69: MutCell<Option<std::string::String>> =
                        MutCell::new(None::<std::string::String>);
                    {
                        let x_2: std::string::String = format!("{}", v68);
                        _v69.set(Some(x_2))
                    }
                    {
                        let v80: std::string::String = getValue(_v69.get().clone());
                        {
                            let x_3: string = fable_library_rust::String_::fromString(v80);
                            _v51.set(Some(x_3))
                        }
                        {
                            let v92: string = getValue(_v51.get().clone());
                            let _v93: MutCell<Option<string>> = MutCell::new(None::<string>);
                            let v95: string = Documents::method25(v3);
                            let v96: string = Documents::method18(v95.clone());
                            let v98: &str = fable_library_rust::String_::LrcStr::as_str(&v96);
                            let v100: std::string::String = String::from(v98);
                            let v102: std::path::PathBuf = std::path::PathBuf::from(v100);
                            {
                                let x_12: string = if v102.exists() == false {
                                    let _v106: MutCell<Option<string>> =
                                        MutCell::new(None::<string>);
                                    let v109: Result<std::path::PathBuf, std::io::Error> =
                                        std::env::current_dir();
                                    let v111: std::path::PathBuf = v109.unwrap();
                                    let v113: std::path::Display = v111.display();
                                    let _v114: MutCell<Option<std::string::String>> =
                                        MutCell::new(None::<std::string::String>);
                                    {
                                        let x_4: std::string::String = format!("{}", v113);
                                        _v114.set(Some(x_4))
                                    }
                                    {
                                        let v125: std::string::String =
                                            getValue(_v114.get().clone());
                                        {
                                            let x_5: string =
                                                fable_library_rust::String_::fromString(v125);
                                            _v106.set(Some(x_5))
                                        }
                                        {
                                            let v134: string = getValue(_v106.get().clone());
                                            let _v135: MutCell<Option<string>> =
                                                MutCell::new(None::<string>);
                                            let v137: string = Documents::method18(v134.clone());
                                            let v139: &str =
                                                fable_library_rust::String_::LrcStr::as_str(&v137);
                                            let v141: std::string::String = String::from(v139);
                                            let v143: std::path::PathBuf =
                                                std::path::PathBuf::from(v141);
                                            let v144: string = Documents::method18(v95.clone());
                                            let v146: &str =
                                                fable_library_rust::String_::LrcStr::as_str(&v144);
                                            let v148: std::string::String = String::from(v146);
                                            let v150: std::path::PathBuf = v143.join(v148);
                                            let v152: std::path::Display = v150.display();
                                            let _v153: MutCell<Option<std::string::String>> =
                                                MutCell::new(None::<std::string::String>);
                                            {
                                                let x_6: std::string::String = format!("{}", v152);
                                                _v153.set(Some(x_6))
                                            }
                                            {
                                                let v164: std::string::String =
                                                    getValue(_v153.get().clone());
                                                {
                                                    let x_7: string =
                                                        fable_library_rust::String_::fromString(
                                                            v164,
                                                        );
                                                    _v135.set(Some(x_7))
                                                }
                                                {
                                                    let v176: string =
                                                        getValue(_v135.get().clone());
                                                    let _v177: MutCell<Option<bool>> =
                                                        MutCell::new(None::<bool>);
                                                    {
                                                        let x_8: bool = cfg!(windows);
                                                        _v177.set(Some(x_8))
                                                    }
                                                    {
                                                        let v215: Array<string> = split(
                                                            if getValue(_v177.get().clone())
                                                                == false
                                                            {
                                                                v176.clone()
                                                            } else {
                                                                let _v190: MutCell<Option<string>> =
                                                                    MutCell::new(None::<string>);
                                                                let v192: string =
                                                                    Documents::method26();
                                                                let v193: string =
                                                                    Documents::method27(v176);
                                                                let v194: string =
                                                                    Documents::method28();
                                                                let v196: &str =
                                                                    &regex::Regex::new(&v192)
                                                                        .unwrap()
                                                                        .replace_all(&v193, &*v194);
                                                                let v198: std::string::String =
                                                                    String::from(v196);
                                                                {
                                                                    let x_9:
                                                                                      string =
                                                                                  fable_library_rust::String_::fromString(v198);
                                                                    _v190.set(Some(x_9))
                                                                }
                                                                {
                                                                    let v208: string = getValue(
                                                                        _v190.get().clone(),
                                                                    );
                                                                    replace(
                                                                        sprintf!(
                                                                            "{}{}",
                                                                            toLower(ofChar(
                                                                                getCharAt(
                                                                                    v208.clone(),
                                                                                    0_i32
                                                                                )
                                                                            )),
                                                                            getSlice(
                                                                                v208,
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
                                                        let v217: i32 = count(v215.clone());
                                                        let v218: LrcPtr<Documents::Mut4> =
                                                            LrcPtr::new(Documents::Mut4 {
                                                                l0: MutCell::new(0_i32),
                                                                l1: MutCell::new(0_i32),
                                                                l2: MutCell::new(
                                                                    new_empty::<string>(),
                                                                ),
                                                            });
                                                        while Documents::method29(
                                                            v217,
                                                            v218.clone(),
                                                        ) {
                                                            let v220: i32 = v218.l0.get().clone();
                                                            let v223: i32 =
                                                                v220.wrapping_neg() + v217 - 1_i32;
                                                            let matchValue: i32 =
                                                                v218.l1.get().clone();
                                                            let v225: Array<string> =
                                                                v218.l2.get().clone();
                                                            let v224: i32 = matchValue;
                                                            let v226: string = v215[v223].clone();
                                                            let patternInput_1: (
                                                                i32,
                                                                Array<string>,
                                                            ) = if string("..") == v226.clone() {
                                                                (v224 + 1_i32, v225.clone())
                                                            } else {
                                                                if 0_i32 == v224 {
                                                                    if endsWith(
                                                                        v226.clone(),
                                                                        string(":"),
                                                                        false,
                                                                    ) {
                                                                        let v233: Array<string> =
                                                                            new_array(&[sprintf!(
                                                                                "{}:",
                                                                                getCharAt(
                                                                                    v134.clone(),
                                                                                    0_i32
                                                                                )
                                                                            )]);
                                                                        let v234: i32 =
                                                                            count(v233.clone());
                                                                        let v236: i32 = v234
                                                                            + count(v225.clone());
                                                                        let v237: Array<string> =
                                                                            new_init(
                                                                                &string(""),
                                                                                v236,
                                                                            );
                                                                        let v238: LrcPtr<
                                                                            Documents::Mut5,
                                                                        > = LrcPtr::new(
                                                                            Documents::Mut5 {
                                                                                l0: MutCell::new(
                                                                                    0_i32,
                                                                                ),
                                                                            },
                                                                        );
                                                                        while Documents::method30(
                                                                            v236,
                                                                            v238.clone(),
                                                                        ) {
                                                                            let v240: i32 = v238
                                                                                .l0
                                                                                .get()
                                                                                .clone();
                                                                            let v245: string =
                                                                                if v240 < v234 {
                                                                                    v233[v240]
                                                                                        .clone()
                                                                                } else {
                                                                                    let v243: i32 =
                                                                                        v240 - v234;
                                                                                    v225[v243]
                                                                                        .clone()
                                                                                };
                                                                            v237.get_mut()
                                                                                [v240 as usize] =
                                                                                v245;
                                                                            {
                                                                                let v246: i32 =
                                                                                    v240 + 1_i32;
                                                                                v238.l0.set(v246);
                                                                                ()
                                                                            }
                                                                        }
                                                                        (0_i32, v237.clone())
                                                                    } else {
                                                                        let v247: Array<string> =
                                                                            new_array(&[v226]);
                                                                        let v248: i32 =
                                                                            count(v247.clone());
                                                                        let v250: i32 = v248
                                                                            + count(v225.clone());
                                                                        let v251: Array<string> =
                                                                            new_init(
                                                                                &string(""),
                                                                                v250,
                                                                            );
                                                                        let v252: LrcPtr<
                                                                            Documents::Mut5,
                                                                        > = LrcPtr::new(
                                                                            Documents::Mut5 {
                                                                                l0: MutCell::new(
                                                                                    0_i32,
                                                                                ),
                                                                            },
                                                                        );
                                                                        while Documents::method30(
                                                                            v250,
                                                                            v252.clone(),
                                                                        ) {
                                                                            let v254: i32 = v252
                                                                                .l0
                                                                                .get()
                                                                                .clone();
                                                                            let v259: string =
                                                                                if v254 < v248 {
                                                                                    v247[v254]
                                                                                        .clone()
                                                                                } else {
                                                                                    let v257: i32 =
                                                                                        v254 - v248;
                                                                                    v225[v257]
                                                                                        .clone()
                                                                                };
                                                                            v251.get_mut()
                                                                                [v254 as usize] =
                                                                                v259;
                                                                            {
                                                                                let v260: i32 =
                                                                                    v254 + 1_i32;
                                                                                v252.l0.set(v260);
                                                                                ()
                                                                            }
                                                                        }
                                                                        (0_i32, v251.clone())
                                                                    }
                                                                } else {
                                                                    (v224 - 1_i32, v225.clone())
                                                                }
                                                            };
                                                            let v268: i32 = v220 + 1_i32;
                                                            v218.l0.set(v268);
                                                            v218.l1.set(patternInput_1.0.clone());
                                                            v218.l2.set(patternInput_1.1.clone());
                                                            ()
                                                        }
                                                        {
                                                            let matchValue_2: i32 =
                                                                v218.l1.get().clone();
                                                            let v270: Array<string> =
                                                                v218.l2.get().clone();
                                                            let v271: LrcPtr<
                                                                dyn IEnumerable_1<string>,
                                                            > = delay(Func0::new({
                                                                let v270 = v270.clone();
                                                                move || {
                                                                    map_1(
                                                                        Func1::new({
                                                                            let v270 = v270.clone();
                                                                            move |i: i32| {
                                                                                v270[i].clone()
                                                                            }
                                                                        }),
                                                                        rangeNumeric(
                                                                            0_i32,
                                                                            1_i32,
                                                                            count(v270.clone())
                                                                                - 1_i32,
                                                                        ),
                                                                    )
                                                                }
                                                            }));
                                                            let _v272: MutCell<Option<char>> =
                                                                MutCell::new(None::<char>);
                                                            {
                                                                let x_10: char =
                                                                    std::path::MAIN_SEPARATOR;
                                                                _v272.set(Some(x_10))
                                                            }
                                                            join(
                                                                Documents::method31(ofChar(
                                                                    getValue(_v272.get().clone()),
                                                                )),
                                                                toArray_1(v271),
                                                            )
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                } else {
                                    let v289: Result<std::path::PathBuf, std::io::Error> =
                                        std::fs::canonicalize(&*v95);
                                    let v291: std::path::PathBuf = v289.unwrap();
                                    let v293: std::path::Display = v291.display();
                                    let _v294: MutCell<Option<std::string::String>> =
                                        MutCell::new(None::<std::string::String>);
                                    {
                                        let x_11: std::string::String = format!("{}", v293);
                                        _v294.set(Some(x_11))
                                    }
                                    {
                                        let v305: std::string::String =
                                            getValue(_v294.get().clone());
                                        fable_library_rust::String_::fromString(v305)
                                    }
                                };
                                _v93.set(Some(x_12))
                            }
                            {
                                let v316: string = getValue(_v93.get().clone());
                                let _v317: MutCell<Option<string>> = MutCell::new(None::<string>);
                                let v319: string = Documents::method25(v2);
                                let v320: string = Documents::method18(v319.clone());
                                let v322: &str = fable_library_rust::String_::LrcStr::as_str(&v320);
                                let v324: std::string::String = String::from(v322);
                                let v326: std::path::PathBuf = std::path::PathBuf::from(v324);
                                {
                                    let x_21: string = if v326.exists() == false {
                                        let _v330: MutCell<Option<string>> =
                                            MutCell::new(None::<string>);
                                        let v333: Result<std::path::PathBuf, std::io::Error> =
                                            std::env::current_dir();
                                        let v335: std::path::PathBuf = v333.unwrap();
                                        let v337: std::path::Display = v335.display();
                                        let _v338: MutCell<Option<std::string::String>> =
                                            MutCell::new(None::<std::string::String>);
                                        {
                                            let x_13: std::string::String = format!("{}", v337);
                                            _v338.set(Some(x_13))
                                        }
                                        {
                                            let v349: std::string::String =
                                                getValue(_v338.get().clone());
                                            {
                                                let x_14: string =
                                                    fable_library_rust::String_::fromString(v349);
                                                _v330.set(Some(x_14))
                                            }
                                            {
                                                let v358: string = getValue(_v330.get().clone());
                                                let _v359: MutCell<Option<string>> =
                                                    MutCell::new(None::<string>);
                                                let v361: string =
                                                    Documents::method18(v358.clone());
                                                let v363: &str =
                                                    fable_library_rust::String_::LrcStr::as_str(
                                                        &v361,
                                                    );
                                                let v365: std::string::String = String::from(v363);
                                                let v367: std::path::PathBuf =
                                                    std::path::PathBuf::from(v365);
                                                let v368: string =
                                                    Documents::method18(v319.clone());
                                                let v370: &str =
                                                    fable_library_rust::String_::LrcStr::as_str(
                                                        &v368,
                                                    );
                                                let v372: std::string::String = String::from(v370);
                                                let v374: std::path::PathBuf = v367.join(v372);
                                                let v376: std::path::Display = v374.display();
                                                let _v377: MutCell<Option<std::string::String>> =
                                                    MutCell::new(None::<std::string::String>);
                                                {
                                                    let x_15: std::string::String =
                                                        format!("{}", v376);
                                                    _v377.set(Some(x_15))
                                                }
                                                {
                                                    let v388: std::string::String =
                                                        getValue(_v377.get().clone());
                                                    {
                                                        let x_16: string =
                                                            fable_library_rust::String_::fromString(
                                                                v388,
                                                            );
                                                        _v359.set(Some(x_16))
                                                    }
                                                    {
                                                        let v400: string =
                                                            getValue(_v359.get().clone());
                                                        let _v401: MutCell<Option<bool>> =
                                                            MutCell::new(None::<bool>);
                                                        {
                                                            let x_17: bool = cfg!(windows);
                                                            _v401.set(Some(x_17))
                                                        }
                                                        {
                                                            let v439: Array<string> = split(
                                                                if getValue(_v401.get().clone())
                                                                    == false
                                                                {
                                                                    v400.clone()
                                                                } else {
                                                                    let _v414: MutCell<
                                                                        Option<string>,
                                                                    > = MutCell::new(
                                                                        None::<string>,
                                                                    );
                                                                    let v416: string =
                                                                        Documents::method26();
                                                                    let v417: string =
                                                                        Documents::method27(v400);
                                                                    let v418: string =
                                                                        Documents::method28();
                                                                    let v420: &str =
                                                                        &regex::Regex::new(&v416)
                                                                            .unwrap()
                                                                            .replace_all(
                                                                                &v417, &*v418,
                                                                            );
                                                                    let v422: std::string::String =
                                                                        String::from(v420);
                                                                    {
                                                                        let x_18:
                                                                                          string =
                                                                                      fable_library_rust::String_::fromString(v422);
                                                                        _v414.set(Some(x_18))
                                                                    }
                                                                    {
                                                                        let v432: string = getValue(
                                                                            _v414.get().clone(),
                                                                        );
                                                                        replace(
                                                                            sprintf!(
                                                                                "{}{}",
                                                                                toLower(ofChar(
                                                                                    getCharAt(
                                                                                        v432.clone(
                                                                                        ),
                                                                                        0_i32
                                                                                    )
                                                                                )),
                                                                                getSlice(
                                                                                    v432,
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
                                                            let v441: i32 = count(v439.clone());
                                                            let v442: LrcPtr<Documents::Mut4> =
                                                                LrcPtr::new(Documents::Mut4 {
                                                                    l0: MutCell::new(0_i32),
                                                                    l1: MutCell::new(0_i32),
                                                                    l2: MutCell::new(new_empty::<
                                                                        string,
                                                                    >(
                                                                    )),
                                                                });
                                                            while Documents::method29(
                                                                v441,
                                                                v442.clone(),
                                                            ) {
                                                                let v444: i32 =
                                                                    v442.l0.get().clone();
                                                                let v447: i32 = v444.wrapping_neg()
                                                                    + v441
                                                                    - 1_i32;
                                                                let matchValue_4: i32 =
                                                                    v442.l1.get().clone();
                                                                let v449: Array<string> =
                                                                    v442.l2.get().clone();
                                                                let v448: i32 = matchValue_4;
                                                                let v450: string =
                                                                    v439[v447].clone();
                                                                let patternInput_4: (
                                                                    i32,
                                                                    Array<string>,
                                                                ) = if string("..") == v450.clone()
                                                                {
                                                                    (v448 + 1_i32, v449.clone())
                                                                } else {
                                                                    if 0_i32 == v448 {
                                                                        if endsWith(
                                                                            v450.clone(),
                                                                            string(":"),
                                                                            false,
                                                                        ) {
                                                                            let v457: Array<
                                                                                string,
                                                                            > = new_array(&[
                                                                                sprintf!(
                                                                                    "{}:",
                                                                                    getCharAt(
                                                                                        v358.clone(
                                                                                        ),
                                                                                        0_i32
                                                                                    )
                                                                                ),
                                                                            ]);
                                                                            let v458: i32 =
                                                                                count(v457.clone());
                                                                            let v460: i32 = v458
                                                                                + count(
                                                                                    v449.clone(),
                                                                                );
                                                                            let v461: Array<
                                                                                string,
                                                                            > = new_init(
                                                                                &string(""),
                                                                                v460,
                                                                            );
                                                                            let v462: LrcPtr<
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
                                                                                Documents::method30(
                                                                                    v460,
                                                                                    v462.clone(),
                                                                                )
                                                                            {
                                                                                let v464: i32 =
                                                                                    v462.l0
                                                                                        .get()
                                                                                        .clone();
                                                                                let v469: string =
                                                                                    if v464 < v458 {
                                                                                        v457[v464]
                                                                                            .clone()
                                                                                    } else {
                                                                                        let v467:
                                                                                                        i32 =
                                                                                                    v464
                                                                                                        -
                                                                                                        v458;
                                                                                        v449[v467]
                                                                                            .clone()
                                                                                    };
                                                                                v461.get_mut()[v464
                                                                                    as usize] =
                                                                                    v469;
                                                                                {
                                                                                    let v470: i32 =
                                                                                        v464 + 1_i32;
                                                                                    v462.l0
                                                                                        .set(v470);
                                                                                    ()
                                                                                }
                                                                            }
                                                                            (0_i32, v461.clone())
                                                                        } else {
                                                                            let v471: Array<
                                                                                string,
                                                                            > = new_array(&[v450]);
                                                                            let v472: i32 =
                                                                                count(v471.clone());
                                                                            let v474: i32 = v472
                                                                                + count(
                                                                                    v449.clone(),
                                                                                );
                                                                            let v475: Array<
                                                                                string,
                                                                            > = new_init(
                                                                                &string(""),
                                                                                v474,
                                                                            );
                                                                            let v476: LrcPtr<
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
                                                                                Documents::method30(
                                                                                    v474,
                                                                                    v476.clone(),
                                                                                )
                                                                            {
                                                                                let v478: i32 =
                                                                                    v476.l0
                                                                                        .get()
                                                                                        .clone();
                                                                                let v483: string =
                                                                                    if v478 < v472 {
                                                                                        v471[v478]
                                                                                            .clone()
                                                                                    } else {
                                                                                        let v481:
                                                                                                        i32 =
                                                                                                    v478
                                                                                                        -
                                                                                                        v472;
                                                                                        v449[v481]
                                                                                            .clone()
                                                                                    };
                                                                                v475.get_mut()[v478
                                                                                    as usize] =
                                                                                    v483;
                                                                                {
                                                                                    let v484: i32 =
                                                                                        v478 + 1_i32;
                                                                                    v476.l0
                                                                                        .set(v484);
                                                                                    ()
                                                                                }
                                                                            }
                                                                            (0_i32, v475.clone())
                                                                        }
                                                                    } else {
                                                                        (v448 - 1_i32, v449.clone())
                                                                    }
                                                                };
                                                                let v492: i32 = v444 + 1_i32;
                                                                v442.l0.set(v492);
                                                                v442.l1
                                                                    .set(patternInput_4.0.clone());
                                                                v442.l2
                                                                    .set(patternInput_4.1.clone());
                                                                ()
                                                            }
                                                            {
                                                                let matchValue_6: i32 =
                                                                    v442.l1.get().clone();
                                                                let v494: Array<string> =
                                                                    v442.l2.get().clone();
                                                                let v495: LrcPtr<
                                                                    dyn IEnumerable_1<string>,
                                                                > = delay(Func0::new({
                                                                    let v494 = v494.clone();
                                                                    move || {
                                                                        map_1(
                                                                            Func1::new({
                                                                                let v494 =
                                                                                    v494.clone();
                                                                                move |i_1: i32| {
                                                                                    v494[i_1]
                                                                                        .clone()
                                                                                }
                                                                            }),
                                                                            rangeNumeric(
                                                                                0_i32,
                                                                                1_i32,
                                                                                count(v494.clone())
                                                                                    - 1_i32,
                                                                            ),
                                                                        )
                                                                    }
                                                                }));
                                                                let _v496: MutCell<Option<char>> =
                                                                    MutCell::new(None::<char>);
                                                                {
                                                                    let x_19: char =
                                                                        std::path::MAIN_SEPARATOR;
                                                                    _v496.set(Some(x_19))
                                                                }
                                                                join(
                                                                    Documents::method31(ofChar(
                                                                        getValue(
                                                                            _v496.get().clone(),
                                                                        ),
                                                                    )),
                                                                    toArray_1(v495),
                                                                )
                                                            }
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    } else {
                                        let v513: Result<std::path::PathBuf, std::io::Error> =
                                            std::fs::canonicalize(&*v319);
                                        let v515: std::path::PathBuf = v513.unwrap();
                                        let v517: std::path::Display = v515.display();
                                        let _v518: MutCell<Option<std::string::String>> =
                                            MutCell::new(None::<std::string::String>);
                                        {
                                            let x_20: std::string::String = format!("{}", v517);
                                            _v518.set(Some(x_20))
                                        }
                                        {
                                            let v529: std::string::String =
                                                getValue(_v518.get().clone());
                                            fable_library_rust::String_::fromString(v529)
                                        }
                                    };
                                    _v317.set(Some(x_21))
                                }
                                {
                                    let v540: string = getValue(_v317.get().clone());
                                    let _v541: MutCell<Option<string>> =
                                        MutCell::new(None::<string>);
                                    let v543: string = Documents::method25(v1_1);
                                    let v544: string = Documents::method18(v543.clone());
                                    let v546: &str =
                                        fable_library_rust::String_::LrcStr::as_str(&v544);
                                    let v548: std::string::String = String::from(v546);
                                    let v550: std::path::PathBuf = std::path::PathBuf::from(v548);
                                    {
                                        let x_30: string = if v550.exists() == false {
                                            let _v554: MutCell<Option<string>> =
                                                MutCell::new(None::<string>);
                                            let v557: Result<std::path::PathBuf, std::io::Error> =
                                                std::env::current_dir();
                                            let v559: std::path::PathBuf = v557.unwrap();
                                            let v561: std::path::Display = v559.display();
                                            let _v562: MutCell<Option<std::string::String>> =
                                                MutCell::new(None::<std::string::String>);
                                            {
                                                let x_22: std::string::String = format!("{}", v561);
                                                _v562.set(Some(x_22))
                                            }
                                            {
                                                let v573: std::string::String =
                                                    getValue(_v562.get().clone());
                                                {
                                                    let x_23: string =
                                                        fable_library_rust::String_::fromString(
                                                            v573,
                                                        );
                                                    _v554.set(Some(x_23))
                                                }
                                                {
                                                    let v582: string =
                                                        getValue(_v554.get().clone());
                                                    let _v583: MutCell<Option<string>> =
                                                        MutCell::new(None::<string>);
                                                    let v585: string =
                                                        Documents::method18(v582.clone());
                                                    let v587: &str =
                                                        fable_library_rust::String_::LrcStr::as_str(
                                                            &v585,
                                                        );
                                                    let v589: std::string::String =
                                                        String::from(v587);
                                                    let v591: std::path::PathBuf =
                                                        std::path::PathBuf::from(v589);
                                                    let v592: string =
                                                        Documents::method18(v543.clone());
                                                    let v594: &str =
                                                        fable_library_rust::String_::LrcStr::as_str(
                                                            &v592,
                                                        );
                                                    let v596: std::string::String =
                                                        String::from(v594);
                                                    let v598: std::path::PathBuf = v591.join(v596);
                                                    let v600: std::path::Display = v598.display();
                                                    let _v601: MutCell<
                                                        Option<std::string::String>,
                                                    > = MutCell::new(None::<std::string::String>);
                                                    {
                                                        let x_24: std::string::String =
                                                            format!("{}", v600);
                                                        _v601.set(Some(x_24))
                                                    }
                                                    {
                                                        let v612: std::string::String =
                                                            getValue(_v601.get().clone());
                                                        {
                                                            let x_25:
                                                                        string =
                                                                    fable_library_rust::String_::fromString(v612);
                                                            _v583.set(Some(x_25))
                                                        }
                                                        {
                                                            let v624: string =
                                                                getValue(_v583.get().clone());
                                                            let _v625: MutCell<Option<bool>> =
                                                                MutCell::new(None::<bool>);
                                                            {
                                                                let x_26: bool = cfg!(windows);
                                                                _v625.set(Some(x_26))
                                                            }
                                                            {
                                                                let v663: Array<string> = split(
                                                                    if getValue(_v625.get().clone())
                                                                        == false
                                                                    {
                                                                        v624.clone()
                                                                    } else {
                                                                        let _v638: MutCell<
                                                                            Option<string>,
                                                                        > = MutCell::new(
                                                                            None::<string>,
                                                                        );
                                                                        let v640: string =
                                                                            Documents::method26();
                                                                        let v641: string =
                                                                            Documents::method27(
                                                                                v624,
                                                                            );
                                                                        let v642: string =
                                                                            Documents::method28();
                                                                        let v644: &str =
                                                                            &regex::Regex::new(
                                                                                &v640,
                                                                            )
                                                                            .unwrap()
                                                                            .replace_all(
                                                                                &v641, &*v642,
                                                                            );
                                                                        let v646:
                                                                                          std::string::String =
                                                                                      String::from(v644);
                                                                        {
                                                                            let x_27:
                                                                                              string =
                                                                                          fable_library_rust::String_::fromString(v646);
                                                                            _v638.set(Some(x_27))
                                                                        }
                                                                        {
                                                                            let v656: string =
                                                                                getValue(
                                                                                    _v638
                                                                                        .get()
                                                                                        .clone(),
                                                                                );
                                                                            replace(sprintf!("{}{}",
                                                                                                       toLower(ofChar(getCharAt(v656.clone(),
                                                                                                                                0_i32))),
                                                                                                       getSlice(v656,
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
                                                                let v665: i32 = count(v663.clone());
                                                                let v666: LrcPtr<Documents::Mut4> =
                                                                    LrcPtr::new(Documents::Mut4 {
                                                                        l0: MutCell::new(0_i32),
                                                                        l1: MutCell::new(0_i32),
                                                                        l2: MutCell::new(
                                                                            new_empty::<string>(),
                                                                        ),
                                                                    });
                                                                while Documents::method29(
                                                                    v665,
                                                                    v666.clone(),
                                                                ) {
                                                                    let v668: i32 =
                                                                        v666.l0.get().clone();
                                                                    let v671: i32 =
                                                                        v668.wrapping_neg() + v665
                                                                            - 1_i32;
                                                                    let matchValue_8: i32 =
                                                                        v666.l1.get().clone();
                                                                    let v673: Array<string> =
                                                                        v666.l2.get().clone();
                                                                    let v672: i32 = matchValue_8;
                                                                    let v674: string =
                                                                        v663[v671].clone();
                                                                    let patternInput_7: (
                                                                        i32,
                                                                        Array<string>,
                                                                    ) = if string("..")
                                                                        == v674.clone()
                                                                    {
                                                                        (v672 + 1_i32, v673.clone())
                                                                    } else {
                                                                        if 0_i32 == v672 {
                                                                            if endsWith(
                                                                                v674.clone(),
                                                                                string(":"),
                                                                                false,
                                                                            ) {
                                                                                let v681:
                                                                                                Array<string> =
                                                                                            new_array(&[sprintf!("{}:",
                                                                                                                 getCharAt(v582.clone(),
                                                                                                                           0_i32))]);
                                                                                let v682: i32 =
                                                                                    count(
                                                                                        v681.clone(
                                                                                        ),
                                                                                    );
                                                                                let v684: i32 = v682
                                                                                    + count(
                                                                                        v673.clone(
                                                                                        ),
                                                                                    );
                                                                                let v685: Array<
                                                                                    string,
                                                                                > = new_init(
                                                                                    &string(""),
                                                                                    v684,
                                                                                );
                                                                                let v686:
                                                                                                LrcPtr<Documents::Mut5> =
                                                                                            LrcPtr::new(Documents::Mut5{l0:
                                                                                                                            MutCell::new(0_i32),});
                                                                                while Documents::method30(v684,
                                                                                                                  v686.clone())
                                                                                              {
                                                                                            let v688:
                                                                                                    i32 =
                                                                                                v686.l0.get().clone();
                                                                                            let v693:
                                                                                                    string =
                                                                                                if v688
                                                                                                       <
                                                                                                       v682
                                                                                                   {
                                                                                                    v681[v688].clone()
                                                                                                } else {
                                                                                                    let v691:
                                                                                                            i32 =
                                                                                                        v688
                                                                                                            -
                                                                                                            v682;
                                                                                                    v673[v691].clone()
                                                                                                };
                                                                                            v685.get_mut()[v688
                                                                                                               as
                                                                                                               usize]
                                                                                                =
                                                                                                v693;
                                                                                            {
                                                                                                let v694:
                                                                                                        i32 =
                                                                                                    v688
                                                                                                        +
                                                                                                        1_i32;
                                                                                                v686.l0.set(v694);
                                                                                                ()
                                                                                            }
                                                                                        }
                                                                                (
                                                                                    0_i32,
                                                                                    v685.clone(),
                                                                                )
                                                                            } else {
                                                                                let v695: Array<
                                                                                    string,
                                                                                > = new_array(&[
                                                                                    v674,
                                                                                ]);
                                                                                let v696: i32 =
                                                                                    count(
                                                                                        v695.clone(
                                                                                        ),
                                                                                    );
                                                                                let v698: i32 = v696
                                                                                    + count(
                                                                                        v673.clone(
                                                                                        ),
                                                                                    );
                                                                                let v699: Array<
                                                                                    string,
                                                                                > = new_init(
                                                                                    &string(""),
                                                                                    v698,
                                                                                );
                                                                                let v700:
                                                                                                LrcPtr<Documents::Mut5> =
                                                                                            LrcPtr::new(Documents::Mut5{l0:
                                                                                                                            MutCell::new(0_i32),});
                                                                                while Documents::method30(v698,
                                                                                                                  v700.clone())
                                                                                              {
                                                                                            let v702:
                                                                                                    i32 =
                                                                                                v700.l0.get().clone();
                                                                                            let v707:
                                                                                                    string =
                                                                                                if v702
                                                                                                       <
                                                                                                       v696
                                                                                                   {
                                                                                                    v695[v702].clone()
                                                                                                } else {
                                                                                                    let v705:
                                                                                                            i32 =
                                                                                                        v702
                                                                                                            -
                                                                                                            v696;
                                                                                                    v673[v705].clone()
                                                                                                };
                                                                                            v699.get_mut()[v702
                                                                                                               as
                                                                                                               usize]
                                                                                                =
                                                                                                v707;
                                                                                            {
                                                                                                let v708:
                                                                                                        i32 =
                                                                                                    v702
                                                                                                        +
                                                                                                        1_i32;
                                                                                                v700.l0.set(v708);
                                                                                                ()
                                                                                            }
                                                                                        }
                                                                                (
                                                                                    0_i32,
                                                                                    v699.clone(),
                                                                                )
                                                                            }
                                                                        } else {
                                                                            (
                                                                                v672 - 1_i32,
                                                                                v673.clone(),
                                                                            )
                                                                        }
                                                                    };
                                                                    let v716: i32 = v668 + 1_i32;
                                                                    v666.l0.set(v716);
                                                                    v666.l1.set(
                                                                        patternInput_7.0.clone(),
                                                                    );
                                                                    v666.l2.set(
                                                                        patternInput_7.1.clone(),
                                                                    );
                                                                    ()
                                                                }
                                                                {
                                                                    let matchValue_10: i32 =
                                                                        v666.l1.get().clone();
                                                                    let v718: Array<string> =
                                                                        v666.l2.get().clone();
                                                                    let v719: LrcPtr<
                                                                        dyn IEnumerable_1<string>,
                                                                    > = delay(Func0::new({
                                                                        let v718 = v718.clone();
                                                                        move || {
                                                                            map_1(
                                                                                Func1::new({
                                                                                    let v718 = v718
                                                                                        .clone();
                                                                                    move
                                                                                                                              |i_2:
                                                                                                                                   i32|
                                                                                                                              v718[i_2].clone()
                                                                                }),
                                                                                rangeNumeric(
                                                                                    0_i32,
                                                                                    1_i32,
                                                                                    count(
                                                                                        v718.clone(
                                                                                        ),
                                                                                    ) - 1_i32,
                                                                                ),
                                                                            )
                                                                        }
                                                                    }));
                                                                    let _v720: MutCell<
                                                                        Option<char>,
                                                                    > = MutCell::new(None::<char>);
                                                                    {
                                                                        let x_28:
                                                                                    char =
                                                                                std::path::MAIN_SEPARATOR;
                                                                        _v720.set(Some(x_28))
                                                                    }
                                                                    join(
                                                                        Documents::method31(
                                                                            ofChar(getValue(
                                                                                _v720.get().clone(),
                                                                            )),
                                                                        ),
                                                                        toArray_1(v719),
                                                                    )
                                                                }
                                                            }
                                                        }
                                                    }
                                                }
                                            }
                                        } else {
                                            let v737: Result<std::path::PathBuf, std::io::Error> =
                                                std::fs::canonicalize(&*v543);
                                            let v739: std::path::PathBuf = v737.unwrap();
                                            let v741: std::path::Display = v739.display();
                                            let _v742: MutCell<Option<std::string::String>> =
                                                MutCell::new(None::<std::string::String>);
                                            {
                                                let x_29: std::string::String = format!("{}", v741);
                                                _v742.set(Some(x_29))
                                            }
                                            {
                                                let v753: std::string::String =
                                                    getValue(_v742.get().clone());
                                                fable_library_rust::String_::fromString(v753)
                                            }
                                        };
                                        _v541.set(Some(x_30))
                                    }
                                    {
                                        let v764: string = getValue(_v541.get().clone());
                                        Documents::method3(
                                            Documents::US0::US0_1,
                                            Func0::new(move || Documents::closure12((), ())),
                                            Func0::new({
                                                let v0_1 = v0_1.clone();
                                                let v316 = v316.clone();
                                                let v540 = v540.clone();
                                                let v764 = v764.clone();
                                                move || {
                                                    Documents::closure13(
                                                        v0_1.clone(),
                                                        v316.clone(),
                                                        v540.clone(),
                                                        v764.clone(),
                                                        (),
                                                    )
                                                }
                                            }),
                                        );
                                        Documents::method33(
                                            v0_1.clone(),
                                            v92,
                                            v316.clone(),
                                            v540.clone(),
                                            v764.clone(),
                                        )
                                    }
                                }
                            }
                        }
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
