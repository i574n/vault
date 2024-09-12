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
        use fable_library_rust::List_::toArray;
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
        use fable_library_rust::Seq_::toArray as toArray_1;
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
        pub mod TraceState {
            use super::*;
            pub fn trace_state() -> LrcPtr<
                MutCell<
                    Option<(
                        LrcPtr<Documents::Mut0>,
                        LrcPtr<Documents::Mut1>,
                        LrcPtr<Documents::Mut2>,
                        LrcPtr<Documents::Mut3>,
                        LrcPtr<Documents::Mut4>,
                        Option<i64>,
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
                                LrcPtr<Documents::Mut3>,
                                LrcPtr<Documents::Mut4>,
                                Option<i64>,
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
                                LrcPtr<Documents::Mut3>,
                                LrcPtr<Documents::Mut4>,
                                Option<i64>,
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
        #[derive(Clone, Debug)]
        pub struct Mut1 {
            pub l0: MutCell<Func1<string, ()>>,
        }
        impl core::fmt::Display for Documents::Mut1 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug, Default, PartialEq, PartialOrd, Hash, Eq)]
        pub struct Mut2 {
            pub l0: MutCell<bool>,
        }
        impl core::fmt::Display for Documents::Mut2 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug, Default, PartialEq, PartialOrd, Hash, Eq)]
        pub struct Mut3 {
            pub l0: MutCell<string>,
        }
        impl core::fmt::Display for Documents::Mut3 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug, PartialEq, PartialOrd, Hash, Eq)]
        pub struct Mut4 {
            pub l0: MutCell<Documents::US0>,
        }
        impl core::fmt::Display for Documents::Mut4 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug, PartialEq, PartialOrd, Hash, Eq)]
        pub enum US1 {
            US1_0(string),
            US1_1,
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
        impl core::fmt::Display for Documents::US2 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Copy, Debug, PartialEq, PartialOrd, Hash, Eq)]
        pub enum US3 {
            US3_0(i64),
            US3_1,
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
        impl core::fmt::Display for Documents::US6 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug, PartialEq, PartialOrd, Hash, Eq)]
        pub enum US7 {
            US7_0(string),
            US7_1(string),
        }
        impl core::fmt::Display for Documents::US7 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug, Default, PartialEq, PartialOrd, Hash, Eq)]
        pub struct Mut5 {
            pub l0: MutCell<i32>,
            pub l1: MutCell<i32>,
            pub l2: MutCell<Array<string>>,
        }
        impl core::fmt::Display for Documents::Mut5 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug, Default, PartialEq, PartialOrd, Hash, Eq)]
        pub struct Mut6 {
            pub l0: MutCell<i32>,
        }
        impl core::fmt::Display for Documents::Mut6 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum US8 {
            US8_0(std::fs::FileType),
            US8_1(std::string::String),
        }
        impl core::fmt::Display for Documents::US8 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Copy, Debug, PartialEq, PartialOrd, Hash, Eq)]
        pub enum US9 {
            US9_0,
            US9_1,
            US9_2,
        }
        impl core::fmt::Display for Documents::US9 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum US10 {
            US10_0(async_walkdir::DirEntry),
            US10_1(std::string::String),
        }
        impl core::fmt::Display for Documents::US10 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug, PartialEq, PartialOrd, Hash, Eq)]
        pub enum US11 {
            US11_0(string, Documents::US1),
            US11_1(string),
        }
        impl core::fmt::Display for Documents::US11 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum US12 {
            US12_0(char, string, LrcPtr<StringBuilder>, i32, i32),
            US12_1(string),
        }
        impl core::fmt::Display for Documents::US12 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug, PartialEq, PartialOrd, Hash, Eq)]
        pub enum UH0 {
            UH0_0,
            UH0_1(char, LrcPtr<Documents::UH0>),
        }
        impl core::fmt::Display for Documents::UH0 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum UH1 {
            UH1_0,
            UH1_1(
                Func1<(string, LrcPtr<StringBuilder>, i32, i32), Documents::US12>,
                LrcPtr<Documents::UH1>,
            ),
        }
        impl core::fmt::Display for Documents::UH1 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum US13 {
            US13_0(string, string, LrcPtr<StringBuilder>, i32, i32),
            US13_1(string),
        }
        impl core::fmt::Display for Documents::US13 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Copy, Debug, PartialEq, PartialOrd, Hash, Eq)]
        pub enum US14 {
            US14_0(char),
            US14_1,
        }
        impl core::fmt::Display for Documents::US14 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum US15 {
            US15_0(string, LrcPtr<StringBuilder>, i32, i32),
            US15_1(string),
        }
        impl core::fmt::Display for Documents::US15 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum US16 {
            US16_0(
                string,
                Documents::US1,
                string,
                LrcPtr<StringBuilder>,
                i32,
                i32,
            ),
            US16_1(string),
        }
        impl core::fmt::Display for Documents::US16 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum US17 {
            US17_0(Documents::US14, string, LrcPtr<StringBuilder>, i32, i32),
            US17_1(string),
        }
        impl core::fmt::Display for Documents::US17 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum US18 {
            US18_0(Documents::US1, string, LrcPtr<StringBuilder>, i32, i32),
            US18_1(string),
        }
        impl core::fmt::Display for Documents::US18 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug, PartialEq, PartialOrd, Hash, Eq)]
        pub enum US19 {
            US19_0(Array<string>),
            US19_1(string),
        }
        impl core::fmt::Display for Documents::US19 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug, PartialEq, PartialOrd, Hash, Eq)]
        pub enum UH2 {
            UH2_0,
            UH2_1(string, LrcPtr<Documents::UH2>),
        }
        impl core::fmt::Display for Documents::UH2 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum US20 {
            US20_0(
                LrcPtr<Documents::UH2>,
                string,
                LrcPtr<StringBuilder>,
                i32,
                i32,
            ),
            US20_1(string),
        }
        impl core::fmt::Display for Documents::US20 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum UH3 {
            UH3_0,
            UH3_1(
                Func1<(string, LrcPtr<StringBuilder>, i32, i32), Documents::US13>,
                LrcPtr<Documents::UH3>,
            ),
        }
        impl core::fmt::Display for Documents::UH3 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum US21 {
            US21_0(std::sync::Arc<std::sync::Mutex<Option<std::process::Child>>>),
            US21_1(std::string::String),
        }
        impl core::fmt::Display for Documents::US21 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum US22 {
            US22_0(
                std::sync::Arc<
                    std::sync::Mutex<
                        std::sync::Arc<std::sync::mpsc::Receiver<std::string::String>>,
                    >,
                >,
            ),
            US22_1,
        }
        impl core::fmt::Display for Documents::US22 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum US23 {
            US23_0(std::string::String),
            US23_1(std::string::String),
        }
        impl core::fmt::Display for Documents::US23 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum US24 {
            US24_0(Func1<std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>, ()>),
            US24_1,
        }
        impl core::fmt::Display for Documents::US24 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum US25 {
            US25_0(std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>),
            US25_1,
        }
        impl core::fmt::Display for Documents::US25 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum US26 {
            US26_0(std::process::Output),
            US26_1(std::string::String),
        }
        impl core::fmt::Display for Documents::US26 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Copy, Debug, PartialEq, PartialOrd, Hash, Eq)]
        pub enum US27 {
            US27_0(i32),
            US27_1,
        }
        impl core::fmt::Display for Documents::US27 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum US28 {
            US28_0(Func1<(i32, string, bool), Arc<Async<()>>>),
            US28_1,
        }
        impl core::fmt::Display for Documents::US28 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Copy, Debug, PartialEq, PartialOrd, Hash, Eq)]
        pub enum US29 {
            US29_0(CancellationToken),
            US29_1,
        }
        impl core::fmt::Display for Documents::US29 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug, PartialEq, PartialOrd, Hash, Eq)]
        pub enum US30 {
            US30_0(Result<string, LrcPtr<(string, string)>>),
            US30_1,
        }
        impl core::fmt::Display for Documents::US30 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum UH5 {
            UH5_0,
            UH5_1(
                string,
                string,
                Func2<string, string, Documents::US30>,
                LrcPtr<Documents::UH5>,
            ),
        }
        impl core::fmt::Display for Documents::UH5 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum UH4 {
            UH4_0,
            UH4_1(LrcPtr<Documents::UH5>, LrcPtr<Documents::UH4>),
        }
        impl core::fmt::Display for Documents::UH4 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum US31 {
            US31_0(string),
            US31_1(std::string::String),
        }
        impl core::fmt::Display for Documents::US31 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug, PartialEq, PartialOrd, Hash, Eq)]
        pub enum US32 {
            US32_0(i32, string),
            US32_1(i32, string),
        }
        impl core::fmt::Display for Documents::US32 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug, Default, PartialEq, PartialOrd, Hash, Eq)]
        pub struct Mut7 {
            pub l0: MutCell<i32>,
            pub l1: MutCell<i32>,
        }
        impl core::fmt::Display for Documents::Mut7 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug, Default, PartialEq, PartialOrd, Hash, Eq)]
        pub struct Mut8 {
            pub l0: MutCell<i32>,
            pub l1: MutCell<string>,
            pub l2: MutCell<i32>,
            pub l3: MutCell<i32>,
        }
        impl core::fmt::Display for Documents::Mut8 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug, Default)]
        pub struct Mut9 {
            pub l0: MutCell<i32>,
            pub l1: MutCell<Vec<Option<Result<string, LrcPtr<(string, string)>>>>>,
        }
        impl core::fmt::Display for Documents::Mut9 {
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
        pub fn method2() -> string {
            string("TRACE_LEVEL")
        }
        pub fn method4() -> string {
            string("")
        }
        pub fn closure3(
            v0_1: LrcPtr<MutCell<Option<Documents::US1>>>,
            v1_1: Option<Documents::US1>,
        ) -> LrcPtr<MutCell<Option<Documents::US1>>> {
            v0_1.set(v1_1);
            v0_1
        }
        pub fn closure4(
            v0_1: Option<string>,
            v1_1: Func1<Option<Documents::US1>, LrcPtr<MutCell<Option<Documents::US1>>>>,
            unitVar: (),
        ) {
            {
                let value: LrcPtr<MutCell<Option<Documents::US1>>> = v1_1(match &v0_1 {
                    None => None::<Documents::US1>,
                    Some(v0_1_0_0) => {
                        let x: string = v0_1_0_0.clone();
                        Some((Func0::new({
                            let x = x.clone();
                            move || Documents::US1::US1_0(x.clone())
                        }))())
                    }
                });
                ()
            }
            ()
        }
        pub fn method3(v0_1: string) -> string {
            let v3: Result<std::string::String, std::env::VarError> = std::env::var(&*v0_1);
            let v5: bool = true;
            let _result_map_ = v3.map(|x| {
                //;
                let v7: std::string::String = x;
                let v9: string = fable_library_rust::String_::fromString(v7);
                let v11: bool = true;
                v9
            });
            let v13: Result<string, std::env::VarError> = _result_map_;
            let v14: string = Documents::method4();
            v13.unwrap_or(v14)
        }
        pub fn method5() -> string {
            string("AUTOMATION")
        }
        pub fn closure5(unitVar: (), v0_1: string) {
            ();
        }
        pub fn method1(
            v0_1: Documents::US0,
        ) -> (
            LrcPtr<Documents::Mut0>,
            LrcPtr<Documents::Mut1>,
            LrcPtr<Documents::Mut2>,
            LrcPtr<Documents::Mut3>,
            LrcPtr<Documents::Mut4>,
            Option<i64>,
        ) {
            let v3: string = Documents::method3(Documents::method2());
            let v8: Documents::US2 = if string("Verbose") == v3.clone() {
                Documents::US2::US2_0(Documents::US0::US0_0)
            } else {
                Documents::US2::US2_1
            };
            let _v1: (Documents::US2, Documents::US3) = (
                match &v8 {
                    Documents::US2::US2_0(v8_0_0) => Documents::US2::US2_0(match &v8 {
                        Documents::US2::US2_0(x) => x.clone(),
                        _ => unreachable!(),
                    }),
                    _ => {
                        let v15: Documents::US2 = if string("Debug") == v3.clone() {
                            Documents::US2::US2_0(Documents::US0::US0_1)
                        } else {
                            Documents::US2::US2_1
                        };
                        match &v15 {
                            Documents::US2::US2_0(v15_0_0) => Documents::US2::US2_0(match &v15 {
                                Documents::US2::US2_0(x) => x.clone(),
                                _ => unreachable!(),
                            }),
                            _ => {
                                let v22: Documents::US2 = if string("Info") == v3.clone() {
                                    Documents::US2::US2_0(Documents::US0::US0_2)
                                } else {
                                    Documents::US2::US2_1
                                };
                                match &v22 {
                                    Documents::US2::US2_0(v22_0_0) => {
                                        Documents::US2::US2_0(match &v22 {
                                            Documents::US2::US2_0(x) => x.clone(),
                                            _ => unreachable!(),
                                        })
                                    }
                                    _ => {
                                        let v29: Documents::US2 = if string("Warning") == v3.clone()
                                        {
                                            Documents::US2::US2_0(Documents::US0::US0_3)
                                        } else {
                                            Documents::US2::US2_1
                                        };
                                        match &v29 {
                                            Documents::US2::US2_0(v29_0_0) => {
                                                Documents::US2::US2_0(match &v29 {
                                                    Documents::US2::US2_0(x) => x.clone(),
                                                    _ => unreachable!(),
                                                })
                                            }
                                            _ => {
                                                let v36: Documents::US2 =
                                                    if string("Critical") == v3.clone() {
                                                        Documents::US2::US2_0(Documents::US0::US0_4)
                                                    } else {
                                                        Documents::US2::US2_1
                                                    };
                                                match &v36 {
                                                    Documents::US2::US2_0(v36_0_0) => {
                                                        Documents::US2::US2_0(match &v36 {
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
                },
                if Documents::method3(Documents::method5()) == string("True") {
                    Documents::US3::US3_0({
                        let _arg: DateTime = DateTime::now();
                        _arg.ticks()
                    })
                } else {
                    Documents::US3::US3_1
                },
            );
            let v295: Documents::US3 = _v1.1.clone();
            let v294: Documents::US2 = _v1.0.clone();
            (
                LrcPtr::new(Documents::Mut0 {
                    l0: MutCell::new(0_i64),
                }),
                LrcPtr::new(Documents::Mut1 {
                    l0: MutCell::new(Func1::new(move |v: string| Documents::closure5((), v))),
                }),
                LrcPtr::new(Documents::Mut2 {
                    l0: MutCell::new(true),
                }),
                LrcPtr::new(Documents::Mut3 {
                    l0: MutCell::new(string("")),
                }),
                LrcPtr::new(Documents::Mut4 {
                    l0: MutCell::new(match &v294 {
                        Documents::US2::US2_0(v294_0_0) => match &v294 {
                            Documents::US2::US2_0(x) => x.clone(),
                            _ => unreachable!(),
                        },
                        _ => v0_1,
                    }),
                }),
                match &v295 {
                    Documents::US3::US3_0(v295_0_0) => Some(match &v295 {
                        Documents::US3::US3_0(x) => x.clone(),
                        _ => unreachable!(),
                    }),
                    _ => None::<i64>,
                },
            )
        }
        pub fn closure2(unitVar: (), unitVar_1: ()) {
            if Documents::TraceState::trace_state().get().clone().is_none() {
                let patternInput: (
                    LrcPtr<Documents::Mut0>,
                    LrcPtr<Documents::Mut1>,
                    LrcPtr<Documents::Mut2>,
                    LrcPtr<Documents::Mut3>,
                    LrcPtr<Documents::Mut4>,
                    Option<i64>,
                ) = Documents::method1(Documents::US0::US0_2);
                Documents::TraceState::trace_state().set(Some((
                    patternInput.0.clone(),
                    patternInput.1.clone(),
                    patternInput.2.clone(),
                    patternInput.3.clone(),
                    patternInput.4.clone(),
                    patternInput.5.clone(),
                )));
                ()
            };
        }
        pub fn closure7(unitVar: (), unitVar_1: ()) {
            if Documents::TraceState::trace_state().get().clone().is_none() {
                let patternInput: (
                    LrcPtr<Documents::Mut0>,
                    LrcPtr<Documents::Mut1>,
                    LrcPtr<Documents::Mut2>,
                    LrcPtr<Documents::Mut3>,
                    LrcPtr<Documents::Mut4>,
                    Option<i64>,
                ) = Documents::method1(Documents::US0::US0_0);
                Documents::TraceState::trace_state().set(Some((
                    patternInput.0.clone(),
                    patternInput.1.clone(),
                    patternInput.2.clone(),
                    patternInput.3.clone(),
                    patternInput.4.clone(),
                    patternInput.5.clone(),
                )));
                ()
            };
        }
        pub fn closure8(v0_1: LrcPtr<Documents::Mut0>, unitVar: ()) {
            let v2: i64 = v0_1.l0.get().clone() + 1_i64;
            v0_1.l0.set(v2);
            ()
        }
        pub fn closure9(
            v0_1: LrcPtr<MutCell<Option<Documents::US3>>>,
            v1_1: Option<Documents::US3>,
        ) -> LrcPtr<MutCell<Option<Documents::US3>>> {
            v0_1.set(v1_1);
            v0_1
        }
        pub fn closure10(
            v0_1: Option<i64>,
            v1_1: Func1<Option<Documents::US3>, LrcPtr<MutCell<Option<Documents::US3>>>>,
            unitVar: (),
        ) {
            {
                let value: LrcPtr<MutCell<Option<Documents::US3>>> = v1_1(match &v0_1 {
                    None => None::<Documents::US3>,
                    Some(v0_1_0_0) => {
                        let x: i64 = v0_1_0_0.clone();
                        Some((Func0::new({
                            let x = x.clone();
                            move || Documents::US3::US3_0(x)
                        }))())
                    }
                });
                ()
            }
            ()
        }
        pub fn method6() -> string {
            string("hh:mm:ss")
        }
        pub fn method7() -> string {
            string("HH:mm:ss")
        }
        pub fn method8() -> string {
            string("\u{001b}[0m")
        }
        pub fn method9() -> string {
            string("")
        }
        pub fn closure11(v0_1: LrcPtr<Documents::Mut3>, v1_1: string, unitVar: ()) {
            let v3: string = append(v0_1.l0.get().clone(), v1_1);
            v0_1.l0.set(v3);
            ()
        }
        pub fn closure13(v0_1: string, unitVar: ()) {
            printfn!("{0}", v0_1);
        }
        pub fn closure12(unitVar: (), v0_1: string) {
            let v3: () = {
                Documents::closure13(v0_1, ());
                ()
            };
            ()
        }
        pub fn closure6(v0_1: Array<string>, unitVar: ()) {
            fn v2() {
                Documents::closure7((), ());
            }
            let v3: () = {
                v2();
                ()
            };
            let patternInput: (
                LrcPtr<Documents::Mut0>,
                LrcPtr<Documents::Mut1>,
                LrcPtr<Documents::Mut2>,
                LrcPtr<Documents::Mut3>,
                LrcPtr<Documents::Mut4>,
                Option<i64>,
            ) = getValue(Documents::TraceState::trace_state().get().clone());
            let v36: () = {
                v2();
                ()
            };
            let patternInput_1: (
                LrcPtr<Documents::Mut0>,
                LrcPtr<Documents::Mut1>,
                LrcPtr<Documents::Mut2>,
                LrcPtr<Documents::Mut3>,
                LrcPtr<Documents::Mut4>,
                Option<i64>,
            ) = getValue(Documents::TraceState::trace_state().get().clone());
            let v68: Documents::US0 = (patternInput_1.4.clone()).l0.get().clone();
            if if (patternInput_1.2.clone()).l0.get().clone() == false {
                false
            } else {
                2_i32
                    >= find(
                        v68,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Documents::US0::US0_0, 0_i32)),
                            LrcPtr::new((Documents::US0::US0_1, 1_i32)),
                            LrcPtr::new((Documents::US0::US0_2, 2_i32)),
                            LrcPtr::new((Documents::US0::US0_3, 3_i32)),
                            LrcPtr::new((Documents::US0::US0_4, 4_i32)),
                        ])))),
                    )
            } {
                let v76: () = {
                    Documents::closure8(patternInput.0.clone(), ());
                    ()
                };
                let v80: () = {
                    v2();
                    ()
                };
                let patternInput_2: (
                    LrcPtr<Documents::Mut0>,
                    LrcPtr<Documents::Mut1>,
                    LrcPtr<Documents::Mut2>,
                    LrcPtr<Documents::Mut3>,
                    LrcPtr<Documents::Mut4>,
                    Option<i64>,
                ) = getValue(Documents::TraceState::trace_state().get().clone());
                let _v113: LrcPtr<MutCell<Option<Documents::US3>>> =
                    refCell(None::<Documents::US3>);
                let v118: () = {
                    Documents::closure10(
                        patternInput_2.5.clone(),
                        Func1::new({
                            let _v113 = _v113.clone();
                            move |v: Option<Documents::US3>| Documents::closure9(_v113.clone(), v)
                        }),
                        (),
                    );
                    ()
                };
                let v133: Documents::US3 = defaultValue(Documents::US3::US3_1, _v113.get().clone());
                let v173: DateTime = match &v133 {
                    Documents::US3::US3_0(v133_0_0) => {
                        let v147: TimeSpan = TimeSpan::new_ticks(
                            {
                                let _arg: DateTime = DateTime::now();
                                _arg.ticks()
                            } - match &v133 {
                                Documents::US3::US3_0(x) => x.clone(),
                                _ => unreachable!(),
                            },
                        );
                        DateTime::new_ymdhms_milli(
                            1_i32,
                            1_i32,
                            1_i32,
                            v147.hours(),
                            v147.minutes(),
                            v147.seconds(),
                            v147.milliseconds(),
                        )
                    }
                    _ => DateTime::now(),
                };
                let v178: string = {
                    let provider: string = Documents::method6();
                    v173.toString(provider)
                };
                let v570: string = padLeft(toLower(string("Info")), 7_i32, ' ');
                let v586: &str = inline_colorization::color_bright_green;
                let v588: &str = &*v570;
                let v590: &str = inline_colorization::color_reset;
                let v592: string = string("format!(\"{v586}{v588}{v590}\")");
                let v593: std::string::String = format!("{v586}{v588}{v590}");
                let v595: string = fable_library_rust::String_::fromString(v593);
                let v636: i64 = (patternInput_2.0.clone()).l0.get().clone();
                let v638: LrcPtr<Documents::Mut3> = LrcPtr::new(Documents::Mut3 {
                    l0: MutCell::new(Documents::method9()),
                });
                let v645: () = {
                    Documents::closure11(v638.clone(), sprintf!("{}", string("{ ")), ());
                    ()
                };
                let v654: () = {
                    Documents::closure11(v638.clone(), sprintf!("{}", string("args")), ());
                    ()
                };
                let v663: () = {
                    Documents::closure11(v638.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v674: () = {
                    Documents::closure11(v638.clone(), sprintf!("{}", sprintf!("{:?}", v0_1)), ());
                    ()
                };
                let v683: () = {
                    Documents::closure11(v638.clone(), sprintf!("{}", string(" }")), ());
                    ()
                };
                let v745: string = trimEndChars(
                    trimStartChars(
                        sprintf!(
                            "{} {} #{} {} / {}",
                            v178,
                            v595,
                            v636,
                            string("documents.main"),
                            v638.l0.get().clone()
                        ),
                        toArray(empty::<char>()),
                    ),
                    toArray(ofArray(new_array(&[' ', '/']))),
                );
                println!("{}", v745.clone());
                ();
                ((patternInput.1.clone()).l0.get().clone())(v745)
            }
        }
        pub fn method10() -> string {
            string("source-dir")
        }
        pub fn closure14(
            v0_1: LrcPtr<MutCell<Option<Documents::US4>>>,
            v1_1: Option<Documents::US4>,
        ) -> LrcPtr<MutCell<Option<Documents::US4>>> {
            v0_1.set(v1_1);
            v0_1
        }
        pub fn closure15(
            v0_1: Option<std::string::String>,
            v1_1: Func1<Option<Documents::US4>, LrcPtr<MutCell<Option<Documents::US4>>>>,
            unitVar: (),
        ) {
            {
                let value: LrcPtr<MutCell<Option<Documents::US4>>> = v1_1(match &v0_1 {
                    None => None::<Documents::US4>,
                    Some(v0_1_0_0) => {
                        let x: std::string::String = v0_1_0_0.clone();
                        Some((Func0::new({
                            let x = x.clone();
                            move || Documents::US4::US4_0(x.clone())
                        }))())
                    }
                });
                ()
            }
            ()
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
            let v4: &str = &*v0_1;
            let v6: std::string::String = String::from(v4);
            let v8: std::path::PathBuf = std::path::PathBuf::from(v6);
            let v10: &str = &*v1_1;
            let v12: std::string::String = String::from(v10);
            let v14: std::path::PathBuf = v8.join(v12);
            let v16: std::path::Display = v14.display();
            let v19: std::string::String = format!("{}", v16);
            fable_library_rust::String_::fromString(v19)
        }
        pub fn method19(v0_1: string) -> bool {
            let v3: &str = &*v0_1;
            let v5: std::string::String = String::from(v3);
            let v7: std::path::PathBuf = std::path::PathBuf::from(v5);
            if v7.clone().exists() {
                true
            } else {
                if v7.clone().is_dir() {
                    true
                } else {
                    v7.is_symlink()
                }
            }
        }
        pub fn method21(v0_1: string) -> Option<string> {
            let v3: &str = &*v0_1;
            let v5: std::string::String = String::from(v3);
            let v7: std::path::PathBuf = std::path::PathBuf::from(v5);
            let v9: Option<std::path::PathBuf> = v7.parent().map(std::path::PathBuf::from);
            let v11: std::path::PathBuf = v9?;
            let v13: std::path::Display = v11.display();
            let v16: std::string::String = format!("{}", v13);
            let v85: Documents::US1 =
                Documents::US1::US1_0(fable_library_rust::String_::fromString(v16));
            match &v85 {
                Documents::US1::US1_0(v85_0_0) => Some(match &v85 {
                    Documents::US1::US1_0(x) => x.clone(),
                    _ => unreachable!(),
                }),
                _ => None::<string>,
            }
        }
        pub fn closure16(unitVar: (), v0_1: string) -> Option<string> {
            Documents::method21(v0_1)
        }
        pub fn method20() -> Func1<string, Option<string>> {
            Func1::new(move |v: string| Documents::closure16((), v))
        }
        pub fn method22(v0_1: string, v1_1: string, v2: string) -> Documents::US7 {
            let v0_1: MutCell<string> = MutCell::new(v0_1.clone());
            let v1_1: MutCell<string> = MutCell::new(v1_1.clone());
            let v2: MutCell<string> = MutCell::new(v2.clone());
            '_method22: loop {
                break '_method22 (if Documents::method19(Documents::method15(
                    v2.get().clone(),
                    v0_1.get().clone(),
                )) {
                    Documents::US7::US7_0(v2.get().clone())
                } else {
                    let v7: Option<string> = (Documents::method20())(v2.get().clone());
                    let _v8: LrcPtr<MutCell<Option<Documents::US1>>> =
                        refCell(None::<Documents::US1>);
                    let v13: () = {
                        Documents::closure4(
                            v7,
                            Func1::new({
                                let _v8 = _v8.clone();
                                move |v: Option<Documents::US1>| Documents::closure3(_v8.clone(), v)
                            }),
                            (),
                        );
                        ()
                    };
                    let v28: Documents::US1 =
                        defaultValue(Documents::US1::US1_1, _v8.get().clone());
                    match &v28 {
                        Documents::US1::US1_0(v28_0_0) => {
                            let v0_1_temp: string = v0_1.get().clone();
                            let v1_1_temp: string = v1_1.get().clone();
                            let v2_temp: string = match &v28 {
                                Documents::US1::US1_0(x) => x.clone(),
                                _ => unreachable!(),
                            };
                            v0_1.set(v0_1_temp);
                            v1_1.set(v1_1_temp);
                            v2.set(v2_temp);
                            continue '_method22;
                        }
                        _ => Documents::US7::US7_1(sprintf!(
                            "No parent for {} \'{}\' at \'{}\' (until \'{}\')",
                            string("dir"),
                            v0_1.get().clone(),
                            v1_1.get().clone(),
                            v2.get().clone()
                        )),
                    }
                });
            }
        }
        pub fn method18(v0_1: string, v1_1: string) -> Documents::US7 {
            if Documents::method19(Documents::method15(v1_1.clone(), v0_1.clone())) {
                Documents::US7::US7_0(v1_1.clone())
            } else {
                let v6: Option<string> = (Documents::method20())(v1_1.clone());
                let _v7: LrcPtr<MutCell<Option<Documents::US1>>> = refCell(None::<Documents::US1>);
                let v12: () = {
                    Documents::closure4(
                        v6,
                        Func1::new({
                            let _v7 = _v7.clone();
                            move |v: Option<Documents::US1>| Documents::closure3(_v7.clone(), v)
                        }),
                        (),
                    );
                    ()
                };
                let v27: Documents::US1 = defaultValue(Documents::US1::US1_1, _v7.get().clone());
                match &v27 {
                    Documents::US1::US1_0(v27_0_0) => Documents::method22(
                        v0_1.clone(),
                        v1_1.clone(),
                        match &v27 {
                            Documents::US1::US1_0(x) => x.clone(),
                            _ => unreachable!(),
                        },
                    ),
                    _ => Documents::US7::US7_1(sprintf!(
                        "No parent for {} \'{}\' at \'{}\' (until \'{}\')",
                        string("dir"),
                        v0_1.clone(),
                        v1_1.clone(),
                        v1_1.clone()
                    )),
                }
            }
        }
        pub fn closure17(v0_1: string, unitVar: ()) {
            fn v2() {
                Documents::closure7((), ());
            }
            let v3: () = {
                v2();
                ()
            };
            let patternInput: (
                LrcPtr<Documents::Mut0>,
                LrcPtr<Documents::Mut1>,
                LrcPtr<Documents::Mut2>,
                LrcPtr<Documents::Mut3>,
                LrcPtr<Documents::Mut4>,
                Option<i64>,
            ) = getValue(Documents::TraceState::trace_state().get().clone());
            let v36: () = {
                v2();
                ()
            };
            let patternInput_1: (
                LrcPtr<Documents::Mut0>,
                LrcPtr<Documents::Mut1>,
                LrcPtr<Documents::Mut2>,
                LrcPtr<Documents::Mut3>,
                LrcPtr<Documents::Mut4>,
                Option<i64>,
            ) = getValue(Documents::TraceState::trace_state().get().clone());
            let v68: Documents::US0 = (patternInput_1.4.clone()).l0.get().clone();
            if if (patternInput_1.2.clone()).l0.get().clone() == false {
                false
            } else {
                3_i32
                    >= find(
                        v68,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Documents::US0::US0_0, 0_i32)),
                            LrcPtr::new((Documents::US0::US0_1, 1_i32)),
                            LrcPtr::new((Documents::US0::US0_2, 2_i32)),
                            LrcPtr::new((Documents::US0::US0_3, 3_i32)),
                            LrcPtr::new((Documents::US0::US0_4, 4_i32)),
                        ])))),
                    )
            } {
                let v76: () = {
                    Documents::closure8(patternInput.0.clone(), ());
                    ()
                };
                let v80: () = {
                    v2();
                    ()
                };
                let patternInput_2: (
                    LrcPtr<Documents::Mut0>,
                    LrcPtr<Documents::Mut1>,
                    LrcPtr<Documents::Mut2>,
                    LrcPtr<Documents::Mut3>,
                    LrcPtr<Documents::Mut4>,
                    Option<i64>,
                ) = getValue(Documents::TraceState::trace_state().get().clone());
                let _v113: LrcPtr<MutCell<Option<Documents::US3>>> =
                    refCell(None::<Documents::US3>);
                let v118: () = {
                    Documents::closure10(
                        patternInput_2.5.clone(),
                        Func1::new({
                            let _v113 = _v113.clone();
                            move |v: Option<Documents::US3>| Documents::closure9(_v113.clone(), v)
                        }),
                        (),
                    );
                    ()
                };
                let v133: Documents::US3 = defaultValue(Documents::US3::US3_1, _v113.get().clone());
                let v173: DateTime = match &v133 {
                    Documents::US3::US3_0(v133_0_0) => {
                        let v147: TimeSpan = TimeSpan::new_ticks(
                            {
                                let _arg: DateTime = DateTime::now();
                                _arg.ticks()
                            } - match &v133 {
                                Documents::US3::US3_0(x) => x.clone(),
                                _ => unreachable!(),
                            },
                        );
                        DateTime::new_ymdhms_milli(
                            1_i32,
                            1_i32,
                            1_i32,
                            v147.hours(),
                            v147.minutes(),
                            v147.seconds(),
                            v147.milliseconds(),
                        )
                    }
                    _ => DateTime::now(),
                };
                let v178: string = {
                    let provider: string = Documents::method6();
                    v173.toString(provider)
                };
                let v570: string = padLeft(toLower(string("Warning")), 7_i32, ' ');
                let v586: &str = inline_colorization::color_yellow;
                let v588: &str = &*v570;
                let v590: &str = inline_colorization::color_reset;
                let v592: string = string("format!(\"{v586}{v588}{v590}\")");
                let v593: std::string::String = format!("{v586}{v588}{v590}");
                let v595: string = fable_library_rust::String_::fromString(v593);
                let v636: i64 = (patternInput_2.0.clone()).l0.get().clone();
                let v638: LrcPtr<Documents::Mut3> = LrcPtr::new(Documents::Mut3 {
                    l0: MutCell::new(Documents::method9()),
                });
                let v645: () = {
                    Documents::closure11(v638.clone(), sprintf!("{}", string("{ ")), ());
                    ()
                };
                let v654: () = {
                    Documents::closure11(v638.clone(), sprintf!("{}", string("error")), ());
                    ()
                };
                let v663: () = {
                    Documents::closure11(v638.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v671: () = {
                    Documents::closure11(v638.clone(), sprintf!("{}", v0_1), ());
                    ()
                };
                let v680: () = {
                    Documents::closure11(v638.clone(), sprintf!("{}", string(" }")), ());
                    ()
                };
                let v722: string = trimEndChars(
                    trimStartChars(
                        sprintf!(
                            "{} {} #{} {} / {}",
                            v178,
                            v595,
                            v636,
                            string("file_system.get_workspace_root"),
                            v638.l0.get().clone()
                        ),
                        toArray(empty::<char>()),
                    ),
                    toArray(ofArray(new_array(&[' ', '/']))),
                );
                println!("{}", v722.clone());
                ();
                ((patternInput.1.clone()).l0.get().clone())(v722)
            }
        }
        pub fn method23() -> string {
            let v2: Result<std::path::PathBuf, std::io::Error> = std::env::current_dir();
            let v4: std::path::PathBuf = v2.unwrap();
            let v6: std::path::Display = v4.display();
            let v9: std::string::String = format!("{}", v6);
            fable_library_rust::String_::fromString(v9)
        }
        pub fn method26(v0_1: string) -> string {
            v0_1
        }
        pub fn method25(v0_1: string) -> string {
            if v0_1.clone() == string("") {
                string("")
            } else {
                let v7: Result<regex::Regex, regex::Error> =
                    regex::Regex::new(&string("^\\\\\\\\\\?\\\\"));
                let v9: regex::Regex = v7.unwrap();
                let v10: string = Documents::method26(v0_1);
                let v12: std::borrow::Cow<str> = v9.replace_all(&*v10, &*string(""));
                let v14: std::string::String = String::from(v12);
                let v30: string = fable_library_rust::String_::fromString(v14);
                replace(
                    sprintf!(
                        "{}{}",
                        toLower(ofChar(getCharAt(v30.clone(), 0_i32))),
                        getSlice(v30, Some(1_i32), None::<i32>)
                    ),
                    string("\\"),
                    string("/"),
                )
            }
        }
        pub fn method27(v0_1: i32, v1_1: LrcPtr<Documents::Mut5>) -> bool {
            v1_1.l0.get().clone() < v0_1
        }
        pub fn method28(v0_1: i32, v1_1: LrcPtr<Documents::Mut6>) -> bool {
            v1_1.l0.get().clone() < v0_1
        }
        pub fn method29() -> char {
            std::path::MAIN_SEPARATOR
        }
        pub fn method24(v0_1: string) -> string {
            let v3: &str = &*v0_1.clone();
            let v5: std::string::String = String::from(v3);
            let v7: std::path::PathBuf = std::path::PathBuf::from(v5);
            if v7.exists() == false {
                let v11: string = Documents::method23();
                let v15: Array<string> = split(
                    Documents::method25(Documents::method15(v11.clone(), v0_1.clone())),
                    string("/"),
                    -1_i32,
                    0_i32,
                );
                let v19: i32 = count_2(v15.clone());
                let v20: LrcPtr<Documents::Mut5> = LrcPtr::new(Documents::Mut5 {
                    l0: MutCell::new(0_i32),
                    l1: MutCell::new(0_i32),
                    l2: MutCell::new(new_empty::<string>()),
                });
                while Documents::method27(v19, v20.clone()) {
                    let v22: i32 = v20.l0.get().clone();
                    let v25: i32 = v22.wrapping_neg() + v19 - 1_i32;
                    let matchValue: i32 = v20.l1.get().clone();
                    let v27: Array<string> = v20.l2.get().clone();
                    let v26: i32 = matchValue;
                    let v28: string = v15[v25].clone();
                    let patternInput_1: (i32, Array<string>) = if string("..") == v28.clone() {
                        (v26 + 1_i32, v27.clone())
                    } else {
                        if string(".") == v28.clone() {
                            (v26, v27.clone())
                        } else {
                            if 0_i32 == v26 {
                                if endsWith(v28.clone(), string(":"), false) {
                                    let v36: Array<string> = new_array(&[sprintf!(
                                        "{}:",
                                        getCharAt(v11.clone(), 0_i32)
                                    )]);
                                    let v37: i32 = count_2(v36.clone());
                                    let v39: i32 = v37 + count_2(v27.clone());
                                    let v40: Array<string> = new_init(&string(""), v39);
                                    let v41: LrcPtr<Documents::Mut6> =
                                        LrcPtr::new(Documents::Mut6 {
                                            l0: MutCell::new(0_i32),
                                        });
                                    while Documents::method28(v39, v41.clone()) {
                                        let v43: i32 = v41.l0.get().clone();
                                        let v48: string = if v43 < v37 {
                                            v36[v43].clone()
                                        } else {
                                            let v46: i32 = v43 - v37;
                                            v27[v46].clone()
                                        };
                                        v40.get_mut()[v43 as usize] = v48;
                                        {
                                            let v49: i32 = v43 + 1_i32;
                                            v41.l0.set(v49);
                                            ()
                                        }
                                    }
                                    (0_i32, v40.clone())
                                } else {
                                    let v50: Array<string> = new_array(&[v28]);
                                    let v51: i32 = count_2(v50.clone());
                                    let v53: i32 = v51 + count_2(v27.clone());
                                    let v54: Array<string> = new_init(&string(""), v53);
                                    let v55: LrcPtr<Documents::Mut6> =
                                        LrcPtr::new(Documents::Mut6 {
                                            l0: MutCell::new(0_i32),
                                        });
                                    while Documents::method28(v53, v55.clone()) {
                                        let v57: i32 = v55.l0.get().clone();
                                        let v62: string = if v57 < v51 {
                                            v50[v57].clone()
                                        } else {
                                            let v60: i32 = v57 - v51;
                                            v27[v60].clone()
                                        };
                                        v54.get_mut()[v57 as usize] = v62;
                                        {
                                            let v63: i32 = v57 + 1_i32;
                                            v55.l0.set(v63);
                                            ()
                                        }
                                    }
                                    (0_i32, v54.clone())
                                }
                            } else {
                                (v26 - 1_i32, v27.clone())
                            }
                        }
                    };
                    let v73: i32 = v22 + 1_i32;
                    v20.l0.set(v73);
                    v20.l1.set(patternInput_1.0.clone());
                    v20.l2.set(patternInput_1.1.clone());
                    ()
                }
                {
                    let matchValue_2: i32 = v20.l1.get().clone();
                    let v75: Array<string> = v20.l2.get().clone();
                    let v76: LrcPtr<dyn IEnumerable_1<string>> = delay(Func0::new({
                        let v75 = v75.clone();
                        move || {
                            map(
                                Func1::new({
                                    let v75 = v75.clone();
                                    move |i: i32| v75[i].clone()
                                }),
                                rangeNumeric(0_i32, 1_i32, count_2(v75.clone()) - 1_i32),
                            )
                        }
                    }));
                    join(ofChar(Documents::method29()), toArray_1(v76))
                }
            } else {
                let v90: Result<std::path::PathBuf, std::io::Error> = std::fs::canonicalize(&*v0_1);
                let v92: std::path::PathBuf = v90.unwrap();
                let v94: std::path::Display = v92.display();
                let v97: std::string::String = format!("{}", v94);
                fable_library_rust::String_::fromString(v97)
            }
        }
        pub fn closure18(v0_1: string, v1_1: string, v2: string, v3: string, unitVar: ()) {
            fn v5() {
                Documents::closure7((), ());
            }
            let v6: () = {
                v5();
                ()
            };
            let patternInput: (
                LrcPtr<Documents::Mut0>,
                LrcPtr<Documents::Mut1>,
                LrcPtr<Documents::Mut2>,
                LrcPtr<Documents::Mut3>,
                LrcPtr<Documents::Mut4>,
                Option<i64>,
            ) = getValue(Documents::TraceState::trace_state().get().clone());
            let v39: () = {
                v5();
                ()
            };
            let patternInput_1: (
                LrcPtr<Documents::Mut0>,
                LrcPtr<Documents::Mut1>,
                LrcPtr<Documents::Mut2>,
                LrcPtr<Documents::Mut3>,
                LrcPtr<Documents::Mut4>,
                Option<i64>,
            ) = getValue(Documents::TraceState::trace_state().get().clone());
            let v71: Documents::US0 = (patternInput_1.4.clone()).l0.get().clone();
            if if (patternInput_1.2.clone()).l0.get().clone() == false {
                false
            } else {
                1_i32
                    >= find(
                        v71,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Documents::US0::US0_0, 0_i32)),
                            LrcPtr::new((Documents::US0::US0_1, 1_i32)),
                            LrcPtr::new((Documents::US0::US0_2, 2_i32)),
                            LrcPtr::new((Documents::US0::US0_3, 3_i32)),
                            LrcPtr::new((Documents::US0::US0_4, 4_i32)),
                        ])))),
                    )
            } {
                let v79: () = {
                    Documents::closure8(patternInput.0.clone(), ());
                    ()
                };
                let v83: () = {
                    v5();
                    ()
                };
                let patternInput_2: (
                    LrcPtr<Documents::Mut0>,
                    LrcPtr<Documents::Mut1>,
                    LrcPtr<Documents::Mut2>,
                    LrcPtr<Documents::Mut3>,
                    LrcPtr<Documents::Mut4>,
                    Option<i64>,
                ) = getValue(Documents::TraceState::trace_state().get().clone());
                let _v116: LrcPtr<MutCell<Option<Documents::US3>>> =
                    refCell(None::<Documents::US3>);
                let v121: () = {
                    Documents::closure10(
                        patternInput_2.5.clone(),
                        Func1::new({
                            let _v116 = _v116.clone();
                            move |v: Option<Documents::US3>| Documents::closure9(_v116.clone(), v)
                        }),
                        (),
                    );
                    ()
                };
                let v136: Documents::US3 = defaultValue(Documents::US3::US3_1, _v116.get().clone());
                let v176: DateTime = match &v136 {
                    Documents::US3::US3_0(v136_0_0) => {
                        let v150: TimeSpan = TimeSpan::new_ticks(
                            {
                                let _arg: DateTime = DateTime::now();
                                _arg.ticks()
                            } - match &v136 {
                                Documents::US3::US3_0(x) => x.clone(),
                                _ => unreachable!(),
                            },
                        );
                        DateTime::new_ymdhms_milli(
                            1_i32,
                            1_i32,
                            1_i32,
                            v150.hours(),
                            v150.minutes(),
                            v150.seconds(),
                            v150.milliseconds(),
                        )
                    }
                    _ => DateTime::now(),
                };
                let v181: string = {
                    let provider: string = Documents::method6();
                    v176.toString(provider)
                };
                let v573: string = padLeft(toLower(string("Debug")), 7_i32, ' ');
                let v589: &str = inline_colorization::color_bright_blue;
                let v591: &str = &*v573;
                let v593: &str = inline_colorization::color_reset;
                let v595: string = string("format!(\"{v589}{v591}{v593}\")");
                let v596: std::string::String = format!("{v589}{v591}{v593}");
                let v598: string = fable_library_rust::String_::fromString(v596);
                let v639: i64 = (patternInput_2.0.clone()).l0.get().clone();
                let v641: LrcPtr<Documents::Mut3> = LrcPtr::new(Documents::Mut3 {
                    l0: MutCell::new(Documents::method9()),
                });
                let v648: () = {
                    Documents::closure11(v641.clone(), sprintf!("{}", string("{ ")), ());
                    ()
                };
                let v657: () = {
                    Documents::closure11(v641.clone(), sprintf!("{}", string("source_dir")), ());
                    ()
                };
                let v666: () = {
                    Documents::closure11(v641.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v674: () = {
                    Documents::closure11(v641.clone(), sprintf!("{}", v1_1), ());
                    ()
                };
                let v683: () = {
                    Documents::closure11(v641.clone(), sprintf!("{}", string("; ")), ());
                    ()
                };
                let v692: () = {
                    Documents::closure11(v641.clone(), sprintf!("{}", string("dist_dir")), ());
                    ()
                };
                let v700: () = {
                    Documents::closure11(v641.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v708: () = {
                    Documents::closure11(v641.clone(), sprintf!("{}", v2), ());
                    ()
                };
                let v716: () = {
                    Documents::closure11(v641.clone(), sprintf!("{}", string("; ")), ());
                    ()
                };
                let v725: () = {
                    Documents::closure11(v641.clone(), sprintf!("{}", string("cache_dir")), ());
                    ()
                };
                let v733: () = {
                    Documents::closure11(v641.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v741: () = {
                    Documents::closure11(v641.clone(), sprintf!("{}", v3), ());
                    ()
                };
                let v749: () = {
                    Documents::closure11(v641.clone(), sprintf!("{}", string("; ")), ());
                    ()
                };
                let v758: () = {
                    Documents::closure11(v641.clone(), sprintf!("{}", string("hangul_spec")), ());
                    ()
                };
                let v766: () = {
                    Documents::closure11(v641.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v774: () = {
                    Documents::closure11(v641.clone(), sprintf!("{}", v0_1), ());
                    ()
                };
                let v783: () = {
                    Documents::closure11(v641.clone(), sprintf!("{}", string(" }")), ());
                    ()
                };
                let v845: string = trimEndChars(
                    trimStartChars(
                        sprintf!(
                            "{} {} #{} {} / {}",
                            v181,
                            v598,
                            v639,
                            string("documents.run"),
                            v641.l0.get().clone()
                        ),
                        toArray(empty::<char>()),
                    ),
                    toArray(ofArray(new_array(&[' ', '/']))),
                );
                println!("{}", v845.clone());
                ();
                ((patternInput.1.clone()).l0.get().clone())(v845)
            }
        }
        pub fn method30(v0_1: async_walkdir::DirEntry) -> async_walkdir::DirEntry {
            v0_1
        }
        pub fn closure20(unitVar: (), v0_1: std::io::Error) -> std::string::String {
            format!("{}", v0_1)
        }
        pub fn method31() -> Func1<std::io::Error, std::string::String> {
            Func1::new(move |v: std::io::Error| Documents::closure20((), v))
        }
        pub fn closure21(unitVar: (), v0_1: std::fs::FileType) -> Documents::US8 {
            Documents::US8::US8_0(v0_1)
        }
        pub fn closure22(unitVar: (), v0_1: std::string::String) -> Documents::US8 {
            Documents::US8::US8_1(v0_1)
        }
        pub fn method32(v0_1: std::fs::FileType) -> std::fs::FileType {
            v0_1
        }
        pub fn method33(v0_1: Documents::US9) -> Documents::US9 {
            v0_1
        }
        pub fn method34(v0_1: async_walkdir::Filtering) -> async_walkdir::Filtering {
            v0_1
        }
        pub fn closure19(
            unitVar: (),
            v0_1: async_walkdir::DirEntry,
        ) -> std::pin::Pin<Box<dyn std::future::Future<Output = async_walkdir::Filtering> + Send>>
        {
            let v2: bool = true;
            let __future_init = Box::pin(async {
                //;
                let v4: bool = true;
                let __future_init = Box::pin(async move {
                    //;
                    let v5: async_walkdir::DirEntry = Documents::method30(v0_1.clone());
                    let v7: std::pin::Pin<
                        Box<
                            dyn std::future::Future<
                                    Output = Result<std::fs::FileType, std::io::Error>,
                                > + Send,
                        >,
                    > = Box::pin(async_walkdir::DirEntry::file_type(&v5));
                    let v9: Result<std::fs::FileType, std::io::Error> = v7.await;
                    let v10 = Documents::method31();
                    let v12: Result<std::fs::FileType, std::string::String> =
                        v9.map_err(|x| v10(x));
                    let v15: Documents::US8 = match &v12 {
                        Err(v12_1_0) => Documents::closure22((), v12_1_0.clone()),
                        Ok(v12_0_0) => Documents::closure21((), v12_0_0.clone()),
                    };
                    let v95: Documents::US9 =
                        Documents::method33(if let Documents::US8::US8_0(v15_0_0) = &v15 {
                            let v17: std::fs::FileType = Documents::method32(match &v15 {
                                Documents::US8::US8_0(x) => x.clone(),
                                _ => unreachable!(),
                            });
                            if std::fs::FileType::is_dir(&v17) {
                                Documents::US9::US9_0
                            } else {
                                let v22: std::path::PathBuf =
                                    async_walkdir::DirEntry::path(&v0_1.clone());
                                let v24: std::path::Display = v22.display();
                                let v27: std::string::String = format!("{}", v24);
                                let v47: string = fable_library_rust::String_::fromString(v27);
                                if if endsWith(v47.clone(), string(".md"), false) == false {
                                    true
                                } else {
                                    endsWith(v47, string(".hangul.md"), false)
                                } {
                                    Documents::US9::US9_0
                                } else {
                                    Documents::US9::US9_2
                                }
                            }
                        } else {
                            let v59: std::path::PathBuf = async_walkdir::DirEntry::path(&v0_1);
                            let v61: std::path::Display = v59.display();
                            let v64: std::string::String = format!("{}", v61);
                            let v84: string = fable_library_rust::String_::fromString(v64);
                            if if endsWith(v84.clone(), string(".md"), false) == false {
                                true
                            } else {
                                endsWith(v84, string(".hangul.md"), false)
                            } {
                                Documents::US9::US9_0
                            } else {
                                Documents::US9::US9_2
                            }
                        });
                    let v99: string = string("true; v95 });  // rust.fix_closure\'");
                    let v100: bool = true;
                    v95
                }); // rust.fix_closure';
                let v102 = __future_init;
                let v104: std::pin::Pin<
                    Box<dyn std::future::Future<Output = Documents::US9> + Send>,
                > = v102;
                let v106: Documents::US9 = v104.await;
                let v116: async_walkdir::Filtering = Documents::method34(match &v106 {
                    Documents::US9::US9_0 => async_walkdir::Filtering::Ignore,
                    Documents::US9::US9_1 => async_walkdir::Filtering::IgnoreDir,
                    _ => async_walkdir::Filtering::Continue,
                });
                let v118: string = string("true; v116 });  // rust.fix_closure\'");
                let v119: bool = true;
                v116
            }); // rust.fix_closure';
            let v121 = __future_init;
            v121
        }
        pub fn closure24(unitVar: (), v0_1: async_walkdir::Error) -> std::string::String {
            format!("{}", v0_1)
        }
        pub fn method36() -> Func1<async_walkdir::Error, std::string::String> {
            Func1::new(move |v: async_walkdir::Error| Documents::closure24((), v))
        }
        pub fn closure25(unitVar: (), v0_1: async_walkdir::DirEntry) -> Documents::US10 {
            Documents::US10::US10_0(v0_1)
        }
        pub fn closure26(unitVar: (), v0_1: std::string::String) -> Documents::US10 {
            Documents::US10::US10_1(v0_1)
        }
        pub fn closure27(v0_1: std::string::String, unitVar: ()) {
            fn v2() {
                Documents::closure7((), ());
            }
            let v3: () = {
                v2();
                ()
            };
            let patternInput: (
                LrcPtr<Documents::Mut0>,
                LrcPtr<Documents::Mut1>,
                LrcPtr<Documents::Mut2>,
                LrcPtr<Documents::Mut3>,
                LrcPtr<Documents::Mut4>,
                Option<i64>,
            ) = getValue(Documents::TraceState::trace_state().get().clone());
            let v36: () = {
                v2();
                ()
            };
            let patternInput_1: (
                LrcPtr<Documents::Mut0>,
                LrcPtr<Documents::Mut1>,
                LrcPtr<Documents::Mut2>,
                LrcPtr<Documents::Mut3>,
                LrcPtr<Documents::Mut4>,
                Option<i64>,
            ) = getValue(Documents::TraceState::trace_state().get().clone());
            let v68: Documents::US0 = (patternInput_1.4.clone()).l0.get().clone();
            if if (patternInput_1.2.clone()).l0.get().clone() == false {
                false
            } else {
                4_i32
                    >= find(
                        v68,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Documents::US0::US0_0, 0_i32)),
                            LrcPtr::new((Documents::US0::US0_1, 1_i32)),
                            LrcPtr::new((Documents::US0::US0_2, 2_i32)),
                            LrcPtr::new((Documents::US0::US0_3, 3_i32)),
                            LrcPtr::new((Documents::US0::US0_4, 4_i32)),
                        ])))),
                    )
            } {
                let v76: () = {
                    Documents::closure8(patternInput.0.clone(), ());
                    ()
                };
                let v80: () = {
                    v2();
                    ()
                };
                let patternInput_2: (
                    LrcPtr<Documents::Mut0>,
                    LrcPtr<Documents::Mut1>,
                    LrcPtr<Documents::Mut2>,
                    LrcPtr<Documents::Mut3>,
                    LrcPtr<Documents::Mut4>,
                    Option<i64>,
                ) = getValue(Documents::TraceState::trace_state().get().clone());
                let _v113: LrcPtr<MutCell<Option<Documents::US3>>> =
                    refCell(None::<Documents::US3>);
                let v118: () = {
                    Documents::closure10(
                        patternInput_2.5.clone(),
                        Func1::new({
                            let _v113 = _v113.clone();
                            move |v: Option<Documents::US3>| Documents::closure9(_v113.clone(), v)
                        }),
                        (),
                    );
                    ()
                };
                let v133: Documents::US3 = defaultValue(Documents::US3::US3_1, _v113.get().clone());
                let v173: DateTime = match &v133 {
                    Documents::US3::US3_0(v133_0_0) => {
                        let v147: TimeSpan = TimeSpan::new_ticks(
                            {
                                let _arg: DateTime = DateTime::now();
                                _arg.ticks()
                            } - match &v133 {
                                Documents::US3::US3_0(x) => x.clone(),
                                _ => unreachable!(),
                            },
                        );
                        DateTime::new_ymdhms_milli(
                            1_i32,
                            1_i32,
                            1_i32,
                            v147.hours(),
                            v147.minutes(),
                            v147.seconds(),
                            v147.milliseconds(),
                        )
                    }
                    _ => DateTime::now(),
                };
                let v178: string = {
                    let provider: string = Documents::method6();
                    v173.toString(provider)
                };
                let v570: string = padLeft(toLower(string("Critical")), 7_i32, ' ');
                let v586: &str = inline_colorization::color_bright_red;
                let v588: &str = &*v570;
                let v590: &str = inline_colorization::color_reset;
                let v592: string = string("format!(\"{v586}{v588}{v590}\")");
                let v593: std::string::String = format!("{v586}{v588}{v590}");
                let v595: string = fable_library_rust::String_::fromString(v593);
                let v636: i64 = (patternInput_2.0.clone()).l0.get().clone();
                let v638: LrcPtr<Documents::Mut3> = LrcPtr::new(Documents::Mut3 {
                    l0: MutCell::new(Documents::method9()),
                });
                let v645: () = {
                    Documents::closure11(v638.clone(), sprintf!("{}", string("{ ")), ());
                    ()
                };
                let v654: () = {
                    Documents::closure11(v638.clone(), sprintf!("{}", string("error")), ());
                    ()
                };
                let v663: () = {
                    Documents::closure11(v638.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v668: std::string::String = format!("{:#?}", v0_1);
                let v698: () = {
                    Documents::closure11(
                        v638.clone(),
                        sprintf!("{}", fable_library_rust::String_::fromString(v668)),
                        (),
                    );
                    ()
                };
                let v707: () = {
                    Documents::closure11(v638.clone(), sprintf!("{}", string(" }")), ());
                    ()
                };
                let v769: string = trimEndChars(
                    trimStartChars(
                        sprintf!(
                            "{} {} #{} {} / {}",
                            v178,
                            v595,
                            v636,
                            string("documents.run / stream_filter_map"),
                            v638.l0.get().clone()
                        ),
                        toArray(empty::<char>()),
                    ),
                    toArray(ofArray(new_array(&[' ', '/']))),
                );
                println!("{}", v769.clone());
                ();
                ((patternInput.1.clone()).l0.get().clone())(v769)
            }
        }
        pub fn closure23(
            unitVar: (),
            v0_1: Result<async_walkdir::DirEntry, async_walkdir::Error>,
        ) -> Option<string> {
            let v1_1 = Documents::method36();
            let v3: Result<async_walkdir::DirEntry, std::string::String> =
                v0_1.map_err(|x| v1_1(x));
            let v6: Documents::US10 = match &v3 {
                Err(v3_1_0) => Documents::closure26((), v3_1_0.clone()),
                Ok(v3_0_0) => Documents::closure25((), v3_0_0.clone()),
            };
            let v865: Documents::US1 = match &v6 {
                Documents::US10::US10_0(v6_0_0) => {
                    let v9: std::path::PathBuf = async_walkdir::DirEntry::path(&v6_0_0.clone());
                    let v11: std::path::Display = v9.display();
                    let v14: std::string::String = format!("{}", v11);
                    Documents::US1::US1_0(fable_library_rust::String_::fromString(v14))
                }
                Documents::US10::US10_1(v6_1_0) => {
                    let v39: () = {
                        Documents::closure27(v6_1_0.clone(), ());
                        ()
                    };
                    Documents::US1::US1_1
                }
            };
            match &v865 {
                Documents::US1::US1_0(v865_0_0) => Some(match &v865 {
                    Documents::US1::US1_0(x) => x.clone(),
                    _ => unreachable!(),
                }),
                _ => None::<string>,
            }
        }
        pub fn method35(
        ) -> Func1<Result<async_walkdir::DirEntry, async_walkdir::Error>, Option<string>> {
            Func1::new(
                move |v: Result<async_walkdir::DirEntry, async_walkdir::Error>| {
                    Documents::closure23((), v)
                },
            )
        }
        pub fn closure28(v0_1: Vec<string>, unitVar: ()) {
            fn v2() {
                Documents::closure7((), ());
            }
            let v3: () = {
                v2();
                ()
            };
            let patternInput: (
                LrcPtr<Documents::Mut0>,
                LrcPtr<Documents::Mut1>,
                LrcPtr<Documents::Mut2>,
                LrcPtr<Documents::Mut3>,
                LrcPtr<Documents::Mut4>,
                Option<i64>,
            ) = getValue(Documents::TraceState::trace_state().get().clone());
            let v36: () = {
                v2();
                ()
            };
            let patternInput_1: (
                LrcPtr<Documents::Mut0>,
                LrcPtr<Documents::Mut1>,
                LrcPtr<Documents::Mut2>,
                LrcPtr<Documents::Mut3>,
                LrcPtr<Documents::Mut4>,
                Option<i64>,
            ) = getValue(Documents::TraceState::trace_state().get().clone());
            let v68: Documents::US0 = (patternInput_1.4.clone()).l0.get().clone();
            if if (patternInput_1.2.clone()).l0.get().clone() == false {
                false
            } else {
                1_i32
                    >= find(
                        v68,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Documents::US0::US0_0, 0_i32)),
                            LrcPtr::new((Documents::US0::US0_1, 1_i32)),
                            LrcPtr::new((Documents::US0::US0_2, 2_i32)),
                            LrcPtr::new((Documents::US0::US0_3, 3_i32)),
                            LrcPtr::new((Documents::US0::US0_4, 4_i32)),
                        ])))),
                    )
            } {
                let v76: () = {
                    Documents::closure8(patternInput.0.clone(), ());
                    ()
                };
                let v80: () = {
                    v2();
                    ()
                };
                let patternInput_2: (
                    LrcPtr<Documents::Mut0>,
                    LrcPtr<Documents::Mut1>,
                    LrcPtr<Documents::Mut2>,
                    LrcPtr<Documents::Mut3>,
                    LrcPtr<Documents::Mut4>,
                    Option<i64>,
                ) = getValue(Documents::TraceState::trace_state().get().clone());
                let _v113: LrcPtr<MutCell<Option<Documents::US3>>> =
                    refCell(None::<Documents::US3>);
                let v118: () = {
                    Documents::closure10(
                        patternInput_2.5.clone(),
                        Func1::new({
                            let _v113 = _v113.clone();
                            move |v: Option<Documents::US3>| Documents::closure9(_v113.clone(), v)
                        }),
                        (),
                    );
                    ()
                };
                let v133: Documents::US3 = defaultValue(Documents::US3::US3_1, _v113.get().clone());
                let v173: DateTime = match &v133 {
                    Documents::US3::US3_0(v133_0_0) => {
                        let v147: TimeSpan = TimeSpan::new_ticks(
                            {
                                let _arg: DateTime = DateTime::now();
                                _arg.ticks()
                            } - match &v133 {
                                Documents::US3::US3_0(x) => x.clone(),
                                _ => unreachable!(),
                            },
                        );
                        DateTime::new_ymdhms_milli(
                            1_i32,
                            1_i32,
                            1_i32,
                            v147.hours(),
                            v147.minutes(),
                            v147.seconds(),
                            v147.milliseconds(),
                        )
                    }
                    _ => DateTime::now(),
                };
                let v178: string = {
                    let provider: string = Documents::method6();
                    v173.toString(provider)
                };
                let v570: string = padLeft(toLower(string("Debug")), 7_i32, ' ');
                let v586: &str = inline_colorization::color_bright_blue;
                let v588: &str = &*v570;
                let v590: &str = inline_colorization::color_reset;
                let v592: string = string("format!(\"{v586}{v588}{v590}\")");
                let v593: std::string::String = format!("{v586}{v588}{v590}");
                let v595: string = fable_library_rust::String_::fromString(v593);
                let v636: i64 = (patternInput_2.0.clone()).l0.get().clone();
                let v638: usize = v0_1.len();
                let v640: LrcPtr<Documents::Mut3> = LrcPtr::new(Documents::Mut3 {
                    l0: MutCell::new(Documents::method9()),
                });
                let v647: () = {
                    Documents::closure11(v640.clone(), sprintf!("{}", string("{ ")), ());
                    ()
                };
                let v656: () = {
                    Documents::closure11(v640.clone(), sprintf!("{}", string("files_len")), ());
                    ()
                };
                let v665: () = {
                    Documents::closure11(v640.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v670: std::string::String = format!("{:#?}", v638);
                let v700: () = {
                    Documents::closure11(
                        v640.clone(),
                        sprintf!("{}", fable_library_rust::String_::fromString(v670)),
                        (),
                    );
                    ()
                };
                let v709: () = {
                    Documents::closure11(v640.clone(), sprintf!("{}", string(" }")), ());
                    ()
                };
                let v771: string = trimEndChars(
                    trimStartChars(
                        sprintf!(
                            "{} {} #{} {} / {}",
                            v178,
                            v595,
                            v636,
                            string("documents.run"),
                            v640.l0.get().clone()
                        ),
                        toArray(empty::<char>()),
                    ),
                    toArray(ofArray(new_array(&[' ', '/']))),
                );
                println!("{}", v771.clone());
                ();
                ((patternInput.1.clone()).l0.get().clone())(v771)
            }
        }
        pub fn method37() -> string {
            string("")
        }
        pub fn method38(v0_1: string) -> string {
            Documents::method25(Documents::method24(v0_1))
        }
        pub fn method40(
            v0_1: string,
            v1_1: Option<CancellationToken>,
            v2: Array<(string, string)>,
            v3: Option<Func1<(i32, string, bool), Arc<Async<()>>>>,
            v4: Option<Func1<std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>, ()>>,
            v5: bool,
            v6: Option<string>,
        ) -> string {
            v0_1
        }
        pub fn closure32(v0_1: char, v1_1: LrcPtr<Documents::UH0>) -> LrcPtr<Documents::UH0> {
            LrcPtr::new(Documents::UH0::UH0_1(v0_1, v1_1))
        }
        pub fn closure31(
            unitVar: (),
            v0_1: char,
        ) -> Func1<LrcPtr<Documents::UH0>, LrcPtr<Documents::UH0>> {
            Func1::new({
                let v0_1 = v0_1.clone();
                move |v: LrcPtr<Documents::UH0>| Documents::closure32(v0_1, v)
            })
        }
        pub fn method42() -> Func1<char, Func1<LrcPtr<Documents::UH0>, LrcPtr<Documents::UH0>>> {
            Func1::new(move |v: char| Documents::closure31((), v))
        }
        pub fn method43(
            v0_1: LrcPtr<Documents::UH0>,
            v1_1: LrcPtr<StringBuilder>,
            v2: i32,
            v3: i32,
        ) -> (LrcPtr<StringBuilder>, i32, i32) {
            let v0_1: MutCell<LrcPtr<Documents::UH0>> = MutCell::new(v0_1.clone());
            let v1_1: MutCell<LrcPtr<StringBuilder>> = MutCell::new(v1_1.clone());
            let v2: MutCell<i32> = MutCell::new(v2);
            let v3: MutCell<i32> = MutCell::new(v3);
            '_method43: loop {
                break '_method43 (match v0_1.get().clone().as_ref() {
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
                            (v2.get().clone() + 1_i32, 1_i32)
                        } else {
                            (v2.get().clone(), v3.get().clone() + 1_i32)
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
                                let v18: LrcPtr<StringBuilder> = {
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
                            continue '_method43;
                        }
                    }
                });
            }
        }
        pub fn closure30(
            unitVar: (),
            _arg: (string, LrcPtr<StringBuilder>, i32, i32),
        ) -> Documents::US12 {
            let v3: i32 = _arg.3.clone();
            let v2: i32 = _arg.2.clone();
            let v1_1: LrcPtr<StringBuilder> = _arg.1.clone();
            let v0_1: string = _arg.0.clone();
            if string("") == v0_1.clone() {
                Documents::US12::US12_1(sprintf!(
                    "parsing.p_char / unexpected end of input / s: {:?}",
                    (v1_1.clone(), v2, v3)
                ))
            } else {
                let v7: char = getCharAt(v0_1.clone(), 0_i32);
                if v7 == '\"' {
                    let v15: string =
                        getSlice(v0_1.clone(), Some(1_i32), Some(length(v0_1.clone())));
                    let v17: string = ofChar(v7);
                    let v20: i32 = length(v17.clone());
                    let v21: Array<char> = new_init(&'\u{0000}', v20);
                    let v22: LrcPtr<Documents::Mut6> = LrcPtr::new(Documents::Mut6 {
                        l0: MutCell::new(0_i32),
                    });
                    while Documents::method28(v20, v22.clone()) {
                        let v24: i32 = v22.l0.get().clone();
                        let v25: char = getCharAt(v17.clone(), v24);
                        v21.get_mut()[v24 as usize] = v25;
                        {
                            let v26: i32 = v24 + 1_i32;
                            v22.l0.set(v26);
                            ()
                        }
                    }
                    {
                        let v27: List<char> = ofArray(v21.clone());
                        let patternInput: (LrcPtr<StringBuilder>, i32, i32) = Documents::method43(
                            foldBack(
                                Func2::new(move |b0: char, b1: LrcPtr<Documents::UH0>| {
                                    (Documents::method42())(b0)(b1)
                                }),
                                v27,
                                LrcPtr::new(Documents::UH0::UH0_0),
                            ),
                            v1_1.clone(),
                            v2,
                            v3,
                        );
                        Documents::US12::US12_0(
                            v7,
                            v15,
                            patternInput.0.clone(),
                            patternInput.1.clone(),
                            patternInput.2.clone(),
                        )
                    }
                } else {
                    let v43: i32 = length(v0_1.clone());
                    let v46: i32 = indexOf(v0_1.clone(), string("\n")) - 1_i32;
                    Documents::US12::US12_1(sprintf!(
                        "{}\n{}\n",
                        sprintf!(
                            "parsing.p_char / expected: \'{}\' / line: {} / col: {}\n{}{}",
                            '\"',
                            v2,
                            v3,
                            v1_1,
                            getSlice(
                                v0_1,
                                Some(0_i32),
                                Some(if -2_i32 == v46 { v43 } else { v46 })
                            )
                        ),
                        append(replicate(v3 - 1_i32, string(" ")), string("^"))
                    ))
                }
            }
        }
        pub fn closure33(
            unitVar: (),
            _arg: (string, LrcPtr<StringBuilder>, i32, i32),
        ) -> Documents::US12 {
            let v3: i32 = _arg.3.clone();
            let v2: i32 = _arg.2.clone();
            let v1_1: LrcPtr<StringBuilder> = _arg.1.clone();
            let v0_1: string = _arg.0.clone();
            if string("") == v0_1.clone() {
                Documents::US12::US12_1(sprintf!(
                    "parsing.p_char / unexpected end of input / s: {:?}",
                    (v1_1.clone(), v2, v3)
                ))
            } else {
                let v7: char = getCharAt(v0_1.clone(), 0_i32);
                if v7 == '\'' {
                    let v15: string =
                        getSlice(v0_1.clone(), Some(1_i32), Some(length(v0_1.clone())));
                    let v17: string = ofChar(v7);
                    let v20: i32 = length(v17.clone());
                    let v21: Array<char> = new_init(&'\u{0000}', v20);
                    let v22: LrcPtr<Documents::Mut6> = LrcPtr::new(Documents::Mut6 {
                        l0: MutCell::new(0_i32),
                    });
                    while Documents::method28(v20, v22.clone()) {
                        let v24: i32 = v22.l0.get().clone();
                        let v25: char = getCharAt(v17.clone(), v24);
                        v21.get_mut()[v24 as usize] = v25;
                        {
                            let v26: i32 = v24 + 1_i32;
                            v22.l0.set(v26);
                            ()
                        }
                    }
                    {
                        let v27: List<char> = ofArray(v21.clone());
                        let patternInput: (LrcPtr<StringBuilder>, i32, i32) = Documents::method43(
                            foldBack(
                                Func2::new(move |b0: char, b1: LrcPtr<Documents::UH0>| {
                                    (Documents::method42())(b0)(b1)
                                }),
                                v27,
                                LrcPtr::new(Documents::UH0::UH0_0),
                            ),
                            v1_1.clone(),
                            v2,
                            v3,
                        );
                        Documents::US12::US12_0(
                            v7,
                            v15,
                            patternInput.0.clone(),
                            patternInput.1.clone(),
                            patternInput.2.clone(),
                        )
                    }
                } else {
                    let v43: i32 = length(v0_1.clone());
                    let v46: i32 = indexOf(v0_1.clone(), string("\n")) - 1_i32;
                    Documents::US12::US12_1(sprintf!(
                        "{}\n{}\n",
                        sprintf!(
                            "parsing.p_char / expected: \'{}\' / line: {} / col: {}\n{}{}",
                            '\'',
                            v2,
                            v3,
                            v1_1,
                            getSlice(
                                v0_1,
                                Some(0_i32),
                                Some(if -2_i32 == v46 { v43 } else { v46 })
                            )
                        ),
                        append(replicate(v3 - 1_i32, string(" ")), string("^"))
                    ))
                }
            }
        }
        pub fn method44(
            v0_1: string,
            v1_1: LrcPtr<StringBuilder>,
            v2: LrcPtr<Documents::UH1>,
        ) -> Documents::US12 {
            let v0_1: MutCell<string> = MutCell::new(v0_1.clone());
            let v1_1: MutCell<LrcPtr<StringBuilder>> = MutCell::new(v1_1.clone());
            let v2: MutCell<LrcPtr<Documents::UH1>> = MutCell::new(v2.clone());
            '_method44: loop {
                break '_method44 (match v2.get().clone().as_ref() {
                    Documents::UH1::UH1_0 => {
                        Documents::US12::US12_1(string("choice / no parsers succeeded"))
                    }
                    Documents::UH1::UH1_1(v2_1_0, v2_1_1) => {
                        let v7: Documents::US12 = (match v2.get().clone().as_ref() {
                            Documents::UH1::UH1_1(x, _) => x.clone(),
                            _ => unreachable!(),
                        })((
                            v0_1.get().clone(),
                            v1_1.get().clone(),
                            1_i32,
                            1_i32,
                        ));
                        match &v7 {
                            Documents::US12::US12_0(v7_0_0, v7_0_1, v7_0_2, v7_0_3, v7_0_4) => {
                                v7.clone()
                            }
                            _ => {
                                let v0_1_temp: string = v0_1.get().clone();
                                let v1_1_temp: LrcPtr<StringBuilder> = v1_1.get().clone();
                                let v2_temp: LrcPtr<Documents::UH1> =
                                    match v2.get().clone().as_ref() {
                                        Documents::UH1::UH1_1(_, x) => x.clone(),
                                        _ => unreachable!(),
                                    };
                                v0_1.set(v0_1_temp);
                                v1_1.set(v1_1_temp);
                                v2.set(v2_temp);
                                continue '_method44;
                            }
                        }
                    }
                });
            }
        }
        pub fn method45(v0_1: char, v1_1: i64) -> bool {
            let v0_1: MutCell<char> = MutCell::new(v0_1);
            let v1_1: MutCell<i64> = MutCell::new(v1_1);
            '_method45: loop {
                break '_method45 (if v1_1.get().clone() >= 2_i64 {
                    false
                } else {
                    let v11: Documents::US14 = if v1_1.get().clone() == 0_i64 {
                        Documents::US14::US14_0('\"')
                    } else {
                        let v5: i64 = v1_1.get().clone() - 1_i64;
                        if v5 == 0_i64 {
                            Documents::US14::US14_0('\'')
                        } else {
                            let v8: i64 = v5 - 1_i64;
                            Documents::US14::US14_1
                        }
                    };
                    if v0_1.get().clone()
                        == match &v11 {
                            Documents::US14::US14_0(v11_0_0) => match &v11 {
                                Documents::US14::US14_0(x) => x.clone(),
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
                        continue '_method45;
                    }
                });
            }
        }
        pub fn method46(
            v0_1: string,
            v1_1: string,
            v2: LrcPtr<StringBuilder>,
            v3: i32,
            v4: i32,
        ) -> Documents::US13 {
            let v0_1: MutCell<string> = MutCell::new(v0_1.clone());
            let v1_1: MutCell<string> = MutCell::new(v1_1.clone());
            let v2: MutCell<LrcPtr<StringBuilder>> = MutCell::new(v2.clone());
            let v3: MutCell<i32> = MutCell::new(v3);
            let v4: MutCell<i32> = MutCell::new(v4);
            '_method46: loop {
                break '_method46 ({
                    let v70: Documents::US12 = if string("") == v1_1.get().clone() {
                        Documents::US12::US12_1(sprintf!(
                            "parsing.none_of / unexpected end of input / chars: {:?} / s: {:?}",
                            toArray(ofArray(new_array(&['\"', '\'']))),
                            (v2.get().clone(), v3.get().clone(), v4.get().clone())
                        ))
                    } else {
                        let v19: char = getCharAt(v1_1.get().clone(), 0_i32);
                        let v26: string = getSlice(
                            v1_1.get().clone(),
                            Some(1_i32),
                            Some(length(v1_1.get().clone())),
                        );
                        if Documents::method45(v19, 0_i64) == false {
                            let v31: string = ofChar(v19);
                            let v34: i32 = length(v31.clone());
                            let v35: Array<char> = new_init(&'\u{0000}', v34);
                            let v36: LrcPtr<Documents::Mut6> = LrcPtr::new(Documents::Mut6 {
                                l0: MutCell::new(0_i32),
                            });
                            while Documents::method28(v34, v36.clone()) {
                                let v38: i32 = v36.l0.get().clone();
                                let v39: char = getCharAt(v31.clone(), v38);
                                v35.get_mut()[v38 as usize] = v39;
                                {
                                    let v40: i32 = v38 + 1_i32;
                                    v36.l0.set(v40);
                                    ()
                                }
                            }
                            {
                                let v41: List<char> = ofArray(v35.clone());
                                let patternInput: (LrcPtr<StringBuilder>, i32, i32) =
                                    Documents::method43(
                                        foldBack(
                                            Func2::new(
                                                move |b0: char, b1: LrcPtr<Documents::UH0>| {
                                                    (Documents::method42())(b0)(b1)
                                                },
                                            ),
                                            v41,
                                            LrcPtr::new(Documents::UH0::UH0_0),
                                        ),
                                        v2.get().clone(),
                                        v3.get().clone(),
                                        v4.get().clone(),
                                    );
                                Documents::US12::US12_0(
                                    v19,
                                    v26,
                                    patternInput.0.clone(),
                                    patternInput.1.clone(),
                                    patternInput.2.clone(),
                                )
                            }
                        } else {
                            Documents::US12::US12_1(sprintf!(
                                "parsing.none_of / unexpected char: \'{}\' / chars: {:?} / s: {:?}",
                                v19,
                                toArray(ofArray(new_array(&['\"', '\'']))),
                                (v2.get().clone(), v3.get().clone(), v4.get().clone())
                            ))
                        }
                    };
                    let v82: Documents::US12 = match &v70 {
                        Documents::US12::US12_0(v70_0_0, v70_0_1, v70_0_2, v70_0_3, v70_0_4) => {
                            let v71: char = v70_0_0.clone();
                            Documents::US12::US12_0(
                                if '\\' == v71 { '/' } else { v71 },
                                v70_0_1.clone(),
                                v70_0_2.clone(),
                                v70_0_3.clone(),
                                v70_0_4.clone(),
                            )
                        }
                        Documents::US12::US12_1(v70_1_0) => {
                            Documents::US12::US12_1(v70_1_0.clone())
                        }
                    };
                    match &v82 {
                        Documents::US12::US12_0(v82_0_0, v82_0_1, v82_0_2, v82_0_3, v82_0_4) => {
                            let v0_1_temp: string =
                                append(v0_1.get().clone(), ofChar(v82_0_0.clone()));
                            let v1_1_temp: string = v82_0_1.clone();
                            let v2_temp: LrcPtr<StringBuilder> = v82_0_2.clone();
                            let v3_temp: i32 = v82_0_3.clone();
                            let v4_temp: i32 = v82_0_4.clone();
                            v0_1.set(v0_1_temp);
                            v1_1.set(v1_1_temp);
                            v2.set(v2_temp);
                            v3.set(v3_temp);
                            v4.set(v4_temp);
                            continue '_method46;
                        }
                        _ => Documents::US13::US13_0(
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
        pub fn method47(
            v0_1: string,
            v1_1: LrcPtr<StringBuilder>,
            v2: i32,
            v3: i32,
            v4: LrcPtr<Documents::UH1>,
        ) -> Documents::US12 {
            let v0_1: MutCell<string> = MutCell::new(v0_1.clone());
            let v1_1: MutCell<LrcPtr<StringBuilder>> = MutCell::new(v1_1.clone());
            let v2: MutCell<i32> = MutCell::new(v2);
            let v3: MutCell<i32> = MutCell::new(v3);
            let v4: MutCell<LrcPtr<Documents::UH1>> = MutCell::new(v4.clone());
            '_method47: loop {
                break '_method47 (match v4.get().clone().as_ref() {
                    Documents::UH1::UH1_0 => {
                        Documents::US12::US12_1(string("choice / no parsers succeeded"))
                    }
                    Documents::UH1::UH1_1(v4_1_0, v4_1_1) => {
                        let v9: Documents::US12 = (match v4.get().clone().as_ref() {
                            Documents::UH1::UH1_1(x, _) => x.clone(),
                            _ => unreachable!(),
                        })((
                            v0_1.get().clone(),
                            v1_1.get().clone(),
                            v2.get().clone(),
                            v3.get().clone(),
                        ));
                        match &v9 {
                            Documents::US12::US12_0(v9_0_0, v9_0_1, v9_0_2, v9_0_3, v9_0_4) => {
                                v9.clone()
                            }
                            _ => {
                                let v0_1_temp: string = v0_1.get().clone();
                                let v1_1_temp: LrcPtr<StringBuilder> = v1_1.get().clone();
                                let v2_temp: i32 = v2.get().clone();
                                let v3_temp: i32 = v3.get().clone();
                                let v4_temp: LrcPtr<Documents::UH1> =
                                    match v4.get().clone().as_ref() {
                                        Documents::UH1::UH1_1(_, x) => x.clone(),
                                        _ => unreachable!(),
                                    };
                                v0_1.set(v0_1_temp);
                                v1_1.set(v1_1_temp);
                                v2.set(v2_temp);
                                v3.set(v3_temp);
                                v4.set(v4_temp);
                                continue '_method47;
                            }
                        }
                    }
                });
            }
        }
        pub fn method48(v0_1: char, v1_1: i64) -> bool {
            let v0_1: MutCell<char> = MutCell::new(v0_1);
            let v1_1: MutCell<i64> = MutCell::new(v1_1);
            '_method48: loop {
                break '_method48 (if v1_1.get().clone() >= 3_i64 {
                    false
                } else {
                    let v15: Documents::US14 = if v1_1.get().clone() == 0_i64 {
                        Documents::US14::US14_0('\"')
                    } else {
                        let v5: i64 = v1_1.get().clone() - 1_i64;
                        if v5 == 0_i64 {
                            Documents::US14::US14_0('\'')
                        } else {
                            let v8: i64 = v5 - 1_i64;
                            if v8 == 0_i64 {
                                Documents::US14::US14_0(' ')
                            } else {
                                let v11: i64 = v8 - 1_i64;
                                Documents::US14::US14_1
                            }
                        }
                    };
                    if v0_1.get().clone()
                        == match &v15 {
                            Documents::US14::US14_0(v15_0_0) => match &v15 {
                                Documents::US14::US14_0(x) => x.clone(),
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
                        continue '_method48;
                    }
                });
            }
        }
        pub fn method49(
            v0_1: string,
            v1_1: string,
            v2: LrcPtr<StringBuilder>,
            v3: i32,
            v4: i32,
        ) -> Documents::US13 {
            let v0_1: MutCell<string> = MutCell::new(v0_1.clone());
            let v1_1: MutCell<string> = MutCell::new(v1_1.clone());
            let v2: MutCell<LrcPtr<StringBuilder>> = MutCell::new(v2.clone());
            let v3: MutCell<i32> = MutCell::new(v3);
            let v4: MutCell<i32> = MutCell::new(v4);
            '_method49: loop {
                break '_method49 ({
                    let v76: Documents::US12 = if string("") == v1_1.get().clone() {
                        Documents::US12::US12_1(sprintf!(
                            "parsing.none_of / unexpected end of input / chars: {:?} / s: {:?}",
                            toArray(ofArray(new_array(&['\"', '\'', ' ']))),
                            (v2.get().clone(), v3.get().clone(), v4.get().clone())
                        ))
                    } else {
                        let v22: char = getCharAt(v1_1.get().clone(), 0_i32);
                        let v29: string = getSlice(
                            v1_1.get().clone(),
                            Some(1_i32),
                            Some(length(v1_1.get().clone())),
                        );
                        if Documents::method48(v22, 0_i64) == false {
                            let v34: string = ofChar(v22);
                            let v37: i32 = length(v34.clone());
                            let v38: Array<char> = new_init(&'\u{0000}', v37);
                            let v39: LrcPtr<Documents::Mut6> = LrcPtr::new(Documents::Mut6 {
                                l0: MutCell::new(0_i32),
                            });
                            while Documents::method28(v37, v39.clone()) {
                                let v41: i32 = v39.l0.get().clone();
                                let v42: char = getCharAt(v34.clone(), v41);
                                v38.get_mut()[v41 as usize] = v42;
                                {
                                    let v43: i32 = v41 + 1_i32;
                                    v39.l0.set(v43);
                                    ()
                                }
                            }
                            {
                                let v44: List<char> = ofArray(v38.clone());
                                let patternInput: (LrcPtr<StringBuilder>, i32, i32) =
                                    Documents::method43(
                                        foldBack(
                                            Func2::new(
                                                move |b0: char, b1: LrcPtr<Documents::UH0>| {
                                                    (Documents::method42())(b0)(b1)
                                                },
                                            ),
                                            v44,
                                            LrcPtr::new(Documents::UH0::UH0_0),
                                        ),
                                        v2.get().clone(),
                                        v3.get().clone(),
                                        v4.get().clone(),
                                    );
                                Documents::US12::US12_0(
                                    v22,
                                    v29,
                                    patternInput.0.clone(),
                                    patternInput.1.clone(),
                                    patternInput.2.clone(),
                                )
                            }
                        } else {
                            Documents::US12::US12_1(sprintf!(
                                "parsing.none_of / unexpected char: \'{}\' / chars: {:?} / s: {:?}",
                                v22,
                                toArray(ofArray(new_array(&['\"', '\'', ' ']))),
                                (v2.get().clone(), v3.get().clone(), v4.get().clone())
                            ))
                        }
                    };
                    let v88: Documents::US12 = match &v76 {
                        Documents::US12::US12_0(v76_0_0, v76_0_1, v76_0_2, v76_0_3, v76_0_4) => {
                            let v77: char = v76_0_0.clone();
                            Documents::US12::US12_0(
                                if '\\' == v77 { '/' } else { v77 },
                                v76_0_1.clone(),
                                v76_0_2.clone(),
                                v76_0_3.clone(),
                                v76_0_4.clone(),
                            )
                        }
                        Documents::US12::US12_1(v76_1_0) => {
                            Documents::US12::US12_1(v76_1_0.clone())
                        }
                    };
                    match &v88 {
                        Documents::US12::US12_0(v88_0_0, v88_0_1, v88_0_2, v88_0_3, v88_0_4) => {
                            let v0_1_temp: string =
                                append(v0_1.get().clone(), ofChar(v88_0_0.clone()));
                            let v1_1_temp: string = v88_0_1.clone();
                            let v2_temp: LrcPtr<StringBuilder> = v88_0_2.clone();
                            let v3_temp: i32 = v88_0_3.clone();
                            let v4_temp: i32 = v88_0_4.clone();
                            v0_1.set(v0_1_temp);
                            v1_1.set(v1_1_temp);
                            v2.set(v2_temp);
                            v3.set(v3_temp);
                            v4.set(v4_temp);
                            continue '_method49;
                        }
                        _ => Documents::US13::US13_0(
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
        pub fn method50(v0_1: string, v1_1: i32) -> i32 {
            let v0_1: MutCell<string> = MutCell::new(v0_1.clone());
            let v1_1: MutCell<i32> = MutCell::new(v1_1);
            '_method50: loop {
                break '_method50 (if v1_1.get().clone() >= length(v0_1.get().clone()) {
                    v1_1.get().clone()
                } else {
                    if getCharAt(v0_1.get().clone(), v1_1.get().clone()) == ' ' {
                        let v0_1_temp: string = v0_1.get().clone();
                        let v1_1_temp: i32 = v1_1.get().clone() + 1_i32;
                        v0_1.set(v0_1_temp);
                        v1_1.set(v1_1_temp);
                        continue '_method50;
                    } else {
                        v1_1.get().clone()
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
        ) -> Documents::US13 {
            let v0_1: MutCell<string> = MutCell::new(v0_1.clone());
            let v1_1: MutCell<string> = MutCell::new(v1_1.clone());
            let v2: MutCell<LrcPtr<StringBuilder>> = MutCell::new(v2.clone());
            let v3: MutCell<i32> = MutCell::new(v3);
            let v4: MutCell<i32> = MutCell::new(v4);
            '_method51: loop {
                break '_method51 ({
                    let v42: Documents::US12 = if string("") == v1_1.get().clone() {
                        Documents::US12::US12_1(sprintf!(
                            "parsing.any_char / unexpected end of input / s: {:?}",
                            (v2.get().clone(), v3.get().clone(), v4.get().clone())
                        ))
                    } else {
                        let v8: char = getCharAt(v1_1.get().clone(), 0_i32);
                        let v15: string = getSlice(
                            v1_1.get().clone(),
                            Some(1_i32),
                            Some(length(v1_1.get().clone())),
                        );
                        let v17: string = ofChar(v8);
                        let v20: i32 = length(v17.clone());
                        let v21: Array<char> = new_init(&'\u{0000}', v20);
                        let v22: LrcPtr<Documents::Mut6> = LrcPtr::new(Documents::Mut6 {
                            l0: MutCell::new(0_i32),
                        });
                        while Documents::method28(v20, v22.clone()) {
                            let v24: i32 = v22.l0.get().clone();
                            let v25: char = getCharAt(v17.clone(), v24);
                            v21.get_mut()[v24 as usize] = v25;
                            {
                                let v26: i32 = v24 + 1_i32;
                                v22.l0.set(v26);
                                ()
                            }
                        }
                        {
                            let v27: List<char> = ofArray(v21.clone());
                            let patternInput: (LrcPtr<StringBuilder>, i32, i32) =
                                Documents::method43(
                                    foldBack(
                                        Func2::new(move |b0: char, b1: LrcPtr<Documents::UH0>| {
                                            (Documents::method42())(b0)(b1)
                                        }),
                                        v27,
                                        LrcPtr::new(Documents::UH0::UH0_0),
                                    ),
                                    v2.get().clone(),
                                    v3.get().clone(),
                                    v4.get().clone(),
                                );
                            Documents::US12::US12_0(
                                v8,
                                v15,
                                patternInput.0.clone(),
                                patternInput.1.clone(),
                                patternInput.2.clone(),
                            )
                        }
                    };
                    match &v42 {
                        Documents::US12::US12_0(v42_0_0, v42_0_1, v42_0_2, v42_0_3, v42_0_4) => {
                            let v0_1_temp: string =
                                append(v0_1.get().clone(), ofChar(v42_0_0.clone()));
                            let v1_1_temp: string = v42_0_1.clone();
                            let v2_temp: LrcPtr<StringBuilder> = v42_0_2.clone();
                            let v3_temp: i32 = v42_0_3.clone();
                            let v4_temp: i32 = v42_0_4.clone();
                            v0_1.set(v0_1_temp);
                            v1_1.set(v1_1_temp);
                            v2.set(v2_temp);
                            v3.set(v3_temp);
                            v4.set(v4_temp);
                            continue '_method51;
                        }
                        _ => Documents::US13::US13_0(
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
        pub fn method41(v0_1: string) -> Documents::US11 {
            let _v0: MutCell<Option<Option<string>>> = MutCell::new(None::<Option<string>>);
            _v0.set(Some(Some(v0_1)));
            {
                let v7: string = defaultValue(
                    string(""),
                    match &_v0.get().clone() {
                        None => panic!("{}", string("optionm\'.of_obj / _v0=None"),),
                        Some(_v0_0_0) => _v0_0_0.clone(),
                    },
                );
                let v11: LrcPtr<StringBuilder> = StringBuilder::_ctor__Z721C83C5(string(""));
                fn v12(arg10_0040: (string, LrcPtr<StringBuilder>, i32, i32)) -> Documents::US12 {
                    Documents::closure30((), arg10_0040)
                }
                fn v13(arg10_0040_1: (string, LrcPtr<StringBuilder>, i32, i32)) -> Documents::US12 {
                    Documents::closure33((), arg10_0040_1)
                }
                let v17: Documents::US12 = Documents::method44(
                    v7.clone(),
                    v11.clone(),
                    LrcPtr::new(Documents::UH1::UH1_1(
                        Func1::from(v12),
                        LrcPtr::new(Documents::UH1::UH1_1(
                            Func1::from(v13),
                            LrcPtr::new(Documents::UH1::UH1_0),
                        )),
                    )),
                );
                let v153: Documents::US13 = match &v17 {
                    Documents::US12::US12_0(v17_0_0, v17_0_1, v17_0_2, v17_0_3, v17_0_4) => {
                        let v22: i32 = v17_0_4.clone();
                        let v21: i32 = v17_0_3.clone();
                        let v20: LrcPtr<StringBuilder> = v17_0_2.clone();
                        let v19: string = v17_0_1.clone();
                        let v88: Documents::US12 = if string("") == v19.clone() {
                            Documents::US12::US12_1(sprintf!(
                                "parsing.none_of / unexpected end of input / chars: {:?} / s: {:?}",
                                toArray(ofArray(new_array(&['\"', '\'']))),
                                (v20.clone(), v21, v22)
                            ))
                        } else {
                            let v37: char = getCharAt(v19.clone(), 0_i32);
                            let v44: string =
                                getSlice(v19.clone(), Some(1_i32), Some(length(v19.clone())));
                            if Documents::method45(v37, 0_i64) == false {
                                let v49: string = ofChar(v37);
                                let v52: i32 = length(v49.clone());
                                let v53: Array<char> = new_init(&'\u{0000}', v52);
                                let v54: LrcPtr<Documents::Mut6> = LrcPtr::new(Documents::Mut6 {
                                    l0: MutCell::new(0_i32),
                                });
                                while Documents::method28(v52, v54.clone()) {
                                    let v56: i32 = v54.l0.get().clone();
                                    let v57: char = getCharAt(v49.clone(), v56);
                                    v53.get_mut()[v56 as usize] = v57;
                                    {
                                        let v58: i32 = v56 + 1_i32;
                                        v54.l0.set(v58);
                                        ()
                                    }
                                }
                                {
                                    let v59: List<char> = ofArray(v53.clone());
                                    let patternInput: (LrcPtr<StringBuilder>, i32, i32) =
                                        Documents::method43(
                                            foldBack(
                                                Func2::new(
                                                    move |b0: char, b1: LrcPtr<Documents::UH0>| {
                                                        (Documents::method42())(b0)(b1)
                                                    },
                                                ),
                                                v59,
                                                LrcPtr::new(Documents::UH0::UH0_0),
                                            ),
                                            v20.clone(),
                                            v21,
                                            v22,
                                        );
                                    Documents::US12::US12_0(
                                        v37,
                                        v44,
                                        patternInput.0.clone(),
                                        patternInput.1.clone(),
                                        patternInput.2.clone(),
                                    )
                                }
                            } else {
                                Documents::US12::US12_1(sprintf!("parsing.none_of / unexpected char: \'{}\' / chars: {:?} / s: {:?}",
                                                                         v37,
                                                                         toArray(ofArray(new_array(&['\"',
                                                                                                     '\'']))),
                                                                         (v20.clone(),
                                                                          v21,
                                                                          v22)))
                            }
                        };
                        let v100: Documents::US12 = match &v88 {
                            Documents::US12::US12_0(
                                v88_0_0,
                                v88_0_1,
                                v88_0_2,
                                v88_0_3,
                                v88_0_4,
                            ) => {
                                let v89: char = v88_0_0.clone();
                                Documents::US12::US12_0(
                                    if '\\' == v89 { '/' } else { v89 },
                                    v88_0_1.clone(),
                                    v88_0_2.clone(),
                                    v88_0_3.clone(),
                                    v88_0_4.clone(),
                                )
                            }
                            Documents::US12::US12_1(v88_1_0) => {
                                Documents::US12::US12_1(v88_1_0.clone())
                            }
                        };
                        let v114: Documents::US13 = match &v100 {
                            Documents::US12::US12_0(
                                v100_0_0,
                                v100_0_1,
                                v100_0_2,
                                v100_0_3,
                                v100_0_4,
                            ) => Documents::method46(
                                ofChar(v100_0_0.clone()),
                                v100_0_1.clone(),
                                v100_0_2.clone(),
                                v100_0_3.clone(),
                                v100_0_4.clone(),
                            ),
                            Documents::US12::US12_1(v100_1_0) => {
                                Documents::US13::US13_1(v100_1_0.clone())
                            }
                        };
                        let v124: Documents::US13 = match &v114 {
                            Documents::US13::US13_0(
                                v114_0_0,
                                v114_0_1,
                                v114_0_2,
                                v114_0_3,
                                v114_0_4,
                            ) => Documents::US13::US13_0(
                                v114_0_0.clone(),
                                v114_0_1.clone(),
                                v114_0_2.clone(),
                                v114_0_3.clone(),
                                v114_0_4.clone(),
                            ),
                            _ => Documents::US13::US13_0(
                                string(""),
                                v19.clone(),
                                v20.clone(),
                                v21,
                                v22,
                            ),
                        };
                        match &v124 {
                            Documents::US13::US13_0(
                                v124_0_0,
                                v124_0_1,
                                v124_0_2,
                                v124_0_3,
                                v124_0_4,
                            ) => {
                                let v129: i32 = v124_0_4.clone();
                                let v128: i32 = v124_0_3.clone();
                                let v127: LrcPtr<StringBuilder> = v124_0_2.clone();
                                let v126: string = v124_0_1.clone();
                                let v133: Documents::US12 = Documents::method47(
                                    v126.clone(),
                                    v127.clone(),
                                    v128,
                                    v129,
                                    LrcPtr::new(Documents::UH1::UH1_1(
                                        Func1::from(v12),
                                        LrcPtr::new(Documents::UH1::UH1_1(
                                            Func1::from(v13),
                                            LrcPtr::new(Documents::UH1::UH1_0),
                                        )),
                                    )),
                                );
                                match &v133 {
                                        Documents::US12::US12_0(v133_0_0,
                                                                v133_0_1,
                                                                v133_0_2,
                                                                v133_0_3,
                                                                v133_0_4) =>
                                        Documents::US13::US13_0(v124_0_0.clone(),
                                                                v133_0_1.clone(),
                                                                v133_0_2.clone(),
                                                                v133_0_3.clone(),
                                                                v133_0_4.clone()),
                                        Documents::US12::US12_1(v133_1_0) =>
                                        Documents::US13::US13_1(sprintf!("between / expected closing delimiter / e: {:?} / input: {:?} / rest1: {:?} / rest2: {:?}",
                                                                         v133_1_0.clone(),
                                                                         (v7.clone(),
                                                                          v11.clone(),
                                                                          1_i32,
                                                                          1_i32),
                                                                         (v19,
                                                                          v20,
                                                                          v21,
                                                                          v22),
                                                                         (v126,
                                                                          v127,
                                                                          v128,
                                                                          v129))),
                                    }
                            }
                            _ => Documents::US13::US13_1(string("between / expected content")),
                        }
                    }
                    Documents::US12::US12_1(v17_1_0) => Documents::US13::US13_1(v17_1_0.clone()),
                };
                let v303: Documents::US13 = match &v153 {
                    Documents::US13::US13_0(v153_0_0, v153_0_1, v153_0_2, v153_0_3, v153_0_4) => {
                        v153.clone()
                    }
                    _ => {
                        let v233: Documents::US12 = if string("") == v7.clone() {
                            Documents::US12::US12_1(sprintf!(
                                "parsing.none_of / unexpected end of input / chars: {:?} / s: {:?}",
                                toArray(ofArray(new_array(&['\"', '\'', ' ']))),
                                (v11.clone(), 1_i32, 1_i32)
                            ))
                        } else {
                            let v177: char = getCharAt(v7.clone(), 0_i32);
                            let v184: string =
                                getSlice(v7.clone(), Some(1_i32), Some(length(v7.clone())));
                            if Documents::method48(v177, 0_i64) == false {
                                let v189: string = ofChar(v177);
                                let v192: i32 = length(v189.clone());
                                let v193: Array<char> = new_init(&'\u{0000}', v192);
                                let v194: LrcPtr<Documents::Mut6> = LrcPtr::new(Documents::Mut6 {
                                    l0: MutCell::new(0_i32),
                                });
                                while Documents::method28(v192, v194.clone()) {
                                    let v196: i32 = v194.l0.get().clone();
                                    let v197: char = getCharAt(v189.clone(), v196);
                                    v193.get_mut()[v196 as usize] = v197;
                                    {
                                        let v198: i32 = v196 + 1_i32;
                                        v194.l0.set(v198);
                                        ()
                                    }
                                }
                                {
                                    let v199: List<char> = ofArray(v193.clone());
                                    let patternInput_1: (LrcPtr<StringBuilder>, i32, i32) =
                                        Documents::method43(
                                            foldBack(
                                                Func2::new(
                                                    move |b0: char, b1: LrcPtr<Documents::UH0>| {
                                                        (Documents::method42())(b0)(b1)
                                                    },
                                                ),
                                                v199,
                                                LrcPtr::new(Documents::UH0::UH0_0),
                                            ),
                                            v11.clone(),
                                            1_i32,
                                            1_i32,
                                        );
                                    Documents::US12::US12_0(
                                        v177,
                                        v184,
                                        patternInput_1.0.clone(),
                                        patternInput_1.1.clone(),
                                        patternInput_1.2.clone(),
                                    )
                                }
                            } else {
                                Documents::US12::US12_1(sprintf!("parsing.none_of / unexpected char: \'{}\' / chars: {:?} / s: {:?}",
                                                                         v177,
                                                                         toArray(ofArray(new_array(&['\"',
                                                                                                     '\'',
                                                                                                     ' ']))),
                                                                         (v11.clone(),
                                                                          1_i32,
                                                                          1_i32)))
                            }
                        };
                        let v245: Documents::US12 = match &v233 {
                            Documents::US12::US12_0(
                                v233_0_0,
                                v233_0_1,
                                v233_0_2,
                                v233_0_3,
                                v233_0_4,
                            ) => {
                                let v234: char = v233_0_0.clone();
                                Documents::US12::US12_0(
                                    if '\\' == v234 { '/' } else { v234 },
                                    v233_0_1.clone(),
                                    v233_0_2.clone(),
                                    v233_0_3.clone(),
                                    v233_0_4.clone(),
                                )
                            }
                            Documents::US12::US12_1(v233_1_0) => {
                                Documents::US12::US12_1(v233_1_0.clone())
                            }
                        };
                        let v259: Documents::US13 = match &v245 {
                            Documents::US12::US12_0(
                                v245_0_0,
                                v245_0_1,
                                v245_0_2,
                                v245_0_3,
                                v245_0_4,
                            ) => Documents::method49(
                                ofChar(v245_0_0.clone()),
                                v245_0_1.clone(),
                                v245_0_2.clone(),
                                v245_0_3.clone(),
                                v245_0_4.clone(),
                            ),
                            Documents::US12::US12_1(v245_1_0) => {
                                Documents::US13::US13_1(v245_1_0.clone())
                            }
                        };
                        match &v259 {
                            Documents::US13::US13_0(
                                v259_0_0,
                                v259_0_1,
                                v259_0_2,
                                v259_0_3,
                                v259_0_4,
                            ) => v259.clone(),
                            _ => {
                                let v271: Documents::US15 = if length(v7.clone()) == 0_i32 {
                                    Documents::US15::US15_0(v7.clone(), v11.clone(), 1_i32, 1_i32)
                                } else {
                                    Documents::US15::US15_1(sprintf!(
                                        "parsing.eof / expected end of input / input: {:?}",
                                        v7.clone()
                                    ))
                                };
                                let v280: Documents::US13 = match &v271 {
                                    Documents::US15::US15_0(
                                        v271_0_0,
                                        v271_0_1,
                                        v271_0_2,
                                        v271_0_3,
                                    ) => Documents::US13::US13_0(
                                        string(""),
                                        v271_0_0.clone(),
                                        v271_0_1.clone(),
                                        v271_0_2.clone(),
                                        v271_0_3.clone(),
                                    ),
                                    Documents::US15::US15_1(v271_1_0) => {
                                        Documents::US13::US13_1(v271_1_0.clone())
                                    }
                                };
                                match &v280 {
                                    Documents::US13::US13_0(
                                        v280_0_0,
                                        v280_0_1,
                                        v280_0_2,
                                        v280_0_3,
                                        v280_0_4,
                                    ) => {
                                        let v282: string = v280_0_1.clone();
                                        Documents::US13::US13_0(
                                            v280_0_0.clone(),
                                            getSlice(
                                                v282.clone(),
                                                Some(Documents::method50(v282.clone(), 0_i32)),
                                                Some(length(v282)),
                                            ),
                                            v280_0_2.clone(),
                                            v280_0_3.clone(),
                                            v280_0_4.clone(),
                                        )
                                    }
                                    Documents::US13::US13_1(v280_1_0) => {
                                        Documents::US13::US13_1(v280_1_0.clone())
                                    }
                                }
                            }
                        }
                    }
                };
                let v471: Documents::US16 = match &v303 {
                    Documents::US13::US13_0(v303_0_0, v303_0_1, v303_0_2, v303_0_3, v303_0_4) => {
                        let v308: i32 = v303_0_4.clone();
                        let v307: i32 = v303_0_3.clone();
                        let v306: LrcPtr<StringBuilder> = v303_0_2.clone();
                        let v305: string = v303_0_1.clone();
                        let v372: Documents::US12 = if string("") == v305.clone() {
                            Documents::US12::US12_1(sprintf!(
                                "parsing.p_char / unexpected end of input / s: {:?}",
                                (v306.clone(), v307, v308)
                            ))
                        } else {
                            let v312: char = getCharAt(v305.clone(), 0_i32);
                            if v312 == ' ' {
                                let v320: string =
                                    getSlice(v305.clone(), Some(1_i32), Some(length(v305.clone())));
                                let v322: string = ofChar(v312);
                                let v325: i32 = length(v322.clone());
                                let v326: Array<char> = new_init(&'\u{0000}', v325);
                                let v327: LrcPtr<Documents::Mut6> = LrcPtr::new(Documents::Mut6 {
                                    l0: MutCell::new(0_i32),
                                });
                                while Documents::method28(v325, v327.clone()) {
                                    let v329: i32 = v327.l0.get().clone();
                                    let v330: char = getCharAt(v322.clone(), v329);
                                    v326.get_mut()[v329 as usize] = v330;
                                    {
                                        let v331: i32 = v329 + 1_i32;
                                        v327.l0.set(v331);
                                        ()
                                    }
                                }
                                {
                                    let v332: List<char> = ofArray(v326.clone());
                                    let patternInput_2: (LrcPtr<StringBuilder>, i32, i32) =
                                        Documents::method43(
                                            foldBack(
                                                Func2::new(
                                                    move |b0: char, b1: LrcPtr<Documents::UH0>| {
                                                        (Documents::method42())(b0)(b1)
                                                    },
                                                ),
                                                v332,
                                                LrcPtr::new(Documents::UH0::UH0_0),
                                            ),
                                            v306.clone(),
                                            v307,
                                            v308,
                                        );
                                    Documents::US12::US12_0(
                                        v312,
                                        v320,
                                        patternInput_2.0.clone(),
                                        patternInput_2.1.clone(),
                                        patternInput_2.2.clone(),
                                    )
                                }
                            } else {
                                let v348: i32 = length(v305.clone());
                                let v351: i32 = indexOf(v305.clone(), string("\n")) - 1_i32;
                                Documents::US12::US12_1(sprintf!("{}\n{}\n",
                                                                         sprintf!("parsing.p_char / expected: \'{}\' / line: {} / col: {}\n{}{}",
                                                                                  ' ',
                                                                                  v307,
                                                                                  v308,
                                                                                  v306.clone(),
                                                                                  getSlice(v305.clone(),
                                                                                           Some(0_i32),
                                                                                           Some(if -2_i32
                                                                                                       ==
                                                                                                       v351
                                                                                                   {
                                                                                                    v348
                                                                                                } else {
                                                                                                    v351
                                                                                                }))),
                                                                         append(replicate(v308
                                                                                              -
                                                                                              1_i32,
                                                                                          string(" ")),
                                                                                string("^"))))
                            }
                        };
                        let v384: Documents::US17 = match &v372 {
                            Documents::US12::US12_0(
                                v372_0_0,
                                v372_0_1,
                                v372_0_2,
                                v372_0_3,
                                v372_0_4,
                            ) => Documents::US17::US17_0(
                                Documents::US14::US14_0(v372_0_0.clone()),
                                v372_0_1.clone(),
                                v372_0_2.clone(),
                                v372_0_3.clone(),
                                v372_0_4.clone(),
                            ),
                            _ => Documents::US17::US17_0(
                                Documents::US14::US14_1,
                                v305.clone(),
                                v306.clone(),
                                v307,
                                v308,
                            ),
                        };
                        let v445: Documents::US13 = match &v384 {
                            Documents::US17::US17_0(
                                v384_0_0,
                                v384_0_1,
                                v384_0_2,
                                v384_0_3,
                                v384_0_4,
                            ) => {
                                let v389: i32 = v384_0_4.clone();
                                let v388: i32 = v384_0_3.clone();
                                let v387: LrcPtr<StringBuilder> = v384_0_2.clone();
                                let v386: string = v384_0_1.clone();
                                let v427: Documents::US12 = if string("") == v386.clone() {
                                    Documents::US12::US12_1(sprintf!(
                                        "parsing.any_char / unexpected end of input / s: {:?}",
                                        (v387.clone(), v388, v389)
                                    ))
                                } else {
                                    let v393: char = getCharAt(v386.clone(), 0_i32);
                                    let v400: string =
                                        getSlice(v386.clone(), Some(1_i32), Some(length(v386)));
                                    let v402: string = ofChar(v393);
                                    let v405: i32 = length(v402.clone());
                                    let v406: Array<char> = new_init(&'\u{0000}', v405);
                                    let v407: LrcPtr<Documents::Mut6> =
                                        LrcPtr::new(Documents::Mut6 {
                                            l0: MutCell::new(0_i32),
                                        });
                                    while Documents::method28(v405, v407.clone()) {
                                        let v409: i32 = v407.l0.get().clone();
                                        let v410: char = getCharAt(v402.clone(), v409);
                                        v406.get_mut()[v409 as usize] = v410;
                                        {
                                            let v411: i32 = v409 + 1_i32;
                                            v407.l0.set(v411);
                                            ()
                                        }
                                    }
                                    {
                                        let v412: List<char> = ofArray(v406.clone());
                                        let patternInput_3:
                                                            (LrcPtr<StringBuilder>,
                                                             i32, i32) =
                                                        Documents::method43(foldBack(Func2::new(move
                                                                                                    |b0:
                                                                                                         char,
                                                                                                     b1:
                                                                                                         LrcPtr<Documents::UH0>|
                                                                                                    (Documents::method42())(b0)(b1)),
                                                                                     v412,
                                                                                     LrcPtr::new(Documents::UH0::UH0_0)),
                                                                            v387,
                                                                            v388,
                                                                            v389);
                                        Documents::US12::US12_0(
                                            v393,
                                            v400,
                                            patternInput_3.0.clone(),
                                            patternInput_3.1.clone(),
                                            patternInput_3.2.clone(),
                                        )
                                    }
                                };
                                match &v427 {
                                    Documents::US12::US12_0(
                                        v427_0_0,
                                        v427_0_1,
                                        v427_0_2,
                                        v427_0_3,
                                        v427_0_4,
                                    ) => Documents::method51(
                                        ofChar(v427_0_0.clone()),
                                        v427_0_1.clone(),
                                        v427_0_2.clone(),
                                        v427_0_3.clone(),
                                        v427_0_4.clone(),
                                    ),
                                    Documents::US12::US12_1(v427_1_0) => {
                                        Documents::US13::US13_1(v427_1_0.clone())
                                    }
                                }
                            }
                            Documents::US17::US17_1(v384_1_0) => {
                                Documents::US13::US13_1(v384_1_0.clone())
                            }
                        };
                        let v457: Documents::US18 = match &v445 {
                            Documents::US13::US13_0(
                                v445_0_0,
                                v445_0_1,
                                v445_0_2,
                                v445_0_3,
                                v445_0_4,
                            ) => Documents::US18::US18_0(
                                Documents::US1::US1_0(v445_0_0.clone()),
                                v445_0_1.clone(),
                                v445_0_2.clone(),
                                v445_0_3.clone(),
                                v445_0_4.clone(),
                            ),
                            _ => Documents::US18::US18_0(
                                Documents::US1::US1_1,
                                v305,
                                v306,
                                v307,
                                v308,
                            ),
                        };
                        match &v457 {
                            Documents::US18::US18_0(
                                v457_0_0,
                                v457_0_1,
                                v457_0_2,
                                v457_0_3,
                                v457_0_4,
                            ) => Documents::US16::US16_0(
                                v303_0_0.clone(),
                                v457_0_0.clone(),
                                v457_0_1.clone(),
                                v457_0_2.clone(),
                                v457_0_3.clone(),
                                v457_0_4.clone(),
                            ),
                            Documents::US18::US18_1(v457_1_0) => {
                                Documents::US16::US16_1(v457_1_0.clone())
                            }
                        }
                    }
                    Documents::US13::US13_1(v303_1_0) => Documents::US16::US16_1(v303_1_0.clone()),
                };
                match &v471 {
                    Documents::US16::US16_0(
                        v471_0_0,
                        v471_0_1,
                        v471_0_2,
                        v471_0_3,
                        v471_0_4,
                        v471_0_5,
                    ) => Documents::US11::US11_0(v471_0_0.clone(), v471_0_1.clone()),
                    Documents::US16::US16_1(v471_1_0) => Documents::US11::US11_1(v471_1_0.clone()),
                }
            }
        }
        pub fn method54(v0_1: char, v1_1: i64) -> bool {
            let v0_1: MutCell<char> = MutCell::new(v0_1);
            let v1_1: MutCell<i64> = MutCell::new(v1_1);
            '_method54: loop {
                break '_method54 (if v1_1.get().clone() >= 4_i64 {
                    false
                } else {
                    let v19: Documents::US14 = if v1_1.get().clone() == 0_i64 {
                        Documents::US14::US14_0('\\')
                    } else {
                        let v5: i64 = v1_1.get().clone() - 1_i64;
                        if v5 == 0_i64 {
                            Documents::US14::US14_0('`')
                        } else {
                            let v8: i64 = v5 - 1_i64;
                            if v8 == 0_i64 {
                                Documents::US14::US14_0('\"')
                            } else {
                                let v11: i64 = v8 - 1_i64;
                                if v11 == 0_i64 {
                                    Documents::US14::US14_0(' ')
                                } else {
                                    let v14: i64 = v11 - 1_i64;
                                    Documents::US14::US14_1
                                }
                            }
                        }
                    };
                    if v0_1.get().clone()
                        == match &v19 {
                            Documents::US14::US14_0(v19_0_0) => match &v19 {
                                Documents::US14::US14_0(x) => x.clone(),
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
                        continue '_method54;
                    }
                });
            }
        }
        pub fn method55(
            v0_1: string,
            v1_1: string,
            v2: LrcPtr<StringBuilder>,
            v3: i32,
            v4: i32,
        ) -> Documents::US13 {
            let v0_1: MutCell<string> = MutCell::new(v0_1.clone());
            let v1_1: MutCell<string> = MutCell::new(v1_1.clone());
            let v2: MutCell<LrcPtr<StringBuilder>> = MutCell::new(v2.clone());
            let v3: MutCell<i32> = MutCell::new(v3);
            let v4: MutCell<i32> = MutCell::new(v4);
            '_method55: loop {
                break '_method55 ({
                    let v82: Documents::US12 = if string("") == v1_1.get().clone() {
                        Documents::US12::US12_1(sprintf!(
                            "parsing.none_of / unexpected end of input / chars: {:?} / s: {:?}",
                            toArray(ofArray(new_array(&['\\', '`', '\"', ' ']))),
                            (v2.get().clone(), v3.get().clone(), v4.get().clone())
                        ))
                    } else {
                        let v25: char = getCharAt(v1_1.get().clone(), 0_i32);
                        let v32: string = getSlice(
                            v1_1.get().clone(),
                            Some(1_i32),
                            Some(length(v1_1.get().clone())),
                        );
                        if Documents::method54(v25, 0_i64) == false {
                            let v37: string = ofChar(v25);
                            let v40: i32 = length(v37.clone());
                            let v41: Array<char> = new_init(&'\u{0000}', v40);
                            let v42: LrcPtr<Documents::Mut6> = LrcPtr::new(Documents::Mut6 {
                                l0: MutCell::new(0_i32),
                            });
                            while Documents::method28(v40, v42.clone()) {
                                let v44: i32 = v42.l0.get().clone();
                                let v45: char = getCharAt(v37.clone(), v44);
                                v41.get_mut()[v44 as usize] = v45;
                                {
                                    let v46: i32 = v44 + 1_i32;
                                    v42.l0.set(v46);
                                    ()
                                }
                            }
                            {
                                let v47: List<char> = ofArray(v41.clone());
                                let patternInput: (LrcPtr<StringBuilder>, i32, i32) =
                                    Documents::method43(
                                        foldBack(
                                            Func2::new(
                                                move |b0: char, b1: LrcPtr<Documents::UH0>| {
                                                    (Documents::method42())(b0)(b1)
                                                },
                                            ),
                                            v47,
                                            LrcPtr::new(Documents::UH0::UH0_0),
                                        ),
                                        v2.get().clone(),
                                        v3.get().clone(),
                                        v4.get().clone(),
                                    );
                                Documents::US12::US12_0(
                                    v25,
                                    v32,
                                    patternInput.0.clone(),
                                    patternInput.1.clone(),
                                    patternInput.2.clone(),
                                )
                            }
                        } else {
                            Documents::US12::US12_1(sprintf!(
                                "parsing.none_of / unexpected char: \'{}\' / chars: {:?} / s: {:?}",
                                v25,
                                toArray(ofArray(new_array(&['\\', '`', '\"', ' ']))),
                                (v2.get().clone(), v3.get().clone(), v4.get().clone())
                            ))
                        }
                    };
                    match &v82 {
                        Documents::US12::US12_0(v82_0_0, v82_0_1, v82_0_2, v82_0_3, v82_0_4) => {
                            let v0_1_temp: string =
                                append(v0_1.get().clone(), ofChar(v82_0_0.clone()));
                            let v1_1_temp: string = v82_0_1.clone();
                            let v2_temp: LrcPtr<StringBuilder> = v82_0_2.clone();
                            let v3_temp: i32 = v82_0_3.clone();
                            let v4_temp: i32 = v82_0_4.clone();
                            v0_1.set(v0_1_temp);
                            v1_1.set(v1_1_temp);
                            v2.set(v2_temp);
                            v3.set(v3_temp);
                            v4.set(v4_temp);
                            continue '_method55;
                        }
                        _ => Documents::US13::US13_0(
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
        pub fn method57(v0_1: char, v1_1: i64) -> bool {
            let v0_1: MutCell<char> = MutCell::new(v0_1);
            let v1_1: MutCell<i64> = MutCell::new(v1_1);
            '_method57: loop {
                break '_method57 (if v1_1.get().clone() >= 3_i64 {
                    false
                } else {
                    let v15: Documents::US14 = if v1_1.get().clone() == 0_i64 {
                        Documents::US14::US14_0('\\')
                    } else {
                        let v5: i64 = v1_1.get().clone() - 1_i64;
                        if v5 == 0_i64 {
                            Documents::US14::US14_0('`')
                        } else {
                            let v8: i64 = v5 - 1_i64;
                            if v8 == 0_i64 {
                                Documents::US14::US14_0('\"')
                            } else {
                                let v11: i64 = v8 - 1_i64;
                                Documents::US14::US14_1
                            }
                        }
                    };
                    if v0_1.get().clone()
                        == match &v15 {
                            Documents::US14::US14_0(v15_0_0) => match &v15 {
                                Documents::US14::US14_0(x) => x.clone(),
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
                        continue '_method57;
                    }
                });
            }
        }
        pub fn closure34(
            unitVar: (),
            _arg: (string, LrcPtr<StringBuilder>, i32, i32),
        ) -> Documents::US13 {
            let v3: i32 = _arg.3.clone();
            let v2: i32 = _arg.2.clone();
            let v1_1: LrcPtr<StringBuilder> = _arg.1.clone();
            let v0_1: string = _arg.0.clone();
            let v67: Documents::US12 = if string("") == v0_1.clone() {
                Documents::US12::US12_1(sprintf!(
                    "parsing.p_char / unexpected end of input / s: {:?}",
                    (v1_1.clone(), v2, v3)
                ))
            } else {
                let v7: char = getCharAt(v0_1.clone(), 0_i32);
                if v7 == '\\' {
                    let v15: string =
                        getSlice(v0_1.clone(), Some(1_i32), Some(length(v0_1.clone())));
                    let v17: string = ofChar(v7);
                    let v20: i32 = length(v17.clone());
                    let v21: Array<char> = new_init(&'\u{0000}', v20);
                    let v22: LrcPtr<Documents::Mut6> = LrcPtr::new(Documents::Mut6 {
                        l0: MutCell::new(0_i32),
                    });
                    while Documents::method28(v20, v22.clone()) {
                        let v24: i32 = v22.l0.get().clone();
                        let v25: char = getCharAt(v17.clone(), v24);
                        v21.get_mut()[v24 as usize] = v25;
                        {
                            let v26: i32 = v24 + 1_i32;
                            v22.l0.set(v26);
                            ()
                        }
                    }
                    {
                        let v27: List<char> = ofArray(v21.clone());
                        let patternInput: (LrcPtr<StringBuilder>, i32, i32) = Documents::method43(
                            foldBack(
                                Func2::new(move |b0: char, b1: LrcPtr<Documents::UH0>| {
                                    (Documents::method42())(b0)(b1)
                                }),
                                v27,
                                LrcPtr::new(Documents::UH0::UH0_0),
                            ),
                            v1_1.clone(),
                            v2,
                            v3,
                        );
                        Documents::US12::US12_0(
                            v7,
                            v15,
                            patternInput.0.clone(),
                            patternInput.1.clone(),
                            patternInput.2.clone(),
                        )
                    }
                } else {
                    let v43: i32 = length(v0_1.clone());
                    let v46: i32 = indexOf(v0_1.clone(), string("\n")) - 1_i32;
                    Documents::US12::US12_1(sprintf!(
                        "{}\n{}\n",
                        sprintf!(
                            "parsing.p_char / expected: \'{}\' / line: {} / col: {}\n{}{}",
                            '\\',
                            v2,
                            v3,
                            v1_1,
                            getSlice(
                                v0_1,
                                Some(0_i32),
                                Some(if -2_i32 == v46 { v43 } else { v46 })
                            )
                        ),
                        append(replicate(v3 - 1_i32, string(" ")), string("^"))
                    ))
                }
            };
            let v114: Documents::US12 = match &v67 {
                Documents::US12::US12_0(v67_0_0, v67_0_1, v67_0_2, v67_0_3, v67_0_4) => {
                    let v72: i32 = v67_0_4.clone();
                    let v71: i32 = v67_0_3.clone();
                    let v70: LrcPtr<StringBuilder> = v67_0_2.clone();
                    let v69: string = v67_0_1.clone();
                    if string("") == v69.clone() {
                        Documents::US12::US12_1(sprintf!(
                            "parsing.any_char / unexpected end of input / s: {:?}",
                            (v70.clone(), v71, v72)
                        ))
                    } else {
                        let v76: char = getCharAt(v69.clone(), 0_i32);
                        let v83: string = getSlice(v69.clone(), Some(1_i32), Some(length(v69)));
                        let v85: string = ofChar(v76);
                        let v88: i32 = length(v85.clone());
                        let v89: Array<char> = new_init(&'\u{0000}', v88);
                        let v90: LrcPtr<Documents::Mut6> = LrcPtr::new(Documents::Mut6 {
                            l0: MutCell::new(0_i32),
                        });
                        while Documents::method28(v88, v90.clone()) {
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
                            let v95: List<char> = ofArray(v89.clone());
                            let patternInput_1: (LrcPtr<StringBuilder>, i32, i32) =
                                Documents::method43(
                                    foldBack(
                                        Func2::new(move |b0: char, b1: LrcPtr<Documents::UH0>| {
                                            (Documents::method42())(b0)(b1)
                                        }),
                                        v95,
                                        LrcPtr::new(Documents::UH0::UH0_0),
                                    ),
                                    v70,
                                    v71,
                                    v72,
                                );
                            Documents::US12::US12_0(
                                v76,
                                v83,
                                patternInput_1.0.clone(),
                                patternInput_1.1.clone(),
                                patternInput_1.2.clone(),
                            )
                        }
                    }
                }
                Documents::US12::US12_1(v67_1_0) => Documents::US12::US12_1(v67_1_0.clone()),
            };
            match &v114 {
                Documents::US12::US12_0(v114_0_0, v114_0_1, v114_0_2, v114_0_3, v114_0_4) => {
                    Documents::US13::US13_0(
                        sprintf!("{}{}", '\\', v114_0_0.clone()),
                        v114_0_1.clone(),
                        v114_0_2.clone(),
                        v114_0_3.clone(),
                        v114_0_4.clone(),
                    )
                }
                Documents::US12::US12_1(v114_1_0) => Documents::US13::US13_1(v114_1_0.clone()),
            }
        }
        pub fn closure35(
            unitVar: (),
            _arg: (string, LrcPtr<StringBuilder>, i32, i32),
        ) -> Documents::US13 {
            let v3: i32 = _arg.3.clone();
            let v2: i32 = _arg.2.clone();
            let v1_1: LrcPtr<StringBuilder> = _arg.1.clone();
            let v0_1: string = _arg.0.clone();
            let v67: Documents::US12 = if string("") == v0_1.clone() {
                Documents::US12::US12_1(sprintf!(
                    "parsing.p_char / unexpected end of input / s: {:?}",
                    (v1_1.clone(), v2, v3)
                ))
            } else {
                let v7: char = getCharAt(v0_1.clone(), 0_i32);
                if v7 == '`' {
                    let v15: string =
                        getSlice(v0_1.clone(), Some(1_i32), Some(length(v0_1.clone())));
                    let v17: string = ofChar(v7);
                    let v20: i32 = length(v17.clone());
                    let v21: Array<char> = new_init(&'\u{0000}', v20);
                    let v22: LrcPtr<Documents::Mut6> = LrcPtr::new(Documents::Mut6 {
                        l0: MutCell::new(0_i32),
                    });
                    while Documents::method28(v20, v22.clone()) {
                        let v24: i32 = v22.l0.get().clone();
                        let v25: char = getCharAt(v17.clone(), v24);
                        v21.get_mut()[v24 as usize] = v25;
                        {
                            let v26: i32 = v24 + 1_i32;
                            v22.l0.set(v26);
                            ()
                        }
                    }
                    {
                        let v27: List<char> = ofArray(v21.clone());
                        let patternInput: (LrcPtr<StringBuilder>, i32, i32) = Documents::method43(
                            foldBack(
                                Func2::new(move |b0: char, b1: LrcPtr<Documents::UH0>| {
                                    (Documents::method42())(b0)(b1)
                                }),
                                v27,
                                LrcPtr::new(Documents::UH0::UH0_0),
                            ),
                            v1_1.clone(),
                            v2,
                            v3,
                        );
                        Documents::US12::US12_0(
                            v7,
                            v15,
                            patternInput.0.clone(),
                            patternInput.1.clone(),
                            patternInput.2.clone(),
                        )
                    }
                } else {
                    let v43: i32 = length(v0_1.clone());
                    let v46: i32 = indexOf(v0_1.clone(), string("\n")) - 1_i32;
                    Documents::US12::US12_1(sprintf!(
                        "{}\n{}\n",
                        sprintf!(
                            "parsing.p_char / expected: \'{}\' / line: {} / col: {}\n{}{}",
                            '`',
                            v2,
                            v3,
                            v1_1,
                            getSlice(
                                v0_1,
                                Some(0_i32),
                                Some(if -2_i32 == v46 { v43 } else { v46 })
                            )
                        ),
                        append(replicate(v3 - 1_i32, string(" ")), string("^"))
                    ))
                }
            };
            let v114: Documents::US12 = match &v67 {
                Documents::US12::US12_0(v67_0_0, v67_0_1, v67_0_2, v67_0_3, v67_0_4) => {
                    let v72: i32 = v67_0_4.clone();
                    let v71: i32 = v67_0_3.clone();
                    let v70: LrcPtr<StringBuilder> = v67_0_2.clone();
                    let v69: string = v67_0_1.clone();
                    if string("") == v69.clone() {
                        Documents::US12::US12_1(sprintf!(
                            "parsing.any_char / unexpected end of input / s: {:?}",
                            (v70.clone(), v71, v72)
                        ))
                    } else {
                        let v76: char = getCharAt(v69.clone(), 0_i32);
                        let v83: string = getSlice(v69.clone(), Some(1_i32), Some(length(v69)));
                        let v85: string = ofChar(v76);
                        let v88: i32 = length(v85.clone());
                        let v89: Array<char> = new_init(&'\u{0000}', v88);
                        let v90: LrcPtr<Documents::Mut6> = LrcPtr::new(Documents::Mut6 {
                            l0: MutCell::new(0_i32),
                        });
                        while Documents::method28(v88, v90.clone()) {
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
                            let v95: List<char> = ofArray(v89.clone());
                            let patternInput_1: (LrcPtr<StringBuilder>, i32, i32) =
                                Documents::method43(
                                    foldBack(
                                        Func2::new(move |b0: char, b1: LrcPtr<Documents::UH0>| {
                                            (Documents::method42())(b0)(b1)
                                        }),
                                        v95,
                                        LrcPtr::new(Documents::UH0::UH0_0),
                                    ),
                                    v70,
                                    v71,
                                    v72,
                                );
                            Documents::US12::US12_0(
                                v76,
                                v83,
                                patternInput_1.0.clone(),
                                patternInput_1.1.clone(),
                                patternInput_1.2.clone(),
                            )
                        }
                    }
                }
                Documents::US12::US12_1(v67_1_0) => Documents::US12::US12_1(v67_1_0.clone()),
            };
            match &v114 {
                Documents::US12::US12_0(v114_0_0, v114_0_1, v114_0_2, v114_0_3, v114_0_4) => {
                    Documents::US13::US13_0(
                        sprintf!("{}{}", '`', v114_0_0.clone()),
                        v114_0_1.clone(),
                        v114_0_2.clone(),
                        v114_0_3.clone(),
                        v114_0_4.clone(),
                    )
                }
                Documents::US12::US12_1(v114_1_0) => Documents::US13::US13_1(v114_1_0.clone()),
            }
        }
        pub fn method58(
            v0_1: string,
            v1_1: LrcPtr<StringBuilder>,
            v2: i32,
            v3: i32,
            v4: LrcPtr<Documents::UH3>,
        ) -> Documents::US13 {
            let v0_1: MutCell<string> = MutCell::new(v0_1.clone());
            let v1_1: MutCell<LrcPtr<StringBuilder>> = MutCell::new(v1_1.clone());
            let v2: MutCell<i32> = MutCell::new(v2);
            let v3: MutCell<i32> = MutCell::new(v3);
            let v4: MutCell<LrcPtr<Documents::UH3>> = MutCell::new(v4.clone());
            '_method58: loop {
                break '_method58 (match v4.get().clone().as_ref() {
                    Documents::UH3::UH3_0 => {
                        Documents::US13::US13_1(string("choice / no parsers succeeded"))
                    }
                    Documents::UH3::UH3_1(v4_1_0, v4_1_1) => {
                        let v9: Documents::US13 = (match v4.get().clone().as_ref() {
                            Documents::UH3::UH3_1(x, _) => x.clone(),
                            _ => unreachable!(),
                        })((
                            v0_1.get().clone(),
                            v1_1.get().clone(),
                            v2.get().clone(),
                            v3.get().clone(),
                        ));
                        match &v9 {
                            Documents::US13::US13_0(v9_0_0, v9_0_1, v9_0_2, v9_0_3, v9_0_4) => {
                                v9.clone()
                            }
                            _ => {
                                let v0_1_temp: string = v0_1.get().clone();
                                let v1_1_temp: LrcPtr<StringBuilder> = v1_1.get().clone();
                                let v2_temp: i32 = v2.get().clone();
                                let v3_temp: i32 = v3.get().clone();
                                let v4_temp: LrcPtr<Documents::UH3> =
                                    match v4.get().clone().as_ref() {
                                        Documents::UH3::UH3_1(_, x) => x.clone(),
                                        _ => unreachable!(),
                                    };
                                v0_1.set(v0_1_temp);
                                v1_1.set(v1_1_temp);
                                v2.set(v2_temp);
                                v3.set(v3_temp);
                                v4.set(v4_temp);
                                continue '_method58;
                            }
                        }
                    }
                });
            }
        }
        pub fn method59(
            v0_1: LrcPtr<Documents::UH2>,
            v1_1: LrcPtr<Documents::UH2>,
        ) -> LrcPtr<Documents::UH2> {
            let v0_1: MutCell<LrcPtr<Documents::UH2>> = MutCell::new(v0_1.clone());
            let v1_1: MutCell<LrcPtr<Documents::UH2>> = MutCell::new(v1_1.clone());
            '_method59: loop {
                break '_method59 (match v0_1.get().clone().as_ref() {
                    Documents::UH2::UH2_0 => v1_1.get().clone(),
                    Documents::UH2::UH2_1(v0_1_1_0, v0_1_1_1) => {
                        let v0_1_temp: LrcPtr<Documents::UH2> = match v0_1.get().clone().as_ref() {
                            Documents::UH2::UH2_1(_, x) => x.clone(),
                            _ => unreachable!(),
                        };
                        let v1_1_temp: LrcPtr<Documents::UH2> = LrcPtr::new(Documents::UH2::UH2_1(
                            match v0_1.get().clone().as_ref() {
                                Documents::UH2::UH2_1(x, _) => x.clone(),
                                _ => unreachable!(),
                            },
                            v1_1.get().clone(),
                        ));
                        v0_1.set(v0_1_temp);
                        v1_1.set(v1_1_temp);
                        continue '_method59;
                    }
                });
            }
        }
        pub fn method56(
            v0_1: LrcPtr<Documents::UH2>,
            v1_1: string,
            v2: LrcPtr<StringBuilder>,
            v3: i32,
            v4: i32,
        ) -> Documents::US20 {
            let v0_1: MutCell<LrcPtr<Documents::UH2>> = MutCell::new(v0_1.clone());
            let v1_1: MutCell<string> = MutCell::new(v1_1.clone());
            let v2: MutCell<LrcPtr<StringBuilder>> = MutCell::new(v2.clone());
            let v3: MutCell<i32> = MutCell::new(v3);
            let v4: MutCell<i32> = MutCell::new(v4);
            '_method56: loop {
                break '_method56 ({
                    let v76: Documents::US12 = if string("") == v1_1.get().clone() {
                        Documents::US12::US12_1(sprintf!(
                            "parsing.none_of / unexpected end of input / chars: {:?} / s: {:?}",
                            toArray(ofArray(new_array(&['\\', '`', '\"']))),
                            (v2.get().clone(), v3.get().clone(), v4.get().clone())
                        ))
                    } else {
                        let v22: char = getCharAt(v1_1.get().clone(), 0_i32);
                        let v29: string = getSlice(
                            v1_1.get().clone(),
                            Some(1_i32),
                            Some(length(v1_1.get().clone())),
                        );
                        if Documents::method57(v22, 0_i64) == false {
                            let v34: string = ofChar(v22);
                            let v37: i32 = length(v34.clone());
                            let v38: Array<char> = new_init(&'\u{0000}', v37);
                            let v39: LrcPtr<Documents::Mut6> = LrcPtr::new(Documents::Mut6 {
                                l0: MutCell::new(0_i32),
                            });
                            while Documents::method28(v37, v39.clone()) {
                                let v41: i32 = v39.l0.get().clone();
                                let v42: char = getCharAt(v34.clone(), v41);
                                v38.get_mut()[v41 as usize] = v42;
                                {
                                    let v43: i32 = v41 + 1_i32;
                                    v39.l0.set(v43);
                                    ()
                                }
                            }
                            {
                                let v44: List<char> = ofArray(v38.clone());
                                let patternInput: (LrcPtr<StringBuilder>, i32, i32) =
                                    Documents::method43(
                                        foldBack(
                                            Func2::new(
                                                move |b0: char, b1: LrcPtr<Documents::UH0>| {
                                                    (Documents::method42())(b0)(b1)
                                                },
                                            ),
                                            v44,
                                            LrcPtr::new(Documents::UH0::UH0_0),
                                        ),
                                        v2.get().clone(),
                                        v3.get().clone(),
                                        v4.get().clone(),
                                    );
                                Documents::US12::US12_0(
                                    v22,
                                    v29,
                                    patternInput.0.clone(),
                                    patternInput.1.clone(),
                                    patternInput.2.clone(),
                                )
                            }
                        } else {
                            Documents::US12::US12_1(sprintf!(
                                "parsing.none_of / unexpected char: \'{}\' / chars: {:?} / s: {:?}",
                                v22,
                                toArray(ofArray(new_array(&['\\', '`', '\"']))),
                                (v2.get().clone(), v3.get().clone(), v4.get().clone())
                            ))
                        }
                    };
                    let v90: Documents::US13 = match &v76 {
                        Documents::US12::US12_0(v76_0_0, v76_0_1, v76_0_2, v76_0_3, v76_0_4) => {
                            Documents::US13::US13_0(
                                ofChar(v76_0_0.clone()),
                                v76_0_1.clone(),
                                v76_0_2.clone(),
                                v76_0_3.clone(),
                                v76_0_4.clone(),
                            )
                        }
                        Documents::US12::US12_1(v76_1_0) => {
                            Documents::US13::US13_1(v76_1_0.clone())
                        }
                    };
                    let v104: Documents::US13 = match &v90 {
                        Documents::US13::US13_0(v90_0_0, v90_0_1, v90_0_2, v90_0_3, v90_0_4) => {
                            v90.clone()
                        }
                        _ => Documents::method58(
                            v1_1.get().clone(),
                            v2.get().clone(),
                            v3.get().clone(),
                            v4.get().clone(),
                            LrcPtr::new(Documents::UH3::UH3_1(
                                Func1::new(
                                    move |arg10_0040: (string, LrcPtr<StringBuilder>, i32, i32)| {
                                        Documents::closure34((), arg10_0040)
                                    },
                                ),
                                LrcPtr::new(Documents::UH3::UH3_1(
                                    Func1::new(
                                        move |arg10_0040_1: (
                                            string,
                                            LrcPtr<StringBuilder>,
                                            i32,
                                            i32,
                                        )| {
                                            Documents::closure35((), arg10_0040_1)
                                        },
                                    ),
                                    LrcPtr::new(Documents::UH3::UH3_0),
                                )),
                            )),
                        ),
                    };
                    match &v104 {
                        Documents::US13::US13_0(
                            v104_0_0,
                            v104_0_1,
                            v104_0_2,
                            v104_0_3,
                            v104_0_4,
                        ) => {
                            let v0_1_temp: LrcPtr<Documents::UH2> = LrcPtr::new(
                                Documents::UH2::UH2_1(v104_0_0.clone(), v0_1.get().clone()),
                            );
                            let v1_1_temp: string = v104_0_1.clone();
                            let v2_temp: LrcPtr<StringBuilder> = v104_0_2.clone();
                            let v3_temp: i32 = v104_0_3.clone();
                            let v4_temp: i32 = v104_0_4.clone();
                            v0_1.set(v0_1_temp);
                            v1_1.set(v1_1_temp);
                            v2.set(v2_temp);
                            v3.set(v3_temp);
                            v4.set(v4_temp);
                            continue '_method56;
                        }
                        _ => Documents::US20::US20_0(
                            Documents::method59(
                                v0_1.get().clone(),
                                LrcPtr::new(Documents::UH2::UH2_0),
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
        pub fn method60(v0_1: LrcPtr<Documents::UH2>, v1_1: List<string>) -> List<string> {
            match v0_1.as_ref() {
                Documents::UH2::UH2_0 => v1_1.clone(),
                Documents::UH2::UH2_1(v0_1_1_0, v0_1_1_1) => cons(
                    match v0_1.as_ref() {
                        Documents::UH2::UH2_1(x, _) => x.clone(),
                        _ => unreachable!(),
                    },
                    Documents::method60(
                        match v0_1.as_ref() {
                            Documents::UH2::UH2_1(_, x) => x.clone(),
                            _ => unreachable!(),
                        },
                        v1_1.clone(),
                    ),
                ),
            }
        }
        pub fn method61(
            v0_1: LrcPtr<Documents::UH2>,
            v1_1: string,
            v2: LrcPtr<StringBuilder>,
            v3: i32,
            v4: i32,
        ) -> Documents::US20 {
            let v0_1: MutCell<LrcPtr<Documents::UH2>> = MutCell::new(v0_1.clone());
            let v1_1: MutCell<string> = MutCell::new(v1_1.clone());
            let v2: MutCell<LrcPtr<StringBuilder>> = MutCell::new(v2.clone());
            let v3: MutCell<i32> = MutCell::new(v3);
            let v4: MutCell<i32> = MutCell::new(v4);
            '_method61: loop {
                break '_method61 ({
                    let v76: Documents::US12 = if string("") == v1_1.get().clone() {
                        Documents::US12::US12_1(sprintf!(
                            "parsing.none_of / unexpected end of input / chars: {:?} / s: {:?}",
                            toArray(ofArray(new_array(&['\\', '`', '\"']))),
                            (v2.get().clone(), v3.get().clone(), v4.get().clone())
                        ))
                    } else {
                        let v22: char = getCharAt(v1_1.get().clone(), 0_i32);
                        let v29: string = getSlice(
                            v1_1.get().clone(),
                            Some(1_i32),
                            Some(length(v1_1.get().clone())),
                        );
                        if Documents::method57(v22, 0_i64) == false {
                            let v34: string = ofChar(v22);
                            let v37: i32 = length(v34.clone());
                            let v38: Array<char> = new_init(&'\u{0000}', v37);
                            let v39: LrcPtr<Documents::Mut6> = LrcPtr::new(Documents::Mut6 {
                                l0: MutCell::new(0_i32),
                            });
                            while Documents::method28(v37, v39.clone()) {
                                let v41: i32 = v39.l0.get().clone();
                                let v42: char = getCharAt(v34.clone(), v41);
                                v38.get_mut()[v41 as usize] = v42;
                                {
                                    let v43: i32 = v41 + 1_i32;
                                    v39.l0.set(v43);
                                    ()
                                }
                            }
                            {
                                let v44: List<char> = ofArray(v38.clone());
                                let patternInput: (LrcPtr<StringBuilder>, i32, i32) =
                                    Documents::method43(
                                        foldBack(
                                            Func2::new(
                                                move |b0: char, b1: LrcPtr<Documents::UH0>| {
                                                    (Documents::method42())(b0)(b1)
                                                },
                                            ),
                                            v44,
                                            LrcPtr::new(Documents::UH0::UH0_0),
                                        ),
                                        v2.get().clone(),
                                        v3.get().clone(),
                                        v4.get().clone(),
                                    );
                                Documents::US12::US12_0(
                                    v22,
                                    v29,
                                    patternInput.0.clone(),
                                    patternInput.1.clone(),
                                    patternInput.2.clone(),
                                )
                            }
                        } else {
                            Documents::US12::US12_1(sprintf!(
                                "parsing.none_of / unexpected char: \'{}\' / chars: {:?} / s: {:?}",
                                v22,
                                toArray(ofArray(new_array(&['\\', '`', '\"']))),
                                (v2.get().clone(), v3.get().clone(), v4.get().clone())
                            ))
                        }
                    };
                    let v90: Documents::US13 = match &v76 {
                        Documents::US12::US12_0(v76_0_0, v76_0_1, v76_0_2, v76_0_3, v76_0_4) => {
                            Documents::US13::US13_0(
                                ofChar(v76_0_0.clone()),
                                v76_0_1.clone(),
                                v76_0_2.clone(),
                                v76_0_3.clone(),
                                v76_0_4.clone(),
                            )
                        }
                        Documents::US12::US12_1(v76_1_0) => {
                            Documents::US13::US13_1(v76_1_0.clone())
                        }
                    };
                    match &v90 {
                        Documents::US13::US13_0(v90_0_0, v90_0_1, v90_0_2, v90_0_3, v90_0_4) => {
                            let v0_1_temp: LrcPtr<Documents::UH2> = LrcPtr::new(
                                Documents::UH2::UH2_1(v90_0_0.clone(), v0_1.get().clone()),
                            );
                            let v1_1_temp: string = v90_0_1.clone();
                            let v2_temp: LrcPtr<StringBuilder> = v90_0_2.clone();
                            let v3_temp: i32 = v90_0_3.clone();
                            let v4_temp: i32 = v90_0_4.clone();
                            v0_1.set(v0_1_temp);
                            v1_1.set(v1_1_temp);
                            v2.set(v2_temp);
                            v3.set(v3_temp);
                            v4.set(v4_temp);
                            continue '_method61;
                        }
                        _ => Documents::US20::US20_0(
                            Documents::method59(
                                v0_1.get().clone(),
                                LrcPtr::new(Documents::UH2::UH2_0),
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
        pub fn method62(v0_1: string, v1_1: i32) -> i32 {
            let v0_1: MutCell<string> = MutCell::new(v0_1.clone());
            let v1_1: MutCell<i32> = MutCell::new(v1_1);
            '_method62: loop {
                break '_method62 (if v1_1.get().clone() >= length(v0_1.get().clone()) {
                    v1_1.get().clone()
                } else {
                    if getCharAt(v0_1.get().clone(), v1_1.get().clone()) == ' ' {
                        let v0_1_temp: string = v0_1.get().clone();
                        let v1_1_temp: i32 = v1_1.get().clone() + 1_i32;
                        v0_1.set(v0_1_temp);
                        v1_1.set(v1_1_temp);
                        continue '_method62;
                    } else {
                        v1_1.get().clone()
                    }
                });
            }
        }
        pub fn method53(
            v0_1: LrcPtr<Documents::UH2>,
            v1_1: string,
            v2: LrcPtr<StringBuilder>,
            v3: i32,
            v4: i32,
        ) -> Documents::US20 {
            let v0_1: MutCell<LrcPtr<Documents::UH2>> = MutCell::new(v0_1.clone());
            let v1_1: MutCell<string> = MutCell::new(v1_1.clone());
            let v2: MutCell<LrcPtr<StringBuilder>> = MutCell::new(v2.clone());
            let v3: MutCell<i32> = MutCell::new(v3);
            let v4: MutCell<i32> = MutCell::new(v4);
            '_method53: loop {
                break '_method53 ({
                    let v5: bool = string("") == v1_1.get().clone();
                    let v82: Documents::US12 = if v5 {
                        Documents::US12::US12_1(sprintf!(
                            "parsing.none_of / unexpected end of input / chars: {:?} / s: {:?}",
                            toArray(ofArray(new_array(&['\\', '`', '\"', ' ']))),
                            (v2.get().clone(), v3.get().clone(), v4.get().clone())
                        ))
                    } else {
                        let v25: char = getCharAt(v1_1.get().clone(), 0_i32);
                        let v32: string = getSlice(
                            v1_1.get().clone(),
                            Some(1_i32),
                            Some(length(v1_1.get().clone())),
                        );
                        if Documents::method54(v25, 0_i64) == false {
                            let v37: string = ofChar(v25);
                            let v40: i32 = length(v37.clone());
                            let v41: Array<char> = new_init(&'\u{0000}', v40);
                            let v42: LrcPtr<Documents::Mut6> = LrcPtr::new(Documents::Mut6 {
                                l0: MutCell::new(0_i32),
                            });
                            while Documents::method28(v40, v42.clone()) {
                                let v44: i32 = v42.l0.get().clone();
                                let v45: char = getCharAt(v37.clone(), v44);
                                v41.get_mut()[v44 as usize] = v45;
                                {
                                    let v46: i32 = v44 + 1_i32;
                                    v42.l0.set(v46);
                                    ()
                                }
                            }
                            {
                                let v47: List<char> = ofArray(v41.clone());
                                let patternInput: (LrcPtr<StringBuilder>, i32, i32) =
                                    Documents::method43(
                                        foldBack(
                                            Func2::new(
                                                move |b0: char, b1: LrcPtr<Documents::UH0>| {
                                                    (Documents::method42())(b0)(b1)
                                                },
                                            ),
                                            v47,
                                            LrcPtr::new(Documents::UH0::UH0_0),
                                        ),
                                        v2.get().clone(),
                                        v3.get().clone(),
                                        v4.get().clone(),
                                    );
                                Documents::US12::US12_0(
                                    v25,
                                    v32,
                                    patternInput.0.clone(),
                                    patternInput.1.clone(),
                                    patternInput.2.clone(),
                                )
                            }
                        } else {
                            Documents::US12::US12_1(sprintf!(
                                "parsing.none_of / unexpected char: \'{}\' / chars: {:?} / s: {:?}",
                                v25,
                                toArray(ofArray(new_array(&['\\', '`', '\"', ' ']))),
                                (v2.get().clone(), v3.get().clone(), v4.get().clone())
                            ))
                        }
                    };
                    let v96: Documents::US13 = match &v82 {
                        Documents::US12::US12_0(v82_0_0, v82_0_1, v82_0_2, v82_0_3, v82_0_4) => {
                            Documents::method55(
                                ofChar(v82_0_0.clone()),
                                v82_0_1.clone(),
                                v82_0_2.clone(),
                                v82_0_3.clone(),
                                v82_0_4.clone(),
                            )
                        }
                        Documents::US12::US12_1(v82_1_0) => {
                            Documents::US13::US13_1(v82_1_0.clone())
                        }
                    };
                    let v341: Documents::US13 = match &v96 {
                        Documents::US13::US13_0(v96_0_0, v96_0_1, v96_0_2, v96_0_3, v96_0_4) => {
                            v96.clone()
                        }
                        _ => {
                            let v165: Documents::US12 = if v5 {
                                Documents::US12::US12_1(sprintf!(
                                    "parsing.p_char / unexpected end of input / s: {:?}",
                                    (v2.get().clone(), v3.get().clone(), v4.get().clone())
                                ))
                            } else {
                                let v105: char = getCharAt(v1_1.get().clone(), 0_i32);
                                if v105 == '\"' {
                                    let v113: string = getSlice(
                                        v1_1.get().clone(),
                                        Some(1_i32),
                                        Some(length(v1_1.get().clone())),
                                    );
                                    let v115: string = ofChar(v105);
                                    let v118: i32 = length(v115.clone());
                                    let v119: Array<char> = new_init(&'\u{0000}', v118);
                                    let v120: LrcPtr<Documents::Mut6> =
                                        LrcPtr::new(Documents::Mut6 {
                                            l0: MutCell::new(0_i32),
                                        });
                                    while Documents::method28(v118, v120.clone()) {
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
                                        let v125: List<char> = ofArray(v119.clone());
                                        let patternInput_1:
                                                                 (LrcPtr<StringBuilder>,
                                                                  i32, i32) =
                                                             Documents::method43(foldBack(Func2::new(move
                                                                                                         |b0:
                                                                                                              char,
                                                                                                          b1:
                                                                                                              LrcPtr<Documents::UH0>|
                                                                                                         (Documents::method42())(b0)(b1)),
                                                                                          v125,
                                                                                          LrcPtr::new(Documents::UH0::UH0_0)),
                                                                                 v2.get().clone(),
                                                                                 v3.get().clone(),
                                                                                 v4.get().clone());
                                        Documents::US12::US12_0(
                                            v105,
                                            v113,
                                            patternInput_1.0.clone(),
                                            patternInput_1.1.clone(),
                                            patternInput_1.2.clone(),
                                        )
                                    }
                                } else {
                                    let v141: i32 = length(v1_1.get().clone());
                                    let v144: i32 =
                                        indexOf(v1_1.get().clone(), string("\n")) - 1_i32;
                                    Documents::US12::US12_1(sprintf!("{}\n{}\n",
                                                                                      sprintf!("parsing.p_char / expected: \'{}\' / line: {} / col: {}\n{}{}",
                                                                                               '\"',
                                                                                               v3.get().clone(),
                                                                                               v4.get().clone(),
                                                                                               v2.get().clone(),
                                                                                               getSlice(v1_1.get().clone(),
                                                                                                        Some(0_i32),
                                                                                                        Some(if -2_i32
                                                                                                                    ==
                                                                                                                    v144
                                                                                                                {
                                                                                                                 v141
                                                                                                             } else {
                                                                                                                 v144
                                                                                                             }))),
                                                                                      append(replicate(v4.get().clone()
                                                                                                           -
                                                                                                           1_i32,
                                                                                                       string(" ")),
                                                                                             string("^"))))
                                }
                            };
                            let v282: Documents::US13 = match &v165 {
                                Documents::US12::US12_0(
                                    v165_0_0,
                                    v165_0_1,
                                    v165_0_2,
                                    v165_0_3,
                                    v165_0_4,
                                ) => {
                                    let v170: i32 = v165_0_4.clone();
                                    let v169: i32 = v165_0_3.clone();
                                    let v168: LrcPtr<StringBuilder> = v165_0_2.clone();
                                    let v167: string = v165_0_1.clone();
                                    let v172: Documents::US20 = Documents::method56(
                                        LrcPtr::new(Documents::UH2::UH2_0),
                                        v167.clone(),
                                        v168.clone(),
                                        v169,
                                        v170,
                                    );
                                    let v193: Documents::US13 = match &v172 {
                                        Documents::US20::US20_0(
                                            v172_0_0,
                                            v172_0_1,
                                            v172_0_2,
                                            v172_0_3,
                                            v172_0_4,
                                        ) => {
                                            let v179: List<string> = Documents::method60(
                                                v172_0_0.clone(),
                                                empty::<string>(),
                                            );
                                            Documents::US13::US13_0(
                                                join(
                                                    string(""),
                                                    toArray_1(delay(Func0::new({
                                                        let v179 = v179.clone();
                                                        move || {
                                                            map(
                                                                Func1::new({
                                                                    let v179 = v179.clone();
                                                                    move |i: i32| {
                                                                        item(i, v179.clone())
                                                                    }
                                                                }),
                                                                rangeNumeric(
                                                                    0_i32,
                                                                    1_i32,
                                                                    length_1(v179.clone()) - 1_i32,
                                                                ),
                                                            )
                                                        }
                                                    }))),
                                                ),
                                                v172_0_1.clone(),
                                                v172_0_2.clone(),
                                                v172_0_3.clone(),
                                                v172_0_4.clone(),
                                            )
                                        }
                                        Documents::US20::US20_1(v172_1_0) => {
                                            Documents::US13::US13_1(v172_1_0.clone())
                                        }
                                    };
                                    match &v193 {
                                        Documents::US13::US13_0(
                                            v193_0_0,
                                            v193_0_1,
                                            v193_0_2,
                                            v193_0_3,
                                            v193_0_4,
                                        ) => {
                                            let v198: i32 = v193_0_4.clone();
                                            let v197: i32 = v193_0_3.clone();
                                            let v196: LrcPtr<StringBuilder> = v193_0_2.clone();
                                            let v195: string = v193_0_1.clone();
                                            let v262: Documents::US12 = if string("")
                                                == v195.clone()
                                            {
                                                Documents::US12::US12_1(sprintf!("parsing.p_char / unexpected end of input / s: {:?}",
                                                                                                      (v196.clone(),
                                                                                                       v197,
                                                                                                       v198)))
                                            } else {
                                                let v202: char = getCharAt(v195.clone(), 0_i32);
                                                if v202 == '\"' {
                                                    let v210: string = getSlice(
                                                        v195.clone(),
                                                        Some(1_i32),
                                                        Some(length(v195.clone())),
                                                    );
                                                    let v212: string = ofChar(v202);
                                                    let v215: i32 = length(v212.clone());
                                                    let v216: Array<char> =
                                                        new_init(&'\u{0000}', v215);
                                                    let v217: LrcPtr<Documents::Mut6> =
                                                        LrcPtr::new(Documents::Mut6 {
                                                            l0: MutCell::new(0_i32),
                                                        });
                                                    while Documents::method28(v215, v217.clone()) {
                                                        let v219: i32 = v217.l0.get().clone();
                                                        let v220: char =
                                                            getCharAt(v212.clone(), v219);
                                                        v216.get_mut()[v219 as usize] = v220;
                                                        {
                                                            let v221: i32 = v219 + 1_i32;
                                                            v217.l0.set(v221);
                                                            ()
                                                        }
                                                    }
                                                    {
                                                        let v222: List<char> =
                                                            ofArray(v216.clone());
                                                        let patternInput_2:
                                                                                     (LrcPtr<StringBuilder>,
                                                                                      i32,
                                                                                      i32) =
                                                                                 Documents::method43(foldBack(Func2::new(move
                                                                                                                             |b0:
                                                                                                                                  char,
                                                                                                                              b1:
                                                                                                                                  LrcPtr<Documents::UH0>|
                                                                                                                             (Documents::method42())(b0)(b1)),
                                                                                                              v222,
                                                                                                              LrcPtr::new(Documents::UH0::UH0_0)),
                                                                                                     v196.clone(),
                                                                                                     v197,
                                                                                                     v198);
                                                        Documents::US12::US12_0(
                                                            v202,
                                                            v210,
                                                            patternInput_2.0.clone(),
                                                            patternInput_2.1.clone(),
                                                            patternInput_2.2.clone(),
                                                        )
                                                    }
                                                } else {
                                                    let v238: i32 = length(v195.clone());
                                                    let v241: i32 =
                                                        indexOf(v195.clone(), string("\n")) - 1_i32;
                                                    Documents::US12::US12_1(sprintf!("{}\n{}\n",
                                                                                                          sprintf!("parsing.p_char / expected: \'{}\' / line: {} / col: {}\n{}{}",
                                                                                                                   '\"',
                                                                                                                   v197,
                                                                                                                   v198,
                                                                                                                   v196.clone(),
                                                                                                                   getSlice(v195.clone(),
                                                                                                                            Some(0_i32),
                                                                                                                            Some(if -2_i32
                                                                                                                                        ==
                                                                                                                                        v241
                                                                                                                                    {
                                                                                                                                     v238
                                                                                                                                 } else {
                                                                                                                                     v241
                                                                                                                                 }))),
                                                                                                          append(replicate(v198
                                                                                                                               -
                                                                                                                               1_i32,
                                                                                                                           string(" ")),
                                                                                                                 string("^"))))
                                                }
                                            };
                                            match &v262 {
                                                                 Documents::US12::US12_0(v262_0_0,
                                                                                         v262_0_1,
                                                                                         v262_0_2,
                                                                                         v262_0_3,
                                                                                         v262_0_4)
                                                                 =>
                                                                 Documents::US13::US13_0(v193_0_0.clone(),
                                                                                         v262_0_1.clone(),
                                                                                         v262_0_2.clone(),
                                                                                         v262_0_3.clone(),
                                                                                         v262_0_4.clone()),
                                                                 Documents::US12::US12_1(v262_1_0)
                                                                 =>
                                                                 Documents::US13::US13_1(sprintf!("between / expected closing delimiter / e: {:?} / input: {:?} / rest1: {:?} / rest2: {:?}",
                                                                                                  v262_1_0.clone(),
                                                                                                  (v1_1.get().clone(),
                                                                                                   v2.get().clone(),
                                                                                                   v3.get().clone(),
                                                                                                   v4.get().clone()),
                                                                                                  (v167,
                                                                                                   v168,
                                                                                                   v169,
                                                                                                   v170),
                                                                                                  (v195,
                                                                                                   v196,
                                                                                                   v197,
                                                                                                   v198))),
                                                             }
                                        }
                                        _ => Documents::US13::US13_1(string(
                                            "between / expected content",
                                        )),
                                    }
                                }
                                Documents::US12::US12_1(v165_1_0) => {
                                    Documents::US13::US13_1(v165_1_0.clone())
                                }
                            };
                            match &v282 {
                                Documents::US13::US13_0(
                                    v282_0_0,
                                    v282_0_1,
                                    v282_0_2,
                                    v282_0_3,
                                    v282_0_4,
                                ) => v282.clone(),
                                _ => {
                                    let v294: Documents::US13 =
                                                     Documents::method58(v1_1.get().clone(),
                                                                         v2.get().clone(),
                                                                         v3.get().clone(),
                                                                         v4.get().clone(),
                                                                         LrcPtr::new(Documents::UH3::UH3_1(Func1::new(move
                                                                                                                          |arg10_0040:
                                                                                                                               (string,
                                                                                                                                LrcPtr<StringBuilder>,
                                                                                                                                i32,
                                                                                                                                i32)|
                                                                                                                          Documents::closure34((),
                                                                                                                                               arg10_0040)),
                                                                                                           LrcPtr::new(Documents::UH3::UH3_1(Func1::new(move
                                                                                                                                                            |arg10_0040_1:
                                                                                                                                                                 (string,
                                                                                                                                                                  LrcPtr<StringBuilder>,
                                                                                                                                                                  i32,
                                                                                                                                                                  i32)|
                                                                                                                                                            Documents::closure35((),
                                                                                                                                                                                 arg10_0040_1)),
                                                                                                                                             LrcPtr::new(Documents::UH3::UH3_0))))));
                                    let v305: Documents::US13 = match &v294 {
                                        Documents::US13::US13_0(
                                            v294_0_0,
                                            v294_0_1,
                                            v294_0_2,
                                            v294_0_3,
                                            v294_0_4,
                                        ) => Documents::US13::US13_0(
                                            string(""),
                                            v294_0_1.clone(),
                                            v294_0_2.clone(),
                                            v294_0_3.clone(),
                                            v294_0_4.clone(),
                                        ),
                                        Documents::US13::US13_1(v294_1_0) => {
                                            Documents::US13::US13_1(v294_1_0.clone())
                                        }
                                    };
                                    let v316: Documents::US20 = match &v305 {
                                        Documents::US13::US13_0(
                                            v305_0_0,
                                            v305_0_1,
                                            v305_0_2,
                                            v305_0_3,
                                            v305_0_4,
                                        ) => Documents::method61(
                                            LrcPtr::new(Documents::UH2::UH2_0),
                                            v305_0_1.clone(),
                                            v305_0_2.clone(),
                                            v305_0_3.clone(),
                                            v305_0_4.clone(),
                                        ),
                                        Documents::US13::US13_1(v305_1_0) => {
                                            Documents::US20::US20_1(v305_1_0.clone())
                                        }
                                    };
                                    match &v316 {
                                        Documents::US20::US20_0(
                                            v316_0_0,
                                            v316_0_1,
                                            v316_0_2,
                                            v316_0_3,
                                            v316_0_4,
                                        ) => {
                                            let v323: List<string> = Documents::method60(
                                                v316_0_0.clone(),
                                                empty::<string>(),
                                            );
                                            Documents::US13::US13_0(
                                                join(
                                                    string(""),
                                                    toArray_1(delay(Func0::new({
                                                        let v323 = v323.clone();
                                                        move || {
                                                            map(
                                                                Func1::new({
                                                                    let v323 = v323.clone();
                                                                    move |i_1: i32| {
                                                                        item(i_1, v323.clone())
                                                                    }
                                                                }),
                                                                rangeNumeric(
                                                                    0_i32,
                                                                    1_i32,
                                                                    length_1(v323.clone()) - 1_i32,
                                                                ),
                                                            )
                                                        }
                                                    }))),
                                                ),
                                                v316_0_1.clone(),
                                                v316_0_2.clone(),
                                                v316_0_3.clone(),
                                                v316_0_4.clone(),
                                            )
                                        }
                                        Documents::US20::US20_1(v316_1_0) => {
                                            Documents::US13::US13_1(v316_1_0.clone())
                                        }
                                    }
                                }
                            }
                        }
                    };
                    match &v341 {
                        Documents::US13::US13_0(
                            v341_0_0,
                            v341_0_1,
                            v341_0_2,
                            v341_0_3,
                            v341_0_4,
                        ) => {
                            let v350: i32 = v341_0_4.clone();
                            let v349: i32 = v341_0_3.clone();
                            let v348: LrcPtr<StringBuilder> = v341_0_2.clone();
                            let v347: string = v341_0_1.clone();
                            let v346: string = v341_0_0.clone();
                            let v352: i32 = Documents::method62(v347.clone(), 0_i32);
                            let v364: Documents::US15 = if 0_i32 == v352 {
                                Documents::US15::US15_1(string(
                                    "spaces1 / expected at least one space",
                                ))
                            } else {
                                Documents::US15::US15_0(
                                    getSlice(v347.clone(), Some(v352), Some(length(v347.clone()))),
                                    v348.clone(),
                                    v349,
                                    v350,
                                )
                            };
                            match &v364 {
                                Documents::US15::US15_0(v364_0_0, v364_0_1, v364_0_2, v364_0_3) => {
                                    let v0_1_temp: LrcPtr<Documents::UH2> = LrcPtr::new(
                                        Documents::UH2::UH2_1(v346.clone(), v0_1.get().clone()),
                                    );
                                    let v1_1_temp: string = v364_0_0.clone();
                                    let v2_temp: LrcPtr<StringBuilder> = v364_0_1.clone();
                                    let v3_temp: i32 = v364_0_2.clone();
                                    let v4_temp: i32 = v364_0_3.clone();
                                    v0_1.set(v0_1_temp);
                                    v1_1.set(v1_1_temp);
                                    v2.set(v2_temp);
                                    v3.set(v3_temp);
                                    v4.set(v4_temp);
                                    continue '_method53;
                                }
                                _ => Documents::US20::US20_0(
                                    Documents::method59(
                                        v0_1.get().clone(),
                                        LrcPtr::new(Documents::UH2::UH2_1(
                                            v346.clone(),
                                            LrcPtr::new(Documents::UH2::UH2_0),
                                        )),
                                    ),
                                    v347,
                                    v348,
                                    v349,
                                    v350,
                                ),
                            }
                        }
                        _ => Documents::US20::US20_0(
                            Documents::method59(
                                v0_1.get().clone(),
                                LrcPtr::new(Documents::UH2::UH2_0),
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
        pub fn method52(v0_1: string) -> Documents::US19 {
            let _v0: MutCell<Option<Option<string>>> = MutCell::new(None::<Option<string>>);
            _v0.set(Some(Some(v0_1)));
            {
                let v15: Documents::US20 = Documents::method53(
                    LrcPtr::new(Documents::UH2::UH2_0),
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
                match &v15 {
                    Documents::US20::US20_0(v15_0_0, v15_0_1, v15_0_2, v15_0_3, v15_0_4) => {
                        Documents::US19::US19_0(toArray(Documents::method60(
                            v15_0_0.clone(),
                            empty::<string>(),
                        )))
                    }
                    Documents::US20::US20_1(v15_1_0) => Documents::US19::US19_1(v15_1_0.clone()),
                }
            }
        }
        pub fn closure36(
            v0_1: string,
            v1_1: Option<CancellationToken>,
            v2: Array<(string, string)>,
            v3: Option<Func1<(i32, string, bool), Arc<Async<()>>>>,
            v4: Option<Func1<std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>, ()>>,
            v5: bool,
            v6: Option<string>,
            v7: string,
            v8: Vec<std::string::String>,
            unitVar: (),
        ) {
            fn v10() {
                Documents::closure7((), ());
            }
            let v11: () = {
                v10();
                ()
            };
            let patternInput: (
                LrcPtr<Documents::Mut0>,
                LrcPtr<Documents::Mut1>,
                LrcPtr<Documents::Mut2>,
                LrcPtr<Documents::Mut3>,
                LrcPtr<Documents::Mut4>,
                Option<i64>,
            ) = getValue(Documents::TraceState::trace_state().get().clone());
            let v44: () = {
                v10();
                ()
            };
            let patternInput_1: (
                LrcPtr<Documents::Mut0>,
                LrcPtr<Documents::Mut1>,
                LrcPtr<Documents::Mut2>,
                LrcPtr<Documents::Mut3>,
                LrcPtr<Documents::Mut4>,
                Option<i64>,
            ) = getValue(Documents::TraceState::trace_state().get().clone());
            let v76: Documents::US0 = (patternInput_1.4.clone()).l0.get().clone();
            if if (patternInput_1.2.clone()).l0.get().clone() == false {
                false
            } else {
                1_i32
                    >= find(
                        v76,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Documents::US0::US0_0, 0_i32)),
                            LrcPtr::new((Documents::US0::US0_1, 1_i32)),
                            LrcPtr::new((Documents::US0::US0_2, 2_i32)),
                            LrcPtr::new((Documents::US0::US0_3, 3_i32)),
                            LrcPtr::new((Documents::US0::US0_4, 4_i32)),
                        ])))),
                    )
            } {
                let v84: () = {
                    Documents::closure8(patternInput.0.clone(), ());
                    ()
                };
                let v88: () = {
                    v10();
                    ()
                };
                let patternInput_2: (
                    LrcPtr<Documents::Mut0>,
                    LrcPtr<Documents::Mut1>,
                    LrcPtr<Documents::Mut2>,
                    LrcPtr<Documents::Mut3>,
                    LrcPtr<Documents::Mut4>,
                    Option<i64>,
                ) = getValue(Documents::TraceState::trace_state().get().clone());
                let _v121: LrcPtr<MutCell<Option<Documents::US3>>> =
                    refCell(None::<Documents::US3>);
                let v126: () = {
                    Documents::closure10(
                        patternInput_2.5.clone(),
                        Func1::new({
                            let _v121 = _v121.clone();
                            move |v: Option<Documents::US3>| Documents::closure9(_v121.clone(), v)
                        }),
                        (),
                    );
                    ()
                };
                let v141: Documents::US3 = defaultValue(Documents::US3::US3_1, _v121.get().clone());
                let v181: DateTime = match &v141 {
                    Documents::US3::US3_0(v141_0_0) => {
                        let v155: TimeSpan = TimeSpan::new_ticks(
                            {
                                let _arg: DateTime = DateTime::now();
                                _arg.ticks()
                            } - match &v141 {
                                Documents::US3::US3_0(x) => x.clone(),
                                _ => unreachable!(),
                            },
                        );
                        DateTime::new_ymdhms_milli(
                            1_i32,
                            1_i32,
                            1_i32,
                            v155.hours(),
                            v155.minutes(),
                            v155.seconds(),
                            v155.milliseconds(),
                        )
                    }
                    _ => DateTime::now(),
                };
                let v186: string = {
                    let provider: string = Documents::method6();
                    v181.toString(provider)
                };
                let v578: string = padLeft(toLower(string("Debug")), 7_i32, ' ');
                let v594: &str = inline_colorization::color_bright_blue;
                let v596: &str = &*v578;
                let v598: &str = inline_colorization::color_reset;
                let v600: string = string("format!(\"{v594}{v596}{v598}\")");
                let v601: std::string::String = format!("{v594}{v596}{v598}");
                let v603: string = fable_library_rust::String_::fromString(v601);
                let v644: i64 = (patternInput_2.0.clone()).l0.get().clone();
                let v646: LrcPtr<Documents::Mut3> = LrcPtr::new(Documents::Mut3 {
                    l0: MutCell::new(Documents::method9()),
                });
                let v653: () = {
                    Documents::closure11(v646.clone(), sprintf!("{}", string("{ ")), ());
                    ()
                };
                let v662: () = {
                    Documents::closure11(v646.clone(), sprintf!("{}", string("file_name")), ());
                    ()
                };
                let v671: () = {
                    Documents::closure11(v646.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v679: () = {
                    Documents::closure11(v646.clone(), sprintf!("{}", v7), ());
                    ()
                };
                let v688: () = {
                    Documents::closure11(v646.clone(), sprintf!("{}", string("; ")), ());
                    ()
                };
                let v697: () = {
                    Documents::closure11(v646.clone(), sprintf!("{}", string("arguments")), ());
                    ()
                };
                let v705: () = {
                    Documents::closure11(v646.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v710: std::string::String = format!("{:#?}", v8);
                let v740: () = {
                    Documents::closure11(
                        v646.clone(),
                        sprintf!("{}", fable_library_rust::String_::fromString(v710)),
                        (),
                    );
                    ()
                };
                let v748: () = {
                    Documents::closure11(v646.clone(), sprintf!("{}", string("; ")), ());
                    ()
                };
                let v757: () = {
                    Documents::closure11(v646.clone(), sprintf!("{}", string("options")), ());
                    ()
                };
                let v765: () = {
                    Documents::closure11(v646.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v773: () = {
                    Documents::closure11(v646.clone(), sprintf!("{}", string("{ ")), ());
                    ()
                };
                let v782: () = {
                    Documents::closure11(v646.clone(), sprintf!("{}", string("command")), ());
                    ()
                };
                let v790: () = {
                    Documents::closure11(v646.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v798: () = {
                    Documents::closure11(v646.clone(), sprintf!("{}", v0_1), ());
                    ()
                };
                let v806: () = {
                    Documents::closure11(v646.clone(), sprintf!("{}", string("; ")), ());
                    ()
                };
                let v815: () = {
                    Documents::closure11(
                        v646.clone(),
                        sprintf!("{}", string("cancellation_token")),
                        (),
                    );
                    ()
                };
                let v823: () = {
                    Documents::closure11(v646.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v828: std::string::String = format!("{:#?}", v1_1);
                let v858: () = {
                    Documents::closure11(
                        v646.clone(),
                        sprintf!("{}", fable_library_rust::String_::fromString(v828)),
                        (),
                    );
                    ()
                };
                let v866: () = {
                    Documents::closure11(v646.clone(), sprintf!("{}", string("; ")), ());
                    ()
                };
                let v875: () = {
                    Documents::closure11(
                        v646.clone(),
                        sprintf!("{}", string("environment_variables")),
                        (),
                    );
                    ()
                };
                let v883: () = {
                    Documents::closure11(v646.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v894: () = {
                    Documents::closure11(v646.clone(), sprintf!("{}", sprintf!("{:?}", v2)), ());
                    ()
                };
                let v902: () = {
                    Documents::closure11(v646.clone(), sprintf!("{}", string("; ")), ());
                    ()
                };
                let v911: () = {
                    Documents::closure11(v646.clone(), sprintf!("{}", string("on_line")), ());
                    ()
                };
                let v919: () = {
                    Documents::closure11(v646.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v924: std::string::String = format!("{:#?}", v3);
                let v954: () = {
                    Documents::closure11(
                        v646.clone(),
                        sprintf!("{}", fable_library_rust::String_::fromString(v924)),
                        (),
                    );
                    ()
                };
                let v962: () = {
                    Documents::closure11(v646.clone(), sprintf!("{}", string("; ")), ());
                    ()
                };
                let v971: () = {
                    Documents::closure11(v646.clone(), sprintf!("{}", string("stdin")), ());
                    ()
                };
                let v979: () = {
                    Documents::closure11(v646.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v984: std::string::String = format!("{:#?}", v4);
                let v1014: () = {
                    Documents::closure11(
                        v646.clone(),
                        sprintf!("{}", fable_library_rust::String_::fromString(v984)),
                        (),
                    );
                    ()
                };
                let v1022: () = {
                    Documents::closure11(v646.clone(), sprintf!("{}", string("; ")), ());
                    ()
                };
                let v1031: () = {
                    Documents::closure11(v646.clone(), sprintf!("{}", string("trace")), ());
                    ()
                };
                let v1039: () = {
                    Documents::closure11(v646.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v1050: () = {
                    Documents::closure11(
                        v646.clone(),
                        sprintf!("{}", if v5 { string("true") } else { string("false") }),
                        (),
                    );
                    ()
                };
                let v1058: () = {
                    Documents::closure11(v646.clone(), sprintf!("{}", string("; ")), ());
                    ()
                };
                let v1067: () = {
                    Documents::closure11(
                        v646.clone(),
                        sprintf!("{}", string("working_directory")),
                        (),
                    );
                    ()
                };
                let v1075: () = {
                    Documents::closure11(v646.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v1080: std::string::String = format!("{:#?}", v6);
                let v1110: () = {
                    Documents::closure11(
                        v646.clone(),
                        sprintf!("{}", fable_library_rust::String_::fromString(v1080)),
                        (),
                    );
                    ()
                };
                let v1119: () = {
                    Documents::closure11(v646.clone(), sprintf!("{}", string(" }")), ());
                    ()
                };
                let v1127: () = {
                    Documents::closure11(v646.clone(), sprintf!("{}", string(" }")), ());
                    ()
                };
                let v1189: string = trimEndChars(
                    trimStartChars(
                        sprintf!(
                            "{} {} #{} {} / {}",
                            v186,
                            v603,
                            v644,
                            string("runtime.execute_with_options"),
                            v646.l0.get().clone()
                        ),
                        toArray(empty::<char>()),
                    ),
                    toArray(ofArray(new_array(&[' ', '/']))),
                );
                println!("{}", v1189.clone());
                ();
                ((patternInput.1.clone()).l0.get().clone())(v1189)
            }
        }
        pub fn closure37(
            unitVar: (),
            v0_1: std::sync::Arc<std::sync::Mutex<Option<std::process::Child>>>,
        ) -> Documents::US21 {
            Documents::US21::US21_0(v0_1)
        }
        pub fn method63(
        ) -> Func1<std::sync::Arc<std::sync::Mutex<Option<std::process::Child>>>, Documents::US21>
        {
            Func1::new(
                move |v: std::sync::Arc<std::sync::Mutex<Option<std::process::Child>>>| {
                    Documents::closure37((), v)
                },
            )
        }
        pub fn closure38(unitVar: (), v0_1: std::string::String) -> Documents::US21 {
            Documents::US21::US21_1(v0_1)
        }
        pub fn method64() -> Func1<std::string::String, Documents::US21> {
            Func1::new(move |v: std::string::String| Documents::closure38((), v))
        }
        pub fn closure39(v0_1: std::string::String, unitVar: ()) {
            fn v2() {
                Documents::closure7((), ());
            }
            let v3: () = {
                v2();
                ()
            };
            let patternInput: (
                LrcPtr<Documents::Mut0>,
                LrcPtr<Documents::Mut1>,
                LrcPtr<Documents::Mut2>,
                LrcPtr<Documents::Mut3>,
                LrcPtr<Documents::Mut4>,
                Option<i64>,
            ) = getValue(Documents::TraceState::trace_state().get().clone());
            let v36: () = {
                v2();
                ()
            };
            let patternInput_1: (
                LrcPtr<Documents::Mut0>,
                LrcPtr<Documents::Mut1>,
                LrcPtr<Documents::Mut2>,
                LrcPtr<Documents::Mut3>,
                LrcPtr<Documents::Mut4>,
                Option<i64>,
            ) = getValue(Documents::TraceState::trace_state().get().clone());
            let v68: Documents::US0 = (patternInput_1.4.clone()).l0.get().clone();
            if if (patternInput_1.2.clone()).l0.get().clone() == false {
                false
            } else {
                4_i32
                    >= find(
                        v68,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Documents::US0::US0_0, 0_i32)),
                            LrcPtr::new((Documents::US0::US0_1, 1_i32)),
                            LrcPtr::new((Documents::US0::US0_2, 2_i32)),
                            LrcPtr::new((Documents::US0::US0_3, 3_i32)),
                            LrcPtr::new((Documents::US0::US0_4, 4_i32)),
                        ])))),
                    )
            } {
                let v76: () = {
                    Documents::closure8(patternInput.0.clone(), ());
                    ()
                };
                let v80: () = {
                    v2();
                    ()
                };
                let patternInput_2: (
                    LrcPtr<Documents::Mut0>,
                    LrcPtr<Documents::Mut1>,
                    LrcPtr<Documents::Mut2>,
                    LrcPtr<Documents::Mut3>,
                    LrcPtr<Documents::Mut4>,
                    Option<i64>,
                ) = getValue(Documents::TraceState::trace_state().get().clone());
                let _v113: LrcPtr<MutCell<Option<Documents::US3>>> =
                    refCell(None::<Documents::US3>);
                let v118: () = {
                    Documents::closure10(
                        patternInput_2.5.clone(),
                        Func1::new({
                            let _v113 = _v113.clone();
                            move |v: Option<Documents::US3>| Documents::closure9(_v113.clone(), v)
                        }),
                        (),
                    );
                    ()
                };
                let v133: Documents::US3 = defaultValue(Documents::US3::US3_1, _v113.get().clone());
                let v173: DateTime = match &v133 {
                    Documents::US3::US3_0(v133_0_0) => {
                        let v147: TimeSpan = TimeSpan::new_ticks(
                            {
                                let _arg: DateTime = DateTime::now();
                                _arg.ticks()
                            } - match &v133 {
                                Documents::US3::US3_0(x) => x.clone(),
                                _ => unreachable!(),
                            },
                        );
                        DateTime::new_ymdhms_milli(
                            1_i32,
                            1_i32,
                            1_i32,
                            v147.hours(),
                            v147.minutes(),
                            v147.seconds(),
                            v147.milliseconds(),
                        )
                    }
                    _ => DateTime::now(),
                };
                let v178: string = {
                    let provider: string = Documents::method6();
                    v173.toString(provider)
                };
                let v570: string = padLeft(toLower(string("Critical")), 7_i32, ' ');
                let v586: &str = inline_colorization::color_bright_red;
                let v588: &str = &*v570;
                let v590: &str = inline_colorization::color_reset;
                let v592: string = string("format!(\"{v586}{v588}{v590}\")");
                let v593: std::string::String = format!("{v586}{v588}{v590}");
                let v595: string = fable_library_rust::String_::fromString(v593);
                let v636: i64 = (patternInput_2.0.clone()).l0.get().clone();
                let v638: LrcPtr<Documents::Mut3> = LrcPtr::new(Documents::Mut3 {
                    l0: MutCell::new(Documents::method9()),
                });
                let v645: () = {
                    Documents::closure11(v638.clone(), sprintf!("{}", string("{ ")), ());
                    ()
                };
                let v654: () = {
                    Documents::closure11(v638.clone(), sprintf!("{}", string("error")), ());
                    ()
                };
                let v663: () = {
                    Documents::closure11(v638.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v668: std::string::String = format!("{:#?}", v0_1);
                let v698: () = {
                    Documents::closure11(
                        v638.clone(),
                        sprintf!("{}", fable_library_rust::String_::fromString(v668)),
                        (),
                    );
                    ()
                };
                let v707: () = {
                    Documents::closure11(v638.clone(), sprintf!("{}", string(" }")), ());
                    ()
                };
                let v769: string = trimEndChars(
                    trimStartChars(
                        sprintf!(
                            "{} {} #{} {} / {}",
                            v178,
                            v595,
                            v636,
                            string("runtime.execute_with_options / child error"),
                            v638.l0.get().clone()
                        ),
                        toArray(empty::<char>()),
                    ),
                    toArray(ofArray(new_array(&[' ', '/']))),
                );
                println!("{}", v769.clone());
                ();
                ((patternInput.1.clone()).l0.get().clone())(v769)
            }
        }
        pub fn closure40(unitVar: (), v0_1: std::string::String) -> Documents::US23 {
            Documents::US23::US23_0(v0_1)
        }
        pub fn method65() -> Func1<std::string::String, Documents::US23> {
            Func1::new(move |v: std::string::String| Documents::closure40((), v))
        }
        pub fn closure41(unitVar: (), v0_1: std::string::String) -> Documents::US23 {
            Documents::US23::US23_1(v0_1)
        }
        pub fn method66() -> Func1<std::string::String, Documents::US23> {
            Func1::new(move |v: std::string::String| Documents::closure41((), v))
        }
        pub fn closure42(v0_1: std::string::String, unitVar: ()) {
            fn v2() {
                Documents::closure7((), ());
            }
            let v3: () = {
                v2();
                ()
            };
            let patternInput: (
                LrcPtr<Documents::Mut0>,
                LrcPtr<Documents::Mut1>,
                LrcPtr<Documents::Mut2>,
                LrcPtr<Documents::Mut3>,
                LrcPtr<Documents::Mut4>,
                Option<i64>,
            ) = getValue(Documents::TraceState::trace_state().get().clone());
            let v36: () = {
                v2();
                ()
            };
            let patternInput_1: (
                LrcPtr<Documents::Mut0>,
                LrcPtr<Documents::Mut1>,
                LrcPtr<Documents::Mut2>,
                LrcPtr<Documents::Mut3>,
                LrcPtr<Documents::Mut4>,
                Option<i64>,
            ) = getValue(Documents::TraceState::trace_state().get().clone());
            let v68: Documents::US0 = (patternInput_1.4.clone()).l0.get().clone();
            if if (patternInput_1.2.clone()).l0.get().clone() == false {
                false
            } else {
                4_i32
                    >= find(
                        v68,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Documents::US0::US0_0, 0_i32)),
                            LrcPtr::new((Documents::US0::US0_1, 1_i32)),
                            LrcPtr::new((Documents::US0::US0_2, 2_i32)),
                            LrcPtr::new((Documents::US0::US0_3, 3_i32)),
                            LrcPtr::new((Documents::US0::US0_4, 4_i32)),
                        ])))),
                    )
            } {
                let v76: () = {
                    Documents::closure8(patternInput.0.clone(), ());
                    ()
                };
                let v80: () = {
                    v2();
                    ()
                };
                let patternInput_2: (
                    LrcPtr<Documents::Mut0>,
                    LrcPtr<Documents::Mut1>,
                    LrcPtr<Documents::Mut2>,
                    LrcPtr<Documents::Mut3>,
                    LrcPtr<Documents::Mut4>,
                    Option<i64>,
                ) = getValue(Documents::TraceState::trace_state().get().clone());
                let _v113: LrcPtr<MutCell<Option<Documents::US3>>> =
                    refCell(None::<Documents::US3>);
                let v118: () = {
                    Documents::closure10(
                        patternInput_2.5.clone(),
                        Func1::new({
                            let _v113 = _v113.clone();
                            move |v: Option<Documents::US3>| Documents::closure9(_v113.clone(), v)
                        }),
                        (),
                    );
                    ()
                };
                let v133: Documents::US3 = defaultValue(Documents::US3::US3_1, _v113.get().clone());
                let v173: DateTime = match &v133 {
                    Documents::US3::US3_0(v133_0_0) => {
                        let v147: TimeSpan = TimeSpan::new_ticks(
                            {
                                let _arg: DateTime = DateTime::now();
                                _arg.ticks()
                            } - match &v133 {
                                Documents::US3::US3_0(x) => x.clone(),
                                _ => unreachable!(),
                            },
                        );
                        DateTime::new_ymdhms_milli(
                            1_i32,
                            1_i32,
                            1_i32,
                            v147.hours(),
                            v147.minutes(),
                            v147.seconds(),
                            v147.milliseconds(),
                        )
                    }
                    _ => DateTime::now(),
                };
                let v178: string = {
                    let provider: string = Documents::method6();
                    v173.toString(provider)
                };
                let v570: string = padLeft(toLower(string("Critical")), 7_i32, ' ');
                let v586: &str = inline_colorization::color_bright_red;
                let v588: &str = &*v570;
                let v590: &str = inline_colorization::color_reset;
                let v592: string = string("format!(\"{v586}{v588}{v590}\")");
                let v593: std::string::String = format!("{v586}{v588}{v590}");
                let v595: string = fable_library_rust::String_::fromString(v593);
                let v636: i64 = (patternInput_2.0.clone()).l0.get().clone();
                let v638: LrcPtr<Documents::Mut3> = LrcPtr::new(Documents::Mut3 {
                    l0: MutCell::new(Documents::method9()),
                });
                let v645: () = {
                    Documents::closure11(v638.clone(), sprintf!("{}", string("{ ")), ());
                    ()
                };
                let v654: () = {
                    Documents::closure11(v638.clone(), sprintf!("{}", string("e")), ());
                    ()
                };
                let v663: () = {
                    Documents::closure11(v638.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v668: std::string::String = format!("{:#?}", v0_1);
                let v698: () = {
                    Documents::closure11(
                        v638.clone(),
                        sprintf!("{}", fable_library_rust::String_::fromString(v668)),
                        (),
                    );
                    ()
                };
                let v707: () = {
                    Documents::closure11(v638.clone(), sprintf!("{}", string(" }")), ());
                    ()
                };
                let v769: string = trimEndChars(
                    trimStartChars(
                        sprintf!(
                            "{} {} #{} {} / {}",
                            v178,
                            v595,
                            v636,
                            string("runtime.stdio_line"),
                            v638.l0.get().clone()
                        ),
                        toArray(empty::<char>()),
                    ),
                    toArray(ofArray(new_array(&[' ', '/']))),
                );
                println!("{}", v769.clone());
                ();
                ((patternInput.1.clone()).l0.get().clone())(v769)
            }
        }
        pub fn closure43(v0_1: string, unitVar: ()) {
            fn v2() {
                Documents::closure7((), ());
            }
            let v3: () = {
                v2();
                ()
            };
            let patternInput: (
                LrcPtr<Documents::Mut0>,
                LrcPtr<Documents::Mut1>,
                LrcPtr<Documents::Mut2>,
                LrcPtr<Documents::Mut3>,
                LrcPtr<Documents::Mut4>,
                Option<i64>,
            ) = getValue(Documents::TraceState::trace_state().get().clone());
            let v36: () = {
                v2();
                ()
            };
            let patternInput_1: (
                LrcPtr<Documents::Mut0>,
                LrcPtr<Documents::Mut1>,
                LrcPtr<Documents::Mut2>,
                LrcPtr<Documents::Mut3>,
                LrcPtr<Documents::Mut4>,
                Option<i64>,
            ) = getValue(Documents::TraceState::trace_state().get().clone());
            let v68: Documents::US0 = (patternInput_1.4.clone()).l0.get().clone();
            if if (patternInput_1.2.clone()).l0.get().clone() == false {
                false
            } else {
                0_i32
                    >= find(
                        v68,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Documents::US0::US0_0, 0_i32)),
                            LrcPtr::new((Documents::US0::US0_1, 1_i32)),
                            LrcPtr::new((Documents::US0::US0_2, 2_i32)),
                            LrcPtr::new((Documents::US0::US0_3, 3_i32)),
                            LrcPtr::new((Documents::US0::US0_4, 4_i32)),
                        ])))),
                    )
            } {
                let v76: () = {
                    Documents::closure8(patternInput.0.clone(), ());
                    ()
                };
                let v80: () = {
                    v2();
                    ()
                };
                let patternInput_2: (
                    LrcPtr<Documents::Mut0>,
                    LrcPtr<Documents::Mut1>,
                    LrcPtr<Documents::Mut2>,
                    LrcPtr<Documents::Mut3>,
                    LrcPtr<Documents::Mut4>,
                    Option<i64>,
                ) = getValue(Documents::TraceState::trace_state().get().clone());
                let _v113: LrcPtr<MutCell<Option<Documents::US3>>> =
                    refCell(None::<Documents::US3>);
                let v118: () = {
                    Documents::closure10(
                        patternInput_2.5.clone(),
                        Func1::new({
                            let _v113 = _v113.clone();
                            move |v: Option<Documents::US3>| Documents::closure9(_v113.clone(), v)
                        }),
                        (),
                    );
                    ()
                };
                let v133: Documents::US3 = defaultValue(Documents::US3::US3_1, _v113.get().clone());
                let v173: DateTime = match &v133 {
                    Documents::US3::US3_0(v133_0_0) => {
                        let v147: TimeSpan = TimeSpan::new_ticks(
                            {
                                let _arg: DateTime = DateTime::now();
                                _arg.ticks()
                            } - match &v133 {
                                Documents::US3::US3_0(x) => x.clone(),
                                _ => unreachable!(),
                            },
                        );
                        DateTime::new_ymdhms_milli(
                            1_i32,
                            1_i32,
                            1_i32,
                            v147.hours(),
                            v147.minutes(),
                            v147.seconds(),
                            v147.milliseconds(),
                        )
                    }
                    _ => DateTime::now(),
                };
                let v178: string = {
                    let provider: string = Documents::method6();
                    v173.toString(provider)
                };
                let v570: string = padLeft(toLower(string("Verbose")), 7_i32, ' ');
                let v586: &str = inline_colorization::color_bright_black;
                let v588: &str = &*v570;
                let v590: &str = inline_colorization::color_reset;
                let v592: string = string("format!(\"{v586}{v588}{v590}\")");
                let v593: std::string::String = format!("{v586}{v588}{v590}");
                let v595: string = fable_library_rust::String_::fromString(v593);
                let v636: i64 = (patternInput_2.0.clone()).l0.get().clone();
                let v638: LrcPtr<Documents::Mut3> = LrcPtr::new(Documents::Mut3 {
                    l0: MutCell::new(Documents::method9()),
                });
                let v697: string = if v0_1.clone() == string("") {
                    string("")
                } else {
                    trimEndChars(
                        trimStartChars(
                            sprintf!(
                                "{} {} #{} {} / {}",
                                v178,
                                v595,
                                v636,
                                v0_1,
                                v638.l0.get().clone()
                            ),
                            toArray(empty::<char>()),
                        ),
                        toArray(ofArray(new_array(&[' ', '/']))),
                    )
                };
                println!("{}", v697.clone());
                ();
                ((patternInput.1.clone()).l0.get().clone())(v697)
            }
        }
        pub fn closure44(
            unitVar: (),
            v0_1: std::sync::mpsc::SendError<std::string::String>,
        ) -> std::string::String {
            format!("{}", v0_1)
        }
        pub fn method67(
        ) -> Func1<std::sync::mpsc::SendError<std::string::String>, std::string::String> {
            Func1::new(move |v: std::sync::mpsc::SendError<std::string::String>| {
                Documents::closure44((), v)
            })
        }
        pub fn method68(v0_1: Result<(), string>) -> Result<(), string> {
            v0_1
        }
        pub fn closure45(
            v0_1: LrcPtr<MutCell<Option<Documents::US24>>>,
            v1_1: Option<Documents::US24>,
        ) -> LrcPtr<MutCell<Option<Documents::US24>>> {
            v0_1.set(v1_1);
            v0_1
        }
        pub fn closure46(
            v0_1: Option<Func1<std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>, ()>>,
            v1_1: Func1<Option<Documents::US24>, LrcPtr<MutCell<Option<Documents::US24>>>>,
            unitVar: (),
        ) {
            {
                let value: LrcPtr<MutCell<Option<Documents::US24>>> = v1_1(match &v0_1 {
                    None => None::<Documents::US24>,
                    Some(v0_1_0_0) => {
                        let x = v0_1_0_0.clone();
                        Some((Func0::new({
                            let x = x.clone();
                            move || Documents::US24::US24_0(x.clone())
                        }))())
                    }
                });
                ()
            }
            ()
        }
        pub fn closure47(
            v0_1: LrcPtr<MutCell<Option<Documents::US25>>>,
            v1_1: Option<Documents::US25>,
        ) -> LrcPtr<MutCell<Option<Documents::US25>>> {
            v0_1.set(v1_1);
            v0_1
        }
        pub fn closure48(
            v0_1: Option<std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>>,
            v1_1: Func1<Option<Documents::US25>, LrcPtr<MutCell<Option<Documents::US25>>>>,
            unitVar: (),
        ) {
            {
                let value: LrcPtr<MutCell<Option<Documents::US25>>> = v1_1(match &v0_1 {
                    None => None::<Documents::US25>,
                    Some(v0_1_0_0) => {
                        let x: std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>> =
                            v0_1_0_0.clone();
                        Some((Func0::new({
                            let x = x.clone();
                            move || Documents::US25::US25_0(x.clone())
                        }))())
                    }
                });
                ()
            }
            ()
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
        pub fn closure49(unitVar: (), v0_1: std::process::Output) -> Documents::US26 {
            Documents::US26::US26_0(v0_1)
        }
        pub fn closure50(unitVar: (), v0_1: std::string::String) -> Documents::US26 {
            Documents::US26::US26_1(v0_1)
        }
        pub fn closure51(v0_1: std::string::String, unitVar: ()) {
            fn v2() {
                Documents::closure7((), ());
            }
            let v3: () = {
                v2();
                ()
            };
            let patternInput: (
                LrcPtr<Documents::Mut0>,
                LrcPtr<Documents::Mut1>,
                LrcPtr<Documents::Mut2>,
                LrcPtr<Documents::Mut3>,
                LrcPtr<Documents::Mut4>,
                Option<i64>,
            ) = getValue(Documents::TraceState::trace_state().get().clone());
            let v36: () = {
                v2();
                ()
            };
            let patternInput_1: (
                LrcPtr<Documents::Mut0>,
                LrcPtr<Documents::Mut1>,
                LrcPtr<Documents::Mut2>,
                LrcPtr<Documents::Mut3>,
                LrcPtr<Documents::Mut4>,
                Option<i64>,
            ) = getValue(Documents::TraceState::trace_state().get().clone());
            let v68: Documents::US0 = (patternInput_1.4.clone()).l0.get().clone();
            if if (patternInput_1.2.clone()).l0.get().clone() == false {
                false
            } else {
                4_i32
                    >= find(
                        v68,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Documents::US0::US0_0, 0_i32)),
                            LrcPtr::new((Documents::US0::US0_1, 1_i32)),
                            LrcPtr::new((Documents::US0::US0_2, 2_i32)),
                            LrcPtr::new((Documents::US0::US0_3, 3_i32)),
                            LrcPtr::new((Documents::US0::US0_4, 4_i32)),
                        ])))),
                    )
            } {
                let v76: () = {
                    Documents::closure8(patternInput.0.clone(), ());
                    ()
                };
                let v80: () = {
                    v2();
                    ()
                };
                let patternInput_2: (
                    LrcPtr<Documents::Mut0>,
                    LrcPtr<Documents::Mut1>,
                    LrcPtr<Documents::Mut2>,
                    LrcPtr<Documents::Mut3>,
                    LrcPtr<Documents::Mut4>,
                    Option<i64>,
                ) = getValue(Documents::TraceState::trace_state().get().clone());
                let _v113: LrcPtr<MutCell<Option<Documents::US3>>> =
                    refCell(None::<Documents::US3>);
                let v118: () = {
                    Documents::closure10(
                        patternInput_2.5.clone(),
                        Func1::new({
                            let _v113 = _v113.clone();
                            move |v: Option<Documents::US3>| Documents::closure9(_v113.clone(), v)
                        }),
                        (),
                    );
                    ()
                };
                let v133: Documents::US3 = defaultValue(Documents::US3::US3_1, _v113.get().clone());
                let v173: DateTime = match &v133 {
                    Documents::US3::US3_0(v133_0_0) => {
                        let v147: TimeSpan = TimeSpan::new_ticks(
                            {
                                let _arg: DateTime = DateTime::now();
                                _arg.ticks()
                            } - match &v133 {
                                Documents::US3::US3_0(x) => x.clone(),
                                _ => unreachable!(),
                            },
                        );
                        DateTime::new_ymdhms_milli(
                            1_i32,
                            1_i32,
                            1_i32,
                            v147.hours(),
                            v147.minutes(),
                            v147.seconds(),
                            v147.milliseconds(),
                        )
                    }
                    _ => DateTime::now(),
                };
                let v178: string = {
                    let provider: string = Documents::method6();
                    v173.toString(provider)
                };
                let v570: string = padLeft(toLower(string("Critical")), 7_i32, ' ');
                let v586: &str = inline_colorization::color_bright_red;
                let v588: &str = &*v570;
                let v590: &str = inline_colorization::color_reset;
                let v592: string = string("format!(\"{v586}{v588}{v590}\")");
                let v593: std::string::String = format!("{v586}{v588}{v590}");
                let v595: string = fable_library_rust::String_::fromString(v593);
                let v636: i64 = (patternInput_2.0.clone()).l0.get().clone();
                let v638: LrcPtr<Documents::Mut3> = LrcPtr::new(Documents::Mut3 {
                    l0: MutCell::new(Documents::method9()),
                });
                let v645: () = {
                    Documents::closure11(v638.clone(), sprintf!("{}", string("{ ")), ());
                    ()
                };
                let v654: () = {
                    Documents::closure11(v638.clone(), sprintf!("{}", string("error")), ());
                    ()
                };
                let v663: () = {
                    Documents::closure11(v638.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v668: std::string::String = format!("{:#?}", v0_1);
                let v698: () = {
                    Documents::closure11(
                        v638.clone(),
                        sprintf!("{}", fable_library_rust::String_::fromString(v668)),
                        (),
                    );
                    ()
                };
                let v707: () = {
                    Documents::closure11(v638.clone(), sprintf!("{}", string(" }")), ());
                    ()
                };
                let v769: string = trimEndChars(
                    trimStartChars(
                        sprintf!(
                            "{} {} #{} {} / {}",
                            v178,
                            v595,
                            v636,
                            string("runtime.execute_with_options / output error"),
                            v638.l0.get().clone()
                        ),
                        toArray(empty::<char>()),
                    ),
                    toArray(ofArray(new_array(&[' ', '/']))),
                );
                println!("{}", v769.clone());
                ();
                ((patternInput.1.clone()).l0.get().clone())(v769)
            }
        }
        pub fn closure52(
            v0_1: LrcPtr<MutCell<Option<Documents::US27>>>,
            v1_1: Option<Documents::US27>,
        ) -> LrcPtr<MutCell<Option<Documents::US27>>> {
            v0_1.set(v1_1);
            v0_1
        }
        pub fn closure53(
            v0_1: Option<i32>,
            v1_1: Func1<Option<Documents::US27>, LrcPtr<MutCell<Option<Documents::US27>>>>,
            unitVar: (),
        ) {
            {
                let value: LrcPtr<MutCell<Option<Documents::US27>>> = v1_1(match &v0_1 {
                    None => None::<Documents::US27>,
                    Some(v0_1_0_0) => {
                        let x: i32 = v0_1_0_0.clone();
                        Some((Func0::new({
                            let x = x.clone();
                            move || Documents::US27::US27_0(x)
                        }))())
                    }
                });
                ()
            }
            ()
        }
        pub fn closure54(v0_1: i32, v1_1: string, unitVar: ()) {
            fn v3() {
                Documents::closure7((), ());
            }
            let v4: () = {
                v3();
                ()
            };
            let patternInput: (
                LrcPtr<Documents::Mut0>,
                LrcPtr<Documents::Mut1>,
                LrcPtr<Documents::Mut2>,
                LrcPtr<Documents::Mut3>,
                LrcPtr<Documents::Mut4>,
                Option<i64>,
            ) = getValue(Documents::TraceState::trace_state().get().clone());
            let v37: () = {
                v3();
                ()
            };
            let patternInput_1: (
                LrcPtr<Documents::Mut0>,
                LrcPtr<Documents::Mut1>,
                LrcPtr<Documents::Mut2>,
                LrcPtr<Documents::Mut3>,
                LrcPtr<Documents::Mut4>,
                Option<i64>,
            ) = getValue(Documents::TraceState::trace_state().get().clone());
            let v69: Documents::US0 = (patternInput_1.4.clone()).l0.get().clone();
            if if (patternInput_1.2.clone()).l0.get().clone() == false {
                false
            } else {
                0_i32
                    >= find(
                        v69,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Documents::US0::US0_0, 0_i32)),
                            LrcPtr::new((Documents::US0::US0_1, 1_i32)),
                            LrcPtr::new((Documents::US0::US0_2, 2_i32)),
                            LrcPtr::new((Documents::US0::US0_3, 3_i32)),
                            LrcPtr::new((Documents::US0::US0_4, 4_i32)),
                        ])))),
                    )
            } {
                let v77: () = {
                    Documents::closure8(patternInput.0.clone(), ());
                    ()
                };
                let v81: () = {
                    v3();
                    ()
                };
                let patternInput_2: (
                    LrcPtr<Documents::Mut0>,
                    LrcPtr<Documents::Mut1>,
                    LrcPtr<Documents::Mut2>,
                    LrcPtr<Documents::Mut3>,
                    LrcPtr<Documents::Mut4>,
                    Option<i64>,
                ) = getValue(Documents::TraceState::trace_state().get().clone());
                let _v114: LrcPtr<MutCell<Option<Documents::US3>>> =
                    refCell(None::<Documents::US3>);
                let v119: () = {
                    Documents::closure10(
                        patternInput_2.5.clone(),
                        Func1::new({
                            let _v114 = _v114.clone();
                            move |v: Option<Documents::US3>| Documents::closure9(_v114.clone(), v)
                        }),
                        (),
                    );
                    ()
                };
                let v134: Documents::US3 = defaultValue(Documents::US3::US3_1, _v114.get().clone());
                let v174: DateTime = match &v134 {
                    Documents::US3::US3_0(v134_0_0) => {
                        let v148: TimeSpan = TimeSpan::new_ticks(
                            {
                                let _arg: DateTime = DateTime::now();
                                _arg.ticks()
                            } - match &v134 {
                                Documents::US3::US3_0(x) => x.clone(),
                                _ => unreachable!(),
                            },
                        );
                        DateTime::new_ymdhms_milli(
                            1_i32,
                            1_i32,
                            1_i32,
                            v148.hours(),
                            v148.minutes(),
                            v148.seconds(),
                            v148.milliseconds(),
                        )
                    }
                    _ => DateTime::now(),
                };
                let v179: string = {
                    let provider: string = Documents::method6();
                    v174.toString(provider)
                };
                let v571: string = padLeft(toLower(string("Verbose")), 7_i32, ' ');
                let v587: &str = inline_colorization::color_bright_black;
                let v589: &str = &*v571;
                let v591: &str = inline_colorization::color_reset;
                let v593: string = string("format!(\"{v587}{v589}{v591}\")");
                let v594: std::string::String = format!("{v587}{v589}{v591}");
                let v596: string = fable_library_rust::String_::fromString(v594);
                let v637: i64 = (patternInput_2.0.clone()).l0.get().clone();
                let v638: i32 = length(v1_1);
                let v640: LrcPtr<Documents::Mut3> = LrcPtr::new(Documents::Mut3 {
                    l0: MutCell::new(Documents::method9()),
                });
                let v647: () = {
                    Documents::closure11(v640.clone(), sprintf!("{}", string("{ ")), ());
                    ()
                };
                let v656: () = {
                    Documents::closure11(v640.clone(), sprintf!("{}", string("exit_code")), ());
                    ()
                };
                let v665: () = {
                    Documents::closure11(v640.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v673: () = {
                    Documents::closure11(v640.clone(), sprintf!("{}", v0_1), ());
                    ()
                };
                let v682: () = {
                    Documents::closure11(v640.clone(), sprintf!("{}", string("; ")), ());
                    ()
                };
                let v691: () = {
                    Documents::closure11(
                        v640.clone(),
                        sprintf!("{}", string("std_trace_length")),
                        (),
                    );
                    ()
                };
                let v699: () = {
                    Documents::closure11(v640.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v707: () = {
                    Documents::closure11(v640.clone(), sprintf!("{}", v638), ());
                    ()
                };
                let v716: () = {
                    Documents::closure11(v640.clone(), sprintf!("{}", string(" }")), ());
                    ()
                };
                let v778: string = trimEndChars(
                    trimStartChars(
                        sprintf!(
                            "{} {} #{} {} / {}",
                            v179,
                            v596,
                            v637,
                            string("runtime.execute_with_options / result"),
                            v640.l0.get().clone()
                        ),
                        toArray(empty::<char>()),
                    ),
                    toArray(ofArray(new_array(&[' ', '/']))),
                );
                println!("{}", v778.clone());
                ();
                ((patternInput.1.clone()).l0.get().clone())(v778)
            }
        }
        pub fn closure55(
            v0_1: string,
            v1_1: Option<CancellationToken>,
            v2: Array<(string, string)>,
            v3: Option<Func1<(i32, string, bool), Arc<Async<()>>>>,
            v4: Option<Func1<std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>, ()>>,
            v5: bool,
            v6: Option<string>,
            unitVar: (),
        ) {
            fn v8() {
                Documents::closure7((), ());
            }
            let v9: () = {
                v8();
                ()
            };
            let patternInput: (
                LrcPtr<Documents::Mut0>,
                LrcPtr<Documents::Mut1>,
                LrcPtr<Documents::Mut2>,
                LrcPtr<Documents::Mut3>,
                LrcPtr<Documents::Mut4>,
                Option<i64>,
            ) = getValue(Documents::TraceState::trace_state().get().clone());
            let v42: () = {
                v8();
                ()
            };
            let patternInput_1: (
                LrcPtr<Documents::Mut0>,
                LrcPtr<Documents::Mut1>,
                LrcPtr<Documents::Mut2>,
                LrcPtr<Documents::Mut3>,
                LrcPtr<Documents::Mut4>,
                Option<i64>,
            ) = getValue(Documents::TraceState::trace_state().get().clone());
            let v74: Documents::US0 = (patternInput_1.4.clone()).l0.get().clone();
            if if (patternInput_1.2.clone()).l0.get().clone() == false {
                false
            } else {
                1_i32
                    >= find(
                        v74,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Documents::US0::US0_0, 0_i32)),
                            LrcPtr::new((Documents::US0::US0_1, 1_i32)),
                            LrcPtr::new((Documents::US0::US0_2, 2_i32)),
                            LrcPtr::new((Documents::US0::US0_3, 3_i32)),
                            LrcPtr::new((Documents::US0::US0_4, 4_i32)),
                        ])))),
                    )
            } {
                let v82: () = {
                    Documents::closure8(patternInput.0.clone(), ());
                    ()
                };
                let v86: () = {
                    v8();
                    ()
                };
                let patternInput_2: (
                    LrcPtr<Documents::Mut0>,
                    LrcPtr<Documents::Mut1>,
                    LrcPtr<Documents::Mut2>,
                    LrcPtr<Documents::Mut3>,
                    LrcPtr<Documents::Mut4>,
                    Option<i64>,
                ) = getValue(Documents::TraceState::trace_state().get().clone());
                let _v119: LrcPtr<MutCell<Option<Documents::US3>>> =
                    refCell(None::<Documents::US3>);
                let v124: () = {
                    Documents::closure10(
                        patternInput_2.5.clone(),
                        Func1::new({
                            let _v119 = _v119.clone();
                            move |v: Option<Documents::US3>| Documents::closure9(_v119.clone(), v)
                        }),
                        (),
                    );
                    ()
                };
                let v139: Documents::US3 = defaultValue(Documents::US3::US3_1, _v119.get().clone());
                let v179: DateTime = match &v139 {
                    Documents::US3::US3_0(v139_0_0) => {
                        let v153: TimeSpan = TimeSpan::new_ticks(
                            {
                                let _arg: DateTime = DateTime::now();
                                _arg.ticks()
                            } - match &v139 {
                                Documents::US3::US3_0(x) => x.clone(),
                                _ => unreachable!(),
                            },
                        );
                        DateTime::new_ymdhms_milli(
                            1_i32,
                            1_i32,
                            1_i32,
                            v153.hours(),
                            v153.minutes(),
                            v153.seconds(),
                            v153.milliseconds(),
                        )
                    }
                    _ => DateTime::now(),
                };
                let v184: string = {
                    let provider: string = Documents::method6();
                    v179.toString(provider)
                };
                let v576: string = padLeft(toLower(string("Debug")), 7_i32, ' ');
                let v592: &str = inline_colorization::color_bright_blue;
                let v594: &str = &*v576;
                let v596: &str = inline_colorization::color_reset;
                let v598: string = string("format!(\"{v592}{v594}{v596}\")");
                let v599: std::string::String = format!("{v592}{v594}{v596}");
                let v601: string = fable_library_rust::String_::fromString(v599);
                let v642: i64 = (patternInput_2.0.clone()).l0.get().clone();
                let v644: LrcPtr<Documents::Mut3> = LrcPtr::new(Documents::Mut3 {
                    l0: MutCell::new(Documents::method9()),
                });
                let v651: () = {
                    Documents::closure11(v644.clone(), sprintf!("{}", string("{ ")), ());
                    ()
                };
                let v660: () = {
                    Documents::closure11(v644.clone(), sprintf!("{}", string("options")), ());
                    ()
                };
                let v669: () = {
                    Documents::closure11(v644.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v677: () = {
                    Documents::closure11(v644.clone(), sprintf!("{}", string("{ ")), ());
                    ()
                };
                let v686: () = {
                    Documents::closure11(v644.clone(), sprintf!("{}", string("command")), ());
                    ()
                };
                let v694: () = {
                    Documents::closure11(v644.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v702: () = {
                    Documents::closure11(v644.clone(), sprintf!("{}", v0_1), ());
                    ()
                };
                let v711: () = {
                    Documents::closure11(v644.clone(), sprintf!("{}", string("; ")), ());
                    ()
                };
                let v720: () = {
                    Documents::closure11(
                        v644.clone(),
                        sprintf!("{}", string("cancellation_token")),
                        (),
                    );
                    ()
                };
                let v728: () = {
                    Documents::closure11(v644.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v733: std::string::String = format!("{:#?}", v1_1);
                let v763: () = {
                    Documents::closure11(
                        v644.clone(),
                        sprintf!("{}", fable_library_rust::String_::fromString(v733)),
                        (),
                    );
                    ()
                };
                let v771: () = {
                    Documents::closure11(v644.clone(), sprintf!("{}", string("; ")), ());
                    ()
                };
                let v780: () = {
                    Documents::closure11(
                        v644.clone(),
                        sprintf!("{}", string("environment_variables")),
                        (),
                    );
                    ()
                };
                let v788: () = {
                    Documents::closure11(v644.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v799: () = {
                    Documents::closure11(v644.clone(), sprintf!("{}", sprintf!("{:?}", v2)), ());
                    ()
                };
                let v807: () = {
                    Documents::closure11(v644.clone(), sprintf!("{}", string("; ")), ());
                    ()
                };
                let v816: () = {
                    Documents::closure11(v644.clone(), sprintf!("{}", string("on_line")), ());
                    ()
                };
                let v824: () = {
                    Documents::closure11(v644.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v829: std::string::String = format!("{:#?}", v3);
                let v859: () = {
                    Documents::closure11(
                        v644.clone(),
                        sprintf!("{}", fable_library_rust::String_::fromString(v829)),
                        (),
                    );
                    ()
                };
                let v867: () = {
                    Documents::closure11(v644.clone(), sprintf!("{}", string("; ")), ());
                    ()
                };
                let v876: () = {
                    Documents::closure11(v644.clone(), sprintf!("{}", string("stdin")), ());
                    ()
                };
                let v884: () = {
                    Documents::closure11(v644.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v889: std::string::String = format!("{:#?}", v4);
                let v919: () = {
                    Documents::closure11(
                        v644.clone(),
                        sprintf!("{}", fable_library_rust::String_::fromString(v889)),
                        (),
                    );
                    ()
                };
                let v927: () = {
                    Documents::closure11(v644.clone(), sprintf!("{}", string("; ")), ());
                    ()
                };
                let v936: () = {
                    Documents::closure11(v644.clone(), sprintf!("{}", string("trace")), ());
                    ()
                };
                let v944: () = {
                    Documents::closure11(v644.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v955: () = {
                    Documents::closure11(
                        v644.clone(),
                        sprintf!("{}", if v5 { string("true") } else { string("false") }),
                        (),
                    );
                    ()
                };
                let v963: () = {
                    Documents::closure11(v644.clone(), sprintf!("{}", string("; ")), ());
                    ()
                };
                let v972: () = {
                    Documents::closure11(
                        v644.clone(),
                        sprintf!("{}", string("working_directory")),
                        (),
                    );
                    ()
                };
                let v980: () = {
                    Documents::closure11(v644.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v985: std::string::String = format!("{:#?}", v6);
                let v1015: () = {
                    Documents::closure11(
                        v644.clone(),
                        sprintf!("{}", fable_library_rust::String_::fromString(v985)),
                        (),
                    );
                    ()
                };
                let v1024: () = {
                    Documents::closure11(v644.clone(), sprintf!("{}", string(" }")), ());
                    ()
                };
                let v1032: () = {
                    Documents::closure11(v644.clone(), sprintf!("{}", string(" }")), ());
                    ()
                };
                let v1094: string = trimEndChars(
                    trimStartChars(
                        sprintf!(
                            "{} {} #{} {} / {}",
                            v184,
                            v601,
                            v642,
                            string("runtime.execute_with_options_async"),
                            v644.l0.get().clone()
                        ),
                        toArray(empty::<char>()),
                    ),
                    toArray(ofArray(new_array(&[' ', '/']))),
                );
                println!("{}", v1094.clone());
                ();
                ((patternInput.1.clone()).l0.get().clone())(v1094)
            }
        }
        pub fn closure57(
            v0_1: LrcPtr<MutCell<Option<Documents::US28>>>,
            v1_1: Option<Documents::US28>,
        ) -> LrcPtr<MutCell<Option<Documents::US28>>> {
            v0_1.set(v1_1);
            v0_1
        }
        pub fn closure58(
            v0_1: Option<Func1<(i32, string, bool), Arc<Async<()>>>>,
            v1_1: Func1<Option<Documents::US28>, LrcPtr<MutCell<Option<Documents::US28>>>>,
            unitVar: (),
        ) {
            {
                let value: LrcPtr<MutCell<Option<Documents::US28>>> = v1_1(match &v0_1 {
                    None => None::<Documents::US28>,
                    Some(v0_1_0_0) => {
                        let x = v0_1_0_0.clone();
                        Some((Func0::new({
                            let x = x.clone();
                            move || Documents::US28::US28_0(x.clone())
                        }))())
                    }
                });
                ()
            }
            ()
        }
        pub fn closure59(v0_1: string, unitVar: ()) {
            fn v2() {
                Documents::closure7((), ());
            }
            let v3: () = {
                v2();
                ()
            };
            let patternInput: (
                LrcPtr<Documents::Mut0>,
                LrcPtr<Documents::Mut1>,
                LrcPtr<Documents::Mut2>,
                LrcPtr<Documents::Mut3>,
                LrcPtr<Documents::Mut4>,
                Option<i64>,
            ) = getValue(Documents::TraceState::trace_state().get().clone());
            let v36: () = {
                v2();
                ()
            };
            let patternInput_1: (
                LrcPtr<Documents::Mut0>,
                LrcPtr<Documents::Mut1>,
                LrcPtr<Documents::Mut2>,
                LrcPtr<Documents::Mut3>,
                LrcPtr<Documents::Mut4>,
                Option<i64>,
            ) = getValue(Documents::TraceState::trace_state().get().clone());
            let v68: Documents::US0 = (patternInput_1.4.clone()).l0.get().clone();
            if if (patternInput_1.2.clone()).l0.get().clone() == false {
                false
            } else {
                0_i32
                    >= find(
                        v68,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Documents::US0::US0_0, 0_i32)),
                            LrcPtr::new((Documents::US0::US0_1, 1_i32)),
                            LrcPtr::new((Documents::US0::US0_2, 2_i32)),
                            LrcPtr::new((Documents::US0::US0_3, 3_i32)),
                            LrcPtr::new((Documents::US0::US0_4, 4_i32)),
                        ])))),
                    )
            } {
                let v76: () = {
                    Documents::closure8(patternInput.0.clone(), ());
                    ()
                };
                let v80: () = {
                    v2();
                    ()
                };
                let patternInput_2: (
                    LrcPtr<Documents::Mut0>,
                    LrcPtr<Documents::Mut1>,
                    LrcPtr<Documents::Mut2>,
                    LrcPtr<Documents::Mut3>,
                    LrcPtr<Documents::Mut4>,
                    Option<i64>,
                ) = getValue(Documents::TraceState::trace_state().get().clone());
                let _v113: LrcPtr<MutCell<Option<Documents::US3>>> =
                    refCell(None::<Documents::US3>);
                let v118: () = {
                    Documents::closure10(
                        patternInput_2.5.clone(),
                        Func1::new({
                            let _v113 = _v113.clone();
                            move |v: Option<Documents::US3>| Documents::closure9(_v113.clone(), v)
                        }),
                        (),
                    );
                    ()
                };
                let v133: Documents::US3 = defaultValue(Documents::US3::US3_1, _v113.get().clone());
                let v173: DateTime = match &v133 {
                    Documents::US3::US3_0(v133_0_0) => {
                        let v147: TimeSpan = TimeSpan::new_ticks(
                            {
                                let _arg: DateTime = DateTime::now();
                                _arg.ticks()
                            } - match &v133 {
                                Documents::US3::US3_0(x) => x.clone(),
                                _ => unreachable!(),
                            },
                        );
                        DateTime::new_ymdhms_milli(
                            1_i32,
                            1_i32,
                            1_i32,
                            v147.hours(),
                            v147.minutes(),
                            v147.seconds(),
                            v147.milliseconds(),
                        )
                    }
                    _ => DateTime::now(),
                };
                let v178: string = {
                    let provider: string = Documents::method6();
                    v173.toString(provider)
                };
                let v570: string = padLeft(toLower(string("Verbose")), 7_i32, ' ');
                let v586: &str = inline_colorization::color_bright_black;
                let v588: &str = &*v570;
                let v590: &str = inline_colorization::color_reset;
                let v592: string = string("format!(\"{v586}{v588}{v590}\")");
                let v593: std::string::String = format!("{v586}{v588}{v590}");
                let v595: string = fable_library_rust::String_::fromString(v593);
                let v636: i64 = (patternInput_2.0.clone()).l0.get().clone();
                let v638: LrcPtr<Documents::Mut3> = LrcPtr::new(Documents::Mut3 {
                    l0: MutCell::new(Documents::method9()),
                });
                let v697: string = if v0_1.clone() == string("") {
                    string("")
                } else {
                    trimEndChars(
                        trimStartChars(
                            sprintf!(
                                "{} {} #{} {} / {}",
                                v178,
                                v595,
                                v636,
                                v0_1,
                                v638.l0.get().clone()
                            ),
                            toArray(empty::<char>()),
                        ),
                        toArray(ofArray(new_array(&[' ', '/']))),
                    )
                };
                println!("{}", v697.clone());
                ();
                ((patternInput.1.clone()).l0.get().clone())(v697)
            }
        }
        pub fn closure56(
            v0_1: string,
            v1_1: Option<CancellationToken>,
            v2: Array<(string, string)>,
            v3: Option<Func1<(i32, string, bool), Arc<Async<()>>>>,
            v4: Option<Func1<std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>, ()>>,
            v5: bool,
            v6: Option<string>,
            v7: (),
            v8: LrcPtr<ConcurrentStack_1<string>>,
            v9: (),
        ) {
            let v11: Arc<Async<()>> = defaultOf();
            defaultOf::<()>();
            ();
            ()
        }
        pub fn closure60(
            v0_1: string,
            v1_1: Option<CancellationToken>,
            v2: Array<(string, string)>,
            v3: Option<Func1<(i32, string, bool), Arc<Async<()>>>>,
            v4: Option<Func1<std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>, ()>>,
            v5: bool,
            v6: Option<string>,
            v7: (),
            v8: LrcPtr<ConcurrentStack_1<string>>,
            v9: (),
        ) {
            let v11: Arc<Async<()>> = defaultOf();
            defaultOf::<()>();
            ();
            ()
        }
        pub fn closure61(
            v0_1: LrcPtr<MutCell<Option<Documents::US29>>>,
            v1_1: Option<Documents::US29>,
        ) -> LrcPtr<MutCell<Option<Documents::US29>>> {
            v0_1.set(v1_1);
            v0_1
        }
        pub fn closure62(
            v0_1: Option<CancellationToken>,
            v1_1: Func1<Option<Documents::US29>, LrcPtr<MutCell<Option<Documents::US29>>>>,
            unitVar: (),
        ) {
            {
                let value: LrcPtr<MutCell<Option<Documents::US29>>> = v1_1(match &v0_1 {
                    None => None::<Documents::US29>,
                    Some(v0_1_0_0) => {
                        let x: CancellationToken = v0_1_0_0.clone();
                        Some((Func0::new({
                            let x = x.clone();
                            move || Documents::US29::US29_0(x.clone())
                        }))())
                    }
                });
                ()
            }
            ()
        }
        pub fn closure63(v0_1: (), unitVar: ()) {
            if unbox::<bool>(&defaultOf()) == false {
                ();
                ()
            };
        }
        pub fn closure64(v0_1: LrcPtr<TaskCanceledException>, unitVar: ()) {
            fn v2() {
                Documents::closure7((), ());
            }
            let v3: () = {
                v2();
                ()
            };
            let patternInput: (
                LrcPtr<Documents::Mut0>,
                LrcPtr<Documents::Mut1>,
                LrcPtr<Documents::Mut2>,
                LrcPtr<Documents::Mut3>,
                LrcPtr<Documents::Mut4>,
                Option<i64>,
            ) = getValue(Documents::TraceState::trace_state().get().clone());
            let v36: () = {
                v2();
                ()
            };
            let patternInput_1: (
                LrcPtr<Documents::Mut0>,
                LrcPtr<Documents::Mut1>,
                LrcPtr<Documents::Mut2>,
                LrcPtr<Documents::Mut3>,
                LrcPtr<Documents::Mut4>,
                Option<i64>,
            ) = getValue(Documents::TraceState::trace_state().get().clone());
            let v68: Documents::US0 = (patternInput_1.4.clone()).l0.get().clone();
            if if (patternInput_1.2.clone()).l0.get().clone() == false {
                false
            } else {
                3_i32
                    >= find(
                        v68,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Documents::US0::US0_0, 0_i32)),
                            LrcPtr::new((Documents::US0::US0_1, 1_i32)),
                            LrcPtr::new((Documents::US0::US0_2, 2_i32)),
                            LrcPtr::new((Documents::US0::US0_3, 3_i32)),
                            LrcPtr::new((Documents::US0::US0_4, 4_i32)),
                        ])))),
                    )
            } {
                let v76: () = {
                    Documents::closure8(patternInput.0.clone(), ());
                    ()
                };
                let v80: () = {
                    v2();
                    ()
                };
                let patternInput_2: (
                    LrcPtr<Documents::Mut0>,
                    LrcPtr<Documents::Mut1>,
                    LrcPtr<Documents::Mut2>,
                    LrcPtr<Documents::Mut3>,
                    LrcPtr<Documents::Mut4>,
                    Option<i64>,
                ) = getValue(Documents::TraceState::trace_state().get().clone());
                let _v113: LrcPtr<MutCell<Option<Documents::US3>>> =
                    refCell(None::<Documents::US3>);
                let v118: () = {
                    Documents::closure10(
                        patternInput_2.5.clone(),
                        Func1::new({
                            let _v113 = _v113.clone();
                            move |v: Option<Documents::US3>| Documents::closure9(_v113.clone(), v)
                        }),
                        (),
                    );
                    ()
                };
                let v133: Documents::US3 = defaultValue(Documents::US3::US3_1, _v113.get().clone());
                let v173: DateTime = match &v133 {
                    Documents::US3::US3_0(v133_0_0) => {
                        let v147: TimeSpan = TimeSpan::new_ticks(
                            {
                                let _arg: DateTime = DateTime::now();
                                _arg.ticks()
                            } - match &v133 {
                                Documents::US3::US3_0(x) => x.clone(),
                                _ => unreachable!(),
                            },
                        );
                        DateTime::new_ymdhms_milli(
                            1_i32,
                            1_i32,
                            1_i32,
                            v147.hours(),
                            v147.minutes(),
                            v147.seconds(),
                            v147.milliseconds(),
                        )
                    }
                    _ => DateTime::now(),
                };
                let v178: string = {
                    let provider: string = Documents::method6();
                    v173.toString(provider)
                };
                let v570: string = padLeft(toLower(string("Warning")), 7_i32, ' ');
                let v586: &str = inline_colorization::color_yellow;
                let v588: &str = &*v570;
                let v590: &str = inline_colorization::color_reset;
                let v592: string = string("format!(\"{v586}{v588}{v590}\")");
                let v593: std::string::String = format!("{v586}{v588}{v590}");
                let v595: string = fable_library_rust::String_::fromString(v593);
                let v636: i64 = (patternInput_2.0.clone()).l0.get().clone();
                let v638: LrcPtr<Documents::Mut3> = LrcPtr::new(Documents::Mut3 {
                    l0: MutCell::new(Documents::method9()),
                });
                let v645: () = {
                    Documents::closure11(v638.clone(), sprintf!("{}", string("{ ")), ());
                    ()
                };
                let v654: () = {
                    Documents::closure11(v638.clone(), sprintf!("{}", string("ex")), ());
                    ()
                };
                let v663: () = {
                    Documents::closure11(v638.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v668: std::string::String = format!("{:#?}", v0_1);
                let v698: () = {
                    Documents::closure11(
                        v638.clone(),
                        sprintf!("{}", fable_library_rust::String_::fromString(v668)),
                        (),
                    );
                    ()
                };
                let v707: () = {
                    Documents::closure11(v638.clone(), sprintf!("{}", string(" }")), ());
                    ()
                };
                let v769: string = trimEndChars(
                    trimStartChars(
                        sprintf!(
                            "{} {} #{} {} / {}",
                            v178,
                            v595,
                            v636,
                            string("runtime.execute_with_options_async / WaitForExitAsync"),
                            v638.l0.get().clone()
                        ),
                        toArray(empty::<char>()),
                    ),
                    toArray(ofArray(new_array(&[' ', '/']))),
                );
                println!("{}", v769.clone());
                ();
                ((patternInput.1.clone()).l0.get().clone())(v769)
            }
        }
        pub fn closure65(v0_1: i32, v1_1: string, unitVar: ()) {
            fn v3() {
                Documents::closure7((), ());
            }
            let v4: () = {
                v3();
                ()
            };
            let patternInput: (
                LrcPtr<Documents::Mut0>,
                LrcPtr<Documents::Mut1>,
                LrcPtr<Documents::Mut2>,
                LrcPtr<Documents::Mut3>,
                LrcPtr<Documents::Mut4>,
                Option<i64>,
            ) = getValue(Documents::TraceState::trace_state().get().clone());
            let v37: () = {
                v3();
                ()
            };
            let patternInput_1: (
                LrcPtr<Documents::Mut0>,
                LrcPtr<Documents::Mut1>,
                LrcPtr<Documents::Mut2>,
                LrcPtr<Documents::Mut3>,
                LrcPtr<Documents::Mut4>,
                Option<i64>,
            ) = getValue(Documents::TraceState::trace_state().get().clone());
            let v69: Documents::US0 = (patternInput_1.4.clone()).l0.get().clone();
            if if (patternInput_1.2.clone()).l0.get().clone() == false {
                false
            } else {
                1_i32
                    >= find(
                        v69,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Documents::US0::US0_0, 0_i32)),
                            LrcPtr::new((Documents::US0::US0_1, 1_i32)),
                            LrcPtr::new((Documents::US0::US0_2, 2_i32)),
                            LrcPtr::new((Documents::US0::US0_3, 3_i32)),
                            LrcPtr::new((Documents::US0::US0_4, 4_i32)),
                        ])))),
                    )
            } {
                let v77: () = {
                    Documents::closure8(patternInput.0.clone(), ());
                    ()
                };
                let v81: () = {
                    v3();
                    ()
                };
                let patternInput_2: (
                    LrcPtr<Documents::Mut0>,
                    LrcPtr<Documents::Mut1>,
                    LrcPtr<Documents::Mut2>,
                    LrcPtr<Documents::Mut3>,
                    LrcPtr<Documents::Mut4>,
                    Option<i64>,
                ) = getValue(Documents::TraceState::trace_state().get().clone());
                let _v114: LrcPtr<MutCell<Option<Documents::US3>>> =
                    refCell(None::<Documents::US3>);
                let v119: () = {
                    Documents::closure10(
                        patternInput_2.5.clone(),
                        Func1::new({
                            let _v114 = _v114.clone();
                            move |v: Option<Documents::US3>| Documents::closure9(_v114.clone(), v)
                        }),
                        (),
                    );
                    ()
                };
                let v134: Documents::US3 = defaultValue(Documents::US3::US3_1, _v114.get().clone());
                let v174: DateTime = match &v134 {
                    Documents::US3::US3_0(v134_0_0) => {
                        let v148: TimeSpan = TimeSpan::new_ticks(
                            {
                                let _arg: DateTime = DateTime::now();
                                _arg.ticks()
                            } - match &v134 {
                                Documents::US3::US3_0(x) => x.clone(),
                                _ => unreachable!(),
                            },
                        );
                        DateTime::new_ymdhms_milli(
                            1_i32,
                            1_i32,
                            1_i32,
                            v148.hours(),
                            v148.minutes(),
                            v148.seconds(),
                            v148.milliseconds(),
                        )
                    }
                    _ => DateTime::now(),
                };
                let v179: string = {
                    let provider: string = Documents::method6();
                    v174.toString(provider)
                };
                let v571: string = padLeft(toLower(string("Debug")), 7_i32, ' ');
                let v587: &str = inline_colorization::color_bright_blue;
                let v589: &str = &*v571;
                let v591: &str = inline_colorization::color_reset;
                let v593: string = string("format!(\"{v587}{v589}{v591}\")");
                let v594: std::string::String = format!("{v587}{v589}{v591}");
                let v596: string = fable_library_rust::String_::fromString(v594);
                let v637: i64 = (patternInput_2.0.clone()).l0.get().clone();
                let v638: i32 = length(v1_1);
                let v640: LrcPtr<Documents::Mut3> = LrcPtr::new(Documents::Mut3 {
                    l0: MutCell::new(Documents::method9()),
                });
                let v647: () = {
                    Documents::closure11(v640.clone(), sprintf!("{}", string("{ ")), ());
                    ()
                };
                let v656: () = {
                    Documents::closure11(v640.clone(), sprintf!("{}", string("exit_code")), ());
                    ()
                };
                let v665: () = {
                    Documents::closure11(v640.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v673: () = {
                    Documents::closure11(v640.clone(), sprintf!("{}", v0_1), ());
                    ()
                };
                let v682: () = {
                    Documents::closure11(v640.clone(), sprintf!("{}", string("; ")), ());
                    ()
                };
                let v691: () = {
                    Documents::closure11(v640.clone(), sprintf!("{}", string("output_length")), ());
                    ()
                };
                let v699: () = {
                    Documents::closure11(v640.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v707: () = {
                    Documents::closure11(v640.clone(), sprintf!("{}", v638), ());
                    ()
                };
                let v716: () = {
                    Documents::closure11(v640.clone(), sprintf!("{}", string(" }")), ());
                    ()
                };
                let v778: string = trimEndChars(
                    trimStartChars(
                        sprintf!(
                            "{} {} #{} {} / {}",
                            v179,
                            v596,
                            v637,
                            string("runtime.execute_with_options_async"),
                            v640.l0.get().clone()
                        ),
                        toArray(empty::<char>()),
                    ),
                    toArray(ofArray(new_array(&[' ', '/']))),
                );
                println!("{}", v778.clone());
                ();
                ((patternInput.1.clone()).l0.get().clone())(v778)
            }
        }
        pub fn method71(
            v0_1: string,
            v1_1: Option<CancellationToken>,
            v2: Array<(string, string)>,
            v3: Option<Func1<(i32, string, bool), Arc<Async<()>>>>,
            v4: Option<Func1<std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>, ()>>,
            v5: bool,
            v6: Option<string>,
        ) -> Arc<Async<(i32, string)>> {
            defaultOf()
        }
        pub fn method39(
            v0_1: string,
            v1_1: Option<CancellationToken>,
            v2: Array<(string, string)>,
            v3: Option<Func1<(i32, string, bool), Arc<Async<()>>>>,
            v4: Option<Func1<std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>, ()>>,
            v5: bool,
            v6: Option<string>,
        ) -> (i32, string) {
            let v9: Documents::US11 = Documents::method41(Documents::method40(
                v0_1.clone(),
                v1_1.clone(),
                v2.clone(),
                v3.clone(),
                v4.clone(),
                v5,
                v6.clone(),
            ));
            let patternInput: (string, Documents::US1) = match &v9 {
                Documents::US11::US11_0(v9_0_0, v9_0_1) => (v9_0_0.clone(), v9_0_1.clone()),
                Documents::US11::US11_1(v9_1_0) => panic!(
                    "{}",
                    sprintf!("resultm.get / Result value was Error: {}", v9_1_0.clone()),
                ),
            };
            let v19: Documents::US1 = patternInput.1.clone();
            let v18: string = patternInput.0.clone();
            let v24: Documents::US19 = Documents::method52(match &v19 {
                Documents::US1::US1_0(v19_0_0) => match &v19 {
                    Documents::US1::US1_0(x) => x.clone(),
                    _ => unreachable!(),
                },
                _ => string(""),
            });
            let v30: Array<string> = match &v24 {
                Documents::US19::US19_0(v24_0_0) => v24_0_0.clone(),
                Documents::US19::US19_1(v24_1_0) => panic!(
                    "{}",
                    sprintf!("resultm.get / Result value was Error: {}", v24_1_0.clone()),
                ),
            };
            let v32: Vec<string> = v30.to_vec();
            let v34: bool = true;
            let _vec_map: Vec<_> = v32
                .into_iter()
                .map(|x| {
                    //;
                    let v36: string = x;
                    let v38: &str = &*v36;
                    let v40: std::string::String = String::from(v38);
                    let v42: bool = true;
                    v40
                })
                .collect::<Vec<_>>();
            let v44: Vec<std::string::String> = _vec_map;
            let v47: () = {
                Documents::closure36(
                    v0_1,
                    v1_1,
                    v2.clone(),
                    v3,
                    v4.clone(),
                    v5,
                    v6.clone(),
                    v18.clone(),
                    v44.clone(),
                    (),
                );
                ()
            };
            let _v1283: MutCell<Option<LrcPtr<(i32, string)>>> =
                MutCell::new(None::<LrcPtr<(i32, string)>>);
            {
                let x_3: LrcPtr<(i32, string)> = (Func0::new({
                    let v18 = v18.clone();
                    let v2 = v2.clone();
                    let v4 = v4.clone();
                    let v44 = v44.clone();
                    let v5 = v5.clone();
                    let v6 = v6.clone();
                    move || {
                        let v1285: std::process::Command =
                            std::process::Command::new(&*v18.clone());
                        let v1287: bool = true;
                        let mut v1285 = v1285;
                        let v1289: &mut std::process::Command =
                            std::process::Command::args(&mut v1285, &*v44.clone());
                        let v1291: std::process::Stdio = std::process::Stdio::piped();
                        let v1293: &mut std::process::Command =
                            std::process::Command::stdout(v1289, std::process::Stdio::piped());
                        let v1295: std::process::Stdio = std::process::Stdio::piped();
                        let v1297: &mut std::process::Command =
                            std::process::Command::stderr(v1293, std::process::Stdio::piped());
                        let v1299: std::process::Stdio = std::process::Stdio::piped();
                        let v1301: &mut std::process::Command =
                            std::process::Command::stdin(v1297, std::process::Stdio::piped());
                        let _v1302: LrcPtr<MutCell<Option<Documents::US1>>> =
                            refCell(None::<Documents::US1>);
                        let v1307: () = {
                            Documents::closure4(
                                v6.clone(),
                                Func1::new({
                                    let _v1302 = _v1302.clone();
                                    move |v: Option<Documents::US1>| {
                                        Documents::closure3(_v1302.clone(), v)
                                    }
                                }),
                                (),
                            );
                            ()
                        };
                        let v1322: Documents::US1 =
                            defaultValue(Documents::US1::US1_1, _v1302.get().clone());
                        let v1330: &mut std::process::Command = match &v1322 {
                            Documents::US1::US1_0(v1322_0_0) => std::process::Command::current_dir(
                                v1301,
                                &*match &v1322 {
                                    Documents::US1::US1_0(x) => x.clone(),
                                    _ => unreachable!(),
                                },
                            ),
                            _ => v1301,
                        };
                        let v1348: &mut std::process::Command = if count_2(v2.clone()) as u64
                            == 0_u64
                        {
                            v1330
                        } else {
                            let v1334: Vec<(string, string)> = v2.clone().to_vec();
                            let v1336: bool = true;
                            let _vec_fold_ = v1334.into_iter().fold(v1330, |acc, x| {
                                //;
                                let v1338: &mut std::process::Command = acc;
                                let patternInput_1: (string, string) = x;
                                let v1343: &mut std::process::Command = std::process::Command::env(
                                    v1338,
                                    &*patternInput_1.0.clone(),
                                    &*patternInput_1.1.clone(),
                                );
                                let v1345: bool = true;
                                v1343
                            });
                            _vec_fold_
                        };
                        let v1350: Result<std::process::Child, std::io::Error> =
                            std::process::Command::spawn(v1348);
                        let v1351 = Documents::method31();
                        let v1353: Result<std::process::Child, std::string::String> =
                            v1350.map_err(|x| v1351(x));
                        let v1355: bool = true;
                        let _result_map_ = v1353.map(|x| {
                            //;
                            let v1357: std::process::Child = x;
                            let v1362: std::sync::Mutex<Option<std::process::Child>> =
                                std::sync::Mutex::new(Some(v1357));
                            let v1364: std::sync::Arc<
                                std::sync::Mutex<Option<std::process::Child>>,
                            > = std::sync::Arc::new(v1362);
                            let v1366: bool = true;
                            v1364
                        });
                        let v1368: Result<
                            std::sync::Arc<std::sync::Mutex<Option<std::process::Child>>>,
                            std::string::String,
                        > = _result_map_;
                        let v1369 = Documents::method63();
                        let v1370 = Documents::method64();
                        let v1372: Documents::US21 = match v1368 {
                            Ok(x) => v1369(x),
                            Err(e) => v1370(e),
                        };
                        let patternInput_3: (i32, Documents::US4, Documents::US22) = match &v1372 {
                            Documents::US21::US21_0(v1372_0_0) => {
                                let v1373: std::sync::Arc<
                                    std::sync::Mutex<Option<std::process::Child>>,
                                > = v1372_0_0.clone();
                                let v1375: bool = true;
                                let _capture = (|| {
                                    //;
                                    let v1377: std::sync::Arc<
                                        std::sync::Mutex<Option<std::process::Child>>,
                                    > = v1373.clone();
                                    let v1379: Result<
                                        std::sync::MutexGuard<Option<std::process::Child>>,
                                        std::sync::PoisonError<
                                            std::sync::MutexGuard<Option<std::process::Child>>,
                                        >,
                                    > = v1377.lock();
                                    let v1381: std::sync::MutexGuard<Option<std::process::Child>> =
                                        v1379.unwrap();
                                    let v1383: bool = true;
                                    let mut v1381 = v1381;
                                    let v1385: &mut Option<std::process::Child> = &mut v1381;
                                    let v1387: Option<&mut std::process::Child> = v1385.as_mut();
                                    let v1389: &mut std::process::Child = v1387.unwrap();
                                    let v1391: &mut Option<std::process::ChildStdout> =
                                        &mut v1389.stdout;
                                    let v1393: Option<std::process::ChildStdout> =
                                        Option::take(v1391);
                                    let v1395: std::process::ChildStdout = v1393.unwrap();
                                    let v1397: bool = true;
                                    v1395
                                })();
                                let v1399: std::process::ChildStdout = _capture;
                                let v1401: bool = true;
                                let _capture = (|| {
                                    //;
                                    let v1403: std::sync::Arc<
                                        std::sync::Mutex<Option<std::process::Child>>,
                                    > = v1373.clone();
                                    let v1405: Result<
                                        std::sync::MutexGuard<Option<std::process::Child>>,
                                        std::sync::PoisonError<
                                            std::sync::MutexGuard<Option<std::process::Child>>,
                                        >,
                                    > = v1403.lock();
                                    let v1407: std::sync::MutexGuard<Option<std::process::Child>> =
                                        v1405.unwrap();
                                    let v1409: bool = true;
                                    let mut v1407 = v1407;
                                    let v1411: &mut Option<std::process::Child> = &mut v1407;
                                    let v1413: Option<&mut std::process::Child> = v1411.as_mut();
                                    let v1415: &mut std::process::Child = v1413.unwrap();
                                    let v1417: &mut Option<std::process::ChildStderr> =
                                        &mut v1415.stderr;
                                    let v1419: Option<std::process::ChildStderr> =
                                        Option::take(v1417);
                                    let v1421: std::process::ChildStderr = v1419.unwrap();
                                    let v1423: bool = true;
                                    v1421
                                })();
                                let v1425: std::process::ChildStderr = _capture;
                                let v1427: bool = true;
                                let _capture = (|| {
                                    //;
                                    let v1429: std::sync::Arc<
                                        std::sync::Mutex<Option<std::process::Child>>,
                                    > = v1373.clone();
                                    let v1431: Result<
                                        std::sync::MutexGuard<Option<std::process::Child>>,
                                        std::sync::PoisonError<
                                            std::sync::MutexGuard<Option<std::process::Child>>,
                                        >,
                                    > = v1429.lock();
                                    let v1433: std::sync::MutexGuard<Option<std::process::Child>> =
                                        v1431.unwrap();
                                    let v1435: bool = true;
                                    let mut v1433 = v1433;
                                    let v1437: &mut Option<std::process::Child> = &mut v1433;
                                    let v1439: Option<&mut std::process::Child> = v1437.as_mut();
                                    let v1441: &mut std::process::Child = v1439.unwrap();
                                    let v1443: &mut Option<std::process::ChildStdin> =
                                        &mut v1441.stdin;
                                    let v1445: Option<std::process::ChildStdin> =
                                        Option::take(v1443);
                                    let v1447: std::process::ChildStdin = v1445.unwrap();
                                    let v1452: std::sync::Mutex<Option<std::process::ChildStdin>> =
                                        std::sync::Mutex::new(Some(v1447));
                                    let v1454: std::sync::Arc<
                                        std::sync::Mutex<Option<std::process::ChildStdin>>,
                                    > = std::sync::Arc::new(v1452);
                                    let v1456: bool = true;
                                    v1454
                                })();
                                let v1458: std::sync::Arc<
                                    std::sync::Mutex<Option<std::process::ChildStdin>>,
                                > = _capture;
                                let patternInput_2: (
                                    std::sync::mpsc::Sender<std::string::String>,
                                    std::sync::Arc<std::sync::mpsc::Receiver<std::string::String>>,
                                ) = {
                                    let (sender, receiver) = std::sync::mpsc::channel();
                                    (sender, std::sync::Arc::new(receiver))
                                };
                                let v1460: std::sync::mpsc::Sender<std::string::String> =
                                    patternInput_2.0.clone();
                                let v1463: std::sync::Mutex<
                                    std::sync::mpsc::Sender<std::string::String>,
                                > = std::sync::Mutex::new(v1460.clone());
                                let v1465: std::sync::Arc<
                                    std::sync::Mutex<std::sync::mpsc::Sender<std::string::String>>,
                                > = std::sync::Arc::new(v1463);
                                let v1467: std::sync::Mutex<
                                    std::sync::mpsc::Sender<std::string::String>,
                                > = std::sync::Mutex::new(v1460);
                                let v1469: std::sync::Arc<
                                    std::sync::Mutex<std::sync::mpsc::Sender<std::string::String>>,
                                > = std::sync::Arc::new(v1467);
                                let v1471: std::sync::Mutex<
                                    std::sync::Arc<std::sync::mpsc::Receiver<std::string::String>>,
                                > = std::sync::Mutex::new(patternInput_2.1.clone());
                                let v1473: std::sync::Arc<
                                    std::sync::Mutex<
                                        std::sync::Arc<
                                            std::sync::mpsc::Receiver<std::string::String>,
                                        >,
                                    >,
                                > = std::sync::Arc::new(v1471);
                                let v1475: bool = true;
                                let __spawn = std::thread::spawn(move || {
                                    //;
                                    let v1477: encoding_rs_io::DecodeReaderBytes<
                                        std::process::ChildStdout,
                                        Vec<u8>,
                                    > = encoding_rs_io::DecodeReaderBytesBuilder::new()
                                        .utf8_passthru(true)
                                        .build(v1399);
                                    let v1479: std::io::BufReader<
                                        encoding_rs_io::DecodeReaderBytes<
                                            std::process::ChildStdout,
                                            Vec<u8>,
                                        >,
                                    > = std::io::BufReader::new(v1477);
                                    let v1481: std::io::Lines<
                                        std::io::BufReader<
                                            encoding_rs_io::DecodeReaderBytes<
                                                std::process::ChildStdout,
                                                Vec<u8>,
                                            >,
                                        >,
                                    > = std::io::BufRead::lines(v1479);
                                    let v1483: bool = true;
                                    let mut v1481 = v1481;
                                    let _iter_try_for_each = v1481.try_for_each(|x| {
                                        //;
                                        let v1485: Result<std::string::String, std::io::Error> = x;
                                        let v1487: std::sync::Arc<
                                            std::sync::Mutex<
                                                std::sync::mpsc::Sender<std::string::String>,
                                            >,
                                        > = v1465.clone();
                                        let v1488 = Documents::method31();
                                        let v1490: Result<
                                            std::string::String,
                                            std::string::String,
                                        > = v1485.map_err(|x| v1488(x));
                                        let v1491 = Documents::method65();
                                        let v1492 = Documents::method66();
                                        let v1494: Documents::US23 = match v1490 {
                                            Ok(x) => v1491(x),
                                            Err(e) => v1492(e),
                                        };
                                        let v3104: std::string::String = match &v1494 {
                                            Documents::US23::US23_0(v1494_0_0) => {
                                                let v1497: string =
                                                    fable_library_rust::String_::fromString(
                                                        v1494_0_0.clone(),
                                                    );
                                                let v1499: &encoding_rs::Encoding =
                                                    encoding_rs::UTF_8;
                                                let v1501: std::borrow::Cow<[u8]> =
                                                    v1499.encode(&*v1497).0;
                                                let v1503: &[u8] = v1501.as_ref();
                                                let v1505: Result<&str, std::str::Utf8Error> =
                                                    std::str::from_utf8(v1503);
                                                let v1507: &str = v1505.unwrap();
                                                let v1509: std::string::String =
                                                    String::from(v1507);
                                                let v1512: string = sprintf!(
                                                    "> {}",
                                                    fable_library_rust::String_::fromString(
                                                        v1509.clone()
                                                    )
                                                );
                                                if v5 {
                                                    let v1515: () = {
                                                        Documents::closure43(v1512.clone(), ());
                                                        ()
                                                    };
                                                    ()
                                                } else {
                                                    let v2269: () = {
                                                        Documents::closure13(v1512, ());
                                                        ()
                                                    };
                                                    ()
                                                }
                                                v1509
                                            }
                                            Documents::US23::US23_1(v1494_1_0) => {
                                                let v2271: std::string::String = v1494_1_0.clone();
                                                let v2274: () = {
                                                    Documents::closure42(v2271.clone(), ());
                                                    ()
                                                };
                                                let v3098: string =
                                                    sprintf!("\u{001b}[4;7m{}\u{001b}[0m", v2271);
                                                let v3100: &str = &*v3098;
                                                String::from(v3100)
                                            }
                                        };
                                        let v3106: std::sync::Arc<
                                            std::sync::Mutex<
                                                std::sync::mpsc::Sender<std::string::String>,
                                            >,
                                        > = v1487;
                                        let v3108: Result<
                                            std::sync::MutexGuard<
                                                std::sync::mpsc::Sender<std::string::String>,
                                            >,
                                            std::sync::PoisonError<
                                                std::sync::MutexGuard<
                                                    std::sync::mpsc::Sender<std::string::String>,
                                                >,
                                            >,
                                        > = v3106.lock();
                                        let v3110: std::sync::MutexGuard<
                                            std::sync::mpsc::Sender<std::string::String>,
                                        > = v3108.unwrap();
                                        let v3112: &std::sync::mpsc::Sender<std::string::String> =
                                            &v3110;
                                        let v3114: Result<
                                            (),
                                            std::sync::mpsc::SendError<std::string::String>,
                                        > = v3112.send(v3104);
                                        let v3115 = Documents::method67();
                                        let v3117: Result<(), std::string::String> =
                                            v3114.map_err(|x| v3115(x));
                                        let v3119: _ = v3117;
                                        let v3121: bool = true;
                                        v3119
                                    }); //;
                                    let v3124: Result<(), string> = Documents::method68(
                                        _iter_try_for_each.map_err(|x| x.into()),
                                    );
                                    let v3128: string =
                                        string("true; v3124 });  // rust.fix_closure\'");
                                    let v3129: bool = true;
                                    v3124
                                }); // rust.fix_closure';
                                let v3131: std::thread::JoinHandle<Result<(), string>> = __spawn;
                                let v3133: bool = true;
                                let __spawn = std::thread::spawn(move || {
                                    //;
                                    let v3135: encoding_rs_io::DecodeReaderBytes<
                                        std::process::ChildStderr,
                                        Vec<u8>,
                                    > = encoding_rs_io::DecodeReaderBytesBuilder::new()
                                        .utf8_passthru(true)
                                        .build(v1425);
                                    let v3137: std::io::BufReader<
                                        encoding_rs_io::DecodeReaderBytes<
                                            std::process::ChildStderr,
                                            Vec<u8>,
                                        >,
                                    > = std::io::BufReader::new(v3135);
                                    let v3139: std::io::Lines<
                                        std::io::BufReader<
                                            encoding_rs_io::DecodeReaderBytes<
                                                std::process::ChildStderr,
                                                Vec<u8>,
                                            >,
                                        >,
                                    > = std::io::BufRead::lines(v3137);
                                    let v3141: bool = true;
                                    let mut v3139 = v3139;
                                    let _iter_try_for_each = v3139.try_for_each(|x| {
                                        //;
                                        let v3143: Result<std::string::String, std::io::Error> = x;
                                        let v3145: std::sync::Arc<
                                            std::sync::Mutex<
                                                std::sync::mpsc::Sender<std::string::String>,
                                            >,
                                        > = v1469.clone();
                                        let v3146 = Documents::method31();
                                        let v3148: Result<
                                            std::string::String,
                                            std::string::String,
                                        > = v3143.map_err(|x| v3146(x));
                                        let v3149 = Documents::method65();
                                        let v3150 = Documents::method66();
                                        let v3152: Documents::US23 = match v3148 {
                                            Ok(x) => v3149(x),
                                            Err(e) => v3150(e),
                                        };
                                        let v4759: std::string::String = match &v3152 {
                                            Documents::US23::US23_0(v3152_0_0) => {
                                                let v3155: string =
                                                    fable_library_rust::String_::fromString(
                                                        v3152_0_0.clone(),
                                                    );
                                                let v3157: &encoding_rs::Encoding =
                                                    encoding_rs::UTF_8;
                                                let v3159: std::borrow::Cow<[u8]> =
                                                    v3157.encode(&*v3155).0;
                                                let v3161: &[u8] = v3159.as_ref();
                                                let v3163: Result<&str, std::str::Utf8Error> =
                                                    std::str::from_utf8(v3161);
                                                let v3165: &str = v3163.unwrap();
                                                let v3167: std::string::String =
                                                    String::from(v3165);
                                                let v3170: string = sprintf!(
                                                    "! {}",
                                                    fable_library_rust::String_::fromString(
                                                        v3167.clone()
                                                    )
                                                );
                                                if v5 {
                                                    let v3173: () = {
                                                        Documents::closure43(v3170.clone(), ());
                                                        ()
                                                    };
                                                    ()
                                                } else {
                                                    let v3923: () = {
                                                        Documents::closure13(v3170, ());
                                                        ()
                                                    };
                                                    ()
                                                }
                                                {
                                                    let v3925: string = sprintf!(
                                                        "\u{001b}[4;7m{}\u{001b}[0m",
                                                        v3167
                                                    );
                                                    let v3927: &str = &*v3925;
                                                    String::from(v3927)
                                                }
                                            }
                                            Documents::US23::US23_1(v3152_1_0) => {
                                                let v3930: std::string::String = v3152_1_0.clone();
                                                let v3933: () = {
                                                    Documents::closure42(v3930.clone(), ());
                                                    ()
                                                };
                                                let v4753: string =
                                                    sprintf!("\u{001b}[4;7m{}\u{001b}[0m", v3930);
                                                let v4755: &str = &*v4753;
                                                String::from(v4755)
                                            }
                                        };
                                        let v4761: std::sync::Arc<
                                            std::sync::Mutex<
                                                std::sync::mpsc::Sender<std::string::String>,
                                            >,
                                        > = v3145;
                                        let v4763: Result<
                                            std::sync::MutexGuard<
                                                std::sync::mpsc::Sender<std::string::String>,
                                            >,
                                            std::sync::PoisonError<
                                                std::sync::MutexGuard<
                                                    std::sync::mpsc::Sender<std::string::String>,
                                                >,
                                            >,
                                        > = v4761.lock();
                                        let v4765: std::sync::MutexGuard<
                                            std::sync::mpsc::Sender<std::string::String>,
                                        > = v4763.unwrap();
                                        let v4767: &std::sync::mpsc::Sender<std::string::String> =
                                            &v4765;
                                        let v4769: Result<
                                            (),
                                            std::sync::mpsc::SendError<std::string::String>,
                                        > = v4767.send(v4759);
                                        let v4770 = Documents::method67();
                                        let v4772: Result<(), std::string::String> =
                                            v4769.map_err(|x| v4770(x));
                                        let v4774: _ = v4772;
                                        let v4776: bool = true;
                                        v4774
                                    }); //;
                                    let v4779: Result<(), string> = Documents::method68(
                                        _iter_try_for_each.map_err(|x| x.into()),
                                    );
                                    let v4781: string =
                                        string("true; v4779 });  // rust.fix_closure\'");
                                    let v4782: bool = true;
                                    v4779
                                }); // rust.fix_closure';
                                let v4784: std::thread::JoinHandle<Result<(), string>> = __spawn;
                                let _v4785: LrcPtr<MutCell<Option<Documents::US24>>> =
                                    refCell(None::<Documents::US24>);
                                let v4790: () = {
                                    Documents::closure46(
                                        v4.clone(),
                                        Func1::new({
                                            let _v4785 = _v4785.clone();
                                            move |v_1: Option<Documents::US24>| {
                                                Documents::closure45(_v4785.clone(), v_1)
                                            }
                                        }),
                                        (),
                                    );
                                    ()
                                };
                                let v4805: Documents::US24 =
                                    defaultValue(Documents::US24::US24_1, _v4785.get().clone());
                                match &v4805 {
                                    Documents::US24::US24_0(v4805_0_0) => {
                                        let v4811: std::sync::Arc<
                                            std::sync::Mutex<Option<std::process::ChildStdin>>,
                                        > = v1458;
                                        let v4813: Result<
                                            std::sync::MutexGuard<Option<std::process::ChildStdin>>,
                                            std::sync::PoisonError<
                                                std::sync::MutexGuard<
                                                    Option<std::process::ChildStdin>,
                                                >,
                                            >,
                                        > = v4811.lock();
                                        let v4815: std::sync::MutexGuard<
                                            Option<std::process::ChildStdin>,
                                        > = v4813.unwrap();
                                        let v4817: bool = true;
                                        let mut v4815 = v4815;
                                        let v4819: &mut Option<std::process::ChildStdin> =
                                            &mut v4815;
                                        let v4821: Option<std::process::ChildStdin> =
                                            Option::take(v4819);
                                        let v4823: bool = true;
                                        let _optionm_map_ = v4821.map(|x| {
                                            //;
                                            let v4825: std::process::ChildStdin = x;
                                            let v4827: std::sync::Mutex<std::process::ChildStdin> =
                                                std::sync::Mutex::new(v4825);
                                            let v4829: std::sync::Arc<
                                                std::sync::Mutex<std::process::ChildStdin>,
                                            > = std::sync::Arc::new(v4827);
                                            let v4831: bool = true;
                                            v4829
                                        });
                                        let v4833: Option<
                                            std::sync::Arc<
                                                std::sync::Mutex<std::process::ChildStdin>,
                                            >,
                                        > = _optionm_map_;
                                        let _v4834: LrcPtr<MutCell<Option<Documents::US25>>> =
                                            refCell(None::<Documents::US25>);
                                        let v4839: () = {
                                            Documents::closure48(
                                                v4833,
                                                Func1::new({
                                                    let _v4834 = _v4834.clone();
                                                    move |v_2: Option<Documents::US25>| {
                                                        Documents::closure47(_v4834.clone(), v_2)
                                                    }
                                                }),
                                                (),
                                            );
                                            ()
                                        };
                                        let v4854: Documents::US25 = defaultValue(
                                            Documents::US25::US25_1,
                                            _v4834.get().clone(),
                                        );
                                        match &v4854 {
                                            Documents::US25::US25_0(v4854_0_0) => {
                                                let v4858: std::sync::Arc<
                                                    std::sync::Mutex<std::process::ChildStdin>,
                                                > = match &v4854 {
                                                    Documents::US25::US25_0(x) => x.clone(),
                                                    _ => unreachable!(),
                                                };
                                                (match &v4805 {
                                                    Documents::US24::US24_0(x) => x.clone(),
                                                    _ => unreachable!(),
                                                })(
                                                    v4858.clone()
                                                );
                                                {
                                                    let v4860: std::sync::Arc<
                                                        std::sync::Mutex<std::process::ChildStdin>,
                                                    > = v4858;
                                                    let v4862: Result<
                                                        std::sync::MutexGuard<
                                                            std::process::ChildStdin,
                                                        >,
                                                        std::sync::PoisonError<
                                                            std::sync::MutexGuard<
                                                                std::process::ChildStdin,
                                                            >,
                                                        >,
                                                    > = v4860.lock();
                                                    let v4865: std::sync::MutexGuard<
                                                        std::process::ChildStdin,
                                                    > = Documents::method69(v4862.unwrap());
                                                    let v4867: bool = true;
                                                    let mut v4865 = v4865;
                                                    let v4869: bool = true;
                                                    std::io::Write::flush(&mut *v4865).unwrap();
                                                    ()
                                                }
                                            }
                                            _ => (),
                                        }
                                    }
                                    _ => (),
                                }
                                {
                                    let v4871: std::sync::Arc<
                                        std::sync::Mutex<Option<std::process::Child>>,
                                    > = v1373;
                                    let v4873: Result<
                                        std::sync::MutexGuard<Option<std::process::Child>>,
                                        std::sync::PoisonError<
                                            std::sync::MutexGuard<Option<std::process::Child>>,
                                        >,
                                    > = v4871.lock();
                                    let v4875: std::sync::MutexGuard<Option<std::process::Child>> =
                                        v4873.unwrap();
                                    let v4877: bool = true;
                                    let mut v4875 = v4875;
                                    let v4879: &mut Option<std::process::Child> = &mut v4875;
                                    let v4881: Option<std::process::Child> = Option::take(v4879);
                                    let v4883: std::process::Child = v4881.unwrap();
                                    let v4885: Result<std::process::Output, std::io::Error> =
                                        v4883.wait_with_output();
                                    let v4886 = Documents::method31();
                                    let v4888: Result<std::process::Output, std::string::String> =
                                        v4885.map_err(|x| v4886(x));
                                    let v4889: std::thread::JoinHandle<Result<(), string>> =
                                        Documents::method70(v4784);
                                    let v4892: string = string("v4889");
                                    let v4893: std::thread::JoinHandle<Result<(), string>> =
                                        Documents::method70(v3131);
                                    let v4898: string = append(
                                        append(string("vec!["), append(string("v4893, "), v4892)),
                                        string("]"),
                                    );
                                    let v4899: Vec<std::thread::JoinHandle<Result<(), string>>> =
                                        vec![v4893, v4889];
                                    let v4901: bool = true;
                                    v4899.into_iter().for_each(|x| {
                                        //;
                                        let v4903: std::thread::JoinHandle<Result<(), string>> = x;
                                        let v4905: Result<
                                            Result<(), string>,
                                            Box<dyn core::any::Any + 'static + Send>,
                                        > = std::thread::JoinHandle::join(v4903);
                                        let v4907: Result<(), string> = v4905.unwrap();
                                        v4907.unwrap();
                                        {
                                            let v4910: bool = true;
                                            let v4912: bool = true;
                                        }
                                    });
                                    {
                                        //;
                                        let v4915: Documents::US26 = match &v4888 {
                                            Err(v4888_1_0) => {
                                                Documents::closure50((), v4888_1_0.clone())
                                            }
                                            Ok(v4888_0_0) => {
                                                Documents::closure49((), v4888_0_0.clone())
                                            }
                                        };
                                        match &v4915 {
                                            Documents::US26::US26_0(v4915_0_0) => {
                                                let v4918: std::process::ExitStatus =
                                                    v4915_0_0.clone().status;
                                                let v4920: Option<i32> = v4918.code();
                                                let _v4921: LrcPtr<
                                                    MutCell<Option<Documents::US27>>,
                                                > = refCell(None::<Documents::US27>);
                                                let v4926: () = {
                                                    Documents::closure53(
                                                        v4920,
                                                        Func1::new({
                                                            let _v4921 = _v4921.clone();
                                                            move |v_5: Option<Documents::US27>| {
                                                                Documents::closure52(
                                                                    _v4921.clone(),
                                                                    v_5,
                                                                )
                                                            }
                                                        }),
                                                        (),
                                                    );
                                                    ()
                                                };
                                                let v4941: Documents::US27 = defaultValue(
                                                    Documents::US27::US27_1,
                                                    _v4921.get().clone(),
                                                );
                                                match &v4941 {
                                                    Documents::US27::US27_0(v4941_0_0) => (
                                                        match &v4941 {
                                                            Documents::US27::US27_0(x) => x.clone(),
                                                            _ => unreachable!(),
                                                        },
                                                        Documents::US4::US4_1,
                                                        Documents::US22::US22_0(v1473.clone()),
                                                    ),
                                                    _ => {
                                                        let v4950:
                                                                                        &str =
                                                                                    &*string("runtime.execute_with_options / exit_code=None");
                                                        (
                                                            -1_i32,
                                                            Documents::US4::US4_0(String::from(
                                                                v4950,
                                                            )),
                                                            Documents::US22::US22_0(v1473.clone()),
                                                        )
                                                    }
                                                }
                                            }
                                            Documents::US26::US26_1(v4915_1_0) => {
                                                let v4961: std::string::String = v4915_1_0.clone();
                                                let v4964: () = {
                                                    Documents::closure51(v4961.clone(), ());
                                                    ()
                                                };
                                                (
                                                    -2_i32,
                                                    Documents::US4::US4_0(v4961),
                                                    Documents::US22::US22_1,
                                                )
                                            }
                                        }
                                    }
                                }
                            }
                            Documents::US21::US21_1(v1372_1_0) => {
                                let v5792: std::string::String = v1372_1_0.clone();
                                let v5795: () = {
                                    Documents::closure39(v5792.clone(), ());
                                    ()
                                };
                                (
                                    -1_i32,
                                    Documents::US4::US4_0(v5792),
                                    Documents::US22::US22_1,
                                )
                            }
                        };
                        let v6626: Documents::US22 = patternInput_3.2.clone();
                        let v6625: Documents::US4 = patternInput_3.1.clone();
                        let v6624: i32 = patternInput_3.0.clone();
                        let v6633: Option<
                            std::sync::Arc<
                                std::sync::Mutex<
                                    std::sync::Arc<std::sync::mpsc::Receiver<std::string::String>>,
                                >,
                            >,
                        > = match &v6626 {
                            Documents::US22::US22_0(v6626_0_0) => Some(match &v6626 {
                                Documents::US22::US22_0(x) => x.clone(),
                                _ => unreachable!(),
                            }),
                            _ => {
                                None::<
                                    std::sync::Arc<
                                        std::sync::Mutex<
                                            std::sync::Arc<
                                                std::sync::mpsc::Receiver<std::string::String>,
                                            >,
                                        >,
                                    >,
                                >
                            }
                        };
                        let v6635: bool = true;
                        let _optionm_map_ = v6633.map(|x| {
                            //;
                            let v6637: std::sync::Arc<
                                std::sync::Mutex<
                                    std::sync::Arc<std::sync::mpsc::Receiver<std::string::String>>,
                                >,
                            > = x;
                            let v6639: std::sync::Arc<
                                std::sync::Mutex<
                                    std::sync::Arc<std::sync::mpsc::Receiver<std::string::String>>,
                                >,
                            > = v6637;
                            let v6641: Result<
                                std::sync::MutexGuard<
                                    std::sync::Arc<std::sync::mpsc::Receiver<std::string::String>>,
                                >,
                                std::sync::PoisonError<
                                    std::sync::MutexGuard<
                                        std::sync::Arc<
                                            std::sync::mpsc::Receiver<std::string::String>,
                                        >,
                                    >,
                                >,
                            > = v6639.lock();
                            let v6643: std::sync::MutexGuard<
                                std::sync::Arc<std::sync::mpsc::Receiver<std::string::String>>,
                            > = v6641.unwrap();
                            let v6645 = v6643.iter();
                            let v6647: Vec<std::string::String> = v6645.collect::<Vec<_>>();
                            let v6649: bool = true;
                            let _vec_map: Vec<_> = v6647
                                .into_iter()
                                .map(|x| {
                                    //;
                                    let v6651: std::string::String = x;
                                    let v6653: string =
                                        fable_library_rust::String_::fromString(v6651);
                                    let v6655: bool = true;
                                    v6653
                                })
                                .collect::<Vec<_>>();
                            let v6657: Vec<string> = _vec_map;
                            let v6666: string = join(
                                string("\n"),
                                toArray_1(ofArray_1(fable_library_rust::NativeArray_::array_from(
                                    v6657,
                                ))),
                            );
                            let v6670: bool = true;
                            v6666
                        });
                        let v6672: Option<string> = _optionm_map_;
                        let v6679: Documents::US1 = match &v6625 {
                            Documents::US4::US4_0(v6625_0_0) => Documents::US1::US1_0(
                                fable_library_rust::String_::fromString(match &v6625 {
                                    Documents::US4::US4_0(x) => x.clone(),
                                    _ => unreachable!(),
                                }),
                            ),
                            _ => Documents::US1::US1_1,
                        };
                        let v6684: string = defaultValue(
                            match &v6679 {
                                Documents::US1::US1_0(v6679_0_0) => match &v6679 {
                                    Documents::US1::US1_0(x) => x.clone(),
                                    _ => unreachable!(),
                                },
                                _ => string(""),
                            },
                            v6672,
                        );
                        let v6689: () = {
                            Documents::closure54(v6624, v6684.clone(), ());
                            ()
                        };
                        LrcPtr::new((v6624, v6684))
                    }
                }))();
                _v1283.set(Some(x_3))
            }
            {
                let v7521: LrcPtr<(i32, string)> = match &_v1283.get().clone() {
                    None => panic!("{}", string("base.capture / _v1283=None"),),
                    Some(_v1283_0_0) => _v1283_0_0.clone(),
                };
                let _v7: (i32, string) = (v7521.0.clone(), v7521.1.clone());
                (_v7.0.clone(), _v7.1.clone())
            }
        }
        pub fn method73(v0_1: string) -> string {
            let v3: &str = &*v0_1;
            let v5: std::string::String = String::from(v3);
            let v7: std::path::PathBuf = std::path::PathBuf::from(v5);
            let v9: Option<&std::ffi::OsStr> = v7.file_name();
            let v11: &std::ffi::OsStr = v9.unwrap();
            let v13: std::ffi::OsString = v11.to_os_string();
            let v15: Option<&str> = v13.to_str();
            let v17: &str = v15.unwrap();
            let v19: std::string::String = String::from(v17);
            fable_library_rust::String_::fromString(v19)
        }
        pub fn method72(v0_1: string, v1_1: string, v2: string) -> (string, string) {
            let v4: string = Documents::method15(v2, Documents::method73(v1_1.clone()));
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
                    sprintf!("{}.{}", v1_1, v0_1.clone())
                } else {
                    sprintf!("{}.{}", v8, v0_1.clone())
                },
                if v14 {
                    sprintf!("{}.{}", v4, v0_1.clone())
                } else {
                    sprintf!("{}.{}", v11, v0_1)
                },
            )
        }
        pub fn method74() -> string {
            string("")
        }
        pub fn closure66(unitVar: (), v0_1: string) -> Documents::US31 {
            Documents::US31::US31_0(v0_1)
        }
        pub fn method75() -> Func1<string, Documents::US31> {
            Func1::new(move |v: string| Documents::closure66((), v))
        }
        pub fn closure67(unitVar: (), v0_1: std::string::String) -> Documents::US31 {
            Documents::US31::US31_1(v0_1)
        }
        pub fn method76() -> Func1<std::string::String, Documents::US31> {
            Func1::new(move |v: std::string::String| Documents::closure67((), v))
        }
        pub fn method77(v0_1: string) -> bool {
            let v3: &str = &*v0_1;
            let v5: std::string::String = String::from(v3);
            let v7: std::path::PathBuf = std::path::PathBuf::from(v5);
            if v7.clone().exists() {
                v7.is_file()
            } else {
                false
            }
        }
        pub fn closure68(
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
            v10: Documents::US1,
            unitVar: (),
        ) {
            fn v12() {
                Documents::closure7((), ());
            }
            let v13: () = {
                v12();
                ()
            };
            let patternInput: (
                LrcPtr<Documents::Mut0>,
                LrcPtr<Documents::Mut1>,
                LrcPtr<Documents::Mut2>,
                LrcPtr<Documents::Mut3>,
                LrcPtr<Documents::Mut4>,
                Option<i64>,
            ) = getValue(Documents::TraceState::trace_state().get().clone());
            let v46: () = {
                v12();
                ()
            };
            let patternInput_1: (
                LrcPtr<Documents::Mut0>,
                LrcPtr<Documents::Mut1>,
                LrcPtr<Documents::Mut2>,
                LrcPtr<Documents::Mut3>,
                LrcPtr<Documents::Mut4>,
                Option<i64>,
            ) = getValue(Documents::TraceState::trace_state().get().clone());
            let v78: Documents::US0 = (patternInput_1.4.clone()).l0.get().clone();
            if if (patternInput_1.2.clone()).l0.get().clone() == false {
                false
            } else {
                2_i32
                    >= find(
                        v78,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Documents::US0::US0_0, 0_i32)),
                            LrcPtr::new((Documents::US0::US0_1, 1_i32)),
                            LrcPtr::new((Documents::US0::US0_2, 2_i32)),
                            LrcPtr::new((Documents::US0::US0_3, 3_i32)),
                            LrcPtr::new((Documents::US0::US0_4, 4_i32)),
                        ])))),
                    )
            } {
                let v86: () = {
                    Documents::closure8(patternInput.0.clone(), ());
                    ()
                };
                let v90: () = {
                    v12();
                    ()
                };
                let patternInput_2: (
                    LrcPtr<Documents::Mut0>,
                    LrcPtr<Documents::Mut1>,
                    LrcPtr<Documents::Mut2>,
                    LrcPtr<Documents::Mut3>,
                    LrcPtr<Documents::Mut4>,
                    Option<i64>,
                ) = getValue(Documents::TraceState::trace_state().get().clone());
                let _v123: LrcPtr<MutCell<Option<Documents::US3>>> =
                    refCell(None::<Documents::US3>);
                let v128: () = {
                    Documents::closure10(
                        patternInput_2.5.clone(),
                        Func1::new({
                            let _v123 = _v123.clone();
                            move |v: Option<Documents::US3>| Documents::closure9(_v123.clone(), v)
                        }),
                        (),
                    );
                    ()
                };
                let v143: Documents::US3 = defaultValue(Documents::US3::US3_1, _v123.get().clone());
                let v183: DateTime = match &v143 {
                    Documents::US3::US3_0(v143_0_0) => {
                        let v157: TimeSpan = TimeSpan::new_ticks(
                            {
                                let _arg: DateTime = DateTime::now();
                                _arg.ticks()
                            } - match &v143 {
                                Documents::US3::US3_0(x) => x.clone(),
                                _ => unreachable!(),
                            },
                        );
                        DateTime::new_ymdhms_milli(
                            1_i32,
                            1_i32,
                            1_i32,
                            v157.hours(),
                            v157.minutes(),
                            v157.seconds(),
                            v157.milliseconds(),
                        )
                    }
                    _ => DateTime::now(),
                };
                let v188: string = {
                    let provider: string = Documents::method6();
                    v183.toString(provider)
                };
                let v580: string = padLeft(toLower(string("Info")), 7_i32, ' ');
                let v596: &str = inline_colorization::color_bright_green;
                let v598: &str = &*v580;
                let v600: &str = inline_colorization::color_reset;
                let v602: string = string("format!(\"{v596}{v598}{v600}\")");
                let v603: std::string::String = format!("{v596}{v598}{v600}");
                let v605: string = fable_library_rust::String_::fromString(v603);
                let v646: i64 = (patternInput_2.0.clone()).l0.get().clone();
                let v648: LrcPtr<Documents::Mut3> = LrcPtr::new(Documents::Mut3 {
                    l0: MutCell::new(Documents::method9()),
                });
                let v655: () = {
                    Documents::closure11(v648.clone(), sprintf!("{}", string("{ ")), ());
                    ()
                };
                let v664: () = {
                    Documents::closure11(v648.clone(), sprintf!("{}", string("file")), ());
                    ()
                };
                let v673: () = {
                    Documents::closure11(v648.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v681: () = {
                    Documents::closure11(v648.clone(), sprintf!("{}", v1_1), ());
                    ()
                };
                let v690: () = {
                    Documents::closure11(v648.clone(), sprintf!("{}", string("; ")), ());
                    ()
                };
                let v699: () = {
                    Documents::closure11(v648.clone(), sprintf!("{}", string("real_path")), ());
                    ()
                };
                let v707: () = {
                    Documents::closure11(v648.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v715: () = {
                    Documents::closure11(v648.clone(), sprintf!("{}", v2), ());
                    ()
                };
                let v723: () = {
                    Documents::closure11(v648.clone(), sprintf!("{}", string("; ")), ());
                    ()
                };
                let v732: () = {
                    Documents::closure11(v648.clone(), sprintf!("{}", string("relative_path")), ());
                    ()
                };
                let v740: () = {
                    Documents::closure11(v648.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v748: () = {
                    Documents::closure11(v648.clone(), sprintf!("{}", v0_1), ());
                    ()
                };
                let v756: () = {
                    Documents::closure11(v648.clone(), sprintf!("{}", string("; ")), ());
                    ()
                };
                let v765: () = {
                    Documents::closure11(
                        v648.clone(),
                        sprintf!("{}", string("origin_hash_exit_code")),
                        (),
                    );
                    ()
                };
                let v773: () = {
                    Documents::closure11(v648.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v781: () = {
                    Documents::closure11(v648.clone(), sprintf!("{}", v4), ());
                    ()
                };
                let v789: () = {
                    Documents::closure11(v648.clone(), sprintf!("{}", string("; ")), ());
                    ()
                };
                let v798: () = {
                    Documents::closure11(v648.clone(), sprintf!("{}", string("origin_hash")), ());
                    ()
                };
                let v806: () = {
                    Documents::closure11(v648.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v814: () = {
                    Documents::closure11(v648.clone(), sprintf!("{}", v3), ());
                    ()
                };
                let v822: () = {
                    Documents::closure11(v648.clone(), sprintf!("{}", string("; ")), ());
                    ()
                };
                let v831: () = {
                    Documents::closure11(
                        v648.clone(),
                        sprintf!("{}", string("local_git_hash_exit_code")),
                        (),
                    );
                    ()
                };
                let v839: () = {
                    Documents::closure11(v648.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v847: () = {
                    Documents::closure11(v648.clone(), sprintf!("{}", v7), ());
                    ()
                };
                let v855: () = {
                    Documents::closure11(v648.clone(), sprintf!("{}", string("; ")), ());
                    ()
                };
                let v864: () = {
                    Documents::closure11(
                        v648.clone(),
                        sprintf!("{}", string("local_git_hash")),
                        (),
                    );
                    ()
                };
                let v872: () = {
                    Documents::closure11(v648.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v880: () = {
                    Documents::closure11(v648.clone(), sprintf!("{}", v6), ());
                    ()
                };
                let v888: () = {
                    Documents::closure11(v648.clone(), sprintf!("{}", string("; ")), ());
                    ()
                };
                let v897: () = {
                    Documents::closure11(v648.clone(), sprintf!("{}", string("hash1")), ());
                    ()
                };
                let v905: () = {
                    Documents::closure11(v648.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v913: () = {
                    Documents::closure11(v648.clone(), sprintf!("{}", v9), ());
                    ()
                };
                let v921: () = {
                    Documents::closure11(v648.clone(), sprintf!("{}", string("; ")), ());
                    ()
                };
                let v930: () = {
                    Documents::closure11(v648.clone(), sprintf!("{}", string("hash2")), ());
                    ()
                };
                let v938: () = {
                    Documents::closure11(v648.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v949: () = {
                    Documents::closure11(v648.clone(), sprintf!("{}", sprintf!("{:?}", v10)), ());
                    ()
                };
                let v957: () = {
                    Documents::closure11(v648.clone(), sprintf!("{}", string("; ")), ());
                    ()
                };
                let v966: () = {
                    Documents::closure11(v648.clone(), sprintf!("{}", string("dist_path")), ());
                    ()
                };
                let v974: () = {
                    Documents::closure11(v648.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v982: () = {
                    Documents::closure11(v648.clone(), sprintf!("{}", v5), ());
                    ()
                };
                let v990: () = {
                    Documents::closure11(v648.clone(), sprintf!("{}", string("; ")), ());
                    ()
                };
                let v999: () = {
                    Documents::closure11(v648.clone(), sprintf!("{}", string("cache_path")), ());
                    ()
                };
                let v1007: () = {
                    Documents::closure11(v648.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v1015: () = {
                    Documents::closure11(v648.clone(), sprintf!("{}", v8), ());
                    ()
                };
                let v1024: () = {
                    Documents::closure11(v648.clone(), sprintf!("{}", string(" }")), ());
                    ()
                };
                let v1028: string =
                    string("documents.run / par_map / origin_hash |> sm\'.contains local_git_hash |> not / hash2 = None || hash1 <>. (hash2 |> optionm.value)");
                let v1086: string = if v1028.clone() == string("") {
                    string("")
                } else {
                    trimEndChars(
                        trimStartChars(
                            sprintf!(
                                "{} {} #{} {} / {}",
                                v188,
                                v605,
                                v646,
                                v1028,
                                v648.l0.get().clone()
                            ),
                            toArray(empty::<char>()),
                        ),
                        toArray(ofArray(new_array(&[' ', '/']))),
                    )
                };
                println!("{}", v1086.clone());
                ();
                ((patternInput.1.clone()).l0.get().clone())(v1086)
            }
        }
        pub fn method79(v0_1: string) -> string {
            v0_1
        }
        pub fn method78(v0_1: string, v1_1: string) {
            let v3: string = Documents::method79(v0_1);
            let v5: Result<u64, std::io::Error> = std::fs::copy(&*v1_1, &*v3);
            let v7: u64 = v5.unwrap();
            ();
            ()
        }
        pub fn method81(v0_1: Vec<u8>) -> Vec<u8> {
            v0_1
        }
        pub fn method82(v0_1: i32, v1_1: LrcPtr<Documents::Mut7>) -> bool {
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
        pub fn closure71(
            v0_1: string,
            v1_1: std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>,
        ) {
            let v3: std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>> = v1_1;
            let v5: Result<
                std::sync::MutexGuard<std::process::ChildStdin>,
                std::sync::PoisonError<std::sync::MutexGuard<std::process::ChildStdin>>,
            > = v3.lock();
            let v7: std::sync::MutexGuard<std::process::ChildStdin> = v5.unwrap();
            let v8: string = Documents::method83(v0_1);
            let v10: &[u8] = v8.as_bytes();
            let v11: std::sync::MutexGuard<std::process::ChildStdin> = Documents::method84(v7);
            let v13: bool = true;
            let mut v11 = v11;
            let v15: bool = true;
            std::io::Write::write_all(&mut *v11, v10).unwrap();
            ()
        }
        pub fn method85(v0_1: i32, v1_1: LrcPtr<Documents::Mut8>) -> bool {
            v1_1.l0.get().clone() < v0_1
        }
        pub fn method86(v0_1: string) -> string {
            v0_1
        }
        pub fn closure72(v0_1: string, v1_1: i32, v2: string, unitVar: ()) {
            fn v4() {
                Documents::closure7((), ());
            }
            let v5: () = {
                v4();
                ()
            };
            let patternInput: (
                LrcPtr<Documents::Mut0>,
                LrcPtr<Documents::Mut1>,
                LrcPtr<Documents::Mut2>,
                LrcPtr<Documents::Mut3>,
                LrcPtr<Documents::Mut4>,
                Option<i64>,
            ) = getValue(Documents::TraceState::trace_state().get().clone());
            let v38: () = {
                v4();
                ()
            };
            let patternInput_1: (
                LrcPtr<Documents::Mut0>,
                LrcPtr<Documents::Mut1>,
                LrcPtr<Documents::Mut2>,
                LrcPtr<Documents::Mut3>,
                LrcPtr<Documents::Mut4>,
                Option<i64>,
            ) = getValue(Documents::TraceState::trace_state().get().clone());
            let v70: Documents::US0 = (patternInput_1.4.clone()).l0.get().clone();
            if if (patternInput_1.2.clone()).l0.get().clone() == false {
                false
            } else {
                2_i32
                    >= find(
                        v70,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Documents::US0::US0_0, 0_i32)),
                            LrcPtr::new((Documents::US0::US0_1, 1_i32)),
                            LrcPtr::new((Documents::US0::US0_2, 2_i32)),
                            LrcPtr::new((Documents::US0::US0_3, 3_i32)),
                            LrcPtr::new((Documents::US0::US0_4, 4_i32)),
                        ])))),
                    )
            } {
                let v78: () = {
                    Documents::closure8(patternInput.0.clone(), ());
                    ()
                };
                let v82: () = {
                    v4();
                    ()
                };
                let patternInput_2: (
                    LrcPtr<Documents::Mut0>,
                    LrcPtr<Documents::Mut1>,
                    LrcPtr<Documents::Mut2>,
                    LrcPtr<Documents::Mut3>,
                    LrcPtr<Documents::Mut4>,
                    Option<i64>,
                ) = getValue(Documents::TraceState::trace_state().get().clone());
                let _v115: LrcPtr<MutCell<Option<Documents::US3>>> =
                    refCell(None::<Documents::US3>);
                let v120: () = {
                    Documents::closure10(
                        patternInput_2.5.clone(),
                        Func1::new({
                            let _v115 = _v115.clone();
                            move |v: Option<Documents::US3>| Documents::closure9(_v115.clone(), v)
                        }),
                        (),
                    );
                    ()
                };
                let v135: Documents::US3 = defaultValue(Documents::US3::US3_1, _v115.get().clone());
                let v175: DateTime = match &v135 {
                    Documents::US3::US3_0(v135_0_0) => {
                        let v149: TimeSpan = TimeSpan::new_ticks(
                            {
                                let _arg: DateTime = DateTime::now();
                                _arg.ticks()
                            } - match &v135 {
                                Documents::US3::US3_0(x) => x.clone(),
                                _ => unreachable!(),
                            },
                        );
                        DateTime::new_ymdhms_milli(
                            1_i32,
                            1_i32,
                            1_i32,
                            v149.hours(),
                            v149.minutes(),
                            v149.seconds(),
                            v149.milliseconds(),
                        )
                    }
                    _ => DateTime::now(),
                };
                let v180: string = {
                    let provider: string = Documents::method6();
                    v175.toString(provider)
                };
                let v572: string = padLeft(toLower(string("Info")), 7_i32, ' ');
                let v588: &str = inline_colorization::color_bright_green;
                let v590: &str = &*v572;
                let v592: &str = inline_colorization::color_reset;
                let v594: string = string("format!(\"{v588}{v590}{v592}\")");
                let v595: std::string::String = format!("{v588}{v590}{v592}");
                let v597: string = fable_library_rust::String_::fromString(v595);
                let v638: i64 = (patternInput_2.0.clone()).l0.get().clone();
                let v639: i32 = length(v2);
                let v641: LrcPtr<Documents::Mut3> = LrcPtr::new(Documents::Mut3 {
                    l0: MutCell::new(Documents::method9()),
                });
                let v648: () = {
                    Documents::closure11(v641.clone(), sprintf!("{}", string("{ ")), ());
                    ()
                };
                let v657: () = {
                    Documents::closure11(v641.clone(), sprintf!("{}", string("exit_code")), ());
                    ()
                };
                let v666: () = {
                    Documents::closure11(v641.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v674: () = {
                    Documents::closure11(v641.clone(), sprintf!("{}", v1_1), ());
                    ()
                };
                let v683: () = {
                    Documents::closure11(v641.clone(), sprintf!("{}", string("; ")), ());
                    ()
                };
                let v692: () = {
                    Documents::closure11(v641.clone(), sprintf!("{}", string("result_len")), ());
                    ()
                };
                let v700: () = {
                    Documents::closure11(v641.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v708: () = {
                    Documents::closure11(v641.clone(), sprintf!("{}", v639), ());
                    ()
                };
                let v716: () = {
                    Documents::closure11(v641.clone(), sprintf!("{}", string("; ")), ());
                    ()
                };
                let v725: () = {
                    Documents::closure11(v641.clone(), sprintf!("{}", string("output_path")), ());
                    ()
                };
                let v733: () = {
                    Documents::closure11(v641.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v741: () = {
                    Documents::closure11(v641.clone(), sprintf!("{}", v0_1), ());
                    ()
                };
                let v750: () = {
                    Documents::closure11(v641.clone(), sprintf!("{}", string(" }")), ());
                    ()
                };
                let v812: string = trimEndChars(
                    trimStartChars(
                        sprintf!(
                            "{} {} #{} {} / {}",
                            v180,
                            v597,
                            v638,
                            string("documents.hangul"),
                            v641.l0.get().clone()
                        ),
                        toArray(empty::<char>()),
                    ),
                    toArray(ofArray(new_array(&[' ', '/']))),
                );
                println!("{}", v812.clone());
                ();
                ((patternInput.1.clone()).l0.get().clone())(v812)
            }
        }
        pub fn method80(v0_1: string, v1_1: string, v2: string, v3: string) -> Documents::US32 {
            let v7: Result<Vec<u8>, std::io::Error> = std::fs::read(&*v3);
            let v30: Vec<u8> = Documents::method81(v7.unwrap());
            let v32: Result<std::string::String, std::string::FromUtf8Error> =
                std::string::String::from_utf8(v30);
            let v34: std::string::String = v32.unwrap();
            let v56: Array<string> = split(
                fable_library_rust::String_::fromString(v34),
                string("\n"),
                -1_i32,
                0_i32,
            );
            let v59: i32 = count_2(v56.clone());
            let v60: Array<string> = new_init(&string(""), v59);
            let v61: LrcPtr<Documents::Mut6> = LrcPtr::new(Documents::Mut6 {
                l0: MutCell::new(0_i32),
            });
            while Documents::method28(v59, v61.clone()) {
                let v63: i32 = v61.l0.get().clone();
                let v66: string = trim(v56[v63].clone());
                v60.get_mut()[v63 as usize] = v66;
                {
                    let v67: i32 = v63 + 1_i32;
                    v61.l0.set(v67);
                    ()
                }
            }
            {
                let v68: i32 = count_2(v60.clone());
                let v69: Array<string> = new_init(&string(""), v68);
                let v70: LrcPtr<Documents::Mut7> = LrcPtr::new(Documents::Mut7 {
                    l0: MutCell::new(0_i32),
                    l1: MutCell::new(0_i32),
                });
                while Documents::method82(v68, v70.clone()) {
                    let v72: i32 = v70.l0.get().clone();
                    let v73: i32 = v70.l1.get().clone();
                    let v74: string = v60[v72].clone();
                    let v80: i32 = if string("") != v74.clone() {
                        v69.get_mut()[v73 as usize] = v74;
                        v73 + 1_i32
                    } else {
                        v73
                    };
                    let v81: i32 = v72 + 1_i32;
                    v70.l0.set(v81);
                    v70.l1.set(v80);
                    ()
                }
                {
                    let v82: i32 = v70.l1.get().clone();
                    let v83: Array<string> = new_init(&string(""), v82);
                    let v84: LrcPtr<Documents::Mut6> = LrcPtr::new(Documents::Mut6 {
                        l0: MutCell::new(0_i32),
                    });
                    while Documents::method28(v82, v84.clone()) {
                        let v86: i32 = v84.l0.get().clone();
                        let v87: string = v69[v86].clone();
                        v83.get_mut()[v86 as usize] = v87;
                        {
                            let v88: i32 = v86 + 1_i32;
                            v84.l0.set(v88);
                            ()
                        }
                    }
                    {
                        let v97: string = sprintf!(
                            "{}\n\n",
                            join(
                                string("\n"),
                                toArray_1(delay(Func0::new({
                                    let v83 = v83.clone();
                                    move || {
                                        map(
                                            Func1::new({
                                                let v83 = v83.clone();
                                                move |i: i32| v83[i].clone()
                                            }),
                                            rangeNumeric(
                                                0_i32,
                                                1_i32,
                                                count_2(v83.clone()) - 1_i32,
                                            ),
                                        )
                                    }
                                })))
                            )
                        );
                        let patternInput: (i32, string) = Documents::method39(
                            sprintf!(
                                "{} {}",
                                Documents::method15(
                                    v0_1,
                                    sprintf!(
                                        "../vault/deps/hangulize/cmd/hangulize/hangulize{}",
                                        if cfg!(windows) {
                                            string(".exe")
                                        } else {
                                            string("")
                                        }
                                    )
                                ),
                                v1_1
                            ),
                            None::<CancellationToken>,
                            new_empty::<(string, string)>(),
                            None::<Func1<(i32, string, bool), Arc<Async<()>>>>,
                            Some(Func1::new({
                                let v97 = v97.clone();
                                move |v: std::sync::Arc<
                                    std::sync::Mutex<std::process::ChildStdin>,
                                >| {
                                    Documents::closure71(v97.clone(), v)
                                }
                            })),
                            true,
                            None::<string>,
                        );
                        let v138: i32 = patternInput.0.clone();
                        let v140: Array<string> =
                            split(patternInput.1.clone(), string("\n"), -1_i32, 0_i32);
                        let v143: i32 = count_2(v140.clone());
                        let v145: LrcPtr<Documents::Mut8> = LrcPtr::new(Documents::Mut8 {
                            l0: MutCell::new(0_i32),
                            l1: MutCell::new(string("")),
                            l2: MutCell::new(0_i32),
                            l3: MutCell::new(0_i32),
                        });
                        while Documents::method85(v68, v145.clone()) {
                            let v147: i32 = v145.l0.get().clone();
                            let matchValue: string = v145.l1.get().clone();
                            let matchValue_1: i32 = v145.l2.get().clone();
                            let v150: i32 = v145.l3.get().clone();
                            let v149: i32 = matchValue_1;
                            let v148: string = matchValue;
                            let patternInput_2: (string, i32, i32) =
                                if v60[v147].clone() == string("") {
                                    (sprintf!("{}\n", v148.clone()), v149 + 1_i32, v150 + 1_i32)
                                } else {
                                    let v156: i32 = v149 - v150;
                                    (
                                        if v156 >= v143 {
                                            v148.clone()
                                        } else {
                                            let v158: string = v140[v156].clone();
                                            if v156 == v143 - 1_i32 {
                                                sprintf!("{}{}", v148.clone(), v158.clone())
                                            } else {
                                                sprintf!("{}{}\n", v148, v158)
                                            }
                                        },
                                        v149 + 1_i32,
                                        v150,
                                    )
                                };
                            let v171: i32 = v147 + 1_i32;
                            v145.l0.set(v171);
                            v145.l1.set(patternInput_2.0.clone());
                            v145.l2.set(patternInput_2.1.clone());
                            v145.l3.set(patternInput_2.2.clone());
                            ()
                        }
                        {
                            let matchValue_3: string = v145.l1.get().clone();
                            let matchValue_4: i32 = v145.l2.get().clone();
                            let matchValue_5: i32 = v145.l3.get().clone();
                            let v172: string = matchValue_3;
                            std::fs::write(&*v2.clone(), &*v172.clone()).unwrap();
                            ();
                            {
                                let v180: () = {
                                    Documents::closure72(v2, v138, v172.clone(), ());
                                    ()
                                };
                                Documents::US32::US32_0(v138, v172)
                            }
                        }
                    }
                }
            }
        }
        pub fn closure73(v0_1: string, v1_1: i32, unitVar: ()) {
            fn v3() {
                Documents::closure7((), ());
            }
            let v4: () = {
                v3();
                ()
            };
            let patternInput: (
                LrcPtr<Documents::Mut0>,
                LrcPtr<Documents::Mut1>,
                LrcPtr<Documents::Mut2>,
                LrcPtr<Documents::Mut3>,
                LrcPtr<Documents::Mut4>,
                Option<i64>,
            ) = getValue(Documents::TraceState::trace_state().get().clone());
            let v37: () = {
                v3();
                ()
            };
            let patternInput_1: (
                LrcPtr<Documents::Mut0>,
                LrcPtr<Documents::Mut1>,
                LrcPtr<Documents::Mut2>,
                LrcPtr<Documents::Mut3>,
                LrcPtr<Documents::Mut4>,
                Option<i64>,
            ) = getValue(Documents::TraceState::trace_state().get().clone());
            let v69: Documents::US0 = (patternInput_1.4.clone()).l0.get().clone();
            if if (patternInput_1.2.clone()).l0.get().clone() == false {
                false
            } else {
                2_i32
                    >= find(
                        v69,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Documents::US0::US0_0, 0_i32)),
                            LrcPtr::new((Documents::US0::US0_1, 1_i32)),
                            LrcPtr::new((Documents::US0::US0_2, 2_i32)),
                            LrcPtr::new((Documents::US0::US0_3, 3_i32)),
                            LrcPtr::new((Documents::US0::US0_4, 4_i32)),
                        ])))),
                    )
            } {
                let v77: () = {
                    Documents::closure8(patternInput.0.clone(), ());
                    ()
                };
                let v81: () = {
                    v3();
                    ()
                };
                let patternInput_2: (
                    LrcPtr<Documents::Mut0>,
                    LrcPtr<Documents::Mut1>,
                    LrcPtr<Documents::Mut2>,
                    LrcPtr<Documents::Mut3>,
                    LrcPtr<Documents::Mut4>,
                    Option<i64>,
                ) = getValue(Documents::TraceState::trace_state().get().clone());
                let _v114: LrcPtr<MutCell<Option<Documents::US3>>> =
                    refCell(None::<Documents::US3>);
                let v119: () = {
                    Documents::closure10(
                        patternInput_2.5.clone(),
                        Func1::new({
                            let _v114 = _v114.clone();
                            move |v: Option<Documents::US3>| Documents::closure9(_v114.clone(), v)
                        }),
                        (),
                    );
                    ()
                };
                let v134: Documents::US3 = defaultValue(Documents::US3::US3_1, _v114.get().clone());
                let v174: DateTime = match &v134 {
                    Documents::US3::US3_0(v134_0_0) => {
                        let v148: TimeSpan = TimeSpan::new_ticks(
                            {
                                let _arg: DateTime = DateTime::now();
                                _arg.ticks()
                            } - match &v134 {
                                Documents::US3::US3_0(x) => x.clone(),
                                _ => unreachable!(),
                            },
                        );
                        DateTime::new_ymdhms_milli(
                            1_i32,
                            1_i32,
                            1_i32,
                            v148.hours(),
                            v148.minutes(),
                            v148.seconds(),
                            v148.milliseconds(),
                        )
                    }
                    _ => DateTime::now(),
                };
                let v179: string = {
                    let provider: string = Documents::method6();
                    v174.toString(provider)
                };
                let v571: string = padLeft(toLower(string("Info")), 7_i32, ' ');
                let v587: &str = inline_colorization::color_bright_green;
                let v589: &str = &*v571;
                let v591: &str = inline_colorization::color_reset;
                let v593: string = string("format!(\"{v587}{v589}{v591}\")");
                let v594: std::string::String = format!("{v587}{v589}{v591}");
                let v596: string = fable_library_rust::String_::fromString(v594);
                let v637: i64 = (patternInput_2.0.clone()).l0.get().clone();
                let v639: LrcPtr<Documents::Mut3> = LrcPtr::new(Documents::Mut3 {
                    l0: MutCell::new(Documents::method9()),
                });
                let v646: () = {
                    Documents::closure11(v639.clone(), sprintf!("{}", string("{ ")), ());
                    ()
                };
                let v655: () = {
                    Documents::closure11(v639.clone(), sprintf!("{}", string("exit_code")), ());
                    ()
                };
                let v664: () = {
                    Documents::closure11(v639.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v672: () = {
                    Documents::closure11(v639.clone(), sprintf!("{}", v1_1), ());
                    ()
                };
                let v681: () = {
                    Documents::closure11(v639.clone(), sprintf!("{}", string("; ")), ());
                    ()
                };
                let v690: () = {
                    Documents::closure11(v639.clone(), sprintf!("{}", string("result")), ());
                    ()
                };
                let v698: () = {
                    Documents::closure11(v639.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v706: () = {
                    Documents::closure11(v639.clone(), sprintf!("{}", v0_1), ());
                    ()
                };
                let v715: () = {
                    Documents::closure11(v639.clone(), sprintf!("{}", string(" }")), ());
                    ()
                };
                let v777: string = trimEndChars(
                    trimStartChars(
                        sprintf!(
                            "{} {} #{} {} / {}",
                            v179,
                            v596,
                            v637,
                            string("documents.files_fn / error"),
                            v639.l0.get().clone()
                        ),
                        toArray(empty::<char>()),
                    ),
                    toArray(ofArray(new_array(&[' ', '/']))),
                );
                println!("{}", v777.clone());
                ();
                ((patternInput.1.clone()).l0.get().clone())(v777)
            }
        }
        pub fn closure70(
            v0_1: string,
            v1_1: string,
            v2: string,
            v3: string,
            v4: string,
            v5: string,
        ) -> Documents::US30 {
            let patternInput: (string, string) = Documents::method72(v5, v4.clone(), v0_1);
            let v7: string = patternInput.1.clone();
            let v6: string = patternInput.0.clone();
            if (if if Documents::method77(v6.clone()) {
                Documents::method77(v7.clone())
            } else {
                false
            } {
                let v11: string = Documents::method25(v6.clone());
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
                    let v31: _ = [0_u8; 1024];
                    let v33: bool = true;
                    loop {
                        // rust.loop;
                        let v35: bool = true;
                        let mut v31 = v31;
                        let v37: Result<usize, std::io::Error> =
                            std::io::Read::read(&mut v19, &mut v31);
                        let v39: usize = v37.unwrap();
                        if v39 == v27 {
                            let v44: bool = true;
                            break;
                            ()
                        }
                        {
                            let v46: usize = v31.len();
                            let v47: u8 = v46 as u8;
                            let v50: usize = v39;
                            let v63: &_ = if v50 == v46 {
                                &v31[v27..]
                            } else {
                                &v31[v27..v50]
                            };
                            sha2::Digest::update(&mut v24, v63);
                            {
                                let v66: bool = true;
                            } // rust.loop;
                            let v68: bool = true;
                        } // rust.loop;
                        let v70: bool = true;
                    } // rust.loop;
                    let v72: bool = true;
                    {
                        // rust.loop;
                        let v74: bool = true;
                        {
                            // rust.loop;
                            let v76: &[u8] = &sha2::Digest::finalize(v24);
                            let v78: Vec<u8> = v76.iter().map(|x| *x).collect::<Vec<_>>();
                            let v80: bool = true;
                            let _vec_map: Vec<_> = v78
                                .into_iter()
                                .map(|x| {
                                    //;
                                    let v82: u8 = x;
                                    let v84: std::string::String = format!("{:02x}", v82);
                                    let v86: string = fable_library_rust::String_::fromString(v84);
                                    let v88: bool = true;
                                    v86
                                })
                                .collect::<Vec<_>>();
                            let v90: Vec<string> = _vec_map;
                            let v92: Array<string> =
                                fable_library_rust::NativeArray_::array_from(v90);
                            let v93: LrcPtr<dyn IEnumerable_1<string>> = delay(Func0::new({
                                let v92 = v92.clone();
                                move || {
                                    map(
                                        Func1::new({
                                            let v92 = v92.clone();
                                            move |i: i32| v92[i].clone()
                                        }),
                                        rangeNumeric(0_i32, 1_i32, count_2(v92.clone()) - 1_i32),
                                    )
                                }
                            }));
                            let v99: string = join(Documents::method74(), toArray_1(v93));
                            let v103 = Documents::method31();
                            let v105: Result<string, std::string::String> =
                                Ok::<string, std::io::Error>(v99).map_err(|x| v103(x));
                            let v106 = Documents::method75();
                            let v107 = Documents::method76();
                            let v109: Documents::US31 = match v105 {
                                Ok(x) => v106(x),
                                Err(e) => v107(e),
                            };
                            let v115: string = match &v109 {
                                Documents::US31::US31_0(v109_0_0) => v109_0_0.clone(),
                                Documents::US31::US31_1(v109_1_0) => panic!(
                                    "{}",
                                    sprintf!(
                                        "resultm.get / Result value was Error: {}",
                                        v109_1_0.clone()
                                    ),
                                ),
                            };
                            let v116: string = Documents::method25(v7.clone());
                            let v118: Result<std::fs::File, std::io::Error> =
                                std::fs::File::open(&*v116);
                            let v120: std::fs::File = v118.unwrap();
                            let v122: std::io::BufReader<std::fs::File> =
                                std::io::BufReader::new(v120);
                            let v124: std::io::BufReader<std::io::BufReader<std::fs::File>> =
                                std::io::BufReader::new(v122);
                            let v126: bool = true;
                            let mut v124 = v124;
                            let result: sha2::Sha256 = sha2::Digest::new();
                            {
                                let v129: sha2::Sha256 = result;
                                let v131: bool = true;
                                let mut v129 = v129;
                                let v132: usize = 0_i32 as usize;
                                let v136: _ = [0_u8; 1024];
                                let v138: bool = true;
                                loop {
                                    // rust.loop;
                                    let v140: bool = true;
                                    let mut v136 = v136;
                                    let v142: Result<usize, std::io::Error> =
                                        std::io::Read::read(&mut v124, &mut v136);
                                    let v144: usize = v142.unwrap();
                                    if v144 == v132 {
                                        let v149: bool = true;
                                        break;
                                        ()
                                    }
                                    {
                                        let v151: usize = v136.len();
                                        let v152: u8 = v151 as u8;
                                        let v155: usize = v144;
                                        let v168: &_ = if v155 == v151 {
                                            &v136[v132..]
                                        } else {
                                            &v136[v132..v155]
                                        };
                                        sha2::Digest::update(&mut v129, v168);
                                        {
                                            let v171: bool = true;
                                        } // rust.loop;
                                        let v173: bool = true;
                                    } // rust.loop;
                                    let v175: bool = true;
                                } // rust.loop;
                                let v177: bool = true;
                                {
                                    // rust.loop;
                                    let v179: bool = true;
                                    {
                                        // rust.loop;
                                        let v181: &[u8] = &sha2::Digest::finalize(v129);
                                        let v183: Vec<u8> =
                                            v181.iter().map(|x| *x).collect::<Vec<_>>();
                                        let v185: bool = true;
                                        let _vec_map: Vec<_> = v183
                                            .into_iter()
                                            .map(|x| {
                                                //;
                                                let v187: u8 = x;
                                                let v189: std::string::String =
                                                    format!("{:02x}", v187);
                                                let v191: string =
                                                    fable_library_rust::String_::fromString(v189);
                                                let v193: bool = true;
                                                v191
                                            })
                                            .collect::<Vec<_>>();
                                        let v195: Vec<string> = _vec_map;
                                        let v197: Array<string> =
                                            fable_library_rust::NativeArray_::array_from(v195);
                                        let v198: LrcPtr<dyn IEnumerable_1<string>> =
                                            delay(Func0::new({
                                                let v197 = v197.clone();
                                                move || {
                                                    map(
                                                        Func1::new({
                                                            let v197 = v197.clone();
                                                            move |i_1: i32| v197[i_1].clone()
                                                        }),
                                                        rangeNumeric(
                                                            0_i32,
                                                            1_i32,
                                                            count_2(v197.clone()) - 1_i32,
                                                        ),
                                                    )
                                                }
                                            }));
                                        let v204: string =
                                            join(Documents::method74(), toArray_1(v198));
                                        let v208 = Documents::method31();
                                        let v210: Result<string, std::string::String> =
                                            Ok::<string, std::io::Error>(v204).map_err(|x| v208(x));
                                        let v211 = Documents::method75();
                                        let v212 = Documents::method76();
                                        let v214: Documents::US31 = match v210 {
                                            Ok(x) => v211(x),
                                            Err(e) => v212(e),
                                        };
                                        v115 == match &v214 {
                                            Documents::US31::US31_0(v214_0_0) => v214_0_0.clone(),
                                            Documents::US31::US31_1(v214_1_0) => panic!(
                                                "{}",
                                                sprintf!(
                                                    "resultm.get / Result value was Error: {}",
                                                    v214_1_0.clone()
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
                let v224: Documents::US32 = Documents::method80(v2, v3, v6.clone(), v4);
                match &v224 {
                    Documents::US32::US32_0(v224_0_0, v224_0_1) => {
                        let v226: string = v224_0_1.clone();
                        let v225: i32 = v224_0_0.clone();
                        if v225 != 0_i32 {
                            let v232: () = {
                                Documents::closure73(v226.clone(), v225, ());
                                ()
                            };
                            Documents::US30::US30_0(Err::<string, LrcPtr<(string, string)>>(
                                LrcPtr::new((v6.clone(), v226)),
                            ))
                        } else {
                            if Documents::method77(v6.clone()) {
                                Documents::method78(v7, v6.clone())
                            } else {
                                panic!(
                                    "{}",
                                    sprintf!("documents.files_fn / {} should exist", v6.clone()),
                                )
                            }
                            Documents::US30::US30_0(Ok::<string, LrcPtr<(string, string)>>(
                                v6.clone(),
                            ))
                        }
                    }
                    Documents::US32::US32_1(v224_1_0, v224_1_1) => {
                        Documents::US30::US30_0(Err::<string, LrcPtr<(string, string)>>(
                            LrcPtr::new((v6.clone(), v224_1_1.clone())),
                        ))
                    }
                }
            } else {
                Documents::US30::US30_1
            }
        }
        pub fn closure69(
            v0_1: string,
            v1_1: string,
            v2: string,
            v3: string,
            v4: string,
        ) -> Func1<string, Documents::US30> {
            Func1::new({
                let v0_1 = v0_1.clone();
                let v1_1 = v1_1.clone();
                let v2 = v2.clone();
                let v3 = v3.clone();
                let v4 = v4.clone();
                move |v: string| {
                    Documents::closure70(
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
        pub fn closure76(v0_1: string, v1_1: string, v2: i32, unitVar: ()) {
            fn v4() {
                Documents::closure7((), ());
            }
            let v5: () = {
                v4();
                ()
            };
            let patternInput: (
                LrcPtr<Documents::Mut0>,
                LrcPtr<Documents::Mut1>,
                LrcPtr<Documents::Mut2>,
                LrcPtr<Documents::Mut3>,
                LrcPtr<Documents::Mut4>,
                Option<i64>,
            ) = getValue(Documents::TraceState::trace_state().get().clone());
            let v38: () = {
                v4();
                ()
            };
            let patternInput_1: (
                LrcPtr<Documents::Mut0>,
                LrcPtr<Documents::Mut1>,
                LrcPtr<Documents::Mut2>,
                LrcPtr<Documents::Mut3>,
                LrcPtr<Documents::Mut4>,
                Option<i64>,
            ) = getValue(Documents::TraceState::trace_state().get().clone());
            let v70: Documents::US0 = (patternInput_1.4.clone()).l0.get().clone();
            if if (patternInput_1.2.clone()).l0.get().clone() == false {
                false
            } else {
                3_i32
                    >= find(
                        v70,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Documents::US0::US0_0, 0_i32)),
                            LrcPtr::new((Documents::US0::US0_1, 1_i32)),
                            LrcPtr::new((Documents::US0::US0_2, 2_i32)),
                            LrcPtr::new((Documents::US0::US0_3, 3_i32)),
                            LrcPtr::new((Documents::US0::US0_4, 4_i32)),
                        ])))),
                    )
            } {
                let v78: () = {
                    Documents::closure8(patternInput.0.clone(), ());
                    ()
                };
                let v82: () = {
                    v4();
                    ()
                };
                let patternInput_2: (
                    LrcPtr<Documents::Mut0>,
                    LrcPtr<Documents::Mut1>,
                    LrcPtr<Documents::Mut2>,
                    LrcPtr<Documents::Mut3>,
                    LrcPtr<Documents::Mut4>,
                    Option<i64>,
                ) = getValue(Documents::TraceState::trace_state().get().clone());
                let _v115: LrcPtr<MutCell<Option<Documents::US3>>> =
                    refCell(None::<Documents::US3>);
                let v120: () = {
                    Documents::closure10(
                        patternInput_2.5.clone(),
                        Func1::new({
                            let _v115 = _v115.clone();
                            move |v: Option<Documents::US3>| Documents::closure9(_v115.clone(), v)
                        }),
                        (),
                    );
                    ()
                };
                let v135: Documents::US3 = defaultValue(Documents::US3::US3_1, _v115.get().clone());
                let v175: DateTime = match &v135 {
                    Documents::US3::US3_0(v135_0_0) => {
                        let v149: TimeSpan = TimeSpan::new_ticks(
                            {
                                let _arg: DateTime = DateTime::now();
                                _arg.ticks()
                            } - match &v135 {
                                Documents::US3::US3_0(x) => x.clone(),
                                _ => unreachable!(),
                            },
                        );
                        DateTime::new_ymdhms_milli(
                            1_i32,
                            1_i32,
                            1_i32,
                            v149.hours(),
                            v149.minutes(),
                            v149.seconds(),
                            v149.milliseconds(),
                        )
                    }
                    _ => DateTime::now(),
                };
                let v180: string = {
                    let provider: string = Documents::method6();
                    v175.toString(provider)
                };
                let v572: string = padLeft(toLower(string("Warning")), 7_i32, ' ');
                let v588: &str = inline_colorization::color_yellow;
                let v590: &str = &*v572;
                let v592: &str = inline_colorization::color_reset;
                let v594: string = string("format!(\"{v588}{v590}{v592}\")");
                let v595: std::string::String = format!("{v588}{v590}{v592}");
                let v597: string = fable_library_rust::String_::fromString(v595);
                let v638: i64 = (patternInput_2.0.clone()).l0.get().clone();
                let v640: LrcPtr<Documents::Mut3> = LrcPtr::new(Documents::Mut3 {
                    l0: MutCell::new(Documents::method9()),
                });
                let v647: () = {
                    Documents::closure11(v640.clone(), sprintf!("{}", string("{ ")), ());
                    ()
                };
                let v656: () = {
                    Documents::closure11(v640.clone(), sprintf!("{}", string("exit_code")), ());
                    ()
                };
                let v665: () = {
                    Documents::closure11(v640.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v673: () = {
                    Documents::closure11(v640.clone(), sprintf!("{}", v2), ());
                    ()
                };
                let v682: () = {
                    Documents::closure11(v640.clone(), sprintf!("{}", string("; ")), ());
                    ()
                };
                let v691: () = {
                    Documents::closure11(v640.clone(), sprintf!("{}", string("output_path")), ());
                    ()
                };
                let v699: () = {
                    Documents::closure11(v640.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v707: () = {
                    Documents::closure11(v640.clone(), sprintf!("{}", v0_1), ());
                    ()
                };
                let v715: () = {
                    Documents::closure11(v640.clone(), sprintf!("{}", string("; ")), ());
                    ()
                };
                let v724: () = {
                    Documents::closure11(v640.clone(), sprintf!("{}", string("result")), ());
                    ()
                };
                let v732: () = {
                    Documents::closure11(v640.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v740: () = {
                    Documents::closure11(v640.clone(), sprintf!("{}", v1_1), ());
                    ()
                };
                let v749: () = {
                    Documents::closure11(v640.clone(), sprintf!("{}", string(" }")), ());
                    ()
                };
                let v811: string = trimEndChars(
                    trimStartChars(
                        sprintf!(
                            "{} {} #{} {} / {}",
                            v180,
                            v597,
                            v638,
                            string("documents.crowbook / result contains ERROR"),
                            v640.l0.get().clone()
                        ),
                        toArray(empty::<char>()),
                    ),
                    toArray(ofArray(new_array(&[' ', '/']))),
                );
                println!("{}", v811.clone());
                ();
                ((patternInput.1.clone()).l0.get().clone())(v811)
            }
        }
        pub fn method87(
            v0_1: bool,
            v1_1: string,
            v2: string,
            v3: string,
            v4: string,
        ) -> Documents::US32 {
            let patternInput: (i32, string) = Documents::method39(
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
                None::<CancellationToken>,
                new_empty::<(string, string)>(),
                None::<Func1<(i32, string, bool), Arc<Async<()>>>>,
                None::<Func1<std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>, ()>>,
                true,
                Some(v3),
            );
            let v61: string = patternInput.1.clone();
            let v60: i32 = patternInput.0.clone();
            if contains(v61.clone(), string("ERROR")) {
                let v68: () = {
                    Documents::closure76(v1_1, v61.clone(), v60, ());
                    ()
                };
                Documents::US32::US32_1(v60, v61.clone())
            } else {
                Documents::US32::US32_0(v60, v61)
            }
        }
        pub fn closure75(
            v0_1: string,
            v1_1: string,
            v2: bool,
            v3: string,
            v4: string,
        ) -> Documents::US30 {
            let patternInput: (string, string) = Documents::method72(v4.clone(), v3.clone(), v0_1);
            let v6: string = patternInput.1.clone();
            let v5: string = patternInput.0.clone();
            if (if if Documents::method77(v5.clone()) {
                Documents::method77(v6.clone())
            } else {
                false
            } {
                let v10: string = Documents::method25(v5.clone());
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
                    let v30: _ = [0_u8; 1024];
                    let v32: bool = true;
                    loop {
                        // rust.loop;
                        let v34: bool = true;
                        let mut v30 = v30;
                        let v36: Result<usize, std::io::Error> =
                            std::io::Read::read(&mut v18, &mut v30);
                        let v38: usize = v36.unwrap();
                        if v38 == v26 {
                            let v43: bool = true;
                            break;
                            ()
                        }
                        {
                            let v45: usize = v30.len();
                            let v46: u8 = v45 as u8;
                            let v49: usize = v38;
                            let v62: &_ = if v49 == v45 {
                                &v30[v26..]
                            } else {
                                &v30[v26..v49]
                            };
                            sha2::Digest::update(&mut v23, v62);
                            {
                                let v65: bool = true;
                            } // rust.loop;
                            let v67: bool = true;
                        } // rust.loop;
                        let v69: bool = true;
                    } // rust.loop;
                    let v71: bool = true;
                    {
                        // rust.loop;
                        let v73: bool = true;
                        {
                            // rust.loop;
                            let v75: &[u8] = &sha2::Digest::finalize(v23);
                            let v77: Vec<u8> = v75.iter().map(|x| *x).collect::<Vec<_>>();
                            let v79: bool = true;
                            let _vec_map: Vec<_> = v77
                                .into_iter()
                                .map(|x| {
                                    //;
                                    let v81: u8 = x;
                                    let v83: std::string::String = format!("{:02x}", v81);
                                    let v85: string = fable_library_rust::String_::fromString(v83);
                                    let v87: bool = true;
                                    v85
                                })
                                .collect::<Vec<_>>();
                            let v89: Vec<string> = _vec_map;
                            let v91: Array<string> =
                                fable_library_rust::NativeArray_::array_from(v89);
                            let v92: LrcPtr<dyn IEnumerable_1<string>> = delay(Func0::new({
                                let v91 = v91.clone();
                                move || {
                                    map(
                                        Func1::new({
                                            let v91 = v91.clone();
                                            move |i: i32| v91[i].clone()
                                        }),
                                        rangeNumeric(0_i32, 1_i32, count_2(v91.clone()) - 1_i32),
                                    )
                                }
                            }));
                            let v98: string = join(Documents::method74(), toArray_1(v92));
                            let v102 = Documents::method31();
                            let v104: Result<string, std::string::String> =
                                Ok::<string, std::io::Error>(v98).map_err(|x| v102(x));
                            let v105 = Documents::method75();
                            let v106 = Documents::method76();
                            let v108: Documents::US31 = match v104 {
                                Ok(x) => v105(x),
                                Err(e) => v106(e),
                            };
                            let v114: string = match &v108 {
                                Documents::US31::US31_0(v108_0_0) => v108_0_0.clone(),
                                Documents::US31::US31_1(v108_1_0) => panic!(
                                    "{}",
                                    sprintf!(
                                        "resultm.get / Result value was Error: {}",
                                        v108_1_0.clone()
                                    ),
                                ),
                            };
                            let v115: string = Documents::method25(v6.clone());
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
                                let v135: _ = [0_u8; 1024];
                                let v137: bool = true;
                                loop {
                                    // rust.loop;
                                    let v139: bool = true;
                                    let mut v135 = v135;
                                    let v141: Result<usize, std::io::Error> =
                                        std::io::Read::read(&mut v123, &mut v135);
                                    let v143: usize = v141.unwrap();
                                    if v143 == v131 {
                                        let v148: bool = true;
                                        break;
                                        ()
                                    }
                                    {
                                        let v150: usize = v135.len();
                                        let v151: u8 = v150 as u8;
                                        let v154: usize = v143;
                                        let v167: &_ = if v154 == v150 {
                                            &v135[v131..]
                                        } else {
                                            &v135[v131..v154]
                                        };
                                        sha2::Digest::update(&mut v128, v167);
                                        {
                                            let v170: bool = true;
                                        } // rust.loop;
                                        let v172: bool = true;
                                    } // rust.loop;
                                    let v174: bool = true;
                                } // rust.loop;
                                let v176: bool = true;
                                {
                                    // rust.loop;
                                    let v178: bool = true;
                                    {
                                        // rust.loop;
                                        let v180: &[u8] = &sha2::Digest::finalize(v128);
                                        let v182: Vec<u8> =
                                            v180.iter().map(|x| *x).collect::<Vec<_>>();
                                        let v184: bool = true;
                                        let _vec_map: Vec<_> = v182
                                            .into_iter()
                                            .map(|x| {
                                                //;
                                                let v186: u8 = x;
                                                let v188: std::string::String =
                                                    format!("{:02x}", v186);
                                                let v190: string =
                                                    fable_library_rust::String_::fromString(v188);
                                                let v192: bool = true;
                                                v190
                                            })
                                            .collect::<Vec<_>>();
                                        let v194: Vec<string> = _vec_map;
                                        let v196: Array<string> =
                                            fable_library_rust::NativeArray_::array_from(v194);
                                        let v197: LrcPtr<dyn IEnumerable_1<string>> =
                                            delay(Func0::new({
                                                let v196 = v196.clone();
                                                move || {
                                                    map(
                                                        Func1::new({
                                                            let v196 = v196.clone();
                                                            move |i_1: i32| v196[i_1].clone()
                                                        }),
                                                        rangeNumeric(
                                                            0_i32,
                                                            1_i32,
                                                            count_2(v196.clone()) - 1_i32,
                                                        ),
                                                    )
                                                }
                                            }));
                                        let v203: string =
                                            join(Documents::method74(), toArray_1(v197));
                                        let v207 = Documents::method31();
                                        let v209: Result<string, std::string::String> =
                                            Ok::<string, std::io::Error>(v203).map_err(|x| v207(x));
                                        let v210 = Documents::method75();
                                        let v211 = Documents::method76();
                                        let v213: Documents::US31 = match v209 {
                                            Ok(x) => v210(x),
                                            Err(e) => v211(e),
                                        };
                                        v114 == match &v213 {
                                            Documents::US31::US31_0(v213_0_0) => v213_0_0.clone(),
                                            Documents::US31::US31_1(v213_1_0) => panic!(
                                                "{}",
                                                sprintf!(
                                                    "resultm.get / Result value was Error: {}",
                                                    v213_1_0.clone()
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
                let v223: Documents::US32 = Documents::method87(v2, v5.clone(), v3, v1_1, v4);
                match &v223 {
                    Documents::US32::US32_0(v223_0_0, v223_0_1) => {
                        let v225: string = v223_0_1.clone();
                        let v224: i32 = v223_0_0.clone();
                        if v224 != 0_i32 {
                            let v231: () = {
                                Documents::closure73(v225.clone(), v224, ());
                                ()
                            };
                            Documents::US30::US30_0(Err::<string, LrcPtr<(string, string)>>(
                                LrcPtr::new((v5.clone(), v225)),
                            ))
                        } else {
                            if Documents::method77(v5.clone()) {
                                Documents::method78(v6, v5.clone())
                            } else {
                                panic!(
                                    "{}",
                                    sprintf!("documents.files_fn / {} should exist", v5.clone()),
                                )
                            }
                            Documents::US30::US30_0(Ok::<string, LrcPtr<(string, string)>>(
                                v5.clone(),
                            ))
                        }
                    }
                    Documents::US32::US32_1(v223_1_0, v223_1_1) => {
                        Documents::US30::US30_0(Err::<string, LrcPtr<(string, string)>>(
                            LrcPtr::new((v5.clone(), v223_1_1.clone())),
                        ))
                    }
                }
            } else {
                Documents::US30::US30_1
            }
        }
        pub fn closure74(
            v0_1: string,
            v1_1: string,
            v2: bool,
            v3: string,
        ) -> Func1<string, Documents::US30> {
            Func1::new({
                let v0_1 = v0_1.clone();
                let v1_1 = v1_1.clone();
                let v2 = v2.clone();
                let v3 = v3.clone();
                move |v: string| Documents::closure75(v0_1.clone(), v1_1.clone(), v2, v3.clone(), v)
            })
        }
        pub fn closure77(v0_1: string, v1_1: string, unitVar: ()) {
            fn v3() {
                Documents::closure7((), ());
            }
            let v4: () = {
                v3();
                ()
            };
            let patternInput: (
                LrcPtr<Documents::Mut0>,
                LrcPtr<Documents::Mut1>,
                LrcPtr<Documents::Mut2>,
                LrcPtr<Documents::Mut3>,
                LrcPtr<Documents::Mut4>,
                Option<i64>,
            ) = getValue(Documents::TraceState::trace_state().get().clone());
            let v37: () = {
                v3();
                ()
            };
            let patternInput_1: (
                LrcPtr<Documents::Mut0>,
                LrcPtr<Documents::Mut1>,
                LrcPtr<Documents::Mut2>,
                LrcPtr<Documents::Mut3>,
                LrcPtr<Documents::Mut4>,
                Option<i64>,
            ) = getValue(Documents::TraceState::trace_state().get().clone());
            let v69: Documents::US0 = (patternInput_1.4.clone()).l0.get().clone();
            if if (patternInput_1.2.clone()).l0.get().clone() == false {
                false
            } else {
                2_i32
                    >= find(
                        v69,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Documents::US0::US0_0, 0_i32)),
                            LrcPtr::new((Documents::US0::US0_1, 1_i32)),
                            LrcPtr::new((Documents::US0::US0_2, 2_i32)),
                            LrcPtr::new((Documents::US0::US0_3, 3_i32)),
                            LrcPtr::new((Documents::US0::US0_4, 4_i32)),
                        ])))),
                    )
            } {
                let v77: () = {
                    Documents::closure8(patternInput.0.clone(), ());
                    ()
                };
                let v81: () = {
                    v3();
                    ()
                };
                let patternInput_2: (
                    LrcPtr<Documents::Mut0>,
                    LrcPtr<Documents::Mut1>,
                    LrcPtr<Documents::Mut2>,
                    LrcPtr<Documents::Mut3>,
                    LrcPtr<Documents::Mut4>,
                    Option<i64>,
                ) = getValue(Documents::TraceState::trace_state().get().clone());
                let _v114: LrcPtr<MutCell<Option<Documents::US3>>> =
                    refCell(None::<Documents::US3>);
                let v119: () = {
                    Documents::closure10(
                        patternInput_2.5.clone(),
                        Func1::new({
                            let _v114 = _v114.clone();
                            move |v: Option<Documents::US3>| Documents::closure9(_v114.clone(), v)
                        }),
                        (),
                    );
                    ()
                };
                let v134: Documents::US3 = defaultValue(Documents::US3::US3_1, _v114.get().clone());
                let v174: DateTime = match &v134 {
                    Documents::US3::US3_0(v134_0_0) => {
                        let v148: TimeSpan = TimeSpan::new_ticks(
                            {
                                let _arg: DateTime = DateTime::now();
                                _arg.ticks()
                            } - match &v134 {
                                Documents::US3::US3_0(x) => x.clone(),
                                _ => unreachable!(),
                            },
                        );
                        DateTime::new_ymdhms_milli(
                            1_i32,
                            1_i32,
                            1_i32,
                            v148.hours(),
                            v148.minutes(),
                            v148.seconds(),
                            v148.milliseconds(),
                        )
                    }
                    _ => DateTime::now(),
                };
                let v179: string = {
                    let provider: string = Documents::method6();
                    v174.toString(provider)
                };
                let v571: string = padLeft(toLower(string("Info")), 7_i32, ' ');
                let v587: &str = inline_colorization::color_bright_green;
                let v589: &str = &*v571;
                let v591: &str = inline_colorization::color_reset;
                let v593: string = string("format!(\"{v587}{v589}{v591}\")");
                let v594: std::string::String = format!("{v587}{v589}{v591}");
                let v596: string = fable_library_rust::String_::fromString(v594);
                let v637: i64 = (patternInput_2.0.clone()).l0.get().clone();
                let v639: LrcPtr<Documents::Mut3> = LrcPtr::new(Documents::Mut3 {
                    l0: MutCell::new(Documents::method9()),
                });
                let v646: () = {
                    Documents::closure11(v639.clone(), sprintf!("{}", string("{ ")), ());
                    ()
                };
                let v655: () = {
                    Documents::closure11(v639.clone(), sprintf!("{}", string("output_path")), ());
                    ()
                };
                let v664: () = {
                    Documents::closure11(v639.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v672: () = {
                    Documents::closure11(v639.clone(), sprintf!("{}", v1_1), ());
                    ()
                };
                let v681: () = {
                    Documents::closure11(v639.clone(), sprintf!("{}", string("; ")), ());
                    ()
                };
                let v690: () = {
                    Documents::closure11(
                        v639.clone(),
                        sprintf!("{}", string("output_cache_path")),
                        (),
                    );
                    ()
                };
                let v698: () = {
                    Documents::closure11(v639.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v706: () = {
                    Documents::closure11(v639.clone(), sprintf!("{}", v0_1), ());
                    ()
                };
                let v715: () = {
                    Documents::closure11(v639.clone(), sprintf!("{}", string(" }")), ());
                    ()
                };
                let v777: string = trimEndChars(
                    trimStartChars(
                        sprintf!(
                            "{} {} #{} {} / {}",
                            v179,
                            v596,
                            v637,
                            string("documents.run / par_map / files\' = [] / listm.iter"),
                            v639.l0.get().clone()
                        ),
                        toArray(empty::<char>()),
                    ),
                    toArray(ofArray(new_array(&[' ', '/']))),
                );
                println!("{}", v777.clone());
                ();
                ((patternInput.1.clone()).l0.get().clone())(v777)
            }
        }
        pub fn method88(
            v0_1: LrcPtr<Documents::UH4>,
            v1_1: List<LrcPtr<Documents::UH5>>,
        ) -> List<LrcPtr<Documents::UH5>> {
            match v0_1.as_ref() {
                Documents::UH4::UH4_0 => v1_1.clone(),
                Documents::UH4::UH4_1(v0_1_1_0, v0_1_1_1) => cons(
                    match v0_1.as_ref() {
                        Documents::UH4::UH4_1(x, _) => x.clone(),
                        _ => unreachable!(),
                    },
                    Documents::method88(
                        match v0_1.as_ref() {
                            Documents::UH4::UH4_1(_, x) => x.clone(),
                            _ => unreachable!(),
                        },
                        v1_1.clone(),
                    ),
                ),
            }
        }
        pub fn method89(v0_1: i32, v1_1: LrcPtr<Documents::Mut9>) -> bool {
            v1_1.l0.get().clone() < v0_1
        }
        pub fn method90(
            v0_1: LrcPtr<Documents::UH5>,
            v1_1: List<(
                string,
                string,
                Func1<string, Func1<string, Documents::US30>>,
            )>,
        ) -> List<(
            string,
            string,
            Func1<string, Func1<string, Documents::US30>>,
        )> {
            match v0_1.as_ref() {
                Documents::UH5::UH5_0 => v1_1.clone(),
                Documents::UH5::UH5_1(v0_1_1_0, v0_1_1_1, v0_1_1_2, v0_1_1_3) => cons(
                    (
                        match v0_1.as_ref() {
                            Documents::UH5::UH5_1(x, _, _, _) => x.clone(),
                            _ => unreachable!(),
                        },
                        match v0_1.as_ref() {
                            Documents::UH5::UH5_1(_, x, _, _) => x.clone(),
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
                                            Documents::UH5::UH5_1(_, _, x, _) => x.clone(),
                                            _ => unreachable!(),
                                        })(a0.clone(), a1)
                                    }
                                })
                            }
                        }),
                    ),
                    Documents::method90(
                        match v0_1.as_ref() {
                            Documents::UH5::UH5_1(_, _, _, x) => x.clone(),
                            _ => unreachable!(),
                        },
                        v1_1.clone(),
                    ),
                ),
            }
        }
        pub fn closure78(
            unitVar: (),
            _arg: (
                string,
                string,
                Func1<string, Func1<string, Documents::US30>>,
            ),
        ) -> Option<Result<string, LrcPtr<(string, string)>>> {
            let v4: Documents::US30 = (_arg.2.clone())(_arg.1.clone())(_arg.0.clone());
            match &v4 {
                Documents::US30::US30_0(v4_0_0) => Some(match &v4 {
                    Documents::US30::US30_0(x) => x.clone(),
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
        pub fn closure29(
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
            let v6: string = Documents::method24(v5);
            let v8: &str = &*v6.clone();
            let v10: std::string::String = String::from(v8);
            let v12: std::path::PathBuf = std::path::PathBuf::from(v10);
            let v14: std::path::Display = v12.display();
            let v17: std::string::String = format!("{}", v14);
            let v43: string = sprintf!(
                ".{}",
                replace(
                    replace(
                        fable_library_rust::String_::fromString(v17),
                        v3.clone(),
                        Documents::method37()
                    ),
                    string("\\"),
                    string("/")
                )
            );
            let v44: string = Documents::method25(v6);
            let v46: string = Documents::method38(Documents::method15(v2.clone(), v43.clone()));
            let patternInput: (i32, string) = Documents::method39(
                sprintf!(
                    "git ls-tree --format=\'%(objectname)\' origin/gh-pages \"{}\"",
                    v46.clone()
                ),
                None::<CancellationToken>,
                new_empty::<(string, string)>(),
                None::<Func1<(i32, string, bool), Arc<Async<()>>>>,
                None::<Func1<std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>, ()>>,
                true,
                Some(v2),
            );
            let v58: string = patternInput.1.clone();
            let v60: string = Documents::method38(Documents::method15(v3.clone(), v43.clone()));
            let patternInput_1: (i32, string) = Documents::method39(
                sprintf!("git hash-object \"{}\"", v60.clone()),
                None::<CancellationToken>,
                new_empty::<(string, string)>(),
                None::<Func1<(i32, string, bool), Arc<Async<()>>>>,
                None::<Func1<std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>, ()>>,
                true,
                Some(v3.clone()),
            );
            let v72: string = patternInput_1.1.clone();
            let v74: string = Documents::method38(Documents::method15(v4.clone(), v43.clone()));
            let v76: string = (Documents::method72(string("hangul.md"), v60.clone(), v4.clone()))
                .0
                .clone();
            let v1469: LrcPtr<Documents::UH4> = if contains(v58.clone(), v72.clone()) == false {
                let v88: string = Documents::method25(v60.clone());
                let v90: Result<std::fs::File, std::io::Error> = std::fs::File::open(&*v88);
                let v92: std::fs::File = v90.unwrap();
                let v94: std::io::BufReader<std::fs::File> = std::io::BufReader::new(v92);
                let v96: std::io::BufReader<std::io::BufReader<std::fs::File>> =
                    std::io::BufReader::new(v94);
                let v98: bool = true;
                let mut v96 = v96;
                let result: sha2::Sha256 = sha2::Digest::new();
                {
                    let v101: sha2::Sha256 = result;
                    let v103: bool = true;
                    let mut v101 = v101;
                    let v104: usize = 0_i32 as usize;
                    let v108: _ = [0_u8; 1024];
                    let v110: bool = true;
                    loop {
                        // rust.loop;
                        let v112: bool = true;
                        let mut v108 = v108;
                        let v114: Result<usize, std::io::Error> =
                            std::io::Read::read(&mut v96, &mut v108);
                        let v116: usize = v114.unwrap();
                        if v116 == v104 {
                            let v121: bool = true;
                            break;
                            ()
                        }
                        {
                            let v123: usize = v108.len();
                            let v124: u8 = v123 as u8;
                            let v127: usize = v116;
                            let v140: &_ = if v127 == v123 {
                                &v108[v104..]
                            } else {
                                &v108[v104..v127]
                            };
                            sha2::Digest::update(&mut v101, v140);
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
                            let v153: &[u8] = &sha2::Digest::finalize(v101);
                            let v155: Vec<u8> = v153.iter().map(|x| *x).collect::<Vec<_>>();
                            let v157: bool = true;
                            let _vec_map: Vec<_> = v155
                                .into_iter()
                                .map(|x| {
                                    //;
                                    let v159: u8 = x;
                                    let v161: std::string::String = format!("{:02x}", v159);
                                    let v163: string =
                                        fable_library_rust::String_::fromString(v161);
                                    let v165: bool = true;
                                    v163
                                })
                                .collect::<Vec<_>>();
                            let v167: Vec<string> = _vec_map;
                            let v169: Array<string> =
                                fable_library_rust::NativeArray_::array_from(v167);
                            let v170: LrcPtr<dyn IEnumerable_1<string>> = delay(Func0::new({
                                let v169 = v169.clone();
                                move || {
                                    map(
                                        Func1::new({
                                            let v169 = v169.clone();
                                            move |i: i32| v169[i].clone()
                                        }),
                                        rangeNumeric(0_i32, 1_i32, count_2(v169.clone()) - 1_i32),
                                    )
                                }
                            }));
                            let v176: string = join(Documents::method74(), toArray_1(v170));
                            let v180 = Documents::method31();
                            let v182: Result<string, std::string::String> =
                                Ok::<string, std::io::Error>(v176).map_err(|x| v180(x));
                            let v183 = Documents::method75();
                            let v184 = Documents::method76();
                            let v186: Documents::US31 = match v182 {
                                Ok(x) => v183(x),
                                Err(e) => v184(e),
                            };
                            let v192: string = match &v186 {
                                Documents::US31::US31_0(v186_0_0) => v186_0_0.clone(),
                                Documents::US31::US31_1(v186_1_0) => panic!(
                                    "{}",
                                    sprintf!(
                                        "resultm.get / Result value was Error: {}",
                                        v186_1_0.clone()
                                    ),
                                ),
                            };
                            let v301: Documents::US1 = if Documents::method77(v74.clone()) == false
                            {
                                Documents::US1::US1_1
                            } else {
                                let v196: string = Documents::method25(v74.clone());
                                let v198: Result<std::fs::File, std::io::Error> =
                                    std::fs::File::open(&*v196);
                                let v200: std::fs::File = v198.unwrap();
                                let v202: std::io::BufReader<std::fs::File> =
                                    std::io::BufReader::new(v200);
                                let v204: std::io::BufReader<std::io::BufReader<std::fs::File>> =
                                    std::io::BufReader::new(v202);
                                let v206: bool = true;
                                let mut v204 = v204;
                                let result: sha2::Sha256 = sha2::Digest::new();
                                {
                                    let v209: sha2::Sha256 = result;
                                    let v211: bool = true;
                                    let mut v209 = v209;
                                    let v212: usize = 0_i32 as usize;
                                    let v216: _ = [0_u8; 1024];
                                    let v218: bool = true;
                                    loop {
                                        // rust.loop;
                                        let v220: bool = true;
                                        let mut v216 = v216;
                                        let v222: Result<usize, std::io::Error> =
                                            std::io::Read::read(&mut v204, &mut v216);
                                        let v224: usize = v222.unwrap();
                                        if v224 == v212 {
                                            let v229: bool = true;
                                            break;
                                            ()
                                        }
                                        {
                                            let v231: usize = v216.len();
                                            let v232: u8 = v231 as u8;
                                            let v235: usize = v224;
                                            let v248: &_ = if v235 == v231 {
                                                &v216[v212..]
                                            } else {
                                                &v216[v212..v235]
                                            };
                                            sha2::Digest::update(&mut v209, v248);
                                            {
                                                let v251: bool = true;
                                            } // rust.loop;
                                            let v253: bool = true;
                                        } // rust.loop;
                                        let v255: bool = true;
                                    } // rust.loop;
                                    let v257: bool = true;
                                    {
                                        // rust.loop;
                                        let v259: bool = true;
                                        {
                                            // rust.loop;
                                            let v261: &[u8] = &sha2::Digest::finalize(v209);
                                            let v263: Vec<u8> =
                                                v261.iter().map(|x| *x).collect::<Vec<_>>();
                                            let v265: bool = true;
                                            let _vec_map: Vec<_> = v263
                                                .into_iter()
                                                .map(|x| {
                                                    //;
                                                    let v267: u8 = x;
                                                    let v269: std::string::String =
                                                        format!("{:02x}", v267);
                                                    let v271: string =
                                                        fable_library_rust::String_::fromString(
                                                            v269,
                                                        );
                                                    let v273: bool = true;
                                                    v271
                                                })
                                                .collect::<Vec<_>>();
                                            let v275: Vec<string> = _vec_map;
                                            let v277: Array<string> =
                                                fable_library_rust::NativeArray_::array_from(v275);
                                            let v278: LrcPtr<dyn IEnumerable_1<string>> =
                                                delay(Func0::new({
                                                    let v277 = v277.clone();
                                                    move || {
                                                        map(
                                                            Func1::new({
                                                                let v277 = v277.clone();
                                                                move |i_1: i32| v277[i_1].clone()
                                                            }),
                                                            rangeNumeric(
                                                                0_i32,
                                                                1_i32,
                                                                count_2(v277.clone()) - 1_i32,
                                                            ),
                                                        )
                                                    }
                                                }));
                                            let v284: string =
                                                join(Documents::method74(), toArray_1(v278));
                                            let v288 = Documents::method31();
                                            let v290: Result<string, std::string::String> =
                                                Ok::<string, std::io::Error>(v284)
                                                    .map_err(|x| v288(x));
                                            let v291 = Documents::method75();
                                            let v292 = Documents::method76();
                                            let v294: Documents::US31 = match v290 {
                                                Ok(x) => v291(x),
                                                Err(e) => v292(e),
                                            };
                                            match &v294 {
                                                Documents::US31::US31_0(v294_0_0) => {
                                                    Documents::US1::US1_0(v294_0_0.clone())
                                                }
                                                _ => Documents::US1::US1_1,
                                            }
                                        }
                                    }
                                }
                            };
                            if if if let Documents::US1::US1_1 = &v301 {
                                true
                            } else {
                                false
                            } {
                                true
                            } else {
                                v192.clone()
                                    != match &v301 {
                                        Documents::US1::US1_0(v301_0_0) => match &v301 {
                                            Documents::US1::US1_0(x) => x.clone(),
                                            _ => unreachable!(),
                                        },
                                        _ => panic!("{}", string("Option does not have a value."),),
                                    }
                            } {
                                let v313: () = {
                                    Documents::closure68(
                                        v43,
                                        v44.clone(),
                                        v46,
                                        v58,
                                        patternInput.0.clone(),
                                        v60.clone(),
                                        v72,
                                        patternInput_1.0.clone(),
                                        v74.clone(),
                                        v192,
                                        v301.clone(),
                                        (),
                                    );
                                    ()
                                };
                                Documents::method78(v74, v60.clone());
                                LrcPtr::new(Documents::UH4::UH4_1(
                                    LrcPtr::new(Documents::UH5::UH5_1(
                                        string("hangul.md"),
                                        v60.clone(),
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
                                                        Documents::closure69(
                                                            v4.clone(),
                                                            v3.clone(),
                                                            v1_1.clone(),
                                                            v0_1.clone(),
                                                            v,
                                                        )
                                                    }
                                                }))(
                                                    b0
                                                )(b1)
                                            }
                                        }),
                                        LrcPtr::new(Documents::UH5::UH5_0),
                                    )),
                                    LrcPtr::new(Documents::UH4::UH4_1(
                                        LrcPtr::new(Documents::UH5::UH5_1(
                                            string("html"),
                                            v60.clone(),
                                            Func2::new({
                                                let v3 = v3.clone();
                                                let v4 = v4.clone();
                                                move |b0: string, b1: string| {
                                                    (Func1::new({
                                                        let v3 = v3.clone();
                                                        let v4 = v4.clone();
                                                        move |v_1: string| {
                                                            Documents::closure74(
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
                                            LrcPtr::new(Documents::UH5::UH5_1(
                                                string("pdf"),
                                                v60.clone(),
                                                Func2::new({
                                                    let v3 = v3.clone();
                                                    let v4 = v4.clone();
                                                    move |b0: string, b1: string| {
                                                        (Func1::new({
                                                            let v3 = v3.clone();
                                                            let v4 = v4.clone();
                                                            move |v_2: string| {
                                                                Documents::closure74(
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
                                                LrcPtr::new(Documents::UH5::UH5_1(
                                                    string("epub"),
                                                    v60.clone(),
                                                    Func2::new({
                                                        let v3 = v3.clone();
                                                        let v4 = v4.clone();
                                                        move |b0: string, b1: string| {
                                                            (Func1::new({
                                                                let v3 = v3.clone();
                                                                let v4 = v4.clone();
                                                                move |v_3: string| {
                                                                    Documents::closure74(
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
                                                    LrcPtr::new(Documents::UH5::UH5_1(
                                                        string("html"),
                                                        v76.clone(),
                                                        Func2::new({
                                                            let v3 = v3.clone();
                                                            let v4 = v4.clone();
                                                            move |b0: string, b1: string| {
                                                                (Func1::new({
                                                                    let v3 = v3.clone();
                                                                    let v4 = v4.clone();
                                                                    move |v_4: string| {
                                                                        Documents::closure74(
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
                                                        LrcPtr::new(Documents::UH5::UH5_1(
                                                            string("pdf"),
                                                            v76.clone(),
                                                            Func2::new({
                                                                let v3 = v3.clone();
                                                                let v4 = v4.clone();
                                                                move |b0: string, b1: string| {
                                                                    (Func1::new({
                                                                        let v3 = v3.clone();
                                                                        let v4 = v4.clone();
                                                                        move |v_5: string| {
                                                                            Documents::closure74(
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
                                                            LrcPtr::new(Documents::UH5::UH5_1(
                                                                string("epub"),
                                                                v76.clone(),
                                                                Func2::new({
                                                                    let v3 = v3.clone();
                                                                    let v4 = v4.clone();
                                                                    move |b0: string, b1: string| {
                                                                        (Func1::new({
                                                                            let v3 = v3.clone();
                                                                            let v4 = v4.clone();
                                                                            move |v_6: string| {
                                                                                Documents::closure74(
                                                                                    v4.clone(),
                                                                                    v3.clone(),
                                                                                    true,
                                                                                    v_6,
                                                                                )
                                                                            }
                                                                        }))(
                                                                            b0
                                                                        )(
                                                                            b1
                                                                        )
                                                                    }
                                                                }),
                                                                LrcPtr::new(Documents::UH5::UH5_0),
                                                            )),
                                                        )),
                                                    )),
                                                )),
                                            )),
                                        )),
                                        LrcPtr::new(Documents::UH4::UH4_0),
                                    )),
                                ))
                            } else {
                                LrcPtr::new(Documents::UH4::UH4_0)
                            }
                        }
                    }
                }
            } else {
                LrcPtr::new(Documents::UH4::UH4_0)
            };
            let v7387: Array<LrcPtr<Documents::UH5>> = toArray(Documents::method88(
                if (if let Documents::UH4::UH4_0 = v1469.as_ref() {
                    true
                } else {
                    false
                }) != true
                {
                    v1469
                } else {
                    let patternInput_3: (string, string) =
                        Documents::method72(string("epub"), v76.clone(), v4.clone());
                    let v1474: string = patternInput_3.1.clone();
                    let v1473: string = patternInput_3.0.clone();
                    let v2317: LrcPtr<Documents::UH5> = if if Documents::method77(v1473.clone())
                        == false
                    {
                        if Documents::method77(v1474.clone()) {
                            let v1480: () = {
                                Documents::closure77(v1474.clone(), v1473.clone(), ());
                                ()
                            };
                            Documents::method78(v1473, v1474);
                            false
                        } else {
                            true
                        }
                    } else {
                        true
                    } {
                        LrcPtr::new(Documents::UH5::UH5_1(
                            string("epub"),
                            v76.clone(),
                            Func2::new({
                                let v3 = v3.clone();
                                let v4 = v4.clone();
                                move |b0: string, b1: string| {
                                    (Func1::new({
                                        let v3 = v3.clone();
                                        let v4 = v4.clone();
                                        move |v_7: string| {
                                            Documents::closure74(v4.clone(), v3.clone(), true, v_7)
                                        }
                                    }))(b0)(b1)
                                }
                            }),
                            LrcPtr::new(Documents::UH5::UH5_0),
                        ))
                    } else {
                        LrcPtr::new(Documents::UH5::UH5_0)
                    };
                    let patternInput_4: (string, string) =
                        Documents::method72(string("pdf"), v76.clone(), v4.clone());
                    let v2320: string = patternInput_4.1.clone();
                    let v2319: string = patternInput_4.0.clone();
                    let v3161: LrcPtr<Documents::UH5> = if if Documents::method77(v2319.clone())
                        == false
                    {
                        if Documents::method77(v2320.clone()) {
                            let v2326: () = {
                                Documents::closure77(v2320.clone(), v2319.clone(), ());
                                ()
                            };
                            Documents::method78(v2319, v2320);
                            false
                        } else {
                            true
                        }
                    } else {
                        true
                    } {
                        LrcPtr::new(Documents::UH5::UH5_1(
                            string("pdf"),
                            v76.clone(),
                            Func2::new({
                                let v3 = v3.clone();
                                let v4 = v4.clone();
                                move |b0: string, b1: string| {
                                    (Func1::new({
                                        let v3 = v3.clone();
                                        let v4 = v4.clone();
                                        move |v_8: string| {
                                            Documents::closure74(v4.clone(), v3.clone(), true, v_8)
                                        }
                                    }))(b0)(b1)
                                }
                            }),
                            v2317.clone(),
                        ))
                    } else {
                        v2317
                    };
                    let patternInput_5: (string, string) =
                        Documents::method72(string("html"), v76.clone(), v4.clone());
                    let v3164: string = patternInput_5.1.clone();
                    let v3163: string = patternInput_5.0.clone();
                    let v4005: LrcPtr<Documents::UH5> = if if Documents::method77(v3163.clone())
                        == false
                    {
                        if Documents::method77(v3164.clone()) {
                            let v3170: () = {
                                Documents::closure77(v3164.clone(), v3163.clone(), ());
                                ()
                            };
                            Documents::method78(v3163, v3164);
                            false
                        } else {
                            true
                        }
                    } else {
                        true
                    } {
                        LrcPtr::new(Documents::UH5::UH5_1(
                            string("html"),
                            v76,
                            Func2::new({
                                let v3 = v3.clone();
                                let v4 = v4.clone();
                                move |b0: string, b1: string| {
                                    (Func1::new({
                                        let v3 = v3.clone();
                                        let v4 = v4.clone();
                                        move |v_9: string| {
                                            Documents::closure74(v4.clone(), v3.clone(), true, v_9)
                                        }
                                    }))(b0)(b1)
                                }
                            }),
                            v3161.clone(),
                        ))
                    } else {
                        v3161
                    };
                    let patternInput_6: (string, string) =
                        Documents::method72(string("epub"), v60.clone(), v4.clone());
                    let v4007: string = patternInput_6.1.clone();
                    let v4006: string = patternInput_6.0.clone();
                    let v4848: LrcPtr<Documents::UH5> =
                        if if Documents::method77(v4006.clone()) == false {
                            if Documents::method77(v4007.clone()) {
                                let v4013: () = {
                                    Documents::closure77(v4007.clone(), v4006.clone(), ());
                                    ()
                                };
                                Documents::method78(v4006, v4007);
                                false
                            } else {
                                true
                            }
                        } else {
                            true
                        } {
                            LrcPtr::new(Documents::UH5::UH5_1(
                                string("epub"),
                                v60.clone(),
                                Func2::new({
                                    let v3 = v3.clone();
                                    let v4 = v4.clone();
                                    move |b0: string, b1: string| {
                                        (Func1::new({
                                            let v3 = v3.clone();
                                            let v4 = v4.clone();
                                            move |v_10: string| {
                                                Documents::closure74(
                                                    v4.clone(),
                                                    v3.clone(),
                                                    false,
                                                    v_10,
                                                )
                                            }
                                        }))(b0)(b1)
                                    }
                                }),
                                v4005.clone(),
                            ))
                        } else {
                            v4005
                        };
                    let patternInput_7: (string, string) =
                        Documents::method72(string("pdf"), v60.clone(), v4.clone());
                    let v4850: string = patternInput_7.1.clone();
                    let v4849: string = patternInput_7.0.clone();
                    let v5691: LrcPtr<Documents::UH5> =
                        if if Documents::method77(v4849.clone()) == false {
                            if Documents::method77(v4850.clone()) {
                                let v4856: () = {
                                    Documents::closure77(v4850.clone(), v4849.clone(), ());
                                    ()
                                };
                                Documents::method78(v4849, v4850);
                                false
                            } else {
                                true
                            }
                        } else {
                            true
                        } {
                            LrcPtr::new(Documents::UH5::UH5_1(
                                string("pdf"),
                                v60.clone(),
                                Func2::new({
                                    let v3 = v3.clone();
                                    let v4 = v4.clone();
                                    move |b0: string, b1: string| {
                                        (Func1::new({
                                            let v3 = v3.clone();
                                            let v4 = v4.clone();
                                            move |v_11: string| {
                                                Documents::closure74(
                                                    v4.clone(),
                                                    v3.clone(),
                                                    false,
                                                    v_11,
                                                )
                                            }
                                        }))(b0)(b1)
                                    }
                                }),
                                v4848.clone(),
                            ))
                        } else {
                            v4848
                        };
                    let patternInput_8: (string, string) =
                        Documents::method72(string("html"), v60.clone(), v4.clone());
                    let v5693: string = patternInput_8.1.clone();
                    let v5692: string = patternInput_8.0.clone();
                    let v6534: LrcPtr<Documents::UH5> =
                        if if Documents::method77(v5692.clone()) == false {
                            if Documents::method77(v5693.clone()) {
                                let v5699: () = {
                                    Documents::closure77(v5693.clone(), v5692.clone(), ());
                                    ()
                                };
                                Documents::method78(v5692, v5693);
                                false
                            } else {
                                true
                            }
                        } else {
                            true
                        } {
                            LrcPtr::new(Documents::UH5::UH5_1(
                                string("html"),
                                v60.clone(),
                                Func2::new({
                                    let v3 = v3.clone();
                                    let v4 = v4.clone();
                                    move |b0: string, b1: string| {
                                        (Func1::new({
                                            let v3 = v3.clone();
                                            let v4 = v4.clone();
                                            move |v_12: string| {
                                                Documents::closure74(
                                                    v4.clone(),
                                                    v3.clone(),
                                                    false,
                                                    v_12,
                                                )
                                            }
                                        }))(b0)(b1)
                                    }
                                }),
                                v5691.clone(),
                            ))
                        } else {
                            v5691
                        };
                    let patternInput_9: (string, string) =
                        Documents::method72(string("hangul.md"), v60.clone(), v4.clone());
                    let v6536: string = patternInput_9.1.clone();
                    let v6535: string = patternInput_9.0.clone();
                    LrcPtr::new(Documents::UH4::UH4_1(
                        if if Documents::method77(v6535.clone()) == false {
                            if Documents::method77(v6536.clone()) {
                                let v6542: () = {
                                    Documents::closure77(v6536.clone(), v6535.clone(), ());
                                    ()
                                };
                                Documents::method78(v6535, v6536);
                                false
                            } else {
                                true
                            }
                        } else {
                            true
                        } {
                            LrcPtr::new(Documents::UH5::UH5_1(
                                string("hangul.md"),
                                v60,
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
                                                Documents::closure69(
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
                                LrcPtr::new(Documents::UH5::UH5_0),
                            ))
                        } else {
                            LrcPtr::new(Documents::UH5::UH5_0)
                        },
                        LrcPtr::new(Documents::UH4::UH4_1(
                            v6534,
                            LrcPtr::new(Documents::UH4::UH4_0),
                        )),
                    ))
                },
                empty::<LrcPtr<Documents::UH5>>(),
            ));
            let v7391: Vec<LrcPtr<Documents::UH5>> = v7387.to_vec();
            let v7394: Vec<Option<Result<string, LrcPtr<(string, string)>>>> =
                new_empty::<Option<Result<string, LrcPtr<(string, string)>>>>().to_vec();
            let v7396: Array<LrcPtr<Documents::UH5>> =
                fable_library_rust::NativeArray_::array_from(v7391);
            let v7397: i32 = count_2(v7396.clone());
            let v7398: LrcPtr<Documents::Mut9> = LrcPtr::new(Documents::Mut9 {
                l0: MutCell::new(0_i32),
                l1: MutCell::new(v7394),
            });
            while Documents::method89(v7397, v7398.clone()) {
                let v7400: i32 = v7398.l0.get().clone();
                let v7401: Vec<Option<Result<string, LrcPtr<(string, string)>>>> =
                    v7398.l1.get().clone();
                let v7406 = toArray(Documents::method90(
                    v7396[v7400].clone(),
                    empty::<(
                        string,
                        string,
                        Func1<string, Func1<string, Documents::US30>>,
                    )>(),
                ));
                let v7410 = v7406.to_vec();
                let v7412 = rayon::iter::IntoParallelIterator::into_par_iter(v7410);
                let v7415 = rayon::iter::ParallelIterator::map(v7412, |x| {
                    Func1::new(
                        move |arg10_0040_8: (
                            string,
                            string,
                            Func1<string, Func1<string, Documents::US30>>,
                        )| Documents::closure78((), arg10_0040_8),
                    )(x)
                });
                let v7418: Vec<Option<Result<string, LrcPtr<(string, string)>>>> =
                    Documents::method91(rayon::iter::ParallelIterator::collect(v7415));
                let v7419: Vec<Option<Result<string, LrcPtr<(string, string)>>>> =
                    Documents::method92(v7401);
                let v7421: bool = true;
                let mut v7419 = v7419;
                let v7423: bool = true;
                v7419.extend(v7418);
                let v7425: Vec<Option<Result<string, LrcPtr<(string, string)>>>> = v7419;
                let v7426: i32 = v7400 + 1_i32;
                v7398.l0.set(v7426);
                v7398.l1.set(v7425);
                ()
            }
            Ok::<
                LrcPtr<(
                    string,
                    Vec<Option<Result<string, LrcPtr<(string, string)>>>>,
                )>,
                std::string::String,
            >(LrcPtr::new((v44, v7398.l1.get().clone())))
        }
        pub fn closure79(
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
        ) {
            fn v2() {
                Documents::closure7((), ());
            }
            let v3: () = {
                v2();
                ()
            };
            let patternInput: (
                LrcPtr<Documents::Mut0>,
                LrcPtr<Documents::Mut1>,
                LrcPtr<Documents::Mut2>,
                LrcPtr<Documents::Mut3>,
                LrcPtr<Documents::Mut4>,
                Option<i64>,
            ) = getValue(Documents::TraceState::trace_state().get().clone());
            let v36: () = {
                v2();
                ()
            };
            let patternInput_1: (
                LrcPtr<Documents::Mut0>,
                LrcPtr<Documents::Mut1>,
                LrcPtr<Documents::Mut2>,
                LrcPtr<Documents::Mut3>,
                LrcPtr<Documents::Mut4>,
                Option<i64>,
            ) = getValue(Documents::TraceState::trace_state().get().clone());
            let v68: Documents::US0 = (patternInput_1.4.clone()).l0.get().clone();
            if if (patternInput_1.2.clone()).l0.get().clone() == false {
                false
            } else {
                2_i32
                    >= find(
                        v68,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Documents::US0::US0_0, 0_i32)),
                            LrcPtr::new((Documents::US0::US0_1, 1_i32)),
                            LrcPtr::new((Documents::US0::US0_2, 2_i32)),
                            LrcPtr::new((Documents::US0::US0_3, 3_i32)),
                            LrcPtr::new((Documents::US0::US0_4, 4_i32)),
                        ])))),
                    )
            } {
                let v76: () = {
                    Documents::closure8(patternInput.0.clone(), ());
                    ()
                };
                let v80: () = {
                    v2();
                    ()
                };
                let patternInput_2: (
                    LrcPtr<Documents::Mut0>,
                    LrcPtr<Documents::Mut1>,
                    LrcPtr<Documents::Mut2>,
                    LrcPtr<Documents::Mut3>,
                    LrcPtr<Documents::Mut4>,
                    Option<i64>,
                ) = getValue(Documents::TraceState::trace_state().get().clone());
                let _v113: LrcPtr<MutCell<Option<Documents::US3>>> =
                    refCell(None::<Documents::US3>);
                let v118: () = {
                    Documents::closure10(
                        patternInput_2.5.clone(),
                        Func1::new({
                            let _v113 = _v113.clone();
                            move |v: Option<Documents::US3>| Documents::closure9(_v113.clone(), v)
                        }),
                        (),
                    );
                    ()
                };
                let v133: Documents::US3 = defaultValue(Documents::US3::US3_1, _v113.get().clone());
                let v173: DateTime = match &v133 {
                    Documents::US3::US3_0(v133_0_0) => {
                        let v147: TimeSpan = TimeSpan::new_ticks(
                            {
                                let _arg: DateTime = DateTime::now();
                                _arg.ticks()
                            } - match &v133 {
                                Documents::US3::US3_0(x) => x.clone(),
                                _ => unreachable!(),
                            },
                        );
                        DateTime::new_ymdhms_milli(
                            1_i32,
                            1_i32,
                            1_i32,
                            v147.hours(),
                            v147.minutes(),
                            v147.seconds(),
                            v147.milliseconds(),
                        )
                    }
                    _ => DateTime::now(),
                };
                let v178: string = {
                    let provider: string = Documents::method6();
                    v173.toString(provider)
                };
                let v570: string = padLeft(toLower(string("Info")), 7_i32, ' ');
                let v586: &str = inline_colorization::color_bright_green;
                let v588: &str = &*v570;
                let v590: &str = inline_colorization::color_reset;
                let v592: string = string("format!(\"{v586}{v588}{v590}\")");
                let v593: std::string::String = format!("{v586}{v588}{v590}");
                let v595: string = fable_library_rust::String_::fromString(v593);
                let v636: i64 = (patternInput_2.0.clone()).l0.get().clone();
                let v638: usize = v0_1.len();
                let v640: LrcPtr<Documents::Mut3> = LrcPtr::new(Documents::Mut3 {
                    l0: MutCell::new(Documents::method9()),
                });
                let v647: () = {
                    Documents::closure11(v640.clone(), sprintf!("{}", string("{ ")), ());
                    ()
                };
                let v656: () = {
                    Documents::closure11(v640.clone(), sprintf!("{}", string("result_len")), ());
                    ()
                };
                let v665: () = {
                    Documents::closure11(v640.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v670: std::string::String = format!("{:#?}", v638);
                let v700: () = {
                    Documents::closure11(
                        v640.clone(),
                        sprintf!("{}", fable_library_rust::String_::fromString(v670)),
                        (),
                    );
                    ()
                };
                let v709: () = {
                    Documents::closure11(v640.clone(), sprintf!("{}", string(" }")), ());
                    ()
                };
                let v771: string = trimEndChars(
                    trimStartChars(
                        sprintf!(
                            "{} {} #{} {} / {}",
                            v178,
                            v595,
                            v636,
                            string("documents.run"),
                            v640.l0.get().clone()
                        ),
                        toArray(empty::<char>()),
                    ),
                    toArray(ofArray(new_array(&[' ', '/']))),
                );
                println!("{}", v771.clone());
                ();
                ((patternInput.1.clone()).l0.get().clone())(v771)
            }
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
            let v8: Documents::US7 = Documents::method18(
                Documents::method15(string("polyglot"), string(".devcontainer")),
                string("C:\\home\\git\\polyglot\\target\\Builder\\documents"),
            );
            let v810: Documents::US1 = match &v8 {
                Documents::US7::US7_0(v8_0_0) => Documents::US1::US1_0(v8_0_0.clone()),
                Documents::US7::US7_1(v8_1_0) => {
                    let v14: () = {
                        Documents::closure17(v8_1_0.clone(), ());
                        ()
                    };
                    Documents::US1::US1_1
                }
            };
            let v1619: Documents::US1 = match &v810 {
                Documents::US1::US1_0(v810_0_0) => Documents::US1::US1_0(match &v810 {
                    Documents::US1::US1_0(x) => x.clone(),
                    _ => unreachable!(),
                }),
                _ => {
                    let v813: string = Documents::method23();
                    let v815: Documents::US7 = Documents::method18(
                        Documents::method15(string("polyglot"), string(".devcontainer")),
                        v813,
                    );
                    match &v815 {
                        Documents::US7::US7_0(v815_0_0) => Documents::US1::US1_0(v815_0_0.clone()),
                        Documents::US7::US7_1(v815_1_0) => {
                            let v821: () = {
                                Documents::closure17(v815_1_0.clone(), ());
                                ()
                            };
                            Documents::US1::US1_1
                        }
                    }
                }
            };
            let v1624: string = Documents::method15(
                match &v1619 {
                    Documents::US1::US1_0(v1619_0_0) => match &v1619 {
                        Documents::US1::US1_0(x) => x.clone(),
                        _ => unreachable!(),
                    },
                    _ => panic!("{}", string("Option does not have a value."),),
                },
                string("polyglot"),
            );
            let v1625: string = Documents::method24(v3);
            let v1626: string = Documents::method24(v2);
            let v1627: string = Documents::method24(v1_1);
            let v1630: () = {
                Documents::closure18(
                    v0_1.clone(),
                    v1625.clone(),
                    v1626.clone(),
                    v1627.clone(),
                    (),
                );
                ()
            };
            let v2528: bool = true;
            let __future_init = Box::pin(async move {
                //;
                let v2530: async_walkdir::WalkDir = async_walkdir::WalkDir::new(&*v1626.clone());
                let v2533: async_walkdir::WalkDir = async_walkdir::WalkDir::filter(v2530, |x| {
                    Func1::new(move |v: async_walkdir::DirEntry| Documents::closure19((), v))(x)
                });
                let v2534 = Documents::method35();
                let v2536 = tokio_stream::StreamExt::filter_map(v2533, |x| v2534(x));
                let v2538: std::pin::Pin<Box<dyn std::future::Future<Output = Vec<string>>>> =
                    Box::pin(tokio_stream::StreamExt::collect(v2536));
                let v2540: Vec<string> = v2538.await;
                let v2543: () = {
                    Documents::closure28(v2540.clone(), ());
                    ()
                };
                let v3370: rayon::vec::IntoIter<string> =
                    rayon::iter::IntoParallelIterator::into_par_iter(v2540);
                let v3373: rayon::iter::Map<rayon::vec::IntoIter<string>, _> =
                    rayon::iter::ParallelIterator::map(v3370, |x| {
                        Func1::new({
                            let v0_1 = v0_1.clone();
                            let v1624 = v1624.clone();
                            let v1625 = v1625.clone();
                            let v1626 = v1626.clone();
                            let v1627 = v1627.clone();
                            move |v_1: string| {
                                Documents::closure29(
                                    v0_1.clone(),
                                    v1624.clone(),
                                    v1625.clone(),
                                    v1626.clone(),
                                    v1627.clone(),
                                    v_1,
                                )
                            }
                        })(x)
                    });
                let v3375: Vec<
                    Result<
                        LrcPtr<(
                            string,
                            Vec<Option<Result<string, LrcPtr<(string, string)>>>>,
                        )>,
                        std::string::String,
                    >,
                > = rayon::iter::ParallelIterator::collect(v3373);
                let v3378: () = {
                    Documents::closure79(v3375.clone(), ());
                    ()
                };
                let v4205: Result<
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
                >(v3375));
                let v4209: string = string("true; v4205 });  // rust.fix_closure\'");
                let v4210: bool = true;
                v4205
            }); // rust.fix_closure';
            let v4212 = __future_init;
            v4212
        }
        pub fn closure1(unitVar: (), v0_1: Array<string>) -> i32 {
            let v3: () = {
                Documents::closure2((), ());
                ()
            };
            let v19: () = {
                Documents::closure6(v0_1, ());
                ()
            };
            let v819: clap::Command = Documents::method0();
            let v821: clap::ArgMatches = clap::Command::get_matches(v819);
            let v822: string = Documents::method10();
            let v824: &str = &*v822;
            let v826: Option<std::string::String> =
                clap::ArgMatches::get_one(&v821.clone(), v824).cloned();
            let _v827: LrcPtr<MutCell<Option<Documents::US4>>> = refCell(None::<Documents::US4>);
            let v832: () = {
                Documents::closure15(
                    v826,
                    Func1::new({
                        let _v827 = _v827.clone();
                        move |v: Option<Documents::US4>| Documents::closure14(_v827.clone(), v)
                    }),
                    (),
                );
                ()
            };
            let v847: Documents::US4 = defaultValue(Documents::US4::US4_1, _v827.get().clone());
            let v854: std::string::String = match &v847 {
                Documents::US4::US4_0(v847_0_0) => match &v847 {
                    Documents::US4::US4_0(x) => x.clone(),
                    _ => unreachable!(),
                },
                _ => panic!("{}", string("Option does not have a value."),),
            };
            let v856: string = fable_library_rust::String_::fromString(v854);
            let v857: string = Documents::method11();
            let v859: &str = &*v857;
            let v861: Option<std::string::String> =
                clap::ArgMatches::get_one(&v821.clone(), v859).cloned();
            let _v862: LrcPtr<MutCell<Option<Documents::US4>>> = refCell(None::<Documents::US4>);
            let v867: () = {
                Documents::closure15(
                    v861,
                    Func1::new({
                        let _v862 = _v862.clone();
                        move |v_1: Option<Documents::US4>| Documents::closure14(_v862.clone(), v_1)
                    }),
                    (),
                );
                ()
            };
            let v882: Documents::US4 = defaultValue(Documents::US4::US4_1, _v862.get().clone());
            let v889: std::string::String = match &v882 {
                Documents::US4::US4_0(v882_0_0) => match &v882 {
                    Documents::US4::US4_0(x) => x.clone(),
                    _ => unreachable!(),
                },
                _ => panic!("{}", string("Option does not have a value."),),
            };
            let v891: string = fable_library_rust::String_::fromString(v889);
            let v892: string = Documents::method12();
            let v894: &str = &*v892;
            let v896: Option<std::string::String> =
                clap::ArgMatches::get_one(&v821.clone(), v894).cloned();
            let _v897: LrcPtr<MutCell<Option<Documents::US4>>> = refCell(None::<Documents::US4>);
            let v902: () = {
                Documents::closure15(
                    v896,
                    Func1::new({
                        let _v897 = _v897.clone();
                        move |v_2: Option<Documents::US4>| Documents::closure14(_v897.clone(), v_2)
                    }),
                    (),
                );
                ()
            };
            let v917: Documents::US4 = defaultValue(Documents::US4::US4_1, _v897.get().clone());
            let v924: std::string::String = match &v917 {
                Documents::US4::US4_0(v917_0_0) => match &v917 {
                    Documents::US4::US4_0(x) => x.clone(),
                    _ => unreachable!(),
                },
                _ => panic!("{}", string("Option does not have a value."),),
            };
            let v926: string = fable_library_rust::String_::fromString(v924);
            let v927: string = Documents::method13();
            let v929: &str = &*v927;
            let v931: Option<std::string::String> = clap::ArgMatches::get_one(&v821, v929).cloned();
            let _v932: LrcPtr<MutCell<Option<Documents::US4>>> = refCell(None::<Documents::US4>);
            let v937: () = {
                Documents::closure15(
                    v931,
                    Func1::new({
                        let _v932 = _v932.clone();
                        move |v_3: Option<Documents::US4>| Documents::closure14(_v932.clone(), v_3)
                    }),
                    (),
                );
                ()
            };
            let v952: Documents::US4 = defaultValue(Documents::US4::US4_1, _v932.get().clone());
            let v959: std::string::String = match &v952 {
                Documents::US4::US4_0(v952_0_0) => match &v952 {
                    Documents::US4::US4_0(x) => x.clone(),
                    _ => unreachable!(),
                },
                _ => panic!("{}", string("Option does not have a value."),),
            };
            let v962: std::pin::Pin<
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
            > = Documents::method14(
                fable_library_rust::String_::fromString(v959),
                v926,
                v891,
                v856,
            );
            let v964 = tokio::runtime::Builder::new_multi_thread()
                .enable_all()
                .build()
                .unwrap();
            let v966: Result<
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
            > = v964.handle().block_on(v962);
            let v968: Vec<
                Result<
                    LrcPtr<(
                        string,
                        Vec<Option<Result<string, LrcPtr<(string, string)>>>>,
                    )>,
                    std::string::String,
                >,
            > = v966.unwrap();
            0_i32
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
