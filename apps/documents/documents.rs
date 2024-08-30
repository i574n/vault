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
        use fable_library_rust::String_::startsWith;
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
                        LrcPtr<Documents::Mut3>,
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
        #[derive(Clone, Debug, PartialEq, PartialOrd, Hash, Eq)]
        pub struct Mut3 {
            pub l0: MutCell<Documents::US0>,
        }
        impl core::fmt::Display for Documents::Mut3 {
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
        #[derive(Clone, Debug, Default, PartialEq, PartialOrd, Hash, Eq)]
        pub struct Mut4 {
            pub l0: MutCell<string>,
        }
        impl core::fmt::Display for Documents::Mut4 {
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
            if Documents::State::trace_state().get().clone().is_none() {
                let patternInput: (
                    LrcPtr<Documents::Mut0>,
                    LrcPtr<Documents::Mut1>,
                    LrcPtr<Documents::Mut2>,
                    LrcPtr<Documents::Mut3>,
                    Option<i64>,
                ) = Documents::method1(Documents::US0::US0_2);
                Documents::State::trace_state().set(Some((
                    patternInput.0.clone(),
                    patternInput.1.clone(),
                    patternInput.2.clone(),
                    patternInput.3.clone(),
                    patternInput.4.clone(),
                )));
                ()
            };
        }
        pub fn closure7(unitVar: (), unitVar_1: ()) {
            if Documents::State::trace_state().get().clone().is_none() {
                let patternInput: (
                    LrcPtr<Documents::Mut0>,
                    LrcPtr<Documents::Mut1>,
                    LrcPtr<Documents::Mut2>,
                    LrcPtr<Documents::Mut3>,
                    Option<i64>,
                ) = Documents::method1(Documents::US0::US0_0);
                Documents::State::trace_state().set(Some((
                    patternInput.0.clone(),
                    patternInput.1.clone(),
                    patternInput.2.clone(),
                    patternInput.3.clone(),
                    patternInput.4.clone(),
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
            string("(")
        }
        pub fn method9() -> string {
            string(" ")
        }
        pub fn method10() -> string {
            string("")
        }
        pub fn closure11(v0_1: LrcPtr<Documents::Mut4>, v1_1: string, unitVar: ()) {
            let v3: string = append(v0_1.l0.get().clone(), v1_1);
            v0_1.l0.set(v3);
            ()
        }
        pub fn method11() -> string {
            string("\u{001b}[0m")
        }
        pub fn closure12(unitVar: (), unitVar_1: ()) -> string {
            string("documents.main")
        }
        pub fn closure14(v0_1: string, unitVar: ()) {
            printfn!("{0}", v0_1);
        }
        pub fn closure13(unitVar: (), v0_1: string) {
            let v3: () = {
                Documents::closure14(v0_1, ());
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
                Option<i64>,
            ) = getValue(Documents::State::trace_state().get().clone());
            let v32: () = {
                v2();
                ()
            };
            let patternInput_1: (
                LrcPtr<Documents::Mut0>,
                LrcPtr<Documents::Mut1>,
                LrcPtr<Documents::Mut2>,
                LrcPtr<Documents::Mut3>,
                Option<i64>,
            ) = getValue(Documents::State::trace_state().get().clone());
            let v60: Documents::US0 = (patternInput_1.3.clone()).l0.get().clone();
            if if (patternInput_1.2.clone()).l0.get().clone() == false {
                false
            } else {
                2_i32
                    >= find(
                        v60,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Documents::US0::US0_0, 0_i32)),
                            LrcPtr::new((Documents::US0::US0_1, 1_i32)),
                            LrcPtr::new((Documents::US0::US0_2, 2_i32)),
                            LrcPtr::new((Documents::US0::US0_3, 3_i32)),
                            LrcPtr::new((Documents::US0::US0_4, 4_i32)),
                        ])))),
                    )
            } {
                let v68: () = {
                    Documents::closure8(patternInput.0.clone(), ());
                    ()
                };
                let v72: () = {
                    v2();
                    ()
                };
                let patternInput_2: (
                    LrcPtr<Documents::Mut0>,
                    LrcPtr<Documents::Mut1>,
                    LrcPtr<Documents::Mut2>,
                    LrcPtr<Documents::Mut3>,
                    Option<i64>,
                ) = getValue(Documents::State::trace_state().get().clone());
                let _v101: LrcPtr<MutCell<Option<Documents::US3>>> =
                    refCell(None::<Documents::US3>);
                let v106: () = {
                    Documents::closure10(
                        patternInput_2.4.clone(),
                        Func1::new({
                            let _v101 = _v101.clone();
                            move |v: Option<Documents::US3>| Documents::closure9(_v101.clone(), v)
                        }),
                        (),
                    );
                    ()
                };
                let v121: Documents::US3 = defaultValue(Documents::US3::US3_1, _v101.get().clone());
                let v161: DateTime = match &v121 {
                    Documents::US3::US3_0(v121_0_0) => {
                        let v135: TimeSpan = TimeSpan::new_ticks(
                            {
                                let _arg: DateTime = DateTime::now();
                                _arg.ticks()
                            } - match &v121 {
                                Documents::US3::US3_0(x) => x.clone(),
                                _ => unreachable!(),
                            },
                        );
                        DateTime::new_ymdhms_milli(
                            1_i32,
                            1_i32,
                            1_i32,
                            v135.hours(),
                            v135.minutes(),
                            v135.seconds(),
                            v135.milliseconds(),
                        )
                    }
                    _ => DateTime::now(),
                };
                let v166: string = {
                    let provider: string = Documents::method6();
                    v161.toString(provider)
                };
                let v554: string = Documents::method8();
                let v566: LrcPtr<Documents::Mut4> = LrcPtr::new(Documents::Mut4 {
                    l0: MutCell::new(Documents::method10()),
                });
                let v577: () = {
                    Documents::closure11(
                        v566.clone(),
                        sprintf!("{}", sprintf!("{:?}", Documents::US0::US0_0)),
                        (),
                    );
                    ()
                };
                let v581: Array<string> = split(v566.l0.get().clone(), v554, -1_i32, 0_i32);
                let v584: string = v581[0_i32].clone();
                let v588: LrcPtr<Documents::Mut4> = LrcPtr::new(Documents::Mut4 {
                    l0: MutCell::new(Documents::method10()),
                });
                let v599: () = {
                    Documents::closure11(
                        v588.clone(),
                        sprintf!("{}", sprintf!("{:?}", Documents::US0::US0_2)),
                        (),
                    );
                    ()
                };
                let v609: Documents::US1 = if startsWith(v588.l0.get().clone(), v584, false) {
                    Documents::US1::US1_0(string("Verbose"))
                } else {
                    Documents::US1::US1_1
                };
                let v676: Documents::US1 = match &v609 {
                    Documents::US1::US1_0(v609_0_0) => Documents::US1::US1_0(match &v609 {
                        Documents::US1::US1_0(x) => x.clone(),
                        _ => unreachable!(),
                    }),
                    _ => {
                        let v613: string = Documents::method8();
                        let v625: LrcPtr<Documents::Mut4> = LrcPtr::new(Documents::Mut4 {
                            l0: MutCell::new(Documents::method10()),
                        });
                        let v636: () = {
                            Documents::closure11(
                                v625.clone(),
                                sprintf!("{}", sprintf!("{:?}", Documents::US0::US0_1)),
                                (),
                            );
                            ()
                        };
                        let v640: Array<string> = split(v625.l0.get().clone(), v613, -1_i32, 0_i32);
                        let v643: string = v640[0_i32].clone();
                        let v647: LrcPtr<Documents::Mut4> = LrcPtr::new(Documents::Mut4 {
                            l0: MutCell::new(Documents::method10()),
                        });
                        let v658: () = {
                            Documents::closure11(
                                v647.clone(),
                                sprintf!("{}", sprintf!("{:?}", Documents::US0::US0_2)),
                                (),
                            );
                            ()
                        };
                        let v668: Documents::US1 = if startsWith(v647.l0.get().clone(), v643, false)
                        {
                            Documents::US1::US1_0(string("Debug"))
                        } else {
                            Documents::US1::US1_1
                        };
                        match &v668 {
                            Documents::US1::US1_0(v668_0_0) => Documents::US1::US1_0(match &v668 {
                                Documents::US1::US1_0(x) => x.clone(),
                                _ => unreachable!(),
                            }),
                            _ => Documents::US1::US1_0(string("Info")),
                        }
                    }
                };
                let v685: string = padLeft(
                    toLower(match &v676 {
                        Documents::US1::US1_0(v676_0_0) => match &v676 {
                            Documents::US1::US1_0(x) => x.clone(),
                            _ => unreachable!(),
                        },
                        _ => panic!("{}", string("Option does not have a value."),),
                    }),
                    7_i32,
                    ' ',
                );
                let v701: &str = inline_colorization::color_bright_green;
                let v703: &str = &*v685;
                let v705: &str = inline_colorization::color_reset;
                let v707: string = string("format!(\"{v701}{v703}{v705}\")");
                let v708: std::string::String = format!("{v701}{v703}{v705}");
                let v710: string = fable_library_rust::String_::fromString(v708);
                let v751: i64 = (patternInput_2.0.clone()).l0.get().clone();
                let v753: LrcPtr<Documents::Mut4> = LrcPtr::new(Documents::Mut4 {
                    l0: MutCell::new(Documents::method10()),
                });
                let v760: () = {
                    Documents::closure11(v753.clone(), sprintf!("{}", string("{ ")), ());
                    ()
                };
                let v769: () = {
                    Documents::closure11(v753.clone(), sprintf!("{}", string("args")), ());
                    ()
                };
                let v778: () = {
                    Documents::closure11(v753.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v789: () = {
                    Documents::closure11(v753.clone(), sprintf!("{}", sprintf!("{:?}", v0_1)), ());
                    ()
                };
                let v798: () = {
                    Documents::closure11(v753.clone(), sprintf!("{}", string(" }")), ());
                    ()
                };
                let v801: string = v753.l0.get().clone();
                let v840: string = trimEndChars(
                    trimStartChars(
                        sprintf!(
                            "{} {} #{} {} / {}",
                            v166,
                            v710,
                            v751,
                            Documents::closure12((), ()),
                            v801
                        ),
                        toArray(empty::<char>()),
                    ),
                    toArray(ofArray(new_array(&[' ', '/']))),
                );
                println!("{}", v840.clone());
                ();
                ((patternInput.1.clone()).l0.get().clone())(v840)
            }
        }
        pub fn method12() -> string {
            string("source-dir")
        }
        pub fn closure15(
            v0_1: LrcPtr<MutCell<Option<Documents::US4>>>,
            v1_1: Option<Documents::US4>,
        ) -> LrcPtr<MutCell<Option<Documents::US4>>> {
            v0_1.set(v1_1);
            v0_1
        }
        pub fn closure16(
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
        pub fn method13() -> string {
            string("dist-dir")
        }
        pub fn method14() -> string {
            string("cache-dir")
        }
        pub fn method15() -> string {
            string("hangul-spec")
        }
        pub fn method19(v0_1: string) -> string {
            v0_1
        }
        pub fn method18(v0_1: string, v1_1: string) -> (string, string) {
            (v1_1, Documents::method19(v0_1))
        }
        pub fn method17(v0_1: string, v1_1: string) -> string {
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
        pub fn method21(v0_1: string) -> bool {
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
        pub fn method23(v0_1: string) -> Option<string> {
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
        pub fn closure17(unitVar: (), v0_1: string) -> Option<string> {
            Documents::method23(v0_1)
        }
        pub fn method22() -> Func1<string, Option<string>> {
            Func1::new(move |v: string| Documents::closure17((), v))
        }
        pub fn method24(v0_1: string, v1_1: string, v2: string) -> Documents::US7 {
            let v0_1: MutCell<string> = MutCell::new(v0_1.clone());
            let v1_1: MutCell<string> = MutCell::new(v1_1.clone());
            let v2: MutCell<string> = MutCell::new(v2.clone());
            '_method24: loop {
                break '_method24 (if Documents::method21(Documents::method17(
                    v2.get().clone(),
                    v0_1.get().clone(),
                )) {
                    Documents::US7::US7_0(v2.get().clone())
                } else {
                    let v7: Option<string> = (Documents::method22())(v2.get().clone());
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
                            continue '_method24;
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
        pub fn method20(v0_1: string, v1_1: string) -> Documents::US7 {
            if Documents::method21(Documents::method17(v1_1.clone(), v0_1.clone())) {
                Documents::US7::US7_0(v1_1.clone())
            } else {
                let v6: Option<string> = (Documents::method22())(v1_1.clone());
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
                    Documents::US1::US1_0(v27_0_0) => Documents::method24(
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
        pub fn closure19(unitVar: (), unitVar_1: ()) -> string {
            string("file_system.get_workspace_root")
        }
        pub fn closure18(v0_1: string, unitVar: ()) {
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
                Option<i64>,
            ) = getValue(Documents::State::trace_state().get().clone());
            let v32: () = {
                v2();
                ()
            };
            let patternInput_1: (
                LrcPtr<Documents::Mut0>,
                LrcPtr<Documents::Mut1>,
                LrcPtr<Documents::Mut2>,
                LrcPtr<Documents::Mut3>,
                Option<i64>,
            ) = getValue(Documents::State::trace_state().get().clone());
            let v60: Documents::US0 = (patternInput_1.3.clone()).l0.get().clone();
            if if (patternInput_1.2.clone()).l0.get().clone() == false {
                false
            } else {
                3_i32
                    >= find(
                        v60,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Documents::US0::US0_0, 0_i32)),
                            LrcPtr::new((Documents::US0::US0_1, 1_i32)),
                            LrcPtr::new((Documents::US0::US0_2, 2_i32)),
                            LrcPtr::new((Documents::US0::US0_3, 3_i32)),
                            LrcPtr::new((Documents::US0::US0_4, 4_i32)),
                        ])))),
                    )
            } {
                let v68: () = {
                    Documents::closure8(patternInput.0.clone(), ());
                    ()
                };
                let v72: () = {
                    v2();
                    ()
                };
                let patternInput_2: (
                    LrcPtr<Documents::Mut0>,
                    LrcPtr<Documents::Mut1>,
                    LrcPtr<Documents::Mut2>,
                    LrcPtr<Documents::Mut3>,
                    Option<i64>,
                ) = getValue(Documents::State::trace_state().get().clone());
                let _v101: LrcPtr<MutCell<Option<Documents::US3>>> =
                    refCell(None::<Documents::US3>);
                let v106: () = {
                    Documents::closure10(
                        patternInput_2.4.clone(),
                        Func1::new({
                            let _v101 = _v101.clone();
                            move |v: Option<Documents::US3>| Documents::closure9(_v101.clone(), v)
                        }),
                        (),
                    );
                    ()
                };
                let v121: Documents::US3 = defaultValue(Documents::US3::US3_1, _v101.get().clone());
                let v161: DateTime = match &v121 {
                    Documents::US3::US3_0(v121_0_0) => {
                        let v135: TimeSpan = TimeSpan::new_ticks(
                            {
                                let _arg: DateTime = DateTime::now();
                                _arg.ticks()
                            } - match &v121 {
                                Documents::US3::US3_0(x) => x.clone(),
                                _ => unreachable!(),
                            },
                        );
                        DateTime::new_ymdhms_milli(
                            1_i32,
                            1_i32,
                            1_i32,
                            v135.hours(),
                            v135.minutes(),
                            v135.seconds(),
                            v135.milliseconds(),
                        )
                    }
                    _ => DateTime::now(),
                };
                let v166: string = {
                    let provider: string = Documents::method6();
                    v161.toString(provider)
                };
                let v554: string = Documents::method8();
                let v566: LrcPtr<Documents::Mut4> = LrcPtr::new(Documents::Mut4 {
                    l0: MutCell::new(Documents::method10()),
                });
                let v577: () = {
                    Documents::closure11(
                        v566.clone(),
                        sprintf!("{}", sprintf!("{:?}", Documents::US0::US0_0)),
                        (),
                    );
                    ()
                };
                let v581: Array<string> = split(v566.l0.get().clone(), v554, -1_i32, 0_i32);
                let v584: string = v581[0_i32].clone();
                let v588: LrcPtr<Documents::Mut4> = LrcPtr::new(Documents::Mut4 {
                    l0: MutCell::new(Documents::method10()),
                });
                let v599: () = {
                    Documents::closure11(
                        v588.clone(),
                        sprintf!("{}", sprintf!("{:?}", Documents::US0::US0_3)),
                        (),
                    );
                    ()
                };
                let v609: Documents::US1 = if startsWith(v588.l0.get().clone(), v584, false) {
                    Documents::US1::US1_0(string("Verbose"))
                } else {
                    Documents::US1::US1_1
                };
                let v737: Documents::US1 = match &v609 {
                    Documents::US1::US1_0(v609_0_0) => Documents::US1::US1_0(match &v609 {
                        Documents::US1::US1_0(x) => x.clone(),
                        _ => unreachable!(),
                    }),
                    _ => {
                        let v613: string = Documents::method8();
                        let v625: LrcPtr<Documents::Mut4> = LrcPtr::new(Documents::Mut4 {
                            l0: MutCell::new(Documents::method10()),
                        });
                        let v636: () = {
                            Documents::closure11(
                                v625.clone(),
                                sprintf!("{}", sprintf!("{:?}", Documents::US0::US0_1)),
                                (),
                            );
                            ()
                        };
                        let v640: Array<string> = split(v625.l0.get().clone(), v613, -1_i32, 0_i32);
                        let v643: string = v640[0_i32].clone();
                        let v647: LrcPtr<Documents::Mut4> = LrcPtr::new(Documents::Mut4 {
                            l0: MutCell::new(Documents::method10()),
                        });
                        let v658: () = {
                            Documents::closure11(
                                v647.clone(),
                                sprintf!("{}", sprintf!("{:?}", Documents::US0::US0_3)),
                                (),
                            );
                            ()
                        };
                        let v668: Documents::US1 = if startsWith(v647.l0.get().clone(), v643, false)
                        {
                            Documents::US1::US1_0(string("Debug"))
                        } else {
                            Documents::US1::US1_1
                        };
                        match &v668 {
                            Documents::US1::US1_0(v668_0_0) => Documents::US1::US1_0(match &v668 {
                                Documents::US1::US1_0(x) => x.clone(),
                                _ => unreachable!(),
                            }),
                            _ => {
                                let v672: string = Documents::method8();
                                let v684: LrcPtr<Documents::Mut4> = LrcPtr::new(Documents::Mut4 {
                                    l0: MutCell::new(Documents::method10()),
                                });
                                let v695: () = {
                                    Documents::closure11(
                                        v684.clone(),
                                        sprintf!("{}", sprintf!("{:?}", Documents::US0::US0_2)),
                                        (),
                                    );
                                    ()
                                };
                                let v699: Array<string> =
                                    split(v684.l0.get().clone(), v672, -1_i32, 0_i32);
                                let v702: string = v699[0_i32].clone();
                                let v706: LrcPtr<Documents::Mut4> = LrcPtr::new(Documents::Mut4 {
                                    l0: MutCell::new(Documents::method10()),
                                });
                                let v717: () = {
                                    Documents::closure11(
                                        v706.clone(),
                                        sprintf!("{}", sprintf!("{:?}", Documents::US0::US0_3)),
                                        (),
                                    );
                                    ()
                                };
                                let v727: Documents::US1 =
                                    if startsWith(v706.l0.get().clone(), v702, false) {
                                        Documents::US1::US1_0(string("Info"))
                                    } else {
                                        Documents::US1::US1_1
                                    };
                                match &v727 {
                                    Documents::US1::US1_0(v727_0_0) => {
                                        Documents::US1::US1_0(match &v727 {
                                            Documents::US1::US1_0(x) => x.clone(),
                                            _ => unreachable!(),
                                        })
                                    }
                                    _ => Documents::US1::US1_0(string("Warning")),
                                }
                            }
                        }
                    }
                };
                let v746: string = padLeft(
                    toLower(match &v737 {
                        Documents::US1::US1_0(v737_0_0) => match &v737 {
                            Documents::US1::US1_0(x) => x.clone(),
                            _ => unreachable!(),
                        },
                        _ => panic!("{}", string("Option does not have a value."),),
                    }),
                    7_i32,
                    ' ',
                );
                let v762: &str = inline_colorization::color_yellow;
                let v764: &str = &*v746;
                let v766: &str = inline_colorization::color_reset;
                let v768: string = string("format!(\"{v762}{v764}{v766}\")");
                let v769: std::string::String = format!("{v762}{v764}{v766}");
                let v771: string = fable_library_rust::String_::fromString(v769);
                let v812: i64 = (patternInput_2.0.clone()).l0.get().clone();
                let v814: LrcPtr<Documents::Mut4> = LrcPtr::new(Documents::Mut4 {
                    l0: MutCell::new(Documents::method10()),
                });
                let v821: () = {
                    Documents::closure11(v814.clone(), sprintf!("{}", string("{ ")), ());
                    ()
                };
                let v830: () = {
                    Documents::closure11(v814.clone(), sprintf!("{}", string("error")), ());
                    ()
                };
                let v839: () = {
                    Documents::closure11(v814.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v847: () = {
                    Documents::closure11(v814.clone(), sprintf!("{}", v0_1), ());
                    ()
                };
                let v856: () = {
                    Documents::closure11(v814.clone(), sprintf!("{}", string(" }")), ());
                    ()
                };
                let v859: string = v814.l0.get().clone();
                let v898: string = trimEndChars(
                    trimStartChars(
                        sprintf!(
                            "{} {} #{} {} / {}",
                            v166,
                            v771,
                            v812,
                            Documents::closure19((), ()),
                            v859
                        ),
                        toArray(empty::<char>()),
                    ),
                    toArray(ofArray(new_array(&[' ', '/']))),
                );
                println!("{}", v898.clone());
                ();
                ((patternInput.1.clone()).l0.get().clone())(v898)
            }
        }
        pub fn method25() -> string {
            let v2: Result<std::path::PathBuf, std::io::Error> = std::env::current_dir();
            let v4: std::path::PathBuf = v2.unwrap();
            let v6: std::path::Display = v4.display();
            let v9: std::string::String = format!("{}", v6);
            fable_library_rust::String_::fromString(v9)
        }
        pub fn method28(v0_1: string) -> string {
            v0_1
        }
        pub fn method27(v0_1: string) -> string {
            if v0_1.clone() == string("") {
                string("")
            } else {
                let v7: Result<regex::Regex, regex::Error> =
                    regex::Regex::new(&string("^\\\\\\\\\\?\\\\"));
                let v9: regex::Regex = v7.unwrap();
                let v10: string = Documents::method28(v0_1);
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
        pub fn method29(v0_1: i32, v1_1: LrcPtr<Documents::Mut5>) -> bool {
            v1_1.l0.get().clone() < v0_1
        }
        pub fn method30(v0_1: i32, v1_1: LrcPtr<Documents::Mut6>) -> bool {
            v1_1.l0.get().clone() < v0_1
        }
        pub fn method31() -> char {
            std::path::MAIN_SEPARATOR
        }
        pub fn method26(v0_1: string) -> string {
            let v3: &str = &*v0_1.clone();
            let v5: std::string::String = String::from(v3);
            let v7: std::path::PathBuf = std::path::PathBuf::from(v5);
            if v7.exists() == false {
                let v11: string = Documents::method25();
                let v15: Array<string> = split(
                    Documents::method27(Documents::method17(v11.clone(), v0_1.clone())),
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
                while Documents::method29(v19, v20.clone()) {
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
                                    while Documents::method30(v39, v41.clone()) {
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
                                    while Documents::method30(v53, v55.clone()) {
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
                    join(ofChar(Documents::method31()), toArray_1(v76))
                }
            } else {
                let v90: Result<std::path::PathBuf, std::io::Error> = std::fs::canonicalize(&*v0_1);
                let v92: std::path::PathBuf = v90.unwrap();
                let v94: std::path::Display = v92.display();
                let v97: std::string::String = format!("{}", v94);
                fable_library_rust::String_::fromString(v97)
            }
        }
        pub fn closure21(unitVar: (), unitVar_1: ()) -> string {
            string("documents.run")
        }
        pub fn closure20(v0_1: string, v1_1: string, v2: string, v3: string, unitVar: ()) {
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
                Option<i64>,
            ) = getValue(Documents::State::trace_state().get().clone());
            let v35: () = {
                v5();
                ()
            };
            let patternInput_1: (
                LrcPtr<Documents::Mut0>,
                LrcPtr<Documents::Mut1>,
                LrcPtr<Documents::Mut2>,
                LrcPtr<Documents::Mut3>,
                Option<i64>,
            ) = getValue(Documents::State::trace_state().get().clone());
            let v63: Documents::US0 = (patternInput_1.3.clone()).l0.get().clone();
            if if (patternInput_1.2.clone()).l0.get().clone() == false {
                false
            } else {
                1_i32
                    >= find(
                        v63,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Documents::US0::US0_0, 0_i32)),
                            LrcPtr::new((Documents::US0::US0_1, 1_i32)),
                            LrcPtr::new((Documents::US0::US0_2, 2_i32)),
                            LrcPtr::new((Documents::US0::US0_3, 3_i32)),
                            LrcPtr::new((Documents::US0::US0_4, 4_i32)),
                        ])))),
                    )
            } {
                let v71: () = {
                    Documents::closure8(patternInput.0.clone(), ());
                    ()
                };
                let v75: () = {
                    v5();
                    ()
                };
                let patternInput_2: (
                    LrcPtr<Documents::Mut0>,
                    LrcPtr<Documents::Mut1>,
                    LrcPtr<Documents::Mut2>,
                    LrcPtr<Documents::Mut3>,
                    Option<i64>,
                ) = getValue(Documents::State::trace_state().get().clone());
                let _v104: LrcPtr<MutCell<Option<Documents::US3>>> =
                    refCell(None::<Documents::US3>);
                let v109: () = {
                    Documents::closure10(
                        patternInput_2.4.clone(),
                        Func1::new({
                            let _v104 = _v104.clone();
                            move |v: Option<Documents::US3>| Documents::closure9(_v104.clone(), v)
                        }),
                        (),
                    );
                    ()
                };
                let v124: Documents::US3 = defaultValue(Documents::US3::US3_1, _v104.get().clone());
                let v164: DateTime = match &v124 {
                    Documents::US3::US3_0(v124_0_0) => {
                        let v138: TimeSpan = TimeSpan::new_ticks(
                            {
                                let _arg: DateTime = DateTime::now();
                                _arg.ticks()
                            } - match &v124 {
                                Documents::US3::US3_0(x) => x.clone(),
                                _ => unreachable!(),
                            },
                        );
                        DateTime::new_ymdhms_milli(
                            1_i32,
                            1_i32,
                            1_i32,
                            v138.hours(),
                            v138.minutes(),
                            v138.seconds(),
                            v138.milliseconds(),
                        )
                    }
                    _ => DateTime::now(),
                };
                let v169: string = {
                    let provider: string = Documents::method6();
                    v164.toString(provider)
                };
                let v557: string = Documents::method8();
                let v569: LrcPtr<Documents::Mut4> = LrcPtr::new(Documents::Mut4 {
                    l0: MutCell::new(Documents::method10()),
                });
                let v580: () = {
                    Documents::closure11(
                        v569.clone(),
                        sprintf!("{}", sprintf!("{:?}", Documents::US0::US0_0)),
                        (),
                    );
                    ()
                };
                let v584: Array<string> = split(v569.l0.get().clone(), v557, -1_i32, 0_i32);
                let v587: string = v584[0_i32].clone();
                let v591: LrcPtr<Documents::Mut4> = LrcPtr::new(Documents::Mut4 {
                    l0: MutCell::new(Documents::method10()),
                });
                let v602: () = {
                    Documents::closure11(
                        v591.clone(),
                        sprintf!("{}", sprintf!("{:?}", Documents::US0::US0_1)),
                        (),
                    );
                    ()
                };
                let v612: Documents::US1 = if startsWith(v591.l0.get().clone(), v587, false) {
                    Documents::US1::US1_0(string("Verbose"))
                } else {
                    Documents::US1::US1_1
                };
                let v618: Documents::US1 = match &v612 {
                    Documents::US1::US1_0(v612_0_0) => Documents::US1::US1_0(match &v612 {
                        Documents::US1::US1_0(x) => x.clone(),
                        _ => unreachable!(),
                    }),
                    _ => Documents::US1::US1_0(string("Debug")),
                };
                let v627: string = padLeft(
                    toLower(match &v618 {
                        Documents::US1::US1_0(v618_0_0) => match &v618 {
                            Documents::US1::US1_0(x) => x.clone(),
                            _ => unreachable!(),
                        },
                        _ => panic!("{}", string("Option does not have a value."),),
                    }),
                    7_i32,
                    ' ',
                );
                let v643: &str = inline_colorization::color_bright_blue;
                let v645: &str = &*v627;
                let v647: &str = inline_colorization::color_reset;
                let v649: string = string("format!(\"{v643}{v645}{v647}\")");
                let v650: std::string::String = format!("{v643}{v645}{v647}");
                let v652: string = fable_library_rust::String_::fromString(v650);
                let v693: i64 = (patternInput_2.0.clone()).l0.get().clone();
                let v695: LrcPtr<Documents::Mut4> = LrcPtr::new(Documents::Mut4 {
                    l0: MutCell::new(Documents::method10()),
                });
                let v702: () = {
                    Documents::closure11(v695.clone(), sprintf!("{}", string("{ ")), ());
                    ()
                };
                let v711: () = {
                    Documents::closure11(v695.clone(), sprintf!("{}", string("source_dir")), ());
                    ()
                };
                let v720: () = {
                    Documents::closure11(v695.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v728: () = {
                    Documents::closure11(v695.clone(), sprintf!("{}", v1_1), ());
                    ()
                };
                let v737: () = {
                    Documents::closure11(v695.clone(), sprintf!("{}", string("; ")), ());
                    ()
                };
                let v746: () = {
                    Documents::closure11(v695.clone(), sprintf!("{}", string("dist_dir")), ());
                    ()
                };
                let v754: () = {
                    Documents::closure11(v695.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v762: () = {
                    Documents::closure11(v695.clone(), sprintf!("{}", v2), ());
                    ()
                };
                let v770: () = {
                    Documents::closure11(v695.clone(), sprintf!("{}", string("; ")), ());
                    ()
                };
                let v779: () = {
                    Documents::closure11(v695.clone(), sprintf!("{}", string("cache_dir")), ());
                    ()
                };
                let v787: () = {
                    Documents::closure11(v695.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v795: () = {
                    Documents::closure11(v695.clone(), sprintf!("{}", v3), ());
                    ()
                };
                let v803: () = {
                    Documents::closure11(v695.clone(), sprintf!("{}", string("; ")), ());
                    ()
                };
                let v812: () = {
                    Documents::closure11(v695.clone(), sprintf!("{}", string("hangul_spec")), ());
                    ()
                };
                let v820: () = {
                    Documents::closure11(v695.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v828: () = {
                    Documents::closure11(v695.clone(), sprintf!("{}", v0_1), ());
                    ()
                };
                let v837: () = {
                    Documents::closure11(v695.clone(), sprintf!("{}", string(" }")), ());
                    ()
                };
                let v840: string = v695.l0.get().clone();
                let v879: string = trimEndChars(
                    trimStartChars(
                        sprintf!(
                            "{} {} #{} {} / {}",
                            v169,
                            v652,
                            v693,
                            Documents::closure21((), ()),
                            v840
                        ),
                        toArray(empty::<char>()),
                    ),
                    toArray(ofArray(new_array(&[' ', '/']))),
                );
                println!("{}", v879.clone());
                ();
                ((patternInput.1.clone()).l0.get().clone())(v879)
            }
        }
        pub fn method32(v0_1: async_walkdir::DirEntry) -> async_walkdir::DirEntry {
            v0_1
        }
        pub fn closure23(unitVar: (), v0_1: std::io::Error) -> std::string::String {
            format!("{}", v0_1)
        }
        pub fn method33() -> Func1<std::io::Error, std::string::String> {
            Func1::new(move |v: std::io::Error| Documents::closure23((), v))
        }
        pub fn closure24(unitVar: (), v0_1: std::fs::FileType) -> Documents::US8 {
            Documents::US8::US8_0(v0_1)
        }
        pub fn closure25(unitVar: (), v0_1: std::string::String) -> Documents::US8 {
            Documents::US8::US8_1(v0_1)
        }
        pub fn method34(v0_1: std::fs::FileType) -> std::fs::FileType {
            v0_1
        }
        pub fn method35(v0_1: Documents::US9) -> Documents::US9 {
            v0_1
        }
        pub fn method36(v0_1: async_walkdir::Filtering) -> async_walkdir::Filtering {
            v0_1
        }
        pub fn closure22(
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
                    let v5: async_walkdir::DirEntry = Documents::method32(v0_1.clone());
                    let v7: std::pin::Pin<
                        Box<
                            dyn std::future::Future<
                                    Output = Result<std::fs::FileType, std::io::Error>,
                                > + Send,
                        >,
                    > = Box::pin(async_walkdir::DirEntry::file_type(&v5));
                    let v9: Result<std::fs::FileType, std::io::Error> = v7.await;
                    let v10 = Documents::method33();
                    let v12: Result<std::fs::FileType, std::string::String> =
                        v9.map_err(|x| v10(x));
                    let v15: Documents::US8 = match &v12 {
                        Err(v12_1_0) => Documents::closure25((), v12_1_0.clone()),
                        Ok(v12_0_0) => Documents::closure24((), v12_0_0.clone()),
                    };
                    let v95: Documents::US9 =
                        Documents::method35(if let Documents::US8::US8_0(v15_0_0) = &v15 {
                            let v17: std::fs::FileType = Documents::method34(match &v15 {
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
                let v116: async_walkdir::Filtering = Documents::method36(match &v106 {
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
        pub fn closure27(unitVar: (), v0_1: async_walkdir::Error) -> std::string::String {
            format!("{}", v0_1)
        }
        pub fn method38() -> Func1<async_walkdir::Error, std::string::String> {
            Func1::new(move |v: async_walkdir::Error| Documents::closure27((), v))
        }
        pub fn closure28(unitVar: (), v0_1: async_walkdir::DirEntry) -> Documents::US10 {
            Documents::US10::US10_0(v0_1)
        }
        pub fn closure29(unitVar: (), v0_1: std::string::String) -> Documents::US10 {
            Documents::US10::US10_1(v0_1)
        }
        pub fn closure31(unitVar: (), unitVar_1: ()) -> string {
            string("documents.run / stream_filter_map")
        }
        pub fn closure30(v0_1: std::string::String, unitVar: ()) {
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
                Option<i64>,
            ) = getValue(Documents::State::trace_state().get().clone());
            let v32: () = {
                v2();
                ()
            };
            let patternInput_1: (
                LrcPtr<Documents::Mut0>,
                LrcPtr<Documents::Mut1>,
                LrcPtr<Documents::Mut2>,
                LrcPtr<Documents::Mut3>,
                Option<i64>,
            ) = getValue(Documents::State::trace_state().get().clone());
            let v60: Documents::US0 = (patternInput_1.3.clone()).l0.get().clone();
            if if (patternInput_1.2.clone()).l0.get().clone() == false {
                false
            } else {
                4_i32
                    >= find(
                        v60,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Documents::US0::US0_0, 0_i32)),
                            LrcPtr::new((Documents::US0::US0_1, 1_i32)),
                            LrcPtr::new((Documents::US0::US0_2, 2_i32)),
                            LrcPtr::new((Documents::US0::US0_3, 3_i32)),
                            LrcPtr::new((Documents::US0::US0_4, 4_i32)),
                        ])))),
                    )
            } {
                let v68: () = {
                    Documents::closure8(patternInput.0.clone(), ());
                    ()
                };
                let v72: () = {
                    v2();
                    ()
                };
                let patternInput_2: (
                    LrcPtr<Documents::Mut0>,
                    LrcPtr<Documents::Mut1>,
                    LrcPtr<Documents::Mut2>,
                    LrcPtr<Documents::Mut3>,
                    Option<i64>,
                ) = getValue(Documents::State::trace_state().get().clone());
                let _v101: LrcPtr<MutCell<Option<Documents::US3>>> =
                    refCell(None::<Documents::US3>);
                let v106: () = {
                    Documents::closure10(
                        patternInput_2.4.clone(),
                        Func1::new({
                            let _v101 = _v101.clone();
                            move |v: Option<Documents::US3>| Documents::closure9(_v101.clone(), v)
                        }),
                        (),
                    );
                    ()
                };
                let v121: Documents::US3 = defaultValue(Documents::US3::US3_1, _v101.get().clone());
                let v161: DateTime = match &v121 {
                    Documents::US3::US3_0(v121_0_0) => {
                        let v135: TimeSpan = TimeSpan::new_ticks(
                            {
                                let _arg: DateTime = DateTime::now();
                                _arg.ticks()
                            } - match &v121 {
                                Documents::US3::US3_0(x) => x.clone(),
                                _ => unreachable!(),
                            },
                        );
                        DateTime::new_ymdhms_milli(
                            1_i32,
                            1_i32,
                            1_i32,
                            v135.hours(),
                            v135.minutes(),
                            v135.seconds(),
                            v135.milliseconds(),
                        )
                    }
                    _ => DateTime::now(),
                };
                let v166: string = {
                    let provider: string = Documents::method6();
                    v161.toString(provider)
                };
                let v554: string = Documents::method8();
                let v566: LrcPtr<Documents::Mut4> = LrcPtr::new(Documents::Mut4 {
                    l0: MutCell::new(Documents::method10()),
                });
                let v577: () = {
                    Documents::closure11(
                        v566.clone(),
                        sprintf!("{}", sprintf!("{:?}", Documents::US0::US0_0)),
                        (),
                    );
                    ()
                };
                let v581: Array<string> = split(v566.l0.get().clone(), v554, -1_i32, 0_i32);
                let v584: string = v581[0_i32].clone();
                let v588: LrcPtr<Documents::Mut4> = LrcPtr::new(Documents::Mut4 {
                    l0: MutCell::new(Documents::method10()),
                });
                let v599: () = {
                    Documents::closure11(
                        v588.clone(),
                        sprintf!("{}", sprintf!("{:?}", Documents::US0::US0_4)),
                        (),
                    );
                    ()
                };
                let v609: Documents::US1 = if startsWith(v588.l0.get().clone(), v584, false) {
                    Documents::US1::US1_0(string("Verbose"))
                } else {
                    Documents::US1::US1_1
                };
                let v798: Documents::US1 = match &v609 {
                    Documents::US1::US1_0(v609_0_0) => Documents::US1::US1_0(match &v609 {
                        Documents::US1::US1_0(x) => x.clone(),
                        _ => unreachable!(),
                    }),
                    _ => {
                        let v613: string = Documents::method8();
                        let v625: LrcPtr<Documents::Mut4> = LrcPtr::new(Documents::Mut4 {
                            l0: MutCell::new(Documents::method10()),
                        });
                        let v636: () = {
                            Documents::closure11(
                                v625.clone(),
                                sprintf!("{}", sprintf!("{:?}", Documents::US0::US0_1)),
                                (),
                            );
                            ()
                        };
                        let v640: Array<string> = split(v625.l0.get().clone(), v613, -1_i32, 0_i32);
                        let v643: string = v640[0_i32].clone();
                        let v647: LrcPtr<Documents::Mut4> = LrcPtr::new(Documents::Mut4 {
                            l0: MutCell::new(Documents::method10()),
                        });
                        let v658: () = {
                            Documents::closure11(
                                v647.clone(),
                                sprintf!("{}", sprintf!("{:?}", Documents::US0::US0_4)),
                                (),
                            );
                            ()
                        };
                        let v668: Documents::US1 = if startsWith(v647.l0.get().clone(), v643, false)
                        {
                            Documents::US1::US1_0(string("Debug"))
                        } else {
                            Documents::US1::US1_1
                        };
                        match &v668 {
                            Documents::US1::US1_0(v668_0_0) => Documents::US1::US1_0(match &v668 {
                                Documents::US1::US1_0(x) => x.clone(),
                                _ => unreachable!(),
                            }),
                            _ => {
                                let v672: string = Documents::method8();
                                let v684: LrcPtr<Documents::Mut4> = LrcPtr::new(Documents::Mut4 {
                                    l0: MutCell::new(Documents::method10()),
                                });
                                let v695: () = {
                                    Documents::closure11(
                                        v684.clone(),
                                        sprintf!("{}", sprintf!("{:?}", Documents::US0::US0_2)),
                                        (),
                                    );
                                    ()
                                };
                                let v699: Array<string> =
                                    split(v684.l0.get().clone(), v672, -1_i32, 0_i32);
                                let v702: string = v699[0_i32].clone();
                                let v706: LrcPtr<Documents::Mut4> = LrcPtr::new(Documents::Mut4 {
                                    l0: MutCell::new(Documents::method10()),
                                });
                                let v717: () = {
                                    Documents::closure11(
                                        v706.clone(),
                                        sprintf!("{}", sprintf!("{:?}", Documents::US0::US0_4)),
                                        (),
                                    );
                                    ()
                                };
                                let v727: Documents::US1 =
                                    if startsWith(v706.l0.get().clone(), v702, false) {
                                        Documents::US1::US1_0(string("Info"))
                                    } else {
                                        Documents::US1::US1_1
                                    };
                                match &v727 {
                                    Documents::US1::US1_0(v727_0_0) => {
                                        Documents::US1::US1_0(match &v727 {
                                            Documents::US1::US1_0(x) => x.clone(),
                                            _ => unreachable!(),
                                        })
                                    }
                                    _ => {
                                        let v731: string = Documents::method8();
                                        let v743: LrcPtr<Documents::Mut4> =
                                            LrcPtr::new(Documents::Mut4 {
                                                l0: MutCell::new(Documents::method10()),
                                            });
                                        let v754: () = {
                                            Documents::closure11(
                                                v743.clone(),
                                                sprintf!(
                                                    "{}",
                                                    sprintf!("{:?}", Documents::US0::US0_3)
                                                ),
                                                (),
                                            );
                                            ()
                                        };
                                        let v758: Array<string> =
                                            split(v743.l0.get().clone(), v731, -1_i32, 0_i32);
                                        let v761: string = v758[0_i32].clone();
                                        let v765: LrcPtr<Documents::Mut4> =
                                            LrcPtr::new(Documents::Mut4 {
                                                l0: MutCell::new(Documents::method10()),
                                            });
                                        let v776: () = {
                                            Documents::closure11(
                                                v765.clone(),
                                                sprintf!(
                                                    "{}",
                                                    sprintf!("{:?}", Documents::US0::US0_4)
                                                ),
                                                (),
                                            );
                                            ()
                                        };
                                        let v786: Documents::US1 =
                                            if startsWith(v765.l0.get().clone(), v761, false) {
                                                Documents::US1::US1_0(string("Warning"))
                                            } else {
                                                Documents::US1::US1_1
                                            };
                                        match &v786 {
                                            Documents::US1::US1_0(v786_0_0) => {
                                                Documents::US1::US1_0(match &v786 {
                                                    Documents::US1::US1_0(x) => x.clone(),
                                                    _ => unreachable!(),
                                                })
                                            }
                                            _ => Documents::US1::US1_0(string("Critical")),
                                        }
                                    }
                                }
                            }
                        }
                    }
                };
                let v807: string = padLeft(
                    toLower(match &v798 {
                        Documents::US1::US1_0(v798_0_0) => match &v798 {
                            Documents::US1::US1_0(x) => x.clone(),
                            _ => unreachable!(),
                        },
                        _ => panic!("{}", string("Option does not have a value."),),
                    }),
                    7_i32,
                    ' ',
                );
                let v823: &str = inline_colorization::color_bright_red;
                let v825: &str = &*v807;
                let v827: &str = inline_colorization::color_reset;
                let v829: string = string("format!(\"{v823}{v825}{v827}\")");
                let v830: std::string::String = format!("{v823}{v825}{v827}");
                let v832: string = fable_library_rust::String_::fromString(v830);
                let v873: i64 = (patternInput_2.0.clone()).l0.get().clone();
                let v875: LrcPtr<Documents::Mut4> = LrcPtr::new(Documents::Mut4 {
                    l0: MutCell::new(Documents::method10()),
                });
                let v882: () = {
                    Documents::closure11(v875.clone(), sprintf!("{}", string("{ ")), ());
                    ()
                };
                let v891: () = {
                    Documents::closure11(v875.clone(), sprintf!("{}", string("error")), ());
                    ()
                };
                let v900: () = {
                    Documents::closure11(v875.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v905: std::string::String = format!("{:#?}", v0_1);
                let v935: () = {
                    Documents::closure11(
                        v875.clone(),
                        sprintf!("{}", fable_library_rust::String_::fromString(v905)),
                        (),
                    );
                    ()
                };
                let v944: () = {
                    Documents::closure11(v875.clone(), sprintf!("{}", string(" }")), ());
                    ()
                };
                let v947: string = v875.l0.get().clone();
                let v986: string = trimEndChars(
                    trimStartChars(
                        sprintf!(
                            "{} {} #{} {} / {}",
                            v166,
                            v832,
                            v873,
                            Documents::closure31((), ()),
                            v947
                        ),
                        toArray(empty::<char>()),
                    ),
                    toArray(ofArray(new_array(&[' ', '/']))),
                );
                println!("{}", v986.clone());
                ();
                ((patternInput.1.clone()).l0.get().clone())(v986)
            }
        }
        pub fn closure26(
            unitVar: (),
            v0_1: Result<async_walkdir::DirEntry, async_walkdir::Error>,
        ) -> Option<string> {
            let v1_1 = Documents::method38();
            let v3: Result<async_walkdir::DirEntry, std::string::String> =
                v0_1.map_err(|x| v1_1(x));
            let v6: Documents::US10 = match &v3 {
                Err(v3_1_0) => Documents::closure29((), v3_1_0.clone()),
                Ok(v3_0_0) => Documents::closure28((), v3_0_0.clone()),
            };
            let v1051: Documents::US1 = match &v6 {
                Documents::US10::US10_0(v6_0_0) => {
                    let v9: std::path::PathBuf = async_walkdir::DirEntry::path(&v6_0_0.clone());
                    let v11: std::path::Display = v9.display();
                    let v14: std::string::String = format!("{}", v11);
                    Documents::US1::US1_0(fable_library_rust::String_::fromString(v14))
                }
                Documents::US10::US10_1(v6_1_0) => {
                    let v39: () = {
                        Documents::closure30(v6_1_0.clone(), ());
                        ()
                    };
                    Documents::US1::US1_1
                }
            };
            match &v1051 {
                Documents::US1::US1_0(v1051_0_0) => Some(match &v1051 {
                    Documents::US1::US1_0(x) => x.clone(),
                    _ => unreachable!(),
                }),
                _ => None::<string>,
            }
        }
        pub fn method37(
        ) -> Func1<Result<async_walkdir::DirEntry, async_walkdir::Error>, Option<string>> {
            Func1::new(
                move |v: Result<async_walkdir::DirEntry, async_walkdir::Error>| {
                    Documents::closure26((), v)
                },
            )
        }
        pub fn closure33(unitVar: (), unitVar_1: ()) -> string {
            string("documents.run")
        }
        pub fn closure32(v0_1: Vec<string>, unitVar: ()) {
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
                Option<i64>,
            ) = getValue(Documents::State::trace_state().get().clone());
            let v32: () = {
                v2();
                ()
            };
            let patternInput_1: (
                LrcPtr<Documents::Mut0>,
                LrcPtr<Documents::Mut1>,
                LrcPtr<Documents::Mut2>,
                LrcPtr<Documents::Mut3>,
                Option<i64>,
            ) = getValue(Documents::State::trace_state().get().clone());
            let v60: Documents::US0 = (patternInput_1.3.clone()).l0.get().clone();
            if if (patternInput_1.2.clone()).l0.get().clone() == false {
                false
            } else {
                1_i32
                    >= find(
                        v60,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Documents::US0::US0_0, 0_i32)),
                            LrcPtr::new((Documents::US0::US0_1, 1_i32)),
                            LrcPtr::new((Documents::US0::US0_2, 2_i32)),
                            LrcPtr::new((Documents::US0::US0_3, 3_i32)),
                            LrcPtr::new((Documents::US0::US0_4, 4_i32)),
                        ])))),
                    )
            } {
                let v68: () = {
                    Documents::closure8(patternInput.0.clone(), ());
                    ()
                };
                let v72: () = {
                    v2();
                    ()
                };
                let patternInput_2: (
                    LrcPtr<Documents::Mut0>,
                    LrcPtr<Documents::Mut1>,
                    LrcPtr<Documents::Mut2>,
                    LrcPtr<Documents::Mut3>,
                    Option<i64>,
                ) = getValue(Documents::State::trace_state().get().clone());
                let _v101: LrcPtr<MutCell<Option<Documents::US3>>> =
                    refCell(None::<Documents::US3>);
                let v106: () = {
                    Documents::closure10(
                        patternInput_2.4.clone(),
                        Func1::new({
                            let _v101 = _v101.clone();
                            move |v: Option<Documents::US3>| Documents::closure9(_v101.clone(), v)
                        }),
                        (),
                    );
                    ()
                };
                let v121: Documents::US3 = defaultValue(Documents::US3::US3_1, _v101.get().clone());
                let v161: DateTime = match &v121 {
                    Documents::US3::US3_0(v121_0_0) => {
                        let v135: TimeSpan = TimeSpan::new_ticks(
                            {
                                let _arg: DateTime = DateTime::now();
                                _arg.ticks()
                            } - match &v121 {
                                Documents::US3::US3_0(x) => x.clone(),
                                _ => unreachable!(),
                            },
                        );
                        DateTime::new_ymdhms_milli(
                            1_i32,
                            1_i32,
                            1_i32,
                            v135.hours(),
                            v135.minutes(),
                            v135.seconds(),
                            v135.milliseconds(),
                        )
                    }
                    _ => DateTime::now(),
                };
                let v166: string = {
                    let provider: string = Documents::method6();
                    v161.toString(provider)
                };
                let v554: string = Documents::method8();
                let v566: LrcPtr<Documents::Mut4> = LrcPtr::new(Documents::Mut4 {
                    l0: MutCell::new(Documents::method10()),
                });
                let v577: () = {
                    Documents::closure11(
                        v566.clone(),
                        sprintf!("{}", sprintf!("{:?}", Documents::US0::US0_0)),
                        (),
                    );
                    ()
                };
                let v581: Array<string> = split(v566.l0.get().clone(), v554, -1_i32, 0_i32);
                let v584: string = v581[0_i32].clone();
                let v588: LrcPtr<Documents::Mut4> = LrcPtr::new(Documents::Mut4 {
                    l0: MutCell::new(Documents::method10()),
                });
                let v599: () = {
                    Documents::closure11(
                        v588.clone(),
                        sprintf!("{}", sprintf!("{:?}", Documents::US0::US0_1)),
                        (),
                    );
                    ()
                };
                let v609: Documents::US1 = if startsWith(v588.l0.get().clone(), v584, false) {
                    Documents::US1::US1_0(string("Verbose"))
                } else {
                    Documents::US1::US1_1
                };
                let v615: Documents::US1 = match &v609 {
                    Documents::US1::US1_0(v609_0_0) => Documents::US1::US1_0(match &v609 {
                        Documents::US1::US1_0(x) => x.clone(),
                        _ => unreachable!(),
                    }),
                    _ => Documents::US1::US1_0(string("Debug")),
                };
                let v624: string = padLeft(
                    toLower(match &v615 {
                        Documents::US1::US1_0(v615_0_0) => match &v615 {
                            Documents::US1::US1_0(x) => x.clone(),
                            _ => unreachable!(),
                        },
                        _ => panic!("{}", string("Option does not have a value."),),
                    }),
                    7_i32,
                    ' ',
                );
                let v640: &str = inline_colorization::color_bright_blue;
                let v642: &str = &*v624;
                let v644: &str = inline_colorization::color_reset;
                let v646: string = string("format!(\"{v640}{v642}{v644}\")");
                let v647: std::string::String = format!("{v640}{v642}{v644}");
                let v649: string = fable_library_rust::String_::fromString(v647);
                let v690: i64 = (patternInput_2.0.clone()).l0.get().clone();
                let v692: usize = v0_1.len();
                let v694: LrcPtr<Documents::Mut4> = LrcPtr::new(Documents::Mut4 {
                    l0: MutCell::new(Documents::method10()),
                });
                let v701: () = {
                    Documents::closure11(v694.clone(), sprintf!("{}", string("{ ")), ());
                    ()
                };
                let v710: () = {
                    Documents::closure11(v694.clone(), sprintf!("{}", string("files_len")), ());
                    ()
                };
                let v719: () = {
                    Documents::closure11(v694.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v724: std::string::String = format!("{:#?}", v692);
                let v754: () = {
                    Documents::closure11(
                        v694.clone(),
                        sprintf!("{}", fable_library_rust::String_::fromString(v724)),
                        (),
                    );
                    ()
                };
                let v763: () = {
                    Documents::closure11(v694.clone(), sprintf!("{}", string(" }")), ());
                    ()
                };
                let v766: string = v694.l0.get().clone();
                let v805: string = trimEndChars(
                    trimStartChars(
                        sprintf!(
                            "{} {} #{} {} / {}",
                            v166,
                            v649,
                            v690,
                            Documents::closure33((), ()),
                            v766
                        ),
                        toArray(empty::<char>()),
                    ),
                    toArray(ofArray(new_array(&[' ', '/']))),
                );
                println!("{}", v805.clone());
                ();
                ((patternInput.1.clone()).l0.get().clone())(v805)
            }
        }
        pub fn method39() -> string {
            string("")
        }
        pub fn method40(v0_1: string) -> string {
            Documents::method27(Documents::method26(v0_1))
        }
        pub fn method42(
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
        pub fn closure37(v0_1: char, v1_1: LrcPtr<Documents::UH0>) -> LrcPtr<Documents::UH0> {
            LrcPtr::new(Documents::UH0::UH0_1(v0_1, v1_1))
        }
        pub fn closure36(
            unitVar: (),
            v0_1: char,
        ) -> Func1<LrcPtr<Documents::UH0>, LrcPtr<Documents::UH0>> {
            Func1::new({
                let v0_1 = v0_1.clone();
                move |v: LrcPtr<Documents::UH0>| Documents::closure37(v0_1, v)
            })
        }
        pub fn method44() -> Func1<char, Func1<LrcPtr<Documents::UH0>, LrcPtr<Documents::UH0>>> {
            Func1::new(move |v: char| Documents::closure36((), v))
        }
        pub fn method45(
            v0_1: LrcPtr<Documents::UH0>,
            v1_1: LrcPtr<StringBuilder>,
            v2: i32,
            v3: i32,
        ) -> (LrcPtr<StringBuilder>, i32, i32) {
            let v0_1: MutCell<LrcPtr<Documents::UH0>> = MutCell::new(v0_1.clone());
            let v1_1: MutCell<LrcPtr<StringBuilder>> = MutCell::new(v1_1.clone());
            let v2: MutCell<i32> = MutCell::new(v2);
            let v3: MutCell<i32> = MutCell::new(v3);
            '_method45: loop {
                break '_method45 (match v0_1.get().clone().as_ref() {
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
                            continue '_method45;
                        }
                    }
                });
            }
        }
        pub fn closure35(
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
                    while Documents::method30(v20, v22.clone()) {
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
                        let patternInput: (LrcPtr<StringBuilder>, i32, i32) = Documents::method45(
                            foldBack(
                                Func2::new(move |b0: char, b1: LrcPtr<Documents::UH0>| {
                                    (Documents::method44())(b0)(b1)
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
        pub fn closure38(
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
                    while Documents::method30(v20, v22.clone()) {
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
                        let patternInput: (LrcPtr<StringBuilder>, i32, i32) = Documents::method45(
                            foldBack(
                                Func2::new(move |b0: char, b1: LrcPtr<Documents::UH0>| {
                                    (Documents::method44())(b0)(b1)
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
        pub fn method46(
            v0_1: string,
            v1_1: LrcPtr<StringBuilder>,
            v2: LrcPtr<Documents::UH1>,
        ) -> Documents::US12 {
            let v0_1: MutCell<string> = MutCell::new(v0_1.clone());
            let v1_1: MutCell<LrcPtr<StringBuilder>> = MutCell::new(v1_1.clone());
            let v2: MutCell<LrcPtr<Documents::UH1>> = MutCell::new(v2.clone());
            '_method46: loop {
                break '_method46 (match v2.get().clone().as_ref() {
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
                                continue '_method46;
                            }
                        }
                    }
                });
            }
        }
        pub fn method47(v0_1: char, v1_1: i64) -> bool {
            let v0_1: MutCell<char> = MutCell::new(v0_1);
            let v1_1: MutCell<i64> = MutCell::new(v1_1);
            '_method47: loop {
                break '_method47 (if v1_1.get().clone() >= 2_i64 {
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
                        continue '_method47;
                    }
                });
            }
        }
        pub fn method48(
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
            '_method48: loop {
                break '_method48 ({
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
                        if Documents::method47(v19, 0_i64) == false {
                            let v31: string = ofChar(v19);
                            let v34: i32 = length(v31.clone());
                            let v35: Array<char> = new_init(&'\u{0000}', v34);
                            let v36: LrcPtr<Documents::Mut6> = LrcPtr::new(Documents::Mut6 {
                                l0: MutCell::new(0_i32),
                            });
                            while Documents::method30(v34, v36.clone()) {
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
                                    Documents::method45(
                                        foldBack(
                                            Func2::new(
                                                move |b0: char, b1: LrcPtr<Documents::UH0>| {
                                                    (Documents::method44())(b0)(b1)
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
                            continue '_method48;
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
        pub fn method49(
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
            '_method49: loop {
                break '_method49 (match v4.get().clone().as_ref() {
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
                                continue '_method49;
                            }
                        }
                    }
                });
            }
        }
        pub fn method50(v0_1: char, v1_1: i64) -> bool {
            let v0_1: MutCell<char> = MutCell::new(v0_1);
            let v1_1: MutCell<i64> = MutCell::new(v1_1);
            '_method50: loop {
                break '_method50 (if v1_1.get().clone() >= 3_i64 {
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
                        continue '_method50;
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
                        if Documents::method50(v22, 0_i64) == false {
                            let v34: string = ofChar(v22);
                            let v37: i32 = length(v34.clone());
                            let v38: Array<char> = new_init(&'\u{0000}', v37);
                            let v39: LrcPtr<Documents::Mut6> = LrcPtr::new(Documents::Mut6 {
                                l0: MutCell::new(0_i32),
                            });
                            while Documents::method30(v37, v39.clone()) {
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
                                    Documents::method45(
                                        foldBack(
                                            Func2::new(
                                                move |b0: char, b1: LrcPtr<Documents::UH0>| {
                                                    (Documents::method44())(b0)(b1)
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
        pub fn method52(v0_1: string, v1_1: i32) -> i32 {
            let v0_1: MutCell<string> = MutCell::new(v0_1.clone());
            let v1_1: MutCell<i32> = MutCell::new(v1_1);
            '_method52: loop {
                break '_method52 (if v1_1.get().clone() >= length(v0_1.get().clone()) {
                    v1_1.get().clone()
                } else {
                    if getCharAt(v0_1.get().clone(), v1_1.get().clone()) == ' ' {
                        let v0_1_temp: string = v0_1.get().clone();
                        let v1_1_temp: i32 = v1_1.get().clone() + 1_i32;
                        v0_1.set(v0_1_temp);
                        v1_1.set(v1_1_temp);
                        continue '_method52;
                    } else {
                        v1_1.get().clone()
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
        ) -> Documents::US13 {
            let v0_1: MutCell<string> = MutCell::new(v0_1.clone());
            let v1_1: MutCell<string> = MutCell::new(v1_1.clone());
            let v2: MutCell<LrcPtr<StringBuilder>> = MutCell::new(v2.clone());
            let v3: MutCell<i32> = MutCell::new(v3);
            let v4: MutCell<i32> = MutCell::new(v4);
            '_method53: loop {
                break '_method53 ({
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
                        while Documents::method30(v20, v22.clone()) {
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
                                Documents::method45(
                                    foldBack(
                                        Func2::new(move |b0: char, b1: LrcPtr<Documents::UH0>| {
                                            (Documents::method44())(b0)(b1)
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
                            continue '_method53;
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
        pub fn method43(v0_1: string) -> Documents::US11 {
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
                    Documents::closure35((), arg10_0040)
                }
                fn v13(arg10_0040_1: (string, LrcPtr<StringBuilder>, i32, i32)) -> Documents::US12 {
                    Documents::closure38((), arg10_0040_1)
                }
                let v17: Documents::US12 = Documents::method46(
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
                            if Documents::method47(v37, 0_i64) == false {
                                let v49: string = ofChar(v37);
                                let v52: i32 = length(v49.clone());
                                let v53: Array<char> = new_init(&'\u{0000}', v52);
                                let v54: LrcPtr<Documents::Mut6> = LrcPtr::new(Documents::Mut6 {
                                    l0: MutCell::new(0_i32),
                                });
                                while Documents::method30(v52, v54.clone()) {
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
                                        Documents::method45(
                                            foldBack(
                                                Func2::new(
                                                    move |b0: char, b1: LrcPtr<Documents::UH0>| {
                                                        (Documents::method44())(b0)(b1)
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
                            ) => Documents::method48(
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
                                let v133: Documents::US12 = Documents::method49(
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
                            if Documents::method50(v177, 0_i64) == false {
                                let v189: string = ofChar(v177);
                                let v192: i32 = length(v189.clone());
                                let v193: Array<char> = new_init(&'\u{0000}', v192);
                                let v194: LrcPtr<Documents::Mut6> = LrcPtr::new(Documents::Mut6 {
                                    l0: MutCell::new(0_i32),
                                });
                                while Documents::method30(v192, v194.clone()) {
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
                                        Documents::method45(
                                            foldBack(
                                                Func2::new(
                                                    move |b0: char, b1: LrcPtr<Documents::UH0>| {
                                                        (Documents::method44())(b0)(b1)
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
                            ) => Documents::method51(
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
                                                Some(Documents::method52(v282.clone(), 0_i32)),
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
                                while Documents::method30(v325, v327.clone()) {
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
                                        Documents::method45(
                                            foldBack(
                                                Func2::new(
                                                    move |b0: char, b1: LrcPtr<Documents::UH0>| {
                                                        (Documents::method44())(b0)(b1)
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
                                    while Documents::method30(v405, v407.clone()) {
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
                                                        Documents::method45(foldBack(Func2::new(move
                                                                                                    |b0:
                                                                                                         char,
                                                                                                     b1:
                                                                                                         LrcPtr<Documents::UH0>|
                                                                                                    (Documents::method44())(b0)(b1)),
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
                                    ) => Documents::method53(
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
        pub fn method56(v0_1: char, v1_1: i64) -> bool {
            let v0_1: MutCell<char> = MutCell::new(v0_1);
            let v1_1: MutCell<i64> = MutCell::new(v1_1);
            '_method56: loop {
                break '_method56 (if v1_1.get().clone() >= 4_i64 {
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
                        continue '_method56;
                    }
                });
            }
        }
        pub fn method57(
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
            '_method57: loop {
                break '_method57 ({
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
                        if Documents::method56(v25, 0_i64) == false {
                            let v37: string = ofChar(v25);
                            let v40: i32 = length(v37.clone());
                            let v41: Array<char> = new_init(&'\u{0000}', v40);
                            let v42: LrcPtr<Documents::Mut6> = LrcPtr::new(Documents::Mut6 {
                                l0: MutCell::new(0_i32),
                            });
                            while Documents::method30(v40, v42.clone()) {
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
                                    Documents::method45(
                                        foldBack(
                                            Func2::new(
                                                move |b0: char, b1: LrcPtr<Documents::UH0>| {
                                                    (Documents::method44())(b0)(b1)
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
                            continue '_method57;
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
        pub fn method59(v0_1: char, v1_1: i64) -> bool {
            let v0_1: MutCell<char> = MutCell::new(v0_1);
            let v1_1: MutCell<i64> = MutCell::new(v1_1);
            '_method59: loop {
                break '_method59 (if v1_1.get().clone() >= 3_i64 {
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
                        continue '_method59;
                    }
                });
            }
        }
        pub fn closure39(
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
                    while Documents::method30(v20, v22.clone()) {
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
                        let patternInput: (LrcPtr<StringBuilder>, i32, i32) = Documents::method45(
                            foldBack(
                                Func2::new(move |b0: char, b1: LrcPtr<Documents::UH0>| {
                                    (Documents::method44())(b0)(b1)
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
                        while Documents::method30(v88, v90.clone()) {
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
                                Documents::method45(
                                    foldBack(
                                        Func2::new(move |b0: char, b1: LrcPtr<Documents::UH0>| {
                                            (Documents::method44())(b0)(b1)
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
        pub fn closure40(
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
                    while Documents::method30(v20, v22.clone()) {
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
                        let patternInput: (LrcPtr<StringBuilder>, i32, i32) = Documents::method45(
                            foldBack(
                                Func2::new(move |b0: char, b1: LrcPtr<Documents::UH0>| {
                                    (Documents::method44())(b0)(b1)
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
                        while Documents::method30(v88, v90.clone()) {
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
                                Documents::method45(
                                    foldBack(
                                        Func2::new(move |b0: char, b1: LrcPtr<Documents::UH0>| {
                                            (Documents::method44())(b0)(b1)
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
        pub fn method60(
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
            '_method60: loop {
                break '_method60 (match v4.get().clone().as_ref() {
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
                                continue '_method60;
                            }
                        }
                    }
                });
            }
        }
        pub fn method61(
            v0_1: LrcPtr<Documents::UH2>,
            v1_1: LrcPtr<Documents::UH2>,
        ) -> LrcPtr<Documents::UH2> {
            let v0_1: MutCell<LrcPtr<Documents::UH2>> = MutCell::new(v0_1.clone());
            let v1_1: MutCell<LrcPtr<Documents::UH2>> = MutCell::new(v1_1.clone());
            '_method61: loop {
                break '_method61 (match v0_1.get().clone().as_ref() {
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
                        continue '_method61;
                    }
                });
            }
        }
        pub fn method58(
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
            '_method58: loop {
                break '_method58 ({
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
                        if Documents::method59(v22, 0_i64) == false {
                            let v34: string = ofChar(v22);
                            let v37: i32 = length(v34.clone());
                            let v38: Array<char> = new_init(&'\u{0000}', v37);
                            let v39: LrcPtr<Documents::Mut6> = LrcPtr::new(Documents::Mut6 {
                                l0: MutCell::new(0_i32),
                            });
                            while Documents::method30(v37, v39.clone()) {
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
                                    Documents::method45(
                                        foldBack(
                                            Func2::new(
                                                move |b0: char, b1: LrcPtr<Documents::UH0>| {
                                                    (Documents::method44())(b0)(b1)
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
                        _ => Documents::method60(
                            v1_1.get().clone(),
                            v2.get().clone(),
                            v3.get().clone(),
                            v4.get().clone(),
                            LrcPtr::new(Documents::UH3::UH3_1(
                                Func1::new(
                                    move |arg10_0040: (string, LrcPtr<StringBuilder>, i32, i32)| {
                                        Documents::closure39((), arg10_0040)
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
                                            Documents::closure40((), arg10_0040_1)
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
                            continue '_method58;
                        }
                        _ => Documents::US20::US20_0(
                            Documents::method61(
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
        pub fn method62(v0_1: LrcPtr<Documents::UH2>, v1_1: List<string>) -> List<string> {
            match v0_1.as_ref() {
                Documents::UH2::UH2_0 => v1_1.clone(),
                Documents::UH2::UH2_1(v0_1_1_0, v0_1_1_1) => cons(
                    match v0_1.as_ref() {
                        Documents::UH2::UH2_1(x, _) => x.clone(),
                        _ => unreachable!(),
                    },
                    Documents::method62(
                        match v0_1.as_ref() {
                            Documents::UH2::UH2_1(_, x) => x.clone(),
                            _ => unreachable!(),
                        },
                        v1_1.clone(),
                    ),
                ),
            }
        }
        pub fn method63(
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
            '_method63: loop {
                break '_method63 ({
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
                        if Documents::method59(v22, 0_i64) == false {
                            let v34: string = ofChar(v22);
                            let v37: i32 = length(v34.clone());
                            let v38: Array<char> = new_init(&'\u{0000}', v37);
                            let v39: LrcPtr<Documents::Mut6> = LrcPtr::new(Documents::Mut6 {
                                l0: MutCell::new(0_i32),
                            });
                            while Documents::method30(v37, v39.clone()) {
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
                                    Documents::method45(
                                        foldBack(
                                            Func2::new(
                                                move |b0: char, b1: LrcPtr<Documents::UH0>| {
                                                    (Documents::method44())(b0)(b1)
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
                            continue '_method63;
                        }
                        _ => Documents::US20::US20_0(
                            Documents::method61(
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
        pub fn method64(v0_1: string, v1_1: i32) -> i32 {
            let v0_1: MutCell<string> = MutCell::new(v0_1.clone());
            let v1_1: MutCell<i32> = MutCell::new(v1_1);
            '_method64: loop {
                break '_method64 (if v1_1.get().clone() >= length(v0_1.get().clone()) {
                    v1_1.get().clone()
                } else {
                    if getCharAt(v0_1.get().clone(), v1_1.get().clone()) == ' ' {
                        let v0_1_temp: string = v0_1.get().clone();
                        let v1_1_temp: i32 = v1_1.get().clone() + 1_i32;
                        v0_1.set(v0_1_temp);
                        v1_1.set(v1_1_temp);
                        continue '_method64;
                    } else {
                        v1_1.get().clone()
                    }
                });
            }
        }
        pub fn method55(
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
            '_method55: loop {
                break '_method55 ({
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
                        if Documents::method56(v25, 0_i64) == false {
                            let v37: string = ofChar(v25);
                            let v40: i32 = length(v37.clone());
                            let v41: Array<char> = new_init(&'\u{0000}', v40);
                            let v42: LrcPtr<Documents::Mut6> = LrcPtr::new(Documents::Mut6 {
                                l0: MutCell::new(0_i32),
                            });
                            while Documents::method30(v40, v42.clone()) {
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
                                    Documents::method45(
                                        foldBack(
                                            Func2::new(
                                                move |b0: char, b1: LrcPtr<Documents::UH0>| {
                                                    (Documents::method44())(b0)(b1)
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
                            Documents::method57(
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
                                        let v125: List<char> = ofArray(v119.clone());
                                        let patternInput_1:
                                                                 (LrcPtr<StringBuilder>,
                                                                  i32, i32) =
                                                             Documents::method45(foldBack(Func2::new(move
                                                                                                         |b0:
                                                                                                              char,
                                                                                                          b1:
                                                                                                              LrcPtr<Documents::UH0>|
                                                                                                         (Documents::method44())(b0)(b1)),
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
                                    let v172: Documents::US20 = Documents::method58(
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
                                            let v179: List<string> = Documents::method62(
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
                                                    while Documents::method30(v215, v217.clone()) {
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
                                                                                 Documents::method45(foldBack(Func2::new(move
                                                                                                                             |b0:
                                                                                                                                  char,
                                                                                                                              b1:
                                                                                                                                  LrcPtr<Documents::UH0>|
                                                                                                                             (Documents::method44())(b0)(b1)),
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
                                                     Documents::method60(v1_1.get().clone(),
                                                                         v2.get().clone(),
                                                                         v3.get().clone(),
                                                                         v4.get().clone(),
                                                                         LrcPtr::new(Documents::UH3::UH3_1(Func1::new(move
                                                                                                                          |arg10_0040:
                                                                                                                               (string,
                                                                                                                                LrcPtr<StringBuilder>,
                                                                                                                                i32,
                                                                                                                                i32)|
                                                                                                                          Documents::closure39((),
                                                                                                                                               arg10_0040)),
                                                                                                           LrcPtr::new(Documents::UH3::UH3_1(Func1::new(move
                                                                                                                                                            |arg10_0040_1:
                                                                                                                                                                 (string,
                                                                                                                                                                  LrcPtr<StringBuilder>,
                                                                                                                                                                  i32,
                                                                                                                                                                  i32)|
                                                                                                                                                            Documents::closure40((),
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
                                        ) => Documents::method63(
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
                                            let v323: List<string> = Documents::method62(
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
                            let v352: i32 = Documents::method64(v347.clone(), 0_i32);
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
                                    continue '_method55;
                                }
                                _ => Documents::US20::US20_0(
                                    Documents::method61(
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
                            Documents::method61(
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
        pub fn method54(v0_1: string) -> Documents::US19 {
            let _v0: MutCell<Option<Option<string>>> = MutCell::new(None::<Option<string>>);
            _v0.set(Some(Some(v0_1)));
            {
                let v15: Documents::US20 = Documents::method55(
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
                        Documents::US19::US19_0(toArray(Documents::method62(
                            v15_0_0.clone(),
                            empty::<string>(),
                        )))
                    }
                    Documents::US20::US20_1(v15_1_0) => Documents::US19::US19_1(v15_1_0.clone()),
                }
            }
        }
        pub fn closure42(unitVar: (), unitVar_1: ()) -> string {
            string("runtime.execute_with_options")
        }
        pub fn closure41(
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
                Option<i64>,
            ) = getValue(Documents::State::trace_state().get().clone());
            let v40: () = {
                v10();
                ()
            };
            let patternInput_1: (
                LrcPtr<Documents::Mut0>,
                LrcPtr<Documents::Mut1>,
                LrcPtr<Documents::Mut2>,
                LrcPtr<Documents::Mut3>,
                Option<i64>,
            ) = getValue(Documents::State::trace_state().get().clone());
            let v68: Documents::US0 = (patternInput_1.3.clone()).l0.get().clone();
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
                    v10();
                    ()
                };
                let patternInput_2: (
                    LrcPtr<Documents::Mut0>,
                    LrcPtr<Documents::Mut1>,
                    LrcPtr<Documents::Mut2>,
                    LrcPtr<Documents::Mut3>,
                    Option<i64>,
                ) = getValue(Documents::State::trace_state().get().clone());
                let _v109: LrcPtr<MutCell<Option<Documents::US3>>> =
                    refCell(None::<Documents::US3>);
                let v114: () = {
                    Documents::closure10(
                        patternInput_2.4.clone(),
                        Func1::new({
                            let _v109 = _v109.clone();
                            move |v: Option<Documents::US3>| Documents::closure9(_v109.clone(), v)
                        }),
                        (),
                    );
                    ()
                };
                let v129: Documents::US3 = defaultValue(Documents::US3::US3_1, _v109.get().clone());
                let v169: DateTime = match &v129 {
                    Documents::US3::US3_0(v129_0_0) => {
                        let v143: TimeSpan = TimeSpan::new_ticks(
                            {
                                let _arg: DateTime = DateTime::now();
                                _arg.ticks()
                            } - match &v129 {
                                Documents::US3::US3_0(x) => x.clone(),
                                _ => unreachable!(),
                            },
                        );
                        DateTime::new_ymdhms_milli(
                            1_i32,
                            1_i32,
                            1_i32,
                            v143.hours(),
                            v143.minutes(),
                            v143.seconds(),
                            v143.milliseconds(),
                        )
                    }
                    _ => DateTime::now(),
                };
                let v174: string = {
                    let provider: string = Documents::method6();
                    v169.toString(provider)
                };
                let v562: string = Documents::method8();
                let v574: LrcPtr<Documents::Mut4> = LrcPtr::new(Documents::Mut4 {
                    l0: MutCell::new(Documents::method10()),
                });
                let v585: () = {
                    Documents::closure11(
                        v574.clone(),
                        sprintf!("{}", sprintf!("{:?}", Documents::US0::US0_0)),
                        (),
                    );
                    ()
                };
                let v589: Array<string> = split(v574.l0.get().clone(), v562, -1_i32, 0_i32);
                let v592: string = v589[0_i32].clone();
                let v596: LrcPtr<Documents::Mut4> = LrcPtr::new(Documents::Mut4 {
                    l0: MutCell::new(Documents::method10()),
                });
                let v607: () = {
                    Documents::closure11(
                        v596.clone(),
                        sprintf!("{}", sprintf!("{:?}", Documents::US0::US0_1)),
                        (),
                    );
                    ()
                };
                let v617: Documents::US1 = if startsWith(v596.l0.get().clone(), v592, false) {
                    Documents::US1::US1_0(string("Verbose"))
                } else {
                    Documents::US1::US1_1
                };
                let v623: Documents::US1 = match &v617 {
                    Documents::US1::US1_0(v617_0_0) => Documents::US1::US1_0(match &v617 {
                        Documents::US1::US1_0(x) => x.clone(),
                        _ => unreachable!(),
                    }),
                    _ => Documents::US1::US1_0(string("Debug")),
                };
                let v632: string = padLeft(
                    toLower(match &v623 {
                        Documents::US1::US1_0(v623_0_0) => match &v623 {
                            Documents::US1::US1_0(x) => x.clone(),
                            _ => unreachable!(),
                        },
                        _ => panic!("{}", string("Option does not have a value."),),
                    }),
                    7_i32,
                    ' ',
                );
                let v648: &str = inline_colorization::color_bright_blue;
                let v650: &str = &*v632;
                let v652: &str = inline_colorization::color_reset;
                let v654: string = string("format!(\"{v648}{v650}{v652}\")");
                let v655: std::string::String = format!("{v648}{v650}{v652}");
                let v657: string = fable_library_rust::String_::fromString(v655);
                let v698: i64 = (patternInput_2.0.clone()).l0.get().clone();
                let v700: LrcPtr<Documents::Mut4> = LrcPtr::new(Documents::Mut4 {
                    l0: MutCell::new(Documents::method10()),
                });
                let v707: () = {
                    Documents::closure11(v700.clone(), sprintf!("{}", string("{ ")), ());
                    ()
                };
                let v716: () = {
                    Documents::closure11(v700.clone(), sprintf!("{}", string("file_name")), ());
                    ()
                };
                let v725: () = {
                    Documents::closure11(v700.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v733: () = {
                    Documents::closure11(v700.clone(), sprintf!("{}", v7), ());
                    ()
                };
                let v742: () = {
                    Documents::closure11(v700.clone(), sprintf!("{}", string("; ")), ());
                    ()
                };
                let v751: () = {
                    Documents::closure11(v700.clone(), sprintf!("{}", string("arguments")), ());
                    ()
                };
                let v759: () = {
                    Documents::closure11(v700.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v764: std::string::String = format!("{:#?}", v8);
                let v794: () = {
                    Documents::closure11(
                        v700.clone(),
                        sprintf!("{}", fable_library_rust::String_::fromString(v764)),
                        (),
                    );
                    ()
                };
                let v802: () = {
                    Documents::closure11(v700.clone(), sprintf!("{}", string("; ")), ());
                    ()
                };
                let v811: () = {
                    Documents::closure11(v700.clone(), sprintf!("{}", string("options")), ());
                    ()
                };
                let v819: () = {
                    Documents::closure11(v700.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v827: () = {
                    Documents::closure11(v700.clone(), sprintf!("{}", string("{ ")), ());
                    ()
                };
                let v836: () = {
                    Documents::closure11(v700.clone(), sprintf!("{}", string("command")), ());
                    ()
                };
                let v844: () = {
                    Documents::closure11(v700.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v852: () = {
                    Documents::closure11(v700.clone(), sprintf!("{}", v0_1), ());
                    ()
                };
                let v860: () = {
                    Documents::closure11(v700.clone(), sprintf!("{}", string("; ")), ());
                    ()
                };
                let v869: () = {
                    Documents::closure11(
                        v700.clone(),
                        sprintf!("{}", string("cancellation_token")),
                        (),
                    );
                    ()
                };
                let v877: () = {
                    Documents::closure11(v700.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v882: std::string::String = format!("{:#?}", v1_1);
                let v912: () = {
                    Documents::closure11(
                        v700.clone(),
                        sprintf!("{}", fable_library_rust::String_::fromString(v882)),
                        (),
                    );
                    ()
                };
                let v920: () = {
                    Documents::closure11(v700.clone(), sprintf!("{}", string("; ")), ());
                    ()
                };
                let v929: () = {
                    Documents::closure11(
                        v700.clone(),
                        sprintf!("{}", string("environment_variables")),
                        (),
                    );
                    ()
                };
                let v937: () = {
                    Documents::closure11(v700.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v948: () = {
                    Documents::closure11(v700.clone(), sprintf!("{}", sprintf!("{:?}", v2)), ());
                    ()
                };
                let v956: () = {
                    Documents::closure11(v700.clone(), sprintf!("{}", string("; ")), ());
                    ()
                };
                let v965: () = {
                    Documents::closure11(v700.clone(), sprintf!("{}", string("on_line")), ());
                    ()
                };
                let v973: () = {
                    Documents::closure11(v700.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v978: std::string::String = format!("{:#?}", v3);
                let v1008: () = {
                    Documents::closure11(
                        v700.clone(),
                        sprintf!("{}", fable_library_rust::String_::fromString(v978)),
                        (),
                    );
                    ()
                };
                let v1016: () = {
                    Documents::closure11(v700.clone(), sprintf!("{}", string("; ")), ());
                    ()
                };
                let v1025: () = {
                    Documents::closure11(v700.clone(), sprintf!("{}", string("stdin")), ());
                    ()
                };
                let v1033: () = {
                    Documents::closure11(v700.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v1038: std::string::String = format!("{:#?}", v4);
                let v1068: () = {
                    Documents::closure11(
                        v700.clone(),
                        sprintf!("{}", fable_library_rust::String_::fromString(v1038)),
                        (),
                    );
                    ()
                };
                let v1076: () = {
                    Documents::closure11(v700.clone(), sprintf!("{}", string("; ")), ());
                    ()
                };
                let v1085: () = {
                    Documents::closure11(v700.clone(), sprintf!("{}", string("trace")), ());
                    ()
                };
                let v1093: () = {
                    Documents::closure11(v700.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v1104: () = {
                    Documents::closure11(
                        v700.clone(),
                        sprintf!("{}", if v5 { string("true") } else { string("false") }),
                        (),
                    );
                    ()
                };
                let v1112: () = {
                    Documents::closure11(v700.clone(), sprintf!("{}", string("; ")), ());
                    ()
                };
                let v1121: () = {
                    Documents::closure11(
                        v700.clone(),
                        sprintf!("{}", string("working_directory")),
                        (),
                    );
                    ()
                };
                let v1129: () = {
                    Documents::closure11(v700.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v1134: std::string::String = format!("{:#?}", v6);
                let v1164: () = {
                    Documents::closure11(
                        v700.clone(),
                        sprintf!("{}", fable_library_rust::String_::fromString(v1134)),
                        (),
                    );
                    ()
                };
                let v1173: () = {
                    Documents::closure11(v700.clone(), sprintf!("{}", string(" }")), ());
                    ()
                };
                let v1181: () = {
                    Documents::closure11(v700.clone(), sprintf!("{}", string(" }")), ());
                    ()
                };
                let v1184: string = v700.l0.get().clone();
                let v1223: string = trimEndChars(
                    trimStartChars(
                        sprintf!(
                            "{} {} #{} {} / {}",
                            v174,
                            v657,
                            v698,
                            Documents::closure42((), ()),
                            v1184
                        ),
                        toArray(empty::<char>()),
                    ),
                    toArray(ofArray(new_array(&[' ', '/']))),
                );
                println!("{}", v1223.clone());
                ();
                ((patternInput.1.clone()).l0.get().clone())(v1223)
            }
        }
        pub fn closure43(
            unitVar: (),
            v0_1: std::sync::Arc<std::sync::Mutex<Option<std::process::Child>>>,
        ) -> Documents::US21 {
            Documents::US21::US21_0(v0_1)
        }
        pub fn method65(
        ) -> Func1<std::sync::Arc<std::sync::Mutex<Option<std::process::Child>>>, Documents::US21>
        {
            Func1::new(
                move |v: std::sync::Arc<std::sync::Mutex<Option<std::process::Child>>>| {
                    Documents::closure43((), v)
                },
            )
        }
        pub fn closure44(unitVar: (), v0_1: std::string::String) -> Documents::US21 {
            Documents::US21::US21_1(v0_1)
        }
        pub fn method66() -> Func1<std::string::String, Documents::US21> {
            Func1::new(move |v: std::string::String| Documents::closure44((), v))
        }
        pub fn closure46(unitVar: (), unitVar_1: ()) -> string {
            string("runtime.execute_with_options / child error")
        }
        pub fn closure45(v0_1: std::string::String, unitVar: ()) {
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
                Option<i64>,
            ) = getValue(Documents::State::trace_state().get().clone());
            let v32: () = {
                v2();
                ()
            };
            let patternInput_1: (
                LrcPtr<Documents::Mut0>,
                LrcPtr<Documents::Mut1>,
                LrcPtr<Documents::Mut2>,
                LrcPtr<Documents::Mut3>,
                Option<i64>,
            ) = getValue(Documents::State::trace_state().get().clone());
            let v60: Documents::US0 = (patternInput_1.3.clone()).l0.get().clone();
            if if (patternInput_1.2.clone()).l0.get().clone() == false {
                false
            } else {
                4_i32
                    >= find(
                        v60,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Documents::US0::US0_0, 0_i32)),
                            LrcPtr::new((Documents::US0::US0_1, 1_i32)),
                            LrcPtr::new((Documents::US0::US0_2, 2_i32)),
                            LrcPtr::new((Documents::US0::US0_3, 3_i32)),
                            LrcPtr::new((Documents::US0::US0_4, 4_i32)),
                        ])))),
                    )
            } {
                let v68: () = {
                    Documents::closure8(patternInput.0.clone(), ());
                    ()
                };
                let v72: () = {
                    v2();
                    ()
                };
                let patternInput_2: (
                    LrcPtr<Documents::Mut0>,
                    LrcPtr<Documents::Mut1>,
                    LrcPtr<Documents::Mut2>,
                    LrcPtr<Documents::Mut3>,
                    Option<i64>,
                ) = getValue(Documents::State::trace_state().get().clone());
                let _v101: LrcPtr<MutCell<Option<Documents::US3>>> =
                    refCell(None::<Documents::US3>);
                let v106: () = {
                    Documents::closure10(
                        patternInput_2.4.clone(),
                        Func1::new({
                            let _v101 = _v101.clone();
                            move |v: Option<Documents::US3>| Documents::closure9(_v101.clone(), v)
                        }),
                        (),
                    );
                    ()
                };
                let v121: Documents::US3 = defaultValue(Documents::US3::US3_1, _v101.get().clone());
                let v161: DateTime = match &v121 {
                    Documents::US3::US3_0(v121_0_0) => {
                        let v135: TimeSpan = TimeSpan::new_ticks(
                            {
                                let _arg: DateTime = DateTime::now();
                                _arg.ticks()
                            } - match &v121 {
                                Documents::US3::US3_0(x) => x.clone(),
                                _ => unreachable!(),
                            },
                        );
                        DateTime::new_ymdhms_milli(
                            1_i32,
                            1_i32,
                            1_i32,
                            v135.hours(),
                            v135.minutes(),
                            v135.seconds(),
                            v135.milliseconds(),
                        )
                    }
                    _ => DateTime::now(),
                };
                let v166: string = {
                    let provider: string = Documents::method6();
                    v161.toString(provider)
                };
                let v554: string = Documents::method8();
                let v566: LrcPtr<Documents::Mut4> = LrcPtr::new(Documents::Mut4 {
                    l0: MutCell::new(Documents::method10()),
                });
                let v577: () = {
                    Documents::closure11(
                        v566.clone(),
                        sprintf!("{}", sprintf!("{:?}", Documents::US0::US0_0)),
                        (),
                    );
                    ()
                };
                let v581: Array<string> = split(v566.l0.get().clone(), v554, -1_i32, 0_i32);
                let v584: string = v581[0_i32].clone();
                let v588: LrcPtr<Documents::Mut4> = LrcPtr::new(Documents::Mut4 {
                    l0: MutCell::new(Documents::method10()),
                });
                let v599: () = {
                    Documents::closure11(
                        v588.clone(),
                        sprintf!("{}", sprintf!("{:?}", Documents::US0::US0_4)),
                        (),
                    );
                    ()
                };
                let v609: Documents::US1 = if startsWith(v588.l0.get().clone(), v584, false) {
                    Documents::US1::US1_0(string("Verbose"))
                } else {
                    Documents::US1::US1_1
                };
                let v798: Documents::US1 = match &v609 {
                    Documents::US1::US1_0(v609_0_0) => Documents::US1::US1_0(match &v609 {
                        Documents::US1::US1_0(x) => x.clone(),
                        _ => unreachable!(),
                    }),
                    _ => {
                        let v613: string = Documents::method8();
                        let v625: LrcPtr<Documents::Mut4> = LrcPtr::new(Documents::Mut4 {
                            l0: MutCell::new(Documents::method10()),
                        });
                        let v636: () = {
                            Documents::closure11(
                                v625.clone(),
                                sprintf!("{}", sprintf!("{:?}", Documents::US0::US0_1)),
                                (),
                            );
                            ()
                        };
                        let v640: Array<string> = split(v625.l0.get().clone(), v613, -1_i32, 0_i32);
                        let v643: string = v640[0_i32].clone();
                        let v647: LrcPtr<Documents::Mut4> = LrcPtr::new(Documents::Mut4 {
                            l0: MutCell::new(Documents::method10()),
                        });
                        let v658: () = {
                            Documents::closure11(
                                v647.clone(),
                                sprintf!("{}", sprintf!("{:?}", Documents::US0::US0_4)),
                                (),
                            );
                            ()
                        };
                        let v668: Documents::US1 = if startsWith(v647.l0.get().clone(), v643, false)
                        {
                            Documents::US1::US1_0(string("Debug"))
                        } else {
                            Documents::US1::US1_1
                        };
                        match &v668 {
                            Documents::US1::US1_0(v668_0_0) => Documents::US1::US1_0(match &v668 {
                                Documents::US1::US1_0(x) => x.clone(),
                                _ => unreachable!(),
                            }),
                            _ => {
                                let v672: string = Documents::method8();
                                let v684: LrcPtr<Documents::Mut4> = LrcPtr::new(Documents::Mut4 {
                                    l0: MutCell::new(Documents::method10()),
                                });
                                let v695: () = {
                                    Documents::closure11(
                                        v684.clone(),
                                        sprintf!("{}", sprintf!("{:?}", Documents::US0::US0_2)),
                                        (),
                                    );
                                    ()
                                };
                                let v699: Array<string> =
                                    split(v684.l0.get().clone(), v672, -1_i32, 0_i32);
                                let v702: string = v699[0_i32].clone();
                                let v706: LrcPtr<Documents::Mut4> = LrcPtr::new(Documents::Mut4 {
                                    l0: MutCell::new(Documents::method10()),
                                });
                                let v717: () = {
                                    Documents::closure11(
                                        v706.clone(),
                                        sprintf!("{}", sprintf!("{:?}", Documents::US0::US0_4)),
                                        (),
                                    );
                                    ()
                                };
                                let v727: Documents::US1 =
                                    if startsWith(v706.l0.get().clone(), v702, false) {
                                        Documents::US1::US1_0(string("Info"))
                                    } else {
                                        Documents::US1::US1_1
                                    };
                                match &v727 {
                                    Documents::US1::US1_0(v727_0_0) => {
                                        Documents::US1::US1_0(match &v727 {
                                            Documents::US1::US1_0(x) => x.clone(),
                                            _ => unreachable!(),
                                        })
                                    }
                                    _ => {
                                        let v731: string = Documents::method8();
                                        let v743: LrcPtr<Documents::Mut4> =
                                            LrcPtr::new(Documents::Mut4 {
                                                l0: MutCell::new(Documents::method10()),
                                            });
                                        let v754: () = {
                                            Documents::closure11(
                                                v743.clone(),
                                                sprintf!(
                                                    "{}",
                                                    sprintf!("{:?}", Documents::US0::US0_3)
                                                ),
                                                (),
                                            );
                                            ()
                                        };
                                        let v758: Array<string> =
                                            split(v743.l0.get().clone(), v731, -1_i32, 0_i32);
                                        let v761: string = v758[0_i32].clone();
                                        let v765: LrcPtr<Documents::Mut4> =
                                            LrcPtr::new(Documents::Mut4 {
                                                l0: MutCell::new(Documents::method10()),
                                            });
                                        let v776: () = {
                                            Documents::closure11(
                                                v765.clone(),
                                                sprintf!(
                                                    "{}",
                                                    sprintf!("{:?}", Documents::US0::US0_4)
                                                ),
                                                (),
                                            );
                                            ()
                                        };
                                        let v786: Documents::US1 =
                                            if startsWith(v765.l0.get().clone(), v761, false) {
                                                Documents::US1::US1_0(string("Warning"))
                                            } else {
                                                Documents::US1::US1_1
                                            };
                                        match &v786 {
                                            Documents::US1::US1_0(v786_0_0) => {
                                                Documents::US1::US1_0(match &v786 {
                                                    Documents::US1::US1_0(x) => x.clone(),
                                                    _ => unreachable!(),
                                                })
                                            }
                                            _ => Documents::US1::US1_0(string("Critical")),
                                        }
                                    }
                                }
                            }
                        }
                    }
                };
                let v807: string = padLeft(
                    toLower(match &v798 {
                        Documents::US1::US1_0(v798_0_0) => match &v798 {
                            Documents::US1::US1_0(x) => x.clone(),
                            _ => unreachable!(),
                        },
                        _ => panic!("{}", string("Option does not have a value."),),
                    }),
                    7_i32,
                    ' ',
                );
                let v823: &str = inline_colorization::color_bright_red;
                let v825: &str = &*v807;
                let v827: &str = inline_colorization::color_reset;
                let v829: string = string("format!(\"{v823}{v825}{v827}\")");
                let v830: std::string::String = format!("{v823}{v825}{v827}");
                let v832: string = fable_library_rust::String_::fromString(v830);
                let v873: i64 = (patternInput_2.0.clone()).l0.get().clone();
                let v875: LrcPtr<Documents::Mut4> = LrcPtr::new(Documents::Mut4 {
                    l0: MutCell::new(Documents::method10()),
                });
                let v882: () = {
                    Documents::closure11(v875.clone(), sprintf!("{}", string("{ ")), ());
                    ()
                };
                let v891: () = {
                    Documents::closure11(v875.clone(), sprintf!("{}", string("error")), ());
                    ()
                };
                let v900: () = {
                    Documents::closure11(v875.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v905: std::string::String = format!("{:#?}", v0_1);
                let v935: () = {
                    Documents::closure11(
                        v875.clone(),
                        sprintf!("{}", fable_library_rust::String_::fromString(v905)),
                        (),
                    );
                    ()
                };
                let v944: () = {
                    Documents::closure11(v875.clone(), sprintf!("{}", string(" }")), ());
                    ()
                };
                let v947: string = v875.l0.get().clone();
                let v986: string = trimEndChars(
                    trimStartChars(
                        sprintf!(
                            "{} {} #{} {} / {}",
                            v166,
                            v832,
                            v873,
                            Documents::closure46((), ()),
                            v947
                        ),
                        toArray(empty::<char>()),
                    ),
                    toArray(ofArray(new_array(&[' ', '/']))),
                );
                println!("{}", v986.clone());
                ();
                ((patternInput.1.clone()).l0.get().clone())(v986)
            }
        }
        pub fn closure47(unitVar: (), v0_1: std::string::String) -> Documents::US23 {
            Documents::US23::US23_0(v0_1)
        }
        pub fn method67() -> Func1<std::string::String, Documents::US23> {
            Func1::new(move |v: std::string::String| Documents::closure47((), v))
        }
        pub fn closure48(unitVar: (), v0_1: std::string::String) -> Documents::US23 {
            Documents::US23::US23_1(v0_1)
        }
        pub fn method68() -> Func1<std::string::String, Documents::US23> {
            Func1::new(move |v: std::string::String| Documents::closure48((), v))
        }
        pub fn closure50(unitVar: (), unitVar_1: ()) -> string {
            string("runtime.stdio_line")
        }
        pub fn closure49(v0_1: std::string::String, unitVar: ()) {
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
                Option<i64>,
            ) = getValue(Documents::State::trace_state().get().clone());
            let v32: () = {
                v2();
                ()
            };
            let patternInput_1: (
                LrcPtr<Documents::Mut0>,
                LrcPtr<Documents::Mut1>,
                LrcPtr<Documents::Mut2>,
                LrcPtr<Documents::Mut3>,
                Option<i64>,
            ) = getValue(Documents::State::trace_state().get().clone());
            let v60: Documents::US0 = (patternInput_1.3.clone()).l0.get().clone();
            if if (patternInput_1.2.clone()).l0.get().clone() == false {
                false
            } else {
                4_i32
                    >= find(
                        v60,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Documents::US0::US0_0, 0_i32)),
                            LrcPtr::new((Documents::US0::US0_1, 1_i32)),
                            LrcPtr::new((Documents::US0::US0_2, 2_i32)),
                            LrcPtr::new((Documents::US0::US0_3, 3_i32)),
                            LrcPtr::new((Documents::US0::US0_4, 4_i32)),
                        ])))),
                    )
            } {
                let v68: () = {
                    Documents::closure8(patternInput.0.clone(), ());
                    ()
                };
                let v72: () = {
                    v2();
                    ()
                };
                let patternInput_2: (
                    LrcPtr<Documents::Mut0>,
                    LrcPtr<Documents::Mut1>,
                    LrcPtr<Documents::Mut2>,
                    LrcPtr<Documents::Mut3>,
                    Option<i64>,
                ) = getValue(Documents::State::trace_state().get().clone());
                let _v101: LrcPtr<MutCell<Option<Documents::US3>>> =
                    refCell(None::<Documents::US3>);
                let v106: () = {
                    Documents::closure10(
                        patternInput_2.4.clone(),
                        Func1::new({
                            let _v101 = _v101.clone();
                            move |v: Option<Documents::US3>| Documents::closure9(_v101.clone(), v)
                        }),
                        (),
                    );
                    ()
                };
                let v121: Documents::US3 = defaultValue(Documents::US3::US3_1, _v101.get().clone());
                let v161: DateTime = match &v121 {
                    Documents::US3::US3_0(v121_0_0) => {
                        let v135: TimeSpan = TimeSpan::new_ticks(
                            {
                                let _arg: DateTime = DateTime::now();
                                _arg.ticks()
                            } - match &v121 {
                                Documents::US3::US3_0(x) => x.clone(),
                                _ => unreachable!(),
                            },
                        );
                        DateTime::new_ymdhms_milli(
                            1_i32,
                            1_i32,
                            1_i32,
                            v135.hours(),
                            v135.minutes(),
                            v135.seconds(),
                            v135.milliseconds(),
                        )
                    }
                    _ => DateTime::now(),
                };
                let v166: string = {
                    let provider: string = Documents::method6();
                    v161.toString(provider)
                };
                let v554: string = Documents::method8();
                let v566: LrcPtr<Documents::Mut4> = LrcPtr::new(Documents::Mut4 {
                    l0: MutCell::new(Documents::method10()),
                });
                let v577: () = {
                    Documents::closure11(
                        v566.clone(),
                        sprintf!("{}", sprintf!("{:?}", Documents::US0::US0_0)),
                        (),
                    );
                    ()
                };
                let v581: Array<string> = split(v566.l0.get().clone(), v554, -1_i32, 0_i32);
                let v584: string = v581[0_i32].clone();
                let v588: LrcPtr<Documents::Mut4> = LrcPtr::new(Documents::Mut4 {
                    l0: MutCell::new(Documents::method10()),
                });
                let v599: () = {
                    Documents::closure11(
                        v588.clone(),
                        sprintf!("{}", sprintf!("{:?}", Documents::US0::US0_4)),
                        (),
                    );
                    ()
                };
                let v609: Documents::US1 = if startsWith(v588.l0.get().clone(), v584, false) {
                    Documents::US1::US1_0(string("Verbose"))
                } else {
                    Documents::US1::US1_1
                };
                let v798: Documents::US1 = match &v609 {
                    Documents::US1::US1_0(v609_0_0) => Documents::US1::US1_0(match &v609 {
                        Documents::US1::US1_0(x) => x.clone(),
                        _ => unreachable!(),
                    }),
                    _ => {
                        let v613: string = Documents::method8();
                        let v625: LrcPtr<Documents::Mut4> = LrcPtr::new(Documents::Mut4 {
                            l0: MutCell::new(Documents::method10()),
                        });
                        let v636: () = {
                            Documents::closure11(
                                v625.clone(),
                                sprintf!("{}", sprintf!("{:?}", Documents::US0::US0_1)),
                                (),
                            );
                            ()
                        };
                        let v640: Array<string> = split(v625.l0.get().clone(), v613, -1_i32, 0_i32);
                        let v643: string = v640[0_i32].clone();
                        let v647: LrcPtr<Documents::Mut4> = LrcPtr::new(Documents::Mut4 {
                            l0: MutCell::new(Documents::method10()),
                        });
                        let v658: () = {
                            Documents::closure11(
                                v647.clone(),
                                sprintf!("{}", sprintf!("{:?}", Documents::US0::US0_4)),
                                (),
                            );
                            ()
                        };
                        let v668: Documents::US1 = if startsWith(v647.l0.get().clone(), v643, false)
                        {
                            Documents::US1::US1_0(string("Debug"))
                        } else {
                            Documents::US1::US1_1
                        };
                        match &v668 {
                            Documents::US1::US1_0(v668_0_0) => Documents::US1::US1_0(match &v668 {
                                Documents::US1::US1_0(x) => x.clone(),
                                _ => unreachable!(),
                            }),
                            _ => {
                                let v672: string = Documents::method8();
                                let v684: LrcPtr<Documents::Mut4> = LrcPtr::new(Documents::Mut4 {
                                    l0: MutCell::new(Documents::method10()),
                                });
                                let v695: () = {
                                    Documents::closure11(
                                        v684.clone(),
                                        sprintf!("{}", sprintf!("{:?}", Documents::US0::US0_2)),
                                        (),
                                    );
                                    ()
                                };
                                let v699: Array<string> =
                                    split(v684.l0.get().clone(), v672, -1_i32, 0_i32);
                                let v702: string = v699[0_i32].clone();
                                let v706: LrcPtr<Documents::Mut4> = LrcPtr::new(Documents::Mut4 {
                                    l0: MutCell::new(Documents::method10()),
                                });
                                let v717: () = {
                                    Documents::closure11(
                                        v706.clone(),
                                        sprintf!("{}", sprintf!("{:?}", Documents::US0::US0_4)),
                                        (),
                                    );
                                    ()
                                };
                                let v727: Documents::US1 =
                                    if startsWith(v706.l0.get().clone(), v702, false) {
                                        Documents::US1::US1_0(string("Info"))
                                    } else {
                                        Documents::US1::US1_1
                                    };
                                match &v727 {
                                    Documents::US1::US1_0(v727_0_0) => {
                                        Documents::US1::US1_0(match &v727 {
                                            Documents::US1::US1_0(x) => x.clone(),
                                            _ => unreachable!(),
                                        })
                                    }
                                    _ => {
                                        let v731: string = Documents::method8();
                                        let v743: LrcPtr<Documents::Mut4> =
                                            LrcPtr::new(Documents::Mut4 {
                                                l0: MutCell::new(Documents::method10()),
                                            });
                                        let v754: () = {
                                            Documents::closure11(
                                                v743.clone(),
                                                sprintf!(
                                                    "{}",
                                                    sprintf!("{:?}", Documents::US0::US0_3)
                                                ),
                                                (),
                                            );
                                            ()
                                        };
                                        let v758: Array<string> =
                                            split(v743.l0.get().clone(), v731, -1_i32, 0_i32);
                                        let v761: string = v758[0_i32].clone();
                                        let v765: LrcPtr<Documents::Mut4> =
                                            LrcPtr::new(Documents::Mut4 {
                                                l0: MutCell::new(Documents::method10()),
                                            });
                                        let v776: () = {
                                            Documents::closure11(
                                                v765.clone(),
                                                sprintf!(
                                                    "{}",
                                                    sprintf!("{:?}", Documents::US0::US0_4)
                                                ),
                                                (),
                                            );
                                            ()
                                        };
                                        let v786: Documents::US1 =
                                            if startsWith(v765.l0.get().clone(), v761, false) {
                                                Documents::US1::US1_0(string("Warning"))
                                            } else {
                                                Documents::US1::US1_1
                                            };
                                        match &v786 {
                                            Documents::US1::US1_0(v786_0_0) => {
                                                Documents::US1::US1_0(match &v786 {
                                                    Documents::US1::US1_0(x) => x.clone(),
                                                    _ => unreachable!(),
                                                })
                                            }
                                            _ => Documents::US1::US1_0(string("Critical")),
                                        }
                                    }
                                }
                            }
                        }
                    }
                };
                let v807: string = padLeft(
                    toLower(match &v798 {
                        Documents::US1::US1_0(v798_0_0) => match &v798 {
                            Documents::US1::US1_0(x) => x.clone(),
                            _ => unreachable!(),
                        },
                        _ => panic!("{}", string("Option does not have a value."),),
                    }),
                    7_i32,
                    ' ',
                );
                let v823: &str = inline_colorization::color_bright_red;
                let v825: &str = &*v807;
                let v827: &str = inline_colorization::color_reset;
                let v829: string = string("format!(\"{v823}{v825}{v827}\")");
                let v830: std::string::String = format!("{v823}{v825}{v827}");
                let v832: string = fable_library_rust::String_::fromString(v830);
                let v873: i64 = (patternInput_2.0.clone()).l0.get().clone();
                let v875: LrcPtr<Documents::Mut4> = LrcPtr::new(Documents::Mut4 {
                    l0: MutCell::new(Documents::method10()),
                });
                let v882: () = {
                    Documents::closure11(v875.clone(), sprintf!("{}", string("{ ")), ());
                    ()
                };
                let v891: () = {
                    Documents::closure11(v875.clone(), sprintf!("{}", string("e")), ());
                    ()
                };
                let v900: () = {
                    Documents::closure11(v875.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v905: std::string::String = format!("{:#?}", v0_1);
                let v935: () = {
                    Documents::closure11(
                        v875.clone(),
                        sprintf!("{}", fable_library_rust::String_::fromString(v905)),
                        (),
                    );
                    ()
                };
                let v944: () = {
                    Documents::closure11(v875.clone(), sprintf!("{}", string(" }")), ());
                    ()
                };
                let v947: string = v875.l0.get().clone();
                let v986: string = trimEndChars(
                    trimStartChars(
                        sprintf!(
                            "{} {} #{} {} / {}",
                            v166,
                            v832,
                            v873,
                            Documents::closure50((), ()),
                            v947
                        ),
                        toArray(empty::<char>()),
                    ),
                    toArray(ofArray(new_array(&[' ', '/']))),
                );
                println!("{}", v986.clone());
                ();
                ((patternInput.1.clone()).l0.get().clone())(v986)
            }
        }
        pub fn closure52(v0_1: string, unitVar: ()) -> string {
            v0_1
        }
        pub fn closure51(v0_1: string, unitVar: ()) {
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
                Option<i64>,
            ) = getValue(Documents::State::trace_state().get().clone());
            let v32: () = {
                v2();
                ()
            };
            let patternInput_1: (
                LrcPtr<Documents::Mut0>,
                LrcPtr<Documents::Mut1>,
                LrcPtr<Documents::Mut2>,
                LrcPtr<Documents::Mut3>,
                Option<i64>,
            ) = getValue(Documents::State::trace_state().get().clone());
            let v60: Documents::US0 = (patternInput_1.3.clone()).l0.get().clone();
            if if (patternInput_1.2.clone()).l0.get().clone() == false {
                false
            } else {
                0_i32
                    >= find(
                        v60,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Documents::US0::US0_0, 0_i32)),
                            LrcPtr::new((Documents::US0::US0_1, 1_i32)),
                            LrcPtr::new((Documents::US0::US0_2, 2_i32)),
                            LrcPtr::new((Documents::US0::US0_3, 3_i32)),
                            LrcPtr::new((Documents::US0::US0_4, 4_i32)),
                        ])))),
                    )
            } {
                let v68: () = {
                    Documents::closure8(patternInput.0.clone(), ());
                    ()
                };
                let v72: () = {
                    v2();
                    ()
                };
                let patternInput_2: (
                    LrcPtr<Documents::Mut0>,
                    LrcPtr<Documents::Mut1>,
                    LrcPtr<Documents::Mut2>,
                    LrcPtr<Documents::Mut3>,
                    Option<i64>,
                ) = getValue(Documents::State::trace_state().get().clone());
                let _v101: LrcPtr<MutCell<Option<Documents::US3>>> =
                    refCell(None::<Documents::US3>);
                let v106: () = {
                    Documents::closure10(
                        patternInput_2.4.clone(),
                        Func1::new({
                            let _v101 = _v101.clone();
                            move |v: Option<Documents::US3>| Documents::closure9(_v101.clone(), v)
                        }),
                        (),
                    );
                    ()
                };
                let v121: Documents::US3 = defaultValue(Documents::US3::US3_1, _v101.get().clone());
                let v161: DateTime = match &v121 {
                    Documents::US3::US3_0(v121_0_0) => {
                        let v135: TimeSpan = TimeSpan::new_ticks(
                            {
                                let _arg: DateTime = DateTime::now();
                                _arg.ticks()
                            } - match &v121 {
                                Documents::US3::US3_0(x) => x.clone(),
                                _ => unreachable!(),
                            },
                        );
                        DateTime::new_ymdhms_milli(
                            1_i32,
                            1_i32,
                            1_i32,
                            v135.hours(),
                            v135.minutes(),
                            v135.seconds(),
                            v135.milliseconds(),
                        )
                    }
                    _ => DateTime::now(),
                };
                let v166: string = {
                    let provider: string = Documents::method6();
                    v161.toString(provider)
                };
                let v558: string = padLeft(toLower(string("Verbose")), 7_i32, ' ');
                let v574: &str = inline_colorization::color_bright_black;
                let v576: &str = &*v558;
                let v578: &str = inline_colorization::color_reset;
                let v580: string = string("format!(\"{v574}{v576}{v578}\")");
                let v581: std::string::String = format!("{v574}{v576}{v578}");
                let v583: string = fable_library_rust::String_::fromString(v581);
                let v624: i64 = (patternInput_2.0.clone()).l0.get().clone();
                let v626: LrcPtr<Documents::Mut4> = LrcPtr::new(Documents::Mut4 {
                    l0: MutCell::new(Documents::method10()),
                });
                let v627: string = v626.l0.get().clone();
                let v666: string = trimEndChars(
                    trimStartChars(
                        sprintf!(
                            "{} {} #{} {} / {}",
                            v166,
                            v583,
                            v624,
                            Documents::closure52(v0_1, ()),
                            v627
                        ),
                        toArray(empty::<char>()),
                    ),
                    toArray(ofArray(new_array(&[' ', '/']))),
                );
                println!("{}", v666.clone());
                ();
                ((patternInput.1.clone()).l0.get().clone())(v666)
            }
        }
        pub fn closure53(
            unitVar: (),
            v0_1: std::sync::mpsc::SendError<std::string::String>,
        ) -> std::string::String {
            format!("{}", v0_1)
        }
        pub fn method69(
        ) -> Func1<std::sync::mpsc::SendError<std::string::String>, std::string::String> {
            Func1::new(move |v: std::sync::mpsc::SendError<std::string::String>| {
                Documents::closure53((), v)
            })
        }
        pub fn method70(v0_1: Result<(), string>) -> Result<(), string> {
            v0_1
        }
        pub fn closure54(
            v0_1: LrcPtr<MutCell<Option<Documents::US24>>>,
            v1_1: Option<Documents::US24>,
        ) -> LrcPtr<MutCell<Option<Documents::US24>>> {
            v0_1.set(v1_1);
            v0_1
        }
        pub fn closure55(
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
        pub fn closure56(
            v0_1: LrcPtr<MutCell<Option<Documents::US25>>>,
            v1_1: Option<Documents::US25>,
        ) -> LrcPtr<MutCell<Option<Documents::US25>>> {
            v0_1.set(v1_1);
            v0_1
        }
        pub fn closure57(
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
        pub fn closure58(unitVar: (), v0_1: std::process::Output) -> Documents::US26 {
            Documents::US26::US26_0(v0_1)
        }
        pub fn closure59(unitVar: (), v0_1: std::string::String) -> Documents::US26 {
            Documents::US26::US26_1(v0_1)
        }
        pub fn closure61(unitVar: (), unitVar_1: ()) -> string {
            string("runtime.execute_with_options / output error")
        }
        pub fn closure60(v0_1: std::string::String, unitVar: ()) {
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
                Option<i64>,
            ) = getValue(Documents::State::trace_state().get().clone());
            let v32: () = {
                v2();
                ()
            };
            let patternInput_1: (
                LrcPtr<Documents::Mut0>,
                LrcPtr<Documents::Mut1>,
                LrcPtr<Documents::Mut2>,
                LrcPtr<Documents::Mut3>,
                Option<i64>,
            ) = getValue(Documents::State::trace_state().get().clone());
            let v60: Documents::US0 = (patternInput_1.3.clone()).l0.get().clone();
            if if (patternInput_1.2.clone()).l0.get().clone() == false {
                false
            } else {
                4_i32
                    >= find(
                        v60,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Documents::US0::US0_0, 0_i32)),
                            LrcPtr::new((Documents::US0::US0_1, 1_i32)),
                            LrcPtr::new((Documents::US0::US0_2, 2_i32)),
                            LrcPtr::new((Documents::US0::US0_3, 3_i32)),
                            LrcPtr::new((Documents::US0::US0_4, 4_i32)),
                        ])))),
                    )
            } {
                let v68: () = {
                    Documents::closure8(patternInput.0.clone(), ());
                    ()
                };
                let v72: () = {
                    v2();
                    ()
                };
                let patternInput_2: (
                    LrcPtr<Documents::Mut0>,
                    LrcPtr<Documents::Mut1>,
                    LrcPtr<Documents::Mut2>,
                    LrcPtr<Documents::Mut3>,
                    Option<i64>,
                ) = getValue(Documents::State::trace_state().get().clone());
                let _v101: LrcPtr<MutCell<Option<Documents::US3>>> =
                    refCell(None::<Documents::US3>);
                let v106: () = {
                    Documents::closure10(
                        patternInput_2.4.clone(),
                        Func1::new({
                            let _v101 = _v101.clone();
                            move |v: Option<Documents::US3>| Documents::closure9(_v101.clone(), v)
                        }),
                        (),
                    );
                    ()
                };
                let v121: Documents::US3 = defaultValue(Documents::US3::US3_1, _v101.get().clone());
                let v161: DateTime = match &v121 {
                    Documents::US3::US3_0(v121_0_0) => {
                        let v135: TimeSpan = TimeSpan::new_ticks(
                            {
                                let _arg: DateTime = DateTime::now();
                                _arg.ticks()
                            } - match &v121 {
                                Documents::US3::US3_0(x) => x.clone(),
                                _ => unreachable!(),
                            },
                        );
                        DateTime::new_ymdhms_milli(
                            1_i32,
                            1_i32,
                            1_i32,
                            v135.hours(),
                            v135.minutes(),
                            v135.seconds(),
                            v135.milliseconds(),
                        )
                    }
                    _ => DateTime::now(),
                };
                let v166: string = {
                    let provider: string = Documents::method6();
                    v161.toString(provider)
                };
                let v554: string = Documents::method8();
                let v566: LrcPtr<Documents::Mut4> = LrcPtr::new(Documents::Mut4 {
                    l0: MutCell::new(Documents::method10()),
                });
                let v577: () = {
                    Documents::closure11(
                        v566.clone(),
                        sprintf!("{}", sprintf!("{:?}", Documents::US0::US0_0)),
                        (),
                    );
                    ()
                };
                let v581: Array<string> = split(v566.l0.get().clone(), v554, -1_i32, 0_i32);
                let v584: string = v581[0_i32].clone();
                let v588: LrcPtr<Documents::Mut4> = LrcPtr::new(Documents::Mut4 {
                    l0: MutCell::new(Documents::method10()),
                });
                let v599: () = {
                    Documents::closure11(
                        v588.clone(),
                        sprintf!("{}", sprintf!("{:?}", Documents::US0::US0_4)),
                        (),
                    );
                    ()
                };
                let v609: Documents::US1 = if startsWith(v588.l0.get().clone(), v584, false) {
                    Documents::US1::US1_0(string("Verbose"))
                } else {
                    Documents::US1::US1_1
                };
                let v798: Documents::US1 = match &v609 {
                    Documents::US1::US1_0(v609_0_0) => Documents::US1::US1_0(match &v609 {
                        Documents::US1::US1_0(x) => x.clone(),
                        _ => unreachable!(),
                    }),
                    _ => {
                        let v613: string = Documents::method8();
                        let v625: LrcPtr<Documents::Mut4> = LrcPtr::new(Documents::Mut4 {
                            l0: MutCell::new(Documents::method10()),
                        });
                        let v636: () = {
                            Documents::closure11(
                                v625.clone(),
                                sprintf!("{}", sprintf!("{:?}", Documents::US0::US0_1)),
                                (),
                            );
                            ()
                        };
                        let v640: Array<string> = split(v625.l0.get().clone(), v613, -1_i32, 0_i32);
                        let v643: string = v640[0_i32].clone();
                        let v647: LrcPtr<Documents::Mut4> = LrcPtr::new(Documents::Mut4 {
                            l0: MutCell::new(Documents::method10()),
                        });
                        let v658: () = {
                            Documents::closure11(
                                v647.clone(),
                                sprintf!("{}", sprintf!("{:?}", Documents::US0::US0_4)),
                                (),
                            );
                            ()
                        };
                        let v668: Documents::US1 = if startsWith(v647.l0.get().clone(), v643, false)
                        {
                            Documents::US1::US1_0(string("Debug"))
                        } else {
                            Documents::US1::US1_1
                        };
                        match &v668 {
                            Documents::US1::US1_0(v668_0_0) => Documents::US1::US1_0(match &v668 {
                                Documents::US1::US1_0(x) => x.clone(),
                                _ => unreachable!(),
                            }),
                            _ => {
                                let v672: string = Documents::method8();
                                let v684: LrcPtr<Documents::Mut4> = LrcPtr::new(Documents::Mut4 {
                                    l0: MutCell::new(Documents::method10()),
                                });
                                let v695: () = {
                                    Documents::closure11(
                                        v684.clone(),
                                        sprintf!("{}", sprintf!("{:?}", Documents::US0::US0_2)),
                                        (),
                                    );
                                    ()
                                };
                                let v699: Array<string> =
                                    split(v684.l0.get().clone(), v672, -1_i32, 0_i32);
                                let v702: string = v699[0_i32].clone();
                                let v706: LrcPtr<Documents::Mut4> = LrcPtr::new(Documents::Mut4 {
                                    l0: MutCell::new(Documents::method10()),
                                });
                                let v717: () = {
                                    Documents::closure11(
                                        v706.clone(),
                                        sprintf!("{}", sprintf!("{:?}", Documents::US0::US0_4)),
                                        (),
                                    );
                                    ()
                                };
                                let v727: Documents::US1 =
                                    if startsWith(v706.l0.get().clone(), v702, false) {
                                        Documents::US1::US1_0(string("Info"))
                                    } else {
                                        Documents::US1::US1_1
                                    };
                                match &v727 {
                                    Documents::US1::US1_0(v727_0_0) => {
                                        Documents::US1::US1_0(match &v727 {
                                            Documents::US1::US1_0(x) => x.clone(),
                                            _ => unreachable!(),
                                        })
                                    }
                                    _ => {
                                        let v731: string = Documents::method8();
                                        let v743: LrcPtr<Documents::Mut4> =
                                            LrcPtr::new(Documents::Mut4 {
                                                l0: MutCell::new(Documents::method10()),
                                            });
                                        let v754: () = {
                                            Documents::closure11(
                                                v743.clone(),
                                                sprintf!(
                                                    "{}",
                                                    sprintf!("{:?}", Documents::US0::US0_3)
                                                ),
                                                (),
                                            );
                                            ()
                                        };
                                        let v758: Array<string> =
                                            split(v743.l0.get().clone(), v731, -1_i32, 0_i32);
                                        let v761: string = v758[0_i32].clone();
                                        let v765: LrcPtr<Documents::Mut4> =
                                            LrcPtr::new(Documents::Mut4 {
                                                l0: MutCell::new(Documents::method10()),
                                            });
                                        let v776: () = {
                                            Documents::closure11(
                                                v765.clone(),
                                                sprintf!(
                                                    "{}",
                                                    sprintf!("{:?}", Documents::US0::US0_4)
                                                ),
                                                (),
                                            );
                                            ()
                                        };
                                        let v786: Documents::US1 =
                                            if startsWith(v765.l0.get().clone(), v761, false) {
                                                Documents::US1::US1_0(string("Warning"))
                                            } else {
                                                Documents::US1::US1_1
                                            };
                                        match &v786 {
                                            Documents::US1::US1_0(v786_0_0) => {
                                                Documents::US1::US1_0(match &v786 {
                                                    Documents::US1::US1_0(x) => x.clone(),
                                                    _ => unreachable!(),
                                                })
                                            }
                                            _ => Documents::US1::US1_0(string("Critical")),
                                        }
                                    }
                                }
                            }
                        }
                    }
                };
                let v807: string = padLeft(
                    toLower(match &v798 {
                        Documents::US1::US1_0(v798_0_0) => match &v798 {
                            Documents::US1::US1_0(x) => x.clone(),
                            _ => unreachable!(),
                        },
                        _ => panic!("{}", string("Option does not have a value."),),
                    }),
                    7_i32,
                    ' ',
                );
                let v823: &str = inline_colorization::color_bright_red;
                let v825: &str = &*v807;
                let v827: &str = inline_colorization::color_reset;
                let v829: string = string("format!(\"{v823}{v825}{v827}\")");
                let v830: std::string::String = format!("{v823}{v825}{v827}");
                let v832: string = fable_library_rust::String_::fromString(v830);
                let v873: i64 = (patternInput_2.0.clone()).l0.get().clone();
                let v875: LrcPtr<Documents::Mut4> = LrcPtr::new(Documents::Mut4 {
                    l0: MutCell::new(Documents::method10()),
                });
                let v882: () = {
                    Documents::closure11(v875.clone(), sprintf!("{}", string("{ ")), ());
                    ()
                };
                let v891: () = {
                    Documents::closure11(v875.clone(), sprintf!("{}", string("error")), ());
                    ()
                };
                let v900: () = {
                    Documents::closure11(v875.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v905: std::string::String = format!("{:#?}", v0_1);
                let v935: () = {
                    Documents::closure11(
                        v875.clone(),
                        sprintf!("{}", fable_library_rust::String_::fromString(v905)),
                        (),
                    );
                    ()
                };
                let v944: () = {
                    Documents::closure11(v875.clone(), sprintf!("{}", string(" }")), ());
                    ()
                };
                let v947: string = v875.l0.get().clone();
                let v986: string = trimEndChars(
                    trimStartChars(
                        sprintf!(
                            "{} {} #{} {} / {}",
                            v166,
                            v832,
                            v873,
                            Documents::closure61((), ()),
                            v947
                        ),
                        toArray(empty::<char>()),
                    ),
                    toArray(ofArray(new_array(&[' ', '/']))),
                );
                println!("{}", v986.clone());
                ();
                ((patternInput.1.clone()).l0.get().clone())(v986)
            }
        }
        pub fn closure62(
            v0_1: LrcPtr<MutCell<Option<Documents::US27>>>,
            v1_1: Option<Documents::US27>,
        ) -> LrcPtr<MutCell<Option<Documents::US27>>> {
            v0_1.set(v1_1);
            v0_1
        }
        pub fn closure63(
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
        pub fn closure65(unitVar: (), unitVar_1: ()) -> string {
            string("runtime.execute_with_options / result")
        }
        pub fn closure64(v0_1: i32, v1_1: string, unitVar: ()) {
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
                Option<i64>,
            ) = getValue(Documents::State::trace_state().get().clone());
            let v33: () = {
                v3();
                ()
            };
            let patternInput_1: (
                LrcPtr<Documents::Mut0>,
                LrcPtr<Documents::Mut1>,
                LrcPtr<Documents::Mut2>,
                LrcPtr<Documents::Mut3>,
                Option<i64>,
            ) = getValue(Documents::State::trace_state().get().clone());
            let v61: Documents::US0 = (patternInput_1.3.clone()).l0.get().clone();
            if if (patternInput_1.2.clone()).l0.get().clone() == false {
                false
            } else {
                0_i32
                    >= find(
                        v61,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Documents::US0::US0_0, 0_i32)),
                            LrcPtr::new((Documents::US0::US0_1, 1_i32)),
                            LrcPtr::new((Documents::US0::US0_2, 2_i32)),
                            LrcPtr::new((Documents::US0::US0_3, 3_i32)),
                            LrcPtr::new((Documents::US0::US0_4, 4_i32)),
                        ])))),
                    )
            } {
                let v69: () = {
                    Documents::closure8(patternInput.0.clone(), ());
                    ()
                };
                let v73: () = {
                    v3();
                    ()
                };
                let patternInput_2: (
                    LrcPtr<Documents::Mut0>,
                    LrcPtr<Documents::Mut1>,
                    LrcPtr<Documents::Mut2>,
                    LrcPtr<Documents::Mut3>,
                    Option<i64>,
                ) = getValue(Documents::State::trace_state().get().clone());
                let _v102: LrcPtr<MutCell<Option<Documents::US3>>> =
                    refCell(None::<Documents::US3>);
                let v107: () = {
                    Documents::closure10(
                        patternInput_2.4.clone(),
                        Func1::new({
                            let _v102 = _v102.clone();
                            move |v: Option<Documents::US3>| Documents::closure9(_v102.clone(), v)
                        }),
                        (),
                    );
                    ()
                };
                let v122: Documents::US3 = defaultValue(Documents::US3::US3_1, _v102.get().clone());
                let v162: DateTime = match &v122 {
                    Documents::US3::US3_0(v122_0_0) => {
                        let v136: TimeSpan = TimeSpan::new_ticks(
                            {
                                let _arg: DateTime = DateTime::now();
                                _arg.ticks()
                            } - match &v122 {
                                Documents::US3::US3_0(x) => x.clone(),
                                _ => unreachable!(),
                            },
                        );
                        DateTime::new_ymdhms_milli(
                            1_i32,
                            1_i32,
                            1_i32,
                            v136.hours(),
                            v136.minutes(),
                            v136.seconds(),
                            v136.milliseconds(),
                        )
                    }
                    _ => DateTime::now(),
                };
                let v167: string = {
                    let provider: string = Documents::method6();
                    v162.toString(provider)
                };
                let v559: string = padLeft(toLower(string("Verbose")), 7_i32, ' ');
                let v575: &str = inline_colorization::color_bright_black;
                let v577: &str = &*v559;
                let v579: &str = inline_colorization::color_reset;
                let v581: string = string("format!(\"{v575}{v577}{v579}\")");
                let v582: std::string::String = format!("{v575}{v577}{v579}");
                let v584: string = fable_library_rust::String_::fromString(v582);
                let v625: i64 = (patternInput_2.0.clone()).l0.get().clone();
                let v626: i32 = length(v1_1);
                let v628: LrcPtr<Documents::Mut4> = LrcPtr::new(Documents::Mut4 {
                    l0: MutCell::new(Documents::method10()),
                });
                let v635: () = {
                    Documents::closure11(v628.clone(), sprintf!("{}", string("{ ")), ());
                    ()
                };
                let v644: () = {
                    Documents::closure11(v628.clone(), sprintf!("{}", string("exit_code")), ());
                    ()
                };
                let v653: () = {
                    Documents::closure11(v628.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v661: () = {
                    Documents::closure11(v628.clone(), sprintf!("{}", v0_1), ());
                    ()
                };
                let v670: () = {
                    Documents::closure11(v628.clone(), sprintf!("{}", string("; ")), ());
                    ()
                };
                let v679: () = {
                    Documents::closure11(
                        v628.clone(),
                        sprintf!("{}", string("std_trace_length")),
                        (),
                    );
                    ()
                };
                let v687: () = {
                    Documents::closure11(v628.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v695: () = {
                    Documents::closure11(v628.clone(), sprintf!("{}", v626), ());
                    ()
                };
                let v704: () = {
                    Documents::closure11(v628.clone(), sprintf!("{}", string(" }")), ());
                    ()
                };
                let v707: string = v628.l0.get().clone();
                let v746: string = trimEndChars(
                    trimStartChars(
                        sprintf!(
                            "{} {} #{} {} / {}",
                            v167,
                            v584,
                            v625,
                            Documents::closure65((), ()),
                            v707
                        ),
                        toArray(empty::<char>()),
                    ),
                    toArray(ofArray(new_array(&[' ', '/']))),
                );
                println!("{}", v746.clone());
                ();
                ((patternInput.1.clone()).l0.get().clone())(v746)
            }
        }
        pub fn closure67(unitVar: (), unitVar_1: ()) -> string {
            string("runtime.execute_with_options_async")
        }
        pub fn closure66(
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
                Option<i64>,
            ) = getValue(Documents::State::trace_state().get().clone());
            let v38: () = {
                v8();
                ()
            };
            let patternInput_1: (
                LrcPtr<Documents::Mut0>,
                LrcPtr<Documents::Mut1>,
                LrcPtr<Documents::Mut2>,
                LrcPtr<Documents::Mut3>,
                Option<i64>,
            ) = getValue(Documents::State::trace_state().get().clone());
            let v66: Documents::US0 = (patternInput_1.3.clone()).l0.get().clone();
            if if (patternInput_1.2.clone()).l0.get().clone() == false {
                false
            } else {
                1_i32
                    >= find(
                        v66,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Documents::US0::US0_0, 0_i32)),
                            LrcPtr::new((Documents::US0::US0_1, 1_i32)),
                            LrcPtr::new((Documents::US0::US0_2, 2_i32)),
                            LrcPtr::new((Documents::US0::US0_3, 3_i32)),
                            LrcPtr::new((Documents::US0::US0_4, 4_i32)),
                        ])))),
                    )
            } {
                let v74: () = {
                    Documents::closure8(patternInput.0.clone(), ());
                    ()
                };
                let v78: () = {
                    v8();
                    ()
                };
                let patternInput_2: (
                    LrcPtr<Documents::Mut0>,
                    LrcPtr<Documents::Mut1>,
                    LrcPtr<Documents::Mut2>,
                    LrcPtr<Documents::Mut3>,
                    Option<i64>,
                ) = getValue(Documents::State::trace_state().get().clone());
                let _v107: LrcPtr<MutCell<Option<Documents::US3>>> =
                    refCell(None::<Documents::US3>);
                let v112: () = {
                    Documents::closure10(
                        patternInput_2.4.clone(),
                        Func1::new({
                            let _v107 = _v107.clone();
                            move |v: Option<Documents::US3>| Documents::closure9(_v107.clone(), v)
                        }),
                        (),
                    );
                    ()
                };
                let v127: Documents::US3 = defaultValue(Documents::US3::US3_1, _v107.get().clone());
                let v167: DateTime = match &v127 {
                    Documents::US3::US3_0(v127_0_0) => {
                        let v141: TimeSpan = TimeSpan::new_ticks(
                            {
                                let _arg: DateTime = DateTime::now();
                                _arg.ticks()
                            } - match &v127 {
                                Documents::US3::US3_0(x) => x.clone(),
                                _ => unreachable!(),
                            },
                        );
                        DateTime::new_ymdhms_milli(
                            1_i32,
                            1_i32,
                            1_i32,
                            v141.hours(),
                            v141.minutes(),
                            v141.seconds(),
                            v141.milliseconds(),
                        )
                    }
                    _ => DateTime::now(),
                };
                let v172: string = {
                    let provider: string = Documents::method6();
                    v167.toString(provider)
                };
                let v560: string = Documents::method8();
                let v572: LrcPtr<Documents::Mut4> = LrcPtr::new(Documents::Mut4 {
                    l0: MutCell::new(Documents::method10()),
                });
                let v583: () = {
                    Documents::closure11(
                        v572.clone(),
                        sprintf!("{}", sprintf!("{:?}", Documents::US0::US0_0)),
                        (),
                    );
                    ()
                };
                let v587: Array<string> = split(v572.l0.get().clone(), v560, -1_i32, 0_i32);
                let v590: string = v587[0_i32].clone();
                let v594: LrcPtr<Documents::Mut4> = LrcPtr::new(Documents::Mut4 {
                    l0: MutCell::new(Documents::method10()),
                });
                let v605: () = {
                    Documents::closure11(
                        v594.clone(),
                        sprintf!("{}", sprintf!("{:?}", Documents::US0::US0_1)),
                        (),
                    );
                    ()
                };
                let v615: Documents::US1 = if startsWith(v594.l0.get().clone(), v590, false) {
                    Documents::US1::US1_0(string("Verbose"))
                } else {
                    Documents::US1::US1_1
                };
                let v621: Documents::US1 = match &v615 {
                    Documents::US1::US1_0(v615_0_0) => Documents::US1::US1_0(match &v615 {
                        Documents::US1::US1_0(x) => x.clone(),
                        _ => unreachable!(),
                    }),
                    _ => Documents::US1::US1_0(string("Debug")),
                };
                let v630: string = padLeft(
                    toLower(match &v621 {
                        Documents::US1::US1_0(v621_0_0) => match &v621 {
                            Documents::US1::US1_0(x) => x.clone(),
                            _ => unreachable!(),
                        },
                        _ => panic!("{}", string("Option does not have a value."),),
                    }),
                    7_i32,
                    ' ',
                );
                let v646: &str = inline_colorization::color_bright_blue;
                let v648: &str = &*v630;
                let v650: &str = inline_colorization::color_reset;
                let v652: string = string("format!(\"{v646}{v648}{v650}\")");
                let v653: std::string::String = format!("{v646}{v648}{v650}");
                let v655: string = fable_library_rust::String_::fromString(v653);
                let v696: i64 = (patternInput_2.0.clone()).l0.get().clone();
                let v698: LrcPtr<Documents::Mut4> = LrcPtr::new(Documents::Mut4 {
                    l0: MutCell::new(Documents::method10()),
                });
                let v705: () = {
                    Documents::closure11(v698.clone(), sprintf!("{}", string("{ ")), ());
                    ()
                };
                let v714: () = {
                    Documents::closure11(v698.clone(), sprintf!("{}", string("options")), ());
                    ()
                };
                let v723: () = {
                    Documents::closure11(v698.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v731: () = {
                    Documents::closure11(v698.clone(), sprintf!("{}", string("{ ")), ());
                    ()
                };
                let v740: () = {
                    Documents::closure11(v698.clone(), sprintf!("{}", string("command")), ());
                    ()
                };
                let v748: () = {
                    Documents::closure11(v698.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v756: () = {
                    Documents::closure11(v698.clone(), sprintf!("{}", v0_1), ());
                    ()
                };
                let v765: () = {
                    Documents::closure11(v698.clone(), sprintf!("{}", string("; ")), ());
                    ()
                };
                let v774: () = {
                    Documents::closure11(
                        v698.clone(),
                        sprintf!("{}", string("cancellation_token")),
                        (),
                    );
                    ()
                };
                let v782: () = {
                    Documents::closure11(v698.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v787: std::string::String = format!("{:#?}", v1_1);
                let v817: () = {
                    Documents::closure11(
                        v698.clone(),
                        sprintf!("{}", fable_library_rust::String_::fromString(v787)),
                        (),
                    );
                    ()
                };
                let v825: () = {
                    Documents::closure11(v698.clone(), sprintf!("{}", string("; ")), ());
                    ()
                };
                let v834: () = {
                    Documents::closure11(
                        v698.clone(),
                        sprintf!("{}", string("environment_variables")),
                        (),
                    );
                    ()
                };
                let v842: () = {
                    Documents::closure11(v698.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v853: () = {
                    Documents::closure11(v698.clone(), sprintf!("{}", sprintf!("{:?}", v2)), ());
                    ()
                };
                let v861: () = {
                    Documents::closure11(v698.clone(), sprintf!("{}", string("; ")), ());
                    ()
                };
                let v870: () = {
                    Documents::closure11(v698.clone(), sprintf!("{}", string("on_line")), ());
                    ()
                };
                let v878: () = {
                    Documents::closure11(v698.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v883: std::string::String = format!("{:#?}", v3);
                let v913: () = {
                    Documents::closure11(
                        v698.clone(),
                        sprintf!("{}", fable_library_rust::String_::fromString(v883)),
                        (),
                    );
                    ()
                };
                let v921: () = {
                    Documents::closure11(v698.clone(), sprintf!("{}", string("; ")), ());
                    ()
                };
                let v930: () = {
                    Documents::closure11(v698.clone(), sprintf!("{}", string("stdin")), ());
                    ()
                };
                let v938: () = {
                    Documents::closure11(v698.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v943: std::string::String = format!("{:#?}", v4);
                let v973: () = {
                    Documents::closure11(
                        v698.clone(),
                        sprintf!("{}", fable_library_rust::String_::fromString(v943)),
                        (),
                    );
                    ()
                };
                let v981: () = {
                    Documents::closure11(v698.clone(), sprintf!("{}", string("; ")), ());
                    ()
                };
                let v990: () = {
                    Documents::closure11(v698.clone(), sprintf!("{}", string("trace")), ());
                    ()
                };
                let v998: () = {
                    Documents::closure11(v698.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v1009: () = {
                    Documents::closure11(
                        v698.clone(),
                        sprintf!("{}", if v5 { string("true") } else { string("false") }),
                        (),
                    );
                    ()
                };
                let v1017: () = {
                    Documents::closure11(v698.clone(), sprintf!("{}", string("; ")), ());
                    ()
                };
                let v1026: () = {
                    Documents::closure11(
                        v698.clone(),
                        sprintf!("{}", string("working_directory")),
                        (),
                    );
                    ()
                };
                let v1034: () = {
                    Documents::closure11(v698.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v1039: std::string::String = format!("{:#?}", v6);
                let v1069: () = {
                    Documents::closure11(
                        v698.clone(),
                        sprintf!("{}", fable_library_rust::String_::fromString(v1039)),
                        (),
                    );
                    ()
                };
                let v1078: () = {
                    Documents::closure11(v698.clone(), sprintf!("{}", string(" }")), ());
                    ()
                };
                let v1086: () = {
                    Documents::closure11(v698.clone(), sprintf!("{}", string(" }")), ());
                    ()
                };
                let v1089: string = v698.l0.get().clone();
                let v1128: string = trimEndChars(
                    trimStartChars(
                        sprintf!(
                            "{} {} #{} {} / {}",
                            v172,
                            v655,
                            v696,
                            Documents::closure67((), ()),
                            v1089
                        ),
                        toArray(empty::<char>()),
                    ),
                    toArray(ofArray(new_array(&[' ', '/']))),
                );
                println!("{}", v1128.clone());
                ();
                ((patternInput.1.clone()).l0.get().clone())(v1128)
            }
        }
        pub fn closure69(
            v0_1: LrcPtr<MutCell<Option<Documents::US28>>>,
            v1_1: Option<Documents::US28>,
        ) -> LrcPtr<MutCell<Option<Documents::US28>>> {
            v0_1.set(v1_1);
            v0_1
        }
        pub fn closure70(
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
        pub fn closure72(v0_1: string, unitVar: ()) -> string {
            v0_1
        }
        pub fn closure71(v0_1: string, unitVar: ()) {
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
                Option<i64>,
            ) = getValue(Documents::State::trace_state().get().clone());
            let v32: () = {
                v2();
                ()
            };
            let patternInput_1: (
                LrcPtr<Documents::Mut0>,
                LrcPtr<Documents::Mut1>,
                LrcPtr<Documents::Mut2>,
                LrcPtr<Documents::Mut3>,
                Option<i64>,
            ) = getValue(Documents::State::trace_state().get().clone());
            let v60: Documents::US0 = (patternInput_1.3.clone()).l0.get().clone();
            if if (patternInput_1.2.clone()).l0.get().clone() == false {
                false
            } else {
                0_i32
                    >= find(
                        v60,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Documents::US0::US0_0, 0_i32)),
                            LrcPtr::new((Documents::US0::US0_1, 1_i32)),
                            LrcPtr::new((Documents::US0::US0_2, 2_i32)),
                            LrcPtr::new((Documents::US0::US0_3, 3_i32)),
                            LrcPtr::new((Documents::US0::US0_4, 4_i32)),
                        ])))),
                    )
            } {
                let v68: () = {
                    Documents::closure8(patternInput.0.clone(), ());
                    ()
                };
                let v72: () = {
                    v2();
                    ()
                };
                let patternInput_2: (
                    LrcPtr<Documents::Mut0>,
                    LrcPtr<Documents::Mut1>,
                    LrcPtr<Documents::Mut2>,
                    LrcPtr<Documents::Mut3>,
                    Option<i64>,
                ) = getValue(Documents::State::trace_state().get().clone());
                let _v101: LrcPtr<MutCell<Option<Documents::US3>>> =
                    refCell(None::<Documents::US3>);
                let v106: () = {
                    Documents::closure10(
                        patternInput_2.4.clone(),
                        Func1::new({
                            let _v101 = _v101.clone();
                            move |v: Option<Documents::US3>| Documents::closure9(_v101.clone(), v)
                        }),
                        (),
                    );
                    ()
                };
                let v121: Documents::US3 = defaultValue(Documents::US3::US3_1, _v101.get().clone());
                let v161: DateTime = match &v121 {
                    Documents::US3::US3_0(v121_0_0) => {
                        let v135: TimeSpan = TimeSpan::new_ticks(
                            {
                                let _arg: DateTime = DateTime::now();
                                _arg.ticks()
                            } - match &v121 {
                                Documents::US3::US3_0(x) => x.clone(),
                                _ => unreachable!(),
                            },
                        );
                        DateTime::new_ymdhms_milli(
                            1_i32,
                            1_i32,
                            1_i32,
                            v135.hours(),
                            v135.minutes(),
                            v135.seconds(),
                            v135.milliseconds(),
                        )
                    }
                    _ => DateTime::now(),
                };
                let v166: string = {
                    let provider: string = Documents::method6();
                    v161.toString(provider)
                };
                let v558: string = padLeft(toLower(string("Verbose")), 7_i32, ' ');
                let v574: &str = inline_colorization::color_bright_black;
                let v576: &str = &*v558;
                let v578: &str = inline_colorization::color_reset;
                let v580: string = string("format!(\"{v574}{v576}{v578}\")");
                let v581: std::string::String = format!("{v574}{v576}{v578}");
                let v583: string = fable_library_rust::String_::fromString(v581);
                let v624: i64 = (patternInput_2.0.clone()).l0.get().clone();
                let v626: LrcPtr<Documents::Mut4> = LrcPtr::new(Documents::Mut4 {
                    l0: MutCell::new(Documents::method10()),
                });
                let v627: string = v626.l0.get().clone();
                let v666: string = trimEndChars(
                    trimStartChars(
                        sprintf!(
                            "{} {} #{} {} / {}",
                            v166,
                            v583,
                            v624,
                            Documents::closure72(v0_1, ()),
                            v627
                        ),
                        toArray(empty::<char>()),
                    ),
                    toArray(ofArray(new_array(&[' ', '/']))),
                );
                println!("{}", v666.clone());
                ();
                ((patternInput.1.clone()).l0.get().clone())(v666)
            }
        }
        pub fn closure68(
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
        pub fn closure73(
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
        pub fn closure74(
            v0_1: LrcPtr<MutCell<Option<Documents::US29>>>,
            v1_1: Option<Documents::US29>,
        ) -> LrcPtr<MutCell<Option<Documents::US29>>> {
            v0_1.set(v1_1);
            v0_1
        }
        pub fn closure75(
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
        pub fn closure76(v0_1: (), unitVar: ()) {
            if unbox::<bool>(&defaultOf()) == false {
                ();
                ()
            };
        }
        pub fn closure78(unitVar: (), unitVar_1: ()) -> string {
            string("runtime.execute_with_options_async / WaitForExitAsync")
        }
        pub fn closure77(v0_1: LrcPtr<TaskCanceledException>, unitVar: ()) {
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
                Option<i64>,
            ) = getValue(Documents::State::trace_state().get().clone());
            let v32: () = {
                v2();
                ()
            };
            let patternInput_1: (
                LrcPtr<Documents::Mut0>,
                LrcPtr<Documents::Mut1>,
                LrcPtr<Documents::Mut2>,
                LrcPtr<Documents::Mut3>,
                Option<i64>,
            ) = getValue(Documents::State::trace_state().get().clone());
            let v60: Documents::US0 = (patternInput_1.3.clone()).l0.get().clone();
            if if (patternInput_1.2.clone()).l0.get().clone() == false {
                false
            } else {
                3_i32
                    >= find(
                        v60,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Documents::US0::US0_0, 0_i32)),
                            LrcPtr::new((Documents::US0::US0_1, 1_i32)),
                            LrcPtr::new((Documents::US0::US0_2, 2_i32)),
                            LrcPtr::new((Documents::US0::US0_3, 3_i32)),
                            LrcPtr::new((Documents::US0::US0_4, 4_i32)),
                        ])))),
                    )
            } {
                let v68: () = {
                    Documents::closure8(patternInput.0.clone(), ());
                    ()
                };
                let v72: () = {
                    v2();
                    ()
                };
                let patternInput_2: (
                    LrcPtr<Documents::Mut0>,
                    LrcPtr<Documents::Mut1>,
                    LrcPtr<Documents::Mut2>,
                    LrcPtr<Documents::Mut3>,
                    Option<i64>,
                ) = getValue(Documents::State::trace_state().get().clone());
                let _v101: LrcPtr<MutCell<Option<Documents::US3>>> =
                    refCell(None::<Documents::US3>);
                let v106: () = {
                    Documents::closure10(
                        patternInput_2.4.clone(),
                        Func1::new({
                            let _v101 = _v101.clone();
                            move |v: Option<Documents::US3>| Documents::closure9(_v101.clone(), v)
                        }),
                        (),
                    );
                    ()
                };
                let v121: Documents::US3 = defaultValue(Documents::US3::US3_1, _v101.get().clone());
                let v161: DateTime = match &v121 {
                    Documents::US3::US3_0(v121_0_0) => {
                        let v135: TimeSpan = TimeSpan::new_ticks(
                            {
                                let _arg: DateTime = DateTime::now();
                                _arg.ticks()
                            } - match &v121 {
                                Documents::US3::US3_0(x) => x.clone(),
                                _ => unreachable!(),
                            },
                        );
                        DateTime::new_ymdhms_milli(
                            1_i32,
                            1_i32,
                            1_i32,
                            v135.hours(),
                            v135.minutes(),
                            v135.seconds(),
                            v135.milliseconds(),
                        )
                    }
                    _ => DateTime::now(),
                };
                let v166: string = {
                    let provider: string = Documents::method6();
                    v161.toString(provider)
                };
                let v554: string = Documents::method8();
                let v566: LrcPtr<Documents::Mut4> = LrcPtr::new(Documents::Mut4 {
                    l0: MutCell::new(Documents::method10()),
                });
                let v577: () = {
                    Documents::closure11(
                        v566.clone(),
                        sprintf!("{}", sprintf!("{:?}", Documents::US0::US0_0)),
                        (),
                    );
                    ()
                };
                let v581: Array<string> = split(v566.l0.get().clone(), v554, -1_i32, 0_i32);
                let v584: string = v581[0_i32].clone();
                let v588: LrcPtr<Documents::Mut4> = LrcPtr::new(Documents::Mut4 {
                    l0: MutCell::new(Documents::method10()),
                });
                let v599: () = {
                    Documents::closure11(
                        v588.clone(),
                        sprintf!("{}", sprintf!("{:?}", Documents::US0::US0_3)),
                        (),
                    );
                    ()
                };
                let v609: Documents::US1 = if startsWith(v588.l0.get().clone(), v584, false) {
                    Documents::US1::US1_0(string("Verbose"))
                } else {
                    Documents::US1::US1_1
                };
                let v737: Documents::US1 = match &v609 {
                    Documents::US1::US1_0(v609_0_0) => Documents::US1::US1_0(match &v609 {
                        Documents::US1::US1_0(x) => x.clone(),
                        _ => unreachable!(),
                    }),
                    _ => {
                        let v613: string = Documents::method8();
                        let v625: LrcPtr<Documents::Mut4> = LrcPtr::new(Documents::Mut4 {
                            l0: MutCell::new(Documents::method10()),
                        });
                        let v636: () = {
                            Documents::closure11(
                                v625.clone(),
                                sprintf!("{}", sprintf!("{:?}", Documents::US0::US0_1)),
                                (),
                            );
                            ()
                        };
                        let v640: Array<string> = split(v625.l0.get().clone(), v613, -1_i32, 0_i32);
                        let v643: string = v640[0_i32].clone();
                        let v647: LrcPtr<Documents::Mut4> = LrcPtr::new(Documents::Mut4 {
                            l0: MutCell::new(Documents::method10()),
                        });
                        let v658: () = {
                            Documents::closure11(
                                v647.clone(),
                                sprintf!("{}", sprintf!("{:?}", Documents::US0::US0_3)),
                                (),
                            );
                            ()
                        };
                        let v668: Documents::US1 = if startsWith(v647.l0.get().clone(), v643, false)
                        {
                            Documents::US1::US1_0(string("Debug"))
                        } else {
                            Documents::US1::US1_1
                        };
                        match &v668 {
                            Documents::US1::US1_0(v668_0_0) => Documents::US1::US1_0(match &v668 {
                                Documents::US1::US1_0(x) => x.clone(),
                                _ => unreachable!(),
                            }),
                            _ => {
                                let v672: string = Documents::method8();
                                let v684: LrcPtr<Documents::Mut4> = LrcPtr::new(Documents::Mut4 {
                                    l0: MutCell::new(Documents::method10()),
                                });
                                let v695: () = {
                                    Documents::closure11(
                                        v684.clone(),
                                        sprintf!("{}", sprintf!("{:?}", Documents::US0::US0_2)),
                                        (),
                                    );
                                    ()
                                };
                                let v699: Array<string> =
                                    split(v684.l0.get().clone(), v672, -1_i32, 0_i32);
                                let v702: string = v699[0_i32].clone();
                                let v706: LrcPtr<Documents::Mut4> = LrcPtr::new(Documents::Mut4 {
                                    l0: MutCell::new(Documents::method10()),
                                });
                                let v717: () = {
                                    Documents::closure11(
                                        v706.clone(),
                                        sprintf!("{}", sprintf!("{:?}", Documents::US0::US0_3)),
                                        (),
                                    );
                                    ()
                                };
                                let v727: Documents::US1 =
                                    if startsWith(v706.l0.get().clone(), v702, false) {
                                        Documents::US1::US1_0(string("Info"))
                                    } else {
                                        Documents::US1::US1_1
                                    };
                                match &v727 {
                                    Documents::US1::US1_0(v727_0_0) => {
                                        Documents::US1::US1_0(match &v727 {
                                            Documents::US1::US1_0(x) => x.clone(),
                                            _ => unreachable!(),
                                        })
                                    }
                                    _ => Documents::US1::US1_0(string("Warning")),
                                }
                            }
                        }
                    }
                };
                let v746: string = padLeft(
                    toLower(match &v737 {
                        Documents::US1::US1_0(v737_0_0) => match &v737 {
                            Documents::US1::US1_0(x) => x.clone(),
                            _ => unreachable!(),
                        },
                        _ => panic!("{}", string("Option does not have a value."),),
                    }),
                    7_i32,
                    ' ',
                );
                let v762: &str = inline_colorization::color_yellow;
                let v764: &str = &*v746;
                let v766: &str = inline_colorization::color_reset;
                let v768: string = string("format!(\"{v762}{v764}{v766}\")");
                let v769: std::string::String = format!("{v762}{v764}{v766}");
                let v771: string = fable_library_rust::String_::fromString(v769);
                let v812: i64 = (patternInput_2.0.clone()).l0.get().clone();
                let v814: LrcPtr<Documents::Mut4> = LrcPtr::new(Documents::Mut4 {
                    l0: MutCell::new(Documents::method10()),
                });
                let v821: () = {
                    Documents::closure11(v814.clone(), sprintf!("{}", string("{ ")), ());
                    ()
                };
                let v830: () = {
                    Documents::closure11(v814.clone(), sprintf!("{}", string("ex")), ());
                    ()
                };
                let v839: () = {
                    Documents::closure11(v814.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v844: std::string::String = format!("{:#?}", v0_1);
                let v874: () = {
                    Documents::closure11(
                        v814.clone(),
                        sprintf!("{}", fable_library_rust::String_::fromString(v844)),
                        (),
                    );
                    ()
                };
                let v883: () = {
                    Documents::closure11(v814.clone(), sprintf!("{}", string(" }")), ());
                    ()
                };
                let v886: string = v814.l0.get().clone();
                let v925: string = trimEndChars(
                    trimStartChars(
                        sprintf!(
                            "{} {} #{} {} / {}",
                            v166,
                            v771,
                            v812,
                            Documents::closure78((), ()),
                            v886
                        ),
                        toArray(empty::<char>()),
                    ),
                    toArray(ofArray(new_array(&[' ', '/']))),
                );
                println!("{}", v925.clone());
                ();
                ((patternInput.1.clone()).l0.get().clone())(v925)
            }
        }
        pub fn closure80(unitVar: (), unitVar_1: ()) -> string {
            string("runtime.execute_with_options_async")
        }
        pub fn closure79(v0_1: i32, v1_1: string, unitVar: ()) {
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
                Option<i64>,
            ) = getValue(Documents::State::trace_state().get().clone());
            let v33: () = {
                v3();
                ()
            };
            let patternInput_1: (
                LrcPtr<Documents::Mut0>,
                LrcPtr<Documents::Mut1>,
                LrcPtr<Documents::Mut2>,
                LrcPtr<Documents::Mut3>,
                Option<i64>,
            ) = getValue(Documents::State::trace_state().get().clone());
            let v61: Documents::US0 = (patternInput_1.3.clone()).l0.get().clone();
            if if (patternInput_1.2.clone()).l0.get().clone() == false {
                false
            } else {
                1_i32
                    >= find(
                        v61,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Documents::US0::US0_0, 0_i32)),
                            LrcPtr::new((Documents::US0::US0_1, 1_i32)),
                            LrcPtr::new((Documents::US0::US0_2, 2_i32)),
                            LrcPtr::new((Documents::US0::US0_3, 3_i32)),
                            LrcPtr::new((Documents::US0::US0_4, 4_i32)),
                        ])))),
                    )
            } {
                let v69: () = {
                    Documents::closure8(patternInput.0.clone(), ());
                    ()
                };
                let v73: () = {
                    v3();
                    ()
                };
                let patternInput_2: (
                    LrcPtr<Documents::Mut0>,
                    LrcPtr<Documents::Mut1>,
                    LrcPtr<Documents::Mut2>,
                    LrcPtr<Documents::Mut3>,
                    Option<i64>,
                ) = getValue(Documents::State::trace_state().get().clone());
                let _v102: LrcPtr<MutCell<Option<Documents::US3>>> =
                    refCell(None::<Documents::US3>);
                let v107: () = {
                    Documents::closure10(
                        patternInput_2.4.clone(),
                        Func1::new({
                            let _v102 = _v102.clone();
                            move |v: Option<Documents::US3>| Documents::closure9(_v102.clone(), v)
                        }),
                        (),
                    );
                    ()
                };
                let v122: Documents::US3 = defaultValue(Documents::US3::US3_1, _v102.get().clone());
                let v162: DateTime = match &v122 {
                    Documents::US3::US3_0(v122_0_0) => {
                        let v136: TimeSpan = TimeSpan::new_ticks(
                            {
                                let _arg: DateTime = DateTime::now();
                                _arg.ticks()
                            } - match &v122 {
                                Documents::US3::US3_0(x) => x.clone(),
                                _ => unreachable!(),
                            },
                        );
                        DateTime::new_ymdhms_milli(
                            1_i32,
                            1_i32,
                            1_i32,
                            v136.hours(),
                            v136.minutes(),
                            v136.seconds(),
                            v136.milliseconds(),
                        )
                    }
                    _ => DateTime::now(),
                };
                let v167: string = {
                    let provider: string = Documents::method6();
                    v162.toString(provider)
                };
                let v555: string = Documents::method8();
                let v567: LrcPtr<Documents::Mut4> = LrcPtr::new(Documents::Mut4 {
                    l0: MutCell::new(Documents::method10()),
                });
                let v578: () = {
                    Documents::closure11(
                        v567.clone(),
                        sprintf!("{}", sprintf!("{:?}", Documents::US0::US0_0)),
                        (),
                    );
                    ()
                };
                let v582: Array<string> = split(v567.l0.get().clone(), v555, -1_i32, 0_i32);
                let v585: string = v582[0_i32].clone();
                let v589: LrcPtr<Documents::Mut4> = LrcPtr::new(Documents::Mut4 {
                    l0: MutCell::new(Documents::method10()),
                });
                let v600: () = {
                    Documents::closure11(
                        v589.clone(),
                        sprintf!("{}", sprintf!("{:?}", Documents::US0::US0_1)),
                        (),
                    );
                    ()
                };
                let v610: Documents::US1 = if startsWith(v589.l0.get().clone(), v585, false) {
                    Documents::US1::US1_0(string("Verbose"))
                } else {
                    Documents::US1::US1_1
                };
                let v616: Documents::US1 = match &v610 {
                    Documents::US1::US1_0(v610_0_0) => Documents::US1::US1_0(match &v610 {
                        Documents::US1::US1_0(x) => x.clone(),
                        _ => unreachable!(),
                    }),
                    _ => Documents::US1::US1_0(string("Debug")),
                };
                let v625: string = padLeft(
                    toLower(match &v616 {
                        Documents::US1::US1_0(v616_0_0) => match &v616 {
                            Documents::US1::US1_0(x) => x.clone(),
                            _ => unreachable!(),
                        },
                        _ => panic!("{}", string("Option does not have a value."),),
                    }),
                    7_i32,
                    ' ',
                );
                let v641: &str = inline_colorization::color_bright_blue;
                let v643: &str = &*v625;
                let v645: &str = inline_colorization::color_reset;
                let v647: string = string("format!(\"{v641}{v643}{v645}\")");
                let v648: std::string::String = format!("{v641}{v643}{v645}");
                let v650: string = fable_library_rust::String_::fromString(v648);
                let v691: i64 = (patternInput_2.0.clone()).l0.get().clone();
                let v692: i32 = length(v1_1);
                let v694: LrcPtr<Documents::Mut4> = LrcPtr::new(Documents::Mut4 {
                    l0: MutCell::new(Documents::method10()),
                });
                let v701: () = {
                    Documents::closure11(v694.clone(), sprintf!("{}", string("{ ")), ());
                    ()
                };
                let v710: () = {
                    Documents::closure11(v694.clone(), sprintf!("{}", string("exit_code")), ());
                    ()
                };
                let v719: () = {
                    Documents::closure11(v694.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v727: () = {
                    Documents::closure11(v694.clone(), sprintf!("{}", v0_1), ());
                    ()
                };
                let v736: () = {
                    Documents::closure11(v694.clone(), sprintf!("{}", string("; ")), ());
                    ()
                };
                let v745: () = {
                    Documents::closure11(v694.clone(), sprintf!("{}", string("output_length")), ());
                    ()
                };
                let v753: () = {
                    Documents::closure11(v694.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v761: () = {
                    Documents::closure11(v694.clone(), sprintf!("{}", v692), ());
                    ()
                };
                let v770: () = {
                    Documents::closure11(v694.clone(), sprintf!("{}", string(" }")), ());
                    ()
                };
                let v773: string = v694.l0.get().clone();
                let v812: string = trimEndChars(
                    trimStartChars(
                        sprintf!(
                            "{} {} #{} {} / {}",
                            v167,
                            v650,
                            v691,
                            Documents::closure80((), ()),
                            v773
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
        pub fn method73(
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
        pub fn method41(
            v0_1: string,
            v1_1: Option<CancellationToken>,
            v2: Array<(string, string)>,
            v3: Option<Func1<(i32, string, bool), Arc<Async<()>>>>,
            v4: Option<Func1<std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>, ()>>,
            v5: bool,
            v6: Option<string>,
        ) -> (i32, string) {
            let v9: Documents::US11 = Documents::method43(Documents::method42(
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
            let v24: Documents::US19 = Documents::method54(match &v19 {
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
                Documents::closure41(
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
            let _v1286: MutCell<Option<LrcPtr<(i32, string)>>> =
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
                        let v1288: std::process::Command =
                            std::process::Command::new(&*v18.clone());
                        let v1290: bool = true;
                        let mut v1288 = v1288;
                        let v1292: &mut std::process::Command =
                            std::process::Command::args(&mut v1288, &*v44.clone());
                        let v1294: std::process::Stdio = std::process::Stdio::piped();
                        let v1296: &mut std::process::Command =
                            std::process::Command::stdout(v1292, std::process::Stdio::piped());
                        let v1298: std::process::Stdio = std::process::Stdio::piped();
                        let v1300: &mut std::process::Command =
                            std::process::Command::stderr(v1296, std::process::Stdio::piped());
                        let v1302: std::process::Stdio = std::process::Stdio::piped();
                        let v1304: &mut std::process::Command =
                            std::process::Command::stdin(v1300, std::process::Stdio::piped());
                        let _v1305: LrcPtr<MutCell<Option<Documents::US1>>> =
                            refCell(None::<Documents::US1>);
                        let v1310: () = {
                            Documents::closure4(
                                v6.clone(),
                                Func1::new({
                                    let _v1305 = _v1305.clone();
                                    move |v: Option<Documents::US1>| {
                                        Documents::closure3(_v1305.clone(), v)
                                    }
                                }),
                                (),
                            );
                            ()
                        };
                        let v1325: Documents::US1 =
                            defaultValue(Documents::US1::US1_1, _v1305.get().clone());
                        let v1333: &mut std::process::Command = match &v1325 {
                            Documents::US1::US1_0(v1325_0_0) => std::process::Command::current_dir(
                                v1304,
                                &*match &v1325 {
                                    Documents::US1::US1_0(x) => x.clone(),
                                    _ => unreachable!(),
                                },
                            ),
                            _ => v1304,
                        };
                        let v1351: &mut std::process::Command = if count_2(v2.clone()) as u64
                            == 0_u64
                        {
                            v1333
                        } else {
                            let v1337: Vec<(string, string)> = v2.clone().to_vec();
                            let v1339: bool = true;
                            let _vec_fold_ = v1337.into_iter().fold(v1333, |acc, x| {
                                //;
                                let v1341: &mut std::process::Command = acc;
                                let patternInput_1: (string, string) = x;
                                let v1346: &mut std::process::Command = std::process::Command::env(
                                    v1341,
                                    &*patternInput_1.0.clone(),
                                    &*patternInput_1.1.clone(),
                                );
                                let v1348: bool = true;
                                v1346
                            });
                            _vec_fold_
                        };
                        let v1353: Result<std::process::Child, std::io::Error> =
                            std::process::Command::spawn(v1351);
                        let v1354 = Documents::method33();
                        let v1356: Result<std::process::Child, std::string::String> =
                            v1353.map_err(|x| v1354(x));
                        let v1358: bool = true;
                        let _result_map_ = v1356.map(|x| {
                            //;
                            let v1360: std::process::Child = x;
                            let v1365: std::sync::Mutex<Option<std::process::Child>> =
                                std::sync::Mutex::new(Some(v1360));
                            let v1367: std::sync::Arc<
                                std::sync::Mutex<Option<std::process::Child>>,
                            > = std::sync::Arc::new(v1365);
                            let v1369: bool = true;
                            v1367
                        });
                        let v1371: Result<
                            std::sync::Arc<std::sync::Mutex<Option<std::process::Child>>>,
                            std::string::String,
                        > = _result_map_;
                        let v1372 = Documents::method65();
                        let v1373 = Documents::method66();
                        let v1375: Documents::US21 = match v1371 {
                            Ok(x) => v1372(x),
                            Err(e) => v1373(e),
                        };
                        let patternInput_3: (i32, Documents::US4, Documents::US22) = match &v1375 {
                            Documents::US21::US21_0(v1375_0_0) => {
                                let v1376: std::sync::Arc<
                                    std::sync::Mutex<Option<std::process::Child>>,
                                > = v1375_0_0.clone();
                                let v1378: bool = true;
                                let _capture = (|| {
                                    //;
                                    let v1380: std::sync::Arc<
                                        std::sync::Mutex<Option<std::process::Child>>,
                                    > = v1376.clone();
                                    let v1382: Result<
                                        std::sync::MutexGuard<Option<std::process::Child>>,
                                        std::sync::PoisonError<
                                            std::sync::MutexGuard<Option<std::process::Child>>,
                                        >,
                                    > = v1380.lock();
                                    let v1384: std::sync::MutexGuard<Option<std::process::Child>> =
                                        v1382.unwrap();
                                    let v1386: bool = true;
                                    let mut v1384 = v1384;
                                    let v1388: &mut Option<std::process::Child> = &mut v1384;
                                    let v1390: Option<&mut std::process::Child> = v1388.as_mut();
                                    let v1392: &mut std::process::Child = v1390.unwrap();
                                    let v1394: &mut Option<std::process::ChildStdout> =
                                        &mut v1392.stdout;
                                    let v1396: Option<std::process::ChildStdout> =
                                        Option::take(v1394);
                                    let v1398: std::process::ChildStdout = v1396.unwrap();
                                    let v1400: bool = true;
                                    v1398
                                })();
                                let v1402: std::process::ChildStdout = _capture;
                                let v1404: bool = true;
                                let _capture = (|| {
                                    //;
                                    let v1406: std::sync::Arc<
                                        std::sync::Mutex<Option<std::process::Child>>,
                                    > = v1376.clone();
                                    let v1408: Result<
                                        std::sync::MutexGuard<Option<std::process::Child>>,
                                        std::sync::PoisonError<
                                            std::sync::MutexGuard<Option<std::process::Child>>,
                                        >,
                                    > = v1406.lock();
                                    let v1410: std::sync::MutexGuard<Option<std::process::Child>> =
                                        v1408.unwrap();
                                    let v1412: bool = true;
                                    let mut v1410 = v1410;
                                    let v1414: &mut Option<std::process::Child> = &mut v1410;
                                    let v1416: Option<&mut std::process::Child> = v1414.as_mut();
                                    let v1418: &mut std::process::Child = v1416.unwrap();
                                    let v1420: &mut Option<std::process::ChildStderr> =
                                        &mut v1418.stderr;
                                    let v1422: Option<std::process::ChildStderr> =
                                        Option::take(v1420);
                                    let v1424: std::process::ChildStderr = v1422.unwrap();
                                    let v1426: bool = true;
                                    v1424
                                })();
                                let v1428: std::process::ChildStderr = _capture;
                                let v1430: bool = true;
                                let _capture = (|| {
                                    //;
                                    let v1432: std::sync::Arc<
                                        std::sync::Mutex<Option<std::process::Child>>,
                                    > = v1376.clone();
                                    let v1434: Result<
                                        std::sync::MutexGuard<Option<std::process::Child>>,
                                        std::sync::PoisonError<
                                            std::sync::MutexGuard<Option<std::process::Child>>,
                                        >,
                                    > = v1432.lock();
                                    let v1436: std::sync::MutexGuard<Option<std::process::Child>> =
                                        v1434.unwrap();
                                    let v1438: bool = true;
                                    let mut v1436 = v1436;
                                    let v1440: &mut Option<std::process::Child> = &mut v1436;
                                    let v1442: Option<&mut std::process::Child> = v1440.as_mut();
                                    let v1444: &mut std::process::Child = v1442.unwrap();
                                    let v1446: &mut Option<std::process::ChildStdin> =
                                        &mut v1444.stdin;
                                    let v1448: Option<std::process::ChildStdin> =
                                        Option::take(v1446);
                                    let v1450: std::process::ChildStdin = v1448.unwrap();
                                    let v1455: std::sync::Mutex<Option<std::process::ChildStdin>> =
                                        std::sync::Mutex::new(Some(v1450));
                                    let v1457: std::sync::Arc<
                                        std::sync::Mutex<Option<std::process::ChildStdin>>,
                                    > = std::sync::Arc::new(v1455);
                                    let v1459: bool = true;
                                    v1457
                                })();
                                let v1461: std::sync::Arc<
                                    std::sync::Mutex<Option<std::process::ChildStdin>>,
                                > = _capture;
                                let patternInput_2: (
                                    std::sync::mpsc::Sender<std::string::String>,
                                    std::sync::Arc<std::sync::mpsc::Receiver<std::string::String>>,
                                ) = {
                                    let (sender, receiver) = std::sync::mpsc::channel();
                                    (sender, std::sync::Arc::new(receiver))
                                };
                                let v1463: std::sync::mpsc::Sender<std::string::String> =
                                    patternInput_2.0.clone();
                                let v1466: std::sync::Mutex<
                                    std::sync::mpsc::Sender<std::string::String>,
                                > = std::sync::Mutex::new(v1463.clone());
                                let v1468: std::sync::Arc<
                                    std::sync::Mutex<std::sync::mpsc::Sender<std::string::String>>,
                                > = std::sync::Arc::new(v1466);
                                let v1470: std::sync::Mutex<
                                    std::sync::mpsc::Sender<std::string::String>,
                                > = std::sync::Mutex::new(v1463);
                                let v1472: std::sync::Arc<
                                    std::sync::Mutex<std::sync::mpsc::Sender<std::string::String>>,
                                > = std::sync::Arc::new(v1470);
                                let v1474: std::sync::Mutex<
                                    std::sync::Arc<std::sync::mpsc::Receiver<std::string::String>>,
                                > = std::sync::Mutex::new(patternInput_2.1.clone());
                                let v1476: std::sync::Arc<
                                    std::sync::Mutex<
                                        std::sync::Arc<
                                            std::sync::mpsc::Receiver<std::string::String>,
                                        >,
                                    >,
                                > = std::sync::Arc::new(v1474);
                                let v1478: bool = true;
                                let __spawn = std::thread::spawn(move || {
                                    //;
                                    let v1480: encoding_rs_io::DecodeReaderBytes<
                                        std::process::ChildStdout,
                                        Vec<u8>,
                                    > = encoding_rs_io::DecodeReaderBytesBuilder::new()
                                        .utf8_passthru(true)
                                        .build(v1402);
                                    let v1482: std::io::BufReader<
                                        encoding_rs_io::DecodeReaderBytes<
                                            std::process::ChildStdout,
                                            Vec<u8>,
                                        >,
                                    > = std::io::BufReader::new(v1480);
                                    let v1484: std::io::Lines<
                                        std::io::BufReader<
                                            encoding_rs_io::DecodeReaderBytes<
                                                std::process::ChildStdout,
                                                Vec<u8>,
                                            >,
                                        >,
                                    > = std::io::BufRead::lines(v1482);
                                    let v1486: bool = true;
                                    let mut v1484 = v1484;
                                    let _iter_try_for_each = v1484.try_for_each(|x| {
                                        //;
                                        let v1488: Result<std::string::String, std::io::Error> = x;
                                        let v1490: std::sync::Arc<
                                            std::sync::Mutex<
                                                std::sync::mpsc::Sender<std::string::String>,
                                            >,
                                        > = v1468.clone();
                                        let v1491 = Documents::method33();
                                        let v1493: Result<
                                            std::string::String,
                                            std::string::String,
                                        > = v1488.map_err(|x| v1491(x));
                                        let v1494 = Documents::method67();
                                        let v1495 = Documents::method68();
                                        let v1497: Documents::US23 = match v1493 {
                                            Ok(x) => v1494(x),
                                            Err(e) => v1495(e),
                                        };
                                        let v3231: std::string::String = match &v1497 {
                                            Documents::US23::US23_0(v1497_0_0) => {
                                                let v1500: string =
                                                    fable_library_rust::String_::fromString(
                                                        v1497_0_0.clone(),
                                                    );
                                                let v1502: &encoding_rs::Encoding =
                                                    encoding_rs::UTF_8;
                                                let v1504: std::borrow::Cow<[u8]> =
                                                    v1502.encode(&*v1500).0;
                                                let v1506: &[u8] = v1504.as_ref();
                                                let v1508: Result<&str, std::str::Utf8Error> =
                                                    std::str::from_utf8(v1506);
                                                let v1510: &str = v1508.unwrap();
                                                let v1512: std::string::String =
                                                    String::from(v1510);
                                                let v1515: string = sprintf!(
                                                    "> {}",
                                                    fable_library_rust::String_::fromString(
                                                        v1512.clone()
                                                    )
                                                );
                                                if v5 {
                                                    let v1518: () = {
                                                        Documents::closure51(v1515.clone(), ());
                                                        ()
                                                    };
                                                    ()
                                                } else {
                                                    let v2210: () = {
                                                        Documents::closure14(v1515, ());
                                                        ()
                                                    };
                                                    ()
                                                }
                                                v1512
                                            }
                                            Documents::US23::US23_1(v1497_1_0) => {
                                                let v2212: std::string::String = v1497_1_0.clone();
                                                let v2215: () = {
                                                    Documents::closure49(v2212.clone(), ());
                                                    ()
                                                };
                                                let v3225: string =
                                                    sprintf!("\u{001b}[4;7m{}\u{001b}[0m", v2212);
                                                let v3227: &str = &*v3225;
                                                String::from(v3227)
                                            }
                                        };
                                        let v3233: std::sync::Arc<
                                            std::sync::Mutex<
                                                std::sync::mpsc::Sender<std::string::String>,
                                            >,
                                        > = v1490;
                                        let v3235: Result<
                                            std::sync::MutexGuard<
                                                std::sync::mpsc::Sender<std::string::String>,
                                            >,
                                            std::sync::PoisonError<
                                                std::sync::MutexGuard<
                                                    std::sync::mpsc::Sender<std::string::String>,
                                                >,
                                            >,
                                        > = v3233.lock();
                                        let v3237: std::sync::MutexGuard<
                                            std::sync::mpsc::Sender<std::string::String>,
                                        > = v3235.unwrap();
                                        let v3239: &std::sync::mpsc::Sender<std::string::String> =
                                            &v3237;
                                        let v3241: Result<
                                            (),
                                            std::sync::mpsc::SendError<std::string::String>,
                                        > = v3239.send(v3231);
                                        let v3242 = Documents::method69();
                                        let v3244: Result<(), std::string::String> =
                                            v3241.map_err(|x| v3242(x));
                                        let v3246: _ = v3244;
                                        let v3248: bool = true;
                                        v3246
                                    }); //;
                                    let v3251: Result<(), string> = Documents::method70(
                                        _iter_try_for_each.map_err(|x| x.into()),
                                    );
                                    let v3255: string =
                                        string("true; v3251 });  // rust.fix_closure\'");
                                    let v3256: bool = true;
                                    v3251
                                }); // rust.fix_closure';
                                let v3258: std::thread::JoinHandle<Result<(), string>> = __spawn;
                                let v3260: bool = true;
                                let __spawn = std::thread::spawn(move || {
                                    //;
                                    let v3262: encoding_rs_io::DecodeReaderBytes<
                                        std::process::ChildStderr,
                                        Vec<u8>,
                                    > = encoding_rs_io::DecodeReaderBytesBuilder::new()
                                        .utf8_passthru(true)
                                        .build(v1428);
                                    let v3264: std::io::BufReader<
                                        encoding_rs_io::DecodeReaderBytes<
                                            std::process::ChildStderr,
                                            Vec<u8>,
                                        >,
                                    > = std::io::BufReader::new(v3262);
                                    let v3266: std::io::Lines<
                                        std::io::BufReader<
                                            encoding_rs_io::DecodeReaderBytes<
                                                std::process::ChildStderr,
                                                Vec<u8>,
                                            >,
                                        >,
                                    > = std::io::BufRead::lines(v3264);
                                    let v3268: bool = true;
                                    let mut v3266 = v3266;
                                    let _iter_try_for_each = v3266.try_for_each(|x| {
                                        //;
                                        let v3270: Result<std::string::String, std::io::Error> = x;
                                        let v3272: std::sync::Arc<
                                            std::sync::Mutex<
                                                std::sync::mpsc::Sender<std::string::String>,
                                            >,
                                        > = v1472.clone();
                                        let v3273 = Documents::method33();
                                        let v3275: Result<
                                            std::string::String,
                                            std::string::String,
                                        > = v3270.map_err(|x| v3273(x));
                                        let v3276 = Documents::method67();
                                        let v3277 = Documents::method68();
                                        let v3279: Documents::US23 = match v3275 {
                                            Ok(x) => v3276(x),
                                            Err(e) => v3277(e),
                                        };
                                        let v5014: std::string::String = match &v3279 {
                                            Documents::US23::US23_0(v3279_0_0) => {
                                                let v3282: string =
                                                    fable_library_rust::String_::fromString(
                                                        v3279_0_0.clone(),
                                                    );
                                                let v3284: &encoding_rs::Encoding =
                                                    encoding_rs::UTF_8;
                                                let v3286: std::borrow::Cow<[u8]> =
                                                    v3284.encode(&*v3282).0;
                                                let v3288: &[u8] = v3286.as_ref();
                                                let v3290: Result<&str, std::str::Utf8Error> =
                                                    std::str::from_utf8(v3288);
                                                let v3292: &str = v3290.unwrap();
                                                let v3294: std::string::String =
                                                    String::from(v3292);
                                                let v3297: string = sprintf!(
                                                    "! {}",
                                                    fable_library_rust::String_::fromString(
                                                        v3294.clone()
                                                    )
                                                );
                                                if v5 {
                                                    let v3300: () = {
                                                        Documents::closure51(v3297.clone(), ());
                                                        ()
                                                    };
                                                    ()
                                                } else {
                                                    let v3990: () = {
                                                        Documents::closure14(v3297, ());
                                                        ()
                                                    };
                                                    ()
                                                }
                                                {
                                                    let v3992: string = sprintf!(
                                                        "\u{001b}[4;7m{}\u{001b}[0m",
                                                        v3294
                                                    );
                                                    let v3994: &str = &*v3992;
                                                    String::from(v3994)
                                                }
                                            }
                                            Documents::US23::US23_1(v3279_1_0) => {
                                                let v3997: std::string::String = v3279_1_0.clone();
                                                let v4000: () = {
                                                    Documents::closure49(v3997.clone(), ());
                                                    ()
                                                };
                                                let v5008: string =
                                                    sprintf!("\u{001b}[4;7m{}\u{001b}[0m", v3997);
                                                let v5010: &str = &*v5008;
                                                String::from(v5010)
                                            }
                                        };
                                        let v5016: std::sync::Arc<
                                            std::sync::Mutex<
                                                std::sync::mpsc::Sender<std::string::String>,
                                            >,
                                        > = v3272;
                                        let v5018: Result<
                                            std::sync::MutexGuard<
                                                std::sync::mpsc::Sender<std::string::String>,
                                            >,
                                            std::sync::PoisonError<
                                                std::sync::MutexGuard<
                                                    std::sync::mpsc::Sender<std::string::String>,
                                                >,
                                            >,
                                        > = v5016.lock();
                                        let v5020: std::sync::MutexGuard<
                                            std::sync::mpsc::Sender<std::string::String>,
                                        > = v5018.unwrap();
                                        let v5022: &std::sync::mpsc::Sender<std::string::String> =
                                            &v5020;
                                        let v5024: Result<
                                            (),
                                            std::sync::mpsc::SendError<std::string::String>,
                                        > = v5022.send(v5014);
                                        let v5025 = Documents::method69();
                                        let v5027: Result<(), std::string::String> =
                                            v5024.map_err(|x| v5025(x));
                                        let v5029: _ = v5027;
                                        let v5031: bool = true;
                                        v5029
                                    }); //;
                                    let v5034: Result<(), string> = Documents::method70(
                                        _iter_try_for_each.map_err(|x| x.into()),
                                    );
                                    let v5036: string =
                                        string("true; v5034 });  // rust.fix_closure\'");
                                    let v5037: bool = true;
                                    v5034
                                }); // rust.fix_closure';
                                let v5039: std::thread::JoinHandle<Result<(), string>> = __spawn;
                                let _v5040: LrcPtr<MutCell<Option<Documents::US24>>> =
                                    refCell(None::<Documents::US24>);
                                let v5045: () = {
                                    Documents::closure55(
                                        v4.clone(),
                                        Func1::new({
                                            let _v5040 = _v5040.clone();
                                            move |v_1: Option<Documents::US24>| {
                                                Documents::closure54(_v5040.clone(), v_1)
                                            }
                                        }),
                                        (),
                                    );
                                    ()
                                };
                                let v5060: Documents::US24 =
                                    defaultValue(Documents::US24::US24_1, _v5040.get().clone());
                                match &v5060 {
                                    Documents::US24::US24_0(v5060_0_0) => {
                                        let v5066: std::sync::Arc<
                                            std::sync::Mutex<Option<std::process::ChildStdin>>,
                                        > = v1461;
                                        let v5068: Result<
                                            std::sync::MutexGuard<Option<std::process::ChildStdin>>,
                                            std::sync::PoisonError<
                                                std::sync::MutexGuard<
                                                    Option<std::process::ChildStdin>,
                                                >,
                                            >,
                                        > = v5066.lock();
                                        let v5070: std::sync::MutexGuard<
                                            Option<std::process::ChildStdin>,
                                        > = v5068.unwrap();
                                        let v5072: bool = true;
                                        let mut v5070 = v5070;
                                        let v5074: &mut Option<std::process::ChildStdin> =
                                            &mut v5070;
                                        let v5076: Option<std::process::ChildStdin> =
                                            Option::take(v5074);
                                        let v5078: bool = true;
                                        let _optionm_map_ = v5076.map(|x| {
                                            //;
                                            let v5080: std::process::ChildStdin = x;
                                            let v5082: std::sync::Mutex<std::process::ChildStdin> =
                                                std::sync::Mutex::new(v5080);
                                            let v5084: std::sync::Arc<
                                                std::sync::Mutex<std::process::ChildStdin>,
                                            > = std::sync::Arc::new(v5082);
                                            let v5086: bool = true;
                                            v5084
                                        });
                                        let v5088: Option<
                                            std::sync::Arc<
                                                std::sync::Mutex<std::process::ChildStdin>,
                                            >,
                                        > = _optionm_map_;
                                        let _v5089: LrcPtr<MutCell<Option<Documents::US25>>> =
                                            refCell(None::<Documents::US25>);
                                        let v5094: () = {
                                            Documents::closure57(
                                                v5088,
                                                Func1::new({
                                                    let _v5089 = _v5089.clone();
                                                    move |v_2: Option<Documents::US25>| {
                                                        Documents::closure56(_v5089.clone(), v_2)
                                                    }
                                                }),
                                                (),
                                            );
                                            ()
                                        };
                                        let v5109: Documents::US25 = defaultValue(
                                            Documents::US25::US25_1,
                                            _v5089.get().clone(),
                                        );
                                        match &v5109 {
                                            Documents::US25::US25_0(v5109_0_0) => {
                                                let v5113: std::sync::Arc<
                                                    std::sync::Mutex<std::process::ChildStdin>,
                                                > = match &v5109 {
                                                    Documents::US25::US25_0(x) => x.clone(),
                                                    _ => unreachable!(),
                                                };
                                                (match &v5060 {
                                                    Documents::US24::US24_0(x) => x.clone(),
                                                    _ => unreachable!(),
                                                })(
                                                    v5113.clone()
                                                );
                                                {
                                                    let v5115: std::sync::Arc<
                                                        std::sync::Mutex<std::process::ChildStdin>,
                                                    > = v5113;
                                                    let v5117: Result<
                                                        std::sync::MutexGuard<
                                                            std::process::ChildStdin,
                                                        >,
                                                        std::sync::PoisonError<
                                                            std::sync::MutexGuard<
                                                                std::process::ChildStdin,
                                                            >,
                                                        >,
                                                    > = v5115.lock();
                                                    let v5120: std::sync::MutexGuard<
                                                        std::process::ChildStdin,
                                                    > = Documents::method71(v5117.unwrap());
                                                    let v5122: bool = true;
                                                    let mut v5120 = v5120;
                                                    let v5124: bool = true;
                                                    std::io::Write::flush(&mut *v5120).unwrap();
                                                    ()
                                                }
                                            }
                                            _ => (),
                                        }
                                    }
                                    _ => (),
                                }
                                {
                                    let v5126: std::sync::Arc<
                                        std::sync::Mutex<Option<std::process::Child>>,
                                    > = v1376;
                                    let v5128: Result<
                                        std::sync::MutexGuard<Option<std::process::Child>>,
                                        std::sync::PoisonError<
                                            std::sync::MutexGuard<Option<std::process::Child>>,
                                        >,
                                    > = v5126.lock();
                                    let v5130: std::sync::MutexGuard<Option<std::process::Child>> =
                                        v5128.unwrap();
                                    let v5132: bool = true;
                                    let mut v5130 = v5130;
                                    let v5134: &mut Option<std::process::Child> = &mut v5130;
                                    let v5136: Option<std::process::Child> = Option::take(v5134);
                                    let v5138: std::process::Child = v5136.unwrap();
                                    let v5140: Result<std::process::Output, std::io::Error> =
                                        v5138.wait_with_output();
                                    let v5141 = Documents::method33();
                                    let v5143: Result<std::process::Output, std::string::String> =
                                        v5140.map_err(|x| v5141(x));
                                    let v5144: std::thread::JoinHandle<Result<(), string>> =
                                        Documents::method72(v5039);
                                    let v5147: string = string("v5144");
                                    let v5148: std::thread::JoinHandle<Result<(), string>> =
                                        Documents::method72(v3258);
                                    let v5153: string = append(
                                        append(string("vec!["), append(string("v5148, "), v5147)),
                                        string("]"),
                                    );
                                    let v5154: Vec<std::thread::JoinHandle<Result<(), string>>> =
                                        vec![v5148, v5144];
                                    let v5156: bool = true;
                                    v5154.into_iter().for_each(|x| {
                                        //;
                                        let v5158: std::thread::JoinHandle<Result<(), string>> = x;
                                        let v5160: Result<
                                            Result<(), string>,
                                            Box<dyn core::any::Any + 'static + Send>,
                                        > = std::thread::JoinHandle::join(v5158);
                                        let v5162: Result<(), string> = v5160.unwrap();
                                        v5162.unwrap();
                                        {
                                            let v5165: bool = true;
                                            let v5167: bool = true;
                                        }
                                    });
                                    {
                                        //;
                                        let v5170: Documents::US26 = match &v5143 {
                                            Err(v5143_1_0) => {
                                                Documents::closure59((), v5143_1_0.clone())
                                            }
                                            Ok(v5143_0_0) => {
                                                Documents::closure58((), v5143_0_0.clone())
                                            }
                                        };
                                        match &v5170 {
                                            Documents::US26::US26_0(v5170_0_0) => {
                                                let v5173: std::process::ExitStatus =
                                                    v5170_0_0.clone().status;
                                                let v5175: Option<i32> = v5173.code();
                                                let _v5176: LrcPtr<
                                                    MutCell<Option<Documents::US27>>,
                                                > = refCell(None::<Documents::US27>);
                                                let v5181: () = {
                                                    Documents::closure63(
                                                        v5175,
                                                        Func1::new({
                                                            let _v5176 = _v5176.clone();
                                                            move |v_5: Option<Documents::US27>| {
                                                                Documents::closure62(
                                                                    _v5176.clone(),
                                                                    v_5,
                                                                )
                                                            }
                                                        }),
                                                        (),
                                                    );
                                                    ()
                                                };
                                                let v5196: Documents::US27 = defaultValue(
                                                    Documents::US27::US27_1,
                                                    _v5176.get().clone(),
                                                );
                                                match &v5196 {
                                                    Documents::US27::US27_0(v5196_0_0) => (
                                                        match &v5196 {
                                                            Documents::US27::US27_0(x) => x.clone(),
                                                            _ => unreachable!(),
                                                        },
                                                        Documents::US4::US4_1,
                                                        Documents::US22::US22_0(v1476.clone()),
                                                    ),
                                                    _ => {
                                                        let v5205:
                                                                                        &str =
                                                                                    &*string("runtime.execute_with_options / exit_code=None");
                                                        (
                                                            -1_i32,
                                                            Documents::US4::US4_0(String::from(
                                                                v5205,
                                                            )),
                                                            Documents::US22::US22_0(v1476.clone()),
                                                        )
                                                    }
                                                }
                                            }
                                            Documents::US26::US26_1(v5170_1_0) => {
                                                let v5216: std::string::String = v5170_1_0.clone();
                                                let v5219: () = {
                                                    Documents::closure60(v5216.clone(), ());
                                                    ()
                                                };
                                                (
                                                    -2_i32,
                                                    Documents::US4::US4_0(v5216),
                                                    Documents::US22::US22_1,
                                                )
                                            }
                                        }
                                    }
                                }
                            }
                            Documents::US21::US21_1(v1375_1_0) => {
                                let v6235: std::string::String = v1375_1_0.clone();
                                let v6238: () = {
                                    Documents::closure45(v6235.clone(), ());
                                    ()
                                };
                                (
                                    -1_i32,
                                    Documents::US4::US4_0(v6235),
                                    Documents::US22::US22_1,
                                )
                            }
                        };
                        let v7255: Documents::US22 = patternInput_3.2.clone();
                        let v7254: Documents::US4 = patternInput_3.1.clone();
                        let v7253: i32 = patternInput_3.0.clone();
                        let v7262: Option<
                            std::sync::Arc<
                                std::sync::Mutex<
                                    std::sync::Arc<std::sync::mpsc::Receiver<std::string::String>>,
                                >,
                            >,
                        > = match &v7255 {
                            Documents::US22::US22_0(v7255_0_0) => Some(match &v7255 {
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
                        let v7264: bool = true;
                        let _optionm_map_ = v7262.map(|x| {
                            //;
                            let v7266: std::sync::Arc<
                                std::sync::Mutex<
                                    std::sync::Arc<std::sync::mpsc::Receiver<std::string::String>>,
                                >,
                            > = x;
                            let v7268: std::sync::Arc<
                                std::sync::Mutex<
                                    std::sync::Arc<std::sync::mpsc::Receiver<std::string::String>>,
                                >,
                            > = v7266;
                            let v7270: Result<
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
                            > = v7268.lock();
                            let v7272: std::sync::MutexGuard<
                                std::sync::Arc<std::sync::mpsc::Receiver<std::string::String>>,
                            > = v7270.unwrap();
                            let v7274 = v7272.iter();
                            let v7276: Vec<std::string::String> = v7274.collect::<Vec<_>>();
                            let v7278: bool = true;
                            let _vec_map: Vec<_> = v7276
                                .into_iter()
                                .map(|x| {
                                    //;
                                    let v7280: std::string::String = x;
                                    let v7282: string =
                                        fable_library_rust::String_::fromString(v7280);
                                    let v7284: bool = true;
                                    v7282
                                })
                                .collect::<Vec<_>>();
                            let v7286: Vec<string> = _vec_map;
                            let v7295: string = join(
                                string("\n"),
                                toArray_1(ofArray_1(fable_library_rust::NativeArray_::array_from(
                                    v7286,
                                ))),
                            );
                            let v7299: bool = true;
                            v7295
                        });
                        let v7301: Option<string> = _optionm_map_;
                        let v7308: Documents::US1 = match &v7254 {
                            Documents::US4::US4_0(v7254_0_0) => Documents::US1::US1_0(
                                fable_library_rust::String_::fromString(match &v7254 {
                                    Documents::US4::US4_0(x) => x.clone(),
                                    _ => unreachable!(),
                                }),
                            ),
                            _ => Documents::US1::US1_1,
                        };
                        let v7313: string = defaultValue(
                            match &v7308 {
                                Documents::US1::US1_0(v7308_0_0) => match &v7308 {
                                    Documents::US1::US1_0(x) => x.clone(),
                                    _ => unreachable!(),
                                },
                                _ => string(""),
                            },
                            v7301,
                        );
                        let v7318: () = {
                            Documents::closure64(v7253, v7313.clone(), ());
                            ()
                        };
                        LrcPtr::new((v7253, v7313))
                    }
                }))();
                _v1286.set(Some(x_3))
            }
            {
                let v8088: LrcPtr<(i32, string)> = match &_v1286.get().clone() {
                    None => panic!("{}", string("base.capture / _v1286=None"),),
                    Some(_v1286_0_0) => _v1286_0_0.clone(),
                };
                let _v7: (i32, string) = (v8088.0.clone(), v8088.1.clone());
                (_v7.0.clone(), _v7.1.clone())
            }
        }
        pub fn method75(v0_1: string) -> string {
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
        pub fn method74(v0_1: string, v1_1: string, v2: string) -> (string, string) {
            let v4: string = Documents::method17(v2, Documents::method75(v1_1.clone()));
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
        pub fn method76() -> string {
            string("")
        }
        pub fn closure81(unitVar: (), v0_1: string) -> Documents::US31 {
            Documents::US31::US31_0(v0_1)
        }
        pub fn method77() -> Func1<string, Documents::US31> {
            Func1::new(move |v: string| Documents::closure81((), v))
        }
        pub fn closure82(unitVar: (), v0_1: std::string::String) -> Documents::US31 {
            Documents::US31::US31_1(v0_1)
        }
        pub fn method78() -> Func1<std::string::String, Documents::US31> {
            Func1::new(move |v: std::string::String| Documents::closure82((), v))
        }
        pub fn method79(v0_1: string) -> bool {
            let v3: &str = &*v0_1;
            let v5: std::string::String = String::from(v3);
            let v7: std::path::PathBuf = std::path::PathBuf::from(v5);
            if v7.clone().exists() {
                v7.is_file()
            } else {
                false
            }
        }
        pub fn closure84(unitVar: (), unitVar_1: ()) -> string {
            let v0_1: string =
                string("documents.run / par_map / origin_hash |> sm\'.contains local_git_hash |> not / hash2 = None || hash1 <>. (hash2 |> optionm.value)");
            v0_1
        }
        pub fn closure83(
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
                Option<i64>,
            ) = getValue(Documents::State::trace_state().get().clone());
            let v42: () = {
                v12();
                ()
            };
            let patternInput_1: (
                LrcPtr<Documents::Mut0>,
                LrcPtr<Documents::Mut1>,
                LrcPtr<Documents::Mut2>,
                LrcPtr<Documents::Mut3>,
                Option<i64>,
            ) = getValue(Documents::State::trace_state().get().clone());
            let v70: Documents::US0 = (patternInput_1.3.clone()).l0.get().clone();
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
                    v12();
                    ()
                };
                let patternInput_2: (
                    LrcPtr<Documents::Mut0>,
                    LrcPtr<Documents::Mut1>,
                    LrcPtr<Documents::Mut2>,
                    LrcPtr<Documents::Mut3>,
                    Option<i64>,
                ) = getValue(Documents::State::trace_state().get().clone());
                let _v111: LrcPtr<MutCell<Option<Documents::US3>>> =
                    refCell(None::<Documents::US3>);
                let v116: () = {
                    Documents::closure10(
                        patternInput_2.4.clone(),
                        Func1::new({
                            let _v111 = _v111.clone();
                            move |v: Option<Documents::US3>| Documents::closure9(_v111.clone(), v)
                        }),
                        (),
                    );
                    ()
                };
                let v131: Documents::US3 = defaultValue(Documents::US3::US3_1, _v111.get().clone());
                let v171: DateTime = match &v131 {
                    Documents::US3::US3_0(v131_0_0) => {
                        let v145: TimeSpan = TimeSpan::new_ticks(
                            {
                                let _arg: DateTime = DateTime::now();
                                _arg.ticks()
                            } - match &v131 {
                                Documents::US3::US3_0(x) => x.clone(),
                                _ => unreachable!(),
                            },
                        );
                        DateTime::new_ymdhms_milli(
                            1_i32,
                            1_i32,
                            1_i32,
                            v145.hours(),
                            v145.minutes(),
                            v145.seconds(),
                            v145.milliseconds(),
                        )
                    }
                    _ => DateTime::now(),
                };
                let v176: string = {
                    let provider: string = Documents::method6();
                    v171.toString(provider)
                };
                let v564: string = Documents::method8();
                let v576: LrcPtr<Documents::Mut4> = LrcPtr::new(Documents::Mut4 {
                    l0: MutCell::new(Documents::method10()),
                });
                let v587: () = {
                    Documents::closure11(
                        v576.clone(),
                        sprintf!("{}", sprintf!("{:?}", Documents::US0::US0_0)),
                        (),
                    );
                    ()
                };
                let v591: Array<string> = split(v576.l0.get().clone(), v564, -1_i32, 0_i32);
                let v594: string = v591[0_i32].clone();
                let v598: LrcPtr<Documents::Mut4> = LrcPtr::new(Documents::Mut4 {
                    l0: MutCell::new(Documents::method10()),
                });
                let v609: () = {
                    Documents::closure11(
                        v598.clone(),
                        sprintf!("{}", sprintf!("{:?}", Documents::US0::US0_2)),
                        (),
                    );
                    ()
                };
                let v619: Documents::US1 = if startsWith(v598.l0.get().clone(), v594, false) {
                    Documents::US1::US1_0(string("Verbose"))
                } else {
                    Documents::US1::US1_1
                };
                let v686: Documents::US1 = match &v619 {
                    Documents::US1::US1_0(v619_0_0) => Documents::US1::US1_0(match &v619 {
                        Documents::US1::US1_0(x) => x.clone(),
                        _ => unreachable!(),
                    }),
                    _ => {
                        let v623: string = Documents::method8();
                        let v635: LrcPtr<Documents::Mut4> = LrcPtr::new(Documents::Mut4 {
                            l0: MutCell::new(Documents::method10()),
                        });
                        let v646: () = {
                            Documents::closure11(
                                v635.clone(),
                                sprintf!("{}", sprintf!("{:?}", Documents::US0::US0_1)),
                                (),
                            );
                            ()
                        };
                        let v650: Array<string> = split(v635.l0.get().clone(), v623, -1_i32, 0_i32);
                        let v653: string = v650[0_i32].clone();
                        let v657: LrcPtr<Documents::Mut4> = LrcPtr::new(Documents::Mut4 {
                            l0: MutCell::new(Documents::method10()),
                        });
                        let v668: () = {
                            Documents::closure11(
                                v657.clone(),
                                sprintf!("{}", sprintf!("{:?}", Documents::US0::US0_2)),
                                (),
                            );
                            ()
                        };
                        let v678: Documents::US1 = if startsWith(v657.l0.get().clone(), v653, false)
                        {
                            Documents::US1::US1_0(string("Debug"))
                        } else {
                            Documents::US1::US1_1
                        };
                        match &v678 {
                            Documents::US1::US1_0(v678_0_0) => Documents::US1::US1_0(match &v678 {
                                Documents::US1::US1_0(x) => x.clone(),
                                _ => unreachable!(),
                            }),
                            _ => Documents::US1::US1_0(string("Info")),
                        }
                    }
                };
                let v695: string = padLeft(
                    toLower(match &v686 {
                        Documents::US1::US1_0(v686_0_0) => match &v686 {
                            Documents::US1::US1_0(x) => x.clone(),
                            _ => unreachable!(),
                        },
                        _ => panic!("{}", string("Option does not have a value."),),
                    }),
                    7_i32,
                    ' ',
                );
                let v711: &str = inline_colorization::color_bright_green;
                let v713: &str = &*v695;
                let v715: &str = inline_colorization::color_reset;
                let v717: string = string("format!(\"{v711}{v713}{v715}\")");
                let v718: std::string::String = format!("{v711}{v713}{v715}");
                let v720: string = fable_library_rust::String_::fromString(v718);
                let v761: i64 = (patternInput_2.0.clone()).l0.get().clone();
                let v763: LrcPtr<Documents::Mut4> = LrcPtr::new(Documents::Mut4 {
                    l0: MutCell::new(Documents::method10()),
                });
                let v770: () = {
                    Documents::closure11(v763.clone(), sprintf!("{}", string("{ ")), ());
                    ()
                };
                let v779: () = {
                    Documents::closure11(v763.clone(), sprintf!("{}", string("file")), ());
                    ()
                };
                let v788: () = {
                    Documents::closure11(v763.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v796: () = {
                    Documents::closure11(v763.clone(), sprintf!("{}", v1_1), ());
                    ()
                };
                let v805: () = {
                    Documents::closure11(v763.clone(), sprintf!("{}", string("; ")), ());
                    ()
                };
                let v814: () = {
                    Documents::closure11(v763.clone(), sprintf!("{}", string("real_path")), ());
                    ()
                };
                let v822: () = {
                    Documents::closure11(v763.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v830: () = {
                    Documents::closure11(v763.clone(), sprintf!("{}", v2), ());
                    ()
                };
                let v838: () = {
                    Documents::closure11(v763.clone(), sprintf!("{}", string("; ")), ());
                    ()
                };
                let v847: () = {
                    Documents::closure11(v763.clone(), sprintf!("{}", string("relative_path")), ());
                    ()
                };
                let v855: () = {
                    Documents::closure11(v763.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v863: () = {
                    Documents::closure11(v763.clone(), sprintf!("{}", v0_1), ());
                    ()
                };
                let v871: () = {
                    Documents::closure11(v763.clone(), sprintf!("{}", string("; ")), ());
                    ()
                };
                let v880: () = {
                    Documents::closure11(
                        v763.clone(),
                        sprintf!("{}", string("origin_hash_exit_code")),
                        (),
                    );
                    ()
                };
                let v888: () = {
                    Documents::closure11(v763.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v896: () = {
                    Documents::closure11(v763.clone(), sprintf!("{}", v4), ());
                    ()
                };
                let v904: () = {
                    Documents::closure11(v763.clone(), sprintf!("{}", string("; ")), ());
                    ()
                };
                let v913: () = {
                    Documents::closure11(v763.clone(), sprintf!("{}", string("origin_hash")), ());
                    ()
                };
                let v921: () = {
                    Documents::closure11(v763.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v929: () = {
                    Documents::closure11(v763.clone(), sprintf!("{}", v3), ());
                    ()
                };
                let v937: () = {
                    Documents::closure11(v763.clone(), sprintf!("{}", string("; ")), ());
                    ()
                };
                let v946: () = {
                    Documents::closure11(
                        v763.clone(),
                        sprintf!("{}", string("local_git_hash_exit_code")),
                        (),
                    );
                    ()
                };
                let v954: () = {
                    Documents::closure11(v763.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v962: () = {
                    Documents::closure11(v763.clone(), sprintf!("{}", v7), ());
                    ()
                };
                let v970: () = {
                    Documents::closure11(v763.clone(), sprintf!("{}", string("; ")), ());
                    ()
                };
                let v979: () = {
                    Documents::closure11(
                        v763.clone(),
                        sprintf!("{}", string("local_git_hash")),
                        (),
                    );
                    ()
                };
                let v987: () = {
                    Documents::closure11(v763.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v995: () = {
                    Documents::closure11(v763.clone(), sprintf!("{}", v6), ());
                    ()
                };
                let v1003: () = {
                    Documents::closure11(v763.clone(), sprintf!("{}", string("; ")), ());
                    ()
                };
                let v1012: () = {
                    Documents::closure11(v763.clone(), sprintf!("{}", string("hash1")), ());
                    ()
                };
                let v1020: () = {
                    Documents::closure11(v763.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v1028: () = {
                    Documents::closure11(v763.clone(), sprintf!("{}", v9), ());
                    ()
                };
                let v1036: () = {
                    Documents::closure11(v763.clone(), sprintf!("{}", string("; ")), ());
                    ()
                };
                let v1045: () = {
                    Documents::closure11(v763.clone(), sprintf!("{}", string("hash2")), ());
                    ()
                };
                let v1053: () = {
                    Documents::closure11(v763.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v1064: () = {
                    Documents::closure11(v763.clone(), sprintf!("{}", sprintf!("{:?}", v10)), ());
                    ()
                };
                let v1072: () = {
                    Documents::closure11(v763.clone(), sprintf!("{}", string("; ")), ());
                    ()
                };
                let v1081: () = {
                    Documents::closure11(v763.clone(), sprintf!("{}", string("dist_path")), ());
                    ()
                };
                let v1089: () = {
                    Documents::closure11(v763.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v1097: () = {
                    Documents::closure11(v763.clone(), sprintf!("{}", v5), ());
                    ()
                };
                let v1105: () = {
                    Documents::closure11(v763.clone(), sprintf!("{}", string("; ")), ());
                    ()
                };
                let v1114: () = {
                    Documents::closure11(v763.clone(), sprintf!("{}", string("cache_path")), ());
                    ()
                };
                let v1122: () = {
                    Documents::closure11(v763.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v1130: () = {
                    Documents::closure11(v763.clone(), sprintf!("{}", v8), ());
                    ()
                };
                let v1139: () = {
                    Documents::closure11(v763.clone(), sprintf!("{}", string(" }")), ());
                    ()
                };
                let v1142: string = v763.l0.get().clone();
                let v1181: string = trimEndChars(
                    trimStartChars(
                        sprintf!(
                            "{} {} #{} {} / {}",
                            v176,
                            v720,
                            v761,
                            Documents::closure84((), ()),
                            v1142
                        ),
                        toArray(empty::<char>()),
                    ),
                    toArray(ofArray(new_array(&[' ', '/']))),
                );
                println!("{}", v1181.clone());
                ();
                ((patternInput.1.clone()).l0.get().clone())(v1181)
            }
        }
        pub fn method81(v0_1: string) -> string {
            v0_1
        }
        pub fn method80(v0_1: string, v1_1: string) {
            let v3: string = Documents::method81(v0_1);
            let v5: Result<u64, std::io::Error> = std::fs::copy(&*v1_1, &*v3);
            let v7: u64 = v5.unwrap();
            ();
            ()
        }
        pub fn method83(v0_1: Vec<u8>) -> Vec<u8> {
            v0_1
        }
        pub fn method84(v0_1: i32, v1_1: LrcPtr<Documents::Mut7>) -> bool {
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
        pub fn closure87(
            v0_1: string,
            v1_1: std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>,
        ) {
            let v3: std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>> = v1_1;
            let v5: Result<
                std::sync::MutexGuard<std::process::ChildStdin>,
                std::sync::PoisonError<std::sync::MutexGuard<std::process::ChildStdin>>,
            > = v3.lock();
            let v7: std::sync::MutexGuard<std::process::ChildStdin> = v5.unwrap();
            let v8: string = Documents::method85(v0_1);
            let v10: &[u8] = v8.as_bytes();
            let v11: std::sync::MutexGuard<std::process::ChildStdin> = Documents::method86(v7);
            let v13: bool = true;
            let mut v11 = v11;
            let v15: bool = true;
            std::io::Write::write_all(&mut *v11, v10).unwrap();
            ()
        }
        pub fn method87(v0_1: i32, v1_1: LrcPtr<Documents::Mut8>) -> bool {
            v1_1.l0.get().clone() < v0_1
        }
        pub fn method88(v0_1: string) -> string {
            v0_1
        }
        pub fn closure89(unitVar: (), unitVar_1: ()) -> string {
            string("documents.hangul")
        }
        pub fn closure88(v0_1: string, v1_1: i32, v2: string, unitVar: ()) {
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
                Option<i64>,
            ) = getValue(Documents::State::trace_state().get().clone());
            let v34: () = {
                v4();
                ()
            };
            let patternInput_1: (
                LrcPtr<Documents::Mut0>,
                LrcPtr<Documents::Mut1>,
                LrcPtr<Documents::Mut2>,
                LrcPtr<Documents::Mut3>,
                Option<i64>,
            ) = getValue(Documents::State::trace_state().get().clone());
            let v62: Documents::US0 = (patternInput_1.3.clone()).l0.get().clone();
            if if (patternInput_1.2.clone()).l0.get().clone() == false {
                false
            } else {
                2_i32
                    >= find(
                        v62,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Documents::US0::US0_0, 0_i32)),
                            LrcPtr::new((Documents::US0::US0_1, 1_i32)),
                            LrcPtr::new((Documents::US0::US0_2, 2_i32)),
                            LrcPtr::new((Documents::US0::US0_3, 3_i32)),
                            LrcPtr::new((Documents::US0::US0_4, 4_i32)),
                        ])))),
                    )
            } {
                let v70: () = {
                    Documents::closure8(patternInput.0.clone(), ());
                    ()
                };
                let v74: () = {
                    v4();
                    ()
                };
                let patternInput_2: (
                    LrcPtr<Documents::Mut0>,
                    LrcPtr<Documents::Mut1>,
                    LrcPtr<Documents::Mut2>,
                    LrcPtr<Documents::Mut3>,
                    Option<i64>,
                ) = getValue(Documents::State::trace_state().get().clone());
                let _v103: LrcPtr<MutCell<Option<Documents::US3>>> =
                    refCell(None::<Documents::US3>);
                let v108: () = {
                    Documents::closure10(
                        patternInput_2.4.clone(),
                        Func1::new({
                            let _v103 = _v103.clone();
                            move |v: Option<Documents::US3>| Documents::closure9(_v103.clone(), v)
                        }),
                        (),
                    );
                    ()
                };
                let v123: Documents::US3 = defaultValue(Documents::US3::US3_1, _v103.get().clone());
                let v163: DateTime = match &v123 {
                    Documents::US3::US3_0(v123_0_0) => {
                        let v137: TimeSpan = TimeSpan::new_ticks(
                            {
                                let _arg: DateTime = DateTime::now();
                                _arg.ticks()
                            } - match &v123 {
                                Documents::US3::US3_0(x) => x.clone(),
                                _ => unreachable!(),
                            },
                        );
                        DateTime::new_ymdhms_milli(
                            1_i32,
                            1_i32,
                            1_i32,
                            v137.hours(),
                            v137.minutes(),
                            v137.seconds(),
                            v137.milliseconds(),
                        )
                    }
                    _ => DateTime::now(),
                };
                let v168: string = {
                    let provider: string = Documents::method6();
                    v163.toString(provider)
                };
                let v556: string = Documents::method8();
                let v568: LrcPtr<Documents::Mut4> = LrcPtr::new(Documents::Mut4 {
                    l0: MutCell::new(Documents::method10()),
                });
                let v579: () = {
                    Documents::closure11(
                        v568.clone(),
                        sprintf!("{}", sprintf!("{:?}", Documents::US0::US0_0)),
                        (),
                    );
                    ()
                };
                let v583: Array<string> = split(v568.l0.get().clone(), v556, -1_i32, 0_i32);
                let v586: string = v583[0_i32].clone();
                let v590: LrcPtr<Documents::Mut4> = LrcPtr::new(Documents::Mut4 {
                    l0: MutCell::new(Documents::method10()),
                });
                let v601: () = {
                    Documents::closure11(
                        v590.clone(),
                        sprintf!("{}", sprintf!("{:?}", Documents::US0::US0_2)),
                        (),
                    );
                    ()
                };
                let v611: Documents::US1 = if startsWith(v590.l0.get().clone(), v586, false) {
                    Documents::US1::US1_0(string("Verbose"))
                } else {
                    Documents::US1::US1_1
                };
                let v678: Documents::US1 = match &v611 {
                    Documents::US1::US1_0(v611_0_0) => Documents::US1::US1_0(match &v611 {
                        Documents::US1::US1_0(x) => x.clone(),
                        _ => unreachable!(),
                    }),
                    _ => {
                        let v615: string = Documents::method8();
                        let v627: LrcPtr<Documents::Mut4> = LrcPtr::new(Documents::Mut4 {
                            l0: MutCell::new(Documents::method10()),
                        });
                        let v638: () = {
                            Documents::closure11(
                                v627.clone(),
                                sprintf!("{}", sprintf!("{:?}", Documents::US0::US0_1)),
                                (),
                            );
                            ()
                        };
                        let v642: Array<string> = split(v627.l0.get().clone(), v615, -1_i32, 0_i32);
                        let v645: string = v642[0_i32].clone();
                        let v649: LrcPtr<Documents::Mut4> = LrcPtr::new(Documents::Mut4 {
                            l0: MutCell::new(Documents::method10()),
                        });
                        let v660: () = {
                            Documents::closure11(
                                v649.clone(),
                                sprintf!("{}", sprintf!("{:?}", Documents::US0::US0_2)),
                                (),
                            );
                            ()
                        };
                        let v670: Documents::US1 = if startsWith(v649.l0.get().clone(), v645, false)
                        {
                            Documents::US1::US1_0(string("Debug"))
                        } else {
                            Documents::US1::US1_1
                        };
                        match &v670 {
                            Documents::US1::US1_0(v670_0_0) => Documents::US1::US1_0(match &v670 {
                                Documents::US1::US1_0(x) => x.clone(),
                                _ => unreachable!(),
                            }),
                            _ => Documents::US1::US1_0(string("Info")),
                        }
                    }
                };
                let v687: string = padLeft(
                    toLower(match &v678 {
                        Documents::US1::US1_0(v678_0_0) => match &v678 {
                            Documents::US1::US1_0(x) => x.clone(),
                            _ => unreachable!(),
                        },
                        _ => panic!("{}", string("Option does not have a value."),),
                    }),
                    7_i32,
                    ' ',
                );
                let v703: &str = inline_colorization::color_bright_green;
                let v705: &str = &*v687;
                let v707: &str = inline_colorization::color_reset;
                let v709: string = string("format!(\"{v703}{v705}{v707}\")");
                let v710: std::string::String = format!("{v703}{v705}{v707}");
                let v712: string = fable_library_rust::String_::fromString(v710);
                let v753: i64 = (patternInput_2.0.clone()).l0.get().clone();
                let v754: i32 = length(v2);
                let v756: LrcPtr<Documents::Mut4> = LrcPtr::new(Documents::Mut4 {
                    l0: MutCell::new(Documents::method10()),
                });
                let v763: () = {
                    Documents::closure11(v756.clone(), sprintf!("{}", string("{ ")), ());
                    ()
                };
                let v772: () = {
                    Documents::closure11(v756.clone(), sprintf!("{}", string("exit_code")), ());
                    ()
                };
                let v781: () = {
                    Documents::closure11(v756.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v789: () = {
                    Documents::closure11(v756.clone(), sprintf!("{}", v1_1), ());
                    ()
                };
                let v798: () = {
                    Documents::closure11(v756.clone(), sprintf!("{}", string("; ")), ());
                    ()
                };
                let v807: () = {
                    Documents::closure11(v756.clone(), sprintf!("{}", string("result_len")), ());
                    ()
                };
                let v815: () = {
                    Documents::closure11(v756.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v823: () = {
                    Documents::closure11(v756.clone(), sprintf!("{}", v754), ());
                    ()
                };
                let v831: () = {
                    Documents::closure11(v756.clone(), sprintf!("{}", string("; ")), ());
                    ()
                };
                let v840: () = {
                    Documents::closure11(v756.clone(), sprintf!("{}", string("output_path")), ());
                    ()
                };
                let v848: () = {
                    Documents::closure11(v756.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v856: () = {
                    Documents::closure11(v756.clone(), sprintf!("{}", v0_1), ());
                    ()
                };
                let v865: () = {
                    Documents::closure11(v756.clone(), sprintf!("{}", string(" }")), ());
                    ()
                };
                let v868: string = v756.l0.get().clone();
                let v907: string = trimEndChars(
                    trimStartChars(
                        sprintf!(
                            "{} {} #{} {} / {}",
                            v168,
                            v712,
                            v753,
                            Documents::closure89((), ()),
                            v868
                        ),
                        toArray(empty::<char>()),
                    ),
                    toArray(ofArray(new_array(&[' ', '/']))),
                );
                println!("{}", v907.clone());
                ();
                ((patternInput.1.clone()).l0.get().clone())(v907)
            }
        }
        pub fn method82(v0_1: string, v1_1: string, v2: string, v3: string) -> Documents::US32 {
            let v7: Result<Vec<u8>, std::io::Error> = std::fs::read(&*v3);
            let v30: Vec<u8> = Documents::method83(v7.unwrap());
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
            while Documents::method30(v59, v61.clone()) {
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
                while Documents::method84(v68, v70.clone()) {
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
                    while Documents::method30(v82, v84.clone()) {
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
                        let patternInput: (i32, string) = Documents::method41(
                            sprintf!(
                                "{} {}",
                                Documents::method17(
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
                                    Documents::closure87(v97.clone(), v)
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
                        while Documents::method87(v68, v145.clone()) {
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
                                    Documents::closure88(v2, v138, v172.clone(), ());
                                    ()
                                };
                                Documents::US32::US32_0(v138, v172)
                            }
                        }
                    }
                }
            }
        }
        pub fn closure91(unitVar: (), unitVar_1: ()) -> string {
            string("documents.files_fn / error")
        }
        pub fn closure90(v0_1: string, v1_1: i32, unitVar: ()) {
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
                Option<i64>,
            ) = getValue(Documents::State::trace_state().get().clone());
            let v33: () = {
                v3();
                ()
            };
            let patternInput_1: (
                LrcPtr<Documents::Mut0>,
                LrcPtr<Documents::Mut1>,
                LrcPtr<Documents::Mut2>,
                LrcPtr<Documents::Mut3>,
                Option<i64>,
            ) = getValue(Documents::State::trace_state().get().clone());
            let v61: Documents::US0 = (patternInput_1.3.clone()).l0.get().clone();
            if if (patternInput_1.2.clone()).l0.get().clone() == false {
                false
            } else {
                2_i32
                    >= find(
                        v61,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Documents::US0::US0_0, 0_i32)),
                            LrcPtr::new((Documents::US0::US0_1, 1_i32)),
                            LrcPtr::new((Documents::US0::US0_2, 2_i32)),
                            LrcPtr::new((Documents::US0::US0_3, 3_i32)),
                            LrcPtr::new((Documents::US0::US0_4, 4_i32)),
                        ])))),
                    )
            } {
                let v69: () = {
                    Documents::closure8(patternInput.0.clone(), ());
                    ()
                };
                let v73: () = {
                    v3();
                    ()
                };
                let patternInput_2: (
                    LrcPtr<Documents::Mut0>,
                    LrcPtr<Documents::Mut1>,
                    LrcPtr<Documents::Mut2>,
                    LrcPtr<Documents::Mut3>,
                    Option<i64>,
                ) = getValue(Documents::State::trace_state().get().clone());
                let _v102: LrcPtr<MutCell<Option<Documents::US3>>> =
                    refCell(None::<Documents::US3>);
                let v107: () = {
                    Documents::closure10(
                        patternInput_2.4.clone(),
                        Func1::new({
                            let _v102 = _v102.clone();
                            move |v: Option<Documents::US3>| Documents::closure9(_v102.clone(), v)
                        }),
                        (),
                    );
                    ()
                };
                let v122: Documents::US3 = defaultValue(Documents::US3::US3_1, _v102.get().clone());
                let v162: DateTime = match &v122 {
                    Documents::US3::US3_0(v122_0_0) => {
                        let v136: TimeSpan = TimeSpan::new_ticks(
                            {
                                let _arg: DateTime = DateTime::now();
                                _arg.ticks()
                            } - match &v122 {
                                Documents::US3::US3_0(x) => x.clone(),
                                _ => unreachable!(),
                            },
                        );
                        DateTime::new_ymdhms_milli(
                            1_i32,
                            1_i32,
                            1_i32,
                            v136.hours(),
                            v136.minutes(),
                            v136.seconds(),
                            v136.milliseconds(),
                        )
                    }
                    _ => DateTime::now(),
                };
                let v167: string = {
                    let provider: string = Documents::method6();
                    v162.toString(provider)
                };
                let v555: string = Documents::method8();
                let v567: LrcPtr<Documents::Mut4> = LrcPtr::new(Documents::Mut4 {
                    l0: MutCell::new(Documents::method10()),
                });
                let v578: () = {
                    Documents::closure11(
                        v567.clone(),
                        sprintf!("{}", sprintf!("{:?}", Documents::US0::US0_0)),
                        (),
                    );
                    ()
                };
                let v582: Array<string> = split(v567.l0.get().clone(), v555, -1_i32, 0_i32);
                let v585: string = v582[0_i32].clone();
                let v589: LrcPtr<Documents::Mut4> = LrcPtr::new(Documents::Mut4 {
                    l0: MutCell::new(Documents::method10()),
                });
                let v600: () = {
                    Documents::closure11(
                        v589.clone(),
                        sprintf!("{}", sprintf!("{:?}", Documents::US0::US0_2)),
                        (),
                    );
                    ()
                };
                let v610: Documents::US1 = if startsWith(v589.l0.get().clone(), v585, false) {
                    Documents::US1::US1_0(string("Verbose"))
                } else {
                    Documents::US1::US1_1
                };
                let v677: Documents::US1 = match &v610 {
                    Documents::US1::US1_0(v610_0_0) => Documents::US1::US1_0(match &v610 {
                        Documents::US1::US1_0(x) => x.clone(),
                        _ => unreachable!(),
                    }),
                    _ => {
                        let v614: string = Documents::method8();
                        let v626: LrcPtr<Documents::Mut4> = LrcPtr::new(Documents::Mut4 {
                            l0: MutCell::new(Documents::method10()),
                        });
                        let v637: () = {
                            Documents::closure11(
                                v626.clone(),
                                sprintf!("{}", sprintf!("{:?}", Documents::US0::US0_1)),
                                (),
                            );
                            ()
                        };
                        let v641: Array<string> = split(v626.l0.get().clone(), v614, -1_i32, 0_i32);
                        let v644: string = v641[0_i32].clone();
                        let v648: LrcPtr<Documents::Mut4> = LrcPtr::new(Documents::Mut4 {
                            l0: MutCell::new(Documents::method10()),
                        });
                        let v659: () = {
                            Documents::closure11(
                                v648.clone(),
                                sprintf!("{}", sprintf!("{:?}", Documents::US0::US0_2)),
                                (),
                            );
                            ()
                        };
                        let v669: Documents::US1 = if startsWith(v648.l0.get().clone(), v644, false)
                        {
                            Documents::US1::US1_0(string("Debug"))
                        } else {
                            Documents::US1::US1_1
                        };
                        match &v669 {
                            Documents::US1::US1_0(v669_0_0) => Documents::US1::US1_0(match &v669 {
                                Documents::US1::US1_0(x) => x.clone(),
                                _ => unreachable!(),
                            }),
                            _ => Documents::US1::US1_0(string("Info")),
                        }
                    }
                };
                let v686: string = padLeft(
                    toLower(match &v677 {
                        Documents::US1::US1_0(v677_0_0) => match &v677 {
                            Documents::US1::US1_0(x) => x.clone(),
                            _ => unreachable!(),
                        },
                        _ => panic!("{}", string("Option does not have a value."),),
                    }),
                    7_i32,
                    ' ',
                );
                let v702: &str = inline_colorization::color_bright_green;
                let v704: &str = &*v686;
                let v706: &str = inline_colorization::color_reset;
                let v708: string = string("format!(\"{v702}{v704}{v706}\")");
                let v709: std::string::String = format!("{v702}{v704}{v706}");
                let v711: string = fable_library_rust::String_::fromString(v709);
                let v752: i64 = (patternInput_2.0.clone()).l0.get().clone();
                let v754: LrcPtr<Documents::Mut4> = LrcPtr::new(Documents::Mut4 {
                    l0: MutCell::new(Documents::method10()),
                });
                let v761: () = {
                    Documents::closure11(v754.clone(), sprintf!("{}", string("{ ")), ());
                    ()
                };
                let v770: () = {
                    Documents::closure11(v754.clone(), sprintf!("{}", string("exit_code")), ());
                    ()
                };
                let v779: () = {
                    Documents::closure11(v754.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v787: () = {
                    Documents::closure11(v754.clone(), sprintf!("{}", v1_1), ());
                    ()
                };
                let v796: () = {
                    Documents::closure11(v754.clone(), sprintf!("{}", string("; ")), ());
                    ()
                };
                let v805: () = {
                    Documents::closure11(v754.clone(), sprintf!("{}", string("result")), ());
                    ()
                };
                let v813: () = {
                    Documents::closure11(v754.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v821: () = {
                    Documents::closure11(v754.clone(), sprintf!("{}", v0_1), ());
                    ()
                };
                let v830: () = {
                    Documents::closure11(v754.clone(), sprintf!("{}", string(" }")), ());
                    ()
                };
                let v833: string = v754.l0.get().clone();
                let v872: string = trimEndChars(
                    trimStartChars(
                        sprintf!(
                            "{} {} #{} {} / {}",
                            v167,
                            v711,
                            v752,
                            Documents::closure91((), ()),
                            v833
                        ),
                        toArray(empty::<char>()),
                    ),
                    toArray(ofArray(new_array(&[' ', '/']))),
                );
                println!("{}", v872.clone());
                ();
                ((patternInput.1.clone()).l0.get().clone())(v872)
            }
        }
        pub fn closure86(
            v0_1: string,
            v1_1: string,
            v2: string,
            v3: string,
            v4: string,
            v5: string,
        ) -> Documents::US30 {
            let patternInput: (string, string) = Documents::method74(v5, v4.clone(), v0_1);
            let v7: string = patternInput.1.clone();
            let v6: string = patternInput.0.clone();
            if (if if Documents::method79(v6.clone()) {
                Documents::method79(v7.clone())
            } else {
                false
            } {
                let v11: string = Documents::method27(v6.clone());
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
                            let v99: string = join(Documents::method76(), toArray_1(v93));
                            let v103 = Documents::method33();
                            let v105: Result<string, std::string::String> =
                                Ok::<string, std::io::Error>(v99).map_err(|x| v103(x));
                            let v106 = Documents::method77();
                            let v107 = Documents::method78();
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
                            let v116: string = Documents::method27(v7.clone());
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
                                            join(Documents::method76(), toArray_1(v198));
                                        let v208 = Documents::method33();
                                        let v210: Result<string, std::string::String> =
                                            Ok::<string, std::io::Error>(v204).map_err(|x| v208(x));
                                        let v211 = Documents::method77();
                                        let v212 = Documents::method78();
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
                let v224: Documents::US32 = Documents::method82(v2, v3, v6.clone(), v4);
                match &v224 {
                    Documents::US32::US32_0(v224_0_0, v224_0_1) => {
                        let v226: string = v224_0_1.clone();
                        let v225: i32 = v224_0_0.clone();
                        if v225 != 0_i32 {
                            let v232: () = {
                                Documents::closure90(v226.clone(), v225, ());
                                ()
                            };
                            Documents::US30::US30_0(Err::<string, LrcPtr<(string, string)>>(
                                LrcPtr::new((v6.clone(), v226)),
                            ))
                        } else {
                            if Documents::method79(v6.clone()) {
                                Documents::method80(v7, v6.clone())
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
        pub fn closure85(
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
                    Documents::closure86(
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
        pub fn closure95(unitVar: (), unitVar_1: ()) -> string {
            string("documents.crowbook / result contains ERROR")
        }
        pub fn closure94(v0_1: string, v1_1: string, v2: i32, unitVar: ()) {
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
                Option<i64>,
            ) = getValue(Documents::State::trace_state().get().clone());
            let v34: () = {
                v4();
                ()
            };
            let patternInput_1: (
                LrcPtr<Documents::Mut0>,
                LrcPtr<Documents::Mut1>,
                LrcPtr<Documents::Mut2>,
                LrcPtr<Documents::Mut3>,
                Option<i64>,
            ) = getValue(Documents::State::trace_state().get().clone());
            let v62: Documents::US0 = (patternInput_1.3.clone()).l0.get().clone();
            if if (patternInput_1.2.clone()).l0.get().clone() == false {
                false
            } else {
                3_i32
                    >= find(
                        v62,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Documents::US0::US0_0, 0_i32)),
                            LrcPtr::new((Documents::US0::US0_1, 1_i32)),
                            LrcPtr::new((Documents::US0::US0_2, 2_i32)),
                            LrcPtr::new((Documents::US0::US0_3, 3_i32)),
                            LrcPtr::new((Documents::US0::US0_4, 4_i32)),
                        ])))),
                    )
            } {
                let v70: () = {
                    Documents::closure8(patternInput.0.clone(), ());
                    ()
                };
                let v74: () = {
                    v4();
                    ()
                };
                let patternInput_2: (
                    LrcPtr<Documents::Mut0>,
                    LrcPtr<Documents::Mut1>,
                    LrcPtr<Documents::Mut2>,
                    LrcPtr<Documents::Mut3>,
                    Option<i64>,
                ) = getValue(Documents::State::trace_state().get().clone());
                let _v103: LrcPtr<MutCell<Option<Documents::US3>>> =
                    refCell(None::<Documents::US3>);
                let v108: () = {
                    Documents::closure10(
                        patternInput_2.4.clone(),
                        Func1::new({
                            let _v103 = _v103.clone();
                            move |v: Option<Documents::US3>| Documents::closure9(_v103.clone(), v)
                        }),
                        (),
                    );
                    ()
                };
                let v123: Documents::US3 = defaultValue(Documents::US3::US3_1, _v103.get().clone());
                let v163: DateTime = match &v123 {
                    Documents::US3::US3_0(v123_0_0) => {
                        let v137: TimeSpan = TimeSpan::new_ticks(
                            {
                                let _arg: DateTime = DateTime::now();
                                _arg.ticks()
                            } - match &v123 {
                                Documents::US3::US3_0(x) => x.clone(),
                                _ => unreachable!(),
                            },
                        );
                        DateTime::new_ymdhms_milli(
                            1_i32,
                            1_i32,
                            1_i32,
                            v137.hours(),
                            v137.minutes(),
                            v137.seconds(),
                            v137.milliseconds(),
                        )
                    }
                    _ => DateTime::now(),
                };
                let v168: string = {
                    let provider: string = Documents::method6();
                    v163.toString(provider)
                };
                let v556: string = Documents::method8();
                let v568: LrcPtr<Documents::Mut4> = LrcPtr::new(Documents::Mut4 {
                    l0: MutCell::new(Documents::method10()),
                });
                let v579: () = {
                    Documents::closure11(
                        v568.clone(),
                        sprintf!("{}", sprintf!("{:?}", Documents::US0::US0_0)),
                        (),
                    );
                    ()
                };
                let v583: Array<string> = split(v568.l0.get().clone(), v556, -1_i32, 0_i32);
                let v586: string = v583[0_i32].clone();
                let v590: LrcPtr<Documents::Mut4> = LrcPtr::new(Documents::Mut4 {
                    l0: MutCell::new(Documents::method10()),
                });
                let v601: () = {
                    Documents::closure11(
                        v590.clone(),
                        sprintf!("{}", sprintf!("{:?}", Documents::US0::US0_3)),
                        (),
                    );
                    ()
                };
                let v611: Documents::US1 = if startsWith(v590.l0.get().clone(), v586, false) {
                    Documents::US1::US1_0(string("Verbose"))
                } else {
                    Documents::US1::US1_1
                };
                let v739: Documents::US1 = match &v611 {
                    Documents::US1::US1_0(v611_0_0) => Documents::US1::US1_0(match &v611 {
                        Documents::US1::US1_0(x) => x.clone(),
                        _ => unreachable!(),
                    }),
                    _ => {
                        let v615: string = Documents::method8();
                        let v627: LrcPtr<Documents::Mut4> = LrcPtr::new(Documents::Mut4 {
                            l0: MutCell::new(Documents::method10()),
                        });
                        let v638: () = {
                            Documents::closure11(
                                v627.clone(),
                                sprintf!("{}", sprintf!("{:?}", Documents::US0::US0_1)),
                                (),
                            );
                            ()
                        };
                        let v642: Array<string> = split(v627.l0.get().clone(), v615, -1_i32, 0_i32);
                        let v645: string = v642[0_i32].clone();
                        let v649: LrcPtr<Documents::Mut4> = LrcPtr::new(Documents::Mut4 {
                            l0: MutCell::new(Documents::method10()),
                        });
                        let v660: () = {
                            Documents::closure11(
                                v649.clone(),
                                sprintf!("{}", sprintf!("{:?}", Documents::US0::US0_3)),
                                (),
                            );
                            ()
                        };
                        let v670: Documents::US1 = if startsWith(v649.l0.get().clone(), v645, false)
                        {
                            Documents::US1::US1_0(string("Debug"))
                        } else {
                            Documents::US1::US1_1
                        };
                        match &v670 {
                            Documents::US1::US1_0(v670_0_0) => Documents::US1::US1_0(match &v670 {
                                Documents::US1::US1_0(x) => x.clone(),
                                _ => unreachable!(),
                            }),
                            _ => {
                                let v674: string = Documents::method8();
                                let v686: LrcPtr<Documents::Mut4> = LrcPtr::new(Documents::Mut4 {
                                    l0: MutCell::new(Documents::method10()),
                                });
                                let v697: () = {
                                    Documents::closure11(
                                        v686.clone(),
                                        sprintf!("{}", sprintf!("{:?}", Documents::US0::US0_2)),
                                        (),
                                    );
                                    ()
                                };
                                let v701: Array<string> =
                                    split(v686.l0.get().clone(), v674, -1_i32, 0_i32);
                                let v704: string = v701[0_i32].clone();
                                let v708: LrcPtr<Documents::Mut4> = LrcPtr::new(Documents::Mut4 {
                                    l0: MutCell::new(Documents::method10()),
                                });
                                let v719: () = {
                                    Documents::closure11(
                                        v708.clone(),
                                        sprintf!("{}", sprintf!("{:?}", Documents::US0::US0_3)),
                                        (),
                                    );
                                    ()
                                };
                                let v729: Documents::US1 =
                                    if startsWith(v708.l0.get().clone(), v704, false) {
                                        Documents::US1::US1_0(string("Info"))
                                    } else {
                                        Documents::US1::US1_1
                                    };
                                match &v729 {
                                    Documents::US1::US1_0(v729_0_0) => {
                                        Documents::US1::US1_0(match &v729 {
                                            Documents::US1::US1_0(x) => x.clone(),
                                            _ => unreachable!(),
                                        })
                                    }
                                    _ => Documents::US1::US1_0(string("Warning")),
                                }
                            }
                        }
                    }
                };
                let v748: string = padLeft(
                    toLower(match &v739 {
                        Documents::US1::US1_0(v739_0_0) => match &v739 {
                            Documents::US1::US1_0(x) => x.clone(),
                            _ => unreachable!(),
                        },
                        _ => panic!("{}", string("Option does not have a value."),),
                    }),
                    7_i32,
                    ' ',
                );
                let v764: &str = inline_colorization::color_yellow;
                let v766: &str = &*v748;
                let v768: &str = inline_colorization::color_reset;
                let v770: string = string("format!(\"{v764}{v766}{v768}\")");
                let v771: std::string::String = format!("{v764}{v766}{v768}");
                let v773: string = fable_library_rust::String_::fromString(v771);
                let v814: i64 = (patternInput_2.0.clone()).l0.get().clone();
                let v816: LrcPtr<Documents::Mut4> = LrcPtr::new(Documents::Mut4 {
                    l0: MutCell::new(Documents::method10()),
                });
                let v823: () = {
                    Documents::closure11(v816.clone(), sprintf!("{}", string("{ ")), ());
                    ()
                };
                let v832: () = {
                    Documents::closure11(v816.clone(), sprintf!("{}", string("exit_code")), ());
                    ()
                };
                let v841: () = {
                    Documents::closure11(v816.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v849: () = {
                    Documents::closure11(v816.clone(), sprintf!("{}", v2), ());
                    ()
                };
                let v858: () = {
                    Documents::closure11(v816.clone(), sprintf!("{}", string("; ")), ());
                    ()
                };
                let v867: () = {
                    Documents::closure11(v816.clone(), sprintf!("{}", string("output_path")), ());
                    ()
                };
                let v875: () = {
                    Documents::closure11(v816.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v883: () = {
                    Documents::closure11(v816.clone(), sprintf!("{}", v0_1), ());
                    ()
                };
                let v891: () = {
                    Documents::closure11(v816.clone(), sprintf!("{}", string("; ")), ());
                    ()
                };
                let v900: () = {
                    Documents::closure11(v816.clone(), sprintf!("{}", string("result")), ());
                    ()
                };
                let v908: () = {
                    Documents::closure11(v816.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v916: () = {
                    Documents::closure11(v816.clone(), sprintf!("{}", v1_1), ());
                    ()
                };
                let v925: () = {
                    Documents::closure11(v816.clone(), sprintf!("{}", string(" }")), ());
                    ()
                };
                let v928: string = v816.l0.get().clone();
                let v967: string = trimEndChars(
                    trimStartChars(
                        sprintf!(
                            "{} {} #{} {} / {}",
                            v168,
                            v773,
                            v814,
                            Documents::closure95((), ()),
                            v928
                        ),
                        toArray(empty::<char>()),
                    ),
                    toArray(ofArray(new_array(&[' ', '/']))),
                );
                println!("{}", v967.clone());
                ();
                ((patternInput.1.clone()).l0.get().clone())(v967)
            }
        }
        pub fn method89(
            v0_1: bool,
            v1_1: string,
            v2: string,
            v3: string,
            v4: string,
        ) -> Documents::US32 {
            let patternInput: (i32, string) = Documents::method41(
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
                    Documents::closure94(v1_1, v61.clone(), v60, ());
                    ()
                };
                Documents::US32::US32_1(v60, v61.clone())
            } else {
                Documents::US32::US32_0(v60, v61)
            }
        }
        pub fn closure93(
            v0_1: string,
            v1_1: string,
            v2: bool,
            v3: string,
            v4: string,
        ) -> Documents::US30 {
            let patternInput: (string, string) = Documents::method74(v4.clone(), v3.clone(), v0_1);
            let v6: string = patternInput.1.clone();
            let v5: string = patternInput.0.clone();
            if (if if Documents::method79(v5.clone()) {
                Documents::method79(v6.clone())
            } else {
                false
            } {
                let v10: string = Documents::method27(v5.clone());
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
                            let v98: string = join(Documents::method76(), toArray_1(v92));
                            let v102 = Documents::method33();
                            let v104: Result<string, std::string::String> =
                                Ok::<string, std::io::Error>(v98).map_err(|x| v102(x));
                            let v105 = Documents::method77();
                            let v106 = Documents::method78();
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
                            let v115: string = Documents::method27(v6.clone());
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
                                            join(Documents::method76(), toArray_1(v197));
                                        let v207 = Documents::method33();
                                        let v209: Result<string, std::string::String> =
                                            Ok::<string, std::io::Error>(v203).map_err(|x| v207(x));
                                        let v210 = Documents::method77();
                                        let v211 = Documents::method78();
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
                let v223: Documents::US32 = Documents::method89(v2, v5.clone(), v3, v1_1, v4);
                match &v223 {
                    Documents::US32::US32_0(v223_0_0, v223_0_1) => {
                        let v225: string = v223_0_1.clone();
                        let v224: i32 = v223_0_0.clone();
                        if v224 != 0_i32 {
                            let v231: () = {
                                Documents::closure90(v225.clone(), v224, ());
                                ()
                            };
                            Documents::US30::US30_0(Err::<string, LrcPtr<(string, string)>>(
                                LrcPtr::new((v5.clone(), v225)),
                            ))
                        } else {
                            if Documents::method79(v5.clone()) {
                                Documents::method80(v6, v5.clone())
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
        pub fn closure92(
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
                move |v: string| Documents::closure93(v0_1.clone(), v1_1.clone(), v2, v3.clone(), v)
            })
        }
        pub fn closure97(unitVar: (), unitVar_1: ()) -> string {
            string("documents.run / par_map / files\' = [] / listm.iter")
        }
        pub fn closure96(v0_1: string, v1_1: string, unitVar: ()) {
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
                Option<i64>,
            ) = getValue(Documents::State::trace_state().get().clone());
            let v33: () = {
                v3();
                ()
            };
            let patternInput_1: (
                LrcPtr<Documents::Mut0>,
                LrcPtr<Documents::Mut1>,
                LrcPtr<Documents::Mut2>,
                LrcPtr<Documents::Mut3>,
                Option<i64>,
            ) = getValue(Documents::State::trace_state().get().clone());
            let v61: Documents::US0 = (patternInput_1.3.clone()).l0.get().clone();
            if if (patternInput_1.2.clone()).l0.get().clone() == false {
                false
            } else {
                2_i32
                    >= find(
                        v61,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Documents::US0::US0_0, 0_i32)),
                            LrcPtr::new((Documents::US0::US0_1, 1_i32)),
                            LrcPtr::new((Documents::US0::US0_2, 2_i32)),
                            LrcPtr::new((Documents::US0::US0_3, 3_i32)),
                            LrcPtr::new((Documents::US0::US0_4, 4_i32)),
                        ])))),
                    )
            } {
                let v69: () = {
                    Documents::closure8(patternInput.0.clone(), ());
                    ()
                };
                let v73: () = {
                    v3();
                    ()
                };
                let patternInput_2: (
                    LrcPtr<Documents::Mut0>,
                    LrcPtr<Documents::Mut1>,
                    LrcPtr<Documents::Mut2>,
                    LrcPtr<Documents::Mut3>,
                    Option<i64>,
                ) = getValue(Documents::State::trace_state().get().clone());
                let _v102: LrcPtr<MutCell<Option<Documents::US3>>> =
                    refCell(None::<Documents::US3>);
                let v107: () = {
                    Documents::closure10(
                        patternInput_2.4.clone(),
                        Func1::new({
                            let _v102 = _v102.clone();
                            move |v: Option<Documents::US3>| Documents::closure9(_v102.clone(), v)
                        }),
                        (),
                    );
                    ()
                };
                let v122: Documents::US3 = defaultValue(Documents::US3::US3_1, _v102.get().clone());
                let v162: DateTime = match &v122 {
                    Documents::US3::US3_0(v122_0_0) => {
                        let v136: TimeSpan = TimeSpan::new_ticks(
                            {
                                let _arg: DateTime = DateTime::now();
                                _arg.ticks()
                            } - match &v122 {
                                Documents::US3::US3_0(x) => x.clone(),
                                _ => unreachable!(),
                            },
                        );
                        DateTime::new_ymdhms_milli(
                            1_i32,
                            1_i32,
                            1_i32,
                            v136.hours(),
                            v136.minutes(),
                            v136.seconds(),
                            v136.milliseconds(),
                        )
                    }
                    _ => DateTime::now(),
                };
                let v167: string = {
                    let provider: string = Documents::method6();
                    v162.toString(provider)
                };
                let v555: string = Documents::method8();
                let v567: LrcPtr<Documents::Mut4> = LrcPtr::new(Documents::Mut4 {
                    l0: MutCell::new(Documents::method10()),
                });
                let v578: () = {
                    Documents::closure11(
                        v567.clone(),
                        sprintf!("{}", sprintf!("{:?}", Documents::US0::US0_0)),
                        (),
                    );
                    ()
                };
                let v582: Array<string> = split(v567.l0.get().clone(), v555, -1_i32, 0_i32);
                let v585: string = v582[0_i32].clone();
                let v589: LrcPtr<Documents::Mut4> = LrcPtr::new(Documents::Mut4 {
                    l0: MutCell::new(Documents::method10()),
                });
                let v600: () = {
                    Documents::closure11(
                        v589.clone(),
                        sprintf!("{}", sprintf!("{:?}", Documents::US0::US0_2)),
                        (),
                    );
                    ()
                };
                let v610: Documents::US1 = if startsWith(v589.l0.get().clone(), v585, false) {
                    Documents::US1::US1_0(string("Verbose"))
                } else {
                    Documents::US1::US1_1
                };
                let v677: Documents::US1 = match &v610 {
                    Documents::US1::US1_0(v610_0_0) => Documents::US1::US1_0(match &v610 {
                        Documents::US1::US1_0(x) => x.clone(),
                        _ => unreachable!(),
                    }),
                    _ => {
                        let v614: string = Documents::method8();
                        let v626: LrcPtr<Documents::Mut4> = LrcPtr::new(Documents::Mut4 {
                            l0: MutCell::new(Documents::method10()),
                        });
                        let v637: () = {
                            Documents::closure11(
                                v626.clone(),
                                sprintf!("{}", sprintf!("{:?}", Documents::US0::US0_1)),
                                (),
                            );
                            ()
                        };
                        let v641: Array<string> = split(v626.l0.get().clone(), v614, -1_i32, 0_i32);
                        let v644: string = v641[0_i32].clone();
                        let v648: LrcPtr<Documents::Mut4> = LrcPtr::new(Documents::Mut4 {
                            l0: MutCell::new(Documents::method10()),
                        });
                        let v659: () = {
                            Documents::closure11(
                                v648.clone(),
                                sprintf!("{}", sprintf!("{:?}", Documents::US0::US0_2)),
                                (),
                            );
                            ()
                        };
                        let v669: Documents::US1 = if startsWith(v648.l0.get().clone(), v644, false)
                        {
                            Documents::US1::US1_0(string("Debug"))
                        } else {
                            Documents::US1::US1_1
                        };
                        match &v669 {
                            Documents::US1::US1_0(v669_0_0) => Documents::US1::US1_0(match &v669 {
                                Documents::US1::US1_0(x) => x.clone(),
                                _ => unreachable!(),
                            }),
                            _ => Documents::US1::US1_0(string("Info")),
                        }
                    }
                };
                let v686: string = padLeft(
                    toLower(match &v677 {
                        Documents::US1::US1_0(v677_0_0) => match &v677 {
                            Documents::US1::US1_0(x) => x.clone(),
                            _ => unreachable!(),
                        },
                        _ => panic!("{}", string("Option does not have a value."),),
                    }),
                    7_i32,
                    ' ',
                );
                let v702: &str = inline_colorization::color_bright_green;
                let v704: &str = &*v686;
                let v706: &str = inline_colorization::color_reset;
                let v708: string = string("format!(\"{v702}{v704}{v706}\")");
                let v709: std::string::String = format!("{v702}{v704}{v706}");
                let v711: string = fable_library_rust::String_::fromString(v709);
                let v752: i64 = (patternInput_2.0.clone()).l0.get().clone();
                let v754: LrcPtr<Documents::Mut4> = LrcPtr::new(Documents::Mut4 {
                    l0: MutCell::new(Documents::method10()),
                });
                let v761: () = {
                    Documents::closure11(v754.clone(), sprintf!("{}", string("{ ")), ());
                    ()
                };
                let v770: () = {
                    Documents::closure11(v754.clone(), sprintf!("{}", string("output_path")), ());
                    ()
                };
                let v779: () = {
                    Documents::closure11(v754.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v787: () = {
                    Documents::closure11(v754.clone(), sprintf!("{}", v1_1), ());
                    ()
                };
                let v796: () = {
                    Documents::closure11(v754.clone(), sprintf!("{}", string("; ")), ());
                    ()
                };
                let v805: () = {
                    Documents::closure11(
                        v754.clone(),
                        sprintf!("{}", string("output_cache_path")),
                        (),
                    );
                    ()
                };
                let v813: () = {
                    Documents::closure11(v754.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v821: () = {
                    Documents::closure11(v754.clone(), sprintf!("{}", v0_1), ());
                    ()
                };
                let v830: () = {
                    Documents::closure11(v754.clone(), sprintf!("{}", string(" }")), ());
                    ()
                };
                let v833: string = v754.l0.get().clone();
                let v872: string = trimEndChars(
                    trimStartChars(
                        sprintf!(
                            "{} {} #{} {} / {}",
                            v167,
                            v711,
                            v752,
                            Documents::closure97((), ()),
                            v833
                        ),
                        toArray(empty::<char>()),
                    ),
                    toArray(ofArray(new_array(&[' ', '/']))),
                );
                println!("{}", v872.clone());
                ();
                ((patternInput.1.clone()).l0.get().clone())(v872)
            }
        }
        pub fn method90(
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
                    Documents::method90(
                        match v0_1.as_ref() {
                            Documents::UH4::UH4_1(_, x) => x.clone(),
                            _ => unreachable!(),
                        },
                        v1_1.clone(),
                    ),
                ),
            }
        }
        pub fn method91(v0_1: i32, v1_1: LrcPtr<Documents::Mut9>) -> bool {
            v1_1.l0.get().clone() < v0_1
        }
        pub fn method92(
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
                    Documents::method92(
                        match v0_1.as_ref() {
                            Documents::UH5::UH5_1(_, _, _, x) => x.clone(),
                            _ => unreachable!(),
                        },
                        v1_1.clone(),
                    ),
                ),
            }
        }
        pub fn closure98(
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
        pub fn closure34(
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
            let v6: string = Documents::method26(v5);
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
                        Documents::method39()
                    ),
                    string("\\"),
                    string("/")
                )
            );
            let v44: string = Documents::method27(v6);
            let v46: string = Documents::method40(Documents::method17(v2.clone(), v43.clone()));
            let patternInput: (i32, string) = Documents::method41(
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
            let v60: string = Documents::method40(Documents::method17(v3.clone(), v43.clone()));
            let patternInput_1: (i32, string) = Documents::method41(
                sprintf!("git hash-object \"{}\"", v60.clone()),
                None::<CancellationToken>,
                new_empty::<(string, string)>(),
                None::<Func1<(i32, string, bool), Arc<Async<()>>>>,
                None::<Func1<std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>, ()>>,
                true,
                Some(v3.clone()),
            );
            let v72: string = patternInput_1.1.clone();
            let v74: string = Documents::method40(Documents::method17(v4.clone(), v43.clone()));
            let v76: string = (Documents::method74(string("hangul.md"), v60.clone(), v4.clone()))
                .0
                .clone();
            let v1533: LrcPtr<Documents::UH4> = if contains(v58.clone(), v72.clone()) == false {
                let v88: string = Documents::method27(v60.clone());
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
                            let v176: string = join(Documents::method76(), toArray_1(v170));
                            let v180 = Documents::method33();
                            let v182: Result<string, std::string::String> =
                                Ok::<string, std::io::Error>(v176).map_err(|x| v180(x));
                            let v183 = Documents::method77();
                            let v184 = Documents::method78();
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
                            let v301: Documents::US1 = if Documents::method79(v74.clone()) == false
                            {
                                Documents::US1::US1_1
                            } else {
                                let v196: string = Documents::method27(v74.clone());
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
                                                join(Documents::method76(), toArray_1(v278));
                                            let v288 = Documents::method33();
                                            let v290: Result<string, std::string::String> =
                                                Ok::<string, std::io::Error>(v284)
                                                    .map_err(|x| v288(x));
                                            let v291 = Documents::method77();
                                            let v292 = Documents::method78();
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
                                    Documents::closure83(
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
                                Documents::method80(v74, v60.clone());
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
                                                        Documents::closure85(
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
                                                            Documents::closure92(
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
                                                                Documents::closure92(
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
                                                                    Documents::closure92(
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
                                                                        Documents::closure92(
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
                                                                            Documents::closure92(
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
                                                                                Documents::closure92(
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
            let v7899: Array<LrcPtr<Documents::UH5>> = toArray(Documents::method90(
                if (if let Documents::UH4::UH4_0 = v1533.as_ref() {
                    true
                } else {
                    false
                }) != true
                {
                    v1533
                } else {
                    let patternInput_3: (string, string) =
                        Documents::method74(string("epub"), v76.clone(), v4.clone());
                    let v1538: string = patternInput_3.1.clone();
                    let v1537: string = patternInput_3.0.clone();
                    let v2445: LrcPtr<Documents::UH5> = if if Documents::method79(v1537.clone())
                        == false
                    {
                        if Documents::method79(v1538.clone()) {
                            let v1544: () = {
                                Documents::closure96(v1538.clone(), v1537.clone(), ());
                                ()
                            };
                            Documents::method80(v1537, v1538);
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
                                            Documents::closure92(v4.clone(), v3.clone(), true, v_7)
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
                        Documents::method74(string("pdf"), v76.clone(), v4.clone());
                    let v2448: string = patternInput_4.1.clone();
                    let v2447: string = patternInput_4.0.clone();
                    let v3353: LrcPtr<Documents::UH5> = if if Documents::method79(v2447.clone())
                        == false
                    {
                        if Documents::method79(v2448.clone()) {
                            let v2454: () = {
                                Documents::closure96(v2448.clone(), v2447.clone(), ());
                                ()
                            };
                            Documents::method80(v2447, v2448);
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
                                            Documents::closure92(v4.clone(), v3.clone(), true, v_8)
                                        }
                                    }))(b0)(b1)
                                }
                            }),
                            v2445.clone(),
                        ))
                    } else {
                        v2445
                    };
                    let patternInput_5: (string, string) =
                        Documents::method74(string("html"), v76.clone(), v4.clone());
                    let v3356: string = patternInput_5.1.clone();
                    let v3355: string = patternInput_5.0.clone();
                    let v4261: LrcPtr<Documents::UH5> = if if Documents::method79(v3355.clone())
                        == false
                    {
                        if Documents::method79(v3356.clone()) {
                            let v3362: () = {
                                Documents::closure96(v3356.clone(), v3355.clone(), ());
                                ()
                            };
                            Documents::method80(v3355, v3356);
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
                                            Documents::closure92(v4.clone(), v3.clone(), true, v_9)
                                        }
                                    }))(b0)(b1)
                                }
                            }),
                            v3353.clone(),
                        ))
                    } else {
                        v3353
                    };
                    let patternInput_6: (string, string) =
                        Documents::method74(string("epub"), v60.clone(), v4.clone());
                    let v4263: string = patternInput_6.1.clone();
                    let v4262: string = patternInput_6.0.clone();
                    let v5168: LrcPtr<Documents::UH5> =
                        if if Documents::method79(v4262.clone()) == false {
                            if Documents::method79(v4263.clone()) {
                                let v4269: () = {
                                    Documents::closure96(v4263.clone(), v4262.clone(), ());
                                    ()
                                };
                                Documents::method80(v4262, v4263);
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
                                                Documents::closure92(
                                                    v4.clone(),
                                                    v3.clone(),
                                                    false,
                                                    v_10,
                                                )
                                            }
                                        }))(b0)(b1)
                                    }
                                }),
                                v4261.clone(),
                            ))
                        } else {
                            v4261
                        };
                    let patternInput_7: (string, string) =
                        Documents::method74(string("pdf"), v60.clone(), v4.clone());
                    let v5170: string = patternInput_7.1.clone();
                    let v5169: string = patternInput_7.0.clone();
                    let v6075: LrcPtr<Documents::UH5> =
                        if if Documents::method79(v5169.clone()) == false {
                            if Documents::method79(v5170.clone()) {
                                let v5176: () = {
                                    Documents::closure96(v5170.clone(), v5169.clone(), ());
                                    ()
                                };
                                Documents::method80(v5169, v5170);
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
                                                Documents::closure92(
                                                    v4.clone(),
                                                    v3.clone(),
                                                    false,
                                                    v_11,
                                                )
                                            }
                                        }))(b0)(b1)
                                    }
                                }),
                                v5168.clone(),
                            ))
                        } else {
                            v5168
                        };
                    let patternInput_8: (string, string) =
                        Documents::method74(string("html"), v60.clone(), v4.clone());
                    let v6077: string = patternInput_8.1.clone();
                    let v6076: string = patternInput_8.0.clone();
                    let v6982: LrcPtr<Documents::UH5> =
                        if if Documents::method79(v6076.clone()) == false {
                            if Documents::method79(v6077.clone()) {
                                let v6083: () = {
                                    Documents::closure96(v6077.clone(), v6076.clone(), ());
                                    ()
                                };
                                Documents::method80(v6076, v6077);
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
                                                Documents::closure92(
                                                    v4.clone(),
                                                    v3.clone(),
                                                    false,
                                                    v_12,
                                                )
                                            }
                                        }))(b0)(b1)
                                    }
                                }),
                                v6075.clone(),
                            ))
                        } else {
                            v6075
                        };
                    let patternInput_9: (string, string) =
                        Documents::method74(string("hangul.md"), v60.clone(), v4.clone());
                    let v6984: string = patternInput_9.1.clone();
                    let v6983: string = patternInput_9.0.clone();
                    LrcPtr::new(Documents::UH4::UH4_1(
                        if if Documents::method79(v6983.clone()) == false {
                            if Documents::method79(v6984.clone()) {
                                let v6990: () = {
                                    Documents::closure96(v6984.clone(), v6983.clone(), ());
                                    ()
                                };
                                Documents::method80(v6983, v6984);
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
                                                Documents::closure85(
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
                            v6982,
                            LrcPtr::new(Documents::UH4::UH4_0),
                        )),
                    ))
                },
                empty::<LrcPtr<Documents::UH5>>(),
            ));
            let v7903: Vec<LrcPtr<Documents::UH5>> = v7899.to_vec();
            let v7906: Vec<Option<Result<string, LrcPtr<(string, string)>>>> =
                new_empty::<Option<Result<string, LrcPtr<(string, string)>>>>().to_vec();
            let v7908: Array<LrcPtr<Documents::UH5>> =
                fable_library_rust::NativeArray_::array_from(v7903);
            let v7909: i32 = count_2(v7908.clone());
            let v7910: LrcPtr<Documents::Mut9> = LrcPtr::new(Documents::Mut9 {
                l0: MutCell::new(0_i32),
                l1: MutCell::new(v7906),
            });
            while Documents::method91(v7909, v7910.clone()) {
                let v7912: i32 = v7910.l0.get().clone();
                let v7913: Vec<Option<Result<string, LrcPtr<(string, string)>>>> =
                    v7910.l1.get().clone();
                let v7918 = toArray(Documents::method92(
                    v7908[v7912].clone(),
                    empty::<(
                        string,
                        string,
                        Func1<string, Func1<string, Documents::US30>>,
                    )>(),
                ));
                let v7922 = v7918.to_vec();
                let v7924 = rayon::iter::IntoParallelIterator::into_par_iter(v7922);
                let v7927 = rayon::iter::ParallelIterator::map(v7924, |x| {
                    Func1::new(
                        move |arg10_0040_8: (
                            string,
                            string,
                            Func1<string, Func1<string, Documents::US30>>,
                        )| Documents::closure98((), arg10_0040_8),
                    )(x)
                });
                let v7930: Vec<Option<Result<string, LrcPtr<(string, string)>>>> =
                    Documents::method93(rayon::iter::ParallelIterator::collect(v7927));
                let v7931: Vec<Option<Result<string, LrcPtr<(string, string)>>>> =
                    Documents::method94(v7913);
                let v7933: bool = true;
                let mut v7931 = v7931;
                let v7935: bool = true;
                v7931.extend(v7930);
                let v7937: Vec<Option<Result<string, LrcPtr<(string, string)>>>> = v7931;
                let v7938: i32 = v7912 + 1_i32;
                v7910.l0.set(v7938);
                v7910.l1.set(v7937);
                ()
            }
            Ok::<
                LrcPtr<(
                    string,
                    Vec<Option<Result<string, LrcPtr<(string, string)>>>>,
                )>,
                std::string::String,
            >(LrcPtr::new((v44, v7910.l1.get().clone())))
        }
        pub fn closure100(unitVar: (), unitVar_1: ()) -> string {
            string("documents.run")
        }
        pub fn closure99(
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
                Option<i64>,
            ) = getValue(Documents::State::trace_state().get().clone());
            let v32: () = {
                v2();
                ()
            };
            let patternInput_1: (
                LrcPtr<Documents::Mut0>,
                LrcPtr<Documents::Mut1>,
                LrcPtr<Documents::Mut2>,
                LrcPtr<Documents::Mut3>,
                Option<i64>,
            ) = getValue(Documents::State::trace_state().get().clone());
            let v60: Documents::US0 = (patternInput_1.3.clone()).l0.get().clone();
            if if (patternInput_1.2.clone()).l0.get().clone() == false {
                false
            } else {
                2_i32
                    >= find(
                        v60,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Documents::US0::US0_0, 0_i32)),
                            LrcPtr::new((Documents::US0::US0_1, 1_i32)),
                            LrcPtr::new((Documents::US0::US0_2, 2_i32)),
                            LrcPtr::new((Documents::US0::US0_3, 3_i32)),
                            LrcPtr::new((Documents::US0::US0_4, 4_i32)),
                        ])))),
                    )
            } {
                let v68: () = {
                    Documents::closure8(patternInput.0.clone(), ());
                    ()
                };
                let v72: () = {
                    v2();
                    ()
                };
                let patternInput_2: (
                    LrcPtr<Documents::Mut0>,
                    LrcPtr<Documents::Mut1>,
                    LrcPtr<Documents::Mut2>,
                    LrcPtr<Documents::Mut3>,
                    Option<i64>,
                ) = getValue(Documents::State::trace_state().get().clone());
                let _v101: LrcPtr<MutCell<Option<Documents::US3>>> =
                    refCell(None::<Documents::US3>);
                let v106: () = {
                    Documents::closure10(
                        patternInput_2.4.clone(),
                        Func1::new({
                            let _v101 = _v101.clone();
                            move |v: Option<Documents::US3>| Documents::closure9(_v101.clone(), v)
                        }),
                        (),
                    );
                    ()
                };
                let v121: Documents::US3 = defaultValue(Documents::US3::US3_1, _v101.get().clone());
                let v161: DateTime = match &v121 {
                    Documents::US3::US3_0(v121_0_0) => {
                        let v135: TimeSpan = TimeSpan::new_ticks(
                            {
                                let _arg: DateTime = DateTime::now();
                                _arg.ticks()
                            } - match &v121 {
                                Documents::US3::US3_0(x) => x.clone(),
                                _ => unreachable!(),
                            },
                        );
                        DateTime::new_ymdhms_milli(
                            1_i32,
                            1_i32,
                            1_i32,
                            v135.hours(),
                            v135.minutes(),
                            v135.seconds(),
                            v135.milliseconds(),
                        )
                    }
                    _ => DateTime::now(),
                };
                let v166: string = {
                    let provider: string = Documents::method6();
                    v161.toString(provider)
                };
                let v554: string = Documents::method8();
                let v566: LrcPtr<Documents::Mut4> = LrcPtr::new(Documents::Mut4 {
                    l0: MutCell::new(Documents::method10()),
                });
                let v577: () = {
                    Documents::closure11(
                        v566.clone(),
                        sprintf!("{}", sprintf!("{:?}", Documents::US0::US0_0)),
                        (),
                    );
                    ()
                };
                let v581: Array<string> = split(v566.l0.get().clone(), v554, -1_i32, 0_i32);
                let v584: string = v581[0_i32].clone();
                let v588: LrcPtr<Documents::Mut4> = LrcPtr::new(Documents::Mut4 {
                    l0: MutCell::new(Documents::method10()),
                });
                let v599: () = {
                    Documents::closure11(
                        v588.clone(),
                        sprintf!("{}", sprintf!("{:?}", Documents::US0::US0_2)),
                        (),
                    );
                    ()
                };
                let v609: Documents::US1 = if startsWith(v588.l0.get().clone(), v584, false) {
                    Documents::US1::US1_0(string("Verbose"))
                } else {
                    Documents::US1::US1_1
                };
                let v676: Documents::US1 = match &v609 {
                    Documents::US1::US1_0(v609_0_0) => Documents::US1::US1_0(match &v609 {
                        Documents::US1::US1_0(x) => x.clone(),
                        _ => unreachable!(),
                    }),
                    _ => {
                        let v613: string = Documents::method8();
                        let v625: LrcPtr<Documents::Mut4> = LrcPtr::new(Documents::Mut4 {
                            l0: MutCell::new(Documents::method10()),
                        });
                        let v636: () = {
                            Documents::closure11(
                                v625.clone(),
                                sprintf!("{}", sprintf!("{:?}", Documents::US0::US0_1)),
                                (),
                            );
                            ()
                        };
                        let v640: Array<string> = split(v625.l0.get().clone(), v613, -1_i32, 0_i32);
                        let v643: string = v640[0_i32].clone();
                        let v647: LrcPtr<Documents::Mut4> = LrcPtr::new(Documents::Mut4 {
                            l0: MutCell::new(Documents::method10()),
                        });
                        let v658: () = {
                            Documents::closure11(
                                v647.clone(),
                                sprintf!("{}", sprintf!("{:?}", Documents::US0::US0_2)),
                                (),
                            );
                            ()
                        };
                        let v668: Documents::US1 = if startsWith(v647.l0.get().clone(), v643, false)
                        {
                            Documents::US1::US1_0(string("Debug"))
                        } else {
                            Documents::US1::US1_1
                        };
                        match &v668 {
                            Documents::US1::US1_0(v668_0_0) => Documents::US1::US1_0(match &v668 {
                                Documents::US1::US1_0(x) => x.clone(),
                                _ => unreachable!(),
                            }),
                            _ => Documents::US1::US1_0(string("Info")),
                        }
                    }
                };
                let v685: string = padLeft(
                    toLower(match &v676 {
                        Documents::US1::US1_0(v676_0_0) => match &v676 {
                            Documents::US1::US1_0(x) => x.clone(),
                            _ => unreachable!(),
                        },
                        _ => panic!("{}", string("Option does not have a value."),),
                    }),
                    7_i32,
                    ' ',
                );
                let v701: &str = inline_colorization::color_bright_green;
                let v703: &str = &*v685;
                let v705: &str = inline_colorization::color_reset;
                let v707: string = string("format!(\"{v701}{v703}{v705}\")");
                let v708: std::string::String = format!("{v701}{v703}{v705}");
                let v710: string = fable_library_rust::String_::fromString(v708);
                let v751: i64 = (patternInput_2.0.clone()).l0.get().clone();
                let v753: usize = v0_1.len();
                let v755: LrcPtr<Documents::Mut4> = LrcPtr::new(Documents::Mut4 {
                    l0: MutCell::new(Documents::method10()),
                });
                let v762: () = {
                    Documents::closure11(v755.clone(), sprintf!("{}", string("{ ")), ());
                    ()
                };
                let v771: () = {
                    Documents::closure11(v755.clone(), sprintf!("{}", string("result_len")), ());
                    ()
                };
                let v780: () = {
                    Documents::closure11(v755.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v785: std::string::String = format!("{:#?}", v753);
                let v815: () = {
                    Documents::closure11(
                        v755.clone(),
                        sprintf!("{}", fable_library_rust::String_::fromString(v785)),
                        (),
                    );
                    ()
                };
                let v824: () = {
                    Documents::closure11(v755.clone(), sprintf!("{}", string(" }")), ());
                    ()
                };
                let v827: string = v755.l0.get().clone();
                let v866: string = trimEndChars(
                    trimStartChars(
                        sprintf!(
                            "{} {} #{} {} / {}",
                            v166,
                            v710,
                            v751,
                            Documents::closure100((), ()),
                            v827
                        ),
                        toArray(empty::<char>()),
                    ),
                    toArray(ofArray(new_array(&[' ', '/']))),
                );
                println!("{}", v866.clone());
                ();
                ((patternInput.1.clone()).l0.get().clone())(v866)
            }
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
        pub fn method16(
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
            let v8: Documents::US7 = Documents::method20(
                Documents::method17(string("polyglot"), string(".devcontainer")),
                string("C:\\home\\git\\polyglot\\target\\Builder\\documents"),
            );
            let v938: Documents::US1 = match &v8 {
                Documents::US7::US7_0(v8_0_0) => Documents::US1::US1_0(v8_0_0.clone()),
                Documents::US7::US7_1(v8_1_0) => {
                    let v14: () = {
                        Documents::closure18(v8_1_0.clone(), ());
                        ()
                    };
                    Documents::US1::US1_1
                }
            };
            let v1875: Documents::US1 = match &v938 {
                Documents::US1::US1_0(v938_0_0) => Documents::US1::US1_0(match &v938 {
                    Documents::US1::US1_0(x) => x.clone(),
                    _ => unreachable!(),
                }),
                _ => {
                    let v941: string = Documents::method25();
                    let v943: Documents::US7 = Documents::method20(
                        Documents::method17(string("polyglot"), string(".devcontainer")),
                        v941,
                    );
                    match &v943 {
                        Documents::US7::US7_0(v943_0_0) => Documents::US1::US1_0(v943_0_0.clone()),
                        Documents::US7::US7_1(v943_1_0) => {
                            let v949: () = {
                                Documents::closure18(v943_1_0.clone(), ());
                                ()
                            };
                            Documents::US1::US1_1
                        }
                    }
                }
            };
            let v1880: string = Documents::method17(
                match &v1875 {
                    Documents::US1::US1_0(v1875_0_0) => match &v1875 {
                        Documents::US1::US1_0(x) => x.clone(),
                        _ => unreachable!(),
                    },
                    _ => panic!("{}", string("Option does not have a value."),),
                },
                string("polyglot"),
            );
            let v1881: string = Documents::method26(v3);
            let v1882: string = Documents::method26(v2);
            let v1883: string = Documents::method26(v1_1);
            let v1886: () = {
                Documents::closure20(
                    v0_1.clone(),
                    v1881.clone(),
                    v1882.clone(),
                    v1883.clone(),
                    (),
                );
                ()
            };
            let v2787: bool = true;
            let __future_init = Box::pin(async move {
                //;
                let v2789: async_walkdir::WalkDir = async_walkdir::WalkDir::new(&*v1882.clone());
                let v2792: async_walkdir::WalkDir = async_walkdir::WalkDir::filter(v2789, |x| {
                    Func1::new(move |v: async_walkdir::DirEntry| Documents::closure22((), v))(x)
                });
                let v2793 = Documents::method37();
                let v2795 = tokio_stream::StreamExt::filter_map(v2792, |x| v2793(x));
                let v2797: std::pin::Pin<Box<dyn std::future::Future<Output = Vec<string>>>> =
                    Box::pin(tokio_stream::StreamExt::collect(v2795));
                let v2799: Vec<string> = v2797.await;
                let v2802: () = {
                    Documents::closure32(v2799.clone(), ());
                    ()
                };
                let v3632: rayon::vec::IntoIter<string> =
                    rayon::iter::IntoParallelIterator::into_par_iter(v2799);
                let v3635: rayon::iter::Map<rayon::vec::IntoIter<string>, _> =
                    rayon::iter::ParallelIterator::map(v3632, |x| {
                        Func1::new({
                            let v0_1 = v0_1.clone();
                            let v1880 = v1880.clone();
                            let v1881 = v1881.clone();
                            let v1882 = v1882.clone();
                            let v1883 = v1883.clone();
                            move |v_1: string| {
                                Documents::closure34(
                                    v0_1.clone(),
                                    v1880.clone(),
                                    v1881.clone(),
                                    v1882.clone(),
                                    v1883.clone(),
                                    v_1,
                                )
                            }
                        })(x)
                    });
                let v3637: Vec<
                    Result<
                        LrcPtr<(
                            string,
                            Vec<Option<Result<string, LrcPtr<(string, string)>>>>,
                        )>,
                        std::string::String,
                    >,
                > = rayon::iter::ParallelIterator::collect(v3635);
                let v3640: () = {
                    Documents::closure99(v3637.clone(), ());
                    ()
                };
                let v4531: Result<
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
                >(v3637));
                let v4535: string = string("true; v4531 });  // rust.fix_closure\'");
                let v4536: bool = true;
                v4531
            }); // rust.fix_closure';
            let v4538 = __future_init;
            v4538
        }
        pub fn closure1(unitVar: (), v0_1: Array<string>) -> i32 {
            let v3: () = {
                Documents::closure2((), ());
                ()
            };
            let v18: () = {
                Documents::closure6(v0_1, ());
                ()
            };
            let v882: clap::Command = Documents::method0();
            let v884: clap::ArgMatches = clap::Command::get_matches(v882);
            let v885: string = Documents::method12();
            let v887: &str = &*v885;
            let v889: Option<std::string::String> =
                clap::ArgMatches::get_one(&v884.clone(), v887).cloned();
            let _v890: LrcPtr<MutCell<Option<Documents::US4>>> = refCell(None::<Documents::US4>);
            let v895: () = {
                Documents::closure16(
                    v889,
                    Func1::new({
                        let _v890 = _v890.clone();
                        move |v: Option<Documents::US4>| Documents::closure15(_v890.clone(), v)
                    }),
                    (),
                );
                ()
            };
            let v910: Documents::US4 = defaultValue(Documents::US4::US4_1, _v890.get().clone());
            let v917: std::string::String = match &v910 {
                Documents::US4::US4_0(v910_0_0) => match &v910 {
                    Documents::US4::US4_0(x) => x.clone(),
                    _ => unreachable!(),
                },
                _ => panic!("{}", string("Option does not have a value."),),
            };
            let v919: string = fable_library_rust::String_::fromString(v917);
            let v920: string = Documents::method13();
            let v922: &str = &*v920;
            let v924: Option<std::string::String> =
                clap::ArgMatches::get_one(&v884.clone(), v922).cloned();
            let _v925: LrcPtr<MutCell<Option<Documents::US4>>> = refCell(None::<Documents::US4>);
            let v930: () = {
                Documents::closure16(
                    v924,
                    Func1::new({
                        let _v925 = _v925.clone();
                        move |v_1: Option<Documents::US4>| Documents::closure15(_v925.clone(), v_1)
                    }),
                    (),
                );
                ()
            };
            let v945: Documents::US4 = defaultValue(Documents::US4::US4_1, _v925.get().clone());
            let v952: std::string::String = match &v945 {
                Documents::US4::US4_0(v945_0_0) => match &v945 {
                    Documents::US4::US4_0(x) => x.clone(),
                    _ => unreachable!(),
                },
                _ => panic!("{}", string("Option does not have a value."),),
            };
            let v954: string = fable_library_rust::String_::fromString(v952);
            let v955: string = Documents::method14();
            let v957: &str = &*v955;
            let v959: Option<std::string::String> =
                clap::ArgMatches::get_one(&v884.clone(), v957).cloned();
            let _v960: LrcPtr<MutCell<Option<Documents::US4>>> = refCell(None::<Documents::US4>);
            let v965: () = {
                Documents::closure16(
                    v959,
                    Func1::new({
                        let _v960 = _v960.clone();
                        move |v_2: Option<Documents::US4>| Documents::closure15(_v960.clone(), v_2)
                    }),
                    (),
                );
                ()
            };
            let v980: Documents::US4 = defaultValue(Documents::US4::US4_1, _v960.get().clone());
            let v987: std::string::String = match &v980 {
                Documents::US4::US4_0(v980_0_0) => match &v980 {
                    Documents::US4::US4_0(x) => x.clone(),
                    _ => unreachable!(),
                },
                _ => panic!("{}", string("Option does not have a value."),),
            };
            let v989: string = fable_library_rust::String_::fromString(v987);
            let v990: string = Documents::method15();
            let v992: &str = &*v990;
            let v994: Option<std::string::String> = clap::ArgMatches::get_one(&v884, v992).cloned();
            let _v995: LrcPtr<MutCell<Option<Documents::US4>>> = refCell(None::<Documents::US4>);
            let v1000: () = {
                Documents::closure16(
                    v994,
                    Func1::new({
                        let _v995 = _v995.clone();
                        move |v_3: Option<Documents::US4>| Documents::closure15(_v995.clone(), v_3)
                    }),
                    (),
                );
                ()
            };
            let v1015: Documents::US4 = defaultValue(Documents::US4::US4_1, _v995.get().clone());
            let v1022: std::string::String = match &v1015 {
                Documents::US4::US4_0(v1015_0_0) => match &v1015 {
                    Documents::US4::US4_0(x) => x.clone(),
                    _ => unreachable!(),
                },
                _ => panic!("{}", string("Option does not have a value."),),
            };
            let v1025: std::pin::Pin<
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
            > = Documents::method16(
                fable_library_rust::String_::fromString(v1022),
                v989,
                v954,
                v919,
            );
            let v1027 = tokio::runtime::Builder::new_multi_thread()
                .enable_all()
                .build()
                .unwrap();
            let v1029: Result<
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
            > = v1027.handle().block_on(v1025);
            let v1031: Vec<
                Result<
                    LrcPtr<(
                        string,
                        Vec<Option<Result<string, LrcPtr<(string, string)>>>>,
                    )>,
                    std::string::String,
                >,
            > = v1029.unwrap();
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
