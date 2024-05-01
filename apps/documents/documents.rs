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
                                let v99: std::io::Lines<
                                    std::io::BufReader<std::process::ChildStdout>,
                                > = std::io::BufRead::lines(std::io::BufReader::new(
                                    v63.lock().unwrap().take().unwrap(),
                                ));
                                let v102: std::sync::Mutex<
                                    std::io::Lines<std::io::BufReader<std::process::ChildStdout>>,
                                > = Documents::method60(std::sync::Mutex::new(v99));
                                let v104: std::sync::Arc<
                                    std::sync::Mutex<
                                        std::io::Lines<
                                            std::io::BufReader<std::process::ChildStdout>,
                                        >,
                                    >,
                                > = std::sync::Arc::new(v102);
                                let v105 = Documents::method61(v88);
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
                                > = Documents::method62(std::sync::Mutex::new(v113));
                                let v118: std::sync::Arc<
                                    std::sync::Mutex<
                                        std::io::Lines<
                                            std::io::BufReader<std::process::ChildStderr>,
                                        >,
                                    >,
                                > = std::sync::Arc::new(v116);
                                let v119 = Documents::method63(v86);
                                let v121: bool = true;
                                for line in v118.lock().unwrap().by_ref() {
                                    v119(line)
                                }
                                let v123: bool = true;
                            });
                            let v126: Documents::US14 = defaultValue(
                                Documents::US14::US14_1,
                                map(Documents::method64(), v4),
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
                                        map(Documents::method66(), v132),
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
                                                > = Documents::method67(v138.unwrap());
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
                                let v148 = Documents::method33();
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
                            Documents::method68(v218.0.clone(), v218.1.clone());
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
        pub fn method72(v0_1: i32, v1_1: LrcPtr<Documents::Mut6>) -> bool {
            v1_1.l0.get().clone() < v0_1
        }
        pub fn method73(v0_1: string) -> string {
            v0_1
        }
        pub fn method74(
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
            let v6: string = Documents::method73(v0_1);
            let v8: &[u8] = v6.as_bytes();
            let v9: std::sync::MutexGuard<std::process::ChildStdin> = Documents::method74(v5);
            let v11: bool = true;
            let mut v9 = v9;
            let v13: bool = true;
            std::io::Write::write_all(&mut *v9, v8).unwrap();
            ()
        }
        pub fn method75(v0_1: i32, v1_1: LrcPtr<Documents::Mut7>) -> bool {
            v1_1.l0.get().clone() < v0_1
        }
        pub fn method76(v0_1: string) -> string {
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
        pub fn method77(v0_1: string) -> string {
            v0_1
        }
        pub fn closure57(
            v0_1: string,
            v1_1: string,
            v2: string,
            v3: string,
            v4: string,
        ) -> Documents::US19 {
            let v6: bool = endsWith(v1_1.clone(), string(".hangul.md"), false);
            let v16: bool = endsWith(v4.clone(), string(".md"), false) == false;
            let v19: string = if v16 {
                sprintf!("{}.{}", v1_1.clone(), v4.clone())
            } else {
                sprintf!(
                    "{}.{}",
                    getSlice(
                        v1_1.clone(),
                        Some(0_i32),
                        Some(lastIndexOf(v1_1.clone(), string(".")) - 1_i32)
                    ),
                    v4.clone()
                )
            };
            let v22: string = if v16 {
                sprintf!("{}.{}", v0_1.clone(), v4.clone())
            } else {
                sprintf!(
                    "{}.{}",
                    getSlice(
                        v0_1.clone(),
                        Some(0_i32),
                        Some(lastIndexOf(v0_1, string(".")) - 1_i32)
                    ),
                    v4
                )
            };
            let _v23: MutCell<Option<bool>> = MutCell::new(None::<bool>);
            let v25: string = Documents::method14(v19.clone());
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
                let v49: string = Documents::method14(v22.clone());
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
                            v19.clone()
                        } else {
                            let _v84: MutCell<Option<string>> = MutCell::new(None::<string>);
                            let v86: string = Documents::method22();
                            let v87: string = Documents::method23(v19.clone());
                            let v88: string = Documents::method24();
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
                    let v116: string = Documents::method38(
                        v109.clone(),
                        v113.clone(),
                        v110.clone(),
                        v111.clone(),
                        v112.clone(),
                        v108.clone(),
                    );
                    let patternInput: (string, string) = Documents::method39();
                    let v119: i32 = length(v116.clone());
                    let v120: Array<char> = new_init(&'\u{0000}', v119);
                    let v121: LrcPtr<Documents::Mut5> = LrcPtr::new(Documents::Mut5 {
                        l0: MutCell::new(0_i32),
                    });
                    while Documents::method26(v119, v121.clone()) {
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
                        let patternInput_1: (string, string) = Documents::method41(
                            patternInput.1.clone(),
                            patternInput.0.clone(),
                            foldBack(
                                Func2::new(move |b0: char, b1: LrcPtr<Documents::UH0>| {
                                    (Documents::method40())(b0)(b1)
                                }),
                                v127,
                                LrcPtr::new(Documents::UH0::UH0_0),
                            ),
                            Documents::US8::US8_0,
                        );
                        let v135: string = patternInput_1.0.clone();
                        let v137: Array<string> = Documents::method42(patternInput_1.1.clone());
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
                            Documents::method47(),
                        );
                        {
                            let v146: std::pin::Pin<
                                Box<dyn std::future::Future<Output = LrcPtr<(i32, string)>>>,
                            > = Documents::method48(
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
                                                             Documents::method22();
                                                         let v347: string =
                                                             Documents::method23(v22.clone());
                                                         let v348: string =
                                                             Documents::method24();
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
                                    let v376: string = Documents::method38(
                                        v369.clone(),
                                        v373.clone(),
                                        v370.clone(),
                                        v371.clone(),
                                        v372.clone(),
                                        v368.clone(),
                                    );
                                    let patternInput_3: (string, string) = Documents::method39();
                                    let v379: i32 = length(v376.clone());
                                    let v380: Array<char> = new_init(&'\u{0000}', v379);
                                    let v381: LrcPtr<Documents::Mut5> =
                                        LrcPtr::new(Documents::Mut5 {
                                            l0: MutCell::new(0_i32),
                                        });
                                    while Documents::method26(v379, v381.clone()) {
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
                                        let patternInput_4: (string, string) = Documents::method41(
                                            patternInput_3.1.clone(),
                                            patternInput_3.0.clone(),
                                            foldBack(
                                                Func2::new(
                                                    move |b0: char, b1: LrcPtr<Documents::UH0>| {
                                                        (Documents::method40())(b0)(b1)
                                                    },
                                                ),
                                                v387,
                                                LrcPtr::new(Documents::UH0::UH0_0),
                                            ),
                                            Documents::US8::US8_0,
                                        );
                                        let v395: string = patternInput_4.0.clone();
                                        let v397: Array<string> =
                                            Documents::method42(patternInput_4.1.clone());
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
                                            Documents::method47(),
                                        );
                                        {
                                            let v405: std::pin::Pin<
                                                Box<
                                                    dyn std::future::Future<
                                                        Output = LrcPtr<(i32, string)>,
                                                    >,
                                                >,
                                            > = Documents::method48(
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
                let _v593: MutCell<Option<string>> = MutCell::new(None::<string>);
                let _v595: MutCell<Option<Vec<u8>>> = MutCell::new(None::<Vec<u8>>);
                {
                    let x_8: Vec<u8> = std::fs::read(&*v1_1).unwrap();
                    _v595.set(Some(x_8))
                }
                {
                    let v606: Vec<u8> = getValue(_v595.get().clone());
                    let v608: Result<std::string::String, std::string::FromUtf8Error> =
                        std::string::String::from_utf8(v606);
                    let v610: std::string::String = v608.unwrap();
                    {
                        let x_9: string = fable_library_rust::String_::fromString(v610);
                        _v593.set(Some(x_9))
                    }
                    {
                        let v620: Array<string> =
                            split(getValue(_v593.get().clone()), string("\n"), -1_i32, 0_i32);
                        let v621: i32 = count(v620.clone());
                        let v622: Array<string> = new_init(&string(""), v621);
                        let v623: LrcPtr<Documents::Mut5> = LrcPtr::new(Documents::Mut5 {
                            l0: MutCell::new(0_i32),
                        });
                        while Documents::method26(v621, v623.clone()) {
                            let v625: i32 = v623.l0.get().clone();
                            let v627: string = trim(v620[v625].clone());
                            v622.get_mut()[v625 as usize] = v627;
                            {
                                let v628: i32 = v625 + 1_i32;
                                v623.l0.set(v628);
                                ()
                            }
                        }
                        {
                            let v629: i32 = count(v622.clone());
                            let v630: Array<string> = new_init(&string(""), v629);
                            let v631: LrcPtr<Documents::Mut6> = LrcPtr::new(Documents::Mut6 {
                                l0: MutCell::new(0_i32),
                                l1: MutCell::new(0_i32),
                            });
                            while Documents::method72(v629, v631.clone()) {
                                let v633: i32 = v631.l0.get().clone();
                                let v634: i32 = v631.l1.get().clone();
                                let v635: string = v622[v633].clone();
                                let v639: i32 = if string("") != v635.clone() {
                                    v630.get_mut()[v634 as usize] = v635;
                                    v634 + 1_i32
                                } else {
                                    v634
                                };
                                let v640: i32 = v633 + 1_i32;
                                v631.l0.set(v640);
                                v631.l1.set(v639);
                                ()
                            }
                            {
                                let v641: i32 = v631.l1.get().clone();
                                let v642: Array<string> = new_init(&string(""), v641);
                                let v643: LrcPtr<Documents::Mut5> = LrcPtr::new(Documents::Mut5 {
                                    l0: MutCell::new(0_i32),
                                });
                                while Documents::method26(v641, v643.clone()) {
                                    let v645: i32 = v643.l0.get().clone();
                                    let v646: string = v630[v645].clone();
                                    v642.get_mut()[v645 as usize] = v646;
                                    {
                                        let v647: i32 = v645 + 1_i32;
                                        v643.l0.set(v647);
                                        ()
                                    }
                                }
                                {
                                    let v648: LrcPtr<dyn IEnumerable_1<string>> =
                                        delay(Func0::new({
                                            let v642 = v642.clone();
                                            move || {
                                                map_1(
                                                    Func1::new({
                                                        let v642 = v642.clone();
                                                        move |i: i32| v642[i].clone()
                                                    }),
                                                    rangeNumeric(
                                                        0_i32,
                                                        1_i32,
                                                        count(v642.clone()) - 1_i32,
                                                    ),
                                                )
                                            }
                                        }));
                                    let v653: string = sprintf!(
                                        "{}\n\n",
                                        join(Documents::method71(), toArray_1(v648))
                                    );
                                    let v654: Option<string> = None::<string>;
                                    let v655: Option<CancellationToken> = None::<CancellationToken>;
                                    let v656: Array<(string, string)> =
                                        new_empty::<(string, string)>();
                                    let v657 = None::<Func1<(bool, string, i32), Arc<Async<()>>>>;
                                    let _v659: MutCell<Option<bool>> = MutCell::new(None::<bool>);
                                    {
                                        let x_10: bool = cfg!(windows);
                                        _v659.set(Some(x_10))
                                    }
                                    {
                                        let v676: string =
                                            sprintf!("{} {}",
                                                     Documents::method13(v3,
                                                                         sprintf!("../vault/deps/hangulize/cmd/hangulize/hangulize{}",
                                                                                  if getValue(_v659.get().clone())
                                                                                     {
                                                                                      string(".exe")
                                                                                  } else {
                                                                                      string("")
                                                                                  })),
                                                     v2);
                                        let v678 = Some(Func1::new({
                                            let v653 = v653.clone();
                                            move |v_1: std::sync::Arc<
                                                std::sync::Mutex<std::process::ChildStdin>,
                                            >| {
                                                Documents::closure58(v653.clone(), v_1)
                                            }
                                        }));
                                        let _v679: MutCell<Option<(i32, string)>> =
                                            MutCell::new(None::<(i32, string)>);
                                        let v681: string = Documents::method38(
                                            v655.clone(),
                                            v676.clone(),
                                            v656.clone(),
                                            v657.clone(),
                                            v678.clone(),
                                            v654.clone(),
                                        );
                                        let patternInput_6: (string, string) =
                                            Documents::method39();
                                        let v684: i32 = length(v681.clone());
                                        let v685: Array<char> = new_init(&'\u{0000}', v684);
                                        let v686: LrcPtr<Documents::Mut5> =
                                            LrcPtr::new(Documents::Mut5 {
                                                l0: MutCell::new(0_i32),
                                            });
                                        while Documents::method26(v684, v686.clone()) {
                                            let v688: i32 = v686.l0.get().clone();
                                            let v689: char = getCharAt(v681.clone(), v688);
                                            v685.get_mut()[v688 as usize] = v689;
                                            {
                                                let v690: i32 = v688 + 1_i32;
                                                v686.l0.set(v690);
                                                ()
                                            }
                                        }
                                        {
                                            let v692: List<char> = ofArray(v685.clone());
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
                                                                             v692,
                                                                             LrcPtr::new(Documents::UH0::UH0_0)),
                                                                    Documents::US8::US8_0);
                                            let v700: string = patternInput_7.0.clone();
                                            let v702: Array<string> =
                                                Documents::method42(patternInput_7.1.clone());
                                            let v704: Vec<string> = v702.to_vec();
                                            let v707: Vec<std::string::String> = v704
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
                                                    let v654 = v654.clone();
                                                    let v655 = v655.clone();
                                                    let v656 = v656.clone();
                                                    let v657 = v657.clone();
                                                    let v676 = v676.clone();
                                                    let v678 = v678.clone();
                                                    let v700 = v700.clone();
                                                    let v707 = v707.clone();
                                                    move || {
                                                        Documents::closure29(
                                                            v655.clone(),
                                                            v676.clone(),
                                                            v656.clone(),
                                                            v657.clone(),
                                                            v678.clone(),
                                                            v654.clone(),
                                                            v700.clone(),
                                                            v707.clone(),
                                                            (),
                                                        )
                                                    }
                                                }),
                                                Documents::method47(),
                                            );
                                            {
                                                let v711: std::pin::Pin<
                                                    Box<
                                                        dyn std::future::Future<
                                                            Output = LrcPtr<(i32, string)>,
                                                        >,
                                                    >,
                                                > = Documents::method48(
                                                    v655.clone(),
                                                    v676.clone(),
                                                    v656.clone(),
                                                    v657.clone(),
                                                    v678.clone(),
                                                    v654.clone(),
                                                    v700.clone(),
                                                    v707.clone(),
                                                );
                                                let v713: LrcPtr<(i32, string)> =
                                                    futures_lite::future::block_on(v711);
                                                _v679.set(Some((v713.0.clone(), v713.1.clone())));
                                                {
                                                    let patternInput_8: (i32, string) =
                                                        getValue(_v679.get().clone());
                                                    let v894: i32 = patternInput_8.0.clone();
                                                    let v896: Array<string> = split(
                                                        patternInput_8.1.clone(),
                                                        string("\n"),
                                                        -1_i32,
                                                        0_i32,
                                                    );
                                                    let v897: i32 = count(v896.clone());
                                                    let v899: LrcPtr<Documents::Mut7> =
                                                        LrcPtr::new(Documents::Mut7 {
                                                            l0: MutCell::new(0_i32),
                                                            l1: MutCell::new(string("")),
                                                            l2: MutCell::new(0_i32),
                                                            l3: MutCell::new(0_i32),
                                                        });
                                                    while Documents::method75(v629, v899.clone()) {
                                                        let v901: i32 = v899.l0.get().clone();
                                                        let matchValue: string =
                                                            v899.l1.get().clone();
                                                        let matchValue_1: i32 =
                                                            v899.l2.get().clone();
                                                        let v904: i32 = v899.l3.get().clone();
                                                        let v903: i32 = matchValue_1;
                                                        let v902: string = matchValue;
                                                        let patternInput_10: (string, i32, i32) =
                                                            if v622[v901].clone() == string("") {
                                                                (
                                                                    sprintf!("{}\n", v902.clone()),
                                                                    v903 + 1_i32,
                                                                    v904 + 1_i32,
                                                                )
                                                            } else {
                                                                let v910: i32 = v903 - v904;
                                                                (
                                                                    if v910 >= v897 {
                                                                        v902.clone()
                                                                    } else {
                                                                        let v912: string =
                                                                            v896[v910].clone();
                                                                        if v910 == v897 - 1_i32 {
                                                                            sprintf!(
                                                                                "{}{}",
                                                                                v902.clone(),
                                                                                v912.clone()
                                                                            )
                                                                        } else {
                                                                            sprintf!(
                                                                                "{}{}\n", v902,
                                                                                v912
                                                                            )
                                                                        }
                                                                    },
                                                                    v903 + 1_i32,
                                                                    v904,
                                                                )
                                                            };
                                                        let v923: i32 = v901 + 1_i32;
                                                        v899.l0.set(v923);
                                                        v899.l1.set(patternInput_10.0.clone());
                                                        v899.l2.set(patternInput_10.1.clone());
                                                        v899.l3.set(patternInput_10.2.clone());
                                                        ()
                                                    }
                                                    {
                                                        let matchValue_3: string =
                                                            v899.l1.get().clone();
                                                        let matchValue_4: i32 =
                                                            v899.l2.get().clone();
                                                        let matchValue_5: i32 =
                                                            v899.l3.get().clone();
                                                        let v924: string = matchValue_3;
                                                        let _v927: MutCell<Option<()>> =
                                                            MutCell::new(None::<()>);
                                                        std::fs::write(
                                                            &*v19.clone(),
                                                            &*v924.clone(),
                                                        )
                                                        .unwrap();
                                                        _v927.set(Some(()));
                                                        getValue(_v927.get().clone());
                                                        if v894 != 0_i32 {
                                                            Documents::method3(
                                                                Documents::US0::US0_2,
                                                                Func0::new(move || {
                                                                    Documents::closure59((), ())
                                                                }),
                                                                Func0::new({
                                                                    let v894 = v894.clone();
                                                                    let v924 = v924.clone();
                                                                    move || {
                                                                        Documents::closure60(
                                                                            v924.clone(),
                                                                            v894,
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
                                                                    v19.clone(),
                                                                    v924.clone(),
                                                                )),
                                                            ))
                                                        } else {
                                                            let _v938: MutCell<Option<bool>> =
                                                                MutCell::new(None::<bool>);
                                                            let v940: string =
                                                                Documents::method14(v19.clone());
                                                            let v942: &str =
                                                                fable_library_rust::String_::LrcStr::as_str(&v940);
                                                            let v944: std::string::String =
                                                                String::from(v942);
                                                            let v946: std::path::PathBuf =
                                                                std::path::PathBuf::from(v944);
                                                            {
                                                                let x_13: bool =
                                                                    if v946.clone().exists() {
                                                                        v946.is_file()
                                                                    } else {
                                                                        false
                                                                    };
                                                                _v938.set(Some(x_13))
                                                            }
                                                            if getValue(_v938.get().clone()) {
                                                                let _v961: MutCell<Option<()>> =
                                                                    MutCell::new(None::<()>);
                                                                let v963: string =
                                                                    Documents::method77(v22);
                                                                let v965: Result<
                                                                    u64,
                                                                    std::io::Error,
                                                                > = std::fs::copy(&*v19, &*v963);
                                                                let v967: u64 = v965.unwrap();
                                                                _v961.set(Some(()));
                                                                getValue(_v961.get().clone());
                                                                ()
                                                            } else {
                                                                panic!("{}",
                                                                       sprintf!("documents.run / files_fn / {} should exist", v19.clone()),)
                                                            }
                                                            Documents::US19::US19_0(Ok::<
                                                                string,
                                                                LrcPtr<(string, string)>,
                                                            >(
                                                                v19
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
            let v5: bool = endsWith(v1_1.clone(), string(".hangul.md"), false);
            let v15: bool = endsWith(v3.clone(), string(".md"), false) == false;
            let v18: string = if v15 {
                sprintf!("{}.{}", v1_1.clone(), v3.clone())
            } else {
                sprintf!(
                    "{}.{}",
                    getSlice(
                        v1_1.clone(),
                        Some(0_i32),
                        Some(lastIndexOf(v1_1.clone(), string(".")) - 1_i32)
                    ),
                    v3.clone()
                )
            };
            let v21: string = if v15 {
                sprintf!("{}.{}", v0_1.clone(), v3.clone())
            } else {
                sprintf!(
                    "{}.{}",
                    getSlice(
                        v0_1.clone(),
                        Some(0_i32),
                        Some(lastIndexOf(v0_1, string(".")) - 1_i32)
                    ),
                    v3.clone()
                )
            };
            let _v22: MutCell<Option<bool>> = MutCell::new(None::<bool>);
            let v24: string = Documents::method14(v18.clone());
            let v26: &str = fable_library_rust::String_::LrcStr::as_str(&v24);
            let v28: std::string::String = String::from(v26);
            let v30: std::path::PathBuf = std::path::PathBuf::from(v28);
            {
                let x: bool = if v30.clone().exists() {
                    v30.is_file()
                } else {
                    false
                };
                _v22.set(Some(x))
            }
            if (if if getValue(_v22.get().clone()) {
                let _v46: MutCell<Option<bool>> = MutCell::new(None::<bool>);
                let v48: string = Documents::method14(v21.clone());
                let v50: &str = fable_library_rust::String_::LrcStr::as_str(&v48);
                let v52: std::string::String = String::from(v50);
                let v54: std::path::PathBuf = std::path::PathBuf::from(v52);
                {
                    let x_1: bool = if v54.clone().exists() {
                        v54.is_file()
                    } else {
                        false
                    };
                    _v46.set(Some(x_1))
                }
                getValue(_v46.get().clone())
            } else {
                false
            } {
                let _v70: MutCell<Option<bool>> = MutCell::new(None::<bool>);
                {
                    let x_2: bool = cfg!(windows);
                    _v70.set(Some(x_2))
                }
                {
                    let v107: Option<string> = None::<string>;
                    let v108: Option<CancellationToken> = None::<CancellationToken>;
                    let v109: Array<(string, string)> = new_empty::<(string, string)>();
                    let v110 = None::<Func1<(bool, string, i32), Arc<Async<()>>>>;
                    let v111 = None::<
                        Func1<std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>, ()>,
                    >;
                    let v112: string = sprintf!(
                        "pwsh -c \"(Get-FileHash \\\"{}\\\" -Algorithm SHA256).Hash\"",
                        if getValue(_v70.get().clone()) == false {
                            v18.clone()
                        } else {
                            let _v83: MutCell<Option<string>> = MutCell::new(None::<string>);
                            let v85: string = Documents::method22();
                            let v86: string = Documents::method23(v18.clone());
                            let v87: string = Documents::method24();
                            let v89: &str =
                                &regex::Regex::new(&v85).unwrap().replace_all(&v86, &*v87);
                            let v91: std::string::String = String::from(v89);
                            {
                                let x_3: string = fable_library_rust::String_::fromString(v91);
                                _v83.set(Some(x_3))
                            }
                            {
                                let v101: string = getValue(_v83.get().clone());
                                replace(
                                    sprintf!(
                                        "{}{}",
                                        toLower(ofChar(getCharAt(v101.clone(), 0_i32))),
                                        getSlice(v101, Some(1_i32), None::<i32>)
                                    ),
                                    string("\\"),
                                    string("/"),
                                )
                            }
                        }
                    );
                    let _v113: MutCell<Option<(i32, string)>> = MutCell::new(None::<(i32, string)>);
                    let v115: string = Documents::method38(
                        v108.clone(),
                        v112.clone(),
                        v109.clone(),
                        v110.clone(),
                        v111.clone(),
                        v107.clone(),
                    );
                    let patternInput: (string, string) = Documents::method39();
                    let v118: i32 = length(v115.clone());
                    let v119: Array<char> = new_init(&'\u{0000}', v118);
                    let v120: LrcPtr<Documents::Mut5> = LrcPtr::new(Documents::Mut5 {
                        l0: MutCell::new(0_i32),
                    });
                    while Documents::method26(v118, v120.clone()) {
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
                        let patternInput_1: (string, string) = Documents::method41(
                            patternInput.1.clone(),
                            patternInput.0.clone(),
                            foldBack(
                                Func2::new(move |b0: char, b1: LrcPtr<Documents::UH0>| {
                                    (Documents::method40())(b0)(b1)
                                }),
                                v126,
                                LrcPtr::new(Documents::UH0::UH0_0),
                            ),
                            Documents::US8::US8_0,
                        );
                        let v134: string = patternInput_1.0.clone();
                        let v136: Array<string> = Documents::method42(patternInput_1.1.clone());
                        let v138: Vec<string> = v136.to_vec();
                        fn v140(v: string) -> std::string::String {
                            Documents::closure28((), v)
                        }
                        let v141: Vec<std::string::String> =
                            v138.iter().map(|x| Func1::from(v140)(x.clone())).collect();
                        Documents::method3(
                            Documents::US0::US0_1,
                            Func0::new({
                                let v107 = v107.clone();
                                let v108 = v108.clone();
                                let v109 = v109.clone();
                                let v110 = v110.clone();
                                let v111 = v111.clone();
                                let v112 = v112.clone();
                                let v134 = v134.clone();
                                let v141 = v141.clone();
                                move || {
                                    Documents::closure29(
                                        v108.clone(),
                                        v112.clone(),
                                        v109.clone(),
                                        v110.clone(),
                                        v111.clone(),
                                        v107.clone(),
                                        v134.clone(),
                                        v141.clone(),
                                        (),
                                    )
                                }
                            }),
                            Documents::method47(),
                        );
                        {
                            let v145: std::pin::Pin<
                                Box<dyn std::future::Future<Output = LrcPtr<(i32, string)>>>,
                            > = Documents::method48(
                                v108.clone(),
                                v112.clone(),
                                v109.clone(),
                                v110.clone(),
                                v111.clone(),
                                v107.clone(),
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
                                    let v371 = None::<
                                        Func1<
                                            std::sync::Arc<
                                                std::sync::Mutex<std::process::ChildStdin>,
                                            >,
                                            (),
                                        >,
                                    >;
                                    let v372: string =
                                            sprintf!("pwsh -c \"(Get-FileHash \\\"{}\\\" -Algorithm SHA256).Hash\"",
                                                     if getValue(_v330.get().clone())
                                                            == false {
                                                         v21.clone()
                                                     } else {
                                                         let _v343:
                                                                 MutCell<Option<string>> =
                                                             MutCell::new(None::<string>);
                                                         let v345: string =
                                                             Documents::method22();
                                                         let v346: string =
                                                             Documents::method23(v21.clone());
                                                         let v347: string =
                                                             Documents::method24();
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
                                    let _v373: MutCell<Option<(i32, string)>> =
                                        MutCell::new(None::<(i32, string)>);
                                    let v375: string = Documents::method38(
                                        v368.clone(),
                                        v372.clone(),
                                        v369.clone(),
                                        v370.clone(),
                                        v371.clone(),
                                        v367.clone(),
                                    );
                                    let patternInput_3: (string, string) = Documents::method39();
                                    let v378: i32 = length(v375.clone());
                                    let v379: Array<char> = new_init(&'\u{0000}', v378);
                                    let v380: LrcPtr<Documents::Mut5> =
                                        LrcPtr::new(Documents::Mut5 {
                                            l0: MutCell::new(0_i32),
                                        });
                                    while Documents::method26(v378, v380.clone()) {
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
                                        let patternInput_4: (string, string) = Documents::method41(
                                            patternInput_3.1.clone(),
                                            patternInput_3.0.clone(),
                                            foldBack(
                                                Func2::new(
                                                    move |b0: char, b1: LrcPtr<Documents::UH0>| {
                                                        (Documents::method40())(b0)(b1)
                                                    },
                                                ),
                                                v386,
                                                LrcPtr::new(Documents::UH0::UH0_0),
                                            ),
                                            Documents::US8::US8_0,
                                        );
                                        let v394: string = patternInput_4.0.clone();
                                        let v396: Array<string> =
                                            Documents::method42(patternInput_4.1.clone());
                                        let v398: Vec<string> = v396.to_vec();
                                        let v400: Vec<std::string::String> = v398
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
                                                let v372 = v372.clone();
                                                let v394 = v394.clone();
                                                let v400 = v400.clone();
                                                move || {
                                                    Documents::closure29(
                                                        v368.clone(),
                                                        v372.clone(),
                                                        v369.clone(),
                                                        v370.clone(),
                                                        v371.clone(),
                                                        v367.clone(),
                                                        v394.clone(),
                                                        v400.clone(),
                                                        (),
                                                    )
                                                }
                                            }),
                                            Documents::method47(),
                                        );
                                        {
                                            let v404: std::pin::Pin<
                                                Box<
                                                    dyn std::future::Future<
                                                        Output = LrcPtr<(i32, string)>,
                                                    >,
                                                >,
                                            > = Documents::method48(
                                                v368.clone(),
                                                v372.clone(),
                                                v369.clone(),
                                                v370.clone(),
                                                v371.clone(),
                                                v367.clone(),
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
                let v592: string =
                    sprintf!("crowbook --single \"{}\" --output \"{}\" --to {} --set rendering.num_depth 6 html.css.add \\\"\'\'\' body {{ color: #e8e6e3; background-color: #202324; }} a {{ color: #989693; }} \'\'\'\\\"",
                             v1_1, v18.clone(), v3);
                let v594: Option<CancellationToken> = None::<CancellationToken>;
                let v595: Array<(string, string)> = new_empty::<(string, string)>();
                let v596 = None::<Func1<(bool, string, i32), Arc<Async<()>>>>;
                let v597 =
                    None::<Func1<std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>, ()>>;
                let v598: Option<string> = Some(v2);
                let _v599: MutCell<Option<(i32, string)>> = MutCell::new(None::<(i32, string)>);
                let v601: string = Documents::method38(
                    v594.clone(),
                    v592.clone(),
                    v595.clone(),
                    v596.clone(),
                    v597.clone(),
                    v598.clone(),
                );
                let patternInput_6: (string, string) = Documents::method39();
                let v604: i32 = length(v601.clone());
                let v605: Array<char> = new_init(&'\u{0000}', v604);
                let v606: LrcPtr<Documents::Mut5> = LrcPtr::new(Documents::Mut5 {
                    l0: MutCell::new(0_i32),
                });
                while Documents::method26(v604, v606.clone()) {
                    let v608: i32 = v606.l0.get().clone();
                    let v609: char = getCharAt(v601.clone(), v608);
                    v605.get_mut()[v608 as usize] = v609;
                    {
                        let v610: i32 = v608 + 1_i32;
                        v606.l0.set(v610);
                        ()
                    }
                }
                {
                    let v612: List<char> = ofArray(v605.clone());
                    let patternInput_7: (string, string) = Documents::method41(
                        patternInput_6.1.clone(),
                        patternInput_6.0.clone(),
                        foldBack(
                            Func2::new(move |b0: char, b1: LrcPtr<Documents::UH0>| {
                                (Documents::method40())(b0)(b1)
                            }),
                            v612,
                            LrcPtr::new(Documents::UH0::UH0_0),
                        ),
                        Documents::US8::US8_0,
                    );
                    let v620: string = patternInput_7.0.clone();
                    let v622: Array<string> = Documents::method42(patternInput_7.1.clone());
                    let v624: Vec<string> = v622.to_vec();
                    let v627: Vec<std::string::String> = v624
                        .iter()
                        .map(|x| {
                            Func1::new(move |v_1: string| Documents::closure28((), v_1))(x.clone())
                        })
                        .collect();
                    Documents::method3(
                        Documents::US0::US0_1,
                        Func0::new({
                            let v592 = v592.clone();
                            let v594 = v594.clone();
                            let v595 = v595.clone();
                            let v596 = v596.clone();
                            let v597 = v597.clone();
                            let v598 = v598.clone();
                            let v620 = v620.clone();
                            let v627 = v627.clone();
                            move || {
                                Documents::closure29(
                                    v594.clone(),
                                    v592.clone(),
                                    v595.clone(),
                                    v596.clone(),
                                    v597.clone(),
                                    v598.clone(),
                                    v620.clone(),
                                    v627.clone(),
                                    (),
                                )
                            }
                        }),
                        Documents::method47(),
                    );
                    {
                        let v631: std::pin::Pin<
                            Box<dyn std::future::Future<Output = LrcPtr<(i32, string)>>>,
                        > = Documents::method48(
                            v594.clone(),
                            v592.clone(),
                            v595.clone(),
                            v596.clone(),
                            v597.clone(),
                            v598.clone(),
                            v620.clone(),
                            v627.clone(),
                        );
                        let v633: LrcPtr<(i32, string)> = futures_lite::future::block_on(v631);
                        _v599.set(Some((v633.0.clone(), v633.1.clone())));
                        {
                            let patternInput_8: (i32, string) = getValue(_v599.get().clone());
                            let v815: string = patternInput_8.1.clone();
                            let v814: i32 = patternInput_8.0.clone();
                            let v823: Documents::US20 = if contains(v815.clone(), string("ERROR")) {
                                Documents::method3(
                                    Documents::US0::US0_2,
                                    Func0::new(move || Documents::closure62((), ())),
                                    Func0::new({
                                        let v814 = v814.clone();
                                        let v815 = v815.clone();
                                        move || Documents::closure63(v815.clone(), v814, ())
                                    }),
                                );
                                Documents::US20::US20_1(v814, v815.clone())
                            } else {
                                Documents::US20::US20_0(v814, v815.clone())
                            };
                            match &v823 {
                                Documents::US20::US20_0(v823_0_0, v823_0_1) => {
                                    let v825: string = v823_0_1.clone();
                                    let v824: i32 = v823_0_0.clone();
                                    if v824 != 0_i32 {
                                        Documents::method3(
                                            Documents::US0::US0_2,
                                            Func0::new(move || Documents::closure59((), ())),
                                            Func0::new({
                                                let v824 = v824.clone();
                                                let v825 = v825.clone();
                                                move || Documents::closure60(v825.clone(), v824, ())
                                            }),
                                        );
                                        Documents::US19::US19_0(Err::<
                                            string,
                                            LrcPtr<(string, string)>,
                                        >(
                                            LrcPtr::new((v18.clone(), v825.clone())),
                                        ))
                                    } else {
                                        let _v833: MutCell<Option<bool>> =
                                            MutCell::new(None::<bool>);
                                        let v835: string = Documents::method14(v18.clone());
                                        let v837: &str =
                                            fable_library_rust::String_::LrcStr::as_str(&v835);
                                        let v839: std::string::String = String::from(v837);
                                        let v841: std::path::PathBuf =
                                            std::path::PathBuf::from(v839);
                                        {
                                            let x_9: bool = if v841.clone().exists() {
                                                v841.is_file()
                                            } else {
                                                false
                                            };
                                            _v833.set(Some(x_9))
                                        }
                                        if getValue(_v833.get().clone()) {
                                            let _v856: MutCell<Option<()>> =
                                                MutCell::new(None::<()>);
                                            let v858: string = Documents::method77(v21);
                                            let v860: Result<u64, std::io::Error> =
                                                std::fs::copy(&*v18, &*v858);
                                            let v862: u64 = v860.unwrap();
                                            _v856.set(Some(()));
                                            getValue(_v856.get().clone());
                                            ()
                                        } else {
                                            panic!(
                                                "{}",
                                                sprintf!(
                                                    "documents.run / files_fn / {} should exist",
                                                    v18.clone()
                                                ),
                                            )
                                        }
                                        Documents::US19::US19_0(Ok::<
                                            string,
                                            LrcPtr<(string, string)>,
                                        >(
                                            v18.clone()
                                        ))
                                    }
                                }
                                Documents::US20::US20_1(v823_1_0, v823_1_1) => {
                                    Documents::US19::US19_0(
                                        Err::<string, LrcPtr<(string, string)>>(LrcPtr::new((
                                            v18.clone(),
                                            v823_1_1.clone(),
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
        pub fn method78(
            v0_1: Vec<Option<Result<string, LrcPtr<(string, string)>>>>,
        ) -> Vec<Option<Result<string, LrcPtr<(string, string)>>>> {
            v0_1
        }
        pub fn method79(
            v0_1: Vec<Option<Result<string, LrcPtr<(string, string)>>>>,
        ) -> Vec<Option<Result<string, LrcPtr<(string, string)>>>> {
            v0_1
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
            let v8: string = Documents::method21(v5);
            let v9: string = Documents::method14(v8.clone());
            let v11: &str = fable_library_rust::String_::LrcStr::as_str(&v9);
            let v13: std::string::String = String::from(v11);
            let v15: std::path::PathBuf = std::path::PathBuf::from(v13);
            {
                let x_6: string = if v15.exists() == false {
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
                            let _v49: MutCell<Option<bool>> = MutCell::new(None::<bool>);
                            {
                                let x_2: bool = cfg!(windows);
                                _v49.set(Some(x_2))
                            }
                            {
                                let v87: Array<string> = split(
                                    if getValue(_v49.get().clone()) == false {
                                        v48.clone()
                                    } else {
                                        let _v62: MutCell<Option<string>> =
                                            MutCell::new(None::<string>);
                                        let v64: string = Documents::method22();
                                        let v65: string = Documents::method23(v48);
                                        let v66: string = Documents::method24();
                                        let v68: &str = &regex::Regex::new(&v64)
                                            .unwrap()
                                            .replace_all(&v65, &*v66);
                                        let v70: std::string::String = String::from(v68);
                                        {
                                            let x_3: string =
                                                fable_library_rust::String_::fromString(v70);
                                            _v62.set(Some(x_3))
                                        }
                                        {
                                            let v80: string = getValue(_v62.get().clone());
                                            replace(
                                                sprintf!(
                                                    "{}{}",
                                                    toLower(ofChar(getCharAt(v80.clone(), 0_i32))),
                                                    getSlice(v80, Some(1_i32), None::<i32>)
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
                                let v89: i32 = count(v87.clone());
                                let v90: LrcPtr<Documents::Mut4> = LrcPtr::new(Documents::Mut4 {
                                    l0: MutCell::new(0_i32),
                                    l1: MutCell::new(0_i32),
                                    l2: MutCell::new(new_empty::<string>()),
                                });
                                while Documents::method25(v89, v90.clone()) {
                                    let v92: i32 = v90.l0.get().clone();
                                    let v95: i32 = v92.wrapping_neg() + v89 - 1_i32;
                                    let matchValue: i32 = v90.l1.get().clone();
                                    let v97: Array<string> = v90.l2.get().clone();
                                    let v96: i32 = matchValue;
                                    let v98: string = v87[v95].clone();
                                    let patternInput_1: (i32, Array<string>) = if string("..")
                                        == v98.clone()
                                    {
                                        (v96 + 1_i32, v97.clone())
                                    } else {
                                        if 0_i32 == v96 {
                                            if endsWith(v98.clone(), string(":"), false) {
                                                let v105: Array<string> = new_array(&[sprintf!(
                                                    "{}:",
                                                    getCharAt(v47.clone(), 0_i32)
                                                )]);
                                                let v106: i32 = count(v105.clone());
                                                let v108: i32 = v106 + count(v97.clone());
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
                                                        v97[v115].clone()
                                                    };
                                                    v109.get_mut()[v112 as usize] = v117;
                                                    {
                                                        let v118: i32 = v112 + 1_i32;
                                                        v110.l0.set(v118);
                                                        ()
                                                    }
                                                }
                                                (0_i32, v109.clone())
                                            } else {
                                                let v119: Array<string> = new_array(&[v98]);
                                                let v120: i32 = count(v119.clone());
                                                let v122: i32 = v120 + count(v97.clone());
                                                let v123: Array<string> =
                                                    new_init(&string(""), v122);
                                                let v124: LrcPtr<Documents::Mut5> =
                                                    LrcPtr::new(Documents::Mut5 {
                                                        l0: MutCell::new(0_i32),
                                                    });
                                                while Documents::method26(v122, v124.clone()) {
                                                    let v126: i32 = v124.l0.get().clone();
                                                    let v131: string = if v126 < v120 {
                                                        v119[v126].clone()
                                                    } else {
                                                        let v129: i32 = v126 - v120;
                                                        v97[v129].clone()
                                                    };
                                                    v123.get_mut()[v126 as usize] = v131;
                                                    {
                                                        let v132: i32 = v126 + 1_i32;
                                                        v124.l0.set(v132);
                                                        ()
                                                    }
                                                }
                                                (0_i32, v123.clone())
                                            }
                                        } else {
                                            (v96 - 1_i32, v97.clone())
                                        }
                                    };
                                    let v140: i32 = v92 + 1_i32;
                                    v90.l0.set(v140);
                                    v90.l1.set(patternInput_1.0.clone());
                                    v90.l2.set(patternInput_1.1.clone());
                                    ()
                                }
                                {
                                    let matchValue_2: i32 = v90.l1.get().clone();
                                    let v142: Array<string> = v90.l2.get().clone();
                                    let v143: LrcPtr<dyn IEnumerable_1<string>> =
                                        delay(Func0::new({
                                            let v142 = v142.clone();
                                            move || {
                                                map_1(
                                                    Func1::new({
                                                        let v142 = v142.clone();
                                                        move |i: i32| v142[i].clone()
                                                    }),
                                                    rangeNumeric(
                                                        0_i32,
                                                        1_i32,
                                                        count(v142.clone()) - 1_i32,
                                                    ),
                                                )
                                            }
                                        }));
                                    let _v144: MutCell<Option<char>> = MutCell::new(None::<char>);
                                    {
                                        let x_4: char = std::path::MAIN_SEPARATOR;
                                        _v144.set(Some(x_4))
                                    }
                                    join(
                                        Documents::method27(ofChar(getValue(_v144.get().clone()))),
                                        toArray_1(v143),
                                    )
                                }
                            }
                        }
                    }
                } else {
                    let v161: Result<std::path::PathBuf, std::io::Error> =
                        std::fs::canonicalize(&*v8);
                    let v163: std::path::PathBuf = v161.unwrap();
                    let v165: std::path::Display = v163.display();
                    let _v166: MutCell<Option<std::string::String>> =
                        MutCell::new(None::<std::string::String>);
                    {
                        let x_5: std::string::String = format!("{}", v165);
                        _v166.set(Some(x_5))
                    }
                    {
                        let v177: std::string::String = getValue(_v166.get().clone());
                        fable_library_rust::String_::fromString(v177)
                    }
                };
                _v6.set(Some(x_6))
            }
            {
                let v188: string = getValue(_v6.get().clone());
                let v189: string = Documents::method14(v188.clone());
                let v191: &str = fable_library_rust::String_::LrcStr::as_str(&v189);
                let v193: std::string::String = String::from(v191);
                let v195: std::path::PathBuf = std::path::PathBuf::from(v193);
                let v197: std::path::Display = v195.display();
                let _v198: MutCell<Option<std::string::String>> =
                    MutCell::new(None::<std::string::String>);
                {
                    let x_7: std::string::String = format!("{}", v197);
                    _v198.set(Some(x_7))
                }
                {
                    let v209: std::string::String = getValue(_v198.get().clone());
                    let v217: string = sprintf!(
                        ".{}",
                        replace(
                            replace(
                                fable_library_rust::String_::fromString(v209),
                                v3.clone(),
                                string("")
                            ),
                            string("\\"),
                            string("/")
                        )
                    );
                    let _v218: MutCell<Option<bool>> = MutCell::new(None::<bool>);
                    {
                        let x_8: bool = cfg!(windows);
                        _v218.set(Some(x_8))
                    }
                    {
                        let v251: string = if getValue(_v218.get().clone()) == false {
                            v188.clone()
                        } else {
                            let _v231: MutCell<Option<string>> = MutCell::new(None::<string>);
                            let v233: string = Documents::method22();
                            let v234: string = Documents::method23(v188);
                            let v235: string = Documents::method24();
                            let v237: &str =
                                &regex::Regex::new(&v233).unwrap().replace_all(&v234, &*v235);
                            let v239: std::string::String = String::from(v237);
                            {
                                let x_9: string = fable_library_rust::String_::fromString(v239);
                                _v231.set(Some(x_9))
                            }
                            {
                                let v248: string = getValue(_v231.get().clone());
                                replace(
                                    sprintf!(
                                        "{}{}",
                                        toLower(ofChar(getCharAt(v248.clone(), 0_i32))),
                                        getSlice(v248, Some(1_i32), None::<i32>)
                                    ),
                                    string("\\"),
                                    string("/"),
                                )
                            }
                        };
                        let v252: string = Documents::method13(v2.clone(), v217.clone());
                        let _v253: MutCell<Option<bool>> = MutCell::new(None::<bool>);
                        {
                            let x_10: bool = cfg!(windows);
                            _v253.set(Some(x_10))
                        }
                        {
                            let v286: string = if getValue(_v253.get().clone()) == false {
                                v252.clone()
                            } else {
                                let _v266: MutCell<Option<string>> = MutCell::new(None::<string>);
                                let v268: string = Documents::method22();
                                let v269: string = Documents::method23(v252);
                                let v270: string = Documents::method24();
                                let v272: &str =
                                    &regex::Regex::new(&v268).unwrap().replace_all(&v269, &*v270);
                                let v274: std::string::String = String::from(v272);
                                {
                                    let x_11: string =
                                        fable_library_rust::String_::fromString(v274);
                                    _v266.set(Some(x_11))
                                }
                                {
                                    let v283: string = getValue(_v266.get().clone());
                                    replace(
                                        sprintf!(
                                            "{}{}",
                                            toLower(ofChar(getCharAt(v283.clone(), 0_i32))),
                                            getSlice(v283, Some(1_i32), None::<i32>)
                                        ),
                                        string("\\"),
                                        string("/"),
                                    )
                                }
                            };
                            let v288: Option<CancellationToken> = None::<CancellationToken>;
                            let v289: Array<(string, string)> = new_empty::<(string, string)>();
                            let v290 = None::<Func1<(bool, string, i32), Arc<Async<()>>>>;
                            let v291 = None::<
                                Func1<
                                    std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>,
                                    (),
                                >,
                            >;
                            let v292: string = sprintf!(
                                "git ls-tree --format=\'%(objectname)\' origin/gh-pages \"{}\"",
                                v286.clone()
                            );
                            let v293: Option<string> = Some(v2);
                            let _v294: MutCell<Option<(i32, string)>> =
                                MutCell::new(None::<(i32, string)>);
                            let v296: string = Documents::method38(
                                v288.clone(),
                                v292.clone(),
                                v289.clone(),
                                v290.clone(),
                                v291.clone(),
                                v293.clone(),
                            );
                            let patternInput_3: (string, string) = Documents::method39();
                            let v299: i32 = length(v296.clone());
                            let v300: Array<char> = new_init(&'\u{0000}', v299);
                            let v301: LrcPtr<Documents::Mut5> = LrcPtr::new(Documents::Mut5 {
                                l0: MutCell::new(0_i32),
                            });
                            while Documents::method26(v299, v301.clone()) {
                                let v303: i32 = v301.l0.get().clone();
                                let v304: char = getCharAt(v296.clone(), v303);
                                v300.get_mut()[v303 as usize] = v304;
                                {
                                    let v305: i32 = v303 + 1_i32;
                                    v301.l0.set(v305);
                                    ()
                                }
                            }
                            {
                                let v307: List<char> = ofArray(v300.clone());
                                let patternInput_4: (string, string) = Documents::method41(
                                    patternInput_3.1.clone(),
                                    patternInput_3.0.clone(),
                                    foldBack(
                                        Func2::new(move |b0: char, b1: LrcPtr<Documents::UH0>| {
                                            (Documents::method40())(b0)(b1)
                                        }),
                                        v307,
                                        LrcPtr::new(Documents::UH0::UH0_0),
                                    ),
                                    Documents::US8::US8_0,
                                );
                                let v315: string = patternInput_4.0.clone();
                                let v317: Array<string> =
                                    Documents::method42(patternInput_4.1.clone());
                                let v319: Vec<string> = v317.to_vec();
                                fn v321(v: string) -> std::string::String {
                                    Documents::closure28((), v)
                                }
                                let v322: Vec<std::string::String> =
                                    v319.iter().map(|x| Func1::from(v321)(x.clone())).collect();
                                Documents::method3(
                                    Documents::US0::US0_1,
                                    Func0::new({
                                        let v288 = v288.clone();
                                        let v289 = v289.clone();
                                        let v290 = v290.clone();
                                        let v291 = v291.clone();
                                        let v292 = v292.clone();
                                        let v293 = v293.clone();
                                        let v315 = v315.clone();
                                        let v322 = v322.clone();
                                        move || {
                                            Documents::closure29(
                                                v288.clone(),
                                                v292.clone(),
                                                v289.clone(),
                                                v290.clone(),
                                                v291.clone(),
                                                v293.clone(),
                                                v315.clone(),
                                                v322.clone(),
                                                (),
                                            )
                                        }
                                    }),
                                    Documents::method47(),
                                );
                                {
                                    let v326: std::pin::Pin<
                                        Box<
                                            dyn std::future::Future<Output = LrcPtr<(i32, string)>>,
                                        >,
                                    > = Documents::method48(
                                        v288.clone(),
                                        v292.clone(),
                                        v289.clone(),
                                        v290.clone(),
                                        v291.clone(),
                                        v293.clone(),
                                        v315.clone(),
                                        v322.clone(),
                                    );
                                    let v328: LrcPtr<(i32, string)> =
                                        futures_lite::future::block_on(v326);
                                    _v294.set(Some((v328.0.clone(), v328.1.clone())));
                                    {
                                        let patternInput_5: (i32, string) =
                                            getValue(_v294.get().clone());
                                        let v509: string = patternInput_5.1.clone();
                                        let v510: string =
                                            Documents::method13(v3.clone(), v217.clone());
                                        let _v511: MutCell<Option<bool>> =
                                            MutCell::new(None::<bool>);
                                        {
                                            let x_13: bool = cfg!(windows);
                                            _v511.set(Some(x_13))
                                        }
                                        {
                                            let v544: string = if getValue(_v511.get().clone())
                                                == false
                                            {
                                                v510.clone()
                                            } else {
                                                let _v524: MutCell<Option<string>> =
                                                    MutCell::new(None::<string>);
                                                let v526: string = Documents::method22();
                                                let v527: string = Documents::method23(v510);
                                                let v528: string = Documents::method24();
                                                let v530: &str = &regex::Regex::new(&v526)
                                                    .unwrap()
                                                    .replace_all(&v527, &*v528);
                                                let v532: std::string::String = String::from(v530);
                                                {
                                                    let x_14: string =
                                                        fable_library_rust::String_::fromString(
                                                            v532,
                                                        );
                                                    _v524.set(Some(x_14))
                                                }
                                                {
                                                    let v541: string =
                                                        getValue(_v524.get().clone());
                                                    replace(
                                                        sprintf!(
                                                            "{}{}",
                                                            toLower(ofChar(getCharAt(
                                                                v541.clone(),
                                                                0_i32
                                                            ))),
                                                            getSlice(
                                                                v541,
                                                                Some(1_i32),
                                                                None::<i32>
                                                            )
                                                        ),
                                                        string("\\"),
                                                        string("/"),
                                                    )
                                                }
                                            };
                                            let v546: Option<CancellationToken> =
                                                None::<CancellationToken>;
                                            let v547: Array<(string, string)> =
                                                new_empty::<(string, string)>();
                                            let v548 =
                                                None::<Func1<(bool, string, i32), Arc<Async<()>>>>;
                                            let v549 = None::<
                                                Func1<
                                                    std::sync::Arc<
                                                        std::sync::Mutex<std::process::ChildStdin>,
                                                    >,
                                                    (),
                                                >,
                                            >;
                                            let v550: string =
                                                sprintf!("git hash-object \"{}\"", v544.clone());
                                            let v551: Option<string> = Some(v3.clone());
                                            let _v552: MutCell<Option<(i32, string)>> =
                                                MutCell::new(None::<(i32, string)>);
                                            let v554: string = Documents::method38(
                                                v546.clone(),
                                                v550.clone(),
                                                v547.clone(),
                                                v548.clone(),
                                                v549.clone(),
                                                v551.clone(),
                                            );
                                            let patternInput_6: (string, string) =
                                                Documents::method39();
                                            let v557: i32 = length(v554.clone());
                                            let v558: Array<char> = new_init(&'\u{0000}', v557);
                                            let v559: LrcPtr<Documents::Mut5> =
                                                LrcPtr::new(Documents::Mut5 {
                                                    l0: MutCell::new(0_i32),
                                                });
                                            while Documents::method26(v557, v559.clone()) {
                                                let v561: i32 = v559.l0.get().clone();
                                                let v562: char = getCharAt(v554.clone(), v561);
                                                v558.get_mut()[v561 as usize] = v562;
                                                {
                                                    let v563: i32 = v561 + 1_i32;
                                                    v559.l0.set(v563);
                                                    ()
                                                }
                                            }
                                            {
                                                let v565: List<char> = ofArray(v558.clone());
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
                                                                                 v565,
                                                                                 LrcPtr::new(Documents::UH0::UH0_0)),
                                                                        Documents::US8::US8_0);
                                                let v573: string = patternInput_7.0.clone();
                                                let v575: Array<string> =
                                                    Documents::method42(patternInput_7.1.clone());
                                                let v577: Vec<string> = v575.to_vec();
                                                let v579: Vec<std::string::String> = v577
                                                    .iter()
                                                    .map(|x| Func1::from(v321)(x.clone()))
                                                    .collect();
                                                Documents::method3(
                                                    Documents::US0::US0_1,
                                                    Func0::new({
                                                        let v546 = v546.clone();
                                                        let v547 = v547.clone();
                                                        let v548 = v548.clone();
                                                        let v549 = v549.clone();
                                                        let v550 = v550.clone();
                                                        let v551 = v551.clone();
                                                        let v573 = v573.clone();
                                                        let v579 = v579.clone();
                                                        move || {
                                                            Documents::closure29(
                                                                v546.clone(),
                                                                v550.clone(),
                                                                v547.clone(),
                                                                v548.clone(),
                                                                v549.clone(),
                                                                v551.clone(),
                                                                v573.clone(),
                                                                v579.clone(),
                                                                (),
                                                            )
                                                        }
                                                    }),
                                                    Documents::method47(),
                                                );
                                                {
                                                    let v583: std::pin::Pin<
                                                        Box<
                                                            dyn std::future::Future<
                                                                Output = LrcPtr<(i32, string)>,
                                                            >,
                                                        >,
                                                    > = Documents::method48(
                                                        v546.clone(),
                                                        v550.clone(),
                                                        v547.clone(),
                                                        v548.clone(),
                                                        v549.clone(),
                                                        v551.clone(),
                                                        v573.clone(),
                                                        v579.clone(),
                                                    );
                                                    let v585: LrcPtr<(i32, string)> =
                                                        futures_lite::future::block_on(v583);
                                                    _v552.set(Some((
                                                        v585.0.clone(),
                                                        v585.1.clone(),
                                                    )));
                                                    {
                                                        let patternInput_8: (i32, string) =
                                                            getValue(_v552.get().clone());
                                                        let v766: string = patternInput_8.1.clone();
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
                                                                v251.clone(),
                                                                if contains(
                                                                    v509.clone(),
                                                                    v766.clone(),
                                                                ) == false
                                                                {
                                                                    let _v769: MutCell<
                                                                        Option<bool>,
                                                                    > = MutCell::new(None::<bool>);
                                                                    {
                                                                        let x_16: bool =
                                                                            cfg!(windows);
                                                                        _v769.set(Some(x_16))
                                                                    }
                                                                    {
                                                                        let v803: Option<string> =
                                                                            None::<string>;
                                                                        let v804: Option<
                                                                            CancellationToken,
                                                                        > = None::<CancellationToken>;
                                                                        let v805: Array<(
                                                                            string,
                                                                            string,
                                                                        )> = new_empty::<(
                                                                            string,
                                                                            string,
                                                                        )>(
                                                                        );
                                                                        let v806 = None::<
                                                                            Func1<
                                                                                (bool, string, i32),
                                                                                Arc<Async<()>>,
                                                                            >,
                                                                        >;
                                                                        let v807 =
                                                                                                           None::<Func1<std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>,
                                                                                                                        ()>>;
                                                                        let v808:
                                                                                                               string =
                                                                                                           sprintf!("pwsh -c \"(Get-FileHash \\\"{}\\\" -Algorithm SHA256).Hash\"",
                                                                                                                    if getValue(_v769.get().clone())
                                                                                                                           ==
                                                                                                                           false
                                                                                                                       {
                                                                                                                        v544.clone()
                                                                                                                    } else {
                                                                                                                        let _v782:
                                                                                                                                MutCell<Option<string>> =
                                                                                                                            MutCell::new(None::<string>);
                                                                                                                        let v784:
                                                                                                                                string =
                                                                                                                            Documents::method22();
                                                                                                                        let v785:
                                                                                                                                string =
                                                                                                                            Documents::method23(v544.clone());
                                                                                                                        let v786:
                                                                                                                                string =
                                                                                                                            Documents::method24();
                                                                                                                        let v788:
                                                                                                                                &str =
                                                                                                                            &regex::Regex::new(&v784).unwrap().replace_all(&v785, &*v786);
                                                                                                                        let v790:
                                                                                                                                std::string::String =
                                                                                                                            String::from(v788);
                                                                                                                        {
                                                                                                                            let x_17:
                                                                                                                                    string =
                                                                                                                                fable_library_rust::String_::fromString(v790);
                                                                                                                            _v782.set(Some(x_17))
                                                                                                                        }
                                                                                                                        {
                                                                                                                            let v799:
                                                                                                                                    string =
                                                                                                                                getValue(_v782.get().clone());
                                                                                                                            replace(sprintf!("{}{}",
                                                                                                                                             toLower(ofChar(getCharAt(v799.clone(),
                                                                                                                                                                      0_i32))),
                                                                                                                                             getSlice(v799,
                                                                                                                                                      Some(1_i32),
                                                                                                                                                      None::<i32>)),
                                                                                                                                    string("\\"),
                                                                                                                                    string("/"))
                                                                                                                        }
                                                                                                                    });
                                                                        let _v809: MutCell<
                                                                            Option<(i32, string)>,
                                                                        > = MutCell::new(
                                                                            None::<(i32, string)>,
                                                                        );
                                                                        let v811: string =
                                                                            Documents::method38(
                                                                                v804.clone(),
                                                                                v808.clone(),
                                                                                v805.clone(),
                                                                                v806.clone(),
                                                                                v807.clone(),
                                                                                v803.clone(),
                                                                            );
                                                                        let patternInput_9: (
                                                                            string,
                                                                            string,
                                                                        ) = Documents::method39();
                                                                        let v814: i32 =
                                                                            length(v811.clone());
                                                                        let v815: Array<char> =
                                                                            new_init(
                                                                                &'\u{0000}',
                                                                                v814,
                                                                            );
                                                                        let v816: LrcPtr<
                                                                            Documents::Mut5,
                                                                        > = LrcPtr::new(
                                                                            Documents::Mut5 {
                                                                                l0: MutCell::new(
                                                                                    0_i32,
                                                                                ),
                                                                            },
                                                                        );
                                                                        while Documents::method26(
                                                                            v814,
                                                                            v816.clone(),
                                                                        ) {
                                                                            let v818: i32 = v816
                                                                                .l0
                                                                                .get()
                                                                                .clone();
                                                                            let v819: char =
                                                                                getCharAt(
                                                                                    v811.clone(),
                                                                                    v818,
                                                                                );
                                                                            v815.get_mut()
                                                                                [v818 as usize] =
                                                                                v819;
                                                                            {
                                                                                let v820: i32 =
                                                                                    v818 + 1_i32;
                                                                                v816.l0.set(v820);
                                                                                ()
                                                                            }
                                                                        }
                                                                        {
                                                                            let v822: List<char> =
                                                                                ofArray(
                                                                                    v815.clone(),
                                                                                );
                                                                            let patternInput_10:
                                                                                                                   (string,
                                                                                                                    string) =
                                                                                                               Documents::method41(patternInput_9.1.clone(),
                                                                                                                                   patternInput_9.0.clone(),
                                                                                                                                   foldBack(Func2::new(move
                                                                                                                                                           |b0:
                                                                                                                                                                char,
                                                                                                                                                            b1:
                                                                                                                                                                LrcPtr<Documents::UH0>|
                                                                                                                                                           (Documents::method40())(b0)(b1)),
                                                                                                                                            v822,
                                                                                                                                            LrcPtr::new(Documents::UH0::UH0_0)),
                                                                                                                                   Documents::US8::US8_0);
                                                                            let v830: string =
                                                                                patternInput_10
                                                                                    .0
                                                                                    .clone();
                                                                            let v832: Array<
                                                                                string,
                                                                            > = Documents::method42(
                                                                                patternInput_10
                                                                                    .1
                                                                                    .clone(),
                                                                            );
                                                                            let v834: Vec<string> =
                                                                                v832.to_vec();
                                                                            let v836: Vec<
                                                                                std::string::String,
                                                                            > = v834
                                                                                .iter()
                                                                                .map(|x| {
                                                                                    Func1::from(
                                                                                        v321,
                                                                                    )(
                                                                                        x.clone()
                                                                                    )
                                                                                })
                                                                                .collect();
                                                                            Documents::method3(Documents::US0::US0_1,
                                                                                                                              Func0::new({
                                                                                                                                             let v803
                                                                                                                                                 =
                                                                                                                                                 v803.clone();
                                                                                                                                             let v804
                                                                                                                                                 =
                                                                                                                                                 v804.clone();
                                                                                                                                             let v805
                                                                                                                                                 =
                                                                                                                                                 v805.clone();
                                                                                                                                             let v806
                                                                                                                                                 =
                                                                                                                                                 v806.clone();
                                                                                                                                             let v807
                                                                                                                                                 =
                                                                                                                                                 v807.clone();
                                                                                                                                             let v808
                                                                                                                                                 =
                                                                                                                                                 v808.clone();
                                                                                                                                             let v830
                                                                                                                                                 =
                                                                                                                                                 v830.clone();
                                                                                                                                             let v836
                                                                                                                                                 =
                                                                                                                                                 v836.clone();
                                                                                                                                             move
                                                                                                                                                 ||
                                                                                                                                                 Documents::closure29(v804.clone(),
                                                                                                                                                                      v808.clone(),
                                                                                                                                                                      v805.clone(),
                                                                                                                                                                      v806.clone(),
                                                                                                                                                                      v807.clone(),
                                                                                                                                                                      v803.clone(),
                                                                                                                                                                      v830.clone(),
                                                                                                                                                                      v836.clone(),
                                                                                                                                                                      ())
                                                                                                                                         }),
                                                                                                                              Documents::method47());
                                                                            {
                                                                                let v840:
                                                                                                                       std::pin::Pin<Box<dyn std::future::Future<Output = LrcPtr<(i32,
                                                                                                                                                                                  string)>>>> =
                                                                                                                   Documents::method48(v804.clone(),
                                                                                                                                       v808.clone(),
                                                                                                                                       v805.clone(),
                                                                                                                                       v806.clone(),
                                                                                                                                       v807.clone(),
                                                                                                                                       v803.clone(),
                                                                                                                                       v830.clone(),
                                                                                                                                       v836.clone());
                                                                                let v842:
                                                                                                                       LrcPtr<(i32,
                                                                                                                               string)> =
                                                                                                                   futures_lite::future::block_on(v840);
                                                                                _v809.set(Some((
                                                                                    v842.0.clone(),
                                                                                    v842.1.clone(),
                                                                                )));
                                                                                {
                                                                                    let v1023:
                                                                                                                           string =
                                                                                                                       (getValue(_v809.get().clone())).1.clone();
                                                                                    let v1024:
                                                                                                                           string =
                                                                                                                       Documents::method13(v4,
                                                                                                                                           v217.clone());
                                                                                    let _v1025:
                                                                                                                           MutCell<Option<bool>> =
                                                                                                                       MutCell::new(None::<bool>);
                                                                                    {
                                                                                        let x_19:
                                                                                                                               bool =
                                                                                                                           cfg!(windows);
                                                                                        _v1025.set(Some(x_19))
                                                                                    }
                                                                                    {
                                                                                        let v1058:
                                                                                                                               string =
                                                                                                                           if getValue(_v1025.get().clone())
                                                                                                                                  ==
                                                                                                                                  false
                                                                                                                              {
                                                                                                                               v1024.clone()
                                                                                                                           } else {
                                                                                                                               let _v1038:
                                                                                                                                       MutCell<Option<string>> =
                                                                                                                                   MutCell::new(None::<string>);
                                                                                                                               let v1040:
                                                                                                                                       string =
                                                                                                                                   Documents::method22();
                                                                                                                               let v1041:
                                                                                                                                       string =
                                                                                                                                   Documents::method23(v1024);
                                                                                                                               let v1042:
                                                                                                                                       string =
                                                                                                                                   Documents::method24();
                                                                                                                               let v1044:
                                                                                                                                       &str =
                                                                                                                                   &regex::Regex::new(&v1040).unwrap().replace_all(&v1041, &*v1042);
                                                                                                                               let v1046:
                                                                                                                                       std::string::String =
                                                                                                                                   String::from(v1044);
                                                                                                                               {
                                                                                                                                   let x_20:
                                                                                                                                           string =
                                                                                                                                       fable_library_rust::String_::fromString(v1046);
                                                                                                                                   _v1038.set(Some(x_20))
                                                                                                                               }
                                                                                                                               {
                                                                                                                                   let v1055:
                                                                                                                                           string =
                                                                                                                                       getValue(_v1038.get().clone());
                                                                                                                                   replace(sprintf!("{}{}",
                                                                                                                                                    toLower(ofChar(getCharAt(v1055.clone(),
                                                                                                                                                                             0_i32))),
                                                                                                                                                    getSlice(v1055,
                                                                                                                                                             Some(1_i32),
                                                                                                                                                             None::<i32>)),
                                                                                                                                           string("\\"),
                                                                                                                                           string("/"))
                                                                                                                               }
                                                                                                                           };
                                                                                        let _v1059:
                                                                                                                               MutCell<Option<bool>> =
                                                                                                                           MutCell::new(None::<bool>);
                                                                                        let v1061:
                                                                                                                               string =
                                                                                                                           Documents::method14(v1058.clone());
                                                                                        let v1063:
                                                                                                                               &str =
                                                                                                                           fable_library_rust::String_::LrcStr::as_str(&v1061);
                                                                                        let v1065:
                                                                                                                               std::string::String =
                                                                                                                           String::from(v1063);
                                                                                        let v1067:
                                                                                                                               std::path::PathBuf =
                                                                                                                           std::path::PathBuf::from(v1065);
                                                                                        {
                                                                                            let x_21:
                                                                                                                                   bool =
                                                                                                                               if v1067.clone().exists()
                                                                                                                                  {
                                                                                                                                   v1067.is_file()
                                                                                                                               } else {
                                                                                                                                   false
                                                                                                                               };
                                                                                            _v1059.set(Some(x_21))
                                                                                        }
                                                                                        {
                                                                                            let v1338:
                                                                                                                                   string =
                                                                                                                               if getValue(_v1059.get().clone())
                                                                                                                                  {
                                                                                                                                   let _v1083:
                                                                                                                                           MutCell<Option<bool>> =
                                                                                                                                       MutCell::new(None::<bool>);
                                                                                                                                   {
                                                                                                                                       let x_22:
                                                                                                                                               bool =
                                                                                                                                           cfg!(windows);
                                                                                                                                       _v1083.set(Some(x_22))
                                                                                                                                   }
                                                                                                                                   {
                                                                                                                                       let v1117:
                                                                                                                                               Option<string> =
                                                                                                                                           None::<string>;
                                                                                                                                       let v1118:
                                                                                                                                               Option<CancellationToken> =
                                                                                                                                           None::<CancellationToken>;
                                                                                                                                       let v1119:
                                                                                                                                               Array<(string,
                                                                                                                                                      string)> =
                                                                                                                                           new_empty::<(string,
                                                                                                                                                        string)>();
                                                                                                                                       let v1120 =
                                                                                                                                           None::<Func1<(bool,
                                                                                                                                                         string,
                                                                                                                                                         i32),
                                                                                                                                                        Arc<Async<()>>>>;
                                                                                                                                       let v1121 =
                                                                                                                                           None::<Func1<std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>,
                                                                                                                                                        ()>>;
                                                                                                                                       let v1122:
                                                                                                                                               string =
                                                                                                                                           sprintf!("pwsh -c \"(Get-FileHash \\\"{}\\\" -Algorithm SHA256).Hash\"",
                                                                                                                                                    if getValue(_v1083.get().clone())
                                                                                                                                                           ==
                                                                                                                                                           false
                                                                                                                                                       {
                                                                                                                                                        v1058.clone()
                                                                                                                                                    } else {
                                                                                                                                                        let _v1096:
                                                                                                                                                                MutCell<Option<string>> =
                                                                                                                                                            MutCell::new(None::<string>);
                                                                                                                                                        let v1098:
                                                                                                                                                                string =
                                                                                                                                                            Documents::method22();
                                                                                                                                                        let v1099:
                                                                                                                                                                string =
                                                                                                                                                            Documents::method23(v1058.clone());
                                                                                                                                                        let v1100:
                                                                                                                                                                string =
                                                                                                                                                            Documents::method24();
                                                                                                                                                        let v1102:
                                                                                                                                                                &str =
                                                                                                                                                            &regex::Regex::new(&v1098).unwrap().replace_all(&v1099, &*v1100);
                                                                                                                                                        let v1104:
                                                                                                                                                                std::string::String =
                                                                                                                                                            String::from(v1102);
                                                                                                                                                        {
                                                                                                                                                            let x_23:
                                                                                                                                                                    string =
                                                                                                                                                                fable_library_rust::String_::fromString(v1104);
                                                                                                                                                            _v1096.set(Some(x_23))
                                                                                                                                                        }
                                                                                                                                                        {
                                                                                                                                                            let v1113:
                                                                                                                                                                    string =
                                                                                                                                                                getValue(_v1096.get().clone());
                                                                                                                                                            replace(sprintf!("{}{}",
                                                                                                                                                                             toLower(ofChar(getCharAt(v1113.clone(),
                                                                                                                                                                                                      0_i32))),
                                                                                                                                                                             getSlice(v1113,
                                                                                                                                                                                      Some(1_i32),
                                                                                                                                                                                      None::<i32>)),
                                                                                                                                                                    string("\\"),
                                                                                                                                                                    string("/"))
                                                                                                                                                        }
                                                                                                                                                    });
                                                                                                                                       let _v1123:
                                                                                                                                               MutCell<Option<(i32,
                                                                                                                                                               string)>> =
                                                                                                                                           MutCell::new(None::<(i32,
                                                                                                                                                                string)>);
                                                                                                                                       let v1125:
                                                                                                                                               string =
                                                                                                                                           Documents::method38(v1118.clone(),
                                                                                                                                                               v1122.clone(),
                                                                                                                                                               v1119.clone(),
                                                                                                                                                               v1120.clone(),
                                                                                                                                                               v1121.clone(),
                                                                                                                                                               v1117.clone());
                                                                                                                                       let patternInput_12:
                                                                                                                                               (string,
                                                                                                                                                string) =
                                                                                                                                           Documents::method39();
                                                                                                                                       let v1128:
                                                                                                                                               i32 =
                                                                                                                                           length(v1125.clone());
                                                                                                                                       let v1129:
                                                                                                                                               Array<char> =
                                                                                                                                           new_init(&'\u{0000}',
                                                                                                                                                    v1128);
                                                                                                                                       let v1130:
                                                                                                                                               LrcPtr<Documents::Mut5> =
                                                                                                                                           LrcPtr::new(Documents::Mut5{l0:
                                                                                                                                                                           MutCell::new(0_i32),});
                                                                                                                                       while Documents::method26(v1128,
                                                                                                                                                                 v1130.clone())
                                                                                                                                             {
                                                                                                                                           let v1132:
                                                                                                                                                   i32 =
                                                                                                                                               v1130.l0.get().clone();
                                                                                                                                           let v1133:
                                                                                                                                                   char =
                                                                                                                                               getCharAt(v1125.clone(),
                                                                                                                                                         v1132);
                                                                                                                                           v1129.get_mut()[v1132
                                                                                                                                                               as
                                                                                                                                                               usize]
                                                                                                                                               =
                                                                                                                                               v1133;
                                                                                                                                           {
                                                                                                                                               let v1134:
                                                                                                                                                       i32 =
                                                                                                                                                   v1132
                                                                                                                                                       +
                                                                                                                                                       1_i32;
                                                                                                                                               v1130.l0.set(v1134);
                                                                                                                                               ()
                                                                                                                                           }
                                                                                                                                       }
                                                                                                                                       {
                                                                                                                                           let v1136:
                                                                                                                                                   List<char> =
                                                                                                                                               ofArray(v1129.clone());
                                                                                                                                           let patternInput_13:
                                                                                                                                                   (string,
                                                                                                                                                    string) =
                                                                                                                                               Documents::method41(patternInput_12.1.clone(),
                                                                                                                                                                   patternInput_12.0.clone(),
                                                                                                                                                                   foldBack(Func2::new(move
                                                                                                                                                                                           |b0:
                                                                                                                                                                                                char,
                                                                                                                                                                                            b1:
                                                                                                                                                                                                LrcPtr<Documents::UH0>|
                                                                                                                                                                                           (Documents::method40())(b0)(b1)),
                                                                                                                                                                            v1136,
                                                                                                                                                                            LrcPtr::new(Documents::UH0::UH0_0)),
                                                                                                                                                                   Documents::US8::US8_0);
                                                                                                                                           let v1144:
                                                                                                                                                   string =
                                                                                                                                               patternInput_13.0.clone();
                                                                                                                                           let v1146:
                                                                                                                                                   Array<string> =
                                                                                                                                               Documents::method42(patternInput_13.1.clone());
                                                                                                                                           let v1148:
                                                                                                                                                   Vec<string> =
                                                                                                                                               v1146.to_vec();
                                                                                                                                           let v1150:
                                                                                                                                                   Vec<std::string::String> =
                                                                                                                                               v1148.iter().map(|x| Func1::from(v321)(x.clone())).collect();
                                                                                                                                           Documents::method3(Documents::US0::US0_1,
                                                                                                                                                              Func0::new({
                                                                                                                                                                             let v1117
                                                                                                                                                                                 =
                                                                                                                                                                                 v1117.clone();
                                                                                                                                                                             let v1118
                                                                                                                                                                                 =
                                                                                                                                                                                 v1118.clone();
                                                                                                                                                                             let v1119
                                                                                                                                                                                 =
                                                                                                                                                                                 v1119.clone();
                                                                                                                                                                             let v1120
                                                                                                                                                                                 =
                                                                                                                                                                                 v1120.clone();
                                                                                                                                                                             let v1121
                                                                                                                                                                                 =
                                                                                                                                                                                 v1121.clone();
                                                                                                                                                                             let v1122
                                                                                                                                                                                 =
                                                                                                                                                                                 v1122.clone();
                                                                                                                                                                             let v1144
                                                                                                                                                                                 =
                                                                                                                                                                                 v1144.clone();
                                                                                                                                                                             let v1150
                                                                                                                                                                                 =
                                                                                                                                                                                 v1150.clone();
                                                                                                                                                                             move
                                                                                                                                                                                 ||
                                                                                                                                                                                 Documents::closure29(v1118.clone(),
                                                                                                                                                                                                      v1122.clone(),
                                                                                                                                                                                                      v1119.clone(),
                                                                                                                                                                                                      v1120.clone(),
                                                                                                                                                                                                      v1121.clone(),
                                                                                                                                                                                                      v1117.clone(),
                                                                                                                                                                                                      v1144.clone(),
                                                                                                                                                                                                      v1150.clone(),
                                                                                                                                                                                                      ())
                                                                                                                                                                         }),
                                                                                                                                                              Documents::method47());
                                                                                                                                           {
                                                                                                                                               let v1154:
                                                                                                                                                       std::pin::Pin<Box<dyn std::future::Future<Output = LrcPtr<(i32,
                                                                                                                                                                                                                  string)>>>> =
                                                                                                                                                   Documents::method48(v1118.clone(),
                                                                                                                                                                       v1122.clone(),
                                                                                                                                                                       v1119.clone(),
                                                                                                                                                                       v1120.clone(),
                                                                                                                                                                       v1121.clone(),
                                                                                                                                                                       v1117.clone(),
                                                                                                                                                                       v1144.clone(),
                                                                                                                                                                       v1150.clone());
                                                                                                                                               let v1156:
                                                                                                                                                       LrcPtr<(i32,
                                                                                                                                                               string)> =
                                                                                                                                                   futures_lite::future::block_on(v1154);
                                                                                                                                               _v1123.set(Some((v1156.0.clone(),
                                                                                                                                                                v1156.1.clone())));
                                                                                                                                               (getValue(_v1123.get().clone())).1.clone()
                                                                                                                                           }
                                                                                                                                       }
                                                                                                                                   }
                                                                                                                               } else {
                                                                                                                                   string("")
                                                                                                                               };
                                                                                            if v1023.clone()
                                                                                                                                  !=
                                                                                                                                  v1338.clone()
                                                                                                                              {
                                                                                                                               let v1345 =
                                                                                                                                   Func1::new({
                                                                                                                                                  let v1058
                                                                                                                                                      =
                                                                                                                                                      v1058.clone();
                                                                                                                                                  let v3
                                                                                                                                                      =
                                                                                                                                                      v3.clone();
                                                                                                                                                  let v544
                                                                                                                                                      =
                                                                                                                                                      v544.clone();
                                                                                                                                                  move
                                                                                                                                                      |v_2:
                                                                                                                                                           string|
                                                                                                                                                      Documents::closure61(v1058.clone(),
                                                                                                                                                                           v544.clone(),
                                                                                                                                                                           v3.clone(),
                                                                                                                                                                           v_2)
                                                                                                                                              });
                                                                                                                               let v1352 =
                                                                                                                                   toArray(ofArray(new_array(&[(string("html"),
                                                                                                                                                                v1345.clone()),
                                                                                                                                                               (string("pdf"),
                                                                                                                                                                v1345.clone()),
                                                                                                                                                               (string("epub"),
                                                                                                                                                                v1345),
                                                                                                                                                               (string("hangul.md"),
                                                                                                                                                                Func1::new({
                                                                                                                                                                               let v0_1
                                                                                                                                                                                   =
                                                                                                                                                                                   v0_1.clone();
                                                                                                                                                                               let v1058
                                                                                                                                                                                   =
                                                                                                                                                                                   v1058.clone();
                                                                                                                                                                               let v1_1
                                                                                                                                                                                   =
                                                                                                                                                                                   v1_1.clone();
                                                                                                                                                                               let v544
                                                                                                                                                                                   =
                                                                                                                                                                                   v544.clone();
                                                                                                                                                                               move
                                                                                                                                                                                   |v_1:
                                                                                                                                                                                        string|
                                                                                                                                                                                   Documents::closure57(v1058.clone(),
                                                                                                                                                                                                        v544.clone(),
                                                                                                                                                                                                        v0_1.clone(),
                                                                                                                                                                                                        v1_1.clone(),
                                                                                                                                                                                                        v_1)
                                                                                                                                                                           }))])));
                                                                                                                               let v1354 =
                                                                                                                                   v1352.to_vec();
                                                                                                                               let v1356 =
                                                                                                                                   rayon::iter::IntoParallelIterator::into_par_iter(v1354);
                                                                                                                               fn v1358(arg10_0040_4:
                                                                                                                                            (string,
                                                                                                                                             Func1<string,
                                                                                                                                                   Documents::US19>))
                                                                                                                                ->
                                                                                                                                    Option<Result<string,
                                                                                                                                                  LrcPtr<(string,
                                                                                                                                                          string)>>> {
                                                                                                                                   Documents::closure64((),
                                                                                                                                                        arg10_0040_4)
                                                                                                                               }
                                                                                                                               let v1359 =
                                                                                                                                   rayon::iter::ParallelIterator::map(v1356, |x| Func1::from(v1358)(x));
                                                                                                                               let v1361:
                                                                                                                                       Vec<Option<Result<string,
                                                                                                                                                         LrcPtr<(string,
                                                                                                                                                                 string)>>>> =
                                                                                                                                   rayon::iter::ParallelIterator::collect(v1359);
                                                                                                                               let v1366:
                                                                                                                                       string =
                                                                                                                                   sprintf!("{}.hangul.md",
                                                                                                                                            getSlice(v544.clone(),
                                                                                                                                                     Some(0_i32),
                                                                                                                                                     Some(lastIndexOf(v544.clone(),
                                                                                                                                                                      string("."))
                                                                                                                                                              -
                                                                                                                                                              1_i32)));
                                                                                                                               let v1368 =
                                                                                                                                   Func1::new({
                                                                                                                                                  let v1058
                                                                                                                                                      =
                                                                                                                                                      v1058.clone();
                                                                                                                                                  let v1366
                                                                                                                                                      =
                                                                                                                                                      v1366.clone();
                                                                                                                                                  let v3
                                                                                                                                                      =
                                                                                                                                                      v3.clone();
                                                                                                                                                  move
                                                                                                                                                      |v_3:
                                                                                                                                                           string|
                                                                                                                                                      Documents::closure61(v1058.clone(),
                                                                                                                                                                           v1366.clone(),
                                                                                                                                                                           v3.clone(),
                                                                                                                                                                           v_3)
                                                                                                                                              });
                                                                                                                               let v1373 =
                                                                                                                                   toArray(ofArray(new_array(&[(string("html"),
                                                                                                                                                                v1368.clone()),
                                                                                                                                                               (string("pdf"),
                                                                                                                                                                v1368.clone()),
                                                                                                                                                               (string("epub"),
                                                                                                                                                                v1368)])));
                                                                                                                               let v1375 =
                                                                                                                                   v1373.to_vec();
                                                                                                                               let v1377 =
                                                                                                                                   rayon::iter::IntoParallelIterator::into_par_iter(v1375);
                                                                                                                               let v1379 =
                                                                                                                                   rayon::iter::ParallelIterator::map(v1377, |x| Func1::from(v1358)(x));
                                                                                                                               let v1382:
                                                                                                                                       Vec<Option<Result<string,
                                                                                                                                                         LrcPtr<(string,
                                                                                                                                                                 string)>>>> =
                                                                                                                                   Documents::method78(rayon::iter::ParallelIterator::collect(v1379));
                                                                                                                               let v1383:
                                                                                                                                       Vec<Option<Result<string,
                                                                                                                                                         LrcPtr<(string,
                                                                                                                                                                 string)>>>> =
                                                                                                                                   Documents::method79(v1361);
                                                                                                                               let mut v1383 = v1383;
                                                                                                                               v1383.extend(v1382);
                                                                                                                               {
                                                                                                                                   let v1387:
                                                                                                                                           Vec<Option<Result<string,
                                                                                                                                                             LrcPtr<(string,
                                                                                                                                                                     string)>>>> =
                                                                                                                                       v1383;
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
                                                                                                                                                                     let v1023
                                                                                                                                                                         =
                                                                                                                                                                         v1023.clone();
                                                                                                                                                                     let v1338
                                                                                                                                                                         =
                                                                                                                                                                         v1338.clone();
                                                                                                                                                                     let v1387
                                                                                                                                                                         =
                                                                                                                                                                         v1387.clone();
                                                                                                                                                                     let v217
                                                                                                                                                                         =
                                                                                                                                                                         v217.clone();
                                                                                                                                                                     let v251
                                                                                                                                                                         =
                                                                                                                                                                         v251.clone();
                                                                                                                                                                     let v286
                                                                                                                                                                         =
                                                                                                                                                                         v286.clone();
                                                                                                                                                                     let v509
                                                                                                                                                                         =
                                                                                                                                                                         v509.clone();
                                                                                                                                                                     let v766
                                                                                                                                                                         =
                                                                                                                                                                         v766.clone();
                                                                                                                                                                     move
                                                                                                                                                                         ||
                                                                                                                                                                         Documents::closure66(v217.clone(),
                                                                                                                                                                                              v251.clone(),
                                                                                                                                                                                              v286.clone(),
                                                                                                                                                                                              v509.clone(),
                                                                                                                                                                                              patternInput_5.0.clone(),
                                                                                                                                                                                              v766.clone(),
                                                                                                                                                                                              patternInput_8.0.clone(),
                                                                                                                                                                                              v1023.clone(),
                                                                                                                                                                                              v1338.clone(),
                                                                                                                                                                                              v1387.clone(),
                                                                                                                                                                                              ())
                                                                                                                                                                 }));
                                                                                                                                   {
                                                                                                                                       let _v1391:
                                                                                                                                               MutCell<Option<()>> =
                                                                                                                                           MutCell::new(None::<()>);
                                                                                                                                       let v1393:
                                                                                                                                               string =
                                                                                                                                           Documents::method77(v1058.clone());
                                                                                                                                       let v1395:
                                                                                                                                               Result<u64,
                                                                                                                                                      std::io::Error> =
                                                                                                                                           std::fs::copy(&*v544, &*v1393);
                                                                                                                                       let v1397:
                                                                                                                                               u64 =
                                                                                                                                           v1395.unwrap();
                                                                                                                                       _v1391.set(Some(()));
                                                                                                                                       getValue(_v1391.get().clone());
                                                                                                                                       v1387.clone()
                                                                                                                                   }
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
                                                                    .to_vec()
                                                                },
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
        pub fn method80(
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
                            > = Documents::method80(Ok::<
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
                let x_6: string = if v19.exists() == false {
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
                            let _v53: MutCell<Option<bool>> = MutCell::new(None::<bool>);
                            {
                                let x_2: bool = cfg!(windows);
                                _v53.set(Some(x_2))
                            }
                            {
                                let v91: Array<string> = split(
                                    if getValue(_v53.get().clone()) == false {
                                        v52.clone()
                                    } else {
                                        let _v66: MutCell<Option<string>> =
                                            MutCell::new(None::<string>);
                                        let v68: string = Documents::method22();
                                        let v69: string = Documents::method23(v52);
                                        let v70: string = Documents::method24();
                                        let v72: &str = &regex::Regex::new(&v68)
                                            .unwrap()
                                            .replace_all(&v69, &*v70);
                                        let v74: std::string::String = String::from(v72);
                                        {
                                            let x_3: string =
                                                fable_library_rust::String_::fromString(v74);
                                            _v66.set(Some(x_3))
                                        }
                                        {
                                            let v84: string = getValue(_v66.get().clone());
                                            replace(
                                                sprintf!(
                                                    "{}{}",
                                                    toLower(ofChar(getCharAt(v84.clone(), 0_i32))),
                                                    getSlice(v84, Some(1_i32), None::<i32>)
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
                                let v93: i32 = count(v91.clone());
                                let v94: LrcPtr<Documents::Mut4> = LrcPtr::new(Documents::Mut4 {
                                    l0: MutCell::new(0_i32),
                                    l1: MutCell::new(0_i32),
                                    l2: MutCell::new(new_empty::<string>()),
                                });
                                while Documents::method25(v93, v94.clone()) {
                                    let v96: i32 = v94.l0.get().clone();
                                    let v99: i32 = v96.wrapping_neg() + v93 - 1_i32;
                                    let matchValue: i32 = v94.l1.get().clone();
                                    let v101: Array<string> = v94.l2.get().clone();
                                    let v100: i32 = matchValue;
                                    let v102: string = v91[v99].clone();
                                    let patternInput_1: (i32, Array<string>) = if string("..")
                                        == v102.clone()
                                    {
                                        (v100 + 1_i32, v101.clone())
                                    } else {
                                        if 0_i32 == v100 {
                                            if endsWith(v102.clone(), string(":"), false) {
                                                let v109: Array<string> = new_array(&[sprintf!(
                                                    "{}:",
                                                    getCharAt(v51.clone(), 0_i32)
                                                )]);
                                                let v110: i32 = count(v109.clone());
                                                let v112: i32 = v110 + count(v101.clone());
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
                                                        v101[v119].clone()
                                                    };
                                                    v113.get_mut()[v116 as usize] = v121;
                                                    {
                                                        let v122: i32 = v116 + 1_i32;
                                                        v114.l0.set(v122);
                                                        ()
                                                    }
                                                }
                                                (0_i32, v113.clone())
                                            } else {
                                                let v123: Array<string> = new_array(&[v102]);
                                                let v124: i32 = count(v123.clone());
                                                let v126: i32 = v124 + count(v101.clone());
                                                let v127: Array<string> =
                                                    new_init(&string(""), v126);
                                                let v128: LrcPtr<Documents::Mut5> =
                                                    LrcPtr::new(Documents::Mut5 {
                                                        l0: MutCell::new(0_i32),
                                                    });
                                                while Documents::method26(v126, v128.clone()) {
                                                    let v130: i32 = v128.l0.get().clone();
                                                    let v135: string = if v130 < v124 {
                                                        v123[v130].clone()
                                                    } else {
                                                        let v133: i32 = v130 - v124;
                                                        v101[v133].clone()
                                                    };
                                                    v127.get_mut()[v130 as usize] = v135;
                                                    {
                                                        let v136: i32 = v130 + 1_i32;
                                                        v128.l0.set(v136);
                                                        ()
                                                    }
                                                }
                                                (0_i32, v127.clone())
                                            }
                                        } else {
                                            (v100 - 1_i32, v101.clone())
                                        }
                                    };
                                    let v144: i32 = v96 + 1_i32;
                                    v94.l0.set(v144);
                                    v94.l1.set(patternInput_1.0.clone());
                                    v94.l2.set(patternInput_1.1.clone());
                                    ()
                                }
                                {
                                    let matchValue_2: i32 = v94.l1.get().clone();
                                    let v146: Array<string> = v94.l2.get().clone();
                                    let v147: LrcPtr<dyn IEnumerable_1<string>> =
                                        delay(Func0::new({
                                            let v146 = v146.clone();
                                            move || {
                                                map_1(
                                                    Func1::new({
                                                        let v146 = v146.clone();
                                                        move |i: i32| v146[i].clone()
                                                    }),
                                                    rangeNumeric(
                                                        0_i32,
                                                        1_i32,
                                                        count(v146.clone()) - 1_i32,
                                                    ),
                                                )
                                            }
                                        }));
                                    let _v148: MutCell<Option<char>> = MutCell::new(None::<char>);
                                    {
                                        let x_4: char = std::path::MAIN_SEPARATOR;
                                        _v148.set(Some(x_4))
                                    }
                                    join(
                                        Documents::method27(ofChar(getValue(_v148.get().clone()))),
                                        toArray_1(v147),
                                    )
                                }
                            }
                        }
                    }
                } else {
                    let v165: Result<std::path::PathBuf, std::io::Error> =
                        std::fs::canonicalize(&*v12);
                    let v167: std::path::PathBuf = v165.unwrap();
                    let v169: std::path::Display = v167.display();
                    let _v170: MutCell<Option<std::string::String>> =
                        MutCell::new(None::<std::string::String>);
                    {
                        let x_5: std::string::String = format!("{}", v169);
                        _v170.set(Some(x_5))
                    }
                    {
                        let v181: std::string::String = getValue(_v170.get().clone());
                        fable_library_rust::String_::fromString(v181)
                    }
                };
                _v10.set(Some(x_6))
            }
            {
                let v192: string = getValue(_v10.get().clone());
                let _v193: MutCell<Option<string>> = MutCell::new(None::<string>);
                let v195: string = Documents::method21(v2);
                let v196: string = Documents::method14(v195.clone());
                let v198: &str = fable_library_rust::String_::LrcStr::as_str(&v196);
                let v200: std::string::String = String::from(v198);
                let v202: std::path::PathBuf = std::path::PathBuf::from(v200);
                {
                    let x_13: string = if v202.exists() == false {
                        let _v206: MutCell<Option<string>> = MutCell::new(None::<string>);
                        let v209: Result<std::path::PathBuf, std::io::Error> =
                            std::env::current_dir();
                        let v211: std::path::PathBuf = v209.unwrap();
                        let v213: std::path::Display = v211.display();
                        let _v214: MutCell<Option<std::string::String>> =
                            MutCell::new(None::<std::string::String>);
                        {
                            let x_7: std::string::String = format!("{}", v213);
                            _v214.set(Some(x_7))
                        }
                        {
                            let v225: std::string::String = getValue(_v214.get().clone());
                            {
                                let x_8: string = fable_library_rust::String_::fromString(v225);
                                _v206.set(Some(x_8))
                            }
                            {
                                let v234: string = getValue(_v206.get().clone());
                                let v235: string = Documents::method13(v234.clone(), v195.clone());
                                let _v236: MutCell<Option<bool>> = MutCell::new(None::<bool>);
                                {
                                    let x_9: bool = cfg!(windows);
                                    _v236.set(Some(x_9))
                                }
                                {
                                    let v274: Array<string> = split(
                                        if getValue(_v236.get().clone()) == false {
                                            v235.clone()
                                        } else {
                                            let _v249: MutCell<Option<string>> =
                                                MutCell::new(None::<string>);
                                            let v251: string = Documents::method22();
                                            let v252: string = Documents::method23(v235);
                                            let v253: string = Documents::method24();
                                            let v255: &str = &regex::Regex::new(&v251)
                                                .unwrap()
                                                .replace_all(&v252, &*v253);
                                            let v257: std::string::String = String::from(v255);
                                            {
                                                let x_10: string =
                                                    fable_library_rust::String_::fromString(v257);
                                                _v249.set(Some(x_10))
                                            }
                                            {
                                                let v267: string = getValue(_v249.get().clone());
                                                replace(
                                                    sprintf!(
                                                        "{}{}",
                                                        toLower(ofChar(getCharAt(
                                                            v267.clone(),
                                                            0_i32
                                                        ))),
                                                        getSlice(v267, Some(1_i32), None::<i32>)
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
                                    let v276: i32 = count(v274.clone());
                                    let v277: LrcPtr<Documents::Mut4> =
                                        LrcPtr::new(Documents::Mut4 {
                                            l0: MutCell::new(0_i32),
                                            l1: MutCell::new(0_i32),
                                            l2: MutCell::new(new_empty::<string>()),
                                        });
                                    while Documents::method25(v276, v277.clone()) {
                                        let v279: i32 = v277.l0.get().clone();
                                        let v282: i32 = v279.wrapping_neg() + v276 - 1_i32;
                                        let matchValue_4: i32 = v277.l1.get().clone();
                                        let v284: Array<string> = v277.l2.get().clone();
                                        let v283: i32 = matchValue_4;
                                        let v285: string = v274[v282].clone();
                                        let patternInput_4: (i32, Array<string>) = if string("..")
                                            == v285.clone()
                                        {
                                            (v283 + 1_i32, v284.clone())
                                        } else {
                                            if 0_i32 == v283 {
                                                if endsWith(v285.clone(), string(":"), false) {
                                                    let v292: Array<string> =
                                                        new_array(&[sprintf!(
                                                            "{}:",
                                                            getCharAt(v234.clone(), 0_i32)
                                                        )]);
                                                    let v293: i32 = count(v292.clone());
                                                    let v295: i32 = v293 + count(v284.clone());
                                                    let v296: Array<string> =
                                                        new_init(&string(""), v295);
                                                    let v297: LrcPtr<Documents::Mut5> =
                                                        LrcPtr::new(Documents::Mut5 {
                                                            l0: MutCell::new(0_i32),
                                                        });
                                                    while Documents::method26(v295, v297.clone()) {
                                                        let v299: i32 = v297.l0.get().clone();
                                                        let v304: string = if v299 < v293 {
                                                            v292[v299].clone()
                                                        } else {
                                                            let v302: i32 = v299 - v293;
                                                            v284[v302].clone()
                                                        };
                                                        v296.get_mut()[v299 as usize] = v304;
                                                        {
                                                            let v305: i32 = v299 + 1_i32;
                                                            v297.l0.set(v305);
                                                            ()
                                                        }
                                                    }
                                                    (0_i32, v296.clone())
                                                } else {
                                                    let v306: Array<string> = new_array(&[v285]);
                                                    let v307: i32 = count(v306.clone());
                                                    let v309: i32 = v307 + count(v284.clone());
                                                    let v310: Array<string> =
                                                        new_init(&string(""), v309);
                                                    let v311: LrcPtr<Documents::Mut5> =
                                                        LrcPtr::new(Documents::Mut5 {
                                                            l0: MutCell::new(0_i32),
                                                        });
                                                    while Documents::method26(v309, v311.clone()) {
                                                        let v313: i32 = v311.l0.get().clone();
                                                        let v318: string = if v313 < v307 {
                                                            v306[v313].clone()
                                                        } else {
                                                            let v316: i32 = v313 - v307;
                                                            v284[v316].clone()
                                                        };
                                                        v310.get_mut()[v313 as usize] = v318;
                                                        {
                                                            let v319: i32 = v313 + 1_i32;
                                                            v311.l0.set(v319);
                                                            ()
                                                        }
                                                    }
                                                    (0_i32, v310.clone())
                                                }
                                            } else {
                                                (v283 - 1_i32, v284.clone())
                                            }
                                        };
                                        let v327: i32 = v279 + 1_i32;
                                        v277.l0.set(v327);
                                        v277.l1.set(patternInput_4.0.clone());
                                        v277.l2.set(patternInput_4.1.clone());
                                        ()
                                    }
                                    {
                                        let matchValue_6: i32 = v277.l1.get().clone();
                                        let v329: Array<string> = v277.l2.get().clone();
                                        let v330: LrcPtr<dyn IEnumerable_1<string>> =
                                            delay(Func0::new({
                                                let v329 = v329.clone();
                                                move || {
                                                    map_1(
                                                        Func1::new({
                                                            let v329 = v329.clone();
                                                            move |i_1: i32| v329[i_1].clone()
                                                        }),
                                                        rangeNumeric(
                                                            0_i32,
                                                            1_i32,
                                                            count(v329.clone()) - 1_i32,
                                                        ),
                                                    )
                                                }
                                            }));
                                        let _v331: MutCell<Option<char>> =
                                            MutCell::new(None::<char>);
                                        {
                                            let x_11: char = std::path::MAIN_SEPARATOR;
                                            _v331.set(Some(x_11))
                                        }
                                        join(
                                            Documents::method27(ofChar(getValue(
                                                _v331.get().clone(),
                                            ))),
                                            toArray_1(v330),
                                        )
                                    }
                                }
                            }
                        }
                    } else {
                        let v348: Result<std::path::PathBuf, std::io::Error> =
                            std::fs::canonicalize(&*v195);
                        let v350: std::path::PathBuf = v348.unwrap();
                        let v352: std::path::Display = v350.display();
                        let _v353: MutCell<Option<std::string::String>> =
                            MutCell::new(None::<std::string::String>);
                        {
                            let x_12: std::string::String = format!("{}", v352);
                            _v353.set(Some(x_12))
                        }
                        {
                            let v364: std::string::String = getValue(_v353.get().clone());
                            fable_library_rust::String_::fromString(v364)
                        }
                    };
                    _v193.set(Some(x_13))
                }
                {
                    let v375: string = getValue(_v193.get().clone());
                    let _v376: MutCell<Option<string>> = MutCell::new(None::<string>);
                    let v378: string = Documents::method21(v1_1);
                    let v379: string = Documents::method14(v378.clone());
                    let v381: &str = fable_library_rust::String_::LrcStr::as_str(&v379);
                    let v383: std::string::String = String::from(v381);
                    let v385: std::path::PathBuf = std::path::PathBuf::from(v383);
                    {
                        let x_20: string = if v385.exists() == false {
                            let _v389: MutCell<Option<string>> = MutCell::new(None::<string>);
                            let v392: Result<std::path::PathBuf, std::io::Error> =
                                std::env::current_dir();
                            let v394: std::path::PathBuf = v392.unwrap();
                            let v396: std::path::Display = v394.display();
                            let _v397: MutCell<Option<std::string::String>> =
                                MutCell::new(None::<std::string::String>);
                            {
                                let x_14: std::string::String = format!("{}", v396);
                                _v397.set(Some(x_14))
                            }
                            {
                                let v408: std::string::String = getValue(_v397.get().clone());
                                {
                                    let x_15: string =
                                        fable_library_rust::String_::fromString(v408);
                                    _v389.set(Some(x_15))
                                }
                                {
                                    let v417: string = getValue(_v389.get().clone());
                                    let v418: string =
                                        Documents::method13(v417.clone(), v378.clone());
                                    let _v419: MutCell<Option<bool>> = MutCell::new(None::<bool>);
                                    {
                                        let x_16: bool = cfg!(windows);
                                        _v419.set(Some(x_16))
                                    }
                                    {
                                        let v457: Array<string> = split(
                                            if getValue(_v419.get().clone()) == false {
                                                v418.clone()
                                            } else {
                                                let _v432: MutCell<Option<string>> =
                                                    MutCell::new(None::<string>);
                                                let v434: string = Documents::method22();
                                                let v435: string = Documents::method23(v418);
                                                let v436: string = Documents::method24();
                                                let v438: &str = &regex::Regex::new(&v434)
                                                    .unwrap()
                                                    .replace_all(&v435, &*v436);
                                                let v440: std::string::String = String::from(v438);
                                                {
                                                    let x_17: string =
                                                        fable_library_rust::String_::fromString(
                                                            v440,
                                                        );
                                                    _v432.set(Some(x_17))
                                                }
                                                {
                                                    let v450: string =
                                                        getValue(_v432.get().clone());
                                                    replace(
                                                        sprintf!(
                                                            "{}{}",
                                                            toLower(ofChar(getCharAt(
                                                                v450.clone(),
                                                                0_i32
                                                            ))),
                                                            getSlice(
                                                                v450,
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
                                        let v459: i32 = count(v457.clone());
                                        let v460: LrcPtr<Documents::Mut4> =
                                            LrcPtr::new(Documents::Mut4 {
                                                l0: MutCell::new(0_i32),
                                                l1: MutCell::new(0_i32),
                                                l2: MutCell::new(new_empty::<string>()),
                                            });
                                        while Documents::method25(v459, v460.clone()) {
                                            let v462: i32 = v460.l0.get().clone();
                                            let v465: i32 = v462.wrapping_neg() + v459 - 1_i32;
                                            let matchValue_8: i32 = v460.l1.get().clone();
                                            let v467: Array<string> = v460.l2.get().clone();
                                            let v466: i32 = matchValue_8;
                                            let v468: string = v457[v465].clone();
                                            let patternInput_7: (i32, Array<string>) =
                                                if string("..") == v468.clone() {
                                                    (v466 + 1_i32, v467.clone())
                                                } else {
                                                    if 0_i32 == v466 {
                                                        if endsWith(
                                                            v468.clone(),
                                                            string(":"),
                                                            false,
                                                        ) {
                                                            let v475: Array<string> =
                                                                new_array(&[sprintf!(
                                                                    "{}:",
                                                                    getCharAt(v417.clone(), 0_i32)
                                                                )]);
                                                            let v476: i32 = count(v475.clone());
                                                            let v478: i32 =
                                                                v476 + count(v467.clone());
                                                            let v479: Array<string> =
                                                                new_init(&string(""), v478);
                                                            let v480: LrcPtr<Documents::Mut5> =
                                                                LrcPtr::new(Documents::Mut5 {
                                                                    l0: MutCell::new(0_i32),
                                                                });
                                                            while Documents::method26(
                                                                v478,
                                                                v480.clone(),
                                                            ) {
                                                                let v482: i32 =
                                                                    v480.l0.get().clone();
                                                                let v487: string = if v482 < v476 {
                                                                    v475[v482].clone()
                                                                } else {
                                                                    let v485: i32 = v482 - v476;
                                                                    v467[v485].clone()
                                                                };
                                                                v479.get_mut()[v482 as usize] =
                                                                    v487;
                                                                {
                                                                    let v488: i32 = v482 + 1_i32;
                                                                    v480.l0.set(v488);
                                                                    ()
                                                                }
                                                            }
                                                            (0_i32, v479.clone())
                                                        } else {
                                                            let v489: Array<string> =
                                                                new_array(&[v468]);
                                                            let v490: i32 = count(v489.clone());
                                                            let v492: i32 =
                                                                v490 + count(v467.clone());
                                                            let v493: Array<string> =
                                                                new_init(&string(""), v492);
                                                            let v494: LrcPtr<Documents::Mut5> =
                                                                LrcPtr::new(Documents::Mut5 {
                                                                    l0: MutCell::new(0_i32),
                                                                });
                                                            while Documents::method26(
                                                                v492,
                                                                v494.clone(),
                                                            ) {
                                                                let v496: i32 =
                                                                    v494.l0.get().clone();
                                                                let v501: string = if v496 < v490 {
                                                                    v489[v496].clone()
                                                                } else {
                                                                    let v499: i32 = v496 - v490;
                                                                    v467[v499].clone()
                                                                };
                                                                v493.get_mut()[v496 as usize] =
                                                                    v501;
                                                                {
                                                                    let v502: i32 = v496 + 1_i32;
                                                                    v494.l0.set(v502);
                                                                    ()
                                                                }
                                                            }
                                                            (0_i32, v493.clone())
                                                        }
                                                    } else {
                                                        (v466 - 1_i32, v467.clone())
                                                    }
                                                };
                                            let v510: i32 = v462 + 1_i32;
                                            v460.l0.set(v510);
                                            v460.l1.set(patternInput_7.0.clone());
                                            v460.l2.set(patternInput_7.1.clone());
                                            ()
                                        }
                                        {
                                            let matchValue_10: i32 = v460.l1.get().clone();
                                            let v512: Array<string> = v460.l2.get().clone();
                                            let v513: LrcPtr<dyn IEnumerable_1<string>> =
                                                delay(Func0::new({
                                                    let v512 = v512.clone();
                                                    move || {
                                                        map_1(
                                                            Func1::new({
                                                                let v512 = v512.clone();
                                                                move |i_2: i32| v512[i_2].clone()
                                                            }),
                                                            rangeNumeric(
                                                                0_i32,
                                                                1_i32,
                                                                count(v512.clone()) - 1_i32,
                                                            ),
                                                        )
                                                    }
                                                }));
                                            let _v514: MutCell<Option<char>> =
                                                MutCell::new(None::<char>);
                                            {
                                                let x_18: char = std::path::MAIN_SEPARATOR;
                                                _v514.set(Some(x_18))
                                            }
                                            join(
                                                Documents::method27(ofChar(getValue(
                                                    _v514.get().clone(),
                                                ))),
                                                toArray_1(v513),
                                            )
                                        }
                                    }
                                }
                            }
                        } else {
                            let v531: Result<std::path::PathBuf, std::io::Error> =
                                std::fs::canonicalize(&*v378);
                            let v533: std::path::PathBuf = v531.unwrap();
                            let v535: std::path::Display = v533.display();
                            let _v536: MutCell<Option<std::string::String>> =
                                MutCell::new(None::<std::string::String>);
                            {
                                let x_19: std::string::String = format!("{}", v535);
                                _v536.set(Some(x_19))
                            }
                            {
                                let v547: std::string::String = getValue(_v536.get().clone());
                                fable_library_rust::String_::fromString(v547)
                            }
                        };
                        _v376.set(Some(x_20))
                    }
                    {
                        let v558: string = getValue(_v376.get().clone());
                        Documents::method3(
                            Documents::US0::US0_1,
                            Func0::new(move || Documents::closure12((), ())),
                            Func0::new({
                                let v0_1 = v0_1.clone();
                                let v192 = v192.clone();
                                let v375 = v375.clone();
                                let v558 = v558.clone();
                                move || {
                                    Documents::closure13(
                                        v0_1.clone(),
                                        v192.clone(),
                                        v375.clone(),
                                        v558.clone(),
                                        (),
                                    )
                                }
                            }),
                        );
                        Documents::method29(
                            v0_1.clone(),
                            v9,
                            v192.clone(),
                            v375.clone(),
                            v558.clone(),
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
