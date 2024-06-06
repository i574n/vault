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
            US6_4(Documents::US5),
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
            pub fn get_IsUS6_4(this_: &MutCell<Documents::US6>, unitArg: ()) -> bool {
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
        #[derive(Clone, Copy, Debug, PartialEq, PartialOrd, Hash, Eq)]
        pub enum US25 {
            US25_0(i32),
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
        #[derive(Clone, Debug)]
        pub enum US26 {
            US26_0(Func1<(bool, string, i32), Arc<Async<()>>>),
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
        #[derive(Clone, Copy, Debug, PartialEq, PartialOrd, Hash, Eq)]
        pub enum US27 {
            US27_0(CancellationToken),
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
        #[derive(Clone, Debug, PartialEq, PartialOrd, Hash, Eq)]
        pub enum US28 {
            US28_0(Result<string, LrcPtr<(string, string)>>),
            US28_1,
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
        #[derive(Clone, Debug)]
        pub enum UH4 {
            UH4_0,
            UH4_1(
                string,
                string,
                Func2<string, string, Documents::US28>,
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
        pub enum US29 {
            US29_0(string),
            US29_1(std::string::String),
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
        #[derive(Clone, Debug, PartialEq, PartialOrd, Hash, Eq)]
        pub enum US30 {
            US30_0(i32, string),
            US30_1(i32, string),
        }
        impl Documents::US30 {
            pub fn get_IsUS30_0(this_: &MutCell<Documents::US30>, unitArg: ()) -> bool {
                if unreachable!() {
                    true
                } else {
                    false
                }
            }
            pub fn get_IsUS30_1(this_: &MutCell<Documents::US30>, unitArg: ()) -> bool {
                if unreachable!() {
                    true
                } else {
                    false
                }
            }
        }
        impl core::fmt::Display for Documents::US30 {
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
            let v9: Documents::US2 = if string("Verbose") == v3.clone() {
                Documents::US2::US2_0(Documents::US0::US0_0)
            } else {
                Documents::US2::US2_1
            };
            let v54: Documents::US2 = match &v9 {
                Documents::US2::US2_0(v9_0_0) => Documents::US2::US2_0(match &v9 {
                    Documents::US2::US2_0(x) => x.clone(),
                    _ => unreachable!(),
                }),
                _ => {
                    let v17: Documents::US2 = if string("Debug") == v3.clone() {
                        Documents::US2::US2_0(Documents::US0::US0_1)
                    } else {
                        Documents::US2::US2_1
                    };
                    match &v17 {
                        Documents::US2::US2_0(v17_0_0) => Documents::US2::US2_0(match &v17 {
                            Documents::US2::US2_0(x) => x.clone(),
                            _ => unreachable!(),
                        }),
                        _ => {
                            let v25: Documents::US2 = if string("Info") == v3.clone() {
                                Documents::US2::US2_0(Documents::US0::US0_2)
                            } else {
                                Documents::US2::US2_1
                            };
                            match &v25 {
                                Documents::US2::US2_0(v25_0_0) => {
                                    Documents::US2::US2_0(match &v25 {
                                        Documents::US2::US2_0(x) => x.clone(),
                                        _ => unreachable!(),
                                    })
                                }
                                _ => {
                                    let v33: Documents::US2 = if string("Warning") == v3.clone() {
                                        Documents::US2::US2_0(Documents::US0::US0_3)
                                    } else {
                                        Documents::US2::US2_1
                                    };
                                    match &v33 {
                                        Documents::US2::US2_0(v33_0_0) => {
                                            Documents::US2::US2_0(match &v33 {
                                                Documents::US2::US2_0(x) => x.clone(),
                                                _ => unreachable!(),
                                            })
                                        }
                                        _ => {
                                            let v41: Documents::US2 =
                                                if string("Critical") == v3.clone() {
                                                    Documents::US2::US2_0(Documents::US0::US0_4)
                                                } else {
                                                    Documents::US2::US2_1
                                                };
                                            match &v41 {
                                                Documents::US2::US2_0(v41_0_0) => {
                                                    Documents::US2::US2_0(match &v41 {
                                                        Documents::US2::US2_0(x) => x.clone(),
                                                        _ => unreachable!(),
                                                    })
                                                }
                                                _ => Documents::US2::US2_1,
                                            }
                                        }
                                    }
                                }
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
                    v54,
                );
                _v1.set(Some(x))
            }
            {
                let patternInput: (Documents::US1, Documents::US2) = match &_v1.get().clone() {
                    None => panic!("{}", string("base.run_target / _v1=None"),),
                    Some(_v1_0_0) => _v1_0_0.clone(),
                };
                let v259: Documents::US2 = patternInput.1.clone();
                let v258: Documents::US1 = patternInput.0.clone();
                let v267: LrcPtr<Documents::Mut3> = LrcPtr::new(Documents::Mut3 {
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
                        l0: MutCell::new(match &v259 {
                            Documents::US2::US2_0(v259_0_0) => match &v259 {
                                Documents::US2::US2_0(x) => x.clone(),
                                _ => unreachable!(),
                            },
                            _ => v0_1,
                        }),
                    }),
                    match &v258 {
                        Documents::US1::US1_0(v258_0_0) => Some(match &v258 {
                            Documents::US1::US1_0(x) => x.clone(),
                            _ => unreachable!(),
                        }),
                        _ => None::<i64>,
                    },
                    v267,
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
                        let v154: Documents::US3 = if if let Documents::US0::US0_0 = &v0_1 {
                            true
                        } else {
                            false
                        } {
                            Documents::US3::US3_0(string("Verbose"))
                        } else {
                            Documents::US3::US3_1
                        };
                        let v203: Documents::US3 = match &v154 {
                            Documents::US3::US3_0(v154_0_0) => Documents::US3::US3_0(match &v154 {
                                Documents::US3::US3_0(x) => x.clone(),
                                _ => unreachable!(),
                            }),
                            _ => {
                                let v163: Documents::US3 = if if let Documents::US0::US0_1 = &v0_1 {
                                    true
                                } else {
                                    false
                                } {
                                    Documents::US3::US3_0(string("Debug"))
                                } else {
                                    Documents::US3::US3_1
                                };
                                match &v163 {
                                    Documents::US3::US3_0(v163_0_0) => {
                                        Documents::US3::US3_0(match &v163 {
                                            Documents::US3::US3_0(x) => x.clone(),
                                            _ => unreachable!(),
                                        })
                                    }
                                    _ => {
                                        let v172: Documents::US3 =
                                            if if let Documents::US0::US0_2 = &v0_1 {
                                                true
                                            } else {
                                                false
                                            } {
                                                Documents::US3::US3_0(string("Info"))
                                            } else {
                                                Documents::US3::US3_1
                                            };
                                        match &v172 {
                                            Documents::US3::US3_0(v172_0_0) => {
                                                Documents::US3::US3_0(match &v172 {
                                                    Documents::US3::US3_0(x) => x.clone(),
                                                    _ => unreachable!(),
                                                })
                                            }
                                            _ => {
                                                let v181: Documents::US3 =
                                                    if if let Documents::US0::US0_3 = &v0_1 {
                                                        true
                                                    } else {
                                                        false
                                                    } {
                                                        Documents::US3::US3_0(string("Warning"))
                                                    } else {
                                                        Documents::US3::US3_1
                                                    };
                                                match &v181 {
                                                    Documents::US3::US3_0(v181_0_0) => {
                                                        Documents::US3::US3_0(match &v181 {
                                                            Documents::US3::US3_0(x) => x.clone(),
                                                            _ => unreachable!(),
                                                        })
                                                    }
                                                    _ => {
                                                        let v190: Documents::US3 =
                                                            if if let Documents::US0::US0_4 = &v0_1
                                                            {
                                                                true
                                                            } else {
                                                                false
                                                            } {
                                                                Documents::US3::US3_0(string(
                                                                    "Critical",
                                                                ))
                                                            } else {
                                                                Documents::US3::US3_1
                                                            };
                                                        match &v190 {
                                                            Documents::US3::US3_0(v190_0_0) => {
                                                                Documents::US3::US3_0(match &v190 {
                                                                    Documents::US3::US3_0(x) => {
                                                                        x.clone()
                                                                    }
                                                                    _ => unreachable!(),
                                                                })
                                                            }
                                                            _ => Documents::US3::US3_1,
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        };
                        let v210: string = padLeft(
                            toLower(match &v203 {
                                Documents::US3::US3_0(v203_0_0) => match &v203 {
                                    Documents::US3::US3_0(x) => x.clone(),
                                    _ => unreachable!(),
                                },
                                _ => panic!("{}", string("Option does not have a value."),),
                            }),
                            7_i32,
                            ' ',
                        );
                        let _v211: MutCell<Option<string>> = MutCell::new(None::<string>);
                        let v226: &str = match &v0_1 {
                            Documents::US0::US0_1 => inline_colorization::color_bright_blue,
                            Documents::US0::US0_2 => inline_colorization::color_bright_green,
                            Documents::US0::US0_0 => inline_colorization::color_bright_black,
                            Documents::US0::US0_3 => inline_colorization::color_yellow,
                            _ => inline_colorization::color_bright_red,
                        };
                        let v228: &str = &*v210;
                        let v230: &str = inline_colorization::color_reset;
                        let v232: string = string("format!(\"{v226}{v228}{v230}\")");
                        let v233: std::string::String = format!("{v226}{v228}{v230}");
                        {
                            let x_5: string = fable_library_rust::String_::fromString(v233);
                            _v211.set(Some(x_5))
                        }
                        trimEndChars(
                            trimStartChars(
                                sprintf!(
                                    "{} {} #{} {} / {}",
                                    v147,
                                    match &_v211.get().clone() {
                                        None =>
                                            panic!("{}", string("base.run_target / _v211=None"),),
                                        Some(_v211_0_0) => _v211_0_0.clone(),
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
        pub fn method27() -> string {
            string("")
        }
        pub fn method28(v0_1: string) -> string {
            v0_1
        }
        pub fn method29() -> string {
            string("^\\\\\\\\\\?\\\\")
        }
        pub fn method26(v0_1: string) -> string {
            let v1_1: string = Documents::method27();
            let _v2: MutCell<Option<string>> = MutCell::new(None::<string>);
            let v3: string = Documents::method28(v0_1);
            let v6: Result<regex::Regex, regex::Error> =
                regex::Regex::new(&string("^\\\\\\\\\\?\\\\"));
            let v8: regex::Regex = v6.unwrap();
            let v10: std::borrow::Cow<str> = v8.replace_all(&v3, &*v1_1);
            let v12: std::string::String = String::from(v10);
            {
                let x: string = fable_library_rust::String_::fromString(v12);
                _v2.set(Some(x))
            }
            {
                let v21: string = match &_v2.get().clone() {
                    None => panic!("{}", string("base.run_target / _v2=None"),),
                    Some(_v2_0_0) => _v2_0_0.clone(),
                };
                replace(
                    sprintf!(
                        "{}{}",
                        toLower(ofChar(getCharAt(v21.clone(), 0_i32))),
                        getSlice(v21, Some(1_i32), None::<i32>)
                    ),
                    string("\\"),
                    string("/"),
                )
            }
        }
        pub fn method30(v0_1: i32, v1_1: LrcPtr<Documents::Mut4>) -> bool {
            v1_1.l0.get().clone() < v0_1
        }
        pub fn method31(v0_1: i32, v1_1: LrcPtr<Documents::Mut5>) -> bool {
            v1_1.l0.get().clone() < v0_1
        }
        pub fn method32() -> char {
            let _v0: MutCell<Option<char>> = MutCell::new(None::<char>);
            {
                let x: char = std::path::MAIN_SEPARATOR;
                _v0.set(Some(x))
            }
            match &_v0.get().clone() {
                None => panic!("{}", string("base.run_target / _v0=None"),),
                Some(_v0_0_0) => _v0_0_0.clone(),
            }
        }
        pub fn method33(v0_1: string) -> string {
            v0_1
        }
        pub fn method23(v0_1: string) -> string {
            let _v1: MutCell<Option<string>> = MutCell::new(None::<string>);
            let v2: string = Documents::method24(v0_1);
            let v4: &str = &*v2.clone();
            let v6: std::string::String = String::from(v4);
            let v8: std::path::PathBuf = std::path::PathBuf::from(v6);
            {
                let x_2: string = if v8.exists() == false {
                    let v12: string = Documents::method25();
                    let v16: Array<string> = split(
                        Documents::method26(Documents::method15(v12.clone(), v2.clone())),
                        string("/"),
                        -1_i32,
                        0_i32,
                    );
                    let v18: i32 = count_2(v16.clone());
                    let v19: LrcPtr<Documents::Mut4> = LrcPtr::new(Documents::Mut4 {
                        l0: MutCell::new(0_i32),
                        l1: MutCell::new(0_i32),
                        l2: MutCell::new(new_empty::<string>()),
                    });
                    while Documents::method30(v18, v19.clone()) {
                        let v21: i32 = v19.l0.get().clone();
                        let v24: i32 = v21.wrapping_neg() + v18 - 1_i32;
                        let matchValue: i32 = v19.l1.get().clone();
                        let v26: Array<string> = v19.l2.get().clone();
                        let v25: i32 = matchValue;
                        let v27: string = v16[v24].clone();
                        let patternInput_1: (i32, Array<string>) = if string("..") == v27.clone() {
                            (v25 + 1_i32, v26.clone())
                        } else {
                            if string(".") == v27.clone() {
                                (v25, v26.clone())
                            } else {
                                if 0_i32 == v25 {
                                    if endsWith(v27.clone(), string(":"), false) {
                                        let v35: Array<string> = new_array(&[sprintf!(
                                            "{}:",
                                            getCharAt(v12.clone(), 0_i32)
                                        )]);
                                        let v36: i32 = count_2(v35.clone());
                                        let v38: i32 = v36 + count_2(v26.clone());
                                        let v39: Array<string> = new_init(&string(""), v38);
                                        let v40: LrcPtr<Documents::Mut5> =
                                            LrcPtr::new(Documents::Mut5 {
                                                l0: MutCell::new(0_i32),
                                            });
                                        while Documents::method31(v38, v40.clone()) {
                                            let v42: i32 = v40.l0.get().clone();
                                            let v47: string = if v42 < v36 {
                                                v35[v42].clone()
                                            } else {
                                                let v45: i32 = v42 - v36;
                                                v26[v45].clone()
                                            };
                                            v39.get_mut()[v42 as usize] = v47;
                                            {
                                                let v48: i32 = v42 + 1_i32;
                                                v40.l0.set(v48);
                                                ()
                                            }
                                        }
                                        (0_i32, v39.clone())
                                    } else {
                                        let v49: Array<string> = new_array(&[v27]);
                                        let v50: i32 = count_2(v49.clone());
                                        let v52: i32 = v50 + count_2(v26.clone());
                                        let v53: Array<string> = new_init(&string(""), v52);
                                        let v54: LrcPtr<Documents::Mut5> =
                                            LrcPtr::new(Documents::Mut5 {
                                                l0: MutCell::new(0_i32),
                                            });
                                        while Documents::method31(v52, v54.clone()) {
                                            let v56: i32 = v54.l0.get().clone();
                                            let v61: string = if v56 < v50 {
                                                v49[v56].clone()
                                            } else {
                                                let v59: i32 = v56 - v50;
                                                v26[v59].clone()
                                            };
                                            v53.get_mut()[v56 as usize] = v61;
                                            {
                                                let v62: i32 = v56 + 1_i32;
                                                v54.l0.set(v62);
                                                ()
                                            }
                                        }
                                        (0_i32, v53.clone())
                                    }
                                } else {
                                    (v25 - 1_i32, v26.clone())
                                }
                            }
                        };
                        let v72: i32 = v21 + 1_i32;
                        v19.l0.set(v72);
                        v19.l1.set(patternInput_1.0.clone());
                        v19.l2.set(patternInput_1.1.clone());
                        ()
                    }
                    {
                        let matchValue_2: i32 = v19.l1.get().clone();
                        let v74: Array<string> = v19.l2.get().clone();
                        let v75: LrcPtr<dyn IEnumerable_1<string>> = delay(Func0::new({
                            let v74 = v74.clone();
                            move || {
                                map(
                                    Func1::new({
                                        let v74 = v74.clone();
                                        move |i: i32| v74[i].clone()
                                    }),
                                    rangeNumeric(0_i32, 1_i32, count_2(v74.clone()) - 1_i32),
                                )
                            }
                        }));
                        join(ofChar(Documents::method32()), toArray(v75))
                    }
                } else {
                    let v83: Result<std::path::PathBuf, std::io::Error> =
                        std::fs::canonicalize(&*v2);
                    let v85: std::path::PathBuf = v83.unwrap();
                    let v87: std::path::Display = v85.display();
                    let _v88: MutCell<Option<std::string::String>> =
                        MutCell::new(None::<std::string::String>);
                    {
                        let x: std::string::String = format!("{}", v87);
                        _v88.set(Some(x))
                    }
                    {
                        let v98: std::string::String = match &_v88.get().clone() {
                            None => panic!("{}", string("base.run_target / _v88=None"),),
                            Some(_v88_0_0) => _v88_0_0.clone(),
                        };
                        fable_library_rust::String_::fromString(v98)
                    }
                };
                _v1.set(Some(x_2))
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
        pub fn method36(v0_1: async_walkdir::DirEntry) -> async_walkdir::DirEntry {
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
        pub fn method37() -> Func1<std::io::Error, std::string::String> {
            Func1::new(move |v: std::io::Error| Documents::closure12((), v))
        }
        pub fn closure13(unitVar: (), v0_1: std::fs::FileType) -> Documents::US8 {
            Documents::US8::US8_0(v0_1)
        }
        pub fn closure14(unitVar: (), v0_1: std::string::String) -> Documents::US8 {
            Documents::US8::US8_1(v0_1)
        }
        pub fn method38(v0_1: std::fs::FileType) -> std::fs::FileType {
            v0_1
        }
        pub fn method39(v0_1: Documents::US7) -> Documents::US7 {
            v0_1
        }
        pub fn method35(
            v0_1: async_walkdir::DirEntry,
        ) -> std::pin::Pin<Box<dyn std::future::Future<Output = Documents::US7> + Send>> {
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
                    let v12: Documents::US8 = match &v9 {
                        Err(v9_1_0) => Documents::closure14((), v9_1_0.clone()),
                        Ok(v9_0_0) => Documents::closure13((), v9_0_0.clone()),
                    };
                    let v72: Documents::US7 =
                        Documents::method39(if let Documents::US8::US8_0(v12_0_0) = &v12 {
                            let v14: std::fs::FileType = Documents::method38(match &v12 {
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
                        Box<dyn std::future::Future<Output = Documents::US7> + Send>,
                    > = Documents::method35(v0_1);
                    let v4: Documents::US7 = v2.await;
                    let v14: async_walkdir::Filtering = Documents::method40(match &v4 {
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
            Documents::method34(v0_1)
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
            let v1_1 = Documents::method37();
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
        pub fn method41() -> Func1<Result<async_walkdir::DirEntry, std::io::Error>, Option<string>>
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
        pub fn method42(v0_1: string) -> string {
            Documents::method26(Documents::method23(v0_1))
        }
        pub fn method44(
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
        pub fn method46() -> (string, string) {
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
        pub fn method47() -> Func1<char, Func1<LrcPtr<Documents::UH0>, LrcPtr<Documents::UH0>>> {
            Func1::new(move |v: char| Documents::closure23((), v))
        }
        pub fn method48(
            v0_1: string,
            v1_1: string,
            v2: LrcPtr<Documents::UH0>,
            v3: Documents::US10,
        ) -> (string, string) {
            let v0_1: MutCell<string> = MutCell::new(v0_1.clone());
            let v1_1: MutCell<string> = MutCell::new(v1_1.clone());
            let v2: MutCell<LrcPtr<Documents::UH0>> = MutCell::new(v2.clone());
            let v3: MutCell<Documents::US10> = MutCell::new(v3.clone());
            '_method48: loop {
                break '_method48 (if let Documents::UH0::UH0_1(v2_1_0, v2_1_1) =
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
                            continue '_method48;
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
                                        continue '_method48;
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
                                            continue '_method48;
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
                                            continue '_method48;
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
                                        continue '_method48;
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
                                        continue '_method48;
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
                                    continue '_method48;
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
                                continue '_method48;
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
                                            continue '_method48;
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
                                                continue '_method48;
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
                                                continue '_method48;
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
                                            continue '_method48;
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
                                            continue '_method48;
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
                                        continue '_method48;
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
                                            continue '_method48;
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
                                            continue '_method48;
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
                                            continue '_method48;
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
                                            continue '_method48;
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
                                        continue '_method48;
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
                                        continue '_method48;
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
                                    continue '_method48;
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
        pub fn method45(v0_1: string) -> (string, string) {
            let patternInput: (string, string) = Documents::method46();
            let v3: i32 = length(v0_1.clone());
            let v4: Array<char> = new_init(&'\u{0000}', v3);
            let v5: LrcPtr<Documents::Mut5> = LrcPtr::new(Documents::Mut5 {
                l0: MutCell::new(0_i32),
            });
            while Documents::method31(v3, v5.clone()) {
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
                Documents::method48(
                    patternInput.1.clone(),
                    patternInput.0.clone(),
                    foldBack(
                        Func2::new(move |b0: char, b1: LrcPtr<Documents::UH0>| {
                            (Documents::method47())(b0)(b1)
                        }),
                        v11,
                        LrcPtr::new(Documents::UH0::UH0_0),
                    ),
                    Documents::US10::US10_0,
                )
            }
        }
        pub fn method51(v0_1: char, v1_1: i64) -> bool {
            let v0_1: MutCell<char> = MutCell::new(v0_1);
            let v1_1: MutCell<i64> = MutCell::new(v1_1);
            '_method51: loop {
                break '_method51 (if v1_1.get().clone() >= 4_i64 {
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
                        continue '_method51;
                    }
                });
            }
        }
        pub fn method52(
            v0_1: LrcPtr<Documents::UH0>,
            v1_1: LrcPtr<StringBuilder>,
            v2: i32,
            v3: i32,
        ) -> (LrcPtr<StringBuilder>, i32, i32) {
            let v0_1: MutCell<LrcPtr<Documents::UH0>> = MutCell::new(v0_1.clone());
            let v1_1: MutCell<LrcPtr<StringBuilder>> = MutCell::new(v1_1.clone());
            let v2: MutCell<i32> = MutCell::new(v2);
            let v3: MutCell<i32> = MutCell::new(v3);
            '_method52: loop {
                break '_method52 (match v0_1.get().clone().as_ref() {
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
                            continue '_method52;
                        }
                    }
                });
            }
        }
        pub fn method53(
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
            '_method53: loop {
                break '_method53 ({
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
                        if Documents::method51(v15, 0_i64) == false {
                            let v27: string = ofChar(v15);
                            let v28: i32 = length(v27.clone());
                            let v29: Array<char> = new_init(&'\u{0000}', v28);
                            let v30: LrcPtr<Documents::Mut5> = LrcPtr::new(Documents::Mut5 {
                                l0: MutCell::new(0_i32),
                            });
                            while Documents::method31(v28, v30.clone()) {
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
                                    Documents::method52(
                                        foldBack(
                                            Func2::new(
                                                move |b0: char, b1: LrcPtr<Documents::UH0>| {
                                                    (Documents::method47())(b0)(b1)
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
                            continue '_method53;
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
        pub fn method55(v0_1: char, v1_1: i64) -> bool {
            let v0_1: MutCell<char> = MutCell::new(v0_1);
            let v1_1: MutCell<i64> = MutCell::new(v1_1);
            '_method55: loop {
                break '_method55 (if v1_1.get().clone() >= 3_i64 {
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
                        continue '_method55;
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
                    while Documents::method31(v18, v20.clone()) {
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
                        let patternInput: (LrcPtr<StringBuilder>, i32, i32) = Documents::method52(
                            foldBack(
                                Func2::new(move |b0: char, b1: LrcPtr<Documents::UH0>| {
                                    (Documents::method47())(b0)(b1)
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
                        while Documents::method31(v79, v81.clone()) {
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
                                Documents::method52(
                                    foldBack(
                                        Func2::new(move |b0: char, b1: LrcPtr<Documents::UH0>| {
                                            (Documents::method47())(b0)(b1)
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
                    while Documents::method31(v18, v20.clone()) {
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
                        let patternInput: (LrcPtr<StringBuilder>, i32, i32) = Documents::method52(
                            foldBack(
                                Func2::new(move |b0: char, b1: LrcPtr<Documents::UH0>| {
                                    (Documents::method47())(b0)(b1)
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
                        while Documents::method31(v79, v81.clone()) {
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
                                Documents::method52(
                                    foldBack(
                                        Func2::new(move |b0: char, b1: LrcPtr<Documents::UH0>| {
                                            (Documents::method47())(b0)(b1)
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
        pub fn method56(
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
            '_method56: loop {
                break '_method56 (match v4.get().clone().as_ref() {
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
                                continue '_method56;
                            }
                        }
                    }
                });
            }
        }
        pub fn method57(
            v0_1: LrcPtr<Documents::UH1>,
            v1_1: LrcPtr<Documents::UH1>,
        ) -> LrcPtr<Documents::UH1> {
            let v0_1: MutCell<LrcPtr<Documents::UH1>> = MutCell::new(v0_1.clone());
            let v1_1: MutCell<LrcPtr<Documents::UH1>> = MutCell::new(v1_1.clone());
            '_method57: loop {
                break '_method57 (match v0_1.get().clone().as_ref() {
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
                        continue '_method57;
                    }
                });
            }
        }
        pub fn method54(
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
            '_method54: loop {
                break '_method54 ({
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
                        if Documents::method55(v14, 0_i64) == false {
                            let v26: string = ofChar(v14);
                            let v27: i32 = length(v26.clone());
                            let v28: Array<char> = new_init(&'\u{0000}', v27);
                            let v29: LrcPtr<Documents::Mut5> = LrcPtr::new(Documents::Mut5 {
                                l0: MutCell::new(0_i32),
                            });
                            while Documents::method31(v27, v29.clone()) {
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
                                    Documents::method52(
                                        foldBack(
                                            Func2::new(
                                                move |b0: char, b1: LrcPtr<Documents::UH0>| {
                                                    (Documents::method47())(b0)(b1)
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
                        _ => Documents::method56(
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
                            continue '_method54;
                        }
                        _ => Documents::US13::US13_0(
                            Documents::method57(
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
        pub fn method58(v0_1: LrcPtr<Documents::UH1>, v1_1: List<string>) -> List<string> {
            match v0_1.as_ref() {
                Documents::UH1::UH1_0 => v1_1.clone(),
                Documents::UH1::UH1_1(v0_1_1_0, v0_1_1_1) => cons(
                    match v0_1.as_ref() {
                        Documents::UH1::UH1_1(x, _) => x.clone(),
                        _ => unreachable!(),
                    },
                    Documents::method58(
                        match v0_1.as_ref() {
                            Documents::UH1::UH1_1(_, x) => x.clone(),
                            _ => unreachable!(),
                        },
                        v1_1.clone(),
                    ),
                ),
            }
        }
        pub fn method59(
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
            '_method59: loop {
                break '_method59 ({
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
                        if Documents::method55(v14, 0_i64) == false {
                            let v26: string = ofChar(v14);
                            let v27: i32 = length(v26.clone());
                            let v28: Array<char> = new_init(&'\u{0000}', v27);
                            let v29: LrcPtr<Documents::Mut5> = LrcPtr::new(Documents::Mut5 {
                                l0: MutCell::new(0_i32),
                            });
                            while Documents::method31(v27, v29.clone()) {
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
                                    Documents::method52(
                                        foldBack(
                                            Func2::new(
                                                move |b0: char, b1: LrcPtr<Documents::UH0>| {
                                                    (Documents::method47())(b0)(b1)
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
                            continue '_method59;
                        }
                        _ => Documents::US13::US13_0(
                            Documents::method57(
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
        pub fn method60(v0_1: string, v1_1: i32) -> i32 {
            let v0_1: MutCell<string> = MutCell::new(v0_1.clone());
            let v1_1: MutCell<i32> = MutCell::new(v1_1);
            '_method60: loop {
                break '_method60 (if v1_1.get().clone() >= length(v0_1.get().clone()) {
                    v1_1.get().clone()
                } else {
                    if getCharAt(v0_1.get().clone(), v1_1.get().clone()) == ' ' {
                        let v0_1_temp: string = v0_1.get().clone();
                        let v1_1_temp: i32 = v1_1.get().clone() + 1_i32;
                        v0_1.set(v0_1_temp);
                        v1_1.set(v1_1_temp);
                        continue '_method60;
                    } else {
                        v1_1.get().clone()
                    }
                });
            }
        }
        pub fn method50(
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
            '_method50: loop {
                break '_method50 ({
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
                        if Documents::method51(v15, 0_i64) == false {
                            let v27: string = ofChar(v15);
                            let v28: i32 = length(v27.clone());
                            let v29: Array<char> = new_init(&'\u{0000}', v28);
                            let v30: LrcPtr<Documents::Mut5> = LrcPtr::new(Documents::Mut5 {
                                l0: MutCell::new(0_i32),
                            });
                            while Documents::method31(v28, v30.clone()) {
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
                                    Documents::method52(
                                        foldBack(
                                            Func2::new(
                                                move |b0: char, b1: LrcPtr<Documents::UH0>| {
                                                    (Documents::method47())(b0)(b1)
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
                            Documents::method53(
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
                                    while Documents::method31(v89, v91.clone()) {
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
                                                             Documents::method52(foldBack(Func2::new(move
                                                                                                         |b0:
                                                                                                              char,
                                                                                                          b1:
                                                                                                              LrcPtr<Documents::UH0>|
                                                                                                         (Documents::method47())(b0)(b1)),
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
                                    let v138: Documents::US13 = Documents::method54(
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
                                            let v145: List<string> = Documents::method58(
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
                                                    while Documents::method31(v175, v177.clone()) {
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
                                                                                 Documents::method52(foldBack(Func2::new(move
                                                                                                                             |b0:
                                                                                                                                  char,
                                                                                                                              b1:
                                                                                                                                  LrcPtr<Documents::UH0>|
                                                                                                                             (Documents::method47())(b0)(b1)),
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
                                                     Documents::method56(v1_1.get().clone(),
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
                                        ) => Documents::method59(
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
                                            let v278: List<string> = Documents::method58(
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
                            let v303: i32 = Documents::method60(v298.clone(), 0_i32);
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
                                    continue '_method50;
                                }
                                _ => Documents::US13::US13_0(
                                    Documents::method57(
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
                            Documents::method57(
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
        pub fn method49(v0_1: string) -> Documents::US12 {
            let _v0: MutCell<Option<Option<string>>> = MutCell::new(None::<Option<string>>);
            _v0.set(Some(Some(v0_1)));
            {
                let v11: Documents::US13 = Documents::method50(
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
                        Documents::US18::US18_0(toArray_1(Documents::method58(
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
        pub fn method61(
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
        pub fn method62() -> Func1<std::string::String, Documents::US19> {
            Func1::new(move |v: std::string::String| Documents::closure30((), v))
        }
        pub fn closure31(unitVar: (), unitVar_1: ()) -> string {
            string("runtime.execute_with_options / child error")
        }
        pub fn closure32(v0_1: std::string::String, unitVar: ()) -> string {
            sprintf!("error: {} / {}", v0_1, Documents::closure6((), ()))
        }
        pub fn method63(
            v0_1: std::sync::Arc<std::sync::Mutex<Option<std::process::Child>>>,
        ) -> std::sync::Arc<std::sync::Mutex<Option<std::process::Child>>> {
            v0_1
        }
        pub fn closure33(unitVar: (), v0_1: std::string::String) -> Documents::US21 {
            Documents::US21::US21_0(v0_1)
        }
        pub fn method64() -> Func1<std::string::String, Documents::US21> {
            Func1::new(move |v: std::string::String| Documents::closure33((), v))
        }
        pub fn closure34(unitVar: (), v0_1: std::string::String) -> Documents::US21 {
            Documents::US21::US21_1(v0_1)
        }
        pub fn method65() -> Func1<std::string::String, Documents::US21> {
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
        pub fn method66(
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
        pub fn method67(
        ) -> Func1<std::sync::mpsc::SendError<std::string::String>, std::string::String> {
            Func1::new(move |v: std::sync::mpsc::SendError<std::string::String>| {
                Documents::closure38((), v)
            })
        }
        pub fn method68(v0_1: Result<(), string>) -> Result<(), string> {
            v0_1
        }
        pub fn method69(
            v0_1: std::sync::Arc<std::sync::Mutex<Option<std::process::ChildStdin>>>,
        ) -> std::sync::Arc<std::sync::Mutex<Option<std::process::ChildStdin>>> {
            v0_1
        }
        pub fn method70(
            v0_1: std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>,
        ) -> std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>> {
            v0_1
        }
        pub fn method71(
            v0_1: std::sync::MutexGuard<std::process::ChildStdin>,
        ) -> std::sync::MutexGuard<std::process::ChildStdin> {
            v0_1
        }
        pub fn method72(
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
        pub fn method73(
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
                "runtime.execute_with_options_async / options: {:?}",
                (v0_1, v1_1, v2, v3, v4, v5, v6)
            )
        }
        pub fn method75() -> Func0<string> {
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
                "runtime.execute_with_options_async / WaitForExitAsync / ex: {:?}",
                v0_1
            )
        }
        pub fn closure51(v0_1: i32, v1_1: string, unitVar: ()) -> string {
            sprintf!(
                "runtime.execute_with_options_async / exit_code: {} / output.Length: {}",
                v0_1,
                length(v1_1)
            )
        }
        pub fn method74(
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
        pub fn method43(
            v0_1: Option<CancellationToken>,
            v1_1: string,
            v2: Array<(string, string)>,
            v3: Option<Func1<(bool, string, i32), Arc<Async<()>>>>,
            v4: Option<Func1<std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>, ()>>,
            v5: bool,
            v6: Option<string>,
        ) -> (i32, string) {
            let _v7: MutCell<Option<(i32, string)>> = MutCell::new(None::<(i32, string)>);
            let patternInput: (string, string) = Documents::method45(Documents::method44(
                v0_1.clone(),
                v1_1.clone(),
                v2.clone(),
                v3.clone(),
                v4.clone(),
                v5,
                v6.clone(),
            ));
            let v9: string = patternInput.0.clone();
            let v11: Documents::US12 = Documents::method49(patternInput.1.clone());
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
                    let x_15: LrcPtr<(i32, string)> = (Func0::new({
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
                                let v85 = Documents::method37();
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
                                let v101 = Documents::method61();
                                let v102 = Documents::method62();
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
                                                > = Documents::method63(v105.clone());
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
                                                > = Documents::method63(v105.clone());
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
                                                > = Documents::method63(v105.clone());
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
                                                                    Documents::method37();
                                                                let v217:
                                                                        Result<std::string::String,
                                                                               std::string::String> =
                                                                    v212.map_err(|x| v215(x));
                                                                let v218 =
                                                                    Documents::method64();
                                                                let v219 =
                                                                    Documents::method65();
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
                                                                    Documents::method66(v214);
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
                                                                    Documents::method67();
                                                                let v266:
                                                                        Result<(),
                                                                               std::string::String> =
                                                                    v263.map_err(|x| v264(x));
                                                                let v268: _ =
                                                                    v266;
                                                                let v270:
                                                                        bool =
                                                                    true; v268 }); //;
                                                let v273: Result<(), string> = Documents::method68(
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
                                                                        Documents::method37();
                                                                    let v296:
                                                                            Result<std::string::String,
                                                                                   std::string::String> =
                                                                        v291.map_err(|x| v294(x));
                                                                    let v297 =
                                                                        Documents::method64();
                                                                    let v298 =
                                                                        Documents::method65();
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
                                                                        Documents::method66(v293);
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
                                                                        Documents::method67();
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
                                                        Documents::method68(
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
                                                                                        Documents::method69(v185);
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
                                                                                                        Documents::method70(v398);
                                                                                let v401:
                                                                                                            Result<std::sync::MutexGuard<std::process::ChildStdin>,
                                                                                                                   std::sync::PoisonError<std::sync::MutexGuard<std::process::ChildStdin>>> =
                                                                                                        v399.lock();
                                                                                let v404:
                                                                                                            std::sync::MutexGuard<std::process::ChildStdin> =
                                                                                                        Documents::method71(v401.unwrap());
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
                                                            > = Documents::method63(v105);
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
                                                            let v424 = Documents::method37();
                                                            let v426: Result<
                                                                std::process::Output,
                                                                std::string::String,
                                                            > = v423.map_err(|x| v424(x));
                                                            let v427: std::thread::JoinHandle<
                                                                Result<(), string>,
                                                            > = Documents::method72(v361);
                                                            let v430: string = string("v427");
                                                            let v431: std::thread::JoinHandle<
                                                                Result<(), string>,
                                                            > = Documents::method72(v279);
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
                                                                        let _v457: LrcPtr<
                                                                            MutCell<
                                                                                Option<
                                                                                    Documents::US25,
                                                                                >,
                                                                            >,
                                                                        > = refCell(
                                                                            None::<Documents::US25>,
                                                                        );
                                                                        {
                                                                            let x_13: Option<
                                                                                Documents::US25,
                                                                            > = match &v456 {
                                                                                None => None::<
                                                                                    Documents::US25,
                                                                                >,
                                                                                Some(v456_0_0) => {
                                                                                    let x_11: i32 =
                                                                                        v456_0_0
                                                                                            .clone();
                                                                                    Some((Func0::new({
                                                                                                                                 let x_11
                                                                                                                                     =
                                                                                                                                     x_11.clone();
                                                                                                                                 move
                                                                                                                                     ||
                                                                                                                                     Documents::US25::US25_0(x_11)
                                                                                                                             }))())
                                                                                }
                                                                            };
                                                                            _v457.set(x_13)
                                                                        }
                                                                        {
                                                                            let v462:
                                                                                                        Documents::US25 =
                                                                                                    defaultValue(Documents::US25::US25_1,
                                                                                                                 _v457.get().clone());
                                                                            match &v462
                                                                                                    {
                                                                                                    Documents::US25::US25_0(v462_0_0)
                                                                                                    =>
                                                                                                    (match &v462
                                                                                                         {
                                                                                                         Documents::US25::US25_0(x)
                                                                                                         =>
                                                                                                         x.clone(),
                                                                                                         _
                                                                                                         =>
                                                                                                         unreachable!(),
                                                                                                     },
                                                                                                     Documents::US4::US4_1,
                                                                                                     Documents::US20::US20_0(v200.clone())),
                                                                                                    _
                                                                                                    =>
                                                                                                    {
                                                                                                        let v468:
                                                                                                                &str =
                                                                                                            &*string("runtime.execute_with_options / exit_code=None");
                                                                                                        (-1_i32,
                                                                                                         Documents::US4::US4_0(String::from(v468)),
                                                                                                         Documents::US20::US20_0(v200.clone()))
                                                                                                    }
                                                                                                }
                                                                        }
                                                                    }
                                                                    Documents::US24::US24_1(
                                                                        v451_1_0,
                                                                    ) => {
                                                                        let v479:
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
                                                                                let v479 =
                                                                                    v479.clone();
                                                                                move || {
                                                                                    Documents::closure42(v479.clone(),
                                                                                                                                                       ())
                                                                                }
                                                                            }),
                                                                        );
                                                                        (
                                                                            -2_i32,
                                                                            Documents::US4::US4_0(
                                                                                v479.clone(),
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
                                            let v491: std::string::String = v104_1_0.clone();
                                            Documents::method5(
                                                Documents::US0::US0_4,
                                                Func0::new(move || Documents::closure31((), ())),
                                                Func0::new({
                                                    let v491 = v491.clone();
                                                    move || Documents::closure32(v491.clone(), ())
                                                }),
                                            );
                                            (
                                                -1_i32,
                                                Documents::US4::US4_0(v491.clone()),
                                                Documents::US20::US20_1,
                                            )
                                        }
                                    };
                                let v502: Documents::US20 = patternInput_3.2.clone();
                                let v501: Documents::US4 = patternInput_3.1.clone();
                                let v500: i32 = patternInput_3.0.clone();
                                let v507: Option<
                                    std::sync::Arc<
                                        std::sync::Mutex<
                                            std::sync::Arc<
                                                std::sync::mpsc::Receiver<std::string::String>,
                                            >,
                                        >,
                                    >,
                                > = match &v502 {
                                    Documents::US20::US20_0(v502_0_0) => Some(match &v502 {
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
                                let v509: bool = true;
                                let _result = v507.map(|x| {
                                    //;
                                    let v512: std::sync::Arc<
                                        std::sync::Mutex<
                                            std::sync::Arc<
                                                std::sync::mpsc::Receiver<std::string::String>,
                                            >,
                                        >,
                                    > = Documents::method73(x);
                                    let v514: Result<
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
                                    > = v512.lock();
                                    let v516: std::sync::MutexGuard<
                                        std::sync::Arc<
                                            std::sync::mpsc::Receiver<std::string::String>,
                                        >,
                                    > = v514.unwrap();
                                    let v518 = v516.iter();
                                    let v520: Vec<std::string::String> = v518.collect::<Vec<_>>();
                                    let v522: bool = true;
                                    let _result: Vec<_> = v520
                                        .into_iter()
                                        .map(|x| {
                                            //;
                                            let v524: std::string::String = x;
                                            let v526: string =
                                                fable_library_rust::String_::fromString(v524);
                                            let v528: bool = true;
                                            v526
                                        })
                                        .collect::<Vec<_>>();
                                    let v530: Vec<string> = _result;
                                    let v538: string = join(
                                        string("\n"),
                                        toArray(ofArray_1(
                                            fable_library_rust::NativeArray_::array_from(v530),
                                        )),
                                    );
                                    let v540: bool = true;
                                    v538
                                });
                                let v542: Option<string> = _result;
                                let v549: Documents::US3 = match &v501 {
                                    Documents::US4::US4_0(v501_0_0) => Documents::US3::US3_0(
                                        fable_library_rust::String_::fromString(match &v501 {
                                            Documents::US4::US4_0(x) => x.clone(),
                                            _ => unreachable!(),
                                        }),
                                    ),
                                    _ => Documents::US3::US3_1,
                                };
                                let v554: string = defaultValue(
                                    match &v549 {
                                        Documents::US3::US3_0(v549_0_0) => match &v549 {
                                            Documents::US3::US3_0(x) => x.clone(),
                                            _ => unreachable!(),
                                        },
                                        _ => string(""),
                                    },
                                    v542,
                                );
                                Documents::method5(
                                    Documents::US0::US0_0,
                                    Func0::new(move || Documents::closure43((), ())),
                                    Func0::new({
                                        let v500 = v500.clone();
                                        let v554 = v554.clone();
                                        move || Documents::closure44(v500, v554.clone(), ())
                                    }),
                                );
                                LrcPtr::new((v500, v554.clone()))
                            }
                        }
                    }))();
                    _v35.set(Some(x_15))
                }
                {
                    let v559: LrcPtr<(i32, string)> = match &_v35.get().clone() {
                        None => panic!("{}", string("base.capture / _v35=None"),),
                        Some(_v35_0_0) => _v35_0_0.clone(),
                    };
                    _v7.set(Some((v559.0.clone(), v559.1.clone())));
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
        pub fn method77(v0_1: string) -> string {
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
        pub fn method76(v0_1: string, v1_1: string, v2: string) -> (string, string) {
            let v4: string = Documents::method15(v2, Documents::method77(v1_1.clone()));
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
        pub fn closure52(unitVar: (), v0_1: string) -> Documents::US29 {
            Documents::US29::US29_0(v0_1)
        }
        pub fn method78() -> Func1<string, Documents::US29> {
            Func1::new(move |v: string| Documents::closure52((), v))
        }
        pub fn closure53(unitVar: (), v0_1: std::string::String) -> Documents::US29 {
            Documents::US29::US29_1(v0_1)
        }
        pub fn method79() -> Func1<std::string::String, Documents::US29> {
            Func1::new(move |v: std::string::String| Documents::closure53((), v))
        }
        pub fn method80(v0_1: string) -> bool {
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
        pub fn method82(v0_1: string) -> string {
            v0_1
        }
        pub fn method81(v0_1: string, v1_1: string) {
            let _v2: MutCell<Option<()>> = MutCell::new(None::<()>);
            let v3: string = Documents::method82(v0_1);
            let v5: Result<u64, std::io::Error> = std::fs::copy(&*v1_1, &*v3);
            let v7: u64 = v5.unwrap();
            _v2.set(Some(()));
            match &_v2.get().clone() {
                None => panic!("{}", string("base.run_target / _v2=None"),),
                Some(_v2_0_0) => _v2_0_0.clone(),
            }
            ()
        }
        pub fn method84(v0_1: i32, v1_1: LrcPtr<Documents::Mut6>) -> bool {
            v1_1.l0.get().clone() < v0_1
        }
        pub fn method85(v0_1: string) -> string {
            v0_1
        }
        pub fn method86(
            v0_1: std::sync::MutexGuard<std::process::ChildStdin>,
        ) -> std::sync::MutexGuard<std::process::ChildStdin> {
            v0_1
        }
        pub fn closure58(
            v0_1: string,
            v1_1: std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>,
        ) {
            let v2: std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>> =
                Documents::method70(v1_1);
            let v4: Result<
                std::sync::MutexGuard<std::process::ChildStdin>,
                std::sync::PoisonError<std::sync::MutexGuard<std::process::ChildStdin>>,
            > = v2.lock();
            let v6: std::sync::MutexGuard<std::process::ChildStdin> = v4.unwrap();
            let v7: string = Documents::method85(v0_1);
            let v9: &[u8] = v7.as_bytes();
            let v10: std::sync::MutexGuard<std::process::ChildStdin> = Documents::method86(v6);
            let v12: bool = true;
            let mut v10 = v10;
            let v14: bool = true;
            std::io::Write::write_all(&mut *v10, v9).unwrap();
            ()
        }
        pub fn method87(v0_1: i32, v1_1: LrcPtr<Documents::Mut7>) -> bool {
            v1_1.l0.get().clone() < v0_1
        }
        pub fn method88(v0_1: string) -> string {
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
        pub fn method83(v0_1: string, v1_1: string, v2: string, v3: string) -> Documents::US30 {
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
                    while Documents::method31(v30, v32.clone()) {
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
                        while Documents::method84(v39, v41.clone()) {
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
                            while Documents::method31(v51, v53.clone()) {
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
                                        Documents::method43(None::<CancellationToken>,
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
                                    while Documents::method87(v39, v101.clone()) {
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
                                        Documents::US30::US30_0(v96, v126.clone())
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
        ) -> Documents::US28 {
            let patternInput: (string, string) = Documents::method76(v5, v4.clone(), v0_1);
            let v7: string = patternInput.1.clone();
            let v6: string = patternInput.0.clone();
            if (if if Documents::method80(v7.clone()) {
                Documents::method80(v6.clone())
            } else {
                false
            } {
                let v11: string = Documents::method26(v7.clone());
                let v13: Result<std::fs::File, std::io::Error> = std::fs::File::open(&*v11);
                let v15: std::fs::File = v13.unwrap();
                let v17: std::io::BufReader<std::fs::File> = std::io::BufReader::new(v15);
                let v19: std::io::BufReader<std::io::BufReader<std::fs::File>> =
                    std::io::BufReader::new(v17);
                let v21: bool = true;
                let mut v19 = v19;
                let result: sha2::Sha256 = sha2::Digest::new();
                {
                    let v24: sha2::Sha256 = result;
                    let v26: bool = true;
                    let mut v24 = v24;
                    let v27: usize = 0_i32 as usize;
                    let v29: _ = [0_u8; 1024];
                    let v31: bool = true;
                    loop {
                        // rust.loop;
                        let v33: bool = true;
                        let mut v29 = v29;
                        let v35: Result<usize, std::io::Error> =
                            std::io::Read::read(&mut v19, &mut v29);
                        let v37: usize = v35.unwrap();
                        if v37 == v27 {
                            let v40: bool = true;
                            break;
                            ()
                        }
                        {
                            let v42: usize = v29.len();
                            let v43: u8 = v42 as u8;
                            let v44: usize = v37;
                            let v51: &_ = if v44 == v42 {
                                &v29[v27..]
                            } else {
                                &v29[v27..v44]
                            };
                            sha2::Digest::update(&mut v24, v51);
                            {
                                let v54: bool = true;
                            } // rust.loop;
                            let v56: bool = true;
                        } // rust.loop;
                        let v58: bool = true;
                    } // rust.loop;
                    let v60: bool = true;
                    {
                        // rust.loop;
                        let v62: bool = true;
                        {
                            // rust.loop;
                            let v64: &[u8] = &sha2::Digest::finalize(v24);
                            let v66: Vec<u8> = v64.iter().map(|x| *x).collect::<Vec<_>>();
                            let v68: bool = true;
                            let _result: Vec<_> = v66
                                .into_iter()
                                .map(|x| {
                                    //;
                                    let v70: u8 = x;
                                    let v72: std::string::String = format!("{:02x}", v70);
                                    let v74: string = fable_library_rust::String_::fromString(v72);
                                    let v76: bool = true;
                                    v74
                                })
                                .collect::<Vec<_>>();
                            let v78: Vec<string> = _result;
                            let v80: Array<string> =
                                fable_library_rust::NativeArray_::array_from(v78);
                            let v85: string = join(
                                string(""),
                                toArray(delay(Func0::new({
                                    let v80 = v80.clone();
                                    move || {
                                        map(
                                            Func1::new({
                                                let v80 = v80.clone();
                                                move |i: i32| v80[i].clone()
                                            }),
                                            rangeNumeric(
                                                0_i32,
                                                1_i32,
                                                count_2(v80.clone()) - 1_i32,
                                            ),
                                        )
                                    }
                                }))),
                            );
                            let v87 = Documents::method37();
                            let v89: Result<string, std::string::String> =
                                Ok::<string, std::io::Error>(v85).map_err(|x| v87(x));
                            let v90 = Documents::method78();
                            let v91 = Documents::method79();
                            let v93: Documents::US29 = match v89 {
                                Ok(x) => v90(x),
                                Err(e) => v91(e),
                            };
                            let v99: string = match &v93 {
                                Documents::US29::US29_0(v93_0_0) => v93_0_0.clone(),
                                Documents::US29::US29_1(v93_1_0) => panic!(
                                    "{}",
                                    sprintf!(
                                        "resultm.get / Result value was Error: {}",
                                        v93_1_0.clone()
                                    ),
                                ),
                            };
                            let v100: string = Documents::method26(v6.clone());
                            let v102: Result<std::fs::File, std::io::Error> =
                                std::fs::File::open(&*v100);
                            let v104: std::fs::File = v102.unwrap();
                            let v106: std::io::BufReader<std::fs::File> =
                                std::io::BufReader::new(v104);
                            let v108: std::io::BufReader<std::io::BufReader<std::fs::File>> =
                                std::io::BufReader::new(v106);
                            let v110: bool = true;
                            let mut v108 = v108;
                            let result: sha2::Sha256 = sha2::Digest::new();
                            {
                                let v113: sha2::Sha256 = result;
                                let v115: bool = true;
                                let mut v113 = v113;
                                let v116: usize = 0_i32 as usize;
                                let v118: _ = [0_u8; 1024];
                                let v120: bool = true;
                                loop {
                                    // rust.loop;
                                    let v122: bool = true;
                                    let mut v118 = v118;
                                    let v124: Result<usize, std::io::Error> =
                                        std::io::Read::read(&mut v108, &mut v118);
                                    let v126: usize = v124.unwrap();
                                    if v126 == v116 {
                                        let v129: bool = true;
                                        break;
                                        ()
                                    }
                                    {
                                        let v131: usize = v118.len();
                                        let v132: u8 = v131 as u8;
                                        let v133: usize = v126;
                                        let v140: &_ = if v133 == v131 {
                                            &v118[v116..]
                                        } else {
                                            &v118[v116..v133]
                                        };
                                        sha2::Digest::update(&mut v113, v140);
                                        {
                                            let v143: bool = true;
                                        } // rust.loop;
                                        let v145: bool = true;
                                    } // rust.loop;
                                    let v147: bool = true;
                                } // rust.loop;
                                let v149: bool = true;
                                {
                                    // rust.loop;
                                    let v151: bool = true;
                                    {
                                        // rust.loop;
                                        let v153: &[u8] = &sha2::Digest::finalize(v113);
                                        let v155: Vec<u8> =
                                            v153.iter().map(|x| *x).collect::<Vec<_>>();
                                        let v157: bool = true;
                                        let _result: Vec<_> = v155
                                            .into_iter()
                                            .map(|x| {
                                                //;
                                                let v159: u8 = x;
                                                let v161: std::string::String =
                                                    format!("{:02x}", v159);
                                                let v163: string =
                                                    fable_library_rust::String_::fromString(v161);
                                                let v165: bool = true;
                                                v163
                                            })
                                            .collect::<Vec<_>>();
                                        let v167: Vec<string> = _result;
                                        let v169: Array<string> =
                                            fable_library_rust::NativeArray_::array_from(v167);
                                        let v173: string = join(
                                            string(""),
                                            toArray(delay(Func0::new({
                                                let v169 = v169.clone();
                                                move || {
                                                    map(
                                                        Func1::new({
                                                            let v169 = v169.clone();
                                                            move |i_1: i32| v169[i_1].clone()
                                                        }),
                                                        rangeNumeric(
                                                            0_i32,
                                                            1_i32,
                                                            count_2(v169.clone()) - 1_i32,
                                                        ),
                                                    )
                                                }
                                            }))),
                                        );
                                        let v175 = Documents::method37();
                                        let v177: Result<string, std::string::String> =
                                            Ok::<string, std::io::Error>(v173).map_err(|x| v175(x));
                                        let v178 = Documents::method78();
                                        let v179 = Documents::method79();
                                        let v181: Documents::US29 = match v177 {
                                            Ok(x) => v178(x),
                                            Err(e) => v179(e),
                                        };
                                        v99 == match &v181 {
                                            Documents::US29::US29_0(v181_0_0) => v181_0_0.clone(),
                                            Documents::US29::US29_1(v181_1_0) => panic!(
                                                "{}",
                                                sprintf!(
                                                    "resultm.get / Result value was Error: {}",
                                                    v181_1_0.clone()
                                                ),
                                            ),
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
                let v191: Documents::US30 = Documents::method83(v2, v3, v7.clone(), v4);
                match &v191 {
                    Documents::US30::US30_0(v191_0_0, v191_0_1) => {
                        let v193: string = v191_0_1.clone();
                        let v192: i32 = v191_0_0.clone();
                        if v192 != 0_i32 {
                            Documents::method5(
                                Documents::US0::US0_2,
                                Func0::new(move || Documents::closure61((), ())),
                                Func0::new({
                                    let v192 = v192.clone();
                                    let v193 = v193.clone();
                                    move || Documents::closure62(v193.clone(), v192, ())
                                }),
                            );
                            Documents::US28::US28_0(Err::<string, LrcPtr<(string, string)>>(
                                LrcPtr::new((v7.clone(), v193.clone())),
                            ))
                        } else {
                            if Documents::method80(v7.clone()) {
                                Documents::method81(v6, v7.clone())
                            } else {
                                panic!(
                                    "{}",
                                    sprintf!("documents.files_fn / {} should exist", v7.clone()),
                                )
                            }
                            Documents::US28::US28_0(Ok::<string, LrcPtr<(string, string)>>(
                                v7.clone(),
                            ))
                        }
                    }
                    Documents::US30::US30_1(v191_1_0, v191_1_1) => {
                        Documents::US28::US28_0(Err::<string, LrcPtr<(string, string)>>(
                            LrcPtr::new((v7.clone(), v191_1_1.clone())),
                        ))
                    }
                }
            } else {
                Documents::US28::US28_1
            }
        }
        pub fn closure56(
            v0_1: string,
            v1_1: string,
            v2: string,
            v3: string,
            v4: string,
        ) -> Func1<string, Documents::US28> {
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
        pub fn method89(
            v0_1: bool,
            v1_1: string,
            v2: string,
            v3: string,
            v4: string,
        ) -> Documents::US30 {
            let patternInput: (i32, string) = Documents::method43(
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
                Documents::US30::US30_1(v58, v59.clone())
            } else {
                Documents::US30::US30_0(v58, v59.clone())
            }
        }
        pub fn closure64(
            v0_1: string,
            v1_1: string,
            v2: bool,
            v3: string,
            v4: string,
        ) -> Documents::US28 {
            let patternInput: (string, string) = Documents::method76(v4.clone(), v3.clone(), v0_1);
            let v6: string = patternInput.1.clone();
            let v5: string = patternInput.0.clone();
            if (if if Documents::method80(v6.clone()) {
                Documents::method80(v5.clone())
            } else {
                false
            } {
                let v10: string = Documents::method26(v6.clone());
                let v12: Result<std::fs::File, std::io::Error> = std::fs::File::open(&*v10);
                let v14: std::fs::File = v12.unwrap();
                let v16: std::io::BufReader<std::fs::File> = std::io::BufReader::new(v14);
                let v18: std::io::BufReader<std::io::BufReader<std::fs::File>> =
                    std::io::BufReader::new(v16);
                let v20: bool = true;
                let mut v18 = v18;
                let result: sha2::Sha256 = sha2::Digest::new();
                {
                    let v23: sha2::Sha256 = result;
                    let v25: bool = true;
                    let mut v23 = v23;
                    let v26: usize = 0_i32 as usize;
                    let v28: _ = [0_u8; 1024];
                    let v30: bool = true;
                    loop {
                        // rust.loop;
                        let v32: bool = true;
                        let mut v28 = v28;
                        let v34: Result<usize, std::io::Error> =
                            std::io::Read::read(&mut v18, &mut v28);
                        let v36: usize = v34.unwrap();
                        if v36 == v26 {
                            let v39: bool = true;
                            break;
                            ()
                        }
                        {
                            let v41: usize = v28.len();
                            let v42: u8 = v41 as u8;
                            let v43: usize = v36;
                            let v50: &_ = if v43 == v41 {
                                &v28[v26..]
                            } else {
                                &v28[v26..v43]
                            };
                            sha2::Digest::update(&mut v23, v50);
                            {
                                let v53: bool = true;
                            } // rust.loop;
                            let v55: bool = true;
                        } // rust.loop;
                        let v57: bool = true;
                    } // rust.loop;
                    let v59: bool = true;
                    {
                        // rust.loop;
                        let v61: bool = true;
                        {
                            // rust.loop;
                            let v63: &[u8] = &sha2::Digest::finalize(v23);
                            let v65: Vec<u8> = v63.iter().map(|x| *x).collect::<Vec<_>>();
                            let v67: bool = true;
                            let _result: Vec<_> = v65
                                .into_iter()
                                .map(|x| {
                                    //;
                                    let v69: u8 = x;
                                    let v71: std::string::String = format!("{:02x}", v69);
                                    let v73: string = fable_library_rust::String_::fromString(v71);
                                    let v75: bool = true;
                                    v73
                                })
                                .collect::<Vec<_>>();
                            let v77: Vec<string> = _result;
                            let v79: Array<string> =
                                fable_library_rust::NativeArray_::array_from(v77);
                            let v84: string = join(
                                string(""),
                                toArray(delay(Func0::new({
                                    let v79 = v79.clone();
                                    move || {
                                        map(
                                            Func1::new({
                                                let v79 = v79.clone();
                                                move |i: i32| v79[i].clone()
                                            }),
                                            rangeNumeric(
                                                0_i32,
                                                1_i32,
                                                count_2(v79.clone()) - 1_i32,
                                            ),
                                        )
                                    }
                                }))),
                            );
                            let v86 = Documents::method37();
                            let v88: Result<string, std::string::String> =
                                Ok::<string, std::io::Error>(v84).map_err(|x| v86(x));
                            let v89 = Documents::method78();
                            let v90 = Documents::method79();
                            let v92: Documents::US29 = match v88 {
                                Ok(x) => v89(x),
                                Err(e) => v90(e),
                            };
                            let v98: string = match &v92 {
                                Documents::US29::US29_0(v92_0_0) => v92_0_0.clone(),
                                Documents::US29::US29_1(v92_1_0) => panic!(
                                    "{}",
                                    sprintf!(
                                        "resultm.get / Result value was Error: {}",
                                        v92_1_0.clone()
                                    ),
                                ),
                            };
                            let v99: string = Documents::method26(v5.clone());
                            let v101: Result<std::fs::File, std::io::Error> =
                                std::fs::File::open(&*v99);
                            let v103: std::fs::File = v101.unwrap();
                            let v105: std::io::BufReader<std::fs::File> =
                                std::io::BufReader::new(v103);
                            let v107: std::io::BufReader<std::io::BufReader<std::fs::File>> =
                                std::io::BufReader::new(v105);
                            let v109: bool = true;
                            let mut v107 = v107;
                            let result: sha2::Sha256 = sha2::Digest::new();
                            {
                                let v112: sha2::Sha256 = result;
                                let v114: bool = true;
                                let mut v112 = v112;
                                let v115: usize = 0_i32 as usize;
                                let v117: _ = [0_u8; 1024];
                                let v119: bool = true;
                                loop {
                                    // rust.loop;
                                    let v121: bool = true;
                                    let mut v117 = v117;
                                    let v123: Result<usize, std::io::Error> =
                                        std::io::Read::read(&mut v107, &mut v117);
                                    let v125: usize = v123.unwrap();
                                    if v125 == v115 {
                                        let v128: bool = true;
                                        break;
                                        ()
                                    }
                                    {
                                        let v130: usize = v117.len();
                                        let v131: u8 = v130 as u8;
                                        let v132: usize = v125;
                                        let v139: &_ = if v132 == v130 {
                                            &v117[v115..]
                                        } else {
                                            &v117[v115..v132]
                                        };
                                        sha2::Digest::update(&mut v112, v139);
                                        {
                                            let v142: bool = true;
                                        } // rust.loop;
                                        let v144: bool = true;
                                    } // rust.loop;
                                    let v146: bool = true;
                                } // rust.loop;
                                let v148: bool = true;
                                {
                                    // rust.loop;
                                    let v150: bool = true;
                                    {
                                        // rust.loop;
                                        let v152: &[u8] = &sha2::Digest::finalize(v112);
                                        let v154: Vec<u8> =
                                            v152.iter().map(|x| *x).collect::<Vec<_>>();
                                        let v156: bool = true;
                                        let _result: Vec<_> = v154
                                            .into_iter()
                                            .map(|x| {
                                                //;
                                                let v158: u8 = x;
                                                let v160: std::string::String =
                                                    format!("{:02x}", v158);
                                                let v162: string =
                                                    fable_library_rust::String_::fromString(v160);
                                                let v164: bool = true;
                                                v162
                                            })
                                            .collect::<Vec<_>>();
                                        let v166: Vec<string> = _result;
                                        let v168: Array<string> =
                                            fable_library_rust::NativeArray_::array_from(v166);
                                        let v172: string = join(
                                            string(""),
                                            toArray(delay(Func0::new({
                                                let v168 = v168.clone();
                                                move || {
                                                    map(
                                                        Func1::new({
                                                            let v168 = v168.clone();
                                                            move |i_1: i32| v168[i_1].clone()
                                                        }),
                                                        rangeNumeric(
                                                            0_i32,
                                                            1_i32,
                                                            count_2(v168.clone()) - 1_i32,
                                                        ),
                                                    )
                                                }
                                            }))),
                                        );
                                        let v174 = Documents::method37();
                                        let v176: Result<string, std::string::String> =
                                            Ok::<string, std::io::Error>(v172).map_err(|x| v174(x));
                                        let v177 = Documents::method78();
                                        let v178 = Documents::method79();
                                        let v180: Documents::US29 = match v176 {
                                            Ok(x) => v177(x),
                                            Err(e) => v178(e),
                                        };
                                        v98 == match &v180 {
                                            Documents::US29::US29_0(v180_0_0) => v180_0_0.clone(),
                                            Documents::US29::US29_1(v180_1_0) => panic!(
                                                "{}",
                                                sprintf!(
                                                    "resultm.get / Result value was Error: {}",
                                                    v180_1_0.clone()
                                                ),
                                            ),
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
                let v190: Documents::US30 = Documents::method89(v2, v6.clone(), v3, v1_1, v4);
                match &v190 {
                    Documents::US30::US30_0(v190_0_0, v190_0_1) => {
                        let v192: string = v190_0_1.clone();
                        let v191: i32 = v190_0_0.clone();
                        if v191 != 0_i32 {
                            Documents::method5(
                                Documents::US0::US0_2,
                                Func0::new(move || Documents::closure61((), ())),
                                Func0::new({
                                    let v191 = v191.clone();
                                    let v192 = v192.clone();
                                    move || Documents::closure62(v192.clone(), v191, ())
                                }),
                            );
                            Documents::US28::US28_0(Err::<string, LrcPtr<(string, string)>>(
                                LrcPtr::new((v6.clone(), v192.clone())),
                            ))
                        } else {
                            if Documents::method80(v6.clone()) {
                                Documents::method81(v5, v6.clone())
                            } else {
                                panic!(
                                    "{}",
                                    sprintf!("documents.files_fn / {} should exist", v6.clone()),
                                )
                            }
                            Documents::US28::US28_0(Ok::<string, LrcPtr<(string, string)>>(
                                v6.clone(),
                            ))
                        }
                    }
                    Documents::US30::US30_1(v190_1_0, v190_1_1) => {
                        Documents::US28::US28_0(Err::<string, LrcPtr<(string, string)>>(
                            LrcPtr::new((v6.clone(), v190_1_1.clone())),
                        ))
                    }
                }
            } else {
                Documents::US28::US28_1
            }
        }
        pub fn closure63(
            v0_1: string,
            v1_1: string,
            v2: bool,
            v3: string,
        ) -> Func1<string, Documents::US28> {
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
        pub fn method90(
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
                    Documents::method90(
                        match v0_1.as_ref() {
                            Documents::UH3::UH3_1(_, x) => x.clone(),
                            _ => unreachable!(),
                        },
                        v1_1.clone(),
                    ),
                ),
            }
        }
        pub fn method91(v0_1: i32, v1_1: LrcPtr<Documents::Mut8>) -> bool {
            v1_1.l0.get().clone() < v0_1
        }
        pub fn method92(
            v0_1: LrcPtr<Documents::UH4>,
            v1_1: List<(
                string,
                string,
                Func1<string, Func1<string, Documents::US28>>,
            )>,
        ) -> List<(
            string,
            string,
            Func1<string, Func1<string, Documents::US28>>,
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
                    Documents::method92(
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
                Func1<string, Func1<string, Documents::US28>>,
            ),
        ) -> Option<Result<string, LrcPtr<(string, string)>>> {
            let v4: Documents::US28 = (_arg.2.clone())(_arg.1.clone())(_arg.0.clone());
            match &v4 {
                Documents::US28::US28_0(v4_0_0) => Some(match &v4 {
                    Documents::US28::US28_0(x) => x.clone(),
                    _ => unreachable!(),
                }),
                _ => None::<Result<string, LrcPtr<(string, string)>>>,
            }
        }
        pub fn method93(
            v0_1: Vec<Option<Result<string, LrcPtr<(string, string)>>>>,
        ) -> Vec<Option<Result<string, LrcPtr<(string, string)>>>> {
            v0_1
        }
        pub fn method94(
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
                let v34: string = Documents::method26(v6);
                let v36: string = Documents::method42(Documents::method15(v2.clone(), v33.clone()));
                let patternInput: (i32, string) = Documents::method43(
                    None::<CancellationToken>,
                    sprintf!(
                        "git ls-tree --format=\'%(objectname)\' origin/gh-pages \"{}\"",
                        v36.clone()
                    ),
                    new_empty::<(string, string)>(),
                    None::<Func1<(bool, string, i32), Arc<Async<()>>>>,
                    None::<Func1<std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>, ()>>,
                    true,
                    Some(v2),
                );
                let v46: string = patternInput.1.clone();
                let v48: string = Documents::method42(Documents::method15(v3.clone(), v33.clone()));
                let patternInput_1: (i32, string) = Documents::method43(
                    None::<CancellationToken>,
                    sprintf!("git hash-object \"{}\"", v48.clone()),
                    new_empty::<(string, string)>(),
                    None::<Func1<(bool, string, i32), Arc<Async<()>>>>,
                    None::<Func1<std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>, ()>>,
                    true,
                    Some(v3.clone()),
                );
                let v58: string = patternInput_1.1.clone();
                let v60: string = Documents::method42(Documents::method15(v4.clone(), v33.clone()));
                let v63: string =
                    (Documents::method76(string("hangul.md"), v48.clone(), v4.clone()))
                        .1
                        .clone();
                let v288: LrcPtr<Documents::UH3> = if contains(v46.clone(), v58.clone()) == false {
                    let v72: string = Documents::method26(v48.clone());
                    let v74: Result<std::fs::File, std::io::Error> = std::fs::File::open(&*v72);
                    let v76: std::fs::File = v74.unwrap();
                    let v78: std::io::BufReader<std::fs::File> = std::io::BufReader::new(v76);
                    let v80: std::io::BufReader<std::io::BufReader<std::fs::File>> =
                        std::io::BufReader::new(v78);
                    let v82: bool = true;
                    let mut v80 = v80;
                    let result: sha2::Sha256 = sha2::Digest::new();
                    {
                        let v85: sha2::Sha256 = result;
                        let v87: bool = true;
                        let mut v85 = v85;
                        let v88: usize = 0_i32 as usize;
                        let v90: _ = [0_u8; 1024];
                        let v92: bool = true;
                        loop {
                            // rust.loop;
                            let v94: bool = true;
                            let mut v90 = v90;
                            let v96: Result<usize, std::io::Error> =
                                std::io::Read::read(&mut v80, &mut v90);
                            let v98: usize = v96.unwrap();
                            if v98 == v88 {
                                let v101: bool = true;
                                break;
                                ()
                            }
                            {
                                let v103: usize = v90.len();
                                let v104: u8 = v103 as u8;
                                let v105: usize = v98;
                                let v112: &_ = if v105 == v103 {
                                    &v90[v88..]
                                } else {
                                    &v90[v88..v105]
                                };
                                sha2::Digest::update(&mut v85, v112);
                                {
                                    let v115: bool = true;
                                } // rust.loop;
                                let v117: bool = true;
                            } // rust.loop;
                            let v119: bool = true;
                        } // rust.loop;
                        let v121: bool = true;
                        {
                            // rust.loop;
                            let v123: bool = true;
                            {
                                // rust.loop;
                                let v125: &[u8] = &sha2::Digest::finalize(v85);
                                let v127: Vec<u8> = v125.iter().map(|x| *x).collect::<Vec<_>>();
                                let v129: bool = true;
                                let _result: Vec<_> = v127
                                    .into_iter()
                                    .map(|x| {
                                        //;
                                        let v131: u8 = x;
                                        let v133: std::string::String = format!("{:02x}", v131);
                                        let v135: string =
                                            fable_library_rust::String_::fromString(v133);
                                        let v137: bool = true;
                                        v135
                                    })
                                    .collect::<Vec<_>>();
                                let v139: Vec<string> = _result;
                                let v141: Array<string> =
                                    fable_library_rust::NativeArray_::array_from(v139);
                                let v145: string = join(
                                    string(""),
                                    toArray(delay(Func0::new({
                                        let v141 = v141.clone();
                                        move || {
                                            map(
                                                Func1::new({
                                                    let v141 = v141.clone();
                                                    move |i: i32| v141[i].clone()
                                                }),
                                                rangeNumeric(
                                                    0_i32,
                                                    1_i32,
                                                    count_2(v141.clone()) - 1_i32,
                                                ),
                                            )
                                        }
                                    }))),
                                );
                                let v147 = Documents::method37();
                                let v149: Result<string, std::string::String> =
                                    Ok::<string, std::io::Error>(v145).map_err(|x| v147(x));
                                let v150 = Documents::method78();
                                let v151 = Documents::method79();
                                let v153: Documents::US29 = match v149 {
                                    Ok(x) => v150(x),
                                    Err(e) => v151(e),
                                };
                                let v159: string = match &v153 {
                                    Documents::US29::US29_0(v153_0_0) => v153_0_0.clone(),
                                    Documents::US29::US29_1(v153_1_0) => panic!(
                                        "{}",
                                        sprintf!(
                                            "resultm.get / Result value was Error: {}",
                                            v153_1_0.clone()
                                        ),
                                    ),
                                };
                                let v251: Documents::US3 = if Documents::method80(v60.clone())
                                    == false
                                {
                                    Documents::US3::US3_1
                                } else {
                                    let v163: string = Documents::method26(v60.clone());
                                    let v165: Result<std::fs::File, std::io::Error> =
                                        std::fs::File::open(&*v163);
                                    let v167: std::fs::File = v165.unwrap();
                                    let v169: std::io::BufReader<std::fs::File> =
                                        std::io::BufReader::new(v167);
                                    let v171: std::io::BufReader<
                                        std::io::BufReader<std::fs::File>,
                                    > = std::io::BufReader::new(v169);
                                    let v173: bool = true;
                                    let mut v171 = v171;
                                    let result: sha2::Sha256 = sha2::Digest::new();
                                    {
                                        let v176: sha2::Sha256 = result;
                                        let v178: bool = true;
                                        let mut v176 = v176;
                                        let v179: usize = 0_i32 as usize;
                                        let v181: _ = [0_u8; 1024];
                                        let v183: bool = true;
                                        loop {
                                            // rust.loop;
                                            let v185: bool = true;
                                            let mut v181 = v181;
                                            let v187: Result<usize, std::io::Error> =
                                                std::io::Read::read(&mut v171, &mut v181);
                                            let v189: usize = v187.unwrap();
                                            if v189 == v179 {
                                                let v192: bool = true;
                                                break;
                                                ()
                                            }
                                            {
                                                let v194: usize = v181.len();
                                                let v195: u8 = v194 as u8;
                                                let v196: usize = v189;
                                                let v203: &_ = if v196 == v194 {
                                                    &v181[v179..]
                                                } else {
                                                    &v181[v179..v196]
                                                };
                                                sha2::Digest::update(&mut v176, v203);
                                                {
                                                    let v206: bool = true;
                                                } // rust.loop;
                                                let v208: bool = true;
                                            } // rust.loop;
                                            let v210: bool = true;
                                        } // rust.loop;
                                        let v212: bool = true;
                                        {
                                            // rust.loop;
                                            let v214: bool = true;
                                            {
                                                // rust.loop;
                                                let v216: &[u8] = &sha2::Digest::finalize(v176);
                                                let v218: Vec<u8> =
                                                    v216.iter().map(|x| *x).collect::<Vec<_>>();
                                                let v220: bool = true;
                                                let _result: Vec<_> = v218
                                                    .into_iter()
                                                    .map(|x| {
                                                        //;
                                                        let v222: u8 = x;
                                                        let v224: std::string::String =
                                                            format!("{:02x}", v222);
                                                        let v226: string =
                                                            fable_library_rust::String_::fromString(
                                                                v224,
                                                            );
                                                        let v228: bool = true;
                                                        v226
                                                    })
                                                    .collect::<Vec<_>>();
                                                let v230: Vec<string> = _result;
                                                let v232: Array<string> =
                                                    fable_library_rust::NativeArray_::array_from(
                                                        v230,
                                                    );
                                                let v236: string = join(
                                                    string(""),
                                                    toArray(delay(Func0::new({
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
                                                                    count_2(v232.clone()) - 1_i32,
                                                                ),
                                                            )
                                                        }
                                                    }))),
                                                );
                                                let v238 = Documents::method37();
                                                let v240: Result<string, std::string::String> =
                                                    Ok::<string, std::io::Error>(v236)
                                                        .map_err(|x| v238(x));
                                                let v241 = Documents::method78();
                                                let v242 = Documents::method79();
                                                let v244: Documents::US29 = match v240 {
                                                    Ok(x) => v241(x),
                                                    Err(e) => v242(e),
                                                };
                                                match &v244 {
                                                    Documents::US29::US29_0(v244_0_0) => {
                                                        Documents::US3::US3_0(v244_0_0.clone())
                                                    }
                                                    _ => Documents::US3::US3_1,
                                                }
                                            }
                                        }
                                    }
                                };
                                if if if let Documents::US3::US3_1 = &v251 {
                                    true
                                } else {
                                    false
                                } {
                                    true
                                } else {
                                    v159.clone()
                                        != match &v251 {
                                            Documents::US3::US3_0(v251_0_0) => match &v251 {
                                                Documents::US3::US3_0(x) => x.clone(),
                                                _ => unreachable!(),
                                            },
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
                                            let v159 = v159.clone();
                                            let v251 = v251.clone();
                                            let v33 = v33.clone();
                                            let v34 = v34.clone();
                                            let v36 = v36.clone();
                                            let v46 = v46.clone();
                                            let v48 = v48.clone();
                                            let v58 = v58.clone();
                                            let v60 = v60.clone();
                                            move || {
                                                Documents::closure55(
                                                    v33.clone(),
                                                    v34.clone(),
                                                    v36.clone(),
                                                    v46.clone(),
                                                    patternInput.0.clone(),
                                                    v48.clone(),
                                                    v58.clone(),
                                                    patternInput_1.0.clone(),
                                                    v60.clone(),
                                                    v159.clone(),
                                                    v251.clone(),
                                                    (),
                                                )
                                            }
                                        }),
                                    );
                                    Documents::method81(v60.clone(), v48.clone());
                                    LrcPtr::new(Documents::UH3::UH3_1(
                                        LrcPtr::new(Documents::UH4::UH4_1(
                                            string("hangul.md"),
                                            v48.clone(),
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
                                                        move |v: string| {
                                                            Documents::closure56(
                                                                v4.clone(),
                                                                v3.clone(),
                                                                v1_1.clone(),
                                                                v0_1.clone(),
                                                                v,
                                                            )
                                                        }
                                                    }))(
                                                        b0
                                                    )(
                                                        b1
                                                    )
                                                }
                                            }),
                                            LrcPtr::new(Documents::UH4::UH4_0),
                                        )),
                                        LrcPtr::new(Documents::UH3::UH3_1(
                                            LrcPtr::new(Documents::UH4::UH4_1(
                                                string("html"),
                                                v48.clone(),
                                                Func2::new({
                                                    let v3 = v3.clone();
                                                    let v4 = v4.clone();
                                                    move |b0: string, b1: string| {
                                                        (Func1::new({
                                                            let v3 = v3.clone();
                                                            let v4 = v4.clone();
                                                            move |v_1: string| {
                                                                Documents::closure63(
                                                                    v4.clone(),
                                                                    v3.clone(),
                                                                    false,
                                                                    v_1,
                                                                )
                                                            }
                                                        }))(
                                                            b0
                                                        )(
                                                            b1
                                                        )
                                                    }
                                                }),
                                                LrcPtr::new(Documents::UH4::UH4_1(
                                                    string("pdf"),
                                                    v48.clone(),
                                                    Func2::new({
                                                        let v3 = v3.clone();
                                                        let v4 = v4.clone();
                                                        move |b0: string, b1: string| {
                                                            (Func1::new({
                                                                let v3 = v3.clone();
                                                                let v4 = v4.clone();
                                                                move |v_2: string| {
                                                                    Documents::closure63(
                                                                        v4.clone(),
                                                                        v3.clone(),
                                                                        false,
                                                                        v_2,
                                                                    )
                                                                }
                                                            }))(
                                                                b0
                                                            )(
                                                                b1
                                                            )
                                                        }
                                                    }),
                                                    LrcPtr::new(Documents::UH4::UH4_1(
                                                        string("epub"),
                                                        v48.clone(),
                                                        Func2::new({
                                                            let v3 = v3.clone();
                                                            let v4 = v4.clone();
                                                            move |b0: string, b1: string| {
                                                                (Func1::new({
                                                                    let v3 = v3.clone();
                                                                    let v4 = v4.clone();
                                                                    move |v_3: string| {
                                                                        Documents::closure63(
                                                                            v4.clone(),
                                                                            v3.clone(),
                                                                            false,
                                                                            v_3,
                                                                        )
                                                                    }
                                                                }))(
                                                                    b0
                                                                )(
                                                                    b1
                                                                )
                                                            }
                                                        }),
                                                        LrcPtr::new(Documents::UH4::UH4_1(
                                                            string("html"),
                                                            v63.clone(),
                                                            Func2::new({
                                                                let v3 = v3.clone();
                                                                let v4 = v4.clone();
                                                                move |b0: string, b1: string| {
                                                                    (Func1::new({
                                                                        let v3 = v3.clone();
                                                                        let v4 = v4.clone();
                                                                        move |v_4: string| {
                                                                            Documents::closure63(
                                                                                v4.clone(),
                                                                                v3.clone(),
                                                                                true,
                                                                                v_4,
                                                                            )
                                                                        }
                                                                    }))(
                                                                        b0
                                                                    )(
                                                                        b1
                                                                    )
                                                                }
                                                            }),
                                                            LrcPtr::new(Documents::UH4::UH4_1(
                                                                string("pdf"),
                                                                v63.clone(),
                                                                Func2::new({
                                                                    let v3 = v3.clone();
                                                                    let v4 = v4.clone();
                                                                    move |b0: string, b1: string| {
                                                                        (Func1::new({
                                                                            let v3 = v3.clone();
                                                                            let v4 = v4.clone();
                                                                            move |v_5: string| {
                                                                                Documents::closure63(
                                                                                    v4.clone(),
                                                                                    v3.clone(),
                                                                                    true,
                                                                                    v_5,
                                                                                )
                                                                            }
                                                                        }))(
                                                                            b0
                                                                        )(
                                                                            b1
                                                                        )
                                                                    }
                                                                }),
                                                                LrcPtr::new(Documents::UH4::UH4_1(
                                                                    string("epub"),
                                                                    v63.clone(),
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
                                                                                                                                                                                                                                                                                                                                                               |v_6:
                                                                                                                                                                                                                                                                                                                                                                    string|
                                                                                                                                                                                                                                                                                                                                                               Documents::closure63(v4.clone(),
                                                                                                                                                                                                                                                                                                                                                                                    v3.clone(),
                                                                                                                                                                                                                                                                                                                                                                                    true,
                                                                                                                                                                                                                                                                                                                                                                                    v_6)
                                                                                                                                                                                                                                                                                                                                                       }))(b0)(b1)
                                                                    }),
                                                                    LrcPtr::new(
                                                                        Documents::UH4::UH4_0,
                                                                    ),
                                                                )),
                                                            )),
                                                        )),
                                                    )),
                                                )),
                                            )),
                                            LrcPtr::new(Documents::UH3::UH3_0),
                                        )),
                                    ))
                                } else {
                                    LrcPtr::new(Documents::UH3::UH3_0)
                                }
                            }
                        }
                    }
                } else {
                    LrcPtr::new(Documents::UH3::UH3_0)
                };
                let v397: Array<LrcPtr<Documents::UH4>> = toArray_1(Documents::method90(
                    if (if let Documents::UH3::UH3_0 = v288.as_ref() {
                        true
                    } else {
                        false
                    }) != true
                    {
                        v288
                    } else {
                        let patternInput_3: (string, string) =
                            Documents::method76(string("epub"), v63.clone(), v4.clone());
                        let v294: string = patternInput_3.1.clone();
                        let v293: string = patternInput_3.0.clone();
                        let v307: LrcPtr<Documents::UH4> = if if Documents::method80(v294.clone())
                            == false
                        {
                            if Documents::method80(v293.clone()) {
                                Documents::method5(
                                    Documents::US0::US0_2,
                                    Func0::new(move || Documents::closure67((), ())),
                                    Func0::new({
                                        let v293 = v293.clone();
                                        let v294 = v294.clone();
                                        move || Documents::closure68(v293.clone(), v294.clone(), ())
                                    }),
                                );
                                Documents::method81(v294.clone(), v293.clone());
                                false
                            } else {
                                true
                            }
                        } else {
                            true
                        } {
                            LrcPtr::new(Documents::UH4::UH4_1(
                                string("epub"),
                                v63.clone(),
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
                                        }))(b0)(b1)
                                    }
                                }),
                                LrcPtr::new(Documents::UH4::UH4_0),
                            ))
                        } else {
                            LrcPtr::new(Documents::UH4::UH4_0)
                        };
                        let patternInput_4: (string, string) =
                            Documents::method76(string("pdf"), v63.clone(), v4.clone());
                        let v310: string = patternInput_4.1.clone();
                        let v309: string = patternInput_4.0.clone();
                        let v321: LrcPtr<Documents::UH4> = if if Documents::method80(v310.clone())
                            == false
                        {
                            if Documents::method80(v309.clone()) {
                                Documents::method5(
                                    Documents::US0::US0_2,
                                    Func0::new(move || Documents::closure67((), ())),
                                    Func0::new({
                                        let v309 = v309.clone();
                                        let v310 = v310.clone();
                                        move || Documents::closure68(v309.clone(), v310.clone(), ())
                                    }),
                                );
                                Documents::method81(v310.clone(), v309.clone());
                                false
                            } else {
                                true
                            }
                        } else {
                            true
                        } {
                            LrcPtr::new(Documents::UH4::UH4_1(
                                string("pdf"),
                                v63.clone(),
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
                                        }))(b0)(b1)
                                    }
                                }),
                                v307.clone(),
                            ))
                        } else {
                            v307
                        };
                        let patternInput_5: (string, string) =
                            Documents::method76(string("html"), v63.clone(), v4.clone());
                        let v324: string = patternInput_5.1.clone();
                        let v323: string = patternInput_5.0.clone();
                        let v335: LrcPtr<Documents::UH4> = if if Documents::method80(v324.clone())
                            == false
                        {
                            if Documents::method80(v323.clone()) {
                                Documents::method5(
                                    Documents::US0::US0_2,
                                    Func0::new(move || Documents::closure67((), ())),
                                    Func0::new({
                                        let v323 = v323.clone();
                                        let v324 = v324.clone();
                                        move || Documents::closure68(v323.clone(), v324.clone(), ())
                                    }),
                                );
                                Documents::method81(v324.clone(), v323.clone());
                                false
                            } else {
                                true
                            }
                        } else {
                            true
                        } {
                            LrcPtr::new(Documents::UH4::UH4_1(
                                string("html"),
                                v63,
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
                                        }))(b0)(b1)
                                    }
                                }),
                                v321.clone(),
                            ))
                        } else {
                            v321
                        };
                        let patternInput_6: (string, string) =
                            Documents::method76(string("epub"), v48.clone(), v4.clone());
                        let v337: string = patternInput_6.1.clone();
                        let v336: string = patternInput_6.0.clone();
                        let v348: LrcPtr<Documents::UH4> = if if Documents::method80(v337.clone())
                            == false
                        {
                            if Documents::method80(v336.clone()) {
                                Documents::method5(
                                    Documents::US0::US0_2,
                                    Func0::new(move || Documents::closure67((), ())),
                                    Func0::new({
                                        let v336 = v336.clone();
                                        let v337 = v337.clone();
                                        move || Documents::closure68(v336.clone(), v337.clone(), ())
                                    }),
                                );
                                Documents::method81(v337.clone(), v336.clone());
                                false
                            } else {
                                true
                            }
                        } else {
                            true
                        } {
                            LrcPtr::new(Documents::UH4::UH4_1(
                                string("epub"),
                                v48.clone(),
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
                                        }))(b0)(b1)
                                    }
                                }),
                                v335.clone(),
                            ))
                        } else {
                            v335
                        };
                        let patternInput_7: (string, string) =
                            Documents::method76(string("pdf"), v48.clone(), v4.clone());
                        let v350: string = patternInput_7.1.clone();
                        let v349: string = patternInput_7.0.clone();
                        let v361: LrcPtr<Documents::UH4> = if if Documents::method80(v350.clone())
                            == false
                        {
                            if Documents::method80(v349.clone()) {
                                Documents::method5(
                                    Documents::US0::US0_2,
                                    Func0::new(move || Documents::closure67((), ())),
                                    Func0::new({
                                        let v349 = v349.clone();
                                        let v350 = v350.clone();
                                        move || Documents::closure68(v349.clone(), v350.clone(), ())
                                    }),
                                );
                                Documents::method81(v350.clone(), v349.clone());
                                false
                            } else {
                                true
                            }
                        } else {
                            true
                        } {
                            LrcPtr::new(Documents::UH4::UH4_1(
                                string("pdf"),
                                v48.clone(),
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
                                        }))(b0)(b1)
                                    }
                                }),
                                v348.clone(),
                            ))
                        } else {
                            v348
                        };
                        let patternInput_8: (string, string) =
                            Documents::method76(string("html"), v48.clone(), v4.clone());
                        let v363: string = patternInput_8.1.clone();
                        let v362: string = patternInput_8.0.clone();
                        let v374: LrcPtr<Documents::UH4> = if if Documents::method80(v363.clone())
                            == false
                        {
                            if Documents::method80(v362.clone()) {
                                Documents::method5(
                                    Documents::US0::US0_2,
                                    Func0::new(move || Documents::closure67((), ())),
                                    Func0::new({
                                        let v362 = v362.clone();
                                        let v363 = v363.clone();
                                        move || Documents::closure68(v362.clone(), v363.clone(), ())
                                    }),
                                );
                                Documents::method81(v363.clone(), v362.clone());
                                false
                            } else {
                                true
                            }
                        } else {
                            true
                        } {
                            LrcPtr::new(Documents::UH4::UH4_1(
                                string("html"),
                                v48.clone(),
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
                                        }))(b0)(b1)
                                    }
                                }),
                                v361.clone(),
                            ))
                        } else {
                            v361
                        };
                        let patternInput_9: (string, string) =
                            Documents::method76(string("hangul.md"), v48.clone(), v4.clone());
                        let v376: string = patternInput_9.1.clone();
                        let v375: string = patternInput_9.0.clone();
                        LrcPtr::new(Documents::UH3::UH3_1(
                            if if Documents::method80(v376.clone()) == false {
                                if Documents::method80(v375.clone()) {
                                    Documents::method5(
                                        Documents::US0::US0_2,
                                        Func0::new(move || Documents::closure67((), ())),
                                        Func0::new({
                                            let v375 = v375.clone();
                                            let v376 = v376.clone();
                                            move || {
                                                Documents::closure68(v375.clone(), v376.clone(), ())
                                            }
                                        }),
                                    );
                                    Documents::method81(v376.clone(), v375.clone());
                                    false
                                } else {
                                    true
                                }
                            } else {
                                true
                            } {
                                LrcPtr::new(Documents::UH4::UH4_1(
                                    string("hangul.md"),
                                    v48.clone(),
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
                                            }))(b0)(b1)
                                        }
                                    }),
                                    LrcPtr::new(Documents::UH4::UH4_0),
                                ))
                            } else {
                                LrcPtr::new(Documents::UH4::UH4_0)
                            },
                            LrcPtr::new(Documents::UH3::UH3_1(
                                v374,
                                LrcPtr::new(Documents::UH3::UH3_0),
                            )),
                        ))
                    },
                    empty::<LrcPtr<Documents::UH4>>(),
                ));
                let v399: Vec<LrcPtr<Documents::UH4>> = v397.to_vec();
                let v402: Vec<Option<Result<string, LrcPtr<(string, string)>>>> =
                    new_empty::<Option<Result<string, LrcPtr<(string, string)>>>>().to_vec();
                let v404: Array<LrcPtr<Documents::UH4>> =
                    fable_library_rust::NativeArray_::array_from(v399);
                let v405: i32 = count_2(v404.clone());
                let v406: LrcPtr<Documents::Mut8> = LrcPtr::new(Documents::Mut8 {
                    l0: MutCell::new(0_i32),
                    l1: MutCell::new(v402),
                });
                while Documents::method91(v405, v406.clone()) {
                    let v408: i32 = v406.l0.get().clone();
                    let v409: Vec<Option<Result<string, LrcPtr<(string, string)>>>> =
                        v406.l1.get().clone();
                    let v414 = toArray_1(Documents::method92(
                        v404[v408].clone(),
                        empty::<(
                            string,
                            string,
                            Func1<string, Func1<string, Documents::US28>>,
                        )>(),
                    ));
                    let v416 = v414.to_vec();
                    let v418 = rayon::iter::IntoParallelIterator::into_par_iter(v416);
                    let v421 = rayon::iter::ParallelIterator::map(v418, |x| {
                        Func1::new(
                            move |arg10_0040_16: (
                                string,
                                string,
                                Func1<string, Func1<string, Documents::US28>>,
                            )| Documents::closure69((), arg10_0040_16),
                        )(x)
                    });
                    let v424: Vec<Option<Result<string, LrcPtr<(string, string)>>>> =
                        Documents::method93(rayon::iter::ParallelIterator::collect(v421));
                    let v425: Vec<Option<Result<string, LrcPtr<(string, string)>>>> =
                        Documents::method94(v409);
                    let v427: bool = true;
                    let mut v425 = v425;
                    let v429: bool = true;
                    v425.extend(v424);
                    let v431: Vec<Option<Result<string, LrcPtr<(string, string)>>>> = v425;
                    let v432: i32 = v408 + 1_i32;
                    v406.l0.set(v432);
                    v406.l1.set(v431);
                    ()
                }
                Ok::<
                    LrcPtr<(
                        string,
                        Vec<Option<Result<string, LrcPtr<(string, string)>>>>,
                    )>,
                    std::string::String,
                >(LrcPtr::new((v34.clone(), v406.l1.get().clone())))
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
        pub fn method95(
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
                    string("C:\\home\\git\\polyglot\\target\\Builder\\documents"),
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
                    let v22 = Documents::method41();
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
                            > = Documents::method95(Ok::<
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
mod module_ad43931;
pub use module_ad43931::*;
#[path = "../../../polyglot/lib/spiral/async_.rs"]
mod module_67c461a2;
pub use module_67c461a2::*;
#[path = "../../../polyglot/lib/spiral/common.rs"]
mod module_181b15d6;
pub use module_181b15d6::*;
#[path = "../../../polyglot/lib/spiral/crypto.rs"]
mod module_90d9c778;
pub use module_90d9c778::*;
#[path = "../../../polyglot/lib/spiral/date_time.rs"]
mod module_e43a8385;
pub use module_e43a8385::*;
#[path = "../../../polyglot/lib/spiral/file_system.rs"]
mod module_a7db9b47;
pub use module_a7db9b47::*;
#[path = "../../../polyglot/lib/spiral/lib.rs"]
mod module_98e448fc;
pub use module_98e448fc::*;
#[path = "../../../polyglot/lib/spiral/networking.rs"]
mod module_268024e5;
pub use module_268024e5::*;
#[path = "../../../polyglot/lib/spiral/platform.rs"]
mod module_7d8ad484;
pub use module_7d8ad484::*;
#[path = "../../../polyglot/lib/spiral/runtime.rs"]
mod module_485aae07;
pub use module_485aae07::*;
#[path = "../../../polyglot/lib/spiral/sm.rs"]
mod module_582b4305;
pub use module_582b4305::*;
#[path = "../../../polyglot/lib/spiral/threading.rs"]
mod module_d5afb6f5;
pub use module_d5afb6f5::*;
#[path = "../../../polyglot/lib/spiral/trace.rs"]
mod module_9e77af3a;
pub use module_9e77af3a::*;
pub mod Polyglot {
    pub use crate::module_ad43931::Polyglot::*;
}
pub fn main() {
    let args = std::env::args().skip(1).map(fromString).collect();
    Documents::main(array_from(args));
}
