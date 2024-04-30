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
        use fable_library_rust::String_::trim;
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
            US14_0(Func1<std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>, ()>),
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
            US15_0(std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>),
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
        #[derive(Clone, Debug, PartialEq, PartialOrd, Hash, Eq)]
        pub enum US19 {
            US19_0(Result<string, LrcPtr<(string, string)>>),
            US19_1,
        }
        impl Documents::US19 {
            pub fn get_IsUS19_0(this_: &MutCell<Documents::US19>, unitArg: ()) -> bool {
                if unreachable!() {
                    true
                } else {
                    false
                }
            }
            pub fn get_IsUS19_1(this_: &MutCell<Documents::US19>, unitArg: ()) -> bool {
                if unreachable!() {
                    true
                } else {
                    false
                }
            }
        }
        impl core::fmt::Display for Documents::US19 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug, Default, PartialEq, PartialOrd, Hash, Eq)]
        pub struct Mut6 {
            pub l0: MutCell<i32>,
            pub l1: MutCell<i32>,
        }
        impl core::fmt::Display for Documents::Mut6 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug, Default, PartialEq, PartialOrd, Hash, Eq)]
        pub struct Mut7 {
            pub l0: MutCell<i32>,
            pub l1: MutCell<string>,
            pub l2: MutCell<i32>,
            pub l3: MutCell<i32>,
        }
        impl core::fmt::Display for Documents::Mut7 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug, PartialEq, PartialOrd, Hash, Eq)]
        pub enum US20 {
            US20_0(i32, string),
            US20_1(i32, string),
        }
        impl Documents::US20 {
            pub fn get_IsUS20_0(this_: &MutCell<Documents::US20>, unitArg: ()) -> bool {
                if unreachable!() {
                    true
                } else {
                    false
                }
            }
            pub fn get_IsUS20_1(this_: &MutCell<Documents::US20>, unitArg: ()) -> bool {
                if unreachable!() {
                    true
                } else {
                    false
                }
            }
        }
        impl core::fmt::Display for Documents::US20 {
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
            v4: Option<Func1<std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>, ()>>,
            v5: Option<string>,
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
            v4: Option<Func1<std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>, ()>>,
            v5: Option<string>,
            v6: string,
            v7: Vec<std::string::String>,
            unitVar: (),
        ) -> string {
            sprintf!(
                "execute_with_options / file_name: {} / arguments: {:?} / options: {:?}",
                v6,
                v7,
                (v0_1, v1_1, v2, v3, v4, v5)
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
        pub fn closure41(
            unitVar: (),
            v0_1: Func1<std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>, ()>,
        ) -> Documents::US14 {
            Documents::US14::US14_0(v0_1)
        }
        pub fn method68() -> Func1<
            Func1<std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>, ()>,
            Documents::US14,
        > {
            Func1::new(
                move |v: Func1<std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>, ()>| {
                    Documents::closure41((), v)
                },
            )
        }
        pub fn method69(
            v0_1: std::sync::Mutex<std::process::ChildStdin>,
        ) -> std::sync::Mutex<std::process::ChildStdin> {
            v0_1
        }
        pub fn closure42(
            unitVar: (),
            v0_1: std::process::ChildStdin,
        ) -> std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>> {
            let v3: std::sync::Mutex<std::process::ChildStdin> =
                Documents::method69(std::sync::Mutex::new(v0_1));
            std::sync::Arc::new(v3)
        }
        pub fn closure43(
            unitVar: (),
            v0_1: std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>,
        ) -> Documents::US15 {
            Documents::US15::US15_0(v0_1)
        }
        pub fn method70(
        ) -> Func1<std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>, Documents::US15>
        {
            Func1::new(
                move |v: std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>| {
                    Documents::closure43((), v)
                },
            )
        }
        pub fn method71(
            v0_1: std::sync::MutexGuard<std::process::ChildStdin>,
        ) -> std::sync::MutexGuard<std::process::ChildStdin> {
            v0_1
        }
        pub fn closure44(unitVar: (), v0_1: std::process::Output) -> Documents::US16 {
            Documents::US16::US16_0(v0_1)
        }
        pub fn closure45(unitVar: (), v0_1: std::string::String) -> Documents::US16 {
            Documents::US16::US16_1(v0_1)
        }
        pub fn closure46(v0_1: std::string::String, unitVar: ()) -> string {
            sprintf!("execute_with_options -2 / error: {}", v0_1)
        }
        pub fn closure47(v0_1: i32, v1_1: string, unitVar: ()) -> string {
            sprintf!(
                "execute_with_options / exit_code: {} / std_trace.Length: {}",
                v0_1,
                length(v1_1)
            )
        }
        pub fn method72(v0_: i32, v0__1: string) -> LrcPtr<(i32, string)> {
            LrcPtr::new((v0_, v0__1))
        }
        pub fn method52(
            v0_1: Option<CancellationToken>,
            v1_1: string,
            v2: Array<(string, string)>,
            v3: Option<Func1<(bool, string, i32), Arc<Async<()>>>>,
            v4: Option<Func1<std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>, ()>>,
            v5: Option<string>,
            v6: string,
            v7: Vec<std::string::String>,
        ) -> std::pin::Pin<Box<dyn std::future::Future<Output = LrcPtr<(i32, string)>>>> {
            let __result = Box::pin(async move {
                //;
                {
                    let v10: std::process::Command = std::process::Command::new(&*v6);
                    let v12: bool = true;
                    let mut v10 = v10;
                    let v14: &mut std::process::Command =
                        std::process::Command::args(&mut v10, &*v7);
                    let v16: bool = true;
                    let mut v14 = v14;
                    let v18: &mut std::process::Command =
                        std::process::Command::stdout(&mut v14, std::process::Stdio::piped());
                    let v20: bool = true;
                    let mut v18 = v18;
                    let v22: &mut std::process::Command =
                        std::process::Command::stderr(&mut v18, std::process::Stdio::piped());
                    let v24: bool = true;
                    let mut v22 = v22;
                    let v26: &mut std::process::Command =
                        std::process::Command::stdin(&mut v22, std::process::Stdio::piped());
                    let v29: Documents::US4 =
                        defaultValue(Documents::US4::US4_1, map(Documents::method22(), v5));
                    let v35: &mut std::process::Command = match &v29 {
                        Documents::US4::US4_0(v29_0_0) => {
                            let v31: string = Documents::method53(match &v29 {
                                Documents::US4::US4_0(x) => x.clone(),
                                _ => unreachable!(),
                            });
                            std::process::Command::current_dir(v26, &*v31)
                        }
                        _ => v26,
                    };
                    let v37: bool = true;
                    let mut v35 = v35;
                    let v39: Result<std::process::Child, std::io::Error> =
                        std::process::Command::spawn(&mut v35);
                    let v40 = Documents::method54();
                    let v41: Result<std::process::Child, std::io::Error> = Documents::method56(v39);
                    let v43: Result<
                        std::sync::Arc<std::sync::Mutex<Option<std::process::Child>>>,
                        std::io::Error,
                    > = v41.map(|x| v40(x));
                    let v44 = Documents::method37();
                    let v46: Result<
                        std::sync::Arc<std::sync::Mutex<Option<std::process::Child>>>,
                        std::string::String,
                    > = v43.map_err(|x| v44(x));
                    let v49: Documents::US11 = match &v46 {
                        Err(v46_1_0) => Documents::closure32((), v46_1_0.clone()),
                        Ok(v46_0_0) => Documents::closure31((), v46_0_0.clone()),
                    };
                    let patternInput_1: (i32, Documents::US3, Documents::US12) = match &v49 {
                        Documents::US11::US11_0(v49_0_0) => {
                            let v51: std::sync::Arc<std::sync::Mutex<Option<std::process::Child>>> =
                                Documents::method57(v49_0_0.clone());
                            let v53: std::process::ChildStdout =
                                v51.lock().unwrap().as_mut().unwrap().stdout.take().unwrap();
                            let v55: std::process::ChildStderr =
                                v51.lock().unwrap().as_mut().unwrap().stderr.take().unwrap();
                            let v57: std::process::ChildStdin =
                                v51.lock().unwrap().as_mut().unwrap().stdin.take().unwrap();
                            let v61: std::sync::Mutex<Option<std::process::ChildStdout>> =
                                Documents::method58(std::sync::Mutex::new(Some(v53)));
                            let v63: std::sync::Arc<
                                std::sync::Mutex<Option<std::process::ChildStdout>>,
                            > = std::sync::Arc::new(v61);
                            let v67: std::sync::Mutex<Option<std::process::ChildStderr>> =
                                Documents::method59(std::sync::Mutex::new(Some(v55)));
                            let v69: std::sync::Arc<
                                std::sync::Mutex<Option<std::process::ChildStderr>>,
                            > = std::sync::Arc::new(v67);
                            let v73: std::sync::Mutex<Option<std::process::ChildStdin>> =
                                Documents::method60(std::sync::Mutex::new(Some(v57)));
                            let v75: std::sync::Arc<
                                std::sync::Mutex<Option<std::process::ChildStdin>>,
                            > = std::sync::Arc::new(v73);
                            let patternInput: (
                                std::sync::mpsc::Sender<std::string::String>,
                                std::sync::Arc<std::sync::mpsc::Receiver<std::string::String>>,
                            ) = {
                                let (sender, receiver) = std::sync::mpsc::channel();
                                (sender, std::sync::Arc::new(receiver))
                            };
                            let v79: std::sync::Arc<
                                std::sync::mpsc::Receiver<std::string::String>,
                            > = Documents::method61(patternInput.1.clone());
                            let v81: bool = true;
                            let v79 = v79;
                            let v84: std::sync::Mutex<
                                std::sync::mpsc::Sender<std::string::String>,
                            > = Documents::method62(std::sync::Mutex::new(patternInput.0.clone()));
                            let v86: std::sync::Arc<
                                std::sync::Mutex<std::sync::mpsc::Sender<std::string::String>>,
                            > = std::sync::Arc::new(v84);
                            let v88: std::sync::Arc<
                                std::sync::Mutex<std::sync::mpsc::Sender<std::string::String>>,
                            > = v86.clone();
                            let v90: std::sync::Arc<
                                std::sync::Mutex<std::sync::mpsc::Sender<std::string::String>>,
                            > = v86.clone();
                            let v93: std::sync::Mutex<
                                std::sync::Arc<std::sync::mpsc::Receiver<std::string::String>>,
                            > = Documents::method63(std::sync::Mutex::new(v79));
                            let v95: std::sync::Arc<
                                std::sync::Mutex<
                                    std::sync::Arc<std::sync::mpsc::Receiver<std::string::String>>,
                                >,
                            > = std::sync::Arc::new(v93);
                            let v97: std::thread::JoinHandle<()> = std::thread::spawn(move || {
                                //;
                                let v99: std::io::Lines<
                                    std::io::BufReader<std::process::ChildStdout>,
                                > = std::io::BufRead::lines(std::io::BufReader::new(
                                    v63.lock().unwrap().take().unwrap(),
                                ));
                                let v102: std::sync::Mutex<
                                    std::io::Lines<std::io::BufReader<std::process::ChildStdout>>,
                                > = Documents::method64(std::sync::Mutex::new(v99));
                                let v104: std::sync::Arc<
                                    std::sync::Mutex<
                                        std::io::Lines<
                                            std::io::BufReader<std::process::ChildStdout>,
                                        >,
                                    >,
                                > = std::sync::Arc::new(v102);
                                let v105 = Documents::method65(v88);
                                let v107: bool = true;
                                for line in v104.lock().unwrap().by_ref() {
                                    v105(line)
                                }
                                let v109: bool = true;
                            });
                            let v111: std::thread::JoinHandle<()> = std::thread::spawn(move || {
                                //;
                                let v113: std::io::Lines<
                                    std::io::BufReader<std::process::ChildStderr>,
                                > = std::io::BufRead::lines(std::io::BufReader::new(
                                    v69.lock().unwrap().take().unwrap(),
                                ));
                                let v116: std::sync::Mutex<
                                    std::io::Lines<std::io::BufReader<std::process::ChildStderr>>,
                                > = Documents::method66(std::sync::Mutex::new(v113));
                                let v118: std::sync::Arc<
                                    std::sync::Mutex<
                                        std::io::Lines<
                                            std::io::BufReader<std::process::ChildStderr>,
                                        >,
                                    >,
                                > = std::sync::Arc::new(v116);
                                let v119 = Documents::method67(v86);
                                let v121: bool = true;
                                for line in v118.lock().unwrap().by_ref() {
                                    v119(line)
                                }
                                let v123: bool = true;
                            });
                            let v126: Documents::US14 = defaultValue(
                                Documents::US14::US14_1,
                                map(Documents::method68(), v4),
                            );
                            match &v126 {
                                Documents::US14::US14_0(v126_0_0) => {
                                    let v129: Option<std::process::ChildStdin> =
                                        v75.lock().unwrap().take();
                                    let v132: Option<
                                        std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>,
                                    > = v129.map(|x| {
                                        Func1::new(move |v_2: std::process::ChildStdin| {
                                            Documents::closure42((), v_2)
                                        })(x)
                                    });
                                    let v135: Documents::US15 = defaultValue(
                                        Documents::US15::US15_1,
                                        map(Documents::method70(), v132),
                                    );
                                    match &v135 {
                                        Documents::US15::US15_0(v135_0_0) => {
                                            let v136: std::sync::Arc<
                                                std::sync::Mutex<std::process::ChildStdin>,
                                            > = match &v135 {
                                                Documents::US15::US15_0(x) => x.clone(),
                                                _ => unreachable!(),
                                            };
                                            (match &v126 {
                                                Documents::US14::US14_0(x) => x.clone(),
                                                _ => unreachable!(),
                                            })(
                                                v136.clone()
                                            );
                                            {
                                                let v138: Result<
                                                    std::sync::MutexGuard<std::process::ChildStdin>,
                                                    std::sync::PoisonError<
                                                        std::sync::MutexGuard<
                                                            std::process::ChildStdin,
                                                        >,
                                                    >,
                                                > = v136.lock();
                                                let v141: std::sync::MutexGuard<
                                                    std::process::ChildStdin,
                                                > = Documents::method71(v138.unwrap());
                                                let v143: bool = true;
                                                let mut v141 = v141;
                                                let v145: bool = true;
                                                std::io::Write::flush(&mut *v141).unwrap();
                                                ()
                                            }
                                        }
                                        _ => (),
                                    }
                                }
                                _ => (),
                            }
                            {
                                let v147: Result<std::process::Output, std::io::Error> =
                                    v51.lock().unwrap().take().unwrap().wait_with_output();
                                let v148 = Documents::method37();
                                let v150: Result<std::process::Output, std::string::String> =
                                    v147.map_err(|x| v148(x));
                                let v152: bool = true;
                                v97.join().unwrap();
                                let v154: bool = true;
                                v111.join().unwrap();
                                let v157: Documents::US16 = match &v150 {
                                    Err(v150_1_0) => Documents::closure45((), v150_1_0.clone()),
                                    Ok(v150_0_0) => Documents::closure44((), v150_0_0.clone()),
                                };
                                match &v157 {
                                    Documents::US16::US16_0(v157_0_0) => (
                                        v157_0_0.clone().status.code().unwrap(),
                                        Documents::US3::US3_1,
                                        Documents::US12::US12_0(v95),
                                    ),
                                    Documents::US16::US16_1(v157_1_0) => {
                                        let v163: std::string::String = v157_1_0.clone();
                                        Documents::method3(
                                            Documents::US0::US0_4,
                                            Func0::new({
                                                let v163 = v163.clone();
                                                move || Documents::closure46(v163.clone(), ())
                                            }),
                                            Func0::new(move || Documents::closure6((), ())),
                                        );
                                        (
                                            -2_i32,
                                            Documents::US3::US3_0(v163.clone()),
                                            Documents::US12::US12_1,
                                        )
                                    }
                                }
                            }
                        }
                        Documents::US11::US11_1(v49_1_0) => {
                            let v175: std::string::String = v49_1_0.clone();
                            Documents::method3(
                                Documents::US0::US0_4,
                                Func0::new({
                                    let v175 = v175.clone();
                                    move || Documents::closure33(v175.clone(), ())
                                }),
                                Func0::new(move || Documents::closure6((), ())),
                            );
                            (
                                -1_i32,
                                Documents::US3::US3_0(v175.clone()),
                                Documents::US12::US12_1,
                            )
                        }
                    };
                    let v186: Documents::US12 = patternInput_1.2.clone();
                    let v185: Documents::US3 = patternInput_1.1.clone();
                    let v184: i32 = patternInput_1.0.clone();
                    let v193: Documents::US3 = match &v186 {
                        Documents::US12::US12_0(v186_0_0) => Documents::US3::US3_0(
                            match &v186 {
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
                    let v200: Documents::US4 = match &v193 {
                        Documents::US3::US3_0(v193_0_0) => Documents::US4::US4_0(
                            fable_library_rust::String_::fromString(match &v193 {
                                Documents::US3::US3_0(x) => x.clone(),
                                _ => unreachable!(),
                            }),
                        ),
                        _ => Documents::US4::US4_1,
                    };
                    let v207: Documents::US4 = match &v185 {
                        Documents::US3::US3_0(v185_0_0) => Documents::US4::US4_0(
                            fable_library_rust::String_::fromString(match &v185 {
                                Documents::US3::US3_0(x) => x.clone(),
                                _ => unreachable!(),
                            }),
                        ),
                        _ => Documents::US4::US4_1,
                    };
                    let v211: string = match &v207 {
                        Documents::US4::US4_0(v207_0_0) => match &v207 {
                            Documents::US4::US4_0(x) => x.clone(),
                            _ => unreachable!(),
                        },
                        _ => string(""),
                    };
                    let v214: string = match &v200 {
                        Documents::US4::US4_0(v200_0_0) => match &v200 {
                            Documents::US4::US4_0(x) => x.clone(),
                            _ => unreachable!(),
                        },
                        _ => v211,
                    };
                    Documents::method3(
                        Documents::US0::US0_0,
                        Func0::new({
                            let v184 = v184.clone();
                            let v214 = v214.clone();
                            move || Documents::closure47(v184, v214.clone(), ())
                        }),
                        Func0::new(move || Documents::closure6((), ())),
                    );
                    {
                        let v218: LrcPtr<(i32, string)> = LrcPtr::new((v184, v214.clone()));
                        let v219: LrcPtr<(i32, string)> =
                            Documents::method72(v218.0.clone(), v218.1.clone());
                        v219
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
        pub fn closure48(
            v0_1: Option<CancellationToken>,
            v1_1: string,
            v2: Array<(string, string)>,
            v3: Option<Func1<(bool, string, i32), Arc<Async<()>>>>,
            v4: Option<Func1<std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>, ()>>,
            v5: Option<string>,
            unitVar: (),
        ) -> string {
            sprintf!(
                "execute_with_options_async / options: {:?}",
                (v0_1, v1_1, v2, v3, v4, v5)
            )
        }
        pub fn closure50(
            unitVar: (),
            v0_1: Func1<(bool, string, i32), Arc<Async<()>>>,
        ) -> Documents::US17 {
            Documents::US17::US17_0(v0_1)
        }
        pub fn method73() -> Func1<Func1<(bool, string, i32), Arc<Async<()>>>, Documents::US17> {
            Func1::new(move |v: Func1<(bool, string, i32), Arc<Async<()>>>| {
                Documents::closure50((), v)
            })
        }
        pub fn closure51(v0_1: string, unitVar: ()) -> string {
            sprintf!("> {}", v0_1)
        }
        pub fn closure49(
            v0_1: Option<CancellationToken>,
            v1_1: string,
            v2: Array<(string, string)>,
            v3: Option<Func1<(bool, string, i32), Arc<Async<()>>>>,
            v4: Option<Func1<std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>, ()>>,
            v5: Option<string>,
            v6: (),
            v7: LrcPtr<ConcurrentStack_1<string>>,
            v8: (),
        ) {
            let _v9: MutCell<Option<Arc<Async<()>>>> = MutCell::new(None::<Arc<Async<()>>>);
            {
                let x: Arc<Async<()>> = defaultOf();
                _v9.set(Some(x))
            }
            {
                let v34: Arc<Async<()>> = getValue(_v9.get().clone());
                let _v35: MutCell<Option<()>> = MutCell::new(None::<()>);
                defaultOf::<()>();
                _v35.set(Some(()));
                getValue(_v35.get().clone());
                ()
            }
        }
        pub fn closure52(
            v0_1: Option<CancellationToken>,
            v1_1: string,
            v2: Array<(string, string)>,
            v3: Option<Func1<(bool, string, i32), Arc<Async<()>>>>,
            v4: Option<Func1<std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>, ()>>,
            v5: Option<string>,
            v6: (),
            v7: LrcPtr<ConcurrentStack_1<string>>,
            v8: (),
        ) {
            let _v9: MutCell<Option<Arc<Async<()>>>> = MutCell::new(None::<Arc<Async<()>>>);
            {
                let x: Arc<Async<()>> = defaultOf();
                _v9.set(Some(x))
            }
            {
                let v35: Arc<Async<()>> = getValue(_v9.get().clone());
                let _v36: MutCell<Option<()>> = MutCell::new(None::<()>);
                defaultOf::<()>();
                _v36.set(Some(()));
                getValue(_v36.get().clone());
                ()
            }
        }
        pub fn closure53(unitVar: (), v0_1: CancellationToken) -> Documents::US18 {
            Documents::US18::US18_0(v0_1)
        }
        pub fn method74() -> Func1<CancellationToken, Documents::US18> {
            Func1::new(move |v: CancellationToken| Documents::closure53((), v))
        }
        pub fn closure54(v0_1: (), unitVar: ()) {
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
        pub fn closure55(v0_1: LrcPtr<TaskCanceledException>, unitVar: ()) -> string {
            sprintf!(
                "execute_with_options_async / WaitForExitAsync / ex: {:?}",
                v0_1
            )
        }
        pub fn method75() -> string {
            string("\n")
        }
        pub fn closure56(v0_1: i32, v1_1: string, unitVar: ()) -> string {
            sprintf!(
                "execute_with_options_async / exit_code: {} / output.Length: {}",
                v0_1,
                length(v1_1)
            )
        }
        pub fn method76(v0_1: i32, v1_1: LrcPtr<Documents::Mut6>) -> bool {
            v1_1.l0.get().clone() < v0_1
        }
        pub fn method77(v0_1: string) -> string {
            v0_1
        }
        pub fn method78(
            v0_1: std::sync::MutexGuard<std::process::ChildStdin>,
        ) -> std::sync::MutexGuard<std::process::ChildStdin> {
            v0_1
        }
        pub fn closure58(
            v0_1: string,
            v1_1: std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>,
        ) {
            let v3: Result<
                std::sync::MutexGuard<std::process::ChildStdin>,
                std::sync::PoisonError<std::sync::MutexGuard<std::process::ChildStdin>>,
            > = v1_1.lock();
            let v5: std::sync::MutexGuard<std::process::ChildStdin> = v3.unwrap();
            let v6: string = Documents::method77(v0_1);
            let v8: &[u8] = v6.as_bytes();
            let v9: std::sync::MutexGuard<std::process::ChildStdin> = Documents::method78(v5);
            let v11: bool = true;
            let mut v9 = v9;
            let v13: bool = true;
            std::io::Write::write_all(&mut *v9, v8).unwrap();
            ()
        }
        pub fn method79(v0_1: i32, v1_1: LrcPtr<Documents::Mut7>) -> bool {
            v1_1.l0.get().clone() < v0_1
        }
        pub fn method80(v0_1: string) -> string {
            v0_1
        }
        pub fn closure59(unitVar: (), unitVar_1: ()) -> string {
            string("documents.run / par_map / files_fn")
        }
        pub fn closure60(v0_1: string, v1_1: i32, unitVar: ()) -> string {
            sprintf!(
                "exit_code: {:?} / result: {} / {}",
                v1_1,
                v0_1,
                Documents::closure6((), ())
            )
        }
        pub fn method81(v0_1: string) -> string {
            v0_1
        }
        pub fn closure57(
            v0_1: string,
            v1_1: string,
            v2: string,
            v3: string,
            v4: string,
        ) -> Documents::US19 {
            let v14: string = if endsWith(v4.clone(), string(".md"), false) == false {
                sprintf!("{}.{}", v0_1.clone(), v4.clone())
            } else {
                sprintf!(
                    "{}.{}",
                    getSlice(
                        v0_1.clone(),
                        Some(0_i32),
                        Some(lastIndexOf(v0_1.clone(), string(".")) - 1_i32)
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
                    let v113 = None::<
                        Func1<std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>, ()>,
                    >;
                    let v114: string = sprintf!(
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
                    let _v115: MutCell<Option<(i32, string)>> = MutCell::new(None::<(i32, string)>);
                    let v117: string = Documents::method42(
                        v110.clone(),
                        v114.clone(),
                        v111.clone(),
                        v112.clone(),
                        v113.clone(),
                        v109.clone(),
                    );
                    let patternInput: (string, string) = Documents::method43();
                    let v120: i32 = length(v117.clone());
                    let v121: Array<char> = new_init(&'\u{0000}', v120);
                    let v122: LrcPtr<Documents::Mut5> = LrcPtr::new(Documents::Mut5 {
                        l0: MutCell::new(0_i32),
                    });
                    while Documents::method30(v120, v122.clone()) {
                        let v124: i32 = v122.l0.get().clone();
                        let v125: char = getCharAt(v117.clone(), v124);
                        v121.get_mut()[v124 as usize] = v125;
                        {
                            let v126: i32 = v124 + 1_i32;
                            v122.l0.set(v126);
                            ()
                        }
                    }
                    {
                        let v128: List<char> = ofArray(v121.clone());
                        let patternInput_1: (string, string) = Documents::method45(
                            patternInput.1.clone(),
                            patternInput.0.clone(),
                            foldBack(
                                Func2::new(move |b0: char, b1: LrcPtr<Documents::UH0>| {
                                    (Documents::method44())(b0)(b1)
                                }),
                                v128,
                                LrcPtr::new(Documents::UH0::UH0_0),
                            ),
                            Documents::US8::US8_0,
                        );
                        let v136: string = patternInput_1.0.clone();
                        let v138: Array<string> = Documents::method46(patternInput_1.1.clone());
                        let v140: Vec<string> = v138.to_vec();
                        fn v142(v: string) -> std::string::String {
                            Documents::closure28((), v)
                        }
                        let v143: Vec<std::string::String> =
                            v140.iter().map(|x| Func1::from(v142)(x.clone())).collect();
                        Documents::method3(
                            Documents::US0::US0_1,
                            Func0::new({
                                let v109 = v109.clone();
                                let v110 = v110.clone();
                                let v111 = v111.clone();
                                let v112 = v112.clone();
                                let v113 = v113.clone();
                                let v114 = v114.clone();
                                let v136 = v136.clone();
                                let v143 = v143.clone();
                                move || {
                                    Documents::closure29(
                                        v110.clone(),
                                        v114.clone(),
                                        v111.clone(),
                                        v112.clone(),
                                        v113.clone(),
                                        v109.clone(),
                                        v136.clone(),
                                        v143.clone(),
                                        (),
                                    )
                                }
                            }),
                            Documents::method51(),
                        );
                        {
                            let v147: std::pin::Pin<
                                Box<dyn std::future::Future<Output = LrcPtr<(i32, string)>>>,
                            > = Documents::method52(
                                v110.clone(),
                                v114.clone(),
                                v111.clone(),
                                v112.clone(),
                                v113.clone(),
                                v109.clone(),
                                v136.clone(),
                                v143.clone(),
                            );
                            let v149: LrcPtr<(i32, string)> = futures_lite::future::block_on(v147);
                            _v115.set(Some((v149.0.clone(), v149.1.clone())));
                            {
                                let patternInput_2: (i32, string) = getValue(_v115.get().clone());
                                let _v332: MutCell<Option<bool>> = MutCell::new(None::<bool>);
                                {
                                    let x_5: bool = cfg!(windows);
                                    _v332.set(Some(x_5))
                                }
                                {
                                    let v369: Option<string> = None::<string>;
                                    let v370: Option<CancellationToken> = None::<CancellationToken>;
                                    let v371: Array<(string, string)> =
                                        new_empty::<(string, string)>();
                                    let v372 = None::<Func1<(bool, string, i32), Arc<Async<()>>>>;
                                    let v373 = None::<
                                        Func1<
                                            std::sync::Arc<
                                                std::sync::Mutex<std::process::ChildStdin>,
                                            >,
                                            (),
                                        >,
                                    >;
                                    let v374: string =
                                            sprintf!("pwsh -c \"(Get-FileHash \\\"{}\\\" -Algorithm SHA256).Hash\"",
                                                     if getValue(_v332.get().clone())
                                                            == false {
                                                         v23.clone()
                                                     } else {
                                                         let _v345:
                                                                 MutCell<Option<string>> =
                                                             MutCell::new(None::<string>);
                                                         let v347: string =
                                                             Documents::method26();
                                                         let v348: string =
                                                             Documents::method27(v23.clone());
                                                         let v349: string =
                                                             Documents::method28();
                                                         let v351: &str =
                                                             &regex::Regex::new(&v347).unwrap().replace_all(&v348, &*v349);
                                                         let v353:
                                                                 std::string::String =
                                                             String::from(v351);
                                                         {
                                                             let x_6: string =
                                                                 fable_library_rust::String_::fromString(v353);
                                                             _v345.set(Some(x_6))
                                                         }
                                                         {
                                                             let v363:
                                                                     string =
                                                                 getValue(_v345.get().clone());
                                                             replace(sprintf!("{}{}",
                                                                              toLower(ofChar(getCharAt(v363.clone(),
                                                                                                       0_i32))),
                                                                              getSlice(v363,
                                                                                       Some(1_i32),
                                                                                       None::<i32>)),
                                                                     string("\\"),
                                                                     string("/"))
                                                         }
                                                     });
                                    let _v375: MutCell<Option<(i32, string)>> =
                                        MutCell::new(None::<(i32, string)>);
                                    let v377: string = Documents::method42(
                                        v370.clone(),
                                        v374.clone(),
                                        v371.clone(),
                                        v372.clone(),
                                        v373.clone(),
                                        v369.clone(),
                                    );
                                    let patternInput_3: (string, string) = Documents::method43();
                                    let v380: i32 = length(v377.clone());
                                    let v381: Array<char> = new_init(&'\u{0000}', v380);
                                    let v382: LrcPtr<Documents::Mut5> =
                                        LrcPtr::new(Documents::Mut5 {
                                            l0: MutCell::new(0_i32),
                                        });
                                    while Documents::method30(v380, v382.clone()) {
                                        let v384: i32 = v382.l0.get().clone();
                                        let v385: char = getCharAt(v377.clone(), v384);
                                        v381.get_mut()[v384 as usize] = v385;
                                        {
                                            let v386: i32 = v384 + 1_i32;
                                            v382.l0.set(v386);
                                            ()
                                        }
                                    }
                                    {
                                        let v388: List<char> = ofArray(v381.clone());
                                        let patternInput_4: (string, string) = Documents::method45(
                                            patternInput_3.1.clone(),
                                            patternInput_3.0.clone(),
                                            foldBack(
                                                Func2::new(
                                                    move |b0: char, b1: LrcPtr<Documents::UH0>| {
                                                        (Documents::method44())(b0)(b1)
                                                    },
                                                ),
                                                v388,
                                                LrcPtr::new(Documents::UH0::UH0_0),
                                            ),
                                            Documents::US8::US8_0,
                                        );
                                        let v396: string = patternInput_4.0.clone();
                                        let v398: Array<string> =
                                            Documents::method46(patternInput_4.1.clone());
                                        let v400: Vec<string> = v398.to_vec();
                                        let v402: Vec<std::string::String> = v400
                                            .iter()
                                            .map(|x| Func1::from(v142)(x.clone()))
                                            .collect();
                                        Documents::method3(
                                            Documents::US0::US0_1,
                                            Func0::new({
                                                let v369 = v369.clone();
                                                let v370 = v370.clone();
                                                let v371 = v371.clone();
                                                let v372 = v372.clone();
                                                let v373 = v373.clone();
                                                let v374 = v374.clone();
                                                let v396 = v396.clone();
                                                let v402 = v402.clone();
                                                move || {
                                                    Documents::closure29(
                                                        v370.clone(),
                                                        v374.clone(),
                                                        v371.clone(),
                                                        v372.clone(),
                                                        v373.clone(),
                                                        v369.clone(),
                                                        v396.clone(),
                                                        v402.clone(),
                                                        (),
                                                    )
                                                }
                                            }),
                                            Documents::method51(),
                                        );
                                        {
                                            let v406: std::pin::Pin<
                                                Box<
                                                    dyn std::future::Future<
                                                        Output = LrcPtr<(i32, string)>,
                                                    >,
                                                >,
                                            > = Documents::method52(
                                                v370.clone(),
                                                v374.clone(),
                                                v371.clone(),
                                                v372.clone(),
                                                v373.clone(),
                                                v369.clone(),
                                                v396.clone(),
                                                v402.clone(),
                                            );
                                            let v408: LrcPtr<(i32, string)> =
                                                futures_lite::future::block_on(v406);
                                            _v375.set(Some((v408.0.clone(), v408.1.clone())));
                                            patternInput_2.1.clone()
                                                == (getValue(_v375.get().clone())).1.clone()
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
                let _v594: MutCell<Option<string>> = MutCell::new(None::<string>);
                let _v596: MutCell<Option<Vec<u8>>> = MutCell::new(None::<Vec<u8>>);
                {
                    let x_8: Vec<u8> = std::fs::read(&*v0_1).unwrap();
                    _v596.set(Some(x_8))
                }
                {
                    let v607: Vec<u8> = getValue(_v596.get().clone());
                    let v609: Result<std::string::String, std::string::FromUtf8Error> =
                        std::string::String::from_utf8(v607);
                    let v611: std::string::String = v609.unwrap();
                    {
                        let x_9: string = fable_library_rust::String_::fromString(v611);
                        _v594.set(Some(x_9))
                    }
                    {
                        let v621: Array<string> =
                            split(getValue(_v594.get().clone()), string("\n"), -1_i32, 0_i32);
                        let v622: i32 = count(v621.clone());
                        let v623: Array<string> = new_init(&string(""), v622);
                        let v624: LrcPtr<Documents::Mut5> = LrcPtr::new(Documents::Mut5 {
                            l0: MutCell::new(0_i32),
                        });
                        while Documents::method30(v622, v624.clone()) {
                            let v626: i32 = v624.l0.get().clone();
                            let v628: string = trim(v621[v626].clone());
                            v623.get_mut()[v626 as usize] = v628;
                            {
                                let v629: i32 = v626 + 1_i32;
                                v624.l0.set(v629);
                                ()
                            }
                        }
                        {
                            let v630: i32 = count(v623.clone());
                            let v631: Array<string> = new_init(&string(""), v630);
                            let v632: LrcPtr<Documents::Mut6> = LrcPtr::new(Documents::Mut6 {
                                l0: MutCell::new(0_i32),
                                l1: MutCell::new(0_i32),
                            });
                            while Documents::method76(v630, v632.clone()) {
                                let v634: i32 = v632.l0.get().clone();
                                let v635: i32 = v632.l1.get().clone();
                                let v636: string = v623[v634].clone();
                                let v640: i32 = if string("") != v636.clone() {
                                    v631.get_mut()[v635 as usize] = v636;
                                    v635 + 1_i32
                                } else {
                                    v635
                                };
                                let v641: i32 = v634 + 1_i32;
                                v632.l0.set(v641);
                                v632.l1.set(v640);
                                ()
                            }
                            {
                                let v642: i32 = v632.l1.get().clone();
                                let v643: Array<string> = new_init(&string(""), v642);
                                let v644: LrcPtr<Documents::Mut5> = LrcPtr::new(Documents::Mut5 {
                                    l0: MutCell::new(0_i32),
                                });
                                while Documents::method30(v642, v644.clone()) {
                                    let v646: i32 = v644.l0.get().clone();
                                    let v647: string = v631[v646].clone();
                                    v643.get_mut()[v646 as usize] = v647;
                                    {
                                        let v648: i32 = v646 + 1_i32;
                                        v644.l0.set(v648);
                                        ()
                                    }
                                }
                                {
                                    let v649: LrcPtr<dyn IEnumerable_1<string>> =
                                        delay(Func0::new({
                                            let v643 = v643.clone();
                                            move || {
                                                map_1(
                                                    Func1::new({
                                                        let v643 = v643.clone();
                                                        move |i: i32| v643[i].clone()
                                                    }),
                                                    rangeNumeric(
                                                        0_i32,
                                                        1_i32,
                                                        count(v643.clone()) - 1_i32,
                                                    ),
                                                )
                                            }
                                        }));
                                    let v654: string = sprintf!(
                                        "{}\n\n",
                                        join(Documents::method75(), toArray_1(v649))
                                    );
                                    let v655: Option<string> = None::<string>;
                                    let v656: Option<CancellationToken> = None::<CancellationToken>;
                                    let v657: Array<(string, string)> =
                                        new_empty::<(string, string)>();
                                    let v658 = None::<Func1<(bool, string, i32), Arc<Async<()>>>>;
                                    let _v660: MutCell<Option<bool>> = MutCell::new(None::<bool>);
                                    {
                                        let x_10: bool = cfg!(windows);
                                        _v660.set(Some(x_10))
                                    }
                                    {
                                        let v675: string = sprintf!(
                                            "../vault/deps/hangulize/cmd/hangulize/hangulize{}",
                                            if getValue(_v660.get().clone()) {
                                                string(".exe")
                                            } else {
                                                string("")
                                            }
                                        );
                                        let _v676: MutCell<Option<string>> =
                                            MutCell::new(None::<string>);
                                        let v678: string = Documents::method18(v3);
                                        let v680: &str =
                                            fable_library_rust::String_::LrcStr::as_str(&v678);
                                        let v682: std::string::String = String::from(v680);
                                        let v684: std::path::PathBuf =
                                            std::path::PathBuf::from(v682);
                                        let v685: string = Documents::method18(v675);
                                        let v687: &str =
                                            fable_library_rust::String_::LrcStr::as_str(&v685);
                                        let v689: std::string::String = String::from(v687);
                                        let v691: std::path::PathBuf = v684.join(v689);
                                        let v693: std::path::Display = v691.display();
                                        let _v694: MutCell<Option<std::string::String>> =
                                            MutCell::new(None::<std::string::String>);
                                        {
                                            let x_11: std::string::String = format!("{}", v693);
                                            _v694.set(Some(x_11))
                                        }
                                        {
                                            let v705: std::string::String =
                                                getValue(_v694.get().clone());
                                            {
                                                let x_12: string =
                                                    fable_library_rust::String_::fromString(v705);
                                                _v676.set(Some(x_12))
                                            }
                                            {
                                                let v719: string = sprintf!(
                                                    "{} {}",
                                                    getValue(_v676.get().clone()),
                                                    v2
                                                );
                                                let v721 = Some(Func1::new({
                                                    let v654 = v654.clone();
                                                    move
                                                                            |v_1:
                                                                                 std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>|
                                                                            Documents::closure58(v654.clone(),
                                                                                                 v_1)
                                                }));
                                                let _v722: MutCell<Option<(i32, string)>> =
                                                    MutCell::new(None::<(i32, string)>);
                                                let v724: string = Documents::method42(
                                                    v656.clone(),
                                                    v719.clone(),
                                                    v657.clone(),
                                                    v658.clone(),
                                                    v721.clone(),
                                                    v655.clone(),
                                                );
                                                let patternInput_6: (string, string) =
                                                    Documents::method43();
                                                let v727: i32 = length(v724.clone());
                                                let v728: Array<char> = new_init(&'\u{0000}', v727);
                                                let v729: LrcPtr<Documents::Mut5> =
                                                    LrcPtr::new(Documents::Mut5 {
                                                        l0: MutCell::new(0_i32),
                                                    });
                                                while Documents::method30(v727, v729.clone()) {
                                                    let v731: i32 = v729.l0.get().clone();
                                                    let v732: char = getCharAt(v724.clone(), v731);
                                                    v728.get_mut()[v731 as usize] = v732;
                                                    {
                                                        let v733: i32 = v731 + 1_i32;
                                                        v729.l0.set(v733);
                                                        ()
                                                    }
                                                }
                                                {
                                                    let v735: List<char> = ofArray(v728.clone());
                                                    let patternInput_7:
                                                            (string, string) =
                                                        Documents::method45(patternInput_6.1.clone(),
                                                                            patternInput_6.0.clone(),
                                                                            foldBack(Func2::new(move
                                                                                                    |b0:
                                                                                                         char,
                                                                                                     b1:
                                                                                                         LrcPtr<Documents::UH0>|
                                                                                                    (Documents::method44())(b0)(b1)),
                                                                                     v735,
                                                                                     LrcPtr::new(Documents::UH0::UH0_0)),
                                                                            Documents::US8::US8_0);
                                                    let v743: string = patternInput_7.0.clone();
                                                    let v745: Array<string> = Documents::method46(
                                                        patternInput_7.1.clone(),
                                                    );
                                                    let v747: Vec<string> = v745.to_vec();
                                                    let v750: Vec<std::string::String> = v747
                                                        .iter()
                                                        .map(|x| {
                                                            Func1::new(move |v_2: string| {
                                                                Documents::closure28((), v_2)
                                                            })(
                                                                x.clone()
                                                            )
                                                        })
                                                        .collect();
                                                    Documents::method3(
                                                        Documents::US0::US0_1,
                                                        Func0::new({
                                                            let v655 = v655.clone();
                                                            let v656 = v656.clone();
                                                            let v657 = v657.clone();
                                                            let v658 = v658.clone();
                                                            let v719 = v719.clone();
                                                            let v721 = v721.clone();
                                                            let v743 = v743.clone();
                                                            let v750 = v750.clone();
                                                            move || {
                                                                Documents::closure29(
                                                                    v656.clone(),
                                                                    v719.clone(),
                                                                    v657.clone(),
                                                                    v658.clone(),
                                                                    v721.clone(),
                                                                    v655.clone(),
                                                                    v743.clone(),
                                                                    v750.clone(),
                                                                    (),
                                                                )
                                                            }
                                                        }),
                                                        Documents::method51(),
                                                    );
                                                    {
                                                        let v754: std::pin::Pin<
                                                            Box<
                                                                dyn std::future::Future<
                                                                    Output = LrcPtr<(i32, string)>,
                                                                >,
                                                            >,
                                                        > = Documents::method52(
                                                            v656.clone(),
                                                            v719.clone(),
                                                            v657.clone(),
                                                            v658.clone(),
                                                            v721.clone(),
                                                            v655.clone(),
                                                            v743.clone(),
                                                            v750.clone(),
                                                        );
                                                        let v756: LrcPtr<(i32, string)> =
                                                            futures_lite::future::block_on(v754);
                                                        _v722.set(Some((
                                                            v756.0.clone(),
                                                            v756.1.clone(),
                                                        )));
                                                        {
                                                            let patternInput_8: (i32, string) =
                                                                getValue(_v722.get().clone());
                                                            let v937: i32 =
                                                                patternInput_8.0.clone();
                                                            let v939: Array<string> = split(
                                                                patternInput_8.1.clone(),
                                                                string("\n"),
                                                                -1_i32,
                                                                0_i32,
                                                            );
                                                            let v940: i32 = count(v939.clone());
                                                            let v942: LrcPtr<Documents::Mut7> =
                                                                LrcPtr::new(Documents::Mut7 {
                                                                    l0: MutCell::new(0_i32),
                                                                    l1: MutCell::new(string("")),
                                                                    l2: MutCell::new(0_i32),
                                                                    l3: MutCell::new(0_i32),
                                                                });
                                                            while Documents::method79(
                                                                v630,
                                                                v942.clone(),
                                                            ) {
                                                                let v944: i32 =
                                                                    v942.l0.get().clone();
                                                                let matchValue: string =
                                                                    v942.l1.get().clone();
                                                                let matchValue_1: i32 =
                                                                    v942.l2.get().clone();
                                                                let v947: i32 =
                                                                    v942.l3.get().clone();
                                                                let v946: i32 = matchValue_1;
                                                                let v945: string = matchValue;
                                                                let patternInput_10: (
                                                                    string,
                                                                    i32,
                                                                    i32,
                                                                ) = if v623[v944].clone()
                                                                    == string("")
                                                                {
                                                                    (
                                                                        sprintf!(
                                                                            "{}\n",
                                                                            v945.clone()
                                                                        ),
                                                                        v946 + 1_i32,
                                                                        v947 + 1_i32,
                                                                    )
                                                                } else {
                                                                    let v953: i32 = v946 - v947;
                                                                    (
                                                                        if v953 >= v940 {
                                                                            v945.clone()
                                                                        } else {
                                                                            let v955: string =
                                                                                v939[v953].clone();
                                                                            if v953 == v940 - 1_i32
                                                                            {
                                                                                sprintf!(
                                                                                    "{}{}",
                                                                                    v945.clone(),
                                                                                    v955.clone()
                                                                                )
                                                                            } else {
                                                                                sprintf!(
                                                                                    "{}{}\n", v945,
                                                                                    v955
                                                                                )
                                                                            }
                                                                        },
                                                                        v946 + 1_i32,
                                                                        v947,
                                                                    )
                                                                };
                                                                let v966: i32 = v944 + 1_i32;
                                                                v942.l0.set(v966);
                                                                v942.l1
                                                                    .set(patternInput_10.0.clone());
                                                                v942.l2
                                                                    .set(patternInput_10.1.clone());
                                                                v942.l3
                                                                    .set(patternInput_10.2.clone());
                                                                ()
                                                            }
                                                            {
                                                                let matchValue_3: string =
                                                                    v942.l1.get().clone();
                                                                let matchValue_4: i32 =
                                                                    v942.l2.get().clone();
                                                                let matchValue_5: i32 =
                                                                    v942.l3.get().clone();
                                                                let v967: string = matchValue_3;
                                                                let _v970: MutCell<Option<()>> =
                                                                    MutCell::new(None::<()>);
                                                                std::fs::write(
                                                                    &*v14.clone(),
                                                                    &*v967.clone(),
                                                                )
                                                                .unwrap();
                                                                _v970.set(Some(()));
                                                                getValue(_v970.get().clone());
                                                                if v937 != 0_i32 {
                                                                    Documents::method3(
                                                                        Documents::US0::US0_2,
                                                                        Func0::new(move || {
                                                                            Documents::closure59(
                                                                                (),
                                                                                (),
                                                                            )
                                                                        }),
                                                                        Func0::new({
                                                                            let v937 = v937.clone();
                                                                            let v967 = v967.clone();
                                                                            move || {
                                                                                Documents::closure60(
                                                                                    v967.clone(),
                                                                                    v937,
                                                                                    (),
                                                                                )
                                                                            }
                                                                        }),
                                                                    );
                                                                    Documents::US19::US19_0(Err::<
                                                                        string,
                                                                        LrcPtr<(string, string)>,
                                                                    >(
                                                                        LrcPtr::new((
                                                                            v14.clone(),
                                                                            v967.clone(),
                                                                        )),
                                                                    ))
                                                                } else {
                                                                    let _v981: MutCell<
                                                                        Option<bool>,
                                                                    > = MutCell::new(None::<bool>);
                                                                    let v983: string =
                                                                        Documents::method18(
                                                                            v14.clone(),
                                                                        );
                                                                    let v985:
                                                                            &str =
                                                                        fable_library_rust::String_::LrcStr::as_str(&v983);
                                                                    let v987: std::string::String =
                                                                        String::from(v985);
                                                                    let v989: std::path::PathBuf =
                                                                        std::path::PathBuf::from(
                                                                            v987,
                                                                        );
                                                                    {
                                                                        let x_15: bool = if v989
                                                                            .clone()
                                                                            .exists()
                                                                        {
                                                                            v989.is_file()
                                                                        } else {
                                                                            false
                                                                        };
                                                                        _v981.set(Some(x_15))
                                                                    }
                                                                    if getValue(_v981.get().clone())
                                                                    {
                                                                        let _v1004: MutCell<
                                                                            Option<()>,
                                                                        > = MutCell::new(
                                                                            None::<()>,
                                                                        );
                                                                        let v1006: string =
                                                                            Documents::method81(
                                                                                v23,
                                                                            );
                                                                        let v1008: Result<
                                                                            u64,
                                                                            std::io::Error,
                                                                        > = std::fs::copy(
                                                                            &*v14, &*v1006,
                                                                        );
                                                                        let v1010: u64 =
                                                                            v1008.unwrap();
                                                                        _v1004.set(Some(()));
                                                                        getValue(
                                                                            _v1004.get().clone(),
                                                                        );
                                                                        ()
                                                                    } else {
                                                                        panic!("{}",
                                                                               sprintf!("documents.run / files_fn / {} should exist", v14.clone()),)
                                                                    }
                                                                    Documents::US19::US19_0(Ok::<
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
                                    }
                                }
                            }
                        }
                    }
                }
            } else {
                Documents::US19::US19_1
            }
        }
        pub fn closure62(unitVar: (), unitVar_1: ()) -> string {
            string("documents.run / par_map / crowbook")
        }
        pub fn closure63(v0_1: string, v1_1: i32, unitVar: ()) -> string {
            sprintf!(
                "exit_code: {:?} / result: {} / {}",
                v1_1,
                v0_1,
                Documents::closure6((), ())
            )
        }
        pub fn closure61(v0_1: string, v1_1: string, v2: string, v3: string) -> Documents::US19 {
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
                    let v112 = None::<
                        Func1<std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>, ()>,
                    >;
                    let v113: string = sprintf!(
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
                    let _v114: MutCell<Option<(i32, string)>> = MutCell::new(None::<(i32, string)>);
                    let v116: string = Documents::method42(
                        v109.clone(),
                        v113.clone(),
                        v110.clone(),
                        v111.clone(),
                        v112.clone(),
                        v108.clone(),
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
                                let v108 = v108.clone();
                                let v109 = v109.clone();
                                let v110 = v110.clone();
                                let v111 = v111.clone();
                                let v112 = v112.clone();
                                let v113 = v113.clone();
                                let v135 = v135.clone();
                                let v142 = v142.clone();
                                move || {
                                    Documents::closure29(
                                        v109.clone(),
                                        v113.clone(),
                                        v110.clone(),
                                        v111.clone(),
                                        v112.clone(),
                                        v108.clone(),
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
                                v109.clone(),
                                v113.clone(),
                                v110.clone(),
                                v111.clone(),
                                v112.clone(),
                                v108.clone(),
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
                                    let v372 = None::<
                                        Func1<
                                            std::sync::Arc<
                                                std::sync::Mutex<std::process::ChildStdin>,
                                            >,
                                            (),
                                        >,
                                    >;
                                    let v373: string =
                                            sprintf!("pwsh -c \"(Get-FileHash \\\"{}\\\" -Algorithm SHA256).Hash\"",
                                                     if getValue(_v331.get().clone())
                                                            == false {
                                                         v22.clone()
                                                     } else {
                                                         let _v344:
                                                                 MutCell<Option<string>> =
                                                             MutCell::new(None::<string>);
                                                         let v346: string =
                                                             Documents::method26();
                                                         let v347: string =
                                                             Documents::method27(v22.clone());
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
                                    let _v374: MutCell<Option<(i32, string)>> =
                                        MutCell::new(None::<(i32, string)>);
                                    let v376: string = Documents::method42(
                                        v369.clone(),
                                        v373.clone(),
                                        v370.clone(),
                                        v371.clone(),
                                        v372.clone(),
                                        v368.clone(),
                                    );
                                    let patternInput_3: (string, string) = Documents::method43();
                                    let v379: i32 = length(v376.clone());
                                    let v380: Array<char> = new_init(&'\u{0000}', v379);
                                    let v381: LrcPtr<Documents::Mut5> =
                                        LrcPtr::new(Documents::Mut5 {
                                            l0: MutCell::new(0_i32),
                                        });
                                    while Documents::method30(v379, v381.clone()) {
                                        let v383: i32 = v381.l0.get().clone();
                                        let v384: char = getCharAt(v376.clone(), v383);
                                        v380.get_mut()[v383 as usize] = v384;
                                        {
                                            let v385: i32 = v383 + 1_i32;
                                            v381.l0.set(v385);
                                            ()
                                        }
                                    }
                                    {
                                        let v387: List<char> = ofArray(v380.clone());
                                        let patternInput_4: (string, string) = Documents::method45(
                                            patternInput_3.1.clone(),
                                            patternInput_3.0.clone(),
                                            foldBack(
                                                Func2::new(
                                                    move |b0: char, b1: LrcPtr<Documents::UH0>| {
                                                        (Documents::method44())(b0)(b1)
                                                    },
                                                ),
                                                v387,
                                                LrcPtr::new(Documents::UH0::UH0_0),
                                            ),
                                            Documents::US8::US8_0,
                                        );
                                        let v395: string = patternInput_4.0.clone();
                                        let v397: Array<string> =
                                            Documents::method46(patternInput_4.1.clone());
                                        let v399: Vec<string> = v397.to_vec();
                                        let v401: Vec<std::string::String> = v399
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
                                                let v373 = v373.clone();
                                                let v395 = v395.clone();
                                                let v401 = v401.clone();
                                                move || {
                                                    Documents::closure29(
                                                        v369.clone(),
                                                        v373.clone(),
                                                        v370.clone(),
                                                        v371.clone(),
                                                        v372.clone(),
                                                        v368.clone(),
                                                        v395.clone(),
                                                        v401.clone(),
                                                        (),
                                                    )
                                                }
                                            }),
                                            Documents::method51(),
                                        );
                                        {
                                            let v405: std::pin::Pin<
                                                Box<
                                                    dyn std::future::Future<
                                                        Output = LrcPtr<(i32, string)>,
                                                    >,
                                                >,
                                            > = Documents::method52(
                                                v369.clone(),
                                                v373.clone(),
                                                v370.clone(),
                                                v371.clone(),
                                                v372.clone(),
                                                v368.clone(),
                                                v395.clone(),
                                                v401.clone(),
                                            );
                                            let v407: LrcPtr<(i32, string)> =
                                                futures_lite::future::block_on(v405);
                                            _v374.set(Some((v407.0.clone(), v407.1.clone())));
                                            patternInput_2.1.clone()
                                                == (getValue(_v374.get().clone())).1.clone()
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
                let v593: string =
                    sprintf!("crowbook --single \"{}\" --output \"{}\" --to {} --set rendering.num_depth 6 html.css.add \\\"\'\'\' body {{ color: #e8e6e3; background-color: #202324; }} a {{ color: #989693; }} \'\'\'\\\"",
                             v0_1, v13.clone(), v3);
                let v595: Option<CancellationToken> = None::<CancellationToken>;
                let v596: Array<(string, string)> = new_empty::<(string, string)>();
                let v597 = None::<Func1<(bool, string, i32), Arc<Async<()>>>>;
                let v598 =
                    None::<Func1<std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>, ()>>;
                let v599: Option<string> = Some(v2);
                let _v600: MutCell<Option<(i32, string)>> = MutCell::new(None::<(i32, string)>);
                let v602: string = Documents::method42(
                    v595.clone(),
                    v593.clone(),
                    v596.clone(),
                    v597.clone(),
                    v598.clone(),
                    v599.clone(),
                );
                let patternInput_6: (string, string) = Documents::method43();
                let v605: i32 = length(v602.clone());
                let v606: Array<char> = new_init(&'\u{0000}', v605);
                let v607: LrcPtr<Documents::Mut5> = LrcPtr::new(Documents::Mut5 {
                    l0: MutCell::new(0_i32),
                });
                while Documents::method30(v605, v607.clone()) {
                    let v609: i32 = v607.l0.get().clone();
                    let v610: char = getCharAt(v602.clone(), v609);
                    v606.get_mut()[v609 as usize] = v610;
                    {
                        let v611: i32 = v609 + 1_i32;
                        v607.l0.set(v611);
                        ()
                    }
                }
                {
                    let v613: List<char> = ofArray(v606.clone());
                    let patternInput_7: (string, string) = Documents::method45(
                        patternInput_6.1.clone(),
                        patternInput_6.0.clone(),
                        foldBack(
                            Func2::new(move |b0: char, b1: LrcPtr<Documents::UH0>| {
                                (Documents::method44())(b0)(b1)
                            }),
                            v613,
                            LrcPtr::new(Documents::UH0::UH0_0),
                        ),
                        Documents::US8::US8_0,
                    );
                    let v621: string = patternInput_7.0.clone();
                    let v623: Array<string> = Documents::method46(patternInput_7.1.clone());
                    let v625: Vec<string> = v623.to_vec();
                    let v628: Vec<std::string::String> = v625
                        .iter()
                        .map(|x| {
                            Func1::new(move |v_1: string| Documents::closure28((), v_1))(x.clone())
                        })
                        .collect();
                    Documents::method3(
                        Documents::US0::US0_1,
                        Func0::new({
                            let v593 = v593.clone();
                            let v595 = v595.clone();
                            let v596 = v596.clone();
                            let v597 = v597.clone();
                            let v598 = v598.clone();
                            let v599 = v599.clone();
                            let v621 = v621.clone();
                            let v628 = v628.clone();
                            move || {
                                Documents::closure29(
                                    v595.clone(),
                                    v593.clone(),
                                    v596.clone(),
                                    v597.clone(),
                                    v598.clone(),
                                    v599.clone(),
                                    v621.clone(),
                                    v628.clone(),
                                    (),
                                )
                            }
                        }),
                        Documents::method51(),
                    );
                    {
                        let v632: std::pin::Pin<
                            Box<dyn std::future::Future<Output = LrcPtr<(i32, string)>>>,
                        > = Documents::method52(
                            v595.clone(),
                            v593.clone(),
                            v596.clone(),
                            v597.clone(),
                            v598.clone(),
                            v599.clone(),
                            v621.clone(),
                            v628.clone(),
                        );
                        let v634: LrcPtr<(i32, string)> = futures_lite::future::block_on(v632);
                        _v600.set(Some((v634.0.clone(), v634.1.clone())));
                        {
                            let patternInput_8: (i32, string) = getValue(_v600.get().clone());
                            let v816: string = patternInput_8.1.clone();
                            let v815: i32 = patternInput_8.0.clone();
                            let v824: Documents::US20 = if contains(v816.clone(), string("ERROR")) {
                                Documents::method3(
                                    Documents::US0::US0_2,
                                    Func0::new(move || Documents::closure62((), ())),
                                    Func0::new({
                                        let v815 = v815.clone();
                                        let v816 = v816.clone();
                                        move || Documents::closure63(v816.clone(), v815, ())
                                    }),
                                );
                                Documents::US20::US20_1(v815, v816.clone())
                            } else {
                                Documents::US20::US20_0(v815, v816.clone())
                            };
                            match &v824 {
                                Documents::US20::US20_0(v824_0_0, v824_0_1) => {
                                    let v826: string = v824_0_1.clone();
                                    let v825: i32 = v824_0_0.clone();
                                    if v825 != 0_i32 {
                                        Documents::method3(
                                            Documents::US0::US0_2,
                                            Func0::new(move || Documents::closure59((), ())),
                                            Func0::new({
                                                let v825 = v825.clone();
                                                let v826 = v826.clone();
                                                move || Documents::closure60(v826.clone(), v825, ())
                                            }),
                                        );
                                        Documents::US19::US19_0(Err::<
                                            string,
                                            LrcPtr<(string, string)>,
                                        >(
                                            LrcPtr::new((v13.clone(), v826.clone())),
                                        ))
                                    } else {
                                        let _v834: MutCell<Option<bool>> =
                                            MutCell::new(None::<bool>);
                                        let v836: string = Documents::method18(v13.clone());
                                        let v838: &str =
                                            fable_library_rust::String_::LrcStr::as_str(&v836);
                                        let v840: std::string::String = String::from(v838);
                                        let v842: std::path::PathBuf =
                                            std::path::PathBuf::from(v840);
                                        {
                                            let x_9: bool = if v842.clone().exists() {
                                                v842.is_file()
                                            } else {
                                                false
                                            };
                                            _v834.set(Some(x_9))
                                        }
                                        if getValue(_v834.get().clone()) {
                                            let _v857: MutCell<Option<()>> =
                                                MutCell::new(None::<()>);
                                            let v859: string = Documents::method81(v22);
                                            let v861: Result<u64, std::io::Error> =
                                                std::fs::copy(&*v13, &*v859);
                                            let v863: u64 = v861.unwrap();
                                            _v857.set(Some(()));
                                            getValue(_v857.get().clone());
                                            ()
                                        } else {
                                            panic!(
                                                "{}",
                                                sprintf!(
                                                    "documents.run / files_fn / {} should exist",
                                                    v13.clone()
                                                ),
                                            )
                                        }
                                        Documents::US19::US19_0(Ok::<
                                            string,
                                            LrcPtr<(string, string)>,
                                        >(
                                            v13.clone()
                                        ))
                                    }
                                }
                                Documents::US20::US20_1(v824_1_0, v824_1_1) => {
                                    Documents::US19::US19_0(
                                        Err::<string, LrcPtr<(string, string)>>(LrcPtr::new((
                                            v13.clone(),
                                            v824_1_1.clone(),
                                        ))),
                                    )
                                }
                            }
                        }
                    }
                }
            } else {
                Documents::US19::US19_1
            }
        }
        pub fn closure64(
            unitVar: (),
            _arg: (string, Func1<string, Documents::US19>),
        ) -> Option<Result<string, LrcPtr<(string, string)>>> {
            let v2: Documents::US19 = (_arg.1.clone())(_arg.0.clone());
            match &v2 {
                Documents::US19::US19_0(v2_0_0) => Some(match &v2 {
                    Documents::US19::US19_0(x) => x.clone(),
                    _ => unreachable!(),
                }),
                _ => None::<Result<string, LrcPtr<(string, string)>>>,
            }
        }
        pub fn closure65(unitVar: (), unitVar_1: ()) -> string {
            string("documents.run / par_map")
        }
        pub fn closure66(
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
                                    let v375 = None::<
                                        Func1<
                                            std::sync::Arc<
                                                std::sync::Mutex<std::process::ChildStdin>,
                                            >,
                                            (),
                                        >,
                                    >;
                                    let v376: string =
                                        sprintf!("git ls-tree --format=\'%(objectname)\' origin/gh-pages \"{}\"",
                                                 v370.clone());
                                    let v377: Option<string> = Some(v2);
                                    let _v378: MutCell<Option<(i32, string)>> =
                                        MutCell::new(None::<(i32, string)>);
                                    let v380: string = Documents::method42(
                                        v372.clone(),
                                        v376.clone(),
                                        v373.clone(),
                                        v374.clone(),
                                        v375.clone(),
                                        v377.clone(),
                                    );
                                    let patternInput_3: (string, string) = Documents::method43();
                                    let v383: i32 = length(v380.clone());
                                    let v384: Array<char> = new_init(&'\u{0000}', v383);
                                    let v385: LrcPtr<Documents::Mut5> =
                                        LrcPtr::new(Documents::Mut5 {
                                            l0: MutCell::new(0_i32),
                                        });
                                    while Documents::method30(v383, v385.clone()) {
                                        let v387: i32 = v385.l0.get().clone();
                                        let v388: char = getCharAt(v380.clone(), v387);
                                        v384.get_mut()[v387 as usize] = v388;
                                        {
                                            let v389: i32 = v387 + 1_i32;
                                            v385.l0.set(v389);
                                            ()
                                        }
                                    }
                                    {
                                        let v391: List<char> = ofArray(v384.clone());
                                        let patternInput_4: (string, string) = Documents::method45(
                                            patternInput_3.1.clone(),
                                            patternInput_3.0.clone(),
                                            foldBack(
                                                Func2::new(
                                                    move |b0: char, b1: LrcPtr<Documents::UH0>| {
                                                        (Documents::method44())(b0)(b1)
                                                    },
                                                ),
                                                v391,
                                                LrcPtr::new(Documents::UH0::UH0_0),
                                            ),
                                            Documents::US8::US8_0,
                                        );
                                        let v399: string = patternInput_4.0.clone();
                                        let v401: Array<string> =
                                            Documents::method46(patternInput_4.1.clone());
                                        let v403: Vec<string> = v401.to_vec();
                                        fn v405(v: string) -> std::string::String {
                                            Documents::closure28((), v)
                                        }
                                        let v406: Vec<std::string::String> = v403
                                            .iter()
                                            .map(|x| Func1::from(v405)(x.clone()))
                                            .collect();
                                        Documents::method3(
                                            Documents::US0::US0_1,
                                            Func0::new({
                                                let v372 = v372.clone();
                                                let v373 = v373.clone();
                                                let v374 = v374.clone();
                                                let v375 = v375.clone();
                                                let v376 = v376.clone();
                                                let v377 = v377.clone();
                                                let v399 = v399.clone();
                                                let v406 = v406.clone();
                                                move || {
                                                    Documents::closure29(
                                                        v372.clone(),
                                                        v376.clone(),
                                                        v373.clone(),
                                                        v374.clone(),
                                                        v375.clone(),
                                                        v377.clone(),
                                                        v399.clone(),
                                                        v406.clone(),
                                                        (),
                                                    )
                                                }
                                            }),
                                            Documents::method51(),
                                        );
                                        {
                                            let v410: std::pin::Pin<
                                                Box<
                                                    dyn std::future::Future<
                                                        Output = LrcPtr<(i32, string)>,
                                                    >,
                                                >,
                                            > = Documents::method52(
                                                v372.clone(),
                                                v376.clone(),
                                                v373.clone(),
                                                v374.clone(),
                                                v375.clone(),
                                                v377.clone(),
                                                v399.clone(),
                                                v406.clone(),
                                            );
                                            let v412: LrcPtr<(i32, string)> =
                                                futures_lite::future::block_on(v410);
                                            _v378.set(Some((v412.0.clone(), v412.1.clone())));
                                            {
                                                let patternInput_5: (i32, string) =
                                                    getValue(_v378.get().clone());
                                                let v593: string = patternInput_5.1.clone();
                                                let _v594: MutCell<Option<string>> =
                                                    MutCell::new(None::<string>);
                                                let v596: string = Documents::method18(v3.clone());
                                                let v598: &str =
                                                    fable_library_rust::String_::LrcStr::as_str(
                                                        &v596,
                                                    );
                                                let v600: std::string::String = String::from(v598);
                                                let v602: std::path::PathBuf =
                                                    std::path::PathBuf::from(v600);
                                                let v603: string =
                                                    Documents::method18(v259.clone());
                                                let v605: &str =
                                                    fable_library_rust::String_::LrcStr::as_str(
                                                        &v603,
                                                    );
                                                let v607: std::string::String = String::from(v605);
                                                let v609: std::path::PathBuf = v602.join(v607);
                                                let v611: std::path::Display = v609.display();
                                                let _v612: MutCell<Option<std::string::String>> =
                                                    MutCell::new(None::<std::string::String>);
                                                {
                                                    let x_17: std::string::String =
                                                        format!("{}", v611);
                                                    _v612.set(Some(x_17))
                                                }
                                                {
                                                    let v623: std::string::String =
                                                        getValue(_v612.get().clone());
                                                    {
                                                        let x_18: string =
                                                            fable_library_rust::String_::fromString(
                                                                v623,
                                                            );
                                                        _v594.set(Some(x_18))
                                                    }
                                                    {
                                                        let v635: string =
                                                            getValue(_v594.get().clone());
                                                        let _v636: MutCell<Option<bool>> =
                                                            MutCell::new(None::<bool>);
                                                        {
                                                            let x_19: bool = cfg!(windows);
                                                            _v636.set(Some(x_19))
                                                        }
                                                        {
                                                            let v669: string = if getValue(
                                                                _v636.get().clone(),
                                                            ) == false
                                                            {
                                                                v635.clone()
                                                            } else {
                                                                let _v649: MutCell<Option<string>> =
                                                                    MutCell::new(None::<string>);
                                                                let v651: string =
                                                                    Documents::method26();
                                                                let v652: string =
                                                                    Documents::method27(v635);
                                                                let v653: string =
                                                                    Documents::method28();
                                                                let v655: &str =
                                                                    &regex::Regex::new(&v651)
                                                                        .unwrap()
                                                                        .replace_all(&v652, &*v653);
                                                                let v657: std::string::String =
                                                                    String::from(v655);
                                                                {
                                                                    let x_20:
                                                                                string =
                                                                            fable_library_rust::String_::fromString(v657);
                                                                    _v649.set(Some(x_20))
                                                                }
                                                                {
                                                                    let v666: string = getValue(
                                                                        _v649.get().clone(),
                                                                    );
                                                                    replace(
                                                                        sprintf!(
                                                                            "{}{}",
                                                                            toLower(ofChar(
                                                                                getCharAt(
                                                                                    v666.clone(),
                                                                                    0_i32
                                                                                )
                                                                            )),
                                                                            getSlice(
                                                                                v666,
                                                                                Some(1_i32),
                                                                                None::<i32>
                                                                            )
                                                                        ),
                                                                        string("\\"),
                                                                        string("/"),
                                                                    )
                                                                }
                                                            };
                                                            let v671: Option<CancellationToken> =
                                                                None::<CancellationToken>;
                                                            let v672: Array<(string, string)> =
                                                                new_empty::<(string, string)>();
                                                            let v673 = None::<
                                                                Func1<
                                                                    (bool, string, i32),
                                                                    Arc<Async<()>>,
                                                                >,
                                                            >;
                                                            let v674 =
                                                                None::<Func1<std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>,
                                                                             ()>>;
                                                            let v675: string = sprintf!(
                                                                "git hash-object \"{}\"",
                                                                v669.clone()
                                                            );
                                                            let v676: Option<string> =
                                                                Some(v3.clone());
                                                            let _v677: MutCell<
                                                                Option<(i32, string)>,
                                                            > = MutCell::new(None::<(i32, string)>);
                                                            let v679: string = Documents::method42(
                                                                v671.clone(),
                                                                v675.clone(),
                                                                v672.clone(),
                                                                v673.clone(),
                                                                v674.clone(),
                                                                v676.clone(),
                                                            );
                                                            let patternInput_6: (string, string) =
                                                                Documents::method43();
                                                            let v682: i32 = length(v679.clone());
                                                            let v683: Array<char> =
                                                                new_init(&'\u{0000}', v682);
                                                            let v684: LrcPtr<Documents::Mut5> =
                                                                LrcPtr::new(Documents::Mut5 {
                                                                    l0: MutCell::new(0_i32),
                                                                });
                                                            while Documents::method30(
                                                                v682,
                                                                v684.clone(),
                                                            ) {
                                                                let v686: i32 =
                                                                    v684.l0.get().clone();
                                                                let v687: char =
                                                                    getCharAt(v679.clone(), v686);
                                                                v683.get_mut()[v686 as usize] =
                                                                    v687;
                                                                {
                                                                    let v688: i32 = v686 + 1_i32;
                                                                    v684.l0.set(v688);
                                                                    ()
                                                                }
                                                            }
                                                            {
                                                                let v690: List<char> =
                                                                    ofArray(v683.clone());
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
                                                                                                 v690,
                                                                                                 LrcPtr::new(Documents::UH0::UH0_0)),
                                                                                        Documents::US8::US8_0);
                                                                let v698: string =
                                                                    patternInput_7.0.clone();
                                                                let v700: Array<string> =
                                                                    Documents::method46(
                                                                        patternInput_7.1.clone(),
                                                                    );
                                                                let v702: Vec<string> =
                                                                    v700.to_vec();
                                                                let v704: Vec<std::string::String> =
                                                                    v702.iter()
                                                                        .map(|x| {
                                                                            Func1::from(v405)(
                                                                                x.clone(),
                                                                            )
                                                                        })
                                                                        .collect();
                                                                Documents::method3(
                                                                    Documents::US0::US0_1,
                                                                    Func0::new({
                                                                        let v671 = v671.clone();
                                                                        let v672 = v672.clone();
                                                                        let v673 = v673.clone();
                                                                        let v674 = v674.clone();
                                                                        let v675 = v675.clone();
                                                                        let v676 = v676.clone();
                                                                        let v698 = v698.clone();
                                                                        let v704 = v704.clone();
                                                                        move || {
                                                                            Documents::closure29(
                                                                                v671.clone(),
                                                                                v675.clone(),
                                                                                v672.clone(),
                                                                                v673.clone(),
                                                                                v674.clone(),
                                                                                v676.clone(),
                                                                                v698.clone(),
                                                                                v704.clone(),
                                                                                (),
                                                                            )
                                                                        }
                                                                    }),
                                                                    Documents::method51(),
                                                                );
                                                                {
                                                                    let v708: std::pin::Pin<
                                                                        Box<
                                                                            dyn std::future::Future<
                                                                                Output = LrcPtr<(
                                                                                    i32,
                                                                                    string,
                                                                                )>,
                                                                            >,
                                                                        >,
                                                                    > = Documents::method52(
                                                                        v671.clone(),
                                                                        v675.clone(),
                                                                        v672.clone(),
                                                                        v673.clone(),
                                                                        v674.clone(),
                                                                        v676.clone(),
                                                                        v698.clone(),
                                                                        v704.clone(),
                                                                    );
                                                                    let v710:
                                                                            LrcPtr<(i32,
                                                                                    string)> =
                                                                        futures_lite::future::block_on(v708);
                                                                    _v677.set(Some((
                                                                        v710.0.clone(),
                                                                        v710.1.clone(),
                                                                    )));
                                                                    {
                                                                        let patternInput_8: (
                                                                            i32,
                                                                            string,
                                                                        ) = getValue(
                                                                            _v677.get().clone(),
                                                                        );
                                                                        let v891: string =
                                                                            patternInput_8
                                                                                .1
                                                                                .clone();
                                                                        Ok::<LrcPtr<(string,
                                                                                     Vec<Option<Result<string,
                                                                                                       LrcPtr<(string,
                                                                                                               string)>>>>)>,
                                                                             std::string::String>(LrcPtr::new((v293.clone(),
                                                                                                               if contains(v593.clone(),
                                                                                                                           v891.clone())
                                                                                                                      ==
                                                                                                                      false
                                                                                                                  {
                                                                                                                   let _v894:
                                                                                                                           MutCell<Option<bool>> =
                                                                                                                       MutCell::new(None::<bool>);
                                                                                                                   {
                                                                                                                       let x_22:
                                                                                                                               bool =
                                                                                                                           cfg!(windows);
                                                                                                                       _v894.set(Some(x_22))
                                                                                                                   }
                                                                                                                   {
                                                                                                                       let v928:
                                                                                                                               Option<string> =
                                                                                                                           None::<string>;
                                                                                                                       let v929:
                                                                                                                               Option<CancellationToken> =
                                                                                                                           None::<CancellationToken>;
                                                                                                                       let v930:
                                                                                                                               Array<(string,
                                                                                                                                      string)> =
                                                                                                                           new_empty::<(string,
                                                                                                                                        string)>();
                                                                                                                       let v931 =
                                                                                                                           None::<Func1<(bool,
                                                                                                                                         string,
                                                                                                                                         i32),
                                                                                                                                        Arc<Async<()>>>>;
                                                                                                                       let v932 =
                                                                                                                           None::<Func1<std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>,
                                                                                                                                        ()>>;
                                                                                                                       let v933:
                                                                                                                               string =
                                                                                                                           sprintf!("pwsh -c \"(Get-FileHash \\\"{}\\\" -Algorithm SHA256).Hash\"",
                                                                                                                                    if getValue(_v894.get().clone())
                                                                                                                                           ==
                                                                                                                                           false
                                                                                                                                       {
                                                                                                                                        v669.clone()
                                                                                                                                    } else {
                                                                                                                                        let _v907:
                                                                                                                                                MutCell<Option<string>> =
                                                                                                                                            MutCell::new(None::<string>);
                                                                                                                                        let v909:
                                                                                                                                                string =
                                                                                                                                            Documents::method26();
                                                                                                                                        let v910:
                                                                                                                                                string =
                                                                                                                                            Documents::method27(v669.clone());
                                                                                                                                        let v911:
                                                                                                                                                string =
                                                                                                                                            Documents::method28();
                                                                                                                                        let v913:
                                                                                                                                                &str =
                                                                                                                                            &regex::Regex::new(&v909).unwrap().replace_all(&v910, &*v911);
                                                                                                                                        let v915:
                                                                                                                                                std::string::String =
                                                                                                                                            String::from(v913);
                                                                                                                                        {
                                                                                                                                            let x_23:
                                                                                                                                                    string =
                                                                                                                                                fable_library_rust::String_::fromString(v915);
                                                                                                                                            _v907.set(Some(x_23))
                                                                                                                                        }
                                                                                                                                        {
                                                                                                                                            let v924:
                                                                                                                                                    string =
                                                                                                                                                getValue(_v907.get().clone());
                                                                                                                                            replace(sprintf!("{}{}",
                                                                                                                                                             toLower(ofChar(getCharAt(v924.clone(),
                                                                                                                                                                                      0_i32))),
                                                                                                                                                             getSlice(v924,
                                                                                                                                                                      Some(1_i32),
                                                                                                                                                                      None::<i32>)),
                                                                                                                                                    string("\\"),
                                                                                                                                                    string("/"))
                                                                                                                                        }
                                                                                                                                    });
                                                                                                                       let _v934:
                                                                                                                               MutCell<Option<(i32,
                                                                                                                                               string)>> =
                                                                                                                           MutCell::new(None::<(i32,
                                                                                                                                                string)>);
                                                                                                                       let v936:
                                                                                                                               string =
                                                                                                                           Documents::method42(v929.clone(),
                                                                                                                                               v933.clone(),
                                                                                                                                               v930.clone(),
                                                                                                                                               v931.clone(),
                                                                                                                                               v932.clone(),
                                                                                                                                               v928.clone());
                                                                                                                       let patternInput_9:
                                                                                                                               (string,
                                                                                                                                string) =
                                                                                                                           Documents::method43();
                                                                                                                       let v939:
                                                                                                                               i32 =
                                                                                                                           length(v936.clone());
                                                                                                                       let v940:
                                                                                                                               Array<char> =
                                                                                                                           new_init(&'\u{0000}',
                                                                                                                                    v939);
                                                                                                                       let v941:
                                                                                                                               LrcPtr<Documents::Mut5> =
                                                                                                                           LrcPtr::new(Documents::Mut5{l0:
                                                                                                                                                           MutCell::new(0_i32),});
                                                                                                                       while Documents::method30(v939,
                                                                                                                                                 v941.clone())
                                                                                                                             {
                                                                                                                           let v943:
                                                                                                                                   i32 =
                                                                                                                               v941.l0.get().clone();
                                                                                                                           let v944:
                                                                                                                                   char =
                                                                                                                               getCharAt(v936.clone(),
                                                                                                                                         v943);
                                                                                                                           v940.get_mut()[v943
                                                                                                                                              as
                                                                                                                                              usize]
                                                                                                                               =
                                                                                                                               v944;
                                                                                                                           {
                                                                                                                               let v945:
                                                                                                                                       i32 =
                                                                                                                                   v943
                                                                                                                                       +
                                                                                                                                       1_i32;
                                                                                                                               v941.l0.set(v945);
                                                                                                                               ()
                                                                                                                           }
                                                                                                                       }
                                                                                                                       {
                                                                                                                           let v947:
                                                                                                                                   List<char> =
                                                                                                                               ofArray(v940.clone());
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
                                                                                                                                                            v947,
                                                                                                                                                            LrcPtr::new(Documents::UH0::UH0_0)),
                                                                                                                                                   Documents::US8::US8_0);
                                                                                                                           let v955:
                                                                                                                                   string =
                                                                                                                               patternInput_10.0.clone();
                                                                                                                           let v957:
                                                                                                                                   Array<string> =
                                                                                                                               Documents::method46(patternInput_10.1.clone());
                                                                                                                           let v959:
                                                                                                                                   Vec<string> =
                                                                                                                               v957.to_vec();
                                                                                                                           let v961:
                                                                                                                                   Vec<std::string::String> =
                                                                                                                               v959.iter().map(|x| Func1::from(v405)(x.clone())).collect();
                                                                                                                           Documents::method3(Documents::US0::US0_1,
                                                                                                                                              Func0::new({
                                                                                                                                                             let v928
                                                                                                                                                                 =
                                                                                                                                                                 v928.clone();
                                                                                                                                                             let v929
                                                                                                                                                                 =
                                                                                                                                                                 v929.clone();
                                                                                                                                                             let v930
                                                                                                                                                                 =
                                                                                                                                                                 v930.clone();
                                                                                                                                                             let v931
                                                                                                                                                                 =
                                                                                                                                                                 v931.clone();
                                                                                                                                                             let v932
                                                                                                                                                                 =
                                                                                                                                                                 v932.clone();
                                                                                                                                                             let v933
                                                                                                                                                                 =
                                                                                                                                                                 v933.clone();
                                                                                                                                                             let v955
                                                                                                                                                                 =
                                                                                                                                                                 v955.clone();
                                                                                                                                                             let v961
                                                                                                                                                                 =
                                                                                                                                                                 v961.clone();
                                                                                                                                                             move
                                                                                                                                                                 ||
                                                                                                                                                                 Documents::closure29(v929.clone(),
                                                                                                                                                                                      v933.clone(),
                                                                                                                                                                                      v930.clone(),
                                                                                                                                                                                      v931.clone(),
                                                                                                                                                                                      v932.clone(),
                                                                                                                                                                                      v928.clone(),
                                                                                                                                                                                      v955.clone(),
                                                                                                                                                                                      v961.clone(),
                                                                                                                                                                                      ())
                                                                                                                                                         }),
                                                                                                                                              Documents::method51());
                                                                                                                           {
                                                                                                                               let v965:
                                                                                                                                       std::pin::Pin<Box<dyn std::future::Future<Output = LrcPtr<(i32,
                                                                                                                                                                                                  string)>>>> =
                                                                                                                                   Documents::method52(v929.clone(),
                                                                                                                                                       v933.clone(),
                                                                                                                                                       v930.clone(),
                                                                                                                                                       v931.clone(),
                                                                                                                                                       v932.clone(),
                                                                                                                                                       v928.clone(),
                                                                                                                                                       v955.clone(),
                                                                                                                                                       v961.clone());
                                                                                                                               let v967:
                                                                                                                                       LrcPtr<(i32,
                                                                                                                                               string)> =
                                                                                                                                   futures_lite::future::block_on(v965);
                                                                                                                               _v934.set(Some((v967.0.clone(),
                                                                                                                                               v967.1.clone())));
                                                                                                                               {
                                                                                                                                   let v1148:
                                                                                                                                           string =
                                                                                                                                       (getValue(_v934.get().clone())).1.clone();
                                                                                                                                   let _v1149:
                                                                                                                                           MutCell<Option<string>> =
                                                                                                                                       MutCell::new(None::<string>);
                                                                                                                                   let v1151:
                                                                                                                                           string =
                                                                                                                                       Documents::method18(v4);
                                                                                                                                   let v1153:
                                                                                                                                           &str =
                                                                                                                                       fable_library_rust::String_::LrcStr::as_str(&v1151);
                                                                                                                                   let v1155:
                                                                                                                                           std::string::String =
                                                                                                                                       String::from(v1153);
                                                                                                                                   let v1157:
                                                                                                                                           std::path::PathBuf =
                                                                                                                                       std::path::PathBuf::from(v1155);
                                                                                                                                   let v1158:
                                                                                                                                           string =
                                                                                                                                       Documents::method18(v259.clone());
                                                                                                                                   let v1160:
                                                                                                                                           &str =
                                                                                                                                       fable_library_rust::String_::LrcStr::as_str(&v1158);
                                                                                                                                   let v1162:
                                                                                                                                           std::string::String =
                                                                                                                                       String::from(v1160);
                                                                                                                                   let v1164:
                                                                                                                                           std::path::PathBuf =
                                                                                                                                       v1157.join(v1162);
                                                                                                                                   let v1166:
                                                                                                                                           std::path::Display =
                                                                                                                                       v1164.display();
                                                                                                                                   let _v1167:
                                                                                                                                           MutCell<Option<std::string::String>> =
                                                                                                                                       MutCell::new(None::<std::string::String>);
                                                                                                                                   {
                                                                                                                                       let x_25:
                                                                                                                                               std::string::String =
                                                                                                                                           format!("{}", v1166);
                                                                                                                                       _v1167.set(Some(x_25))
                                                                                                                                   }
                                                                                                                                   {
                                                                                                                                       let v1178:
                                                                                                                                               std::string::String =
                                                                                                                                           getValue(_v1167.get().clone());
                                                                                                                                       {
                                                                                                                                           let x_26:
                                                                                                                                                   string =
                                                                                                                                               fable_library_rust::String_::fromString(v1178);
                                                                                                                                           _v1149.set(Some(x_26))
                                                                                                                                       }
                                                                                                                                       {
                                                                                                                                           let v1190:
                                                                                                                                                   string =
                                                                                                                                               getValue(_v1149.get().clone());
                                                                                                                                           let _v1191:
                                                                                                                                                   MutCell<Option<bool>> =
                                                                                                                                               MutCell::new(None::<bool>);
                                                                                                                                           {
                                                                                                                                               let x_27:
                                                                                                                                                       bool =
                                                                                                                                                   cfg!(windows);
                                                                                                                                               _v1191.set(Some(x_27))
                                                                                                                                           }
                                                                                                                                           {
                                                                                                                                               let v1224:
                                                                                                                                                       string =
                                                                                                                                                   if getValue(_v1191.get().clone())
                                                                                                                                                          ==
                                                                                                                                                          false
                                                                                                                                                      {
                                                                                                                                                       v1190.clone()
                                                                                                                                                   } else {
                                                                                                                                                       let _v1204:
                                                                                                                                                               MutCell<Option<string>> =
                                                                                                                                                           MutCell::new(None::<string>);
                                                                                                                                                       let v1206:
                                                                                                                                                               string =
                                                                                                                                                           Documents::method26();
                                                                                                                                                       let v1207:
                                                                                                                                                               string =
                                                                                                                                                           Documents::method27(v1190);
                                                                                                                                                       let v1208:
                                                                                                                                                               string =
                                                                                                                                                           Documents::method28();
                                                                                                                                                       let v1210:
                                                                                                                                                               &str =
                                                                                                                                                           &regex::Regex::new(&v1206).unwrap().replace_all(&v1207, &*v1208);
                                                                                                                                                       let v1212:
                                                                                                                                                               std::string::String =
                                                                                                                                                           String::from(v1210);
                                                                                                                                                       {
                                                                                                                                                           let x_28:
                                                                                                                                                                   string =
                                                                                                                                                               fable_library_rust::String_::fromString(v1212);
                                                                                                                                                           _v1204.set(Some(x_28))
                                                                                                                                                       }
                                                                                                                                                       {
                                                                                                                                                           let v1221:
                                                                                                                                                                   string =
                                                                                                                                                               getValue(_v1204.get().clone());
                                                                                                                                                           replace(sprintf!("{}{}",
                                                                                                                                                                            toLower(ofChar(getCharAt(v1221.clone(),
                                                                                                                                                                                                     0_i32))),
                                                                                                                                                                            getSlice(v1221,
                                                                                                                                                                                     Some(1_i32),
                                                                                                                                                                                     None::<i32>)),
                                                                                                                                                                   string("\\"),
                                                                                                                                                                   string("/"))
                                                                                                                                                       }
                                                                                                                                                   };
                                                                                                                                               let _v1225:
                                                                                                                                                       MutCell<Option<bool>> =
                                                                                                                                                   MutCell::new(None::<bool>);
                                                                                                                                               let v1227:
                                                                                                                                                       string =
                                                                                                                                                   Documents::method18(v1224.clone());
                                                                                                                                               let v1229:
                                                                                                                                                       &str =
                                                                                                                                                   fable_library_rust::String_::LrcStr::as_str(&v1227);
                                                                                                                                               let v1231:
                                                                                                                                                       std::string::String =
                                                                                                                                                   String::from(v1229);
                                                                                                                                               let v1233:
                                                                                                                                                       std::path::PathBuf =
                                                                                                                                                   std::path::PathBuf::from(v1231);
                                                                                                                                               {
                                                                                                                                                   let x_29:
                                                                                                                                                           bool =
                                                                                                                                                       if v1233.clone().exists()
                                                                                                                                                          {
                                                                                                                                                           v1233.is_file()
                                                                                                                                                       } else {
                                                                                                                                                           false
                                                                                                                                                       };
                                                                                                                                                   _v1225.set(Some(x_29))
                                                                                                                                               }
                                                                                                                                               {
                                                                                                                                                   let v1504:
                                                                                                                                                           string =
                                                                                                                                                       if getValue(_v1225.get().clone())
                                                                                                                                                          {
                                                                                                                                                           let _v1249:
                                                                                                                                                                   MutCell<Option<bool>> =
                                                                                                                                                               MutCell::new(None::<bool>);
                                                                                                                                                           {
                                                                                                                                                               let x_30:
                                                                                                                                                                       bool =
                                                                                                                                                                   cfg!(windows);
                                                                                                                                                               _v1249.set(Some(x_30))
                                                                                                                                                           }
                                                                                                                                                           {
                                                                                                                                                               let v1283:
                                                                                                                                                                       Option<string> =
                                                                                                                                                                   None::<string>;
                                                                                                                                                               let v1284:
                                                                                                                                                                       Option<CancellationToken> =
                                                                                                                                                                   None::<CancellationToken>;
                                                                                                                                                               let v1285:
                                                                                                                                                                       Array<(string,
                                                                                                                                                                              string)> =
                                                                                                                                                                   new_empty::<(string,
                                                                                                                                                                                string)>();
                                                                                                                                                               let v1286 =
                                                                                                                                                                   None::<Func1<(bool,
                                                                                                                                                                                 string,
                                                                                                                                                                                 i32),
                                                                                                                                                                                Arc<Async<()>>>>;
                                                                                                                                                               let v1287 =
                                                                                                                                                                   None::<Func1<std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>,
                                                                                                                                                                                ()>>;
                                                                                                                                                               let v1288:
                                                                                                                                                                       string =
                                                                                                                                                                   sprintf!("pwsh -c \"(Get-FileHash \\\"{}\\\" -Algorithm SHA256).Hash\"",
                                                                                                                                                                            if getValue(_v1249.get().clone())
                                                                                                                                                                                   ==
                                                                                                                                                                                   false
                                                                                                                                                                               {
                                                                                                                                                                                v1224.clone()
                                                                                                                                                                            } else {
                                                                                                                                                                                let _v1262:
                                                                                                                                                                                        MutCell<Option<string>> =
                                                                                                                                                                                    MutCell::new(None::<string>);
                                                                                                                                                                                let v1264:
                                                                                                                                                                                        string =
                                                                                                                                                                                    Documents::method26();
                                                                                                                                                                                let v1265:
                                                                                                                                                                                        string =
                                                                                                                                                                                    Documents::method27(v1224.clone());
                                                                                                                                                                                let v1266:
                                                                                                                                                                                        string =
                                                                                                                                                                                    Documents::method28();
                                                                                                                                                                                let v1268:
                                                                                                                                                                                        &str =
                                                                                                                                                                                    &regex::Regex::new(&v1264).unwrap().replace_all(&v1265, &*v1266);
                                                                                                                                                                                let v1270:
                                                                                                                                                                                        std::string::String =
                                                                                                                                                                                    String::from(v1268);
                                                                                                                                                                                {
                                                                                                                                                                                    let x_31:
                                                                                                                                                                                            string =
                                                                                                                                                                                        fable_library_rust::String_::fromString(v1270);
                                                                                                                                                                                    _v1262.set(Some(x_31))
                                                                                                                                                                                }
                                                                                                                                                                                {
                                                                                                                                                                                    let v1279:
                                                                                                                                                                                            string =
                                                                                                                                                                                        getValue(_v1262.get().clone());
                                                                                                                                                                                    replace(sprintf!("{}{}",
                                                                                                                                                                                                     toLower(ofChar(getCharAt(v1279.clone(),
                                                                                                                                                                                                                              0_i32))),
                                                                                                                                                                                                     getSlice(v1279,
                                                                                                                                                                                                              Some(1_i32),
                                                                                                                                                                                                              None::<i32>)),
                                                                                                                                                                                            string("\\"),
                                                                                                                                                                                            string("/"))
                                                                                                                                                                                }
                                                                                                                                                                            });
                                                                                                                                                               let _v1289:
                                                                                                                                                                       MutCell<Option<(i32,
                                                                                                                                                                                       string)>> =
                                                                                                                                                                   MutCell::new(None::<(i32,
                                                                                                                                                                                        string)>);
                                                                                                                                                               let v1291:
                                                                                                                                                                       string =
                                                                                                                                                                   Documents::method42(v1284.clone(),
                                                                                                                                                                                       v1288.clone(),
                                                                                                                                                                                       v1285.clone(),
                                                                                                                                                                                       v1286.clone(),
                                                                                                                                                                                       v1287.clone(),
                                                                                                                                                                                       v1283.clone());
                                                                                                                                                               let patternInput_12:
                                                                                                                                                                       (string,
                                                                                                                                                                        string) =
                                                                                                                                                                   Documents::method43();
                                                                                                                                                               let v1294:
                                                                                                                                                                       i32 =
                                                                                                                                                                   length(v1291.clone());
                                                                                                                                                               let v1295:
                                                                                                                                                                       Array<char> =
                                                                                                                                                                   new_init(&'\u{0000}',
                                                                                                                                                                            v1294);
                                                                                                                                                               let v1296:
                                                                                                                                                                       LrcPtr<Documents::Mut5> =
                                                                                                                                                                   LrcPtr::new(Documents::Mut5{l0:
                                                                                                                                                                                                   MutCell::new(0_i32),});
                                                                                                                                                               while Documents::method30(v1294,
                                                                                                                                                                                         v1296.clone())
                                                                                                                                                                     {
                                                                                                                                                                   let v1298:
                                                                                                                                                                           i32 =
                                                                                                                                                                       v1296.l0.get().clone();
                                                                                                                                                                   let v1299:
                                                                                                                                                                           char =
                                                                                                                                                                       getCharAt(v1291.clone(),
                                                                                                                                                                                 v1298);
                                                                                                                                                                   v1295.get_mut()[v1298
                                                                                                                                                                                       as
                                                                                                                                                                                       usize]
                                                                                                                                                                       =
                                                                                                                                                                       v1299;
                                                                                                                                                                   {
                                                                                                                                                                       let v1300:
                                                                                                                                                                               i32 =
                                                                                                                                                                           v1298
                                                                                                                                                                               +
                                                                                                                                                                               1_i32;
                                                                                                                                                                       v1296.l0.set(v1300);
                                                                                                                                                                       ()
                                                                                                                                                                   }
                                                                                                                                                               }
                                                                                                                                                               {
                                                                                                                                                                   let v1302:
                                                                                                                                                                           List<char> =
                                                                                                                                                                       ofArray(v1295.clone());
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
                                                                                                                                                                                                    v1302,
                                                                                                                                                                                                    LrcPtr::new(Documents::UH0::UH0_0)),
                                                                                                                                                                                           Documents::US8::US8_0);
                                                                                                                                                                   let v1310:
                                                                                                                                                                           string =
                                                                                                                                                                       patternInput_13.0.clone();
                                                                                                                                                                   let v1312:
                                                                                                                                                                           Array<string> =
                                                                                                                                                                       Documents::method46(patternInput_13.1.clone());
                                                                                                                                                                   let v1314:
                                                                                                                                                                           Vec<string> =
                                                                                                                                                                       v1312.to_vec();
                                                                                                                                                                   let v1316:
                                                                                                                                                                           Vec<std::string::String> =
                                                                                                                                                                       v1314.iter().map(|x| Func1::from(v405)(x.clone())).collect();
                                                                                                                                                                   Documents::method3(Documents::US0::US0_1,
                                                                                                                                                                                      Func0::new({
                                                                                                                                                                                                     let v1283
                                                                                                                                                                                                         =
                                                                                                                                                                                                         v1283.clone();
                                                                                                                                                                                                     let v1284
                                                                                                                                                                                                         =
                                                                                                                                                                                                         v1284.clone();
                                                                                                                                                                                                     let v1285
                                                                                                                                                                                                         =
                                                                                                                                                                                                         v1285.clone();
                                                                                                                                                                                                     let v1286
                                                                                                                                                                                                         =
                                                                                                                                                                                                         v1286.clone();
                                                                                                                                                                                                     let v1287
                                                                                                                                                                                                         =
                                                                                                                                                                                                         v1287.clone();
                                                                                                                                                                                                     let v1288
                                                                                                                                                                                                         =
                                                                                                                                                                                                         v1288.clone();
                                                                                                                                                                                                     let v1310
                                                                                                                                                                                                         =
                                                                                                                                                                                                         v1310.clone();
                                                                                                                                                                                                     let v1316
                                                                                                                                                                                                         =
                                                                                                                                                                                                         v1316.clone();
                                                                                                                                                                                                     move
                                                                                                                                                                                                         ||
                                                                                                                                                                                                         Documents::closure29(v1284.clone(),
                                                                                                                                                                                                                              v1288.clone(),
                                                                                                                                                                                                                              v1285.clone(),
                                                                                                                                                                                                                              v1286.clone(),
                                                                                                                                                                                                                              v1287.clone(),
                                                                                                                                                                                                                              v1283.clone(),
                                                                                                                                                                                                                              v1310.clone(),
                                                                                                                                                                                                                              v1316.clone(),
                                                                                                                                                                                                                              ())
                                                                                                                                                                                                 }),
                                                                                                                                                                                      Documents::method51());
                                                                                                                                                                   {
                                                                                                                                                                       let v1320:
                                                                                                                                                                               std::pin::Pin<Box<dyn std::future::Future<Output = LrcPtr<(i32,
                                                                                                                                                                                                                                          string)>>>> =
                                                                                                                                                                           Documents::method52(v1284.clone(),
                                                                                                                                                                                               v1288.clone(),
                                                                                                                                                                                               v1285.clone(),
                                                                                                                                                                                               v1286.clone(),
                                                                                                                                                                                               v1287.clone(),
                                                                                                                                                                                               v1283.clone(),
                                                                                                                                                                                               v1310.clone(),
                                                                                                                                                                                               v1316.clone());
                                                                                                                                                                       let v1322:
                                                                                                                                                                               LrcPtr<(i32,
                                                                                                                                                                                       string)> =
                                                                                                                                                                           futures_lite::future::block_on(v1320);
                                                                                                                                                                       _v1289.set(Some((v1322.0.clone(),
                                                                                                                                                                                        v1322.1.clone())));
                                                                                                                                                                       (getValue(_v1289.get().clone())).1.clone()
                                                                                                                                                                   }
                                                                                                                                                               }
                                                                                                                                                           }
                                                                                                                                                       } else {
                                                                                                                                                           string("")
                                                                                                                                                       };
                                                                                                                                                   if v1148.clone()
                                                                                                                                                          !=
                                                                                                                                                          v1504.clone()
                                                                                                                                                      {
                                                                                                                                                       let v1511 =
                                                                                                                                                           Func1::new({
                                                                                                                                                                          let v1224
                                                                                                                                                                              =
                                                                                                                                                                              v1224.clone();
                                                                                                                                                                          let v3
                                                                                                                                                                              =
                                                                                                                                                                              v3.clone();
                                                                                                                                                                          let v669
                                                                                                                                                                              =
                                                                                                                                                                              v669.clone();
                                                                                                                                                                          move
                                                                                                                                                                              |v_2:
                                                                                                                                                                                   string|
                                                                                                                                                                              Documents::closure61(v669.clone(),
                                                                                                                                                                                                   v1224.clone(),
                                                                                                                                                                                                   v3.clone(),
                                                                                                                                                                                                   v_2)
                                                                                                                                                                      });
                                                                                                                                                       let v1518 =
                                                                                                                                                           toArray(ofArray(new_array(&[(string("html"),
                                                                                                                                                                                        v1511.clone()),
                                                                                                                                                                                       (string("pdf"),
                                                                                                                                                                                        v1511.clone()),
                                                                                                                                                                                       (string("epub"),
                                                                                                                                                                                        v1511),
                                                                                                                                                                                       (string("hangul.md"),
                                                                                                                                                                                        Func1::new({
                                                                                                                                                                                                       let v0_1
                                                                                                                                                                                                           =
                                                                                                                                                                                                           v0_1.clone();
                                                                                                                                                                                                       let v1224
                                                                                                                                                                                                           =
                                                                                                                                                                                                           v1224.clone();
                                                                                                                                                                                                       let v1_1
                                                                                                                                                                                                           =
                                                                                                                                                                                                           v1_1.clone();
                                                                                                                                                                                                       let v669
                                                                                                                                                                                                           =
                                                                                                                                                                                                           v669.clone();
                                                                                                                                                                                                       move
                                                                                                                                                                                                           |v_1:
                                                                                                                                                                                                                string|
                                                                                                                                                                                                           Documents::closure57(v669.clone(),
                                                                                                                                                                                                                                v1224.clone(),
                                                                                                                                                                                                                                v0_1.clone(),
                                                                                                                                                                                                                                v1_1.clone(),
                                                                                                                                                                                                                                v_1)
                                                                                                                                                                                                   }))])));
                                                                                                                                                       let v1520 =
                                                                                                                                                           v1518.to_vec();
                                                                                                                                                       let v1522 =
                                                                                                                                                           rayon::iter::IntoParallelIterator::into_par_iter(v1520);
                                                                                                                                                       let v1525 =
                                                                                                                                                           rayon::iter::ParallelIterator::map(v1522, |x| Func1::new(move
                                                                                                                                                                                                                        |arg10_0040_4:
                                                                                                                                                                                                                             (string,
                                                                                                                                                                                                                              Func1<string,
                                                                                                                                                                                                                                    Documents::US19>)|
                                                                                                                                                                                                                        Documents::closure64((),
                                                                                                                                                                                                                                             arg10_0040_4))(x));
                                                                                                                                                       let v1527:
                                                                                                                                                               Vec<Option<Result<string,
                                                                                                                                                                                 LrcPtr<(string,
                                                                                                                                                                                         string)>>>> =
                                                                                                                                                           rayon::iter::ParallelIterator::collect(v1525);
                                                                                                                                                       Documents::method3(Documents::US0::US0_2,
                                                                                                                                                                          Func0::new(move
                                                                                                                                                                                         ||
                                                                                                                                                                                         Documents::closure65((),
                                                                                                                                                                                                              ())),
                                                                                                                                                                          Func0::new({
                                                                                                                                                                                         let patternInput_5
                                                                                                                                                                                             =
                                                                                                                                                                                             patternInput_5.clone();
                                                                                                                                                                                         let patternInput_8
                                                                                                                                                                                             =
                                                                                                                                                                                             patternInput_8.clone();
                                                                                                                                                                                         let v1148
                                                                                                                                                                                             =
                                                                                                                                                                                             v1148.clone();
                                                                                                                                                                                         let v1504
                                                                                                                                                                                             =
                                                                                                                                                                                             v1504.clone();
                                                                                                                                                                                         let v1527
                                                                                                                                                                                             =
                                                                                                                                                                                             v1527.clone();
                                                                                                                                                                                         let v259
                                                                                                                                                                                             =
                                                                                                                                                                                             v259.clone();
                                                                                                                                                                                         let v293
                                                                                                                                                                                             =
                                                                                                                                                                                             v293.clone();
                                                                                                                                                                                         let v370
                                                                                                                                                                                             =
                                                                                                                                                                                             v370.clone();
                                                                                                                                                                                         let v593
                                                                                                                                                                                             =
                                                                                                                                                                                             v593.clone();
                                                                                                                                                                                         let v891
                                                                                                                                                                                             =
                                                                                                                                                                                             v891.clone();
                                                                                                                                                                                         move
                                                                                                                                                                                             ||
                                                                                                                                                                                             Documents::closure66(v259.clone(),
                                                                                                                                                                                                                  v293.clone(),
                                                                                                                                                                                                                  v370.clone(),
                                                                                                                                                                                                                  v593.clone(),
                                                                                                                                                                                                                  patternInput_5.0.clone(),
                                                                                                                                                                                                                  v891.clone(),
                                                                                                                                                                                                                  patternInput_8.0.clone(),
                                                                                                                                                                                                                  v1148.clone(),
                                                                                                                                                                                                                  v1504.clone(),
                                                                                                                                                                                                                  v1527.clone(),
                                                                                                                                                                                                                  ())
                                                                                                                                                                                     }));
                                                                                                                                                       {
                                                                                                                                                           let _v1531:
                                                                                                                                                                   MutCell<Option<()>> =
                                                                                                                                                               MutCell::new(None::<()>);
                                                                                                                                                           let v1533:
                                                                                                                                                                   string =
                                                                                                                                                               Documents::method81(v1224.clone());
                                                                                                                                                           let v1535:
                                                                                                                                                                   Result<u64,
                                                                                                                                                                          std::io::Error> =
                                                                                                                                                               std::fs::copy(&*v669, &*v1533);
                                                                                                                                                           let v1537:
                                                                                                                                                                   u64 =
                                                                                                                                                               v1535.unwrap();
                                                                                                                                                           _v1531.set(Some(()));
                                                                                                                                                           getValue(_v1531.get().clone());
                                                                                                                                                           v1527.clone()
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
        pub fn closure67(unitVar: (), unitVar_1: ()) -> string {
            string("documents.run")
        }
        pub fn closure68(
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
        pub fn method82(
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
                            Func0::new(move || Documents::closure67((), ())),
                            Func0::new({
                                let v23 = v23.clone();
                                move || Documents::closure68(v23.clone(), ())
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
                            > = Documents::method82(Ok::<
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
