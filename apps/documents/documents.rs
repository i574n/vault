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
        use fable_library_rust::List_::item;
        use fable_library_rust::List_::length as length_1;
        use fable_library_rust::List_::ofArray;
        use fable_library_rust::List_::toArray as toArray_1;
        use fable_library_rust::List_::List;
        use fable_library_rust::Map_::find;
        use fable_library_rust::Map_::ofSeq;
        use fable_library_rust::NativeArray_::count as count_2;
        use fable_library_rust::NativeArray_::new_array;
        use fable_library_rust::NativeArray_::new_empty;
        use fable_library_rust::NativeArray_::new_init;
        use fable_library_rust::NativeArray_::Array;
        use fable_library_rust::Native_::defaultOf;
        use fable_library_rust::Native_::refCell;
        use fable_library_rust::Native_::unbox;
        use fable_library_rust::Native_::Any;
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
        use fable_library_rust::Seq_::ofArray as ofArray_1;
        use fable_library_rust::Seq_::ofList;
        use fable_library_rust::Seq_::toArray;
        use fable_library_rust::String_::append;
        use fable_library_rust::String_::contains;
        use fable_library_rust::String_::endsWith;
        use fable_library_rust::String_::getCharAt;
        use fable_library_rust::String_::getSlice;
        use fable_library_rust::String_::indexOf;
        use fable_library_rust::String_::join;
        use fable_library_rust::String_::lastIndexOf;
        use fable_library_rust::String_::length;
        use fable_library_rust::String_::ofChar;
        use fable_library_rust::String_::padLeft;
        use fable_library_rust::String_::printfn;
        use fable_library_rust::String_::replace;
        use fable_library_rust::String_::replicate;
        use fable_library_rust::String_::split;
        use fable_library_rust::String_::sprintf;
        use fable_library_rust::String_::string;
        use fable_library_rust::String_::toLower;
        use fable_library_rust::String_::trim;
        use fable_library_rust::String_::trimEndChars;
        use fable_library_rust::String_::trimStartChars;
        use fable_library_rust::TimeSpan_::TimeSpan;
        type ConcurrentStack_1<T> = T;
        use fable_library_rust::System::Text::StringBuilder;
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
        pub trait IOsEnviron {
            fn environ(&self) -> LrcPtr<dyn Any>;
        }
        impl<V: IOsEnviron + Clone + 'static> IOsEnviron for LrcPtr<V> {
            #[inline]
            fn environ(&self) -> LrcPtr<dyn Any> {
                (**self).environ()
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
        #[derive(Clone, Copy, Debug, PartialEq, PartialOrd, Hash, Eq)]
        pub enum US2 {
            US2_0(Documents::US0),
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
        #[derive(Clone, Copy, Debug, PartialEq, PartialOrd, Hash, Eq)]
        pub enum US6 {
            US6_0(Documents::US5),
            US6_1(Documents::US5),
            US6_2(Documents::US5),
            US6_3(Documents::US5),
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
            pub fn get_IsUS6_2(this_: &MutCell<Documents::US6>, unitArg: ()) -> bool {
                if unreachable!() {
                    true
                } else {
                    false
                }
            }
            pub fn get_IsUS6_3(this_: &MutCell<Documents::US6>, unitArg: ()) -> bool {
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
        pub enum US7 {
            US7_0,
            US7_1,
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
        #[derive(Clone, Debug)]
        pub enum US8 {
            US8_0(std::fs::FileType),
            US8_1(std::string::String),
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
        #[derive(Clone, Debug)]
        pub enum US9 {
            US9_0(async_walkdir::DirEntry),
            US9_1(std::string::String),
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
        pub enum US12 {
            US12_0(Array<string>),
            US12_1(string),
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
        #[derive(Clone, Debug)]
        pub enum US13 {
            US13_0(
                LrcPtr<Documents::UH1>,
                string,
                LrcPtr<StringBuilder>,
                i32,
                i32,
            ),
            US13_1(string),
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
            US14_0(char, string, LrcPtr<StringBuilder>, i32, i32),
            US14_1(string),
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
        #[derive(Clone, Copy, Debug, PartialEq, PartialOrd, Hash, Eq)]
        pub enum US15 {
            US15_0(char),
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
            US16_0(string, string, LrcPtr<StringBuilder>, i32, i32),
            US16_1(string),
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
        pub enum UH2 {
            UH2_0,
            UH2_1(
                Func1<(string, LrcPtr<StringBuilder>, i32, i32), Documents::US16>,
                LrcPtr<Documents::UH2>,
            ),
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
        #[derive(Clone, Debug)]
        pub enum US17 {
            US17_0(string, LrcPtr<StringBuilder>, i32, i32),
            US17_1(string),
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
            US18_0(Array<string>),
            US18_1(string),
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
        pub enum US19 {
            US19_0(std::sync::Arc<std::sync::Mutex<Option<std::process::Child>>>),
            US19_1(std::string::String),
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
        pub enum US20 {
            US20_0(
                std::sync::Arc<
                    std::sync::Mutex<
                        std::sync::Arc<std::sync::mpsc::Receiver<std::string::String>>,
                    >,
                >,
            ),
            US20_1,
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
        #[derive(Clone, Debug)]
        pub enum US21 {
            US21_0(std::string::String),
            US21_1(std::string::String),
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
        #[derive(Clone, Debug)]
        pub enum US22 {
            US22_0(Func1<std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>, ()>),
            US22_1,
        }
        impl Documents::US22 {
            pub fn get_IsUS22_0(this_: &MutCell<Documents::US22>, unitArg: ()) -> bool {
                if unreachable!() {
                    true
                } else {
                    false
                }
            }
            pub fn get_IsUS22_1(this_: &MutCell<Documents::US22>, unitArg: ()) -> bool {
                if unreachable!() {
                    true
                } else {
                    false
                }
            }
        }
        impl core::fmt::Display for Documents::US22 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum US23 {
            US23_0(std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>),
            US23_1,
        }
        impl Documents::US23 {
            pub fn get_IsUS23_0(this_: &MutCell<Documents::US23>, unitArg: ()) -> bool {
                if unreachable!() {
                    true
                } else {
                    false
                }
            }
            pub fn get_IsUS23_1(this_: &MutCell<Documents::US23>, unitArg: ()) -> bool {
                if unreachable!() {
                    true
                } else {
                    false
                }
            }
        }
        impl core::fmt::Display for Documents::US23 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum US24 {
            US24_0(std::process::Output),
            US24_1(std::string::String),
        }
        impl Documents::US24 {
            pub fn get_IsUS24_0(this_: &MutCell<Documents::US24>, unitArg: ()) -> bool {
                if unreachable!() {
                    true
                } else {
                    false
                }
            }
            pub fn get_IsUS24_1(this_: &MutCell<Documents::US24>, unitArg: ()) -> bool {
                if unreachable!() {
                    true
                } else {
                    false
                }
            }
        }
        impl core::fmt::Display for Documents::US24 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum US25 {
            US25_0(Func1<(bool, string, i32), Arc<Async<()>>>),
            US25_1,
        }
        impl Documents::US25 {
            pub fn get_IsUS25_0(this_: &MutCell<Documents::US25>, unitArg: ()) -> bool {
                if unreachable!() {
                    true
                } else {
                    false
                }
            }
            pub fn get_IsUS25_1(this_: &MutCell<Documents::US25>, unitArg: ()) -> bool {
                if unreachable!() {
                    true
                } else {
                    false
                }
            }
        }
        impl core::fmt::Display for Documents::US25 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Copy, Debug, PartialEq, PartialOrd, Hash, Eq)]
        pub enum US26 {
            US26_0(CancellationToken),
            US26_1,
        }
        impl Documents::US26 {
            pub fn get_IsUS26_0(this_: &MutCell<Documents::US26>, unitArg: ()) -> bool {
                if unreachable!() {
                    true
                } else {
                    false
                }
            }
            pub fn get_IsUS26_1(this_: &MutCell<Documents::US26>, unitArg: ()) -> bool {
                if unreachable!() {
                    true
                } else {
                    false
                }
            }
        }
        impl core::fmt::Display for Documents::US26 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug, PartialEq, PartialOrd, Hash, Eq)]
        pub enum US27 {
            US27_0(Result<string, LrcPtr<(string, string)>>),
            US27_1,
        }
        impl Documents::US27 {
            pub fn get_IsUS27_0(this_: &MutCell<Documents::US27>, unitArg: ()) -> bool {
                if unreachable!() {
                    true
                } else {
                    false
                }
            }
            pub fn get_IsUS27_1(this_: &MutCell<Documents::US27>, unitArg: ()) -> bool {
                if unreachable!() {
                    true
                } else {
                    false
                }
            }
        }
        impl core::fmt::Display for Documents::US27 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum UH4 {
            UH4_0,
            UH4_1(
                string,
                string,
                Func2<string, string, Documents::US27>,
                LrcPtr<Documents::UH4>,
            ),
        }
        impl Documents::UH4 {
            pub fn get_IsUH4_0(this_: LrcPtr<Documents::UH4>, unitArg: ()) -> bool {
                if let Documents::UH4::UH4_0 = this_.as_ref() {
                    true
                } else {
                    false
                }
            }
            pub fn get_IsUH4_1(this_: LrcPtr<Documents::UH4>, unitArg: ()) -> bool {
                if let Documents::UH4::UH4_1(this__1_0, this__1_1, this__1_2, this__1_3) =
                    this_.as_ref()
                {
                    true
                } else {
                    false
                }
            }
        }
        impl core::fmt::Display for Documents::UH4 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum UH3 {
            UH3_0,
            UH3_1(LrcPtr<Documents::UH4>, LrcPtr<Documents::UH3>),
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
                if let Documents::UH3::UH3_1(this__1_0, this__1_1) = this_.as_ref() {
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
        pub enum US28 {
            US28_0(string),
            US28_1(std::string::String),
        }
        impl Documents::US28 {
            pub fn get_IsUS28_0(this_: &MutCell<Documents::US28>, unitArg: ()) -> bool {
                if unreachable!() {
                    true
                } else {
                    false
                }
            }
            pub fn get_IsUS28_1(this_: &MutCell<Documents::US28>, unitArg: ()) -> bool {
                if unreachable!() {
                    true
                } else {
                    false
                }
            }
        }
        impl core::fmt::Display for Documents::US28 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug, PartialEq, PartialOrd, Hash, Eq)]
        pub enum US29 {
            US29_0(i32, string),
            US29_1(i32, string),
        }
        impl Documents::US29 {
            pub fn get_IsUS29_0(this_: &MutCell<Documents::US29>, unitArg: ()) -> bool {
                if unreachable!() {
                    true
                } else {
                    false
                }
            }
            pub fn get_IsUS29_1(this_: &MutCell<Documents::US29>, unitArg: ()) -> bool {
                if unreachable!() {
                    true
                } else {
                    false
                }
            }
        }
        impl core::fmt::Display for Documents::US29 {
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
        pub fn method1() -> string {
            string("TRACE_LEVEL")
        }
        pub fn method3() -> string {
            string("")
        }
        pub fn method2(v0_1: string) -> string {
            let _v1: MutCell<Option<string>> = MutCell::new(None::<string>);
            let v3: Result<std::string::String, std::env::VarError> = std::env::var(&*v0_1);
            let v5: bool = true;
            let _result = v3.map(|x| {
                //;
                let v7: std::string::String = x;
                let v9: string = fable_library_rust::String_::fromString(v7);
                let v11: bool = true;
                v9
            });
            let v13: Result<string, std::env::VarError> = _result;
            let v14: string = Documents::method3();
            {
                let x: string = v13.unwrap_or(v14);
                _v1.set(Some(x))
            }
            match &_v1.get().clone() {
                None => panic!("{}", string("base.run_target / _v1=None"),),
                Some(_v1_0_0) => _v1_0_0.clone(),
            }
        }
        pub fn method4() -> string {
            string("AUTOMATION")
        }
        pub fn closure3(unitVar: (), v0_1: string) {
            ();
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
            let _v1: MutCell<Option<(Documents::US1, Documents::US2)>> =
                MutCell::new(None::<(Documents::US1, Documents::US2)>);
            let v3: string = Documents::method2(Documents::method1());
            let v24: Documents::US2 = if string("Verbose") == v3.clone() {
                Documents::US2::US2_0(Documents::US0::US0_0)
            } else {
                if string("Debug") == v3.clone() {
                    Documents::US2::US2_0(Documents::US0::US0_1)
                } else {
                    if string("Info") == v3.clone() {
                        Documents::US2::US2_0(Documents::US0::US0_2)
                    } else {
                        if string("Warning") == v3.clone() {
                            Documents::US2::US2_0(Documents::US0::US0_3)
                        } else {
                            if string("Critical") == v3 {
                                Documents::US2::US2_0(Documents::US0::US0_4)
                            } else {
                                Documents::US2::US2_1
                            }
                        }
                    }
                }
            };
            {
                let x: (Documents::US1, Documents::US2) = (
                    if Documents::method2(Documents::method4()) == string("True") {
                        Documents::US1::US1_0({
                            let _arg: DateTime = DateTime::now();
                            _arg.ticks()
                        })
                    } else {
                        Documents::US1::US1_1
                    },
                    v24,
                );
                _v1.set(Some(x))
            }
            {
                let patternInput: (Documents::US1, Documents::US2) = match &_v1.get().clone() {
                    None => panic!("{}", string("base.run_target / _v1=None"),),
                    Some(_v1_0_0) => _v1_0_0.clone(),
                };
                let v139: Documents::US2 = patternInput.1.clone();
                let v138: Documents::US1 = patternInput.0.clone();
                let v147: LrcPtr<Documents::Mut3> = LrcPtr::new(Documents::Mut3 {
                    l0: MutCell::new(Func1::new(move |v: string| Documents::closure3((), v))),
                });
                (
                    LrcPtr::new(Documents::Mut0 {
                        l0: MutCell::new(0_i64),
                    }),
                    LrcPtr::new(Documents::Mut1 {
                        l0: MutCell::new(true),
                    }),
                    LrcPtr::new(Documents::Mut2 {
                        l0: MutCell::new(match &v139 {
                            Documents::US2::US2_0(v139_0_0) => match &v139 {
                                Documents::US2::US2_0(x) => x.clone(),
                                _ => unreachable!(),
                            },
                            _ => v0_1,
                        }),
                    }),
                    match &v138 {
                        Documents::US1::US1_0(v138_0_0) => Some(match &v138 {
                            Documents::US1::US1_0(x) => x.clone(),
                            _ => unreachable!(),
                        }),
                        _ => None::<i64>,
                    },
                    v147,
                )
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
        pub fn method6() -> string {
            string("hh:mm:ss")
        }
        pub fn method7() -> string {
            string("")
        }
        pub fn method8() -> string {
            string("HH:mm:ss")
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
                    let v35: DateTime = match &v16 {
                        Documents::US1::US1_0(v16_0_0) => {
                            let v23: TimeSpan = TimeSpan::new_ticks(
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
                                v23.hours(),
                                v23.minutes(),
                                v23.seconds(),
                                v23.milliseconds(),
                            )
                        }
                        _ => DateTime::now(),
                    };
                    let v36: string = Documents::method6();
                    {
                        let x_3: string = v35.toString(v36);
                        _v10.set(Some(x_3))
                    }
                    {
                        let v147: string = match &_v10.get().clone() {
                            None => panic!("{}", string("base.run_target / _v10=None"),),
                            Some(_v10_0_0) => _v10_0_0.clone(),
                        };
                        let v160: string = padLeft(
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
                        let _v161: MutCell<Option<string>> = MutCell::new(None::<string>);
                        let v176: &str = match &v0_1 {
                            Documents::US0::US0_1 => inline_colorization::color_bright_blue,
                            Documents::US0::US0_2 => inline_colorization::color_bright_green,
                            Documents::US0::US0_0 => inline_colorization::color_bright_black,
                            Documents::US0::US0_3 => inline_colorization::color_yellow,
                            _ => inline_colorization::color_bright_red,
                        };
                        let v178: &str = &*v160;
                        let v180: &str = inline_colorization::color_reset;
                        let v182: string = string("format!(\"{v176}{v178}{v180}\")");
                        let v183: std::string::String = format!("{v176}{v178}{v180}");
                        {
                            let x_5: string = fable_library_rust::String_::fromString(v183);
                            _v161.set(Some(x_5))
                        }
                        trimEndChars(
                            trimStartChars(
                                sprintf!(
                                    "{} {} #{} {} / {}",
                                    v147,
                                    match &_v161.get().clone() {
                                        None =>
                                            panic!("{}", string("base.run_target / _v161=None"),),
                                        Some(_v161_0_0) => _v161_0_0.clone(),
                                    },
                                    (patternInput.0.clone()).l0.get().clone(),
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
        pub fn method9(v0_1: Documents::US0, v1_1: Func0<string>) {
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
                            match &_v25.get().clone() {
                                None => panic!("{}", string("base.run_target / _v25=None"),),
                                Some(_v25_0_0) => _v25_0_0.clone(),
                            }
                            ((patternInput.4.clone()).l0.get().clone())(v24)
                        }
                    }
                }
            }
        }
        pub fn method5(v0_1: Documents::US0, v1_1: Func0<string>, v2: Func0<string>) {
            Documents::method9(
                v0_1.clone(),
                Func0::new({
                    let v0_1 = v0_1.clone();
                    let v1_1 = v1_1.clone();
                    let v2 = v2.clone();
                    move || Documents::closure7(v0_1.clone(), v1_1.clone(), v2.clone(), ())
                }),
            );
        }
        pub fn method10() -> string {
            string("source-dir")
        }
        pub fn method11() -> string {
            string("dist-dir")
        }
        pub fn method12() -> string {
            string("cache-dir")
        }
        pub fn method13() -> string {
            string("hangul-spec")
        }
        pub fn method17(v0_1: string) -> string {
            v0_1
        }
        pub fn method16(v0_1: string, v1_1: string) -> (string, string) {
            (v1_1, Documents::method17(v0_1))
        }
        pub fn method15(v0_1: string, v1_1: string) -> string {
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
                let v27: std::string::String = match &_v17.get().clone() {
                    None => panic!("{}", string("base.run_target / _v17=None"),),
                    Some(_v17_0_0) => _v17_0_0.clone(),
                };
                {
                    let x_2: string = fable_library_rust::String_::fromString(v27);
                    _v2.set(Some(x_2))
                }
                match &_v2.get().clone() {
                    None => panic!("{}", string("base.run_target / _v2=None"),),
                    Some(_v2_0_0) => _v2_0_0.clone(),
                }
            }
        }
        pub fn method19(v0_1: string) -> bool {
            let _v1: MutCell<Option<bool>> = MutCell::new(None::<bool>);
            let v3: &str = &*v0_1;
            let v5: std::string::String = String::from(v3);
            let v7: std::path::PathBuf = std::path::PathBuf::from(v5);
            {
                let x: bool = if v7.clone().exists() {
                    true
                } else {
                    if v7.clone().is_dir() {
                        true
                    } else {
                        v7.is_symlink()
                    }
                };
                _v1.set(Some(x))
            }
            match &_v1.get().clone() {
                None => panic!("{}", string("base.run_target / _v1=None"),),
                Some(_v1_0_0) => _v1_0_0.clone(),
            }
        }
        pub fn method21(v0_1: string) -> Option<string> {
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
                let v24: std::string::String = match &_v14.get().clone() {
                    None => panic!("{}", string("base.run_target / _v14=None"),),
                    Some(_v14_0_0) => _v14_0_0.clone(),
                };
                {
                    let x_2: Documents::US3 =
                        Documents::US3::US3_0(fable_library_rust::String_::fromString(v24));
                    _v1.set(Some(x_2))
                }
                {
                    let v51: Documents::US3 = match &_v1.get().clone() {
                        None => panic!("{}", string("base.run_target / _v1=None"),),
                        Some(_v1_0_0) => _v1_0_0.clone(),
                    };
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
        pub fn closure8(unitVar: (), v0_1: string) -> Option<string> {
            Documents::method21(v0_1)
        }
        pub fn method20() -> Func1<string, Option<string>> {
            Func1::new(move |v: string| Documents::closure8((), v))
        }
        pub fn method22(v0_1: string, v1_1: string, v2: string) -> string {
            let v0_1: MutCell<string> = MutCell::new(v0_1.clone());
            let v1_1: MutCell<string> = MutCell::new(v1_1.clone());
            let v2: MutCell<string> = MutCell::new(v2.clone());
            '_method22: loop {
                break '_method22 (if Documents::method19(Documents::method15(
                    v2.get().clone(),
                    v0_1.get().clone(),
                )) {
                    v2.get().clone()
                } else {
                    let v6: Option<string> = (Documents::method20())(v2.get().clone());
                    let _v7: LrcPtr<MutCell<Option<Documents::US3>>> =
                        refCell(None::<Documents::US3>);
                    {
                        let x_2: Option<Documents::US3> = match &v6 {
                            None => None::<Documents::US3>,
                            Some(v6_0_0) => {
                                let x: string = v6_0_0.clone();
                                Some((Func0::new({
                                    let x = x.clone();
                                    move || Documents::US3::US3_0(x.clone())
                                }))())
                            }
                        };
                        _v7.set(x_2)
                    }
                    {
                        let v12: Documents::US3 =
                            defaultValue(Documents::US3::US3_1, _v7.get().clone());
                        match &v12 {
                            Documents::US3::US3_0(v12_0_0) => {
                                let v0_1_temp: string = v0_1.get().clone();
                                let v1_1_temp: string = v1_1.get().clone();
                                let v2_temp: string = match &v12 {
                                    Documents::US3::US3_0(x) => x.clone(),
                                    _ => unreachable!(),
                                };
                                v0_1.set(v0_1_temp);
                                v1_1.set(v1_1_temp);
                                v2.set(v2_temp);
                                continue '_method22;
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
        pub fn method18(v0_1: string, v1_1: string) -> string {
            if Documents::method19(Documents::method15(v1_1.clone(), v0_1.clone())) {
                v1_1.clone()
            } else {
                let v5: Option<string> = (Documents::method20())(v1_1.clone());
                let _v6: LrcPtr<MutCell<Option<Documents::US3>>> = refCell(None::<Documents::US3>);
                {
                    let x_2: Option<Documents::US3> = match &v5 {
                        None => None::<Documents::US3>,
                        Some(v5_0_0) => {
                            let x: string = v5_0_0.clone();
                            Some((Func0::new({
                                let x = x.clone();
                                move || Documents::US3::US3_0(x.clone())
                            }))())
                        }
                    };
                    _v6.set(x_2)
                }
                {
                    let v11: Documents::US3 =
                        defaultValue(Documents::US3::US3_1, _v6.get().clone());
                    match &v11 {
                        Documents::US3::US3_0(v11_0_0) => Documents::method22(
                            v0_1.clone(),
                            v1_1.clone(),
                            match &v11 {
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
        pub fn method24(v0_1: string) -> string {
            v0_1
        }
        pub fn method25() -> string {
            let _v0: MutCell<Option<string>> = MutCell::new(None::<string>);
            let v2: Result<std::path::PathBuf, std::io::Error> = std::env::current_dir();
            let v4: std::path::PathBuf = v2.unwrap();
            let v6: std::path::Display = v4.display();
            let _v7: MutCell<Option<std::string::String>> =
                MutCell::new(None::<std::string::String>);
            {
                let x: std::string::String = format!("{}", v6);
                _v7.set(Some(x))
            }
            {
                let v17: std::string::String = match &_v7.get().clone() {
                    None => panic!("{}", string("base.run_target / _v7=None"),),
                    Some(_v7_0_0) => _v7_0_0.clone(),
                };
                {
                    let x_2: string = fable_library_rust::String_::fromString(v17);
                    _v0.set(Some(x_2))
                }
                match &_v0.get().clone() {
                    None => panic!("{}", string("base.run_target / _v0=None"),),
                    Some(_v0_0_0) => _v0_0_0.clone(),
                }
            }
        }
        pub fn method26() -> string {
            string("")
        }
        pub fn method27(v0_1: string) -> string {
            v0_1
        }
        pub fn method28() -> string {
            string("^\\\\\\\\\\?\\\\")
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
        pub fn method23(v0_1: string) -> string {
            let _v1: MutCell<Option<string>> = MutCell::new(None::<string>);
            let v2: string = Documents::method24(v0_1);
            let v4: &str = &*v2.clone();
            let v6: std::string::String = String::from(v4);
            let v8: std::path::PathBuf = std::path::PathBuf::from(v6);
            {
                let x_6: string = if v8.exists() == false {
                    let v12: string = Documents::method25();
                    let v13: string = Documents::method15(v12.clone(), v2.clone());
                    let v14: string = Documents::method26();
                    let _v15: MutCell<Option<string>> = MutCell::new(None::<string>);
                    let v16: string = Documents::method27(v13);
                    let v19: Result<regex::Regex, regex::Error> =
                        regex::Regex::new(&string("^\\\\\\\\\\?\\\\"));
                    let v21: regex::Regex = v19.unwrap();
                    let v23: std::borrow::Cow<str> = v21.replace_all(&v16, &*v14);
                    let v25: std::string::String = String::from(v23);
                    {
                        let x: string = fable_library_rust::String_::fromString(v25);
                        _v15.set(Some(x))
                    }
                    {
                        let v34: string = match &_v15.get().clone() {
                            None => panic!("{}", string("base.run_target / _v15=None"),),
                            Some(_v15_0_0) => _v15_0_0.clone(),
                        };
                        let v39: Array<string> = split(
                            replace(
                                sprintf!(
                                    "{}{}",
                                    toLower(ofChar(getCharAt(v34.clone(), 0_i32))),
                                    getSlice(v34, Some(1_i32), None::<i32>)
                                ),
                                string("\\"),
                                string("/"),
                            ),
                            string("/"),
                            -1_i32,
                            0_i32,
                        );
                        let v41: i32 = count_2(v39.clone());
                        let v42: LrcPtr<Documents::Mut4> = LrcPtr::new(Documents::Mut4 {
                            l0: MutCell::new(0_i32),
                            l1: MutCell::new(0_i32),
                            l2: MutCell::new(new_empty::<string>()),
                        });
                        while Documents::method29(v41, v42.clone()) {
                            let v44: i32 = v42.l0.get().clone();
                            let v47: i32 = v44.wrapping_neg() + v41 - 1_i32;
                            let matchValue: i32 = v42.l1.get().clone();
                            let v49: Array<string> = v42.l2.get().clone();
                            let v48: i32 = matchValue;
                            let v50: string = v39[v47].clone();
                            let patternInput_1: (i32, Array<string>) =
                                if string("..") == v50.clone() {
                                    (v48 + 1_i32, v49.clone())
                                } else {
                                    if string(".") == v50.clone() {
                                        (v48, v49.clone())
                                    } else {
                                        if 0_i32 == v48 {
                                            if endsWith(v50.clone(), string(":"), false) {
                                                let v58: Array<string> = new_array(&[sprintf!(
                                                    "{}:",
                                                    getCharAt(v12.clone(), 0_i32)
                                                )]);
                                                let v59: i32 = count_2(v58.clone());
                                                let v61: i32 = v59 + count_2(v49.clone());
                                                let v62: Array<string> = new_init(&string(""), v61);
                                                let v63: LrcPtr<Documents::Mut5> =
                                                    LrcPtr::new(Documents::Mut5 {
                                                        l0: MutCell::new(0_i32),
                                                    });
                                                while Documents::method30(v61, v63.clone()) {
                                                    let v65: i32 = v63.l0.get().clone();
                                                    let v70: string = if v65 < v59 {
                                                        v58[v65].clone()
                                                    } else {
                                                        let v68: i32 = v65 - v59;
                                                        v49[v68].clone()
                                                    };
                                                    v62.get_mut()[v65 as usize] = v70;
                                                    {
                                                        let v71: i32 = v65 + 1_i32;
                                                        v63.l0.set(v71);
                                                        ()
                                                    }
                                                }
                                                (0_i32, v62.clone())
                                            } else {
                                                let v72: Array<string> = new_array(&[v50]);
                                                let v73: i32 = count_2(v72.clone());
                                                let v75: i32 = v73 + count_2(v49.clone());
                                                let v76: Array<string> = new_init(&string(""), v75);
                                                let v77: LrcPtr<Documents::Mut5> =
                                                    LrcPtr::new(Documents::Mut5 {
                                                        l0: MutCell::new(0_i32),
                                                    });
                                                while Documents::method30(v75, v77.clone()) {
                                                    let v79: i32 = v77.l0.get().clone();
                                                    let v84: string = if v79 < v73 {
                                                        v72[v79].clone()
                                                    } else {
                                                        let v82: i32 = v79 - v73;
                                                        v49[v82].clone()
                                                    };
                                                    v76.get_mut()[v79 as usize] = v84;
                                                    {
                                                        let v85: i32 = v79 + 1_i32;
                                                        v77.l0.set(v85);
                                                        ()
                                                    }
                                                }
                                                (0_i32, v76.clone())
                                            }
                                        } else {
                                            (v48 - 1_i32, v49.clone())
                                        }
                                    }
                                };
                            let v95: i32 = v44 + 1_i32;
                            v42.l0.set(v95);
                            v42.l1.set(patternInput_1.0.clone());
                            v42.l2.set(patternInput_1.1.clone());
                            ()
                        }
                        {
                            let matchValue_2: i32 = v42.l1.get().clone();
                            let v97: Array<string> = v42.l2.get().clone();
                            let v98: LrcPtr<dyn IEnumerable_1<string>> = delay(Func0::new({
                                let v97 = v97.clone();
                                move || {
                                    map(
                                        Func1::new({
                                            let v97 = v97.clone();
                                            move |i: i32| v97[i].clone()
                                        }),
                                        rangeNumeric(0_i32, 1_i32, count_2(v97.clone()) - 1_i32),
                                    )
                                }
                            }));
                            let _v99: MutCell<Option<char>> = MutCell::new(None::<char>);
                            {
                                let x_2: char = std::path::MAIN_SEPARATOR;
                                _v99.set(Some(x_2))
                            }
                            join(
                                ofChar(match &_v99.get().clone() {
                                    None => panic!("{}", string("base.run_target / _v99=None"),),
                                    Some(_v99_0_0) => _v99_0_0.clone(),
                                }),
                                toArray(v98),
                            )
                        }
                    }
                } else {
                    let v114: Result<std::path::PathBuf, std::io::Error> =
                        std::fs::canonicalize(&*v2);
                    let v116: std::path::PathBuf = v114.unwrap();
                    let v118: std::path::Display = v116.display();
                    let _v119: MutCell<Option<std::string::String>> =
                        MutCell::new(None::<std::string::String>);
                    {
                        let x_4: std::string::String = format!("{}", v118);
                        _v119.set(Some(x_4))
                    }
                    {
                        let v129: std::string::String = match &_v119.get().clone() {
                            None => panic!("{}", string("base.run_target / _v119=None"),),
                            Some(_v119_0_0) => _v119_0_0.clone(),
                        };
                        fable_library_rust::String_::fromString(v129)
                    }
                };
                _v1.set(Some(x_6))
            }
            match &_v1.get().clone() {
                None => panic!("{}", string("base.run_target / _v1=None"),),
                Some(_v1_0_0) => _v1_0_0.clone(),
            }
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
        pub fn method34(v0_1: async_walkdir::DirEntry) -> async_walkdir::DirEntry {
            v0_1
        }
        pub fn closure12(unitVar: (), v0_1: std::io::Error) -> std::string::String {
            let _v1: MutCell<Option<std::string::String>> =
                MutCell::new(None::<std::string::String>);
            {
                let x: std::string::String = format!("{}", v0_1);
                _v1.set(Some(x))
            }
            match &_v1.get().clone() {
                None => panic!("{}", string("base.run_target / _v1=None"),),
                Some(_v1_0_0) => _v1_0_0.clone(),
            }
        }
        pub fn method35() -> Func1<std::io::Error, std::string::String> {
            Func1::new(move |v: std::io::Error| Documents::closure12((), v))
        }
        pub fn closure13(unitVar: (), v0_1: std::fs::FileType) -> Documents::US8 {
            Documents::US8::US8_0(v0_1)
        }
        pub fn closure14(unitVar: (), v0_1: std::string::String) -> Documents::US8 {
            Documents::US8::US8_1(v0_1)
        }
        pub fn method36(v0_1: std::fs::FileType) -> std::fs::FileType {
            v0_1
        }
        pub fn method37(v0_1: Documents::US7) -> Documents::US7 {
            v0_1
        }
        pub fn method33(
            v0_1: async_walkdir::DirEntry,
        ) -> std::pin::Pin<Box<dyn std::future::Future<Output = Documents::US7> + Send>> {
            let __result = Box::pin(async move {
                //;
                {
                    let v2: async_walkdir::DirEntry = Documents::method34(v0_1.clone());
                    let v4: std::pin::Pin<
                        Box<
                            dyn std::future::Future<
                                    Output = Result<std::fs::FileType, std::io::Error>,
                                > + Send,
                        >,
                    > = Box::pin(async_walkdir::DirEntry::file_type(&v2));
                    let v6: Result<std::fs::FileType, std::io::Error> = v4.await;
                    let v7 = Documents::method35();
                    let v9: Result<std::fs::FileType, std::string::String> = v6.map_err(|x| v7(x));
                    let v12: Documents::US8 = match &v9 {
                        Err(v9_1_0) => Documents::closure14((), v9_1_0.clone()),
                        Ok(v9_0_0) => Documents::closure13((), v9_0_0.clone()),
                    };
                    let v72: Documents::US7 =
                        Documents::method37(if let Documents::US8::US8_0(v12_0_0) = &v12 {
                            let v14: std::fs::FileType = Documents::method36(match &v12 {
                                Documents::US8::US8_0(x) => x.clone(),
                                _ => unreachable!(),
                            });
                            if std::fs::FileType::is_dir(&v14) {
                                Documents::US7::US7_0
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
                                    let v32: std::string::String = match &_v22.get().clone() {
                                        None => {
                                            panic!("{}", string("base.run_target / _v22=None"),)
                                        }
                                        Some(_v22_0_0) => _v22_0_0.clone(),
                                    };
                                    let v34: string = fable_library_rust::String_::fromString(v32);
                                    if if endsWith(v34.clone(), string(".md"), false) == false {
                                        true
                                    } else {
                                        endsWith(v34, string(".hangul.md"), false)
                                    } {
                                        Documents::US7::US7_0
                                    } else {
                                        Documents::US7::US7_2
                                    }
                                }
                            }
                        } else {
                            let v46: std::path::PathBuf = async_walkdir::DirEntry::path(&v0_1);
                            let v48: std::path::Display = v46.display();
                            let _v49: MutCell<Option<std::string::String>> =
                                MutCell::new(None::<std::string::String>);
                            {
                                let x_4: std::string::String = format!("{}", v48);
                                _v49.set(Some(x_4))
                            }
                            {
                                let v59: std::string::String = match &_v49.get().clone() {
                                    None => panic!("{}", string("base.run_target / _v49=None"),),
                                    Some(_v49_0_0) => _v49_0_0.clone(),
                                };
                                let v61: string = fable_library_rust::String_::fromString(v59);
                                if if endsWith(v61.clone(), string(".md"), false) == false {
                                    true
                                } else {
                                    endsWith(v61, string(".hangul.md"), false)
                                } {
                                    Documents::US7::US7_0
                                } else {
                                    Documents::US7::US7_2
                                }
                            }
                        });
                    let v79: string = string("v72 }}); { //");
                    v72
                }
            });
            {
                //;
                __result
            }
        }
        pub fn method38(v0_1: async_walkdir::Filtering) -> async_walkdir::Filtering {
            v0_1
        }
        pub fn method32(
            v0_1: async_walkdir::DirEntry,
        ) -> std::pin::Pin<Box<dyn std::future::Future<Output = async_walkdir::Filtering> + Send>>
        {
            let __result = Box::pin(async {
                //;
                {
                    let v2: std::pin::Pin<
                        Box<dyn std::future::Future<Output = Documents::US7> + Send>,
                    > = Documents::method33(v0_1);
                    let v4: Documents::US7 = v2.await;
                    let v14: async_walkdir::Filtering = Documents::method38(match &v4 {
                        Documents::US7::US7_0 => async_walkdir::Filtering::Ignore,
                        Documents::US7::US7_1 => async_walkdir::Filtering::IgnoreDir,
                        _ => async_walkdir::Filtering::Continue,
                    });
                    let v21: string = string("v14 }}); { //");
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
            Documents::method32(v0_1)
        }
        pub fn closure16(unitVar: (), v0_1: async_walkdir::DirEntry) -> Documents::US9 {
            Documents::US9::US9_0(v0_1)
        }
        pub fn closure17(unitVar: (), v0_1: std::string::String) -> Documents::US9 {
            Documents::US9::US9_1(v0_1)
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
            let v1_1 = Documents::method35();
            let v3: Result<async_walkdir::DirEntry, std::string::String> =
                v0_1.map_err(|x| v1_1(x));
            let v6: Documents::US9 = match &v3 {
                Err(v3_1_0) => Documents::closure17((), v3_1_0.clone()),
                Ok(v3_0_0) => Documents::closure16((), v3_0_0.clone()),
            };
            let v32: Documents::US3 = match &v6 {
                Documents::US9::US9_0(v6_0_0) => {
                    let v9: std::path::PathBuf = async_walkdir::DirEntry::path(&v6_0_0.clone());
                    let v11: std::path::Display = v9.display();
                    let _v12: MutCell<Option<std::string::String>> =
                        MutCell::new(None::<std::string::String>);
                    {
                        let x_2: std::string::String = format!("{}", v11);
                        _v12.set(Some(x_2))
                    }
                    {
                        let v22: std::string::String = match &_v12.get().clone() {
                            None => panic!("{}", string("base.run_target / _v12=None"),),
                            Some(_v12_0_0) => _v12_0_0.clone(),
                        };
                        Documents::US3::US3_0(fable_library_rust::String_::fromString(v22))
                    }
                }
                Documents::US9::US9_1(v6_1_0) => {
                    Documents::method5(
                        Documents::US0::US0_4,
                        Func0::new(move || Documents::closure18((), ())),
                        Func0::new({
                            let v6 = v6.clone();
                            move || {
                                Documents::closure19(
                                    match &v6 {
                                        Documents::US9::US9_1(x) => x.clone(),
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
        pub fn method39() -> Func1<Result<async_walkdir::DirEntry, std::io::Error>, Option<string>>
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
        pub fn method40(v0_1: string) -> string {
            let v1_1: string = Documents::method23(v0_1);
            let v2: string = Documents::method26();
            let _v3: MutCell<Option<string>> = MutCell::new(None::<string>);
            let v4: string = Documents::method27(v1_1);
            let v7: Result<regex::Regex, regex::Error> =
                regex::Regex::new(&string("^\\\\\\\\\\?\\\\"));
            let v9: regex::Regex = v7.unwrap();
            let v11: std::borrow::Cow<str> = v9.replace_all(&v4, &*v2);
            let v13: std::string::String = String::from(v11);
            {
                let x: string = fable_library_rust::String_::fromString(v13);
                _v3.set(Some(x))
            }
            {
                let v22: string = match &_v3.get().clone() {
                    None => panic!("{}", string("base.run_target / _v3=None"),),
                    Some(_v3_0_0) => _v3_0_0.clone(),
                };
                replace(
                    sprintf!(
                        "{}{}",
                        toLower(ofChar(getCharAt(v22.clone(), 0_i32))),
                        getSlice(v22, Some(1_i32), None::<i32>)
                    ),
                    string("\\"),
                    string("/"),
                )
            }
        }
        pub fn method42(
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
        pub fn method44() -> (string, string) {
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
        pub fn method45() -> Func1<char, Func1<LrcPtr<Documents::UH0>, LrcPtr<Documents::UH0>>> {
            Func1::new(move |v: char| Documents::closure23((), v))
        }
        pub fn method46(
            v0_1: string,
            v1_1: string,
            v2: LrcPtr<Documents::UH0>,
            v3: Documents::US10,
        ) -> (string, string) {
            let v0_1: MutCell<string> = MutCell::new(v0_1.clone());
            let v1_1: MutCell<string> = MutCell::new(v1_1.clone());
            let v2: MutCell<LrcPtr<Documents::UH0>> = MutCell::new(v2.clone());
            let v3: MutCell<Documents::US10> = MutCell::new(v3.clone());
            '_method46: loop {
                break '_method46 (if let Documents::UH0::UH0_1(v2_1_0, v2_1_1) =
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
                            continue '_method46;
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
                                        continue '_method46;
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
                                            continue '_method46;
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
                                            continue '_method46;
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
                                        continue '_method46;
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
                                        continue '_method46;
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
                                    continue '_method46;
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
                                continue '_method46;
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
                                            continue '_method46;
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
                                                continue '_method46;
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
                                                continue '_method46;
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
                                            continue '_method46;
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
                                            continue '_method46;
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
                                        continue '_method46;
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
                                            continue '_method46;
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
                                            continue '_method46;
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
                                            continue '_method46;
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
                                            continue '_method46;
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
                                        continue '_method46;
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
                                        continue '_method46;
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
                                    continue '_method46;
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
        pub fn method43(v0_1: string) -> (string, string) {
            let patternInput: (string, string) = Documents::method44();
            let v3: i32 = length(v0_1.clone());
            let v4: Array<char> = new_init(&'\u{0000}', v3);
            let v5: LrcPtr<Documents::Mut5> = LrcPtr::new(Documents::Mut5 {
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
                Documents::method46(
                    patternInput.1.clone(),
                    patternInput.0.clone(),
                    foldBack(
                        Func2::new(move |b0: char, b1: LrcPtr<Documents::UH0>| {
                            (Documents::method45())(b0)(b1)
                        }),
                        v11,
                        LrcPtr::new(Documents::UH0::UH0_0),
                    ),
                    Documents::US10::US10_0,
                )
            }
        }
        pub fn method49(v0_1: char, v1_1: i64) -> bool {
            let v0_1: MutCell<char> = MutCell::new(v0_1);
            let v1_1: MutCell<i64> = MutCell::new(v1_1);
            '_method49: loop {
                break '_method49 (if v1_1.get().clone() >= 4_i64 {
                    false
                } else {
                    let v19: Documents::US15 = if v1_1.get().clone() == 0_i64 {
                        Documents::US15::US15_0('\\')
                    } else {
                        let v5: i64 = v1_1.get().clone() - 1_i64;
                        if v5 == 0_i64 {
                            Documents::US15::US15_0('`')
                        } else {
                            let v8: i64 = v5 - 1_i64;
                            if v8 == 0_i64 {
                                Documents::US15::US15_0('\"')
                            } else {
                                let v11: i64 = v8 - 1_i64;
                                if v11 == 0_i64 {
                                    Documents::US15::US15_0(' ')
                                } else {
                                    let v14: i64 = v11 - 1_i64;
                                    Documents::US15::US15_1
                                }
                            }
                        }
                    };
                    if v0_1.get().clone()
                        == match &v19 {
                            Documents::US15::US15_0(v19_0_0) => match &v19 {
                                Documents::US15::US15_0(x) => x.clone(),
                                _ => unreachable!(),
                            },
                            _ => panic!("{}", string("Option does not have a value."),),
                        }
                    {
                        true
                    } else {
                        let v0_1_temp: char = v0_1.get().clone();
                        let v1_1_temp: i64 = v1_1.get().clone() + 1_i64;
                        v0_1.set(v0_1_temp);
                        v1_1.set(v1_1_temp);
                        continue '_method49;
                    }
                });
            }
        }
        pub fn method50(
            v0_1: LrcPtr<Documents::UH0>,
            v1_1: LrcPtr<StringBuilder>,
            v2: i32,
            v3: i32,
        ) -> (LrcPtr<StringBuilder>, i32, i32) {
            let v0_1: MutCell<LrcPtr<Documents::UH0>> = MutCell::new(v0_1.clone());
            let v1_1: MutCell<LrcPtr<StringBuilder>> = MutCell::new(v1_1.clone());
            let v2: MutCell<i32> = MutCell::new(v2);
            let v3: MutCell<i32> = MutCell::new(v3);
            '_method50: loop {
                break '_method50 (match v0_1.get().clone().as_ref() {
                    Documents::UH0::UH0_0 => {
                        (v1_1.get().clone(), v2.get().clone(), v3.get().clone())
                    }
                    Documents::UH0::UH0_1(v0_1_1_0, v0_1_1_1) => {
                        let v4: char = match v0_1.get().clone().as_ref() {
                            Documents::UH0::UH0_1(x, _) => x.clone(),
                            _ => unreachable!(),
                        };
                        let v6: bool = '\n' == v4;
                        let patternInput: (i32, i32) = if v6 {
                            (1_i32, v3.get().clone() + 1_i32)
                        } else {
                            (v2.get().clone() + 1_i32, v3.get().clone())
                        };
                        {
                            let v0_1_temp: LrcPtr<Documents::UH0> =
                                match v0_1.get().clone().as_ref() {
                                    Documents::UH0::UH0_1(_, x) => x.clone(),
                                    _ => unreachable!(),
                                };
                            let v1_1_temp: LrcPtr<StringBuilder> = if v6 {
                                let v12: LrcPtr<StringBuilder> = v1_1.get().clone().Clear();
                                v1_1.get().clone()
                            } else {
                                let v16: LrcPtr<StringBuilder> = {
                                    let value: string = ofChar(v4);
                                    v1_1.get().clone().Append_Z721C83C5(value)
                                };
                                v1_1.get().clone()
                            };
                            let v2_temp: i32 = patternInput.0.clone();
                            let v3_temp: i32 = patternInput.1.clone();
                            v0_1.set(v0_1_temp);
                            v1_1.set(v1_1_temp);
                            v2.set(v2_temp);
                            v3.set(v3_temp);
                            continue '_method50;
                        }
                    }
                });
            }
        }
        pub fn method51(
            v0_1: string,
            v1_1: string,
            v2: LrcPtr<StringBuilder>,
            v3: i32,
            v4: i32,
        ) -> Documents::US16 {
            let v0_1: MutCell<string> = MutCell::new(v0_1.clone());
            let v1_1: MutCell<string> = MutCell::new(v1_1.clone());
            let v2: MutCell<LrcPtr<StringBuilder>> = MutCell::new(v2.clone());
            let v3: MutCell<i32> = MutCell::new(v3);
            let v4: MutCell<i32> = MutCell::new(v4);
            '_method51: loop {
                break '_method51 ({
                    let v57: Documents::US14 = if string("") == v1_1.get().clone() {
                        Documents::US14::US14_1(sprintf!(
                            "parsing.none_of / unexpected end of input / chars: {:?} / s: {:?}",
                            toArray_1(ofArray(new_array(&['\\', '`', '\"', ' ']))),
                            (v2.get().clone(), v3.get().clone(), v4.get().clone())
                        ))
                    } else {
                        let v15: char = getCharAt(v1_1.get().clone(), 0_i32);
                        let v22: string = getSlice(
                            v1_1.get().clone(),
                            Some(1_i32),
                            Some(length(v1_1.get().clone())),
                        );
                        if Documents::method49(v15, 0_i64) == false {
                            let v27: string = ofChar(v15);
                            let v28: i32 = length(v27.clone());
                            let v29: Array<char> = new_init(&'\u{0000}', v28);
                            let v30: LrcPtr<Documents::Mut5> = LrcPtr::new(Documents::Mut5 {
                                l0: MutCell::new(0_i32),
                            });
                            while Documents::method30(v28, v30.clone()) {
                                let v32: i32 = v30.l0.get().clone();
                                let v33: char = getCharAt(v27.clone(), v32);
                                v29.get_mut()[v32 as usize] = v33;
                                {
                                    let v34: i32 = v32 + 1_i32;
                                    v30.l0.set(v34);
                                    ()
                                }
                            }
                            {
                                let v36: List<char> = ofArray(v29.clone());
                                let patternInput: (LrcPtr<StringBuilder>, i32, i32) =
                                    Documents::method50(
                                        foldBack(
                                            Func2::new(
                                                move |b0: char, b1: LrcPtr<Documents::UH0>| {
                                                    (Documents::method45())(b0)(b1)
                                                },
                                            ),
                                            v36,
                                            LrcPtr::new(Documents::UH0::UH0_0),
                                        ),
                                        v2.get().clone(),
                                        v3.get().clone(),
                                        v4.get().clone(),
                                    );
                                Documents::US14::US14_0(
                                    v15,
                                    v22,
                                    patternInput.0.clone(),
                                    patternInput.1.clone(),
                                    patternInput.2.clone(),
                                )
                            }
                        } else {
                            Documents::US14::US14_1(sprintf!(
                                "parsing.none_of / unexpected char: \'{}\' / chars: {:?} / s: {:?}",
                                v15,
                                toArray_1(ofArray(new_array(&['\\', '`', '\"', ' ']))),
                                (v2.get().clone(), v3.get().clone(), v4.get().clone())
                            ))
                        }
                    };
                    match &v57 {
                        Documents::US14::US14_0(v57_0_0, v57_0_1, v57_0_2, v57_0_3, v57_0_4) => {
                            let v0_1_temp: string =
                                append(v0_1.get().clone(), ofChar(v57_0_0.clone()));
                            let v1_1_temp: string = v57_0_1.clone();
                            let v2_temp: LrcPtr<StringBuilder> = v57_0_2.clone();
                            let v3_temp: i32 = v57_0_3.clone();
                            let v4_temp: i32 = v57_0_4.clone();
                            v0_1.set(v0_1_temp);
                            v1_1.set(v1_1_temp);
                            v2.set(v2_temp);
                            v3.set(v3_temp);
                            v4.set(v4_temp);
                            continue '_method51;
                        }
                        _ => Documents::US16::US16_0(
                            v0_1.get().clone(),
                            v1_1.get().clone(),
                            v2.get().clone(),
                            v3.get().clone(),
                            v4.get().clone(),
                        ),
                    }
                });
            }
        }
        pub fn method53(v0_1: char, v1_1: i64) -> bool {
            let v0_1: MutCell<char> = MutCell::new(v0_1);
            let v1_1: MutCell<i64> = MutCell::new(v1_1);
            '_method53: loop {
                break '_method53 (if v1_1.get().clone() >= 3_i64 {
                    false
                } else {
                    let v15: Documents::US15 = if v1_1.get().clone() == 0_i64 {
                        Documents::US15::US15_0('\\')
                    } else {
                        let v5: i64 = v1_1.get().clone() - 1_i64;
                        if v5 == 0_i64 {
                            Documents::US15::US15_0('`')
                        } else {
                            let v8: i64 = v5 - 1_i64;
                            if v8 == 0_i64 {
                                Documents::US15::US15_0('\"')
                            } else {
                                let v11: i64 = v8 - 1_i64;
                                Documents::US15::US15_1
                            }
                        }
                    };
                    if v0_1.get().clone()
                        == match &v15 {
                            Documents::US15::US15_0(v15_0_0) => match &v15 {
                                Documents::US15::US15_0(x) => x.clone(),
                                _ => unreachable!(),
                            },
                            _ => panic!("{}", string("Option does not have a value."),),
                        }
                    {
                        true
                    } else {
                        let v0_1_temp: char = v0_1.get().clone();
                        let v1_1_temp: i64 = v1_1.get().clone() + 1_i64;
                        v0_1.set(v0_1_temp);
                        v1_1.set(v1_1_temp);
                        continue '_method53;
                    }
                });
            }
        }
        pub fn closure25(
            unitVar: (),
            _arg: (string, LrcPtr<StringBuilder>, i32, i32),
        ) -> Documents::US16 {
            let v3: i32 = _arg.3.clone();
            let v2: i32 = _arg.2.clone();
            let v1_1: LrcPtr<StringBuilder> = _arg.1.clone();
            let v0_1: string = _arg.0.clone();
            let v60: Documents::US14 = if string("") == v0_1.clone() {
                Documents::US14::US14_1(sprintf!(
                    "parsing.p_char / unexpected end of input / s: {:?}",
                    (v1_1.clone(), v2, v3)
                ))
            } else {
                let v7: char = getCharAt(v0_1.clone(), 0_i32);
                if v7 == '\\' {
                    let v15: string =
                        getSlice(v0_1.clone(), Some(1_i32), Some(length(v0_1.clone())));
                    let v17: string = ofChar(v7);
                    let v18: i32 = length(v17.clone());
                    let v19: Array<char> = new_init(&'\u{0000}', v18);
                    let v20: LrcPtr<Documents::Mut5> = LrcPtr::new(Documents::Mut5 {
                        l0: MutCell::new(0_i32),
                    });
                    while Documents::method30(v18, v20.clone()) {
                        let v22: i32 = v20.l0.get().clone();
                        let v23: char = getCharAt(v17.clone(), v22);
                        v19.get_mut()[v22 as usize] = v23;
                        {
                            let v24: i32 = v22 + 1_i32;
                            v20.l0.set(v24);
                            ()
                        }
                    }
                    {
                        let v26: List<char> = ofArray(v19.clone());
                        let patternInput: (LrcPtr<StringBuilder>, i32, i32) = Documents::method50(
                            foldBack(
                                Func2::new(move |b0: char, b1: LrcPtr<Documents::UH0>| {
                                    (Documents::method45())(b0)(b1)
                                }),
                                v26,
                                LrcPtr::new(Documents::UH0::UH0_0),
                            ),
                            v1_1.clone(),
                            v2,
                            v3,
                        );
                        Documents::US14::US14_0(
                            v7,
                            v15,
                            patternInput.0.clone(),
                            patternInput.1.clone(),
                            patternInput.2.clone(),
                        )
                    }
                } else {
                    let v38: i32 = length(v0_1.clone());
                    let v41: i32 = indexOf(v0_1.clone(), string("\n")) - 1_i32;
                    Documents::US14::US14_1(sprintf!(
                        "{}\n{}\n",
                        sprintf!(
                            "parsing.p_char / expected: \'{}\' / line: {} / col: {}\n{}{}",
                            '\\',
                            v3,
                            v2,
                            v1_1,
                            getSlice(
                                v0_1,
                                Some(0_i32),
                                Some(if -2_i32 == v41 { v38 } else { v41 })
                            )
                        ),
                        append(replicate(v2 - 1_i32, string(" ")), string("^"))
                    ))
                }
            };
            let v102: Documents::US14 = match &v60 {
                Documents::US14::US14_0(v60_0_0, v60_0_1, v60_0_2, v60_0_3, v60_0_4) => {
                    let v65: i32 = v60_0_4.clone();
                    let v64: i32 = v60_0_3.clone();
                    let v63: LrcPtr<StringBuilder> = v60_0_2.clone();
                    let v62: string = v60_0_1.clone();
                    if string("") == v62.clone() {
                        Documents::US14::US14_1(sprintf!(
                            "parsing.any_char / unexpected end of input / s: {:?}",
                            (v63.clone(), v64, v65)
                        ))
                    } else {
                        let v69: char = getCharAt(v62.clone(), 0_i32);
                        let v76: string = getSlice(v62.clone(), Some(1_i32), Some(length(v62)));
                        let v78: string = ofChar(v69);
                        let v79: i32 = length(v78.clone());
                        let v80: Array<char> = new_init(&'\u{0000}', v79);
                        let v81: LrcPtr<Documents::Mut5> = LrcPtr::new(Documents::Mut5 {
                            l0: MutCell::new(0_i32),
                        });
                        while Documents::method30(v79, v81.clone()) {
                            let v83: i32 = v81.l0.get().clone();
                            let v84: char = getCharAt(v78.clone(), v83);
                            v80.get_mut()[v83 as usize] = v84;
                            {
                                let v85: i32 = v83 + 1_i32;
                                v81.l0.set(v85);
                                ()
                            }
                        }
                        {
                            let v87: List<char> = ofArray(v80.clone());
                            let patternInput_1: (LrcPtr<StringBuilder>, i32, i32) =
                                Documents::method50(
                                    foldBack(
                                        Func2::new(move |b0: char, b1: LrcPtr<Documents::UH0>| {
                                            (Documents::method45())(b0)(b1)
                                        }),
                                        v87,
                                        LrcPtr::new(Documents::UH0::UH0_0),
                                    ),
                                    v63,
                                    v64,
                                    v65,
                                );
                            Documents::US14::US14_0(
                                v69,
                                v76,
                                patternInput_1.0.clone(),
                                patternInput_1.1.clone(),
                                patternInput_1.2.clone(),
                            )
                        }
                    }
                }
                Documents::US14::US14_1(v60_1_0) => Documents::US14::US14_1(v60_1_0.clone()),
            };
            match &v102 {
                Documents::US14::US14_0(v102_0_0, v102_0_1, v102_0_2, v102_0_3, v102_0_4) => {
                    Documents::US16::US16_0(
                        sprintf!("{}{}", '\\', v102_0_0.clone()),
                        v102_0_1.clone(),
                        v102_0_2.clone(),
                        v102_0_3.clone(),
                        v102_0_4.clone(),
                    )
                }
                Documents::US14::US14_1(v102_1_0) => Documents::US16::US16_1(v102_1_0.clone()),
            }
        }
        pub fn closure26(
            unitVar: (),
            _arg: (string, LrcPtr<StringBuilder>, i32, i32),
        ) -> Documents::US16 {
            let v3: i32 = _arg.3.clone();
            let v2: i32 = _arg.2.clone();
            let v1_1: LrcPtr<StringBuilder> = _arg.1.clone();
            let v0_1: string = _arg.0.clone();
            let v60: Documents::US14 = if string("") == v0_1.clone() {
                Documents::US14::US14_1(sprintf!(
                    "parsing.p_char / unexpected end of input / s: {:?}",
                    (v1_1.clone(), v2, v3)
                ))
            } else {
                let v7: char = getCharAt(v0_1.clone(), 0_i32);
                if v7 == '`' {
                    let v15: string =
                        getSlice(v0_1.clone(), Some(1_i32), Some(length(v0_1.clone())));
                    let v17: string = ofChar(v7);
                    let v18: i32 = length(v17.clone());
                    let v19: Array<char> = new_init(&'\u{0000}', v18);
                    let v20: LrcPtr<Documents::Mut5> = LrcPtr::new(Documents::Mut5 {
                        l0: MutCell::new(0_i32),
                    });
                    while Documents::method30(v18, v20.clone()) {
                        let v22: i32 = v20.l0.get().clone();
                        let v23: char = getCharAt(v17.clone(), v22);
                        v19.get_mut()[v22 as usize] = v23;
                        {
                            let v24: i32 = v22 + 1_i32;
                            v20.l0.set(v24);
                            ()
                        }
                    }
                    {
                        let v26: List<char> = ofArray(v19.clone());
                        let patternInput: (LrcPtr<StringBuilder>, i32, i32) = Documents::method50(
                            foldBack(
                                Func2::new(move |b0: char, b1: LrcPtr<Documents::UH0>| {
                                    (Documents::method45())(b0)(b1)
                                }),
                                v26,
                                LrcPtr::new(Documents::UH0::UH0_0),
                            ),
                            v1_1.clone(),
                            v2,
                            v3,
                        );
                        Documents::US14::US14_0(
                            v7,
                            v15,
                            patternInput.0.clone(),
                            patternInput.1.clone(),
                            patternInput.2.clone(),
                        )
                    }
                } else {
                    let v38: i32 = length(v0_1.clone());
                    let v41: i32 = indexOf(v0_1.clone(), string("\n")) - 1_i32;
                    Documents::US14::US14_1(sprintf!(
                        "{}\n{}\n",
                        sprintf!(
                            "parsing.p_char / expected: \'{}\' / line: {} / col: {}\n{}{}",
                            '`',
                            v3,
                            v2,
                            v1_1,
                            getSlice(
                                v0_1,
                                Some(0_i32),
                                Some(if -2_i32 == v41 { v38 } else { v41 })
                            )
                        ),
                        append(replicate(v2 - 1_i32, string(" ")), string("^"))
                    ))
                }
            };
            let v102: Documents::US14 = match &v60 {
                Documents::US14::US14_0(v60_0_0, v60_0_1, v60_0_2, v60_0_3, v60_0_4) => {
                    let v65: i32 = v60_0_4.clone();
                    let v64: i32 = v60_0_3.clone();
                    let v63: LrcPtr<StringBuilder> = v60_0_2.clone();
                    let v62: string = v60_0_1.clone();
                    if string("") == v62.clone() {
                        Documents::US14::US14_1(sprintf!(
                            "parsing.any_char / unexpected end of input / s: {:?}",
                            (v63.clone(), v64, v65)
                        ))
                    } else {
                        let v69: char = getCharAt(v62.clone(), 0_i32);
                        let v76: string = getSlice(v62.clone(), Some(1_i32), Some(length(v62)));
                        let v78: string = ofChar(v69);
                        let v79: i32 = length(v78.clone());
                        let v80: Array<char> = new_init(&'\u{0000}', v79);
                        let v81: LrcPtr<Documents::Mut5> = LrcPtr::new(Documents::Mut5 {
                            l0: MutCell::new(0_i32),
                        });
                        while Documents::method30(v79, v81.clone()) {
                            let v83: i32 = v81.l0.get().clone();
                            let v84: char = getCharAt(v78.clone(), v83);
                            v80.get_mut()[v83 as usize] = v84;
                            {
                                let v85: i32 = v83 + 1_i32;
                                v81.l0.set(v85);
                                ()
                            }
                        }
                        {
                            let v87: List<char> = ofArray(v80.clone());
                            let patternInput_1: (LrcPtr<StringBuilder>, i32, i32) =
                                Documents::method50(
                                    foldBack(
                                        Func2::new(move |b0: char, b1: LrcPtr<Documents::UH0>| {
                                            (Documents::method45())(b0)(b1)
                                        }),
                                        v87,
                                        LrcPtr::new(Documents::UH0::UH0_0),
                                    ),
                                    v63,
                                    v64,
                                    v65,
                                );
                            Documents::US14::US14_0(
                                v69,
                                v76,
                                patternInput_1.0.clone(),
                                patternInput_1.1.clone(),
                                patternInput_1.2.clone(),
                            )
                        }
                    }
                }
                Documents::US14::US14_1(v60_1_0) => Documents::US14::US14_1(v60_1_0.clone()),
            };
            match &v102 {
                Documents::US14::US14_0(v102_0_0, v102_0_1, v102_0_2, v102_0_3, v102_0_4) => {
                    Documents::US16::US16_0(
                        sprintf!("{}{}", '`', v102_0_0.clone()),
                        v102_0_1.clone(),
                        v102_0_2.clone(),
                        v102_0_3.clone(),
                        v102_0_4.clone(),
                    )
                }
                Documents::US14::US14_1(v102_1_0) => Documents::US16::US16_1(v102_1_0.clone()),
            }
        }
        pub fn method54(
            v0_1: string,
            v1_1: LrcPtr<StringBuilder>,
            v2: i32,
            v3: i32,
            v4: LrcPtr<Documents::UH2>,
        ) -> Documents::US16 {
            let v0_1: MutCell<string> = MutCell::new(v0_1.clone());
            let v1_1: MutCell<LrcPtr<StringBuilder>> = MutCell::new(v1_1.clone());
            let v2: MutCell<i32> = MutCell::new(v2);
            let v3: MutCell<i32> = MutCell::new(v3);
            let v4: MutCell<LrcPtr<Documents::UH2>> = MutCell::new(v4.clone());
            '_method54: loop {
                break '_method54 (match v4.get().clone().as_ref() {
                    Documents::UH2::UH2_0 => {
                        Documents::US16::US16_1(string("choice / no parsers succeeded"))
                    }
                    Documents::UH2::UH2_1(v4_1_0, v4_1_1) => {
                        let v9: Documents::US16 = (match v4.get().clone().as_ref() {
                            Documents::UH2::UH2_1(x, _) => x.clone(),
                            _ => unreachable!(),
                        })((
                            v0_1.get().clone(),
                            v1_1.get().clone(),
                            v2.get().clone(),
                            v3.get().clone(),
                        ));
                        match &v9 {
                            Documents::US16::US16_0(v9_0_0, v9_0_1, v9_0_2, v9_0_3, v9_0_4) => {
                                v9.clone()
                            }
                            _ => {
                                let v0_1_temp: string = v0_1.get().clone();
                                let v1_1_temp: LrcPtr<StringBuilder> = v1_1.get().clone();
                                let v2_temp: i32 = v2.get().clone();
                                let v3_temp: i32 = v3.get().clone();
                                let v4_temp: LrcPtr<Documents::UH2> =
                                    match v4.get().clone().as_ref() {
                                        Documents::UH2::UH2_1(_, x) => x.clone(),
                                        _ => unreachable!(),
                                    };
                                v0_1.set(v0_1_temp);
                                v1_1.set(v1_1_temp);
                                v2.set(v2_temp);
                                v3.set(v3_temp);
                                v4.set(v4_temp);
                                continue '_method54;
                            }
                        }
                    }
                });
            }
        }
        pub fn method55(
            v0_1: LrcPtr<Documents::UH1>,
            v1_1: LrcPtr<Documents::UH1>,
        ) -> LrcPtr<Documents::UH1> {
            let v0_1: MutCell<LrcPtr<Documents::UH1>> = MutCell::new(v0_1.clone());
            let v1_1: MutCell<LrcPtr<Documents::UH1>> = MutCell::new(v1_1.clone());
            '_method55: loop {
                break '_method55 (match v0_1.get().clone().as_ref() {
                    Documents::UH1::UH1_0 => v1_1.get().clone(),
                    Documents::UH1::UH1_1(v0_1_1_0, v0_1_1_1) => {
                        let v0_1_temp: LrcPtr<Documents::UH1> = match v0_1.get().clone().as_ref() {
                            Documents::UH1::UH1_1(_, x) => x.clone(),
                            _ => unreachable!(),
                        };
                        let v1_1_temp: LrcPtr<Documents::UH1> = LrcPtr::new(Documents::UH1::UH1_1(
                            match v0_1.get().clone().as_ref() {
                                Documents::UH1::UH1_1(x, _) => x.clone(),
                                _ => unreachable!(),
                            },
                            v1_1.get().clone(),
                        ));
                        v0_1.set(v0_1_temp);
                        v1_1.set(v1_1_temp);
                        continue '_method55;
                    }
                });
            }
        }
        pub fn method52(
            v0_1: LrcPtr<Documents::UH1>,
            v1_1: string,
            v2: LrcPtr<StringBuilder>,
            v3: i32,
            v4: i32,
        ) -> Documents::US13 {
            let v0_1: MutCell<LrcPtr<Documents::UH1>> = MutCell::new(v0_1.clone());
            let v1_1: MutCell<string> = MutCell::new(v1_1.clone());
            let v2: MutCell<LrcPtr<StringBuilder>> = MutCell::new(v2.clone());
            let v3: MutCell<i32> = MutCell::new(v3);
            let v4: MutCell<i32> = MutCell::new(v4);
            '_method52: loop {
                break '_method52 ({
                    let v55: Documents::US14 = if string("") == v1_1.get().clone() {
                        Documents::US14::US14_1(sprintf!(
                            "parsing.none_of / unexpected end of input / chars: {:?} / s: {:?}",
                            toArray_1(ofArray(new_array(&['\\', '`', '\"']))),
                            (v2.get().clone(), v3.get().clone(), v4.get().clone())
                        ))
                    } else {
                        let v14: char = getCharAt(v1_1.get().clone(), 0_i32);
                        let v21: string = getSlice(
                            v1_1.get().clone(),
                            Some(1_i32),
                            Some(length(v1_1.get().clone())),
                        );
                        if Documents::method53(v14, 0_i64) == false {
                            let v26: string = ofChar(v14);
                            let v27: i32 = length(v26.clone());
                            let v28: Array<char> = new_init(&'\u{0000}', v27);
                            let v29: LrcPtr<Documents::Mut5> = LrcPtr::new(Documents::Mut5 {
                                l0: MutCell::new(0_i32),
                            });
                            while Documents::method30(v27, v29.clone()) {
                                let v31: i32 = v29.l0.get().clone();
                                let v32: char = getCharAt(v26.clone(), v31);
                                v28.get_mut()[v31 as usize] = v32;
                                {
                                    let v33: i32 = v31 + 1_i32;
                                    v29.l0.set(v33);
                                    ()
                                }
                            }
                            {
                                let v35: List<char> = ofArray(v28.clone());
                                let patternInput: (LrcPtr<StringBuilder>, i32, i32) =
                                    Documents::method50(
                                        foldBack(
                                            Func2::new(
                                                move |b0: char, b1: LrcPtr<Documents::UH0>| {
                                                    (Documents::method45())(b0)(b1)
                                                },
                                            ),
                                            v35,
                                            LrcPtr::new(Documents::UH0::UH0_0),
                                        ),
                                        v2.get().clone(),
                                        v3.get().clone(),
                                        v4.get().clone(),
                                    );
                                Documents::US14::US14_0(
                                    v14,
                                    v21,
                                    patternInput.0.clone(),
                                    patternInput.1.clone(),
                                    patternInput.2.clone(),
                                )
                            }
                        } else {
                            Documents::US14::US14_1(sprintf!(
                                "parsing.none_of / unexpected char: \'{}\' / chars: {:?} / s: {:?}",
                                v14,
                                toArray_1(ofArray(new_array(&['\\', '`', '\"']))),
                                (v2.get().clone(), v3.get().clone(), v4.get().clone())
                            ))
                        }
                    };
                    let v67: Documents::US16 = match &v55 {
                        Documents::US14::US14_0(v55_0_0, v55_0_1, v55_0_2, v55_0_3, v55_0_4) => {
                            Documents::US16::US16_0(
                                ofChar(v55_0_0.clone()),
                                v55_0_1.clone(),
                                v55_0_2.clone(),
                                v55_0_3.clone(),
                                v55_0_4.clone(),
                            )
                        }
                        Documents::US14::US14_1(v55_1_0) => {
                            Documents::US16::US16_1(v55_1_0.clone())
                        }
                    };
                    let v81: Documents::US16 = match &v67 {
                        Documents::US16::US16_0(v67_0_0, v67_0_1, v67_0_2, v67_0_3, v67_0_4) => {
                            v67.clone()
                        }
                        _ => Documents::method54(
                            v1_1.get().clone(),
                            v2.get().clone(),
                            v3.get().clone(),
                            v4.get().clone(),
                            LrcPtr::new(Documents::UH2::UH2_1(
                                Func1::new(
                                    move |arg10_0040: (string, LrcPtr<StringBuilder>, i32, i32)| {
                                        Documents::closure25((), arg10_0040)
                                    },
                                ),
                                LrcPtr::new(Documents::UH2::UH2_1(
                                    Func1::new(
                                        move |arg10_0040_1: (
                                            string,
                                            LrcPtr<StringBuilder>,
                                            i32,
                                            i32,
                                        )| {
                                            Documents::closure26((), arg10_0040_1)
                                        },
                                    ),
                                    LrcPtr::new(Documents::UH2::UH2_0),
                                )),
                            )),
                        ),
                    };
                    match &v81 {
                        Documents::US16::US16_0(v81_0_0, v81_0_1, v81_0_2, v81_0_3, v81_0_4) => {
                            let v0_1_temp: LrcPtr<Documents::UH1> = LrcPtr::new(
                                Documents::UH1::UH1_1(v81_0_0.clone(), v0_1.get().clone()),
                            );
                            let v1_1_temp: string = v81_0_1.clone();
                            let v2_temp: LrcPtr<StringBuilder> = v81_0_2.clone();
                            let v3_temp: i32 = v81_0_3.clone();
                            let v4_temp: i32 = v81_0_4.clone();
                            v0_1.set(v0_1_temp);
                            v1_1.set(v1_1_temp);
                            v2.set(v2_temp);
                            v3.set(v3_temp);
                            v4.set(v4_temp);
                            continue '_method52;
                        }
                        _ => Documents::US13::US13_0(
                            Documents::method55(
                                v0_1.get().clone(),
                                LrcPtr::new(Documents::UH1::UH1_0),
                            ),
                            v1_1.get().clone(),
                            v2.get().clone(),
                            v3.get().clone(),
                            v4.get().clone(),
                        ),
                    }
                });
            }
        }
        pub fn method56(v0_1: LrcPtr<Documents::UH1>, v1_1: List<string>) -> List<string> {
            match v0_1.as_ref() {
                Documents::UH1::UH1_0 => v1_1.clone(),
                Documents::UH1::UH1_1(v0_1_1_0, v0_1_1_1) => cons(
                    match v0_1.as_ref() {
                        Documents::UH1::UH1_1(x, _) => x.clone(),
                        _ => unreachable!(),
                    },
                    Documents::method56(
                        match v0_1.as_ref() {
                            Documents::UH1::UH1_1(_, x) => x.clone(),
                            _ => unreachable!(),
                        },
                        v1_1.clone(),
                    ),
                ),
            }
        }
        pub fn method57(
            v0_1: LrcPtr<Documents::UH1>,
            v1_1: string,
            v2: LrcPtr<StringBuilder>,
            v3: i32,
            v4: i32,
        ) -> Documents::US13 {
            let v0_1: MutCell<LrcPtr<Documents::UH1>> = MutCell::new(v0_1.clone());
            let v1_1: MutCell<string> = MutCell::new(v1_1.clone());
            let v2: MutCell<LrcPtr<StringBuilder>> = MutCell::new(v2.clone());
            let v3: MutCell<i32> = MutCell::new(v3);
            let v4: MutCell<i32> = MutCell::new(v4);
            '_method57: loop {
                break '_method57 ({
                    let v55: Documents::US14 = if string("") == v1_1.get().clone() {
                        Documents::US14::US14_1(sprintf!(
                            "parsing.none_of / unexpected end of input / chars: {:?} / s: {:?}",
                            toArray_1(ofArray(new_array(&['\\', '`', '\"']))),
                            (v2.get().clone(), v3.get().clone(), v4.get().clone())
                        ))
                    } else {
                        let v14: char = getCharAt(v1_1.get().clone(), 0_i32);
                        let v21: string = getSlice(
                            v1_1.get().clone(),
                            Some(1_i32),
                            Some(length(v1_1.get().clone())),
                        );
                        if Documents::method53(v14, 0_i64) == false {
                            let v26: string = ofChar(v14);
                            let v27: i32 = length(v26.clone());
                            let v28: Array<char> = new_init(&'\u{0000}', v27);
                            let v29: LrcPtr<Documents::Mut5> = LrcPtr::new(Documents::Mut5 {
                                l0: MutCell::new(0_i32),
                            });
                            while Documents::method30(v27, v29.clone()) {
                                let v31: i32 = v29.l0.get().clone();
                                let v32: char = getCharAt(v26.clone(), v31);
                                v28.get_mut()[v31 as usize] = v32;
                                {
                                    let v33: i32 = v31 + 1_i32;
                                    v29.l0.set(v33);
                                    ()
                                }
                            }
                            {
                                let v35: List<char> = ofArray(v28.clone());
                                let patternInput: (LrcPtr<StringBuilder>, i32, i32) =
                                    Documents::method50(
                                        foldBack(
                                            Func2::new(
                                                move |b0: char, b1: LrcPtr<Documents::UH0>| {
                                                    (Documents::method45())(b0)(b1)
                                                },
                                            ),
                                            v35,
                                            LrcPtr::new(Documents::UH0::UH0_0),
                                        ),
                                        v2.get().clone(),
                                        v3.get().clone(),
                                        v4.get().clone(),
                                    );
                                Documents::US14::US14_0(
                                    v14,
                                    v21,
                                    patternInput.0.clone(),
                                    patternInput.1.clone(),
                                    patternInput.2.clone(),
                                )
                            }
                        } else {
                            Documents::US14::US14_1(sprintf!(
                                "parsing.none_of / unexpected char: \'{}\' / chars: {:?} / s: {:?}",
                                v14,
                                toArray_1(ofArray(new_array(&['\\', '`', '\"']))),
                                (v2.get().clone(), v3.get().clone(), v4.get().clone())
                            ))
                        }
                    };
                    let v67: Documents::US16 = match &v55 {
                        Documents::US14::US14_0(v55_0_0, v55_0_1, v55_0_2, v55_0_3, v55_0_4) => {
                            Documents::US16::US16_0(
                                ofChar(v55_0_0.clone()),
                                v55_0_1.clone(),
                                v55_0_2.clone(),
                                v55_0_3.clone(),
                                v55_0_4.clone(),
                            )
                        }
                        Documents::US14::US14_1(v55_1_0) => {
                            Documents::US16::US16_1(v55_1_0.clone())
                        }
                    };
                    match &v67 {
                        Documents::US16::US16_0(v67_0_0, v67_0_1, v67_0_2, v67_0_3, v67_0_4) => {
                            let v0_1_temp: LrcPtr<Documents::UH1> = LrcPtr::new(
                                Documents::UH1::UH1_1(v67_0_0.clone(), v0_1.get().clone()),
                            );
                            let v1_1_temp: string = v67_0_1.clone();
                            let v2_temp: LrcPtr<StringBuilder> = v67_0_2.clone();
                            let v3_temp: i32 = v67_0_3.clone();
                            let v4_temp: i32 = v67_0_4.clone();
                            v0_1.set(v0_1_temp);
                            v1_1.set(v1_1_temp);
                            v2.set(v2_temp);
                            v3.set(v3_temp);
                            v4.set(v4_temp);
                            continue '_method57;
                        }
                        _ => Documents::US13::US13_0(
                            Documents::method55(
                                v0_1.get().clone(),
                                LrcPtr::new(Documents::UH1::UH1_0),
                            ),
                            v1_1.get().clone(),
                            v2.get().clone(),
                            v3.get().clone(),
                            v4.get().clone(),
                        ),
                    }
                });
            }
        }
        pub fn method58(v0_1: string, v1_1: i32) -> i32 {
            let v0_1: MutCell<string> = MutCell::new(v0_1.clone());
            let v1_1: MutCell<i32> = MutCell::new(v1_1);
            '_method58: loop {
                break '_method58 (if v1_1.get().clone() >= length(v0_1.get().clone()) {
                    v1_1.get().clone()
                } else {
                    if getCharAt(v0_1.get().clone(), v1_1.get().clone()) == ' ' {
                        let v0_1_temp: string = v0_1.get().clone();
                        let v1_1_temp: i32 = v1_1.get().clone() + 1_i32;
                        v0_1.set(v0_1_temp);
                        v1_1.set(v1_1_temp);
                        continue '_method58;
                    } else {
                        v1_1.get().clone()
                    }
                });
            }
        }
        pub fn method48(
            v0_1: LrcPtr<Documents::UH1>,
            v1_1: string,
            v2: LrcPtr<StringBuilder>,
            v3: i32,
            v4: i32,
        ) -> Documents::US13 {
            let v0_1: MutCell<LrcPtr<Documents::UH1>> = MutCell::new(v0_1.clone());
            let v1_1: MutCell<string> = MutCell::new(v1_1.clone());
            let v2: MutCell<LrcPtr<StringBuilder>> = MutCell::new(v2.clone());
            let v3: MutCell<i32> = MutCell::new(v3);
            let v4: MutCell<i32> = MutCell::new(v4);
            '_method48: loop {
                break '_method48 ({
                    let v5: bool = string("") == v1_1.get().clone();
                    let v57: Documents::US14 = if v5 {
                        Documents::US14::US14_1(sprintf!(
                            "parsing.none_of / unexpected end of input / chars: {:?} / s: {:?}",
                            toArray_1(ofArray(new_array(&['\\', '`', '\"', ' ']))),
                            (v2.get().clone(), v3.get().clone(), v4.get().clone())
                        ))
                    } else {
                        let v15: char = getCharAt(v1_1.get().clone(), 0_i32);
                        let v22: string = getSlice(
                            v1_1.get().clone(),
                            Some(1_i32),
                            Some(length(v1_1.get().clone())),
                        );
                        if Documents::method49(v15, 0_i64) == false {
                            let v27: string = ofChar(v15);
                            let v28: i32 = length(v27.clone());
                            let v29: Array<char> = new_init(&'\u{0000}', v28);
                            let v30: LrcPtr<Documents::Mut5> = LrcPtr::new(Documents::Mut5 {
                                l0: MutCell::new(0_i32),
                            });
                            while Documents::method30(v28, v30.clone()) {
                                let v32: i32 = v30.l0.get().clone();
                                let v33: char = getCharAt(v27.clone(), v32);
                                v29.get_mut()[v32 as usize] = v33;
                                {
                                    let v34: i32 = v32 + 1_i32;
                                    v30.l0.set(v34);
                                    ()
                                }
                            }
                            {
                                let v36: List<char> = ofArray(v29.clone());
                                let patternInput: (LrcPtr<StringBuilder>, i32, i32) =
                                    Documents::method50(
                                        foldBack(
                                            Func2::new(
                                                move |b0: char, b1: LrcPtr<Documents::UH0>| {
                                                    (Documents::method45())(b0)(b1)
                                                },
                                            ),
                                            v36,
                                            LrcPtr::new(Documents::UH0::UH0_0),
                                        ),
                                        v2.get().clone(),
                                        v3.get().clone(),
                                        v4.get().clone(),
                                    );
                                Documents::US14::US14_0(
                                    v15,
                                    v22,
                                    patternInput.0.clone(),
                                    patternInput.1.clone(),
                                    patternInput.2.clone(),
                                )
                            }
                        } else {
                            Documents::US14::US14_1(sprintf!(
                                "parsing.none_of / unexpected char: \'{}\' / chars: {:?} / s: {:?}",
                                v15,
                                toArray_1(ofArray(new_array(&['\\', '`', '\"', ' ']))),
                                (v2.get().clone(), v3.get().clone(), v4.get().clone())
                            ))
                        }
                    };
                    let v69: Documents::US16 = match &v57 {
                        Documents::US14::US14_0(v57_0_0, v57_0_1, v57_0_2, v57_0_3, v57_0_4) => {
                            Documents::method51(
                                ofChar(v57_0_0.clone()),
                                v57_0_1.clone(),
                                v57_0_2.clone(),
                                v57_0_3.clone(),
                                v57_0_4.clone(),
                            )
                        }
                        Documents::US14::US14_1(v57_1_0) => {
                            Documents::US16::US16_1(v57_1_0.clone())
                        }
                    };
                    let v292: Documents::US16 = match &v69 {
                        Documents::US16::US16_0(v69_0_0, v69_0_1, v69_0_2, v69_0_3, v69_0_4) => {
                            v69.clone()
                        }
                        _ => {
                            let v131: Documents::US14 = if v5 {
                                Documents::US14::US14_1(sprintf!(
                                    "parsing.p_char / unexpected end of input / s: {:?}",
                                    (v2.get().clone(), v3.get().clone(), v4.get().clone())
                                ))
                            } else {
                                let v78: char = getCharAt(v1_1.get().clone(), 0_i32);
                                if v78 == '\"' {
                                    let v86: string = getSlice(
                                        v1_1.get().clone(),
                                        Some(1_i32),
                                        Some(length(v1_1.get().clone())),
                                    );
                                    let v88: string = ofChar(v78);
                                    let v89: i32 = length(v88.clone());
                                    let v90: Array<char> = new_init(&'\u{0000}', v89);
                                    let v91: LrcPtr<Documents::Mut5> =
                                        LrcPtr::new(Documents::Mut5 {
                                            l0: MutCell::new(0_i32),
                                        });
                                    while Documents::method30(v89, v91.clone()) {
                                        let v93: i32 = v91.l0.get().clone();
                                        let v94: char = getCharAt(v88.clone(), v93);
                                        v90.get_mut()[v93 as usize] = v94;
                                        {
                                            let v95: i32 = v93 + 1_i32;
                                            v91.l0.set(v95);
                                            ()
                                        }
                                    }
                                    {
                                        let v97: List<char> = ofArray(v90.clone());
                                        let patternInput_1:
                                                                 (LrcPtr<StringBuilder>,
                                                                  i32, i32) =
                                                             Documents::method50(foldBack(Func2::new(move
                                                                                                         |b0:
                                                                                                              char,
                                                                                                          b1:
                                                                                                              LrcPtr<Documents::UH0>|
                                                                                                         (Documents::method45())(b0)(b1)),
                                                                                          v97,
                                                                                          LrcPtr::new(Documents::UH0::UH0_0)),
                                                                                 v2.get().clone(),
                                                                                 v3.get().clone(),
                                                                                 v4.get().clone());
                                        Documents::US14::US14_0(
                                            v78,
                                            v86,
                                            patternInput_1.0.clone(),
                                            patternInput_1.1.clone(),
                                            patternInput_1.2.clone(),
                                        )
                                    }
                                } else {
                                    let v109: i32 = length(v1_1.get().clone());
                                    let v112: i32 =
                                        indexOf(v1_1.get().clone(), string("\n")) - 1_i32;
                                    Documents::US14::US14_1(sprintf!("{}\n{}\n",
                                                                                      sprintf!("parsing.p_char / expected: \'{}\' / line: {} / col: {}\n{}{}",
                                                                                               '\"',
                                                                                               v4.get().clone(),
                                                                                               v3.get().clone(),
                                                                                               v2.get().clone(),
                                                                                               getSlice(v1_1.get().clone(),
                                                                                                        Some(0_i32),
                                                                                                        Some(if -2_i32
                                                                                                                    ==
                                                                                                                    v112
                                                                                                                {
                                                                                                                 v109
                                                                                                             } else {
                                                                                                                 v112
                                                                                                             }))),
                                                                                      append(replicate(v3.get().clone()
                                                                                                           -
                                                                                                           1_i32,
                                                                                                       string(" ")),
                                                                                             string("^"))))
                                }
                            };
                            let v237: Documents::US16 = match &v131 {
                                Documents::US14::US14_0(
                                    v131_0_0,
                                    v131_0_1,
                                    v131_0_2,
                                    v131_0_3,
                                    v131_0_4,
                                ) => {
                                    let v136: i32 = v131_0_4.clone();
                                    let v135: i32 = v131_0_3.clone();
                                    let v134: LrcPtr<StringBuilder> = v131_0_2.clone();
                                    let v133: string = v131_0_1.clone();
                                    let v138: Documents::US13 = Documents::method52(
                                        LrcPtr::new(Documents::UH1::UH1_0),
                                        v133.clone(),
                                        v134.clone(),
                                        v135,
                                        v136,
                                    );
                                    let v155: Documents::US16 = match &v138 {
                                        Documents::US13::US13_0(
                                            v138_0_0,
                                            v138_0_1,
                                            v138_0_2,
                                            v138_0_3,
                                            v138_0_4,
                                        ) => {
                                            let v145: List<string> = Documents::method56(
                                                v138_0_0.clone(),
                                                empty::<string>(),
                                            );
                                            Documents::US16::US16_0(
                                                join(
                                                    string(""),
                                                    toArray(delay(Func0::new({
                                                        let v145 = v145.clone();
                                                        move || {
                                                            map(
                                                                Func1::new({
                                                                    let v145 = v145.clone();
                                                                    move |i: i32| {
                                                                        item(i, v145.clone())
                                                                    }
                                                                }),
                                                                rangeNumeric(
                                                                    0_i32,
                                                                    1_i32,
                                                                    length_1(v145.clone()) - 1_i32,
                                                                ),
                                                            )
                                                        }
                                                    }))),
                                                ),
                                                v138_0_1.clone(),
                                                v138_0_2.clone(),
                                                v138_0_3.clone(),
                                                v138_0_4.clone(),
                                            )
                                        }
                                        Documents::US13::US13_1(v138_1_0) => {
                                            Documents::US16::US16_1(v138_1_0.clone())
                                        }
                                    };
                                    match &v155 {
                                        Documents::US16::US16_0(
                                            v155_0_0,
                                            v155_0_1,
                                            v155_0_2,
                                            v155_0_3,
                                            v155_0_4,
                                        ) => {
                                            let v160: i32 = v155_0_4.clone();
                                            let v159: i32 = v155_0_3.clone();
                                            let v158: LrcPtr<StringBuilder> = v155_0_2.clone();
                                            let v157: string = v155_0_1.clone();
                                            let v217: Documents::US14 = if string("")
                                                == v157.clone()
                                            {
                                                Documents::US14::US14_1(sprintf!("parsing.p_char / unexpected end of input / s: {:?}",
                                                                                                      (v158.clone(),
                                                                                                       v159,
                                                                                                       v160)))
                                            } else {
                                                let v164: char = getCharAt(v157.clone(), 0_i32);
                                                if v164 == '\"' {
                                                    let v172: string = getSlice(
                                                        v157.clone(),
                                                        Some(1_i32),
                                                        Some(length(v157.clone())),
                                                    );
                                                    let v174: string = ofChar(v164);
                                                    let v175: i32 = length(v174.clone());
                                                    let v176: Array<char> =
                                                        new_init(&'\u{0000}', v175);
                                                    let v177: LrcPtr<Documents::Mut5> =
                                                        LrcPtr::new(Documents::Mut5 {
                                                            l0: MutCell::new(0_i32),
                                                        });
                                                    while Documents::method30(v175, v177.clone()) {
                                                        let v179: i32 = v177.l0.get().clone();
                                                        let v180: char =
                                                            getCharAt(v174.clone(), v179);
                                                        v176.get_mut()[v179 as usize] = v180;
                                                        {
                                                            let v181: i32 = v179 + 1_i32;
                                                            v177.l0.set(v181);
                                                            ()
                                                        }
                                                    }
                                                    {
                                                        let v183: List<char> =
                                                            ofArray(v176.clone());
                                                        let patternInput_2:
                                                                                     (LrcPtr<StringBuilder>,
                                                                                      i32,
                                                                                      i32) =
                                                                                 Documents::method50(foldBack(Func2::new(move
                                                                                                                             |b0:
                                                                                                                                  char,
                                                                                                                              b1:
                                                                                                                                  LrcPtr<Documents::UH0>|
                                                                                                                             (Documents::method45())(b0)(b1)),
                                                                                                              v183,
                                                                                                              LrcPtr::new(Documents::UH0::UH0_0)),
                                                                                                     v158.clone(),
                                                                                                     v159,
                                                                                                     v160);
                                                        Documents::US14::US14_0(
                                                            v164,
                                                            v172,
                                                            patternInput_2.0.clone(),
                                                            patternInput_2.1.clone(),
                                                            patternInput_2.2.clone(),
                                                        )
                                                    }
                                                } else {
                                                    let v195: i32 = length(v157.clone());
                                                    let v198: i32 =
                                                        indexOf(v157.clone(), string("\n")) - 1_i32;
                                                    Documents::US14::US14_1(sprintf!("{}\n{}\n",
                                                                                                          sprintf!("parsing.p_char / expected: \'{}\' / line: {} / col: {}\n{}{}",
                                                                                                                   '\"',
                                                                                                                   v160,
                                                                                                                   v159,
                                                                                                                   v158.clone(),
                                                                                                                   getSlice(v157.clone(),
                                                                                                                            Some(0_i32),
                                                                                                                            Some(if -2_i32
                                                                                                                                        ==
                                                                                                                                        v198
                                                                                                                                    {
                                                                                                                                     v195
                                                                                                                                 } else {
                                                                                                                                     v198
                                                                                                                                 }))),
                                                                                                          append(replicate(v159
                                                                                                                               -
                                                                                                                               1_i32,
                                                                                                                           string(" ")),
                                                                                                                 string("^"))))
                                                }
                                            };
                                            match &v217 {
                                                                 Documents::US14::US14_0(v217_0_0,
                                                                                         v217_0_1,
                                                                                         v217_0_2,
                                                                                         v217_0_3,
                                                                                         v217_0_4)
                                                                 =>
                                                                 Documents::US16::US16_0(v155_0_0.clone(),
                                                                                         v217_0_1.clone(),
                                                                                         v217_0_2.clone(),
                                                                                         v217_0_3.clone(),
                                                                                         v217_0_4.clone()),
                                                                 Documents::US14::US14_1(v217_1_0)
                                                                 =>
                                                                 Documents::US16::US16_1(sprintf!("between / expected closing delimiter / e: {:?} / input: {:?} / rest1: {:?} / rest2: {:?}",
                                                                                                  v217_1_0.clone(),
                                                                                                  (v1_1.get().clone(),
                                                                                                   v2.get().clone(),
                                                                                                   v3.get().clone(),
                                                                                                   v4.get().clone()),
                                                                                                  (v133,
                                                                                                   v134,
                                                                                                   v135,
                                                                                                   v136),
                                                                                                  (v157,
                                                                                                   v158,
                                                                                                   v159,
                                                                                                   v160))),
                                                             }
                                        }
                                        _ => Documents::US16::US16_1(string(
                                            "between / expected content",
                                        )),
                                    }
                                }
                                Documents::US14::US14_1(v131_1_0) => {
                                    Documents::US16::US16_1(v131_1_0.clone())
                                }
                            };
                            match &v237 {
                                Documents::US16::US16_0(
                                    v237_0_0,
                                    v237_0_1,
                                    v237_0_2,
                                    v237_0_3,
                                    v237_0_4,
                                ) => v237.clone(),
                                _ => {
                                    let v249: Documents::US16 =
                                                     Documents::method54(v1_1.get().clone(),
                                                                         v2.get().clone(),
                                                                         v3.get().clone(),
                                                                         v4.get().clone(),
                                                                         LrcPtr::new(Documents::UH2::UH2_1(Func1::new(move
                                                                                                                          |arg10_0040:
                                                                                                                               (string,
                                                                                                                                LrcPtr<StringBuilder>,
                                                                                                                                i32,
                                                                                                                                i32)|
                                                                                                                          Documents::closure25((),
                                                                                                                                               arg10_0040)),
                                                                                                           LrcPtr::new(Documents::UH2::UH2_1(Func1::new(move
                                                                                                                                                            |arg10_0040_1:
                                                                                                                                                                 (string,
                                                                                                                                                                  LrcPtr<StringBuilder>,
                                                                                                                                                                  i32,
                                                                                                                                                                  i32)|
                                                                                                                                                            Documents::closure26((),
                                                                                                                                                                                 arg10_0040_1)),
                                                                                                                                             LrcPtr::new(Documents::UH2::UH2_0))))));
                                    let v260: Documents::US16 = match &v249 {
                                        Documents::US16::US16_0(
                                            v249_0_0,
                                            v249_0_1,
                                            v249_0_2,
                                            v249_0_3,
                                            v249_0_4,
                                        ) => Documents::US16::US16_0(
                                            string(""),
                                            v249_0_1.clone(),
                                            v249_0_2.clone(),
                                            v249_0_3.clone(),
                                            v249_0_4.clone(),
                                        ),
                                        Documents::US16::US16_1(v249_1_0) => {
                                            Documents::US16::US16_1(v249_1_0.clone())
                                        }
                                    };
                                    let v271: Documents::US13 = match &v260 {
                                        Documents::US16::US16_0(
                                            v260_0_0,
                                            v260_0_1,
                                            v260_0_2,
                                            v260_0_3,
                                            v260_0_4,
                                        ) => Documents::method57(
                                            LrcPtr::new(Documents::UH1::UH1_0),
                                            v260_0_1.clone(),
                                            v260_0_2.clone(),
                                            v260_0_3.clone(),
                                            v260_0_4.clone(),
                                        ),
                                        Documents::US16::US16_1(v260_1_0) => {
                                            Documents::US13::US13_1(v260_1_0.clone())
                                        }
                                    };
                                    match &v271 {
                                        Documents::US13::US13_0(
                                            v271_0_0,
                                            v271_0_1,
                                            v271_0_2,
                                            v271_0_3,
                                            v271_0_4,
                                        ) => {
                                            let v278: List<string> = Documents::method56(
                                                v271_0_0.clone(),
                                                empty::<string>(),
                                            );
                                            Documents::US16::US16_0(
                                                join(
                                                    string(""),
                                                    toArray(delay(Func0::new({
                                                        let v278 = v278.clone();
                                                        move || {
                                                            map(
                                                                Func1::new({
                                                                    let v278 = v278.clone();
                                                                    move |i_1: i32| {
                                                                        item(i_1, v278.clone())
                                                                    }
                                                                }),
                                                                rangeNumeric(
                                                                    0_i32,
                                                                    1_i32,
                                                                    length_1(v278.clone()) - 1_i32,
                                                                ),
                                                            )
                                                        }
                                                    }))),
                                                ),
                                                v271_0_1.clone(),
                                                v271_0_2.clone(),
                                                v271_0_3.clone(),
                                                v271_0_4.clone(),
                                            )
                                        }
                                        Documents::US13::US13_1(v271_1_0) => {
                                            Documents::US16::US16_1(v271_1_0.clone())
                                        }
                                    }
                                }
                            }
                        }
                    };
                    match &v292 {
                        Documents::US16::US16_0(
                            v292_0_0,
                            v292_0_1,
                            v292_0_2,
                            v292_0_3,
                            v292_0_4,
                        ) => {
                            let v301: i32 = v292_0_4.clone();
                            let v300: i32 = v292_0_3.clone();
                            let v299: LrcPtr<StringBuilder> = v292_0_2.clone();
                            let v298: string = v292_0_1.clone();
                            let v297: string = v292_0_0.clone();
                            let v303: i32 = Documents::method58(v298.clone(), 0_i32);
                            let v315: Documents::US17 = if 0_i32 == v303 {
                                Documents::US17::US17_1(string(
                                    "spaces1 / expected at least one space",
                                ))
                            } else {
                                Documents::US17::US17_0(
                                    getSlice(v298.clone(), Some(v303), Some(length(v298.clone()))),
                                    v299.clone(),
                                    v300,
                                    v301,
                                )
                            };
                            match &v315 {
                                Documents::US17::US17_0(v315_0_0, v315_0_1, v315_0_2, v315_0_3) => {
                                    let v0_1_temp: LrcPtr<Documents::UH1> = LrcPtr::new(
                                        Documents::UH1::UH1_1(v297.clone(), v0_1.get().clone()),
                                    );
                                    let v1_1_temp: string = v315_0_0.clone();
                                    let v2_temp: LrcPtr<StringBuilder> = v315_0_1.clone();
                                    let v3_temp: i32 = v315_0_2.clone();
                                    let v4_temp: i32 = v315_0_3.clone();
                                    v0_1.set(v0_1_temp);
                                    v1_1.set(v1_1_temp);
                                    v2.set(v2_temp);
                                    v3.set(v3_temp);
                                    v4.set(v4_temp);
                                    continue '_method48;
                                }
                                _ => Documents::US13::US13_0(
                                    Documents::method55(
                                        v0_1.get().clone(),
                                        LrcPtr::new(Documents::UH1::UH1_1(
                                            v297.clone(),
                                            LrcPtr::new(Documents::UH1::UH1_0),
                                        )),
                                    ),
                                    v298,
                                    v299,
                                    v300,
                                    v301,
                                ),
                            }
                        }
                        _ => Documents::US13::US13_0(
                            Documents::method55(
                                v0_1.get().clone(),
                                LrcPtr::new(Documents::UH1::UH1_0),
                            ),
                            v1_1.get().clone(),
                            v2.get().clone(),
                            v3.get().clone(),
                            v4.get().clone(),
                        ),
                    }
                });
            }
        }
        pub fn method47(v0_1: string) -> Documents::US12 {
            let _v0: MutCell<Option<Option<string>>> = MutCell::new(None::<Option<string>>);
            _v0.set(Some(Some(v0_1)));
            {
                let v11: Documents::US13 = Documents::method48(
                    LrcPtr::new(Documents::UH1::UH1_0),
                    defaultValue(
                        string(""),
                        match &_v0.get().clone() {
                            None => panic!("{}", string("optionm\'.of_obj / _v0=None"),),
                            Some(_v0_0_0) => _v0_0_0.clone(),
                        },
                    ),
                    StringBuilder::_ctor__Z721C83C5(string("")),
                    1_i32,
                    1_i32,
                );
                let v25: Documents::US18 = match &v11 {
                    Documents::US13::US13_0(v11_0_0, v11_0_1, v11_0_2, v11_0_3, v11_0_4) => {
                        Documents::US18::US18_0(toArray_1(Documents::method56(
                            v11_0_0.clone(),
                            empty::<string>(),
                        )))
                    }
                    Documents::US13::US13_1(v11_1_0) => Documents::US18::US18_1(v11_1_0.clone()),
                };
                match &v25 {
                    Documents::US18::US18_0(v25_0_0) => Documents::US12::US12_0(v25_0_0.clone()),
                    Documents::US18::US18_1(v25_1_0) => Documents::US12::US12_1(v25_1_0.clone()),
                }
            }
        }
        pub fn closure27(unitVar: (), unitVar_1: ()) -> string {
            string("runtime.execute_with_options")
        }
        pub fn closure28(
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
            append(
                sprintf!("file_name: {} / arguments: {:?}", v7, v8),
                sprintf!(
                    " / options: {:?} / {}",
                    (v0_1, v1_1, v2, v3, v4, v5, v6),
                    Documents::closure6((), ())
                ),
            )
        }
        pub fn closure29(
            unitVar: (),
            v0_1: std::sync::Arc<std::sync::Mutex<Option<std::process::Child>>>,
        ) -> Documents::US19 {
            Documents::US19::US19_0(v0_1)
        }
        pub fn method59(
        ) -> Func1<std::sync::Arc<std::sync::Mutex<Option<std::process::Child>>>, Documents::US19>
        {
            Func1::new(
                move |v: std::sync::Arc<std::sync::Mutex<Option<std::process::Child>>>| {
                    Documents::closure29((), v)
                },
            )
        }
        pub fn closure30(unitVar: (), v0_1: std::string::String) -> Documents::US19 {
            Documents::US19::US19_1(v0_1)
        }
        pub fn method60() -> Func1<std::string::String, Documents::US19> {
            Func1::new(move |v: std::string::String| Documents::closure30((), v))
        }
        pub fn closure31(unitVar: (), unitVar_1: ()) -> string {
            string("runtime.execute_with_options / child error")
        }
        pub fn closure32(v0_1: std::string::String, unitVar: ()) -> string {
            sprintf!("error: {} / {}", v0_1, Documents::closure6((), ()))
        }
        pub fn method61(
            v0_1: std::sync::Arc<std::sync::Mutex<Option<std::process::Child>>>,
        ) -> std::sync::Arc<std::sync::Mutex<Option<std::process::Child>>> {
            v0_1
        }
        pub fn closure33(unitVar: (), v0_1: std::string::String) -> Documents::US21 {
            Documents::US21::US21_0(v0_1)
        }
        pub fn method62() -> Func1<std::string::String, Documents::US21> {
            Func1::new(move |v: std::string::String| Documents::closure33((), v))
        }
        pub fn closure34(unitVar: (), v0_1: std::string::String) -> Documents::US21 {
            Documents::US21::US21_1(v0_1)
        }
        pub fn method63() -> Func1<std::string::String, Documents::US21> {
            Func1::new(move |v: std::string::String| Documents::closure34((), v))
        }
        pub fn closure35(unitVar: (), unitVar_1: ()) -> string {
            string("runtime.stdio_line")
        }
        pub fn closure36(v0_1: std::string::String, unitVar: ()) -> string {
            sprintf!("e: {} / {}", v0_1, Documents::closure6((), ()))
        }
        pub fn closure37(v0_1: string, unitVar: ()) -> string {
            v0_1
        }
        pub fn method64(
            v0_1: std::sync::Arc<std::sync::Mutex<std::sync::mpsc::Sender<std::string::String>>>,
        ) -> std::sync::Arc<std::sync::Mutex<std::sync::mpsc::Sender<std::string::String>>>
        {
            v0_1
        }
        pub fn closure38(
            unitVar: (),
            v0_1: std::sync::mpsc::SendError<std::string::String>,
        ) -> std::string::String {
            let _v1: MutCell<Option<std::string::String>> =
                MutCell::new(None::<std::string::String>);
            {
                let x: std::string::String = format!("{}", v0_1);
                _v1.set(Some(x))
            }
            match &_v1.get().clone() {
                None => panic!("{}", string("base.run_target / _v1=None"),),
                Some(_v1_0_0) => _v1_0_0.clone(),
            }
        }
        pub fn method65(
        ) -> Func1<std::sync::mpsc::SendError<std::string::String>, std::string::String> {
            Func1::new(move |v: std::sync::mpsc::SendError<std::string::String>| {
                Documents::closure38((), v)
            })
        }
        pub fn method66(v0_1: Result<(), string>) -> Result<(), string> {
            v0_1
        }
        pub fn method67(
            v0_1: std::sync::Arc<std::sync::Mutex<Option<std::process::ChildStdin>>>,
        ) -> std::sync::Arc<std::sync::Mutex<Option<std::process::ChildStdin>>> {
            v0_1
        }
        pub fn method68(
            v0_1: std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>,
        ) -> std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>> {
            v0_1
        }
        pub fn method69(
            v0_1: std::sync::MutexGuard<std::process::ChildStdin>,
        ) -> std::sync::MutexGuard<std::process::ChildStdin> {
            v0_1
        }
        pub fn method70(
            v0_1: std::thread::JoinHandle<Result<(), string>>,
        ) -> std::thread::JoinHandle<Result<(), string>> {
            v0_1
        }
        pub fn closure39(unitVar: (), v0_1: std::process::Output) -> Documents::US24 {
            Documents::US24::US24_0(v0_1)
        }
        pub fn closure40(unitVar: (), v0_1: std::string::String) -> Documents::US24 {
            Documents::US24::US24_1(v0_1)
        }
        pub fn closure41(unitVar: (), unitVar_1: ()) -> string {
            string("runtime.execute_with_options / output error")
        }
        pub fn closure42(v0_1: std::string::String, unitVar: ()) -> string {
            sprintf!("error: {} / {}", v0_1, Documents::closure6((), ()))
        }
        pub fn method71(
            v0_1: std::sync::Arc<
                std::sync::Mutex<std::sync::Arc<std::sync::mpsc::Receiver<std::string::String>>>,
            >,
        ) -> std::sync::Arc<
            std::sync::Mutex<std::sync::Arc<std::sync::mpsc::Receiver<std::string::String>>>,
        > {
            v0_1
        }
        pub fn closure43(unitVar: (), unitVar_1: ()) -> string {
            string("runtime.execute_with_options / result")
        }
        pub fn closure44(v0_1: i32, v1_1: string, unitVar: ()) -> string {
            append(
                sprintf!("exit_code: {}", v0_1),
                sprintf!(
                    " / std_trace.Length: {} / {}",
                    length(v1_1),
                    Documents::closure6((), ())
                ),
            )
        }
        pub fn closure45(
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
        pub fn method73() -> Func0<string> {
            Func0::new(move || Documents::closure6((), ()))
        }
        pub fn closure47(v0_1: string, unitVar: ()) -> string {
            v0_1
        }
        pub fn closure46(
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
                let v39: Arc<Async<()>> = match &_v10.get().clone() {
                    None => panic!("{}", string("base.run_target / _v10=None"),),
                    Some(_v10_0_0) => _v10_0_0.clone(),
                };
                let _v40: MutCell<Option<()>> = MutCell::new(None::<()>);
                defaultOf::<()>();
                _v40.set(Some(()));
                match &_v40.get().clone() {
                    None => panic!("{}", string("base.run_target / _v40=None"),),
                    Some(_v40_0_0) => _v40_0_0.clone(),
                }
                ()
            }
        }
        pub fn closure48(
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
                let v40: Arc<Async<()>> = match &_v10.get().clone() {
                    None => panic!("{}", string("base.run_target / _v10=None"),),
                    Some(_v10_0_0) => _v10_0_0.clone(),
                };
                let _v41: MutCell<Option<()>> = MutCell::new(None::<()>);
                defaultOf::<()>();
                _v41.set(Some(()));
                match &_v41.get().clone() {
                    None => panic!("{}", string("base.run_target / _v41=None"),),
                    Some(_v41_0_0) => _v41_0_0.clone(),
                }
                ()
            }
        }
        pub fn closure49(v0_1: (), unitVar: ()) {
            let _v1: MutCell<Option<bool>> = MutCell::new(None::<bool>);
            {
                let x: bool = unbox::<bool>(&defaultOf());
                _v1.set(Some(x))
            }
            if match &_v1.get().clone() {
                None => panic!("{}", string("base.run_target / _v1=None"),),
                Some(_v1_0_0) => _v1_0_0.clone(),
            } == false
            {
                let _v10: MutCell<Option<()>> = MutCell::new(None::<()>);
                defaultOf::<()>();
                _v10.set(Some(()));
                match &_v10.get().clone() {
                    None => panic!("{}", string("base.run_target / _v10=None"),),
                    Some(_v10_0_0) => _v10_0_0.clone(),
                }
                ()
            }
        }
        pub fn closure50(v0_1: LrcPtr<TaskCanceledException>, unitVar: ()) -> string {
            sprintf!(
                "execute_with_options_async / WaitForExitAsync / ex: {:?}",
                v0_1
            )
        }
        pub fn closure51(v0_1: i32, v1_1: string, unitVar: ()) -> string {
            sprintf!(
                "execute_with_options_async / exit_code: {} / output.Length: {}",
                v0_1,
                length(v1_1)
            )
        }
        pub fn method72(
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
            match &_v7.get().clone() {
                None => panic!("{}", string("base.run_target / _v7=None"),),
                Some(_v7_0_0) => _v7_0_0.clone(),
            }
        }
        pub fn method41(
            v0_1: Option<CancellationToken>,
            v1_1: string,
            v2: Array<(string, string)>,
            v3: Option<Func1<(bool, string, i32), Arc<Async<()>>>>,
            v4: Option<Func1<std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>, ()>>,
            v5: bool,
            v6: Option<string>,
        ) -> (i32, string) {
            let _v7: MutCell<Option<(i32, string)>> = MutCell::new(None::<(i32, string)>);
            let patternInput: (string, string) = Documents::method43(Documents::method42(
                v0_1.clone(),
                v1_1.clone(),
                v2.clone(),
                v3.clone(),
                v4.clone(),
                v5,
                v6.clone(),
            ));
            let v9: string = patternInput.0.clone();
            let v11: Documents::US12 = Documents::method47(patternInput.1.clone());
            let v17: Array<string> = match &v11 {
                Documents::US12::US12_0(v11_0_0) => v11_0_0.clone(),
                Documents::US12::US12_1(v11_1_0) => panic!(
                    "{}",
                    sprintf!("resultm.get / Result value was Error: {}", v11_1_0.clone()),
                ),
            };
            let v19: Vec<string> = v17.to_vec();
            let v21: bool = true;
            let _result: Vec<_> = v19
                .into_iter()
                .map(|x| {
                    //;
                    let v23: string = x;
                    let v25: &str = &*v23;
                    let v27: std::string::String = String::from(v25);
                    let v29: bool = true;
                    v27
                })
                .collect::<Vec<_>>();
            let v31: Vec<std::string::String> = _result;
            Documents::method5(
                Documents::US0::US0_1,
                Func0::new(move || Documents::closure27((), ())),
                Func0::new({
                    let v0_1 = v0_1.clone();
                    let v1_1 = v1_1.clone();
                    let v2 = v2.clone();
                    let v3 = v3.clone();
                    let v31 = v31.clone();
                    let v4 = v4.clone();
                    let v5 = v5.clone();
                    let v6 = v6.clone();
                    let v9 = v9.clone();
                    move || {
                        Documents::closure28(
                            v0_1.clone(),
                            v1_1.clone(),
                            v2.clone(),
                            v3.clone(),
                            v4.clone(),
                            v5,
                            v6.clone(),
                            v9.clone(),
                            v31.clone(),
                            (),
                        )
                    }
                }),
            );
            {
                let _v35: MutCell<Option<LrcPtr<(i32, string)>>> =
                    MutCell::new(None::<LrcPtr<(i32, string)>>);
                {
                    let x_12: LrcPtr<(i32, string)> = (Func0::new({
                        let v2 = v2.clone();
                        let v31 = v31.clone();
                        let v4 = v4.clone();
                        let v5 = v5.clone();
                        let v6 = v6.clone();
                        let v9 = v9.clone();
                        move || {
                            let v37: std::process::Command =
                                std::process::Command::new(&*v9.clone());
                            let v39: bool = true;
                            let mut v37 = v37;
                            let v41: &mut std::process::Command =
                                std::process::Command::args(&mut v37, &*v31.clone());
                            let v43: std::process::Stdio = std::process::Stdio::piped();
                            let v45: &mut std::process::Command =
                                std::process::Command::stdout(v41, std::process::Stdio::piped());
                            let v47: std::process::Stdio = std::process::Stdio::piped();
                            let v49: &mut std::process::Command =
                                std::process::Command::stderr(v45, std::process::Stdio::piped());
                            let v51: std::process::Stdio = std::process::Stdio::piped();
                            let v53: &mut std::process::Command =
                                std::process::Command::stdin(v49, std::process::Stdio::piped());
                            let _v54: LrcPtr<MutCell<Option<Documents::US3>>> =
                                refCell(None::<Documents::US3>);
                            {
                                let x_2: Option<Documents::US3> = match &v6 {
                                    None => None::<Documents::US3>,
                                    Some(v6_0_0) => {
                                        let x: string = v6_0_0.clone();
                                        Some((Func0::new({
                                            let x = x.clone();
                                            move || Documents::US3::US3_0(x.clone())
                                        }))())
                                    }
                                };
                                _v54.set(x_2)
                            }
                            {
                                let v59: Documents::US3 =
                                    defaultValue(Documents::US3::US3_1, _v54.get().clone());
                                let v64: &mut std::process::Command = match &v59 {
                                    Documents::US3::US3_0(v59_0_0) => {
                                        std::process::Command::current_dir(
                                            v53,
                                            &*match &v59 {
                                                Documents::US3::US3_0(x) => x.clone(),
                                                _ => unreachable!(),
                                            },
                                        )
                                    }
                                    _ => v53,
                                };
                                let v82: &mut std::process::Command =
                                    if count_2(v2.clone()) as u64 == 0_u64 {
                                        v64
                                    } else {
                                        let v68: Vec<(string, string)> = v2.clone().to_vec();
                                        let v70: bool = true;
                                        let _result = v68.into_iter().fold(v64, |acc, x| {
                                            //;
                                            let v72: &mut std::process::Command = acc;
                                            let patternInput_1: (string, string) = x;
                                            let v77: &mut std::process::Command =
                                                std::process::Command::env(
                                                    v72,
                                                    &*patternInput_1.0.clone(),
                                                    &*patternInput_1.1.clone(),
                                                );
                                            let v79: bool = true;
                                            v77
                                        });
                                        _result
                                    };
                                let v84: Result<std::process::Child, std::io::Error> =
                                    std::process::Command::spawn(v82);
                                let v85 = Documents::method35();
                                let v87: Result<std::process::Child, std::string::String> =
                                    v84.map_err(|x| v85(x));
                                let v89: bool = true;
                                let _result = v87.map(|x| {
                                    //;
                                    let v91: std::process::Child = x;
                                    let v94: std::sync::Mutex<Option<std::process::Child>> =
                                        std::sync::Mutex::new(Some(v91));
                                    let v96: std::sync::Arc<
                                        std::sync::Mutex<Option<std::process::Child>>,
                                    > = std::sync::Arc::new(v94);
                                    let v98: bool = true;
                                    v96
                                });
                                let v100: Result<
                                    std::sync::Arc<std::sync::Mutex<Option<std::process::Child>>>,
                                    std::string::String,
                                > = _result;
                                let v101 = Documents::method59();
                                let v102 = Documents::method60();
                                let v104: Documents::US19 = match v100 {
                                    Ok(x) => v101(x),
                                    Err(e) => v102(e),
                                };
                                let patternInput_3: (i32, Documents::US4, Documents::US20) =
                                    match &v104 {
                                        Documents::US19::US19_0(v104_0_0) => {
                                            let v105: std::sync::Arc<
                                                std::sync::Mutex<Option<std::process::Child>>,
                                            > = v104_0_0.clone();
                                            let v107: bool = true;
                                            let _result = (|| {
                                                //;
                                                let v108: std::sync::Arc<
                                                    std::sync::Mutex<Option<std::process::Child>>,
                                                > = Documents::method61(v105.clone());
                                                let v110: Result<
                                                    std::sync::MutexGuard<
                                                        Option<std::process::Child>,
                                                    >,
                                                    std::sync::PoisonError<
                                                        std::sync::MutexGuard<
                                                            Option<std::process::Child>,
                                                        >,
                                                    >,
                                                > = v108.lock();
                                                let v112: std::sync::MutexGuard<
                                                    Option<std::process::Child>,
                                                > = v110.unwrap();
                                                let v114: bool = true;
                                                let mut v112 = v112;
                                                let v116: &mut Option<std::process::Child> =
                                                    &mut v112;
                                                let v118: Option<&mut std::process::Child> =
                                                    v116.as_mut();
                                                let v120: &mut std::process::Child = v118.unwrap();
                                                let v122: &mut Option<std::process::ChildStdout> =
                                                    &mut v120.stdout;
                                                let v124: Option<std::process::ChildStdout> =
                                                    Option::take(v122);
                                                let v126: std::process::ChildStdout = v124.unwrap();
                                                let v128: bool = true;
                                                v126
                                            })(
                                            );
                                            let v130: std::process::ChildStdout = _result;
                                            let v132: bool = true;
                                            let _result = (|| {
                                                //;
                                                let v133: std::sync::Arc<
                                                    std::sync::Mutex<Option<std::process::Child>>,
                                                > = Documents::method61(v105.clone());
                                                let v135: Result<
                                                    std::sync::MutexGuard<
                                                        Option<std::process::Child>,
                                                    >,
                                                    std::sync::PoisonError<
                                                        std::sync::MutexGuard<
                                                            Option<std::process::Child>,
                                                        >,
                                                    >,
                                                > = v133.lock();
                                                let v137: std::sync::MutexGuard<
                                                    Option<std::process::Child>,
                                                > = v135.unwrap();
                                                let v139: bool = true;
                                                let mut v137 = v137;
                                                let v141: &mut Option<std::process::Child> =
                                                    &mut v137;
                                                let v143: Option<&mut std::process::Child> =
                                                    v141.as_mut();
                                                let v145: &mut std::process::Child = v143.unwrap();
                                                let v147: &mut Option<std::process::ChildStderr> =
                                                    &mut v145.stderr;
                                                let v149: Option<std::process::ChildStderr> =
                                                    Option::take(v147);
                                                let v151: std::process::ChildStderr = v149.unwrap();
                                                let v153: bool = true;
                                                v151
                                            })(
                                            );
                                            let v155: std::process::ChildStderr = _result;
                                            let v157: bool = true;
                                            let _result = (|| {
                                                //;
                                                let v158: std::sync::Arc<
                                                    std::sync::Mutex<Option<std::process::Child>>,
                                                > = Documents::method61(v105.clone());
                                                let v160: Result<
                                                    std::sync::MutexGuard<
                                                        Option<std::process::Child>,
                                                    >,
                                                    std::sync::PoisonError<
                                                        std::sync::MutexGuard<
                                                            Option<std::process::Child>,
                                                        >,
                                                    >,
                                                > = v158.lock();
                                                let v162: std::sync::MutexGuard<
                                                    Option<std::process::Child>,
                                                > = v160.unwrap();
                                                let v164: bool = true;
                                                let mut v162 = v162;
                                                let v166: &mut Option<std::process::Child> =
                                                    &mut v162;
                                                let v168: Option<&mut std::process::Child> =
                                                    v166.as_mut();
                                                let v170: &mut std::process::Child = v168.unwrap();
                                                let v172: &mut Option<std::process::ChildStdin> =
                                                    &mut v170.stdin;
                                                let v174: Option<std::process::ChildStdin> =
                                                    Option::take(v172);
                                                let v176: std::process::ChildStdin = v174.unwrap();
                                                let v179: std::sync::Mutex<
                                                    Option<std::process::ChildStdin>,
                                                > = std::sync::Mutex::new(Some(v176));
                                                let v181: std::sync::Arc<
                                                    std::sync::Mutex<
                                                        Option<std::process::ChildStdin>,
                                                    >,
                                                > = std::sync::Arc::new(v179);
                                                let v183: bool = true;
                                                v181
                                            })(
                                            );
                                            let v185: std::sync::Arc<
                                                std::sync::Mutex<Option<std::process::ChildStdin>>,
                                            > = _result;
                                            let patternInput_2: (
                                                std::sync::mpsc::Sender<std::string::String>,
                                                std::sync::Arc<
                                                    std::sync::mpsc::Receiver<std::string::String>,
                                                >,
                                            ) = {
                                                let (sender, receiver) = std::sync::mpsc::channel();
                                                (sender, std::sync::Arc::new(receiver))
                                            };
                                            let v187: std::sync::mpsc::Sender<std::string::String> =
                                                patternInput_2.0.clone();
                                            let v190: std::sync::Mutex<
                                                std::sync::mpsc::Sender<std::string::String>,
                                            > = std::sync::Mutex::new(v187.clone());
                                            let v192: std::sync::Arc<
                                                std::sync::Mutex<
                                                    std::sync::mpsc::Sender<std::string::String>,
                                                >,
                                            > = std::sync::Arc::new(v190);
                                            let v194: std::sync::Mutex<
                                                std::sync::mpsc::Sender<std::string::String>,
                                            > = std::sync::Mutex::new(v187);
                                            let v196: std::sync::Arc<
                                                std::sync::Mutex<
                                                    std::sync::mpsc::Sender<std::string::String>,
                                                >,
                                            > = std::sync::Arc::new(v194);
                                            let v198: std::sync::Mutex<
                                                std::sync::Arc<
                                                    std::sync::mpsc::Receiver<std::string::String>,
                                                >,
                                            > = std::sync::Mutex::new(patternInput_2.1.clone());
                                            let v200: std::sync::Arc<
                                                std::sync::Mutex<
                                                    std::sync::Arc<
                                                        std::sync::mpsc::Receiver<
                                                            std::string::String,
                                                        >,
                                                    >,
                                                >,
                                            > = std::sync::Arc::new(v198);
                                            let v202: bool = true;
                                            let __result = std::thread::spawn(move || {
                                                //;
                                                let v204: encoding_rs_io::DecodeReaderBytes<
                                                    std::process::ChildStdout,
                                                    Vec<u8>,
                                                > = encoding_rs_io::DecodeReaderBytesBuilder::new()
                                                    .utf8_passthru(true)
                                                    .build(v130);
                                                let v206: std::io::BufReader<
                                                    encoding_rs_io::DecodeReaderBytes<
                                                        std::process::ChildStdout,
                                                        Vec<u8>,
                                                    >,
                                                > = std::io::BufReader::new(v204);
                                                let v208: std::io::Lines<
                                                    std::io::BufReader<
                                                        encoding_rs_io::DecodeReaderBytes<
                                                            std::process::ChildStdout,
                                                            Vec<u8>,
                                                        >,
                                                    >,
                                                > = std::io::BufRead::lines(v206);
                                                let v210: bool = true;
                                                let mut v208 = v208;
                                                let _result = v208.try_for_each(|x| { //;
                                                                let v212:
                                                                        Result<std::string::String,
                                                                               std::io::Error> =
                                                                    x;
                                                                let v214:
                                                                        std::sync::Arc<std::sync::Mutex<std::sync::mpsc::Sender<std::string::String>>> =
                                                                    v192.clone();
                                                                let v215 =
                                                                    Documents::method35();
                                                                let v217:
                                                                        Result<std::string::String,
                                                                               std::string::String> =
                                                                    v212.map_err(|x| v215(x));
                                                                let v218 =
                                                                    Documents::method62();
                                                                let v219 =
                                                                    Documents::method63();
                                                                let v221:
                                                                        Documents::US21 =
                                                                    match v217 { Ok(x) => v218(x), Err(e) => v219(e) };
                                                                let v254:
                                                                        std::string::String =
                                                                    match &v221
                                                                        {
                                                                        Documents::US21::US21_0(v221_0_0)
                                                                        => {
                                                                            let v224:
                                                                                    string =
                                                                                fable_library_rust::String_::fromString(v221_0_0.clone());
                                                                            let v226:
                                                                                    &encoding_rs::Encoding =
                                                                                encoding_rs::UTF_8;
                                                                            let v228:
                                                                                    std::borrow::Cow<[u8]> =
                                                                                v226.encode(&*v224).0;
                                                                            let v230:
                                                                                    &[u8] =
                                                                                v228.as_ref();
                                                                            let v232:
                                                                                    Result<&str,
                                                                                           std::str::Utf8Error> =
                                                                                std::str::from_utf8(v230);
                                                                            let v234:
                                                                                    &str =
                                                                                v232.unwrap();
                                                                            let v236:
                                                                                    std::string::String =
                                                                                String::from(v234);
                                                                            let v239:
                                                                                    string =
                                                                                sprintf!("> {}",
                                                                                         fable_library_rust::String_::fromString(v236.clone()));
                                                                            if v5
                                                                               {
                                                                                Documents::method5(Documents::US0::US0_0,
                                                                                                   Func0::new({
                                                                                                                  let v239
                                                                                                                      =
                                                                                                                      v239.clone();
                                                                                                                  move
                                                                                                                      ||
                                                                                                                      Documents::closure37(v239.clone(),
                                                                                                                                           ())
                                                                                                              }),
                                                                                                   Func0::new(move
                                                                                                                  ||
                                                                                                                  Documents::closure6((),
                                                                                                                                      ())))
                                                                            } else {
                                                                                printfn!("{0}",
                                                                                         v239.clone())
                                                                            }
                                                                            v236
                                                                        }
                                                                        Documents::US21::US21_1(v221_1_0)
                                                                        => {
                                                                            let v244:
                                                                                    std::string::String =
                                                                                v221_1_0.clone();
                                                                            Documents::method5(Documents::US0::US0_4,
                                                                                               Func0::new(move
                                                                                                              ||
                                                                                                              Documents::closure35((),
                                                                                                                                   ())),
                                                                                               Func0::new({
                                                                                                              let v244
                                                                                                                  =
                                                                                                                  v244.clone();
                                                                                                              move
                                                                                                                  ||
                                                                                                                  Documents::closure36(v244.clone(),
                                                                                                                                       ())
                                                                                                          }));
                                                                            {
                                                                                let v248:
                                                                                        string =
                                                                                    sprintf!("\u{001b}[4;7m{}\u{001b}[0m",
                                                                                             v244.clone());
                                                                                let v250:
                                                                                        &str =
                                                                                    &*v248;
                                                                                String::from(v250)
                                                                            }
                                                                        }
                                                                    };
                                                                let v255:
                                                                        std::sync::Arc<std::sync::Mutex<std::sync::mpsc::Sender<std::string::String>>> =
                                                                    Documents::method64(v214);
                                                                let v257:
                                                                        Result<std::sync::MutexGuard<std::sync::mpsc::Sender<std::string::String>>,
                                                                               std::sync::PoisonError<std::sync::MutexGuard<std::sync::mpsc::Sender<std::string::String>>>> =
                                                                    v255.lock();
                                                                let v259:
                                                                        std::sync::MutexGuard<std::sync::mpsc::Sender<std::string::String>> =
                                                                    v257.unwrap();
                                                                let v261:
                                                                        &std::sync::mpsc::Sender<std::string::String> =
                                                                    &v259;
                                                                let v263:
                                                                        Result<(),
                                                                               std::sync::mpsc::SendError<std::string::String>> =
                                                                    v261.send(v254);
                                                                let v264 =
                                                                    Documents::method65();
                                                                let v266:
                                                                        Result<(),
                                                                               std::string::String> =
                                                                    v263.map_err(|x| v264(x));
                                                                let v268: _ =
                                                                    v266;
                                                                let v270:
                                                                        bool =
                                                                    true; v268 }); //;
                                                let v273: Result<(), string> = Documents::method66(
                                                    _result.map_err(|x| x.into()),
                                                );
                                                let v277: string = string("v273 });  //");
                                                v273
                                            }); //;
                                            {
                                                let v279: std::thread::JoinHandle<
                                                    Result<(), string>,
                                                > = __result;
                                                let v281: bool = true;
                                                let __result = std::thread::spawn(move || {
                                                    //;
                                                    let v283:
                                                                            encoding_rs_io::DecodeReaderBytes<std::process::ChildStderr, Vec<u8>> =
                                                                        encoding_rs_io::DecodeReaderBytesBuilder::new().utf8_passthru(true).build(v155);
                                                    let v285: std::io::BufReader<
                                                        encoding_rs_io::DecodeReaderBytes<
                                                            std::process::ChildStderr,
                                                            Vec<u8>,
                                                        >,
                                                    > = std::io::BufReader::new(v283);
                                                    let v287: std::io::Lines<
                                                        std::io::BufReader<
                                                            encoding_rs_io::DecodeReaderBytes<
                                                                std::process::ChildStderr,
                                                                Vec<u8>,
                                                            >,
                                                        >,
                                                    > = std::io::BufRead::lines(v285);
                                                    let v289: bool = true;
                                                    let mut v287 = v287;
                                                    let _result = v287.try_for_each(|x| { //;
                                                                    let v291:
                                                                            Result<std::string::String,
                                                                                   std::io::Error> =
                                                                        x;
                                                                    let v293:
                                                                            std::sync::Arc<std::sync::Mutex<std::sync::mpsc::Sender<std::string::String>>> =
                                                                        v196.clone();
                                                                    let v294 =
                                                                        Documents::method35();
                                                                    let v296:
                                                                            Result<std::string::String,
                                                                                   std::string::String> =
                                                                        v291.map_err(|x| v294(x));
                                                                    let v297 =
                                                                        Documents::method62();
                                                                    let v298 =
                                                                        Documents::method63();
                                                                    let v300:
                                                                            Documents::US21 =
                                                                        match v296 { Ok(x) => v297(x), Err(e) => v298(e) };
                                                                    let v338:
                                                                            std::string::String =
                                                                        match &v300
                                                                            {
                                                                            Documents::US21::US21_0(v300_0_0)
                                                                            =>
                                                                            {
                                                                                let v303:
                                                                                        string =
                                                                                    fable_library_rust::String_::fromString(v300_0_0.clone());
                                                                                let v305:
                                                                                        &encoding_rs::Encoding =
                                                                                    encoding_rs::UTF_8;
                                                                                let v307:
                                                                                        std::borrow::Cow<[u8]> =
                                                                                    v305.encode(&*v303).0;
                                                                                let v309:
                                                                                        &[u8] =
                                                                                    v307.as_ref();
                                                                                let v311:
                                                                                        Result<&str,
                                                                                               std::str::Utf8Error> =
                                                                                    std::str::from_utf8(v309);
                                                                                let v313:
                                                                                        &str =
                                                                                    v311.unwrap();
                                                                                let v315:
                                                                                        std::string::String =
                                                                                    String::from(v313);
                                                                                let v318:
                                                                                        string =
                                                                                    sprintf!("! {}",
                                                                                             fable_library_rust::String_::fromString(v315.clone()));
                                                                                if v5
                                                                                   {
                                                                                    Documents::method5(Documents::US0::US0_0,
                                                                                                       Func0::new({
                                                                                                                      let v318
                                                                                                                          =
                                                                                                                          v318.clone();
                                                                                                                      move
                                                                                                                          ||
                                                                                                                          Documents::closure37(v318.clone(),
                                                                                                                                               ())
                                                                                                                  }),
                                                                                                       Func0::new(move
                                                                                                                      ||
                                                                                                                      Documents::closure6((),
                                                                                                                                          ())))
                                                                                } else {
                                                                                    printfn!("{0}",
                                                                                             v318.clone())
                                                                                }
                                                                                {
                                                                                    let v323:
                                                                                            string =
                                                                                        sprintf!("\u{001b}[4;7m{}\u{001b}[0m",
                                                                                                 v315);
                                                                                    let v325:
                                                                                            &str =
                                                                                        &*v323;
                                                                                    String::from(v325)
                                                                                }
                                                                            }
                                                                            Documents::US21::US21_1(v300_1_0)
                                                                            =>
                                                                            {
                                                                                let v328:
                                                                                        std::string::String =
                                                                                    v300_1_0.clone();
                                                                                Documents::method5(Documents::US0::US0_4,
                                                                                                   Func0::new(move
                                                                                                                  ||
                                                                                                                  Documents::closure35((),
                                                                                                                                       ())),
                                                                                                   Func0::new({
                                                                                                                  let v328
                                                                                                                      =
                                                                                                                      v328.clone();
                                                                                                                  move
                                                                                                                      ||
                                                                                                                      Documents::closure36(v328.clone(),
                                                                                                                                           ())
                                                                                                              }));
                                                                                {
                                                                                    let v332:
                                                                                            string =
                                                                                        sprintf!("\u{001b}[4;7m{}\u{001b}[0m",
                                                                                                 v328.clone());
                                                                                    let v334:
                                                                                            &str =
                                                                                        &*v332;
                                                                                    String::from(v334)
                                                                                }
                                                                            }
                                                                        };
                                                                    let v339:
                                                                            std::sync::Arc<std::sync::Mutex<std::sync::mpsc::Sender<std::string::String>>> =
                                                                        Documents::method64(v293);
                                                                    let v341:
                                                                            Result<std::sync::MutexGuard<std::sync::mpsc::Sender<std::string::String>>,
                                                                                   std::sync::PoisonError<std::sync::MutexGuard<std::sync::mpsc::Sender<std::string::String>>>> =
                                                                        v339.lock();
                                                                    let v343:
                                                                            std::sync::MutexGuard<std::sync::mpsc::Sender<std::string::String>> =
                                                                        v341.unwrap();
                                                                    let v345:
                                                                            &std::sync::mpsc::Sender<std::string::String> =
                                                                        &v343;
                                                                    let v347:
                                                                            Result<(),
                                                                                   std::sync::mpsc::SendError<std::string::String>> =
                                                                        v345.send(v338);
                                                                    let v348 =
                                                                        Documents::method65();
                                                                    let v350:
                                                                            Result<(),
                                                                                   std::string::String> =
                                                                        v347.map_err(|x| v348(x));
                                                                    let v352:
                                                                            _ =
                                                                        v350;
                                                                    let v354:
                                                                            bool =
                                                                        true; v352 }); //;
                                                    let v357: Result<(), string> =
                                                        Documents::method66(
                                                            _result.map_err(|x| x.into()),
                                                        );
                                                    let v359: string = string("v357 });  //");
                                                    v357
                                                }); //;
                                                {
                                                    let v361: std::thread::JoinHandle<
                                                        Result<(), string>,
                                                    > = __result;
                                                    let _v362: LrcPtr<
                                                        MutCell<Option<Documents::US22>>,
                                                    > = refCell(None::<Documents::US22>);
                                                    {
                                                        let x_5: Option<Documents::US22> = match &v4
                                                        {
                                                            None => None::<Documents::US22>,
                                                            Some(v4_0_0) => {
                                                                let x_3 = v4_0_0.clone();
                                                                Some((Func0::new({
                                                                    let x_3 = x_3.clone();
                                                                    move || {
                                                                        Documents::US22::US22_0(
                                                                            x_3.clone(),
                                                                        )
                                                                    }
                                                                }))(
                                                                ))
                                                            }
                                                        };
                                                        _v362.set(x_5)
                                                    }
                                                    {
                                                        let v367: Documents::US22 = defaultValue(
                                                            Documents::US22::US22_1,
                                                            _v362.get().clone(),
                                                        );
                                                        match &v367 {
                                                            Documents::US22::US22_0(v367_0_0) => {
                                                                let v369:
                                                                                            std::sync::Arc<std::sync::Mutex<Option<std::process::ChildStdin>>> =
                                                                                        Documents::method67(v185);
                                                                let v371:
                                                                                            Result<std::sync::MutexGuard<Option<std::process::ChildStdin>>,
                                                                                                   std::sync::PoisonError<std::sync::MutexGuard<Option<std::process::ChildStdin>>>> =
                                                                                        v369.lock();
                                                                let v373: std::sync::MutexGuard<
                                                                    Option<
                                                                        std::process::ChildStdin,
                                                                    >,
                                                                > = v371.unwrap();
                                                                let v375: bool = true;
                                                                let mut v373 = v373;
                                                                let v377: &mut Option<
                                                                    std::process::ChildStdin,
                                                                > = &mut v373;
                                                                let v379: Option<
                                                                    std::process::ChildStdin,
                                                                > = Option::take(v377);
                                                                let v381: bool = true;
                                                                let _result = v379.map(|x| { //;
                                                                                    let v383:
                                                                                            std::process::ChildStdin =
                                                                                        x;
                                                                                    let v385:
                                                                                            std::sync::Mutex<std::process::ChildStdin> =
                                                                                        std::sync::Mutex::new(v383);
                                                                                    let v387:
                                                                                            std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>> =
                                                                                        std::sync::Arc::new(v385);
                                                                                    let v389:
                                                                                            bool =
                                                                                        true; v387 });
                                                                let v391:
                                                                                            Option<std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>> =
                                                                                        _result;
                                                                let _v392: LrcPtr<
                                                                    MutCell<
                                                                        Option<Documents::US23>,
                                                                    >,
                                                                > = refCell(
                                                                    None::<Documents::US23>,
                                                                );
                                                                {
                                                                    let x_8: Option<
                                                                        Documents::US23,
                                                                    > = match &v391 {
                                                                        None => {
                                                                            None::<Documents::US23>
                                                                        }
                                                                        Some(v391_0_0) => {
                                                                            let x_6:
                                                                                                            std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>> =
                                                                                                        v391_0_0.clone();
                                                                            Some((Func0::new({
                                                                                let x_6 =
                                                                                    x_6.clone();
                                                                                move || {
                                                                                    Documents::US23::US23_0(x_6.clone())
                                                                                }
                                                                            }))(
                                                                            ))
                                                                        }
                                                                    };
                                                                    _v392.set(x_8)
                                                                }
                                                                {
                                                                    let v397: Documents::US23 =
                                                                        defaultValue(
                                                                            Documents::US23::US23_1,
                                                                            _v392.get().clone(),
                                                                        );
                                                                    match &v397 {
                                                                        Documents::US23::US23_0(
                                                                            v397_0_0,
                                                                        ) => {
                                                                            let v398:
                                                                                                        std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>> =
                                                                                                    match &v397
                                                                                                        {
                                                                                                        Documents::US23::US23_0(x)
                                                                                                        =>
                                                                                                        x.clone(),
                                                                                                        _
                                                                                                        =>
                                                                                                        unreachable!(),
                                                                                                    };
                                                                            (match &v367
                                                                                                     {
                                                                                                     Documents::US22::US22_0(x)
                                                                                                     =>
                                                                                                     x.clone(),
                                                                                                     _
                                                                                                     =>
                                                                                                     unreachable!(),
                                                                                                 })(v398.clone());
                                                                            {
                                                                                let v399:
                                                                                                            std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>> =
                                                                                                        Documents::method68(v398);
                                                                                let v401:
                                                                                                            Result<std::sync::MutexGuard<std::process::ChildStdin>,
                                                                                                                   std::sync::PoisonError<std::sync::MutexGuard<std::process::ChildStdin>>> =
                                                                                                        v399.lock();
                                                                                let v404:
                                                                                                            std::sync::MutexGuard<std::process::ChildStdin> =
                                                                                                        Documents::method69(v401.unwrap());
                                                                                let v406: bool =
                                                                                    true;
                                                                                let mut v404 = v404;
                                                                                let v408: bool =
                                                                                    true;
                                                                                std::io::Write::flush(&mut *v404).unwrap();
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
                                                            let v409: std::sync::Arc<
                                                                std::sync::Mutex<
                                                                    Option<std::process::Child>,
                                                                >,
                                                            > = Documents::method61(v105);
                                                            let v411: Result<
                                                                std::sync::MutexGuard<
                                                                    Option<std::process::Child>,
                                                                >,
                                                                std::sync::PoisonError<
                                                                    std::sync::MutexGuard<
                                                                        Option<std::process::Child>,
                                                                    >,
                                                                >,
                                                            > = v409.lock();
                                                            let v413: std::sync::MutexGuard<
                                                                Option<std::process::Child>,
                                                            > = v411.unwrap();
                                                            let v415: bool = true;
                                                            let mut v413 = v413;
                                                            let v417: &mut Option<
                                                                std::process::Child,
                                                            > = &mut v413;
                                                            let v419: Option<std::process::Child> =
                                                                Option::take(v417);
                                                            let v421: std::process::Child =
                                                                v419.unwrap();
                                                            let v423: Result<
                                                                std::process::Output,
                                                                std::io::Error,
                                                            > = v421.wait_with_output();
                                                            let v424 = Documents::method35();
                                                            let v426: Result<
                                                                std::process::Output,
                                                                std::string::String,
                                                            > = v423.map_err(|x| v424(x));
                                                            let v427: std::thread::JoinHandle<
                                                                Result<(), string>,
                                                            > = Documents::method70(v361);
                                                            let v430: string = string("v427");
                                                            let v431: std::thread::JoinHandle<
                                                                Result<(), string>,
                                                            > = Documents::method70(v279);
                                                            let v436: string = append(
                                                                append(
                                                                    string("vec!["),
                                                                    append(string("v431, "), v430),
                                                                ),
                                                                string("]"),
                                                            );
                                                            let v437: Vec<
                                                                std::thread::JoinHandle<
                                                                    Result<(), string>,
                                                                >,
                                                            > = vec![v431, v427];
                                                            let v439: bool = true;
                                                            v437.into_iter().for_each(|x| {
                                                                //;
                                                                let v441: std::thread::JoinHandle<
                                                                    Result<(), string>,
                                                                > = x;
                                                                let v443: Result<
                                                                    Result<(), string>,
                                                                    Box<
                                                                        dyn core::any::Any
                                                                            + 'static
                                                                            + Send,
                                                                    >,
                                                                > = std::thread::JoinHandle::join(
                                                                    v441,
                                                                );
                                                                let v445: Result<(), string> =
                                                                    v443.unwrap();
                                                                v445.unwrap();
                                                                {
                                                                    let v448: bool = true;
                                                                    ()
                                                                }
                                                            });
                                                            {
                                                                //;
                                                                let v451: Documents::US24 =
                                                                    match &v426 {
                                                                        Err(v426_1_0) => {
                                                                            Documents::closure40(
                                                                                (),
                                                                                v426_1_0.clone(),
                                                                            )
                                                                        }
                                                                        Ok(v426_0_0) => {
                                                                            Documents::closure39(
                                                                                (),
                                                                                v426_0_0.clone(),
                                                                            )
                                                                        }
                                                                    };
                                                                match &v451 {
                                                                    Documents::US24::US24_0(
                                                                        v451_0_0,
                                                                    ) => {
                                                                        let v454:
                                                                                                    std::process::ExitStatus =
                                                                                                v451_0_0.clone().status;
                                                                        let v456: Option<i32> =
                                                                            v454.code();
                                                                        (
                                                                            v456.unwrap(),
                                                                            Documents::US4::US4_1,
                                                                            Documents::US20::US20_0(
                                                                                v200,
                                                                            ),
                                                                        )
                                                                    }
                                                                    Documents::US24::US24_1(
                                                                        v451_1_0,
                                                                    ) => {
                                                                        let v461:
                                                                                                    std::string::String =
                                                                                                v451_1_0.clone();
                                                                        Documents::method5(
                                                                            Documents::US0::US0_4,
                                                                            Func0::new(move || {
                                                                                Documents::closure41(
                                                                                    (),
                                                                                    (),
                                                                                )
                                                                            }),
                                                                            Func0::new({
                                                                                let v461 =
                                                                                    v461.clone();
                                                                                move || {
                                                                                    Documents::closure42(v461.clone(),
                                                                                                                                                       ())
                                                                                }
                                                                            }),
                                                                        );
                                                                        (
                                                                            -2_i32,
                                                                            Documents::US4::US4_0(
                                                                                v461.clone(),
                                                                            ),
                                                                            Documents::US20::US20_1,
                                                                        )
                                                                    }
                                                                }
                                                            }
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                        Documents::US19::US19_1(v104_1_0) => {
                                            let v473: std::string::String = v104_1_0.clone();
                                            Documents::method5(
                                                Documents::US0::US0_4,
                                                Func0::new(move || Documents::closure31((), ())),
                                                Func0::new({
                                                    let v473 = v473.clone();
                                                    move || Documents::closure32(v473.clone(), ())
                                                }),
                                            );
                                            (
                                                -1_i32,
                                                Documents::US4::US4_0(v473.clone()),
                                                Documents::US20::US20_1,
                                            )
                                        }
                                    };
                                let v484: Documents::US20 = patternInput_3.2.clone();
                                let v483: Documents::US4 = patternInput_3.1.clone();
                                let v482: i32 = patternInput_3.0.clone();
                                let v489: Option<
                                    std::sync::Arc<
                                        std::sync::Mutex<
                                            std::sync::Arc<
                                                std::sync::mpsc::Receiver<std::string::String>,
                                            >,
                                        >,
                                    >,
                                > = match &v484 {
                                    Documents::US20::US20_0(v484_0_0) => Some(match &v484 {
                                        Documents::US20::US20_0(x) => x.clone(),
                                        _ => unreachable!(),
                                    }),
                                    _ => {
                                        None::<
                                            std::sync::Arc<
                                                std::sync::Mutex<
                                                    std::sync::Arc<
                                                        std::sync::mpsc::Receiver<
                                                            std::string::String,
                                                        >,
                                                    >,
                                                >,
                                            >,
                                        >
                                    }
                                };
                                let v491: bool = true;
                                let _result = v489.map(|x| {
                                    //;
                                    let v494: std::sync::Arc<
                                        std::sync::Mutex<
                                            std::sync::Arc<
                                                std::sync::mpsc::Receiver<std::string::String>,
                                            >,
                                        >,
                                    > = Documents::method71(x);
                                    let v496: Result<
                                        std::sync::MutexGuard<
                                            std::sync::Arc<
                                                std::sync::mpsc::Receiver<std::string::String>,
                                            >,
                                        >,
                                        std::sync::PoisonError<
                                            std::sync::MutexGuard<
                                                std::sync::Arc<
                                                    std::sync::mpsc::Receiver<std::string::String>,
                                                >,
                                            >,
                                        >,
                                    > = v494.lock();
                                    let v498: std::sync::MutexGuard<
                                        std::sync::Arc<
                                            std::sync::mpsc::Receiver<std::string::String>,
                                        >,
                                    > = v496.unwrap();
                                    let v500 = v498.iter();
                                    let v502: Vec<std::string::String> = v500.collect::<Vec<_>>();
                                    let v504: bool = true;
                                    let _result: Vec<_> = v502
                                        .into_iter()
                                        .map(|x| {
                                            //;
                                            let v506: std::string::String = x;
                                            let v508: string =
                                                fable_library_rust::String_::fromString(v506);
                                            let v510: bool = true;
                                            v508
                                        })
                                        .collect::<Vec<_>>();
                                    let v512: Vec<string> = _result;
                                    let v520: string = join(
                                        string("\n"),
                                        toArray(ofArray_1(
                                            fable_library_rust::NativeArray_::array_from(v512),
                                        )),
                                    );
                                    let v522: bool = true;
                                    v520
                                });
                                let v524: Option<string> = _result;
                                let v531: Documents::US3 = match &v483 {
                                    Documents::US4::US4_0(v483_0_0) => Documents::US3::US3_0(
                                        fable_library_rust::String_::fromString(match &v483 {
                                            Documents::US4::US4_0(x) => x.clone(),
                                            _ => unreachable!(),
                                        }),
                                    ),
                                    _ => Documents::US3::US3_1,
                                };
                                let v536: string = defaultValue(
                                    match &v531 {
                                        Documents::US3::US3_0(v531_0_0) => match &v531 {
                                            Documents::US3::US3_0(x) => x.clone(),
                                            _ => unreachable!(),
                                        },
                                        _ => string(""),
                                    },
                                    v524,
                                );
                                Documents::method5(
                                    Documents::US0::US0_0,
                                    Func0::new(move || Documents::closure43((), ())),
                                    Func0::new({
                                        let v482 = v482.clone();
                                        let v536 = v536.clone();
                                        move || Documents::closure44(v482, v536.clone(), ())
                                    }),
                                );
                                LrcPtr::new((v482, v536.clone()))
                            }
                        }
                    }))();
                    _v35.set(Some(x_12))
                }
                {
                    let v541: LrcPtr<(i32, string)> = match &_v35.get().clone() {
                        None => panic!("{}", string("base.capture / _v35=None"),),
                        Some(_v35_0_0) => _v35_0_0.clone(),
                    };
                    _v7.set(Some((v541.0.clone(), v541.1.clone())));
                    {
                        let patternInput_4: (i32, string) = match &_v7.get().clone() {
                            None => panic!("{}", string("base.run_target / _v7=None"),),
                            Some(_v7_0_0) => _v7_0_0.clone(),
                        };
                        (patternInput_4.0.clone(), patternInput_4.1.clone())
                    }
                }
            }
        }
        pub fn method75(v0_1: string) -> string {
            let _v1: MutCell<Option<string>> = MutCell::new(None::<string>);
            let v3: &str = &*v0_1;
            let v5: std::string::String = String::from(v3);
            let v7: std::path::PathBuf = std::path::PathBuf::from(v5);
            let v9: Option<&std::ffi::OsStr> = v7.file_name();
            let v11: &std::ffi::OsStr = v9.unwrap();
            let v13: std::ffi::OsString = v11.to_os_string();
            let v15: Option<&str> = v13.to_str();
            let v17: &str = v15.unwrap();
            let v19: std::string::String = String::from(v17);
            {
                let x: string = fable_library_rust::String_::fromString(v19);
                _v1.set(Some(x))
            }
            match &_v1.get().clone() {
                None => panic!("{}", string("base.run_target / _v1=None"),),
                Some(_v1_0_0) => _v1_0_0.clone(),
            }
        }
        pub fn method74(v0_1: string, v1_1: string, v2: string) -> (string, string) {
            let v4: string = Documents::method15(v2, Documents::method75(v1_1.clone()));
            let v8: string = getSlice(
                v1_1.clone(),
                Some(0_i32),
                Some(lastIndexOf(v1_1.clone(), string(".")) - 1_i32),
            );
            let v11: string = getSlice(
                v4.clone(),
                Some(0_i32),
                Some(lastIndexOf(v4.clone(), string(".")) - 1_i32),
            );
            let v14: bool = endsWith(v0_1.clone(), string(".md"), false) == false;
            (
                if v14 {
                    sprintf!("{}.{}", v4, v0_1.clone())
                } else {
                    sprintf!("{}.{}", v11, v0_1.clone())
                },
                if v14 {
                    sprintf!("{}.{}", v1_1, v0_1.clone())
                } else {
                    sprintf!("{}.{}", v8, v0_1)
                },
            )
        }
        pub fn closure52(unitVar: (), v0_1: string) -> Documents::US28 {
            Documents::US28::US28_0(v0_1)
        }
        pub fn method76() -> Func1<string, Documents::US28> {
            Func1::new(move |v: string| Documents::closure52((), v))
        }
        pub fn closure53(unitVar: (), v0_1: std::string::String) -> Documents::US28 {
            Documents::US28::US28_1(v0_1)
        }
        pub fn method77() -> Func1<std::string::String, Documents::US28> {
            Func1::new(move |v: std::string::String| Documents::closure53((), v))
        }
        pub fn method78(v0_1: string) -> bool {
            let _v1: MutCell<Option<bool>> = MutCell::new(None::<bool>);
            let v3: &str = &*v0_1;
            let v5: std::string::String = String::from(v3);
            let v7: std::path::PathBuf = std::path::PathBuf::from(v5);
            {
                let x: bool = if v7.clone().exists() {
                    v7.is_file()
                } else {
                    false
                };
                _v1.set(Some(x))
            }
            match &_v1.get().clone() {
                None => panic!("{}", string("base.run_target / _v1=None"),),
                Some(_v1_0_0) => _v1_0_0.clone(),
            }
        }
        pub fn closure54(unitVar: (), unitVar_1: ()) -> string {
            let v0_1: string =
                string("documents.run / par_map / origin_hash |> sm\'.contains local_git_hash |> not / hash2 = None || hash1 <>. (hash2 |> optionm.value)");
            v0_1
        }
        pub fn closure55(
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
        pub fn method80(v0_1: string) -> string {
            v0_1
        }
        pub fn method79(v0_1: string, v1_1: string) {
            let _v2: MutCell<Option<()>> = MutCell::new(None::<()>);
            let v3: string = Documents::method80(v0_1);
            let v5: Result<u64, std::io::Error> = std::fs::copy(&*v1_1, &*v3);
            let v7: u64 = v5.unwrap();
            _v2.set(Some(()));
            match &_v2.get().clone() {
                None => panic!("{}", string("base.run_target / _v2=None"),),
                Some(_v2_0_0) => _v2_0_0.clone(),
            }
            ()
        }
        pub fn method82(v0_1: i32, v1_1: LrcPtr<Documents::Mut6>) -> bool {
            v1_1.l0.get().clone() < v0_1
        }
        pub fn method83(v0_1: string) -> string {
            v0_1
        }
        pub fn method84(
            v0_1: std::sync::MutexGuard<std::process::ChildStdin>,
        ) -> std::sync::MutexGuard<std::process::ChildStdin> {
            v0_1
        }
        pub fn closure58(
            v0_1: string,
            v1_1: std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>,
        ) {
            let v2: std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>> =
                Documents::method68(v1_1);
            let v4: Result<
                std::sync::MutexGuard<std::process::ChildStdin>,
                std::sync::PoisonError<std::sync::MutexGuard<std::process::ChildStdin>>,
            > = v2.lock();
            let v6: std::sync::MutexGuard<std::process::ChildStdin> = v4.unwrap();
            let v7: string = Documents::method83(v0_1);
            let v9: &[u8] = v7.as_bytes();
            let v10: std::sync::MutexGuard<std::process::ChildStdin> = Documents::method84(v6);
            let v12: bool = true;
            let mut v10 = v10;
            let v14: bool = true;
            std::io::Write::write_all(&mut *v10, v9).unwrap();
            ()
        }
        pub fn method85(v0_1: i32, v1_1: LrcPtr<Documents::Mut7>) -> bool {
            v1_1.l0.get().clone() < v0_1
        }
        pub fn method86(v0_1: string) -> string {
            v0_1
        }
        pub fn closure59(unitVar: (), unitVar_1: ()) -> string {
            string("documents.hangul")
        }
        pub fn closure60(v0_1: string, v1_1: i32, v2: string, unitVar: ()) -> string {
            sprintf!(
                "exit_code: {:?} / result_len: {} / output_path: {} / {}",
                v1_1,
                length(v2),
                v0_1,
                Documents::closure6((), ())
            )
        }
        pub fn method81(v0_1: string, v1_1: string, v2: string, v3: string) -> Documents::US29 {
            let _v4: MutCell<Option<string>> = MutCell::new(None::<string>);
            let _v5: MutCell<Option<Vec<u8>>> = MutCell::new(None::<Vec<u8>>);
            {
                let x: Vec<u8> = std::fs::read(&*v3).unwrap();
                _v5.set(Some(x))
            }
            {
                let v15: Vec<u8> = match &_v5.get().clone() {
                    None => panic!("{}", string("base.run_target / _v5=None"),),
                    Some(_v5_0_0) => _v5_0_0.clone(),
                };
                let v17: Result<std::string::String, std::string::FromUtf8Error> =
                    std::string::String::from_utf8(v15);
                let v19: std::string::String = v17.unwrap();
                {
                    let x_2: string = fable_library_rust::String_::fromString(v19);
                    _v4.set(Some(x_2))
                }
                {
                    let v29: Array<string> = split(
                        match &_v4.get().clone() {
                            None => panic!("{}", string("base.run_target / _v4=None"),),
                            Some(_v4_0_0) => _v4_0_0.clone(),
                        },
                        string("\n"),
                        -1_i32,
                        0_i32,
                    );
                    let v30: i32 = count_2(v29.clone());
                    let v31: Array<string> = new_init(&string(""), v30);
                    let v32: LrcPtr<Documents::Mut5> = LrcPtr::new(Documents::Mut5 {
                        l0: MutCell::new(0_i32),
                    });
                    while Documents::method30(v30, v32.clone()) {
                        let v34: i32 = v32.l0.get().clone();
                        let v37: string = trim(v29[v34].clone());
                        v31.get_mut()[v34 as usize] = v37;
                        {
                            let v38: i32 = v34 + 1_i32;
                            v32.l0.set(v38);
                            ()
                        }
                    }
                    {
                        let v39: i32 = count_2(v31.clone());
                        let v40: Array<string> = new_init(&string(""), v39);
                        let v41: LrcPtr<Documents::Mut6> = LrcPtr::new(Documents::Mut6 {
                            l0: MutCell::new(0_i32),
                            l1: MutCell::new(0_i32),
                        });
                        while Documents::method82(v39, v41.clone()) {
                            let v43: i32 = v41.l0.get().clone();
                            let v44: i32 = v41.l1.get().clone();
                            let v45: string = v31[v43].clone();
                            let v49: i32 = if string("") != v45.clone() {
                                v40.get_mut()[v44 as usize] = v45;
                                v44 + 1_i32
                            } else {
                                v44
                            };
                            let v50: i32 = v43 + 1_i32;
                            v41.l0.set(v50);
                            v41.l1.set(v49);
                            ()
                        }
                        {
                            let v51: i32 = v41.l1.get().clone();
                            let v52: Array<string> = new_init(&string(""), v51);
                            let v53: LrcPtr<Documents::Mut5> = LrcPtr::new(Documents::Mut5 {
                                l0: MutCell::new(0_i32),
                            });
                            while Documents::method30(v51, v53.clone()) {
                                let v55: i32 = v53.l0.get().clone();
                                let v56: string = v40[v55].clone();
                                v52.get_mut()[v55 as usize] = v56;
                                {
                                    let v57: i32 = v55 + 1_i32;
                                    v53.l0.set(v57);
                                    ()
                                }
                            }
                            {
                                let v62: string = sprintf!(
                                    "{}\n\n",
                                    join(
                                        string("\n"),
                                        toArray(delay(Func0::new({
                                            let v52 = v52.clone();
                                            move || {
                                                map(
                                                    Func1::new({
                                                        let v52 = v52.clone();
                                                        move |i: i32| v52[i].clone()
                                                    }),
                                                    rangeNumeric(
                                                        0_i32,
                                                        1_i32,
                                                        count_2(v52.clone()) - 1_i32,
                                                    ),
                                                )
                                            }
                                        })))
                                    )
                                );
                                let _v68: MutCell<Option<bool>> = MutCell::new(None::<bool>);
                                {
                                    let x_4: bool = cfg!(windows);
                                    _v68.set(Some(x_4))
                                }
                                {
                                    let patternInput: (i32, string) =
                                        Documents::method41(None::<CancellationToken>,
                                                            sprintf!("{} {}",
                                                                     Documents::method15(v0_1,
                                                                                         sprintf!("../vault/deps/hangulize/cmd/hangulize/hangulize{}",
                                                                                                  if match &_v68.get().clone()
                                                                                                         {
                                                                                                         None
                                                                                                         =>
                                                                                                         panic!("{}",
                                                                                                                string("base.run_target / _v68=None"),),
                                                                                                         Some(_v68_0_0)
                                                                                                         =>
                                                                                                         _v68_0_0.clone(),
                                                                                                     }
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
                                                                                    Documents::closure58(v62.clone(),
                                                                                                         v)
                                                                            })),
                                                            true,
                                                            None::<string>);
                                    let v96: i32 = patternInput.0.clone();
                                    let v98: Array<string> =
                                        split(patternInput.1.clone(), string("\n"), -1_i32, 0_i32);
                                    let v99: i32 = count_2(v98.clone());
                                    let v101: LrcPtr<Documents::Mut7> =
                                        LrcPtr::new(Documents::Mut7 {
                                            l0: MutCell::new(0_i32),
                                            l1: MutCell::new(string("")),
                                            l2: MutCell::new(0_i32),
                                            l3: MutCell::new(0_i32),
                                        });
                                    while Documents::method85(v39, v101.clone()) {
                                        let v103: i32 = v101.l0.get().clone();
                                        let matchValue: string = v101.l1.get().clone();
                                        let matchValue_1: i32 = v101.l2.get().clone();
                                        let v106: i32 = v101.l3.get().clone();
                                        let v105: i32 = matchValue_1;
                                        let v104: string = matchValue;
                                        let patternInput_2: (string, i32, i32) = if v31[v103]
                                            .clone()
                                            == string("")
                                        {
                                            (
                                                sprintf!("{}\n", v104.clone()),
                                                v105 + 1_i32,
                                                v106 + 1_i32,
                                            )
                                        } else {
                                            let v112: i32 = v105 - v106;
                                            (
                                                if v112 >= v99 {
                                                    v104.clone()
                                                } else {
                                                    let v114: string = v98[v112].clone();
                                                    if v112 == v99 - 1_i32 {
                                                        sprintf!("{}{}", v104.clone(), v114.clone())
                                                    } else {
                                                        sprintf!("{}{}\n", v104, v114)
                                                    }
                                                },
                                                v105 + 1_i32,
                                                v106,
                                            )
                                        };
                                        let v125: i32 = v103 + 1_i32;
                                        v101.l0.set(v125);
                                        v101.l1.set(patternInput_2.0.clone());
                                        v101.l2.set(patternInput_2.1.clone());
                                        v101.l3.set(patternInput_2.2.clone());
                                        ()
                                    }
                                    {
                                        let matchValue_3: string = v101.l1.get().clone();
                                        let matchValue_4: i32 = v101.l2.get().clone();
                                        let matchValue_5: i32 = v101.l3.get().clone();
                                        let v126: string = matchValue_3;
                                        let _v129: MutCell<Option<()>> = MutCell::new(None::<()>);
                                        std::fs::write(&*v2.clone(), &*v126.clone()).unwrap();
                                        _v129.set(Some(()));
                                        match &_v129.get().clone() {
                                            None => {
                                                panic!("{}", string("base.run_target / _v129=None"),)
                                            }
                                            Some(_v129_0_0) => _v129_0_0.clone(),
                                        }
                                        Documents::method5(
                                            Documents::US0::US0_2,
                                            Func0::new(move || Documents::closure59((), ())),
                                            Func0::new({
                                                let v126 = v126.clone();
                                                let v2 = v2.clone();
                                                let v96 = v96.clone();
                                                move || {
                                                    Documents::closure60(
                                                        v2.clone(),
                                                        v96,
                                                        v126.clone(),
                                                        (),
                                                    )
                                                }
                                            }),
                                        );
                                        Documents::US29::US29_0(v96, v126.clone())
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
        pub fn closure61(unitVar: (), unitVar_1: ()) -> string {
            string("documents.files_fn / error")
        }
        pub fn closure62(v0_1: string, v1_1: i32, unitVar: ()) -> string {
            sprintf!(
                "exit_code: {:?} / result: {} / {}",
                v1_1,
                v0_1,
                Documents::closure6((), ())
            )
        }
        pub fn closure57(
            v0_1: string,
            v1_1: string,
            v2: string,
            v3: string,
            v4: string,
            v5: string,
        ) -> Documents::US27 {
            let patternInput: (string, string) = Documents::method74(v5, v4.clone(), v0_1);
            let v7: string = patternInput.1.clone();
            let v6: string = patternInput.0.clone();
            if (if if Documents::method78(v7.clone()) {
                Documents::method78(v6.clone())
            } else {
                false
            } {
                let v11: string = Documents::method26();
                let _v12: MutCell<Option<string>> = MutCell::new(None::<string>);
                let v13: string = Documents::method27(v7.clone());
                let v16: Result<regex::Regex, regex::Error> =
                    regex::Regex::new(&string("^\\\\\\\\\\?\\\\"));
                let v18: regex::Regex = v16.unwrap();
                let v20: std::borrow::Cow<str> = v18.replace_all(&v13, &*v11);
                let v22: std::string::String = String::from(v20);
                {
                    let x: string = fable_library_rust::String_::fromString(v22);
                    _v12.set(Some(x))
                }
                {
                    let v31: string = match &_v12.get().clone() {
                        None => panic!("{}", string("base.run_target / _v12=None"),),
                        Some(_v12_0_0) => _v12_0_0.clone(),
                    };
                    let v35: string = replace(
                        sprintf!(
                            "{}{}",
                            toLower(ofChar(getCharAt(v31.clone(), 0_i32))),
                            getSlice(v31, Some(1_i32), None::<i32>)
                        ),
                        string("\\"),
                        string("/"),
                    );
                    let v37: Result<std::fs::File, std::io::Error> = std::fs::File::open(&*v35);
                    let v39: std::fs::File = v37.unwrap();
                    let v41: std::io::BufReader<std::fs::File> = std::io::BufReader::new(v39);
                    let v43: std::io::BufReader<std::io::BufReader<std::fs::File>> =
                        std::io::BufReader::new(v41);
                    let v45: bool = true;
                    let mut v43 = v43;
                    let result: sha2::Sha256 = sha2::Digest::new();
                    {
                        let v48: sha2::Sha256 = result;
                        let v50: bool = true;
                        let mut v48 = v48;
                        let v51: usize = 0_i32 as usize;
                        let v53: _ = [0_u8; 1024];
                        let v55: bool = true;
                        loop {
                            // rust.loop;
                            let v57: bool = true;
                            let mut v53 = v53;
                            let v59: Result<usize, std::io::Error> =
                                std::io::Read::read(&mut v43, &mut v53);
                            let v61: usize = v59.unwrap();
                            if v61 == v51 {
                                let v64: bool = true;
                                break;
                                ()
                            }
                            {
                                let v66: usize = v53.len();
                                let v67: u8 = v66 as u8;
                                let v68: usize = v61;
                                let v75: &_ = if v68 == v66 {
                                    &v53[v51..]
                                } else {
                                    &v53[v51..v68]
                                };
                                sha2::Digest::update(&mut v48, v75);
                                {
                                    let v78: bool = true;
                                } // rust.loop;
                                let v80: bool = true;
                            } // rust.loop;
                            let v82: bool = true;
                        } // rust.loop;
                        let v84: bool = true;
                        {
                            // rust.loop;
                            let v86: bool = true;
                            {
                                // rust.loop;
                                let v88: &[u8] = &sha2::Digest::finalize(v48);
                                let v90: Vec<u8> = v88.iter().map(|x| *x).collect::<Vec<_>>();
                                let v92: bool = true;
                                let _result: Vec<_> = v90
                                    .into_iter()
                                    .map(|x| {
                                        //;
                                        let v94: u8 = x;
                                        let v96: std::string::String = format!("{:02x}", v94);
                                        let v98: string =
                                            fable_library_rust::String_::fromString(v96);
                                        let v100: bool = true;
                                        v98
                                    })
                                    .collect::<Vec<_>>();
                                let v102: Vec<string> = _result;
                                let v104: Array<string> =
                                    fable_library_rust::NativeArray_::array_from(v102);
                                let v109: string = join(
                                    string(""),
                                    toArray(delay(Func0::new({
                                        let v104 = v104.clone();
                                        move || {
                                            map(
                                                Func1::new({
                                                    let v104 = v104.clone();
                                                    move |i: i32| v104[i].clone()
                                                }),
                                                rangeNumeric(
                                                    0_i32,
                                                    1_i32,
                                                    count_2(v104.clone()) - 1_i32,
                                                ),
                                            )
                                        }
                                    }))),
                                );
                                let v111 = Documents::method35();
                                let v113: Result<string, std::string::String> =
                                    Ok::<string, std::io::Error>(v109).map_err(|x| v111(x));
                                let v114 = Documents::method76();
                                let v115 = Documents::method77();
                                let v117: Documents::US28 = match v113 {
                                    Ok(x) => v114(x),
                                    Err(e) => v115(e),
                                };
                                let v123: string = match &v117 {
                                    Documents::US28::US28_0(v117_0_0) => v117_0_0.clone(),
                                    Documents::US28::US28_1(v117_1_0) => panic!(
                                        "{}",
                                        sprintf!(
                                            "resultm.get / Result value was Error: {}",
                                            v117_1_0.clone()
                                        ),
                                    ),
                                };
                                let v124: string = Documents::method26();
                                let _v125: MutCell<Option<string>> = MutCell::new(None::<string>);
                                let v126: string = Documents::method27(v6.clone());
                                let v128: Result<regex::Regex, regex::Error> =
                                    regex::Regex::new(&string("^\\\\\\\\\\?\\\\"));
                                let v130: regex::Regex = v128.unwrap();
                                let v132: std::borrow::Cow<str> = v130.replace_all(&v126, &*v124);
                                let v134: std::string::String = String::from(v132);
                                {
                                    let x_2: string = fable_library_rust::String_::fromString(v134);
                                    _v125.set(Some(x_2))
                                }
                                {
                                    let v143: string = match &_v125.get().clone() {
                                        None => {
                                            panic!("{}", string("base.run_target / _v125=None"),)
                                        }
                                        Some(_v125_0_0) => _v125_0_0.clone(),
                                    };
                                    let v145: string = replace(
                                        sprintf!(
                                            "{}{}",
                                            toLower(ofChar(getCharAt(v143.clone(), 0_i32))),
                                            getSlice(v143, Some(1_i32), None::<i32>)
                                        ),
                                        string("\\"),
                                        string("/"),
                                    );
                                    let v147: Result<std::fs::File, std::io::Error> =
                                        std::fs::File::open(&*v145);
                                    let v149: std::fs::File = v147.unwrap();
                                    let v151: std::io::BufReader<std::fs::File> =
                                        std::io::BufReader::new(v149);
                                    let v153: std::io::BufReader<
                                        std::io::BufReader<std::fs::File>,
                                    > = std::io::BufReader::new(v151);
                                    let v155: bool = true;
                                    let mut v153 = v153;
                                    let result: sha2::Sha256 = sha2::Digest::new();
                                    {
                                        let v158: sha2::Sha256 = result;
                                        let v160: bool = true;
                                        let mut v158 = v158;
                                        let v161: usize = 0_i32 as usize;
                                        let v163: _ = [0_u8; 1024];
                                        let v165: bool = true;
                                        loop {
                                            // rust.loop;
                                            let v167: bool = true;
                                            let mut v163 = v163;
                                            let v169: Result<usize, std::io::Error> =
                                                std::io::Read::read(&mut v153, &mut v163);
                                            let v171: usize = v169.unwrap();
                                            if v171 == v161 {
                                                let v174: bool = true;
                                                break;
                                                ()
                                            }
                                            {
                                                let v176: usize = v163.len();
                                                let v177: u8 = v176 as u8;
                                                let v178: usize = v171;
                                                let v185: &_ = if v178 == v176 {
                                                    &v163[v161..]
                                                } else {
                                                    &v163[v161..v178]
                                                };
                                                sha2::Digest::update(&mut v158, v185);
                                                {
                                                    let v188: bool = true;
                                                } // rust.loop;
                                                let v190: bool = true;
                                            } // rust.loop;
                                            let v192: bool = true;
                                        } // rust.loop;
                                        let v194: bool = true;
                                        {
                                            // rust.loop;
                                            let v196: bool = true;
                                            {
                                                // rust.loop;
                                                let v198: &[u8] = &sha2::Digest::finalize(v158);
                                                let v200: Vec<u8> =
                                                    v198.iter().map(|x| *x).collect::<Vec<_>>();
                                                let v202: bool = true;
                                                let _result: Vec<_> = v200
                                                    .into_iter()
                                                    .map(|x| {
                                                        //;
                                                        let v204: u8 = x;
                                                        let v206: std::string::String =
                                                            format!("{:02x}", v204);
                                                        let v208: string =
                                                            fable_library_rust::String_::fromString(
                                                                v206,
                                                            );
                                                        let v210: bool = true;
                                                        v208
                                                    })
                                                    .collect::<Vec<_>>();
                                                let v212: Vec<string> = _result;
                                                let v214: Array<string> =
                                                    fable_library_rust::NativeArray_::array_from(
                                                        v212,
                                                    );
                                                let v218: string = join(
                                                    string(""),
                                                    toArray(delay(Func0::new({
                                                        let v214 = v214.clone();
                                                        move || {
                                                            map(
                                                                Func1::new({
                                                                    let v214 = v214.clone();
                                                                    move |i_1: i32| {
                                                                        v214[i_1].clone()
                                                                    }
                                                                }),
                                                                rangeNumeric(
                                                                    0_i32,
                                                                    1_i32,
                                                                    count_2(v214.clone()) - 1_i32,
                                                                ),
                                                            )
                                                        }
                                                    }))),
                                                );
                                                let v220 = Documents::method35();
                                                let v222: Result<string, std::string::String> =
                                                    Ok::<string, std::io::Error>(v218)
                                                        .map_err(|x| v220(x));
                                                let v223 = Documents::method76();
                                                let v224 = Documents::method77();
                                                let v226: Documents::US28 = match v222 {
                                                    Ok(x) => v223(x),
                                                    Err(e) => v224(e),
                                                };
                                                v123 ==
                                                        match &v226 {
                                                            Documents::US28::US28_0(v226_0_0)
                                                            =>
                                                            v226_0_0.clone(),
                                                            Documents::US28::US28_1(v226_1_0)
                                                            =>
                                                            panic!("{}",
                                                                   sprintf!("resultm.get / Result value was Error: {}", v226_1_0.clone()),),
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
                let v236: Documents::US29 = Documents::method81(v2, v3, v7.clone(), v4);
                match &v236 {
                    Documents::US29::US29_0(v236_0_0, v236_0_1) => {
                        let v238: string = v236_0_1.clone();
                        let v237: i32 = v236_0_0.clone();
                        if v237 != 0_i32 {
                            Documents::method5(
                                Documents::US0::US0_2,
                                Func0::new(move || Documents::closure61((), ())),
                                Func0::new({
                                    let v237 = v237.clone();
                                    let v238 = v238.clone();
                                    move || Documents::closure62(v238.clone(), v237, ())
                                }),
                            );
                            Documents::US27::US27_0(Err::<string, LrcPtr<(string, string)>>(
                                LrcPtr::new((v7.clone(), v238.clone())),
                            ))
                        } else {
                            if Documents::method78(v7.clone()) {
                                Documents::method79(v6, v7.clone())
                            } else {
                                panic!(
                                    "{}",
                                    sprintf!("documents.files_fn / {} should exist", v7.clone()),
                                )
                            }
                            Documents::US27::US27_0(Ok::<string, LrcPtr<(string, string)>>(
                                v7.clone(),
                            ))
                        }
                    }
                    Documents::US29::US29_1(v236_1_0, v236_1_1) => {
                        Documents::US27::US27_0(Err::<string, LrcPtr<(string, string)>>(
                            LrcPtr::new((v7.clone(), v236_1_1.clone())),
                        ))
                    }
                }
            } else {
                Documents::US27::US27_1
            }
        }
        pub fn closure56(
            v0_1: string,
            v1_1: string,
            v2: string,
            v3: string,
            v4: string,
        ) -> Func1<string, Documents::US27> {
            Func1::new({
                let v0_1 = v0_1.clone();
                let v1_1 = v1_1.clone();
                let v2 = v2.clone();
                let v3 = v3.clone();
                let v4 = v4.clone();
                move |v: string| {
                    Documents::closure57(
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
        pub fn closure65(unitVar: (), unitVar_1: ()) -> string {
            string("documents.crowbook / result contains ERROR")
        }
        pub fn closure66(v0_1: string, v1_1: string, v2: i32, unitVar: ()) -> string {
            sprintf!(
                "exit_code: {:?} / output_path: {} / result: {} / {}",
                v2,
                v0_1,
                v1_1,
                Documents::closure6((), ())
            )
        }
        pub fn method87(
            v0_1: bool,
            v1_1: string,
            v2: string,
            v3: string,
            v4: string,
        ) -> Documents::US29 {
            let patternInput: (i32, string) = Documents::method41(
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
                                append(append(string("--set tex.paper.size a4paper tex.template.add \"\\pagenumbering{gobble}\""),
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
            let v59: string = patternInput.1.clone();
            let v58: i32 = patternInput.0.clone();
            if contains(v59.clone(), string("ERROR")) {
                Documents::method5(
                    Documents::US0::US0_3,
                    Func0::new(move || Documents::closure65((), ())),
                    Func0::new({
                        let v1_1 = v1_1.clone();
                        let v58 = v58.clone();
                        let v59 = v59.clone();
                        move || Documents::closure66(v1_1.clone(), v59.clone(), v58, ())
                    }),
                );
                Documents::US29::US29_1(v58, v59.clone())
            } else {
                Documents::US29::US29_0(v58, v59.clone())
            }
        }
        pub fn closure64(
            v0_1: string,
            v1_1: string,
            v2: bool,
            v3: string,
            v4: string,
        ) -> Documents::US27 {
            let patternInput: (string, string) = Documents::method74(v4.clone(), v3.clone(), v0_1);
            let v6: string = patternInput.1.clone();
            let v5: string = patternInput.0.clone();
            if (if if Documents::method78(v6.clone()) {
                Documents::method78(v5.clone())
            } else {
                false
            } {
                let v10: string = Documents::method26();
                let _v11: MutCell<Option<string>> = MutCell::new(None::<string>);
                let v12: string = Documents::method27(v6.clone());
                let v15: Result<regex::Regex, regex::Error> =
                    regex::Regex::new(&string("^\\\\\\\\\\?\\\\"));
                let v17: regex::Regex = v15.unwrap();
                let v19: std::borrow::Cow<str> = v17.replace_all(&v12, &*v10);
                let v21: std::string::String = String::from(v19);
                {
                    let x: string = fable_library_rust::String_::fromString(v21);
                    _v11.set(Some(x))
                }
                {
                    let v30: string = match &_v11.get().clone() {
                        None => panic!("{}", string("base.run_target / _v11=None"),),
                        Some(_v11_0_0) => _v11_0_0.clone(),
                    };
                    let v34: string = replace(
                        sprintf!(
                            "{}{}",
                            toLower(ofChar(getCharAt(v30.clone(), 0_i32))),
                            getSlice(v30, Some(1_i32), None::<i32>)
                        ),
                        string("\\"),
                        string("/"),
                    );
                    let v36: Result<std::fs::File, std::io::Error> = std::fs::File::open(&*v34);
                    let v38: std::fs::File = v36.unwrap();
                    let v40: std::io::BufReader<std::fs::File> = std::io::BufReader::new(v38);
                    let v42: std::io::BufReader<std::io::BufReader<std::fs::File>> =
                        std::io::BufReader::new(v40);
                    let v44: bool = true;
                    let mut v42 = v42;
                    let result: sha2::Sha256 = sha2::Digest::new();
                    {
                        let v47: sha2::Sha256 = result;
                        let v49: bool = true;
                        let mut v47 = v47;
                        let v50: usize = 0_i32 as usize;
                        let v52: _ = [0_u8; 1024];
                        let v54: bool = true;
                        loop {
                            // rust.loop;
                            let v56: bool = true;
                            let mut v52 = v52;
                            let v58: Result<usize, std::io::Error> =
                                std::io::Read::read(&mut v42, &mut v52);
                            let v60: usize = v58.unwrap();
                            if v60 == v50 {
                                let v63: bool = true;
                                break;
                                ()
                            }
                            {
                                let v65: usize = v52.len();
                                let v66: u8 = v65 as u8;
                                let v67: usize = v60;
                                let v74: &_ = if v67 == v65 {
                                    &v52[v50..]
                                } else {
                                    &v52[v50..v67]
                                };
                                sha2::Digest::update(&mut v47, v74);
                                {
                                    let v77: bool = true;
                                } // rust.loop;
                                let v79: bool = true;
                            } // rust.loop;
                            let v81: bool = true;
                        } // rust.loop;
                        let v83: bool = true;
                        {
                            // rust.loop;
                            let v85: bool = true;
                            {
                                // rust.loop;
                                let v87: &[u8] = &sha2::Digest::finalize(v47);
                                let v89: Vec<u8> = v87.iter().map(|x| *x).collect::<Vec<_>>();
                                let v91: bool = true;
                                let _result: Vec<_> = v89
                                    .into_iter()
                                    .map(|x| {
                                        //;
                                        let v93: u8 = x;
                                        let v95: std::string::String = format!("{:02x}", v93);
                                        let v97: string =
                                            fable_library_rust::String_::fromString(v95);
                                        let v99: bool = true;
                                        v97
                                    })
                                    .collect::<Vec<_>>();
                                let v101: Vec<string> = _result;
                                let v103: Array<string> =
                                    fable_library_rust::NativeArray_::array_from(v101);
                                let v108: string = join(
                                    string(""),
                                    toArray(delay(Func0::new({
                                        let v103 = v103.clone();
                                        move || {
                                            map(
                                                Func1::new({
                                                    let v103 = v103.clone();
                                                    move |i: i32| v103[i].clone()
                                                }),
                                                rangeNumeric(
                                                    0_i32,
                                                    1_i32,
                                                    count_2(v103.clone()) - 1_i32,
                                                ),
                                            )
                                        }
                                    }))),
                                );
                                let v110 = Documents::method35();
                                let v112: Result<string, std::string::String> =
                                    Ok::<string, std::io::Error>(v108).map_err(|x| v110(x));
                                let v113 = Documents::method76();
                                let v114 = Documents::method77();
                                let v116: Documents::US28 = match v112 {
                                    Ok(x) => v113(x),
                                    Err(e) => v114(e),
                                };
                                let v122: string = match &v116 {
                                    Documents::US28::US28_0(v116_0_0) => v116_0_0.clone(),
                                    Documents::US28::US28_1(v116_1_0) => panic!(
                                        "{}",
                                        sprintf!(
                                            "resultm.get / Result value was Error: {}",
                                            v116_1_0.clone()
                                        ),
                                    ),
                                };
                                let v123: string = Documents::method26();
                                let _v124: MutCell<Option<string>> = MutCell::new(None::<string>);
                                let v125: string = Documents::method27(v5.clone());
                                let v127: Result<regex::Regex, regex::Error> =
                                    regex::Regex::new(&string("^\\\\\\\\\\?\\\\"));
                                let v129: regex::Regex = v127.unwrap();
                                let v131: std::borrow::Cow<str> = v129.replace_all(&v125, &*v123);
                                let v133: std::string::String = String::from(v131);
                                {
                                    let x_2: string = fable_library_rust::String_::fromString(v133);
                                    _v124.set(Some(x_2))
                                }
                                {
                                    let v142: string = match &_v124.get().clone() {
                                        None => {
                                            panic!("{}", string("base.run_target / _v124=None"),)
                                        }
                                        Some(_v124_0_0) => _v124_0_0.clone(),
                                    };
                                    let v144: string = replace(
                                        sprintf!(
                                            "{}{}",
                                            toLower(ofChar(getCharAt(v142.clone(), 0_i32))),
                                            getSlice(v142, Some(1_i32), None::<i32>)
                                        ),
                                        string("\\"),
                                        string("/"),
                                    );
                                    let v146: Result<std::fs::File, std::io::Error> =
                                        std::fs::File::open(&*v144);
                                    let v148: std::fs::File = v146.unwrap();
                                    let v150: std::io::BufReader<std::fs::File> =
                                        std::io::BufReader::new(v148);
                                    let v152: std::io::BufReader<
                                        std::io::BufReader<std::fs::File>,
                                    > = std::io::BufReader::new(v150);
                                    let v154: bool = true;
                                    let mut v152 = v152;
                                    let result: sha2::Sha256 = sha2::Digest::new();
                                    {
                                        let v157: sha2::Sha256 = result;
                                        let v159: bool = true;
                                        let mut v157 = v157;
                                        let v160: usize = 0_i32 as usize;
                                        let v162: _ = [0_u8; 1024];
                                        let v164: bool = true;
                                        loop {
                                            // rust.loop;
                                            let v166: bool = true;
                                            let mut v162 = v162;
                                            let v168: Result<usize, std::io::Error> =
                                                std::io::Read::read(&mut v152, &mut v162);
                                            let v170: usize = v168.unwrap();
                                            if v170 == v160 {
                                                let v173: bool = true;
                                                break;
                                                ()
                                            }
                                            {
                                                let v175: usize = v162.len();
                                                let v176: u8 = v175 as u8;
                                                let v177: usize = v170;
                                                let v184: &_ = if v177 == v175 {
                                                    &v162[v160..]
                                                } else {
                                                    &v162[v160..v177]
                                                };
                                                sha2::Digest::update(&mut v157, v184);
                                                {
                                                    let v187: bool = true;
                                                } // rust.loop;
                                                let v189: bool = true;
                                            } // rust.loop;
                                            let v191: bool = true;
                                        } // rust.loop;
                                        let v193: bool = true;
                                        {
                                            // rust.loop;
                                            let v195: bool = true;
                                            {
                                                // rust.loop;
                                                let v197: &[u8] = &sha2::Digest::finalize(v157);
                                                let v199: Vec<u8> =
                                                    v197.iter().map(|x| *x).collect::<Vec<_>>();
                                                let v201: bool = true;
                                                let _result: Vec<_> = v199
                                                    .into_iter()
                                                    .map(|x| {
                                                        //;
                                                        let v203: u8 = x;
                                                        let v205: std::string::String =
                                                            format!("{:02x}", v203);
                                                        let v207: string =
                                                            fable_library_rust::String_::fromString(
                                                                v205,
                                                            );
                                                        let v209: bool = true;
                                                        v207
                                                    })
                                                    .collect::<Vec<_>>();
                                                let v211: Vec<string> = _result;
                                                let v213: Array<string> =
                                                    fable_library_rust::NativeArray_::array_from(
                                                        v211,
                                                    );
                                                let v217: string = join(
                                                    string(""),
                                                    toArray(delay(Func0::new({
                                                        let v213 = v213.clone();
                                                        move || {
                                                            map(
                                                                Func1::new({
                                                                    let v213 = v213.clone();
                                                                    move |i_1: i32| {
                                                                        v213[i_1].clone()
                                                                    }
                                                                }),
                                                                rangeNumeric(
                                                                    0_i32,
                                                                    1_i32,
                                                                    count_2(v213.clone()) - 1_i32,
                                                                ),
                                                            )
                                                        }
                                                    }))),
                                                );
                                                let v219 = Documents::method35();
                                                let v221: Result<string, std::string::String> =
                                                    Ok::<string, std::io::Error>(v217)
                                                        .map_err(|x| v219(x));
                                                let v222 = Documents::method76();
                                                let v223 = Documents::method77();
                                                let v225: Documents::US28 = match v221 {
                                                    Ok(x) => v222(x),
                                                    Err(e) => v223(e),
                                                };
                                                v122 ==
                                                        match &v225 {
                                                            Documents::US28::US28_0(v225_0_0)
                                                            =>
                                                            v225_0_0.clone(),
                                                            Documents::US28::US28_1(v225_1_0)
                                                            =>
                                                            panic!("{}",
                                                                   sprintf!("resultm.get / Result value was Error: {}", v225_1_0.clone()),),
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
                let v235: Documents::US29 = Documents::method87(v2, v6.clone(), v3, v1_1, v4);
                match &v235 {
                    Documents::US29::US29_0(v235_0_0, v235_0_1) => {
                        let v237: string = v235_0_1.clone();
                        let v236: i32 = v235_0_0.clone();
                        if v236 != 0_i32 {
                            Documents::method5(
                                Documents::US0::US0_2,
                                Func0::new(move || Documents::closure61((), ())),
                                Func0::new({
                                    let v236 = v236.clone();
                                    let v237 = v237.clone();
                                    move || Documents::closure62(v237.clone(), v236, ())
                                }),
                            );
                            Documents::US27::US27_0(Err::<string, LrcPtr<(string, string)>>(
                                LrcPtr::new((v6.clone(), v237.clone())),
                            ))
                        } else {
                            if Documents::method78(v6.clone()) {
                                Documents::method79(v5, v6.clone())
                            } else {
                                panic!(
                                    "{}",
                                    sprintf!("documents.files_fn / {} should exist", v6.clone()),
                                )
                            }
                            Documents::US27::US27_0(Ok::<string, LrcPtr<(string, string)>>(
                                v6.clone(),
                            ))
                        }
                    }
                    Documents::US29::US29_1(v235_1_0, v235_1_1) => {
                        Documents::US27::US27_0(Err::<string, LrcPtr<(string, string)>>(
                            LrcPtr::new((v6.clone(), v235_1_1.clone())),
                        ))
                    }
                }
            } else {
                Documents::US27::US27_1
            }
        }
        pub fn closure63(
            v0_1: string,
            v1_1: string,
            v2: bool,
            v3: string,
        ) -> Func1<string, Documents::US27> {
            Func1::new({
                let v0_1 = v0_1.clone();
                let v1_1 = v1_1.clone();
                let v2 = v2.clone();
                let v3 = v3.clone();
                move |v: string| Documents::closure64(v0_1.clone(), v1_1.clone(), v2, v3.clone(), v)
            })
        }
        pub fn closure67(unitVar: (), unitVar_1: ()) -> string {
            string("documents.run / par_map / files\' = [] / listm.iter")
        }
        pub fn closure68(v0_1: string, v1_1: string, unitVar: ()) -> string {
            sprintf!(
                "output_path: {:?} / output_cache_path: {} / {}",
                v1_1,
                v0_1,
                Documents::closure6((), ())
            )
        }
        pub fn method88(
            v0_1: LrcPtr<Documents::UH3>,
            v1_1: List<LrcPtr<Documents::UH4>>,
        ) -> List<LrcPtr<Documents::UH4>> {
            match v0_1.as_ref() {
                Documents::UH3::UH3_0 => v1_1.clone(),
                Documents::UH3::UH3_1(v0_1_1_0, v0_1_1_1) => cons(
                    match v0_1.as_ref() {
                        Documents::UH3::UH3_1(x, _) => x.clone(),
                        _ => unreachable!(),
                    },
                    Documents::method88(
                        match v0_1.as_ref() {
                            Documents::UH3::UH3_1(_, x) => x.clone(),
                            _ => unreachable!(),
                        },
                        v1_1.clone(),
                    ),
                ),
            }
        }
        pub fn method89(v0_1: i32, v1_1: LrcPtr<Documents::Mut8>) -> bool {
            v1_1.l0.get().clone() < v0_1
        }
        pub fn method90(
            v0_1: LrcPtr<Documents::UH4>,
            v1_1: List<(
                string,
                string,
                Func1<string, Func1<string, Documents::US27>>,
            )>,
        ) -> List<(
            string,
            string,
            Func1<string, Func1<string, Documents::US27>>,
        )> {
            match v0_1.as_ref() {
                Documents::UH4::UH4_0 => v1_1.clone(),
                Documents::UH4::UH4_1(v0_1_1_0, v0_1_1_1, v0_1_1_2, v0_1_1_3) => cons(
                    (
                        match v0_1.as_ref() {
                            Documents::UH4::UH4_1(x, _, _, _) => x.clone(),
                            _ => unreachable!(),
                        },
                        match v0_1.as_ref() {
                            Documents::UH4::UH4_1(_, x, _, _) => x.clone(),
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
                                            Documents::UH4::UH4_1(_, _, x, _) => x.clone(),
                                            _ => unreachable!(),
                                        })(a0.clone(), a1)
                                    }
                                })
                            }
                        }),
                    ),
                    Documents::method90(
                        match v0_1.as_ref() {
                            Documents::UH4::UH4_1(_, _, _, x) => x.clone(),
                            _ => unreachable!(),
                        },
                        v1_1.clone(),
                    ),
                ),
            }
        }
        pub fn closure69(
            unitVar: (),
            _arg: (
                string,
                string,
                Func1<string, Func1<string, Documents::US27>>,
            ),
        ) -> Option<Result<string, LrcPtr<(string, string)>>> {
            let v4: Documents::US27 = (_arg.2.clone())(_arg.1.clone())(_arg.0.clone());
            match &v4 {
                Documents::US27::US27_0(v4_0_0) => Some(match &v4 {
                    Documents::US27::US27_0(x) => x.clone(),
                    _ => unreachable!(),
                }),
                _ => None::<Result<string, LrcPtr<(string, string)>>>,
            }
        }
        pub fn method91(
            v0_1: Vec<Option<Result<string, LrcPtr<(string, string)>>>>,
        ) -> Vec<Option<Result<string, LrcPtr<(string, string)>>>> {
            v0_1
        }
        pub fn method92(
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
            let v6: string = Documents::method23(v5);
            let v8: &str = &*v6.clone();
            let v10: std::string::String = String::from(v8);
            let v12: std::path::PathBuf = std::path::PathBuf::from(v10);
            let v14: std::path::Display = v12.display();
            let _v15: MutCell<Option<std::string::String>> =
                MutCell::new(None::<std::string::String>);
            {
                let x: std::string::String = format!("{}", v14);
                _v15.set(Some(x))
            }
            {
                let v25: std::string::String = match &_v15.get().clone() {
                    None => panic!("{}", string("base.run_target / _v15=None"),),
                    Some(_v15_0_0) => _v15_0_0.clone(),
                };
                let v33: string = sprintf!(
                    ".{}",
                    replace(
                        replace(
                            fable_library_rust::String_::fromString(v25),
                            v3.clone(),
                            string("")
                        ),
                        string("\\"),
                        string("/")
                    )
                );
                let v34: string = Documents::method26();
                let _v35: MutCell<Option<string>> = MutCell::new(None::<string>);
                let v36: string = Documents::method27(v6);
                let v39: Result<regex::Regex, regex::Error> =
                    regex::Regex::new(&string("^\\\\\\\\\\?\\\\"));
                let v41: regex::Regex = v39.unwrap();
                let v43: std::borrow::Cow<str> = v41.replace_all(&v36, &*v34);
                let v45: std::string::String = String::from(v43);
                {
                    let x_2: string = fable_library_rust::String_::fromString(v45);
                    _v35.set(Some(x_2))
                }
                {
                    let v54: string = match &_v35.get().clone() {
                        None => panic!("{}", string("base.run_target / _v35=None"),),
                        Some(_v35_0_0) => _v35_0_0.clone(),
                    };
                    let v56: string = replace(
                        sprintf!(
                            "{}{}",
                            toLower(ofChar(getCharAt(v54.clone(), 0_i32))),
                            getSlice(v54, Some(1_i32), None::<i32>)
                        ),
                        string("\\"),
                        string("/"),
                    );
                    let v58: string =
                        Documents::method40(Documents::method15(v2.clone(), v33.clone()));
                    let patternInput: (i32, string) = Documents::method41(
                        None::<CancellationToken>,
                        sprintf!(
                            "git ls-tree --format=\'%(objectname)\' origin/gh-pages \"{}\"",
                            v58.clone()
                        ),
                        new_empty::<(string, string)>(),
                        None::<Func1<(bool, string, i32), Arc<Async<()>>>>,
                        None::<Func1<std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>, ()>>,
                        true,
                        Some(v2),
                    );
                    let v68: string = patternInput.1.clone();
                    let v70: string =
                        Documents::method40(Documents::method15(v3.clone(), v33.clone()));
                    let patternInput_1: (i32, string) = Documents::method41(
                        None::<CancellationToken>,
                        sprintf!("git hash-object \"{}\"", v70.clone()),
                        new_empty::<(string, string)>(),
                        None::<Func1<(bool, string, i32), Arc<Async<()>>>>,
                        None::<Func1<std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>, ()>>,
                        true,
                        Some(v3.clone()),
                    );
                    let v80: string = patternInput_1.1.clone();
                    let v82: string =
                        Documents::method40(Documents::method15(v4.clone(), v33.clone()));
                    let v85: string =
                        (Documents::method74(string("hangul.md"), v70.clone(), v4.clone()))
                            .1
                            .clone();
                    let v352: LrcPtr<Documents::UH3> = if contains(v68.clone(), v80.clone())
                        == false
                    {
                        let v94: string = Documents::method26();
                        let _v95: MutCell<Option<string>> = MutCell::new(None::<string>);
                        let v96: string = Documents::method27(v70.clone());
                        let v98: Result<regex::Regex, regex::Error> =
                            regex::Regex::new(&string("^\\\\\\\\\\?\\\\"));
                        let v100: regex::Regex = v98.unwrap();
                        let v102: std::borrow::Cow<str> = v100.replace_all(&v96, &*v94);
                        let v104: std::string::String = String::from(v102);
                        {
                            let x_4: string = fable_library_rust::String_::fromString(v104);
                            _v95.set(Some(x_4))
                        }
                        {
                            let v113: string = match &_v95.get().clone() {
                                None => panic!("{}", string("base.run_target / _v95=None"),),
                                Some(_v95_0_0) => _v95_0_0.clone(),
                            };
                            let v115: string = replace(
                                sprintf!(
                                    "{}{}",
                                    toLower(ofChar(getCharAt(v113.clone(), 0_i32))),
                                    getSlice(v113, Some(1_i32), None::<i32>)
                                ),
                                string("\\"),
                                string("/"),
                            );
                            let v117: Result<std::fs::File, std::io::Error> =
                                std::fs::File::open(&*v115);
                            let v119: std::fs::File = v117.unwrap();
                            let v121: std::io::BufReader<std::fs::File> =
                                std::io::BufReader::new(v119);
                            let v123: std::io::BufReader<std::io::BufReader<std::fs::File>> =
                                std::io::BufReader::new(v121);
                            let v125: bool = true;
                            let mut v123 = v123;
                            let result: sha2::Sha256 = sha2::Digest::new();
                            {
                                let v128: sha2::Sha256 = result;
                                let v130: bool = true;
                                let mut v128 = v128;
                                let v131: usize = 0_i32 as usize;
                                let v133: _ = [0_u8; 1024];
                                let v135: bool = true;
                                loop {
                                    // rust.loop;
                                    let v137: bool = true;
                                    let mut v133 = v133;
                                    let v139: Result<usize, std::io::Error> =
                                        std::io::Read::read(&mut v123, &mut v133);
                                    let v141: usize = v139.unwrap();
                                    if v141 == v131 {
                                        let v144: bool = true;
                                        break;
                                        ()
                                    }
                                    {
                                        let v146: usize = v133.len();
                                        let v147: u8 = v146 as u8;
                                        let v148: usize = v141;
                                        let v155: &_ = if v148 == v146 {
                                            &v133[v131..]
                                        } else {
                                            &v133[v131..v148]
                                        };
                                        sha2::Digest::update(&mut v128, v155);
                                        {
                                            let v158: bool = true;
                                        } // rust.loop;
                                        let v160: bool = true;
                                    } // rust.loop;
                                    let v162: bool = true;
                                } // rust.loop;
                                let v164: bool = true;
                                {
                                    // rust.loop;
                                    let v166: bool = true;
                                    {
                                        // rust.loop;
                                        let v168: &[u8] = &sha2::Digest::finalize(v128);
                                        let v170: Vec<u8> =
                                            v168.iter().map(|x| *x).collect::<Vec<_>>();
                                        let v172: bool = true;
                                        let _result: Vec<_> = v170
                                            .into_iter()
                                            .map(|x| {
                                                //;
                                                let v174: u8 = x;
                                                let v176: std::string::String =
                                                    format!("{:02x}", v174);
                                                let v178: string =
                                                    fable_library_rust::String_::fromString(v176);
                                                let v180: bool = true;
                                                v178
                                            })
                                            .collect::<Vec<_>>();
                                        let v182: Vec<string> = _result;
                                        let v184: Array<string> =
                                            fable_library_rust::NativeArray_::array_from(v182);
                                        let v188: string = join(
                                            string(""),
                                            toArray(delay(Func0::new({
                                                let v184 = v184.clone();
                                                move || {
                                                    map(
                                                        Func1::new({
                                                            let v184 = v184.clone();
                                                            move |i: i32| v184[i].clone()
                                                        }),
                                                        rangeNumeric(
                                                            0_i32,
                                                            1_i32,
                                                            count_2(v184.clone()) - 1_i32,
                                                        ),
                                                    )
                                                }
                                            }))),
                                        );
                                        let v190 = Documents::method35();
                                        let v192: Result<string, std::string::String> =
                                            Ok::<string, std::io::Error>(v188).map_err(|x| v190(x));
                                        let v193 = Documents::method76();
                                        let v194 = Documents::method77();
                                        let v196: Documents::US28 = match v192 {
                                            Ok(x) => v193(x),
                                            Err(e) => v194(e),
                                        };
                                        let v202: string = match &v196 {
                                            Documents::US28::US28_0(v196_0_0) => v196_0_0.clone(),
                                            Documents::US28::US28_1(v196_1_0) => panic!(
                                                "{}",
                                                sprintf!(
                                                    "resultm.get / Result value was Error: {}",
                                                    v196_1_0.clone()
                                                ),
                                            ),
                                        };
                                        let v315: Documents::US3 = if Documents::method78(
                                            v82.clone(),
                                        ) == false
                                        {
                                            Documents::US3::US3_1
                                        } else {
                                            let v206: string = Documents::method26();
                                            let _v207: MutCell<Option<string>> =
                                                MutCell::new(None::<string>);
                                            let v208: string = Documents::method27(v82.clone());
                                            let v210: Result<regex::Regex, regex::Error> =
                                                regex::Regex::new(&string("^\\\\\\\\\\?\\\\"));
                                            let v212: regex::Regex = v210.unwrap();
                                            let v214: std::borrow::Cow<str> =
                                                v212.replace_all(&v208, &*v206);
                                            let v216: std::string::String = String::from(v214);
                                            {
                                                let x_6: string =
                                                    fable_library_rust::String_::fromString(v216);
                                                _v207.set(Some(x_6))
                                            }
                                            {
                                                let v225: string = match &_v207.get().clone() {
                                                    None => panic!(
                                                        "{}",
                                                        string("base.run_target / _v207=None"),
                                                    ),
                                                    Some(_v207_0_0) => _v207_0_0.clone(),
                                                };
                                                let v227: string = replace(
                                                    sprintf!(
                                                        "{}{}",
                                                        toLower(ofChar(getCharAt(
                                                            v225.clone(),
                                                            0_i32
                                                        ))),
                                                        getSlice(v225, Some(1_i32), None::<i32>)
                                                    ),
                                                    string("\\"),
                                                    string("/"),
                                                );
                                                let v229: Result<std::fs::File, std::io::Error> =
                                                    std::fs::File::open(&*v227);
                                                let v231: std::fs::File = v229.unwrap();
                                                let v233: std::io::BufReader<std::fs::File> =
                                                    std::io::BufReader::new(v231);
                                                let v235: std::io::BufReader<
                                                    std::io::BufReader<std::fs::File>,
                                                > = std::io::BufReader::new(v233);
                                                let v237: bool = true;
                                                let mut v235 = v235;
                                                let result: sha2::Sha256 = sha2::Digest::new();
                                                {
                                                    let v240: sha2::Sha256 = result;
                                                    let v242: bool = true;
                                                    let mut v240 = v240;
                                                    let v243: usize = 0_i32 as usize;
                                                    let v245: _ = [0_u8; 1024];
                                                    let v247: bool = true;
                                                    loop {
                                                        // rust.loop;
                                                        let v249: bool = true;
                                                        let mut v245 = v245;
                                                        let v251: Result<usize, std::io::Error> =
                                                            std::io::Read::read(
                                                                &mut v235, &mut v245,
                                                            );
                                                        let v253: usize = v251.unwrap();
                                                        if v253 == v243 {
                                                            let v256: bool = true;
                                                            break;
                                                            ()
                                                        }
                                                        {
                                                            let v258: usize = v245.len();
                                                            let v259: u8 = v258 as u8;
                                                            let v260: usize = v253;
                                                            let v267: &_ = if v260 == v258 {
                                                                &v245[v243..]
                                                            } else {
                                                                &v245[v243..v260]
                                                            };
                                                            sha2::Digest::update(&mut v240, v267);
                                                            {
                                                                let v270: bool = true;
                                                            } // rust.loop;
                                                            let v272: bool = true;
                                                        } // rust.loop;
                                                        let v274: bool = true;
                                                    } // rust.loop;
                                                    let v276: bool = true;
                                                    {
                                                        // rust.loop;
                                                        let v278: bool = true;
                                                        {
                                                            // rust.loop;
                                                            let v280: &[u8] =
                                                                &sha2::Digest::finalize(v240);
                                                            let v282: Vec<u8> = v280
                                                                .iter()
                                                                .map(|x| *x)
                                                                .collect::<Vec<_>>();
                                                            let v284: bool = true;
                                                            let _result : Vec<_> = v282.into_iter().map(|x| { //;
                                                                    let v286:
                                                                            u8 =
                                                                        x;
                                                                    let v288:
                                                                            std::string::String =
                                                                        format!("{:02x}", v286);
                                                                    let v290:
                                                                            string =
                                                                        fable_library_rust::String_::fromString(v288);
                                                                    let v292:
                                                                            bool =
                                                                        true; v290 }).collect::<Vec<_>>();
                                                            let v294: Vec<string> = _result;
                                                            let v296:
                                                                            Array<string> =
                                                                        fable_library_rust::NativeArray_::array_from(v294);
                                                            let v300: string = join(
                                                                string(""),
                                                                toArray(delay(Func0::new({
                                                                    let v296 = v296.clone();
                                                                    move || {
                                                                        map(
                                                                            Func1::new({
                                                                                let v296 =
                                                                                    v296.clone();
                                                                                move |i_1: i32| {
                                                                                    v296[i_1]
                                                                                        .clone()
                                                                                }
                                                                            }),
                                                                            rangeNumeric(
                                                                                0_i32,
                                                                                1_i32,
                                                                                count_2(
                                                                                    v296.clone(),
                                                                                ) - 1_i32,
                                                                            ),
                                                                        )
                                                                    }
                                                                }))),
                                                            );
                                                            let v302 = Documents::method35();
                                                            let v304: Result<
                                                                string,
                                                                std::string::String,
                                                            > = Ok::<string, std::io::Error>(v300)
                                                                .map_err(|x| v302(x));
                                                            let v305 = Documents::method76();
                                                            let v306 = Documents::method77();
                                                            let v308: Documents::US28 = match v304 {
                                                                Ok(x) => v305(x),
                                                                Err(e) => v306(e),
                                                            };
                                                            match &v308 {
                                                                Documents::US28::US28_0(
                                                                    v308_0_0,
                                                                ) => Documents::US3::US3_0(
                                                                    v308_0_0.clone(),
                                                                ),
                                                                _ => Documents::US3::US3_1,
                                                            }
                                                        }
                                                    }
                                                }
                                            }
                                        };
                                        if if if let Documents::US3::US3_1 = &v315 {
                                            true
                                        } else {
                                            false
                                        } {
                                            true
                                        } else {
                                            v202.clone()
                                                != match &v315 {
                                                    Documents::US3::US3_0(v315_0_0) => {
                                                        match &v315 {
                                                            Documents::US3::US3_0(x) => x.clone(),
                                                            _ => unreachable!(),
                                                        }
                                                    }
                                                    _ => panic!(
                                                        "{}",
                                                        string("Option does not have a value."),
                                                    ),
                                                }
                                        } {
                                            Documents::method5(
                                                Documents::US0::US0_2,
                                                Func0::new(move || Documents::closure54((), ())),
                                                Func0::new({
                                                    let patternInput = patternInput.clone();
                                                    let patternInput_1 = patternInput_1.clone();
                                                    let v202 = v202.clone();
                                                    let v315 = v315.clone();
                                                    let v33 = v33.clone();
                                                    let v56 = v56.clone();
                                                    let v58 = v58.clone();
                                                    let v68 = v68.clone();
                                                    let v70 = v70.clone();
                                                    let v80 = v80.clone();
                                                    let v82 = v82.clone();
                                                    move || {
                                                        Documents::closure55(
                                                            v33.clone(),
                                                            v56.clone(),
                                                            v58.clone(),
                                                            v68.clone(),
                                                            patternInput.0.clone(),
                                                            v70.clone(),
                                                            v80.clone(),
                                                            patternInput_1.0.clone(),
                                                            v82.clone(),
                                                            v202.clone(),
                                                            v315.clone(),
                                                            (),
                                                        )
                                                    }
                                                }),
                                            );
                                            Documents::method79(v82.clone(), v70.clone());
                                            LrcPtr::new(Documents::UH3::UH3_1(LrcPtr::new(Documents::UH4::UH4_1(string("hangul.md"),
                                                                                                                    v70.clone(),
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
                                                                                                                                                           |v:
                                                                                                                                                                string|
                                                                                                                                                           Documents::closure56(v4.clone(),
                                                                                                                                                                                v3.clone(),
                                                                                                                                                                                v1_1.clone(),
                                                                                                                                                                                v0_1.clone(),
                                                                                                                                                                                v)
                                                                                                                                                   }))(b0)(b1)
                                                                                                                               }),
                                                                                                                    LrcPtr::new(Documents::UH4::UH4_0))),
                                                                                  LrcPtr::new(Documents::UH3::UH3_1(LrcPtr::new(Documents::UH4::UH4_1(string("html"),
                                                                                                                                                      v70.clone(),
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
                                                                                                                                                                                             |v_1:
                                                                                                                                                                                                  string|
                                                                                                                                                                                             Documents::closure63(v4.clone(),
                                                                                                                                                                                                                  v3.clone(),
                                                                                                                                                                                                                  false,
                                                                                                                                                                                                                  v_1)
                                                                                                                                                                                     }))(b0)(b1)
                                                                                                                                                                 }),
                                                                                                                                                      LrcPtr::new(Documents::UH4::UH4_1(string("pdf"),
                                                                                                                                                                                        v70.clone(),
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
                                                                                                                                                                                                                               Documents::closure63(v4.clone(),
                                                                                                                                                                                                                                                    v3.clone(),
                                                                                                                                                                                                                                                    false,
                                                                                                                                                                                                                                                    v_2)
                                                                                                                                                                                                                       }))(b0)(b1)
                                                                                                                                                                                                   }),
                                                                                                                                                                                        LrcPtr::new(Documents::UH4::UH4_1(string("epub"),
                                                                                                                                                                                                                          v70.clone(),
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
                                                                                                                                                                                                                                                                 Documents::closure63(v4.clone(),
                                                                                                                                                                                                                                                                                      v3.clone(),
                                                                                                                                                                                                                                                                                      false,
                                                                                                                                                                                                                                                                                      v_3)
                                                                                                                                                                                                                                                         }))(b0)(b1)
                                                                                                                                                                                                                                     }),
                                                                                                                                                                                                                          LrcPtr::new(Documents::UH4::UH4_1(string("html"),
                                                                                                                                                                                                                                                            v85.clone(),
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
                                                                                                                                                                                                                                                                                                   Documents::closure63(v4.clone(),
                                                                                                                                                                                                                                                                                                                        v3.clone(),
                                                                                                                                                                                                                                                                                                                        true,
                                                                                                                                                                                                                                                                                                                        v_4)
                                                                                                                                                                                                                                                                                           }))(b0)(b1)
                                                                                                                                                                                                                                                                       }),
                                                                                                                                                                                                                                                            LrcPtr::new(Documents::UH4::UH4_1(string("pdf"),
                                                                                                                                                                                                                                                                                              v85.clone(),
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
                                                                                                                                                                                                                                                                                                                                     Documents::closure63(v4.clone(),
                                                                                                                                                                                                                                                                                                                                                          v3.clone(),
                                                                                                                                                                                                                                                                                                                                                          true,
                                                                                                                                                                                                                                                                                                                                                          v_5)
                                                                                                                                                                                                                                                                                                                             }))(b0)(b1)
                                                                                                                                                                                                                                                                                                         }),
                                                                                                                                                                                                                                                                                              LrcPtr::new(Documents::UH4::UH4_1(string("epub"),
                                                                                                                                                                                                                                                                                                                                v85.clone(),
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
                                                                                                                                                                                                                                                                                                                                                                       Documents::closure63(v4.clone(),
                                                                                                                                                                                                                                                                                                                                                                                            v3.clone(),
                                                                                                                                                                                                                                                                                                                                                                                            true,
                                                                                                                                                                                                                                                                                                                                                                                            v_6)
                                                                                                                                                                                                                                                                                                                                                               }))(b0)(b1)
                                                                                                                                                                                                                                                                                                                                           }),
                                                                                                                                                                                                                                                                                                                                LrcPtr::new(Documents::UH4::UH4_0))))))))))))),
                                                                                                                    LrcPtr::new(Documents::UH3::UH3_0)))))
                                        } else {
                                            LrcPtr::new(Documents::UH3::UH3_0)
                                        }
                                    }
                                }
                            }
                        }
                    } else {
                        LrcPtr::new(Documents::UH3::UH3_0)
                    };
                    let v461: Array<LrcPtr<Documents::UH4>> = toArray_1(Documents::method88(
                        if (if let Documents::UH3::UH3_0 = v352.as_ref() {
                            true
                        } else {
                            false
                        }) != true
                        {
                            v352
                        } else {
                            let patternInput_3: (string, string) =
                                Documents::method74(string("epub"), v85.clone(), v4.clone());
                            let v358: string = patternInput_3.1.clone();
                            let v357: string = patternInput_3.0.clone();
                            let v371: LrcPtr<Documents::UH4> =
                                if if Documents::method78(v358.clone()) == false {
                                    if Documents::method78(v357.clone()) {
                                        Documents::method5(
                                            Documents::US0::US0_2,
                                            Func0::new(move || Documents::closure67((), ())),
                                            Func0::new({
                                                let v357 = v357.clone();
                                                let v358 = v358.clone();
                                                move || {
                                                    Documents::closure68(
                                                        v357.clone(),
                                                        v358.clone(),
                                                        (),
                                                    )
                                                }
                                            }),
                                        );
                                        Documents::method79(v358.clone(), v357.clone());
                                        false
                                    } else {
                                        true
                                    }
                                } else {
                                    true
                                } {
                                    LrcPtr::new(Documents::UH4::UH4_1(
                                        string("epub"),
                                        v85.clone(),
                                        Func2::new({
                                            let v3 = v3.clone();
                                            let v4 = v4.clone();
                                            move |b0: string, b1: string| {
                                                (Func1::new({
                                                    let v3 = v3.clone();
                                                    let v4 = v4.clone();
                                                    move |v_7: string| {
                                                        Documents::closure63(
                                                            v4.clone(),
                                                            v3.clone(),
                                                            true,
                                                            v_7,
                                                        )
                                                    }
                                                }))(
                                                    b0
                                                )(b1)
                                            }
                                        }),
                                        LrcPtr::new(Documents::UH4::UH4_0),
                                    ))
                                } else {
                                    LrcPtr::new(Documents::UH4::UH4_0)
                                };
                            let patternInput_4: (string, string) =
                                Documents::method74(string("pdf"), v85.clone(), v4.clone());
                            let v374: string = patternInput_4.1.clone();
                            let v373: string = patternInput_4.0.clone();
                            let v385: LrcPtr<Documents::UH4> =
                                if if Documents::method78(v374.clone()) == false {
                                    if Documents::method78(v373.clone()) {
                                        Documents::method5(
                                            Documents::US0::US0_2,
                                            Func0::new(move || Documents::closure67((), ())),
                                            Func0::new({
                                                let v373 = v373.clone();
                                                let v374 = v374.clone();
                                                move || {
                                                    Documents::closure68(
                                                        v373.clone(),
                                                        v374.clone(),
                                                        (),
                                                    )
                                                }
                                            }),
                                        );
                                        Documents::method79(v374.clone(), v373.clone());
                                        false
                                    } else {
                                        true
                                    }
                                } else {
                                    true
                                } {
                                    LrcPtr::new(Documents::UH4::UH4_1(
                                        string("pdf"),
                                        v85.clone(),
                                        Func2::new({
                                            let v3 = v3.clone();
                                            let v4 = v4.clone();
                                            move |b0: string, b1: string| {
                                                (Func1::new({
                                                    let v3 = v3.clone();
                                                    let v4 = v4.clone();
                                                    move |v_8: string| {
                                                        Documents::closure63(
                                                            v4.clone(),
                                                            v3.clone(),
                                                            true,
                                                            v_8,
                                                        )
                                                    }
                                                }))(
                                                    b0
                                                )(b1)
                                            }
                                        }),
                                        v371.clone(),
                                    ))
                                } else {
                                    v371
                                };
                            let patternInput_5: (string, string) =
                                Documents::method74(string("html"), v85.clone(), v4.clone());
                            let v388: string = patternInput_5.1.clone();
                            let v387: string = patternInput_5.0.clone();
                            let v399: LrcPtr<Documents::UH4> =
                                if if Documents::method78(v388.clone()) == false {
                                    if Documents::method78(v387.clone()) {
                                        Documents::method5(
                                            Documents::US0::US0_2,
                                            Func0::new(move || Documents::closure67((), ())),
                                            Func0::new({
                                                let v387 = v387.clone();
                                                let v388 = v388.clone();
                                                move || {
                                                    Documents::closure68(
                                                        v387.clone(),
                                                        v388.clone(),
                                                        (),
                                                    )
                                                }
                                            }),
                                        );
                                        Documents::method79(v388.clone(), v387.clone());
                                        false
                                    } else {
                                        true
                                    }
                                } else {
                                    true
                                } {
                                    LrcPtr::new(Documents::UH4::UH4_1(
                                        string("html"),
                                        v85,
                                        Func2::new({
                                            let v3 = v3.clone();
                                            let v4 = v4.clone();
                                            move |b0: string, b1: string| {
                                                (Func1::new({
                                                    let v3 = v3.clone();
                                                    let v4 = v4.clone();
                                                    move |v_9: string| {
                                                        Documents::closure63(
                                                            v4.clone(),
                                                            v3.clone(),
                                                            true,
                                                            v_9,
                                                        )
                                                    }
                                                }))(
                                                    b0
                                                )(b1)
                                            }
                                        }),
                                        v385.clone(),
                                    ))
                                } else {
                                    v385
                                };
                            let patternInput_6: (string, string) =
                                Documents::method74(string("epub"), v70.clone(), v4.clone());
                            let v401: string = patternInput_6.1.clone();
                            let v400: string = patternInput_6.0.clone();
                            let v412: LrcPtr<Documents::UH4> =
                                if if Documents::method78(v401.clone()) == false {
                                    if Documents::method78(v400.clone()) {
                                        Documents::method5(
                                            Documents::US0::US0_2,
                                            Func0::new(move || Documents::closure67((), ())),
                                            Func0::new({
                                                let v400 = v400.clone();
                                                let v401 = v401.clone();
                                                move || {
                                                    Documents::closure68(
                                                        v400.clone(),
                                                        v401.clone(),
                                                        (),
                                                    )
                                                }
                                            }),
                                        );
                                        Documents::method79(v401.clone(), v400.clone());
                                        false
                                    } else {
                                        true
                                    }
                                } else {
                                    true
                                } {
                                    LrcPtr::new(Documents::UH4::UH4_1(
                                        string("epub"),
                                        v70.clone(),
                                        Func2::new({
                                            let v3 = v3.clone();
                                            let v4 = v4.clone();
                                            move |b0: string, b1: string| {
                                                (Func1::new({
                                                    let v3 = v3.clone();
                                                    let v4 = v4.clone();
                                                    move |v_10: string| {
                                                        Documents::closure63(
                                                            v4.clone(),
                                                            v3.clone(),
                                                            false,
                                                            v_10,
                                                        )
                                                    }
                                                }))(
                                                    b0
                                                )(b1)
                                            }
                                        }),
                                        v399.clone(),
                                    ))
                                } else {
                                    v399
                                };
                            let patternInput_7: (string, string) =
                                Documents::method74(string("pdf"), v70.clone(), v4.clone());
                            let v414: string = patternInput_7.1.clone();
                            let v413: string = patternInput_7.0.clone();
                            let v425: LrcPtr<Documents::UH4> =
                                if if Documents::method78(v414.clone()) == false {
                                    if Documents::method78(v413.clone()) {
                                        Documents::method5(
                                            Documents::US0::US0_2,
                                            Func0::new(move || Documents::closure67((), ())),
                                            Func0::new({
                                                let v413 = v413.clone();
                                                let v414 = v414.clone();
                                                move || {
                                                    Documents::closure68(
                                                        v413.clone(),
                                                        v414.clone(),
                                                        (),
                                                    )
                                                }
                                            }),
                                        );
                                        Documents::method79(v414.clone(), v413.clone());
                                        false
                                    } else {
                                        true
                                    }
                                } else {
                                    true
                                } {
                                    LrcPtr::new(Documents::UH4::UH4_1(
                                        string("pdf"),
                                        v70.clone(),
                                        Func2::new({
                                            let v3 = v3.clone();
                                            let v4 = v4.clone();
                                            move |b0: string, b1: string| {
                                                (Func1::new({
                                                    let v3 = v3.clone();
                                                    let v4 = v4.clone();
                                                    move |v_11: string| {
                                                        Documents::closure63(
                                                            v4.clone(),
                                                            v3.clone(),
                                                            false,
                                                            v_11,
                                                        )
                                                    }
                                                }))(
                                                    b0
                                                )(b1)
                                            }
                                        }),
                                        v412.clone(),
                                    ))
                                } else {
                                    v412
                                };
                            let patternInput_8: (string, string) =
                                Documents::method74(string("html"), v70.clone(), v4.clone());
                            let v427: string = patternInput_8.1.clone();
                            let v426: string = patternInput_8.0.clone();
                            let v438: LrcPtr<Documents::UH4> =
                                if if Documents::method78(v427.clone()) == false {
                                    if Documents::method78(v426.clone()) {
                                        Documents::method5(
                                            Documents::US0::US0_2,
                                            Func0::new(move || Documents::closure67((), ())),
                                            Func0::new({
                                                let v426 = v426.clone();
                                                let v427 = v427.clone();
                                                move || {
                                                    Documents::closure68(
                                                        v426.clone(),
                                                        v427.clone(),
                                                        (),
                                                    )
                                                }
                                            }),
                                        );
                                        Documents::method79(v427.clone(), v426.clone());
                                        false
                                    } else {
                                        true
                                    }
                                } else {
                                    true
                                } {
                                    LrcPtr::new(Documents::UH4::UH4_1(
                                        string("html"),
                                        v70.clone(),
                                        Func2::new({
                                            let v3 = v3.clone();
                                            let v4 = v4.clone();
                                            move |b0: string, b1: string| {
                                                (Func1::new({
                                                    let v3 = v3.clone();
                                                    let v4 = v4.clone();
                                                    move |v_12: string| {
                                                        Documents::closure63(
                                                            v4.clone(),
                                                            v3.clone(),
                                                            false,
                                                            v_12,
                                                        )
                                                    }
                                                }))(
                                                    b0
                                                )(b1)
                                            }
                                        }),
                                        v425.clone(),
                                    ))
                                } else {
                                    v425
                                };
                            let patternInput_9: (string, string) =
                                Documents::method74(string("hangul.md"), v70.clone(), v4.clone());
                            let v440: string = patternInput_9.1.clone();
                            let v439: string = patternInput_9.0.clone();
                            LrcPtr::new(Documents::UH3::UH3_1(
                                if if Documents::method78(v440.clone()) == false {
                                    if Documents::method78(v439.clone()) {
                                        Documents::method5(
                                            Documents::US0::US0_2,
                                            Func0::new(move || Documents::closure67((), ())),
                                            Func0::new({
                                                let v439 = v439.clone();
                                                let v440 = v440.clone();
                                                move || {
                                                    Documents::closure68(
                                                        v439.clone(),
                                                        v440.clone(),
                                                        (),
                                                    )
                                                }
                                            }),
                                        );
                                        Documents::method79(v440.clone(), v439.clone());
                                        false
                                    } else {
                                        true
                                    }
                                } else {
                                    true
                                } {
                                    LrcPtr::new(Documents::UH4::UH4_1(
                                        string("hangul.md"),
                                        v70.clone(),
                                        Func2::new({
                                            let v0_1 = v0_1.clone();
                                            let v1_1 = v1_1.clone();
                                            let v3 = v3.clone();
                                            let v4 = v4.clone();
                                            move |b0: string, b1: string| {
                                                (Func1::new({
                                                    let v0_1 = v0_1.clone();
                                                    let v1_1 = v1_1.clone();
                                                    let v3 = v3.clone();
                                                    let v4 = v4.clone();
                                                    move |v_13: string| {
                                                        Documents::closure56(
                                                            v4.clone(),
                                                            v3.clone(),
                                                            v1_1.clone(),
                                                            v0_1.clone(),
                                                            v_13,
                                                        )
                                                    }
                                                }))(
                                                    b0
                                                )(b1)
                                            }
                                        }),
                                        LrcPtr::new(Documents::UH4::UH4_0),
                                    ))
                                } else {
                                    LrcPtr::new(Documents::UH4::UH4_0)
                                },
                                LrcPtr::new(Documents::UH3::UH3_1(
                                    v438,
                                    LrcPtr::new(Documents::UH3::UH3_0),
                                )),
                            ))
                        },
                        empty::<LrcPtr<Documents::UH4>>(),
                    ));
                    let v463: Vec<LrcPtr<Documents::UH4>> = v461.to_vec();
                    let v466: Vec<Option<Result<string, LrcPtr<(string, string)>>>> =
                        new_empty::<Option<Result<string, LrcPtr<(string, string)>>>>().to_vec();
                    let v468: Array<LrcPtr<Documents::UH4>> =
                        fable_library_rust::NativeArray_::array_from(v463);
                    let v469: i32 = count_2(v468.clone());
                    let v470: LrcPtr<Documents::Mut8> = LrcPtr::new(Documents::Mut8 {
                        l0: MutCell::new(0_i32),
                        l1: MutCell::new(v466),
                    });
                    while Documents::method89(v469, v470.clone()) {
                        let v472: i32 = v470.l0.get().clone();
                        let v473: Vec<Option<Result<string, LrcPtr<(string, string)>>>> =
                            v470.l1.get().clone();
                        let v478 = toArray_1(Documents::method90(
                            v468[v472].clone(),
                            empty::<(
                                string,
                                string,
                                Func1<string, Func1<string, Documents::US27>>,
                            )>(),
                        ));
                        let v480 = v478.to_vec();
                        let v482 = rayon::iter::IntoParallelIterator::into_par_iter(v480);
                        let v485 = rayon::iter::ParallelIterator::map(v482, |x| {
                            Func1::new(
                                move |arg10_0040_16: (
                                    string,
                                    string,
                                    Func1<string, Func1<string, Documents::US27>>,
                                )| {
                                    Documents::closure69((), arg10_0040_16)
                                },
                            )(x)
                        });
                        let v488: Vec<Option<Result<string, LrcPtr<(string, string)>>>> =
                            Documents::method91(rayon::iter::ParallelIterator::collect(v485));
                        let v489: Vec<Option<Result<string, LrcPtr<(string, string)>>>> =
                            Documents::method92(v473);
                        let v491: bool = true;
                        let mut v489 = v489;
                        let v493: bool = true;
                        v489.extend(v488);
                        let v495: Vec<Option<Result<string, LrcPtr<(string, string)>>>> = v489;
                        let v496: i32 = v472 + 1_i32;
                        v470.l0.set(v496);
                        v470.l1.set(v495);
                        ()
                    }
                    Ok::<
                        LrcPtr<(
                            string,
                            Vec<Option<Result<string, LrcPtr<(string, string)>>>>,
                        )>,
                        std::string::String,
                    >(LrcPtr::new((v56.clone(), v470.l1.get().clone())))
                }
            }
        }
        pub fn closure70(unitVar: (), unitVar_1: ()) -> string {
            string("documents.run")
        }
        pub fn closure71(
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
        pub fn method93(
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
        pub fn method14(
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
            let v9: string = Documents::method15(
                Documents::method18(
                    Documents::method15(string("polyglot"), string(".paket")),
                    string("C:\\home\\git\\polyglot\\target\\polyglot\\builder\\documents"),
                ),
                string("polyglot"),
            );
            let v10: string = Documents::method23(v3);
            let v11: string = Documents::method23(v2);
            let v12: string = Documents::method23(v1_1);
            Documents::method5(
                Documents::US0::US0_1,
                Func0::new(move || Documents::closure9((), ())),
                Func0::new({
                    let v0_1 = v0_1.clone();
                    let v10 = v10.clone();
                    let v11 = v11.clone();
                    let v12 = v12.clone();
                    move || {
                        Documents::closure10(
                            v0_1.clone(),
                            v10.clone(),
                            v11.clone(),
                            v12.clone(),
                            (),
                        )
                    }
                }),
            );
            let __result = Box::pin(async move {
                //;
                {
                    let v18: async_walkdir::WalkDir = async_walkdir::WalkDir::new(&*v11.clone());
                    let v21: async_walkdir::WalkDir = async_walkdir::WalkDir::filter(v18, |x| {
                        Func1::new(move |v: async_walkdir::DirEntry| Documents::closure11((), v))(x)
                    });
                    let v22 = Documents::method39();
                    let v24: Vec<string> = tokio_stream::StreamExt::collect(
                        tokio_stream::StreamExt::filter_map(v21, |x| v22(x)),
                    )
                    .await;
                    Documents::method5(
                        Documents::US0::US0_1,
                        Func0::new(move || Documents::closure20((), ())),
                        Func0::new({
                            let v24 = v24.clone();
                            move || Documents::closure21(v24.clone(), ())
                        }),
                    );
                    {
                        let v29: rayon::vec::IntoIter<string> =
                            rayon::iter::IntoParallelIterator::into_par_iter(v24);
                        let v32: rayon::iter::Map<rayon::vec::IntoIter<string>, _> =
                            rayon::iter::ParallelIterator::map(v29, |x| {
                                Func1::new({
                                    let v0_1 = v0_1.clone();
                                    let v10 = v10.clone();
                                    let v11 = v11.clone();
                                    let v12 = v12.clone();
                                    let v9 = v9.clone();
                                    move |v_1: string| {
                                        Documents::closure22(
                                            v0_1.clone(),
                                            v9.clone(),
                                            v10.clone(),
                                            v11.clone(),
                                            v12.clone(),
                                            v_1,
                                        )
                                    }
                                })(x)
                            });
                        let v34: Vec<
                            Result<
                                LrcPtr<(
                                    string,
                                    Vec<Option<Result<string, LrcPtr<(string, string)>>>>,
                                )>,
                                std::string::String,
                            >,
                        > = rayon::iter::ParallelIterator::collect(v32);
                        Documents::method5(
                            Documents::US0::US0_2,
                            Func0::new(move || Documents::closure70((), ())),
                            Func0::new({
                                let v34 = v34.clone();
                                move || Documents::closure71(v34.clone(), ())
                            }),
                        );
                        {
                            let v39: Result<
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
                            > = Documents::method93(Ok::<
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
                            >(v34.clone()));
                            let v50: string = string("v39 }}}}); {{{ //");
                            v39
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
                Documents::State::trace_state()
                    .set(Some(Documents::closure2((), Documents::US0::US0_2)));
            }
            Documents::method5(
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
                let v9: string = Documents::method10();
                let v11: &str = &*v9;
                let v13: Option<std::string::String> =
                    clap::ArgMatches::get_one(&v8.clone(), v11).cloned();
                let _v14: LrcPtr<MutCell<Option<Documents::US4>>> = refCell(None::<Documents::US4>);
                {
                    let x_2: Option<Documents::US4> = match &v13 {
                        None => None::<Documents::US4>,
                        Some(v13_0_0) => {
                            let x: std::string::String = v13_0_0.clone();
                            Some((Func0::new({
                                let x = x.clone();
                                move || Documents::US4::US4_0(x.clone())
                            }))())
                        }
                    };
                    _v14.set(x_2)
                }
                {
                    let v19: Documents::US4 =
                        defaultValue(Documents::US4::US4_1, _v14.get().clone());
                    let v23: std::string::String = match &v19 {
                        Documents::US4::US4_0(v19_0_0) => match &v19 {
                            Documents::US4::US4_0(x) => x.clone(),
                            _ => unreachable!(),
                        },
                        _ => panic!("{}", string("Option does not have a value."),),
                    };
                    let v25: string = fable_library_rust::String_::fromString(v23);
                    let v26: string = Documents::method11();
                    let v28: &str = &*v26;
                    let v30: Option<std::string::String> =
                        clap::ArgMatches::get_one(&v8.clone(), v28).cloned();
                    let _v31: LrcPtr<MutCell<Option<Documents::US4>>> =
                        refCell(None::<Documents::US4>);
                    {
                        let x_5: Option<Documents::US4> = match &v30 {
                            None => None::<Documents::US4>,
                            Some(v30_0_0) => {
                                let x_3: std::string::String = v30_0_0.clone();
                                Some((Func0::new({
                                    let x_3 = x_3.clone();
                                    move || Documents::US4::US4_0(x_3.clone())
                                }))())
                            }
                        };
                        _v31.set(x_5)
                    }
                    {
                        let v36: Documents::US4 =
                            defaultValue(Documents::US4::US4_1, _v31.get().clone());
                        let v40: std::string::String = match &v36 {
                            Documents::US4::US4_0(v36_0_0) => match &v36 {
                                Documents::US4::US4_0(x) => x.clone(),
                                _ => unreachable!(),
                            },
                            _ => panic!("{}", string("Option does not have a value."),),
                        };
                        let v42: string = fable_library_rust::String_::fromString(v40);
                        let v43: string = Documents::method12();
                        let v45: &str = &*v43;
                        let v47: Option<std::string::String> =
                            clap::ArgMatches::get_one(&v8.clone(), v45).cloned();
                        let _v48: LrcPtr<MutCell<Option<Documents::US4>>> =
                            refCell(None::<Documents::US4>);
                        {
                            let x_8: Option<Documents::US4> = match &v47 {
                                None => None::<Documents::US4>,
                                Some(v47_0_0) => {
                                    let x_6: std::string::String = v47_0_0.clone();
                                    Some((Func0::new({
                                        let x_6 = x_6.clone();
                                        move || Documents::US4::US4_0(x_6.clone())
                                    }))())
                                }
                            };
                            _v48.set(x_8)
                        }
                        {
                            let v53: Documents::US4 =
                                defaultValue(Documents::US4::US4_1, _v48.get().clone());
                            let v57: std::string::String = match &v53 {
                                Documents::US4::US4_0(v53_0_0) => match &v53 {
                                    Documents::US4::US4_0(x) => x.clone(),
                                    _ => unreachable!(),
                                },
                                _ => panic!("{}", string("Option does not have a value."),),
                            };
                            let v59: string = fable_library_rust::String_::fromString(v57);
                            let v60: string = Documents::method13();
                            let v62: &str = &*v60;
                            let v64: Option<std::string::String> =
                                clap::ArgMatches::get_one(&v8, v62).cloned();
                            let _v65: LrcPtr<MutCell<Option<Documents::US4>>> =
                                refCell(None::<Documents::US4>);
                            {
                                let x_11: Option<Documents::US4> = match &v64 {
                                    None => None::<Documents::US4>,
                                    Some(v64_0_0) => {
                                        let x_9: std::string::String = v64_0_0.clone();
                                        Some((Func0::new({
                                            let x_9 = x_9.clone();
                                            move || Documents::US4::US4_0(x_9.clone())
                                        }))())
                                    }
                                };
                                _v65.set(x_11)
                            }
                            {
                                let v70: Documents::US4 =
                                    defaultValue(Documents::US4::US4_1, _v65.get().clone());
                                let v74: std::string::String = match &v70 {
                                    Documents::US4::US4_0(v70_0_0) => match &v70 {
                                        Documents::US4::US4_0(x) => x.clone(),
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
                                > = Documents::method14(
                                    fable_library_rust::String_::fromString(v74),
                                    v59,
                                    v42,
                                    v25,
                                );
                                let v79 = tokio::runtime::Builder::new_multi_thread()
                                    .enable_all()
                                    .build()
                                    .unwrap();
                                let v81: Result<
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
                                > = v79.handle().block_on(v77);
                                let v83: Vec<
                                    Result<
                                        LrcPtr<(
                                            string,
                                            Vec<Option<Result<string, LrcPtr<(string, string)>>>>,
                                        )>,
                                        std::string::String,
                                    >,
                                > = v81.unwrap();
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
