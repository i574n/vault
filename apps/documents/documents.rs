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
        use fable_library_rust::List_::toArray as toArray_1;
        use fable_library_rust::List_::List;
        use fable_library_rust::Map_::find;
        use fable_library_rust::Map_::ofSeq;
        use fable_library_rust::NativeArray_::count;
        use fable_library_rust::NativeArray_::new_array;
        use fable_library_rust::NativeArray_::new_empty;
        use fable_library_rust::NativeArray_::new_init;
        use fable_library_rust::NativeArray_::Array;
        use fable_library_rust::Native_::defaultOf;
        use fable_library_rust::Native_::refCell;
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
        use fable_library_rust::Range_::rangeNumeric;
        use fable_library_rust::Seq_::delay;
        use fable_library_rust::Seq_::map;
        use fable_library_rust::Seq_::ofList;
        use fable_library_rust::Seq_::toArray;
        use fable_library_rust::String_::append;
        use fable_library_rust::String_::contains;
        use fable_library_rust::String_::endsWith;
        use fable_library_rust::String_::getCharAt;
        use fable_library_rust::String_::getSlice;
        use fable_library_rust::String_::join;
        use fable_library_rust::String_::lastIndexOf;
        use fable_library_rust::String_::length;
        use fable_library_rust::String_::ofChar;
        use fable_library_rust::String_::padLeft;
        use fable_library_rust::String_::printfn;
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
        #[derive(Clone, Debug)]
        pub enum US2 {
            US2_0(std::string::String),
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
        #[derive(Clone, Debug, PartialEq, PartialOrd, Hash, Eq)]
        pub enum US3 {
            US3_0(string),
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
        pub enum US8 {
            US8_0,
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
        #[derive(Clone, Copy, Debug, PartialEq, PartialOrd, Hash, Eq)]
        pub enum US7 {
            US7_0,
            US7_1(Documents::US8),
            US7_2,
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
            pub fn get_IsUS7_2(this_: &MutCell<Documents::US7>, unitArg: ()) -> bool {
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
        pub enum US9 {
            US9_0,
            US9_1(char),
            US9_2(u8, char),
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
            pub fn get_IsUS9_2(this_: &MutCell<Documents::US9>, unitArg: ()) -> bool {
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
        #[derive(Clone, Debug)]
        pub enum US10 {
            US10_0(std::sync::Arc<std::sync::Mutex<Option<std::process::Child>>>),
            US10_1(std::string::String),
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
        }
        impl core::fmt::Display for Documents::US10 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum US11 {
            US11_0(
                std::sync::Arc<
                    std::sync::Mutex<
                        std::sync::Arc<std::sync::mpsc::Receiver<std::string::String>>,
                    >,
                >,
            ),
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
        #[derive(Clone, Debug)]
        pub enum US12 {
            US12_0(std::string::String),
            US12_1(std::string::String),
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
            US13_0(Func1<std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>, ()>),
            US13_1,
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
            US14_0(std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>),
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
            US15_0(std::process::Output),
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
            US16_0(Func1<(bool, string, i32), Arc<Async<()>>>),
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
        #[derive(Clone, Copy, Debug, PartialEq, PartialOrd, Hash, Eq)]
        pub enum US17 {
            US17_0(CancellationToken),
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
            US18_0(Result<string, LrcPtr<(string, string)>>),
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
        #[derive(Clone, Debug)]
        pub enum UH3 {
            UH3_0,
            UH3_1(
                string,
                string,
                Func2<string, string, Documents::US18>,
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
        pub enum US19 {
            US19_0(i32, string),
            US19_1(i32, string),
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
        pub fn method1() -> string {
            string("")
        }
        pub fn method2() -> string {
            string("AUTOMATION")
        }
        pub fn closure2(
            unitVar: (),
            v0_1: Documents::US0,
        ) -> (
            LrcPtr<Documents::Mut0>,
            LrcPtr<Documents::Mut1>,
            LrcPtr<Documents::Mut2>,
            Option<i64>,
            LrcPtr<Documents::Mut3>,
        ) {
            let v1_1: LrcPtr<Documents::Mut1> = LrcPtr::new(Documents::Mut1 {
                l0: MutCell::new(true),
            });
            let v2: LrcPtr<Documents::Mut0> = LrcPtr::new(Documents::Mut0 {
                l0: MutCell::new(0_i64),
            });
            let v3: LrcPtr<Documents::Mut2> = LrcPtr::new(Documents::Mut2 {
                l0: MutCell::new(v0_1),
            });
            let v5: LrcPtr<Documents::Mut3> = LrcPtr::new(Documents::Mut3 {
                l0: MutCell::new(Func1::new(move |v: string| Documents::closure3((), v))),
            });
            let _v6: MutCell<Option<Option<i64>>> = MutCell::new(None::<Option<i64>>);
            let _v7: MutCell<Option<string>> = MutCell::new(None::<string>);
            let v10: Result<std::string::String, std::env::VarError> =
                std::env::var(&*string("AUTOMATION"));
            let v12: bool = true;
            let _result = v10.map(|x| {
                //;
                let v14: std::string::String = x;
                let v16: string = fable_library_rust::String_::fromString(v14);
                let v18: bool = true;
                v16
            });
            let v20: Result<string, std::env::VarError> = _result;
            let v21: string = Documents::method1();
            {
                let x: string = v20.unwrap_or(v21);
                _v7.set(Some(x))
            }
            {
                let v39: Documents::US1 = if getValue(_v7.get().clone()) == string("True") {
                    Documents::US1::US1_0({
                        let _arg: DateTime = DateTime::now();
                        _arg.ticks()
                    })
                } else {
                    Documents::US1::US1_1
                };
                {
                    let x_1: Option<i64> = match &v39 {
                        Documents::US1::US1_0(v39_0_0) => Some(match &v39 {
                            Documents::US1::US1_0(x) => x.clone(),
                            _ => unreachable!(),
                        }),
                        _ => None::<i64>,
                    };
                    _v6.set(Some(x_1))
                }
                (v2, v1_1, v3, getValue(_v6.get().clone()), v5)
            }
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
        pub fn method4() -> string {
            string("")
        }
        pub fn closure7(
            v0_1: Documents::US0,
            v1_1: Func0<string>,
            v2: Func0<string>,
            unitVar: (),
        ) -> string {
            if Documents::State::trace_state().get().clone().is_none() {
                Documents::State::trace_state()
                    .set(Some(Documents::closure2((), Documents::US0::US0_0)));
            }
            {
                let patternInput: (
                    LrcPtr<Documents::Mut0>,
                    LrcPtr<Documents::Mut1>,
                    LrcPtr<Documents::Mut2>,
                    Option<i64>,
                    LrcPtr<Documents::Mut3>,
                ) = getValue(Documents::State::trace_state().get().clone());
                let v8: Option<i64> = patternInput.3.clone();
                let _v10: MutCell<Option<string>> = MutCell::new(None::<string>);
                let _v11: LrcPtr<MutCell<Option<Documents::US1>>> = refCell(None::<Documents::US1>);
                {
                    let x_2: Option<Documents::US1> = match &v8 {
                        None => None::<Documents::US1>,
                        Some(v8_0_0) => {
                            let x: i64 = v8_0_0.clone();
                            Some((Func0::new({
                                let x = x.clone();
                                move || Documents::US1::US1_0(x)
                            }))())
                        }
                    };
                    _v11.set(x_2)
                }
                {
                    let v16: Documents::US1 =
                        defaultValue(Documents::US1::US1_1, _v11.get().clone());
                    let v34: DateTime = match &v16 {
                        Documents::US1::US1_0(v16_0_0) => {
                            let v22: TimeSpan = TimeSpan::new_ticks(
                                {
                                    let _arg: DateTime = DateTime::now();
                                    _arg.ticks()
                                } - match &v16 {
                                    Documents::US1::US1_0(x) => x.clone(),
                                    _ => unreachable!(),
                                },
                            );
                            DateTime::new_ymdhms_milli(
                                1_i32,
                                1_i32,
                                1_i32,
                                v22.hours(),
                                v22.minutes(),
                                v22.seconds(),
                                v22.milliseconds(),
                            )
                        }
                        _ => DateTime::now(),
                    };
                    {
                        let x_3: string = v34.toString(string("hh:mm:ss"));
                        _v10.set(Some(x_3))
                    }
                    {
                        let v67: string = getValue(_v10.get().clone());
                        let v68: i64 = (patternInput.0.clone()).l0.get().clone();
                        let v80: string = padLeft(
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
                        let _v81: MutCell<Option<string>> = MutCell::new(None::<string>);
                        let v96: &str = match &v0_1 {
                            Documents::US0::US0_1 => inline_colorization::color_bright_blue,
                            Documents::US0::US0_2 => inline_colorization::color_bright_green,
                            Documents::US0::US0_0 => inline_colorization::color_bright_black,
                            Documents::US0::US0_3 => inline_colorization::color_yellow,
                            _ => inline_colorization::color_bright_red,
                        };
                        let v98: &str = &*v80;
                        let v100: &str = inline_colorization::color_reset;
                        let v102: string = string("format!(\"{v96}{v98}{v100}\")");
                        let v103: std::string::String = format!("{v96}{v98}{v100}");
                        {
                            let x_4: string = fable_library_rust::String_::fromString(v103);
                            _v81.set(Some(x_4))
                        }
                        trimEndChars(
                            trimStartChars(
                                sprintf!(
                                    "{} {} #{} {} / {}",
                                    v67,
                                    getValue(_v81.get().clone()),
                                    v68,
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
        }
        pub fn method5(v0_1: Documents::US0, v1_1: Func0<string>) {
            fn v2(
                v: Documents::US0,
            ) -> (
                LrcPtr<Documents::Mut0>,
                LrcPtr<Documents::Mut1>,
                LrcPtr<Documents::Mut2>,
                Option<i64>,
                LrcPtr<Documents::Mut3>,
            ) {
                Documents::closure2((), v)
            }
            if Documents::State::trace_state().get().clone().is_none() {
                Documents::State::trace_state().set(Some(v2(Documents::US0::US0_0)));
            }
            {
                let patternInput: (
                    LrcPtr<Documents::Mut0>,
                    LrcPtr<Documents::Mut1>,
                    LrcPtr<Documents::Mut2>,
                    Option<i64>,
                    LrcPtr<Documents::Mut3>,
                ) = getValue(Documents::State::trace_state().get().clone());
                let v4: LrcPtr<Documents::Mut0> = patternInput.0.clone();
                if Documents::State::trace_state().get().clone().is_none() {
                    Documents::State::trace_state().set(Some(v2(Documents::US0::US0_0)));
                }
                {
                    let patternInput_1: (
                        LrcPtr<Documents::Mut0>,
                        LrcPtr<Documents::Mut1>,
                        LrcPtr<Documents::Mut2>,
                        Option<i64>,
                        LrcPtr<Documents::Mut3>,
                    ) = getValue(Documents::State::trace_state().get().clone());
                    let v15: Documents::US0 = (patternInput_1.2.clone()).l0.get().clone();
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
                            v15,
                            ofSeq(ofList(ofArray(new_array(&[
                                LrcPtr::new((Documents::US0::US0_0, 0_i32)),
                                LrcPtr::new((Documents::US0::US0_1, 1_i32)),
                                LrcPtr::new((Documents::US0::US0_2, 2_i32)),
                                LrcPtr::new((Documents::US0::US0_3, 3_i32)),
                                LrcPtr::new((Documents::US0::US0_4, 4_i32)),
                            ])))),
                        )
                    } {
                        let v23: i64 = v4.l0.get().clone() + 1_i64;
                        v4.l0.set(v23);
                        {
                            let v24: string = sprintf!("{}", v1_1());
                            let _v25: MutCell<Option<()>> = MutCell::new(None::<()>);
                            println!("{}", v24.clone());
                            _v25.set(Some(()));
                            getValue(_v25.get().clone());
                            ((patternInput.4.clone()).l0.get().clone())(v24)
                        }
                    }
                }
            }
        }
        pub fn method3(v0_1: Documents::US0, v1_1: Func0<string>, v2: Func0<string>) {
            Documents::method5(
                v0_1.clone(),
                Func0::new({
                    let v0_1 = v0_1.clone();
                    let v1_1 = v1_1.clone();
                    let v2 = v2.clone();
                    move || Documents::closure7(v0_1.clone(), v1_1.clone(), v2.clone(), ())
                }),
            );
        }
        pub fn method6() -> string {
            string("source-dir")
        }
        pub fn method7() -> string {
            string("dist-dir")
        }
        pub fn method8() -> string {
            string("cache-dir")
        }
        pub fn method9() -> string {
            string("hangul-spec")
        }
        pub fn method12(v0_1: string) -> string {
            v0_1
        }
        pub fn method13(v0_1: string) -> string {
            v0_1
        }
        pub fn method11(v0_1: string, v1_1: string) -> string {
            let _v2: MutCell<Option<string>> = MutCell::new(None::<string>);
            let v4: &str = &*v0_1;
            let v6: std::string::String = String::from(v4);
            let v8: std::path::PathBuf = std::path::PathBuf::from(v6);
            let v10: &str = &*v1_1;
            let v12: std::string::String = String::from(v10);
            let v14: std::path::PathBuf = v8.join(v12);
            let v16: std::path::Display = v14.display();
            let _v17: MutCell<Option<std::string::String>> =
                MutCell::new(None::<std::string::String>);
            {
                let x: std::string::String = format!("{}", v16);
                _v17.set(Some(x))
            }
            {
                let v27: std::string::String = getValue(_v17.get().clone());
                {
                    let x_1: string = fable_library_rust::String_::fromString(v27);
                    _v2.set(Some(x_1))
                }
                getValue(_v2.get().clone())
            }
        }
        pub fn closure8(unitVar: (), v0_1: string) -> Option<string> {
            let _v1: MutCell<Option<Documents::US3>> = MutCell::new(None::<Documents::US3>);
            let v3: &str = &*v0_1;
            let v5: std::string::String = String::from(v3);
            let v7: std::path::PathBuf = std::path::PathBuf::from(v5);
            let v9: Option<std::path::PathBuf> = v7.parent().map(std::path::PathBuf::from);
            let v11: std::path::PathBuf = v9?;
            let v13: std::path::Display = v11.display();
            let _v14: MutCell<Option<std::string::String>> =
                MutCell::new(None::<std::string::String>);
            {
                let x: std::string::String = format!("{}", v13);
                _v14.set(Some(x))
            }
            {
                let v24: std::string::String = getValue(_v14.get().clone());
                {
                    let x_1: Documents::US3 =
                        Documents::US3::US3_0(fable_library_rust::String_::fromString(v24));
                    _v1.set(Some(x_1))
                }
                {
                    let v51: Documents::US3 = getValue(_v1.get().clone());
                    match &v51 {
                        Documents::US3::US3_0(v51_0_0) => Some(match &v51 {
                            Documents::US3::US3_0(x) => x.clone(),
                            _ => unreachable!(),
                        }),
                        _ => None::<string>,
                    }
                }
            }
        }
        pub fn method15() -> Func1<string, Option<string>> {
            Func1::new(move |v: string| Documents::closure8((), v))
        }
        pub fn method16(v0_1: string, v1_1: string, v2: string) -> string {
            let v0_1: MutCell<string> = MutCell::new(v0_1.clone());
            let v1_1: MutCell<string> = MutCell::new(v1_1.clone());
            let v2: MutCell<string> = MutCell::new(v2.clone());
            '_method16: loop {
                break '_method16 ({
                    let v3: string = Documents::method11(v2.get().clone(), v0_1.get().clone());
                    let _v4: MutCell<Option<bool>> = MutCell::new(None::<bool>);
                    let v6: &str = &*v3;
                    let v8: std::string::String = String::from(v6);
                    let v10: std::path::PathBuf = std::path::PathBuf::from(v8);
                    {
                        let x: bool = if v10.clone().exists() {
                            v10.is_dir()
                        } else {
                            false
                        };
                        _v4.set(Some(x))
                    }
                    if getValue(_v4.get().clone()) {
                        v2.get().clone()
                    } else {
                        let v27: Option<string> = (Documents::method15())(v2.get().clone());
                        let _v28: LrcPtr<MutCell<Option<Documents::US3>>> =
                            refCell(None::<Documents::US3>);
                        {
                            let x_3: Option<Documents::US3> = match &v27 {
                                None => None::<Documents::US3>,
                                Some(v27_0_0) => {
                                    let x_1: string = v27_0_0.clone();
                                    Some((Func0::new({
                                        let x_1 = x_1.clone();
                                        move || Documents::US3::US3_0(x_1.clone())
                                    }))())
                                }
                            };
                            _v28.set(x_3)
                        }
                        {
                            let v33: Documents::US3 =
                                defaultValue(Documents::US3::US3_1, _v28.get().clone());
                            match &v33 {
                                Documents::US3::US3_0(v33_0_0) => {
                                    let v0_1_temp: string = v0_1.get().clone();
                                    let v1_1_temp: string = v1_1.get().clone();
                                    let v2_temp: string = match &v33 {
                                        Documents::US3::US3_0(x) => x.clone(),
                                        _ => unreachable!(),
                                    };
                                    v0_1.set(v0_1_temp);
                                    v1_1.set(v1_1_temp);
                                    v2.set(v2_temp);
                                    continue '_method16;
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
        pub fn method14(v0_1: string, v1_1: string) -> string {
            let v2: string = Documents::method11(v1_1.clone(), v0_1.clone());
            let _v3: MutCell<Option<bool>> = MutCell::new(None::<bool>);
            let v5: &str = &*v2;
            let v7: std::string::String = String::from(v5);
            let v9: std::path::PathBuf = std::path::PathBuf::from(v7);
            {
                let x: bool = if v9.clone().exists() {
                    v9.is_dir()
                } else {
                    false
                };
                _v3.set(Some(x))
            }
            if getValue(_v3.get().clone()) {
                v1_1.clone()
            } else {
                let v26: Option<string> = (Documents::method15())(v1_1.clone());
                let _v27: LrcPtr<MutCell<Option<Documents::US3>>> = refCell(None::<Documents::US3>);
                {
                    let x_3: Option<Documents::US3> = match &v26 {
                        None => None::<Documents::US3>,
                        Some(v26_0_0) => {
                            let x_1: string = v26_0_0.clone();
                            Some((Func0::new({
                                let x_1 = x_1.clone();
                                move || Documents::US3::US3_0(x_1.clone())
                            }))())
                        }
                    };
                    _v27.set(x_3)
                }
                {
                    let v32: Documents::US3 =
                        defaultValue(Documents::US3::US3_1, _v27.get().clone());
                    match &v32 {
                        Documents::US3::US3_0(v32_0_0) => Documents::method16(
                            v0_1.clone(),
                            v1_1.clone(),
                            match &v32 {
                                Documents::US3::US3_0(x) => x.clone(),
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
        pub fn method17(v0_1: string) -> string {
            v0_1
        }
        pub fn method18(v0_1: string) -> string {
            v0_1
        }
        pub fn method19() -> string {
            string("")
        }
        pub fn method20() -> string {
            string("^\\\\\\\\\\?\\\\")
        }
        pub fn method21() -> string {
            string("")
        }
        pub fn method22(v0_1: i32, v1_1: LrcPtr<Documents::Mut4>) -> bool {
            v1_1.l0.get().clone() < v0_1
        }
        pub fn method23(v0_1: i32, v1_1: LrcPtr<Documents::Mut5>) -> bool {
            v1_1.l0.get().clone() < v0_1
        }
        pub fn method24(v0_1: string) -> string {
            v0_1
        }
        pub fn method25(v0_1: string) -> string {
            v0_1
        }
        pub fn closure9(unitVar: (), unitVar_1: ()) -> string {
            string("documents.run")
        }
        pub fn closure10(
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
        pub fn method28(v0_1: async_walkdir::DirEntry) -> async_walkdir::DirEntry {
            v0_1
        }
        pub fn closure12(unitVar: (), v0_1: std::io::Error) -> std::string::String {
            let _v1: MutCell<Option<std::string::String>> =
                MutCell::new(None::<std::string::String>);
            {
                let x: std::string::String = format!("{}", v0_1);
                _v1.set(Some(x))
            }
            getValue(_v1.get().clone())
        }
        pub fn method29() -> Func1<std::io::Error, std::string::String> {
            Func1::new(move |v: std::io::Error| Documents::closure12((), v))
        }
        pub fn closure13(unitVar: (), v0_1: std::fs::FileType) -> Documents::US5 {
            Documents::US5::US5_0(v0_1)
        }
        pub fn closure14(unitVar: (), v0_1: std::string::String) -> Documents::US5 {
            Documents::US5::US5_1(v0_1)
        }
        pub fn method30(v0_1: std::fs::FileType) -> std::fs::FileType {
            v0_1
        }
        pub fn method31(v0_1: Documents::US4) -> Documents::US4 {
            v0_1
        }
        pub fn method27(
            v0_1: async_walkdir::DirEntry,
        ) -> std::pin::Pin<Box<dyn std::future::Future<Output = Documents::US4> + Send>> {
            let __result = Box::pin(async move {
                //;
                {
                    let v2: async_walkdir::DirEntry = Documents::method28(v0_1.clone());
                    let v4: std::pin::Pin<
                        Box<
                            dyn std::future::Future<
                                    Output = Result<std::fs::FileType, std::io::Error>,
                                > + Send,
                        >,
                    > = Box::pin(async_walkdir::DirEntry::file_type(&v2));
                    let v6: Result<std::fs::FileType, std::io::Error> = v4.await;
                    let v7 = Documents::method29();
                    let v9: Result<std::fs::FileType, std::string::String> = v6.map_err(|x| v7(x));
                    let v12: Documents::US5 = match &v9 {
                        Err(v9_1_0) => Documents::closure14((), v9_1_0.clone()),
                        Ok(v9_0_0) => Documents::closure13((), v9_0_0.clone()),
                    };
                    let v72: Documents::US4 =
                        Documents::method31(if let Documents::US5::US5_0(v12_0_0) = &v12 {
                            let v14: std::fs::FileType = Documents::method30(match &v12 {
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
                                    let v32: std::string::String = getValue(_v22.get().clone());
                                    let v34: string = fable_library_rust::String_::fromString(v32);
                                    if if endsWith(v34.clone(), string(".md"), false) == false {
                                        true
                                    } else {
                                        endsWith(v34, string(".hangul.md"), false)
                                    } {
                                        Documents::US4::US4_0
                                    } else {
                                        Documents::US4::US4_2
                                    }
                                }
                            }
                        } else {
                            let v46: std::path::PathBuf = async_walkdir::DirEntry::path(&v0_1);
                            let v48: std::path::Display = v46.display();
                            let _v49: MutCell<Option<std::string::String>> =
                                MutCell::new(None::<std::string::String>);
                            {
                                let x_3: std::string::String = format!("{}", v48);
                                _v49.set(Some(x_3))
                            }
                            {
                                let v59: std::string::String = getValue(_v49.get().clone());
                                let v61: string = fable_library_rust::String_::fromString(v59);
                                if if endsWith(v61.clone(), string(".md"), false) == false {
                                    true
                                } else {
                                    endsWith(v61, string(".hangul.md"), false)
                                } {
                                    Documents::US4::US4_0
                                } else {
                                    Documents::US4::US4_2
                                }
                            }
                        });
                    v72
                }
            });
            {
                //;
                __result
            }
        }
        pub fn method32(v0_1: async_walkdir::Filtering) -> async_walkdir::Filtering {
            v0_1
        }
        pub fn method26(
            v0_1: async_walkdir::DirEntry,
        ) -> std::pin::Pin<Box<dyn std::future::Future<Output = async_walkdir::Filtering> + Send>>
        {
            let __result = Box::pin(async {
                //;
                {
                    let v2: std::pin::Pin<
                        Box<dyn std::future::Future<Output = Documents::US4> + Send>,
                    > = Documents::method27(v0_1);
                    let v4: Documents::US4 = v2.await;
                    let v14: async_walkdir::Filtering = Documents::method32(match &v4 {
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
        pub fn closure11(
            unitVar: (),
            v0_1: async_walkdir::DirEntry,
        ) -> std::pin::Pin<Box<dyn std::future::Future<Output = async_walkdir::Filtering> + Send>>
        {
            Documents::method26(v0_1)
        }
        pub fn closure16(unitVar: (), v0_1: async_walkdir::DirEntry) -> Documents::US6 {
            Documents::US6::US6_0(v0_1)
        }
        pub fn closure17(unitVar: (), v0_1: std::string::String) -> Documents::US6 {
            Documents::US6::US6_1(v0_1)
        }
        pub fn closure18(unitVar: (), unitVar_1: ()) -> string {
            string("documents.run / stream_filter_map")
        }
        pub fn closure19(v0_1: std::string::String, unitVar: ()) -> string {
            sprintf!("error: {} / {}", v0_1, Documents::closure6((), ()))
        }
        pub fn closure15(
            unitVar: (),
            v0_1: Result<async_walkdir::DirEntry, std::io::Error>,
        ) -> Option<string> {
            let v1_1 = Documents::method29();
            let v3: Result<async_walkdir::DirEntry, std::string::String> =
                v0_1.map_err(|x| v1_1(x));
            let v6: Documents::US6 = match &v3 {
                Err(v3_1_0) => Documents::closure17((), v3_1_0.clone()),
                Ok(v3_0_0) => Documents::closure16((), v3_0_0.clone()),
            };
            let v32: Documents::US3 = match &v6 {
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
                        let v22: std::string::String = getValue(_v12.get().clone());
                        Documents::US3::US3_0(fable_library_rust::String_::fromString(v22))
                    }
                }
                Documents::US6::US6_1(v6_1_0) => {
                    Documents::method3(
                        Documents::US0::US0_4,
                        Func0::new(move || Documents::closure18((), ())),
                        Func0::new({
                            let v6 = v6.clone();
                            move || {
                                Documents::closure19(
                                    match &v6 {
                                        Documents::US6::US6_1(x) => x.clone(),
                                        _ => unreachable!(),
                                    },
                                    (),
                                )
                            }
                        }),
                    );
                    Documents::US3::US3_1
                }
            };
            match &v32 {
                Documents::US3::US3_0(v32_0_0) => Some(match &v32 {
                    Documents::US3::US3_0(x) => x.clone(),
                    _ => unreachable!(),
                }),
                _ => None::<string>,
            }
        }
        pub fn method33() -> Func1<Result<async_walkdir::DirEntry, std::io::Error>, Option<string>>
        {
            Func1::new(move |v: Result<async_walkdir::DirEntry, std::io::Error>| {
                Documents::closure15((), v)
            })
        }
        pub fn closure20(unitVar: (), unitVar_1: ()) -> string {
            string("documents.run")
        }
        pub fn closure21(v0_1: Vec<string>, unitVar: ()) -> string {
            sprintf!(
                "files_len: {} / {}",
                v0_1.len(),
                Documents::closure6((), ())
            )
        }
        pub fn method34(v0_1: string) -> string {
            let _v1: MutCell<Option<string>> = MutCell::new(None::<string>);
            let v2: string = Documents::method17(v0_1);
            let v4: &str = &*v2.clone();
            let v6: std::string::String = String::from(v4);
            let v8: std::path::PathBuf = std::path::PathBuf::from(v6);
            {
                let x_6: string = if v8.exists() == false {
                    let _v12: MutCell<Option<string>> = MutCell::new(None::<string>);
                    let v14: Result<std::path::PathBuf, std::io::Error> = std::env::current_dir();
                    let v16: std::path::PathBuf = v14.unwrap();
                    let v18: std::path::Display = v16.display();
                    let _v19: MutCell<Option<std::string::String>> =
                        MutCell::new(None::<std::string::String>);
                    {
                        let x: std::string::String = format!("{}", v18);
                        _v19.set(Some(x))
                    }
                    {
                        let v29: std::string::String = getValue(_v19.get().clone());
                        {
                            let x_1: string = fable_library_rust::String_::fromString(v29);
                            _v12.set(Some(x_1))
                        }
                        {
                            let v38: string = getValue(_v12.get().clone());
                            let _v40: MutCell<Option<string>> = MutCell::new(None::<string>);
                            let v41: string =
                                Documents::method18(Documents::method11(v38.clone(), v2.clone()));
                            let v42: string = Documents::method19();
                            let _v43: MutCell<Option<Result<regex::Regex, regex::Error>>> =
                                MutCell::new(None::<Result<regex::Regex, regex::Error>>);
                            let v44: string = Documents::method20();
                            {
                                let x_2: Result<regex::Regex, regex::Error> =
                                    regex::Regex::new(&v44);
                                _v43.set(Some(x_2))
                            }
                            {
                                let v52: Result<regex::Regex, regex::Error> =
                                    getValue(_v43.get().clone());
                                let v54: regex::Regex = v52.unwrap();
                                let v56: std::borrow::Cow<str> = v54.replace_all(&v41, &*v42);
                                let v58: std::string::String = String::from(v56);
                                {
                                    let x_3: string = fable_library_rust::String_::fromString(v58);
                                    _v40.set(Some(x_3))
                                }
                                {
                                    let v68: string = getValue(_v40.get().clone());
                                    let v73: Array<string> = split(
                                        replace(
                                            sprintf!(
                                                "{}{}",
                                                toLower(ofChar(getCharAt(v68.clone(), 0_i32))),
                                                getSlice(v68, Some(1_i32), None::<i32>)
                                            ),
                                            string("\\"),
                                            string("/"),
                                        ),
                                        string("/"),
                                        -1_i32,
                                        0_i32,
                                    );
                                    let v75: i32 = count(v73.clone());
                                    let v76: LrcPtr<Documents::Mut4> =
                                        LrcPtr::new(Documents::Mut4 {
                                            l0: MutCell::new(0_i32),
                                            l1: MutCell::new(0_i32),
                                            l2: MutCell::new(new_empty::<string>()),
                                        });
                                    while Documents::method22(v75, v76.clone()) {
                                        let v78: i32 = v76.l0.get().clone();
                                        let v81: i32 = v78.wrapping_neg() + v75 - 1_i32;
                                        let matchValue: i32 = v76.l1.get().clone();
                                        let v83: Array<string> = v76.l2.get().clone();
                                        let v82: i32 = matchValue;
                                        let v84: string = v73[v81].clone();
                                        let patternInput_1: (i32, Array<string>) = if string("..")
                                            == v84.clone()
                                        {
                                            (v82 + 1_i32, v83.clone())
                                        } else {
                                            if string(".") == v84.clone() {
                                                (v82, v83.clone())
                                            } else {
                                                if 0_i32 == v82 {
                                                    if endsWith(v84.clone(), string(":"), false) {
                                                        let v92: Array<string> =
                                                            new_array(&[sprintf!(
                                                                "{}:",
                                                                getCharAt(v38.clone(), 0_i32)
                                                            )]);
                                                        let v93: i32 = count(v92.clone());
                                                        let v95: i32 = v93 + count(v83.clone());
                                                        let v96: Array<string> =
                                                            new_init(&string(""), v95);
                                                        let v97: LrcPtr<Documents::Mut5> =
                                                            LrcPtr::new(Documents::Mut5 {
                                                                l0: MutCell::new(0_i32),
                                                            });
                                                        while Documents::method23(v95, v97.clone())
                                                        {
                                                            let v99: i32 = v97.l0.get().clone();
                                                            let v104: string = if v99 < v93 {
                                                                v92[v99].clone()
                                                            } else {
                                                                let v102: i32 = v99 - v93;
                                                                v83[v102].clone()
                                                            };
                                                            v96.get_mut()[v99 as usize] = v104;
                                                            {
                                                                let v105: i32 = v99 + 1_i32;
                                                                v97.l0.set(v105);
                                                                ()
                                                            }
                                                        }
                                                        (0_i32, v96.clone())
                                                    } else {
                                                        let v106: Array<string> = new_array(&[v84]);
                                                        let v107: i32 = count(v106.clone());
                                                        let v109: i32 = v107 + count(v83.clone());
                                                        let v110: Array<string> =
                                                            new_init(&string(""), v109);
                                                        let v111: LrcPtr<Documents::Mut5> =
                                                            LrcPtr::new(Documents::Mut5 {
                                                                l0: MutCell::new(0_i32),
                                                            });
                                                        while Documents::method23(
                                                            v109,
                                                            v111.clone(),
                                                        ) {
                                                            let v113: i32 = v111.l0.get().clone();
                                                            let v118: string = if v113 < v107 {
                                                                v106[v113].clone()
                                                            } else {
                                                                let v116: i32 = v113 - v107;
                                                                v83[v116].clone()
                                                            };
                                                            v110.get_mut()[v113 as usize] = v118;
                                                            {
                                                                let v119: i32 = v113 + 1_i32;
                                                                v111.l0.set(v119);
                                                                ()
                                                            }
                                                        }
                                                        (0_i32, v110.clone())
                                                    }
                                                } else {
                                                    (v82 - 1_i32, v83.clone())
                                                }
                                            }
                                        };
                                        let v129: i32 = v78 + 1_i32;
                                        v76.l0.set(v129);
                                        v76.l1.set(patternInput_1.0.clone());
                                        v76.l2.set(patternInput_1.1.clone());
                                        ()
                                    }
                                    {
                                        let matchValue_2: i32 = v76.l1.get().clone();
                                        let v131: Array<string> = v76.l2.get().clone();
                                        let v132: LrcPtr<dyn IEnumerable_1<string>> =
                                            delay(Func0::new({
                                                let v131 = v131.clone();
                                                move || {
                                                    map(
                                                        Func1::new({
                                                            let v131 = v131.clone();
                                                            move |i: i32| v131[i].clone()
                                                        }),
                                                        rangeNumeric(
                                                            0_i32,
                                                            1_i32,
                                                            count(v131.clone()) - 1_i32,
                                                        ),
                                                    )
                                                }
                                            }));
                                        let _v133: MutCell<Option<char>> =
                                            MutCell::new(None::<char>);
                                        {
                                            let x_4: char = std::path::MAIN_SEPARATOR;
                                            _v133.set(Some(x_4))
                                        }
                                        join(
                                            Documents::method24(ofChar(getValue(
                                                _v133.get().clone(),
                                            ))),
                                            toArray(v132),
                                        )
                                    }
                                }
                            }
                        }
                    }
                } else {
                    let v149: Result<std::path::PathBuf, std::io::Error> =
                        std::fs::canonicalize(&*v2);
                    let v151: std::path::PathBuf = v149.unwrap();
                    let v153: std::path::Display = v151.display();
                    let _v154: MutCell<Option<std::string::String>> =
                        MutCell::new(None::<std::string::String>);
                    {
                        let x_5: std::string::String = format!("{}", v153);
                        _v154.set(Some(x_5))
                    }
                    {
                        let v164: std::string::String = getValue(_v154.get().clone());
                        fable_library_rust::String_::fromString(v164)
                    }
                };
                _v1.set(Some(x_6))
            }
            {
                let _v176: MutCell<Option<string>> = MutCell::new(None::<string>);
                let v177: string = Documents::method18(getValue(_v1.get().clone()));
                let v178: string = Documents::method19();
                let _v179: MutCell<Option<Result<regex::Regex, regex::Error>>> =
                    MutCell::new(None::<Result<regex::Regex, regex::Error>>);
                let v180: string = Documents::method20();
                {
                    let x_7: Result<regex::Regex, regex::Error> = regex::Regex::new(&v180);
                    _v179.set(Some(x_7))
                }
                {
                    let v188: Result<regex::Regex, regex::Error> = getValue(_v179.get().clone());
                    let v190: regex::Regex = v188.unwrap();
                    let v192: std::borrow::Cow<str> = v190.replace_all(&v177, &*v178);
                    let v194: std::string::String = String::from(v192);
                    {
                        let x_8: string = fable_library_rust::String_::fromString(v194);
                        _v176.set(Some(x_8))
                    }
                    {
                        let v204: string = getValue(_v176.get().clone());
                        replace(
                            sprintf!(
                                "{}{}",
                                toLower(ofChar(getCharAt(v204.clone(), 0_i32))),
                                getSlice(v204, Some(1_i32), None::<i32>)
                            ),
                            string("\\"),
                            string("/"),
                        )
                    }
                }
            }
        }
        pub fn method36(
            v0_1: Option<CancellationToken>,
            v1_1: string,
            v2: Array<(string, string)>,
            v3: Option<Func1<(bool, string, i32), Arc<Async<()>>>>,
            v4: Option<Func1<std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>, ()>>,
            v5: bool,
            v6: Option<string>,
        ) -> string {
            v1_1
        }
        pub fn method37() -> (string, string) {
            (string(""), string(""))
        }
        pub fn closure24(v0_1: char, v1_1: LrcPtr<Documents::UH0>) -> LrcPtr<Documents::UH0> {
            LrcPtr::new(Documents::UH0::UH0_1(v0_1, v1_1))
        }
        pub fn closure23(
            unitVar: (),
            v0_1: char,
        ) -> Func1<LrcPtr<Documents::UH0>, LrcPtr<Documents::UH0>> {
            Func1::new({
                let v0_1 = v0_1.clone();
                move |v: LrcPtr<Documents::UH0>| Documents::closure24(v0_1, v)
            })
        }
        pub fn method38() -> Func1<char, Func1<LrcPtr<Documents::UH0>, LrcPtr<Documents::UH0>>> {
            Func1::new(move |v: char| Documents::closure23((), v))
        }
        pub fn method39(
            v0_1: string,
            v1_1: string,
            v2: LrcPtr<Documents::UH0>,
            v3: Documents::US7,
        ) -> (string, string) {
            let v0_1: MutCell<string> = MutCell::new(v0_1.clone());
            let v1_1: MutCell<string> = MutCell::new(v1_1.clone());
            let v2: MutCell<LrcPtr<Documents::UH0>> = MutCell::new(v2.clone());
            let v3: MutCell<Documents::US7> = MutCell::new(v3.clone());
            '_method39: loop {
                break '_method39 (if let Documents::UH0::UH0_1(v2_1_0, v2_1_1) =
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
                            let v3_temp: Documents::US7 =
                                Documents::US7::US7_1(Documents::US8::US8_0);
                            v0_1.set(v0_1_temp);
                            v1_1.set(v1_1_temp);
                            v2.set(v2_temp);
                            v3.set(v3_temp);
                            continue '_method39;
                        } else {
                            match &v3.get().clone() {
                                Documents::US7::US7_1(v3_1_0) => {
                                    if let Documents::US8::US8_0 = v3_1_0 {
                                        let v0_1_temp: string = v0_1.get().clone();
                                        let v1_1_temp: string = v1_1.get().clone();
                                        let v2_temp: LrcPtr<Documents::UH0> = v5.clone();
                                        let v3_temp: Documents::US7 =
                                            Documents::US7::US7_1(Documents::US8::US8_1);
                                        v0_1.set(v0_1_temp);
                                        v1_1.set(v1_1_temp);
                                        v2.set(v2_temp);
                                        v3.set(v3_temp);
                                        continue '_method39;
                                    } else {
                                        if ' ' == v4 {
                                            let v0_1_temp: string = v0_1.get().clone();
                                            let v1_1_temp: string = v1_1.get().clone();
                                            let v2_temp: LrcPtr<Documents::UH0> = v5.clone();
                                            let v3_temp: Documents::US7 = Documents::US7::US7_2;
                                            v0_1.set(v0_1_temp);
                                            v1_1.set(v1_1_temp);
                                            v2.set(v2_temp);
                                            v3.set(v3_temp);
                                            continue '_method39;
                                        } else {
                                            let v0_1_temp: string = v0_1.get().clone();
                                            let v1_1_temp: string =
                                                sprintf!("{}{}", v1_1.get().clone(), v4);
                                            let v2_temp: LrcPtr<Documents::UH0> = v5.clone();
                                            let v3_temp: Documents::US7 = v3.get().clone();
                                            v0_1.set(v0_1_temp);
                                            v1_1.set(v1_1_temp);
                                            v2.set(v2_temp);
                                            v3.set(v3_temp);
                                            continue '_method39;
                                        }
                                    }
                                }
                                Documents::US7::US7_0 => {
                                    if ' ' == v4 {
                                        let v0_1_temp: string = v0_1.get().clone();
                                        let v1_1_temp: string = v1_1.get().clone();
                                        let v2_temp: LrcPtr<Documents::UH0> = v5.clone();
                                        let v3_temp: Documents::US7 = Documents::US7::US7_2;
                                        v0_1.set(v0_1_temp);
                                        v1_1.set(v1_1_temp);
                                        v2.set(v2_temp);
                                        v3.set(v3_temp);
                                        continue '_method39;
                                    } else {
                                        let v0_1_temp: string = v0_1.get().clone();
                                        let v1_1_temp: string =
                                            sprintf!("{}{}", v1_1.get().clone(), v4);
                                        let v2_temp: LrcPtr<Documents::UH0> = v5.clone();
                                        let v3_temp: Documents::US7 = v3.get().clone();
                                        v0_1.set(v0_1_temp);
                                        v1_1.set(v1_1_temp);
                                        v2.set(v2_temp);
                                        v3.set(v3_temp);
                                        continue '_method39;
                                    }
                                }
                                _ => {
                                    let v0_1_temp: string =
                                        sprintf!("{}{}", v0_1.get().clone(), v4);
                                    let v1_1_temp: string = v1_1.get().clone();
                                    let v2_temp: LrcPtr<Documents::UH0> = v5.clone();
                                    let v3_temp: Documents::US7 = Documents::US7::US7_2;
                                    v0_1.set(v0_1_temp);
                                    v1_1.set(v1_1_temp);
                                    v2.set(v2_temp);
                                    v3.set(v3_temp);
                                    continue '_method39;
                                }
                            }
                        }
                    } else {
                        if '\'' == v4 {
                            if v1_1.get().clone() == string("") {
                                let v0_1_temp: string = v0_1.get().clone();
                                let v1_1_temp: string = v1_1.get().clone();
                                let v2_temp: LrcPtr<Documents::UH0> = v5.clone();
                                let v3_temp: Documents::US7 =
                                    Documents::US7::US7_1(Documents::US8::US8_0);
                                v0_1.set(v0_1_temp);
                                v1_1.set(v1_1_temp);
                                v2.set(v2_temp);
                                v3.set(v3_temp);
                                continue '_method39;
                            } else {
                                match &v3.get().clone() {
                                    Documents::US7::US7_1(v3_1_0) => {
                                        if let Documents::US8::US8_0 = v3_1_0 {
                                            let v0_1_temp: string = v0_1.get().clone();
                                            let v1_1_temp: string = v1_1.get().clone();
                                            let v2_temp: LrcPtr<Documents::UH0> = v5.clone();
                                            let v3_temp: Documents::US7 =
                                                Documents::US7::US7_1(Documents::US8::US8_1);
                                            v0_1.set(v0_1_temp);
                                            v1_1.set(v1_1_temp);
                                            v2.set(v2_temp);
                                            v3.set(v3_temp);
                                            continue '_method39;
                                        } else {
                                            if ' ' == v4 {
                                                let v0_1_temp: string = v0_1.get().clone();
                                                let v1_1_temp: string = v1_1.get().clone();
                                                let v2_temp: LrcPtr<Documents::UH0> = v5.clone();
                                                let v3_temp: Documents::US7 = Documents::US7::US7_2;
                                                v0_1.set(v0_1_temp);
                                                v1_1.set(v1_1_temp);
                                                v2.set(v2_temp);
                                                v3.set(v3_temp);
                                                continue '_method39;
                                            } else {
                                                let v0_1_temp: string = v0_1.get().clone();
                                                let v1_1_temp: string =
                                                    sprintf!("{}{}", v1_1.get().clone(), v4);
                                                let v2_temp: LrcPtr<Documents::UH0> = v5.clone();
                                                let v3_temp: Documents::US7 = v3.get().clone();
                                                v0_1.set(v0_1_temp);
                                                v1_1.set(v1_1_temp);
                                                v2.set(v2_temp);
                                                v3.set(v3_temp);
                                                continue '_method39;
                                            }
                                        }
                                    }
                                    Documents::US7::US7_0 => {
                                        if ' ' == v4 {
                                            let v0_1_temp: string = v0_1.get().clone();
                                            let v1_1_temp: string = v1_1.get().clone();
                                            let v2_temp: LrcPtr<Documents::UH0> = v5.clone();
                                            let v3_temp: Documents::US7 = Documents::US7::US7_2;
                                            v0_1.set(v0_1_temp);
                                            v1_1.set(v1_1_temp);
                                            v2.set(v2_temp);
                                            v3.set(v3_temp);
                                            continue '_method39;
                                        } else {
                                            let v0_1_temp: string = v0_1.get().clone();
                                            let v1_1_temp: string =
                                                sprintf!("{}{}", v1_1.get().clone(), v4);
                                            let v2_temp: LrcPtr<Documents::UH0> = v5.clone();
                                            let v3_temp: Documents::US7 = v3.get().clone();
                                            v0_1.set(v0_1_temp);
                                            v1_1.set(v1_1_temp);
                                            v2.set(v2_temp);
                                            v3.set(v3_temp);
                                            continue '_method39;
                                        }
                                    }
                                    _ => {
                                        let v0_1_temp: string =
                                            sprintf!("{}{}", v0_1.get().clone(), v4);
                                        let v1_1_temp: string = v1_1.get().clone();
                                        let v2_temp: LrcPtr<Documents::UH0> = v5.clone();
                                        let v3_temp: Documents::US7 = Documents::US7::US7_2;
                                        v0_1.set(v0_1_temp);
                                        v1_1.set(v1_1_temp);
                                        v2.set(v2_temp);
                                        v3.set(v3_temp);
                                        continue '_method39;
                                    }
                                }
                            }
                        } else {
                            match &v3.get().clone() {
                                Documents::US7::US7_1(v3_1_0) => {
                                    if let Documents::US8::US8_0 = v3_1_0 {
                                        if ' ' == v4 {
                                            let v0_1_temp: string = v0_1.get().clone();
                                            let v1_1_temp: string =
                                                sprintf!("{} ", v1_1.get().clone());
                                            let v2_temp: LrcPtr<Documents::UH0> = v5.clone();
                                            let v3_temp: Documents::US7 =
                                                Documents::US7::US7_1(Documents::US8::US8_0);
                                            v0_1.set(v0_1_temp);
                                            v1_1.set(v1_1_temp);
                                            v2.set(v2_temp);
                                            v3.set(v3_temp);
                                            continue '_method39;
                                        } else {
                                            let v0_1_temp: string = v0_1.get().clone();
                                            let v1_1_temp: string =
                                                sprintf!("{}{}", v1_1.get().clone(), v4);
                                            let v2_temp: LrcPtr<Documents::UH0> = v5.clone();
                                            let v3_temp: Documents::US7 = v3.get().clone();
                                            v0_1.set(v0_1_temp);
                                            v1_1.set(v1_1_temp);
                                            v2.set(v2_temp);
                                            v3.set(v3_temp);
                                            continue '_method39;
                                        }
                                    } else {
                                        if ' ' == v4 {
                                            let v0_1_temp: string = v0_1.get().clone();
                                            let v1_1_temp: string = v1_1.get().clone();
                                            let v2_temp: LrcPtr<Documents::UH0> = v5.clone();
                                            let v3_temp: Documents::US7 = Documents::US7::US7_2;
                                            v0_1.set(v0_1_temp);
                                            v1_1.set(v1_1_temp);
                                            v2.set(v2_temp);
                                            v3.set(v3_temp);
                                            continue '_method39;
                                        } else {
                                            let v0_1_temp: string = v0_1.get().clone();
                                            let v1_1_temp: string =
                                                sprintf!("{}{}", v1_1.get().clone(), v4);
                                            let v2_temp: LrcPtr<Documents::UH0> = v5.clone();
                                            let v3_temp: Documents::US7 = v3.get().clone();
                                            v0_1.set(v0_1_temp);
                                            v1_1.set(v1_1_temp);
                                            v2.set(v2_temp);
                                            v3.set(v3_temp);
                                            continue '_method39;
                                        }
                                    }
                                }
                                Documents::US7::US7_0 => {
                                    if ' ' == v4 {
                                        let v0_1_temp: string = v0_1.get().clone();
                                        let v1_1_temp: string = v1_1.get().clone();
                                        let v2_temp: LrcPtr<Documents::UH0> = v5.clone();
                                        let v3_temp: Documents::US7 = Documents::US7::US7_2;
                                        v0_1.set(v0_1_temp);
                                        v1_1.set(v1_1_temp);
                                        v2.set(v2_temp);
                                        v3.set(v3_temp);
                                        continue '_method39;
                                    } else {
                                        let v0_1_temp: string = v0_1.get().clone();
                                        let v1_1_temp: string =
                                            sprintf!("{}{}", v1_1.get().clone(), v4);
                                        let v2_temp: LrcPtr<Documents::UH0> = v5;
                                        let v3_temp: Documents::US7 = v3.get().clone();
                                        v0_1.set(v0_1_temp);
                                        v1_1.set(v1_1_temp);
                                        v2.set(v2_temp);
                                        v3.set(v3_temp);
                                        continue '_method39;
                                    }
                                }
                                _ => {
                                    let v0_1_temp: string =
                                        sprintf!("{}{}", v0_1.get().clone(), v4);
                                    let v1_1_temp: string = v1_1.get().clone();
                                    let v2_temp: LrcPtr<Documents::UH0> = v5.clone();
                                    let v3_temp: Documents::US7 = Documents::US7::US7_2;
                                    v0_1.set(v0_1_temp);
                                    v1_1.set(v1_1_temp);
                                    v2.set(v2_temp);
                                    v3.set(v3_temp);
                                    continue '_method39;
                                }
                            }
                        }
                    }
                } else {
                    match &v3.get().clone() {
                        Documents::US7::US7_1(v3_1_0) => {
                            if let Documents::US8::US8_0 = v3_1_0 {
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
                        Documents::US7::US7_0 => (
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
        pub fn method43(
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
                    Documents::method43(
                        match v0_1.as_ref() {
                            Documents::UH1::UH1_1(_, x) => x.clone(),
                            _ => unreachable!(),
                        },
                        v1_1.clone(),
                    ),
                )),
            }
        }
        pub fn method42(
            v0_1: string,
            v1_1: LrcPtr<Documents::UH1>,
            v2: LrcPtr<Documents::UH0>,
            v3: Documents::US9,
        ) -> (LrcPtr<Documents::UH1>, string) {
            let v0_1: MutCell<string> = MutCell::new(v0_1.clone());
            let v1_1: MutCell<LrcPtr<Documents::UH1>> = MutCell::new(v1_1.clone());
            let v2: MutCell<LrcPtr<Documents::UH0>> = MutCell::new(v2.clone());
            let v3: MutCell<Documents::US9> = MutCell::new(v3.clone());
            '_method42: loop {
                break '_method42 (match &v3.get().clone() {
                    Documents::US9::US9_1(v3_1_0) => {
                        let v259: char = v3_1_0.clone();
                        if '\"' == v259 {
                            if let Documents::UH0::UH0_1(v2_1_0, v2_1_1) = v2.get().clone().as_ref()
                            {
                                let v262: LrcPtr<Documents::UH0> = match v2.get().clone().as_ref() {
                                    Documents::UH0::UH0_1(_, x) => x.clone(),
                                    _ => unreachable!(),
                                };
                                let v261: char = match v2.get().clone().as_ref() {
                                    Documents::UH0::UH0_1(x, _) => x.clone(),
                                    _ => unreachable!(),
                                };
                                if '\"' == v261 {
                                    Documents::method41(
                                        v0_1.get().clone(),
                                        v1_1.get().clone(),
                                        v262.clone(),
                                        v3.get().clone(),
                                        Documents::US9::US9_0,
                                    )
                                } else {
                                    if '\\' == v259 {
                                        if '\\' == v261 {
                                            Documents::method41(
                                                v0_1.get().clone(),
                                                v1_1.get().clone(),
                                                v262.clone(),
                                                v3.get().clone(),
                                                Documents::US9::US9_2(0_u8, v261),
                                            )
                                        } else {
                                            if '`' == v261 {
                                                Documents::method41(
                                                    v0_1.get().clone(),
                                                    v1_1.get().clone(),
                                                    v262.clone(),
                                                    v3.get().clone(),
                                                    Documents::US9::US9_2(0_u8, v261),
                                                )
                                            } else {
                                                if ' ' == v261 {
                                                    let v0_1_temp: string =
                                                        sprintf!("{} ", v0_1.get().clone());
                                                    let v1_1_temp: LrcPtr<Documents::UH1> =
                                                        v1_1.get().clone();
                                                    let v2_temp: LrcPtr<Documents::UH0> =
                                                        v262.clone();
                                                    let v3_temp: Documents::US9 = v3.get().clone();
                                                    v0_1.set(v0_1_temp);
                                                    v1_1.set(v1_1_temp);
                                                    v2.set(v2_temp);
                                                    v3.set(v3_temp);
                                                    continue '_method42;
                                                } else {
                                                    let v0_1_temp: string =
                                                        sprintf!("{}{}", v0_1.get().clone(), v261);
                                                    let v1_1_temp: LrcPtr<Documents::UH1> =
                                                        v1_1.get().clone();
                                                    let v2_temp: LrcPtr<Documents::UH0> =
                                                        v262.clone();
                                                    let v3_temp: Documents::US9 = v3.get().clone();
                                                    v0_1.set(v0_1_temp);
                                                    v1_1.set(v1_1_temp);
                                                    v2.set(v2_temp);
                                                    v3.set(v3_temp);
                                                    continue '_method42;
                                                }
                                            }
                                        }
                                    } else {
                                        if '`' == v259 {
                                            if '\\' == v261 {
                                                Documents::method41(
                                                    v0_1.get().clone(),
                                                    v1_1.get().clone(),
                                                    v262.clone(),
                                                    v3.get().clone(),
                                                    Documents::US9::US9_2(0_u8, v261),
                                                )
                                            } else {
                                                if '`' == v261 {
                                                    Documents::method41(
                                                        v0_1.get().clone(),
                                                        v1_1.get().clone(),
                                                        v262.clone(),
                                                        v3.get().clone(),
                                                        Documents::US9::US9_2(0_u8, v261),
                                                    )
                                                } else {
                                                    if ' ' == v261 {
                                                        let v0_1_temp: string =
                                                            sprintf!("{} ", v0_1.get().clone());
                                                        let v1_1_temp: LrcPtr<Documents::UH1> =
                                                            v1_1.get().clone();
                                                        let v2_temp: LrcPtr<Documents::UH0> =
                                                            v262.clone();
                                                        let v3_temp: Documents::US9 =
                                                            v3.get().clone();
                                                        v0_1.set(v0_1_temp);
                                                        v1_1.set(v1_1_temp);
                                                        v2.set(v2_temp);
                                                        v3.set(v3_temp);
                                                        continue '_method42;
                                                    } else {
                                                        let v0_1_temp: string = sprintf!(
                                                            "{}{}",
                                                            v0_1.get().clone(),
                                                            v261
                                                        );
                                                        let v1_1_temp: LrcPtr<Documents::UH1> =
                                                            v1_1.get().clone();
                                                        let v2_temp: LrcPtr<Documents::UH0> = v262;
                                                        let v3_temp: Documents::US9 =
                                                            v3.get().clone();
                                                        v0_1.set(v0_1_temp);
                                                        v1_1.set(v1_1_temp);
                                                        v2.set(v2_temp);
                                                        v3.set(v3_temp);
                                                        continue '_method42;
                                                    }
                                                }
                                            }
                                        } else {
                                            if '\\' == v261 {
                                                Documents::method41(
                                                    v0_1.get().clone(),
                                                    v1_1.get().clone(),
                                                    v262.clone(),
                                                    v3.get().clone(),
                                                    Documents::US9::US9_2(0_u8, v261),
                                                )
                                            } else {
                                                if '`' == v261 {
                                                    Documents::method41(
                                                        v0_1.get().clone(),
                                                        v1_1.get().clone(),
                                                        v262.clone(),
                                                        v3.get().clone(),
                                                        Documents::US9::US9_2(0_u8, v261),
                                                    )
                                                } else {
                                                    if ' ' == v261 {
                                                        let v0_1_temp: string =
                                                            sprintf!("{} ", v0_1.get().clone());
                                                        let v1_1_temp: LrcPtr<Documents::UH1> =
                                                            v1_1.get().clone();
                                                        let v2_temp: LrcPtr<Documents::UH0> =
                                                            v262.clone();
                                                        let v3_temp: Documents::US9 =
                                                            v3.get().clone();
                                                        v0_1.set(v0_1_temp);
                                                        v1_1.set(v1_1_temp);
                                                        v2.set(v2_temp);
                                                        v3.set(v3_temp);
                                                        continue '_method42;
                                                    } else {
                                                        let v0_1_temp: string = sprintf!(
                                                            "{}{}",
                                                            v0_1.get().clone(),
                                                            v261
                                                        );
                                                        let v1_1_temp: LrcPtr<Documents::UH1> =
                                                            v1_1.get().clone();
                                                        let v2_temp: LrcPtr<Documents::UH0> =
                                                            v262.clone();
                                                        let v3_temp: Documents::US9 =
                                                            v3.get().clone();
                                                        v0_1.set(v0_1_temp);
                                                        v1_1.set(v1_1_temp);
                                                        v2.set(v2_temp);
                                                        v3.set(v3_temp);
                                                        continue '_method42;
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            } else {
                                if '\\' == v259 {
                                    (
                                        if v0_1.get().clone() == string("") {
                                            v1_1.get().clone()
                                        } else {
                                            Documents::method43(
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
                                    if '`' == v259 {
                                        (
                                            if v0_1.get().clone() == string("") {
                                                v1_1.get().clone()
                                            } else {
                                                Documents::method43(
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
                                                Documents::method43(
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
                        } else {
                            if '\\' == v259 {
                                if let Documents::UH0::UH0_1(v2_1_0, v2_1_1) =
                                    v2.get().clone().as_ref()
                                {
                                    let v372: LrcPtr<Documents::UH0> =
                                        match v2.get().clone().as_ref() {
                                            Documents::UH0::UH0_1(_, x) => x.clone(),
                                            _ => unreachable!(),
                                        };
                                    let v371: char = match v2.get().clone().as_ref() {
                                        Documents::UH0::UH0_1(x, _) => x.clone(),
                                        _ => unreachable!(),
                                    };
                                    if '\"' == v371 {
                                        if if !(v3.get().clone()
                                            == Documents::US9::US9_2(0_u8, '\\'))
                                        {
                                            !(v3.get().clone() == Documents::US9::US9_2(0_u8, '`'))
                                        } else {
                                            false
                                        } {
                                            Documents::method41(
                                                sprintf!("{}{}\"", v0_1.get().clone(), v259),
                                                v1_1.get().clone(),
                                                v372.clone(),
                                                v3.get().clone(),
                                                Documents::US9::US9_1('\"'),
                                            )
                                        } else {
                                            Documents::method41(
                                                sprintf!("{}{}\"", v0_1.get().clone(), v259),
                                                v1_1.get().clone(),
                                                v372.clone(),
                                                v3.get().clone(),
                                                Documents::US9::US9_1('\"'),
                                            )
                                        }
                                    } else {
                                        if '\\' == v371 {
                                            Documents::method41(
                                                v0_1.get().clone(),
                                                v1_1.get().clone(),
                                                v372.clone(),
                                                v3.get().clone(),
                                                Documents::US9::US9_2(0_u8, v371),
                                            )
                                        } else {
                                            if '`' == v371 {
                                                Documents::method41(
                                                    v0_1.get().clone(),
                                                    v1_1.get().clone(),
                                                    v372.clone(),
                                                    v3.get().clone(),
                                                    Documents::US9::US9_2(0_u8, v371),
                                                )
                                            } else {
                                                if ' ' == v371 {
                                                    let v0_1_temp: string =
                                                        sprintf!("{} ", v0_1.get().clone());
                                                    let v1_1_temp: LrcPtr<Documents::UH1> =
                                                        v1_1.get().clone();
                                                    let v2_temp: LrcPtr<Documents::UH0> = v372;
                                                    let v3_temp: Documents::US9 = v3.get().clone();
                                                    v0_1.set(v0_1_temp);
                                                    v1_1.set(v1_1_temp);
                                                    v2.set(v2_temp);
                                                    v3.set(v3_temp);
                                                    continue '_method42;
                                                } else {
                                                    let v0_1_temp: string =
                                                        sprintf!("{}{}", v0_1.get().clone(), v371);
                                                    let v1_1_temp: LrcPtr<Documents::UH1> =
                                                        v1_1.get().clone();
                                                    let v2_temp: LrcPtr<Documents::UH0> =
                                                        v372.clone();
                                                    let v3_temp: Documents::US9 = v3.get().clone();
                                                    v0_1.set(v0_1_temp);
                                                    v1_1.set(v1_1_temp);
                                                    v2.set(v2_temp);
                                                    v3.set(v3_temp);
                                                    continue '_method42;
                                                }
                                            }
                                        }
                                    }
                                } else {
                                    (
                                        if v0_1.get().clone() == string("") {
                                            v1_1.get().clone()
                                        } else {
                                            Documents::method43(
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
                                if '`' == v259 {
                                    if let Documents::UH0::UH0_1(v2_1_0, v2_1_1) =
                                        v2.get().clone().as_ref()
                                    {
                                        let v426: LrcPtr<Documents::UH0> =
                                            match v2.get().clone().as_ref() {
                                                Documents::UH0::UH0_1(_, x) => x.clone(),
                                                _ => unreachable!(),
                                            };
                                        let v425: char = match v2.get().clone().as_ref() {
                                            Documents::UH0::UH0_1(x, _) => x.clone(),
                                            _ => unreachable!(),
                                        };
                                        if '\"' == v425 {
                                            if if !(v3.get().clone()
                                                == Documents::US9::US9_2(0_u8, '\\'))
                                            {
                                                !(v3.get().clone()
                                                    == Documents::US9::US9_2(0_u8, '`'))
                                            } else {
                                                false
                                            } {
                                                Documents::method41(
                                                    sprintf!("{}{}\"", v0_1.get().clone(), v259),
                                                    v1_1.get().clone(),
                                                    v426.clone(),
                                                    v3.get().clone(),
                                                    Documents::US9::US9_1('\"'),
                                                )
                                            } else {
                                                Documents::method41(
                                                    sprintf!("{}{}\"", v0_1.get().clone(), v259),
                                                    v1_1.get().clone(),
                                                    v426.clone(),
                                                    v3.get().clone(),
                                                    Documents::US9::US9_1('\"'),
                                                )
                                            }
                                        } else {
                                            if '\\' == v425 {
                                                Documents::method41(
                                                    v0_1.get().clone(),
                                                    v1_1.get().clone(),
                                                    v426.clone(),
                                                    v3.get().clone(),
                                                    Documents::US9::US9_2(0_u8, v425),
                                                )
                                            } else {
                                                if '`' == v425 {
                                                    Documents::method41(
                                                        v0_1.get().clone(),
                                                        v1_1.get().clone(),
                                                        v426.clone(),
                                                        v3.get().clone(),
                                                        Documents::US9::US9_2(0_u8, v425),
                                                    )
                                                } else {
                                                    if ' ' == v425 {
                                                        let v0_1_temp: string =
                                                            sprintf!("{} ", v0_1.get().clone());
                                                        let v1_1_temp: LrcPtr<Documents::UH1> =
                                                            v1_1.get().clone();
                                                        let v2_temp: LrcPtr<Documents::UH0> = v426;
                                                        let v3_temp: Documents::US9 =
                                                            v3.get().clone();
                                                        v0_1.set(v0_1_temp);
                                                        v1_1.set(v1_1_temp);
                                                        v2.set(v2_temp);
                                                        v3.set(v3_temp);
                                                        continue '_method42;
                                                    } else {
                                                        let v0_1_temp: string = sprintf!(
                                                            "{}{}",
                                                            v0_1.get().clone(),
                                                            v425
                                                        );
                                                        let v1_1_temp: LrcPtr<Documents::UH1> =
                                                            v1_1.get().clone();
                                                        let v2_temp: LrcPtr<Documents::UH0> =
                                                            v426.clone();
                                                        let v3_temp: Documents::US9 =
                                                            v3.get().clone();
                                                        v0_1.set(v0_1_temp);
                                                        v1_1.set(v1_1_temp);
                                                        v2.set(v2_temp);
                                                        v3.set(v3_temp);
                                                        continue '_method42;
                                                    }
                                                }
                                            }
                                        }
                                    } else {
                                        (
                                            if v0_1.get().clone() == string("") {
                                                v1_1.get().clone()
                                            } else {
                                                Documents::method43(
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
                                        let v479: LrcPtr<Documents::UH0> =
                                            match v2.get().clone().as_ref() {
                                                Documents::UH0::UH0_1(_, x) => x.clone(),
                                                _ => unreachable!(),
                                            };
                                        let v478: char = match v2.get().clone().as_ref() {
                                            Documents::UH0::UH0_1(x, _) => x.clone(),
                                            _ => unreachable!(),
                                        };
                                        if '\\' == v478 {
                                            Documents::method41(
                                                v0_1.get().clone(),
                                                v1_1.get().clone(),
                                                v479.clone(),
                                                v3.get().clone(),
                                                Documents::US9::US9_2(0_u8, v478),
                                            )
                                        } else {
                                            if '`' == v478 {
                                                Documents::method41(
                                                    v0_1.get().clone(),
                                                    v1_1.get().clone(),
                                                    v479.clone(),
                                                    v3.get().clone(),
                                                    Documents::US9::US9_2(0_u8, v478),
                                                )
                                            } else {
                                                if '\"' == v478 {
                                                    Documents::method41(
                                                        string(""),
                                                        Documents::method43(
                                                            v1_1.get().clone(),
                                                            LrcPtr::new(Documents::UH1::UH1_1(
                                                                v0_1.get().clone(),
                                                                LrcPtr::new(Documents::UH1::UH1_0),
                                                            )),
                                                        ),
                                                        v479.clone(),
                                                        v3.get().clone(),
                                                        Documents::US9::US9_0,
                                                    )
                                                } else {
                                                    if ' ' == v478 {
                                                        let v0_1_temp: string =
                                                            sprintf!("{} ", v0_1.get().clone());
                                                        let v1_1_temp: LrcPtr<Documents::UH1> =
                                                            v1_1.get().clone();
                                                        let v2_temp: LrcPtr<Documents::UH0> = v479;
                                                        let v3_temp: Documents::US9 =
                                                            v3.get().clone();
                                                        v0_1.set(v0_1_temp);
                                                        v1_1.set(v1_1_temp);
                                                        v2.set(v2_temp);
                                                        v3.set(v3_temp);
                                                        continue '_method42;
                                                    } else {
                                                        let v0_1_temp: string = sprintf!(
                                                            "{}{}",
                                                            v0_1.get().clone(),
                                                            v478
                                                        );
                                                        let v1_1_temp: LrcPtr<Documents::UH1> =
                                                            v1_1.get().clone();
                                                        let v2_temp: LrcPtr<Documents::UH0> =
                                                            v479.clone();
                                                        let v3_temp: Documents::US9 =
                                                            v3.get().clone();
                                                        v0_1.set(v0_1_temp);
                                                        v1_1.set(v1_1_temp);
                                                        v2.set(v2_temp);
                                                        v3.set(v3_temp);
                                                        continue '_method42;
                                                    }
                                                }
                                            }
                                        }
                                    } else {
                                        (
                                            if v0_1.get().clone() == string("") {
                                                v1_1.get().clone()
                                            } else {
                                                Documents::method43(
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
                    }
                    Documents::US9::US9_0 => {
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
                                Documents::method41(
                                    string(""),
                                    v1_1.get().clone(),
                                    v5.clone(),
                                    v3.get().clone(),
                                    Documents::US9::US9_1('\"'),
                                )
                            } else {
                                if '\\' == v4 {
                                    Documents::method41(
                                        v0_1.get().clone(),
                                        v1_1.get().clone(),
                                        v5.clone(),
                                        v3.get().clone(),
                                        Documents::US9::US9_2(0_u8, v4),
                                    )
                                } else {
                                    if '`' == v4 {
                                        Documents::method41(
                                            v0_1.get().clone(),
                                            v1_1.get().clone(),
                                            v5.clone(),
                                            v3.get().clone(),
                                            Documents::US9::US9_2(0_u8, v4),
                                        )
                                    } else {
                                        if ' ' == v4 {
                                            let v0_1_temp: string = string("");
                                            let v1_1_temp: LrcPtr<Documents::UH1> =
                                                if v0_1.get().clone() == string("") {
                                                    v1_1.get().clone()
                                                } else {
                                                    Documents::method43(
                                                        v1_1.get().clone(),
                                                        LrcPtr::new(Documents::UH1::UH1_1(
                                                            v0_1.get().clone(),
                                                            LrcPtr::new(Documents::UH1::UH1_0),
                                                        )),
                                                    )
                                                };
                                            let v2_temp: LrcPtr<Documents::UH0> = v5;
                                            let v3_temp: Documents::US9 = v3.get().clone();
                                            v0_1.set(v0_1_temp);
                                            v1_1.set(v1_1_temp);
                                            v2.set(v2_temp);
                                            v3.set(v3_temp);
                                            continue '_method42;
                                        } else {
                                            let v0_1_temp: string =
                                                sprintf!("{}{}", v0_1.get().clone(), v4);
                                            let v1_1_temp: LrcPtr<Documents::UH1> =
                                                v1_1.get().clone();
                                            let v2_temp: LrcPtr<Documents::UH0> = v5.clone();
                                            let v3_temp: Documents::US9 = v3.get().clone();
                                            v0_1.set(v0_1_temp);
                                            v1_1.set(v1_1_temp);
                                            v2.set(v2_temp);
                                            v3.set(v3_temp);
                                            continue '_method42;
                                        }
                                    }
                                }
                            }
                        } else {
                            (
                                if v0_1.get().clone() == string("") {
                                    v1_1.get().clone()
                                } else {
                                    Documents::method43(
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
                    Documents::US9::US9_2(v3_2_0, v3_2_1) => {
                        let v52: char = match &v3.get().clone() {
                            Documents::US9::US9_2(_, x) => x.clone(),
                            _ => unreachable!(),
                        };
                        let v51: u8 = match &v3.get().clone() {
                            Documents::US9::US9_2(x, _) => x.clone(),
                            _ => unreachable!(),
                        };
                        if let Documents::UH0::UH0_1(v2_1_0, v2_1_1) = v2.get().clone().as_ref() {
                            let v54: LrcPtr<Documents::UH0> = match v2.get().clone().as_ref() {
                                Documents::UH0::UH0_1(_, x) => x.clone(),
                                _ => unreachable!(),
                            };
                            let v53: char = match v2.get().clone().as_ref() {
                                Documents::UH0::UH0_1(x, _) => x.clone(),
                                _ => unreachable!(),
                            };
                            if '\\' == v53 {
                                Documents::method41(
                                    v0_1.get().clone(),
                                    v1_1.get().clone(),
                                    v54.clone(),
                                    v3.get().clone(),
                                    Documents::US9::US9_1(v53),
                                )
                            } else {
                                if '`' == v53 {
                                    Documents::method41(
                                        v0_1.get().clone(),
                                        v1_1.get().clone(),
                                        v54.clone(),
                                        v3.get().clone(),
                                        Documents::US9::US9_1(v53),
                                    )
                                } else {
                                    if 0_u8 == v51 {
                                        if '\\' == v52 {
                                            if '\"' == v53 {
                                                Documents::method41(
                                                    sprintf!("{}{}\"", v0_1.get().clone(), v52),
                                                    v1_1.get().clone(),
                                                    v54.clone(),
                                                    v3.get().clone(),
                                                    Documents::US9::US9_2(v51, v52),
                                                )
                                            } else {
                                                if ' ' == v53 {
                                                    let v0_1_temp: string =
                                                        sprintf!("{} ", v0_1.get().clone());
                                                    let v1_1_temp: LrcPtr<Documents::UH1> =
                                                        v1_1.get().clone();
                                                    let v2_temp: LrcPtr<Documents::UH0> =
                                                        v54.clone();
                                                    let v3_temp: Documents::US9 = v3.get().clone();
                                                    v0_1.set(v0_1_temp);
                                                    v1_1.set(v1_1_temp);
                                                    v2.set(v2_temp);
                                                    v3.set(v3_temp);
                                                    continue '_method42;
                                                } else {
                                                    if 1_u8 == v51 {
                                                        if !(v3.get().clone() == v3.get().clone()) {
                                                            let v0_1_temp: string = sprintf!(
                                                                "{}\\{}",
                                                                v0_1.get().clone(),
                                                                v53
                                                            );
                                                            let v1_1_temp: LrcPtr<Documents::UH1> =
                                                                v1_1.get().clone();
                                                            let v2_temp: LrcPtr<Documents::UH0> =
                                                                v54.clone();
                                                            let v3_temp: Documents::US9 =
                                                                v3.get().clone();
                                                            v0_1.set(v0_1_temp);
                                                            v1_1.set(v1_1_temp);
                                                            v2.set(v2_temp);
                                                            v3.set(v3_temp);
                                                            continue '_method42;
                                                        } else {
                                                            let v0_1_temp: string = sprintf!(
                                                                "{}{}",
                                                                v0_1.get().clone(),
                                                                v53
                                                            );
                                                            let v1_1_temp: LrcPtr<Documents::UH1> =
                                                                v1_1.get().clone();
                                                            let v2_temp: LrcPtr<Documents::UH0> =
                                                                v54.clone();
                                                            let v3_temp: Documents::US9 =
                                                                v3.get().clone();
                                                            v0_1.set(v0_1_temp);
                                                            v1_1.set(v1_1_temp);
                                                            v2.set(v2_temp);
                                                            v3.set(v3_temp);
                                                            continue '_method42;
                                                        }
                                                    } else {
                                                        let v0_1_temp: string = sprintf!(
                                                            "{}{}",
                                                            v0_1.get().clone(),
                                                            v53
                                                        );
                                                        let v1_1_temp: LrcPtr<Documents::UH1> =
                                                            v1_1.get().clone();
                                                        let v2_temp: LrcPtr<Documents::UH0> =
                                                            v54.clone();
                                                        let v3_temp: Documents::US9 =
                                                            v3.get().clone();
                                                        v0_1.set(v0_1_temp);
                                                        v1_1.set(v1_1_temp);
                                                        v2.set(v2_temp);
                                                        v3.set(v3_temp);
                                                        continue '_method42;
                                                    }
                                                }
                                            }
                                        } else {
                                            if '`' == v52 {
                                                if '\"' == v53 {
                                                    Documents::method41(
                                                        sprintf!("{}{}\"", v0_1.get().clone(), v52),
                                                        v1_1.get().clone(),
                                                        v54.clone(),
                                                        v3.get().clone(),
                                                        Documents::US9::US9_2(v51, v52),
                                                    )
                                                } else {
                                                    if ' ' == v53 {
                                                        let v0_1_temp: string =
                                                            sprintf!("{} ", v0_1.get().clone());
                                                        let v1_1_temp: LrcPtr<Documents::UH1> =
                                                            v1_1.get().clone();
                                                        let v2_temp: LrcPtr<Documents::UH0> =
                                                            v54.clone();
                                                        let v3_temp: Documents::US9 =
                                                            v3.get().clone();
                                                        v0_1.set(v0_1_temp);
                                                        v1_1.set(v1_1_temp);
                                                        v2.set(v2_temp);
                                                        v3.set(v3_temp);
                                                        continue '_method42;
                                                    } else {
                                                        if 1_u8 == v51 {
                                                            if !(v3.get().clone()
                                                                == v3.get().clone())
                                                            {
                                                                let v0_1_temp: string = sprintf!(
                                                                    "{}\\{}",
                                                                    v0_1.get().clone(),
                                                                    v53
                                                                );
                                                                let v1_1_temp: LrcPtr<
                                                                    Documents::UH1,
                                                                > = v1_1.get().clone();
                                                                let v2_temp: LrcPtr<
                                                                    Documents::UH0,
                                                                > = v54.clone();
                                                                let v3_temp: Documents::US9 =
                                                                    v3.get().clone();
                                                                v0_1.set(v0_1_temp);
                                                                v1_1.set(v1_1_temp);
                                                                v2.set(v2_temp);
                                                                v3.set(v3_temp);
                                                                continue '_method42;
                                                            } else {
                                                                let v0_1_temp: string = sprintf!(
                                                                    "{}{}",
                                                                    v0_1.get().clone(),
                                                                    v53
                                                                );
                                                                let v1_1_temp: LrcPtr<
                                                                    Documents::UH1,
                                                                > = v1_1.get().clone();
                                                                let v2_temp: LrcPtr<
                                                                    Documents::UH0,
                                                                > = v54.clone();
                                                                let v3_temp: Documents::US9 =
                                                                    v3.get().clone();
                                                                v0_1.set(v0_1_temp);
                                                                v1_1.set(v1_1_temp);
                                                                v2.set(v2_temp);
                                                                v3.set(v3_temp);
                                                                continue '_method42;
                                                            }
                                                        } else {
                                                            let v0_1_temp: string = sprintf!(
                                                                "{}{}",
                                                                v0_1.get().clone(),
                                                                v53
                                                            );
                                                            let v1_1_temp: LrcPtr<Documents::UH1> =
                                                                v1_1.get().clone();
                                                            let v2_temp: LrcPtr<Documents::UH0> =
                                                                v54.clone();
                                                            let v3_temp: Documents::US9 =
                                                                v3.get().clone();
                                                            v0_1.set(v0_1_temp);
                                                            v1_1.set(v1_1_temp);
                                                            v2.set(v2_temp);
                                                            v3.set(v3_temp);
                                                            continue '_method42;
                                                        }
                                                    }
                                                }
                                            } else {
                                                if '\"' == v53 {
                                                    Documents::method41(
                                                        sprintf!("{}{}\"", v0_1.get().clone(), v52),
                                                        v1_1.get().clone(),
                                                        v54.clone(),
                                                        v3.get().clone(),
                                                        Documents::US9::US9_2(v51, v52),
                                                    )
                                                } else {
                                                    if ' ' == v53 {
                                                        let v0_1_temp: string =
                                                            sprintf!("{} ", v0_1.get().clone());
                                                        let v1_1_temp: LrcPtr<Documents::UH1> =
                                                            v1_1.get().clone();
                                                        let v2_temp: LrcPtr<Documents::UH0> =
                                                            v54.clone();
                                                        let v3_temp: Documents::US9 =
                                                            v3.get().clone();
                                                        v0_1.set(v0_1_temp);
                                                        v1_1.set(v1_1_temp);
                                                        v2.set(v2_temp);
                                                        v3.set(v3_temp);
                                                        continue '_method42;
                                                    } else {
                                                        if 1_u8 == v51 {
                                                            if !(v3.get().clone()
                                                                == v3.get().clone())
                                                            {
                                                                let v0_1_temp: string = sprintf!(
                                                                    "{}\\{}",
                                                                    v0_1.get().clone(),
                                                                    v53
                                                                );
                                                                let v1_1_temp: LrcPtr<
                                                                    Documents::UH1,
                                                                > = v1_1.get().clone();
                                                                let v2_temp: LrcPtr<
                                                                    Documents::UH0,
                                                                > = v54.clone();
                                                                let v3_temp: Documents::US9 =
                                                                    v3.get().clone();
                                                                v0_1.set(v0_1_temp);
                                                                v1_1.set(v1_1_temp);
                                                                v2.set(v2_temp);
                                                                v3.set(v3_temp);
                                                                continue '_method42;
                                                            } else {
                                                                let v0_1_temp: string = sprintf!(
                                                                    "{}{}",
                                                                    v0_1.get().clone(),
                                                                    v53
                                                                );
                                                                let v1_1_temp: LrcPtr<
                                                                    Documents::UH1,
                                                                > = v1_1.get().clone();
                                                                let v2_temp: LrcPtr<
                                                                    Documents::UH0,
                                                                > = v54.clone();
                                                                let v3_temp: Documents::US9 =
                                                                    v3.get().clone();
                                                                v0_1.set(v0_1_temp);
                                                                v1_1.set(v1_1_temp);
                                                                v2.set(v2_temp);
                                                                v3.set(v3_temp);
                                                                continue '_method42;
                                                            }
                                                        } else {
                                                            let v0_1_temp: string = sprintf!(
                                                                "{}{}",
                                                                v0_1.get().clone(),
                                                                v53
                                                            );
                                                            let v1_1_temp: LrcPtr<Documents::UH1> =
                                                                v1_1.get().clone();
                                                            let v2_temp: LrcPtr<Documents::UH0> =
                                                                v54.clone();
                                                            let v3_temp: Documents::US9 =
                                                                v3.get().clone();
                                                            v0_1.set(v0_1_temp);
                                                            v1_1.set(v1_1_temp);
                                                            v2.set(v2_temp);
                                                            v3.set(v3_temp);
                                                            continue '_method42;
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    } else {
                                        if '\"' == v53 {
                                            Documents::method41(
                                                sprintf!("{}{}\"", v0_1.get().clone(), v52),
                                                v1_1.get().clone(),
                                                v54.clone(),
                                                v3.get().clone(),
                                                Documents::US9::US9_2(v51, v52),
                                            )
                                        } else {
                                            if ' ' == v53 {
                                                let v0_1_temp: string =
                                                    sprintf!("{} ", v0_1.get().clone());
                                                let v1_1_temp: LrcPtr<Documents::UH1> =
                                                    v1_1.get().clone();
                                                let v2_temp: LrcPtr<Documents::UH0> = v54.clone();
                                                let v3_temp: Documents::US9 = v3.get().clone();
                                                v0_1.set(v0_1_temp);
                                                v1_1.set(v1_1_temp);
                                                v2.set(v2_temp);
                                                v3.set(v3_temp);
                                                continue '_method42;
                                            } else {
                                                if 1_u8 == v51 {
                                                    if !(v3.get().clone() == v3.get().clone()) {
                                                        let v0_1_temp: string = sprintf!(
                                                            "{}\\{}",
                                                            v0_1.get().clone(),
                                                            v53
                                                        );
                                                        let v1_1_temp: LrcPtr<Documents::UH1> =
                                                            v1_1.get().clone();
                                                        let v2_temp: LrcPtr<Documents::UH0> =
                                                            v54.clone();
                                                        let v3_temp: Documents::US9 =
                                                            v3.get().clone();
                                                        v0_1.set(v0_1_temp);
                                                        v1_1.set(v1_1_temp);
                                                        v2.set(v2_temp);
                                                        v3.set(v3_temp);
                                                        continue '_method42;
                                                    } else {
                                                        let v0_1_temp: string = sprintf!(
                                                            "{}{}",
                                                            v0_1.get().clone(),
                                                            v53
                                                        );
                                                        let v1_1_temp: LrcPtr<Documents::UH1> =
                                                            v1_1.get().clone();
                                                        let v2_temp: LrcPtr<Documents::UH0> =
                                                            v54.clone();
                                                        let v3_temp: Documents::US9 =
                                                            v3.get().clone();
                                                        v0_1.set(v0_1_temp);
                                                        v1_1.set(v1_1_temp);
                                                        v2.set(v2_temp);
                                                        v3.set(v3_temp);
                                                        continue '_method42;
                                                    }
                                                } else {
                                                    let v0_1_temp: string =
                                                        sprintf!("{}{}", v0_1.get().clone(), v53);
                                                    let v1_1_temp: LrcPtr<Documents::UH1> =
                                                        v1_1.get().clone();
                                                    let v2_temp: LrcPtr<Documents::UH0> =
                                                        v54.clone();
                                                    let v3_temp: Documents::US9 = v3.get().clone();
                                                    v0_1.set(v0_1_temp);
                                                    v1_1.set(v1_1_temp);
                                                    v2.set(v2_temp);
                                                    v3.set(v3_temp);
                                                    continue '_method42;
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        } else {
                            if 0_u8 == v51 {
                                if '\\' == v52 {
                                    if 1_u8 == v51 {
                                        (
                                            if v0_1.get().clone() == string("") {
                                                v1_1.get().clone()
                                            } else {
                                                Documents::method43(
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
                                                Documents::method43(
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
                                    if '`' == v52 {
                                        if 1_u8 == v51 {
                                            (
                                                if v0_1.get().clone() == string("") {
                                                    v1_1.get().clone()
                                                } else {
                                                    Documents::method43(
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
                                                    Documents::method43(
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
                                        if 1_u8 == v51 {
                                            (
                                                if v0_1.get().clone() == string("") {
                                                    v1_1.get().clone()
                                                } else {
                                                    Documents::method43(
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
                                                    Documents::method43(
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
                            } else {
                                if 1_u8 == v51 {
                                    (
                                        if v0_1.get().clone() == string("") {
                                            v1_1.get().clone()
                                        } else {
                                            Documents::method43(
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
                                            Documents::method43(
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
                });
            }
        }
        pub fn method41(
            v0_1: string,
            v1_1: LrcPtr<Documents::UH1>,
            v2: LrcPtr<Documents::UH0>,
            v3: Documents::US9,
            v4: Documents::US9,
        ) -> (LrcPtr<Documents::UH1>, string) {
            let v0_1: MutCell<string> = MutCell::new(v0_1.clone());
            let v1_1: MutCell<LrcPtr<Documents::UH1>> = MutCell::new(v1_1.clone());
            let v2: MutCell<LrcPtr<Documents::UH0>> = MutCell::new(v2.clone());
            let v3: MutCell<Documents::US9> = MutCell::new(v3.clone());
            let v4: MutCell<Documents::US9> = MutCell::new(v4.clone());
            '_method41: loop {
                break '_method41 (match &v4.get().clone() {
                    Documents::US9::US9_1(v4_1_0) => {
                        let v581: char = v4_1_0.clone();
                        if '\"' == v581 {
                            if let Documents::US9::US9_1(v3_1_0) = &v3.get().clone() {
                                if let Documents::UH0::UH0_1(v2_1_0, v2_1_1) =
                                    v2.get().clone().as_ref()
                                {
                                    let v585: LrcPtr<Documents::UH0> =
                                        match v2.get().clone().as_ref() {
                                            Documents::UH0::UH0_1(_, x) => x.clone(),
                                            _ => unreachable!(),
                                        };
                                    let v584: char = match v2.get().clone().as_ref() {
                                        Documents::UH0::UH0_1(x, _) => x.clone(),
                                        _ => unreachable!(),
                                    };
                                    if '\"' == v584 {
                                        let v0_1_temp: string = v0_1.get().clone();
                                        let v1_1_temp: LrcPtr<Documents::UH1> = v1_1.get().clone();
                                        let v2_temp: LrcPtr<Documents::UH0> = v585.clone();
                                        let v3_temp: Documents::US9 = v4.get().clone();
                                        let v4_temp: Documents::US9 = Documents::US9::US9_0;
                                        v0_1.set(v0_1_temp);
                                        v1_1.set(v1_1_temp);
                                        v2.set(v2_temp);
                                        v3.set(v3_temp);
                                        v4.set(v4_temp);
                                        continue '_method41;
                                    } else {
                                        if '\\' == v581 {
                                            if '\\' == v584 {
                                                let v0_1_temp: string = v0_1.get().clone();
                                                let v1_1_temp: LrcPtr<Documents::UH1> =
                                                    v1_1.get().clone();
                                                let v2_temp: LrcPtr<Documents::UH0> = v585.clone();
                                                let v3_temp: Documents::US9 = v4.get().clone();
                                                let v4_temp: Documents::US9 =
                                                    Documents::US9::US9_2(0_u8, v584);
                                                v0_1.set(v0_1_temp);
                                                v1_1.set(v1_1_temp);
                                                v2.set(v2_temp);
                                                v3.set(v3_temp);
                                                v4.set(v4_temp);
                                                continue '_method41;
                                            } else {
                                                if '`' == v584 {
                                                    let v0_1_temp: string = v0_1.get().clone();
                                                    let v1_1_temp: LrcPtr<Documents::UH1> =
                                                        v1_1.get().clone();
                                                    let v2_temp: LrcPtr<Documents::UH0> =
                                                        v585.clone();
                                                    let v3_temp: Documents::US9 = v4.get().clone();
                                                    let v4_temp: Documents::US9 =
                                                        Documents::US9::US9_2(0_u8, v584);
                                                    v0_1.set(v0_1_temp);
                                                    v1_1.set(v1_1_temp);
                                                    v2.set(v2_temp);
                                                    v3.set(v3_temp);
                                                    v4.set(v4_temp);
                                                    continue '_method41;
                                                } else {
                                                    if ' ' == v584 {
                                                        Documents::method42(
                                                            sprintf!("{} ", v0_1.get().clone()),
                                                            v1_1.get().clone(),
                                                            v585.clone(),
                                                            v4.get().clone(),
                                                        )
                                                    } else {
                                                        Documents::method42(
                                                            sprintf!(
                                                                "{}{}",
                                                                v0_1.get().clone(),
                                                                v584
                                                            ),
                                                            v1_1.get().clone(),
                                                            v585.clone(),
                                                            v4.get().clone(),
                                                        )
                                                    }
                                                }
                                            }
                                        } else {
                                            if '`' == v581 {
                                                if '\\' == v584 {
                                                    let v0_1_temp: string = v0_1.get().clone();
                                                    let v1_1_temp: LrcPtr<Documents::UH1> =
                                                        v1_1.get().clone();
                                                    let v2_temp: LrcPtr<Documents::UH0> =
                                                        v585.clone();
                                                    let v3_temp: Documents::US9 = v4.get().clone();
                                                    let v4_temp: Documents::US9 =
                                                        Documents::US9::US9_2(0_u8, v584);
                                                    v0_1.set(v0_1_temp);
                                                    v1_1.set(v1_1_temp);
                                                    v2.set(v2_temp);
                                                    v3.set(v3_temp);
                                                    v4.set(v4_temp);
                                                    continue '_method41;
                                                } else {
                                                    if '`' == v584 {
                                                        let v0_1_temp: string = v0_1.get().clone();
                                                        let v1_1_temp: LrcPtr<Documents::UH1> =
                                                            v1_1.get().clone();
                                                        let v2_temp: LrcPtr<Documents::UH0> =
                                                            v585.clone();
                                                        let v3_temp: Documents::US9 =
                                                            v4.get().clone();
                                                        let v4_temp: Documents::US9 =
                                                            Documents::US9::US9_2(0_u8, v584);
                                                        v0_1.set(v0_1_temp);
                                                        v1_1.set(v1_1_temp);
                                                        v2.set(v2_temp);
                                                        v3.set(v3_temp);
                                                        v4.set(v4_temp);
                                                        continue '_method41;
                                                    } else {
                                                        if ' ' == v584 {
                                                            Documents::method42(
                                                                sprintf!("{} ", v0_1.get().clone()),
                                                                v1_1.get().clone(),
                                                                v585,
                                                                v4.get().clone(),
                                                            )
                                                        } else {
                                                            Documents::method42(
                                                                sprintf!(
                                                                    "{}{}",
                                                                    v0_1.get().clone(),
                                                                    v584
                                                                ),
                                                                v1_1.get().clone(),
                                                                v585.clone(),
                                                                v4.get().clone(),
                                                            )
                                                        }
                                                    }
                                                }
                                            } else {
                                                if '\\' == v584 {
                                                    let v0_1_temp: string = v0_1.get().clone();
                                                    let v1_1_temp: LrcPtr<Documents::UH1> =
                                                        v1_1.get().clone();
                                                    let v2_temp: LrcPtr<Documents::UH0> =
                                                        v585.clone();
                                                    let v3_temp: Documents::US9 = v4.get().clone();
                                                    let v4_temp: Documents::US9 =
                                                        Documents::US9::US9_2(0_u8, v584);
                                                    v0_1.set(v0_1_temp);
                                                    v1_1.set(v1_1_temp);
                                                    v2.set(v2_temp);
                                                    v3.set(v3_temp);
                                                    v4.set(v4_temp);
                                                    continue '_method41;
                                                } else {
                                                    if '`' == v584 {
                                                        let v0_1_temp: string = v0_1.get().clone();
                                                        let v1_1_temp: LrcPtr<Documents::UH1> =
                                                            v1_1.get().clone();
                                                        let v2_temp: LrcPtr<Documents::UH0> =
                                                            v585.clone();
                                                        let v3_temp: Documents::US9 =
                                                            v4.get().clone();
                                                        let v4_temp: Documents::US9 =
                                                            Documents::US9::US9_2(0_u8, v584);
                                                        v0_1.set(v0_1_temp);
                                                        v1_1.set(v1_1_temp);
                                                        v2.set(v2_temp);
                                                        v3.set(v3_temp);
                                                        v4.set(v4_temp);
                                                        continue '_method41;
                                                    } else {
                                                        if ' ' == v584 {
                                                            Documents::method42(
                                                                sprintf!("{} ", v0_1.get().clone()),
                                                                v1_1.get().clone(),
                                                                v585.clone(),
                                                                v4.get().clone(),
                                                            )
                                                        } else {
                                                            Documents::method42(
                                                                sprintf!(
                                                                    "{}{}",
                                                                    v0_1.get().clone(),
                                                                    v584
                                                                ),
                                                                v1_1.get().clone(),
                                                                v585.clone(),
                                                                v4.get().clone(),
                                                            )
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                } else {
                                    if '\\' == v581 {
                                        (
                                            if v0_1.get().clone() == string("") {
                                                v1_1.get().clone()
                                            } else {
                                                Documents::method43(
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
                                        if '`' == v581 {
                                            (
                                                if v0_1.get().clone() == string("") {
                                                    v1_1.get().clone()
                                                } else {
                                                    Documents::method43(
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
                                                    Documents::method43(
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
                            } else {
                                if '\\' == v581 {
                                    if let Documents::UH0::UH0_1(v2_1_0, v2_1_1) =
                                        v2.get().clone().as_ref()
                                    {
                                        let v695: LrcPtr<Documents::UH0> =
                                            match v2.get().clone().as_ref() {
                                                Documents::UH0::UH0_1(_, x) => x.clone(),
                                                _ => unreachable!(),
                                            };
                                        let v694: char = match v2.get().clone().as_ref() {
                                            Documents::UH0::UH0_1(x, _) => x.clone(),
                                            _ => unreachable!(),
                                        };
                                        if '\"' == v694 {
                                            if if !(v3.get().clone()
                                                == Documents::US9::US9_2(0_u8, '\\'))
                                            {
                                                !(v3.get().clone()
                                                    == Documents::US9::US9_2(0_u8, '`'))
                                            } else {
                                                false
                                            } {
                                                let v0_1_temp: string =
                                                    sprintf!("{}{}\"", v0_1.get().clone(), v581);
                                                let v1_1_temp: LrcPtr<Documents::UH1> =
                                                    v1_1.get().clone();
                                                let v2_temp: LrcPtr<Documents::UH0> = v695.clone();
                                                let v3_temp: Documents::US9 = v4.get().clone();
                                                let v4_temp: Documents::US9 =
                                                    Documents::US9::US9_1('\"');
                                                v0_1.set(v0_1_temp);
                                                v1_1.set(v1_1_temp);
                                                v2.set(v2_temp);
                                                v3.set(v3_temp);
                                                v4.set(v4_temp);
                                                continue '_method41;
                                            } else {
                                                let v0_1_temp: string = v0_1.get().clone();
                                                let v1_1_temp: LrcPtr<Documents::UH1> =
                                                    v1_1.get().clone();
                                                let v2_temp: LrcPtr<Documents::UH0> = v695.clone();
                                                let v3_temp: Documents::US9 = v4.get().clone();
                                                let v4_temp: Documents::US9 = Documents::US9::US9_0;
                                                v0_1.set(v0_1_temp);
                                                v1_1.set(v1_1_temp);
                                                v2.set(v2_temp);
                                                v3.set(v3_temp);
                                                v4.set(v4_temp);
                                                continue '_method41;
                                            }
                                        } else {
                                            if '\\' == v694 {
                                                let v0_1_temp: string = v0_1.get().clone();
                                                let v1_1_temp: LrcPtr<Documents::UH1> =
                                                    v1_1.get().clone();
                                                let v2_temp: LrcPtr<Documents::UH0> = v695.clone();
                                                let v3_temp: Documents::US9 = v4.get().clone();
                                                let v4_temp: Documents::US9 =
                                                    Documents::US9::US9_2(1_u8, v694);
                                                v0_1.set(v0_1_temp);
                                                v1_1.set(v1_1_temp);
                                                v2.set(v2_temp);
                                                v3.set(v3_temp);
                                                v4.set(v4_temp);
                                                continue '_method41;
                                            } else {
                                                if '`' == v694 {
                                                    let v0_1_temp: string = v0_1.get().clone();
                                                    let v1_1_temp: LrcPtr<Documents::UH1> =
                                                        v1_1.get().clone();
                                                    let v2_temp: LrcPtr<Documents::UH0> =
                                                        v695.clone();
                                                    let v3_temp: Documents::US9 = v4.get().clone();
                                                    let v4_temp: Documents::US9 =
                                                        Documents::US9::US9_2(1_u8, v694);
                                                    v0_1.set(v0_1_temp);
                                                    v1_1.set(v1_1_temp);
                                                    v2.set(v2_temp);
                                                    v3.set(v3_temp);
                                                    v4.set(v4_temp);
                                                    continue '_method41;
                                                } else {
                                                    if let Documents::US9::US9_2(v3_2_0, v3_2_1) =
                                                        &v3.get().clone()
                                                    {
                                                        if 0_u8
                                                            == match &v3.get().clone() {
                                                                Documents::US9::US9_2(x, _) => {
                                                                    x.clone()
                                                                }
                                                                _ => unreachable!(),
                                                            }
                                                        {
                                                            if ' ' == v694 {
                                                                Documents::method42(
                                                                    sprintf!(
                                                                        "{} ",
                                                                        v0_1.get().clone()
                                                                    ),
                                                                    v1_1.get().clone(),
                                                                    v695.clone(),
                                                                    v4.get().clone(),
                                                                )
                                                            } else {
                                                                Documents::method42(
                                                                    sprintf!(
                                                                        "{}{}",
                                                                        v0_1.get().clone(),
                                                                        v694
                                                                    ),
                                                                    v1_1.get().clone(),
                                                                    v695,
                                                                    v4.get().clone(),
                                                                )
                                                            }
                                                        } else {
                                                            if ' ' == v694 {
                                                                Documents::method42(
                                                                    sprintf!(
                                                                        "{} ",
                                                                        v0_1.get().clone()
                                                                    ),
                                                                    v1_1.get().clone(),
                                                                    v695.clone(),
                                                                    v4.get().clone(),
                                                                )
                                                            } else {
                                                                Documents::method42(
                                                                    sprintf!(
                                                                        "{}{}",
                                                                        v0_1.get().clone(),
                                                                        v694
                                                                    ),
                                                                    v1_1.get().clone(),
                                                                    v695.clone(),
                                                                    v4.get().clone(),
                                                                )
                                                            }
                                                        }
                                                    } else {
                                                        if ' ' == v694 {
                                                            Documents::method42(
                                                                sprintf!("{} ", v0_1.get().clone()),
                                                                v1_1.get().clone(),
                                                                v695.clone(),
                                                                v4.get().clone(),
                                                            )
                                                        } else {
                                                            Documents::method42(
                                                                sprintf!(
                                                                    "{}{}",
                                                                    v0_1.get().clone(),
                                                                    v694
                                                                ),
                                                                v1_1.get().clone(),
                                                                v695.clone(),
                                                                v4.get().clone(),
                                                            )
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    } else {
                                        if let Documents::US9::US9_2(v3_2_0, v3_2_1) =
                                            &v3.get().clone()
                                        {
                                            if 0_u8
                                                == match &v3.get().clone() {
                                                    Documents::US9::US9_2(x, _) => x.clone(),
                                                    _ => unreachable!(),
                                                }
                                            {
                                                (
                                                    if v0_1.get().clone() == string("") {
                                                        v1_1.get().clone()
                                                    } else {
                                                        Documents::method43(
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
                                                        Documents::method43(
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
                                            (
                                                if v0_1.get().clone() == string("") {
                                                    v1_1.get().clone()
                                                } else {
                                                    Documents::method43(
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
                                    if '`' == v581 {
                                        if let Documents::UH0::UH0_1(v2_1_0, v2_1_1) =
                                            v2.get().clone().as_ref()
                                        {
                                            let v791: LrcPtr<Documents::UH0> =
                                                match v2.get().clone().as_ref() {
                                                    Documents::UH0::UH0_1(_, x) => x.clone(),
                                                    _ => unreachable!(),
                                                };
                                            let v790: char = match v2.get().clone().as_ref() {
                                                Documents::UH0::UH0_1(x, _) => x.clone(),
                                                _ => unreachable!(),
                                            };
                                            if '\"' == v790 {
                                                if if !(v3.get().clone()
                                                    == Documents::US9::US9_2(0_u8, '\\'))
                                                {
                                                    !(v3.get().clone()
                                                        == Documents::US9::US9_2(0_u8, '`'))
                                                } else {
                                                    false
                                                } {
                                                    let v0_1_temp: string = sprintf!(
                                                        "{}{}\"",
                                                        v0_1.get().clone(),
                                                        v581
                                                    );
                                                    let v1_1_temp: LrcPtr<Documents::UH1> =
                                                        v1_1.get().clone();
                                                    let v2_temp: LrcPtr<Documents::UH0> =
                                                        v791.clone();
                                                    let v3_temp: Documents::US9 = v4.get().clone();
                                                    let v4_temp: Documents::US9 =
                                                        Documents::US9::US9_1('\"');
                                                    v0_1.set(v0_1_temp);
                                                    v1_1.set(v1_1_temp);
                                                    v2.set(v2_temp);
                                                    v3.set(v3_temp);
                                                    v4.set(v4_temp);
                                                    continue '_method41;
                                                } else {
                                                    let v0_1_temp: string = v0_1.get().clone();
                                                    let v1_1_temp: LrcPtr<Documents::UH1> =
                                                        v1_1.get().clone();
                                                    let v2_temp: LrcPtr<Documents::UH0> =
                                                        v791.clone();
                                                    let v3_temp: Documents::US9 = v4.get().clone();
                                                    let v4_temp: Documents::US9 =
                                                        Documents::US9::US9_0;
                                                    v0_1.set(v0_1_temp);
                                                    v1_1.set(v1_1_temp);
                                                    v2.set(v2_temp);
                                                    v3.set(v3_temp);
                                                    v4.set(v4_temp);
                                                    continue '_method41;
                                                }
                                            } else {
                                                if '\\' == v790 {
                                                    let v0_1_temp: string = v0_1.get().clone();
                                                    let v1_1_temp: LrcPtr<Documents::UH1> =
                                                        v1_1.get().clone();
                                                    let v2_temp: LrcPtr<Documents::UH0> =
                                                        v791.clone();
                                                    let v3_temp: Documents::US9 = v4.get().clone();
                                                    let v4_temp: Documents::US9 =
                                                        Documents::US9::US9_2(1_u8, v790);
                                                    v0_1.set(v0_1_temp);
                                                    v1_1.set(v1_1_temp);
                                                    v2.set(v2_temp);
                                                    v3.set(v3_temp);
                                                    v4.set(v4_temp);
                                                    continue '_method41;
                                                } else {
                                                    if '`' == v790 {
                                                        let v0_1_temp: string = v0_1.get().clone();
                                                        let v1_1_temp: LrcPtr<Documents::UH1> =
                                                            v1_1.get().clone();
                                                        let v2_temp: LrcPtr<Documents::UH0> =
                                                            v791.clone();
                                                        let v3_temp: Documents::US9 =
                                                            v4.get().clone();
                                                        let v4_temp: Documents::US9 =
                                                            Documents::US9::US9_2(1_u8, v790);
                                                        v0_1.set(v0_1_temp);
                                                        v1_1.set(v1_1_temp);
                                                        v2.set(v2_temp);
                                                        v3.set(v3_temp);
                                                        v4.set(v4_temp);
                                                        continue '_method41;
                                                    } else {
                                                        if let Documents::US9::US9_2(
                                                            v3_2_0,
                                                            v3_2_1,
                                                        ) = &v3.get().clone()
                                                        {
                                                            if 0_u8
                                                                == match &v3.get().clone() {
                                                                    Documents::US9::US9_2(x, _) => {
                                                                        x.clone()
                                                                    }
                                                                    _ => unreachable!(),
                                                                }
                                                            {
                                                                if ' ' == v790 {
                                                                    Documents::method42(
                                                                        sprintf!(
                                                                            "{} ",
                                                                            v0_1.get().clone()
                                                                        ),
                                                                        v1_1.get().clone(),
                                                                        v791.clone(),
                                                                        v4.get().clone(),
                                                                    )
                                                                } else {
                                                                    Documents::method42(
                                                                        sprintf!(
                                                                            "{}{}",
                                                                            v0_1.get().clone(),
                                                                            v790
                                                                        ),
                                                                        v1_1.get().clone(),
                                                                        v791,
                                                                        v4.get().clone(),
                                                                    )
                                                                }
                                                            } else {
                                                                if ' ' == v790 {
                                                                    Documents::method42(
                                                                        sprintf!(
                                                                            "{} ",
                                                                            v0_1.get().clone()
                                                                        ),
                                                                        v1_1.get().clone(),
                                                                        v791.clone(),
                                                                        v4.get().clone(),
                                                                    )
                                                                } else {
                                                                    Documents::method42(
                                                                        sprintf!(
                                                                            "{}{}",
                                                                            v0_1.get().clone(),
                                                                            v790
                                                                        ),
                                                                        v1_1.get().clone(),
                                                                        v791.clone(),
                                                                        v4.get().clone(),
                                                                    )
                                                                }
                                                            }
                                                        } else {
                                                            if ' ' == v790 {
                                                                Documents::method42(
                                                                    sprintf!(
                                                                        "{} ",
                                                                        v0_1.get().clone()
                                                                    ),
                                                                    v1_1.get().clone(),
                                                                    v791.clone(),
                                                                    v4.get().clone(),
                                                                )
                                                            } else {
                                                                Documents::method42(
                                                                    sprintf!(
                                                                        "{}{}",
                                                                        v0_1.get().clone(),
                                                                        v790
                                                                    ),
                                                                    v1_1.get().clone(),
                                                                    v791.clone(),
                                                                    v4.get().clone(),
                                                                )
                                                            }
                                                        }
                                                    }
                                                }
                                            }
                                        } else {
                                            if let Documents::US9::US9_2(v3_2_0, v3_2_1) =
                                                &v3.get().clone()
                                            {
                                                if 0_u8
                                                    == match &v3.get().clone() {
                                                        Documents::US9::US9_2(x, _) => x.clone(),
                                                        _ => unreachable!(),
                                                    }
                                                {
                                                    (
                                                        if v0_1.get().clone() == string("") {
                                                            v1_1.get().clone()
                                                        } else {
                                                            Documents::method43(
                                                                v1_1.get().clone(),
                                                                LrcPtr::new(Documents::UH1::UH1_1(
                                                                    v0_1.get().clone(),
                                                                    LrcPtr::new(
                                                                        Documents::UH1::UH1_0,
                                                                    ),
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
                                                            Documents::method43(
                                                                v1_1.get().clone(),
                                                                LrcPtr::new(Documents::UH1::UH1_1(
                                                                    v0_1.get().clone(),
                                                                    LrcPtr::new(
                                                                        Documents::UH1::UH1_0,
                                                                    ),
                                                                )),
                                                            )
                                                        },
                                                        v0_1.get().clone(),
                                                    )
                                                }
                                            } else {
                                                (
                                                    if v0_1.get().clone() == string("") {
                                                        v1_1.get().clone()
                                                    } else {
                                                        Documents::method43(
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
                                        if let Documents::UH0::UH0_1(v2_1_0, v2_1_1) =
                                            v2.get().clone().as_ref()
                                        {
                                            let v886: LrcPtr<Documents::UH0> =
                                                match v2.get().clone().as_ref() {
                                                    Documents::UH0::UH0_1(_, x) => x.clone(),
                                                    _ => unreachable!(),
                                                };
                                            let v885: char = match v2.get().clone().as_ref() {
                                                Documents::UH0::UH0_1(x, _) => x.clone(),
                                                _ => unreachable!(),
                                            };
                                            if '\\' == v885 {
                                                let v0_1_temp: string = v0_1.get().clone();
                                                let v1_1_temp: LrcPtr<Documents::UH1> =
                                                    v1_1.get().clone();
                                                let v2_temp: LrcPtr<Documents::UH0> = v886.clone();
                                                let v3_temp: Documents::US9 = v4.get().clone();
                                                let v4_temp: Documents::US9 =
                                                    Documents::US9::US9_2(1_u8, v885);
                                                v0_1.set(v0_1_temp);
                                                v1_1.set(v1_1_temp);
                                                v2.set(v2_temp);
                                                v3.set(v3_temp);
                                                v4.set(v4_temp);
                                                continue '_method41;
                                            } else {
                                                if '`' == v885 {
                                                    let v0_1_temp: string = v0_1.get().clone();
                                                    let v1_1_temp: LrcPtr<Documents::UH1> =
                                                        v1_1.get().clone();
                                                    let v2_temp: LrcPtr<Documents::UH0> =
                                                        v886.clone();
                                                    let v3_temp: Documents::US9 = v4.get().clone();
                                                    let v4_temp: Documents::US9 =
                                                        Documents::US9::US9_2(1_u8, v885);
                                                    v0_1.set(v0_1_temp);
                                                    v1_1.set(v1_1_temp);
                                                    v2.set(v2_temp);
                                                    v3.set(v3_temp);
                                                    v4.set(v4_temp);
                                                    continue '_method41;
                                                } else {
                                                    if let Documents::US9::US9_2(v3_2_0, v3_2_1) =
                                                        &v3.get().clone()
                                                    {
                                                        if 0_u8
                                                            == match &v3.get().clone() {
                                                                Documents::US9::US9_2(x, _) => {
                                                                    x.clone()
                                                                }
                                                                _ => unreachable!(),
                                                            }
                                                        {
                                                            if '\"' == v885 {
                                                                let v0_1_temp: string = sprintf!(
                                                                    "{}",
                                                                    v0_1.get().clone()
                                                                );
                                                                let v1_1_temp: LrcPtr<
                                                                    Documents::UH1,
                                                                > = v1_1.get().clone();
                                                                let v2_temp: LrcPtr<
                                                                    Documents::UH0,
                                                                > = v886.clone();
                                                                let v3_temp: Documents::US9 =
                                                                    v4.get().clone();
                                                                let v4_temp: Documents::US9 =
                                                                    Documents::US9::US9_1('\"');
                                                                v0_1.set(v0_1_temp);
                                                                v1_1.set(v1_1_temp);
                                                                v2.set(v2_temp);
                                                                v3.set(v3_temp);
                                                                v4.set(v4_temp);
                                                                continue '_method41;
                                                            } else {
                                                                if ' ' == v885 {
                                                                    Documents::method42(
                                                                        sprintf!(
                                                                            "{} ",
                                                                            v0_1.get().clone()
                                                                        ),
                                                                        v1_1.get().clone(),
                                                                        v886.clone(),
                                                                        v4.get().clone(),
                                                                    )
                                                                } else {
                                                                    Documents::method42(
                                                                        sprintf!(
                                                                            "{}{}",
                                                                            v0_1.get().clone(),
                                                                            v885
                                                                        ),
                                                                        v1_1.get().clone(),
                                                                        v886.clone(),
                                                                        v4.get().clone(),
                                                                    )
                                                                }
                                                            }
                                                        } else {
                                                            if '\"' == v885 {
                                                                let v0_1_temp: string = string("");
                                                                let v1_1_temp:
                                                                                 LrcPtr<Documents::UH1> =
                                                                             Documents::method43(v1_1.get().clone(),
                                                                                                 LrcPtr::new(Documents::UH1::UH1_1(v0_1.get().clone(),
                                                                                                                                   LrcPtr::new(Documents::UH1::UH1_0))));
                                                                let v2_temp: LrcPtr<
                                                                    Documents::UH0,
                                                                > = v886.clone();
                                                                let v3_temp: Documents::US9 =
                                                                    v4.get().clone();
                                                                let v4_temp: Documents::US9 =
                                                                    Documents::US9::US9_0;
                                                                v0_1.set(v0_1_temp);
                                                                v1_1.set(v1_1_temp);
                                                                v2.set(v2_temp);
                                                                v3.set(v3_temp);
                                                                v4.set(v4_temp);
                                                                continue '_method41;
                                                            } else {
                                                                if ' ' == v885 {
                                                                    Documents::method42(
                                                                        sprintf!(
                                                                            "{} ",
                                                                            v0_1.get().clone()
                                                                        ),
                                                                        v1_1.get().clone(),
                                                                        v886,
                                                                        v4.get().clone(),
                                                                    )
                                                                } else {
                                                                    Documents::method42(
                                                                        sprintf!(
                                                                            "{}{}",
                                                                            v0_1.get().clone(),
                                                                            v885
                                                                        ),
                                                                        v1_1.get().clone(),
                                                                        v886.clone(),
                                                                        v4.get().clone(),
                                                                    )
                                                                }
                                                            }
                                                        }
                                                    } else {
                                                        if '\"' == v885 {
                                                            let v0_1_temp: string = string("");
                                                            let v1_1_temp:
                                                                             LrcPtr<Documents::UH1> =
                                                                         Documents::method43(v1_1.get().clone(),
                                                                                             LrcPtr::new(Documents::UH1::UH1_1(v0_1.get().clone(),
                                                                                                                               LrcPtr::new(Documents::UH1::UH1_0))));
                                                            let v2_temp: LrcPtr<Documents::UH0> =
                                                                v886.clone();
                                                            let v3_temp: Documents::US9 =
                                                                v4.get().clone();
                                                            let v4_temp: Documents::US9 =
                                                                Documents::US9::US9_0;
                                                            v0_1.set(v0_1_temp);
                                                            v1_1.set(v1_1_temp);
                                                            v2.set(v2_temp);
                                                            v3.set(v3_temp);
                                                            v4.set(v4_temp);
                                                            continue '_method41;
                                                        } else {
                                                            if ' ' == v885 {
                                                                Documents::method42(
                                                                    sprintf!(
                                                                        "{} ",
                                                                        v0_1.get().clone()
                                                                    ),
                                                                    v1_1.get().clone(),
                                                                    v886.clone(),
                                                                    v4.get().clone(),
                                                                )
                                                            } else {
                                                                Documents::method42(
                                                                    sprintf!(
                                                                        "{}{}",
                                                                        v0_1.get().clone(),
                                                                        v885
                                                                    ),
                                                                    v1_1.get().clone(),
                                                                    v886.clone(),
                                                                    v4.get().clone(),
                                                                )
                                                            }
                                                        }
                                                    }
                                                }
                                            }
                                        } else {
                                            if let Documents::US9::US9_2(v3_2_0, v3_2_1) =
                                                &v3.get().clone()
                                            {
                                                if 0_u8
                                                    == match &v3.get().clone() {
                                                        Documents::US9::US9_2(x, _) => x.clone(),
                                                        _ => unreachable!(),
                                                    }
                                                {
                                                    (
                                                        if v0_1.get().clone() == string("") {
                                                            v1_1.get().clone()
                                                        } else {
                                                            Documents::method43(
                                                                v1_1.get().clone(),
                                                                LrcPtr::new(Documents::UH1::UH1_1(
                                                                    v0_1.get().clone(),
                                                                    LrcPtr::new(
                                                                        Documents::UH1::UH1_0,
                                                                    ),
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
                                                            Documents::method43(
                                                                v1_1.get().clone(),
                                                                LrcPtr::new(Documents::UH1::UH1_1(
                                                                    v0_1.get().clone(),
                                                                    LrcPtr::new(
                                                                        Documents::UH1::UH1_0,
                                                                    ),
                                                                )),
                                                            )
                                                        },
                                                        v0_1.get().clone(),
                                                    )
                                                }
                                            } else {
                                                (
                                                    if v0_1.get().clone() == string("") {
                                                        v1_1.get().clone()
                                                    } else {
                                                        Documents::method43(
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
                            }
                        } else {
                            if '\\' == v581 {
                                if let Documents::UH0::UH0_1(v2_1_0, v2_1_1) =
                                    v2.get().clone().as_ref()
                                {
                                    let v998: LrcPtr<Documents::UH0> =
                                        match v2.get().clone().as_ref() {
                                            Documents::UH0::UH0_1(_, x) => x.clone(),
                                            _ => unreachable!(),
                                        };
                                    let v997: char = match v2.get().clone().as_ref() {
                                        Documents::UH0::UH0_1(x, _) => x.clone(),
                                        _ => unreachable!(),
                                    };
                                    if '\"' == v997 {
                                        if if !(v3.get().clone()
                                            == Documents::US9::US9_2(0_u8, '\\'))
                                        {
                                            !(v3.get().clone() == Documents::US9::US9_2(0_u8, '`'))
                                        } else {
                                            false
                                        } {
                                            let v0_1_temp: string =
                                                sprintf!("{}{}\"", v0_1.get().clone(), v581);
                                            let v1_1_temp: LrcPtr<Documents::UH1> =
                                                v1_1.get().clone();
                                            let v2_temp: LrcPtr<Documents::UH0> = v998.clone();
                                            let v3_temp: Documents::US9 = v4.get().clone();
                                            let v4_temp: Documents::US9 =
                                                Documents::US9::US9_1('\"');
                                            v0_1.set(v0_1_temp);
                                            v1_1.set(v1_1_temp);
                                            v2.set(v2_temp);
                                            v3.set(v3_temp);
                                            v4.set(v4_temp);
                                            continue '_method41;
                                        } else {
                                            if let Documents::US9::US9_1(v3_1_0) = &v3.get().clone()
                                            {
                                                let v0_1_temp: string =
                                                    sprintf!("{}{}\"", v0_1.get().clone(), v581);
                                                let v1_1_temp: LrcPtr<Documents::UH1> =
                                                    v1_1.get().clone();
                                                let v2_temp: LrcPtr<Documents::UH0> = v998.clone();
                                                let v3_temp: Documents::US9 = v4.get().clone();
                                                let v4_temp: Documents::US9 =
                                                    Documents::US9::US9_1('\"');
                                                v0_1.set(v0_1_temp);
                                                v1_1.set(v1_1_temp);
                                                v2.set(v2_temp);
                                                v3.set(v3_temp);
                                                v4.set(v4_temp);
                                                continue '_method41;
                                            } else {
                                                let v0_1_temp: string = v0_1.get().clone();
                                                let v1_1_temp: LrcPtr<Documents::UH1> =
                                                    v1_1.get().clone();
                                                let v2_temp: LrcPtr<Documents::UH0> = v998.clone();
                                                let v3_temp: Documents::US9 = v4.get().clone();
                                                let v4_temp: Documents::US9 = Documents::US9::US9_0;
                                                v0_1.set(v0_1_temp);
                                                v1_1.set(v1_1_temp);
                                                v2.set(v2_temp);
                                                v3.set(v3_temp);
                                                v4.set(v4_temp);
                                                continue '_method41;
                                            }
                                        }
                                    } else {
                                        if let Documents::US9::US9_1(v3_1_0) = &v3.get().clone() {
                                            if '\\' == v997 {
                                                let v0_1_temp: string = v0_1.get().clone();
                                                let v1_1_temp: LrcPtr<Documents::UH1> =
                                                    v1_1.get().clone();
                                                let v2_temp: LrcPtr<Documents::UH0> = v998.clone();
                                                let v3_temp: Documents::US9 = v4.get().clone();
                                                let v4_temp: Documents::US9 =
                                                    Documents::US9::US9_2(0_u8, v997);
                                                v0_1.set(v0_1_temp);
                                                v1_1.set(v1_1_temp);
                                                v2.set(v2_temp);
                                                v3.set(v3_temp);
                                                v4.set(v4_temp);
                                                continue '_method41;
                                            } else {
                                                if '`' == v997 {
                                                    let v0_1_temp: string = v0_1.get().clone();
                                                    let v1_1_temp: LrcPtr<Documents::UH1> =
                                                        v1_1.get().clone();
                                                    let v2_temp: LrcPtr<Documents::UH0> =
                                                        v998.clone();
                                                    let v3_temp: Documents::US9 = v4.get().clone();
                                                    let v4_temp: Documents::US9 =
                                                        Documents::US9::US9_2(0_u8, v997);
                                                    v0_1.set(v0_1_temp);
                                                    v1_1.set(v1_1_temp);
                                                    v2.set(v2_temp);
                                                    v3.set(v3_temp);
                                                    v4.set(v4_temp);
                                                    continue '_method41;
                                                } else {
                                                    if ' ' == v997 {
                                                        Documents::method42(
                                                            sprintf!("{} ", v0_1.get().clone()),
                                                            v1_1.get().clone(),
                                                            v998.clone(),
                                                            v4.get().clone(),
                                                        )
                                                    } else {
                                                        Documents::method42(
                                                            sprintf!(
                                                                "{}{}",
                                                                v0_1.get().clone(),
                                                                v997
                                                            ),
                                                            v1_1.get().clone(),
                                                            v998.clone(),
                                                            v4.get().clone(),
                                                        )
                                                    }
                                                }
                                            }
                                        } else {
                                            if '\\' == v997 {
                                                let v0_1_temp: string = v0_1.get().clone();
                                                let v1_1_temp: LrcPtr<Documents::UH1> =
                                                    v1_1.get().clone();
                                                let v2_temp: LrcPtr<Documents::UH0> = v998.clone();
                                                let v3_temp: Documents::US9 = v4.get().clone();
                                                let v4_temp: Documents::US9 =
                                                    Documents::US9::US9_2(1_u8, v997);
                                                v0_1.set(v0_1_temp);
                                                v1_1.set(v1_1_temp);
                                                v2.set(v2_temp);
                                                v3.set(v3_temp);
                                                v4.set(v4_temp);
                                                continue '_method41;
                                            } else {
                                                if '`' == v997 {
                                                    let v0_1_temp: string = v0_1.get().clone();
                                                    let v1_1_temp: LrcPtr<Documents::UH1> =
                                                        v1_1.get().clone();
                                                    let v2_temp: LrcPtr<Documents::UH0> =
                                                        v998.clone();
                                                    let v3_temp: Documents::US9 = v4.get().clone();
                                                    let v4_temp: Documents::US9 =
                                                        Documents::US9::US9_2(1_u8, v997);
                                                    v0_1.set(v0_1_temp);
                                                    v1_1.set(v1_1_temp);
                                                    v2.set(v2_temp);
                                                    v3.set(v3_temp);
                                                    v4.set(v4_temp);
                                                    continue '_method41;
                                                } else {
                                                    if let Documents::US9::US9_2(v3_2_0, v3_2_1) =
                                                        &v3.get().clone()
                                                    {
                                                        if 0_u8
                                                            == match &v3.get().clone() {
                                                                Documents::US9::US9_2(x, _) => {
                                                                    x.clone()
                                                                }
                                                                _ => unreachable!(),
                                                            }
                                                        {
                                                            if ' ' == v997 {
                                                                Documents::method42(
                                                                    sprintf!(
                                                                        "{} ",
                                                                        v0_1.get().clone()
                                                                    ),
                                                                    v1_1.get().clone(),
                                                                    v998.clone(),
                                                                    v4.get().clone(),
                                                                )
                                                            } else {
                                                                Documents::method42(
                                                                    sprintf!(
                                                                        "{}{}",
                                                                        v0_1.get().clone(),
                                                                        v997
                                                                    ),
                                                                    v1_1.get().clone(),
                                                                    v998.clone(),
                                                                    v4.get().clone(),
                                                                )
                                                            }
                                                        } else {
                                                            if ' ' == v997 {
                                                                Documents::method42(
                                                                    sprintf!(
                                                                        "{} ",
                                                                        v0_1.get().clone()
                                                                    ),
                                                                    v1_1.get().clone(),
                                                                    v998.clone(),
                                                                    v4.get().clone(),
                                                                )
                                                            } else {
                                                                Documents::method42(
                                                                    sprintf!(
                                                                        "{}{}",
                                                                        v0_1.get().clone(),
                                                                        v997
                                                                    ),
                                                                    v1_1.get().clone(),
                                                                    v998.clone(),
                                                                    v4.get().clone(),
                                                                )
                                                            }
                                                        }
                                                    } else {
                                                        if ' ' == v997 {
                                                            Documents::method42(
                                                                sprintf!("{} ", v0_1.get().clone()),
                                                                v1_1.get().clone(),
                                                                v998.clone(),
                                                                v4.get().clone(),
                                                            )
                                                        } else {
                                                            Documents::method42(
                                                                sprintf!(
                                                                    "{}{}",
                                                                    v0_1.get().clone(),
                                                                    v997
                                                                ),
                                                                v1_1.get().clone(),
                                                                v998.clone(),
                                                                v4.get().clone(),
                                                            )
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                } else {
                                    match &v3.get().clone() {
                                        Documents::US9::US9_2(v3_2_0, v3_2_1) => {
                                            if 0_u8
                                                == match &v3.get().clone() {
                                                    Documents::US9::US9_2(x, _) => x.clone(),
                                                    _ => unreachable!(),
                                                }
                                            {
                                                (
                                                    if v0_1.get().clone() == string("") {
                                                        v1_1.get().clone()
                                                    } else {
                                                        Documents::method43(
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
                                                        Documents::method43(
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
                                        Documents::US9::US9_1(v3_1_0) => (
                                            if v0_1.get().clone() == string("") {
                                                v1_1.get().clone()
                                            } else {
                                                Documents::method43(
                                                    v1_1.get().clone(),
                                                    LrcPtr::new(Documents::UH1::UH1_1(
                                                        v0_1.get().clone(),
                                                        LrcPtr::new(Documents::UH1::UH1_0),
                                                    )),
                                                )
                                            },
                                            v0_1.get().clone(),
                                        ),
                                        _ => (
                                            if v0_1.get().clone() == string("") {
                                                v1_1.get().clone()
                                            } else {
                                                Documents::method43(
                                                    v1_1.get().clone(),
                                                    LrcPtr::new(Documents::UH1::UH1_1(
                                                        v0_1.get().clone(),
                                                        LrcPtr::new(Documents::UH1::UH1_0),
                                                    )),
                                                )
                                            },
                                            v0_1.get().clone(),
                                        ),
                                    }
                                }
                            } else {
                                if '`' == v581 {
                                    if let Documents::UH0::UH0_1(v2_1_0, v2_1_1) =
                                        v2.get().clone().as_ref()
                                    {
                                        let v1137: LrcPtr<Documents::UH0> =
                                            match v2.get().clone().as_ref() {
                                                Documents::UH0::UH0_1(_, x) => x.clone(),
                                                _ => unreachable!(),
                                            };
                                        let v1136: char = match v2.get().clone().as_ref() {
                                            Documents::UH0::UH0_1(x, _) => x.clone(),
                                            _ => unreachable!(),
                                        };
                                        if '\"' == v1136 {
                                            if if !(v3.get().clone()
                                                == Documents::US9::US9_2(0_u8, '\\'))
                                            {
                                                !(v3.get().clone()
                                                    == Documents::US9::US9_2(0_u8, '`'))
                                            } else {
                                                false
                                            } {
                                                let v0_1_temp: string =
                                                    sprintf!("{}{}\"", v0_1.get().clone(), v581);
                                                let v1_1_temp: LrcPtr<Documents::UH1> =
                                                    v1_1.get().clone();
                                                let v2_temp: LrcPtr<Documents::UH0> = v1137.clone();
                                                let v3_temp: Documents::US9 = v4.get().clone();
                                                let v4_temp: Documents::US9 =
                                                    Documents::US9::US9_1('\"');
                                                v0_1.set(v0_1_temp);
                                                v1_1.set(v1_1_temp);
                                                v2.set(v2_temp);
                                                v3.set(v3_temp);
                                                v4.set(v4_temp);
                                                continue '_method41;
                                            } else {
                                                if let Documents::US9::US9_1(v3_1_0) =
                                                    &v3.get().clone()
                                                {
                                                    let v0_1_temp: string = sprintf!(
                                                        "{}{}\"",
                                                        v0_1.get().clone(),
                                                        v581
                                                    );
                                                    let v1_1_temp: LrcPtr<Documents::UH1> =
                                                        v1_1.get().clone();
                                                    let v2_temp: LrcPtr<Documents::UH0> =
                                                        v1137.clone();
                                                    let v3_temp: Documents::US9 = v4.get().clone();
                                                    let v4_temp: Documents::US9 =
                                                        Documents::US9::US9_1('\"');
                                                    v0_1.set(v0_1_temp);
                                                    v1_1.set(v1_1_temp);
                                                    v2.set(v2_temp);
                                                    v3.set(v3_temp);
                                                    v4.set(v4_temp);
                                                    continue '_method41;
                                                } else {
                                                    let v0_1_temp: string = v0_1.get().clone();
                                                    let v1_1_temp: LrcPtr<Documents::UH1> =
                                                        v1_1.get().clone();
                                                    let v2_temp: LrcPtr<Documents::UH0> =
                                                        v1137.clone();
                                                    let v3_temp: Documents::US9 = v4.get().clone();
                                                    let v4_temp: Documents::US9 =
                                                        Documents::US9::US9_0;
                                                    v0_1.set(v0_1_temp);
                                                    v1_1.set(v1_1_temp);
                                                    v2.set(v2_temp);
                                                    v3.set(v3_temp);
                                                    v4.set(v4_temp);
                                                    continue '_method41;
                                                }
                                            }
                                        } else {
                                            if let Documents::US9::US9_1(v3_1_0) = &v3.get().clone()
                                            {
                                                if '\\' == v1136 {
                                                    let v0_1_temp: string = v0_1.get().clone();
                                                    let v1_1_temp: LrcPtr<Documents::UH1> =
                                                        v1_1.get().clone();
                                                    let v2_temp: LrcPtr<Documents::UH0> =
                                                        v1137.clone();
                                                    let v3_temp: Documents::US9 = v4.get().clone();
                                                    let v4_temp: Documents::US9 =
                                                        Documents::US9::US9_2(0_u8, v1136);
                                                    v0_1.set(v0_1_temp);
                                                    v1_1.set(v1_1_temp);
                                                    v2.set(v2_temp);
                                                    v3.set(v3_temp);
                                                    v4.set(v4_temp);
                                                    continue '_method41;
                                                } else {
                                                    if '`' == v1136 {
                                                        let v0_1_temp: string = v0_1.get().clone();
                                                        let v1_1_temp: LrcPtr<Documents::UH1> =
                                                            v1_1.get().clone();
                                                        let v2_temp: LrcPtr<Documents::UH0> =
                                                            v1137.clone();
                                                        let v3_temp: Documents::US9 =
                                                            v4.get().clone();
                                                        let v4_temp: Documents::US9 =
                                                            Documents::US9::US9_2(0_u8, v1136);
                                                        v0_1.set(v0_1_temp);
                                                        v1_1.set(v1_1_temp);
                                                        v2.set(v2_temp);
                                                        v3.set(v3_temp);
                                                        v4.set(v4_temp);
                                                        continue '_method41;
                                                    } else {
                                                        if ' ' == v1136 {
                                                            Documents::method42(
                                                                sprintf!("{} ", v0_1.get().clone()),
                                                                v1_1.get().clone(),
                                                                v1137.clone(),
                                                                v4.get().clone(),
                                                            )
                                                        } else {
                                                            Documents::method42(
                                                                sprintf!(
                                                                    "{}{}",
                                                                    v0_1.get().clone(),
                                                                    v1136
                                                                ),
                                                                v1_1.get().clone(),
                                                                v1137.clone(),
                                                                v4.get().clone(),
                                                            )
                                                        }
                                                    }
                                                }
                                            } else {
                                                if '\\' == v1136 {
                                                    let v0_1_temp: string = v0_1.get().clone();
                                                    let v1_1_temp: LrcPtr<Documents::UH1> =
                                                        v1_1.get().clone();
                                                    let v2_temp: LrcPtr<Documents::UH0> =
                                                        v1137.clone();
                                                    let v3_temp: Documents::US9 = v4.get().clone();
                                                    let v4_temp: Documents::US9 =
                                                        Documents::US9::US9_2(1_u8, v1136);
                                                    v0_1.set(v0_1_temp);
                                                    v1_1.set(v1_1_temp);
                                                    v2.set(v2_temp);
                                                    v3.set(v3_temp);
                                                    v4.set(v4_temp);
                                                    continue '_method41;
                                                } else {
                                                    if '`' == v1136 {
                                                        let v0_1_temp: string = v0_1.get().clone();
                                                        let v1_1_temp: LrcPtr<Documents::UH1> =
                                                            v1_1.get().clone();
                                                        let v2_temp: LrcPtr<Documents::UH0> =
                                                            v1137.clone();
                                                        let v3_temp: Documents::US9 =
                                                            v4.get().clone();
                                                        let v4_temp: Documents::US9 =
                                                            Documents::US9::US9_2(1_u8, v1136);
                                                        v0_1.set(v0_1_temp);
                                                        v1_1.set(v1_1_temp);
                                                        v2.set(v2_temp);
                                                        v3.set(v3_temp);
                                                        v4.set(v4_temp);
                                                        continue '_method41;
                                                    } else {
                                                        if let Documents::US9::US9_2(
                                                            v3_2_0,
                                                            v3_2_1,
                                                        ) = &v3.get().clone()
                                                        {
                                                            if 0_u8
                                                                == match &v3.get().clone() {
                                                                    Documents::US9::US9_2(x, _) => {
                                                                        x.clone()
                                                                    }
                                                                    _ => unreachable!(),
                                                                }
                                                            {
                                                                if ' ' == v1136 {
                                                                    Documents::method42(
                                                                        sprintf!(
                                                                            "{} ",
                                                                            v0_1.get().clone()
                                                                        ),
                                                                        v1_1.get().clone(),
                                                                        v1137.clone(),
                                                                        v4.get().clone(),
                                                                    )
                                                                } else {
                                                                    Documents::method42(
                                                                        sprintf!(
                                                                            "{}{}",
                                                                            v0_1.get().clone(),
                                                                            v1136
                                                                        ),
                                                                        v1_1.get().clone(),
                                                                        v1137.clone(),
                                                                        v4.get().clone(),
                                                                    )
                                                                }
                                                            } else {
                                                                if ' ' == v1136 {
                                                                    Documents::method42(
                                                                        sprintf!(
                                                                            "{} ",
                                                                            v0_1.get().clone()
                                                                        ),
                                                                        v1_1.get().clone(),
                                                                        v1137.clone(),
                                                                        v4.get().clone(),
                                                                    )
                                                                } else {
                                                                    Documents::method42(
                                                                        sprintf!(
                                                                            "{}{}",
                                                                            v0_1.get().clone(),
                                                                            v1136
                                                                        ),
                                                                        v1_1.get().clone(),
                                                                        v1137.clone(),
                                                                        v4.get().clone(),
                                                                    )
                                                                }
                                                            }
                                                        } else {
                                                            if ' ' == v1136 {
                                                                Documents::method42(
                                                                    sprintf!(
                                                                        "{} ",
                                                                        v0_1.get().clone()
                                                                    ),
                                                                    v1_1.get().clone(),
                                                                    v1137.clone(),
                                                                    v4.get().clone(),
                                                                )
                                                            } else {
                                                                Documents::method42(
                                                                    sprintf!(
                                                                        "{}{}",
                                                                        v0_1.get().clone(),
                                                                        v1136
                                                                    ),
                                                                    v1_1.get().clone(),
                                                                    v1137.clone(),
                                                                    v4.get().clone(),
                                                                )
                                                            }
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    } else {
                                        match &v3.get().clone() {
                                            Documents::US9::US9_2(v3_2_0, v3_2_1) => {
                                                if 0_u8
                                                    == match &v3.get().clone() {
                                                        Documents::US9::US9_2(x, _) => x.clone(),
                                                        _ => unreachable!(),
                                                    }
                                                {
                                                    (
                                                        if v0_1.get().clone() == string("") {
                                                            v1_1.get().clone()
                                                        } else {
                                                            Documents::method43(
                                                                v1_1.get().clone(),
                                                                LrcPtr::new(Documents::UH1::UH1_1(
                                                                    v0_1.get().clone(),
                                                                    LrcPtr::new(
                                                                        Documents::UH1::UH1_0,
                                                                    ),
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
                                                            Documents::method43(
                                                                v1_1.get().clone(),
                                                                LrcPtr::new(Documents::UH1::UH1_1(
                                                                    v0_1.get().clone(),
                                                                    LrcPtr::new(
                                                                        Documents::UH1::UH1_0,
                                                                    ),
                                                                )),
                                                            )
                                                        },
                                                        v0_1.get().clone(),
                                                    )
                                                }
                                            }
                                            Documents::US9::US9_1(v3_1_0) => (
                                                if v0_1.get().clone() == string("") {
                                                    v1_1.get().clone()
                                                } else {
                                                    Documents::method43(
                                                        v1_1.get().clone(),
                                                        LrcPtr::new(Documents::UH1::UH1_1(
                                                            v0_1.get().clone(),
                                                            LrcPtr::new(Documents::UH1::UH1_0),
                                                        )),
                                                    )
                                                },
                                                v0_1.get().clone(),
                                            ),
                                            _ => (
                                                if v0_1.get().clone() == string("") {
                                                    v1_1.get().clone()
                                                } else {
                                                    Documents::method43(
                                                        v1_1.get().clone(),
                                                        LrcPtr::new(Documents::UH1::UH1_1(
                                                            v0_1.get().clone(),
                                                            LrcPtr::new(Documents::UH1::UH1_0),
                                                        )),
                                                    )
                                                },
                                                v0_1.get().clone(),
                                            ),
                                        }
                                    }
                                } else {
                                    if let Documents::US9::US9_1(v3_1_0) = &v3.get().clone() {
                                        if let Documents::UH0::UH0_1(v2_1_0, v2_1_1) =
                                            v2.get().clone().as_ref()
                                        {
                                            let v1276: LrcPtr<Documents::UH0> =
                                                match v2.get().clone().as_ref() {
                                                    Documents::UH0::UH0_1(_, x) => x.clone(),
                                                    _ => unreachable!(),
                                                };
                                            let v1275: char = match v2.get().clone().as_ref() {
                                                Documents::UH0::UH0_1(x, _) => x.clone(),
                                                _ => unreachable!(),
                                            };
                                            if '\\' == v1275 {
                                                let v0_1_temp: string = v0_1.get().clone();
                                                let v1_1_temp: LrcPtr<Documents::UH1> =
                                                    v1_1.get().clone();
                                                let v2_temp: LrcPtr<Documents::UH0> = v1276.clone();
                                                let v3_temp: Documents::US9 = v4.get().clone();
                                                let v4_temp: Documents::US9 =
                                                    Documents::US9::US9_2(0_u8, v1275);
                                                v0_1.set(v0_1_temp);
                                                v1_1.set(v1_1_temp);
                                                v2.set(v2_temp);
                                                v3.set(v3_temp);
                                                v4.set(v4_temp);
                                                continue '_method41;
                                            } else {
                                                if '`' == v1275 {
                                                    let v0_1_temp: string = v0_1.get().clone();
                                                    let v1_1_temp: LrcPtr<Documents::UH1> =
                                                        v1_1.get().clone();
                                                    let v2_temp: LrcPtr<Documents::UH0> =
                                                        v1276.clone();
                                                    let v3_temp: Documents::US9 = v4.get().clone();
                                                    let v4_temp: Documents::US9 =
                                                        Documents::US9::US9_2(0_u8, v1275);
                                                    v0_1.set(v0_1_temp);
                                                    v1_1.set(v1_1_temp);
                                                    v2.set(v2_temp);
                                                    v3.set(v3_temp);
                                                    v4.set(v4_temp);
                                                    continue '_method41;
                                                } else {
                                                    if '\"' == v1275 {
                                                        let v0_1_temp: string = string("");
                                                        let v1_1_temp: LrcPtr<Documents::UH1> =
                                                            Documents::method43(
                                                                v1_1.get().clone(),
                                                                LrcPtr::new(Documents::UH1::UH1_1(
                                                                    v0_1.get().clone(),
                                                                    LrcPtr::new(
                                                                        Documents::UH1::UH1_0,
                                                                    ),
                                                                )),
                                                            );
                                                        let v2_temp: LrcPtr<Documents::UH0> =
                                                            v1276.clone();
                                                        let v3_temp: Documents::US9 =
                                                            v4.get().clone();
                                                        let v4_temp: Documents::US9 =
                                                            Documents::US9::US9_0;
                                                        v0_1.set(v0_1_temp);
                                                        v1_1.set(v1_1_temp);
                                                        v2.set(v2_temp);
                                                        v3.set(v3_temp);
                                                        v4.set(v4_temp);
                                                        continue '_method41;
                                                    } else {
                                                        if ' ' == v1275 {
                                                            Documents::method42(
                                                                sprintf!("{} ", v0_1.get().clone()),
                                                                v1_1.get().clone(),
                                                                v1276.clone(),
                                                                v4.get().clone(),
                                                            )
                                                        } else {
                                                            Documents::method42(
                                                                sprintf!(
                                                                    "{}{}",
                                                                    v0_1.get().clone(),
                                                                    v1275
                                                                ),
                                                                v1_1.get().clone(),
                                                                v1276.clone(),
                                                                v4.get().clone(),
                                                            )
                                                        }
                                                    }
                                                }
                                            }
                                        } else {
                                            (
                                                if v0_1.get().clone() == string("") {
                                                    v1_1.get().clone()
                                                } else {
                                                    Documents::method43(
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
                                            let v1319: LrcPtr<Documents::UH0> =
                                                match v2.get().clone().as_ref() {
                                                    Documents::UH0::UH0_1(_, x) => x.clone(),
                                                    _ => unreachable!(),
                                                };
                                            let v1318: char = match v2.get().clone().as_ref() {
                                                Documents::UH0::UH0_1(x, _) => x.clone(),
                                                _ => unreachable!(),
                                            };
                                            if '\\' == v1318 {
                                                let v0_1_temp: string = v0_1.get().clone();
                                                let v1_1_temp: LrcPtr<Documents::UH1> =
                                                    v1_1.get().clone();
                                                let v2_temp: LrcPtr<Documents::UH0> = v1319.clone();
                                                let v3_temp: Documents::US9 = v4.get().clone();
                                                let v4_temp: Documents::US9 =
                                                    Documents::US9::US9_2(1_u8, v1318);
                                                v0_1.set(v0_1_temp);
                                                v1_1.set(v1_1_temp);
                                                v2.set(v2_temp);
                                                v3.set(v3_temp);
                                                v4.set(v4_temp);
                                                continue '_method41;
                                            } else {
                                                if '`' == v1318 {
                                                    let v0_1_temp: string = v0_1.get().clone();
                                                    let v1_1_temp: LrcPtr<Documents::UH1> =
                                                        v1_1.get().clone();
                                                    let v2_temp: LrcPtr<Documents::UH0> =
                                                        v1319.clone();
                                                    let v3_temp: Documents::US9 = v4.get().clone();
                                                    let v4_temp: Documents::US9 =
                                                        Documents::US9::US9_2(1_u8, v1318);
                                                    v0_1.set(v0_1_temp);
                                                    v1_1.set(v1_1_temp);
                                                    v2.set(v2_temp);
                                                    v3.set(v3_temp);
                                                    v4.set(v4_temp);
                                                    continue '_method41;
                                                } else {
                                                    if let Documents::US9::US9_2(v3_2_0, v3_2_1) =
                                                        &v3.get().clone()
                                                    {
                                                        if 0_u8
                                                            == match &v3.get().clone() {
                                                                Documents::US9::US9_2(x, _) => {
                                                                    x.clone()
                                                                }
                                                                _ => unreachable!(),
                                                            }
                                                        {
                                                            if '\"' == v1318 {
                                                                let v0_1_temp: string = sprintf!(
                                                                    "{}",
                                                                    v0_1.get().clone()
                                                                );
                                                                let v1_1_temp: LrcPtr<
                                                                    Documents::UH1,
                                                                > = v1_1.get().clone();
                                                                let v2_temp: LrcPtr<
                                                                    Documents::UH0,
                                                                > = v1319.clone();
                                                                let v3_temp: Documents::US9 =
                                                                    v4.get().clone();
                                                                let v4_temp: Documents::US9 =
                                                                    Documents::US9::US9_1('\"');
                                                                v0_1.set(v0_1_temp);
                                                                v1_1.set(v1_1_temp);
                                                                v2.set(v2_temp);
                                                                v3.set(v3_temp);
                                                                v4.set(v4_temp);
                                                                continue '_method41;
                                                            } else {
                                                                if ' ' == v1318 {
                                                                    Documents::method42(
                                                                        sprintf!(
                                                                            "{} ",
                                                                            v0_1.get().clone()
                                                                        ),
                                                                        v1_1.get().clone(),
                                                                        v1319.clone(),
                                                                        v4.get().clone(),
                                                                    )
                                                                } else {
                                                                    Documents::method42(
                                                                        sprintf!(
                                                                            "{}{}",
                                                                            v0_1.get().clone(),
                                                                            v1318
                                                                        ),
                                                                        v1_1.get().clone(),
                                                                        v1319.clone(),
                                                                        v4.get().clone(),
                                                                    )
                                                                }
                                                            }
                                                        } else {
                                                            if '\"' == v1318 {
                                                                let v0_1_temp: string = string("");
                                                                let v1_1_temp:
                                                                                 LrcPtr<Documents::UH1> =
                                                                             Documents::method43(v1_1.get().clone(),
                                                                                                 LrcPtr::new(Documents::UH1::UH1_1(v0_1.get().clone(),
                                                                                                                                   LrcPtr::new(Documents::UH1::UH1_0))));
                                                                let v2_temp: LrcPtr<
                                                                    Documents::UH0,
                                                                > = v1319.clone();
                                                                let v3_temp: Documents::US9 =
                                                                    v4.get().clone();
                                                                let v4_temp: Documents::US9 =
                                                                    Documents::US9::US9_0;
                                                                v0_1.set(v0_1_temp);
                                                                v1_1.set(v1_1_temp);
                                                                v2.set(v2_temp);
                                                                v3.set(v3_temp);
                                                                v4.set(v4_temp);
                                                                continue '_method41;
                                                            } else {
                                                                if ' ' == v1318 {
                                                                    Documents::method42(
                                                                        sprintf!(
                                                                            "{} ",
                                                                            v0_1.get().clone()
                                                                        ),
                                                                        v1_1.get().clone(),
                                                                        v1319,
                                                                        v4.get().clone(),
                                                                    )
                                                                } else {
                                                                    Documents::method42(
                                                                        sprintf!(
                                                                            "{}{}",
                                                                            v0_1.get().clone(),
                                                                            v1318
                                                                        ),
                                                                        v1_1.get().clone(),
                                                                        v1319.clone(),
                                                                        v4.get().clone(),
                                                                    )
                                                                }
                                                            }
                                                        }
                                                    } else {
                                                        if '\"' == v1318 {
                                                            let v0_1_temp: string = string("");
                                                            let v1_1_temp:
                                                                             LrcPtr<Documents::UH1> =
                                                                         Documents::method43(v1_1.get().clone(),
                                                                                             LrcPtr::new(Documents::UH1::UH1_1(v0_1.get().clone(),
                                                                                                                               LrcPtr::new(Documents::UH1::UH1_0))));
                                                            let v2_temp: LrcPtr<Documents::UH0> =
                                                                v1319.clone();
                                                            let v3_temp: Documents::US9 =
                                                                v4.get().clone();
                                                            let v4_temp: Documents::US9 =
                                                                Documents::US9::US9_0;
                                                            v0_1.set(v0_1_temp);
                                                            v1_1.set(v1_1_temp);
                                                            v2.set(v2_temp);
                                                            v3.set(v3_temp);
                                                            v4.set(v4_temp);
                                                            continue '_method41;
                                                        } else {
                                                            if ' ' == v1318 {
                                                                Documents::method42(
                                                                    sprintf!(
                                                                        "{} ",
                                                                        v0_1.get().clone()
                                                                    ),
                                                                    v1_1.get().clone(),
                                                                    v1319.clone(),
                                                                    v4.get().clone(),
                                                                )
                                                            } else {
                                                                Documents::method42(
                                                                    sprintf!(
                                                                        "{}{}",
                                                                        v0_1.get().clone(),
                                                                        v1318
                                                                    ),
                                                                    v1_1.get().clone(),
                                                                    v1319.clone(),
                                                                    v4.get().clone(),
                                                                )
                                                            }
                                                        }
                                                    }
                                                }
                                            }
                                        } else {
                                            if let Documents::US9::US9_2(v3_2_0, v3_2_1) =
                                                &v3.get().clone()
                                            {
                                                if 0_u8
                                                    == match &v3.get().clone() {
                                                        Documents::US9::US9_2(x, _) => x.clone(),
                                                        _ => unreachable!(),
                                                    }
                                                {
                                                    (
                                                        if v0_1.get().clone() == string("") {
                                                            v1_1.get().clone()
                                                        } else {
                                                            Documents::method43(
                                                                v1_1.get().clone(),
                                                                LrcPtr::new(Documents::UH1::UH1_1(
                                                                    v0_1.get().clone(),
                                                                    LrcPtr::new(
                                                                        Documents::UH1::UH1_0,
                                                                    ),
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
                                                            Documents::method43(
                                                                v1_1.get().clone(),
                                                                LrcPtr::new(Documents::UH1::UH1_1(
                                                                    v0_1.get().clone(),
                                                                    LrcPtr::new(
                                                                        Documents::UH1::UH1_0,
                                                                    ),
                                                                )),
                                                            )
                                                        },
                                                        v0_1.get().clone(),
                                                    )
                                                }
                                            } else {
                                                (
                                                    if v0_1.get().clone() == string("") {
                                                        v1_1.get().clone()
                                                    } else {
                                                        Documents::method43(
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
                            }
                        }
                    }
                    Documents::US9::US9_0 => {
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
                                let v3_temp: Documents::US9 = v4.get().clone();
                                let v4_temp: Documents::US9 = Documents::US9::US9_1('\"');
                                v0_1.set(v0_1_temp);
                                v1_1.set(v1_1_temp);
                                v2.set(v2_temp);
                                v3.set(v3_temp);
                                v4.set(v4_temp);
                                continue '_method41;
                            } else {
                                if '\\' == v5 {
                                    let v0_1_temp: string = v0_1.get().clone();
                                    let v1_1_temp: LrcPtr<Documents::UH1> = v1_1.get().clone();
                                    let v2_temp: LrcPtr<Documents::UH0> = v6.clone();
                                    let v3_temp: Documents::US9 = v4.get().clone();
                                    let v4_temp: Documents::US9 = Documents::US9::US9_2(0_u8, v5);
                                    v0_1.set(v0_1_temp);
                                    v1_1.set(v1_1_temp);
                                    v2.set(v2_temp);
                                    v3.set(v3_temp);
                                    v4.set(v4_temp);
                                    continue '_method41;
                                } else {
                                    if '`' == v5 {
                                        let v0_1_temp: string = v0_1.get().clone();
                                        let v1_1_temp: LrcPtr<Documents::UH1> = v1_1.get().clone();
                                        let v2_temp: LrcPtr<Documents::UH0> = v6.clone();
                                        let v3_temp: Documents::US9 = v4.get().clone();
                                        let v4_temp: Documents::US9 =
                                            Documents::US9::US9_2(0_u8, v5);
                                        v0_1.set(v0_1_temp);
                                        v1_1.set(v1_1_temp);
                                        v2.set(v2_temp);
                                        v3.set(v3_temp);
                                        v4.set(v4_temp);
                                        continue '_method41;
                                    } else {
                                        if ' ' == v5 {
                                            Documents::method42(
                                                string(""),
                                                if v0_1.get().clone() == string("") {
                                                    v1_1.get().clone()
                                                } else {
                                                    Documents::method43(
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
                                            Documents::method42(
                                                sprintf!("{}{}", v0_1.get().clone(), v5),
                                                v1_1.get().clone(),
                                                v6.clone(),
                                                v4.get().clone(),
                                            )
                                        }
                                    }
                                }
                            }
                        } else {
                            (
                                if v0_1.get().clone() == string("") {
                                    v1_1.get().clone()
                                } else {
                                    Documents::method43(
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
                    Documents::US9::US9_2(v4_2_0, v4_2_1) => {
                        let v53: char = match &v4.get().clone() {
                            Documents::US9::US9_2(_, x) => x.clone(),
                            _ => unreachable!(),
                        };
                        let v52: u8 = match &v4.get().clone() {
                            Documents::US9::US9_2(x, _) => x.clone(),
                            _ => unreachable!(),
                        };
                        if let Documents::UH0::UH0_1(v2_1_0, v2_1_1) = v2.get().clone().as_ref() {
                            let v55: LrcPtr<Documents::UH0> = match v2.get().clone().as_ref() {
                                Documents::UH0::UH0_1(_, x) => x.clone(),
                                _ => unreachable!(),
                            };
                            let v54: char = match v2.get().clone().as_ref() {
                                Documents::UH0::UH0_1(x, _) => x.clone(),
                                _ => unreachable!(),
                            };
                            if '\\' == v54 {
                                let v0_1_temp: string = v0_1.get().clone();
                                let v1_1_temp: LrcPtr<Documents::UH1> = v1_1.get().clone();
                                let v2_temp: LrcPtr<Documents::UH0> = v55.clone();
                                let v3_temp: Documents::US9 = v4.get().clone();
                                let v4_temp: Documents::US9 = Documents::US9::US9_1(v54);
                                v0_1.set(v0_1_temp);
                                v1_1.set(v1_1_temp);
                                v2.set(v2_temp);
                                v3.set(v3_temp);
                                v4.set(v4_temp);
                                continue '_method41;
                            } else {
                                if '`' == v54 {
                                    let v0_1_temp: string = v0_1.get().clone();
                                    let v1_1_temp: LrcPtr<Documents::UH1> = v1_1.get().clone();
                                    let v2_temp: LrcPtr<Documents::UH0> = v55.clone();
                                    let v3_temp: Documents::US9 = v4.get().clone();
                                    let v4_temp: Documents::US9 = Documents::US9::US9_1(v54);
                                    v0_1.set(v0_1_temp);
                                    v1_1.set(v1_1_temp);
                                    v2.set(v2_temp);
                                    v3.set(v3_temp);
                                    v4.set(v4_temp);
                                    continue '_method41;
                                } else {
                                    if let Documents::US9::US9_0 = &v3.get().clone() {
                                        if '\"' == v54 {
                                            Documents::method42(
                                                v0_1.get().clone(),
                                                v1_1.get().clone(),
                                                v55.clone(),
                                                v4.get().clone(),
                                            )
                                        } else {
                                            if 0_u8 == v52 {
                                                if '\\' == v53 {
                                                    if ' ' == v54 {
                                                        Documents::method42(
                                                            sprintf!("{} ", v0_1.get().clone()),
                                                            v1_1.get().clone(),
                                                            v55.clone(),
                                                            v4.get().clone(),
                                                        )
                                                    } else {
                                                        if 1_u8 == v52 {
                                                            if !(v3.get().clone()
                                                                == v4.get().clone())
                                                            {
                                                                let v0_1_temp: string = sprintf!(
                                                                    "{}\\{}",
                                                                    v0_1.get().clone(),
                                                                    v54
                                                                );
                                                                let v1_1_temp: LrcPtr<
                                                                    Documents::UH1,
                                                                > = v1_1.get().clone();
                                                                let v2_temp: LrcPtr<
                                                                    Documents::UH0,
                                                                > = v55.clone();
                                                                let v3_temp: Documents::US9 =
                                                                    v4.get().clone();
                                                                let v4_temp: Documents::US9 =
                                                                    v3.get().clone();
                                                                v0_1.set(v0_1_temp);
                                                                v1_1.set(v1_1_temp);
                                                                v2.set(v2_temp);
                                                                v3.set(v3_temp);
                                                                v4.set(v4_temp);
                                                                continue '_method41;
                                                            } else {
                                                                Documents::method42(
                                                                    sprintf!(
                                                                        "{}{}",
                                                                        v0_1.get().clone(),
                                                                        v54
                                                                    ),
                                                                    v1_1.get().clone(),
                                                                    v55.clone(),
                                                                    v4.get().clone(),
                                                                )
                                                            }
                                                        } else {
                                                            Documents::method42(
                                                                sprintf!(
                                                                    "{}{}",
                                                                    v0_1.get().clone(),
                                                                    v54
                                                                ),
                                                                v1_1.get().clone(),
                                                                v55.clone(),
                                                                v4.get().clone(),
                                                            )
                                                        }
                                                    }
                                                } else {
                                                    if '`' == v53 {
                                                        if ' ' == v54 {
                                                            Documents::method42(
                                                                sprintf!("{} ", v0_1.get().clone()),
                                                                v1_1.get().clone(),
                                                                v55.clone(),
                                                                v4.get().clone(),
                                                            )
                                                        } else {
                                                            if 1_u8 == v52 {
                                                                if !(v3.get().clone()
                                                                    == v4.get().clone())
                                                                {
                                                                    let v0_1_temp: string = sprintf!(
                                                                        "{}\\{}",
                                                                        v0_1.get().clone(),
                                                                        v54
                                                                    );
                                                                    let v1_1_temp: LrcPtr<
                                                                        Documents::UH1,
                                                                    > = v1_1.get().clone();
                                                                    let v2_temp: LrcPtr<
                                                                        Documents::UH0,
                                                                    > = v55.clone();
                                                                    let v3_temp: Documents::US9 =
                                                                        v4.get().clone();
                                                                    let v4_temp: Documents::US9 =
                                                                        v3.get().clone();
                                                                    v0_1.set(v0_1_temp);
                                                                    v1_1.set(v1_1_temp);
                                                                    v2.set(v2_temp);
                                                                    v3.set(v3_temp);
                                                                    v4.set(v4_temp);
                                                                    continue '_method41;
                                                                } else {
                                                                    Documents::method42(
                                                                        sprintf!(
                                                                            "{}{}",
                                                                            v0_1.get().clone(),
                                                                            v54
                                                                        ),
                                                                        v1_1.get().clone(),
                                                                        v55.clone(),
                                                                        v4.get().clone(),
                                                                    )
                                                                }
                                                            } else {
                                                                Documents::method42(
                                                                    sprintf!(
                                                                        "{}{}",
                                                                        v0_1.get().clone(),
                                                                        v54
                                                                    ),
                                                                    v1_1.get().clone(),
                                                                    v55.clone(),
                                                                    v4.get().clone(),
                                                                )
                                                            }
                                                        }
                                                    } else {
                                                        if ' ' == v54 {
                                                            Documents::method42(
                                                                sprintf!("{} ", v0_1.get().clone()),
                                                                v1_1.get().clone(),
                                                                v55.clone(),
                                                                v4.get().clone(),
                                                            )
                                                        } else {
                                                            if 1_u8 == v52 {
                                                                if !(v3.get().clone()
                                                                    == v4.get().clone())
                                                                {
                                                                    let v0_1_temp: string = sprintf!(
                                                                        "{}\\{}",
                                                                        v0_1.get().clone(),
                                                                        v54
                                                                    );
                                                                    let v1_1_temp: LrcPtr<
                                                                        Documents::UH1,
                                                                    > = v1_1.get().clone();
                                                                    let v2_temp: LrcPtr<
                                                                        Documents::UH0,
                                                                    > = v55.clone();
                                                                    let v3_temp: Documents::US9 =
                                                                        v4.get().clone();
                                                                    let v4_temp: Documents::US9 =
                                                                        v3.get().clone();
                                                                    v0_1.set(v0_1_temp);
                                                                    v1_1.set(v1_1_temp);
                                                                    v2.set(v2_temp);
                                                                    v3.set(v3_temp);
                                                                    v4.set(v4_temp);
                                                                    continue '_method41;
                                                                } else {
                                                                    Documents::method42(
                                                                        sprintf!(
                                                                            "{}{}",
                                                                            v0_1.get().clone(),
                                                                            v54
                                                                        ),
                                                                        v1_1.get().clone(),
                                                                        v55.clone(),
                                                                        v4.get().clone(),
                                                                    )
                                                                }
                                                            } else {
                                                                Documents::method42(
                                                                    sprintf!(
                                                                        "{}{}",
                                                                        v0_1.get().clone(),
                                                                        v54
                                                                    ),
                                                                    v1_1.get().clone(),
                                                                    v55.clone(),
                                                                    v4.get().clone(),
                                                                )
                                                            }
                                                        }
                                                    }
                                                }
                                            } else {
                                                if ' ' == v54 {
                                                    Documents::method42(
                                                        sprintf!("{} ", v0_1.get().clone()),
                                                        v1_1.get().clone(),
                                                        v55.clone(),
                                                        v4.get().clone(),
                                                    )
                                                } else {
                                                    if 1_u8 == v52 {
                                                        if !(v3.get().clone() == v4.get().clone()) {
                                                            let v0_1_temp: string = sprintf!(
                                                                "{}\\{}",
                                                                v0_1.get().clone(),
                                                                v54
                                                            );
                                                            let v1_1_temp: LrcPtr<Documents::UH1> =
                                                                v1_1.get().clone();
                                                            let v2_temp: LrcPtr<Documents::UH0> =
                                                                v55.clone();
                                                            let v3_temp: Documents::US9 =
                                                                v4.get().clone();
                                                            let v4_temp: Documents::US9 =
                                                                v3.get().clone();
                                                            v0_1.set(v0_1_temp);
                                                            v1_1.set(v1_1_temp);
                                                            v2.set(v2_temp);
                                                            v3.set(v3_temp);
                                                            v4.set(v4_temp);
                                                            continue '_method41;
                                                        } else {
                                                            Documents::method42(
                                                                sprintf!(
                                                                    "{}{}",
                                                                    v0_1.get().clone(),
                                                                    v54
                                                                ),
                                                                v1_1.get().clone(),
                                                                v55.clone(),
                                                                v4.get().clone(),
                                                            )
                                                        }
                                                    } else {
                                                        Documents::method42(
                                                            sprintf!(
                                                                "{}{}",
                                                                v0_1.get().clone(),
                                                                v54
                                                            ),
                                                            v1_1.get().clone(),
                                                            v55.clone(),
                                                            v4.get().clone(),
                                                        )
                                                    }
                                                }
                                            }
                                        }
                                    } else {
                                        if 0_u8 == v52 {
                                            if '\\' == v53 {
                                                if let Documents::US9::US9_1(v3_1_0) =
                                                    &v3.get().clone()
                                                {
                                                    if '\"'
                                                        == match &v3.get().clone() {
                                                            Documents::US9::US9_1(x) => x.clone(),
                                                            _ => unreachable!(),
                                                        }
                                                    {
                                                        let v0_1_temp: string = sprintf!(
                                                            "{}{}{}",
                                                            v0_1.get().clone(),
                                                            v53,
                                                            v54
                                                        );
                                                        let v1_1_temp: LrcPtr<Documents::UH1> =
                                                            v1_1.get().clone();
                                                        let v2_temp: LrcPtr<Documents::UH0> =
                                                            v55.clone();
                                                        let v3_temp: Documents::US9 =
                                                            v4.get().clone();
                                                        let v4_temp: Documents::US9 =
                                                            Documents::US9::US9_1('\"');
                                                        v0_1.set(v0_1_temp);
                                                        v1_1.set(v1_1_temp);
                                                        v2.set(v2_temp);
                                                        v3.set(v3_temp);
                                                        v4.set(v4_temp);
                                                        continue '_method41;
                                                    } else {
                                                        if '\"' == v54 {
                                                            let v0_1_temp: string = sprintf!(
                                                                "{}{}\"",
                                                                v0_1.get().clone(),
                                                                v53
                                                            );
                                                            let v1_1_temp: LrcPtr<Documents::UH1> =
                                                                v1_1.get().clone();
                                                            let v2_temp: LrcPtr<Documents::UH0> =
                                                                v55.clone();
                                                            let v3_temp: Documents::US9 =
                                                                v4.get().clone();
                                                            let v4_temp: Documents::US9 =
                                                                Documents::US9::US9_2(v52, v53);
                                                            v0_1.set(v0_1_temp);
                                                            v1_1.set(v1_1_temp);
                                                            v2.set(v2_temp);
                                                            v3.set(v3_temp);
                                                            v4.set(v4_temp);
                                                            continue '_method41;
                                                        } else {
                                                            if ' ' == v54 {
                                                                Documents::method42(
                                                                    sprintf!(
                                                                        "{} ",
                                                                        v0_1.get().clone()
                                                                    ),
                                                                    v1_1.get().clone(),
                                                                    v55.clone(),
                                                                    v4.get().clone(),
                                                                )
                                                            } else {
                                                                if 1_u8 == v52 {
                                                                    if !(v3.get().clone()
                                                                        == v4.get().clone())
                                                                    {
                                                                        let v0_1_temp: string = sprintf!(
                                                                            "{}\\{}",
                                                                            v0_1.get().clone(),
                                                                            v54
                                                                        );
                                                                        let v1_1_temp: LrcPtr<
                                                                            Documents::UH1,
                                                                        > = v1_1.get().clone();
                                                                        let v2_temp: LrcPtr<
                                                                            Documents::UH0,
                                                                        > = v55.clone();
                                                                        let v3_temp:
                                                                                         Documents::US9 =
                                                                                     v4.get().clone();
                                                                        let v4_temp:
                                                                                         Documents::US9 =
                                                                                     v3.get().clone();
                                                                        v0_1.set(v0_1_temp);
                                                                        v1_1.set(v1_1_temp);
                                                                        v2.set(v2_temp);
                                                                        v3.set(v3_temp);
                                                                        v4.set(v4_temp);
                                                                        continue '_method41;
                                                                    } else {
                                                                        Documents::method42(
                                                                            sprintf!(
                                                                                "{}{}",
                                                                                v0_1.get().clone(),
                                                                                v54
                                                                            ),
                                                                            v1_1.get().clone(),
                                                                            v55.clone(),
                                                                            v4.get().clone(),
                                                                        )
                                                                    }
                                                                } else {
                                                                    Documents::method42(
                                                                        sprintf!(
                                                                            "{}{}",
                                                                            v0_1.get().clone(),
                                                                            v54
                                                                        ),
                                                                        v1_1.get().clone(),
                                                                        v55.clone(),
                                                                        v4.get().clone(),
                                                                    )
                                                                }
                                                            }
                                                        }
                                                    }
                                                } else {
                                                    if '\"' == v54 {
                                                        let v0_1_temp: string = sprintf!(
                                                            "{}{}\"",
                                                            v0_1.get().clone(),
                                                            v53
                                                        );
                                                        let v1_1_temp: LrcPtr<Documents::UH1> =
                                                            v1_1.get().clone();
                                                        let v2_temp: LrcPtr<Documents::UH0> =
                                                            v55.clone();
                                                        let v3_temp: Documents::US9 =
                                                            v4.get().clone();
                                                        let v4_temp: Documents::US9 =
                                                            Documents::US9::US9_2(v52, v53);
                                                        v0_1.set(v0_1_temp);
                                                        v1_1.set(v1_1_temp);
                                                        v2.set(v2_temp);
                                                        v3.set(v3_temp);
                                                        v4.set(v4_temp);
                                                        continue '_method41;
                                                    } else {
                                                        if ' ' == v54 {
                                                            Documents::method42(
                                                                sprintf!("{} ", v0_1.get().clone()),
                                                                v1_1.get().clone(),
                                                                v55.clone(),
                                                                v4.get().clone(),
                                                            )
                                                        } else {
                                                            if 1_u8 == v52 {
                                                                if !(v3.get().clone()
                                                                    == v4.get().clone())
                                                                {
                                                                    let v0_1_temp: string = sprintf!(
                                                                        "{}\\{}",
                                                                        v0_1.get().clone(),
                                                                        v54
                                                                    );
                                                                    let v1_1_temp: LrcPtr<
                                                                        Documents::UH1,
                                                                    > = v1_1.get().clone();
                                                                    let v2_temp: LrcPtr<
                                                                        Documents::UH0,
                                                                    > = v55.clone();
                                                                    let v3_temp: Documents::US9 =
                                                                        v4.get().clone();
                                                                    let v4_temp: Documents::US9 =
                                                                        v3.get().clone();
                                                                    v0_1.set(v0_1_temp);
                                                                    v1_1.set(v1_1_temp);
                                                                    v2.set(v2_temp);
                                                                    v3.set(v3_temp);
                                                                    v4.set(v4_temp);
                                                                    continue '_method41;
                                                                } else {
                                                                    Documents::method42(
                                                                        sprintf!(
                                                                            "{}{}",
                                                                            v0_1.get().clone(),
                                                                            v54
                                                                        ),
                                                                        v1_1.get().clone(),
                                                                        v55.clone(),
                                                                        v4.get().clone(),
                                                                    )
                                                                }
                                                            } else {
                                                                Documents::method42(
                                                                    sprintf!(
                                                                        "{}{}",
                                                                        v0_1.get().clone(),
                                                                        v54
                                                                    ),
                                                                    v1_1.get().clone(),
                                                                    v55.clone(),
                                                                    v4.get().clone(),
                                                                )
                                                            }
                                                        }
                                                    }
                                                }
                                            } else {
                                                if '`' == v53 {
                                                    if let Documents::US9::US9_1(v3_1_0) =
                                                        &v3.get().clone()
                                                    {
                                                        if '\"'
                                                            == match &v3.get().clone() {
                                                                Documents::US9::US9_1(x) => {
                                                                    x.clone()
                                                                }
                                                                _ => unreachable!(),
                                                            }
                                                        {
                                                            let v0_1_temp: string = sprintf!(
                                                                "{}{}{}",
                                                                v0_1.get().clone(),
                                                                v53,
                                                                v54
                                                            );
                                                            let v1_1_temp: LrcPtr<Documents::UH1> =
                                                                v1_1.get().clone();
                                                            let v2_temp: LrcPtr<Documents::UH0> =
                                                                v55.clone();
                                                            let v3_temp: Documents::US9 =
                                                                v4.get().clone();
                                                            let v4_temp: Documents::US9 =
                                                                Documents::US9::US9_1('\"');
                                                            v0_1.set(v0_1_temp);
                                                            v1_1.set(v1_1_temp);
                                                            v2.set(v2_temp);
                                                            v3.set(v3_temp);
                                                            v4.set(v4_temp);
                                                            continue '_method41;
                                                        } else {
                                                            if '\"' == v54 {
                                                                let v0_1_temp: string = sprintf!(
                                                                    "{}{}\"",
                                                                    v0_1.get().clone(),
                                                                    v53
                                                                );
                                                                let v1_1_temp: LrcPtr<
                                                                    Documents::UH1,
                                                                > = v1_1.get().clone();
                                                                let v2_temp: LrcPtr<
                                                                    Documents::UH0,
                                                                > = v55.clone();
                                                                let v3_temp: Documents::US9 =
                                                                    v4.get().clone();
                                                                let v4_temp: Documents::US9 =
                                                                    Documents::US9::US9_2(v52, v53);
                                                                v0_1.set(v0_1_temp);
                                                                v1_1.set(v1_1_temp);
                                                                v2.set(v2_temp);
                                                                v3.set(v3_temp);
                                                                v4.set(v4_temp);
                                                                continue '_method41;
                                                            } else {
                                                                if ' ' == v54 {
                                                                    Documents::method42(
                                                                        sprintf!(
                                                                            "{} ",
                                                                            v0_1.get().clone()
                                                                        ),
                                                                        v1_1.get().clone(),
                                                                        v55.clone(),
                                                                        v4.get().clone(),
                                                                    )
                                                                } else {
                                                                    if 1_u8 == v52 {
                                                                        if !(v3.get().clone()
                                                                            == v4.get().clone())
                                                                        {
                                                                            let v0_1_temp: string = sprintf!(
                                                                                "{}\\{}",
                                                                                v0_1.get().clone(),
                                                                                v54
                                                                            );
                                                                            let v1_1_temp: LrcPtr<
                                                                                Documents::UH1,
                                                                            > = v1_1.get().clone();
                                                                            let v2_temp: LrcPtr<
                                                                                Documents::UH0,
                                                                            > = v55.clone();
                                                                            let v3_temp:
                                                                                             Documents::US9 =
                                                                                         v4.get().clone();
                                                                            let v4_temp:
                                                                                             Documents::US9 =
                                                                                         v3.get().clone();
                                                                            v0_1.set(v0_1_temp);
                                                                            v1_1.set(v1_1_temp);
                                                                            v2.set(v2_temp);
                                                                            v3.set(v3_temp);
                                                                            v4.set(v4_temp);
                                                                            continue '_method41;
                                                                        } else {
                                                                            Documents::method42(
                                                                                sprintf!(
                                                                                    "{}{}",
                                                                                    v0_1.get()
                                                                                        .clone(),
                                                                                    v54
                                                                                ),
                                                                                v1_1.get().clone(),
                                                                                v55.clone(),
                                                                                v4.get().clone(),
                                                                            )
                                                                        }
                                                                    } else {
                                                                        Documents::method42(
                                                                            sprintf!(
                                                                                "{}{}",
                                                                                v0_1.get().clone(),
                                                                                v54
                                                                            ),
                                                                            v1_1.get().clone(),
                                                                            v55.clone(),
                                                                            v4.get().clone(),
                                                                        )
                                                                    }
                                                                }
                                                            }
                                                        }
                                                    } else {
                                                        if '\"' == v54 {
                                                            let v0_1_temp: string = sprintf!(
                                                                "{}{}\"",
                                                                v0_1.get().clone(),
                                                                v53
                                                            );
                                                            let v1_1_temp: LrcPtr<Documents::UH1> =
                                                                v1_1.get().clone();
                                                            let v2_temp: LrcPtr<Documents::UH0> =
                                                                v55.clone();
                                                            let v3_temp: Documents::US9 =
                                                                v4.get().clone();
                                                            let v4_temp: Documents::US9 =
                                                                Documents::US9::US9_2(v52, v53);
                                                            v0_1.set(v0_1_temp);
                                                            v1_1.set(v1_1_temp);
                                                            v2.set(v2_temp);
                                                            v3.set(v3_temp);
                                                            v4.set(v4_temp);
                                                            continue '_method41;
                                                        } else {
                                                            if ' ' == v54 {
                                                                Documents::method42(
                                                                    sprintf!(
                                                                        "{} ",
                                                                        v0_1.get().clone()
                                                                    ),
                                                                    v1_1.get().clone(),
                                                                    v55.clone(),
                                                                    v4.get().clone(),
                                                                )
                                                            } else {
                                                                if 1_u8 == v52 {
                                                                    if !(v3.get().clone()
                                                                        == v4.get().clone())
                                                                    {
                                                                        let v0_1_temp: string = sprintf!(
                                                                            "{}\\{}",
                                                                            v0_1.get().clone(),
                                                                            v54
                                                                        );
                                                                        let v1_1_temp: LrcPtr<
                                                                            Documents::UH1,
                                                                        > = v1_1.get().clone();
                                                                        let v2_temp: LrcPtr<
                                                                            Documents::UH0,
                                                                        > = v55.clone();
                                                                        let v3_temp:
                                                                                         Documents::US9 =
                                                                                     v4.get().clone();
                                                                        let v4_temp:
                                                                                         Documents::US9 =
                                                                                     v3.get().clone();
                                                                        v0_1.set(v0_1_temp);
                                                                        v1_1.set(v1_1_temp);
                                                                        v2.set(v2_temp);
                                                                        v3.set(v3_temp);
                                                                        v4.set(v4_temp);
                                                                        continue '_method41;
                                                                    } else {
                                                                        Documents::method42(
                                                                            sprintf!(
                                                                                "{}{}",
                                                                                v0_1.get().clone(),
                                                                                v54
                                                                            ),
                                                                            v1_1.get().clone(),
                                                                            v55.clone(),
                                                                            v4.get().clone(),
                                                                        )
                                                                    }
                                                                } else {
                                                                    Documents::method42(
                                                                        sprintf!(
                                                                            "{}{}",
                                                                            v0_1.get().clone(),
                                                                            v54
                                                                        ),
                                                                        v1_1.get().clone(),
                                                                        v55.clone(),
                                                                        v4.get().clone(),
                                                                    )
                                                                }
                                                            }
                                                        }
                                                    }
                                                } else {
                                                    if '\"' == v54 {
                                                        let v0_1_temp: string = sprintf!(
                                                            "{}{}\"",
                                                            v0_1.get().clone(),
                                                            v53
                                                        );
                                                        let v1_1_temp: LrcPtr<Documents::UH1> =
                                                            v1_1.get().clone();
                                                        let v2_temp: LrcPtr<Documents::UH0> =
                                                            v55.clone();
                                                        let v3_temp: Documents::US9 =
                                                            v4.get().clone();
                                                        let v4_temp: Documents::US9 =
                                                            Documents::US9::US9_2(v52, v53);
                                                        v0_1.set(v0_1_temp);
                                                        v1_1.set(v1_1_temp);
                                                        v2.set(v2_temp);
                                                        v3.set(v3_temp);
                                                        v4.set(v4_temp);
                                                        continue '_method41;
                                                    } else {
                                                        if ' ' == v54 {
                                                            Documents::method42(
                                                                sprintf!("{} ", v0_1.get().clone()),
                                                                v1_1.get().clone(),
                                                                v55.clone(),
                                                                v4.get().clone(),
                                                            )
                                                        } else {
                                                            if 1_u8 == v52 {
                                                                if !(v3.get().clone()
                                                                    == v4.get().clone())
                                                                {
                                                                    let v0_1_temp: string = sprintf!(
                                                                        "{}\\{}",
                                                                        v0_1.get().clone(),
                                                                        v54
                                                                    );
                                                                    let v1_1_temp: LrcPtr<
                                                                        Documents::UH1,
                                                                    > = v1_1.get().clone();
                                                                    let v2_temp: LrcPtr<
                                                                        Documents::UH0,
                                                                    > = v55.clone();
                                                                    let v3_temp: Documents::US9 =
                                                                        v4.get().clone();
                                                                    let v4_temp: Documents::US9 =
                                                                        v3.get().clone();
                                                                    v0_1.set(v0_1_temp);
                                                                    v1_1.set(v1_1_temp);
                                                                    v2.set(v2_temp);
                                                                    v3.set(v3_temp);
                                                                    v4.set(v4_temp);
                                                                    continue '_method41;
                                                                } else {
                                                                    Documents::method42(
                                                                        sprintf!(
                                                                            "{}{}",
                                                                            v0_1.get().clone(),
                                                                            v54
                                                                        ),
                                                                        v1_1.get().clone(),
                                                                        v55.clone(),
                                                                        v4.get().clone(),
                                                                    )
                                                                }
                                                            } else {
                                                                Documents::method42(
                                                                    sprintf!(
                                                                        "{}{}",
                                                                        v0_1.get().clone(),
                                                                        v54
                                                                    ),
                                                                    v1_1.get().clone(),
                                                                    v55.clone(),
                                                                    v4.get().clone(),
                                                                )
                                                            }
                                                        }
                                                    }
                                                }
                                            }
                                        } else {
                                            if '\"' == v54 {
                                                let v0_1_temp: string =
                                                    sprintf!("{}{}\"", v0_1.get().clone(), v53);
                                                let v1_1_temp: LrcPtr<Documents::UH1> =
                                                    v1_1.get().clone();
                                                let v2_temp: LrcPtr<Documents::UH0> = v55.clone();
                                                let v3_temp: Documents::US9 = v4.get().clone();
                                                let v4_temp: Documents::US9 =
                                                    Documents::US9::US9_2(v52, v53);
                                                v0_1.set(v0_1_temp);
                                                v1_1.set(v1_1_temp);
                                                v2.set(v2_temp);
                                                v3.set(v3_temp);
                                                v4.set(v4_temp);
                                                continue '_method41;
                                            } else {
                                                if ' ' == v54 {
                                                    Documents::method42(
                                                        sprintf!("{} ", v0_1.get().clone()),
                                                        v1_1.get().clone(),
                                                        v55.clone(),
                                                        v4.get().clone(),
                                                    )
                                                } else {
                                                    if 1_u8 == v52 {
                                                        if !(v3.get().clone() == v4.get().clone()) {
                                                            let v0_1_temp: string = sprintf!(
                                                                "{}\\{}",
                                                                v0_1.get().clone(),
                                                                v54
                                                            );
                                                            let v1_1_temp: LrcPtr<Documents::UH1> =
                                                                v1_1.get().clone();
                                                            let v2_temp: LrcPtr<Documents::UH0> =
                                                                v55.clone();
                                                            let v3_temp: Documents::US9 =
                                                                v4.get().clone();
                                                            let v4_temp: Documents::US9 =
                                                                v3.get().clone();
                                                            v0_1.set(v0_1_temp);
                                                            v1_1.set(v1_1_temp);
                                                            v2.set(v2_temp);
                                                            v3.set(v3_temp);
                                                            v4.set(v4_temp);
                                                            continue '_method41;
                                                        } else {
                                                            Documents::method42(
                                                                sprintf!(
                                                                    "{}{}",
                                                                    v0_1.get().clone(),
                                                                    v54
                                                                ),
                                                                v1_1.get().clone(),
                                                                v55.clone(),
                                                                v4.get().clone(),
                                                            )
                                                        }
                                                    } else {
                                                        Documents::method42(
                                                            sprintf!(
                                                                "{}{}",
                                                                v0_1.get().clone(),
                                                                v54
                                                            ),
                                                            v1_1.get().clone(),
                                                            v55.clone(),
                                                            v4.get().clone(),
                                                        )
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        } else {
                            if let Documents::US9::US9_0 = &v3.get().clone() {
                                if 0_u8 == v52 {
                                    if '\\' == v53 {
                                        if 1_u8 == v52 {
                                            (
                                                if v0_1.get().clone() == string("") {
                                                    v1_1.get().clone()
                                                } else {
                                                    Documents::method43(
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
                                                    Documents::method43(
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
                                        if '`' == v53 {
                                            if 1_u8 == v52 {
                                                (
                                                    if v0_1.get().clone() == string("") {
                                                        v1_1.get().clone()
                                                    } else {
                                                        Documents::method43(
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
                                                        Documents::method43(
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
                                            if 1_u8 == v52 {
                                                (
                                                    if v0_1.get().clone() == string("") {
                                                        v1_1.get().clone()
                                                    } else {
                                                        Documents::method43(
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
                                                        Documents::method43(
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
                                } else {
                                    if 1_u8 == v52 {
                                        (
                                            if v0_1.get().clone() == string("") {
                                                v1_1.get().clone()
                                            } else {
                                                Documents::method43(
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
                                                Documents::method43(
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
                                if 0_u8 == v52 {
                                    if '\\' == v53 {
                                        if let Documents::US9::US9_1(v3_1_0) = &v3.get().clone() {
                                            if '\"'
                                                == match &v3.get().clone() {
                                                    Documents::US9::US9_1(x) => x.clone(),
                                                    _ => unreachable!(),
                                                }
                                            {
                                                if 1_u8 == v52 {
                                                    (
                                                        if v0_1.get().clone() == string("") {
                                                            v1_1.get().clone()
                                                        } else {
                                                            Documents::method43(
                                                                v1_1.get().clone(),
                                                                LrcPtr::new(Documents::UH1::UH1_1(
                                                                    v0_1.get().clone(),
                                                                    LrcPtr::new(
                                                                        Documents::UH1::UH1_0,
                                                                    ),
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
                                                            Documents::method43(
                                                                v1_1.get().clone(),
                                                                LrcPtr::new(Documents::UH1::UH1_1(
                                                                    v0_1.get().clone(),
                                                                    LrcPtr::new(
                                                                        Documents::UH1::UH1_0,
                                                                    ),
                                                                )),
                                                            )
                                                        },
                                                        v0_1.get().clone(),
                                                    )
                                                }
                                            } else {
                                                if 1_u8 == v52 {
                                                    (
                                                        if v0_1.get().clone() == string("") {
                                                            v1_1.get().clone()
                                                        } else {
                                                            Documents::method43(
                                                                v1_1.get().clone(),
                                                                LrcPtr::new(Documents::UH1::UH1_1(
                                                                    v0_1.get().clone(),
                                                                    LrcPtr::new(
                                                                        Documents::UH1::UH1_0,
                                                                    ),
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
                                                            Documents::method43(
                                                                v1_1.get().clone(),
                                                                LrcPtr::new(Documents::UH1::UH1_1(
                                                                    v0_1.get().clone(),
                                                                    LrcPtr::new(
                                                                        Documents::UH1::UH1_0,
                                                                    ),
                                                                )),
                                                            )
                                                        },
                                                        v0_1.get().clone(),
                                                    )
                                                }
                                            }
                                        } else {
                                            if 1_u8 == v52 {
                                                (
                                                    if v0_1.get().clone() == string("") {
                                                        v1_1.get().clone()
                                                    } else {
                                                        Documents::method43(
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
                                                        Documents::method43(
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
                                        if '`' == v53 {
                                            if let Documents::US9::US9_1(v3_1_0) = &v3.get().clone()
                                            {
                                                if '\"'
                                                    == match &v3.get().clone() {
                                                        Documents::US9::US9_1(x) => x.clone(),
                                                        _ => unreachable!(),
                                                    }
                                                {
                                                    if 1_u8 == v52 {
                                                        (
                                                            if v0_1.get().clone() == string("") {
                                                                v1_1.get().clone()
                                                            } else {
                                                                Documents::method43(v1_1.get().clone(),
                                                                                          LrcPtr::new(Documents::UH1::UH1_1(v0_1.get().clone(),
                                                                                                                            LrcPtr::new(Documents::UH1::UH1_0))))
                                                            },
                                                            v0_1.get().clone(),
                                                        )
                                                    } else {
                                                        (
                                                            if v0_1.get().clone() == string("") {
                                                                v1_1.get().clone()
                                                            } else {
                                                                Documents::method43(v1_1.get().clone(),
                                                                                          LrcPtr::new(Documents::UH1::UH1_1(v0_1.get().clone(),
                                                                                                                            LrcPtr::new(Documents::UH1::UH1_0))))
                                                            },
                                                            v0_1.get().clone(),
                                                        )
                                                    }
                                                } else {
                                                    if 1_u8 == v52 {
                                                        (
                                                            if v0_1.get().clone() == string("") {
                                                                v1_1.get().clone()
                                                            } else {
                                                                Documents::method43(v1_1.get().clone(),
                                                                                          LrcPtr::new(Documents::UH1::UH1_1(v0_1.get().clone(),
                                                                                                                            LrcPtr::new(Documents::UH1::UH1_0))))
                                                            },
                                                            v0_1.get().clone(),
                                                        )
                                                    } else {
                                                        (
                                                            if v0_1.get().clone() == string("") {
                                                                v1_1.get().clone()
                                                            } else {
                                                                Documents::method43(v1_1.get().clone(),
                                                                                          LrcPtr::new(Documents::UH1::UH1_1(v0_1.get().clone(),
                                                                                                                            LrcPtr::new(Documents::UH1::UH1_0))))
                                                            },
                                                            v0_1.get().clone(),
                                                        )
                                                    }
                                                }
                                            } else {
                                                if 1_u8 == v52 {
                                                    (
                                                        if v0_1.get().clone() == string("") {
                                                            v1_1.get().clone()
                                                        } else {
                                                            Documents::method43(
                                                                v1_1.get().clone(),
                                                                LrcPtr::new(Documents::UH1::UH1_1(
                                                                    v0_1.get().clone(),
                                                                    LrcPtr::new(
                                                                        Documents::UH1::UH1_0,
                                                                    ),
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
                                                            Documents::method43(
                                                                v1_1.get().clone(),
                                                                LrcPtr::new(Documents::UH1::UH1_1(
                                                                    v0_1.get().clone(),
                                                                    LrcPtr::new(
                                                                        Documents::UH1::UH1_0,
                                                                    ),
                                                                )),
                                                            )
                                                        },
                                                        v0_1.get().clone(),
                                                    )
                                                }
                                            }
                                        } else {
                                            if 1_u8 == v52 {
                                                (
                                                    if v0_1.get().clone() == string("") {
                                                        v1_1.get().clone()
                                                    } else {
                                                        Documents::method43(
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
                                                        Documents::method43(
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
                                } else {
                                    if 1_u8 == v52 {
                                        (
                                            if v0_1.get().clone() == string("") {
                                                v1_1.get().clone()
                                            } else {
                                                Documents::method43(
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
                                                Documents::method43(
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
                    }
                });
            }
        }
        pub fn method44(v0_1: LrcPtr<Documents::UH1>, v1_1: List<string>) -> List<string> {
            match v0_1.as_ref() {
                Documents::UH1::UH1_0 => v1_1.clone(),
                Documents::UH1::UH1_1(v0_1_1_0, v0_1_1_1) => cons(
                    match v0_1.as_ref() {
                        Documents::UH1::UH1_1(x, _) => x.clone(),
                        _ => unreachable!(),
                    },
                    Documents::method44(
                        match v0_1.as_ref() {
                            Documents::UH1::UH1_1(_, x) => x.clone(),
                            _ => unreachable!(),
                        },
                        v1_1.clone(),
                    ),
                ),
            }
        }
        pub fn method40(v0_1: string) -> Array<string> {
            let _v0: MutCell<Option<Option<string>>> = MutCell::new(None::<Option<string>>);
            _v0.set(Some(Some(v0_1)));
            {
                let v5: Option<string> = getValue(_v0.get().clone());
                let _v6: LrcPtr<MutCell<Option<Documents::US3>>> = refCell(None::<Documents::US3>);
                {
                    let x_3: Option<Documents::US3> = match &v5 {
                        None => None::<Documents::US3>,
                        Some(v5_0_0) => {
                            let x_1: string = v5_0_0.clone();
                            Some((Func0::new({
                                let x_1 = x_1.clone();
                                move || Documents::US3::US3_0(x_1.clone())
                            }))())
                        }
                    };
                    _v6.set(x_3)
                }
                {
                    let v11: Documents::US3 =
                        defaultValue(Documents::US3::US3_1, _v6.get().clone());
                    let v14: string = match &v11 {
                        Documents::US3::US3_0(v11_0_0) => match &v11 {
                            Documents::US3::US3_0(x) => x.clone(),
                            _ => unreachable!(),
                        },
                        _ => string(""),
                    };
                    let v15: i32 = length(v14.clone());
                    let v16: Array<char> = new_init(&'\u{0000}', v15);
                    let v17: LrcPtr<Documents::Mut5> = LrcPtr::new(Documents::Mut5 {
                        l0: MutCell::new(0_i32),
                    });
                    while Documents::method23(v15, v17.clone()) {
                        let v19: i32 = v17.l0.get().clone();
                        let v20: char = getCharAt(v14.clone(), v19);
                        v16.get_mut()[v19 as usize] = v20;
                        {
                            let v21: i32 = v19 + 1_i32;
                            v17.l0.set(v21);
                            ()
                        }
                    }
                    {
                        let v23: List<char> = ofArray(v16.clone());
                        toArray_1(Documents::method44(
                            (Documents::method41(
                                string(""),
                                LrcPtr::new(Documents::UH1::UH1_0),
                                foldBack(
                                    Func2::new(move |b0: char, b1: LrcPtr<Documents::UH0>| {
                                        (Documents::method38())(b0)(b1)
                                    }),
                                    v23,
                                    LrcPtr::new(Documents::UH0::UH0_0),
                                ),
                                Documents::US9::US9_0,
                                Documents::US9::US9_0,
                            ))
                            .0
                            .clone(),
                            empty::<string>(),
                        ))
                    }
                }
            }
        }
        pub fn closure25(unitVar: (), unitVar_1: ()) -> string {
            string("runtime.execute_with_options")
        }
        pub fn closure26(
            v0_1: Option<CancellationToken>,
            v1_1: string,
            v2: Array<(string, string)>,
            v3: Option<Func1<(bool, string, i32), Arc<Async<()>>>>,
            v4: Option<Func1<std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>, ()>>,
            v5: bool,
            v6: Option<string>,
            v7: string,
            v8: Vec<std::string::String>,
            unitVar: (),
        ) -> string {
            sprintf!(
                "file_name: {} / arguments: {:?} / options: {:?} / {}",
                v7,
                v8,
                (v0_1, v1_1, v2, v3, v4, v5, v6),
                Documents::closure6((), ())
            )
        }
        pub fn closure27(
            unitVar: (),
            v0_1: std::sync::Arc<std::sync::Mutex<Option<std::process::Child>>>,
        ) -> Documents::US10 {
            Documents::US10::US10_0(v0_1)
        }
        pub fn closure28(unitVar: (), v0_1: std::string::String) -> Documents::US10 {
            Documents::US10::US10_1(v0_1)
        }
        pub fn closure29(unitVar: (), unitVar_1: ()) -> string {
            string("runtime.execute_with_options / child error")
        }
        pub fn closure30(v0_1: std::string::String, unitVar: ()) -> string {
            sprintf!("error: {} / {}", v0_1, Documents::closure6((), ()))
        }
        pub fn method45(
            v0_1: std::sync::Arc<std::sync::mpsc::Receiver<std::string::String>>,
        ) -> std::sync::Arc<std::sync::mpsc::Receiver<std::string::String>> {
            v0_1
        }
        pub fn closure32(unitVar: (), v0_1: std::string::String) -> Documents::US12 {
            Documents::US12::US12_0(v0_1)
        }
        pub fn closure33(unitVar: (), v0_1: std::string::String) -> Documents::US12 {
            Documents::US12::US12_1(v0_1)
        }
        pub fn closure34(unitVar: (), unitVar_1: ()) -> string {
            string("runtime.stdio_line")
        }
        pub fn closure35(v0_1: std::string::String, unitVar: ()) -> string {
            sprintf!("e: {} / {}", v0_1, Documents::closure6((), ()))
        }
        pub fn closure36(v0_1: string, unitVar: ()) -> string {
            v0_1
        }
        pub fn closure31(
            v0_1: bool,
            v1_1: std::sync::Arc<std::sync::Mutex<std::sync::mpsc::Sender<std::string::String>>>,
            v2: Result<std::string::String, std::io::Error>,
        ) {
            let _v3: MutCell<Option<()>> = MutCell::new(None::<()>);
            let v4 = Documents::method29();
            let v6: Result<std::string::String, std::string::String> = v2.map_err(|x| v4(x));
            let v9: Documents::US12 = match &v6 {
                Err(v6_1_0) => Documents::closure33((), v6_1_0.clone()),
                Ok(v6_0_0) => Documents::closure32((), v6_0_0.clone()),
            };
            let v40: std::string::String = match &v9 {
                Documents::US12::US12_0(v9_0_0) => {
                    let v12: string = fable_library_rust::String_::fromString(v9_0_0.clone());
                    let v14: &encoding_rs::Encoding = encoding_rs::UTF_8;
                    let v16: std::borrow::Cow<[u8]> = v14.encode(&*v12).0;
                    let v18: &[u8] = v16.as_ref();
                    let v20: Result<&str, std::str::Utf8Error> = std::str::from_utf8(v18);
                    let v22: &str = v20.unwrap();
                    let v24: std::string::String = String::from(v22);
                    let v26: string = fable_library_rust::String_::fromString(v24.clone());
                    if v0_1 {
                        Documents::method3(
                            Documents::US0::US0_0,
                            Func0::new({
                                let v26 = v26.clone();
                                move || Documents::closure36(v26.clone(), ())
                            }),
                            Func0::new(move || Documents::closure6((), ())),
                        )
                    } else {
                        printfn!("{0}", v26.clone());
                        ()
                    }
                    v24
                }
                Documents::US12::US12_1(v9_1_0) => {
                    let v30: std::string::String = v9_1_0.clone();
                    Documents::method3(
                        Documents::US0::US0_4,
                        Func0::new(move || Documents::closure34((), ())),
                        Func0::new({
                            let v30 = v30.clone();
                            move || Documents::closure35(v30.clone(), ())
                        }),
                    );
                    {
                        let v34: string = sprintf!("\\e[4;7m{}\\e[0m", v30.clone());
                        let v36: &str = &*v34;
                        String::from(v36)
                    }
                }
            };
            let v42: bool = true;
            v1_1.lock().unwrap().send(v40).unwrap();
            _v3.set(Some(()));
            getValue(_v3.get().clone());
            ()
        }
        pub fn closure37(
            v0_1: bool,
            v1_1: std::sync::Arc<std::sync::Mutex<std::sync::mpsc::Sender<std::string::String>>>,
            v2: Result<std::string::String, std::io::Error>,
        ) {
            let _v3: MutCell<Option<()>> = MutCell::new(None::<()>);
            let v4 = Documents::method29();
            let v6: Result<std::string::String, std::string::String> = v2.map_err(|x| v4(x));
            let v9: Documents::US12 = match &v6 {
                Err(v6_1_0) => Documents::closure33((), v6_1_0.clone()),
                Ok(v6_0_0) => Documents::closure32((), v6_0_0.clone()),
            };
            let v41: std::string::String = match &v9 {
                Documents::US12::US12_0(v9_0_0) => {
                    let v12: string = fable_library_rust::String_::fromString(v9_0_0.clone());
                    let v14: &encoding_rs::Encoding = encoding_rs::UTF_8;
                    let v16: std::borrow::Cow<[u8]> = v14.encode(&*v12).0;
                    let v18: &[u8] = v16.as_ref();
                    let v20: Result<&str, std::str::Utf8Error> = std::str::from_utf8(v18);
                    let v22: &str = v20.unwrap();
                    let v24: std::string::String = String::from(v22);
                    let v27: string = sprintf!(
                        "\\e[4;7m{}\\e[0m",
                        fable_library_rust::String_::fromString(v24.clone())
                    );
                    if v0_1 {
                        Documents::method3(
                            Documents::US0::US0_0,
                            Func0::new({
                                let v27 = v27.clone();
                                move || Documents::closure36(v27.clone(), ())
                            }),
                            Func0::new(move || Documents::closure6((), ())),
                        )
                    } else {
                        printfn!("{0}", v27.clone());
                        ()
                    }
                    v24
                }
                Documents::US12::US12_1(v9_1_0) => {
                    let v31: std::string::String = v9_1_0.clone();
                    Documents::method3(
                        Documents::US0::US0_4,
                        Func0::new(move || Documents::closure34((), ())),
                        Func0::new({
                            let v31 = v31.clone();
                            move || Documents::closure35(v31.clone(), ())
                        }),
                    );
                    {
                        let v35: string = sprintf!("\\e[4;7m{}\\e[0m", v31.clone());
                        let v37: &str = &*v35;
                        String::from(v37)
                    }
                }
            };
            let v43: bool = true;
            v1_1.lock().unwrap().send(v41).unwrap();
            _v3.set(Some(()));
            getValue(_v3.get().clone());
            ()
        }
        pub fn method46(
            v0_1: std::sync::MutexGuard<std::process::ChildStdin>,
        ) -> std::sync::MutexGuard<std::process::ChildStdin> {
            v0_1
        }
        pub fn closure38(unitVar: (), v0_1: std::process::Output) -> Documents::US15 {
            Documents::US15::US15_0(v0_1)
        }
        pub fn closure39(unitVar: (), v0_1: std::string::String) -> Documents::US15 {
            Documents::US15::US15_1(v0_1)
        }
        pub fn closure40(unitVar: (), unitVar_1: ()) -> string {
            string("runtime.execute_with_options / output error")
        }
        pub fn closure41(v0_1: std::string::String, unitVar: ()) -> string {
            sprintf!("error: {} / {}", v0_1, Documents::closure6((), ()))
        }
        pub fn closure42(unitVar: (), unitVar_1: ()) -> string {
            string("runtime.execute_with_options / result")
        }
        pub fn closure43(v0_1: i32, v1_1: string, unitVar: ()) -> string {
            sprintf!(
                "exit_code: {} / std_trace.Length: {} / {}",
                v0_1,
                length(v1_1),
                Documents::closure6((), ())
            )
        }
        pub fn method47(v0_: i32, v0__1: string) -> LrcPtr<(i32, string)> {
            LrcPtr::new((v0_, v0__1))
        }
        pub fn closure44(
            v0_1: Option<CancellationToken>,
            v1_1: string,
            v2: Array<(string, string)>,
            v3: Option<Func1<(bool, string, i32), Arc<Async<()>>>>,
            v4: Option<Func1<std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>, ()>>,
            v5: bool,
            v6: Option<string>,
            unitVar: (),
        ) -> string {
            sprintf!(
                "execute_with_options_async / options: {:?}",
                (v0_1, v1_1, v2, v3, v4, v5, v6)
            )
        }
        pub fn method49() -> Func0<string> {
            Func0::new(move || Documents::closure6((), ()))
        }
        pub fn closure46(v0_1: string, unitVar: ()) -> string {
            v0_1
        }
        pub fn closure45(
            v0_1: Option<CancellationToken>,
            v1_1: string,
            v2: Array<(string, string)>,
            v3: Option<Func1<(bool, string, i32), Arc<Async<()>>>>,
            v4: Option<Func1<std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>, ()>>,
            v5: bool,
            v6: Option<string>,
            v7: (),
            v8: LrcPtr<ConcurrentStack_1<string>>,
            v9: (),
        ) {
            let _v10: MutCell<Option<Arc<Async<()>>>> = MutCell::new(None::<Arc<Async<()>>>);
            {
                let x: Arc<Async<()>> = defaultOf();
                _v10.set(Some(x))
            }
            {
                let v38: Arc<Async<()>> = getValue(_v10.get().clone());
                let _v39: MutCell<Option<()>> = MutCell::new(None::<()>);
                defaultOf::<()>();
                _v39.set(Some(()));
                getValue(_v39.get().clone());
                ()
            }
        }
        pub fn closure47(
            v0_1: Option<CancellationToken>,
            v1_1: string,
            v2: Array<(string, string)>,
            v3: Option<Func1<(bool, string, i32), Arc<Async<()>>>>,
            v4: Option<Func1<std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>, ()>>,
            v5: bool,
            v6: Option<string>,
            v7: (),
            v8: LrcPtr<ConcurrentStack_1<string>>,
            v9: (),
        ) {
            let _v10: MutCell<Option<Arc<Async<()>>>> = MutCell::new(None::<Arc<Async<()>>>);
            {
                let x: Arc<Async<()>> = defaultOf();
                _v10.set(Some(x))
            }
            {
                let v39: Arc<Async<()>> = getValue(_v10.get().clone());
                let _v40: MutCell<Option<()>> = MutCell::new(None::<()>);
                defaultOf::<()>();
                _v40.set(Some(()));
                getValue(_v40.get().clone());
                ()
            }
        }
        pub fn closure48(v0_1: (), unitVar: ()) {
            let _v1: MutCell<Option<bool>> = MutCell::new(None::<bool>);
            {
                let x: bool = unbox::<bool>(&defaultOf());
                _v1.set(Some(x))
            }
            if getValue(_v1.get().clone()) == false {
                let _v10: MutCell<Option<()>> = MutCell::new(None::<()>);
                defaultOf::<()>();
                _v10.set(Some(()));
                getValue(_v10.get().clone());
                ()
            }
        }
        pub fn closure49(v0_1: LrcPtr<TaskCanceledException>, unitVar: ()) -> string {
            sprintf!(
                "execute_with_options_async / WaitForExitAsync / ex: {:?}",
                v0_1
            )
        }
        pub fn method50() -> string {
            string("\n")
        }
        pub fn closure50(v0_1: i32, v1_1: string, unitVar: ()) -> string {
            sprintf!(
                "execute_with_options_async / exit_code: {} / output.Length: {}",
                v0_1,
                length(v1_1)
            )
        }
        pub fn method48(
            v0_1: Option<CancellationToken>,
            v1_1: string,
            v2: Array<(string, string)>,
            v3: Option<Func1<(bool, string, i32), Arc<Async<()>>>>,
            v4: Option<Func1<std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>, ()>>,
            v5: bool,
            v6: Option<string>,
        ) -> Arc<Async<(i32, string)>> {
            let _v7: MutCell<Option<Arc<Async<(i32, string)>>>> =
                MutCell::new(None::<Arc<Async<(i32, string)>>>);
            {
                let x: Arc<Async<(i32, string)>> = defaultOf();
                _v7.set(Some(x))
            }
            getValue(_v7.get().clone())
        }
        pub fn method35(
            v0_1: Option<CancellationToken>,
            v1_1: string,
            v2: Array<(string, string)>,
            v3: Option<Func1<(bool, string, i32), Arc<Async<()>>>>,
            v4: Option<Func1<std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>, ()>>,
            v5: bool,
            v6: Option<string>,
        ) -> (i32, string) {
            let _v7: MutCell<Option<(i32, string)>> = MutCell::new(None::<(i32, string)>);
            let v8: string = Documents::method36(
                v0_1.clone(),
                v1_1.clone(),
                v2.clone(),
                v3.clone(),
                v4.clone(),
                v5,
                v6.clone(),
            );
            let patternInput: (string, string) = Documents::method37();
            let v11: i32 = length(v8.clone());
            let v12: Array<char> = new_init(&'\u{0000}', v11);
            let v13: LrcPtr<Documents::Mut5> = LrcPtr::new(Documents::Mut5 {
                l0: MutCell::new(0_i32),
            });
            while Documents::method23(v11, v13.clone()) {
                let v15: i32 = v13.l0.get().clone();
                let v16: char = getCharAt(v8.clone(), v15);
                v12.get_mut()[v15 as usize] = v16;
                {
                    let v17: i32 = v15 + 1_i32;
                    v13.l0.set(v17);
                    ()
                }
            }
            {
                let v19: List<char> = ofArray(v12.clone());
                let patternInput_1: (string, string) = Documents::method39(
                    patternInput.1.clone(),
                    patternInput.0.clone(),
                    foldBack(
                        Func2::new(move |b0: char, b1: LrcPtr<Documents::UH0>| {
                            (Documents::method38())(b0)(b1)
                        }),
                        v19,
                        LrcPtr::new(Documents::UH0::UH0_0),
                    ),
                    Documents::US7::US7_0,
                );
                let v27: string = patternInput_1.0.clone();
                let v29: Array<string> = Documents::method40(patternInput_1.1.clone());
                let v31: Vec<string> = v29.to_vec();
                let v33: bool = true;
                let _result = v31
                    .into_iter()
                    .map(|x| {
                        //;
                        let v35: string = x;
                        let v37: &str = &*v35;
                        let v39: std::string::String = String::from(v37);
                        let v41: bool = true;
                        v39
                    })
                    .collect();
                let v43: Vec<std::string::String> = _result;
                Documents::method3(
                    Documents::US0::US0_1,
                    Func0::new(move || Documents::closure25((), ())),
                    Func0::new({
                        let v0_1 = v0_1.clone();
                        let v1_1 = v1_1.clone();
                        let v2 = v2.clone();
                        let v27 = v27.clone();
                        let v3 = v3.clone();
                        let v4 = v4.clone();
                        let v43 = v43.clone();
                        let v5 = v5.clone();
                        let v6 = v6.clone();
                        move || {
                            Documents::closure26(
                                v0_1.clone(),
                                v1_1.clone(),
                                v2.clone(),
                                v3.clone(),
                                v4.clone(),
                                v5,
                                v6.clone(),
                                v27.clone(),
                                v43.clone(),
                                (),
                            )
                        }
                    }),
                );
                let __result = Box::pin(async move {
                    //;
                    {
                        let _v48: MutCell<Option<LrcPtr<(i32, string)>>> =
                            MutCell::new(None::<LrcPtr<(i32, string)>>);
                        {
                            let x_12: LrcPtr<(i32, string)> = (Func0::new({
                                let v2 = v2.clone();
                                let v27 = v27.clone();
                                let v4 = v4.clone();
                                let v43 = v43.clone();
                                let v5 = v5.clone();
                                let v6 = v6.clone();
                                move || {
                                    let v50: std::process::Command =
                                        std::process::Command::new(&*v27.clone());
                                    let v52: bool = true;
                                    let mut v50 = v50;
                                    let v54: &mut std::process::Command =
                                        std::process::Command::args(&mut v50, &*v43.clone());
                                    let v56: std::process::Stdio = std::process::Stdio::piped();
                                    let v58: &mut std::process::Command =
                                        std::process::Command::stdout(
                                            v54,
                                            std::process::Stdio::piped(),
                                        );
                                    let v60: std::process::Stdio = std::process::Stdio::piped();
                                    let v62: &mut std::process::Command =
                                        std::process::Command::stderr(
                                            v58,
                                            std::process::Stdio::piped(),
                                        );
                                    let v64: std::process::Stdio = std::process::Stdio::piped();
                                    let v66: &mut std::process::Command =
                                        std::process::Command::stdin(
                                            v62,
                                            std::process::Stdio::piped(),
                                        );
                                    let _v67: LrcPtr<MutCell<Option<Documents::US3>>> =
                                        refCell(None::<Documents::US3>);
                                    {
                                        let x_2: Option<Documents::US3> = match &v6 {
                                            None => None::<Documents::US3>,
                                            Some(v6_0_0) => {
                                                let x: string = v6_0_0.clone();
                                                Some((Func0::new({
                                                    let x = x.clone();
                                                    move || Documents::US3::US3_0(x.clone())
                                                }))(
                                                ))
                                            }
                                        };
                                        _v67.set(x_2)
                                    }
                                    {
                                        let v72: Documents::US3 =
                                            defaultValue(Documents::US3::US3_1, _v67.get().clone());
                                        let v77: &mut std::process::Command = match &v72 {
                                            Documents::US3::US3_0(v72_0_0) => {
                                                std::process::Command::current_dir(
                                                    v66,
                                                    &*match &v72 {
                                                        Documents::US3::US3_0(x) => x.clone(),
                                                        _ => unreachable!(),
                                                    },
                                                )
                                            }
                                            _ => v66,
                                        };
                                        let v95: &mut std::process::Command = if count(v2.clone())
                                            as u64
                                            == 0_u64
                                        {
                                            v77
                                        } else {
                                            let v81: Vec<(string, string)> = v2.clone().to_vec();
                                            let v83: bool = true;
                                            let _result = v81.into_iter().fold(v77, |acc, x| {
                                                //;
                                                let v85: &mut std::process::Command = acc;
                                                let patternInput_2: (string, string) = x;
                                                let v90: &mut std::process::Command =
                                                    std::process::Command::env(
                                                        v85,
                                                        &*patternInput_2.0.clone(),
                                                        &*patternInput_2.1.clone(),
                                                    );
                                                let v92: bool = true;
                                                v90
                                            });
                                            _result
                                        };
                                        let v97: Result<std::process::Child, std::io::Error> =
                                            std::process::Command::spawn(v95);
                                        let v98 = Documents::method29();
                                        let v100: Result<std::process::Child, std::string::String> =
                                            v97.map_err(|x| v98(x));
                                        let v102: bool = true;
                                        let _result = v100.map(|x| {
                                            //;
                                            let v104: std::process::Child = x;
                                            let v107: std::sync::Mutex<
                                                Option<std::process::Child>,
                                            > = std::sync::Mutex::new(Some(v104));
                                            let v109: std::sync::Arc<
                                                std::sync::Mutex<Option<std::process::Child>>,
                                            > = std::sync::Arc::new(v107);
                                            let v111: bool = true;
                                            v109
                                        });
                                        let v113: Result<
                                            std::sync::Arc<
                                                std::sync::Mutex<Option<std::process::Child>>,
                                            >,
                                            std::string::String,
                                        > = _result;
                                        let v117: Documents::US10 = match v113 {
                                            Ok(x) => Func1::new(
                                                move |v: std::sync::Arc<
                                                    std::sync::Mutex<Option<std::process::Child>>,
                                                >| {
                                                    Documents::closure27((), v)
                                                },
                                            )(
                                                x
                                            ),
                                            Err(e) => {
                                                Func1::new(move |v_1: std::string::String| {
                                                    Documents::closure28((), v_1)
                                                })(e)
                                            }
                                        };
                                        let patternInput_4: (i32, Documents::US2, Documents::US11) =
                                            match &v117 {
                                                Documents::US10::US10_0(v117_0_0) => {
                                                    let v118: std::sync::Arc<
                                                        std::sync::Mutex<
                                                            Option<std::process::Child>,
                                                        >,
                                                    > = v117_0_0.clone();
                                                    let v120: std::process::ChildStdout = v118
                                                        .clone()
                                                        .lock()
                                                        .unwrap()
                                                        .as_mut()
                                                        .unwrap()
                                                        .stdout
                                                        .take()
                                                        .unwrap();
                                                    let v122: std::process::ChildStderr = v118
                                                        .clone()
                                                        .lock()
                                                        .unwrap()
                                                        .as_mut()
                                                        .unwrap()
                                                        .stderr
                                                        .take()
                                                        .unwrap();
                                                    let v124: std::process::ChildStdin = v118
                                                        .clone()
                                                        .lock()
                                                        .unwrap()
                                                        .as_mut()
                                                        .unwrap()
                                                        .stdin
                                                        .take()
                                                        .unwrap();
                                                    let v127: std::sync::Mutex<
                                                        Option<std::process::ChildStdout>,
                                                    > = std::sync::Mutex::new(Some(v120));
                                                    let v129: std::sync::Arc<
                                                        std::sync::Mutex<
                                                            Option<std::process::ChildStdout>,
                                                        >,
                                                    > = std::sync::Arc::new(v127);
                                                    let v132: std::sync::Mutex<
                                                        Option<std::process::ChildStderr>,
                                                    > = std::sync::Mutex::new(Some(v122));
                                                    let v134: std::sync::Arc<
                                                        std::sync::Mutex<
                                                            Option<std::process::ChildStderr>,
                                                        >,
                                                    > = std::sync::Arc::new(v132);
                                                    let v137: std::sync::Mutex<
                                                        Option<std::process::ChildStdin>,
                                                    > = std::sync::Mutex::new(Some(v124));
                                                    let v139: std::sync::Arc<
                                                        std::sync::Mutex<
                                                            Option<std::process::ChildStdin>,
                                                        >,
                                                    > = std::sync::Arc::new(v137);
                                                    let patternInput_3: (
                                                        std::sync::mpsc::Sender<
                                                            std::string::String,
                                                        >,
                                                        std::sync::Arc<
                                                            std::sync::mpsc::Receiver<
                                                                std::string::String,
                                                            >,
                                                        >,
                                                    ) = {
                                                        let (sender, receiver) =
                                                            std::sync::mpsc::channel();
                                                        (sender, std::sync::Arc::new(receiver))
                                                    };
                                                    let v143: std::sync::Arc<
                                                        std::sync::mpsc::Receiver<
                                                            std::string::String,
                                                        >,
                                                    > = Documents::method45(
                                                        patternInput_3.1.clone(),
                                                    );
                                                    let v145: bool = true;
                                                    let v143 = v143;
                                                    let v147: std::sync::Mutex<
                                                        std::sync::mpsc::Sender<
                                                            std::string::String,
                                                        >,
                                                    > = std::sync::Mutex::new(
                                                        patternInput_3.0.clone(),
                                                    );
                                                    let v149: std::sync::Arc<
                                                        std::sync::Mutex<
                                                            std::sync::mpsc::Sender<
                                                                std::string::String,
                                                            >,
                                                        >,
                                                    > = std::sync::Arc::new(v147);
                                                    let v151: std::sync::Arc<
                                                        std::sync::Mutex<
                                                            std::sync::mpsc::Sender<
                                                                std::string::String,
                                                            >,
                                                        >,
                                                    > = v149.clone();
                                                    let v153: std::sync::Arc<
                                                        std::sync::Mutex<
                                                            std::sync::mpsc::Sender<
                                                                std::string::String,
                                                            >,
                                                        >,
                                                    > = v149.clone();
                                                    let v155: std::sync::Mutex<
                                                        std::sync::Arc<
                                                            std::sync::mpsc::Receiver<
                                                                std::string::String,
                                                            >,
                                                        >,
                                                    > = std::sync::Mutex::new(v143);
                                                    let v157: std::sync::Arc<
                                                        std::sync::Mutex<
                                                            std::sync::Arc<
                                                                std::sync::mpsc::Receiver<
                                                                    std::string::String,
                                                                >,
                                                            >,
                                                        >,
                                                    > = std::sync::Arc::new(v155);
                                                    let v159: std::thread::JoinHandle<()> =
                                                        std::thread::spawn(move || {
                                                            //;
                                                            let v161: std::process::ChildStdout =
                                                                v129.lock()
                                                                    .unwrap()
                                                                    .take()
                                                                    .unwrap();
                                                            let v163:
                                                                            encoding_rs_io::DecodeReaderBytes<std::process::ChildStdout, Vec<u8>> =
                                                                        encoding_rs_io::DecodeReaderBytesBuilder::new().utf8_passthru(true).build(v161);
                                                            let v165: std::io::BufReader<
                                                                encoding_rs_io::DecodeReaderBytes<
                                                                    std::process::ChildStdout,
                                                                    Vec<u8>,
                                                                >,
                                                            > = std::io::BufReader::new(v163);
                                                            let v167:
                                                                            std::sync::Mutex<std::io::BufReader<encoding_rs_io::DecodeReaderBytes<std::process::ChildStdout, Vec<u8>>>> =
                                                                        std::sync::Mutex::new(v165);
                                                            let v169:
                                                                            std::sync::Arc<std::sync::Mutex<std::io::BufReader<encoding_rs_io::DecodeReaderBytes<std::process::ChildStdout, Vec<u8>>>>> =
                                                                        std::sync::Arc::new(v167);
                                                            let v170:
                                                                            string =
                                                                        string("true; for line in std::io::BufRead::lines(std::io::Read::by_ref(&mut *$0.lock().unwrap())).collect::<Vec<_>>() { $1(line) }");
                                                            let v172: bool = true;
                                                            for line in std::io::BufRead::lines(
                                                                std::io::Read::by_ref(
                                                                    &mut *v169.lock().unwrap(),
                                                                ),
                                                            )
                                                            .collect::<Vec<_>>()
                                                            {
                                                                Func1::new({
                                                                    let v151 = v151.clone();
                                                                    move
                                                                                                                                                                                                              |v_2:
                                                                                                                                                                                                                   Result<std::string::String,
                                                                                                                                                                                                                          std::io::Error>|
                                                                                                                                                                                                              Documents::closure31(v5,
                                                                                                                                                                                                                                   v151.clone(),
                                                                                                                                                                                                                                   v_2)
                                                                })(
                                                                    line
                                                                )
                                                            }
                                                            let v174: bool = true;
                                                        });
                                                    let v176: std::thread::JoinHandle<()> =
                                                        std::thread::spawn(move || {
                                                            //;
                                                            let v178: std::process::ChildStderr =
                                                                v134.lock()
                                                                    .unwrap()
                                                                    .take()
                                                                    .unwrap();
                                                            let v180:
                                                                            encoding_rs_io::DecodeReaderBytes<std::process::ChildStderr, Vec<u8>> =
                                                                        encoding_rs_io::DecodeReaderBytesBuilder::new().utf8_passthru(true).build(v178);
                                                            let v182: std::io::BufReader<
                                                                encoding_rs_io::DecodeReaderBytes<
                                                                    std::process::ChildStderr,
                                                                    Vec<u8>,
                                                                >,
                                                            > = std::io::BufReader::new(v180);
                                                            let v184:
                                                                            std::sync::Mutex<std::io::BufReader<encoding_rs_io::DecodeReaderBytes<std::process::ChildStderr, Vec<u8>>>> =
                                                                        std::sync::Mutex::new(v182);
                                                            let v186:
                                                                            std::sync::Arc<std::sync::Mutex<std::io::BufReader<encoding_rs_io::DecodeReaderBytes<std::process::ChildStderr, Vec<u8>>>>> =
                                                                        std::sync::Arc::new(v184);
                                                            let v187:
                                                                            string =
                                                                        string("true; for line in std::io::BufRead::lines(std::io::Read::by_ref(&mut *$0.lock().unwrap())).collect::<Vec<_>>() { $1(line) }");
                                                            let v189: bool = true;
                                                            for line in std::io::BufRead::lines(
                                                                std::io::Read::by_ref(
                                                                    &mut *v186.lock().unwrap(),
                                                                ),
                                                            )
                                                            .collect::<Vec<_>>()
                                                            {
                                                                Func1::new({
                                                                    let v149 = v149.clone();
                                                                    move
                                                                                                                                                                                                              |v_3:
                                                                                                                                                                                                                   Result<std::string::String,
                                                                                                                                                                                                                          std::io::Error>|
                                                                                                                                                                                                              Documents::closure37(v5,
                                                                                                                                                                                                                                   v149.clone(),
                                                                                                                                                                                                                                   v_3)
                                                                })(
                                                                    line
                                                                )
                                                            }
                                                            let v191: bool = true;
                                                        });
                                                    let _v192: LrcPtr<
                                                        MutCell<Option<Documents::US13>>,
                                                    > = refCell(None::<Documents::US13>);
                                                    {
                                                        let x_5: Option<Documents::US13> = match &v4
                                                        {
                                                            None => None::<Documents::US13>,
                                                            Some(v4_0_0) => {
                                                                let x_3 = v4_0_0.clone();
                                                                Some((Func0::new({
                                                                    let x_3 = x_3.clone();
                                                                    move || {
                                                                        Documents::US13::US13_0(
                                                                            x_3.clone(),
                                                                        )
                                                                    }
                                                                }))(
                                                                ))
                                                            }
                                                        };
                                                        _v192.set(x_5)
                                                    }
                                                    {
                                                        let v197: Documents::US13 = defaultValue(
                                                            Documents::US13::US13_1,
                                                            _v192.get().clone(),
                                                        );
                                                        match &v197 {
                                                            Documents::US13::US13_0(v197_0_0) => {
                                                                let v200: Option<
                                                                    std::process::ChildStdin,
                                                                > = v139.lock().unwrap().take();
                                                                let v202: bool = true;
                                                                let _result = v200.map(|x| { //;
                                                                                let v204:
                                                                                        std::process::ChildStdin =
                                                                                    x;
                                                                                let v206:
                                                                                        std::sync::Mutex<std::process::ChildStdin> =
                                                                                    std::sync::Mutex::new(v204);
                                                                                let v208:
                                                                                        std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>> =
                                                                                    std::sync::Arc::new(v206);
                                                                                let v210:
                                                                                        bool =
                                                                                    true; v208 });
                                                                let v212:
                                                                                        Option<std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>> =
                                                                                    _result;
                                                                let _v213: LrcPtr<
                                                                    MutCell<
                                                                        Option<Documents::US14>,
                                                                    >,
                                                                > = refCell(
                                                                    None::<Documents::US14>,
                                                                );
                                                                {
                                                                    let x_8: Option<
                                                                        Documents::US14,
                                                                    > = match &v212 {
                                                                        None => {
                                                                            None::<Documents::US14>
                                                                        }
                                                                        Some(v212_0_0) => {
                                                                            let x_6:
                                                                                                        std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>> =
                                                                                                    v212_0_0.clone();
                                                                            Some((Func0::new({
                                                                                let x_6 =
                                                                                    x_6.clone();
                                                                                move || {
                                                                                    Documents::US14::US14_0(x_6.clone())
                                                                                }
                                                                            }))(
                                                                            ))
                                                                        }
                                                                    };
                                                                    _v213.set(x_8)
                                                                }
                                                                {
                                                                    let v218: Documents::US14 =
                                                                        defaultValue(
                                                                            Documents::US14::US14_1,
                                                                            _v213.get().clone(),
                                                                        );
                                                                    match &v218 {
                                                                        Documents::US14::US14_0(
                                                                            v218_0_0,
                                                                        ) => {
                                                                            let v219:
                                                                                                    std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>> =
                                                                                                match &v218
                                                                                                    {
                                                                                                    Documents::US14::US14_0(x)
                                                                                                    =>
                                                                                                    x.clone(),
                                                                                                    _
                                                                                                    =>
                                                                                                    unreachable!(),
                                                                                                };
                                                                            (match &v197
                                                                                                 {
                                                                                                 Documents::US13::US13_0(x)
                                                                                                 =>
                                                                                                 x.clone(),
                                                                                                 _
                                                                                                 =>
                                                                                                 unreachable!(),
                                                                                             })(v219.clone());
                                                                            {
                                                                                let v221:
                                                                                                        Result<std::sync::MutexGuard<std::process::ChildStdin>,
                                                                                                               std::sync::PoisonError<std::sync::MutexGuard<std::process::ChildStdin>>> =
                                                                                                    v219.lock();
                                                                                let v224:
                                                                                                        std::sync::MutexGuard<std::process::ChildStdin> =
                                                                                                    Documents::method46(v221.unwrap());
                                                                                let v226: bool =
                                                                                    true;
                                                                                let mut v224 = v224;
                                                                                let v228: bool =
                                                                                    true;
                                                                                std::io::Write::flush(&mut *v224).unwrap();
                                                                                ()
                                                                            }
                                                                        }
                                                                        _ => (),
                                                                    }
                                                                }
                                                            }
                                                            _ => (),
                                                        }
                                                        {
                                                            let v230: Result<
                                                                std::process::Output,
                                                                std::io::Error,
                                                            > = v118
                                                                .lock()
                                                                .unwrap()
                                                                .take()
                                                                .unwrap()
                                                                .wait_with_output();
                                                            let v231 = Documents::method29();
                                                            let v233: Result<
                                                                std::process::Output,
                                                                std::string::String,
                                                            > = v230.map_err(|x| v231(x));
                                                            let v235: bool = true;
                                                            v159.join().unwrap();
                                                            let v237: bool = true;
                                                            v176.join().unwrap();
                                                            let v240: Documents::US15 = match &v233
                                                            {
                                                                Err(v233_1_0) => {
                                                                    Documents::closure39(
                                                                        (),
                                                                        v233_1_0.clone(),
                                                                    )
                                                                }
                                                                Ok(v233_0_0) => {
                                                                    Documents::closure38(
                                                                        (),
                                                                        v233_0_0.clone(),
                                                                    )
                                                                }
                                                            };
                                                            match &v240 {
                                                                Documents::US15::US15_0(
                                                                    v240_0_0,
                                                                ) => (
                                                                    v240_0_0
                                                                        .clone()
                                                                        .status
                                                                        .code()
                                                                        .unwrap(),
                                                                    Documents::US2::US2_1,
                                                                    Documents::US11::US11_0(v157),
                                                                ),
                                                                Documents::US15::US15_1(
                                                                    v240_1_0,
                                                                ) => {
                                                                    let v246: std::string::String =
                                                                        v240_1_0.clone();
                                                                    Documents::method3(
                                                                        Documents::US0::US0_4,
                                                                        Func0::new(move || {
                                                                            Documents::closure40(
                                                                                (),
                                                                                (),
                                                                            )
                                                                        }),
                                                                        Func0::new({
                                                                            let v246 = v246.clone();
                                                                            move || {
                                                                                Documents::closure41(
                                                                                    v246.clone(),
                                                                                    (),
                                                                                )
                                                                            }
                                                                        }),
                                                                    );
                                                                    (
                                                                        -2_i32,
                                                                        Documents::US2::US2_0(
                                                                            v246.clone(),
                                                                        ),
                                                                        Documents::US11::US11_1,
                                                                    )
                                                                }
                                                            }
                                                        }
                                                    }
                                                }
                                                Documents::US10::US10_1(v117_1_0) => {
                                                    let v258: std::string::String =
                                                        v117_1_0.clone();
                                                    Documents::method3(
                                                        Documents::US0::US0_4,
                                                        Func0::new(move || {
                                                            Documents::closure29((), ())
                                                        }),
                                                        Func0::new({
                                                            let v258 = v258.clone();
                                                            move || {
                                                                Documents::closure30(
                                                                    v258.clone(),
                                                                    (),
                                                                )
                                                            }
                                                        }),
                                                    );
                                                    (
                                                        -1_i32,
                                                        Documents::US2::US2_0(v258.clone()),
                                                        Documents::US11::US11_1,
                                                    )
                                                }
                                            };
                                        let v269: Documents::US11 = patternInput_4.2.clone();
                                        let v268: Documents::US2 = patternInput_4.1.clone();
                                        let v267: i32 = patternInput_4.0.clone();
                                        let v276: Documents::US2 = match &v269 {
                                            Documents::US11::US11_0(v269_0_0) => {
                                                Documents::US2::US2_0(
                                                    match &v269 {
                                                        Documents::US11::US11_0(x) => x.clone(),
                                                        _ => unreachable!(),
                                                    }
                                                    .lock()
                                                    .unwrap()
                                                    .iter()
                                                    .collect::<Vec<String>>()
                                                    .join("\n"),
                                                )
                                            }
                                            _ => Documents::US2::US2_1,
                                        };
                                        let v283: Documents::US3 = match &v276 {
                                            Documents::US2::US2_0(v276_0_0) => {
                                                Documents::US3::US3_0(
                                                    fable_library_rust::String_::fromString(
                                                        match &v276 {
                                                            Documents::US2::US2_0(x) => x.clone(),
                                                            _ => unreachable!(),
                                                        },
                                                    ),
                                                )
                                            }
                                            _ => Documents::US3::US3_1,
                                        };
                                        let v290: Documents::US3 = match &v268 {
                                            Documents::US2::US2_0(v268_0_0) => {
                                                Documents::US3::US3_0(
                                                    fable_library_rust::String_::fromString(
                                                        match &v268 {
                                                            Documents::US2::US2_0(x) => x.clone(),
                                                            _ => unreachable!(),
                                                        },
                                                    ),
                                                )
                                            }
                                            _ => Documents::US3::US3_1,
                                        };
                                        let v294: string = match &v290 {
                                            Documents::US3::US3_0(v290_0_0) => match &v290 {
                                                Documents::US3::US3_0(x) => x.clone(),
                                                _ => unreachable!(),
                                            },
                                            _ => string(""),
                                        };
                                        let v297: string = match &v283 {
                                            Documents::US3::US3_0(v283_0_0) => match &v283 {
                                                Documents::US3::US3_0(x) => x.clone(),
                                                _ => unreachable!(),
                                            },
                                            _ => v294,
                                        };
                                        Documents::method3(
                                            Documents::US0::US0_0,
                                            Func0::new(move || Documents::closure42((), ())),
                                            Func0::new({
                                                let v267 = v267.clone();
                                                let v297 = v297.clone();
                                                move || Documents::closure43(v267, v297.clone(), ())
                                            }),
                                        );
                                        LrcPtr::new((v267, v297.clone()))
                                    }
                                }
                            }))();
                            _v48.set(Some(x_12))
                        }
                        {
                            let v302: LrcPtr<(i32, string)> = getValue(_v48.get().clone());
                            let v303: LrcPtr<(i32, string)> =
                                Documents::method47(v302.0.clone(), v302.1.clone());
                            v303
                        }
                    }
                });
                {
                    {
                        //;
                        {
                            let v307: std::pin::Pin<
                                Box<dyn std::future::Future<Output = LrcPtr<(i32, string)>>>,
                            > = __result;
                            let v309: LrcPtr<(i32, string)> = futures_lite::future::block_on(v307);
                            _v7.set(Some((v309.0.clone(), v309.1.clone())));
                            {
                                let patternInput_5: (i32, string) = getValue(_v7.get().clone());
                                (patternInput_5.0.clone(), patternInput_5.1.clone())
                            }
                        }
                    }
                }
            }
        }
        pub fn method51(v0_1: string, v1_1: string, v2: string) -> (string, string) {
            let _v3: MutCell<Option<string>> = MutCell::new(None::<string>);
            let v5: &str = &*v1_1.clone();
            let v7: std::string::String = String::from(v5);
            let v9: std::path::PathBuf = std::path::PathBuf::from(v7);
            let v11: Option<&std::ffi::OsStr> = v9.file_name();
            let v13: &std::ffi::OsStr = v11.unwrap();
            let v15: std::ffi::OsString = v13.to_os_string();
            let v17: Option<&str> = v15.to_str();
            let v19: &str = v17.unwrap();
            let v21: std::string::String = String::from(v19);
            {
                let x: string = fable_library_rust::String_::fromString(v21);
                _v3.set(Some(x))
            }
            {
                let v31: string = Documents::method11(v2, getValue(_v3.get().clone()));
                let v35: string = getSlice(
                    v1_1.clone(),
                    Some(0_i32),
                    Some(lastIndexOf(v1_1.clone(), string(".")) - 1_i32),
                );
                let v38: string = getSlice(
                    v31.clone(),
                    Some(0_i32),
                    Some(lastIndexOf(v31.clone(), string(".")) - 1_i32),
                );
                let v41: bool = endsWith(v0_1.clone(), string(".md"), false) == false;
                (
                    if v41 {
                        sprintf!("{}.{}", v31, v0_1.clone())
                    } else {
                        sprintf!("{}.{}", v38, v0_1.clone())
                    },
                    if v41 {
                        sprintf!("{}.{}", v1_1, v0_1.clone())
                    } else {
                        sprintf!("{}.{}", v35, v0_1)
                    },
                )
            }
        }
        pub fn closure51(unitVar: (), v0_1: u8) -> string {
            let v2: string = string("format!(\"{:02x}\", $0)");
            let v3: std::string::String = format!("{:02x}", v0_1);
            fable_library_rust::String_::fromString(v3)
        }
        pub fn method52() -> string {
            string("")
        }
        pub fn closure52(unitVar: (), unitVar_1: ()) -> string {
            let v0_1: string =
                string("documents.run / par_map / origin_hash |> sm\'.contains local_git_hash |> not / hash2 = None || hash1 <>. (hash2 |> optionm.value)");
            v0_1
        }
        pub fn closure53(
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
            v10: Documents::US3,
            unitVar: (),
        ) -> string {
            sprintf!("file: {} / real_path: {} / relative_path: {} / origin_hash_exit_code: {} / origin_hash: {} / local_git_hash_exit_code: {} / local_git_hash: {} / hash1: {} / hash2: {:?} / dist_path: {} / cache_path: {} / {}",
                     v1_1, v2, v0_1, v4, v3, v7, v6, v9, v10, v5, v8,
                     Documents::closure6((), ()))
        }
        pub fn method53(v0_1: string) -> string {
            v0_1
        }
        pub fn method55(v0_1: i32, v1_1: LrcPtr<Documents::Mut6>) -> bool {
            v1_1.l0.get().clone() < v0_1
        }
        pub fn method56(v0_1: string) -> string {
            v0_1
        }
        pub fn method57(
            v0_1: std::sync::MutexGuard<std::process::ChildStdin>,
        ) -> std::sync::MutexGuard<std::process::ChildStdin> {
            v0_1
        }
        pub fn closure56(
            v0_1: string,
            v1_1: std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>,
        ) {
            let v3: Result<
                std::sync::MutexGuard<std::process::ChildStdin>,
                std::sync::PoisonError<std::sync::MutexGuard<std::process::ChildStdin>>,
            > = v1_1.lock();
            let v5: std::sync::MutexGuard<std::process::ChildStdin> = v3.unwrap();
            let v6: string = Documents::method56(v0_1);
            let v8: &[u8] = v6.as_bytes();
            let v9: std::sync::MutexGuard<std::process::ChildStdin> = Documents::method57(v5);
            let v11: bool = true;
            let mut v9 = v9;
            let v13: bool = true;
            std::io::Write::write_all(&mut *v9, v8).unwrap();
            ()
        }
        pub fn method58(v0_1: i32, v1_1: LrcPtr<Documents::Mut7>) -> bool {
            v1_1.l0.get().clone() < v0_1
        }
        pub fn method59(v0_1: string) -> string {
            v0_1
        }
        pub fn closure57(unitVar: (), unitVar_1: ()) -> string {
            string("documents.hangul")
        }
        pub fn closure58(v0_1: string, v1_1: i32, v2: string, unitVar: ()) -> string {
            sprintf!(
                "exit_code: {:?} / result_len: {} / output_path: {} / {}",
                v1_1,
                length(v2),
                v0_1,
                Documents::closure6((), ())
            )
        }
        pub fn method54(v0_1: string, v1_1: string, v2: string, v3: string) -> Documents::US19 {
            let _v4: MutCell<Option<string>> = MutCell::new(None::<string>);
            let _v5: MutCell<Option<Vec<u8>>> = MutCell::new(None::<Vec<u8>>);
            {
                let x: Vec<u8> = std::fs::read(&*v3).unwrap();
                _v5.set(Some(x))
            }
            {
                let v15: Vec<u8> = getValue(_v5.get().clone());
                let v17: Result<std::string::String, std::string::FromUtf8Error> =
                    std::string::String::from_utf8(v15);
                let v19: std::string::String = v17.unwrap();
                {
                    let x_1: string = fable_library_rust::String_::fromString(v19);
                    _v4.set(Some(x_1))
                }
                {
                    let v29: Array<string> =
                        split(getValue(_v4.get().clone()), string("\n"), -1_i32, 0_i32);
                    let v30: i32 = count(v29.clone());
                    let v31: Array<string> = new_init(&string(""), v30);
                    let v32: LrcPtr<Documents::Mut5> = LrcPtr::new(Documents::Mut5 {
                        l0: MutCell::new(0_i32),
                    });
                    while Documents::method23(v30, v32.clone()) {
                        let v34: i32 = v32.l0.get().clone();
                        let v36: string = trim(v29[v34].clone());
                        v31.get_mut()[v34 as usize] = v36;
                        {
                            let v37: i32 = v34 + 1_i32;
                            v32.l0.set(v37);
                            ()
                        }
                    }
                    {
                        let v38: i32 = count(v31.clone());
                        let v39: Array<string> = new_init(&string(""), v38);
                        let v40: LrcPtr<Documents::Mut6> = LrcPtr::new(Documents::Mut6 {
                            l0: MutCell::new(0_i32),
                            l1: MutCell::new(0_i32),
                        });
                        while Documents::method55(v38, v40.clone()) {
                            let v42: i32 = v40.l0.get().clone();
                            let v43: i32 = v40.l1.get().clone();
                            let v44: string = v31[v42].clone();
                            let v48: i32 = if string("") != v44.clone() {
                                v39.get_mut()[v43 as usize] = v44;
                                v43 + 1_i32
                            } else {
                                v43
                            };
                            let v49: i32 = v42 + 1_i32;
                            v40.l0.set(v49);
                            v40.l1.set(v48);
                            ()
                        }
                        {
                            let v50: i32 = v40.l1.get().clone();
                            let v51: Array<string> = new_init(&string(""), v50);
                            let v52: LrcPtr<Documents::Mut5> = LrcPtr::new(Documents::Mut5 {
                                l0: MutCell::new(0_i32),
                            });
                            while Documents::method23(v50, v52.clone()) {
                                let v54: i32 = v52.l0.get().clone();
                                let v55: string = v39[v54].clone();
                                v51.get_mut()[v54 as usize] = v55;
                                {
                                    let v56: i32 = v54 + 1_i32;
                                    v52.l0.set(v56);
                                    ()
                                }
                            }
                            {
                                let v57: LrcPtr<dyn IEnumerable_1<string>> = delay(Func0::new({
                                    let v51 = v51.clone();
                                    move || {
                                        map(
                                            Func1::new({
                                                let v51 = v51.clone();
                                                move |i: i32| v51[i].clone()
                                            }),
                                            rangeNumeric(0_i32, 1_i32, count(v51.clone()) - 1_i32),
                                        )
                                    }
                                }));
                                let v62: string =
                                    sprintf!("{}\n\n", join(Documents::method50(), toArray(v57)));
                                let _v68: MutCell<Option<bool>> = MutCell::new(None::<bool>);
                                {
                                    let x_2: bool = cfg!(windows);
                                    _v68.set(Some(x_2))
                                }
                                {
                                    let patternInput: (i32, string) =
                                        Documents::method35(None::<CancellationToken>,
                                                            sprintf!("{} {}",
                                                                     Documents::method11(v0_1,
                                                                                         sprintf!("../vault/deps/hangulize/cmd/hangulize/hangulize{}",
                                                                                                  if getValue(_v68.get().clone())
                                                                                                     {
                                                                                                      string(".exe")
                                                                                                  } else {
                                                                                                      string("")
                                                                                                  })),
                                                                     v1_1),
                                                            new_empty::<(string,
                                                                         string)>(),
                                                            None::<Func1<(bool,
                                                                          string,
                                                                          i32),
                                                                         Arc<Async<()>>>>,
                                                            Some(Func1::new({
                                                                                let v62
                                                                                    =
                                                                                    v62.clone();
                                                                                move
                                                                                    |v:
                                                                                         std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>|
                                                                                    Documents::closure56(v62.clone(),
                                                                                                         v)
                                                                            })),
                                                            true,
                                                            None::<string>);
                                    let v88: i32 = patternInput.0.clone();
                                    let v90: Array<string> =
                                        split(patternInput.1.clone(), string("\n"), -1_i32, 0_i32);
                                    let v91: i32 = count(v90.clone());
                                    let v93: LrcPtr<Documents::Mut7> =
                                        LrcPtr::new(Documents::Mut7 {
                                            l0: MutCell::new(0_i32),
                                            l1: MutCell::new(string("")),
                                            l2: MutCell::new(0_i32),
                                            l3: MutCell::new(0_i32),
                                        });
                                    while Documents::method58(v38, v93.clone()) {
                                        let v95: i32 = v93.l0.get().clone();
                                        let matchValue: string = v93.l1.get().clone();
                                        let matchValue_1: i32 = v93.l2.get().clone();
                                        let v98: i32 = v93.l3.get().clone();
                                        let v97: i32 = matchValue_1;
                                        let v96: string = matchValue;
                                        let patternInput_2: (string, i32, i32) = if v31[v95].clone()
                                            == string("")
                                        {
                                            (
                                                sprintf!("{}\n", v96.clone()),
                                                v97 + 1_i32,
                                                v98 + 1_i32,
                                            )
                                        } else {
                                            let v104: i32 = v97 - v98;
                                            (
                                                if v104 >= v91 {
                                                    v96.clone()
                                                } else {
                                                    let v106: string = v90[v104].clone();
                                                    if v104 == v91 - 1_i32 {
                                                        sprintf!("{}{}", v96.clone(), v106.clone())
                                                    } else {
                                                        sprintf!("{}{}\n", v96, v106)
                                                    }
                                                },
                                                v97 + 1_i32,
                                                v98,
                                            )
                                        };
                                        let v117: i32 = v95 + 1_i32;
                                        v93.l0.set(v117);
                                        v93.l1.set(patternInput_2.0.clone());
                                        v93.l2.set(patternInput_2.1.clone());
                                        v93.l3.set(patternInput_2.2.clone());
                                        ()
                                    }
                                    {
                                        let matchValue_3: string = v93.l1.get().clone();
                                        let matchValue_4: i32 = v93.l2.get().clone();
                                        let matchValue_5: i32 = v93.l3.get().clone();
                                        let v118: string = matchValue_3;
                                        let _v121: MutCell<Option<()>> = MutCell::new(None::<()>);
                                        std::fs::write(&*v2.clone(), &*v118.clone()).unwrap();
                                        _v121.set(Some(()));
                                        getValue(_v121.get().clone());
                                        Documents::method3(
                                            Documents::US0::US0_2,
                                            Func0::new(move || Documents::closure57((), ())),
                                            Func0::new({
                                                let v118 = v118.clone();
                                                let v2 = v2.clone();
                                                let v88 = v88.clone();
                                                move || {
                                                    Documents::closure58(
                                                        v2.clone(),
                                                        v88,
                                                        v118.clone(),
                                                        (),
                                                    )
                                                }
                                            }),
                                        );
                                        Documents::US19::US19_0(v88, v118.clone())
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
        pub fn closure59(unitVar: (), unitVar_1: ()) -> string {
            string("documents.files_fn / error")
        }
        pub fn closure60(v0_1: string, v1_1: i32, unitVar: ()) -> string {
            sprintf!(
                "exit_code: {:?} / result: {} / {}",
                v1_1,
                v0_1,
                Documents::closure6((), ())
            )
        }
        pub fn closure55(
            v0_1: string,
            v1_1: string,
            v2: string,
            v3: string,
            v4: string,
            v5: string,
        ) -> Documents::US18 {
            let patternInput: (string, string) = Documents::method51(v5, v4.clone(), v0_1);
            let v7: string = patternInput.1.clone();
            let v6: string = patternInput.0.clone();
            let _v8: MutCell<Option<bool>> = MutCell::new(None::<bool>);
            let v10: &str = &*v7.clone();
            let v12: std::string::String = String::from(v10);
            let v14: std::path::PathBuf = std::path::PathBuf::from(v12);
            {
                let x: bool = if v14.clone().exists() {
                    v14.is_file()
                } else {
                    false
                };
                _v8.set(Some(x))
            }
            if (if if getValue(_v8.get().clone()) {
                let _v30: MutCell<Option<bool>> = MutCell::new(None::<bool>);
                let v32: &str = &*v6.clone();
                let v34: std::string::String = String::from(v32);
                let v36: std::path::PathBuf = std::path::PathBuf::from(v34);
                {
                    let x_1: bool = if v36.clone().exists() {
                        v36.is_file()
                    } else {
                        false
                    };
                    _v30.set(Some(x_1))
                }
                getValue(_v30.get().clone())
            } else {
                false
            } {
                let _v52: MutCell<Option<string>> = MutCell::new(None::<string>);
                let v53: string = Documents::method18(v7.clone());
                let v54: string = Documents::method19();
                let _v55: MutCell<Option<Result<regex::Regex, regex::Error>>> =
                    MutCell::new(None::<Result<regex::Regex, regex::Error>>);
                let v56: string = Documents::method20();
                {
                    let x_2: Result<regex::Regex, regex::Error> = regex::Regex::new(&v56);
                    _v55.set(Some(x_2))
                }
                {
                    let v64: Result<regex::Regex, regex::Error> = getValue(_v55.get().clone());
                    let v66: regex::Regex = v64.unwrap();
                    let v68: std::borrow::Cow<str> = v66.replace_all(&v53, &*v54);
                    let v70: std::string::String = String::from(v68);
                    {
                        let x_3: string = fable_library_rust::String_::fromString(v70);
                        _v52.set(Some(x_3))
                    }
                    {
                        let v80: string = getValue(_v52.get().clone());
                        let v84: string = replace(
                            sprintf!(
                                "{}{}",
                                toLower(ofChar(getCharAt(v80.clone(), 0_i32))),
                                getSlice(v80, Some(1_i32), None::<i32>)
                            ),
                            string("\\"),
                            string("/"),
                        );
                        let v86: Result<std::fs::File, std::io::Error> = std::fs::File::open(&*v84);
                        let v88: std::fs::File = v86.unwrap();
                        let v90: std::io::BufReader<std::fs::File> = std::io::BufReader::new(v88);
                        let v92: bool = true;
                        let mut v90 = v90;
                        let v94: sha2::Sha256 = sha2::Digest::new();
                        let v96: bool = true;
                        let mut v94 = v94;
                        let v97: usize = 0_i32 as usize;
                        let v99: _ = [0_u8; 1024];
                        let v101: bool = true;
                        loop {
                            // rust.loop;
                            let v103: bool = true;
                            let mut v99 = v99;
                            let v105: Result<usize, std::io::Error> =
                                std::io::Read::read(&mut v90, &mut v99);
                            let v107: usize = v105.unwrap();
                            if v107 == v97 {
                                let v110: bool = true;
                                break;
                                ()
                            }
                            {
                                let v112: usize = v99.len();
                                let v113: u8 = v112 as u8;
                                let v114: usize = v107;
                                let v121: &_ = if v114 == v112 {
                                    &v99[v97..]
                                } else {
                                    &v99[v97..v114]
                                };
                                sha2::Digest::update(&mut v94, v121);
                                {
                                    let v124: bool = true;
                                } // rust.loop;
                                let v126: bool = true;
                            } // rust.loop;
                            let v128: bool = true;
                        } // rust.loop;
                        let v130: bool = true;
                        {
                            // rust.loop;
                            let v132: bool = true;
                            {
                                // rust.loop;
                                let v134: &[u8] = &sha2::Digest::finalize(v94);
                                let v136: Vec<u8> = v134.iter().map(|x| *x).collect();
                                fn v138(v: u8) -> string {
                                    Documents::closure51((), v)
                                }
                                let v139: Vec<string> = v136
                                    .into_iter()
                                    .map(|x| Func1::from(v138)(x.clone()))
                                    .collect();
                                let v141: Array<string> =
                                    fable_library_rust::NativeArray_::array_from(v139);
                                let v142: LrcPtr<dyn IEnumerable_1<string>> = delay(Func0::new({
                                    let v141 = v141.clone();
                                    move || {
                                        map(
                                            Func1::new({
                                                let v141 = v141.clone();
                                                move |i: i32| v141[i].clone()
                                            }),
                                            rangeNumeric(0_i32, 1_i32, count(v141.clone()) - 1_i32),
                                        )
                                    }
                                }));
                                let v146: string = join(Documents::method52(), toArray(v142));
                                let _v147: MutCell<Option<string>> = MutCell::new(None::<string>);
                                let v148: string = Documents::method18(v6.clone());
                                let v149: string = Documents::method19();
                                let _v150: MutCell<Option<Result<regex::Regex, regex::Error>>> =
                                    MutCell::new(None::<Result<regex::Regex, regex::Error>>);
                                let v151: string = Documents::method20();
                                {
                                    let x_4: Result<regex::Regex, regex::Error> =
                                        regex::Regex::new(&v151);
                                    _v150.set(Some(x_4))
                                }
                                {
                                    let v159: Result<regex::Regex, regex::Error> =
                                        getValue(_v150.get().clone());
                                    let v161: regex::Regex = v159.unwrap();
                                    let v163: std::borrow::Cow<str> =
                                        v161.replace_all(&v148, &*v149);
                                    let v165: std::string::String = String::from(v163);
                                    {
                                        let x_5: string =
                                            fable_library_rust::String_::fromString(v165);
                                        _v147.set(Some(x_5))
                                    }
                                    {
                                        let v174: string = getValue(_v147.get().clone());
                                        let v176: string = replace(
                                            sprintf!(
                                                "{}{}",
                                                toLower(ofChar(getCharAt(v174.clone(), 0_i32))),
                                                getSlice(v174, Some(1_i32), None::<i32>)
                                            ),
                                            string("\\"),
                                            string("/"),
                                        );
                                        let v178: Result<std::fs::File, std::io::Error> =
                                            std::fs::File::open(&*v176);
                                        let v180: std::fs::File = v178.unwrap();
                                        let v182: std::io::BufReader<std::fs::File> =
                                            std::io::BufReader::new(v180);
                                        let v184: bool = true;
                                        let mut v182 = v182;
                                        let v186: sha2::Sha256 = sha2::Digest::new();
                                        let v188: bool = true;
                                        let mut v186 = v186;
                                        let v189: usize = 0_i32 as usize;
                                        let v191: _ = [0_u8; 1024];
                                        let v193: bool = true;
                                        loop {
                                            // rust.loop;
                                            let v195: bool = true;
                                            let mut v191 = v191;
                                            let v197: Result<usize, std::io::Error> =
                                                std::io::Read::read(&mut v182, &mut v191);
                                            let v199: usize = v197.unwrap();
                                            if v199 == v189 {
                                                let v202: bool = true;
                                                break;
                                                ()
                                            }
                                            {
                                                let v204: usize = v191.len();
                                                let v205: u8 = v204 as u8;
                                                let v206: usize = v199;
                                                let v213: &_ = if v206 == v204 {
                                                    &v191[v189..]
                                                } else {
                                                    &v191[v189..v206]
                                                };
                                                sha2::Digest::update(&mut v186, v213);
                                                {
                                                    let v216: bool = true;
                                                } // rust.loop;
                                                let v218: bool = true;
                                            } // rust.loop;
                                            let v220: bool = true;
                                        } // rust.loop;
                                        let v222: bool = true;
                                        {
                                            // rust.loop;
                                            let v224: bool = true;
                                            {
                                                // rust.loop;
                                                let v226: &[u8] = &sha2::Digest::finalize(v186);
                                                let v228: Vec<u8> =
                                                    v226.iter().map(|x| *x).collect();
                                                let v230: Vec<string> = v228
                                                    .into_iter()
                                                    .map(|x| Func1::from(v138)(x.clone()))
                                                    .collect();
                                                let v232: Array<string> =
                                                    fable_library_rust::NativeArray_::array_from(
                                                        v230,
                                                    );
                                                let v233: LrcPtr<dyn IEnumerable_1<string>> =
                                                    delay(Func0::new({
                                                        let v232 = v232.clone();
                                                        move || {
                                                            map(
                                                                Func1::new({
                                                                    let v232 = v232.clone();
                                                                    move |i_1: i32| {
                                                                        v232[i_1].clone()
                                                                    }
                                                                }),
                                                                rangeNumeric(
                                                                    0_i32,
                                                                    1_i32,
                                                                    count(v232.clone()) - 1_i32,
                                                                ),
                                                            )
                                                        }
                                                    }));
                                                v146 == join(Documents::method52(), toArray(v233))
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
                let v241: Documents::US19 = Documents::method54(v2, v3, v7.clone(), v4);
                match &v241 {
                    Documents::US19::US19_0(v241_0_0, v241_0_1) => {
                        let v243: string = v241_0_1.clone();
                        let v242: i32 = v241_0_0.clone();
                        if v242 != 0_i32 {
                            Documents::method3(
                                Documents::US0::US0_2,
                                Func0::new(move || Documents::closure59((), ())),
                                Func0::new({
                                    let v242 = v242.clone();
                                    let v243 = v243.clone();
                                    move || Documents::closure60(v243.clone(), v242, ())
                                }),
                            );
                            Documents::US18::US18_0(Err::<string, LrcPtr<(string, string)>>(
                                LrcPtr::new((v7.clone(), v243.clone())),
                            ))
                        } else {
                            let _v251: MutCell<Option<bool>> = MutCell::new(None::<bool>);
                            let v253: &str = &*v7.clone();
                            let v255: std::string::String = String::from(v253);
                            let v257: std::path::PathBuf = std::path::PathBuf::from(v255);
                            {
                                let x_6: bool = if v257.clone().exists() {
                                    v257.is_file()
                                } else {
                                    false
                                };
                                _v251.set(Some(x_6))
                            }
                            if getValue(_v251.get().clone()) {
                                let _v272: MutCell<Option<()>> = MutCell::new(None::<()>);
                                let v273: string = Documents::method53(v6);
                                let v275: Result<u64, std::io::Error> =
                                    std::fs::copy(&*v7.clone(), &*v273);
                                let v277: u64 = v275.unwrap();
                                _v272.set(Some(()));
                                getValue(_v272.get().clone());
                                ()
                            } else {
                                panic!(
                                    "{}",
                                    sprintf!("documents.files_fn / {} should exist", v7.clone()),
                                )
                            }
                            Documents::US18::US18_0(Ok::<string, LrcPtr<(string, string)>>(
                                v7.clone(),
                            ))
                        }
                    }
                    Documents::US19::US19_1(v241_1_0, v241_1_1) => {
                        Documents::US18::US18_0(Err::<string, LrcPtr<(string, string)>>(
                            LrcPtr::new((v7.clone(), v241_1_1.clone())),
                        ))
                    }
                }
            } else {
                Documents::US18::US18_1
            }
        }
        pub fn closure54(
            v0_1: string,
            v1_1: string,
            v2: string,
            v3: string,
            v4: string,
        ) -> Func1<string, Documents::US18> {
            Func1::new({
                let v0_1 = v0_1.clone();
                let v1_1 = v1_1.clone();
                let v2 = v2.clone();
                let v3 = v3.clone();
                let v4 = v4.clone();
                move |v: string| {
                    Documents::closure55(
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
        pub fn closure63(unitVar: (), unitVar_1: ()) -> string {
            string("documents.crowbook / result contains ERROR")
        }
        pub fn closure64(v0_1: string, v1_1: string, v2: i32, unitVar: ()) -> string {
            sprintf!(
                "exit_code: {:?} / output_path: {} / result: {} / {}",
                v2,
                v0_1,
                v1_1,
                Documents::closure6((), ())
            )
        }
        pub fn method60(
            v0_1: bool,
            v1_1: string,
            v2: string,
            v3: string,
            v4: string,
        ) -> Documents::US19 {
            let patternInput: (i32, string) = Documents::method35(
                None::<CancellationToken>,
                append(
                    sprintf!("crowbook --verbose --to {}", v4.clone()),
                    sprintf!(
                        " --single \"{}\" --output \"{}\" {}",
                        v2,
                        v1_1.clone(),
                        if string("html") == v4.clone() {
                            let v7: string =
                                                            string(" html.css.add \\\"\' body { color: #e8e6e3; background-color: #202324; } a { color: #989693; } pre { background-color: #1b1b1b; padding: 10px; } \'\\\"");
                            append(append(string("--set"),
                                                                      v7),
                                                               string(" rendering.num_depth 6 rendering.highlight.theme \\\"Solarized (dark)\\\""))
                        } else {
                            if string("pdf") == v4.clone() {
                                append(append(string("--set tex.paper.size a4paper"),
                                                                          (if v0_1
                                                                                  ==
                                                                                  false
                                                                              {
                                                                               string("")
                                                                           } else {
                                                                               string(" tex.template.add \"\\usepackage{polyglossia}\" tex.template.add \"\\setmainlanguage{korean}\" tex.template.add \"\\setmainfont{NanumGothicCoding}\" tex.font.size 12")
                                                                           })),
                                                                   string(" rendering.num_depth 6 rendering.highlight.theme \\\"Solarized (dark)\\\""))
                            } else {
                                if string("epub") == v4 {
                                    string("--set epub.version 3 html.css.add \\\"\' body { color: #e8e6e3; background-color: #202324; } a { color: #989693; } \'\\\" rendering.num_depth 6 rendering.highlight.theme \\\"Solarized (dark)\\\"")
                                } else {
                                    string("")
                                }
                            }
                        }
                    ),
                ),
                new_empty::<(string, string)>(),
                None::<Func1<(bool, string, i32), Arc<Async<()>>>>,
                None::<Func1<std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>, ()>>,
                true,
                Some(v3),
            );
            let v57: string = patternInput.1.clone();
            let v56: i32 = patternInput.0.clone();
            if contains(v57.clone(), string("ERROR")) {
                Documents::method3(
                    Documents::US0::US0_3,
                    Func0::new(move || Documents::closure63((), ())),
                    Func0::new({
                        let v1_1 = v1_1.clone();
                        let v56 = v56.clone();
                        let v57 = v57.clone();
                        move || Documents::closure64(v1_1.clone(), v57.clone(), v56, ())
                    }),
                );
                Documents::US19::US19_1(v56, v57.clone())
            } else {
                Documents::US19::US19_0(v56, v57.clone())
            }
        }
        pub fn closure62(
            v0_1: string,
            v1_1: string,
            v2: bool,
            v3: string,
            v4: string,
        ) -> Documents::US18 {
            let patternInput: (string, string) = Documents::method51(v4.clone(), v3.clone(), v0_1);
            let v6: string = patternInput.1.clone();
            let v5: string = patternInput.0.clone();
            let _v7: MutCell<Option<bool>> = MutCell::new(None::<bool>);
            let v9: &str = &*v6.clone();
            let v11: std::string::String = String::from(v9);
            let v13: std::path::PathBuf = std::path::PathBuf::from(v11);
            {
                let x: bool = if v13.clone().exists() {
                    v13.is_file()
                } else {
                    false
                };
                _v7.set(Some(x))
            }
            if (if if getValue(_v7.get().clone()) {
                let _v29: MutCell<Option<bool>> = MutCell::new(None::<bool>);
                let v31: &str = &*v5.clone();
                let v33: std::string::String = String::from(v31);
                let v35: std::path::PathBuf = std::path::PathBuf::from(v33);
                {
                    let x_1: bool = if v35.clone().exists() {
                        v35.is_file()
                    } else {
                        false
                    };
                    _v29.set(Some(x_1))
                }
                getValue(_v29.get().clone())
            } else {
                false
            } {
                let _v51: MutCell<Option<string>> = MutCell::new(None::<string>);
                let v52: string = Documents::method18(v6.clone());
                let v53: string = Documents::method19();
                let _v54: MutCell<Option<Result<regex::Regex, regex::Error>>> =
                    MutCell::new(None::<Result<regex::Regex, regex::Error>>);
                let v55: string = Documents::method20();
                {
                    let x_2: Result<regex::Regex, regex::Error> = regex::Regex::new(&v55);
                    _v54.set(Some(x_2))
                }
                {
                    let v63: Result<regex::Regex, regex::Error> = getValue(_v54.get().clone());
                    let v65: regex::Regex = v63.unwrap();
                    let v67: std::borrow::Cow<str> = v65.replace_all(&v52, &*v53);
                    let v69: std::string::String = String::from(v67);
                    {
                        let x_3: string = fable_library_rust::String_::fromString(v69);
                        _v51.set(Some(x_3))
                    }
                    {
                        let v79: string = getValue(_v51.get().clone());
                        let v83: string = replace(
                            sprintf!(
                                "{}{}",
                                toLower(ofChar(getCharAt(v79.clone(), 0_i32))),
                                getSlice(v79, Some(1_i32), None::<i32>)
                            ),
                            string("\\"),
                            string("/"),
                        );
                        let v85: Result<std::fs::File, std::io::Error> = std::fs::File::open(&*v83);
                        let v87: std::fs::File = v85.unwrap();
                        let v89: std::io::BufReader<std::fs::File> = std::io::BufReader::new(v87);
                        let v91: bool = true;
                        let mut v89 = v89;
                        let v93: sha2::Sha256 = sha2::Digest::new();
                        let v95: bool = true;
                        let mut v93 = v93;
                        let v96: usize = 0_i32 as usize;
                        let v98: _ = [0_u8; 1024];
                        let v100: bool = true;
                        loop {
                            // rust.loop;
                            let v102: bool = true;
                            let mut v98 = v98;
                            let v104: Result<usize, std::io::Error> =
                                std::io::Read::read(&mut v89, &mut v98);
                            let v106: usize = v104.unwrap();
                            if v106 == v96 {
                                let v109: bool = true;
                                break;
                                ()
                            }
                            {
                                let v111: usize = v98.len();
                                let v112: u8 = v111 as u8;
                                let v113: usize = v106;
                                let v120: &_ = if v113 == v111 {
                                    &v98[v96..]
                                } else {
                                    &v98[v96..v113]
                                };
                                sha2::Digest::update(&mut v93, v120);
                                {
                                    let v123: bool = true;
                                } // rust.loop;
                                let v125: bool = true;
                            } // rust.loop;
                            let v127: bool = true;
                        } // rust.loop;
                        let v129: bool = true;
                        {
                            // rust.loop;
                            let v131: bool = true;
                            {
                                // rust.loop;
                                let v133: &[u8] = &sha2::Digest::finalize(v93);
                                let v135: Vec<u8> = v133.iter().map(|x| *x).collect();
                                fn v137(v: u8) -> string {
                                    Documents::closure51((), v)
                                }
                                let v138: Vec<string> = v135
                                    .into_iter()
                                    .map(|x| Func1::from(v137)(x.clone()))
                                    .collect();
                                let v140: Array<string> =
                                    fable_library_rust::NativeArray_::array_from(v138);
                                let v141: LrcPtr<dyn IEnumerable_1<string>> = delay(Func0::new({
                                    let v140 = v140.clone();
                                    move || {
                                        map(
                                            Func1::new({
                                                let v140 = v140.clone();
                                                move |i: i32| v140[i].clone()
                                            }),
                                            rangeNumeric(0_i32, 1_i32, count(v140.clone()) - 1_i32),
                                        )
                                    }
                                }));
                                let v145: string = join(Documents::method52(), toArray(v141));
                                let _v146: MutCell<Option<string>> = MutCell::new(None::<string>);
                                let v147: string = Documents::method18(v5.clone());
                                let v148: string = Documents::method19();
                                let _v149: MutCell<Option<Result<regex::Regex, regex::Error>>> =
                                    MutCell::new(None::<Result<regex::Regex, regex::Error>>);
                                let v150: string = Documents::method20();
                                {
                                    let x_4: Result<regex::Regex, regex::Error> =
                                        regex::Regex::new(&v150);
                                    _v149.set(Some(x_4))
                                }
                                {
                                    let v158: Result<regex::Regex, regex::Error> =
                                        getValue(_v149.get().clone());
                                    let v160: regex::Regex = v158.unwrap();
                                    let v162: std::borrow::Cow<str> =
                                        v160.replace_all(&v147, &*v148);
                                    let v164: std::string::String = String::from(v162);
                                    {
                                        let x_5: string =
                                            fable_library_rust::String_::fromString(v164);
                                        _v146.set(Some(x_5))
                                    }
                                    {
                                        let v173: string = getValue(_v146.get().clone());
                                        let v175: string = replace(
                                            sprintf!(
                                                "{}{}",
                                                toLower(ofChar(getCharAt(v173.clone(), 0_i32))),
                                                getSlice(v173, Some(1_i32), None::<i32>)
                                            ),
                                            string("\\"),
                                            string("/"),
                                        );
                                        let v177: Result<std::fs::File, std::io::Error> =
                                            std::fs::File::open(&*v175);
                                        let v179: std::fs::File = v177.unwrap();
                                        let v181: std::io::BufReader<std::fs::File> =
                                            std::io::BufReader::new(v179);
                                        let v183: bool = true;
                                        let mut v181 = v181;
                                        let v185: sha2::Sha256 = sha2::Digest::new();
                                        let v187: bool = true;
                                        let mut v185 = v185;
                                        let v188: usize = 0_i32 as usize;
                                        let v190: _ = [0_u8; 1024];
                                        let v192: bool = true;
                                        loop {
                                            // rust.loop;
                                            let v194: bool = true;
                                            let mut v190 = v190;
                                            let v196: Result<usize, std::io::Error> =
                                                std::io::Read::read(&mut v181, &mut v190);
                                            let v198: usize = v196.unwrap();
                                            if v198 == v188 {
                                                let v201: bool = true;
                                                break;
                                                ()
                                            }
                                            {
                                                let v203: usize = v190.len();
                                                let v204: u8 = v203 as u8;
                                                let v205: usize = v198;
                                                let v212: &_ = if v205 == v203 {
                                                    &v190[v188..]
                                                } else {
                                                    &v190[v188..v205]
                                                };
                                                sha2::Digest::update(&mut v185, v212);
                                                {
                                                    let v215: bool = true;
                                                } // rust.loop;
                                                let v217: bool = true;
                                            } // rust.loop;
                                            let v219: bool = true;
                                        } // rust.loop;
                                        let v221: bool = true;
                                        {
                                            // rust.loop;
                                            let v223: bool = true;
                                            {
                                                // rust.loop;
                                                let v225: &[u8] = &sha2::Digest::finalize(v185);
                                                let v227: Vec<u8> =
                                                    v225.iter().map(|x| *x).collect();
                                                let v229: Vec<string> = v227
                                                    .into_iter()
                                                    .map(|x| Func1::from(v137)(x.clone()))
                                                    .collect();
                                                let v231: Array<string> =
                                                    fable_library_rust::NativeArray_::array_from(
                                                        v229,
                                                    );
                                                let v232: LrcPtr<dyn IEnumerable_1<string>> =
                                                    delay(Func0::new({
                                                        let v231 = v231.clone();
                                                        move || {
                                                            map(
                                                                Func1::new({
                                                                    let v231 = v231.clone();
                                                                    move |i_1: i32| {
                                                                        v231[i_1].clone()
                                                                    }
                                                                }),
                                                                rangeNumeric(
                                                                    0_i32,
                                                                    1_i32,
                                                                    count(v231.clone()) - 1_i32,
                                                                ),
                                                            )
                                                        }
                                                    }));
                                                v145 == join(Documents::method52(), toArray(v232))
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
                let v240: Documents::US19 = Documents::method60(v2, v6.clone(), v3, v1_1, v4);
                match &v240 {
                    Documents::US19::US19_0(v240_0_0, v240_0_1) => {
                        let v242: string = v240_0_1.clone();
                        let v241: i32 = v240_0_0.clone();
                        if v241 != 0_i32 {
                            Documents::method3(
                                Documents::US0::US0_2,
                                Func0::new(move || Documents::closure59((), ())),
                                Func0::new({
                                    let v241 = v241.clone();
                                    let v242 = v242.clone();
                                    move || Documents::closure60(v242.clone(), v241, ())
                                }),
                            );
                            Documents::US18::US18_0(Err::<string, LrcPtr<(string, string)>>(
                                LrcPtr::new((v6.clone(), v242.clone())),
                            ))
                        } else {
                            let _v250: MutCell<Option<bool>> = MutCell::new(None::<bool>);
                            let v252: &str = &*v6.clone();
                            let v254: std::string::String = String::from(v252);
                            let v256: std::path::PathBuf = std::path::PathBuf::from(v254);
                            {
                                let x_6: bool = if v256.clone().exists() {
                                    v256.is_file()
                                } else {
                                    false
                                };
                                _v250.set(Some(x_6))
                            }
                            if getValue(_v250.get().clone()) {
                                let _v271: MutCell<Option<()>> = MutCell::new(None::<()>);
                                let v272: string = Documents::method53(v5);
                                let v274: Result<u64, std::io::Error> =
                                    std::fs::copy(&*v6.clone(), &*v272);
                                let v276: u64 = v274.unwrap();
                                _v271.set(Some(()));
                                getValue(_v271.get().clone());
                                ()
                            } else {
                                panic!(
                                    "{}",
                                    sprintf!("documents.files_fn / {} should exist", v6.clone()),
                                )
                            }
                            Documents::US18::US18_0(Ok::<string, LrcPtr<(string, string)>>(
                                v6.clone(),
                            ))
                        }
                    }
                    Documents::US19::US19_1(v240_1_0, v240_1_1) => {
                        Documents::US18::US18_0(Err::<string, LrcPtr<(string, string)>>(
                            LrcPtr::new((v6.clone(), v240_1_1.clone())),
                        ))
                    }
                }
            } else {
                Documents::US18::US18_1
            }
        }
        pub fn closure61(
            v0_1: string,
            v1_1: string,
            v2: bool,
            v3: string,
        ) -> Func1<string, Documents::US18> {
            Func1::new({
                let v0_1 = v0_1.clone();
                let v1_1 = v1_1.clone();
                let v2 = v2.clone();
                let v3 = v3.clone();
                move |v: string| Documents::closure62(v0_1.clone(), v1_1.clone(), v2, v3.clone(), v)
            })
        }
        pub fn closure65(unitVar: (), unitVar_1: ()) -> string {
            string("documents.run / par_map / files\' = [] / listm.iter")
        }
        pub fn closure66(v0_1: string, v1_1: string, unitVar: ()) -> string {
            sprintf!(
                "output_path: {:?} / output_cache_path: {} / {}",
                v1_1,
                v0_1,
                Documents::closure6((), ())
            )
        }
        pub fn method61(
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
                    Documents::method61(
                        match v0_1.as_ref() {
                            Documents::UH2::UH2_1(_, x) => x.clone(),
                            _ => unreachable!(),
                        },
                        v1_1.clone(),
                    ),
                ),
            }
        }
        pub fn method62(v0_1: i32, v1_1: LrcPtr<Documents::Mut8>) -> bool {
            v1_1.l0.get().clone() < v0_1
        }
        pub fn method63(
            v0_1: LrcPtr<Documents::UH3>,
            v1_1: List<(
                string,
                string,
                Func1<string, Func1<string, Documents::US18>>,
            )>,
        ) -> List<(
            string,
            string,
            Func1<string, Func1<string, Documents::US18>>,
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
                    Documents::method63(
                        match v0_1.as_ref() {
                            Documents::UH3::UH3_1(_, _, _, x) => x.clone(),
                            _ => unreachable!(),
                        },
                        v1_1.clone(),
                    ),
                ),
            }
        }
        pub fn closure67(
            unitVar: (),
            _arg: (
                string,
                string,
                Func1<string, Func1<string, Documents::US18>>,
            ),
        ) -> Option<Result<string, LrcPtr<(string, string)>>> {
            let v4: Documents::US18 = (_arg.2.clone())(_arg.1.clone())(_arg.0.clone());
            match &v4 {
                Documents::US18::US18_0(v4_0_0) => Some(match &v4 {
                    Documents::US18::US18_0(x) => x.clone(),
                    _ => unreachable!(),
                }),
                _ => None::<Result<string, LrcPtr<(string, string)>>>,
            }
        }
        pub fn method64(
            v0_1: Vec<Option<Result<string, LrcPtr<(string, string)>>>>,
        ) -> Vec<Option<Result<string, LrcPtr<(string, string)>>>> {
            v0_1
        }
        pub fn method65(
            v0_1: Vec<Option<Result<string, LrcPtr<(string, string)>>>>,
        ) -> Vec<Option<Result<string, LrcPtr<(string, string)>>>> {
            v0_1
        }
        pub fn closure22(
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
            let v7: string = Documents::method17(v5);
            let v9: &str = &*v7.clone();
            let v11: std::string::String = String::from(v9);
            let v13: std::path::PathBuf = std::path::PathBuf::from(v11);
            {
                let x_6: string = if v13.exists() == false {
                    let _v17: MutCell<Option<string>> = MutCell::new(None::<string>);
                    let v19: Result<std::path::PathBuf, std::io::Error> = std::env::current_dir();
                    let v21: std::path::PathBuf = v19.unwrap();
                    let v23: std::path::Display = v21.display();
                    let _v24: MutCell<Option<std::string::String>> =
                        MutCell::new(None::<std::string::String>);
                    {
                        let x: std::string::String = format!("{}", v23);
                        _v24.set(Some(x))
                    }
                    {
                        let v34: std::string::String = getValue(_v24.get().clone());
                        {
                            let x_1: string = fable_library_rust::String_::fromString(v34);
                            _v17.set(Some(x_1))
                        }
                        {
                            let v43: string = getValue(_v17.get().clone());
                            let _v45: MutCell<Option<string>> = MutCell::new(None::<string>);
                            let v46: string =
                                Documents::method18(Documents::method11(v43.clone(), v7.clone()));
                            let v47: string = Documents::method19();
                            let _v48: MutCell<Option<Result<regex::Regex, regex::Error>>> =
                                MutCell::new(None::<Result<regex::Regex, regex::Error>>);
                            let v49: string = Documents::method20();
                            {
                                let x_2: Result<regex::Regex, regex::Error> =
                                    regex::Regex::new(&v49);
                                _v48.set(Some(x_2))
                            }
                            {
                                let v57: Result<regex::Regex, regex::Error> =
                                    getValue(_v48.get().clone());
                                let v59: regex::Regex = v57.unwrap();
                                let v61: std::borrow::Cow<str> = v59.replace_all(&v46, &*v47);
                                let v63: std::string::String = String::from(v61);
                                {
                                    let x_3: string = fable_library_rust::String_::fromString(v63);
                                    _v45.set(Some(x_3))
                                }
                                {
                                    let v73: string = getValue(_v45.get().clone());
                                    let v78: Array<string> = split(
                                        replace(
                                            sprintf!(
                                                "{}{}",
                                                toLower(ofChar(getCharAt(v73.clone(), 0_i32))),
                                                getSlice(v73, Some(1_i32), None::<i32>)
                                            ),
                                            string("\\"),
                                            string("/"),
                                        ),
                                        string("/"),
                                        -1_i32,
                                        0_i32,
                                    );
                                    let v80: i32 = count(v78.clone());
                                    let v81: LrcPtr<Documents::Mut4> =
                                        LrcPtr::new(Documents::Mut4 {
                                            l0: MutCell::new(0_i32),
                                            l1: MutCell::new(0_i32),
                                            l2: MutCell::new(new_empty::<string>()),
                                        });
                                    while Documents::method22(v80, v81.clone()) {
                                        let v83: i32 = v81.l0.get().clone();
                                        let v86: i32 = v83.wrapping_neg() + v80 - 1_i32;
                                        let matchValue: i32 = v81.l1.get().clone();
                                        let v88: Array<string> = v81.l2.get().clone();
                                        let v87: i32 = matchValue;
                                        let v89: string = v78[v86].clone();
                                        let patternInput_1: (i32, Array<string>) = if string("..")
                                            == v89.clone()
                                        {
                                            (v87 + 1_i32, v88.clone())
                                        } else {
                                            if string(".") == v89.clone() {
                                                (v87, v88.clone())
                                            } else {
                                                if 0_i32 == v87 {
                                                    if endsWith(v89.clone(), string(":"), false) {
                                                        let v97: Array<string> =
                                                            new_array(&[sprintf!(
                                                                "{}:",
                                                                getCharAt(v43.clone(), 0_i32)
                                                            )]);
                                                        let v98: i32 = count(v97.clone());
                                                        let v100: i32 = v98 + count(v88.clone());
                                                        let v101: Array<string> =
                                                            new_init(&string(""), v100);
                                                        let v102: LrcPtr<Documents::Mut5> =
                                                            LrcPtr::new(Documents::Mut5 {
                                                                l0: MutCell::new(0_i32),
                                                            });
                                                        while Documents::method23(
                                                            v100,
                                                            v102.clone(),
                                                        ) {
                                                            let v104: i32 = v102.l0.get().clone();
                                                            let v109: string = if v104 < v98 {
                                                                v97[v104].clone()
                                                            } else {
                                                                let v107: i32 = v104 - v98;
                                                                v88[v107].clone()
                                                            };
                                                            v101.get_mut()[v104 as usize] = v109;
                                                            {
                                                                let v110: i32 = v104 + 1_i32;
                                                                v102.l0.set(v110);
                                                                ()
                                                            }
                                                        }
                                                        (0_i32, v101.clone())
                                                    } else {
                                                        let v111: Array<string> = new_array(&[v89]);
                                                        let v112: i32 = count(v111.clone());
                                                        let v114: i32 = v112 + count(v88.clone());
                                                        let v115: Array<string> =
                                                            new_init(&string(""), v114);
                                                        let v116: LrcPtr<Documents::Mut5> =
                                                            LrcPtr::new(Documents::Mut5 {
                                                                l0: MutCell::new(0_i32),
                                                            });
                                                        while Documents::method23(
                                                            v114,
                                                            v116.clone(),
                                                        ) {
                                                            let v118: i32 = v116.l0.get().clone();
                                                            let v123: string = if v118 < v112 {
                                                                v111[v118].clone()
                                                            } else {
                                                                let v121: i32 = v118 - v112;
                                                                v88[v121].clone()
                                                            };
                                                            v115.get_mut()[v118 as usize] = v123;
                                                            {
                                                                let v124: i32 = v118 + 1_i32;
                                                                v116.l0.set(v124);
                                                                ()
                                                            }
                                                        }
                                                        (0_i32, v115.clone())
                                                    }
                                                } else {
                                                    (v87 - 1_i32, v88.clone())
                                                }
                                            }
                                        };
                                        let v134: i32 = v83 + 1_i32;
                                        v81.l0.set(v134);
                                        v81.l1.set(patternInput_1.0.clone());
                                        v81.l2.set(patternInput_1.1.clone());
                                        ()
                                    }
                                    {
                                        let matchValue_2: i32 = v81.l1.get().clone();
                                        let v136: Array<string> = v81.l2.get().clone();
                                        let v137: LrcPtr<dyn IEnumerable_1<string>> =
                                            delay(Func0::new({
                                                let v136 = v136.clone();
                                                move || {
                                                    map(
                                                        Func1::new({
                                                            let v136 = v136.clone();
                                                            move |i: i32| v136[i].clone()
                                                        }),
                                                        rangeNumeric(
                                                            0_i32,
                                                            1_i32,
                                                            count(v136.clone()) - 1_i32,
                                                        ),
                                                    )
                                                }
                                            }));
                                        let _v138: MutCell<Option<char>> =
                                            MutCell::new(None::<char>);
                                        {
                                            let x_4: char = std::path::MAIN_SEPARATOR;
                                            _v138.set(Some(x_4))
                                        }
                                        join(
                                            Documents::method24(ofChar(getValue(
                                                _v138.get().clone(),
                                            ))),
                                            toArray(v137),
                                        )
                                    }
                                }
                            }
                        }
                    }
                } else {
                    let v154: Result<std::path::PathBuf, std::io::Error> =
                        std::fs::canonicalize(&*v7);
                    let v156: std::path::PathBuf = v154.unwrap();
                    let v158: std::path::Display = v156.display();
                    let _v159: MutCell<Option<std::string::String>> =
                        MutCell::new(None::<std::string::String>);
                    {
                        let x_5: std::string::String = format!("{}", v158);
                        _v159.set(Some(x_5))
                    }
                    {
                        let v169: std::string::String = getValue(_v159.get().clone());
                        fable_library_rust::String_::fromString(v169)
                    }
                };
                _v6.set(Some(x_6))
            }
            {
                let v180: string = getValue(_v6.get().clone());
                let v182: &str = &*v180.clone();
                let v184: std::string::String = String::from(v182);
                let v186: std::path::PathBuf = std::path::PathBuf::from(v184);
                let v188: std::path::Display = v186.display();
                let _v189: MutCell<Option<std::string::String>> =
                    MutCell::new(None::<std::string::String>);
                {
                    let x_7: std::string::String = format!("{}", v188);
                    _v189.set(Some(x_7))
                }
                {
                    let v199: std::string::String = getValue(_v189.get().clone());
                    let v207: string = sprintf!(
                        ".{}",
                        replace(
                            replace(
                                fable_library_rust::String_::fromString(v199),
                                v3.clone(),
                                string("")
                            ),
                            string("\\"),
                            string("/")
                        )
                    );
                    let _v208: MutCell<Option<string>> = MutCell::new(None::<string>);
                    let v209: string = Documents::method18(v180);
                    let v210: string = Documents::method19();
                    let _v211: MutCell<Option<Result<regex::Regex, regex::Error>>> =
                        MutCell::new(None::<Result<regex::Regex, regex::Error>>);
                    let v212: string = Documents::method20();
                    {
                        let x_8: Result<regex::Regex, regex::Error> = regex::Regex::new(&v212);
                        _v211.set(Some(x_8))
                    }
                    {
                        let v220: Result<regex::Regex, regex::Error> =
                            getValue(_v211.get().clone());
                        let v222: regex::Regex = v220.unwrap();
                        let v224: std::borrow::Cow<str> = v222.replace_all(&v209, &*v210);
                        let v226: std::string::String = String::from(v224);
                        {
                            let x_9: string = fable_library_rust::String_::fromString(v226);
                            _v208.set(Some(x_9))
                        }
                        {
                            let v236: string = getValue(_v208.get().clone());
                            let v238: string = replace(
                                sprintf!(
                                    "{}{}",
                                    toLower(ofChar(getCharAt(v236.clone(), 0_i32))),
                                    getSlice(v236, Some(1_i32), None::<i32>)
                                ),
                                string("\\"),
                                string("/"),
                            );
                            let v240: string =
                                Documents::method34(Documents::method11(v2.clone(), v207.clone()));
                            let patternInput_3: (i32, string) = Documents::method35(
                                None::<CancellationToken>,
                                sprintf!(
                                    "git ls-tree --format=\'%(objectname)\' origin/gh-pages \"{}\"",
                                    v240.clone()
                                ),
                                new_empty::<(string, string)>(),
                                None::<Func1<(bool, string, i32), Arc<Async<()>>>>,
                                None::<
                                    Func1<
                                        std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>,
                                        (),
                                    >,
                                >,
                                true,
                                Some(v2),
                            );
                            let v250: string = patternInput_3.1.clone();
                            let v252: string =
                                Documents::method34(Documents::method11(v3.clone(), v207.clone()));
                            let patternInput_4: (i32, string) = Documents::method35(
                                None::<CancellationToken>,
                                sprintf!("git hash-object \"{}\"", v252.clone()),
                                new_empty::<(string, string)>(),
                                None::<Func1<(bool, string, i32), Arc<Async<()>>>>,
                                None::<
                                    Func1<
                                        std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>,
                                        (),
                                    >,
                                >,
                                true,
                                Some(v3.clone()),
                            );
                            let v262: string = patternInput_4.1.clone();
                            let v264: string =
                                Documents::method34(Documents::method11(v4.clone(), v207.clone()));
                            let v267: string = (Documents::method51(
                                string("hangul.md"),
                                v252.clone(),
                                v4.clone(),
                            ))
                            .1
                            .clone();
                            let v526: LrcPtr<Documents::UH2> = if contains(
                                v250.clone(),
                                v262.clone(),
                            ) == false
                            {
                                let _v276: MutCell<Option<string>> = MutCell::new(None::<string>);
                                let v277: string = Documents::method18(v252.clone());
                                let v278: string = Documents::method19();
                                let _v279: MutCell<Option<Result<regex::Regex, regex::Error>>> =
                                    MutCell::new(None::<Result<regex::Regex, regex::Error>>);
                                let v280: string = Documents::method20();
                                {
                                    let x_10: Result<regex::Regex, regex::Error> =
                                        regex::Regex::new(&v280);
                                    _v279.set(Some(x_10))
                                }
                                {
                                    let v288: Result<regex::Regex, regex::Error> =
                                        getValue(_v279.get().clone());
                                    let v290: regex::Regex = v288.unwrap();
                                    let v292: std::borrow::Cow<str> =
                                        v290.replace_all(&v277, &*v278);
                                    let v294: std::string::String = String::from(v292);
                                    {
                                        let x_11: string =
                                            fable_library_rust::String_::fromString(v294);
                                        _v276.set(Some(x_11))
                                    }
                                    {
                                        let v303: string = getValue(_v276.get().clone());
                                        let v305: string = replace(
                                            sprintf!(
                                                "{}{}",
                                                toLower(ofChar(getCharAt(v303.clone(), 0_i32))),
                                                getSlice(v303, Some(1_i32), None::<i32>)
                                            ),
                                            string("\\"),
                                            string("/"),
                                        );
                                        let v307: Result<std::fs::File, std::io::Error> =
                                            std::fs::File::open(&*v305);
                                        let v309: std::fs::File = v307.unwrap();
                                        let v311: std::io::BufReader<std::fs::File> =
                                            std::io::BufReader::new(v309);
                                        let v313: bool = true;
                                        let mut v311 = v311;
                                        let v315: sha2::Sha256 = sha2::Digest::new();
                                        let v317: bool = true;
                                        let mut v315 = v315;
                                        let v318: usize = 0_i32 as usize;
                                        let v320: _ = [0_u8; 1024];
                                        let v322: bool = true;
                                        loop {
                                            // rust.loop;
                                            let v324: bool = true;
                                            let mut v320 = v320;
                                            let v326: Result<usize, std::io::Error> =
                                                std::io::Read::read(&mut v311, &mut v320);
                                            let v328: usize = v326.unwrap();
                                            if v328 == v318 {
                                                let v331: bool = true;
                                                break;
                                                ()
                                            }
                                            {
                                                let v333: usize = v320.len();
                                                let v334: u8 = v333 as u8;
                                                let v335: usize = v328;
                                                let v342: &_ = if v335 == v333 {
                                                    &v320[v318..]
                                                } else {
                                                    &v320[v318..v335]
                                                };
                                                sha2::Digest::update(&mut v315, v342);
                                                {
                                                    let v345: bool = true;
                                                } // rust.loop;
                                                let v347: bool = true;
                                            } // rust.loop;
                                            let v349: bool = true;
                                        } // rust.loop;
                                        let v351: bool = true;
                                        {
                                            // rust.loop;
                                            let v353: bool = true;
                                            {
                                                // rust.loop;
                                                let v355: &[u8] = &sha2::Digest::finalize(v315);
                                                let v357: Vec<u8> =
                                                    v355.iter().map(|x| *x).collect();
                                                fn v359(v: u8) -> string {
                                                    Documents::closure51((), v)
                                                }
                                                let v360: Vec<string> = v357
                                                    .into_iter()
                                                    .map(|x| Func1::from(v359)(x.clone()))
                                                    .collect();
                                                let v362: Array<string> =
                                                    fable_library_rust::NativeArray_::array_from(
                                                        v360,
                                                    );
                                                let v363: LrcPtr<dyn IEnumerable_1<string>> =
                                                    delay(Func0::new({
                                                        let v362 = v362.clone();
                                                        move || {
                                                            map(
                                                                Func1::new({
                                                                    let v362 = v362.clone();
                                                                    move |i_1: i32| {
                                                                        v362[i_1].clone()
                                                                    }
                                                                }),
                                                                rangeNumeric(
                                                                    0_i32,
                                                                    1_i32,
                                                                    count(v362.clone()) - 1_i32,
                                                                ),
                                                            )
                                                        }
                                                    }));
                                                let v367: string =
                                                    join(Documents::method52(), toArray(v363));
                                                let _v368: MutCell<Option<bool>> =
                                                    MutCell::new(None::<bool>);
                                                let v370: &str = &*v264.clone();
                                                let v372: std::string::String = String::from(v370);
                                                let v374: std::path::PathBuf =
                                                    std::path::PathBuf::from(v372);
                                                {
                                                    let x_12: bool = if v374.clone().exists() {
                                                        v374.is_file()
                                                    } else {
                                                        false
                                                    };
                                                    _v368.set(Some(x_12))
                                                }
                                                {
                                                    let v483: Documents::US3 = if getValue(
                                                        _v368.get().clone(),
                                                    ) {
                                                        let _v390: MutCell<Option<string>> =
                                                            MutCell::new(None::<string>);
                                                        let v391: string =
                                                            Documents::method18(v264.clone());
                                                        let v392: string = Documents::method19();
                                                        let _v393: MutCell<
                                                            Option<
                                                                Result<regex::Regex, regex::Error>,
                                                            >,
                                                        > = MutCell::new(
                                                            None::<
                                                                Result<regex::Regex, regex::Error>,
                                                            >,
                                                        );
                                                        let v394: string = Documents::method20();
                                                        {
                                                            let x_13: Result<
                                                                regex::Regex,
                                                                regex::Error,
                                                            > = regex::Regex::new(&v394);
                                                            _v393.set(Some(x_13))
                                                        }
                                                        {
                                                            let v402: Result<
                                                                regex::Regex,
                                                                regex::Error,
                                                            > = getValue(_v393.get().clone());
                                                            let v404: regex::Regex = v402.unwrap();
                                                            let v406: std::borrow::Cow<str> =
                                                                v404.replace_all(&v391, &*v392);
                                                            let v408: std::string::String =
                                                                String::from(v406);
                                                            {
                                                                let x_14:
                                                                                string =
                                                                            fable_library_rust::String_::fromString(v408);
                                                                _v390.set(Some(x_14))
                                                            }
                                                            {
                                                                let v417: string =
                                                                    getValue(_v390.get().clone());
                                                                let v419: string = replace(
                                                                    sprintf!(
                                                                        "{}{}",
                                                                        toLower(ofChar(getCharAt(
                                                                            v417.clone(),
                                                                            0_i32
                                                                        ))),
                                                                        getSlice(
                                                                            v417,
                                                                            Some(1_i32),
                                                                            None::<i32>
                                                                        )
                                                                    ),
                                                                    string("\\"),
                                                                    string("/"),
                                                                );
                                                                let v421: Result<
                                                                    std::fs::File,
                                                                    std::io::Error,
                                                                > = std::fs::File::open(&*v419);
                                                                let v423: std::fs::File =
                                                                    v421.unwrap();
                                                                let v425: std::io::BufReader<
                                                                    std::fs::File,
                                                                > = std::io::BufReader::new(v423);
                                                                let v427: bool = true;
                                                                let mut v425 = v425;
                                                                let v429: sha2::Sha256 =
                                                                    sha2::Digest::new();
                                                                let v431: bool = true;
                                                                let mut v429 = v429;
                                                                let v432: usize = 0_i32 as usize;
                                                                let v434: _ = [0_u8; 1024];
                                                                let v436: bool = true;
                                                                loop {
                                                                    // rust.loop;
                                                                    let v438: bool = true;
                                                                    let mut v434 = v434;
                                                                    let v440: Result<
                                                                        usize,
                                                                        std::io::Error,
                                                                    > = std::io::Read::read(
                                                                        &mut v425, &mut v434,
                                                                    );
                                                                    let v442: usize = v440.unwrap();
                                                                    if v442 == v432 {
                                                                        let v445: bool = true;
                                                                        break;
                                                                        ()
                                                                    }
                                                                    {
                                                                        let v447: usize =
                                                                            v434.len();
                                                                        let v448: u8 = v447 as u8;
                                                                        let v449: usize = v442;
                                                                        let v456: &_ =
                                                                            if v449 == v447 {
                                                                                &v434[v432..]
                                                                            } else {
                                                                                &v434[v432..v449]
                                                                            };
                                                                        sha2::Digest::update(
                                                                            &mut v429, v456,
                                                                        );
                                                                        {
                                                                            let v459: bool = true;
                                                                        } // rust.loop;
                                                                        let v461: bool = true;
                                                                    } // rust.loop;
                                                                    let v463: bool = true;
                                                                } // rust.loop;
                                                                let v465: bool = true;
                                                                {
                                                                    // rust.loop;
                                                                    let v467: bool = true;
                                                                    {
                                                                        // rust.loop;
                                                                        let v469: &[u8] =
                                                                            &sha2::Digest::finalize(
                                                                                v429,
                                                                            );
                                                                        let v471: Vec<u8> = v469
                                                                            .iter()
                                                                            .map(|x| *x)
                                                                            .collect();
                                                                        let v473: Vec<string> =
                                                                            v471.into_iter()
                                                                                .map(|x| {
                                                                                    Func1::from(
                                                                                        v359,
                                                                                    )(
                                                                                        x.clone()
                                                                                    )
                                                                                })
                                                                                .collect();
                                                                        let v475:
                                                                                        Array<string> =
                                                                                    fable_library_rust::NativeArray_::array_from(v473);
                                                                        let v476: LrcPtr<
                                                                            dyn IEnumerable_1<
                                                                                string,
                                                                            >,
                                                                        > = delay(Func0::new({
                                                                            let v475 = v475.clone();
                                                                            move || {
                                                                                map(Func1::new({
                                                                                                                                let v475
                                                                                                                                    =
                                                                                                                                    v475.clone();
                                                                                                                                move
                                                                                                                                    |i_2:
                                                                                                                                         i32|
                                                                                                                                    v475[i_2].clone()
                                                                                                                            }),
                                                                                                                 rangeNumeric(0_i32,
                                                                                                                              1_i32,
                                                                                                                              count(v475.clone())
                                                                                                                                  -
                                                                                                                                  1_i32))
                                                                            }
                                                                        }));
                                                                        Documents::US3::US3_0(join(
                                                                            Documents::method52(),
                                                                            toArray(v476),
                                                                        ))
                                                                    }
                                                                }
                                                            }
                                                        }
                                                    } else {
                                                        Documents::US3::US3_1
                                                    };
                                                    if if if let Documents::US3::US3_1 = &v483 {
                                                        true
                                                    } else {
                                                        false
                                                    } {
                                                        true
                                                    } else {
                                                        v367.clone() != match &v483 {
                                                            Documents::US3::US3_0(v483_0_0) => {
                                                                match &v483 {
                                                                    Documents::US3::US3_0(x) => {
                                                                        x.clone()
                                                                    }
                                                                    _ => unreachable!(),
                                                                }
                                                            }
                                                            _ => panic!(
                                                                "{}",
                                                                string(
                                                                    "Option does not have a value."
                                                                ),
                                                            ),
                                                        }
                                                    } {
                                                        Documents::method3(
                                                            Documents::US0::US0_2,
                                                            Func0::new(move || {
                                                                Documents::closure52((), ())
                                                            }),
                                                            Func0::new({
                                                                let patternInput_3 =
                                                                    patternInput_3.clone();
                                                                let patternInput_4 =
                                                                    patternInput_4.clone();
                                                                let v207 = v207.clone();
                                                                let v238 = v238.clone();
                                                                let v240 = v240.clone();
                                                                let v250 = v250.clone();
                                                                let v252 = v252.clone();
                                                                let v262 = v262.clone();
                                                                let v264 = v264.clone();
                                                                let v367 = v367.clone();
                                                                let v483 = v483.clone();
                                                                move || {
                                                                    Documents::closure53(
                                                                        v207.clone(),
                                                                        v238.clone(),
                                                                        v240.clone(),
                                                                        v250.clone(),
                                                                        patternInput_3.0.clone(),
                                                                        v252.clone(),
                                                                        v262.clone(),
                                                                        patternInput_4.0.clone(),
                                                                        v264.clone(),
                                                                        v367.clone(),
                                                                        v483.clone(),
                                                                        (),
                                                                    )
                                                                }
                                                            }),
                                                        );
                                                        {
                                                            let _v495: MutCell<Option<()>> =
                                                                MutCell::new(None::<()>);
                                                            let v496: string =
                                                                Documents::method53(v264.clone());
                                                            let v498: Result<u64, std::io::Error> =
                                                                std::fs::copy(
                                                                    &*v252.clone(),
                                                                    &*v496,
                                                                );
                                                            let v500: u64 = v498.unwrap();
                                                            _v495.set(Some(()));
                                                            getValue(_v495.get().clone());
                                                            LrcPtr::new(Documents::UH2::UH2_1(LrcPtr::new(Documents::UH3::UH3_1(string("hangul.md"),
                                                                                                                                    v252.clone(),
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
                                                                                                                                                                           Documents::closure54(v4.clone(),
                                                                                                                                                                                                v3.clone(),
                                                                                                                                                                                                v1_1.clone(),
                                                                                                                                                                                                v0_1.clone(),
                                                                                                                                                                                                v_1)
                                                                                                                                                                   }))(b0)(b1)
                                                                                                                                               }),
                                                                                                                                    LrcPtr::new(Documents::UH3::UH3_0))),
                                                                                                  LrcPtr::new(Documents::UH2::UH2_1(LrcPtr::new(Documents::UH3::UH3_1(string("html"),
                                                                                                                                                                      v252.clone(),
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
                                                                                                                                                                                                             |v_2:
                                                                                                                                                                                                                  string|
                                                                                                                                                                                                             Documents::closure61(v4.clone(),
                                                                                                                                                                                                                                  v3.clone(),
                                                                                                                                                                                                                                  false,
                                                                                                                                                                                                                                  v_2)
                                                                                                                                                                                                     }))(b0)(b1)
                                                                                                                                                                                 }),
                                                                                                                                                                      LrcPtr::new(Documents::UH3::UH3_1(string("pdf"),
                                                                                                                                                                                                        v252.clone(),
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
                                                                                                                                                                                                                                               Documents::closure61(v4.clone(),
                                                                                                                                                                                                                                                                    v3.clone(),
                                                                                                                                                                                                                                                                    false,
                                                                                                                                                                                                                                                                    v_3)
                                                                                                                                                                                                                                       }))(b0)(b1)
                                                                                                                                                                                                                   }),
                                                                                                                                                                                                        LrcPtr::new(Documents::UH3::UH3_1(string("epub"),
                                                                                                                                                                                                                                          v252.clone(),
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
                                                                                                                                                                                                                                                                                 Documents::closure61(v4.clone(),
                                                                                                                                                                                                                                                                                                      v3.clone(),
                                                                                                                                                                                                                                                                                                      false,
                                                                                                                                                                                                                                                                                                      v_4)
                                                                                                                                                                                                                                                                         }))(b0)(b1)
                                                                                                                                                                                                                                                     }),
                                                                                                                                                                                                                                          LrcPtr::new(Documents::UH3::UH3_1(string("html"),
                                                                                                                                                                                                                                                                            v267.clone(),
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
                                                                                                                                                                                                                                                                                                                   Documents::closure61(v4.clone(),
                                                                                                                                                                                                                                                                                                                                        v3.clone(),
                                                                                                                                                                                                                                                                                                                                        true,
                                                                                                                                                                                                                                                                                                                                        v_5)
                                                                                                                                                                                                                                                                                                           }))(b0)(b1)
                                                                                                                                                                                                                                                                                       }),
                                                                                                                                                                                                                                                                            LrcPtr::new(Documents::UH3::UH3_1(string("pdf"),
                                                                                                                                                                                                                                                                                                              v267.clone(),
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
                                                                                                                                                                                                                                                                                                                                                     Documents::closure61(v4.clone(),
                                                                                                                                                                                                                                                                                                                                                                          v3.clone(),
                                                                                                                                                                                                                                                                                                                                                                          true,
                                                                                                                                                                                                                                                                                                                                                                          v_6)
                                                                                                                                                                                                                                                                                                                                             }))(b0)(b1)
                                                                                                                                                                                                                                                                                                                         }),
                                                                                                                                                                                                                                                                                                              LrcPtr::new(Documents::UH3::UH3_1(string("epub"),
                                                                                                                                                                                                                                                                                                                                                v267.clone(),
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
                                                                                                                                                                                                                                                                                                                                                                                       Documents::closure61(v4.clone(),
                                                                                                                                                                                                                                                                                                                                                                                                            v3.clone(),
                                                                                                                                                                                                                                                                                                                                                                                                            true,
                                                                                                                                                                                                                                                                                                                                                                                                            v_7)
                                                                                                                                                                                                                                                                                                                                                                               }))(b0)(b1)
                                                                                                                                                                                                                                                                                                                                                           }),
                                                                                                                                                                                                                                                                                                                                                LrcPtr::new(Documents::UH3::UH3_0))))))))))))),
                                                                                                                                    LrcPtr::new(Documents::UH2::UH2_0)))))
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
                                LrcPtr::new(Documents::UH2::UH2_0)
                            };
                            let v958: Array<LrcPtr<Documents::UH3>> = toArray_1(
                                Documents::method61(
                                    if (if let Documents::UH2::UH2_0 = v526.as_ref() {
                                        true
                                    } else {
                                        false
                                    }) != true
                                    {
                                        v526
                                    } else {
                                        let patternInput_6: (string, string) = Documents::method51(
                                            string("epub"),
                                            v267.clone(),
                                            v4.clone(),
                                        );
                                        let v532: string = patternInput_6.1.clone();
                                        let v531: string = patternInput_6.0.clone();
                                        let _v533: MutCell<Option<bool>> =
                                            MutCell::new(None::<bool>);
                                        let v535: &str = &*v532.clone();
                                        let v537: std::string::String = String::from(v535);
                                        let v539: std::path::PathBuf =
                                            std::path::PathBuf::from(v537);
                                        {
                                            let x_16: bool = if v539.clone().exists() {
                                                v539.is_file()
                                            } else {
                                                false
                                            };
                                            _v533.set(Some(x_16))
                                        }
                                        {
                                            let v592: LrcPtr<Documents::UH3> =
                                                if if getValue(_v533.get().clone()) == false {
                                                    let _v556: MutCell<Option<bool>> =
                                                        MutCell::new(None::<bool>);
                                                    let v558: &str = &*v531.clone();
                                                    let v560: std::string::String =
                                                        String::from(v558);
                                                    let v562: std::path::PathBuf =
                                                        std::path::PathBuf::from(v560);
                                                    {
                                                        let x_17: bool = if v562.clone().exists() {
                                                            v562.is_file()
                                                        } else {
                                                            false
                                                        };
                                                        _v556.set(Some(x_17))
                                                    }
                                                    if getValue(_v556.get().clone()) {
                                                        Documents::method3(
                                                            Documents::US0::US0_2,
                                                            Func0::new(move || {
                                                                Documents::closure65((), ())
                                                            }),
                                                            Func0::new({
                                                                let v531 = v531.clone();
                                                                let v532 = v532.clone();
                                                                move || {
                                                                    Documents::closure66(
                                                                        v531.clone(),
                                                                        v532.clone(),
                                                                        (),
                                                                    )
                                                                }
                                                            }),
                                                        );
                                                        {
                                                            let _v580: MutCell<Option<()>> =
                                                                MutCell::new(None::<()>);
                                                            let v581: string =
                                                                Documents::method53(v532.clone());
                                                            let v583: Result<u64, std::io::Error> =
                                                                std::fs::copy(
                                                                    &*v531.clone(),
                                                                    &*v581,
                                                                );
                                                            let v585: u64 = v583.unwrap();
                                                            _v580.set(Some(()));
                                                            getValue(_v580.get().clone());
                                                            false
                                                        }
                                                    } else {
                                                        true
                                                    }
                                                } else {
                                                    true
                                                } {
                                                    LrcPtr::new(Documents::UH3::UH3_1(
                                                        string("epub"),
                                                        v267.clone(),
                                                        Func2::new({
                                                            let v3 = v3.clone();
                                                            let v4 = v4.clone();
                                                            move |b0: string, b1: string| {
                                                                (Func1::new({
                                                                    let v3 = v3.clone();
                                                                    let v4 = v4.clone();
                                                                    move |v_8: string| {
                                                                        Documents::closure61(
                                                                            v4.clone(),
                                                                            v3.clone(),
                                                                            true,
                                                                            v_8,
                                                                        )
                                                                    }
                                                                }))(
                                                                    b0
                                                                )(
                                                                    b1
                                                                )
                                                            }
                                                        }),
                                                        LrcPtr::new(Documents::UH3::UH3_0),
                                                    ))
                                                } else {
                                                    LrcPtr::new(Documents::UH3::UH3_0)
                                                };
                                            let patternInput_7: (string, string) =
                                                Documents::method51(
                                                    string("pdf"),
                                                    v267.clone(),
                                                    v4.clone(),
                                                );
                                            let v595: string = patternInput_7.1.clone();
                                            let v594: string = patternInput_7.0.clone();
                                            let _v596: MutCell<Option<bool>> =
                                                MutCell::new(None::<bool>);
                                            let v598: &str = &*v595.clone();
                                            let v600: std::string::String = String::from(v598);
                                            let v602: std::path::PathBuf =
                                                std::path::PathBuf::from(v600);
                                            {
                                                let x_19: bool = if v602.clone().exists() {
                                                    v602.is_file()
                                                } else {
                                                    false
                                                };
                                                _v596.set(Some(x_19))
                                            }
                                            {
                                                let v652: LrcPtr<Documents::UH3> =
                                                    if if getValue(_v596.get().clone()) == false {
                                                        let _v618: MutCell<Option<bool>> =
                                                            MutCell::new(None::<bool>);
                                                        let v620: &str = &*v594.clone();
                                                        let v622: std::string::String =
                                                            String::from(v620);
                                                        let v624: std::path::PathBuf =
                                                            std::path::PathBuf::from(v622);
                                                        {
                                                            let x_20: bool =
                                                                if v624.clone().exists() {
                                                                    v624.is_file()
                                                                } else {
                                                                    false
                                                                };
                                                            _v618.set(Some(x_20))
                                                        }
                                                        if getValue(_v618.get().clone()) {
                                                            Documents::method3(
                                                                Documents::US0::US0_2,
                                                                Func0::new(move || {
                                                                    Documents::closure65((), ())
                                                                }),
                                                                Func0::new({
                                                                    let v594 = v594.clone();
                                                                    let v595 = v595.clone();
                                                                    move || {
                                                                        Documents::closure66(
                                                                            v594.clone(),
                                                                            v595.clone(),
                                                                            (),
                                                                        )
                                                                    }
                                                                }),
                                                            );
                                                            {
                                                                let _v642: MutCell<Option<()>> =
                                                                    MutCell::new(None::<()>);
                                                                let v643: string =
                                                                    Documents::method53(
                                                                        v595.clone(),
                                                                    );
                                                                let v645: Result<
                                                                    u64,
                                                                    std::io::Error,
                                                                > = std::fs::copy(
                                                                    &*v594.clone(),
                                                                    &*v643,
                                                                );
                                                                let v647: u64 = v645.unwrap();
                                                                _v642.set(Some(()));
                                                                getValue(_v642.get().clone());
                                                                false
                                                            }
                                                        } else {
                                                            true
                                                        }
                                                    } else {
                                                        true
                                                    } {
                                                        LrcPtr::new(Documents::UH3::UH3_1(
                                                            string("pdf"),
                                                            v267.clone(),
                                                            Func2::new({
                                                                let v3 = v3.clone();
                                                                let v4 = v4.clone();
                                                                move |b0: string, b1: string| {
                                                                    (Func1::new({
                                                                        let v3 = v3.clone();
                                                                        let v4 = v4.clone();
                                                                        move |v_9: string| {
                                                                            Documents::closure61(
                                                                                v4.clone(),
                                                                                v3.clone(),
                                                                                true,
                                                                                v_9,
                                                                            )
                                                                        }
                                                                    }))(
                                                                        b0
                                                                    )(
                                                                        b1
                                                                    )
                                                                }
                                                            }),
                                                            v592.clone(),
                                                        ))
                                                    } else {
                                                        v592
                                                    };
                                                let patternInput_8: (string, string) =
                                                    Documents::method51(
                                                        string("html"),
                                                        v267.clone(),
                                                        v4.clone(),
                                                    );
                                                let v655: string = patternInput_8.1.clone();
                                                let v654: string = patternInput_8.0.clone();
                                                let _v656: MutCell<Option<bool>> =
                                                    MutCell::new(None::<bool>);
                                                let v658: &str = &*v655.clone();
                                                let v660: std::string::String = String::from(v658);
                                                let v662: std::path::PathBuf =
                                                    std::path::PathBuf::from(v660);
                                                {
                                                    let x_22: bool = if v662.clone().exists() {
                                                        v662.is_file()
                                                    } else {
                                                        false
                                                    };
                                                    _v656.set(Some(x_22))
                                                }
                                                {
                                                    let v712: LrcPtr<Documents::UH3> =
                                                        if if getValue(_v656.get().clone()) == false
                                                        {
                                                            let _v678: MutCell<Option<bool>> =
                                                                MutCell::new(None::<bool>);
                                                            let v680: &str = &*v654.clone();
                                                            let v682: std::string::String =
                                                                String::from(v680);
                                                            let v684: std::path::PathBuf =
                                                                std::path::PathBuf::from(v682);
                                                            {
                                                                let x_23: bool =
                                                                    if v684.clone().exists() {
                                                                        v684.is_file()
                                                                    } else {
                                                                        false
                                                                    };
                                                                _v678.set(Some(x_23))
                                                            }
                                                            if getValue(_v678.get().clone()) {
                                                                Documents::method3(
                                                                    Documents::US0::US0_2,
                                                                    Func0::new(move || {
                                                                        Documents::closure65((), ())
                                                                    }),
                                                                    Func0::new({
                                                                        let v654 = v654.clone();
                                                                        let v655 = v655.clone();
                                                                        move || {
                                                                            Documents::closure66(
                                                                                v654.clone(),
                                                                                v655.clone(),
                                                                                (),
                                                                            )
                                                                        }
                                                                    }),
                                                                );
                                                                {
                                                                    let _v702: MutCell<Option<()>> =
                                                                        MutCell::new(None::<()>);
                                                                    let v703: string =
                                                                        Documents::method53(
                                                                            v655.clone(),
                                                                        );
                                                                    let v705: Result<
                                                                        u64,
                                                                        std::io::Error,
                                                                    > = std::fs::copy(
                                                                        &*v654.clone(),
                                                                        &*v703,
                                                                    );
                                                                    let v707: u64 = v705.unwrap();
                                                                    _v702.set(Some(()));
                                                                    getValue(_v702.get().clone());
                                                                    false
                                                                }
                                                            } else {
                                                                true
                                                            }
                                                        } else {
                                                            true
                                                        } {
                                                            LrcPtr::new(Documents::UH3::UH3_1(
                                                                string("html"),
                                                                v267,
                                                                Func2::new({
                                                                    let v3 = v3.clone();
                                                                    let v4 = v4.clone();
                                                                    move |b0: string, b1: string| {
                                                                        (Func1::new({
                                                                            let v3 = v3.clone();
                                                                            let v4 = v4.clone();
                                                                            move |v_10: string| {
                                                                                Documents::closure61(
                                                                                    v4.clone(),
                                                                                    v3.clone(),
                                                                                    true,
                                                                                    v_10,
                                                                                )
                                                                            }
                                                                        }))(
                                                                            b0
                                                                        )(
                                                                            b1
                                                                        )
                                                                    }
                                                                }),
                                                                v652.clone(),
                                                            ))
                                                        } else {
                                                            v652
                                                        };
                                                    let patternInput_9: (string, string) =
                                                        Documents::method51(
                                                            string("epub"),
                                                            v252.clone(),
                                                            v4.clone(),
                                                        );
                                                    let v714: string = patternInput_9.1.clone();
                                                    let v713: string = patternInput_9.0.clone();
                                                    let _v715: MutCell<Option<bool>> =
                                                        MutCell::new(None::<bool>);
                                                    let v717: &str = &*v714.clone();
                                                    let v719: std::string::String =
                                                        String::from(v717);
                                                    let v721: std::path::PathBuf =
                                                        std::path::PathBuf::from(v719);
                                                    {
                                                        let x_25: bool = if v721.clone().exists() {
                                                            v721.is_file()
                                                        } else {
                                                            false
                                                        };
                                                        _v715.set(Some(x_25))
                                                    }
                                                    {
                                                        let v771: LrcPtr<Documents::UH3> =
                                                            if if getValue(_v715.get().clone())
                                                                == false
                                                            {
                                                                let _v737: MutCell<Option<bool>> =
                                                                    MutCell::new(None::<bool>);
                                                                let v739: &str = &*v713.clone();
                                                                let v741: std::string::String =
                                                                    String::from(v739);
                                                                let v743: std::path::PathBuf =
                                                                    std::path::PathBuf::from(v741);
                                                                {
                                                                    let x_26: bool =
                                                                        if v743.clone().exists() {
                                                                            v743.is_file()
                                                                        } else {
                                                                            false
                                                                        };
                                                                    _v737.set(Some(x_26))
                                                                }
                                                                if getValue(_v737.get().clone()) {
                                                                    Documents::method3(
                                                                        Documents::US0::US0_2,
                                                                        Func0::new(move || {
                                                                            Documents::closure65(
                                                                                (),
                                                                                (),
                                                                            )
                                                                        }),
                                                                        Func0::new({
                                                                            let v713 = v713.clone();
                                                                            let v714 = v714.clone();
                                                                            move || {
                                                                                Documents::closure66(
                                                                                    v713.clone(),
                                                                                    v714.clone(),
                                                                                    (),
                                                                                )
                                                                            }
                                                                        }),
                                                                    );
                                                                    {
                                                                        let _v761: MutCell<
                                                                            Option<()>,
                                                                        > = MutCell::new(
                                                                            None::<()>,
                                                                        );
                                                                        let v762: string =
                                                                            Documents::method53(
                                                                                v714.clone(),
                                                                            );
                                                                        let v764: Result<
                                                                            u64,
                                                                            std::io::Error,
                                                                        > = std::fs::copy(
                                                                            &*v713.clone(),
                                                                            &*v762,
                                                                        );
                                                                        let v766: u64 =
                                                                            v764.unwrap();
                                                                        _v761.set(Some(()));
                                                                        getValue(
                                                                            _v761.get().clone(),
                                                                        );
                                                                        false
                                                                    }
                                                                } else {
                                                                    true
                                                                }
                                                            } else {
                                                                true
                                                            } {
                                                                LrcPtr::new(Documents::UH3::UH3_1(
                                                                    string("epub"),
                                                                    v252.clone(),
                                                                    Func2::new({
                                                                        let v3 = v3.clone();
                                                                        let v4 = v4.clone();
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
                                                                                                                                                                   |v_11:
                                                                                                                                                                        string|
                                                                                                                                                                   Documents::closure61(v4.clone(),
                                                                                                                                                                                        v3.clone(),
                                                                                                                                                                                        false,
                                                                                                                                                                                        v_11)
                                                                                                                                                           }))(b0)(b1)
                                                                    }),
                                                                    v712.clone(),
                                                                ))
                                                            } else {
                                                                v712
                                                            };
                                                        let patternInput_10: (string, string) =
                                                            Documents::method51(
                                                                string("pdf"),
                                                                v252.clone(),
                                                                v4.clone(),
                                                            );
                                                        let v773: string =
                                                            patternInput_10.1.clone();
                                                        let v772: string =
                                                            patternInput_10.0.clone();
                                                        let _v774: MutCell<Option<bool>> =
                                                            MutCell::new(None::<bool>);
                                                        let v776: &str = &*v773.clone();
                                                        let v778: std::string::String =
                                                            String::from(v776);
                                                        let v780: std::path::PathBuf =
                                                            std::path::PathBuf::from(v778);
                                                        {
                                                            let x_28: bool =
                                                                if v780.clone().exists() {
                                                                    v780.is_file()
                                                                } else {
                                                                    false
                                                                };
                                                            _v774.set(Some(x_28))
                                                        }
                                                        {
                                                            let v830: LrcPtr<Documents::UH3> =
                                                                if if getValue(_v774.get().clone())
                                                                    == false
                                                                {
                                                                    let _v796: MutCell<
                                                                        Option<bool>,
                                                                    > = MutCell::new(None::<bool>);
                                                                    let v798: &str = &*v772.clone();
                                                                    let v800: std::string::String =
                                                                        String::from(v798);
                                                                    let v802: std::path::PathBuf =
                                                                        std::path::PathBuf::from(
                                                                            v800,
                                                                        );
                                                                    {
                                                                        let x_29: bool = if v802
                                                                            .clone()
                                                                            .exists()
                                                                        {
                                                                            v802.is_file()
                                                                        } else {
                                                                            false
                                                                        };
                                                                        _v796.set(Some(x_29))
                                                                    }
                                                                    if getValue(_v796.get().clone())
                                                                    {
                                                                        Documents::method3(
                                                                            Documents::US0::US0_2,
                                                                            Func0::new(move || {
                                                                                Documents::closure65(
                                                                                    (),
                                                                                    (),
                                                                                )
                                                                            }),
                                                                            Func0::new({
                                                                                let v772 =
                                                                                    v772.clone();
                                                                                let v773 =
                                                                                    v773.clone();
                                                                                move || {
                                                                                    Documents::closure66(v772.clone(),
                                                                                                                                                                v773.clone(),
                                                                                                                                                                ())
                                                                                }
                                                                            }),
                                                                        );
                                                                        {
                                                                            let _v820: MutCell<
                                                                                Option<()>,
                                                                            > = MutCell::new(
                                                                                None::<()>,
                                                                            );
                                                                            let v821: string =
                                                                                Documents::method53(
                                                                                    v773.clone(),
                                                                                );
                                                                            let v823: Result<
                                                                                u64,
                                                                                std::io::Error,
                                                                            > = std::fs::copy(
                                                                                &*v772.clone(),
                                                                                &*v821,
                                                                            );
                                                                            let v825: u64 =
                                                                                v823.unwrap();
                                                                            _v820.set(Some(()));
                                                                            getValue(
                                                                                _v820.get().clone(),
                                                                            );
                                                                            false
                                                                        }
                                                                    } else {
                                                                        true
                                                                    }
                                                                } else {
                                                                    true
                                                                } {
                                                                    LrcPtr::new(
                                                                        Documents::UH3::UH3_1(
                                                                            string("pdf"),
                                                                            v252.clone(),
                                                                            Func2::new({
                                                                                let v3 = v3.clone();
                                                                                let v4 = v4.clone();
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
                                                                                                                                                                       |v_12:
                                                                                                                                                                            string|
                                                                                                                                                                       Documents::closure61(v4.clone(),
                                                                                                                                                                                            v3.clone(),
                                                                                                                                                                                            false,
                                                                                                                                                                                            v_12)
                                                                                                                                                               }))(b0)(b1)
                                                                            }),
                                                                            v771.clone(),
                                                                        ),
                                                                    )
                                                                } else {
                                                                    v771
                                                                };
                                                            let patternInput_11: (string, string) =
                                                                Documents::method51(
                                                                    string("html"),
                                                                    v252.clone(),
                                                                    v4.clone(),
                                                                );
                                                            let v832: string =
                                                                patternInput_11.1.clone();
                                                            let v831: string =
                                                                patternInput_11.0.clone();
                                                            let _v833: MutCell<Option<bool>> =
                                                                MutCell::new(None::<bool>);
                                                            let v835: &str = &*v832.clone();
                                                            let v837: std::string::String =
                                                                String::from(v835);
                                                            let v839: std::path::PathBuf =
                                                                std::path::PathBuf::from(v837);
                                                            {
                                                                let x_31: bool =
                                                                    if v839.clone().exists() {
                                                                        v839.is_file()
                                                                    } else {
                                                                        false
                                                                    };
                                                                _v833.set(Some(x_31))
                                                            }
                                                            {
                                                                let v889: LrcPtr<Documents::UH3> =
                                                                    if if getValue(
                                                                        _v833.get().clone(),
                                                                    ) == false
                                                                    {
                                                                        let _v855: MutCell<
                                                                            Option<bool>,
                                                                        > = MutCell::new(
                                                                            None::<bool>,
                                                                        );
                                                                        let v857: &str =
                                                                            &*v831.clone();
                                                                        let v859:
                                                                                                             std::string::String =
                                                                                                         String::from(v857);
                                                                        let v861:
                                                                                                             std::path::PathBuf =
                                                                                                         std::path::PathBuf::from(v859);
                                                                        {
                                                                            let x_32: bool = if v861
                                                                                .clone()
                                                                                .exists()
                                                                            {
                                                                                v861.is_file()
                                                                            } else {
                                                                                false
                                                                            };
                                                                            _v855.set(Some(x_32))
                                                                        }
                                                                        if getValue(
                                                                            _v855.get().clone(),
                                                                        ) {
                                                                            Documents::method3(Documents::US0::US0_2,
                                                                                                                            Func0::new(move
                                                                                                                                           ||
                                                                                                                                           Documents::closure65((),
                                                                                                                                                                ())),
                                                                                                                            Func0::new({
                                                                                                                                           let v831
                                                                                                                                               =
                                                                                                                                               v831.clone();
                                                                                                                                           let v832
                                                                                                                                               =
                                                                                                                                               v832.clone();
                                                                                                                                           move
                                                                                                                                               ||
                                                                                                                                               Documents::closure66(v831.clone(),
                                                                                                                                                                    v832.clone(),
                                                                                                                                                                    ())
                                                                                                                                       }));
                                                                            {
                                                                                let _v879: MutCell<
                                                                                    Option<()>,
                                                                                > = MutCell::new(
                                                                                    None::<()>,
                                                                                );
                                                                                let v880:
                                                                                                                     string =
                                                                                                                 Documents::method53(v832.clone());
                                                                                let v882: Result<
                                                                                    u64,
                                                                                    std::io::Error,
                                                                                > = std::fs::copy(
                                                                                    &*v831.clone(),
                                                                                    &*v880,
                                                                                );
                                                                                let v884: u64 =
                                                                                    v882.unwrap();
                                                                                _v879.set(Some(()));
                                                                                getValue(
                                                                                    _v879
                                                                                        .get()
                                                                                        .clone(),
                                                                                );
                                                                                false
                                                                            }
                                                                        } else {
                                                                            true
                                                                        }
                                                                    } else {
                                                                        true
                                                                    } {
                                                                        LrcPtr::new(
                                                                            Documents::UH3::UH3_1(
                                                                                string("html"),
                                                                                v252.clone(),
                                                                                Func2::new({
                                                                                    let v3 =
                                                                                        v3.clone();
                                                                                    let v4 =
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
                                                                                                                                                                           |v_13:
                                                                                                                                                                                string|
                                                                                                                                                                           Documents::closure61(v4.clone(),
                                                                                                                                                                                                v3.clone(),
                                                                                                                                                                                                false,
                                                                                                                                                                                                v_13)
                                                                                                                                                                   }))(b0)(b1)
                                                                                }),
                                                                                v830.clone(),
                                                                            ),
                                                                        )
                                                                    } else {
                                                                        v830
                                                                    };
                                                                let patternInput_12: (
                                                                    string,
                                                                    string,
                                                                ) = Documents::method51(
                                                                    string("hangul.md"),
                                                                    v252.clone(),
                                                                    v4.clone(),
                                                                );
                                                                let v891: string =
                                                                    patternInput_12.1.clone();
                                                                let v890: string =
                                                                    patternInput_12.0.clone();
                                                                let _v892: MutCell<Option<bool>> =
                                                                    MutCell::new(None::<bool>);
                                                                let v894: &str = &*v891.clone();
                                                                let v896: std::string::String =
                                                                    String::from(v894);
                                                                let v898: std::path::PathBuf =
                                                                    std::path::PathBuf::from(v896);
                                                                {
                                                                    let x_34: bool =
                                                                        if v898.clone().exists() {
                                                                            v898.is_file()
                                                                        } else {
                                                                            false
                                                                        };
                                                                    _v892.set(Some(x_34))
                                                                }
                                                                LrcPtr::new(Documents::UH2::UH2_1(if if getValue(_v892.get().clone())
                                                                                                                                      ==
                                                                                                                                      false
                                                                                                                                  {
                                                                                                                                   let _v914:
                                                                                                                                           MutCell<Option<bool>> =
                                                                                                                                       MutCell::new(None::<bool>);
                                                                                                                                   let v916:
                                                                                                                                           &str =
                                                                                                                                       &*v890.clone();
                                                                                                                                   let v918:
                                                                                                                                           std::string::String =
                                                                                                                                       String::from(v916);
                                                                                                                                   let v920:
                                                                                                                                           std::path::PathBuf =
                                                                                                                                       std::path::PathBuf::from(v918);
                                                                                                                                   {
                                                                                                                                       let x_35:
                                                                                                                                               bool =
                                                                                                                                           if v920.clone().exists()
                                                                                                                                              {
                                                                                                                                               v920.is_file()
                                                                                                                                           } else {
                                                                                                                                               false
                                                                                                                                           };
                                                                                                                                       _v914.set(Some(x_35))
                                                                                                                                   }
                                                                                                                                   if getValue(_v914.get().clone())
                                                                                                                                      {
                                                                                                                                       Documents::method3(Documents::US0::US0_2,
                                                                                                                                                          Func0::new(move
                                                                                                                                                                         ||
                                                                                                                                                                         Documents::closure65((),
                                                                                                                                                                                              ())),
                                                                                                                                                          Func0::new({
                                                                                                                                                                         let v890
                                                                                                                                                                             =
                                                                                                                                                                             v890.clone();
                                                                                                                                                                         let v891
                                                                                                                                                                             =
                                                                                                                                                                             v891.clone();
                                                                                                                                                                         move
                                                                                                                                                                             ||
                                                                                                                                                                             Documents::closure66(v890.clone(),
                                                                                                                                                                                                  v891.clone(),
                                                                                                                                                                                                  ())
                                                                                                                                                                     }));
                                                                                                                                       {
                                                                                                                                           let _v938:
                                                                                                                                                   MutCell<Option<()>> =
                                                                                                                                               MutCell::new(None::<()>);
                                                                                                                                           let v939:
                                                                                                                                                   string =
                                                                                                                                               Documents::method53(v891.clone());
                                                                                                                                           let v941:
                                                                                                                                                   Result<u64,
                                                                                                                                                          std::io::Error> =
                                                                                                                                               std::fs::copy(&*v890.clone(), &*v939);
                                                                                                                                           let v943:
                                                                                                                                                   u64 =
                                                                                                                                               v941.unwrap();
                                                                                                                                           _v938.set(Some(()));
                                                                                                                                           getValue(_v938.get().clone());
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
                                                                                                                                                                  v252.clone(),
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
                                                                                                                                                                                                         |v_14:
                                                                                                                                                                                                              string|
                                                                                                                                                                                                         Documents::closure54(v4.clone(),
                                                                                                                                                                                                                              v3.clone(),
                                                                                                                                                                                                                              v1_1.clone(),
                                                                                                                                                                                                                              v0_1.clone(),
                                                                                                                                                                                                                              v_14)
                                                                                                                                                                                                 }))(b0)(b1)
                                                                                                                                                                             }),
                                                                                                                                                                  LrcPtr::new(Documents::UH3::UH3_0)))
                                                                                                                            } else {
                                                                                                                                LrcPtr::new(Documents::UH3::UH3_0)
                                                                                                                            },
                                                                                                                            LrcPtr::new(Documents::UH2::UH2_1(v889,
                                                                                                                                                              LrcPtr::new(Documents::UH2::UH2_0)))))
                                                            }
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    },
                                    empty::<LrcPtr<Documents::UH3>>(),
                                ),
                            );
                            let v960: Vec<LrcPtr<Documents::UH3>> = v958.to_vec();
                            let v963: Vec<Option<Result<string, LrcPtr<(string, string)>>>> =
                                new_empty::<Option<Result<string, LrcPtr<(string, string)>>>>()
                                    .to_vec();
                            let v965: Array<LrcPtr<Documents::UH3>> =
                                fable_library_rust::NativeArray_::array_from(v960);
                            let v966: i32 = count(v965.clone());
                            let v967: LrcPtr<Documents::Mut8> = LrcPtr::new(Documents::Mut8 {
                                l0: MutCell::new(0_i32),
                                l1: MutCell::new(v963),
                            });
                            while Documents::method62(v966, v967.clone()) {
                                let v969: i32 = v967.l0.get().clone();
                                let v970: Vec<Option<Result<string, LrcPtr<(string, string)>>>> =
                                    v967.l1.get().clone();
                                let v975 = toArray_1(Documents::method63(
                                    v965[v969].clone(),
                                    empty::<(
                                        string,
                                        string,
                                        Func1<string, Func1<string, Documents::US18>>,
                                    )>(),
                                ));
                                let v977 = v975.to_vec();
                                let v979 = rayon::iter::IntoParallelIterator::into_par_iter(v977);
                                let v982 = rayon::iter::ParallelIterator::map(v979, |x| {
                                    Func1::new(
                                        move |arg10_0040_16: (
                                            string,
                                            string,
                                            Func1<string, Func1<string, Documents::US18>>,
                                        )| {
                                            Documents::closure67((), arg10_0040_16)
                                        },
                                    )(x)
                                });
                                let v985: Vec<Option<Result<string, LrcPtr<(string, string)>>>> =
                                    Documents::method64(rayon::iter::ParallelIterator::collect(
                                        v982,
                                    ));
                                let v986: Vec<Option<Result<string, LrcPtr<(string, string)>>>> =
                                    Documents::method65(v970);
                                let v988: bool = true;
                                let mut v986 = v986;
                                let v990: bool = true;
                                v986.extend(v985);
                                let v992: Vec<Option<Result<string, LrcPtr<(string, string)>>>> =
                                    v986;
                                let v993: i32 = v969 + 1_i32;
                                v967.l0.set(v993);
                                v967.l1.set(v992);
                                ()
                            }
                            Ok::<
                                LrcPtr<(
                                    string,
                                    Vec<Option<Result<string, LrcPtr<(string, string)>>>>,
                                )>,
                                std::string::String,
                            >(LrcPtr::new((
                                v238.clone(),
                                v967.l1.get().clone(),
                            )))
                        }
                    }
                }
            }
        }
        pub fn closure68(unitVar: (), unitVar_1: ()) -> string {
            string("documents.run")
        }
        pub fn closure69(
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
        pub fn method66(
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
        pub fn method10(
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
            let v9: string = Documents::method11(
                Documents::method14(
                    Documents::method11(string("polyglot"), string(".paket")),
                    string("C:\\home\\git\\polyglot\\target\\polyglot\\builder\\documents"),
                ),
                string("polyglot"),
            );
            let _v10: MutCell<Option<string>> = MutCell::new(None::<string>);
            let v11: string = Documents::method17(v3);
            let v13: &str = &*v11.clone();
            let v15: std::string::String = String::from(v13);
            let v17: std::path::PathBuf = std::path::PathBuf::from(v15);
            {
                let x_6: string = if v17.exists() == false {
                    let _v21: MutCell<Option<string>> = MutCell::new(None::<string>);
                    let v23: Result<std::path::PathBuf, std::io::Error> = std::env::current_dir();
                    let v25: std::path::PathBuf = v23.unwrap();
                    let v27: std::path::Display = v25.display();
                    let _v28: MutCell<Option<std::string::String>> =
                        MutCell::new(None::<std::string::String>);
                    {
                        let x: std::string::String = format!("{}", v27);
                        _v28.set(Some(x))
                    }
                    {
                        let v38: std::string::String = getValue(_v28.get().clone());
                        {
                            let x_1: string = fable_library_rust::String_::fromString(v38);
                            _v21.set(Some(x_1))
                        }
                        {
                            let v47: string = getValue(_v21.get().clone());
                            let _v49: MutCell<Option<string>> = MutCell::new(None::<string>);
                            let v50: string =
                                Documents::method18(Documents::method11(v47.clone(), v11.clone()));
                            let v51: string = Documents::method19();
                            let _v52: MutCell<Option<Result<regex::Regex, regex::Error>>> =
                                MutCell::new(None::<Result<regex::Regex, regex::Error>>);
                            let v53: string = Documents::method20();
                            {
                                let x_2: Result<regex::Regex, regex::Error> =
                                    regex::Regex::new(&v53);
                                _v52.set(Some(x_2))
                            }
                            {
                                let v61: Result<regex::Regex, regex::Error> =
                                    getValue(_v52.get().clone());
                                let v63: regex::Regex = v61.unwrap();
                                let v65: std::borrow::Cow<str> = v63.replace_all(&v50, &*v51);
                                let v67: std::string::String = String::from(v65);
                                {
                                    let x_3: string = fable_library_rust::String_::fromString(v67);
                                    _v49.set(Some(x_3))
                                }
                                {
                                    let v77: string = getValue(_v49.get().clone());
                                    let v82: Array<string> = split(
                                        replace(
                                            sprintf!(
                                                "{}{}",
                                                toLower(ofChar(getCharAt(v77.clone(), 0_i32))),
                                                getSlice(v77, Some(1_i32), None::<i32>)
                                            ),
                                            string("\\"),
                                            string("/"),
                                        ),
                                        string("/"),
                                        -1_i32,
                                        0_i32,
                                    );
                                    let v84: i32 = count(v82.clone());
                                    let v85: LrcPtr<Documents::Mut4> =
                                        LrcPtr::new(Documents::Mut4 {
                                            l0: MutCell::new(0_i32),
                                            l1: MutCell::new(0_i32),
                                            l2: MutCell::new(new_empty::<string>()),
                                        });
                                    while Documents::method22(v84, v85.clone()) {
                                        let v87: i32 = v85.l0.get().clone();
                                        let v90: i32 = v87.wrapping_neg() + v84 - 1_i32;
                                        let matchValue: i32 = v85.l1.get().clone();
                                        let v92: Array<string> = v85.l2.get().clone();
                                        let v91: i32 = matchValue;
                                        let v93: string = v82[v90].clone();
                                        let patternInput_1: (i32, Array<string>) = if string("..")
                                            == v93.clone()
                                        {
                                            (v91 + 1_i32, v92.clone())
                                        } else {
                                            if string(".") == v93.clone() {
                                                (v91, v92.clone())
                                            } else {
                                                if 0_i32 == v91 {
                                                    if endsWith(v93.clone(), string(":"), false) {
                                                        let v101: Array<string> =
                                                            new_array(&[sprintf!(
                                                                "{}:",
                                                                getCharAt(v47.clone(), 0_i32)
                                                            )]);
                                                        let v102: i32 = count(v101.clone());
                                                        let v104: i32 = v102 + count(v92.clone());
                                                        let v105: Array<string> =
                                                            new_init(&string(""), v104);
                                                        let v106: LrcPtr<Documents::Mut5> =
                                                            LrcPtr::new(Documents::Mut5 {
                                                                l0: MutCell::new(0_i32),
                                                            });
                                                        while Documents::method23(
                                                            v104,
                                                            v106.clone(),
                                                        ) {
                                                            let v108: i32 = v106.l0.get().clone();
                                                            let v113: string = if v108 < v102 {
                                                                v101[v108].clone()
                                                            } else {
                                                                let v111: i32 = v108 - v102;
                                                                v92[v111].clone()
                                                            };
                                                            v105.get_mut()[v108 as usize] = v113;
                                                            {
                                                                let v114: i32 = v108 + 1_i32;
                                                                v106.l0.set(v114);
                                                                ()
                                                            }
                                                        }
                                                        (0_i32, v105.clone())
                                                    } else {
                                                        let v115: Array<string> = new_array(&[v93]);
                                                        let v116: i32 = count(v115.clone());
                                                        let v118: i32 = v116 + count(v92.clone());
                                                        let v119: Array<string> =
                                                            new_init(&string(""), v118);
                                                        let v120: LrcPtr<Documents::Mut5> =
                                                            LrcPtr::new(Documents::Mut5 {
                                                                l0: MutCell::new(0_i32),
                                                            });
                                                        while Documents::method23(
                                                            v118,
                                                            v120.clone(),
                                                        ) {
                                                            let v122: i32 = v120.l0.get().clone();
                                                            let v127: string = if v122 < v116 {
                                                                v115[v122].clone()
                                                            } else {
                                                                let v125: i32 = v122 - v116;
                                                                v92[v125].clone()
                                                            };
                                                            v119.get_mut()[v122 as usize] = v127;
                                                            {
                                                                let v128: i32 = v122 + 1_i32;
                                                                v120.l0.set(v128);
                                                                ()
                                                            }
                                                        }
                                                        (0_i32, v119.clone())
                                                    }
                                                } else {
                                                    (v91 - 1_i32, v92.clone())
                                                }
                                            }
                                        };
                                        let v138: i32 = v87 + 1_i32;
                                        v85.l0.set(v138);
                                        v85.l1.set(patternInput_1.0.clone());
                                        v85.l2.set(patternInput_1.1.clone());
                                        ()
                                    }
                                    {
                                        let matchValue_2: i32 = v85.l1.get().clone();
                                        let v140: Array<string> = v85.l2.get().clone();
                                        let v141: LrcPtr<dyn IEnumerable_1<string>> =
                                            delay(Func0::new({
                                                let v140 = v140.clone();
                                                move || {
                                                    map(
                                                        Func1::new({
                                                            let v140 = v140.clone();
                                                            move |i: i32| v140[i].clone()
                                                        }),
                                                        rangeNumeric(
                                                            0_i32,
                                                            1_i32,
                                                            count(v140.clone()) - 1_i32,
                                                        ),
                                                    )
                                                }
                                            }));
                                        let _v142: MutCell<Option<char>> =
                                            MutCell::new(None::<char>);
                                        {
                                            let x_4: char = std::path::MAIN_SEPARATOR;
                                            _v142.set(Some(x_4))
                                        }
                                        join(
                                            Documents::method24(ofChar(getValue(
                                                _v142.get().clone(),
                                            ))),
                                            toArray(v141),
                                        )
                                    }
                                }
                            }
                        }
                    }
                } else {
                    let v158: Result<std::path::PathBuf, std::io::Error> =
                        std::fs::canonicalize(&*v11);
                    let v160: std::path::PathBuf = v158.unwrap();
                    let v162: std::path::Display = v160.display();
                    let _v163: MutCell<Option<std::string::String>> =
                        MutCell::new(None::<std::string::String>);
                    {
                        let x_5: std::string::String = format!("{}", v162);
                        _v163.set(Some(x_5))
                    }
                    {
                        let v173: std::string::String = getValue(_v163.get().clone());
                        fable_library_rust::String_::fromString(v173)
                    }
                };
                _v10.set(Some(x_6))
            }
            {
                let v184: string = getValue(_v10.get().clone());
                let _v185: MutCell<Option<string>> = MutCell::new(None::<string>);
                let v186: string = Documents::method17(v2);
                let v188: &str = &*v186.clone();
                let v190: std::string::String = String::from(v188);
                let v192: std::path::PathBuf = std::path::PathBuf::from(v190);
                {
                    let x_13: string = if v192.exists() == false {
                        let _v196: MutCell<Option<string>> = MutCell::new(None::<string>);
                        let v198: Result<std::path::PathBuf, std::io::Error> =
                            std::env::current_dir();
                        let v200: std::path::PathBuf = v198.unwrap();
                        let v202: std::path::Display = v200.display();
                        let _v203: MutCell<Option<std::string::String>> =
                            MutCell::new(None::<std::string::String>);
                        {
                            let x_7: std::string::String = format!("{}", v202);
                            _v203.set(Some(x_7))
                        }
                        {
                            let v213: std::string::String = getValue(_v203.get().clone());
                            {
                                let x_8: string = fable_library_rust::String_::fromString(v213);
                                _v196.set(Some(x_8))
                            }
                            {
                                let v222: string = getValue(_v196.get().clone());
                                let _v224: MutCell<Option<string>> = MutCell::new(None::<string>);
                                let v225: string = Documents::method18(Documents::method11(
                                    v222.clone(),
                                    v186.clone(),
                                ));
                                let v226: string = Documents::method19();
                                let _v227: MutCell<Option<Result<regex::Regex, regex::Error>>> =
                                    MutCell::new(None::<Result<regex::Regex, regex::Error>>);
                                let v228: string = Documents::method20();
                                {
                                    let x_9: Result<regex::Regex, regex::Error> =
                                        regex::Regex::new(&v228);
                                    _v227.set(Some(x_9))
                                }
                                {
                                    let v236: Result<regex::Regex, regex::Error> =
                                        getValue(_v227.get().clone());
                                    let v238: regex::Regex = v236.unwrap();
                                    let v240: std::borrow::Cow<str> =
                                        v238.replace_all(&v225, &*v226);
                                    let v242: std::string::String = String::from(v240);
                                    {
                                        let x_10: string =
                                            fable_library_rust::String_::fromString(v242);
                                        _v224.set(Some(x_10))
                                    }
                                    {
                                        let v252: string = getValue(_v224.get().clone());
                                        let v257: Array<string> = split(
                                            replace(
                                                sprintf!(
                                                    "{}{}",
                                                    toLower(ofChar(getCharAt(v252.clone(), 0_i32))),
                                                    getSlice(v252, Some(1_i32), None::<i32>)
                                                ),
                                                string("\\"),
                                                string("/"),
                                            ),
                                            string("/"),
                                            -1_i32,
                                            0_i32,
                                        );
                                        let v259: i32 = count(v257.clone());
                                        let v260: LrcPtr<Documents::Mut4> =
                                            LrcPtr::new(Documents::Mut4 {
                                                l0: MutCell::new(0_i32),
                                                l1: MutCell::new(0_i32),
                                                l2: MutCell::new(new_empty::<string>()),
                                            });
                                        while Documents::method22(v259, v260.clone()) {
                                            let v262: i32 = v260.l0.get().clone();
                                            let v265: i32 = v262.wrapping_neg() + v259 - 1_i32;
                                            let matchValue_4: i32 = v260.l1.get().clone();
                                            let v267: Array<string> = v260.l2.get().clone();
                                            let v266: i32 = matchValue_4;
                                            let v268: string = v257[v265].clone();
                                            let patternInput_4: (i32, Array<string>) =
                                                if string("..") == v268.clone() {
                                                    (v266 + 1_i32, v267.clone())
                                                } else {
                                                    if string(".") == v268.clone() {
                                                        (v266, v267.clone())
                                                    } else {
                                                        if 0_i32 == v266 {
                                                            if endsWith(
                                                                v268.clone(),
                                                                string(":"),
                                                                false,
                                                            ) {
                                                                let v276: Array<string> =
                                                                    new_array(&[sprintf!(
                                                                        "{}:",
                                                                        getCharAt(
                                                                            v222.clone(),
                                                                            0_i32
                                                                        )
                                                                    )]);
                                                                let v277: i32 = count(v276.clone());
                                                                let v279: i32 =
                                                                    v277 + count(v267.clone());
                                                                let v280: Array<string> =
                                                                    new_init(&string(""), v279);
                                                                let v281: LrcPtr<Documents::Mut5> =
                                                                    LrcPtr::new(Documents::Mut5 {
                                                                        l0: MutCell::new(0_i32),
                                                                    });
                                                                while Documents::method23(
                                                                    v279,
                                                                    v281.clone(),
                                                                ) {
                                                                    let v283: i32 =
                                                                        v281.l0.get().clone();
                                                                    let v288: string = if v283
                                                                        < v277
                                                                    {
                                                                        v276[v283].clone()
                                                                    } else {
                                                                        let v286: i32 = v283 - v277;
                                                                        v267[v286].clone()
                                                                    };
                                                                    v280.get_mut()[v283 as usize] =
                                                                        v288;
                                                                    {
                                                                        let v289: i32 =
                                                                            v283 + 1_i32;
                                                                        v281.l0.set(v289);
                                                                        ()
                                                                    }
                                                                }
                                                                (0_i32, v280.clone())
                                                            } else {
                                                                let v290: Array<string> =
                                                                    new_array(&[v268]);
                                                                let v291: i32 = count(v290.clone());
                                                                let v293: i32 =
                                                                    v291 + count(v267.clone());
                                                                let v294: Array<string> =
                                                                    new_init(&string(""), v293);
                                                                let v295: LrcPtr<Documents::Mut5> =
                                                                    LrcPtr::new(Documents::Mut5 {
                                                                        l0: MutCell::new(0_i32),
                                                                    });
                                                                while Documents::method23(
                                                                    v293,
                                                                    v295.clone(),
                                                                ) {
                                                                    let v297: i32 =
                                                                        v295.l0.get().clone();
                                                                    let v302: string = if v297
                                                                        < v291
                                                                    {
                                                                        v290[v297].clone()
                                                                    } else {
                                                                        let v300: i32 = v297 - v291;
                                                                        v267[v300].clone()
                                                                    };
                                                                    v294.get_mut()[v297 as usize] =
                                                                        v302;
                                                                    {
                                                                        let v303: i32 =
                                                                            v297 + 1_i32;
                                                                        v295.l0.set(v303);
                                                                        ()
                                                                    }
                                                                }
                                                                (0_i32, v294.clone())
                                                            }
                                                        } else {
                                                            (v266 - 1_i32, v267.clone())
                                                        }
                                                    }
                                                };
                                            let v313: i32 = v262 + 1_i32;
                                            v260.l0.set(v313);
                                            v260.l1.set(patternInput_4.0.clone());
                                            v260.l2.set(patternInput_4.1.clone());
                                            ()
                                        }
                                        {
                                            let matchValue_6: i32 = v260.l1.get().clone();
                                            let v315: Array<string> = v260.l2.get().clone();
                                            let v316: LrcPtr<dyn IEnumerable_1<string>> =
                                                delay(Func0::new({
                                                    let v315 = v315.clone();
                                                    move || {
                                                        map(
                                                            Func1::new({
                                                                let v315 = v315.clone();
                                                                move |i_1: i32| v315[i_1].clone()
                                                            }),
                                                            rangeNumeric(
                                                                0_i32,
                                                                1_i32,
                                                                count(v315.clone()) - 1_i32,
                                                            ),
                                                        )
                                                    }
                                                }));
                                            let _v317: MutCell<Option<char>> =
                                                MutCell::new(None::<char>);
                                            {
                                                let x_11: char = std::path::MAIN_SEPARATOR;
                                                _v317.set(Some(x_11))
                                            }
                                            join(
                                                Documents::method24(ofChar(getValue(
                                                    _v317.get().clone(),
                                                ))),
                                                toArray(v316),
                                            )
                                        }
                                    }
                                }
                            }
                        }
                    } else {
                        let v333: Result<std::path::PathBuf, std::io::Error> =
                            std::fs::canonicalize(&*v186);
                        let v335: std::path::PathBuf = v333.unwrap();
                        let v337: std::path::Display = v335.display();
                        let _v338: MutCell<Option<std::string::String>> =
                            MutCell::new(None::<std::string::String>);
                        {
                            let x_12: std::string::String = format!("{}", v337);
                            _v338.set(Some(x_12))
                        }
                        {
                            let v348: std::string::String = getValue(_v338.get().clone());
                            fable_library_rust::String_::fromString(v348)
                        }
                    };
                    _v185.set(Some(x_13))
                }
                {
                    let v359: string = getValue(_v185.get().clone());
                    let _v360: MutCell<Option<string>> = MutCell::new(None::<string>);
                    let v361: string = Documents::method17(v1_1);
                    let v363: &str = &*v361.clone();
                    let v365: std::string::String = String::from(v363);
                    let v367: std::path::PathBuf = std::path::PathBuf::from(v365);
                    {
                        let x_20: string = if v367.exists() == false {
                            let _v371: MutCell<Option<string>> = MutCell::new(None::<string>);
                            let v373: Result<std::path::PathBuf, std::io::Error> =
                                std::env::current_dir();
                            let v375: std::path::PathBuf = v373.unwrap();
                            let v377: std::path::Display = v375.display();
                            let _v378: MutCell<Option<std::string::String>> =
                                MutCell::new(None::<std::string::String>);
                            {
                                let x_14: std::string::String = format!("{}", v377);
                                _v378.set(Some(x_14))
                            }
                            {
                                let v388: std::string::String = getValue(_v378.get().clone());
                                {
                                    let x_15: string =
                                        fable_library_rust::String_::fromString(v388);
                                    _v371.set(Some(x_15))
                                }
                                {
                                    let v397: string = getValue(_v371.get().clone());
                                    let _v399: MutCell<Option<string>> =
                                        MutCell::new(None::<string>);
                                    let v400: string = Documents::method18(Documents::method11(
                                        v397.clone(),
                                        v361.clone(),
                                    ));
                                    let v401: string = Documents::method19();
                                    let _v402: MutCell<Option<Result<regex::Regex, regex::Error>>> =
                                        MutCell::new(None::<Result<regex::Regex, regex::Error>>);
                                    let v403: string = Documents::method20();
                                    {
                                        let x_16: Result<regex::Regex, regex::Error> =
                                            regex::Regex::new(&v403);
                                        _v402.set(Some(x_16))
                                    }
                                    {
                                        let v411: Result<regex::Regex, regex::Error> =
                                            getValue(_v402.get().clone());
                                        let v413: regex::Regex = v411.unwrap();
                                        let v415: std::borrow::Cow<str> =
                                            v413.replace_all(&v400, &*v401);
                                        let v417: std::string::String = String::from(v415);
                                        {
                                            let x_17: string =
                                                fable_library_rust::String_::fromString(v417);
                                            _v399.set(Some(x_17))
                                        }
                                        {
                                            let v427: string = getValue(_v399.get().clone());
                                            let v432: Array<string> = split(
                                                replace(
                                                    sprintf!(
                                                        "{}{}",
                                                        toLower(ofChar(getCharAt(
                                                            v427.clone(),
                                                            0_i32
                                                        ))),
                                                        getSlice(v427, Some(1_i32), None::<i32>)
                                                    ),
                                                    string("\\"),
                                                    string("/"),
                                                ),
                                                string("/"),
                                                -1_i32,
                                                0_i32,
                                            );
                                            let v434: i32 = count(v432.clone());
                                            let v435: LrcPtr<Documents::Mut4> =
                                                LrcPtr::new(Documents::Mut4 {
                                                    l0: MutCell::new(0_i32),
                                                    l1: MutCell::new(0_i32),
                                                    l2: MutCell::new(new_empty::<string>()),
                                                });
                                            while Documents::method22(v434, v435.clone()) {
                                                let v437: i32 = v435.l0.get().clone();
                                                let v440: i32 = v437.wrapping_neg() + v434 - 1_i32;
                                                let matchValue_8: i32 = v435.l1.get().clone();
                                                let v442: Array<string> = v435.l2.get().clone();
                                                let v441: i32 = matchValue_8;
                                                let v443: string = v432[v440].clone();
                                                let patternInput_7: (i32, Array<string>) =
                                                    if string("..") == v443.clone() {
                                                        (v441 + 1_i32, v442.clone())
                                                    } else {
                                                        if string(".") == v443.clone() {
                                                            (v441, v442.clone())
                                                        } else {
                                                            if 0_i32 == v441 {
                                                                if endsWith(
                                                                    v443.clone(),
                                                                    string(":"),
                                                                    false,
                                                                ) {
                                                                    let v451: Array<string> =
                                                                        new_array(&[sprintf!(
                                                                            "{}:",
                                                                            getCharAt(
                                                                                v397.clone(),
                                                                                0_i32
                                                                            )
                                                                        )]);
                                                                    let v452: i32 =
                                                                        count(v451.clone());
                                                                    let v454: i32 =
                                                                        v452 + count(v442.clone());
                                                                    let v455: Array<string> =
                                                                        new_init(&string(""), v454);
                                                                    let v456: LrcPtr<
                                                                        Documents::Mut5,
                                                                    > = LrcPtr::new(
                                                                        Documents::Mut5 {
                                                                            l0: MutCell::new(0_i32),
                                                                        },
                                                                    );
                                                                    while Documents::method23(
                                                                        v454,
                                                                        v456.clone(),
                                                                    ) {
                                                                        let v458: i32 =
                                                                            v456.l0.get().clone();
                                                                        let v463: string =
                                                                            if v458 < v452 {
                                                                                v451[v458].clone()
                                                                            } else {
                                                                                let v461: i32 =
                                                                                    v458 - v452;
                                                                                v442[v461].clone()
                                                                            };
                                                                        v455.get_mut()
                                                                            [v458 as usize] = v463;
                                                                        {
                                                                            let v464: i32 =
                                                                                v458 + 1_i32;
                                                                            v456.l0.set(v464);
                                                                            ()
                                                                        }
                                                                    }
                                                                    (0_i32, v455.clone())
                                                                } else {
                                                                    let v465: Array<string> =
                                                                        new_array(&[v443]);
                                                                    let v466: i32 =
                                                                        count(v465.clone());
                                                                    let v468: i32 =
                                                                        v466 + count(v442.clone());
                                                                    let v469: Array<string> =
                                                                        new_init(&string(""), v468);
                                                                    let v470: LrcPtr<
                                                                        Documents::Mut5,
                                                                    > = LrcPtr::new(
                                                                        Documents::Mut5 {
                                                                            l0: MutCell::new(0_i32),
                                                                        },
                                                                    );
                                                                    while Documents::method23(
                                                                        v468,
                                                                        v470.clone(),
                                                                    ) {
                                                                        let v472: i32 =
                                                                            v470.l0.get().clone();
                                                                        let v477: string =
                                                                            if v472 < v466 {
                                                                                v465[v472].clone()
                                                                            } else {
                                                                                let v475: i32 =
                                                                                    v472 - v466;
                                                                                v442[v475].clone()
                                                                            };
                                                                        v469.get_mut()
                                                                            [v472 as usize] = v477;
                                                                        {
                                                                            let v478: i32 =
                                                                                v472 + 1_i32;
                                                                            v470.l0.set(v478);
                                                                            ()
                                                                        }
                                                                    }
                                                                    (0_i32, v469.clone())
                                                                }
                                                            } else {
                                                                (v441 - 1_i32, v442.clone())
                                                            }
                                                        }
                                                    };
                                                let v488: i32 = v437 + 1_i32;
                                                v435.l0.set(v488);
                                                v435.l1.set(patternInput_7.0.clone());
                                                v435.l2.set(patternInput_7.1.clone());
                                                ()
                                            }
                                            {
                                                let matchValue_10: i32 = v435.l1.get().clone();
                                                let v490: Array<string> = v435.l2.get().clone();
                                                let v491: LrcPtr<dyn IEnumerable_1<string>> =
                                                    delay(Func0::new({
                                                        let v490 = v490.clone();
                                                        move || {
                                                            map(
                                                                Func1::new({
                                                                    let v490 = v490.clone();
                                                                    move |i_2: i32| {
                                                                        v490[i_2].clone()
                                                                    }
                                                                }),
                                                                rangeNumeric(
                                                                    0_i32,
                                                                    1_i32,
                                                                    count(v490.clone()) - 1_i32,
                                                                ),
                                                            )
                                                        }
                                                    }));
                                                let _v492: MutCell<Option<char>> =
                                                    MutCell::new(None::<char>);
                                                {
                                                    let x_18: char = std::path::MAIN_SEPARATOR;
                                                    _v492.set(Some(x_18))
                                                }
                                                join(
                                                    Documents::method24(ofChar(getValue(
                                                        _v492.get().clone(),
                                                    ))),
                                                    toArray(v491),
                                                )
                                            }
                                        }
                                    }
                                }
                            }
                        } else {
                            let v508: Result<std::path::PathBuf, std::io::Error> =
                                std::fs::canonicalize(&*v361);
                            let v510: std::path::PathBuf = v508.unwrap();
                            let v512: std::path::Display = v510.display();
                            let _v513: MutCell<Option<std::string::String>> =
                                MutCell::new(None::<std::string::String>);
                            {
                                let x_19: std::string::String = format!("{}", v512);
                                _v513.set(Some(x_19))
                            }
                            {
                                let v523: std::string::String = getValue(_v513.get().clone());
                                fable_library_rust::String_::fromString(v523)
                            }
                        };
                        _v360.set(Some(x_20))
                    }
                    {
                        let v534: string = getValue(_v360.get().clone());
                        Documents::method3(
                            Documents::US0::US0_1,
                            Func0::new(move || Documents::closure9((), ())),
                            Func0::new({
                                let v0_1 = v0_1.clone();
                                let v184 = v184.clone();
                                let v359 = v359.clone();
                                let v534 = v534.clone();
                                move || {
                                    Documents::closure10(
                                        v0_1.clone(),
                                        v184.clone(),
                                        v359.clone(),
                                        v534.clone(),
                                        (),
                                    )
                                }
                            }),
                        );
                        let __result = Box::pin(async move {
                            //;
                            {
                                let v540: async_walkdir::WalkDir =
                                    async_walkdir::WalkDir::new(&*v359.clone());
                                let v543: async_walkdir::WalkDir =
                                    async_walkdir::WalkDir::filter(v540, |x| {
                                        Func1::new(move |v: async_walkdir::DirEntry| {
                                            Documents::closure11((), v)
                                        })(x)
                                    });
                                let v544 = Documents::method33();
                                let v545: string =
                                string("futures_lite::stream::StreamExt::collect(futures_lite::stream::StreamExt::filter_map(v543, |x| v544(x))).await");
                                let v546: Vec<string> = futures_lite::stream::StreamExt::collect(
                                    futures_lite::stream::StreamExt::filter_map(v543, |x| v544(x)),
                                )
                                .await;
                                Documents::method3(
                                    Documents::US0::US0_1,
                                    Func0::new(move || Documents::closure20((), ())),
                                    Func0::new({
                                        let v546 = v546.clone();
                                        move || Documents::closure21(v546.clone(), ())
                                    }),
                                );
                                {
                                    let v551: rayon::vec::IntoIter<string> =
                                        rayon::iter::IntoParallelIterator::into_par_iter(v546);
                                    let v554: rayon::iter::Map<rayon::vec::IntoIter<string>, _> =
                                        rayon::iter::ParallelIterator::map(v551, |x| {
                                            Func1::new({
                                                let v0_1 = v0_1.clone();
                                                let v184 = v184.clone();
                                                let v359 = v359.clone();
                                                let v534 = v534.clone();
                                                let v9 = v9.clone();
                                                move |v_1: string| {
                                                    Documents::closure22(
                                                        v0_1.clone(),
                                                        v9.clone(),
                                                        v184.clone(),
                                                        v359.clone(),
                                                        v534.clone(),
                                                        v_1,
                                                    )
                                                }
                                            })(x)
                                        });
                                    let v556: Vec<
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
                                    > = rayon::iter::ParallelIterator::collect(v554);
                                    Documents::method3(
                                        Documents::US0::US0_2,
                                        Func0::new(move || Documents::closure68((), ())),
                                        Func0::new({
                                            let v556 = v556.clone();
                                            move || Documents::closure69(v556.clone(), ())
                                        }),
                                    );
                                    {
                                        let v561: Result<
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
                                        > = Documents::method66(Ok::<
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
                                        >(
                                            v556.clone()
                                        ));
                                        v561
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
                }
            }
        }
        pub fn closure1(unitVar: (), v0_1: Array<string>) -> i32 {
            if Documents::State::trace_state().get().clone().is_none() {
                Documents::State::trace_state()
                    .set(Some(Documents::closure2((), Documents::US0::US0_2)));
            }
            Documents::method3(
                Documents::US0::US0_2,
                Func0::new(move || Documents::closure4((), ())),
                Func0::new({
                    let v0_1 = v0_1.clone();
                    move || Documents::closure5(v0_1.clone(), ())
                }),
            );
            {
                let v6: clap::Command = Documents::method0();
                let v8: clap::ArgMatches = clap::Command::get_matches(v6);
                let v9: string = Documents::method6();
                let v11: &str = &*v9;
                let v13: Option<std::string::String> =
                    clap::ArgMatches::get_one(&v8.clone(), v11).cloned();
                let _v14: LrcPtr<MutCell<Option<Documents::US2>>> = refCell(None::<Documents::US2>);
                {
                    let x_2: Option<Documents::US2> = match &v13 {
                        None => None::<Documents::US2>,
                        Some(v13_0_0) => {
                            let x: std::string::String = v13_0_0.clone();
                            Some((Func0::new({
                                let x = x.clone();
                                move || Documents::US2::US2_0(x.clone())
                            }))())
                        }
                    };
                    _v14.set(x_2)
                }
                {
                    let v19: Documents::US2 =
                        defaultValue(Documents::US2::US2_1, _v14.get().clone());
                    let v23: std::string::String = match &v19 {
                        Documents::US2::US2_0(v19_0_0) => match &v19 {
                            Documents::US2::US2_0(x) => x.clone(),
                            _ => unreachable!(),
                        },
                        _ => panic!("{}", string("Option does not have a value."),),
                    };
                    let v25: string = fable_library_rust::String_::fromString(v23);
                    let v26: string = Documents::method7();
                    let v28: &str = &*v26;
                    let v30: Option<std::string::String> =
                        clap::ArgMatches::get_one(&v8.clone(), v28).cloned();
                    let _v31: LrcPtr<MutCell<Option<Documents::US2>>> =
                        refCell(None::<Documents::US2>);
                    {
                        let x_5: Option<Documents::US2> = match &v30 {
                            None => None::<Documents::US2>,
                            Some(v30_0_0) => {
                                let x_3: std::string::String = v30_0_0.clone();
                                Some((Func0::new({
                                    let x_3 = x_3.clone();
                                    move || Documents::US2::US2_0(x_3.clone())
                                }))())
                            }
                        };
                        _v31.set(x_5)
                    }
                    {
                        let v36: Documents::US2 =
                            defaultValue(Documents::US2::US2_1, _v31.get().clone());
                        let v40: std::string::String = match &v36 {
                            Documents::US2::US2_0(v36_0_0) => match &v36 {
                                Documents::US2::US2_0(x) => x.clone(),
                                _ => unreachable!(),
                            },
                            _ => panic!("{}", string("Option does not have a value."),),
                        };
                        let v42: string = fable_library_rust::String_::fromString(v40);
                        let v43: string = Documents::method8();
                        let v45: &str = &*v43;
                        let v47: Option<std::string::String> =
                            clap::ArgMatches::get_one(&v8.clone(), v45).cloned();
                        let _v48: LrcPtr<MutCell<Option<Documents::US2>>> =
                            refCell(None::<Documents::US2>);
                        {
                            let x_8: Option<Documents::US2> = match &v47 {
                                None => None::<Documents::US2>,
                                Some(v47_0_0) => {
                                    let x_6: std::string::String = v47_0_0.clone();
                                    Some((Func0::new({
                                        let x_6 = x_6.clone();
                                        move || Documents::US2::US2_0(x_6.clone())
                                    }))())
                                }
                            };
                            _v48.set(x_8)
                        }
                        {
                            let v53: Documents::US2 =
                                defaultValue(Documents::US2::US2_1, _v48.get().clone());
                            let v57: std::string::String = match &v53 {
                                Documents::US2::US2_0(v53_0_0) => match &v53 {
                                    Documents::US2::US2_0(x) => x.clone(),
                                    _ => unreachable!(),
                                },
                                _ => panic!("{}", string("Option does not have a value."),),
                            };
                            let v59: string = fable_library_rust::String_::fromString(v57);
                            let v60: string = Documents::method9();
                            let v62: &str = &*v60;
                            let v64: Option<std::string::String> =
                                clap::ArgMatches::get_one(&v8, v62).cloned();
                            let _v65: LrcPtr<MutCell<Option<Documents::US2>>> =
                                refCell(None::<Documents::US2>);
                            {
                                let x_11: Option<Documents::US2> = match &v64 {
                                    None => None::<Documents::US2>,
                                    Some(v64_0_0) => {
                                        let x_9: std::string::String = v64_0_0.clone();
                                        Some((Func0::new({
                                            let x_9 = x_9.clone();
                                            move || Documents::US2::US2_0(x_9.clone())
                                        }))())
                                    }
                                };
                                _v65.set(x_11)
                            }
                            {
                                let v70: Documents::US2 =
                                    defaultValue(Documents::US2::US2_1, _v65.get().clone());
                                let v74: std::string::String = match &v70 {
                                    Documents::US2::US2_0(v70_0_0) => match &v70 {
                                        Documents::US2::US2_0(x) => x.clone(),
                                        _ => unreachable!(),
                                    },
                                    _ => panic!("{}", string("Option does not have a value."),),
                                };
                                let v77: std::pin::Pin<
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
                                > = Documents::method10(
                                    fable_library_rust::String_::fromString(v74),
                                    v59,
                                    v42,
                                    v25,
                                );
                                let v79: Result<
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
                                > = futures_lite::future::block_on(v77);
                                let v81: Vec<
                                    Result<
                                        LrcPtr<(
                                            string,
                                            Vec<Option<Result<string, LrcPtr<(string, string)>>>>,
                                        )>,
                                        std::string::String,
                                    >,
                                > = v79.unwrap();
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
