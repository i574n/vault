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
        #[derive(Clone, Debug)]
        pub enum UH3 {
            UH3_0,
            UH3_1(
                string,
                string,
                Func2<string, string, Documents::US19>,
                LrcPtr<Documents::UH3>,
            ),
        }
        impl Documents::UH3 {
            pub fn get_IsUH3_0(this_: LrcPtr<Documents::UH3>, unitArg: ()) -> bool {
                if let Documents::UH3::UH3_0 = this_.as_ref() {
                    true
                } else {
                    false
                }
            }
            pub fn get_IsUH3_1(this_: LrcPtr<Documents::UH3>, unitArg: ()) -> bool {
                if let Documents::UH3::UH3_1(this__1_0, this__1_1, this__1_2, this__1_3) =
                    this_.as_ref()
                {
                    true
                } else {
                    false
                }
            }
        }
        impl core::fmt::Display for Documents::UH3 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum UH2 {
            UH2_0,
            UH2_1(LrcPtr<Documents::UH3>, LrcPtr<Documents::UH2>),
        }
        impl Documents::UH2 {
            pub fn get_IsUH2_0(this_: LrcPtr<Documents::UH2>, unitArg: ()) -> bool {
                if let Documents::UH2::UH2_0 = this_.as_ref() {
                    true
                } else {
                    false
                }
            }
            pub fn get_IsUH2_1(this_: LrcPtr<Documents::UH2>, unitArg: ()) -> bool {
                if let Documents::UH2::UH2_1(this__1_0, this__1_1) = this_.as_ref() {
                    true
                } else {
                    false
                }
            }
        }
        impl core::fmt::Display for Documents::UH2 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug, PartialEq, PartialOrd, Hash, Eq)]
        pub enum US20 {
            US20_0(string),
            US20_1(string),
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
        #[derive(Clone, Debug, PartialEq, PartialOrd, Hash, Eq)]
        pub enum US21 {
            US21_0(i32, string),
            US21_1(i32, string),
        }
        impl Documents::US21 {
            pub fn get_IsUS21_0(this_: &MutCell<Documents::US21>, unitArg: ()) -> bool {
                if unreachable!() {
                    true
                } else {
                    false
                }
            }
            pub fn get_IsUS21_1(this_: &MutCell<Documents::US21>, unitArg: ()) -> bool {
                if unreachable!() {
                    true
                } else {
                    false
                }
            }
        }
        impl core::fmt::Display for Documents::US21 {
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
        #[derive(Clone, Debug, Default)]
        pub struct Mut8 {
            pub l0: MutCell<i32>,
            pub l1: MutCell<Vec<Option<Result<string, LrcPtr<(string, string)>>>>>,
        }
        impl core::fmt::Display for Documents::Mut8 {
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
        pub fn closure5(v0_1: Array<string>, unitVar: ()) -> string {
            sprintf!("args: {} / {}", v0_1, Documents::closure6((), ()))
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
        pub fn method14(v0_1: string) -> string {
            v0_1
        }
        pub fn method15(v0_1: string) -> string {
            v0_1
        }
        pub fn method16(v0_1: string) -> string {
            v0_1
        }
        pub fn method13(v0_1: string, v1_1: string) -> string {
            let _v2: MutCell<Option<string>> = MutCell::new(None::<string>);
            let v4: string = Documents::method14(v0_1);
            let v6: &str = fable_library_rust::String_::LrcStr::as_str(&v4);
            let v8: std::string::String = String::from(v6);
            let v10: std::path::PathBuf = std::path::PathBuf::from(v8);
            let v11: string = Documents::method14(v1_1);
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
                getValue(_v2.get().clone())
            }
        }
        pub fn closure10(unitVar: (), v0_1: string) -> Option<string> {
            let _v1: MutCell<Option<Documents::US4>> = MutCell::new(None::<Documents::US4>);
            let v3: string = Documents::method14(v0_1);
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
        pub fn method18() -> Func1<string, Option<string>> {
            Func1::new(move |v: string| Documents::closure10((), v))
        }
        pub fn closure11(unitVar: (), v0_1: string) -> Documents::US4 {
            Documents::US4::US4_0(v0_1)
        }
        pub fn method19() -> Func1<string, Documents::US4> {
            Func1::new(move |v: string| Documents::closure11((), v))
        }
        pub fn method20(v0_1: string, v1_1: string, v2: string) -> string {
            let v0_1: MutCell<string> = MutCell::new(v0_1.clone());
            let v1_1: MutCell<string> = MutCell::new(v1_1.clone());
            let v2: MutCell<string> = MutCell::new(v2.clone());
            '_method20: loop {
                break '_method20 ({
                    let _v4: MutCell<Option<bool>> = MutCell::new(None::<bool>);
                    let v6: string = Documents::method14(Documents::method13(
                        v2.get().clone(),
                        v0_1.get().clone(),
                    ));
                    let v8: &str = fable_library_rust::String_::LrcStr::as_str(&v6);
                    let v10: std::string::String = String::from(v8);
                    let v12: std::path::PathBuf = std::path::PathBuf::from(v10);
                    {
                        let x: bool = if v12.clone().exists() {
                            v12.is_dir()
                        } else {
                            false
                        };
                        _v4.set(Some(x))
                    }
                    if getValue(_v4.get().clone()) {
                        v2.get().clone()
                    } else {
                        let v29: Option<string> = (Documents::method18())(v2.get().clone());
                        let v32: Documents::US4 =
                            defaultValue(Documents::US4::US4_1, map(Documents::method19(), v29));
                        match &v32 {
                            Documents::US4::US4_0(v32_0_0) => {
                                let v0_1_temp: string = v0_1.get().clone();
                                let v1_1_temp: string = v1_1.get().clone();
                                let v2_temp: string = match &v32 {
                                    Documents::US4::US4_0(x) => x.clone(),
                                    _ => unreachable!(),
                                };
                                v0_1.set(v0_1_temp);
                                v1_1.set(v1_1_temp);
                                v2.set(v2_temp);
                                continue '_method20;
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
                });
            }
        }
        pub fn method17(v0_1: string, v1_1: string) -> string {
            let _v3: MutCell<Option<bool>> = MutCell::new(None::<bool>);
            let v5: string = Documents::method14(Documents::method13(v1_1.clone(), v0_1.clone()));
            let v7: &str = fable_library_rust::String_::LrcStr::as_str(&v5);
            let v9: std::string::String = String::from(v7);
            let v11: std::path::PathBuf = std::path::PathBuf::from(v9);
            {
                let x: bool = if v11.clone().exists() {
                    v11.is_dir()
                } else {
                    false
                };
                _v3.set(Some(x))
            }
            if getValue(_v3.get().clone()) {
                v1_1.clone()
            } else {
                let v28: Option<string> = (Documents::method18())(v1_1.clone());
                let v31: Documents::US4 =
                    defaultValue(Documents::US4::US4_1, map(Documents::method19(), v28));
                match &v31 {
                    Documents::US4::US4_0(v31_0_0) => Documents::method20(
                        v0_1.clone(),
                        v1_1.clone(),
                        match &v31 {
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
        pub fn method21(v0_1: string) -> string {
            v0_1
        }
        pub fn method22() -> string {
            string("^\\\\\\\\\\?\\\\")
        }
        pub fn method23(v0_1: string) -> string {
            v0_1
        }
        pub fn method24() -> string {
            string("")
        }
        pub fn method25(v0_1: i32, v1_1: LrcPtr<Documents::Mut4>) -> bool {
            v1_1.l0.get().clone() < v0_1
        }
        pub fn method26(v0_1: i32, v1_1: LrcPtr<Documents::Mut5>) -> bool {
            v1_1.l0.get().clone() < v0_1
        }
        pub fn method27(v0_1: string) -> string {
            v0_1
        }
        pub fn method28(v0_1: string) -> string {
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
        pub fn method32(v0_1: async_walkdir::DirEntry) -> async_walkdir::DirEntry {
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
        pub fn method33() -> Func1<std::io::Error, std::string::String> {
            Func1::new(move |v: std::io::Error| Documents::closure15((), v))
        }
        pub fn closure16(unitVar: (), v0_1: std::fs::FileType) -> Documents::US6 {
            Documents::US6::US6_0(v0_1)
        }
        pub fn closure17(unitVar: (), v0_1: std::string::String) -> Documents::US6 {
            Documents::US6::US6_1(v0_1)
        }
        pub fn method34(v0_1: std::fs::FileType) -> std::fs::FileType {
            v0_1
        }
        pub fn method35(v0_1: Documents::US5) -> Documents::US5 {
            v0_1
        }
        pub fn method31(
            v0_1: async_walkdir::DirEntry,
        ) -> std::pin::Pin<Box<dyn std::future::Future<Output = Documents::US5> + Send>> {
            let __result = Box::pin(async move {
                //;
                {
                    let v2: async_walkdir::DirEntry = Documents::method32(v0_1.clone());
                    let v4: std::pin::Pin<
                        Box<
                            dyn std::future::Future<
                                    Output = Result<std::fs::FileType, std::io::Error>,
                                > + Send,
                        >,
                    > = Box::pin(async_walkdir::DirEntry::file_type(&v2));
                    let v6: Result<std::fs::FileType, std::io::Error> = v4.await;
                    let v7 = Documents::method33();
                    let v9: Result<std::fs::FileType, std::string::String> = v6.map_err(|x| v7(x));
                    let v12: Documents::US6 = match &v9 {
                        Err(v9_1_0) => Documents::closure17((), v9_1_0.clone()),
                        Ok(v9_0_0) => Documents::closure16((), v9_0_0.clone()),
                    };
                    let v74: Documents::US5 =
                        Documents::method35(if let Documents::US6::US6_0(v12_0_0) = &v12 {
                            let v14: std::fs::FileType = Documents::method34(match &v12 {
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
        pub fn method36(v0_1: async_walkdir::Filtering) -> async_walkdir::Filtering {
            v0_1
        }
        pub fn method30(
            v0_1: async_walkdir::DirEntry,
        ) -> std::pin::Pin<Box<dyn std::future::Future<Output = async_walkdir::Filtering> + Send>>
        {
            let __result = Box::pin(async {
                //;
                {
                    let v2: std::pin::Pin<
                        Box<dyn std::future::Future<Output = Documents::US5> + Send>,
                    > = Documents::method31(v0_1);
                    let v4: Documents::US5 = v2.await;
                    let v14: async_walkdir::Filtering = Documents::method36(match &v4 {
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
            Documents::method30(v0_1)
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
            let v1_1 = Documents::method33();
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
        pub fn method37() -> Func1<Result<async_walkdir::DirEntry, std::io::Error>, Option<string>>
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
        pub fn method38(
            v0_1: Option<CancellationToken>,
            v1_1: string,
            v2: Array<(string, string)>,
            v3: Option<Func1<(bool, string, i32), Arc<Async<()>>>>,
            v4: Option<Func1<std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>, ()>>,
            v5: Option<string>,
        ) -> string {
            v1_1
        }
        pub fn method39() -> (string, string) {
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
        pub fn method40() -> Func1<char, Func1<LrcPtr<Documents::UH0>, LrcPtr<Documents::UH0>>> {
            Func1::new(move |v: char| Documents::closure26((), v))
        }
        pub fn method41(
            v0_1: string,
            v1_1: string,
            v2: LrcPtr<Documents::UH0>,
            v3: Documents::US8,
        ) -> (string, string) {
            let v0_1: MutCell<string> = MutCell::new(v0_1.clone());
            let v1_1: MutCell<string> = MutCell::new(v1_1.clone());
            let v2: MutCell<LrcPtr<Documents::UH0>> = MutCell::new(v2.clone());
            let v3: MutCell<Documents::US8> = MutCell::new(v3.clone());
            '_method41: loop {
                break '_method41 (if let Documents::UH0::UH0_1(v2_1_0, v2_1_1) =
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
                            continue '_method41;
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
                                        continue '_method41;
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
                                            continue '_method41;
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
                                            continue '_method41;
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
                                        continue '_method41;
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
                                        continue '_method41;
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
                                    continue '_method41;
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
                                continue '_method41;
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
                                            continue '_method41;
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
                                                continue '_method41;
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
                                                continue '_method41;
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
                                            continue '_method41;
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
                                            continue '_method41;
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
                                        continue '_method41;
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
                                            continue '_method41;
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
                                            continue '_method41;
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
                                            continue '_method41;
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
                                            continue '_method41;
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
                                        continue '_method41;
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
                                        continue '_method41;
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
                                    continue '_method41;
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
        pub fn method45(
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
                    Documents::method45(
                        match v0_1.as_ref() {
                            Documents::UH1::UH1_1(_, x) => x.clone(),
                            _ => unreachable!(),
                        },
                        v1_1.clone(),
                    ),
                )),
            }
        }
        pub fn method44(
            v0_1: string,
            v1_1: LrcPtr<Documents::UH1>,
            v2: LrcPtr<Documents::UH0>,
            v3: Documents::US10,
        ) -> (LrcPtr<Documents::UH1>, string) {
            let v0_1: MutCell<string> = MutCell::new(v0_1.clone());
            let v1_1: MutCell<LrcPtr<Documents::UH1>> = MutCell::new(v1_1.clone());
            let v2: MutCell<LrcPtr<Documents::UH0>> = MutCell::new(v2.clone());
            let v3: MutCell<Documents::US10> = MutCell::new(v3.clone());
            '_method44: loop {
                break '_method44 (match &v3.get().clone() {
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
                                        Documents::method43(
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
                                                Documents::method43(
                                                    sprintf!("{}\"", v0_1.get().clone()),
                                                    v1_1.get().clone(),
                                                    v108.clone(),
                                                    v3.get().clone(),
                                                    Documents::US10::US10_1('\"'),
                                                )
                                            } else {
                                                if v3.get().clone() == Documents::US10::US10_1('\\')
                                                {
                                                    Documents::method43(
                                                        sprintf!("{}\"", v0_1.get().clone()),
                                                        v1_1.get().clone(),
                                                        v108.clone(),
                                                        v3.get().clone(),
                                                        Documents::US10::US10_1('\"'),
                                                    )
                                                } else {
                                                    Documents::method43(
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
                                                Documents::method43(
                                                    v0_1.get().clone(),
                                                    v1_1.get().clone(),
                                                    v108.clone(),
                                                    v3.get().clone(),
                                                    Documents::US10::US10_2(1_u8),
                                                )
                                            } else {
                                                if v3.get().clone() == Documents::US10::US10_2(0_u8)
                                                {
                                                    Documents::method43(
                                                        sprintf!("{}\"", v0_1.get().clone()),
                                                        v1_1.get().clone(),
                                                        v108.clone(),
                                                        v3.get().clone(),
                                                        Documents::US10::US10_1('\"'),
                                                    )
                                                } else {
                                                    Documents::method43(
                                                        string(""),
                                                        Documents::method45(
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
                                            Documents::method43(
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
                                                continue '_method44;
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
                                                continue '_method44;
                                            }
                                        }
                                    } else {
                                        if '\\' == v107 {
                                            Documents::method43(
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
                                                continue '_method44;
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
                                                continue '_method44;
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
                                            Documents::method45(
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
                                            Documents::method45(
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
                                            Documents::method43(
                                                sprintf!("{}\"", v0_1.get().clone()),
                                                v1_1.get().clone(),
                                                v220.clone(),
                                                v3.get().clone(),
                                                Documents::US10::US10_1('\"'),
                                            )
                                        } else {
                                            if v3.get().clone() == Documents::US10::US10_1('\\') {
                                                Documents::method43(
                                                    sprintf!("{}\"", v0_1.get().clone()),
                                                    v1_1.get().clone(),
                                                    v220.clone(),
                                                    v3.get().clone(),
                                                    Documents::US10::US10_1('\"'),
                                                )
                                            } else {
                                                Documents::method43(
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
                                            Documents::method43(
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
                                                continue '_method44;
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
                                                continue '_method44;
                                            }
                                        }
                                    }
                                } else {
                                    (
                                        if v0_1.get().clone() == string("") {
                                            v1_1.get().clone()
                                        } else {
                                            Documents::method45(
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
                                        Documents::method43(
                                            v0_1.get().clone(),
                                            v1_1.get().clone(),
                                            v270.clone(),
                                            v3.get().clone(),
                                            Documents::US10::US10_2(1_u8),
                                        )
                                    } else {
                                        if '\"' == v269 {
                                            if v3.get().clone() == Documents::US10::US10_2(0_u8) {
                                                Documents::method43(
                                                    sprintf!("{}\"", v0_1.get().clone()),
                                                    v1_1.get().clone(),
                                                    v270.clone(),
                                                    v3.get().clone(),
                                                    Documents::US10::US10_1('\"'),
                                                )
                                            } else {
                                                Documents::method43(
                                                    string(""),
                                                    Documents::method45(
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
                                                continue '_method44;
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
                                                continue '_method44;
                                            }
                                        }
                                    }
                                } else {
                                    (
                                        if v0_1.get().clone() == string("") {
                                            v1_1.get().clone()
                                        } else {
                                            Documents::method45(
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
                                Documents::method43(
                                    string(""),
                                    v1_1.get().clone(),
                                    v5.clone(),
                                    v3.get().clone(),
                                    Documents::US10::US10_1('\"'),
                                )
                            } else {
                                if '\\' == v4 {
                                    Documents::method43(
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
                                                Documents::method45(
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
                                        continue '_method44;
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
                                        continue '_method44;
                                    }
                                }
                            }
                        } else {
                            (
                                if v0_1.get().clone() == string("") {
                                    v1_1.get().clone()
                                } else {
                                    Documents::method45(
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
                                Documents::method43(
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
                                        continue '_method44;
                                    } else {
                                        Documents::method43(
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
                                        continue '_method44;
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
                                                continue '_method44;
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
                                                continue '_method44;
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
                                            continue '_method44;
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
                                        Documents::method45(
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
                                        Documents::method45(
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
        pub fn method43(
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
            '_method43: loop {
                break '_method43 (match &v4.get().clone() {
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
                                        continue '_method43;
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
                                                continue '_method43;
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
                                                    continue '_method43;
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
                                                    continue '_method43;
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
                                                continue '_method43;
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
                                                    continue '_method43;
                                                } else {
                                                    let v0_1_temp: string = string("");
                                                    let v1_1_temp: LrcPtr<Documents::UH1> =
                                                        Documents::method45(
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
                                                    continue '_method43;
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
                                            continue '_method43;
                                        } else {
                                            if ' ' == v108 {
                                                Documents::method44(
                                                    sprintf!("{} ", v0_1.get().clone()),
                                                    v1_1.get().clone(),
                                                    v109.clone(),
                                                    v4.get().clone(),
                                                )
                                            } else {
                                                Documents::method44(
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
                                            continue '_method43;
                                        } else {
                                            if ' ' == v108 {
                                                Documents::method44(
                                                    sprintf!("{} ", v0_1.get().clone()),
                                                    v1_1.get().clone(),
                                                    v109.clone(),
                                                    v4.get().clone(),
                                                )
                                            } else {
                                                Documents::method44(
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
                                            Documents::method45(
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
                                            Documents::method45(
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
                                            continue '_method43;
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
                                                continue '_method43;
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
                                                continue '_method43;
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
                                            continue '_method43;
                                        } else {
                                            if ' ' == v220 {
                                                Documents::method44(
                                                    sprintf!("{} ", v0_1.get().clone()),
                                                    v1_1.get().clone(),
                                                    v221.clone(),
                                                    v4.get().clone(),
                                                )
                                            } else {
                                                Documents::method44(
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
                                            Documents::method45(
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
                                        continue '_method43;
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
                                                continue '_method43;
                                            } else {
                                                let v0_1_temp: string = string("");
                                                let v1_1_temp: LrcPtr<Documents::UH1> =
                                                    Documents::method45(
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
                                                continue '_method43;
                                            }
                                        } else {
                                            if ' ' == v270 {
                                                Documents::method44(
                                                    sprintf!("{} ", v0_1.get().clone()),
                                                    v1_1.get().clone(),
                                                    v271.clone(),
                                                    v4.get().clone(),
                                                )
                                            } else {
                                                Documents::method44(
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
                                            Documents::method45(
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
                                continue '_method43;
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
                                    continue '_method43;
                                } else {
                                    if ' ' == v5 {
                                        Documents::method44(
                                            string(""),
                                            if v0_1.get().clone() == string("") {
                                                v1_1.get().clone()
                                            } else {
                                                Documents::method45(
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
                                        Documents::method44(
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
                                    Documents::method45(
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
                                continue '_method43;
                            } else {
                                if '\"' == v46 {
                                    if if let Documents::US10::US10_0 = &v3.get().clone() {
                                        true
                                    } else {
                                        false
                                    } {
                                        Documents::method44(
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
                                        continue '_method43;
                                    }
                                } else {
                                    if ' ' == v46 {
                                        Documents::method44(
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
                                                continue '_method43;
                                            } else {
                                                Documents::method44(
                                                    sprintf!("{}{}", v0_1.get().clone(), v46),
                                                    v1_1.get().clone(),
                                                    v47.clone(),
                                                    v4.get().clone(),
                                                )
                                            }
                                        } else {
                                            Documents::method44(
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
                                        Documents::method45(
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
                                        Documents::method45(
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
        pub fn method46(v0_1: LrcPtr<Documents::UH1>, v1_1: List<string>) -> List<string> {
            match v0_1.as_ref() {
                Documents::UH1::UH1_0 => v1_1.clone(),
                Documents::UH1::UH1_1(v0_1_1_0, v0_1_1_1) => cons(
                    match v0_1.as_ref() {
                        Documents::UH1::UH1_1(x, _) => x.clone(),
                        _ => unreachable!(),
                    },
                    Documents::method46(
                        match v0_1.as_ref() {
                            Documents::UH1::UH1_1(_, x) => x.clone(),
                            _ => unreachable!(),
                        },
                        v1_1.clone(),
                    ),
                ),
            }
        }
        pub fn method42(v0_1: string) -> Array<string> {
            let _v0: MutCell<Option<Option<string>>> = MutCell::new(None::<Option<string>>);
            _v0.set(Some(Some(v0_1)));
            {
                let v6: Option<string> = getValue(_v0.get().clone());
                let v9: Documents::US4 =
                    defaultValue(Documents::US4::US4_1, map(Documents::method19(), v6));
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
                while Documents::method26(v13, v15.clone()) {
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
                    toArray(Documents::method46(
                        (Documents::method43(
                            string(""),
                            LrcPtr::new(Documents::UH1::UH1_0),
                            foldBack(
                                Func2::new(move |b0: char, b1: LrcPtr<Documents::UH0>| {
                                    (Documents::method40())(b0)(b1)
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
            let v1_1: string = Documents::method14(v0_1);
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
        pub fn method47() -> Func0<string> {
            Func0::new(move || Documents::closure6((), ()))
        }
        pub fn method49(v0_1: string) -> string {
            v0_1
        }
        pub fn method51(
            v0_1: std::sync::Mutex<Option<std::process::Child>>,
        ) -> std::sync::Mutex<Option<std::process::Child>> {
            v0_1
        }
        pub fn closure30(
            unitVar: (),
            v0_1: std::process::Child,
        ) -> std::sync::Arc<std::sync::Mutex<Option<std::process::Child>>> {
            let v4: std::sync::Mutex<Option<std::process::Child>> =
                Documents::method51(std::sync::Mutex::new(Some(v0_1)));
            std::sync::Arc::new(v4)
        }
        pub fn method50(
        ) -> Func1<std::process::Child, std::sync::Arc<std::sync::Mutex<Option<std::process::Child>>>>
        {
            Func1::new(move |v: std::process::Child| Documents::closure30((), v))
        }
        pub fn method52(
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
        pub fn method53(
            v0_1: std::sync::Arc<std::sync::Mutex<Option<std::process::Child>>>,
        ) -> std::sync::Arc<std::sync::Mutex<Option<std::process::Child>>> {
            v0_1
        }
        pub fn method54(
            v0_1: std::sync::Mutex<Option<std::process::ChildStdout>>,
        ) -> std::sync::Mutex<Option<std::process::ChildStdout>> {
            v0_1
        }
        pub fn method55(
            v0_1: std::sync::Mutex<Option<std::process::ChildStderr>>,
        ) -> std::sync::Mutex<Option<std::process::ChildStderr>> {
            v0_1
        }
        pub fn method56(
            v0_1: std::sync::Mutex<Option<std::process::ChildStdin>>,
        ) -> std::sync::Mutex<Option<std::process::ChildStdin>> {
            v0_1
        }
        pub fn method57(
            v0_1: std::sync::Arc<std::sync::mpsc::Receiver<std::string::String>>,
        ) -> std::sync::Arc<std::sync::mpsc::Receiver<std::string::String>> {
            v0_1
        }
        pub fn method58(
            v0_1: std::sync::Mutex<std::sync::mpsc::Sender<std::string::String>>,
        ) -> std::sync::Mutex<std::sync::mpsc::Sender<std::string::String>> {
            v0_1
        }
        pub fn method59(
            v0_1: std::sync::Mutex<std::sync::Arc<std::sync::mpsc::Receiver<std::string::String>>>,
        ) -> std::sync::Mutex<std::sync::Arc<std::sync::mpsc::Receiver<std::string::String>>>
        {
            v0_1
        }
        pub fn method60(
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
            let v2 = Documents::method33();
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
        pub fn method61(
            v0_1: std::sync::Arc<std::sync::Mutex<std::sync::mpsc::Sender<std::string::String>>>,
        ) -> Func1<Result<std::string::String, std::io::Error>, ()> {
            Func1::new({
                let v0_1 = v0_1.clone();
                move |v: Result<std::string::String, std::io::Error>| {
                    Documents::closure34(v0_1.clone(), v)
                }
            })
        }
        pub fn method62(
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
            let v2 = Documents::method33();
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
        pub fn method63(
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
        pub fn method64() -> Func1<
            Func1<std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>, ()>,
            Documents::US14,
        > {
            Func1::new(
                move |v: Func1<std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>, ()>| {
                    Documents::closure41((), v)
                },
            )
        }
        pub fn method65(
            v0_1: std::sync::Mutex<std::process::ChildStdin>,
        ) -> std::sync::Mutex<std::process::ChildStdin> {
            v0_1
        }
        pub fn closure42(
            unitVar: (),
            v0_1: std::process::ChildStdin,
        ) -> std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>> {
            let v3: std::sync::Mutex<std::process::ChildStdin> =
                Documents::method65(std::sync::Mutex::new(v0_1));
            std::sync::Arc::new(v3)
        }
        pub fn closure43(
            unitVar: (),
            v0_1: std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>,
        ) -> Documents::US15 {
            Documents::US15::US15_0(v0_1)
        }
        pub fn method66(
        ) -> Func1<std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>, Documents::US15>
        {
            Func1::new(
                move |v: std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>| {
                    Documents::closure43((), v)
                },
            )
        }
        pub fn method67(
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
        pub fn method68(v0_: i32, v0__1: string) -> LrcPtr<(i32, string)> {
            LrcPtr::new((v0_, v0__1))
        }
        pub fn method48(
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
                        defaultValue(Documents::US4::US4_1, map(Documents::method19(), v5));
                    let v35: &mut std::process::Command = match &v29 {
                        Documents::US4::US4_0(v29_0_0) => {
                            let v31: string = Documents::method49(match &v29 {
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
                    let v40 = Documents::method50();
                    let v41: Result<std::process::Child, std::io::Error> = Documents::method52(v39);
                    let v43: Result<
                        std::sync::Arc<std::sync::Mutex<Option<std::process::Child>>>,
                        std::io::Error,
                    > = v41.map(|x| v40(x));
                    let v44 = Documents::method33();
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
                                Documents::method53(v49_0_0.clone());
                            let v53: std::process::ChildStdout =
                                v51.lock().unwrap().as_mut().unwrap().stdout.take().unwrap();
                            let v55: std::process::ChildStderr =
                                v51.lock().unwrap().as_mut().unwrap().stderr.take().unwrap();
                            let v57: std::process::ChildStdin =
                                v51.lock().unwrap().as_mut().unwrap().stdin.take().unwrap();
                            let v61: std::sync::Mutex<Option<std::process::ChildStdout>> =
                                Documents::method54(std::sync::Mutex::new(Some(v53)));
                            let v63: std::sync::Arc<
                                std::sync::Mutex<Option<std::process::ChildStdout>>,
                            > = std::sync::Arc::new(v61);
                            let v67: std::sync::Mutex<Option<std::process::ChildStderr>> =
                                Documents::method55(std::sync::Mutex::new(Some(v55)));
                            let v69: std::sync::Arc<
                                std::sync::Mutex<Option<std::process::ChildStderr>>,
                            > = std::sync::Arc::new(v67);
                            let v73: std::sync::Mutex<Option<std::process::ChildStdin>> =
                                Documents::method56(std::sync::Mutex::new(Some(v57)));
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
                            > = Documents::method57(patternInput.1.clone());
                            let v81: bool = true;
                            let v79 = v79;
                            let v84: std::sync::Mutex<
                                std::sync::mpsc::Sender<std::string::String>,
                            > = Documents::method58(std::sync::Mutex::new(patternInput.0.clone()));
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
                            > = Documents::method59(std::sync::Mutex::new(v79));
                            let v95: std::sync::Arc<
                                std::sync::Mutex<
                                    std::sync::Arc<std::sync::mpsc::Receiver<std::string::String>>,
                                >,
                            > = std::sync::Arc::new(v93);
                            let v97: std::thread::JoinHandle<()> = std::thread::spawn(move || {
                                //;
                                let v99: std::process::ChildStdout =
                                    v63.lock().unwrap().take().unwrap();
                                let v101: std::io::BufReader<std::process::ChildStdout> =
                                    std::io::BufReader::new(v99);
                                let v103: std::io::Lines<
                                    std::io::BufReader<std::process::ChildStdout>,
                                > = std::io::BufRead::lines(v101);
                                let v106: std::sync::Mutex<
                                    std::io::Lines<std::io::BufReader<std::process::ChildStdout>>,
                                > = Documents::method60(std::sync::Mutex::new(v103));
                                let v108: std::sync::Arc<
                                    std::sync::Mutex<
                                        std::io::Lines<
                                            std::io::BufReader<std::process::ChildStdout>,
                                        >,
                                    >,
                                > = std::sync::Arc::new(v106);
                                let v109 = Documents::method61(v88);
                                let v111: bool = true;
                                for line in v108.lock().unwrap().by_ref() {
                                    v109(line)
                                }
                                let v113: bool = true;
                            });
                            let v115: std::thread::JoinHandle<()> = std::thread::spawn(move || {
                                //;
                                let v117: std::process::ChildStderr =
                                    v69.lock().unwrap().take().unwrap();
                                let v119: std::io::BufReader<std::process::ChildStderr> =
                                    std::io::BufReader::new(v117);
                                let v121: std::io::Lines<
                                    std::io::BufReader<std::process::ChildStderr>,
                                > = std::io::BufRead::lines(v119);
                                let v124: std::sync::Mutex<
                                    std::io::Lines<std::io::BufReader<std::process::ChildStderr>>,
                                > = Documents::method62(std::sync::Mutex::new(v121));
                                let v126: std::sync::Arc<
                                    std::sync::Mutex<
                                        std::io::Lines<
                                            std::io::BufReader<std::process::ChildStderr>,
                                        >,
                                    >,
                                > = std::sync::Arc::new(v124);
                                let v127 = Documents::method63(v86);
                                let v129: bool = true;
                                for line in v126.lock().unwrap().by_ref() {
                                    v127(line)
                                }
                                let v131: bool = true;
                            });
                            let v134: Documents::US14 = defaultValue(
                                Documents::US14::US14_1,
                                map(Documents::method64(), v4),
                            );
                            match &v134 {
                                Documents::US14::US14_0(v134_0_0) => {
                                    let v137: Option<std::process::ChildStdin> =
                                        v75.lock().unwrap().take();
                                    let v140: Option<
                                        std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>,
                                    > = v137.map(|x| {
                                        Func1::new(move |v_2: std::process::ChildStdin| {
                                            Documents::closure42((), v_2)
                                        })(x)
                                    });
                                    let v143: Documents::US15 = defaultValue(
                                        Documents::US15::US15_1,
                                        map(Documents::method66(), v140),
                                    );
                                    match &v143 {
                                        Documents::US15::US15_0(v143_0_0) => {
                                            let v144: std::sync::Arc<
                                                std::sync::Mutex<std::process::ChildStdin>,
                                            > = match &v143 {
                                                Documents::US15::US15_0(x) => x.clone(),
                                                _ => unreachable!(),
                                            };
                                            (match &v134 {
                                                Documents::US14::US14_0(x) => x.clone(),
                                                _ => unreachable!(),
                                            })(
                                                v144.clone()
                                            );
                                            {
                                                let v146: Result<
                                                    std::sync::MutexGuard<std::process::ChildStdin>,
                                                    std::sync::PoisonError<
                                                        std::sync::MutexGuard<
                                                            std::process::ChildStdin,
                                                        >,
                                                    >,
                                                > = v144.lock();
                                                let v149: std::sync::MutexGuard<
                                                    std::process::ChildStdin,
                                                > = Documents::method67(v146.unwrap());
                                                let v151: bool = true;
                                                let mut v149 = v149;
                                                let v153: bool = true;
                                                std::io::Write::flush(&mut *v149).unwrap();
                                                ()
                                            }
                                        }
                                        _ => (),
                                    }
                                }
                                _ => (),
                            }
                            {
                                let v155: Result<std::process::Output, std::io::Error> =
                                    v51.lock().unwrap().take().unwrap().wait_with_output();
                                let v156 = Documents::method33();
                                let v158: Result<std::process::Output, std::string::String> =
                                    v155.map_err(|x| v156(x));
                                let v160: bool = true;
                                v97.join().unwrap();
                                let v162: bool = true;
                                v115.join().unwrap();
                                let v165: Documents::US16 = match &v158 {
                                    Err(v158_1_0) => Documents::closure45((), v158_1_0.clone()),
                                    Ok(v158_0_0) => Documents::closure44((), v158_0_0.clone()),
                                };
                                match &v165 {
                                    Documents::US16::US16_0(v165_0_0) => (
                                        v165_0_0.clone().status.code().unwrap(),
                                        Documents::US3::US3_1,
                                        Documents::US12::US12_0(v95),
                                    ),
                                    Documents::US16::US16_1(v165_1_0) => {
                                        let v171: std::string::String = v165_1_0.clone();
                                        Documents::method3(
                                            Documents::US0::US0_4,
                                            Func0::new({
                                                let v171 = v171.clone();
                                                move || Documents::closure46(v171.clone(), ())
                                            }),
                                            Func0::new(move || Documents::closure6((), ())),
                                        );
                                        (
                                            -2_i32,
                                            Documents::US3::US3_0(v171.clone()),
                                            Documents::US12::US12_1,
                                        )
                                    }
                                }
                            }
                        }
                        Documents::US11::US11_1(v49_1_0) => {
                            let v183: std::string::String = v49_1_0.clone();
                            Documents::method3(
                                Documents::US0::US0_4,
                                Func0::new({
                                    let v183 = v183.clone();
                                    move || Documents::closure33(v183.clone(), ())
                                }),
                                Func0::new(move || Documents::closure6((), ())),
                            );
                            (
                                -1_i32,
                                Documents::US3::US3_0(v183.clone()),
                                Documents::US12::US12_1,
                            )
                        }
                    };
                    let v194: Documents::US12 = patternInput_1.2.clone();
                    let v193: Documents::US3 = patternInput_1.1.clone();
                    let v192: i32 = patternInput_1.0.clone();
                    let v201: Documents::US3 = match &v194 {
                        Documents::US12::US12_0(v194_0_0) => Documents::US3::US3_0(
                            match &v194 {
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
                    let v208: Documents::US4 = match &v201 {
                        Documents::US3::US3_0(v201_0_0) => Documents::US4::US4_0(
                            fable_library_rust::String_::fromString(match &v201 {
                                Documents::US3::US3_0(x) => x.clone(),
                                _ => unreachable!(),
                            }),
                        ),
                        _ => Documents::US4::US4_1,
                    };
                    let v215: Documents::US4 = match &v193 {
                        Documents::US3::US3_0(v193_0_0) => Documents::US4::US4_0(
                            fable_library_rust::String_::fromString(match &v193 {
                                Documents::US3::US3_0(x) => x.clone(),
                                _ => unreachable!(),
                            }),
                        ),
                        _ => Documents::US4::US4_1,
                    };
                    let v219: string = match &v215 {
                        Documents::US4::US4_0(v215_0_0) => match &v215 {
                            Documents::US4::US4_0(x) => x.clone(),
                            _ => unreachable!(),
                        },
                        _ => string(""),
                    };
                    let v222: string = match &v208 {
                        Documents::US4::US4_0(v208_0_0) => match &v208 {
                            Documents::US4::US4_0(x) => x.clone(),
                            _ => unreachable!(),
                        },
                        _ => v219,
                    };
                    Documents::method3(
                        Documents::US0::US0_0,
                        Func0::new({
                            let v192 = v192.clone();
                            let v222 = v222.clone();
                            move || Documents::closure47(v192, v222.clone(), ())
                        }),
                        Func0::new(move || Documents::closure6((), ())),
                    );
                    {
                        let v226: LrcPtr<(i32, string)> = LrcPtr::new((v192, v222.clone()));
                        let v227: LrcPtr<(i32, string)> =
                            Documents::method68(v226.0.clone(), v226.1.clone());
                        v227
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
        pub fn method69() -> Func1<Func1<(bool, string, i32), Arc<Async<()>>>, Documents::US17> {
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
        pub fn method70() -> Func1<CancellationToken, Documents::US18> {
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
        pub fn method71() -> string {
            string("\n")
        }
        pub fn closure56(v0_1: i32, v1_1: string, unitVar: ()) -> string {
            sprintf!(
                "execute_with_options_async / exit_code: {} / output.Length: {}",
                v0_1,
                length(v1_1)
            )
        }
        pub fn method72(v0_1: string, v1_1: string, v2: string) -> (string, string) {
            let _v3: MutCell<Option<string>> = MutCell::new(None::<string>);
            let v5: string = Documents::method14(v1_1.clone());
            let v7: &str = fable_library_rust::String_::LrcStr::as_str(&v5);
            let v9: std::string::String = String::from(v7);
            let v11: std::path::PathBuf = std::path::PathBuf::from(v9);
            let v13: Option<&std::ffi::OsStr> = v11.file_name();
            let v15: &std::ffi::OsStr = v13.unwrap();
            let v17: std::ffi::OsString = v15.to_os_string();
            let v19: Option<&str> = v17.to_str();
            let v21: &str = v19.unwrap();
            let v23: std::string::String = String::from(v21);
            {
                let x: string = fable_library_rust::String_::fromString(v23);
                _v3.set(Some(x))
            }
            {
                let v33: string = Documents::method13(v2, getValue(_v3.get().clone()));
                let v37: string = getSlice(
                    v1_1.clone(),
                    Some(0_i32),
                    Some(lastIndexOf(v1_1.clone(), string(".")) - 1_i32),
                );
                let v40: string = getSlice(
                    v33.clone(),
                    Some(0_i32),
                    Some(lastIndexOf(v33.clone(), string(".")) - 1_i32),
                );
                let v43: bool = endsWith(v0_1.clone(), string(".md"), false) == false;
                (
                    if v43 {
                        sprintf!("{}.{}", v33, v0_1.clone())
                    } else {
                        sprintf!("{}.{}", v40, v0_1.clone())
                    },
                    if v43 {
                        sprintf!("{}.{}", v1_1, v0_1.clone())
                    } else {
                        sprintf!("{}.{}", v37, v0_1)
                    },
                )
            }
        }
        pub fn closure57(unitVar: (), unitVar_1: ()) -> string {
            let v0_1: string =
                string("documents.run / par_map / origin_hash |> sm\'.contains local_git_hash |> not / hash2 = None || hash1 <>. (hash2 |> optionm.value)");
            v0_1
        }
        pub fn closure58(
            v0_1: string,
            v1_1: string,
            v2: string,
            v3: string,
            v4: i32,
            v5: string,
            v6: string,
            v7: i32,
            v8: string,
            v9: string,
            v10: Documents::US4,
            unitVar: (),
        ) -> string {
            sprintf!("file: {} / real_path: {} / relative_path: {} / origin_hash_exit_code: {} / origin_hash: {} / local_git_hash_exit_code: {} / local_git_hash: {} / hash1: {} / hash2: {:?} / dist_path: {} / cache_path: {} / {}",
                     v1_1, v2, v0_1, v4, v3, v7, v6, v9, v10, v5, v8,
                     Documents::closure6((), ()))
        }
        pub fn method73(v0_1: string) -> string {
            v0_1
        }
        pub fn method75(v0_1: i32, v1_1: LrcPtr<Documents::Mut6>) -> bool {
            v1_1.l0.get().clone() < v0_1
        }
        pub fn method76(v0_1: string) -> string {
            v0_1
        }
        pub fn method77(
            v0_1: std::sync::MutexGuard<std::process::ChildStdin>,
        ) -> std::sync::MutexGuard<std::process::ChildStdin> {
            v0_1
        }
        pub fn closure61(
            v0_1: string,
            v1_1: std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>,
        ) {
            let v3: Result<
                std::sync::MutexGuard<std::process::ChildStdin>,
                std::sync::PoisonError<std::sync::MutexGuard<std::process::ChildStdin>>,
            > = v1_1.lock();
            let v5: std::sync::MutexGuard<std::process::ChildStdin> = v3.unwrap();
            let v6: string = Documents::method76(v0_1);
            let v8: &[u8] = v6.as_bytes();
            let v9: std::sync::MutexGuard<std::process::ChildStdin> = Documents::method77(v5);
            let v11: bool = true;
            let mut v9 = v9;
            let v13: bool = true;
            std::io::Write::write_all(&mut *v9, v8).unwrap();
            ()
        }
        pub fn method78(v0_1: i32, v1_1: LrcPtr<Documents::Mut7>) -> bool {
            v1_1.l0.get().clone() < v0_1
        }
        pub fn method79(v0_1: string) -> string {
            v0_1
        }
        pub fn closure62(unitVar: (), unitVar_1: ()) -> string {
            string("documents.hangul")
        }
        pub fn closure63(v0_1: string, v1_1: i32, v2: string, unitVar: ()) -> string {
            sprintf!(
                "exit_code: {:?} / result_len: {} / output_path: {} / {}",
                v1_1,
                length(v2),
                v0_1,
                Documents::closure6((), ())
            )
        }
        pub fn method74(v0_1: string, v1_1: string, v2: string, v3: string) -> Documents::US21 {
            let _v4: MutCell<Option<string>> = MutCell::new(None::<string>);
            let _v6: MutCell<Option<Vec<u8>>> = MutCell::new(None::<Vec<u8>>);
            {
                let x: Vec<u8> = std::fs::read(&*v3).unwrap();
                _v6.set(Some(x))
            }
            {
                let v17: Vec<u8> = getValue(_v6.get().clone());
                let v19: Result<std::string::String, std::string::FromUtf8Error> =
                    std::string::String::from_utf8(v17);
                let v21: std::string::String = v19.unwrap();
                {
                    let x_1: string = fable_library_rust::String_::fromString(v21);
                    _v4.set(Some(x_1))
                }
                {
                    let v31: Array<string> =
                        split(getValue(_v4.get().clone()), string("\n"), -1_i32, 0_i32);
                    let v32: i32 = count(v31.clone());
                    let v33: Array<string> = new_init(&string(""), v32);
                    let v34: LrcPtr<Documents::Mut5> = LrcPtr::new(Documents::Mut5 {
                        l0: MutCell::new(0_i32),
                    });
                    while Documents::method26(v32, v34.clone()) {
                        let v36: i32 = v34.l0.get().clone();
                        let v38: string = trim(v31[v36].clone());
                        v33.get_mut()[v36 as usize] = v38;
                        {
                            let v39: i32 = v36 + 1_i32;
                            v34.l0.set(v39);
                            ()
                        }
                    }
                    {
                        let v40: i32 = count(v33.clone());
                        let v41: Array<string> = new_init(&string(""), v40);
                        let v42: LrcPtr<Documents::Mut6> = LrcPtr::new(Documents::Mut6 {
                            l0: MutCell::new(0_i32),
                            l1: MutCell::new(0_i32),
                        });
                        while Documents::method75(v40, v42.clone()) {
                            let v44: i32 = v42.l0.get().clone();
                            let v45: i32 = v42.l1.get().clone();
                            let v46: string = v33[v44].clone();
                            let v50: i32 = if string("") != v46.clone() {
                                v41.get_mut()[v45 as usize] = v46;
                                v45 + 1_i32
                            } else {
                                v45
                            };
                            let v51: i32 = v44 + 1_i32;
                            v42.l0.set(v51);
                            v42.l1.set(v50);
                            ()
                        }
                        {
                            let v52: i32 = v42.l1.get().clone();
                            let v53: Array<string> = new_init(&string(""), v52);
                            let v54: LrcPtr<Documents::Mut5> = LrcPtr::new(Documents::Mut5 {
                                l0: MutCell::new(0_i32),
                            });
                            while Documents::method26(v52, v54.clone()) {
                                let v56: i32 = v54.l0.get().clone();
                                let v57: string = v41[v56].clone();
                                v53.get_mut()[v56 as usize] = v57;
                                {
                                    let v58: i32 = v56 + 1_i32;
                                    v54.l0.set(v58);
                                    ()
                                }
                            }
                            {
                                let v59: LrcPtr<dyn IEnumerable_1<string>> = delay(Func0::new({
                                    let v53 = v53.clone();
                                    move || {
                                        map_1(
                                            Func1::new({
                                                let v53 = v53.clone();
                                                move |i: i32| v53[i].clone()
                                            }),
                                            rangeNumeric(0_i32, 1_i32, count(v53.clone()) - 1_i32),
                                        )
                                    }
                                }));
                                let v64: string =
                                    sprintf!("{}\n\n", join(Documents::method71(), toArray_1(v59)));
                                let v65: Option<string> = None::<string>;
                                let v66: Option<CancellationToken> = None::<CancellationToken>;
                                let v67: Array<(string, string)> = new_empty::<(string, string)>();
                                let v68 = None::<Func1<(bool, string, i32), Arc<Async<()>>>>;
                                let _v70: MutCell<Option<bool>> = MutCell::new(None::<bool>);
                                {
                                    let x_2: bool = cfg!(windows);
                                    _v70.set(Some(x_2))
                                }
                                {
                                    let v87: string = sprintf!(
                                        "{} {}",
                                        Documents::method13(
                                            v0_1,
                                            sprintf!(
                                                "../vault/deps/hangulize/cmd/hangulize/hangulize{}",
                                                if getValue(_v70.get().clone()) {
                                                    string(".exe")
                                                } else {
                                                    string("")
                                                }
                                            )
                                        ),
                                        v1_1
                                    );
                                    let v89 = Some(Func1::new({
                                        let v64 = v64.clone();
                                        move |v: std::sync::Arc<
                                            std::sync::Mutex<std::process::ChildStdin>,
                                        >| {
                                            Documents::closure61(v64.clone(), v)
                                        }
                                    }));
                                    let _v90: MutCell<Option<(i32, string)>> =
                                        MutCell::new(None::<(i32, string)>);
                                    let v92: string = Documents::method38(
                                        v66.clone(),
                                        v87.clone(),
                                        v67.clone(),
                                        v68.clone(),
                                        v89.clone(),
                                        v65.clone(),
                                    );
                                    let patternInput: (string, string) = Documents::method39();
                                    let v95: i32 = length(v92.clone());
                                    let v96: Array<char> = new_init(&'\u{0000}', v95);
                                    let v97: LrcPtr<Documents::Mut5> =
                                        LrcPtr::new(Documents::Mut5 {
                                            l0: MutCell::new(0_i32),
                                        });
                                    while Documents::method26(v95, v97.clone()) {
                                        let v99: i32 = v97.l0.get().clone();
                                        let v100: char = getCharAt(v92.clone(), v99);
                                        v96.get_mut()[v99 as usize] = v100;
                                        {
                                            let v101: i32 = v99 + 1_i32;
                                            v97.l0.set(v101);
                                            ()
                                        }
                                    }
                                    {
                                        let v103: List<char> = ofArray(v96.clone());
                                        let patternInput_1: (string, string) = Documents::method41(
                                            patternInput.1.clone(),
                                            patternInput.0.clone(),
                                            foldBack(
                                                Func2::new(
                                                    move |b0: char, b1: LrcPtr<Documents::UH0>| {
                                                        (Documents::method40())(b0)(b1)
                                                    },
                                                ),
                                                v103,
                                                LrcPtr::new(Documents::UH0::UH0_0),
                                            ),
                                            Documents::US8::US8_0,
                                        );
                                        let v111: string = patternInput_1.0.clone();
                                        let v113: Array<string> =
                                            Documents::method42(patternInput_1.1.clone());
                                        let v115: Vec<string> = v113.to_vec();
                                        let v118: Vec<std::string::String> = v115
                                            .iter()
                                            .map(|x| {
                                                Func1::new(move |v_1: string| {
                                                    Documents::closure28((), v_1)
                                                })(
                                                    x.clone()
                                                )
                                            })
                                            .collect();
                                        Documents::method3(
                                            Documents::US0::US0_1,
                                            Func0::new({
                                                let v111 = v111.clone();
                                                let v118 = v118.clone();
                                                let v65 = v65.clone();
                                                let v66 = v66.clone();
                                                let v67 = v67.clone();
                                                let v68 = v68.clone();
                                                let v87 = v87.clone();
                                                let v89 = v89.clone();
                                                move || {
                                                    Documents::closure29(
                                                        v66.clone(),
                                                        v87.clone(),
                                                        v67.clone(),
                                                        v68.clone(),
                                                        v89.clone(),
                                                        v65.clone(),
                                                        v111.clone(),
                                                        v118.clone(),
                                                        (),
                                                    )
                                                }
                                            }),
                                            Documents::method47(),
                                        );
                                        {
                                            let v122: std::pin::Pin<
                                                Box<
                                                    dyn std::future::Future<
                                                        Output = LrcPtr<(i32, string)>,
                                                    >,
                                                >,
                                            > = Documents::method48(
                                                v66.clone(),
                                                v87.clone(),
                                                v67.clone(),
                                                v68.clone(),
                                                v89.clone(),
                                                v65.clone(),
                                                v111.clone(),
                                                v118.clone(),
                                            );
                                            let v124: LrcPtr<(i32, string)> =
                                                futures_lite::future::block_on(v122);
                                            _v90.set(Some((v124.0.clone(), v124.1.clone())));
                                            {
                                                let patternInput_2: (i32, string) =
                                                    getValue(_v90.get().clone());
                                                let v305: i32 = patternInput_2.0.clone();
                                                let v307: Array<string> = split(
                                                    patternInput_2.1.clone(),
                                                    string("\n"),
                                                    -1_i32,
                                                    0_i32,
                                                );
                                                let v308: i32 = count(v307.clone());
                                                let v310: LrcPtr<Documents::Mut7> =
                                                    LrcPtr::new(Documents::Mut7 {
                                                        l0: MutCell::new(0_i32),
                                                        l1: MutCell::new(string("")),
                                                        l2: MutCell::new(0_i32),
                                                        l3: MutCell::new(0_i32),
                                                    });
                                                while Documents::method78(v40, v310.clone()) {
                                                    let v312: i32 = v310.l0.get().clone();
                                                    let matchValue: string = v310.l1.get().clone();
                                                    let matchValue_1: i32 = v310.l2.get().clone();
                                                    let v315: i32 = v310.l3.get().clone();
                                                    let v314: i32 = matchValue_1;
                                                    let v313: string = matchValue;
                                                    let patternInput_4: (string, i32, i32) =
                                                        if v33[v312].clone() == string("") {
                                                            (
                                                                sprintf!("{}\n", v313.clone()),
                                                                v314 + 1_i32,
                                                                v315 + 1_i32,
                                                            )
                                                        } else {
                                                            let v321: i32 = v314 - v315;
                                                            (
                                                                if v321 >= v308 {
                                                                    v313.clone()
                                                                } else {
                                                                    let v323: string =
                                                                        v307[v321].clone();
                                                                    if v321 == v308 - 1_i32 {
                                                                        sprintf!(
                                                                            "{}{}",
                                                                            v313.clone(),
                                                                            v323.clone()
                                                                        )
                                                                    } else {
                                                                        sprintf!(
                                                                            "{}{}\n", v313, v323
                                                                        )
                                                                    }
                                                                },
                                                                v314 + 1_i32,
                                                                v315,
                                                            )
                                                        };
                                                    let v334: i32 = v312 + 1_i32;
                                                    v310.l0.set(v334);
                                                    v310.l1.set(patternInput_4.0.clone());
                                                    v310.l2.set(patternInput_4.1.clone());
                                                    v310.l3.set(patternInput_4.2.clone());
                                                    ()
                                                }
                                                {
                                                    let matchValue_3: string =
                                                        v310.l1.get().clone();
                                                    let matchValue_4: i32 = v310.l2.get().clone();
                                                    let matchValue_5: i32 = v310.l3.get().clone();
                                                    let v335: string = matchValue_3;
                                                    let _v338: MutCell<Option<()>> =
                                                        MutCell::new(None::<()>);
                                                    std::fs::write(&*v2.clone(), &*v335.clone())
                                                        .unwrap();
                                                    _v338.set(Some(()));
                                                    getValue(_v338.get().clone());
                                                    Documents::method3(
                                                        Documents::US0::US0_2,
                                                        Func0::new(move || {
                                                            Documents::closure62((), ())
                                                        }),
                                                        Func0::new({
                                                            let v2 = v2.clone();
                                                            let v305 = v305.clone();
                                                            let v335 = v335.clone();
                                                            move || {
                                                                Documents::closure63(
                                                                    v2.clone(),
                                                                    v305,
                                                                    v335.clone(),
                                                                    (),
                                                                )
                                                            }
                                                        }),
                                                    );
                                                    Documents::US21::US21_0(v305, v335.clone())
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
        pub fn closure64(unitVar: (), unitVar_1: ()) -> string {
            string("documents.files_fn / error")
        }
        pub fn closure65(v0_1: string, v1_1: i32, unitVar: ()) -> string {
            sprintf!(
                "exit_code: {:?} / result: {} / {}",
                v1_1,
                v0_1,
                Documents::closure6((), ())
            )
        }
        pub fn closure60(
            v0_1: string,
            v1_1: string,
            v2: string,
            v3: string,
            v4: string,
            v5: string,
        ) -> Documents::US19 {
            let patternInput: (string, string) = Documents::method72(v5, v4.clone(), v0_1);
            let v7: string = patternInput.1.clone();
            let v6: string = patternInput.0.clone();
            let _v8: MutCell<Option<bool>> = MutCell::new(None::<bool>);
            let v10: string = Documents::method14(v7.clone());
            let v12: &str = fable_library_rust::String_::LrcStr::as_str(&v10);
            let v14: std::string::String = String::from(v12);
            let v16: std::path::PathBuf = std::path::PathBuf::from(v14);
            {
                let x: bool = if v16.clone().exists() {
                    v16.is_file()
                } else {
                    false
                };
                _v8.set(Some(x))
            }
            if (if if getValue(_v8.get().clone()) {
                let _v32: MutCell<Option<bool>> = MutCell::new(None::<bool>);
                let v34: string = Documents::method14(v6.clone());
                let v36: &str = fable_library_rust::String_::LrcStr::as_str(&v34);
                let v38: std::string::String = String::from(v36);
                let v40: std::path::PathBuf = std::path::PathBuf::from(v38);
                {
                    let x_1: bool = if v40.clone().exists() {
                        v40.is_file()
                    } else {
                        false
                    };
                    _v32.set(Some(x_1))
                }
                getValue(_v32.get().clone())
            } else {
                false
            } {
                let _v56: MutCell<Option<string>> = MutCell::new(None::<string>);
                let v58: string = Documents::method22();
                let v59: string = Documents::method23(v7.clone());
                let v60: string = Documents::method24();
                let v62: std::borrow::Cow<str> =
                    regex::Regex::new(&v58).unwrap().replace_all(&v59, &*v60);
                let v64: std::string::String = String::from(v62);
                {
                    let x_2: string = fable_library_rust::String_::fromString(v64);
                    _v56.set(Some(x_2))
                }
                {
                    let v74: string = getValue(_v56.get().clone());
                    let v79: Option<string> = None::<string>;
                    let v80: Option<CancellationToken> = None::<CancellationToken>;
                    let v81: Array<(string, string)> = new_empty::<(string, string)>();
                    let v82 = None::<Func1<(bool, string, i32), Arc<Async<()>>>>;
                    let v83 = None::<
                        Func1<std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>, ()>,
                    >;
                    let v84: string = sprintf!(
                        "pwsh -c \"(Get-FileHash \\\"{}\\\" -Algorithm SHA256).Hash\"",
                        replace(
                            sprintf!(
                                "{}{}",
                                toLower(ofChar(getCharAt(v74.clone(), 0_i32))),
                                getSlice(v74, Some(1_i32), None::<i32>)
                            ),
                            string("\\"),
                            string("/")
                        )
                    );
                    let _v85: MutCell<Option<(i32, string)>> = MutCell::new(None::<(i32, string)>);
                    let v87: string = Documents::method38(
                        v80.clone(),
                        v84.clone(),
                        v81.clone(),
                        v82.clone(),
                        v83.clone(),
                        v79.clone(),
                    );
                    let patternInput_1: (string, string) = Documents::method39();
                    let v90: i32 = length(v87.clone());
                    let v91: Array<char> = new_init(&'\u{0000}', v90);
                    let v92: LrcPtr<Documents::Mut5> = LrcPtr::new(Documents::Mut5 {
                        l0: MutCell::new(0_i32),
                    });
                    while Documents::method26(v90, v92.clone()) {
                        let v94: i32 = v92.l0.get().clone();
                        let v95: char = getCharAt(v87.clone(), v94);
                        v91.get_mut()[v94 as usize] = v95;
                        {
                            let v96: i32 = v94 + 1_i32;
                            v92.l0.set(v96);
                            ()
                        }
                    }
                    {
                        let v98: List<char> = ofArray(v91.clone());
                        let patternInput_2: (string, string) = Documents::method41(
                            patternInput_1.1.clone(),
                            patternInput_1.0.clone(),
                            foldBack(
                                Func2::new(move |b0: char, b1: LrcPtr<Documents::UH0>| {
                                    (Documents::method40())(b0)(b1)
                                }),
                                v98,
                                LrcPtr::new(Documents::UH0::UH0_0),
                            ),
                            Documents::US8::US8_0,
                        );
                        let v106: string = patternInput_2.0.clone();
                        let v108: Array<string> = Documents::method42(patternInput_2.1.clone());
                        let v110: Vec<string> = v108.to_vec();
                        fn v112(v: string) -> std::string::String {
                            Documents::closure28((), v)
                        }
                        let v113: Vec<std::string::String> =
                            v110.iter().map(|x| Func1::from(v112)(x.clone())).collect();
                        Documents::method3(
                            Documents::US0::US0_1,
                            Func0::new({
                                let v106 = v106.clone();
                                let v113 = v113.clone();
                                let v79 = v79.clone();
                                let v80 = v80.clone();
                                let v81 = v81.clone();
                                let v82 = v82.clone();
                                let v83 = v83.clone();
                                let v84 = v84.clone();
                                move || {
                                    Documents::closure29(
                                        v80.clone(),
                                        v84.clone(),
                                        v81.clone(),
                                        v82.clone(),
                                        v83.clone(),
                                        v79.clone(),
                                        v106.clone(),
                                        v113.clone(),
                                        (),
                                    )
                                }
                            }),
                            Documents::method47(),
                        );
                        {
                            let v117: std::pin::Pin<
                                Box<dyn std::future::Future<Output = LrcPtr<(i32, string)>>>,
                            > = Documents::method48(
                                v80.clone(),
                                v84.clone(),
                                v81.clone(),
                                v82.clone(),
                                v83.clone(),
                                v79.clone(),
                                v106.clone(),
                                v113.clone(),
                            );
                            let v119: LrcPtr<(i32, string)> = futures_lite::future::block_on(v117);
                            _v85.set(Some((v119.0.clone(), v119.1.clone())));
                            {
                                let patternInput_3: (i32, string) = getValue(_v85.get().clone());
                                let v300: string = patternInput_3.1.clone();
                                let v304: Documents::US20 = if patternInput_3.0.clone() == 0_i32 {
                                    Documents::US20::US20_0(v300.clone())
                                } else {
                                    Documents::US20::US20_1(v300)
                                };
                                let v310: string = match &v304 {
                                    Documents::US20::US20_0(v304_0_0) => v304_0_0.clone(),
                                    Documents::US20::US20_1(v304_1_0) => panic!(
                                        "{}",
                                        sprintf!(
                                            "resultm.get / Result value was Error: {}",
                                            v304_1_0.clone()
                                        ),
                                    ),
                                };
                                let _v311: MutCell<Option<string>> = MutCell::new(None::<string>);
                                let v313: string = Documents::method22();
                                let v314: string = Documents::method23(v6.clone());
                                let v315: string = Documents::method24();
                                let v317: std::borrow::Cow<str> =
                                    regex::Regex::new(&v313).unwrap().replace_all(&v314, &*v315);
                                let v319: std::string::String = String::from(v317);
                                {
                                    let x_4: string = fable_library_rust::String_::fromString(v319);
                                    _v311.set(Some(x_4))
                                }
                                {
                                    let v327: string = getValue(_v311.get().clone());
                                    let v330: Option<string> = None::<string>;
                                    let v331: Option<CancellationToken> = None::<CancellationToken>;
                                    let v332: Array<(string, string)> =
                                        new_empty::<(string, string)>();
                                    let v333 = None::<Func1<(bool, string, i32), Arc<Async<()>>>>;
                                    let v334 = None::<
                                        Func1<
                                            std::sync::Arc<
                                                std::sync::Mutex<std::process::ChildStdin>,
                                            >,
                                            (),
                                        >,
                                    >;
                                    let v335: string =
                                            sprintf!("pwsh -c \"(Get-FileHash \\\"{}\\\" -Algorithm SHA256).Hash\"",
                                                     replace(sprintf!("{}{}",
                                                                      toLower(ofChar(getCharAt(v327.clone(),
                                                                                               0_i32))),
                                                                      getSlice(v327,
                                                                               Some(1_i32),
                                                                               None::<i32>)),
                                                             string("\\"),
                                                             string("/")));
                                    let _v336: MutCell<Option<(i32, string)>> =
                                        MutCell::new(None::<(i32, string)>);
                                    let v338: string = Documents::method38(
                                        v331.clone(),
                                        v335.clone(),
                                        v332.clone(),
                                        v333.clone(),
                                        v334.clone(),
                                        v330.clone(),
                                    );
                                    let patternInput_4: (string, string) = Documents::method39();
                                    let v341: i32 = length(v338.clone());
                                    let v342: Array<char> = new_init(&'\u{0000}', v341);
                                    let v343: LrcPtr<Documents::Mut5> =
                                        LrcPtr::new(Documents::Mut5 {
                                            l0: MutCell::new(0_i32),
                                        });
                                    while Documents::method26(v341, v343.clone()) {
                                        let v345: i32 = v343.l0.get().clone();
                                        let v346: char = getCharAt(v338.clone(), v345);
                                        v342.get_mut()[v345 as usize] = v346;
                                        {
                                            let v347: i32 = v345 + 1_i32;
                                            v343.l0.set(v347);
                                            ()
                                        }
                                    }
                                    {
                                        let v349: List<char> = ofArray(v342.clone());
                                        let patternInput_5: (string, string) = Documents::method41(
                                            patternInput_4.1.clone(),
                                            patternInput_4.0.clone(),
                                            foldBack(
                                                Func2::new(
                                                    move |b0: char, b1: LrcPtr<Documents::UH0>| {
                                                        (Documents::method40())(b0)(b1)
                                                    },
                                                ),
                                                v349,
                                                LrcPtr::new(Documents::UH0::UH0_0),
                                            ),
                                            Documents::US8::US8_0,
                                        );
                                        let v357: string = patternInput_5.0.clone();
                                        let v359: Array<string> =
                                            Documents::method42(patternInput_5.1.clone());
                                        let v361: Vec<string> = v359.to_vec();
                                        let v363: Vec<std::string::String> = v361
                                            .iter()
                                            .map(|x| Func1::from(v112)(x.clone()))
                                            .collect();
                                        Documents::method3(
                                            Documents::US0::US0_1,
                                            Func0::new({
                                                let v330 = v330.clone();
                                                let v331 = v331.clone();
                                                let v332 = v332.clone();
                                                let v333 = v333.clone();
                                                let v334 = v334.clone();
                                                let v335 = v335.clone();
                                                let v357 = v357.clone();
                                                let v363 = v363.clone();
                                                move || {
                                                    Documents::closure29(
                                                        v331.clone(),
                                                        v335.clone(),
                                                        v332.clone(),
                                                        v333.clone(),
                                                        v334.clone(),
                                                        v330.clone(),
                                                        v357.clone(),
                                                        v363.clone(),
                                                        (),
                                                    )
                                                }
                                            }),
                                            Documents::method47(),
                                        );
                                        {
                                            let v367: std::pin::Pin<
                                                Box<
                                                    dyn std::future::Future<
                                                        Output = LrcPtr<(i32, string)>,
                                                    >,
                                                >,
                                            > = Documents::method48(
                                                v331.clone(),
                                                v335.clone(),
                                                v332.clone(),
                                                v333.clone(),
                                                v334.clone(),
                                                v330.clone(),
                                                v357.clone(),
                                                v363.clone(),
                                            );
                                            let v369: LrcPtr<(i32, string)> =
                                                futures_lite::future::block_on(v367);
                                            _v336.set(Some((v369.0.clone(), v369.1.clone())));
                                            {
                                                let patternInput_6: (i32, string) =
                                                    getValue(_v336.get().clone());
                                                let v550: string = patternInput_6.1.clone();
                                                let v554: Documents::US20 =
                                                    if patternInput_6.0.clone() == 0_i32 {
                                                        Documents::US20::US20_0(v550.clone())
                                                    } else {
                                                        Documents::US20::US20_1(v550)
                                                    };
                                                v310 ==
                                                        match &v554 {
                                                            Documents::US20::US20_0(v554_0_0)
                                                            =>
                                                            v554_0_0.clone(),
                                                            Documents::US20::US20_1(v554_1_0)
                                                            =>
                                                            panic!("{}",
                                                                   sprintf!("resultm.get / Result value was Error: {}", v554_1_0.clone()),),
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
                false
            }) == false
            {
                let v564: Documents::US21 = Documents::method74(v2, v3, v7.clone(), v4);
                match &v564 {
                    Documents::US21::US21_0(v564_0_0, v564_0_1) => {
                        let v566: string = v564_0_1.clone();
                        let v565: i32 = v564_0_0.clone();
                        if v565 != 0_i32 {
                            Documents::method3(
                                Documents::US0::US0_2,
                                Func0::new(move || Documents::closure64((), ())),
                                Func0::new({
                                    let v565 = v565.clone();
                                    let v566 = v566.clone();
                                    move || Documents::closure65(v566.clone(), v565, ())
                                }),
                            );
                            Documents::US19::US19_0(Err::<string, LrcPtr<(string, string)>>(
                                LrcPtr::new((v7.clone(), v566.clone())),
                            ))
                        } else {
                            let _v574: MutCell<Option<bool>> = MutCell::new(None::<bool>);
                            let v576: string = Documents::method14(v7.clone());
                            let v578: &str = fable_library_rust::String_::LrcStr::as_str(&v576);
                            let v580: std::string::String = String::from(v578);
                            let v582: std::path::PathBuf = std::path::PathBuf::from(v580);
                            {
                                let x_6: bool = if v582.clone().exists() {
                                    v582.is_file()
                                } else {
                                    false
                                };
                                _v574.set(Some(x_6))
                            }
                            if getValue(_v574.get().clone()) {
                                let _v597: MutCell<Option<()>> = MutCell::new(None::<()>);
                                let v599: string = Documents::method73(v6);
                                let v601: Result<u64, std::io::Error> =
                                    std::fs::copy(&*v7.clone(), &*v599);
                                let v603: u64 = v601.unwrap();
                                _v597.set(Some(()));
                                getValue(_v597.get().clone());
                                ()
                            } else {
                                panic!(
                                    "{}",
                                    sprintf!("documents.files_fn / {} should exist", v7.clone()),
                                )
                            }
                            Documents::US19::US19_0(Ok::<string, LrcPtr<(string, string)>>(
                                v7.clone(),
                            ))
                        }
                    }
                    Documents::US21::US21_1(v564_1_0, v564_1_1) => {
                        Documents::US19::US19_0(Err::<string, LrcPtr<(string, string)>>(
                            LrcPtr::new((v7.clone(), v564_1_1.clone())),
                        ))
                    }
                }
            } else {
                Documents::US19::US19_1
            }
        }
        pub fn closure59(
            v0_1: string,
            v1_1: string,
            v2: string,
            v3: string,
            v4: string,
        ) -> Func1<string, Documents::US19> {
            Func1::new({
                let v0_1 = v0_1.clone();
                let v1_1 = v1_1.clone();
                let v2 = v2.clone();
                let v3 = v3.clone();
                let v4 = v4.clone();
                move |v: string| {
                    Documents::closure60(
                        v0_1.clone(),
                        v1_1.clone(),
                        v2.clone(),
                        v3.clone(),
                        v4.clone(),
                        v,
                    )
                }
            })
        }
        pub fn closure68(unitVar: (), unitVar_1: ()) -> string {
            string("documents.crowbook / result contains ERROR")
        }
        pub fn closure69(v0_1: string, v1_1: string, v2: i32, unitVar: ()) -> string {
            sprintf!(
                "exit_code: {:?} / result: {} / output_path: {} / {}",
                v2,
                v1_1,
                v0_1,
                Documents::closure6((), ())
            )
        }
        pub fn method80(v0_1: string, v1_1: string, v2: string, v3: string) -> Documents::US21 {
            let v4: string =
                sprintf!("crowbook --single \"{}\" --output \"{}\" --to {} --set rendering.num_depth 6 html.css.add \\\"\'\'\' body {{ color: #e8e6e3; background-color: #202324; }} a {{ color: #989693; }} \'\'\'\\\"",
                         v1_1, v0_1.clone(), v3);
            let v6: Option<CancellationToken> = None::<CancellationToken>;
            let v7: Array<(string, string)> = new_empty::<(string, string)>();
            let v8 = None::<Func1<(bool, string, i32), Arc<Async<()>>>>;
            let v9 = None::<Func1<std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>, ()>>;
            let v10: Option<string> = Some(v2);
            let _v11: MutCell<Option<(i32, string)>> = MutCell::new(None::<(i32, string)>);
            let v13: string = Documents::method38(
                v6.clone(),
                v4.clone(),
                v7.clone(),
                v8.clone(),
                v9.clone(),
                v10.clone(),
            );
            let patternInput: (string, string) = Documents::method39();
            let v16: i32 = length(v13.clone());
            let v17: Array<char> = new_init(&'\u{0000}', v16);
            let v18: LrcPtr<Documents::Mut5> = LrcPtr::new(Documents::Mut5 {
                l0: MutCell::new(0_i32),
            });
            while Documents::method26(v16, v18.clone()) {
                let v20: i32 = v18.l0.get().clone();
                let v21: char = getCharAt(v13.clone(), v20);
                v17.get_mut()[v20 as usize] = v21;
                {
                    let v22: i32 = v20 + 1_i32;
                    v18.l0.set(v22);
                    ()
                }
            }
            {
                let v24: List<char> = ofArray(v17.clone());
                let patternInput_1: (string, string) = Documents::method41(
                    patternInput.1.clone(),
                    patternInput.0.clone(),
                    foldBack(
                        Func2::new(move |b0: char, b1: LrcPtr<Documents::UH0>| {
                            (Documents::method40())(b0)(b1)
                        }),
                        v24,
                        LrcPtr::new(Documents::UH0::UH0_0),
                    ),
                    Documents::US8::US8_0,
                );
                let v32: string = patternInput_1.0.clone();
                let v34: Array<string> = Documents::method42(patternInput_1.1.clone());
                let v36: Vec<string> = v34.to_vec();
                let v39: Vec<std::string::String> = v36
                    .iter()
                    .map(|x| Func1::new(move |v: string| Documents::closure28((), v))(x.clone()))
                    .collect();
                Documents::method3(
                    Documents::US0::US0_1,
                    Func0::new({
                        let v10 = v10.clone();
                        let v32 = v32.clone();
                        let v39 = v39.clone();
                        let v4 = v4.clone();
                        let v6 = v6.clone();
                        let v7 = v7.clone();
                        let v8 = v8.clone();
                        let v9 = v9.clone();
                        move || {
                            Documents::closure29(
                                v6.clone(),
                                v4.clone(),
                                v7.clone(),
                                v8.clone(),
                                v9.clone(),
                                v10.clone(),
                                v32.clone(),
                                v39.clone(),
                                (),
                            )
                        }
                    }),
                    Documents::method47(),
                );
                {
                    let v43: std::pin::Pin<
                        Box<dyn std::future::Future<Output = LrcPtr<(i32, string)>>>,
                    > = Documents::method48(
                        v6.clone(),
                        v4.clone(),
                        v7.clone(),
                        v8.clone(),
                        v9.clone(),
                        v10.clone(),
                        v32.clone(),
                        v39.clone(),
                    );
                    let v45: LrcPtr<(i32, string)> = futures_lite::future::block_on(v43);
                    _v11.set(Some((v45.0.clone(), v45.1.clone())));
                    {
                        let patternInput_2: (i32, string) = getValue(_v11.get().clone());
                        let v227: string = patternInput_2.1.clone();
                        let v226: i32 = patternInput_2.0.clone();
                        if contains(v227.clone(), string("ERROR")) {
                            Documents::method3(
                                Documents::US0::US0_2,
                                Func0::new(move || Documents::closure68((), ())),
                                Func0::new({
                                    let v0_1 = v0_1.clone();
                                    let v226 = v226.clone();
                                    let v227 = v227.clone();
                                    move || {
                                        Documents::closure69(v0_1.clone(), v227.clone(), v226, ())
                                    }
                                }),
                            );
                            Documents::US21::US21_1(v226, v227.clone())
                        } else {
                            Documents::US21::US21_0(v226, v227.clone())
                        }
                    }
                }
            }
        }
        pub fn closure67(v0_1: string, v1_1: string, v2: string, v3: string) -> Documents::US19 {
            let patternInput: (string, string) = Documents::method72(v3.clone(), v2.clone(), v0_1);
            let v5: string = patternInput.1.clone();
            let v4: string = patternInput.0.clone();
            let _v6: MutCell<Option<bool>> = MutCell::new(None::<bool>);
            let v8: string = Documents::method14(v5.clone());
            let v10: &str = fable_library_rust::String_::LrcStr::as_str(&v8);
            let v12: std::string::String = String::from(v10);
            let v14: std::path::PathBuf = std::path::PathBuf::from(v12);
            {
                let x: bool = if v14.clone().exists() {
                    v14.is_file()
                } else {
                    false
                };
                _v6.set(Some(x))
            }
            if (if if getValue(_v6.get().clone()) {
                let _v30: MutCell<Option<bool>> = MutCell::new(None::<bool>);
                let v32: string = Documents::method14(v4.clone());
                let v34: &str = fable_library_rust::String_::LrcStr::as_str(&v32);
                let v36: std::string::String = String::from(v34);
                let v38: std::path::PathBuf = std::path::PathBuf::from(v36);
                {
                    let x_1: bool = if v38.clone().exists() {
                        v38.is_file()
                    } else {
                        false
                    };
                    _v30.set(Some(x_1))
                }
                getValue(_v30.get().clone())
            } else {
                false
            } {
                let _v54: MutCell<Option<string>> = MutCell::new(None::<string>);
                let v56: string = Documents::method22();
                let v57: string = Documents::method23(v5.clone());
                let v58: string = Documents::method24();
                let v60: std::borrow::Cow<str> =
                    regex::Regex::new(&v56).unwrap().replace_all(&v57, &*v58);
                let v62: std::string::String = String::from(v60);
                {
                    let x_2: string = fable_library_rust::String_::fromString(v62);
                    _v54.set(Some(x_2))
                }
                {
                    let v72: string = getValue(_v54.get().clone());
                    let v77: Option<string> = None::<string>;
                    let v78: Option<CancellationToken> = None::<CancellationToken>;
                    let v79: Array<(string, string)> = new_empty::<(string, string)>();
                    let v80 = None::<Func1<(bool, string, i32), Arc<Async<()>>>>;
                    let v81 = None::<
                        Func1<std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>, ()>,
                    >;
                    let v82: string = sprintf!(
                        "pwsh -c \"(Get-FileHash \\\"{}\\\" -Algorithm SHA256).Hash\"",
                        replace(
                            sprintf!(
                                "{}{}",
                                toLower(ofChar(getCharAt(v72.clone(), 0_i32))),
                                getSlice(v72, Some(1_i32), None::<i32>)
                            ),
                            string("\\"),
                            string("/")
                        )
                    );
                    let _v83: MutCell<Option<(i32, string)>> = MutCell::new(None::<(i32, string)>);
                    let v85: string = Documents::method38(
                        v78.clone(),
                        v82.clone(),
                        v79.clone(),
                        v80.clone(),
                        v81.clone(),
                        v77.clone(),
                    );
                    let patternInput_1: (string, string) = Documents::method39();
                    let v88: i32 = length(v85.clone());
                    let v89: Array<char> = new_init(&'\u{0000}', v88);
                    let v90: LrcPtr<Documents::Mut5> = LrcPtr::new(Documents::Mut5 {
                        l0: MutCell::new(0_i32),
                    });
                    while Documents::method26(v88, v90.clone()) {
                        let v92: i32 = v90.l0.get().clone();
                        let v93: char = getCharAt(v85.clone(), v92);
                        v89.get_mut()[v92 as usize] = v93;
                        {
                            let v94: i32 = v92 + 1_i32;
                            v90.l0.set(v94);
                            ()
                        }
                    }
                    {
                        let v96: List<char> = ofArray(v89.clone());
                        let patternInput_2: (string, string) = Documents::method41(
                            patternInput_1.1.clone(),
                            patternInput_1.0.clone(),
                            foldBack(
                                Func2::new(move |b0: char, b1: LrcPtr<Documents::UH0>| {
                                    (Documents::method40())(b0)(b1)
                                }),
                                v96,
                                LrcPtr::new(Documents::UH0::UH0_0),
                            ),
                            Documents::US8::US8_0,
                        );
                        let v104: string = patternInput_2.0.clone();
                        let v106: Array<string> = Documents::method42(patternInput_2.1.clone());
                        let v108: Vec<string> = v106.to_vec();
                        fn v110(v: string) -> std::string::String {
                            Documents::closure28((), v)
                        }
                        let v111: Vec<std::string::String> =
                            v108.iter().map(|x| Func1::from(v110)(x.clone())).collect();
                        Documents::method3(
                            Documents::US0::US0_1,
                            Func0::new({
                                let v104 = v104.clone();
                                let v111 = v111.clone();
                                let v77 = v77.clone();
                                let v78 = v78.clone();
                                let v79 = v79.clone();
                                let v80 = v80.clone();
                                let v81 = v81.clone();
                                let v82 = v82.clone();
                                move || {
                                    Documents::closure29(
                                        v78.clone(),
                                        v82.clone(),
                                        v79.clone(),
                                        v80.clone(),
                                        v81.clone(),
                                        v77.clone(),
                                        v104.clone(),
                                        v111.clone(),
                                        (),
                                    )
                                }
                            }),
                            Documents::method47(),
                        );
                        {
                            let v115: std::pin::Pin<
                                Box<dyn std::future::Future<Output = LrcPtr<(i32, string)>>>,
                            > = Documents::method48(
                                v78.clone(),
                                v82.clone(),
                                v79.clone(),
                                v80.clone(),
                                v81.clone(),
                                v77.clone(),
                                v104.clone(),
                                v111.clone(),
                            );
                            let v117: LrcPtr<(i32, string)> = futures_lite::future::block_on(v115);
                            _v83.set(Some((v117.0.clone(), v117.1.clone())));
                            {
                                let patternInput_3: (i32, string) = getValue(_v83.get().clone());
                                let v298: string = patternInput_3.1.clone();
                                let v302: Documents::US20 = if patternInput_3.0.clone() == 0_i32 {
                                    Documents::US20::US20_0(v298.clone())
                                } else {
                                    Documents::US20::US20_1(v298)
                                };
                                let v308: string = match &v302 {
                                    Documents::US20::US20_0(v302_0_0) => v302_0_0.clone(),
                                    Documents::US20::US20_1(v302_1_0) => panic!(
                                        "{}",
                                        sprintf!(
                                            "resultm.get / Result value was Error: {}",
                                            v302_1_0.clone()
                                        ),
                                    ),
                                };
                                let _v309: MutCell<Option<string>> = MutCell::new(None::<string>);
                                let v311: string = Documents::method22();
                                let v312: string = Documents::method23(v4.clone());
                                let v313: string = Documents::method24();
                                let v315: std::borrow::Cow<str> =
                                    regex::Regex::new(&v311).unwrap().replace_all(&v312, &*v313);
                                let v317: std::string::String = String::from(v315);
                                {
                                    let x_4: string = fable_library_rust::String_::fromString(v317);
                                    _v309.set(Some(x_4))
                                }
                                {
                                    let v325: string = getValue(_v309.get().clone());
                                    let v328: Option<string> = None::<string>;
                                    let v329: Option<CancellationToken> = None::<CancellationToken>;
                                    let v330: Array<(string, string)> =
                                        new_empty::<(string, string)>();
                                    let v331 = None::<Func1<(bool, string, i32), Arc<Async<()>>>>;
                                    let v332 = None::<
                                        Func1<
                                            std::sync::Arc<
                                                std::sync::Mutex<std::process::ChildStdin>,
                                            >,
                                            (),
                                        >,
                                    >;
                                    let v333: string =
                                            sprintf!("pwsh -c \"(Get-FileHash \\\"{}\\\" -Algorithm SHA256).Hash\"",
                                                     replace(sprintf!("{}{}",
                                                                      toLower(ofChar(getCharAt(v325.clone(),
                                                                                               0_i32))),
                                                                      getSlice(v325,
                                                                               Some(1_i32),
                                                                               None::<i32>)),
                                                             string("\\"),
                                                             string("/")));
                                    let _v334: MutCell<Option<(i32, string)>> =
                                        MutCell::new(None::<(i32, string)>);
                                    let v336: string = Documents::method38(
                                        v329.clone(),
                                        v333.clone(),
                                        v330.clone(),
                                        v331.clone(),
                                        v332.clone(),
                                        v328.clone(),
                                    );
                                    let patternInput_4: (string, string) = Documents::method39();
                                    let v339: i32 = length(v336.clone());
                                    let v340: Array<char> = new_init(&'\u{0000}', v339);
                                    let v341: LrcPtr<Documents::Mut5> =
                                        LrcPtr::new(Documents::Mut5 {
                                            l0: MutCell::new(0_i32),
                                        });
                                    while Documents::method26(v339, v341.clone()) {
                                        let v343: i32 = v341.l0.get().clone();
                                        let v344: char = getCharAt(v336.clone(), v343);
                                        v340.get_mut()[v343 as usize] = v344;
                                        {
                                            let v345: i32 = v343 + 1_i32;
                                            v341.l0.set(v345);
                                            ()
                                        }
                                    }
                                    {
                                        let v347: List<char> = ofArray(v340.clone());
                                        let patternInput_5: (string, string) = Documents::method41(
                                            patternInput_4.1.clone(),
                                            patternInput_4.0.clone(),
                                            foldBack(
                                                Func2::new(
                                                    move |b0: char, b1: LrcPtr<Documents::UH0>| {
                                                        (Documents::method40())(b0)(b1)
                                                    },
                                                ),
                                                v347,
                                                LrcPtr::new(Documents::UH0::UH0_0),
                                            ),
                                            Documents::US8::US8_0,
                                        );
                                        let v355: string = patternInput_5.0.clone();
                                        let v357: Array<string> =
                                            Documents::method42(patternInput_5.1.clone());
                                        let v359: Vec<string> = v357.to_vec();
                                        let v361: Vec<std::string::String> = v359
                                            .iter()
                                            .map(|x| Func1::from(v110)(x.clone()))
                                            .collect();
                                        Documents::method3(
                                            Documents::US0::US0_1,
                                            Func0::new({
                                                let v328 = v328.clone();
                                                let v329 = v329.clone();
                                                let v330 = v330.clone();
                                                let v331 = v331.clone();
                                                let v332 = v332.clone();
                                                let v333 = v333.clone();
                                                let v355 = v355.clone();
                                                let v361 = v361.clone();
                                                move || {
                                                    Documents::closure29(
                                                        v329.clone(),
                                                        v333.clone(),
                                                        v330.clone(),
                                                        v331.clone(),
                                                        v332.clone(),
                                                        v328.clone(),
                                                        v355.clone(),
                                                        v361.clone(),
                                                        (),
                                                    )
                                                }
                                            }),
                                            Documents::method47(),
                                        );
                                        {
                                            let v365: std::pin::Pin<
                                                Box<
                                                    dyn std::future::Future<
                                                        Output = LrcPtr<(i32, string)>,
                                                    >,
                                                >,
                                            > = Documents::method48(
                                                v329.clone(),
                                                v333.clone(),
                                                v330.clone(),
                                                v331.clone(),
                                                v332.clone(),
                                                v328.clone(),
                                                v355.clone(),
                                                v361.clone(),
                                            );
                                            let v367: LrcPtr<(i32, string)> =
                                                futures_lite::future::block_on(v365);
                                            _v334.set(Some((v367.0.clone(), v367.1.clone())));
                                            {
                                                let patternInput_6: (i32, string) =
                                                    getValue(_v334.get().clone());
                                                let v548: string = patternInput_6.1.clone();
                                                let v552: Documents::US20 =
                                                    if patternInput_6.0.clone() == 0_i32 {
                                                        Documents::US20::US20_0(v548.clone())
                                                    } else {
                                                        Documents::US20::US20_1(v548)
                                                    };
                                                v308 ==
                                                        match &v552 {
                                                            Documents::US20::US20_0(v552_0_0)
                                                            =>
                                                            v552_0_0.clone(),
                                                            Documents::US20::US20_1(v552_1_0)
                                                            =>
                                                            panic!("{}",
                                                                   sprintf!("resultm.get / Result value was Error: {}", v552_1_0.clone()),),
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
                false
            }) == false
            {
                let v562: Documents::US21 = Documents::method80(v5.clone(), v2, v1_1, v3);
                match &v562 {
                    Documents::US21::US21_0(v562_0_0, v562_0_1) => {
                        let v564: string = v562_0_1.clone();
                        let v563: i32 = v562_0_0.clone();
                        if v563 != 0_i32 {
                            Documents::method3(
                                Documents::US0::US0_2,
                                Func0::new(move || Documents::closure64((), ())),
                                Func0::new({
                                    let v563 = v563.clone();
                                    let v564 = v564.clone();
                                    move || Documents::closure65(v564.clone(), v563, ())
                                }),
                            );
                            Documents::US19::US19_0(Err::<string, LrcPtr<(string, string)>>(
                                LrcPtr::new((v5.clone(), v564.clone())),
                            ))
                        } else {
                            let _v572: MutCell<Option<bool>> = MutCell::new(None::<bool>);
                            let v574: string = Documents::method14(v5.clone());
                            let v576: &str = fable_library_rust::String_::LrcStr::as_str(&v574);
                            let v578: std::string::String = String::from(v576);
                            let v580: std::path::PathBuf = std::path::PathBuf::from(v578);
                            {
                                let x_6: bool = if v580.clone().exists() {
                                    v580.is_file()
                                } else {
                                    false
                                };
                                _v572.set(Some(x_6))
                            }
                            if getValue(_v572.get().clone()) {
                                let _v595: MutCell<Option<()>> = MutCell::new(None::<()>);
                                let v597: string = Documents::method73(v4);
                                let v599: Result<u64, std::io::Error> =
                                    std::fs::copy(&*v5.clone(), &*v597);
                                let v601: u64 = v599.unwrap();
                                _v595.set(Some(()));
                                getValue(_v595.get().clone());
                                ()
                            } else {
                                panic!(
                                    "{}",
                                    sprintf!("documents.files_fn / {} should exist", v5.clone()),
                                )
                            }
                            Documents::US19::US19_0(Ok::<string, LrcPtr<(string, string)>>(
                                v5.clone(),
                            ))
                        }
                    }
                    Documents::US21::US21_1(v562_1_0, v562_1_1) => {
                        Documents::US19::US19_0(Err::<string, LrcPtr<(string, string)>>(
                            LrcPtr::new((v5.clone(), v562_1_1.clone())),
                        ))
                    }
                }
            } else {
                Documents::US19::US19_1
            }
        }
        pub fn closure66(v0_1: string, v1_1: string, v2: string) -> Func1<string, Documents::US19> {
            Func1::new({
                let v0_1 = v0_1.clone();
                let v1_1 = v1_1.clone();
                let v2 = v2.clone();
                move |v: string| Documents::closure67(v0_1.clone(), v1_1.clone(), v2.clone(), v)
            })
        }
        pub fn closure70(unitVar: (), unitVar_1: ()) -> string {
            string("documents.run / par_map / files\' = [] / listm.iter")
        }
        pub fn closure71(v0_1: string, v1_1: string, unitVar: ()) -> string {
            sprintf!(
                "output_path: {:?} / output_cache_path: {} / {}",
                v1_1,
                v0_1,
                Documents::closure6((), ())
            )
        }
        pub fn method81(
            v0_1: LrcPtr<Documents::UH2>,
            v1_1: List<LrcPtr<Documents::UH3>>,
        ) -> List<LrcPtr<Documents::UH3>> {
            match v0_1.as_ref() {
                Documents::UH2::UH2_0 => v1_1.clone(),
                Documents::UH2::UH2_1(v0_1_1_0, v0_1_1_1) => cons(
                    match v0_1.as_ref() {
                        Documents::UH2::UH2_1(x, _) => x.clone(),
                        _ => unreachable!(),
                    },
                    Documents::method81(
                        match v0_1.as_ref() {
                            Documents::UH2::UH2_1(_, x) => x.clone(),
                            _ => unreachable!(),
                        },
                        v1_1.clone(),
                    ),
                ),
            }
        }
        pub fn method82(v0_1: i32, v1_1: LrcPtr<Documents::Mut8>) -> bool {
            v1_1.l0.get().clone() < v0_1
        }
        pub fn method83(
            v0_1: LrcPtr<Documents::UH3>,
            v1_1: List<(
                string,
                string,
                Func1<string, Func1<string, Documents::US19>>,
            )>,
        ) -> List<(
            string,
            string,
            Func1<string, Func1<string, Documents::US19>>,
        )> {
            match v0_1.as_ref() {
                Documents::UH3::UH3_0 => v1_1.clone(),
                Documents::UH3::UH3_1(v0_1_1_0, v0_1_1_1, v0_1_1_2, v0_1_1_3) => cons(
                    (
                        match v0_1.as_ref() {
                            Documents::UH3::UH3_1(x, _, _, _) => x.clone(),
                            _ => unreachable!(),
                        },
                        match v0_1.as_ref() {
                            Documents::UH3::UH3_1(_, x, _, _) => x.clone(),
                            _ => unreachable!(),
                        },
                        Func1::new({
                            let v0_1 = v0_1.clone();
                            move |a0: string| {
                                Func1::new({
                                    let a0 = a0.clone();
                                    let v0_1 = v0_1.clone();
                                    move |a1: string| {
                                        (match v0_1.as_ref() {
                                            Documents::UH3::UH3_1(_, _, x, _) => x.clone(),
                                            _ => unreachable!(),
                                        })(a0.clone(), a1)
                                    }
                                })
                            }
                        }),
                    ),
                    Documents::method83(
                        match v0_1.as_ref() {
                            Documents::UH3::UH3_1(_, _, _, x) => x.clone(),
                            _ => unreachable!(),
                        },
                        v1_1.clone(),
                    ),
                ),
            }
        }
        pub fn closure72(
            unitVar: (),
            _arg: (
                string,
                string,
                Func1<string, Func1<string, Documents::US19>>,
            ),
        ) -> Option<Result<string, LrcPtr<(string, string)>>> {
            let v4: Documents::US19 = (_arg.2.clone())(_arg.1.clone())(_arg.0.clone());
            match &v4 {
                Documents::US19::US19_0(v4_0_0) => Some(match &v4 {
                    Documents::US19::US19_0(x) => x.clone(),
                    _ => unreachable!(),
                }),
                _ => None::<Result<string, LrcPtr<(string, string)>>>,
            }
        }
        pub fn method84(
            v0_1: Vec<Option<Result<string, LrcPtr<(string, string)>>>>,
        ) -> Vec<Option<Result<string, LrcPtr<(string, string)>>>> {
            v0_1
        }
        pub fn method85(
            v0_1: Vec<Option<Result<string, LrcPtr<(string, string)>>>>,
        ) -> Vec<Option<Result<string, LrcPtr<(string, string)>>>> {
            v0_1
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
            let v8: string = Documents::method21(v5);
            let v9: string = Documents::method14(v8.clone());
            let v11: &str = fable_library_rust::String_::LrcStr::as_str(&v9);
            let v13: std::string::String = String::from(v11);
            let v15: std::path::PathBuf = std::path::PathBuf::from(v13);
            {
                let x_5: string = if v15.exists() == false {
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
                            let v48: string = Documents::method13(v47.clone(), v8.clone());
                            let _v49: MutCell<Option<string>> = MutCell::new(None::<string>);
                            let v51: string = Documents::method22();
                            let v52: string = Documents::method23(v48);
                            let v53: string = Documents::method24();
                            let v55: std::borrow::Cow<str> =
                                regex::Regex::new(&v51).unwrap().replace_all(&v52, &*v53);
                            let v57: std::string::String = String::from(v55);
                            {
                                let x_2: string = fable_library_rust::String_::fromString(v57);
                                _v49.set(Some(x_2))
                            }
                            {
                                let v67: string = getValue(_v49.get().clone());
                                let v72: Array<string> = split(
                                    replace(
                                        sprintf!(
                                            "{}{}",
                                            toLower(ofChar(getCharAt(v67.clone(), 0_i32))),
                                            getSlice(v67, Some(1_i32), None::<i32>)
                                        ),
                                        string("\\"),
                                        string("/"),
                                    ),
                                    string("/"),
                                    -1_i32,
                                    0_i32,
                                );
                                let v74: i32 = count(v72.clone());
                                let v75: LrcPtr<Documents::Mut4> = LrcPtr::new(Documents::Mut4 {
                                    l0: MutCell::new(0_i32),
                                    l1: MutCell::new(0_i32),
                                    l2: MutCell::new(new_empty::<string>()),
                                });
                                while Documents::method25(v74, v75.clone()) {
                                    let v77: i32 = v75.l0.get().clone();
                                    let v80: i32 = v77.wrapping_neg() + v74 - 1_i32;
                                    let matchValue: i32 = v75.l1.get().clone();
                                    let v82: Array<string> = v75.l2.get().clone();
                                    let v81: i32 = matchValue;
                                    let v83: string = v72[v80].clone();
                                    let patternInput_1: (i32, Array<string>) = if string("..")
                                        == v83.clone()
                                    {
                                        (v81 + 1_i32, v82.clone())
                                    } else {
                                        if string(".") == v83.clone() {
                                            (v81, v82.clone())
                                        } else {
                                            if 0_i32 == v81 {
                                                if endsWith(v83.clone(), string(":"), false) {
                                                    let v91: Array<string> =
                                                        new_array(&[sprintf!(
                                                            "{}:",
                                                            getCharAt(v47.clone(), 0_i32)
                                                        )]);
                                                    let v92: i32 = count(v91.clone());
                                                    let v94: i32 = v92 + count(v82.clone());
                                                    let v95: Array<string> =
                                                        new_init(&string(""), v94);
                                                    let v96: LrcPtr<Documents::Mut5> =
                                                        LrcPtr::new(Documents::Mut5 {
                                                            l0: MutCell::new(0_i32),
                                                        });
                                                    while Documents::method26(v94, v96.clone()) {
                                                        let v98: i32 = v96.l0.get().clone();
                                                        let v103: string = if v98 < v92 {
                                                            v91[v98].clone()
                                                        } else {
                                                            let v101: i32 = v98 - v92;
                                                            v82[v101].clone()
                                                        };
                                                        v95.get_mut()[v98 as usize] = v103;
                                                        {
                                                            let v104: i32 = v98 + 1_i32;
                                                            v96.l0.set(v104);
                                                            ()
                                                        }
                                                    }
                                                    (0_i32, v95.clone())
                                                } else {
                                                    let v105: Array<string> = new_array(&[v83]);
                                                    let v106: i32 = count(v105.clone());
                                                    let v108: i32 = v106 + count(v82.clone());
                                                    let v109: Array<string> =
                                                        new_init(&string(""), v108);
                                                    let v110: LrcPtr<Documents::Mut5> =
                                                        LrcPtr::new(Documents::Mut5 {
                                                            l0: MutCell::new(0_i32),
                                                        });
                                                    while Documents::method26(v108, v110.clone()) {
                                                        let v112: i32 = v110.l0.get().clone();
                                                        let v117: string = if v112 < v106 {
                                                            v105[v112].clone()
                                                        } else {
                                                            let v115: i32 = v112 - v106;
                                                            v82[v115].clone()
                                                        };
                                                        v109.get_mut()[v112 as usize] = v117;
                                                        {
                                                            let v118: i32 = v112 + 1_i32;
                                                            v110.l0.set(v118);
                                                            ()
                                                        }
                                                    }
                                                    (0_i32, v109.clone())
                                                }
                                            } else {
                                                (v81 - 1_i32, v82.clone())
                                            }
                                        }
                                    };
                                    let v128: i32 = v77 + 1_i32;
                                    v75.l0.set(v128);
                                    v75.l1.set(patternInput_1.0.clone());
                                    v75.l2.set(patternInput_1.1.clone());
                                    ()
                                }
                                {
                                    let matchValue_2: i32 = v75.l1.get().clone();
                                    let v130: Array<string> = v75.l2.get().clone();
                                    let v131: LrcPtr<dyn IEnumerable_1<string>> =
                                        delay(Func0::new({
                                            let v130 = v130.clone();
                                            move || {
                                                map_1(
                                                    Func1::new({
                                                        let v130 = v130.clone();
                                                        move |i: i32| v130[i].clone()
                                                    }),
                                                    rangeNumeric(
                                                        0_i32,
                                                        1_i32,
                                                        count(v130.clone()) - 1_i32,
                                                    ),
                                                )
                                            }
                                        }));
                                    let _v132: MutCell<Option<char>> = MutCell::new(None::<char>);
                                    {
                                        let x_3: char = std::path::MAIN_SEPARATOR;
                                        _v132.set(Some(x_3))
                                    }
                                    join(
                                        Documents::method27(ofChar(getValue(_v132.get().clone()))),
                                        toArray_1(v131),
                                    )
                                }
                            }
                        }
                    }
                } else {
                    let v149: Result<std::path::PathBuf, std::io::Error> =
                        std::fs::canonicalize(&*v8);
                    let v151: std::path::PathBuf = v149.unwrap();
                    let v153: std::path::Display = v151.display();
                    let _v154: MutCell<Option<std::string::String>> =
                        MutCell::new(None::<std::string::String>);
                    {
                        let x_4: std::string::String = format!("{}", v153);
                        _v154.set(Some(x_4))
                    }
                    {
                        let v165: std::string::String = getValue(_v154.get().clone());
                        fable_library_rust::String_::fromString(v165)
                    }
                };
                _v6.set(Some(x_5))
            }
            {
                let v176: string = getValue(_v6.get().clone());
                let v177: string = Documents::method14(v176.clone());
                let v179: &str = fable_library_rust::String_::LrcStr::as_str(&v177);
                let v181: std::string::String = String::from(v179);
                let v183: std::path::PathBuf = std::path::PathBuf::from(v181);
                let v185: std::path::Display = v183.display();
                let _v186: MutCell<Option<std::string::String>> =
                    MutCell::new(None::<std::string::String>);
                {
                    let x_6: std::string::String = format!("{}", v185);
                    _v186.set(Some(x_6))
                }
                {
                    let v197: std::string::String = getValue(_v186.get().clone());
                    let v205: string = sprintf!(
                        ".{}",
                        replace(
                            replace(
                                fable_library_rust::String_::fromString(v197),
                                v3.clone(),
                                string("")
                            ),
                            string("\\"),
                            string("/")
                        )
                    );
                    let _v206: MutCell<Option<string>> = MutCell::new(None::<string>);
                    let v208: string = Documents::method22();
                    let v209: string = Documents::method23(v176);
                    let v210: string = Documents::method24();
                    let v212: std::borrow::Cow<str> =
                        regex::Regex::new(&v208).unwrap().replace_all(&v209, &*v210);
                    let v214: std::string::String = String::from(v212);
                    {
                        let x_7: string = fable_library_rust::String_::fromString(v214);
                        _v206.set(Some(x_7))
                    }
                    {
                        let v223: string = getValue(_v206.get().clone());
                        let v225: string = replace(
                            sprintf!(
                                "{}{}",
                                toLower(ofChar(getCharAt(v223.clone(), 0_i32))),
                                getSlice(v223, Some(1_i32), None::<i32>)
                            ),
                            string("\\"),
                            string("/"),
                        );
                        let v226: string = Documents::method13(v2.clone(), v205.clone());
                        let _v227: MutCell<Option<string>> = MutCell::new(None::<string>);
                        let v229: string = Documents::method22();
                        let v230: string = Documents::method23(v226);
                        let v231: string = Documents::method24();
                        let v233: std::borrow::Cow<str> =
                            regex::Regex::new(&v229).unwrap().replace_all(&v230, &*v231);
                        let v235: std::string::String = String::from(v233);
                        {
                            let x_8: string = fable_library_rust::String_::fromString(v235);
                            _v227.set(Some(x_8))
                        }
                        {
                            let v243: string = getValue(_v227.get().clone());
                            let v245: string = replace(
                                sprintf!(
                                    "{}{}",
                                    toLower(ofChar(getCharAt(v243.clone(), 0_i32))),
                                    getSlice(v243, Some(1_i32), None::<i32>)
                                ),
                                string("\\"),
                                string("/"),
                            );
                            let v247: Option<CancellationToken> = None::<CancellationToken>;
                            let v248: Array<(string, string)> = new_empty::<(string, string)>();
                            let v249 = None::<Func1<(bool, string, i32), Arc<Async<()>>>>;
                            let v250 = None::<
                                Func1<
                                    std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>,
                                    (),
                                >,
                            >;
                            let v251: string = sprintf!(
                                "git ls-tree --format=\'%(objectname)\' origin/gh-pages \"{}\"",
                                v245.clone()
                            );
                            let v252: Option<string> = Some(v2);
                            let _v253: MutCell<Option<(i32, string)>> =
                                MutCell::new(None::<(i32, string)>);
                            let v255: string = Documents::method38(
                                v247.clone(),
                                v251.clone(),
                                v248.clone(),
                                v249.clone(),
                                v250.clone(),
                                v252.clone(),
                            );
                            let patternInput_3: (string, string) = Documents::method39();
                            let v258: i32 = length(v255.clone());
                            let v259: Array<char> = new_init(&'\u{0000}', v258);
                            let v260: LrcPtr<Documents::Mut5> = LrcPtr::new(Documents::Mut5 {
                                l0: MutCell::new(0_i32),
                            });
                            while Documents::method26(v258, v260.clone()) {
                                let v262: i32 = v260.l0.get().clone();
                                let v263: char = getCharAt(v255.clone(), v262);
                                v259.get_mut()[v262 as usize] = v263;
                                {
                                    let v264: i32 = v262 + 1_i32;
                                    v260.l0.set(v264);
                                    ()
                                }
                            }
                            {
                                let v266: List<char> = ofArray(v259.clone());
                                let patternInput_4: (string, string) = Documents::method41(
                                    patternInput_3.1.clone(),
                                    patternInput_3.0.clone(),
                                    foldBack(
                                        Func2::new(move |b0: char, b1: LrcPtr<Documents::UH0>| {
                                            (Documents::method40())(b0)(b1)
                                        }),
                                        v266,
                                        LrcPtr::new(Documents::UH0::UH0_0),
                                    ),
                                    Documents::US8::US8_0,
                                );
                                let v274: string = patternInput_4.0.clone();
                                let v276: Array<string> =
                                    Documents::method42(patternInput_4.1.clone());
                                let v278: Vec<string> = v276.to_vec();
                                fn v280(v: string) -> std::string::String {
                                    Documents::closure28((), v)
                                }
                                let v281: Vec<std::string::String> =
                                    v278.iter().map(|x| Func1::from(v280)(x.clone())).collect();
                                Documents::method3(
                                    Documents::US0::US0_1,
                                    Func0::new({
                                        let v247 = v247.clone();
                                        let v248 = v248.clone();
                                        let v249 = v249.clone();
                                        let v250 = v250.clone();
                                        let v251 = v251.clone();
                                        let v252 = v252.clone();
                                        let v274 = v274.clone();
                                        let v281 = v281.clone();
                                        move || {
                                            Documents::closure29(
                                                v247.clone(),
                                                v251.clone(),
                                                v248.clone(),
                                                v249.clone(),
                                                v250.clone(),
                                                v252.clone(),
                                                v274.clone(),
                                                v281.clone(),
                                                (),
                                            )
                                        }
                                    }),
                                    Documents::method47(),
                                );
                                {
                                    let v285: std::pin::Pin<
                                        Box<
                                            dyn std::future::Future<Output = LrcPtr<(i32, string)>>,
                                        >,
                                    > = Documents::method48(
                                        v247.clone(),
                                        v251.clone(),
                                        v248.clone(),
                                        v249.clone(),
                                        v250.clone(),
                                        v252.clone(),
                                        v274.clone(),
                                        v281.clone(),
                                    );
                                    let v287: LrcPtr<(i32, string)> =
                                        futures_lite::future::block_on(v285);
                                    _v253.set(Some((v287.0.clone(), v287.1.clone())));
                                    {
                                        let patternInput_5: (i32, string) =
                                            getValue(_v253.get().clone());
                                        let v468: string = patternInput_5.1.clone();
                                        let v469: string =
                                            Documents::method13(v3.clone(), v205.clone());
                                        let _v470: MutCell<Option<string>> =
                                            MutCell::new(None::<string>);
                                        let v472: string = Documents::method22();
                                        let v473: string = Documents::method23(v469);
                                        let v474: string = Documents::method24();
                                        let v476: std::borrow::Cow<str> = regex::Regex::new(&v472)
                                            .unwrap()
                                            .replace_all(&v473, &*v474);
                                        let v478: std::string::String = String::from(v476);
                                        {
                                            let x_10: string =
                                                fable_library_rust::String_::fromString(v478);
                                            _v470.set(Some(x_10))
                                        }
                                        {
                                            let v486: string = getValue(_v470.get().clone());
                                            let v488: string = replace(
                                                sprintf!(
                                                    "{}{}",
                                                    toLower(ofChar(getCharAt(v486.clone(), 0_i32))),
                                                    getSlice(v486, Some(1_i32), None::<i32>)
                                                ),
                                                string("\\"),
                                                string("/"),
                                            );
                                            let v490: Option<CancellationToken> =
                                                None::<CancellationToken>;
                                            let v491: Array<(string, string)> =
                                                new_empty::<(string, string)>();
                                            let v492 =
                                                None::<Func1<(bool, string, i32), Arc<Async<()>>>>;
                                            let v493 = None::<
                                                Func1<
                                                    std::sync::Arc<
                                                        std::sync::Mutex<std::process::ChildStdin>,
                                                    >,
                                                    (),
                                                >,
                                            >;
                                            let v494: string =
                                                sprintf!("git hash-object \"{}\"", v488.clone());
                                            let v495: Option<string> = Some(v3.clone());
                                            let _v496: MutCell<Option<(i32, string)>> =
                                                MutCell::new(None::<(i32, string)>);
                                            let v498: string = Documents::method38(
                                                v490.clone(),
                                                v494.clone(),
                                                v491.clone(),
                                                v492.clone(),
                                                v493.clone(),
                                                v495.clone(),
                                            );
                                            let patternInput_6: (string, string) =
                                                Documents::method39();
                                            let v501: i32 = length(v498.clone());
                                            let v502: Array<char> = new_init(&'\u{0000}', v501);
                                            let v503: LrcPtr<Documents::Mut5> =
                                                LrcPtr::new(Documents::Mut5 {
                                                    l0: MutCell::new(0_i32),
                                                });
                                            while Documents::method26(v501, v503.clone()) {
                                                let v505: i32 = v503.l0.get().clone();
                                                let v506: char = getCharAt(v498.clone(), v505);
                                                v502.get_mut()[v505 as usize] = v506;
                                                {
                                                    let v507: i32 = v505 + 1_i32;
                                                    v503.l0.set(v507);
                                                    ()
                                                }
                                            }
                                            {
                                                let v509: List<char> = ofArray(v502.clone());
                                                let patternInput_7:
                                                        (string, string) =
                                                    Documents::method41(patternInput_6.1.clone(),
                                                                        patternInput_6.0.clone(),
                                                                        foldBack(Func2::new(move
                                                                                                |b0:
                                                                                                     char,
                                                                                                 b1:
                                                                                                     LrcPtr<Documents::UH0>|
                                                                                                (Documents::method40())(b0)(b1)),
                                                                                 v509,
                                                                                 LrcPtr::new(Documents::UH0::UH0_0)),
                                                                        Documents::US8::US8_0);
                                                let v517: string = patternInput_7.0.clone();
                                                let v519: Array<string> =
                                                    Documents::method42(patternInput_7.1.clone());
                                                let v521: Vec<string> = v519.to_vec();
                                                let v523: Vec<std::string::String> = v521
                                                    .iter()
                                                    .map(|x| Func1::from(v280)(x.clone()))
                                                    .collect();
                                                Documents::method3(
                                                    Documents::US0::US0_1,
                                                    Func0::new({
                                                        let v490 = v490.clone();
                                                        let v491 = v491.clone();
                                                        let v492 = v492.clone();
                                                        let v493 = v493.clone();
                                                        let v494 = v494.clone();
                                                        let v495 = v495.clone();
                                                        let v517 = v517.clone();
                                                        let v523 = v523.clone();
                                                        move || {
                                                            Documents::closure29(
                                                                v490.clone(),
                                                                v494.clone(),
                                                                v491.clone(),
                                                                v492.clone(),
                                                                v493.clone(),
                                                                v495.clone(),
                                                                v517.clone(),
                                                                v523.clone(),
                                                                (),
                                                            )
                                                        }
                                                    }),
                                                    Documents::method47(),
                                                );
                                                {
                                                    let v527: std::pin::Pin<
                                                        Box<
                                                            dyn std::future::Future<
                                                                Output = LrcPtr<(i32, string)>,
                                                            >,
                                                        >,
                                                    > = Documents::method48(
                                                        v490.clone(),
                                                        v494.clone(),
                                                        v491.clone(),
                                                        v492.clone(),
                                                        v493.clone(),
                                                        v495.clone(),
                                                        v517.clone(),
                                                        v523.clone(),
                                                    );
                                                    let v529: LrcPtr<(i32, string)> =
                                                        futures_lite::future::block_on(v527);
                                                    _v496.set(Some((
                                                        v529.0.clone(),
                                                        v529.1.clone(),
                                                    )));
                                                    {
                                                        let patternInput_8: (i32, string) =
                                                            getValue(_v496.get().clone());
                                                        let v710: string = patternInput_8.1.clone();
                                                        let v711: string = Documents::method13(
                                                            v4.clone(),
                                                            v205.clone(),
                                                        );
                                                        let _v712: MutCell<Option<string>> =
                                                            MutCell::new(None::<string>);
                                                        let v714: string = Documents::method22();
                                                        let v715: string =
                                                            Documents::method23(v711);
                                                        let v716: string = Documents::method24();
                                                        let v718: std::borrow::Cow<str> =
                                                            regex::Regex::new(&v714)
                                                                .unwrap()
                                                                .replace_all(&v715, &*v716);
                                                        let v720: std::string::String =
                                                            String::from(v718);
                                                        {
                                                            let x_12: string =
                                                                fable_library_rust::String_::fromString(v720);
                                                            _v712.set(Some(x_12))
                                                        }
                                                        {
                                                            let v728: string =
                                                                getValue(_v712.get().clone());
                                                            let v730: string = replace(
                                                                sprintf!(
                                                                    "{}{}",
                                                                    toLower(ofChar(getCharAt(
                                                                        v728.clone(),
                                                                        0_i32
                                                                    ))),
                                                                    getSlice(
                                                                        v728,
                                                                        Some(1_i32),
                                                                        None::<i32>
                                                                    )
                                                                ),
                                                                string("\\"),
                                                                string("/"),
                                                            );
                                                            let v733: string =
                                                                (Documents::method72(
                                                                    string("hangul.md"),
                                                                    v488.clone(),
                                                                    v4.clone(),
                                                                ))
                                                                .1
                                                                .clone();
                                                            let v1300: LrcPtr<Documents::UH2> =
                                                                if contains(
                                                                    v468.clone(),
                                                                    v710.clone(),
                                                                ) == false
                                                                {
                                                                    let _v736: MutCell<
                                                                        Option<string>,
                                                                    > = MutCell::new(
                                                                        None::<string>,
                                                                    );
                                                                    let v738: string =
                                                                        Documents::method22();
                                                                    let v739: string =
                                                                        Documents::method23(
                                                                            v488.clone(),
                                                                        );
                                                                    let v740: string =
                                                                        Documents::method24();
                                                                    let v742: std::borrow::Cow<
                                                                        str,
                                                                    > = regex::Regex::new(&v738)
                                                                        .unwrap()
                                                                        .replace_all(&v739, &*v740);
                                                                    let v744: std::string::String =
                                                                        String::from(v742);
                                                                    {
                                                                        let x_13:
                                                                                string =
                                                                            fable_library_rust::String_::fromString(v744);
                                                                        _v736.set(Some(x_13))
                                                                    }
                                                                    {
                                                                        let v752: string = getValue(
                                                                            _v736.get().clone(),
                                                                        );
                                                                        let v755: Option<string> =
                                                                            None::<string>;
                                                                        let v756: Option<
                                                                            CancellationToken,
                                                                        > = None::<CancellationToken>;
                                                                        let v757: Array<(
                                                                            string,
                                                                            string,
                                                                        )> = new_empty::<(
                                                                            string,
                                                                            string,
                                                                        )>(
                                                                        );
                                                                        let v758 = None::<
                                                                            Func1<
                                                                                (bool, string, i32),
                                                                                Arc<Async<()>>,
                                                                            >,
                                                                        >;
                                                                        let v759 =
                                                                            None::<Func1<std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>,
                                                                                         ()>>;
                                                                        let v760:
                                                                                string =
                                                                            sprintf!("pwsh -c \"(Get-FileHash \\\"{}\\\" -Algorithm SHA256).Hash\"",
                                                                                     replace(sprintf!("{}{}",
                                                                                                      toLower(ofChar(getCharAt(v752.clone(),
                                                                                                                               0_i32))),
                                                                                                      getSlice(v752,
                                                                                                               Some(1_i32),
                                                                                                               None::<i32>)),
                                                                                             string("\\"),
                                                                                             string("/")));
                                                                        let _v761: MutCell<
                                                                            Option<(i32, string)>,
                                                                        > = MutCell::new(
                                                                            None::<(i32, string)>,
                                                                        );
                                                                        let v763: string =
                                                                            Documents::method38(
                                                                                v756.clone(),
                                                                                v760.clone(),
                                                                                v757.clone(),
                                                                                v758.clone(),
                                                                                v759.clone(),
                                                                                v755.clone(),
                                                                            );
                                                                        let patternInput_10: (
                                                                            string,
                                                                            string,
                                                                        ) = Documents::method39();
                                                                        let v766: i32 =
                                                                            length(v763.clone());
                                                                        let v767: Array<char> =
                                                                            new_init(
                                                                                &'\u{0000}',
                                                                                v766,
                                                                            );
                                                                        let v768: LrcPtr<
                                                                            Documents::Mut5,
                                                                        > = LrcPtr::new(
                                                                            Documents::Mut5 {
                                                                                l0: MutCell::new(
                                                                                    0_i32,
                                                                                ),
                                                                            },
                                                                        );
                                                                        while Documents::method26(
                                                                            v766,
                                                                            v768.clone(),
                                                                        ) {
                                                                            let v770: i32 = v768
                                                                                .l0
                                                                                .get()
                                                                                .clone();
                                                                            let v771: char =
                                                                                getCharAt(
                                                                                    v763.clone(),
                                                                                    v770,
                                                                                );
                                                                            v767.get_mut()
                                                                                [v770 as usize] =
                                                                                v771;
                                                                            {
                                                                                let v772: i32 =
                                                                                    v770 + 1_i32;
                                                                                v768.l0.set(v772);
                                                                                ()
                                                                            }
                                                                        }
                                                                        {
                                                                            let v774: List<char> =
                                                                                ofArray(
                                                                                    v767.clone(),
                                                                                );
                                                                            let patternInput_11:
                                                                                    (string,
                                                                                     string) =
                                                                                Documents::method41(patternInput_10.1.clone(),
                                                                                                    patternInput_10.0.clone(),
                                                                                                    foldBack(Func2::new(move
                                                                                                                            |b0:
                                                                                                                                 char,
                                                                                                                             b1:
                                                                                                                                 LrcPtr<Documents::UH0>|
                                                                                                                            (Documents::method40())(b0)(b1)),
                                                                                                             v774,
                                                                                                             LrcPtr::new(Documents::UH0::UH0_0)),
                                                                                                    Documents::US8::US8_0);
                                                                            let v782: string =
                                                                                patternInput_11
                                                                                    .0
                                                                                    .clone();
                                                                            let v784: Array<
                                                                                string,
                                                                            > = Documents::method42(
                                                                                patternInput_11
                                                                                    .1
                                                                                    .clone(),
                                                                            );
                                                                            let v786: Vec<string> =
                                                                                v784.to_vec();
                                                                            let v788: Vec<
                                                                                std::string::String,
                                                                            > = v786
                                                                                .iter()
                                                                                .map(|x| {
                                                                                    Func1::from(
                                                                                        v280,
                                                                                    )(
                                                                                        x.clone()
                                                                                    )
                                                                                })
                                                                                .collect();
                                                                            Documents::method3(Documents::US0::US0_1,
                                                                                               Func0::new({
                                                                                                              let v755
                                                                                                                  =
                                                                                                                  v755.clone();
                                                                                                              let v756
                                                                                                                  =
                                                                                                                  v756.clone();
                                                                                                              let v757
                                                                                                                  =
                                                                                                                  v757.clone();
                                                                                                              let v758
                                                                                                                  =
                                                                                                                  v758.clone();
                                                                                                              let v759
                                                                                                                  =
                                                                                                                  v759.clone();
                                                                                                              let v760
                                                                                                                  =
                                                                                                                  v760.clone();
                                                                                                              let v782
                                                                                                                  =
                                                                                                                  v782.clone();
                                                                                                              let v788
                                                                                                                  =
                                                                                                                  v788.clone();
                                                                                                              move
                                                                                                                  ||
                                                                                                                  Documents::closure29(v756.clone(),
                                                                                                                                       v760.clone(),
                                                                                                                                       v757.clone(),
                                                                                                                                       v758.clone(),
                                                                                                                                       v759.clone(),
                                                                                                                                       v755.clone(),
                                                                                                                                       v782.clone(),
                                                                                                                                       v788.clone(),
                                                                                                                                       ())
                                                                                                          }),
                                                                                               Documents::method47());
                                                                            {
                                                                                let v792:
                                                                                        std::pin::Pin<Box<dyn std::future::Future<Output = LrcPtr<(i32,
                                                                                                                                                   string)>>>> =
                                                                                    Documents::method48(v756.clone(),
                                                                                                        v760.clone(),
                                                                                                        v757.clone(),
                                                                                                        v758.clone(),
                                                                                                        v759.clone(),
                                                                                                        v755.clone(),
                                                                                                        v782.clone(),
                                                                                                        v788.clone());
                                                                                let v794:
                                                                                        LrcPtr<(i32,
                                                                                                string)> =
                                                                                    futures_lite::future::block_on(v792);
                                                                                _v761.set(Some((
                                                                                    v794.0.clone(),
                                                                                    v794.1.clone(),
                                                                                )));
                                                                                {
                                                                                    let patternInput_12:
                                                                                            (i32,
                                                                                             string) =
                                                                                        getValue(_v761.get().clone());
                                                                                    let v975:
                                                                                            string =
                                                                                        patternInput_12.1.clone();
                                                                                    let v979:
                                                                                            Documents::US20 =
                                                                                        if patternInput_12.0.clone()
                                                                                               ==
                                                                                               0_i32
                                                                                           {
                                                                                            Documents::US20::US20_0(v975.clone())
                                                                                        } else {
                                                                                            Documents::US20::US20_1(v975)
                                                                                        };
                                                                                    let v985:
                                                                                            string =
                                                                                        match &v979
                                                                                            {
                                                                                            Documents::US20::US20_0(v979_0_0)
                                                                                            =>
                                                                                            v979_0_0.clone(),
                                                                                            Documents::US20::US20_1(v979_1_0)
                                                                                            =>
                                                                                            panic!("{}",
                                                                                                   sprintf!("resultm.get / Result value was Error: {}", v979_1_0.clone()),),
                                                                                        };
                                                                                    let _v986:
                                                                                            MutCell<Option<bool>> =
                                                                                        MutCell::new(None::<bool>);
                                                                                    let v988:
                                                                                            string =
                                                                                        Documents::method14(v730.clone());
                                                                                    let v990:
                                                                                            &str =
                                                                                        fable_library_rust::String_::LrcStr::as_str(&v988);
                                                                                    let v992:
                                                                                            std::string::String =
                                                                                        String::from(v990);
                                                                                    let v994:
                                                                                            std::path::PathBuf =
                                                                                        std::path::PathBuf::from(v992);
                                                                                    {
                                                                                        let x_15:
                                                                                                bool =
                                                                                            if v994.clone().exists()
                                                                                               {
                                                                                                v994.is_file()
                                                                                            } else {
                                                                                                false
                                                                                            };
                                                                                        _v986.set(Some(x_15))
                                                                                    }
                                                                                    {
                                                                                        let v1261:
                                                                                                Documents::US4 =
                                                                                            if getValue(_v986.get().clone())
                                                                                               {
                                                                                                let _v1010:
                                                                                                        MutCell<Option<string>> =
                                                                                                    MutCell::new(None::<string>);
                                                                                                let v1012:
                                                                                                        string =
                                                                                                    Documents::method22();
                                                                                                let v1013:
                                                                                                        string =
                                                                                                    Documents::method23(v730.clone());
                                                                                                let v1014:
                                                                                                        string =
                                                                                                    Documents::method24();
                                                                                                let v1016:
                                                                                                        std::borrow::Cow<str> =
                                                                                                    regex::Regex::new(&v1012).unwrap().replace_all(&v1013, &*v1014);
                                                                                                let v1018:
                                                                                                        std::string::String =
                                                                                                    String::from(v1016);
                                                                                                {
                                                                                                    let x_16:
                                                                                                            string =
                                                                                                        fable_library_rust::String_::fromString(v1018);
                                                                                                    _v1010.set(Some(x_16))
                                                                                                }
                                                                                                {
                                                                                                    let v1026:
                                                                                                            string =
                                                                                                        getValue(_v1010.get().clone());
                                                                                                    let v1029:
                                                                                                            Option<string> =
                                                                                                        None::<string>;
                                                                                                    let v1030:
                                                                                                            Option<CancellationToken> =
                                                                                                        None::<CancellationToken>;
                                                                                                    let v1031:
                                                                                                            Array<(string,
                                                                                                                   string)> =
                                                                                                        new_empty::<(string,
                                                                                                                     string)>();
                                                                                                    let v1032 =
                                                                                                        None::<Func1<(bool,
                                                                                                                      string,
                                                                                                                      i32),
                                                                                                                     Arc<Async<()>>>>;
                                                                                                    let v1033 =
                                                                                                        None::<Func1<std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>,
                                                                                                                     ()>>;
                                                                                                    let v1034:
                                                                                                            string =
                                                                                                        sprintf!("pwsh -c \"(Get-FileHash \\\"{}\\\" -Algorithm SHA256).Hash\"",
                                                                                                                 replace(sprintf!("{}{}",
                                                                                                                                  toLower(ofChar(getCharAt(v1026.clone(),
                                                                                                                                                           0_i32))),
                                                                                                                                  getSlice(v1026,
                                                                                                                                           Some(1_i32),
                                                                                                                                           None::<i32>)),
                                                                                                                         string("\\"),
                                                                                                                         string("/")));
                                                                                                    let _v1035:
                                                                                                            MutCell<Option<(i32,
                                                                                                                            string)>> =
                                                                                                        MutCell::new(None::<(i32,
                                                                                                                             string)>);
                                                                                                    let v1037:
                                                                                                            string =
                                                                                                        Documents::method38(v1030.clone(),
                                                                                                                            v1034.clone(),
                                                                                                                            v1031.clone(),
                                                                                                                            v1032.clone(),
                                                                                                                            v1033.clone(),
                                                                                                                            v1029.clone());
                                                                                                    let patternInput_13:
                                                                                                            (string,
                                                                                                             string) =
                                                                                                        Documents::method39();
                                                                                                    let v1040:
                                                                                                            i32 =
                                                                                                        length(v1037.clone());
                                                                                                    let v1041:
                                                                                                            Array<char> =
                                                                                                        new_init(&'\u{0000}',
                                                                                                                 v1040);
                                                                                                    let v1042:
                                                                                                            LrcPtr<Documents::Mut5> =
                                                                                                        LrcPtr::new(Documents::Mut5{l0:
                                                                                                                                        MutCell::new(0_i32),});
                                                                                                    while Documents::method26(v1040,
                                                                                                                              v1042.clone())
                                                                                                          {
                                                                                                        let v1044:
                                                                                                                i32 =
                                                                                                            v1042.l0.get().clone();
                                                                                                        let v1045:
                                                                                                                char =
                                                                                                            getCharAt(v1037.clone(),
                                                                                                                      v1044);
                                                                                                        v1041.get_mut()[v1044
                                                                                                                            as
                                                                                                                            usize]
                                                                                                            =
                                                                                                            v1045;
                                                                                                        {
                                                                                                            let v1046:
                                                                                                                    i32 =
                                                                                                                v1044
                                                                                                                    +
                                                                                                                    1_i32;
                                                                                                            v1042.l0.set(v1046);
                                                                                                            ()
                                                                                                        }
                                                                                                    }
                                                                                                    {
                                                                                                        let v1048:
                                                                                                                List<char> =
                                                                                                            ofArray(v1041.clone());
                                                                                                        let patternInput_14:
                                                                                                                (string,
                                                                                                                 string) =
                                                                                                            Documents::method41(patternInput_13.1.clone(),
                                                                                                                                patternInput_13.0.clone(),
                                                                                                                                foldBack(Func2::new(move
                                                                                                                                                        |b0:
                                                                                                                                                             char,
                                                                                                                                                         b1:
                                                                                                                                                             LrcPtr<Documents::UH0>|
                                                                                                                                                        (Documents::method40())(b0)(b1)),
                                                                                                                                         v1048,
                                                                                                                                         LrcPtr::new(Documents::UH0::UH0_0)),
                                                                                                                                Documents::US8::US8_0);
                                                                                                        let v1056:
                                                                                                                string =
                                                                                                            patternInput_14.0.clone();
                                                                                                        let v1058:
                                                                                                                Array<string> =
                                                                                                            Documents::method42(patternInput_14.1.clone());
                                                                                                        let v1060:
                                                                                                                Vec<string> =
                                                                                                            v1058.to_vec();
                                                                                                        let v1062:
                                                                                                                Vec<std::string::String> =
                                                                                                            v1060.iter().map(|x| Func1::from(v280)(x.clone())).collect();
                                                                                                        Documents::method3(Documents::US0::US0_1,
                                                                                                                           Func0::new({
                                                                                                                                          let v1029
                                                                                                                                              =
                                                                                                                                              v1029.clone();
                                                                                                                                          let v1030
                                                                                                                                              =
                                                                                                                                              v1030.clone();
                                                                                                                                          let v1031
                                                                                                                                              =
                                                                                                                                              v1031.clone();
                                                                                                                                          let v1032
                                                                                                                                              =
                                                                                                                                              v1032.clone();
                                                                                                                                          let v1033
                                                                                                                                              =
                                                                                                                                              v1033.clone();
                                                                                                                                          let v1034
                                                                                                                                              =
                                                                                                                                              v1034.clone();
                                                                                                                                          let v1056
                                                                                                                                              =
                                                                                                                                              v1056.clone();
                                                                                                                                          let v1062
                                                                                                                                              =
                                                                                                                                              v1062.clone();
                                                                                                                                          move
                                                                                                                                              ||
                                                                                                                                              Documents::closure29(v1030.clone(),
                                                                                                                                                                   v1034.clone(),
                                                                                                                                                                   v1031.clone(),
                                                                                                                                                                   v1032.clone(),
                                                                                                                                                                   v1033.clone(),
                                                                                                                                                                   v1029.clone(),
                                                                                                                                                                   v1056.clone(),
                                                                                                                                                                   v1062.clone(),
                                                                                                                                                                   ())
                                                                                                                                      }),
                                                                                                                           Documents::method47());
                                                                                                        {
                                                                                                            let v1066:
                                                                                                                    std::pin::Pin<Box<dyn std::future::Future<Output = LrcPtr<(i32,
                                                                                                                                                                               string)>>>> =
                                                                                                                Documents::method48(v1030.clone(),
                                                                                                                                    v1034.clone(),
                                                                                                                                    v1031.clone(),
                                                                                                                                    v1032.clone(),
                                                                                                                                    v1033.clone(),
                                                                                                                                    v1029.clone(),
                                                                                                                                    v1056.clone(),
                                                                                                                                    v1062.clone());
                                                                                                            let v1068:
                                                                                                                    LrcPtr<(i32,
                                                                                                                            string)> =
                                                                                                                futures_lite::future::block_on(v1066);
                                                                                                            _v1035.set(Some((v1068.0.clone(),
                                                                                                                             v1068.1.clone())));
                                                                                                            {
                                                                                                                let patternInput_15:
                                                                                                                        (i32,
                                                                                                                         string) =
                                                                                                                    getValue(_v1035.get().clone());
                                                                                                                let v1249:
                                                                                                                        string =
                                                                                                                    patternInput_15.1.clone();
                                                                                                                let v1253:
                                                                                                                        Documents::US20 =
                                                                                                                    if patternInput_15.0.clone()
                                                                                                                           ==
                                                                                                                           0_i32
                                                                                                                       {
                                                                                                                        Documents::US20::US20_0(v1249.clone())
                                                                                                                    } else {
                                                                                                                        Documents::US20::US20_1(v1249)
                                                                                                                    };
                                                                                                                match &v1253
                                                                                                                    {
                                                                                                                    Documents::US20::US20_0(v1253_0_0)
                                                                                                                    =>
                                                                                                                    Documents::US4::US4_0(v1253_0_0.clone()),
                                                                                                                    _
                                                                                                                    =>
                                                                                                                    Documents::US4::US4_1,
                                                                                                                }
                                                                                                            }
                                                                                                        }
                                                                                                    }
                                                                                                }
                                                                                            } else {
                                                                                                Documents::US4::US4_1
                                                                                            };
                                                                                        if if if let Documents::US4::US4_1
                                                                                                     =
                                                                                                     &v1261
                                                                                                 {
                                                                                                  true
                                                                                              } else {
                                                                                                  false
                                                                                              }
                                                                                              {
                                                                                               true
                                                                                           } else {
                                                                                               v985.clone()
                                                                                                   !=
                                                                                                   match &v1261
                                                                                                       {
                                                                                                       Documents::US4::US4_0(v1261_0_0)
                                                                                                       =>
                                                                                                       match &v1261
                                                                                                           {
                                                                                                           Documents::US4::US4_0(x)
                                                                                                           =>
                                                                                                           x.clone(),
                                                                                                           _
                                                                                                           =>
                                                                                                           unreachable!(),
                                                                                                       },
                                                                                                       _
                                                                                                       =>
                                                                                                       panic!("{}",
                                                                                                              string("Option does not have a value."),),
                                                                                                   }
                                                                                           }
                                                                                           {
                                                                                            Documents::method3(Documents::US0::US0_2,
                                                                                                               Func0::new(move
                                                                                                                              ||
                                                                                                                              Documents::closure57((),
                                                                                                                                                   ())),
                                                                                                               Func0::new({
                                                                                                                              let patternInput_5
                                                                                                                                  =
                                                                                                                                  patternInput_5.clone();
                                                                                                                              let patternInput_8
                                                                                                                                  =
                                                                                                                                  patternInput_8.clone();
                                                                                                                              let v1261
                                                                                                                                  =
                                                                                                                                  v1261.clone();
                                                                                                                              let v205
                                                                                                                                  =
                                                                                                                                  v205.clone();
                                                                                                                              let v225
                                                                                                                                  =
                                                                                                                                  v225.clone();
                                                                                                                              let v245
                                                                                                                                  =
                                                                                                                                  v245.clone();
                                                                                                                              let v468
                                                                                                                                  =
                                                                                                                                  v468.clone();
                                                                                                                              let v488
                                                                                                                                  =
                                                                                                                                  v488.clone();
                                                                                                                              let v710
                                                                                                                                  =
                                                                                                                                  v710.clone();
                                                                                                                              let v730
                                                                                                                                  =
                                                                                                                                  v730.clone();
                                                                                                                              let v985
                                                                                                                                  =
                                                                                                                                  v985.clone();
                                                                                                                              move
                                                                                                                                  ||
                                                                                                                                  Documents::closure58(v205.clone(),
                                                                                                                                                       v225.clone(),
                                                                                                                                                       v245.clone(),
                                                                                                                                                       v468.clone(),
                                                                                                                                                       patternInput_5.0.clone(),
                                                                                                                                                       v488.clone(),
                                                                                                                                                       v710.clone(),
                                                                                                                                                       patternInput_8.0.clone(),
                                                                                                                                                       v730.clone(),
                                                                                                                                                       v985.clone(),
                                                                                                                                                       v1261.clone(),
                                                                                                                                                       ())
                                                                                                                          }));
                                                                                            {
                                                                                                let _v1273:
                                                                                                        MutCell<Option<()>> =
                                                                                                    MutCell::new(None::<()>);
                                                                                                let v1275:
                                                                                                        string =
                                                                                                    Documents::method73(v730.clone());
                                                                                                let v1277:
                                                                                                        Result<u64,
                                                                                                               std::io::Error> =
                                                                                                    std::fs::copy(&*v488.clone(), &*v1275);
                                                                                                let v1279:
                                                                                                        u64 =
                                                                                                    v1277.unwrap();
                                                                                                _v1273.set(Some(()));
                                                                                                getValue(_v1273.get().clone());
                                                                                                {
                                                                                                    let v1284 =
                                                                                                        Func1::new({
                                                                                                                       let v3
                                                                                                                           =
                                                                                                                           v3.clone();
                                                                                                                       let v4
                                                                                                                           =
                                                                                                                           v4.clone();
                                                                                                                       move
                                                                                                                           |v_2:
                                                                                                                                string|
                                                                                                                           Documents::closure66(v4.clone(),
                                                                                                                                                v3.clone(),
                                                                                                                                                v_2)
                                                                                                                   });
                                                                                                    LrcPtr::new(Documents::UH2::UH2_1(LrcPtr::new(Documents::UH3::UH3_1(string("hangul.md"),
                                                                                                                                                                        v488.clone(),
                                                                                                                                                                        Func2::new({
                                                                                                                                                                                       let v0_1
                                                                                                                                                                                           =
                                                                                                                                                                                           v0_1.clone();
                                                                                                                                                                                       let v1_1
                                                                                                                                                                                           =
                                                                                                                                                                                           v1_1.clone();
                                                                                                                                                                                       let v3
                                                                                                                                                                                           =
                                                                                                                                                                                           v3.clone();
                                                                                                                                                                                       let v4
                                                                                                                                                                                           =
                                                                                                                                                                                           v4.clone();
                                                                                                                                                                                       move
                                                                                                                                                                                           |b0:
                                                                                                                                                                                                string,
                                                                                                                                                                                            b1:
                                                                                                                                                                                                string|
                                                                                                                                                                                           (Func1::new({
                                                                                                                                                                                                           let v0_1
                                                                                                                                                                                                               =
                                                                                                                                                                                                               v0_1.clone();
                                                                                                                                                                                                           let v1_1
                                                                                                                                                                                                               =
                                                                                                                                                                                                               v1_1.clone();
                                                                                                                                                                                                           let v3
                                                                                                                                                                                                               =
                                                                                                                                                                                                               v3.clone();
                                                                                                                                                                                                           let v4
                                                                                                                                                                                                               =
                                                                                                                                                                                                               v4.clone();
                                                                                                                                                                                                           move
                                                                                                                                                                                                               |v_1:
                                                                                                                                                                                                                    string|
                                                                                                                                                                                                               Documents::closure59(v4.clone(),
                                                                                                                                                                                                                                    v3.clone(),
                                                                                                                                                                                                                                    v1_1.clone(),
                                                                                                                                                                                                                                    v0_1.clone(),
                                                                                                                                                                                                                                    v_1)
                                                                                                                                                                                                       }))(b0)(b1)
                                                                                                                                                                                   }),
                                                                                                                                                                        LrcPtr::new(Documents::UH3::UH3_0))),
                                                                                                                                      LrcPtr::new(Documents::UH2::UH2_1(LrcPtr::new(Documents::UH3::UH3_1(string("html"),
                                                                                                                                                                                                          v488.clone(),
                                                                                                                                                                                                          Func2::new({
                                                                                                                                                                                                                         let v1284
                                                                                                                                                                                                                             =
                                                                                                                                                                                                                             v1284.clone();
                                                                                                                                                                                                                         move
                                                                                                                                                                                                                             |b0:
                                                                                                                                                                                                                                  string,
                                                                                                                                                                                                                              b1:
                                                                                                                                                                                                                                  string|
                                                                                                                                                                                                                             v1284(b0)(b1)
                                                                                                                                                                                                                     }),
                                                                                                                                                                                                          LrcPtr::new(Documents::UH3::UH3_1(string("pdf"),
                                                                                                                                                                                                                                            v488.clone(),
                                                                                                                                                                                                                                            Func2::new({
                                                                                                                                                                                                                                                           let v1284
                                                                                                                                                                                                                                                               =
                                                                                                                                                                                                                                                               v1284.clone();
                                                                                                                                                                                                                                                           move
                                                                                                                                                                                                                                                               |b0:
                                                                                                                                                                                                                                                                    string,
                                                                                                                                                                                                                                                                b1:
                                                                                                                                                                                                                                                                    string|
                                                                                                                                                                                                                                                               v1284(b0)(b1)
                                                                                                                                                                                                                                                       }),
                                                                                                                                                                                                                                            LrcPtr::new(Documents::UH3::UH3_1(string("epub"),
                                                                                                                                                                                                                                                                              v488.clone(),
                                                                                                                                                                                                                                                                              Func2::new({
                                                                                                                                                                                                                                                                                             let v1284
                                                                                                                                                                                                                                                                                                 =
                                                                                                                                                                                                                                                                                                 v1284.clone();
                                                                                                                                                                                                                                                                                             move
                                                                                                                                                                                                                                                                                                 |b0:
                                                                                                                                                                                                                                                                                                      string,
                                                                                                                                                                                                                                                                                                  b1:
                                                                                                                                                                                                                                                                                                      string|
                                                                                                                                                                                                                                                                                                 v1284(b0)(b1)
                                                                                                                                                                                                                                                                                         }),
                                                                                                                                                                                                                                                                              LrcPtr::new(Documents::UH3::UH3_1(string("html"),
                                                                                                                                                                                                                                                                                                                v733.clone(),
                                                                                                                                                                                                                                                                                                                Func2::new({
                                                                                                                                                                                                                                                                                                                               let v1284
                                                                                                                                                                                                                                                                                                                                   =
                                                                                                                                                                                                                                                                                                                                   v1284.clone();
                                                                                                                                                                                                                                                                                                                               move
                                                                                                                                                                                                                                                                                                                                   |b0:
                                                                                                                                                                                                                                                                                                                                        string,
                                                                                                                                                                                                                                                                                                                                    b1:
                                                                                                                                                                                                                                                                                                                                        string|
                                                                                                                                                                                                                                                                                                                                   v1284(b0)(b1)
                                                                                                                                                                                                                                                                                                                           }),
                                                                                                                                                                                                                                                                                                                LrcPtr::new(Documents::UH3::UH3_1(string("pdf"),
                                                                                                                                                                                                                                                                                                                                                  v733.clone(),
                                                                                                                                                                                                                                                                                                                                                  Func2::new({
                                                                                                                                                                                                                                                                                                                                                                 let v1284
                                                                                                                                                                                                                                                                                                                                                                     =
                                                                                                                                                                                                                                                                                                                                                                     v1284.clone();
                                                                                                                                                                                                                                                                                                                                                                 move
                                                                                                                                                                                                                                                                                                                                                                     |b0:
                                                                                                                                                                                                                                                                                                                                                                          string,
                                                                                                                                                                                                                                                                                                                                                                      b1:
                                                                                                                                                                                                                                                                                                                                                                          string|
                                                                                                                                                                                                                                                                                                                                                                     v1284(b0)(b1)
                                                                                                                                                                                                                                                                                                                                                             }),
                                                                                                                                                                                                                                                                                                                                                  LrcPtr::new(Documents::UH3::UH3_1(string("epub"),
                                                                                                                                                                                                                                                                                                                                                                                    v733.clone(),
                                                                                                                                                                                                                                                                                                                                                                                    Func2::new({
                                                                                                                                                                                                                                                                                                                                                                                                   let v1284
                                                                                                                                                                                                                                                                                                                                                                                                       =
                                                                                                                                                                                                                                                                                                                                                                                                       v1284.clone();
                                                                                                                                                                                                                                                                                                                                                                                                   move
                                                                                                                                                                                                                                                                                                                                                                                                       |b0:
                                                                                                                                                                                                                                                                                                                                                                                                            string,
                                                                                                                                                                                                                                                                                                                                                                                                        b1:
                                                                                                                                                                                                                                                                                                                                                                                                            string|
                                                                                                                                                                                                                                                                                                                                                                                                       v1284(b0)(b1)
                                                                                                                                                                                                                                                                                                                                                                                               }),
                                                                                                                                                                                                                                                                                                                                                                                    LrcPtr::new(Documents::UH3::UH3_0))))))))))))),
                                                                                                                                                                        LrcPtr::new(Documents::UH2::UH2_0)))))
                                                                                                }
                                                                                            }
                                                                                        } else {
                                                                                            LrcPtr::new(Documents::UH2::UH2_0)
                                                                                        }
                                                                                    }
                                                                                }
                                                                            }
                                                                        }
                                                                    }
                                                                } else {
                                                                    LrcPtr::new(
                                                                        Documents::UH2::UH2_0,
                                                                    )
                                                                };
                                                            let v1767: Array<
                                                                LrcPtr<Documents::UH3>,
                                                            > = toArray(Documents::method81(
                                                                if (if let Documents::UH2::UH2_0 =
                                                                    v1300.as_ref()
                                                                {
                                                                    true
                                                                } else {
                                                                    false
                                                                }) != true
                                                                {
                                                                    v1300
                                                                } else {
                                                                    let patternInput_16: (
                                                                        string,
                                                                        string,
                                                                    ) = Documents::method72(
                                                                        string("epub"),
                                                                        v733.clone(),
                                                                        v4.clone(),
                                                                    );
                                                                    let v1306: string =
                                                                        patternInput_16.1.clone();
                                                                    let v1305: string =
                                                                        patternInput_16.0.clone();
                                                                    let _v1307: MutCell<
                                                                        Option<bool>,
                                                                    > = MutCell::new(None::<bool>);
                                                                    let v1309: string =
                                                                        Documents::method14(
                                                                            v1306.clone(),
                                                                        );
                                                                    let v1311:
                                                                                                        &str =
                                                                                                    fable_library_rust::String_::LrcStr::as_str(&v1309);
                                                                    let v1313: std::string::String =
                                                                        String::from(v1311);
                                                                    let v1315: std::path::PathBuf =
                                                                        std::path::PathBuf::from(
                                                                            v1313,
                                                                        );
                                                                    {
                                                                        let x_19: bool = if v1315
                                                                            .clone()
                                                                            .exists()
                                                                        {
                                                                            v1315.is_file()
                                                                        } else {
                                                                            false
                                                                        };
                                                                        _v1307.set(Some(x_19))
                                                                    }
                                                                    {
                                                                        let v1371: LrcPtr<
                                                                            Documents::UH3,
                                                                        > = if if getValue(
                                                                            _v1307.get().clone(),
                                                                        ) == false
                                                                        {
                                                                            let _v1332: MutCell<
                                                                                Option<bool>,
                                                                            > = MutCell::new(
                                                                                None::<bool>,
                                                                            );
                                                                            let v1334: string =
                                                                                Documents::method14(
                                                                                    v1305.clone(),
                                                                                );
                                                                            let v1336:
                                                                                                                       &str =
                                                                                                                   fable_library_rust::String_::LrcStr::as_str(&v1334);
                                                                            let v1338:
                                                                                                                       std::string::String =
                                                                                                                   String::from(v1336);
                                                                            let v1340:
                                                                                                                       std::path::PathBuf =
                                                                                                                   std::path::PathBuf::from(v1338);
                                                                            {
                                                                                let x_20: bool =
                                                                                    if v1340
                                                                                        .clone()
                                                                                        .exists()
                                                                                    {
                                                                                        v1340.is_file()
                                                                                    } else {
                                                                                        false
                                                                                    };
                                                                                _v1332
                                                                                    .set(Some(x_20))
                                                                            }
                                                                            if getValue(
                                                                                _v1332
                                                                                    .get()
                                                                                    .clone(),
                                                                            ) {
                                                                                Documents::method3(Documents::US0::US0_2,
                                                                                                                                      Func0::new(move
                                                                                                                                                     ||
                                                                                                                                                     Documents::closure70((),
                                                                                                                                                                          ())),
                                                                                                                                      Func0::new({
                                                                                                                                                     let v1305
                                                                                                                                                         =
                                                                                                                                                         v1305.clone();
                                                                                                                                                     let v1306
                                                                                                                                                         =
                                                                                                                                                         v1306.clone();
                                                                                                                                                     move
                                                                                                                                                         ||
                                                                                                                                                         Documents::closure71(v1305.clone(),
                                                                                                                                                                              v1306.clone(),
                                                                                                                                                                              ())
                                                                                                                                                 }));
                                                                                {
                                                                                    let _v1358:
                                                                                                                               MutCell<Option<()>> =
                                                                                                                           MutCell::new(None::<()>);
                                                                                    let v1360:
                                                                                                                               string =
                                                                                                                           Documents::method73(v1306.clone());
                                                                                    let v1362:
                                                                                                                               Result<u64,
                                                                                                                                      std::io::Error> =
                                                                                                                           std::fs::copy(&*v1305.clone(), &*v1360);
                                                                                    let v1364: u64 =
                                                                                        v1362
                                                                                            .unwrap(
                                                                                            );
                                                                                    _v1358.set(
                                                                                        Some(()),
                                                                                    );
                                                                                    getValue(
                                                                                        _v1358
                                                                                            .get()
                                                                                            .clone(
                                                                                            ),
                                                                                    );
                                                                                    false
                                                                                }
                                                                            } else {
                                                                                true
                                                                            }
                                                                        } else {
                                                                            true
                                                                        } {
                                                                            LrcPtr::new(Documents::UH3::UH3_1(string("epub"),
                                                                                                                                              v733.clone(),
                                                                                                                                              Func2::new({
                                                                                                                                                             let v3
                                                                                                                                                                 =
                                                                                                                                                                 v3.clone();
                                                                                                                                                             let v4
                                                                                                                                                                 =
                                                                                                                                                                 v4.clone();
                                                                                                                                                             move
                                                                                                                                                                 |b0:
                                                                                                                                                                      string,
                                                                                                                                                                  b1:
                                                                                                                                                                      string|
                                                                                                                                                                 (Func1::new({
                                                                                                                                                                                 let v3
                                                                                                                                                                                     =
                                                                                                                                                                                     v3.clone();
                                                                                                                                                                                 let v4
                                                                                                                                                                                     =
                                                                                                                                                                                     v4.clone();
                                                                                                                                                                                 move
                                                                                                                                                                                     |v_3:
                                                                                                                                                                                          string|
                                                                                                                                                                                     Documents::closure66(v4.clone(),
                                                                                                                                                                                                          v3.clone(),
                                                                                                                                                                                                          v_3)
                                                                                                                                                                             }))(b0)(b1)
                                                                                                                                                         }),
                                                                                                                                              LrcPtr::new(Documents::UH3::UH3_0)))
                                                                        } else {
                                                                            LrcPtr::new(Documents::UH3::UH3_0)
                                                                        };
                                                                        let patternInput_17: (
                                                                            string,
                                                                            string,
                                                                        ) = Documents::method72(
                                                                            string("pdf"),
                                                                            v733.clone(),
                                                                            v4.clone(),
                                                                        );
                                                                        let v1374: string =
                                                                            patternInput_17
                                                                                .1
                                                                                .clone();
                                                                        let v1373: string =
                                                                            patternInput_17
                                                                                .0
                                                                                .clone();
                                                                        let _v1375: MutCell<
                                                                            Option<bool>,
                                                                        > = MutCell::new(
                                                                            None::<bool>,
                                                                        );
                                                                        let v1377: string =
                                                                            Documents::method14(
                                                                                v1374.clone(),
                                                                            );
                                                                        let v1379:
                                                                                                            &str =
                                                                                                        fable_library_rust::String_::LrcStr::as_str(&v1377);
                                                                        let v1381:
                                                                                                            std::string::String =
                                                                                                        String::from(v1379);
                                                                        let v1383:
                                                                                                            std::path::PathBuf =
                                                                                                        std::path::PathBuf::from(v1381);
                                                                        {
                                                                            let x_22: bool =
                                                                                if v1383
                                                                                    .clone()
                                                                                    .exists()
                                                                                {
                                                                                    v1383.is_file()
                                                                                } else {
                                                                                    false
                                                                                };
                                                                            _v1375.set(Some(x_22))
                                                                        }
                                                                        {
                                                                            let v1436: LrcPtr<
                                                                                Documents::UH3,
                                                                            > = if if getValue(
                                                                                _v1375
                                                                                    .get()
                                                                                    .clone(),
                                                                            ) == false
                                                                            {
                                                                                let _v1399:
                                                                                                                           MutCell<Option<bool>> =
                                                                                                                       MutCell::new(None::<bool>);
                                                                                let v1401:
                                                                                                                           string =
                                                                                                                       Documents::method14(v1373.clone());
                                                                                let v1403:
                                                                                                                           &str =
                                                                                                                       fable_library_rust::String_::LrcStr::as_str(&v1401);
                                                                                let v1405:
                                                                                                                           std::string::String =
                                                                                                                       String::from(v1403);
                                                                                let v1407:
                                                                                                                           std::path::PathBuf =
                                                                                                                       std::path::PathBuf::from(v1405);
                                                                                {
                                                                                    let x_23: bool =
                                                                                        if v1407
                                                                                            .clone()
                                                                                            .exists(
                                                                                            )
                                                                                        {
                                                                                            v1407.is_file()
                                                                                        } else {
                                                                                            false
                                                                                        };
                                                                                    _v1399.set(
                                                                                        Some(x_23),
                                                                                    )
                                                                                }
                                                                                if getValue(
                                                                                    _v1399
                                                                                        .get()
                                                                                        .clone(),
                                                                                ) {
                                                                                    Documents::method3(Documents::US0::US0_2,
                                                                                                                                          Func0::new(move
                                                                                                                                                         ||
                                                                                                                                                         Documents::closure70((),
                                                                                                                                                                              ())),
                                                                                                                                          Func0::new({
                                                                                                                                                         let v1373
                                                                                                                                                             =
                                                                                                                                                             v1373.clone();
                                                                                                                                                         let v1374
                                                                                                                                                             =
                                                                                                                                                             v1374.clone();
                                                                                                                                                         move
                                                                                                                                                             ||
                                                                                                                                                             Documents::closure71(v1373.clone(),
                                                                                                                                                                                  v1374.clone(),
                                                                                                                                                                                  ())
                                                                                                                                                     }));
                                                                                    {
                                                                                        let _v1425:
                                                                                                                                   MutCell<Option<()>> =
                                                                                                                               MutCell::new(None::<()>);
                                                                                        let v1427:
                                                                                                                                   string =
                                                                                                                               Documents::method73(v1374.clone());
                                                                                        let v1429:
                                                                                                                                   Result<u64,
                                                                                                                                          std::io::Error> =
                                                                                                                               std::fs::copy(&*v1373.clone(), &*v1427);
                                                                                        let v1431:
                                                                                                                                   u64 =
                                                                                                                               v1429.unwrap();
                                                                                        _v1425.set(Some(()));
                                                                                        getValue(_v1425.get().clone());
                                                                                        false
                                                                                    }
                                                                                } else {
                                                                                    true
                                                                                }
                                                                            } else {
                                                                                true
                                                                            } {
                                                                                LrcPtr::new(Documents::UH3::UH3_1(string("pdf"),
                                                                                                                                                  v733.clone(),
                                                                                                                                                  Func2::new({
                                                                                                                                                                 let v3
                                                                                                                                                                     =
                                                                                                                                                                     v3.clone();
                                                                                                                                                                 let v4
                                                                                                                                                                     =
                                                                                                                                                                     v4.clone();
                                                                                                                                                                 move
                                                                                                                                                                     |b0:
                                                                                                                                                                          string,
                                                                                                                                                                      b1:
                                                                                                                                                                          string|
                                                                                                                                                                     (Func1::new({
                                                                                                                                                                                     let v3
                                                                                                                                                                                         =
                                                                                                                                                                                         v3.clone();
                                                                                                                                                                                     let v4
                                                                                                                                                                                         =
                                                                                                                                                                                         v4.clone();
                                                                                                                                                                                     move
                                                                                                                                                                                         |v_4:
                                                                                                                                                                                              string|
                                                                                                                                                                                         Documents::closure66(v4.clone(),
                                                                                                                                                                                                              v3.clone(),
                                                                                                                                                                                                              v_4)
                                                                                                                                                                                 }))(b0)(b1)
                                                                                                                                                             }),
                                                                                                                                                  v1371.clone()))
                                                                            } else {
                                                                                v1371
                                                                            };
                                                                            let patternInput_18: (
                                                                                string,
                                                                                string,
                                                                            ) = Documents::method72(
                                                                                string("html"),
                                                                                v733.clone(),
                                                                                v4.clone(),
                                                                            );
                                                                            let v1439: string =
                                                                                patternInput_18
                                                                                    .1
                                                                                    .clone();
                                                                            let v1438: string =
                                                                                patternInput_18
                                                                                    .0
                                                                                    .clone();
                                                                            let _v1440: MutCell<
                                                                                Option<bool>,
                                                                            > = MutCell::new(
                                                                                None::<bool>,
                                                                            );
                                                                            let v1442: string =
                                                                                Documents::method14(
                                                                                    v1439.clone(),
                                                                                );
                                                                            let v1444:
                                                                                                                &str =
                                                                                                            fable_library_rust::String_::LrcStr::as_str(&v1442);
                                                                            let v1446:
                                                                                                                std::string::String =
                                                                                                            String::from(v1444);
                                                                            let v1448:
                                                                                                                std::path::PathBuf =
                                                                                                            std::path::PathBuf::from(v1446);
                                                                            {
                                                                                let x_25: bool =
                                                                                    if v1448
                                                                                        .clone()
                                                                                        .exists()
                                                                                    {
                                                                                        v1448.is_file()
                                                                                    } else {
                                                                                        false
                                                                                    };
                                                                                _v1440
                                                                                    .set(Some(x_25))
                                                                            }
                                                                            {
                                                                                let v1501: LrcPtr<
                                                                                    Documents::UH3,
                                                                                > = if if getValue(
                                                                                    _v1440
                                                                                        .get()
                                                                                        .clone(),
                                                                                ) == false
                                                                                {
                                                                                    let _v1464:
                                                                                                                               MutCell<Option<bool>> =
                                                                                                                           MutCell::new(None::<bool>);
                                                                                    let v1466:
                                                                                                                               string =
                                                                                                                           Documents::method14(v1438.clone());
                                                                                    let v1468:
                                                                                                                               &str =
                                                                                                                           fable_library_rust::String_::LrcStr::as_str(&v1466);
                                                                                    let v1470:
                                                                                                                               std::string::String =
                                                                                                                           String::from(v1468);
                                                                                    let v1472:
                                                                                                                               std::path::PathBuf =
                                                                                                                           std::path::PathBuf::from(v1470);
                                                                                    {
                                                                                        let x_26:
                                                                                                                                   bool =
                                                                                                                               if v1472.clone().exists()
                                                                                                                                  {
                                                                                                                                   v1472.is_file()
                                                                                                                               } else {
                                                                                                                                   false
                                                                                                                               };
                                                                                        _v1464.set(Some(x_26))
                                                                                    }
                                                                                    if getValue(
                                                                                        _v1464
                                                                                            .get()
                                                                                            .clone(
                                                                                            ),
                                                                                    ) {
                                                                                        Documents::method3(Documents::US0::US0_2,
                                                                                                                                              Func0::new(move
                                                                                                                                                             ||
                                                                                                                                                             Documents::closure70((),
                                                                                                                                                                                  ())),
                                                                                                                                              Func0::new({
                                                                                                                                                             let v1438
                                                                                                                                                                 =
                                                                                                                                                                 v1438.clone();
                                                                                                                                                             let v1439
                                                                                                                                                                 =
                                                                                                                                                                 v1439.clone();
                                                                                                                                                             move
                                                                                                                                                                 ||
                                                                                                                                                                 Documents::closure71(v1438.clone(),
                                                                                                                                                                                      v1439.clone(),
                                                                                                                                                                                      ())
                                                                                                                                                         }));
                                                                                        {
                                                                                            let _v1490:
                                                                                                                                       MutCell<Option<()>> =
                                                                                                                                   MutCell::new(None::<()>);
                                                                                            let v1492:
                                                                                                                                       string =
                                                                                                                                   Documents::method73(v1439.clone());
                                                                                            let v1494:
                                                                                                                                       Result<u64,
                                                                                                                                              std::io::Error> =
                                                                                                                                   std::fs::copy(&*v1438.clone(), &*v1492);
                                                                                            let v1496:
                                                                                                                                       u64 =
                                                                                                                                   v1494.unwrap();
                                                                                            _v1490.set(Some(()));
                                                                                            getValue(_v1490.get().clone());
                                                                                            false
                                                                                        }
                                                                                    } else {
                                                                                        true
                                                                                    }
                                                                                } else {
                                                                                    true
                                                                                } {
                                                                                    LrcPtr::new(Documents::UH3::UH3_1(string("html"),
                                                                                                                                                      v733,
                                                                                                                                                      Func2::new({
                                                                                                                                                                     let v3
                                                                                                                                                                         =
                                                                                                                                                                         v3.clone();
                                                                                                                                                                     let v4
                                                                                                                                                                         =
                                                                                                                                                                         v4.clone();
                                                                                                                                                                     move
                                                                                                                                                                         |b0:
                                                                                                                                                                              string,
                                                                                                                                                                          b1:
                                                                                                                                                                              string|
                                                                                                                                                                         (Func1::new({
                                                                                                                                                                                         let v3
                                                                                                                                                                                             =
                                                                                                                                                                                             v3.clone();
                                                                                                                                                                                         let v4
                                                                                                                                                                                             =
                                                                                                                                                                                             v4.clone();
                                                                                                                                                                                         move
                                                                                                                                                                                             |v_5:
                                                                                                                                                                                                  string|
                                                                                                                                                                                             Documents::closure66(v4.clone(),
                                                                                                                                                                                                                  v3.clone(),
                                                                                                                                                                                                                  v_5)
                                                                                                                                                                                     }))(b0)(b1)
                                                                                                                                                                 }),
                                                                                                                                                      v1436.clone()))
                                                                                } else {
                                                                                    v1436
                                                                                };
                                                                                let patternInput_19:
                                                                                                                    (string,
                                                                                                                     string) =
                                                                                                                Documents::method72(string("epub"),
                                                                                                                                    v488.clone(),
                                                                                                                                    v4.clone());
                                                                                let v1503: string =
                                                                                    patternInput_19
                                                                                        .1
                                                                                        .clone();
                                                                                let v1502: string =
                                                                                    patternInput_19
                                                                                        .0
                                                                                        .clone();
                                                                                let _v1504:
                                                                                                                    MutCell<Option<bool>> =
                                                                                                                MutCell::new(None::<bool>);
                                                                                let v1506:
                                                                                                                    string =
                                                                                                                Documents::method14(v1503.clone());
                                                                                let v1508:
                                                                                                                    &str =
                                                                                                                fable_library_rust::String_::LrcStr::as_str(&v1506);
                                                                                let v1510:
                                                                                                                    std::string::String =
                                                                                                                String::from(v1508);
                                                                                let v1512:
                                                                                                                    std::path::PathBuf =
                                                                                                                std::path::PathBuf::from(v1510);
                                                                                {
                                                                                    let x_28: bool =
                                                                                        if v1512
                                                                                            .clone()
                                                                                            .exists(
                                                                                            )
                                                                                        {
                                                                                            v1512.is_file()
                                                                                        } else {
                                                                                            false
                                                                                        };
                                                                                    _v1504.set(
                                                                                        Some(x_28),
                                                                                    )
                                                                                }
                                                                                {
                                                                                    let v1565:
                                                                                                                        LrcPtr<Documents::UH3> =
                                                                                                                    if if getValue(_v1504.get().clone())
                                                                                                                              ==
                                                                                                                              false
                                                                                                                          {
                                                                                                                           let _v1528:
                                                                                                                                   MutCell<Option<bool>> =
                                                                                                                               MutCell::new(None::<bool>);
                                                                                                                           let v1530:
                                                                                                                                   string =
                                                                                                                               Documents::method14(v1502.clone());
                                                                                                                           let v1532:
                                                                                                                                   &str =
                                                                                                                               fable_library_rust::String_::LrcStr::as_str(&v1530);
                                                                                                                           let v1534:
                                                                                                                                   std::string::String =
                                                                                                                               String::from(v1532);
                                                                                                                           let v1536:
                                                                                                                                   std::path::PathBuf =
                                                                                                                               std::path::PathBuf::from(v1534);
                                                                                                                           {
                                                                                                                               let x_29:
                                                                                                                                       bool =
                                                                                                                                   if v1536.clone().exists()
                                                                                                                                      {
                                                                                                                                       v1536.is_file()
                                                                                                                                   } else {
                                                                                                                                       false
                                                                                                                                   };
                                                                                                                               _v1528.set(Some(x_29))
                                                                                                                           }
                                                                                                                           if getValue(_v1528.get().clone())
                                                                                                                              {
                                                                                                                               Documents::method3(Documents::US0::US0_2,
                                                                                                                                                  Func0::new(move
                                                                                                                                                                 ||
                                                                                                                                                                 Documents::closure70((),
                                                                                                                                                                                      ())),
                                                                                                                                                  Func0::new({
                                                                                                                                                                 let v1502
                                                                                                                                                                     =
                                                                                                                                                                     v1502.clone();
                                                                                                                                                                 let v1503
                                                                                                                                                                     =
                                                                                                                                                                     v1503.clone();
                                                                                                                                                                 move
                                                                                                                                                                     ||
                                                                                                                                                                     Documents::closure71(v1502.clone(),
                                                                                                                                                                                          v1503.clone(),
                                                                                                                                                                                          ())
                                                                                                                                                             }));
                                                                                                                               {
                                                                                                                                   let _v1554:
                                                                                                                                           MutCell<Option<()>> =
                                                                                                                                       MutCell::new(None::<()>);
                                                                                                                                   let v1556:
                                                                                                                                           string =
                                                                                                                                       Documents::method73(v1503.clone());
                                                                                                                                   let v1558:
                                                                                                                                           Result<u64,
                                                                                                                                                  std::io::Error> =
                                                                                                                                       std::fs::copy(&*v1502.clone(), &*v1556);
                                                                                                                                   let v1560:
                                                                                                                                           u64 =
                                                                                                                                       v1558.unwrap();
                                                                                                                                   _v1554.set(Some(()));
                                                                                                                                   getValue(_v1554.get().clone());
                                                                                                                                   false
                                                                                                                               }
                                                                                                                           } else {
                                                                                                                               true
                                                                                                                           }
                                                                                                                       } else {
                                                                                                                           true
                                                                                                                       }
                                                                                                                       {
                                                                                                                        LrcPtr::new(Documents::UH3::UH3_1(string("epub"),
                                                                                                                                                          v488.clone(),
                                                                                                                                                          Func2::new({
                                                                                                                                                                         let v3
                                                                                                                                                                             =
                                                                                                                                                                             v3.clone();
                                                                                                                                                                         let v4
                                                                                                                                                                             =
                                                                                                                                                                             v4.clone();
                                                                                                                                                                         move
                                                                                                                                                                             |b0:
                                                                                                                                                                                  string,
                                                                                                                                                                              b1:
                                                                                                                                                                                  string|
                                                                                                                                                                             (Func1::new({
                                                                                                                                                                                             let v3
                                                                                                                                                                                                 =
                                                                                                                                                                                                 v3.clone();
                                                                                                                                                                                             let v4
                                                                                                                                                                                                 =
                                                                                                                                                                                                 v4.clone();
                                                                                                                                                                                             move
                                                                                                                                                                                                 |v_6:
                                                                                                                                                                                                      string|
                                                                                                                                                                                                 Documents::closure66(v4.clone(),
                                                                                                                                                                                                                      v3.clone(),
                                                                                                                                                                                                                      v_6)
                                                                                                                                                                                         }))(b0)(b1)
                                                                                                                                                                     }),
                                                                                                                                                          v1501.clone()))
                                                                                                                    } else {
                                                                                                                        v1501
                                                                                                                    };
                                                                                    let patternInput_20:
                                                                                                                        (string,
                                                                                                                         string) =
                                                                                                                    Documents::method72(string("pdf"),
                                                                                                                                        v488.clone(),
                                                                                                                                        v4.clone());
                                                                                    let v1567:
                                                                                                                        string =
                                                                                                                    patternInput_20.1.clone();
                                                                                    let v1566:
                                                                                                                        string =
                                                                                                                    patternInput_20.0.clone();
                                                                                    let _v1568:
                                                                                                                        MutCell<Option<bool>> =
                                                                                                                    MutCell::new(None::<bool>);
                                                                                    let v1570:
                                                                                                                        string =
                                                                                                                    Documents::method14(v1567.clone());
                                                                                    let v1572:
                                                                                                                        &str =
                                                                                                                    fable_library_rust::String_::LrcStr::as_str(&v1570);
                                                                                    let v1574:
                                                                                                                        std::string::String =
                                                                                                                    String::from(v1572);
                                                                                    let v1576:
                                                                                                                        std::path::PathBuf =
                                                                                                                    std::path::PathBuf::from(v1574);
                                                                                    {
                                                                                        let x_31:
                                                                                                                            bool =
                                                                                                                        if v1576.clone().exists()
                                                                                                                           {
                                                                                                                            v1576.is_file()
                                                                                                                        } else {
                                                                                                                            false
                                                                                                                        };
                                                                                        _v1568.set(Some(x_31))
                                                                                    }
                                                                                    {
                                                                                        let v1629:
                                                                                                                            LrcPtr<Documents::UH3> =
                                                                                                                        if if getValue(_v1568.get().clone())
                                                                                                                                  ==
                                                                                                                                  false
                                                                                                                              {
                                                                                                                               let _v1592:
                                                                                                                                       MutCell<Option<bool>> =
                                                                                                                                   MutCell::new(None::<bool>);
                                                                                                                               let v1594:
                                                                                                                                       string =
                                                                                                                                   Documents::method14(v1566.clone());
                                                                                                                               let v1596:
                                                                                                                                       &str =
                                                                                                                                   fable_library_rust::String_::LrcStr::as_str(&v1594);
                                                                                                                               let v1598:
                                                                                                                                       std::string::String =
                                                                                                                                   String::from(v1596);
                                                                                                                               let v1600:
                                                                                                                                       std::path::PathBuf =
                                                                                                                                   std::path::PathBuf::from(v1598);
                                                                                                                               {
                                                                                                                                   let x_32:
                                                                                                                                           bool =
                                                                                                                                       if v1600.clone().exists()
                                                                                                                                          {
                                                                                                                                           v1600.is_file()
                                                                                                                                       } else {
                                                                                                                                           false
                                                                                                                                       };
                                                                                                                                   _v1592.set(Some(x_32))
                                                                                                                               }
                                                                                                                               if getValue(_v1592.get().clone())
                                                                                                                                  {
                                                                                                                                   Documents::method3(Documents::US0::US0_2,
                                                                                                                                                      Func0::new(move
                                                                                                                                                                     ||
                                                                                                                                                                     Documents::closure70((),
                                                                                                                                                                                          ())),
                                                                                                                                                      Func0::new({
                                                                                                                                                                     let v1566
                                                                                                                                                                         =
                                                                                                                                                                         v1566.clone();
                                                                                                                                                                     let v1567
                                                                                                                                                                         =
                                                                                                                                                                         v1567.clone();
                                                                                                                                                                     move
                                                                                                                                                                         ||
                                                                                                                                                                         Documents::closure71(v1566.clone(),
                                                                                                                                                                                              v1567.clone(),
                                                                                                                                                                                              ())
                                                                                                                                                                 }));
                                                                                                                                   {
                                                                                                                                       let _v1618:
                                                                                                                                               MutCell<Option<()>> =
                                                                                                                                           MutCell::new(None::<()>);
                                                                                                                                       let v1620:
                                                                                                                                               string =
                                                                                                                                           Documents::method73(v1567.clone());
                                                                                                                                       let v1622:
                                                                                                                                               Result<u64,
                                                                                                                                                      std::io::Error> =
                                                                                                                                           std::fs::copy(&*v1566.clone(), &*v1620);
                                                                                                                                       let v1624:
                                                                                                                                               u64 =
                                                                                                                                           v1622.unwrap();
                                                                                                                                       _v1618.set(Some(()));
                                                                                                                                       getValue(_v1618.get().clone());
                                                                                                                                       false
                                                                                                                                   }
                                                                                                                               } else {
                                                                                                                                   true
                                                                                                                               }
                                                                                                                           } else {
                                                                                                                               true
                                                                                                                           }
                                                                                                                           {
                                                                                                                            LrcPtr::new(Documents::UH3::UH3_1(string("pdf"),
                                                                                                                                                              v488.clone(),
                                                                                                                                                              Func2::new({
                                                                                                                                                                             let v3
                                                                                                                                                                                 =
                                                                                                                                                                                 v3.clone();
                                                                                                                                                                             let v4
                                                                                                                                                                                 =
                                                                                                                                                                                 v4.clone();
                                                                                                                                                                             move
                                                                                                                                                                                 |b0:
                                                                                                                                                                                      string,
                                                                                                                                                                                  b1:
                                                                                                                                                                                      string|
                                                                                                                                                                                 (Func1::new({
                                                                                                                                                                                                 let v3
                                                                                                                                                                                                     =
                                                                                                                                                                                                     v3.clone();
                                                                                                                                                                                                 let v4
                                                                                                                                                                                                     =
                                                                                                                                                                                                     v4.clone();
                                                                                                                                                                                                 move
                                                                                                                                                                                                     |v_7:
                                                                                                                                                                                                          string|
                                                                                                                                                                                                     Documents::closure66(v4.clone(),
                                                                                                                                                                                                                          v3.clone(),
                                                                                                                                                                                                                          v_7)
                                                                                                                                                                                             }))(b0)(b1)
                                                                                                                                                                         }),
                                                                                                                                                              v1565.clone()))
                                                                                                                        } else {
                                                                                                                            v1565
                                                                                                                        };
                                                                                        let patternInput_21:
                                                                                                                            (string,
                                                                                                                             string) =
                                                                                                                        Documents::method72(string("html"),
                                                                                                                                            v488.clone(),
                                                                                                                                            v4.clone());
                                                                                        let v1631:
                                                                                                                            string =
                                                                                                                        patternInput_21.1.clone();
                                                                                        let v1630:
                                                                                                                            string =
                                                                                                                        patternInput_21.0.clone();
                                                                                        let _v1632:
                                                                                                                            MutCell<Option<bool>> =
                                                                                                                        MutCell::new(None::<bool>);
                                                                                        let v1634:
                                                                                                                            string =
                                                                                                                        Documents::method14(v1631.clone());
                                                                                        let v1636:
                                                                                                                            &str =
                                                                                                                        fable_library_rust::String_::LrcStr::as_str(&v1634);
                                                                                        let v1638:
                                                                                                                            std::string::String =
                                                                                                                        String::from(v1636);
                                                                                        let v1640:
                                                                                                                            std::path::PathBuf =
                                                                                                                        std::path::PathBuf::from(v1638);
                                                                                        {
                                                                                            let x_34:
                                                                                                                                bool =
                                                                                                                            if v1640.clone().exists()
                                                                                                                               {
                                                                                                                                v1640.is_file()
                                                                                                                            } else {
                                                                                                                                false
                                                                                                                            };
                                                                                            _v1632.set(Some(x_34))
                                                                                        }
                                                                                        {
                                                                                            let v1693:
                                                                                                                                LrcPtr<Documents::UH3> =
                                                                                                                            if if getValue(_v1632.get().clone())
                                                                                                                                      ==
                                                                                                                                      false
                                                                                                                                  {
                                                                                                                                   let _v1656:
                                                                                                                                           MutCell<Option<bool>> =
                                                                                                                                       MutCell::new(None::<bool>);
                                                                                                                                   let v1658:
                                                                                                                                           string =
                                                                                                                                       Documents::method14(v1630.clone());
                                                                                                                                   let v1660:
                                                                                                                                           &str =
                                                                                                                                       fable_library_rust::String_::LrcStr::as_str(&v1658);
                                                                                                                                   let v1662:
                                                                                                                                           std::string::String =
                                                                                                                                       String::from(v1660);
                                                                                                                                   let v1664:
                                                                                                                                           std::path::PathBuf =
                                                                                                                                       std::path::PathBuf::from(v1662);
                                                                                                                                   {
                                                                                                                                       let x_35:
                                                                                                                                               bool =
                                                                                                                                           if v1664.clone().exists()
                                                                                                                                              {
                                                                                                                                               v1664.is_file()
                                                                                                                                           } else {
                                                                                                                                               false
                                                                                                                                           };
                                                                                                                                       _v1656.set(Some(x_35))
                                                                                                                                   }
                                                                                                                                   if getValue(_v1656.get().clone())
                                                                                                                                      {
                                                                                                                                       Documents::method3(Documents::US0::US0_2,
                                                                                                                                                          Func0::new(move
                                                                                                                                                                         ||
                                                                                                                                                                         Documents::closure70((),
                                                                                                                                                                                              ())),
                                                                                                                                                          Func0::new({
                                                                                                                                                                         let v1630
                                                                                                                                                                             =
                                                                                                                                                                             v1630.clone();
                                                                                                                                                                         let v1631
                                                                                                                                                                             =
                                                                                                                                                                             v1631.clone();
                                                                                                                                                                         move
                                                                                                                                                                             ||
                                                                                                                                                                             Documents::closure71(v1630.clone(),
                                                                                                                                                                                                  v1631.clone(),
                                                                                                                                                                                                  ())
                                                                                                                                                                     }));
                                                                                                                                       {
                                                                                                                                           let _v1682:
                                                                                                                                                   MutCell<Option<()>> =
                                                                                                                                               MutCell::new(None::<()>);
                                                                                                                                           let v1684:
                                                                                                                                                   string =
                                                                                                                                               Documents::method73(v1631.clone());
                                                                                                                                           let v1686:
                                                                                                                                                   Result<u64,
                                                                                                                                                          std::io::Error> =
                                                                                                                                               std::fs::copy(&*v1630.clone(), &*v1684);
                                                                                                                                           let v1688:
                                                                                                                                                   u64 =
                                                                                                                                               v1686.unwrap();
                                                                                                                                           _v1682.set(Some(()));
                                                                                                                                           getValue(_v1682.get().clone());
                                                                                                                                           false
                                                                                                                                       }
                                                                                                                                   } else {
                                                                                                                                       true
                                                                                                                                   }
                                                                                                                               } else {
                                                                                                                                   true
                                                                                                                               }
                                                                                                                               {
                                                                                                                                LrcPtr::new(Documents::UH3::UH3_1(string("html"),
                                                                                                                                                                  v488.clone(),
                                                                                                                                                                  Func2::new({
                                                                                                                                                                                 let v3
                                                                                                                                                                                     =
                                                                                                                                                                                     v3.clone();
                                                                                                                                                                                 let v4
                                                                                                                                                                                     =
                                                                                                                                                                                     v4.clone();
                                                                                                                                                                                 move
                                                                                                                                                                                     |b0:
                                                                                                                                                                                          string,
                                                                                                                                                                                      b1:
                                                                                                                                                                                          string|
                                                                                                                                                                                     (Func1::new({
                                                                                                                                                                                                     let v3
                                                                                                                                                                                                         =
                                                                                                                                                                                                         v3.clone();
                                                                                                                                                                                                     let v4
                                                                                                                                                                                                         =
                                                                                                                                                                                                         v4.clone();
                                                                                                                                                                                                     move
                                                                                                                                                                                                         |v_8:
                                                                                                                                                                                                              string|
                                                                                                                                                                                                         Documents::closure66(v4.clone(),
                                                                                                                                                                                                                              v3.clone(),
                                                                                                                                                                                                                              v_8)
                                                                                                                                                                                                 }))(b0)(b1)
                                                                                                                                                                             }),
                                                                                                                                                                  v1629.clone()))
                                                                                                                            } else {
                                                                                                                                v1629
                                                                                                                            };
                                                                                            let patternInput_22:
                                                                                                                                (string,
                                                                                                                                 string) =
                                                                                                                            Documents::method72(string("hangul.md"),
                                                                                                                                                v488.clone(),
                                                                                                                                                v4.clone());
                                                                                            let v1695:
                                                                                                                                string =
                                                                                                                            patternInput_22.1.clone();
                                                                                            let v1694:
                                                                                                                                string =
                                                                                                                            patternInput_22.0.clone();
                                                                                            let _v1696:
                                                                                                                                MutCell<Option<bool>> =
                                                                                                                            MutCell::new(None::<bool>);
                                                                                            let v1698:
                                                                                                                                string =
                                                                                                                            Documents::method14(v1695.clone());
                                                                                            let v1700:
                                                                                                                                &str =
                                                                                                                            fable_library_rust::String_::LrcStr::as_str(&v1698);
                                                                                            let v1702:
                                                                                                                                std::string::String =
                                                                                                                            String::from(v1700);
                                                                                            let v1704:
                                                                                                                                std::path::PathBuf =
                                                                                                                            std::path::PathBuf::from(v1702);
                                                                                            {
                                                                                                let x_37:
                                                                                                                                    bool =
                                                                                                                                if v1704.clone().exists()
                                                                                                                                   {
                                                                                                                                    v1704.is_file()
                                                                                                                                } else {
                                                                                                                                    false
                                                                                                                                };
                                                                                                _v1696.set(Some(x_37))
                                                                                            }
                                                                                            LrcPtr::new(Documents::UH2::UH2_1(if if getValue(_v1696.get().clone())
                                                                                                                                                                    ==
                                                                                                                                                                    false
                                                                                                                                                                {
                                                                                                                                                                 let _v1720:
                                                                                                                                                                         MutCell<Option<bool>> =
                                                                                                                                                                     MutCell::new(None::<bool>);
                                                                                                                                                                 let v1722:
                                                                                                                                                                         string =
                                                                                                                                                                     Documents::method14(v1694.clone());
                                                                                                                                                                 let v1724:
                                                                                                                                                                         &str =
                                                                                                                                                                     fable_library_rust::String_::LrcStr::as_str(&v1722);
                                                                                                                                                                 let v1726:
                                                                                                                                                                         std::string::String =
                                                                                                                                                                     String::from(v1724);
                                                                                                                                                                 let v1728:
                                                                                                                                                                         std::path::PathBuf =
                                                                                                                                                                     std::path::PathBuf::from(v1726);
                                                                                                                                                                 {
                                                                                                                                                                     let x_38:
                                                                                                                                                                             bool =
                                                                                                                                                                         if v1728.clone().exists()
                                                                                                                                                                            {
                                                                                                                                                                             v1728.is_file()
                                                                                                                                                                         } else {
                                                                                                                                                                             false
                                                                                                                                                                         };
                                                                                                                                                                     _v1720.set(Some(x_38))
                                                                                                                                                                 }
                                                                                                                                                                 if getValue(_v1720.get().clone())
                                                                                                                                                                    {
                                                                                                                                                                     Documents::method3(Documents::US0::US0_2,
                                                                                                                                                                                        Func0::new(move
                                                                                                                                                                                                       ||
                                                                                                                                                                                                       Documents::closure70((),
                                                                                                                                                                                                                            ())),
                                                                                                                                                                                        Func0::new({
                                                                                                                                                                                                       let v1694
                                                                                                                                                                                                           =
                                                                                                                                                                                                           v1694.clone();
                                                                                                                                                                                                       let v1695
                                                                                                                                                                                                           =
                                                                                                                                                                                                           v1695.clone();
                                                                                                                                                                                                       move
                                                                                                                                                                                                           ||
                                                                                                                                                                                                           Documents::closure71(v1694.clone(),
                                                                                                                                                                                                                                v1695.clone(),
                                                                                                                                                                                                                                ())
                                                                                                                                                                                                   }));
                                                                                                                                                                     {
                                                                                                                                                                         let _v1746:
                                                                                                                                                                                 MutCell<Option<()>> =
                                                                                                                                                                             MutCell::new(None::<()>);
                                                                                                                                                                         let v1748:
                                                                                                                                                                                 string =
                                                                                                                                                                             Documents::method73(v1695.clone());
                                                                                                                                                                         let v1750:
                                                                                                                                                                                 Result<u64,
                                                                                                                                                                                        std::io::Error> =
                                                                                                                                                                             std::fs::copy(&*v1694.clone(), &*v1748);
                                                                                                                                                                         let v1752:
                                                                                                                                                                                 u64 =
                                                                                                                                                                             v1750.unwrap();
                                                                                                                                                                         _v1746.set(Some(()));
                                                                                                                                                                         getValue(_v1746.get().clone());
                                                                                                                                                                         false
                                                                                                                                                                     }
                                                                                                                                                                 } else {
                                                                                                                                                                     true
                                                                                                                                                                 }
                                                                                                                                                             } else {
                                                                                                                                                                 true
                                                                                                                                                             }
                                                                                                                                                             {
                                                                                                                                                              LrcPtr::new(Documents::UH3::UH3_1(string("hangul.md"),
                                                                                                                                                                                                v488.clone(),
                                                                                                                                                                                                Func2::new({
                                                                                                                                                                                                               let v0_1
                                                                                                                                                                                                                   =
                                                                                                                                                                                                                   v0_1.clone();
                                                                                                                                                                                                               let v1_1
                                                                                                                                                                                                                   =
                                                                                                                                                                                                                   v1_1.clone();
                                                                                                                                                                                                               let v3
                                                                                                                                                                                                                   =
                                                                                                                                                                                                                   v3.clone();
                                                                                                                                                                                                               let v4
                                                                                                                                                                                                                   =
                                                                                                                                                                                                                   v4.clone();
                                                                                                                                                                                                               move
                                                                                                                                                                                                                   |b0:
                                                                                                                                                                                                                        string,
                                                                                                                                                                                                                    b1:
                                                                                                                                                                                                                        string|
                                                                                                                                                                                                                   (Func1::new({
                                                                                                                                                                                                                                   let v0_1
                                                                                                                                                                                                                                       =
                                                                                                                                                                                                                                       v0_1.clone();
                                                                                                                                                                                                                                   let v1_1
                                                                                                                                                                                                                                       =
                                                                                                                                                                                                                                       v1_1.clone();
                                                                                                                                                                                                                                   let v3
                                                                                                                                                                                                                                       =
                                                                                                                                                                                                                                       v3.clone();
                                                                                                                                                                                                                                   let v4
                                                                                                                                                                                                                                       =
                                                                                                                                                                                                                                       v4.clone();
                                                                                                                                                                                                                                   move
                                                                                                                                                                                                                                       |v_9:
                                                                                                                                                                                                                                            string|
                                                                                                                                                                                                                                       Documents::closure59(v4.clone(),
                                                                                                                                                                                                                                                            v3.clone(),
                                                                                                                                                                                                                                                            v1_1.clone(),
                                                                                                                                                                                                                                                            v0_1.clone(),
                                                                                                                                                                                                                                                            v_9)
                                                                                                                                                                                                                               }))(b0)(b1)
                                                                                                                                                                                                           }),
                                                                                                                                                                                                LrcPtr::new(Documents::UH3::UH3_0)))
                                                                                                                                                          } else {
                                                                                                                                                              LrcPtr::new(Documents::UH3::UH3_0)
                                                                                                                                                          },
                                                                                                                                                          LrcPtr::new(Documents::UH2::UH2_1(v1693,
                                                                                                                                                                                            LrcPtr::new(Documents::UH2::UH2_0)))))
                                                                                        }
                                                                                    }
                                                                                }
                                                                            }
                                                                        }
                                                                    }
                                                                },
                                                                empty::<LrcPtr<Documents::UH3>>(),
                                                            ));
                                                            let v1769: Vec<LrcPtr<Documents::UH3>> =
                                                                v1767.to_vec();
                                                            let v1772: Vec<
                                                                Option<
                                                                    Result<
                                                                        string,
                                                                        LrcPtr<(string, string)>,
                                                                    >,
                                                                >,
                                                            > = new_empty::<
                                                                Option<
                                                                    Result<
                                                                        string,
                                                                        LrcPtr<(string, string)>,
                                                                    >,
                                                                >,
                                                            >(
                                                            )
                                                            .to_vec();
                                                            let v1774:
                                                                    Array<LrcPtr<Documents::UH3>> =
                                                                fable_library_rust::NativeArray_::array_from(v1769);
                                                            let v1775: i32 = count(v1774.clone());
                                                            let v1776: LrcPtr<Documents::Mut8> =
                                                                LrcPtr::new(Documents::Mut8 {
                                                                    l0: MutCell::new(0_i32),
                                                                    l1: MutCell::new(v1772),
                                                                });
                                                            while Documents::method82(
                                                                v1775,
                                                                v1776.clone(),
                                                            ) {
                                                                let v1778: i32 =
                                                                    v1776.l0.get().clone();
                                                                let v1779: Vec<
                                                                    Option<
                                                                        Result<
                                                                            string,
                                                                            LrcPtr<(
                                                                                string,
                                                                                string,
                                                                            )>,
                                                                        >,
                                                                    >,
                                                                > = v1776.l1.get().clone();
                                                                let v1784 =
                                                                    toArray(Documents::method83(
                                                                        v1774[v1778].clone(),
                                                                        empty::<(
                                                                            string,
                                                                            string,
                                                                            Func1<
                                                                                string,
                                                                                Func1<
                                                                                    string,
                                                                                    Documents::US19,
                                                                                >,
                                                                            >,
                                                                        )>(
                                                                        ),
                                                                    ));
                                                                let v1786 = v1784.to_vec();
                                                                let v1788 =
                                                                    rayon::iter::IntoParallelIterator::into_par_iter(v1786);
                                                                let v1791 =
                                                                    rayon::iter::ParallelIterator::map(v1788, |x| Func1::new(move
                                                                                                                                 |arg10_0040_20:
                                                                                                                                      (string,
                                                                                                                                       string,
                                                                                                                                       Func1<string,
                                                                                                                                             Func1<string,
                                                                                                                                                   Documents::US19>>)|
                                                                                                                                 Documents::closure72((),
                                                                                                                                                      arg10_0040_20))(x));
                                                                let v1794:
                                                                        Vec<Option<Result<string,
                                                                                          LrcPtr<(string,
                                                                                                  string)>>>> =
                                                                    Documents::method84(rayon::iter::ParallelIterator::collect(v1791));
                                                                let v1795: Vec<
                                                                    Option<
                                                                        Result<
                                                                            string,
                                                                            LrcPtr<(
                                                                                string,
                                                                                string,
                                                                            )>,
                                                                        >,
                                                                    >,
                                                                > = Documents::method85(v1779);
                                                                let mut v1795 = v1795;
                                                                v1795.extend(v1794);
                                                                {
                                                                    let v1799: Vec<
                                                                        Option<
                                                                            Result<
                                                                                string,
                                                                                LrcPtr<(
                                                                                    string,
                                                                                    string,
                                                                                )>,
                                                                            >,
                                                                        >,
                                                                    > = v1795;
                                                                    let v1800: i32 = v1778 + 1_i32;
                                                                    v1776.l0.set(v1800);
                                                                    v1776.l1.set(v1799);
                                                                    ()
                                                                }
                                                            }
                                                            Ok::<
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
                                                            >(
                                                                LrcPtr::new((
                                                                    v225.clone(),
                                                                    v1776.l1.get().clone(),
                                                                )),
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
        pub fn closure73(unitVar: (), unitVar_1: ()) -> string {
            string("documents.run")
        }
        pub fn closure74(
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
        pub fn method86(
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
        pub fn method29(
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
                    let v11 = Documents::method37();
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
                            Func0::new(move || Documents::closure73((), ())),
                            Func0::new({
                                let v23 = v23.clone();
                                move || Documents::closure74(v23.clone(), ())
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
                            > = Documents::method86(Ok::<
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
            let v9: string = Documents::method13(
                Documents::method17(
                    Documents::method13(string("polyglot"), string(".paket")),
                    string("C:\\home\\git\\polyglot\\target\\polyglot\\builder\\documents"),
                ),
                string("polyglot"),
            );
            let _v10: MutCell<Option<string>> = MutCell::new(None::<string>);
            let v12: string = Documents::method21(v3);
            let v13: string = Documents::method14(v12.clone());
            let v15: &str = fable_library_rust::String_::LrcStr::as_str(&v13);
            let v17: std::string::String = String::from(v15);
            let v19: std::path::PathBuf = std::path::PathBuf::from(v17);
            {
                let x_5: string = if v19.exists() == false {
                    let _v23: MutCell<Option<string>> = MutCell::new(None::<string>);
                    let v26: Result<std::path::PathBuf, std::io::Error> = std::env::current_dir();
                    let v28: std::path::PathBuf = v26.unwrap();
                    let v30: std::path::Display = v28.display();
                    let _v31: MutCell<Option<std::string::String>> =
                        MutCell::new(None::<std::string::String>);
                    {
                        let x: std::string::String = format!("{}", v30);
                        _v31.set(Some(x))
                    }
                    {
                        let v42: std::string::String = getValue(_v31.get().clone());
                        {
                            let x_1: string = fable_library_rust::String_::fromString(v42);
                            _v23.set(Some(x_1))
                        }
                        {
                            let v51: string = getValue(_v23.get().clone());
                            let v52: string = Documents::method13(v51.clone(), v12.clone());
                            let _v53: MutCell<Option<string>> = MutCell::new(None::<string>);
                            let v55: string = Documents::method22();
                            let v56: string = Documents::method23(v52);
                            let v57: string = Documents::method24();
                            let v59: std::borrow::Cow<str> =
                                regex::Regex::new(&v55).unwrap().replace_all(&v56, &*v57);
                            let v61: std::string::String = String::from(v59);
                            {
                                let x_2: string = fable_library_rust::String_::fromString(v61);
                                _v53.set(Some(x_2))
                            }
                            {
                                let v71: string = getValue(_v53.get().clone());
                                let v76: Array<string> = split(
                                    replace(
                                        sprintf!(
                                            "{}{}",
                                            toLower(ofChar(getCharAt(v71.clone(), 0_i32))),
                                            getSlice(v71, Some(1_i32), None::<i32>)
                                        ),
                                        string("\\"),
                                        string("/"),
                                    ),
                                    string("/"),
                                    -1_i32,
                                    0_i32,
                                );
                                let v78: i32 = count(v76.clone());
                                let v79: LrcPtr<Documents::Mut4> = LrcPtr::new(Documents::Mut4 {
                                    l0: MutCell::new(0_i32),
                                    l1: MutCell::new(0_i32),
                                    l2: MutCell::new(new_empty::<string>()),
                                });
                                while Documents::method25(v78, v79.clone()) {
                                    let v81: i32 = v79.l0.get().clone();
                                    let v84: i32 = v81.wrapping_neg() + v78 - 1_i32;
                                    let matchValue: i32 = v79.l1.get().clone();
                                    let v86: Array<string> = v79.l2.get().clone();
                                    let v85: i32 = matchValue;
                                    let v87: string = v76[v84].clone();
                                    let patternInput_1: (i32, Array<string>) = if string("..")
                                        == v87.clone()
                                    {
                                        (v85 + 1_i32, v86.clone())
                                    } else {
                                        if string(".") == v87.clone() {
                                            (v85, v86.clone())
                                        } else {
                                            if 0_i32 == v85 {
                                                if endsWith(v87.clone(), string(":"), false) {
                                                    let v95: Array<string> =
                                                        new_array(&[sprintf!(
                                                            "{}:",
                                                            getCharAt(v51.clone(), 0_i32)
                                                        )]);
                                                    let v96: i32 = count(v95.clone());
                                                    let v98: i32 = v96 + count(v86.clone());
                                                    let v99: Array<string> =
                                                        new_init(&string(""), v98);
                                                    let v100: LrcPtr<Documents::Mut5> =
                                                        LrcPtr::new(Documents::Mut5 {
                                                            l0: MutCell::new(0_i32),
                                                        });
                                                    while Documents::method26(v98, v100.clone()) {
                                                        let v102: i32 = v100.l0.get().clone();
                                                        let v107: string = if v102 < v96 {
                                                            v95[v102].clone()
                                                        } else {
                                                            let v105: i32 = v102 - v96;
                                                            v86[v105].clone()
                                                        };
                                                        v99.get_mut()[v102 as usize] = v107;
                                                        {
                                                            let v108: i32 = v102 + 1_i32;
                                                            v100.l0.set(v108);
                                                            ()
                                                        }
                                                    }
                                                    (0_i32, v99.clone())
                                                } else {
                                                    let v109: Array<string> = new_array(&[v87]);
                                                    let v110: i32 = count(v109.clone());
                                                    let v112: i32 = v110 + count(v86.clone());
                                                    let v113: Array<string> =
                                                        new_init(&string(""), v112);
                                                    let v114: LrcPtr<Documents::Mut5> =
                                                        LrcPtr::new(Documents::Mut5 {
                                                            l0: MutCell::new(0_i32),
                                                        });
                                                    while Documents::method26(v112, v114.clone()) {
                                                        let v116: i32 = v114.l0.get().clone();
                                                        let v121: string = if v116 < v110 {
                                                            v109[v116].clone()
                                                        } else {
                                                            let v119: i32 = v116 - v110;
                                                            v86[v119].clone()
                                                        };
                                                        v113.get_mut()[v116 as usize] = v121;
                                                        {
                                                            let v122: i32 = v116 + 1_i32;
                                                            v114.l0.set(v122);
                                                            ()
                                                        }
                                                    }
                                                    (0_i32, v113.clone())
                                                }
                                            } else {
                                                (v85 - 1_i32, v86.clone())
                                            }
                                        }
                                    };
                                    let v132: i32 = v81 + 1_i32;
                                    v79.l0.set(v132);
                                    v79.l1.set(patternInput_1.0.clone());
                                    v79.l2.set(patternInput_1.1.clone());
                                    ()
                                }
                                {
                                    let matchValue_2: i32 = v79.l1.get().clone();
                                    let v134: Array<string> = v79.l2.get().clone();
                                    let v135: LrcPtr<dyn IEnumerable_1<string>> =
                                        delay(Func0::new({
                                            let v134 = v134.clone();
                                            move || {
                                                map_1(
                                                    Func1::new({
                                                        let v134 = v134.clone();
                                                        move |i: i32| v134[i].clone()
                                                    }),
                                                    rangeNumeric(
                                                        0_i32,
                                                        1_i32,
                                                        count(v134.clone()) - 1_i32,
                                                    ),
                                                )
                                            }
                                        }));
                                    let _v136: MutCell<Option<char>> = MutCell::new(None::<char>);
                                    {
                                        let x_3: char = std::path::MAIN_SEPARATOR;
                                        _v136.set(Some(x_3))
                                    }
                                    join(
                                        Documents::method27(ofChar(getValue(_v136.get().clone()))),
                                        toArray_1(v135),
                                    )
                                }
                            }
                        }
                    }
                } else {
                    let v153: Result<std::path::PathBuf, std::io::Error> =
                        std::fs::canonicalize(&*v12);
                    let v155: std::path::PathBuf = v153.unwrap();
                    let v157: std::path::Display = v155.display();
                    let _v158: MutCell<Option<std::string::String>> =
                        MutCell::new(None::<std::string::String>);
                    {
                        let x_4: std::string::String = format!("{}", v157);
                        _v158.set(Some(x_4))
                    }
                    {
                        let v169: std::string::String = getValue(_v158.get().clone());
                        fable_library_rust::String_::fromString(v169)
                    }
                };
                _v10.set(Some(x_5))
            }
            {
                let v180: string = getValue(_v10.get().clone());
                let _v181: MutCell<Option<string>> = MutCell::new(None::<string>);
                let v183: string = Documents::method21(v2);
                let v184: string = Documents::method14(v183.clone());
                let v186: &str = fable_library_rust::String_::LrcStr::as_str(&v184);
                let v188: std::string::String = String::from(v186);
                let v190: std::path::PathBuf = std::path::PathBuf::from(v188);
                {
                    let x_11: string = if v190.exists() == false {
                        let _v194: MutCell<Option<string>> = MutCell::new(None::<string>);
                        let v197: Result<std::path::PathBuf, std::io::Error> =
                            std::env::current_dir();
                        let v199: std::path::PathBuf = v197.unwrap();
                        let v201: std::path::Display = v199.display();
                        let _v202: MutCell<Option<std::string::String>> =
                            MutCell::new(None::<std::string::String>);
                        {
                            let x_6: std::string::String = format!("{}", v201);
                            _v202.set(Some(x_6))
                        }
                        {
                            let v213: std::string::String = getValue(_v202.get().clone());
                            {
                                let x_7: string = fable_library_rust::String_::fromString(v213);
                                _v194.set(Some(x_7))
                            }
                            {
                                let v222: string = getValue(_v194.get().clone());
                                let v223: string = Documents::method13(v222.clone(), v183.clone());
                                let _v224: MutCell<Option<string>> = MutCell::new(None::<string>);
                                let v226: string = Documents::method22();
                                let v227: string = Documents::method23(v223);
                                let v228: string = Documents::method24();
                                let v230: std::borrow::Cow<str> =
                                    regex::Regex::new(&v226).unwrap().replace_all(&v227, &*v228);
                                let v232: std::string::String = String::from(v230);
                                {
                                    let x_8: string = fable_library_rust::String_::fromString(v232);
                                    _v224.set(Some(x_8))
                                }
                                {
                                    let v242: string = getValue(_v224.get().clone());
                                    let v247: Array<string> = split(
                                        replace(
                                            sprintf!(
                                                "{}{}",
                                                toLower(ofChar(getCharAt(v242.clone(), 0_i32))),
                                                getSlice(v242, Some(1_i32), None::<i32>)
                                            ),
                                            string("\\"),
                                            string("/"),
                                        ),
                                        string("/"),
                                        -1_i32,
                                        0_i32,
                                    );
                                    let v249: i32 = count(v247.clone());
                                    let v250: LrcPtr<Documents::Mut4> =
                                        LrcPtr::new(Documents::Mut4 {
                                            l0: MutCell::new(0_i32),
                                            l1: MutCell::new(0_i32),
                                            l2: MutCell::new(new_empty::<string>()),
                                        });
                                    while Documents::method25(v249, v250.clone()) {
                                        let v252: i32 = v250.l0.get().clone();
                                        let v255: i32 = v252.wrapping_neg() + v249 - 1_i32;
                                        let matchValue_4: i32 = v250.l1.get().clone();
                                        let v257: Array<string> = v250.l2.get().clone();
                                        let v256: i32 = matchValue_4;
                                        let v258: string = v247[v255].clone();
                                        let patternInput_4: (i32, Array<string>) = if string("..")
                                            == v258.clone()
                                        {
                                            (v256 + 1_i32, v257.clone())
                                        } else {
                                            if string(".") == v258.clone() {
                                                (v256, v257.clone())
                                            } else {
                                                if 0_i32 == v256 {
                                                    if endsWith(v258.clone(), string(":"), false) {
                                                        let v266: Array<string> =
                                                            new_array(&[sprintf!(
                                                                "{}:",
                                                                getCharAt(v222.clone(), 0_i32)
                                                            )]);
                                                        let v267: i32 = count(v266.clone());
                                                        let v269: i32 = v267 + count(v257.clone());
                                                        let v270: Array<string> =
                                                            new_init(&string(""), v269);
                                                        let v271: LrcPtr<Documents::Mut5> =
                                                            LrcPtr::new(Documents::Mut5 {
                                                                l0: MutCell::new(0_i32),
                                                            });
                                                        while Documents::method26(
                                                            v269,
                                                            v271.clone(),
                                                        ) {
                                                            let v273: i32 = v271.l0.get().clone();
                                                            let v278: string = if v273 < v267 {
                                                                v266[v273].clone()
                                                            } else {
                                                                let v276: i32 = v273 - v267;
                                                                v257[v276].clone()
                                                            };
                                                            v270.get_mut()[v273 as usize] = v278;
                                                            {
                                                                let v279: i32 = v273 + 1_i32;
                                                                v271.l0.set(v279);
                                                                ()
                                                            }
                                                        }
                                                        (0_i32, v270.clone())
                                                    } else {
                                                        let v280: Array<string> =
                                                            new_array(&[v258]);
                                                        let v281: i32 = count(v280.clone());
                                                        let v283: i32 = v281 + count(v257.clone());
                                                        let v284: Array<string> =
                                                            new_init(&string(""), v283);
                                                        let v285: LrcPtr<Documents::Mut5> =
                                                            LrcPtr::new(Documents::Mut5 {
                                                                l0: MutCell::new(0_i32),
                                                            });
                                                        while Documents::method26(
                                                            v283,
                                                            v285.clone(),
                                                        ) {
                                                            let v287: i32 = v285.l0.get().clone();
                                                            let v292: string = if v287 < v281 {
                                                                v280[v287].clone()
                                                            } else {
                                                                let v290: i32 = v287 - v281;
                                                                v257[v290].clone()
                                                            };
                                                            v284.get_mut()[v287 as usize] = v292;
                                                            {
                                                                let v293: i32 = v287 + 1_i32;
                                                                v285.l0.set(v293);
                                                                ()
                                                            }
                                                        }
                                                        (0_i32, v284.clone())
                                                    }
                                                } else {
                                                    (v256 - 1_i32, v257.clone())
                                                }
                                            }
                                        };
                                        let v303: i32 = v252 + 1_i32;
                                        v250.l0.set(v303);
                                        v250.l1.set(patternInput_4.0.clone());
                                        v250.l2.set(patternInput_4.1.clone());
                                        ()
                                    }
                                    {
                                        let matchValue_6: i32 = v250.l1.get().clone();
                                        let v305: Array<string> = v250.l2.get().clone();
                                        let v306: LrcPtr<dyn IEnumerable_1<string>> =
                                            delay(Func0::new({
                                                let v305 = v305.clone();
                                                move || {
                                                    map_1(
                                                        Func1::new({
                                                            let v305 = v305.clone();
                                                            move |i_1: i32| v305[i_1].clone()
                                                        }),
                                                        rangeNumeric(
                                                            0_i32,
                                                            1_i32,
                                                            count(v305.clone()) - 1_i32,
                                                        ),
                                                    )
                                                }
                                            }));
                                        let _v307: MutCell<Option<char>> =
                                            MutCell::new(None::<char>);
                                        {
                                            let x_9: char = std::path::MAIN_SEPARATOR;
                                            _v307.set(Some(x_9))
                                        }
                                        join(
                                            Documents::method27(ofChar(getValue(
                                                _v307.get().clone(),
                                            ))),
                                            toArray_1(v306),
                                        )
                                    }
                                }
                            }
                        }
                    } else {
                        let v324: Result<std::path::PathBuf, std::io::Error> =
                            std::fs::canonicalize(&*v183);
                        let v326: std::path::PathBuf = v324.unwrap();
                        let v328: std::path::Display = v326.display();
                        let _v329: MutCell<Option<std::string::String>> =
                            MutCell::new(None::<std::string::String>);
                        {
                            let x_10: std::string::String = format!("{}", v328);
                            _v329.set(Some(x_10))
                        }
                        {
                            let v340: std::string::String = getValue(_v329.get().clone());
                            fable_library_rust::String_::fromString(v340)
                        }
                    };
                    _v181.set(Some(x_11))
                }
                {
                    let v351: string = getValue(_v181.get().clone());
                    let _v352: MutCell<Option<string>> = MutCell::new(None::<string>);
                    let v354: string = Documents::method21(v1_1);
                    let v355: string = Documents::method14(v354.clone());
                    let v357: &str = fable_library_rust::String_::LrcStr::as_str(&v355);
                    let v359: std::string::String = String::from(v357);
                    let v361: std::path::PathBuf = std::path::PathBuf::from(v359);
                    {
                        let x_17: string = if v361.exists() == false {
                            let _v365: MutCell<Option<string>> = MutCell::new(None::<string>);
                            let v368: Result<std::path::PathBuf, std::io::Error> =
                                std::env::current_dir();
                            let v370: std::path::PathBuf = v368.unwrap();
                            let v372: std::path::Display = v370.display();
                            let _v373: MutCell<Option<std::string::String>> =
                                MutCell::new(None::<std::string::String>);
                            {
                                let x_12: std::string::String = format!("{}", v372);
                                _v373.set(Some(x_12))
                            }
                            {
                                let v384: std::string::String = getValue(_v373.get().clone());
                                {
                                    let x_13: string =
                                        fable_library_rust::String_::fromString(v384);
                                    _v365.set(Some(x_13))
                                }
                                {
                                    let v393: string = getValue(_v365.get().clone());
                                    let v394: string =
                                        Documents::method13(v393.clone(), v354.clone());
                                    let _v395: MutCell<Option<string>> =
                                        MutCell::new(None::<string>);
                                    let v397: string = Documents::method22();
                                    let v398: string = Documents::method23(v394);
                                    let v399: string = Documents::method24();
                                    let v401: std::borrow::Cow<str> = regex::Regex::new(&v397)
                                        .unwrap()
                                        .replace_all(&v398, &*v399);
                                    let v403: std::string::String = String::from(v401);
                                    {
                                        let x_14: string =
                                            fable_library_rust::String_::fromString(v403);
                                        _v395.set(Some(x_14))
                                    }
                                    {
                                        let v413: string = getValue(_v395.get().clone());
                                        let v418: Array<string> = split(
                                            replace(
                                                sprintf!(
                                                    "{}{}",
                                                    toLower(ofChar(getCharAt(v413.clone(), 0_i32))),
                                                    getSlice(v413, Some(1_i32), None::<i32>)
                                                ),
                                                string("\\"),
                                                string("/"),
                                            ),
                                            string("/"),
                                            -1_i32,
                                            0_i32,
                                        );
                                        let v420: i32 = count(v418.clone());
                                        let v421: LrcPtr<Documents::Mut4> =
                                            LrcPtr::new(Documents::Mut4 {
                                                l0: MutCell::new(0_i32),
                                                l1: MutCell::new(0_i32),
                                                l2: MutCell::new(new_empty::<string>()),
                                            });
                                        while Documents::method25(v420, v421.clone()) {
                                            let v423: i32 = v421.l0.get().clone();
                                            let v426: i32 = v423.wrapping_neg() + v420 - 1_i32;
                                            let matchValue_8: i32 = v421.l1.get().clone();
                                            let v428: Array<string> = v421.l2.get().clone();
                                            let v427: i32 = matchValue_8;
                                            let v429: string = v418[v426].clone();
                                            let patternInput_7: (i32, Array<string>) =
                                                if string("..") == v429.clone() {
                                                    (v427 + 1_i32, v428.clone())
                                                } else {
                                                    if string(".") == v429.clone() {
                                                        (v427, v428.clone())
                                                    } else {
                                                        if 0_i32 == v427 {
                                                            if endsWith(
                                                                v429.clone(),
                                                                string(":"),
                                                                false,
                                                            ) {
                                                                let v437: Array<string> =
                                                                    new_array(&[sprintf!(
                                                                        "{}:",
                                                                        getCharAt(
                                                                            v393.clone(),
                                                                            0_i32
                                                                        )
                                                                    )]);
                                                                let v438: i32 = count(v437.clone());
                                                                let v440: i32 =
                                                                    v438 + count(v428.clone());
                                                                let v441: Array<string> =
                                                                    new_init(&string(""), v440);
                                                                let v442: LrcPtr<Documents::Mut5> =
                                                                    LrcPtr::new(Documents::Mut5 {
                                                                        l0: MutCell::new(0_i32),
                                                                    });
                                                                while Documents::method26(
                                                                    v440,
                                                                    v442.clone(),
                                                                ) {
                                                                    let v444: i32 =
                                                                        v442.l0.get().clone();
                                                                    let v449: string = if v444
                                                                        < v438
                                                                    {
                                                                        v437[v444].clone()
                                                                    } else {
                                                                        let v447: i32 = v444 - v438;
                                                                        v428[v447].clone()
                                                                    };
                                                                    v441.get_mut()[v444 as usize] =
                                                                        v449;
                                                                    {
                                                                        let v450: i32 =
                                                                            v444 + 1_i32;
                                                                        v442.l0.set(v450);
                                                                        ()
                                                                    }
                                                                }
                                                                (0_i32, v441.clone())
                                                            } else {
                                                                let v451: Array<string> =
                                                                    new_array(&[v429]);
                                                                let v452: i32 = count(v451.clone());
                                                                let v454: i32 =
                                                                    v452 + count(v428.clone());
                                                                let v455: Array<string> =
                                                                    new_init(&string(""), v454);
                                                                let v456: LrcPtr<Documents::Mut5> =
                                                                    LrcPtr::new(Documents::Mut5 {
                                                                        l0: MutCell::new(0_i32),
                                                                    });
                                                                while Documents::method26(
                                                                    v454,
                                                                    v456.clone(),
                                                                ) {
                                                                    let v458: i32 =
                                                                        v456.l0.get().clone();
                                                                    let v463: string = if v458
                                                                        < v452
                                                                    {
                                                                        v451[v458].clone()
                                                                    } else {
                                                                        let v461: i32 = v458 - v452;
                                                                        v428[v461].clone()
                                                                    };
                                                                    v455.get_mut()[v458 as usize] =
                                                                        v463;
                                                                    {
                                                                        let v464: i32 =
                                                                            v458 + 1_i32;
                                                                        v456.l0.set(v464);
                                                                        ()
                                                                    }
                                                                }
                                                                (0_i32, v455.clone())
                                                            }
                                                        } else {
                                                            (v427 - 1_i32, v428.clone())
                                                        }
                                                    }
                                                };
                                            let v474: i32 = v423 + 1_i32;
                                            v421.l0.set(v474);
                                            v421.l1.set(patternInput_7.0.clone());
                                            v421.l2.set(patternInput_7.1.clone());
                                            ()
                                        }
                                        {
                                            let matchValue_10: i32 = v421.l1.get().clone();
                                            let v476: Array<string> = v421.l2.get().clone();
                                            let v477: LrcPtr<dyn IEnumerable_1<string>> =
                                                delay(Func0::new({
                                                    let v476 = v476.clone();
                                                    move || {
                                                        map_1(
                                                            Func1::new({
                                                                let v476 = v476.clone();
                                                                move |i_2: i32| v476[i_2].clone()
                                                            }),
                                                            rangeNumeric(
                                                                0_i32,
                                                                1_i32,
                                                                count(v476.clone()) - 1_i32,
                                                            ),
                                                        )
                                                    }
                                                }));
                                            let _v478: MutCell<Option<char>> =
                                                MutCell::new(None::<char>);
                                            {
                                                let x_15: char = std::path::MAIN_SEPARATOR;
                                                _v478.set(Some(x_15))
                                            }
                                            join(
                                                Documents::method27(ofChar(getValue(
                                                    _v478.get().clone(),
                                                ))),
                                                toArray_1(v477),
                                            )
                                        }
                                    }
                                }
                            }
                        } else {
                            let v495: Result<std::path::PathBuf, std::io::Error> =
                                std::fs::canonicalize(&*v354);
                            let v497: std::path::PathBuf = v495.unwrap();
                            let v499: std::path::Display = v497.display();
                            let _v500: MutCell<Option<std::string::String>> =
                                MutCell::new(None::<std::string::String>);
                            {
                                let x_16: std::string::String = format!("{}", v499);
                                _v500.set(Some(x_16))
                            }
                            {
                                let v511: std::string::String = getValue(_v500.get().clone());
                                fable_library_rust::String_::fromString(v511)
                            }
                        };
                        _v352.set(Some(x_17))
                    }
                    {
                        let v522: string = getValue(_v352.get().clone());
                        Documents::method3(
                            Documents::US0::US0_1,
                            Func0::new(move || Documents::closure12((), ())),
                            Func0::new({
                                let v0_1 = v0_1.clone();
                                let v180 = v180.clone();
                                let v351 = v351.clone();
                                let v522 = v522.clone();
                                move || {
                                    Documents::closure13(
                                        v0_1.clone(),
                                        v180.clone(),
                                        v351.clone(),
                                        v522.clone(),
                                        (),
                                    )
                                }
                            }),
                        );
                        Documents::method29(
                            v0_1.clone(),
                            v9,
                            v180.clone(),
                            v351.clone(),
                            v522.clone(),
                        )
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
                Documents::method3(
                    Documents::US0::US0_2,
                    Func0::new(move || Documents::closure4((), ())),
                    Func0::new({
                        let v0_1 = v0_1.clone();
                        move || Documents::closure5(v0_1.clone(), ())
                    }),
                );
                {
                    let v11: clap::Command = Documents::method0();
                    let v13: clap::ArgMatches = clap::Command::get_matches(v11);
                    let v14: string = Documents::method7();
                    let v16: &str = fable_library_rust::String_::LrcStr::as_str(&v14);
                    let v18: Option<std::string::String> =
                        clap::ArgMatches::get_one(&v13, v16).cloned();
                    let v21: Documents::US3 =
                        defaultValue(Documents::US3::US3_1, map(Documents::method8(), v18));
                    let v25: std::string::String = match &v21 {
                        Documents::US3::US3_0(v21_0_0) => match &v21 {
                            Documents::US3::US3_0(x) => x.clone(),
                            _ => unreachable!(),
                        },
                        _ => panic!("{}", string("Option does not have a value."),),
                    };
                    let v27: string = fable_library_rust::String_::fromString(v25);
                    let v28: string = Documents::method9();
                    let v30: &str = fable_library_rust::String_::LrcStr::as_str(&v28);
                    let v32: Option<std::string::String> =
                        clap::ArgMatches::get_one(&v13, v30).cloned();
                    let v35: Documents::US3 =
                        defaultValue(Documents::US3::US3_1, map(Documents::method8(), v32));
                    let v39: std::string::String = match &v35 {
                        Documents::US3::US3_0(v35_0_0) => match &v35 {
                            Documents::US3::US3_0(x) => x.clone(),
                            _ => unreachable!(),
                        },
                        _ => panic!("{}", string("Option does not have a value."),),
                    };
                    let v41: string = fable_library_rust::String_::fromString(v39);
                    let v42: string = Documents::method10();
                    let v44: &str = fable_library_rust::String_::LrcStr::as_str(&v42);
                    let v46: Option<std::string::String> =
                        clap::ArgMatches::get_one(&v13, v44).cloned();
                    let v49: Documents::US3 =
                        defaultValue(Documents::US3::US3_1, map(Documents::method8(), v46));
                    let v53: std::string::String = match &v49 {
                        Documents::US3::US3_0(v49_0_0) => match &v49 {
                            Documents::US3::US3_0(x) => x.clone(),
                            _ => unreachable!(),
                        },
                        _ => panic!("{}", string("Option does not have a value."),),
                    };
                    let v55: string = fable_library_rust::String_::fromString(v53);
                    let v56: string = Documents::method11();
                    let v58: &str = fable_library_rust::String_::LrcStr::as_str(&v56);
                    let v60: Option<std::string::String> =
                        clap::ArgMatches::get_one(&v13, v58).cloned();
                    let v63: Documents::US3 =
                        defaultValue(Documents::US3::US3_1, map(Documents::method8(), v60));
                    let v67: std::string::String = match &v63 {
                        Documents::US3::US3_0(v63_0_0) => match &v63 {
                            Documents::US3::US3_0(x) => x.clone(),
                            _ => unreachable!(),
                        },
                        _ => panic!("{}", string("Option does not have a value."),),
                    };
                    let v70: std::pin::Pin<
                        Box<
                            dyn std::future::Future<
                                Output = Result<
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
                                >,
                            >,
                        >,
                    > = Documents::method12(
                        fable_library_rust::String_::fromString(v67),
                        v55,
                        v41,
                        v27,
                    );
                    let v72: Result<
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
                    > = futures_lite::future::block_on(v70);
                    let v74: Vec<
                        Result<
                            LrcPtr<(
                                string,
                                Vec<Option<Result<string, LrcPtr<(string, string)>>>>,
                            )>,
                            std::string::String,
                        >,
                    > = v72.unwrap();
                    0_i32
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
